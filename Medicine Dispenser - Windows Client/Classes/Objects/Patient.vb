Namespace Objects
    Public Class Patient

#Region "Properties/Fields"
        Property ID As Integer
        Property Name As String
        Property Diseases As List(Of String)
        Property Allergies As List(Of String)
        Property Medication As List(Of Medication)
        Property Doctor As Doctor
#End Region

#Region "Constructors"
        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Diseases As List(Of String), ByVal Allergies As List(Of String), ByVal Medication As List(Of Medication), ByVal Doctor As Doctor)
            Me.ID = ID
            Me.Name = Name
            Me.Diseases = Diseases
            Me.Allergies = Allergies
            Me.Medication = Medication
            Me.Doctor = Doctor
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Diseases As String, ByVal Allergies As String, ByVal Medication As String, ByVal Doctor As Doctor)
            Me.ID = ID
            Me.Name = Name
            Me.Doctor = Doctor

            If Diseases.Trim <> "" Then
                Me.Diseases = Utils.Serializer.FromXML(Of List(Of String))(Diseases)
            End If

            If Allergies.Trim <> "" Then
                Me.Allergies = Utils.Serializer.FromXML(Of List(Of String))(Allergies)
            End If

            If Medication.Trim <> "" Then
                Me.Medication = Utils.Serializer.FromXML(Of List(Of Medication))(Medication)
            End If

            If Me.Diseases Is Nothing Then Me.Diseases = New List(Of String)
            If Me.Allergies Is Nothing Then Me.Allergies = New List(Of String)
            If Me.Medication Is Nothing Then Me.Medication = New List(Of Medication)
        End Sub
#End Region

    End Class
End Namespace
