<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rpg_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Data_Common = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.tab_Main = New DevExpress.XtraTab.XtraTabControl()
        Me.tp_Patients = New DevExpress.XtraTab.XtraTabPage()
        Me.gc_Patients = New DevExpress.XtraGrid.GridControl()
        Me.gv_Patients = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tp_Doctor = New DevExpress.XtraTab.XtraTabPage()
        Me.gc_Doctors = New DevExpress.XtraGrid.GridControl()
        Me.gv_Doctors = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLoader = New System.ComponentModel.BackgroundWorker()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Main.SuspendLayout()
        Me.tp_Patients.SuspendLayout()
        CType(Me.gc_Patients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Patients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_Doctor.SuspendLayout()
        CType(Me.gc_Doctors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Doctors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Refresh})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpg_Home})
        Me.RibbonControl.Size = New System.Drawing.Size(879, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'rpg_Home
        '
        Me.rpg_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Data_Common})
        Me.rpg_Home.Name = "rpg_Home"
        Me.rpg_Home.Text = "Home"
        '
        'rpg_Data_Common
        '
        Me.rpg_Data_Common.ItemLinks.Add(Me.btn_Refresh)
        Me.rpg_Data_Common.Name = "rpg_Data_Common"
        Me.rpg_Data_Common.ShowCaptionButton = False
        Me.rpg_Data_Common.Text = "Common"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(879, 31)
        '
        'tab_Main
        '
        Me.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Main.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.tab_Main.Location = New System.Drawing.Point(0, 143)
        Me.tab_Main.Name = "tab_Main"
        Me.tab_Main.SelectedTabPage = Me.tp_Patients
        Me.tab_Main.Size = New System.Drawing.Size(879, 275)
        Me.tab_Main.TabIndex = 2
        Me.tab_Main.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp_Patients, Me.tp_Doctor})
        '
        'tp_Patients
        '
        Me.tp_Patients.Controls.Add(Me.gc_Patients)
        Me.tp_Patients.Name = "tp_Patients"
        Me.tp_Patients.Size = New System.Drawing.Size(873, 247)
        Me.tp_Patients.Text = "Patients"
        '
        'gc_Patients
        '
        Me.gc_Patients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Patients.Location = New System.Drawing.Point(0, 0)
        Me.gc_Patients.MainView = Me.gv_Patients
        Me.gc_Patients.MenuManager = Me.RibbonControl
        Me.gc_Patients.Name = "gc_Patients"
        Me.gc_Patients.Size = New System.Drawing.Size(873, 247)
        Me.gc_Patients.TabIndex = 0
        Me.gc_Patients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Patients})
        '
        'gv_Patients
        '
        Me.gv_Patients.GridControl = Me.gc_Patients
        Me.gv_Patients.Name = "gv_Patients"
        Me.gv_Patients.OptionsBehavior.Editable = False
        Me.gv_Patients.OptionsBehavior.ReadOnly = True
        Me.gv_Patients.OptionsSelection.MultiSelect = True
        '
        'tp_Doctor
        '
        Me.tp_Doctor.Controls.Add(Me.gc_Doctors)
        Me.tp_Doctor.Name = "tp_Doctor"
        Me.tp_Doctor.Size = New System.Drawing.Size(873, 247)
        Me.tp_Doctor.Text = "Doctors"
        '
        'gc_Doctors
        '
        Me.gc_Doctors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Doctors.Location = New System.Drawing.Point(0, 0)
        Me.gc_Doctors.MainView = Me.gv_Doctors
        Me.gc_Doctors.MenuManager = Me.RibbonControl
        Me.gc_Doctors.Name = "gc_Doctors"
        Me.gc_Doctors.Size = New System.Drawing.Size(873, 247)
        Me.gc_Doctors.TabIndex = 1
        Me.gc_Doctors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Doctors})
        '
        'gv_Doctors
        '
        Me.gv_Doctors.GridControl = Me.gc_Doctors
        Me.gv_Doctors.Name = "gv_Doctors"
        Me.gv_Doctors.OptionsBehavior.Editable = False
        Me.gv_Doctors.OptionsBehavior.ReadOnly = True
        Me.gv_Doctors.OptionsSelection.MultiSelect = True
        '
        'DataLoader
        '
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.BarAnimationElementThickness = 2
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel.Location = New System.Drawing.Point(0, 143)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(879, 275)
        Me.ProgressPanel.TabIndex = 1
        Me.ProgressPanel.Text = "ProgressPanel1"
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Caption = "Refresh"
        Me.btn_Refresh.Id = 1
        Me.btn_Refresh.ImageOptions.SvgImage = CType(resources.GetObject("btn_Refresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Refresh.Name = "btn_Refresh"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 449)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.tab_Main)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frm_Main"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Main.ResumeLayout(False)
        Me.tp_Patients.ResumeLayout(False)
        CType(Me.gc_Patients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Patients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_Doctor.ResumeLayout(False)
        CType(Me.gc_Doctors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Doctors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpg_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Data_Common As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents tab_Main As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp_Patients As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc_Patients As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Patients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tp_Doctor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc_Doctors As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Doctors As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLoader As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarButtonItem
End Class
