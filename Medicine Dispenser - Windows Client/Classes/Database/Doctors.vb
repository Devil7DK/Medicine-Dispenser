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

            Try
                Dim CommandString As String = String.Format("SELECT [id],[username],[name] FROM {0}", TableName)

                Using Command As New MySqlCommand(CommandString, GetConnection)
                    Using Reader As MySqlDataReader = Command.ExecuteReader
                        While Reader.Read
                            R.Add(Read(Reader))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(String.Format("Unable to fetch doctors data from server.{0}{0}Additional Information:{0}{1}", vbNewLine, ex.Message), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
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
