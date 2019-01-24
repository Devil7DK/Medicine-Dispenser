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

    Private Sub LoginWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoginWorker.DoWork
        Me.Invoke(Sub()
                      ProgressPanel.Visible = True
                  End Sub)
        Dim User As Objects.Doctor = Database.Doctors.Login(txt_Username.SelectedItem.ToString, txt_Password.Text)
        If User IsNot Nothing Then
            Dim T As New Threading.Tasks.Task(Sub()
                                                  Application.Run(New frm_Main(User, Me))
                                              End Sub)
            T.Start()
        Else
            Me.Invoke(Sub()
                          ProgressPanel.Visible = False
                      End Sub)
        End If
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If txt_Username.SelectedIndex >= 0 AndAlso txt_Password.Text.Trim <> "" Then
            If Not LoginWorker.IsBusy Then LoginWorker.RunWorkerAsync()
            My.Settings.LastUser = txt_Username.SelectedItem.ID
            My.Settings.Save()
        End If
    End Sub
#End Region

End Class