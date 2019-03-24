Imports System.ComponentModel

Public Class frm_Patient

#Region "Variables"
    Dim Mode As Enums.Mode
    Dim Doctors As New List(Of Objects.Doctor)
#End Region

#Region "Properties"
    Property Patient As Objects.Patient
#End Region

#Region "Constructor"
    Sub New(ByVal Mode As Enums.Mode, ByVal Doctors As List(Of Objects.Doctor))
        InitializeComponent()

        Me.Mode = Mode
        Me.Doctors = Doctors
        If Mode = Enums.Mode.Edit Then
            Text = "Edit Patient"
        Else
            Text = "Add Patient"
        End If

        txt_Doctor.Properties.Items.AddRange(Doctors.ToArray)
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Patient_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Mode = Enums.Mode.Edit AndAlso Patient IsNot Nothing Then
            txt_Name.Text = Patient.Name
            txt_PhoneticName.Text = Patient.PhoneticName
            With Patient.Diseases
                .AllowNew = True
                .AllowEdit = True
                .AllowRemove = True
            End With
            With Patient.Allergies
                .AllowNew = True
                .AllowEdit = True
                .AllowRemove = True
            End With
            With Patient.Medication
                .AllowNew = True
                .AllowEdit = True
                .AllowRemove = True
            End With
            gc_Diseases.DataSource = Patient.Diseases
            gc_Allergies.DataSource = Patient.Allergies
            gc_Medication.DataSource = Patient.Medication

            If Patient.Doctor IsNot Nothing Then
                txt_Doctor.SelectedItem = Doctors.Find(Function(c) c.ID = Patient.Doctor.ID)
                If txt_Doctor.SelectedIndex = -1 Then
                    Doctors.Add(Patient.Doctor)
                    txt_Doctor.Properties.Items.Add(Patient.Doctor)
                    txt_Doctor.SelectedItem = Patient.Doctor
                End If
            End If

            If Patient.Photo IsNot Nothing Then
                pic_Photo.Image = Patient.Photo
            End If
        Else
            If txt_Doctor.Properties.Items.Count > 0 Then txt_Doctor.SelectedIndex = 0
            gc_Diseases.DataSource = New BindingList(Of String) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
            gc_Allergies.DataSource = New BindingList(Of String) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
            gc_Medication.DataSource = New BindingList(Of Objects.Medication) With {.AllowNew = True, .AllowEdit = True, .AllowRemove = True}
            pic_Photo.Image = My.Resources.patient
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        If Mode = Enums.Mode.Add Then
            Dim Patient As Objects.Patient = Database.Patients.[New](txt_Name.Text, txt_PhoneticName.Text, gc_Diseases.DataSource, gc_Allergies.DataSource, gc_Medication.DataSource, txt_Doctor.SelectedItem, pic_Photo.Image)
            If Patient IsNot Nothing Then
                Me.Patient = Patient
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        ElseIf Mode = Enums.Mode.Edit AndAlso Me.Patient IsNot Nothing Then
            Dim Patient As New Objects.Patient(Me.Patient.ID, txt_Name.Text, txt_PhoneticName.Text, CType(gc_Diseases.DataSource, BindingList(Of String)), CType(gc_Allergies.DataSource, BindingList(Of String)), CType(gc_Medication.DataSource, BindingList(Of Objects.Medication)), txt_Doctor.SelectedItem, pic_Photo.Image)
            If Database.Patients.Update(Patient) Then
                Me.Patient.Name = txt_Name.Text
                Me.Patient.PhoneticName = txt_PhoneticName.Text
                Me.Patient.Diseases = gc_Diseases.DataSource
                Me.Patient.Allergies = gc_Allergies.DataSource
                Me.Patient.Medication = gc_Medication.DataSource
                Me.Patient.Doctor = txt_Doctor.SelectedItem

                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Error. Unknown Mode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_CaptureImage_Click(sender As Object, e As EventArgs) Handles btn_CaptureImage.Click
        Dim D As New frm_Capture
        D.ShowDialog()
        If D.CapturedImage IsNot Nothing Then
            pic_Photo.Image = D.CapturedImage
        End If
    End Sub

    Private Sub btn_SelectImage_Click(sender As Object, e As EventArgs) Handles btn_SelectImage.Click
        If dlg_SelectImage.ShowDialog = DialogResult.OK Then
            pic_Photo.Image = Image.FromFile(dlg_SelectImage.FileName)
        End If
    End Sub

    Private Sub btn_ResetImage_Click(sender As Object, e As EventArgs) Handles btn_ResetImage.Click
        pic_Photo.Image = My.Resources.patient
    End Sub

    Private Sub btn_PhoneticName_Click(sender As Object, e As EventArgs) Handles btn_PhoneticName.Click
        Speak(txt_PhoneticName.Text)
    End Sub
#End Region

End Class