Public Class frm_Main

#Region "Variables"
    Dim Doctor As Objects.Doctor
    Dim LoginInstance As frm_Login
#End Region

#Region "Constructor"
    Sub New(Doctor As Objects.Doctor, LoginInstance As frm_Login)
        InitializeComponent()
        Me.Doctor = Doctor
        Me.LoginInstance = LoginInstance
    End Sub
#End Region

#Region "Subs"
    Private Sub UpdateProgress(ByVal Description As String, Optional ByVal Caption As String = "")
        If InvokeRequired Then
            Invoke(Sub() UpdateProgress(Description, Caption))
        Else
            If Description <> "" Then
                ProgressPanel.Description = Description
            End If
            If Caption <> "" Then
                ProgressPanel.Caption = Caption
            End If
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoginInstance.BeginInvoke(Sub() LoginInstance.Close())
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not DataLoader.IsBusy Then DataLoader.RunWorkerAsync()
    End Sub
#End Region

#Region "Other Events"
    Private Sub DataLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DataLoader.DoWork
        Me.Invoke(Sub()
                      Me.RibbonControl.Enabled = False
                      Me.ProgressPanel.Visible = True
                  End Sub)

        UpdateProgress("Loading Doctors Data...", "Please Wait")
        Dim Doctors As List(Of Objects.Doctor) = Database.Doctors.FetchAll
        Me.Invoke(Sub() gc_Doctors.DataSource = Doctors)

        UpdateProgress("Loading Patients Data...")
        Dim Patients As List(Of Objects.Patient) = Database.Patients.FetchAll(Doctors)
        Me.Invoke(Sub() gc_Patients.DataSource = Patients)

        Me.Invoke(Sub()
                      Me.RibbonControl.Enabled = True
                      Me.ProgressPanel.Visible = False
                  End Sub)
    End Sub
#End Region

End Class