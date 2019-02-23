Imports Luxand

Public Class frm_Capture

#Region "Variables"
    Dim CameraHandle As Integer = 0
    Dim ClosingForm As Boolean = False
    Dim CaptureImage As Boolean = False
#End Region

#Region "Properties"
    ReadOnly Property CapturedImage As Image
        Get
            Return PictureBox1.Image
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frm_Capture_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not ActivateFaceSDK() Then
            ClosingForm = True
            Close()
        End If

        FSDK.InitializeLibrary()
        FSDKCam.InitializeCapturing()

        Dim CameraList(1) As String
        Dim Count As Integer
        FSDKCam.GetCameraList(CameraList, Count)
        If Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Unable to find any camera devices! Aborting..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClosingForm = True
            Close()
        End If

        If FSDKCam.OpenVideoCamera(CameraList(0), CameraHandle) <> FSDK.FSDKE_OK Then
            MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If

        ' Set realtime face detection parameters
        FSDK.SetFaceDetectionParameters(False, False, 100)
        FSDK.SetFaceDetectionThreshold(3)
        Dim MaxFaces As Integer = 20

        Dim Image As FSDK.CImage
        Dim FrameImage As Image

        Dim TrackerHandle As Integer
        FSDK.CreateTracker(TrackerHandle)

        Dim err As Long ' set realtime face detection parameters
        FSDK.SetTrackerMultipleParameters(TrackerHandle, "RecognizeFaces=false; HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", err)

        While Not ClosingForm
            Dim ImageHandle As Integer
            If (FSDKCam.GrabFrame(CameraHandle, ImageHandle) <> FSDK.FSDKE_OK) Then ' Grab the current frame from the camera
                Application.DoEvents()
                Continue While
            End If

            Image = New FSDK.CImage(ImageHandle)

            Dim IDs(0 To 256) As Long
            Dim FaceCount As Long
            FSDK.FeedFrame(TrackerHandle, 0, Image.ImageHandle, FaceCount, IDs, 8 * 256) ' Size of long * Maximum 256 faces detected
            Array.Resize(IDs, FaceCount)

            FrameImage = Image.ToCLRImage()
            Using gr As Graphics = Graphics.FromImage(FrameImage)
                For i As Integer = 0 To IDs.Length - 1
                    Dim FacePosition As FSDK.TFacePosition
                    FacePosition = New FSDK.TFacePosition
                    FSDK.GetTrackerFacePosition(TrackerHandle, 0, IDs(i), FacePosition)

                    Dim Left As Integer = FacePosition.xc - CInt(FacePosition.w * 0.6)
                    Dim Top As Integer = FacePosition.yc - CInt(FacePosition.w * 0.5)
                    If CaptureImage = True Then
                        Dim bmimg As New Bitmap(CInt(FacePosition.w * 1.2), CInt(FacePosition.w * 1.2) + 80)
                        Dim grimg As Graphics = Graphics.FromImage(bmimg)
                        grimg.DrawImage(FrameImage, New Rectangle(0, 0, CInt(FacePosition.w * 1.2), CInt(FacePosition.w * 1.2) + 80), New Rectangle(Left, Top - 50, CInt(FacePosition.w * 1.2), CInt(FacePosition.w * 1.2) + 60), GraphicsUnit.Pixel)
                        grimg.Dispose()
                        PictureBox1.Image = bmimg
                        CaptureImage = False
                        btn_Capture.Enabled = True
                        btn_OK.Enabled = True
                    End If
                    gr.DrawRectangle(Pens.LightGreen, Left, Top, CInt(FacePosition.w * 1.2), CInt(FacePosition.w * 1.2))
                Next
            End Using

            ' Display current frame
            image_PICBX.Image = FrameImage

            GC.Collect() ' Collect the garbage after the deletion

            ' Make UI controls accessible
            Application.DoEvents()
        End While

        FSDK.FreeTracker(TrackerHandle)
        FSDKCam.CloseVideoCamera(CameraHandle)
        FSDKCam.FinalizeCapturing()
        Close()
    End Sub

    Private Sub frm_Capture_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not ClosingForm Then
            e.Cancel = True
            ClosingForm = True
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Capture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capture.Click
        btn_Capture.Enabled = False
        CaptureImage = True
    End Sub

    Private Sub btn_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
#End Region

End Class