Public Class frm_SelectPatient

#Region "Properties"
    ReadOnly Property SelectedPatient As Objects.Patient
        Get
            Return CType(cmb_Patient.SelectedItem, Objects.Patient)
        End Get
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Patients As List(Of Objects.Patient))
        InitializeComponent()

        cmb_Patient.Properties.Items.AddRange(Patients.ToArray)
        If Patients.Count > 0 Then cmb_Patient.SelectedIndex = 0
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

End Class