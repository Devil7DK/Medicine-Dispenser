Public Class ServerSettings

#Region "Form Events"
    Private Sub ServerSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_ServerName.Text = My.Settings.ServerAddresss
        txt_DatabaseName.Text = My.Settings.DatabaseName
        txt_Username.Text = My.Settings.Username
        txt_Password.Text = Utils.Encryption.DecryptString(My.Settings.Password)
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        My.Settings.ServerAddresss = txt_ServerName.Text
        My.Settings.DatabaseName = txt_DatabaseName.Text
        My.Settings.Username = txt_Username.Text
        My.Settings.Password = Utils.Encryption.EncryptString(txt_Password.Text)
        My.Settings.Save()

        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

End Class