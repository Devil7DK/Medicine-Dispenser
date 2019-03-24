<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StringInputBox
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_StringInputBox))
        Me.panel_Layout = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Prompt = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Value = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_Layout.SuspendLayout()
        CType(Me.txt_Value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_Layout
        '
        Me.panel_Layout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_Layout.AutoSize = True
        Me.panel_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel_Layout.ColumnCount = 3
        Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_Layout.Controls.Add(Me.lbl_Prompt, 0, 0)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter, 1, 0)
        Me.panel_Layout.Controls.Add(Me.txt_Value, 2, 0)
        Me.panel_Layout.Location = New System.Drawing.Point(12, 12)
        Me.panel_Layout.Name = "panel_Layout"
        Me.panel_Layout.RowCount = 1
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_Layout.Size = New System.Drawing.Size(440, 26)
        Me.panel_Layout.TabIndex = 0
        '
        'lbl_Prompt
        '
        Me.lbl_Prompt.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Prompt.Name = "lbl_Prompt"
        Me.lbl_Prompt.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Prompt.TabIndex = 0
        Me.lbl_Prompt.Text = "Enter Text"
        '
        'lbl_Splitter
        '
        Me.lbl_Splitter.Location = New System.Drawing.Point(60, 3)
        Me.lbl_Splitter.Name = "lbl_Splitter"
        Me.lbl_Splitter.Size = New System.Drawing.Size(4, 13)
        Me.lbl_Splitter.TabIndex = 1
        Me.lbl_Splitter.Text = ":"
        '
        'txt_Value
        '
        Me.txt_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Value.Location = New System.Drawing.Point(70, 3)
        Me.txt_Value.Name = "txt_Value"
        Me.txt_Value.Size = New System.Drawing.Size(367, 20)
        Me.txt_Value.TabIndex = 2
        '
        'btn_Done
        '
        Me.btn_Done.Location = New System.Drawing.Point(377, 44)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(75, 23)
        Me.btn_Done.TabIndex = 1
        Me.btn_Done.Text = "Done"
        '
        'frm_StringInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 73)
        Me.Controls.Add(Me.btn_Done)
        Me.Controls.Add(Me.panel_Layout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_StringInputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Text"
        Me.panel_Layout.ResumeLayout(False)
        Me.panel_Layout.PerformLayout()
        CType(Me.txt_Value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_Layout As TableLayoutPanel
    Friend WithEvents lbl_Prompt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Value As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
End Class
