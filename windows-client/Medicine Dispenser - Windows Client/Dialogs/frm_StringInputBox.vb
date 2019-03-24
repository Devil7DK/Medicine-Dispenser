Public Class frm_StringInputBox

#Region "Constructor"
    Sub New(ByVal Title As String, ByVal Prompt As String, Optional ByVal DefaultValue As String = "")
        InitializeComponent()

        Me.Text = Title
        Me.lbl_Prompt.Text = Prompt
        Me.txt_Value.Text = DefaultValue
    End Sub
#End Region

#Region "Properties"
    ReadOnly Property Value As String
        Get
            Return txt_Value.Text.Trim
        End Get
    End Property
#End Region

#Region "Button Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
#End Region

End Class