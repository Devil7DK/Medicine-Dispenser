<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Patient
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Patient))
        Me.panel_Layout = New System.Windows.Forms.TableLayoutPanel()
        Me.gc_Medication = New DevExpress.XtraGrid.GridControl()
        Me.gv_Medication = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_Allergies = New DevExpress.XtraGrid.GridControl()
        Me.gv_Allergies = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbl_Name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Diseases = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Allergies = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Medication = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Doctor = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Doctor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gc_Diseases = New DevExpress.XtraGrid.GridControl()
        Me.gv_Diseases = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbl_Photo = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_1 = New DevExpress.XtraEditors.LabelControl()
        Me.table_Photo = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_CaptureImage = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_SelectImage = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ResetImage = New DevExpress.XtraEditors.SimpleButton()
        Me.pic_Photo = New System.Windows.Forms.PictureBox()
        Me.lbl_PhoneticName = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Splitter_3 = New DevExpress.XtraEditors.LabelControl()
        Me.table_PhoneticName = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_PhoneticName = New DevExpress.XtraEditors.TextEdit()
        Me.btn_PhoneticName = New DevExpress.XtraEditors.LabelControl()
        Me.panel_Footer = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.dlg_SelectImage = New System.Windows.Forms.OpenFileDialog()
        Me.panel_Layout.SuspendLayout()
        CType(Me.gc_Medication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Medication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Allergies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Allergies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Doctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Diseases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Diseases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_Photo.SuspendLayout()
        CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_PhoneticName.SuspendLayout()
        CType(Me.txt_PhoneticName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Layout
        '
        Me.panel_Layout.ColumnCount = 3
        Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panel_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_Layout.Controls.Add(Me.gc_Medication, 2, 5)
        Me.panel_Layout.Controls.Add(Me.gc_Allergies, 2, 4)
        Me.panel_Layout.Controls.Add(Me.lbl_Name, 0, 1)
        Me.panel_Layout.Controls.Add(Me.lbl_Diseases, 0, 3)
        Me.panel_Layout.Controls.Add(Me.lbl_Allergies, 0, 4)
        Me.panel_Layout.Controls.Add(Me.lbl_Medication, 0, 5)
        Me.panel_Layout.Controls.Add(Me.lbl_Doctor, 0, 6)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_2, 1, 1)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_4, 1, 3)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_5, 1, 4)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_6, 1, 5)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_7, 1, 6)
        Me.panel_Layout.Controls.Add(Me.txt_Name, 2, 1)
        Me.panel_Layout.Controls.Add(Me.txt_Doctor, 2, 6)
        Me.panel_Layout.Controls.Add(Me.gc_Diseases, 2, 3)
        Me.panel_Layout.Controls.Add(Me.lbl_Photo, 0, 0)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_1, 1, 0)
        Me.panel_Layout.Controls.Add(Me.table_Photo, 2, 0)
        Me.panel_Layout.Controls.Add(Me.lbl_PhoneticName, 0, 2)
        Me.panel_Layout.Controls.Add(Me.lbl_Splitter_3, 1, 2)
        Me.panel_Layout.Controls.Add(Me.table_PhoneticName, 2, 2)
        Me.panel_Layout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Layout.Location = New System.Drawing.Point(0, 0)
        Me.panel_Layout.Name = "panel_Layout"
        Me.panel_Layout.RowCount = 7
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_Layout.Size = New System.Drawing.Size(556, 567)
        Me.panel_Layout.TabIndex = 0
        '
        'gc_Medication
        '
        Me.gc_Medication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Medication.Location = New System.Drawing.Point(90, 446)
        Me.gc_Medication.MainView = Me.gv_Medication
        Me.gc_Medication.Name = "gc_Medication"
        Me.gc_Medication.Size = New System.Drawing.Size(463, 91)
        Me.gc_Medication.TabIndex = 17
        Me.gc_Medication.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Medication})
        '
        'gv_Medication
        '
        Me.gv_Medication.GridControl = Me.gc_Medication
        Me.gv_Medication.Name = "gv_Medication"
        Me.gv_Medication.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Medication.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Medication.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gv_Medication.OptionsView.ShowGroupedColumns = True
        Me.gv_Medication.OptionsView.ShowGroupPanel = False
        '
        'gc_Allergies
        '
        Me.gc_Allergies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Allergies.Location = New System.Drawing.Point(90, 349)
        Me.gc_Allergies.MainView = Me.gv_Allergies
        Me.gc_Allergies.Name = "gc_Allergies"
        Me.gc_Allergies.Size = New System.Drawing.Size(463, 91)
        Me.gc_Allergies.TabIndex = 16
        Me.gc_Allergies.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Allergies})
        '
        'gv_Allergies
        '
        Me.gv_Allergies.GridControl = Me.gc_Allergies
        Me.gv_Allergies.Name = "gv_Allergies"
        Me.gv_Allergies.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Allergies.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Allergies.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gv_Allergies.OptionsView.ShowColumnHeaders = False
        Me.gv_Allergies.OptionsView.ShowGroupedColumns = True
        Me.gv_Allergies.OptionsView.ShowGroupPanel = False
        '
        'lbl_Name
        '
        Me.lbl_Name.Appearance.Options.UseTextOptions = True
        Me.lbl_Name.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Name.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Name.Location = New System.Drawing.Point(3, 194)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(71, 20)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Name"
        '
        'lbl_Diseases
        '
        Me.lbl_Diseases.Appearance.Options.UseTextOptions = True
        Me.lbl_Diseases.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Diseases.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Diseases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Diseases.Location = New System.Drawing.Point(3, 252)
        Me.lbl_Diseases.Name = "lbl_Diseases"
        Me.lbl_Diseases.Size = New System.Drawing.Size(71, 91)
        Me.lbl_Diseases.TabIndex = 1
        Me.lbl_Diseases.Text = "Diseases"
        '
        'lbl_Allergies
        '
        Me.lbl_Allergies.Appearance.Options.UseTextOptions = True
        Me.lbl_Allergies.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Allergies.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Allergies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Allergies.Location = New System.Drawing.Point(3, 349)
        Me.lbl_Allergies.Name = "lbl_Allergies"
        Me.lbl_Allergies.Size = New System.Drawing.Size(71, 91)
        Me.lbl_Allergies.TabIndex = 2
        Me.lbl_Allergies.Text = "Allergies"
        '
        'lbl_Medication
        '
        Me.lbl_Medication.Appearance.Options.UseTextOptions = True
        Me.lbl_Medication.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Medication.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Medication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Medication.Location = New System.Drawing.Point(3, 446)
        Me.lbl_Medication.Name = "lbl_Medication"
        Me.lbl_Medication.Size = New System.Drawing.Size(71, 91)
        Me.lbl_Medication.TabIndex = 3
        Me.lbl_Medication.Text = "Medication"
        '
        'lbl_Doctor
        '
        Me.lbl_Doctor.Appearance.Options.UseTextOptions = True
        Me.lbl_Doctor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Doctor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Doctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Doctor.Location = New System.Drawing.Point(3, 543)
        Me.lbl_Doctor.Name = "lbl_Doctor"
        Me.lbl_Doctor.Size = New System.Drawing.Size(71, 21)
        Me.lbl_Doctor.TabIndex = 4
        Me.lbl_Doctor.Text = "Doctor"
        '
        'lbl_Splitter_2
        '
        Me.lbl_Splitter_2.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_2.Location = New System.Drawing.Point(80, 194)
        Me.lbl_Splitter_2.Name = "lbl_Splitter_2"
        Me.lbl_Splitter_2.Size = New System.Drawing.Size(4, 20)
        Me.lbl_Splitter_2.TabIndex = 5
        Me.lbl_Splitter_2.Text = ":"
        '
        'lbl_Splitter_4
        '
        Me.lbl_Splitter_4.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_4.Location = New System.Drawing.Point(80, 252)
        Me.lbl_Splitter_4.Name = "lbl_Splitter_4"
        Me.lbl_Splitter_4.Size = New System.Drawing.Size(4, 91)
        Me.lbl_Splitter_4.TabIndex = 6
        Me.lbl_Splitter_4.Text = ":"
        '
        'lbl_Splitter_5
        '
        Me.lbl_Splitter_5.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_5.Location = New System.Drawing.Point(80, 349)
        Me.lbl_Splitter_5.Name = "lbl_Splitter_5"
        Me.lbl_Splitter_5.Size = New System.Drawing.Size(4, 91)
        Me.lbl_Splitter_5.TabIndex = 7
        Me.lbl_Splitter_5.Text = ":"
        '
        'lbl_Splitter_6
        '
        Me.lbl_Splitter_6.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_6.Location = New System.Drawing.Point(80, 446)
        Me.lbl_Splitter_6.Name = "lbl_Splitter_6"
        Me.lbl_Splitter_6.Size = New System.Drawing.Size(4, 91)
        Me.lbl_Splitter_6.TabIndex = 8
        Me.lbl_Splitter_6.Text = ":"
        '
        'lbl_Splitter_7
        '
        Me.lbl_Splitter_7.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_7.Location = New System.Drawing.Point(80, 543)
        Me.lbl_Splitter_7.Name = "lbl_Splitter_7"
        Me.lbl_Splitter_7.Size = New System.Drawing.Size(4, 21)
        Me.lbl_Splitter_7.TabIndex = 9
        Me.lbl_Splitter_7.Text = ":"
        '
        'txt_Name
        '
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.Location = New System.Drawing.Point(90, 194)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(463, 20)
        Me.txt_Name.TabIndex = 10
        '
        'txt_Doctor
        '
        Me.txt_Doctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Doctor.Location = New System.Drawing.Point(90, 543)
        Me.txt_Doctor.Name = "txt_Doctor"
        Me.txt_Doctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Doctor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Doctor.Size = New System.Drawing.Size(463, 20)
        Me.txt_Doctor.TabIndex = 14
        '
        'gc_Diseases
        '
        Me.gc_Diseases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Diseases.Location = New System.Drawing.Point(90, 252)
        Me.gc_Diseases.MainView = Me.gv_Diseases
        Me.gc_Diseases.Name = "gc_Diseases"
        Me.gc_Diseases.Size = New System.Drawing.Size(463, 91)
        Me.gc_Diseases.TabIndex = 15
        Me.gc_Diseases.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Diseases})
        '
        'gv_Diseases
        '
        Me.gv_Diseases.GridControl = Me.gc_Diseases
        Me.gv_Diseases.Name = "gv_Diseases"
        Me.gv_Diseases.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Diseases.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gv_Diseases.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gv_Diseases.OptionsView.ShowColumnHeaders = False
        Me.gv_Diseases.OptionsView.ShowGroupedColumns = True
        Me.gv_Diseases.OptionsView.ShowGroupPanel = False
        '
        'lbl_Photo
        '
        Me.lbl_Photo.Appearance.Options.UseTextOptions = True
        Me.lbl_Photo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Photo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Photo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Photo.Location = New System.Drawing.Point(3, 3)
        Me.lbl_Photo.Name = "lbl_Photo"
        Me.lbl_Photo.Size = New System.Drawing.Size(71, 185)
        Me.lbl_Photo.TabIndex = 18
        Me.lbl_Photo.Text = "Photo"
        '
        'lbl_Splitter_1
        '
        Me.lbl_Splitter_1.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_1.Location = New System.Drawing.Point(80, 3)
        Me.lbl_Splitter_1.Name = "lbl_Splitter_1"
        Me.lbl_Splitter_1.Size = New System.Drawing.Size(4, 185)
        Me.lbl_Splitter_1.TabIndex = 19
        Me.lbl_Splitter_1.Text = ":"
        '
        'table_Photo
        '
        Me.table_Photo.AutoSize = True
        Me.table_Photo.ColumnCount = 3
        Me.table_Photo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_Photo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.table_Photo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.table_Photo.Controls.Add(Me.btn_CaptureImage, 0, 1)
        Me.table_Photo.Controls.Add(Me.btn_SelectImage, 1, 1)
        Me.table_Photo.Controls.Add(Me.btn_ResetImage, 2, 1)
        Me.table_Photo.Controls.Add(Me.pic_Photo, 0, 0)
        Me.table_Photo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_Photo.Location = New System.Drawing.Point(90, 3)
        Me.table_Photo.Name = "table_Photo"
        Me.table_Photo.RowCount = 2
        Me.table_Photo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.table_Photo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.table_Photo.Size = New System.Drawing.Size(463, 185)
        Me.table_Photo.TabIndex = 20
        '
        'btn_CaptureImage
        '
        Me.btn_CaptureImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CaptureImage.Location = New System.Drawing.Point(3, 153)
        Me.btn_CaptureImage.Name = "btn_CaptureImage"
        Me.btn_CaptureImage.Size = New System.Drawing.Size(148, 29)
        Me.btn_CaptureImage.TabIndex = 0
        Me.btn_CaptureImage.Text = "Capture"
        '
        'btn_SelectImage
        '
        Me.btn_SelectImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SelectImage.Location = New System.Drawing.Point(157, 153)
        Me.btn_SelectImage.Name = "btn_SelectImage"
        Me.btn_SelectImage.Size = New System.Drawing.Size(148, 29)
        Me.btn_SelectImage.TabIndex = 1
        Me.btn_SelectImage.Text = "Select Image"
        '
        'btn_ResetImage
        '
        Me.btn_ResetImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ResetImage.Location = New System.Drawing.Point(311, 153)
        Me.btn_ResetImage.Name = "btn_ResetImage"
        Me.btn_ResetImage.Size = New System.Drawing.Size(149, 29)
        Me.btn_ResetImage.TabIndex = 2
        Me.btn_ResetImage.Text = "Reset"
        '
        'pic_Photo
        '
        Me.pic_Photo.BackColor = System.Drawing.Color.Black
        Me.table_Photo.SetColumnSpan(Me.pic_Photo, 3)
        Me.pic_Photo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Photo.Location = New System.Drawing.Point(3, 3)
        Me.pic_Photo.Name = "pic_Photo"
        Me.pic_Photo.Size = New System.Drawing.Size(457, 144)
        Me.pic_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Photo.TabIndex = 3
        Me.pic_Photo.TabStop = False
        '
        'lbl_PhoneticName
        '
        Me.lbl_PhoneticName.Appearance.Options.UseTextOptions = True
        Me.lbl_PhoneticName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_PhoneticName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_PhoneticName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_PhoneticName.Location = New System.Drawing.Point(3, 220)
        Me.lbl_PhoneticName.Name = "lbl_PhoneticName"
        Me.lbl_PhoneticName.Size = New System.Drawing.Size(71, 26)
        Me.lbl_PhoneticName.TabIndex = 21
        Me.lbl_PhoneticName.Text = "Phonetic Name"
        '
        'lbl_Splitter_3
        '
        Me.lbl_Splitter_3.Appearance.Options.UseTextOptions = True
        Me.lbl_Splitter_3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Splitter_3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_Splitter_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Splitter_3.Location = New System.Drawing.Point(80, 220)
        Me.lbl_Splitter_3.Name = "lbl_Splitter_3"
        Me.lbl_Splitter_3.Size = New System.Drawing.Size(4, 26)
        Me.lbl_Splitter_3.TabIndex = 22
        Me.lbl_Splitter_3.Text = ":"
        '
        'table_PhoneticName
        '
        Me.table_PhoneticName.AutoSize = True
        Me.table_PhoneticName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.table_PhoneticName.ColumnCount = 2
        Me.table_PhoneticName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_PhoneticName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.table_PhoneticName.Controls.Add(Me.txt_PhoneticName, 0, 0)
        Me.table_PhoneticName.Controls.Add(Me.btn_PhoneticName, 1, 0)
        Me.table_PhoneticName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_PhoneticName.Location = New System.Drawing.Point(90, 220)
        Me.table_PhoneticName.Name = "table_PhoneticName"
        Me.table_PhoneticName.RowCount = 1
        Me.table_PhoneticName.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table_PhoneticName.Size = New System.Drawing.Size(463, 26)
        Me.table_PhoneticName.TabIndex = 23
        '
        'txt_PhoneticName
        '
        Me.txt_PhoneticName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PhoneticName.Location = New System.Drawing.Point(3, 3)
        Me.txt_PhoneticName.Name = "txt_PhoneticName"
        Me.txt_PhoneticName.Size = New System.Drawing.Size(431, 20)
        Me.txt_PhoneticName.TabIndex = 0
        '
        'btn_PhoneticName
        '
        Me.btn_PhoneticName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.btn_PhoneticName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PhoneticName.ImageOptions.SvgImage = CType(resources.GetObject("btn_PhoneticName.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_PhoneticName.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_PhoneticName.Location = New System.Drawing.Point(440, 3)
        Me.btn_PhoneticName.Name = "btn_PhoneticName"
        Me.btn_PhoneticName.Size = New System.Drawing.Size(20, 20)
        Me.btn_PhoneticName.TabIndex = 1
        '
        'panel_Footer
        '
        Me.panel_Footer.Controls.Add(Me.btn_Done)
        Me.panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_Footer.Location = New System.Drawing.Point(0, 567)
        Me.panel_Footer.Name = "panel_Footer"
        Me.panel_Footer.Size = New System.Drawing.Size(556, 47)
        Me.panel_Footer.TabIndex = 1
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.ImageOptions.SvgImage = CType(resources.GetObject("btn_Done.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Done.Location = New System.Drawing.Point(465, 5)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(86, 37)
        Me.btn_Done.TabIndex = 0
        Me.btn_Done.Text = "Done"
        '
        'dlg_SelectImage
        '
        Me.dlg_SelectImage.Filter = "All Supported Files|*.bmp;*.png;*.jpg;*.jpeg"
        '
        'frm_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 614)
        Me.Controls.Add(Me.panel_Layout)
        Me.Controls.Add(Me.panel_Footer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient"
        Me.panel_Layout.ResumeLayout(False)
        Me.panel_Layout.PerformLayout()
        CType(Me.gc_Medication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Medication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Allergies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Allergies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Doctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Diseases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Diseases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_Photo.ResumeLayout(False)
        CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_PhoneticName.ResumeLayout(False)
        Me.table_PhoneticName.PerformLayout()
        CType(Me.txt_PhoneticName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Footer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_Layout As TableLayoutPanel
    Friend WithEvents lbl_Name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Diseases As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Allergies As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Medication As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Doctor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Doctor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents panel_Footer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc_Diseases As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Diseases As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_Medication As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Medication As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_Allergies As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Allergies As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbl_Photo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents table_Photo As TableLayoutPanel
    Friend WithEvents btn_CaptureImage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_SelectImage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ResetImage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pic_Photo As PictureBox
    Friend WithEvents dlg_SelectImage As OpenFileDialog
    Friend WithEvents lbl_PhoneticName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Splitter_3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents table_PhoneticName As TableLayoutPanel
    Friend WithEvents txt_PhoneticName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_PhoneticName As DevExpress.XtraEditors.LabelControl
End Class
