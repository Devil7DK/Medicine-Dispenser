Public Class frm_Login

#Region "Form Events"
    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Doctors As List(Of Objects.Doctor) = Database.Doctors.FetchAll
        txt_Username.Properties.Items.AddRange(Doctors.ToArray)
        If My.Settings.LastUser >= 0 Then
            txt_Username.SelectedItem = Doctors.Find(Function(c) c.ID = My.Settings.LastUser)
        End If
        If txt_Username.SelectedIndex = -1 AndAlso txt_Username.Properties.Items.Count > 0 Then txt_Username.SelectedIndex = 0
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_ServerSettings_Click(sender As Object, e As EventArgs) Handles btn_ServerSettings.Click
        ServerSettings.ShowDialog()
    End Sub
#End Region

End Class