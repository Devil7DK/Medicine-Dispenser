Module Common

#Region "Variables"
    Private SpeechSynthesizer As New Speech.Synthesis.SpeechSynthesizer
#End Region

#Region "Public Functions"
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

    Function Speak(ByVal Text As String) As Boolean
        Try
            SpeechSynthesizer.Rate = 0
            SpeechSynthesizer.Volume = 100
            'SpeechSynthesizer.SelectVoice(GetVoices(0))
            SpeechSynthesizer.Speak(Text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function GetVoices() As String()
        Dim R As New List(Of String)
        For Each Voice As Speech.Synthesis.InstalledVoice In SpeechSynthesizer.GetInstalledVoices(Globalization.CultureInfo.CurrentCulture)
            R.Add(Voice.VoiceInfo.Name)
        Next
        Return R.ToArray
    End Function
#End Region

End Module
