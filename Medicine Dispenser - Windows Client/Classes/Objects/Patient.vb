Public Class Patient

#Region "Properties/Fields"
    Property ID As Integer
    Property Name As String
    Property Diseases As List(Of String)
    Property Allergies As List(Of String)
    Property Medication As List(Of Medication)
#End Region

#Region "Constructors"
    Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Diseases As List(Of String), ByVal Allergies As List(Of String), ByVal Medication As List(Of Medication))
        Me.ID = ID
        Me.Name = Name
        Me.Diseases = Diseases
        Me.Allergies = Allergies
        Me.Medication = Medication
    End Sub
#End Region

End Class
