Module Common

    Function ExInputBox(ByVal Title As String, ByVal Prompt As String, Optional ByVal DefaultValue As String = "") As String
        Dim InputBox As New frm_StringInputBox(Title, Prompt, DefaultValue)
        If InputBox.ShowDialog = DialogResult.OK Then
            Return InputBox.Value
        Else
            Return ""
        End If
    End Function

    Function ActivateFaceSDK() As Boolean
        Select Case Luxand.FSDK.ActivateLibrary(Keys.LuxandFaceSDK)
            Case Luxand.FSDK.FSDKE_OK
                Return True
            Case Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Luxand Face SDK Activation Failed! Aborting...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
        End Select
    End Function

End Module
