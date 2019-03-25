Imports System.IO.Ports
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen
Imports Luxand
Imports Medicine_Dispenser___Windows_Client.Objects

Public Class frm_DispenserDashBoard

#Region "Variables"
    Dim Patients As List(Of Objects.Patient)

    Dim ClosingForm As Boolean = False
    Dim CameraHandle As Integer

    Dim Mouse_X As Integer = 0
    Dim Mouse_Y As Integer = 0
    Dim ProgramState As Enums.ProgramStates

    Dim TrackerMemoryFile As String = IO.Path.Combine(Application.StartupPath, "training.luxand.dat")

    Dim OverlayHandle As IOverlaySplashScreenHandle

    Dim AnnouncedIDs As New List(Of Integer)
    Dim CurrentPatientID As Integer = 0

    Dim Dispensed As Boolean = False
#End Region

#Region "Properties"
    Private ReadOnly Property RemainingList As List(Of Objects.MedicationScheduler)
        Get
            If gc_RemainingMedications.DataSource Is Nothing Then gc_RemainingMedications.DataSource = New List(Of Objects.MedicationScheduler)
            Return CType(gc_RemainingMedications.DataSource, List(Of Objects.MedicationScheduler))
        End Get
    End Property

    Private ReadOnly Property WaitingList As List(Of Objects.MedicationScheduler)
        Get
            If gc_WaitingMedications.DataSource Is Nothing Then gc_WaitingMedications.DataSource = New List(Of Objects.MedicationScheduler)
            Return CType(gc_WaitingMedications.DataSource, List(Of Objects.MedicationScheduler))
        End Get
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Patients As List(Of Objects.Patient))
        InitializeComponent()

        Me.Patients = Patients
    End Sub
#End Region

#Region "Subs"
    Private Sub PrepareList()
        If InvokeRequired Then
            Invoke(Sub() PrepareList())
        Else
            If Patients IsNot Nothing Then
                RemainingList.Clear()
                WaitingList.Clear()

                For Each Patient As Objects.Patient In Patients
                    Dim TempMedications As New List(Of Objects.Medication)(Patient.Medication.ToArray)

                    While TempMedications.Count > 0
                        Dim Medication As Objects.Medication = TempMedications(0)
                        Dim CurrentMedications As New List(Of Objects.Medication)
                        CurrentMedications.AddRange(TempMedications.FindAll(Function(c) c.Hour = Medication.Hour And c.Minute = Medication.Minute))
                        For Each i As Objects.Medication In CurrentMedications
                            TempMedications.Remove(i)
                        Next

                        Dim AlertTime As New DateTime(Now.Year, Now.Month, Now.Day, Medication.Hour, Medication.Minute, Now.Second)
                        If Date.Compare(Now, AlertTime) = 1 Then AlertTime = AlertTime.AddDays(1)

                        Dim Scheduler As New MedicationScheduler(Patient, CurrentMedications, AlertTime)
                        AddHandler Scheduler.Alert, AddressOf MedicationScheduler_Alert
                        AddHandler Scheduler.Expired, AddressOf MedicationScheduler_Expired
                        RemainingList.Add(Scheduler)
                    End While
                Next
            End If

            Try
                Dim DateColumns As New List(Of DevExpress.XtraGrid.Columns.GridColumn)
                DateColumns.Add(gv_RemainingMedications.Columns("AlertTime"))
                DateColumns.Add(gv_RemainingMedications.Columns("ExpiryTime"))
                DateColumns.Add(gv_WaitingMedications.Columns("AlertTime"))
                DateColumns.Add(gv_WaitingMedications.Columns("ExpiryTime"))

                For Each Column As DevExpress.XtraGrid.Columns.GridColumn In DateColumns
                    Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    Column.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"
                Next
            Catch ex As Exception

            End Try

            gc_RemainingMedications.RefreshDataSource()
            gc_WaitingMedications.RefreshDataSource()
        End If
    End Sub
#End Region

