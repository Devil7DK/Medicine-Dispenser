<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Doctor
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
    'It can be modified using the Windows Fo~r~m Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Doctor))
        Me.lbl_Name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Username = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Password = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ConfirmPassword = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Username = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ConfirmPassword = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ConfirmPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Name
        '
        Me.lbl_Name.Location = New System.Drawing.Point(70, 15)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Name :"
        '
        'lbl_Username
        '
        Me.lbl_Username.Location = New System.Drawing.Point(49, 41)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "Username :"
        '
        'lbl_Password
        '
        Me.lbl_Password.Location = New System.Drawing.Point(51, 67)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Password.TabIndex = 0
        Me.lbl_Password.Text = "Password :"
        '
        'lbl_ConfirmPassword
        '
        Me.lbl_ConfirmPassword.Location = New System.Drawing.Point(12, 93)
        Me.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword"
        Me.lbl_ConfirmPassword.Size = New System.Drawing.Size(93, 13)
        Me.lbl_ConfirmPassword.TabIndex = 0
        Me.lbl_ConfirmPassword.Text = "Confirm Password :"
        '
        'txt_Name
        '
        Me.txt_Name.EnterMoveNextControl = True
        Me.txt_Name.Location = New System.Drawing.Point(110, 12)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(240, 20)
        Me.txt_Name.TabIndex = 0
        '
        'txt_Username
        '
        Me.txt_Username.EnterMoveNextControl = True
        Me.txt_Username.Location = New System.Drawing.Point(110, 38)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(240, 20)
        Me.txt_Username.TabIndex = 1
        '
        'txt_Password
        '
        Me.txt_Password.EnterMoveNextControl = True
        Me.txt_Password.Location = New System.Drawing.Point(110, 64)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(240, 20)
        Me.txt_Password.TabIndex = 2
        '
        'txt_ConfirmPassword
        '
        Me.txt_ConfirmPassword.EnterMoveNextControl = True
        Me.txt_ConfirmPassword.Location = New System.Drawing.Point(110, 90)
        Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
        Me.txt_ConfirmPassword.Properties.UseSystemPasswordChar = True
        Me.txt_ConfirmPassword.Size = New System.Drawing.Size(240, 20)
        Me.txt_ConfirmPassword.TabIndex = 3
        '
        'btn_Done
        '
        Me.btn_Done.Location = New System.Drawing.Point(275, 116)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(75, 23)
        Me.btn_Done.TabIndex = 4
        Me.btn_Done.Text = "Done"
        '
        'frm_Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 149)
        Me.Controls.Add(Me.btn_Done)
        Me.Controls.Add(Me.txt_ConfirmPassword)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.lbl_ConfirmPassword)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Doctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Doctor"
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ConfirmPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Password As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ConfirmPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ConfirmPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
End Class
