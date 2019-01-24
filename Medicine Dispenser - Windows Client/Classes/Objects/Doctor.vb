Namespace Objects
    Public Class Doctor

#Region "Properties/Fields"
        Property ID As Integer
        Property Username As String
        Property Name As String
#End Region

#Region "Constructors"
        Sub New(ByVal ID As Integer, ByVal Username As String, ByVal Name As String)
            Me.ID = ID
            Me.Username = Username
            Me.Name = Name
        End Sub
#End Region

#Region "Subs"
        Public Overrides Function ToString() As String
            Return Username
        End Function
#End Region

    End Class
End Namespace