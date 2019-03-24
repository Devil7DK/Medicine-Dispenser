<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Capture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Capture))
        Me.image_PICBX = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Capture = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.image_PICBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'image_PICBX
        '
        Me.image_PICBX.BackColor = System.Drawing.Color.Black
        Me.image_PICBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.image_PICBX.Location = New System.Drawing.Point(12, 12)
        Me.image_PICBX.Name = "image_PICBX"
        Me.image_PICBX.Size = New System.Drawing.Size(448, 307)
        Me.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image_PICBX.TabIndex = 17
        Me.image_PICBX.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Capture, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_OK, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(466, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 307)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 3)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btn_Capture
        '
        Me.btn_Capture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Capture.Location = New System.Drawing.Point(3, 273)
        Me.btn_Capture.Name = "btn_Capture"
        Me.btn_Capture.Size = New System.Drawing.Size(68, 31)
        Me.btn_Capture.TabIndex = 21
        Me.btn_Capture.Text = "Capture"
        '
        'btn_OK
        '
        Me.btn_OK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_OK.Enabled = False
        Me.btn_OK.Location = New System.Drawing.Point(144, 273)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(68, 31)
        Me.btn_OK.TabIndex = 22
        Me.btn_OK.Text = "OK"
        '
        'frm_Capture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 334)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.image_PICBX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Capture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Capture"
        CType(Me.image_PICBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents image_PICBX As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Capture As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
End Class
