Imports MySql.Data.MySqlClient

Namespace Database
    Public Module Common

#Region "Variables"
        Dim Connection As MySqlConnection
#End Region

#Region "Public Functions"
        Public Function GetConnection() As MySqlConnection
            If Connection Is Nothing Then
                Connection = New MySqlConnection(String.Format("Server={0};Database={1};Uid={2};Pwd={3};", My.Settings.ServerAddresss, My.Settings.DatabaseName, My.Settings.Username, My.Settings.Password))
            End If
            Return Connection
        End Function
#End Region

    End Module
End Namespace