#Region "Progress Panel Overlay"
    Private Function ShowProgressPanel() As IOverlaySplashScreenHandle
        Return SplashScreenManager.ShowOverlayForm(Me)
    End Function

    Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
        If handle IsNot Nothing Then SplashScreenManager.CloseOverlayForm(handle)
    End Sub
#End Region

#Region "Functions"
    Private Function HasWaitingMedication(ByVal Patient As Patient) As Boolean
        Return (WaitingList.Find(Function(c) c.Patient.ID = Patient.ID) IsNot Nothing)
    End Function

    Function Dispense(ByVal Medications As List(Of Objects.Medication)) As Boolean
        Try
            Dim Timer As New Stopwatch

            Dim A As Integer = 0
            Dim B As Integer = 0
            Dim C As Integer = 0

            For Each Medication As Objects.Medication In Medications
                Select Case Medication.Medicine
                    Case Enums.Medicine.A
                        A += Medication.Dosage
                    Case Enums.Medicine.B
                        B += Medication.Dosage
                    Case Enums.Medicine.C
                        C += Medication.Dosage
                End Select
            Next

            ArduinoPort.WriteLine(String.Format("{0}:{1}:{2}", A, B, C))
            Threading.Thread.Sleep(1000)
            Timer.Start()
            Dispensed = False
            Do Until Dispensed Or Timer.Elapsed.TotalSeconds >= 30
                Application.DoEvents()
            Loop
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Button Events"
    Private Sub btn_StartRecognition_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_StartRecognition.ItemClick
        btn_StartRecognition.Enabled = False
        btn_TrainingMode.Enabled = False
        ClosingForm = False

        ArduinoPort.PortName = cmb_Ports.EditValue
        ArduinoPort.Open()

        Dim TrackerHandle As Integer = 0  ' Creating a Tracker
        If (FSDK.FSDKE_OK <> FSDK.LoadTrackerMemoryFromFile(TrackerHandle, TrackerMemoryFile)) Then ' try to load saved tracker state
            FSDK.CreateTracker(TrackerHandle) ' If could not be loaded, create a new tracker
        End If

        Dim err As Integer = 0 ' set realtime face detection parameters
        FSDK.SetTrackerMultipleParameters(TrackerHandle, String.Format("HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5; Learning={0}; MemoryLimit=7500; Threshold=0.997707;", If(btn_TrainingMode.Checked, "true", "false")), err)

        Dim CameraImage As FSDK.CImage
        Dim FrameImage As Image
        While Not ClosingForm
            Dim ImageHandle As Integer
            If (FSDKCam.GrabFrame(CameraHandle, ImageHandle) <> FSDK.FSDKE_OK) Then ' Grab the current frame from the camera
                Application.DoEvents()
                Continue While
            End If

            CameraImage = New FSDK.CImage(ImageHandle)

            Dim IDs() As Long
            ReDim IDs(0 To 256)
            Dim FaceCount As Long
            FSDK.FeedFrame(TrackerHandle, 0, CameraImage.ImageHandle, FaceCount, IDs, 8 * 256) ' Size of Long * Maximum 256 faces detected
            Array.Resize(IDs, FaceCount)

            FrameImage = CameraImage.ToCLRImage()

            Using g As Graphics = Graphics.FromImage(FrameImage)

                Dim i As Integer
                For i = 0 To IDs.Length - 1
                    Dim FacePosition As FSDK.TFacePosition
                    FacePosition = New FSDK.TFacePosition
                    FSDK.GetTrackerFacePosition(TrackerHandle, 0, IDs(i), FacePosition)

                    Dim FaceLeft As Integer
                    Dim FaceTop As Integer
                    Dim FaceWidth As Integer
                    FaceLeft = FacePosition.xc - CInt(FacePosition.w * 0.6)
                    FaceTop = FacePosition.yc - CInt(FacePosition.w * 0.5)
                    FaceWidth = FacePosition.w * 1.2

                    Dim DetectedID As String = ""
                    Dim Result As Integer
                    Result = FSDK.GetAllNames(TrackerHandle, IDs(i), DetectedID, 65536) ' Maximum of 65536 characters
                    Dim PatientID As Integer = -1
                    Dim Patient As Patient = Nothing
                    Integer.TryParse(DetectedID, PatientID)
                    If (Result = FSDK.FSDKE_OK And PatientID > 0) Then ' Draw DetectedName
                        Patient = Patients.Find(Function(c) c.ID = PatientID)
                        If Patient IsNot Nothing Then
                            Me.CurrentPatientID = PatientID
                            Dim Format As New StringFormat()
                            Format.Alignment = StringAlignment.Center
                            g.DrawString(Patient.Name, New Font("Arial", 16), New SolidBrush(System.Drawing.Color.LightGreen), FacePosition.xc, FaceTop + FaceWidth + 5, Format)
                        End If
                    Else
                        Me.CurrentPatientID = -1
                    End If

                    If Patient IsNot Nothing AndAlso Not AnnouncedIDs.Contains(Patient.ID) AndAlso HasWaitingMedication(Patient) Then
                        AnnouncedIDs.Add(Patient.ID)
                        Dim Message As String = String.Format("Hi {0}, Place your hand in dispenser to receive your medicine.", Patient.PhoneticName)
                        Speak(Message, True)
                    End If

                    Dim pen As Pen = Pens.LightGreen
                    If btn_TrainingMode.Checked AndAlso Me.ProgramState = Enums.ProgramStates.Remember AndAlso (Mouse_X >= FaceLeft And Mouse_X <= FaceLeft + FaceWidth And Mouse_Y >= FaceTop And Mouse_Y <= FaceTop + FaceWidth) Then
                        pen = Pens.Blue
                        Dim D As New frm_SelectPatient(Patients)
                        If D.ShowDialog = DialogResult.OK Then
                            If (FSDK.FSDKE_OK = FSDK.LockID(TrackerHandle, IDs(i))) Then
                                If D.SelectedPatient Is Nothing Then
                                    FSDK.SetName(TrackerHandle, IDs(i), "")
                                    FSDK.PurgeID(TrackerHandle, IDs(i))
                                Else
                                    FSDK.SetName(TrackerHandle, IDs(i), D.SelectedPatient.ID)
                                End If
                                FSDK.UnlockID(TrackerHandle, IDs(i))
                            End If
                        End If
                    End If
                    g.DrawRectangle(pen, FaceLeft, FaceTop, FaceWidth, FaceWidth)
                Next
            End Using
            ProgramState = Enums.ProgramStates.Recognize

            CamImageBox.Image = FrameImage ' Display current frame
            GC.Collect() ' Collect the garbage after the deletion
            Application.DoEvents() ' Make UI controls accessible
        End While

        FSDK.SaveTrackerMemoryToFile(TrackerHandle, TrackerMemoryFile)
        FSDK.FreeTracker(TrackerHandle)
        Close()
    End Sub
