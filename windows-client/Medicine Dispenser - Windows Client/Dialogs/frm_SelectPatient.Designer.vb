<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SelectPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SelectPatient))
        Me.lbl_Patient = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Patient = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmb_Patient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Patient
        '
        Me.lbl_Patient.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Patient.Name = "lbl_Patient"
        Me.lbl_Patient.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Patient.TabIndex = 0
        Me.lbl_Patient.Text = "Patient :"
        '
        'cmb_Patient
        '
        Me.cmb_Patient.Location = New System.Drawing.Point(59, 12)
        Me.cmb_Patient.Name = "cmb_Patient"
        Me.cmb_Patient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Patient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_Patient.Size = New System.Drawing.Size(294, 20)
        Me.cmb_Patient.TabIndex = 1
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(279, 40)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(74, 21)
        Me.btn_OK.TabIndex = 2
        Me.btn_OK.Text = "OK"
        '
        'frm_SelectPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 73)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.cmb_Patient)
        Me.Controls.Add(Me.lbl_Patient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SelectPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Patient"
        CType(Me.cmb_Patient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Patient As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Patient As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
End Class
