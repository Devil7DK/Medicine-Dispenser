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

#Region "Form Events"
    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoginInstance.BeginInvoke(Sub() LoginInstance.Close())
    End Sub
#End Region

End Class