#End Region

#Region "Scheduler Events"
    Private Sub MedicationScheduler_Alert(MedicationScheduler As MedicationScheduler)
        If RemainingList.Contains(MedicationScheduler) Then
            RemainingList.Remove(MedicationScheduler)
            WaitingList.Add(MedicationScheduler)

            Dim Message As String = String.Format("Alert, Its Time for {0} to take tablets", MedicationScheduler.Patient.PhoneticName)
            Speak(Message, True)
            If AnnouncedIDs.Contains(MedicationScheduler.Patient.ID) Then AnnouncedIDs.Remove(MedicationScheduler.Patient.Name)

            gc_RemainingMedications.RefreshDataSource()
            gc_WaitingMedications.RefreshDataSource()
        End If
    End Sub

    Private Sub MedicationScheduler_Expired(MedicationScheduler As MedicationScheduler)
        If WaitingList.Contains(MedicationScheduler) Then
            WaitingList.Remove(MedicationScheduler)
            gc_WaitingMedications.RefreshDataSource()
        End If
    End Sub
#End Region

#Region "Other Events"
    Private Sub CamImageBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CamImageBox.MouseLeave
        Mouse_X = 0
        Mouse_Y = 0
    End Sub

    Private Sub CamImageBox_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CamImageBox.MouseMove
        Mouse_X = e.X
        Mouse_Y = e.Y
    End Sub

    Private Sub CamImageBox_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CamImageBox.MouseUp
        ProgramState = Enums.ProgramStates.Remember
    End Sub

    Private Sub frm_DispenserDashBoard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        If ClosingForm Or btn_StartRecognition.Enabled Then
            FSDKCam.CloseVideoCamera(CameraHandle)
            FSDKCam.FinalizeCapturing()

            'DispenserDevice.stop
            If ArduinoPort.IsOpen Then ArduinoPort.Close()
        Else
            ClosingForm = True
            e.Cancel = True
        End If
    End Sub

    Private Async Sub frm_DispenserDashBoard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        OverlayHandle = ShowProgressPanel()
        Await Task.Run(Sub()
                           Try
                               If Not ActivateFaceSDK() Then
                                   ClosingForm = True
                                   Me.Invoke(Sub() Close())
                               End If

                               FSDK.InitializeLibrary()
                               FSDKCam.InitializeCapturing()

                               Dim cameralist() As String
                               Dim count As Integer
                               FSDKCam.GetCameraList(cameralist, count)

                               If (0 = count) Then
                                   Invoke(Sub()
                                              DevExpress.XtraEditors.XtraMessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                              Close()
                                          End Sub)
                               End If


                               Dim formatList() As FSDKCam.VideoFormatInfo
                               FSDKCam.GetVideoFormatList(cameralist(0), formatList, count)
                               Invoke(Sub()
                                          CamImageBox.MinimumSize = New Size(formatList(0).Width, formatList(0).Height)
                                          CamImageBox.MaximumSize = New Size(formatList(0).Width, formatList(0).Height)
                                          SplitContainerControl1.SplitterPosition = formatList(0).Width + 5
                                      End Sub)
                               Dim cameraName As String
                               cameraName = cameralist(0)
                               If FSDKCam.OpenVideoCamera(cameraName, CameraHandle) <> FSDK.FSDKE_OK Then
                                   Invoke(Sub()
                                              DevExpress.XtraEditors.XtraMessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                              Close()
                                          End Sub)
                               End If

                               Dim Ports As New List(Of String)
                               For Each SerialPort As String In My.Computer.Ports.SerialPortNames
                                   Ports.Add(SerialPort)
                               Next
                               Invoke(Sub() CType(cmb_Ports.Edit, DevExpress.XtraEditors.Repository.RepositoryItemComboBox).Items.AddRange(Ports.ToArray))

                               PrepareList()

                           Catch ex As Exception
                               Invoke(Sub()
                                          DevExpress.XtraEditors.XtraMessageBox.Show("Unable to initialize camera!" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                          Close()
                                      End Sub)
                           End Try
                       End Sub)
        CloseProgressPanel(OverlayHandle)
    End Sub

    Private Sub ArduinoPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles ArduinoPort.DataReceived
        Dim Data As String = ArduinoPort.ReadExisting.Trim
        If Data = "HP" Then
            lbl_Hand.ImageOptions.SvgImage = My.Resources.hand_green

            Dim MedicationScheduler As MedicationScheduler = WaitingList.Find(Function(c) c.Patient.ID = CurrentPatientID)
            If MedicationScheduler IsNot Nothing Then
                Dispense(MedicationScheduler.Medications)
                WaitingList.Remove(MedicationScheduler)
                gc_WaitingMedications.RefreshDataSource()
            End If
        ElseIf Data = "HR" Then
            lbl_Hand.ImageOptions.SvgImage = My.Resources.hand_blue
        ElseIf Data = "DS" Then
            Dispensed = True
        End If
    End Sub
#End Region

End Class