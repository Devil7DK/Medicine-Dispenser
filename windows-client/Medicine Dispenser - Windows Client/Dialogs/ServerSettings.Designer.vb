<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerSettings))
        Me.lbl_ServerName = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_DatabaseName = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Username = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Password = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ServerName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_DatabaseName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Username = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_ServerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DatabaseName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.Location = New System.Drawing.Point(12, 15)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(83, 13)
        Me.lbl_ServerName.TabIndex = 0
        Me.lbl_ServerName.Text = "Server Name/IP :"
        '
        'lbl_DatabaseName
        '
        Me.lbl_DatabaseName.Location = New System.Drawing.Point(12, 41)
        Me.lbl_DatabaseName.Name = "lbl_DatabaseName"
        Me.lbl_DatabaseName.Size = New System.Drawing.Size(83, 13)
        Me.lbl_DatabaseName.TabIndex = 1
        Me.lbl_DatabaseName.Text = "Database Name :"
        '
        'lbl_Username
        '
        Me.lbl_Username.Location = New System.Drawing.Point(40, 67)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Username.TabIndex = 2
        Me.lbl_Username.Text = "Username :"
        '
        'lbl_Password
        '
        Me.lbl_Password.Location = New System.Drawing.Point(42, 93)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Password.TabIndex = 3
        Me.lbl_Password.Text = "Password :"
        '
        'txt_ServerName
        '
        Me.txt_ServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ServerName.EnterMoveNextControl = True
        Me.txt_ServerName.Location = New System.Drawing.Point(101, 12)
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.Size = New System.Drawing.Size(307, 20)
        Me.txt_ServerName.TabIndex = 4
        '
        'txt_DatabaseName
        '
        Me.txt_DatabaseName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DatabaseName.EnterMoveNextControl = True
        Me.txt_DatabaseName.Location = New System.Drawing.Point(101, 38)
        Me.txt_DatabaseName.Name = "txt_DatabaseName"
        Me.txt_DatabaseName.Size = New System.Drawing.Size(307, 20)
        Me.txt_DatabaseName.TabIndex = 5
        '
        'txt_Username
        '
        Me.txt_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Username.EnterMoveNextControl = True
        Me.txt_Username.Location = New System.Drawing.Point(101, 64)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(307, 20)
        Me.txt_Username.TabIndex = 6
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Password.EnterMoveNextControl = True
        Me.txt_Password.Location = New System.Drawing.Point(101, 90)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(307, 20)
        Me.txt_Password.TabIndex = 7
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(333, 116)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 8
        Me.btn_Save.Text = "Save"
        '
        'ServerSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 146)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_DatabaseName)
        Me.Controls.Add(Me.txt_ServerName)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_DatabaseName)
        Me.Controls.Add(Me.lbl_ServerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServerSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Server Settings"
        CType(Me.txt_ServerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DatabaseName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_ServerName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_DatabaseName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Password As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ServerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DatabaseName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
End Class
