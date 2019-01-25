Namespace Objects
    Public Class Medication

#Region "Properties/Fields"
        Property Medicine As Medicine
        Property Dosage As Integer
        Property Hour As Integer
        Property Minute As Integer
#End Region

#Region "Constructor"
        Sub New(ByVal Medicine As Medicine, ByVal Dosage As Integer, ByVal Hour As Integer, ByVal Minute As Integer)
            Me.Medicine = Medicine
            Me.Dosage = Dosage
            Me.Hour = Hour
            Me.Minute = Minute
        End Sub
#End Region

    End Class
End Namespace