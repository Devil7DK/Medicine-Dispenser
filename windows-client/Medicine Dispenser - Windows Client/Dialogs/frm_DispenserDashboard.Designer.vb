<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DispenserDashBoard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DispenserDashBoard))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_StartRecognition = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.btn_TrainingMode = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.cmb_Ports = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.txt_Status = New DevExpress.XtraBars.BarStaticItem()
        Me.lbl_TrackerStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_TrackerStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.lbl_Hand = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grp_RemainingMedications = New DevExpress.XtraEditors.GroupControl()
        Me.gc_RemainingMedications = New DevExpress.XtraGrid.GridControl()
        Me.gv_RemainingMedications = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grp_WaitingMedications = New DevExpress.XtraEditors.GroupControl()
        Me.gc_WaitingMedications = New DevExpress.XtraGrid.GridControl()
        Me.gv_WaitingMedications = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Container_CamImageBox = New System.Windows.Forms.Panel()
        Me.CamImageBox = New System.Windows.Forms.PictureBox()
        Me.ArduinoPort = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.grp_RemainingMedications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_RemainingMedications.SuspendLayout()
        CType(Me.gc_RemainingMedications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_RemainingMedications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_WaitingMedications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_WaitingMedications.SuspendLayout()
        CType(Me.gc_WaitingMedications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_WaitingMedications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Container_CamImageBox.SuspendLayout()
        CType(Me.CamImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_StartRecognition, Me.btn_TrainingMode, Me.txt_Status, Me.lbl_TrackerStatus, Me.txt_TrackerStatus, Me.cmb_Ports, Me.lbl_Hand})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_StartRecognition), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_TrainingMode), New DevExpress.XtraBars.LinkPersistInfo(Me.cmb_Ports)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_StartRecognition
        '
        Me.btn_StartRecognition.Caption = "Start Recognition"
        Me.btn_StartRecognition.Id = 2
        Me.btn_StartRecognition.Name = "btn_StartRecognition"
        '
        'btn_TrainingMode
        '
        Me.btn_TrainingMode.Caption = "Training Mode"
        Me.btn_TrainingMode.Id = 3
        Me.btn_TrainingMode.Name = "btn_TrainingMode"
        '
        'cmb_Ports
        '
        Me.cmb_Ports.Caption = "COM Port"
        Me.cmb_Ports.Edit = Me.RepositoryItemComboBox1
        Me.cmb_Ports.EditWidth = 70
        Me.cmb_Ports.Id = 13
        Me.cmb_Ports.Name = "cmb_Ports"
        Me.cmb_Ports.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.txt_Status), New DevExpress.XtraBars.LinkPersistInfo(Me.lbl_TrackerStatus), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_TrackerStatus), New DevExpress.XtraBars.LinkPersistInfo(Me.lbl_Hand)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'txt_Status
        '
        Me.txt_Status.Caption = "-"
        Me.txt_Status.Id = 4
        Me.txt_Status.Name = "txt_Status"
        '
        'lbl_TrackerStatus
        '
        Me.lbl_TrackerStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_TrackerStatus.Caption = "Tracker Status :"
        Me.lbl_TrackerStatus.Id = 5
        Me.lbl_TrackerStatus.Name = "lbl_TrackerStatus"
        '
        'txt_TrackerStatus
        '
        Me.txt_TrackerStatus.Caption = "0"
        Me.txt_TrackerStatus.Id = 6
        Me.txt_TrackerStatus.Name = "txt_TrackerStatus"
        '
        'lbl_Hand
        '
        Me.lbl_Hand.Caption = "BarStaticItem1"
        Me.lbl_Hand.Id = 14
        Me.lbl_Hand.ImageOptions.SvgImage = Global.MedicineDispenser.My.Resources.Resources.hand_blue
        Me.lbl_Hand.Name = "lbl_Hand"
        Me.lbl_Hand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(800, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 423)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(800, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 399)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(800, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 399)
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Container_CamImageBox)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(800, 399)
        Me.SplitContainerControl1.SplitterPosition = 345
        Me.SplitContainerControl1.TabIndex = 4
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.grp_RemainingMedications)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.grp_WaitingMedications)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(450, 399)
        Me.SplitContainerControl2.SplitterPosition = 201
        Me.SplitContainerControl2.TabIndex = 1
        '
        'grp_RemainingMedications
        '
        Me.grp_RemainingMedications.Controls.Add(Me.gc_RemainingMedications)
        Me.grp_RemainingMedications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_RemainingMedications.Location = New System.Drawing.Point(0, 0)
        Me.grp_RemainingMedications.Name = "grp_RemainingMedications"
        Me.grp_RemainingMedications.Size = New System.Drawing.Size(450, 201)
        Me.grp_RemainingMedications.TabIndex = 0
        Me.grp_RemainingMedications.Text = "Medications to be Dispensed"
        '
        'gc_RemainingMedications
        '
        Me.gc_RemainingMedications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_RemainingMedications.Location = New System.Drawing.Point(2, 20)
        Me.gc_RemainingMedications.MainView = Me.gv_RemainingMedications
        Me.gc_RemainingMedications.MenuManager = Me.BarManager1
        Me.gc_RemainingMedications.Name = "gc_RemainingMedications"
        Me.gc_RemainingMedications.Size = New System.Drawing.Size(446, 179)
        Me.gc_RemainingMedications.TabIndex = 0
        Me.gc_RemainingMedications.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_RemainingMedications})
        '
        'gv_RemainingMedications
        '
        Me.gv_RemainingMedications.GridControl = Me.gc_RemainingMedications
        Me.gv_RemainingMedications.Name = "gv_RemainingMedications"
        Me.gv_RemainingMedications.OptionsBehavior.Editable = False
        Me.gv_RemainingMedications.OptionsBehavior.ReadOnly = True
        Me.gv_RemainingMedications.OptionsView.ShowGroupPanel = False
        '
        'grp_WaitingMedications
        '
        Me.grp_WaitingMedications.Controls.Add(Me.gc_WaitingMedications)
        Me.grp_WaitingMedications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_WaitingMedications.Location = New System.Drawing.Point(0, 0)
        Me.grp_WaitingMedications.Name = "grp_WaitingMedications"
        Me.grp_WaitingMedications.Size = New System.Drawing.Size(450, 193)
        Me.grp_WaitingMedications.TabIndex = 1
        Me.grp_WaitingMedications.Text = "Waiting for Patient"
        '
        'gc_WaitingMedications
        '
        Me.gc_WaitingMedications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_WaitingMedications.Location = New System.Drawing.Point(2, 20)
        Me.gc_WaitingMedications.MainView = Me.gv_WaitingMedications
        Me.gc_WaitingMedications.MenuManager = Me.BarManager1
        Me.gc_WaitingMedications.Name = "gc_WaitingMedications"
        Me.gc_WaitingMedications.Size = New System.Drawing.Size(446, 171)
        Me.gc_WaitingMedications.TabIndex = 0
        Me.gc_WaitingMedications.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_WaitingMedications})
        '
        'gv_WaitingMedications
        '
        Me.gv_WaitingMedications.GridControl = Me.gc_WaitingMedications
        Me.gv_WaitingMedications.Name = "gv_WaitingMedications"
        Me.gv_WaitingMedications.OptionsBehavior.Editable = False
        Me.gv_WaitingMedications.OptionsBehavior.ReadOnly = True
        Me.gv_WaitingMedications.OptionsView.ShowGroupPanel = False
        '
        'Container_CamImageBox
        '
        Me.Container_CamImageBox.AutoScroll = True
        Me.Container_CamImageBox.Controls.Add(Me.CamImageBox)
        Me.Container_CamImageBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Container_CamImageBox.Location = New System.Drawing.Point(0, 0)
        Me.Container_CamImageBox.Name = "Container_CamImageBox"
        Me.Container_CamImageBox.Size = New System.Drawing.Size(345, 399)
        Me.Container_CamImageBox.TabIndex = 28
        '
        'CamImageBox
        '
        Me.CamImageBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CamImageBox.Location = New System.Drawing.Point(3, 3)
        Me.CamImageBox.Name = "CamImageBox"
        Me.CamImageBox.Size = New System.Drawing.Size(357, 236)
        Me.CamImageBox.TabIndex = 19
        Me.CamImageBox.TabStop = False
        '
        'ArduinoPort
        '
        '
        'frm_DispenserDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_DispenserDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dispenser Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.grp_RemainingMedications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_RemainingMedications.ResumeLayout(False)
        CType(Me.gc_RemainingMedications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_RemainingMedications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_WaitingMedications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_WaitingMedications.ResumeLayout(False)
        CType(Me.gc_WaitingMedications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_WaitingMedications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Container_CamImageBox.ResumeLayout(False)
        CType(Me.CamImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Container_CamImageBox As Panel
    Friend WithEvents CamImageBox As PictureBox
    Friend WithEvents btn_StartRecognition As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents btn_TrainingMode As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents txt_Status As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lbl_TrackerStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_TrackerStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grp_RemainingMedications As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_RemainingMedications As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_RemainingMedications As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grp_WaitingMedications As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_WaitingMedications As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_WaitingMedications As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmb_Ports As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lbl_Hand As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ArduinoPort As IO.Ports.SerialPort
End Class
