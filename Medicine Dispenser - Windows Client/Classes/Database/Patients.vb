Imports Medicine_Dispenser___Windows_Client.Objects
Imports MySql.Data.MySqlClient

Namespace Database
    Public Class Patients

#Region "Variables"
        Private Shared TableName As String = "patients"
#End Region

#Region "Public Functions"
        Public Shared Function FetchAll(ByVal Doctors As List(Of Doctor)) As List(Of Patient)
            Dim R As New List(Of Patient)
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("SELECT * FROM {0};", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Using Reader As MySqlDataReader = Command.ExecuteReader
                        While Reader.Read
                            R.Add(Read(Reader, Doctors))
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
        Private Shared Function Read(ByVal Reader As MySqlDataReader, ByVal Doctors As List(Of Doctor)) As Patient
            Dim ID As Integer = Reader.Item("id")
            Dim Name As String = Reader.Item("name").ToString
            Dim Diseases As String = Reader.Item("diseases").ToString
            Dim Allergies As String = Reader.Item("allergies").ToString
            Dim Medication As String = Reader.Item("medication").ToString

            Dim DoctorID As Integer = -1
            Dim Doctor As Doctor = Nothing
            If Doctors IsNot Nothing AndAlso Not String.IsNullOrEmpty(Reader.Item("doctor").ToString) AndAlso Integer.TryParse(Reader.Item("doctor").ToString, DoctorID) Then
                Doctor = Doctors.Find(Function(c) c.ID = DoctorID)
            End If
            Return New Patient(ID, Name, Diseases, Allergies, Medication, Doctor)
        End Function
#End Region

    End Class
End Namespace
