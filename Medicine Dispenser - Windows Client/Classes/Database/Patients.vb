Imports Medicine_Dispenser___Windows_Client.Objects
Imports MySql.Data.MySqlClient

Namespace Database
    Public Class Patients

#Region "Variables"
        Private Shared TableName As String = "patients"
#End Region

#Region "Public Functions"
        Public Shared Function FetchAll() As List(Of Patient)
            Dim R As New List(Of Patient)
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("SELECT * FROM {0};", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Using Reader As MySqlDataReader = Command.ExecuteReader
                        While Reader.Read
                            R.Add(Read(Reader))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Unable to fetch patients data from server.{0}{0}Additional Information:{0}{1}", vbNewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Connection.State <> ConnectionState.Closed Then Connection.Close()
            End Try

            Return R
        End Function
#End Region

#Region "Private Functions"
        Private Shared Function Read(ByVal Reader As MySqlDataReader) As Patient
            Dim ID As Integer = Reader.Item("id")
            Dim Name As String = Reader.Item("name").ToString
            Dim Diseases As String = Reader.Item("diseases").ToString
            Dim Allergies As String = Reader.Item("allergies").ToString
            Dim Medication As String = Reader.Item("medication").ToString
            Return New Patient(ID, Name, Diseases, Allergies, Medication)
        End Function
#End Region

    End Class
End Namespace
