Namespace Objects
    Public Class HandPlacedEventArgs : Inherits EventArgs

#Region "Properties"
        Property isHandPlaced As Boolean
#End Region

#Region "Constructor"
        Sub New(ByVal isHandPlaced As Boolean)
            Me.isHandPlaced = isHandPlaced
        End Sub
#End Region

    End Class
End Namespace