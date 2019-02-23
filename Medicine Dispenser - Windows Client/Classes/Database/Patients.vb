Imports System.ComponentModel
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

        Public Shared Function [New](ByVal Name As String, ByVal Diseases As BindingList(Of String), ByVal Allergies As BindingList(Of String), ByVal Medication As BindingList(Of Medication), ByVal Doctor As Doctor, ByVal Photo As Image) As Patient
            Dim R As Patient = Nothing
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("INSERT INTO {0} (name,diseases,allergies,medication,doctor) VALUES(@name,@diseases,@allergies,@medication,@doctor);SELECT LAST_INSERT_ID();", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@name", Name)
                    Command.Parameters.AddWithValue("@diseases", Utils.Serializer.ToZXML(Diseases))
                    Command.Parameters.AddWithValue("@allergies", Utils.Serializer.ToZXML(Allergies))
                    Command.Parameters.AddWithValue("@medication", Utils.Serializer.ToZXML(Medication))
                    Command.Parameters.AddWithValue("@doctor", Doctor.ID)

                    Dim ID As Integer = Command.ExecuteScalar
                    If ID > 0 Then
                        R = New Patient(ID, Name, Diseases, Allergies, Medication, Doctor, Photo)
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting patient.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Error while inserting patient." & vbNewLine & ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return R
        End Function

        Public Shared Function Update(ByVal UpdatedPatient As Patient) As Boolean
            Dim R As Boolean = False
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("UPDATE {0} SET name=@name,diseases=@diseases,allergies=@allergies,medication=@medication,doctor=@doctor WHERE id=@id;", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@id", UpdatedPatient.ID)
                    Command.Parameters.AddWithValue("@name", UpdatedPatient.Name)
                    Command.Parameters.AddWithValue("@diseases", Utils.Serializer.ToZXML(UpdatedPatient.Diseases))
                    Command.Parameters.AddWithValue("@allergies", Utils.Serializer.ToZXML(UpdatedPatient.Allergies))
                    Command.Parameters.AddWithValue("@medication", Utils.Serializer.ToZXML(UpdatedPatient.Medication))
                    Command.Parameters.AddWithValue("@doctor", UpdatedPatient.Doctor.ID)

                    Dim Result As Integer = Command.ExecuteNonQuery
                    If Result = 1 Then
                        R = True
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while updating patient.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Error while updating patient." & vbNewLine & ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return R
        End Function

        Public Shared Function Remove(ByVal ID As Integer, ByVal CloseConnection As Boolean) As Boolean
            Return RemoveItem(TableName, ID, CloseConnection)
        End Function
#End Region

#Region "Private Functions"
        Private Shared Function Read(ByVal Reader As MySqlDataReader, ByVal Doctors As List(Of Doctor)) As Patient
            Dim ID As Integer = Reader.Item("id")
            Dim Name As String = Reader.Item("name").ToString
            Dim Diseases As Byte() = Reader.Item("diseases")
            Dim Allergies As Byte() = Reader.Item("allergies")
            Dim Medication As Byte() = Reader.Item("medication")
            Dim Photo As Byte() = If(IsDBNull(Reader.Item("photo")), Nothing, Reader.Item("photo"))

            Dim DoctorID As Integer = -1
            Dim Doctor As Doctor = Nothing
            If Doctors IsNot Nothing AndAlso Not String.IsNullOrEmpty(Reader.Item("doctor").ToString) AndAlso Integer.TryParse(Reader.Item("doctor").ToString, DoctorID) Then
                Doctor = Doctors.Find(Function(c) c.ID = DoctorID)
            End If
            Return New Patient(ID, Name, Diseases, Allergies, Medication, Doctor, Photo)
        End Function
#End Region

    End Class
End Namespace
