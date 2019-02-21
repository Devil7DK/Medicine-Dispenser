Public Class frm_Doctor

#Region "Variables"
    Dim Mode As Enums.Mode
    Dim Doctors As List(Of String)
#End Region

#Region "Properties"
    Property Doctor As Objects.Doctor
#End Region

#Region "Constructor"
    Sub New(ByVal Mode As Enums.Mode, ByVal Doctors As List(Of String))
        InitializeComponent()

        Me.Mode = Mode
        Me.Doctors = Doctors
        If Mode = Enums.Mode.Edit Then
            Text = "Edit Doctor"
        Else
            Text = "Add Doctor"
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Mode = Enums.Mode.Edit AndAlso Me.Doctor IsNot Nothing Then
            txt_Name.Text = Me.Doctor.Name
            txt_Username.Text = Me.Doctor.Username
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        If txt_Name.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If txt_Username.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Doctors.Contains(txt_Username.Text) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Me.Mode = Enums.Mode.Edit AndAlso Me.Doctor IsNot Nothing Then
            If txt_Password.Text <> "" Then
                If txt_ConfirmPassword.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Confirm Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If txt_Password.Text <> txt_ConfirmPassword.Text Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Password & Confirm Password are not matching!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If Database.Doctors.Update(Me.Doctor.ID, txt_Username.Text, txt_Name.Text, txt_Password.Text) Then
                Me.Doctor.Name = Me.txt_Name.Text
                Me.Doctor.Username = Me.txt_Username.Text
                DialogResult = DialogResult.OK
                Close()
            End If
        Else
            If txt_Password.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If txt_ConfirmPassword.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Confirm Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If txt_Password.Text <> txt_ConfirmPassword.Text Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Password & Confirm Password are not matching!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim R As Objects.Doctor = Database.Doctors.[New](txt_Name.Text, txt_Username.Text, txt_Password.Text)
            If R IsNot Nothing Then
                Me.Doctor = R
                DialogResult = DialogResult.OK
                Close()
            End If
        End If
    End Sub
#End Region

End Class