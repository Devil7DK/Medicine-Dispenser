Imports MedicineDispenser.Objects
Imports MySql.Data.MySqlClient

Namespace Database
    Public Class Doctors

#Region "Variables"
        Private Shared TableName As String = "doctors"
#End Region

#Region "Public Functions"
        Public Shared Function Login(ByVal UserName As String, ByVal Password As String) As Doctor
            Dim R As Doctor = Nothing

            Dim Connection As MySqlConnection = GetConnection()
            Try
                Dim CommandString As String = String.Format("SELECT id,username,name from {0} WHERE username=@username AND password=@password;", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@username", UserName)
                    Command.Parameters.AddWithValue("@password", Utils.Encryption.EncryptString(Password))

                    Using Reader As MySqlDataReader = Command.ExecuteReader
                        If Reader.Read Then
                            R = Read(Reader)
                        Else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Login Failed! Incorrect username/password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Unable to complete Login process.{0}{0}Additional Information:{0}{1}", vbNewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Connection.State <> ConnectionState.Closed Then Connection.Close()
            End Try

            Return R
        End Function

        Public Shared Function FetchAll() As List(Of Doctor)
            Dim R As New List(Of Doctor)
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("SELECT id,username,name FROM {0};", TableName)
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

        Public Shared Function [New](ByVal Name As String, ByVal Username As String, ByVal Password As String) As Doctor
            Dim R As Doctor = Nothing
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("INSERT INTO {0} (name,username,password) VALUES(@name,@username,@password);SELECT LAST_INSERT_ID();", TableName)
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@name", Name)
                    Command.Parameters.AddWithValue("@username", Username)
                    Command.Parameters.AddWithValue("@password", Utils.EncryptString(Password))

                    Dim ID As Integer = Command.ExecuteScalar
                    If ID > 0 Then
                        R = New Doctor(ID, Username, Name)
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting doctor.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Error while inserting doctor." & vbNewLine & ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return R
        End Function

        Public Shared Function Update(ByVal ID As Integer, ByVal Username As String, ByVal Name As String, ByVal Password As String) As Boolean
            Dim R As Boolean = False
            Dim Connection As MySqlConnection = GetConnection()

            Try
                Dim CommandString As String = String.Format("UPDATE {0} SET name=@name,username=@username{1} WHERE id=@id;", TableName, If(Password <> "", ",password=@password", ""))
                If Connection.State = ConnectionState.Closed Then Connection.Open()

                Using Command As New MySqlCommand(CommandString, Connection)
                    Command.Parameters.AddWithValue("@id", ID)
                    Command.Parameters.AddWithValue("@name", Name)
                    Command.Parameters.AddWithValue("@username", Username)
                    If Password <> "" Then Command.Parameters.AddWithValue("@password", Utils.EncryptString(Password))

                    Dim Result As Integer = Command.ExecuteNonQuery
                    If Result = 1 Then
                        R = True
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while updating doctor.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show("Error while updating doctor." & vbNewLine & ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return R
        End Function

        Public Shared Function Remove(ByVal ID As Integer, ByVal CloseConnection As Boolean) As Boolean
            Return RemoveItem(TableName, ID, CloseConnection)
        End Function
#End Region

#Region "Private Functions"
        Private Shared Function Read(ByVal Reader As MySqlDataReader) As Doctor
            Dim ID As Integer = Reader.Item("id")
            Dim Name As String = Reader.Item("name")
            Dim Username As String = Reader.Item("username")
            Return New Doctor(ID, Username, Name)
        End Function
#End Region

    End Class
End Namespace
