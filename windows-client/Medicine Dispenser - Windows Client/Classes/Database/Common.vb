Imports MySql.Data.MySqlClient

Namespace Database
    Public Module Common

#Region "Variables"
        Dim Connection As MySqlConnection
#End Region

#Region "Public Functions"
        Public Function GetConnection() As MySqlConnection
            If Connection Is Nothing Then
                Connection = New MySqlConnection(String.Format("Server={0};Database={1};Uid={2};Pwd={3};", My.Settings.ServerAddresss, My.Settings.DatabaseName, My.Settings.Username, Utils.Encryption.DecryptString(My.Settings.Password)))
            End If
            Return Connection
        End Function

        Public Function RemoveItem(ByVal TableName As String, ByVal ID As Integer, ByVal CloseConnection As Boolean) As Boolean
            Dim R As Boolean = False

            Dim Connection As MySqlConnection = GetConnection()
            Try
                Dim CommandString As String = String.Format("DELETE FROM {0} WHERE id=@id", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@id", ID)
                    If Command.ExecuteNonQuery = 1 Then
                        R = True
                    End If
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Unable to remove item with id {1} from table {2}. {0}{0}Additional Information:{0}{3}", vbNewLine, ID, TableName, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If CloseConnection AndAlso Connection.State = ConnectionState.Open Then Connection.Close()
            End Try

            Return R
        End Function
#End Region

    End Module
End Namespace