Module Common

    Function ExInputBox(ByVal Title As String, ByVal Prompt As String, Optional ByVal DefaultValue As String = "") As String
        Dim InputBox As New frm_StringInputBox(Title, Prompt, DefaultValue)
        If InputBox.ShowDialog = DialogResult.OK Then
            Return InputBox.Value
        Else
            Return ""
        End If
    End Function

End Module
