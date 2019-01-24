Imports Medicine_Dispenser___Windows_Client.Objects
Imports MySql.Data.MySqlClient

Namespace Database
    Public Class Doctors

#Region "Variables"
        Private Shared TableName As String = "doctors"
#End Region

#Region "Public Functions"
        Public Shared Function FetchAll() As List(Of Doctor)
            Dim R As New List(Of Doctor)
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("SELECT [id],[username],[name] FROM {0}", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Using Reader As MySqlDataReader = Command.ExecuteReader
                        While Reader.Read
                            R.Add(Read(Reader))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Unable to fetch doctors data from server.{0}{0}Additional Information:{0}{1}", vbNewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Connection.State <> ConnectionState.Closed Then Connection.Close()
            End Try

            Return R
        End Function
#End Region

#Region "Private Functions"
        Private Shared Function Read(ByVal Reader As MySqlDataReader) As Doctor
            Dim ID As Integer = Reader.Item("id")
            Dim Name As String = Reader.Item("name")
            Dim Username As String = Reader.Item("username")
            Return New Doctor(ID, Name, Username)
        End Function
#End Region

    End Class
End Namespace
