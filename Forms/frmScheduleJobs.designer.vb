<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleJobs
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleJobs))
        Me.flexNeedAttention = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOpenJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTopButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnShowSchedule = New System.Windows.Forms.Button()
        Me.btnShowJobComm = New System.Windows.Forms.Button()
        Me.c1Sizer1 = New System.Windows.Forms.Panel()
        Me.C1Calendar1 = New C1.Win.C1Schedule.C1Calendar()
        Me.flexSWO = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lblSWO = New System.Windows.Forms.Label()
        Me.flexOnHold = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lblOnHold = New System.Windows.Forms.Label()
        Me.pnlCustomSearch = New System.Windows.Forms.Panel()
        Me.flexSearch = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblCustomSearch = New System.Windows.Forms.Label()
        Me.lblNeedsAttention = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.C1Sizer2 = New C1.Win.C1Sizer.C1Sizer()
        Me.CtrFullSchedule1 = New TKSISchedule.ctrFullSchedule()
        Me.CtrJobComm1 = New TKSISchedule.ctrJobComm()
        Me.ds1 = New TKSISchedule.TKSIJOBSDataSet()
        Me.TJobTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter()
        Me.TPOHeaderTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter()
        Me.TCustomrTableAdapter = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter()
        Me.TVendorTableAdapter = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter()
        Me.TblJobActivityTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.TblActivityTypeTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblActivityTypeTableAdapter()
        Me.AppointmentsTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.AppointmentsTableAdapter()
        Me.TAddressTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tAddressTableAdapter()
        Me.TblInstallerDatesTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblInstallerDatesTableAdapter()
        CType(Me.flexNeedAttention, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlTopButtons.SuspendLayout()
        Me.c1Sizer1.SuspendLayout()
        CType(Me.C1Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flexSWO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flexOnHold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomSearch.SuspendLayout()
        CType(Me.flexSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Sizer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer2.SuspendLayout()
        CType(Me.ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flexNeedAttention
        '
        Me.flexNeedAttention.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.flexNeedAttention.AllowEditing = False
        Me.flexNeedAttention.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.flexNeedAttention.ColumnInfo = "1,0,0,0,0,85,Columns:0{Width:509;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.flexNeedAttention.ContextMenuStrip = Me.ContextMenuStrip1
        Me.flexNeedAttention.Dock = System.Windows.Forms.DockStyle.Top
        Me.flexNeedAttention.DragMode = C1.Win.C1FlexGrid.DragModeEnum.Automatic
        Me.flexNeedAttention.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.flexNeedAttention.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.flexNeedAttention.Location = New System.Drawing.Point(0, 14)
        Me.flexNeedAttention.Name = "flexNeedAttention"
        Me.flexNeedAttention.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.flexNeedAttention.Rows.DefaultSize = 21
        Me.flexNeedAttention.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.flexNeedAttention.ShowErrors = True
        Me.flexNeedAttention.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.flexNeedAttention.Size = New System.Drawing.Size(308, 147)
        Me.flexNeedAttention.StyleInfo = resources.GetString("flexNeedAttention.StyleInfo")
        Me.flexNeedAttention.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenJobToolStripMenuItem, Me.PrintJobToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        'mnuOpenJobToolStripMenuItem
        '
        Me.mnuOpenJobToolStripMenuItem.Name = "mnuOpenJobToolStripMenuItem"
        Me.mnuOpenJobToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.mnuOpenJobToolStripMenuItem.Text = "Open Job"
        '
        'PrintJobToolStripMenuItem
        '
        Me.PrintJobToolStripMenuItem.Name = "PrintJobToolStripMenuItem"
        Me.PrintJobToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PrintJobToolStripMenuItem.Text = "Print Job"
        '
        'pnlTopButtons
        '
        Me.pnlTopButtons.Controls.Add(Me.btnRefresh)
        Me.pnlTopButtons.Controls.Add(Me.btnShowSchedule)
        Me.pnlTopButtons.Controls.Add(Me.btnShowJobComm)
        Me.pnlTopButtons.Location = New System.Drawing.Point(3, 3)
        Me.pnlTopButtons.Name = "pnlTopButtons"
        Me.pnlTopButtons.Size = New System.Drawing.Size(878, 19)
        Me.pnlTopButtons.TabIndex = 14
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.Location = New System.Drawing.Point(240, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 19)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnShowSchedule
        '
        Me.btnShowSchedule.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowSchedule.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowSchedule.ForeColor = System.Drawing.Color.Black
        Me.btnShowSchedule.Location = New System.Drawing.Point(120, 0)
        Me.btnShowSchedule.Name = "btnShowSchedule"
        Me.btnShowSchedule.Size = New System.Drawing.Size(120, 19)
        Me.btnShowSchedule.TabIndex = 7
        Me.btnShowSchedule.Text = "Schedule"
        Me.btnShowSchedule.UseVisualStyleBackColor = False
        '
        'btnShowJobComm
        '
        Me.btnShowJobComm.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShowJobComm.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowJobComm.ForeColor = System.Drawing.Color.Black
        Me.btnShowJobComm.Location = New System.Drawing.Point(0, 0)
        Me.btnShowJobComm.Name = "btnShowJobComm"
        Me.btnShowJobComm.Size = New System.Drawing.Size(120, 19)
        Me.btnShowJobComm.TabIndex = 13
        Me.btnShowJobComm.Text = "Job"
        Me.btnShowJobComm.UseVisualStyleBackColor = False
        '
        'c1Sizer1
        '
        Me.c1Sizer1.Controls.Add(Me.C1Calendar1)
        Me.c1Sizer1.Controls.Add(Me.flexSWO)
        Me.c1Sizer1.Controls.Add(Me.lblSWO)
        Me.c1Sizer1.Controls.Add(Me.flexOnHold)
        Me.c1Sizer1.Controls.Add(Me.lblOnHold)
        Me.c1Sizer1.Controls.Add(Me.pnlCustomSearch)
        Me.c1Sizer1.Controls.Add(Me.lblCustomSearch)
        Me.c1Sizer1.Controls.Add(Me.flexNeedAttention)
        Me.c1Sizer1.Controls.Add(Me.lblNeedsAttention)
        Me.c1Sizer1.Controls.Add(Me.pictureBox3)
        Me.c1Sizer1.Controls.Add(Me.pictureBox4)
        Me.c1Sizer1.Location = New System.Drawing.Point(3, 26)
        Me.c1Sizer1.Name = "c1Sizer1"
        Me.c1Sizer1.Size = New System.Drawing.Size(308, 639)
        Me.c1Sizer1.TabIndex = 0
        '
        'C1Calendar1
        '
        Me.C1Calendar1.BoldedDates = New Date(-1) {}
        '
        '
        '
        Me.C1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00")
        Me.C1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00")
        Me.C1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
        Me.C1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday
        Me.C1Calendar1.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday})
        Me.C1Calendar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1Calendar1.Location = New System.Drawing.Point(0, 533)
        Me.C1Calendar1.Name = "C1Calendar1"
        Me.C1Calendar1.ShowWeekNumbers = False
        Me.C1Calendar1.Size = New System.Drawing.Size(308, 180)
        Me.C1Calendar1.TabIndex = 7
        '
        'flexSWO
        '
        Me.flexSWO.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.flexSWO.AllowEditing = False
        Me.flexSWO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.flexSWO.ColumnInfo = "1,0,0,0,0,85,Columns:0{Width:509;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.flexSWO.ContextMenuStrip = Me.ContextMenuStrip1
        Me.flexSWO.Dock = System.Windows.Forms.DockStyle.Top
        Me.flexSWO.Location = New System.Drawing.Point(0, 422)
        Me.flexSWO.Name = "flexSWO"
        Me.flexSWO.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.flexSWO.Rows.DefaultSize = 17
        Me.flexSWO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.flexSWO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.flexSWO.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.flexSWO.Size = New System.Drawing.Size(308, 111)
        Me.flexSWO.TabIndex = 3
        '
        'lblSWO
        '
        Me.lblSWO.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSWO.Location = New System.Drawing.Point(0, 408)
        Me.lblSWO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSWO.Name = "lblSWO"
        Me.lblSWO.Size = New System.Drawing.Size(308, 14)
        Me.lblSWO.TabIndex = 16
        Me.lblSWO.Text = "SWO"
        Me.lblSWO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'flexOnHold
        '
        Me.flexOnHold.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.flexOnHold.AllowEditing = False
        Me.flexOnHold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.flexOnHold.ColumnInfo = "1,0,0,0,0,85,Columns:0{Width:509;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.flexOnHold.ContextMenuStrip = Me.ContextMenuStrip1
        Me.flexOnHold.Dock = System.Windows.Forms.DockStyle.Top
        Me.flexOnHold.Location = New System.Drawing.Point(0, 297)
        Me.flexOnHold.Name = "flexOnHold"
        Me.flexOnHold.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.flexOnHold.Rows.DefaultSize = 17
        Me.flexOnHold.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.flexOnHold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.flexOnHold.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.flexOnHold.Size = New System.Drawing.Size(308, 111)
        Me.flexOnHold.TabIndex = 2
        '
        'lblOnHold
        '
        Me.lblOnHold.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOnHold.Location = New System.Drawing.Point(0, 283)
        Me.lblOnHold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOnHold.Name = "lblOnHold"
        Me.lblOnHold.Size = New System.Drawing.Size(308, 14)
        Me.lblOnHold.TabIndex = 15
        Me.lblOnHold.Text = "On Hold"
        Me.lblOnHold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlCustomSearch
        '
        Me.pnlCustomSearch.Controls.Add(Me.flexSearch)
        Me.pnlCustomSearch.Controls.Add(Me.txtSearch)
        Me.pnlCustomSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustomSearch.Location = New System.Drawing.Point(0, 175)
        Me.pnlCustomSearch.Name = "pnlCustomSearch"
        Me.pnlCustomSearch.Size = New System.Drawing.Size(308, 108)
        Me.pnlCustomSearch.TabIndex = 8
        '
        'flexSearch
        '
        Me.flexSearch.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.flexSearch.AllowEditing = False
        Me.flexSearch.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.flexSearch.ColumnInfo = "1,0,0,0,0,85,Columns:0{Width:250;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.flexSearch.ContextMenuStrip = Me.ContextMenuStrip1
        Me.flexSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flexSearch.DragMode = C1.Win.C1FlexGrid.DragModeEnum.Automatic
        Me.flexSearch.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.flexSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.flexSearch.Location = New System.Drawing.Point(0, 20)
        Me.flexSearch.Name = "flexSearch"
        Me.flexSearch.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.flexSearch.Rows.DefaultSize = 21
        Me.flexSearch.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.flexSearch.ShowErrors = True
        Me.flexSearch.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.flexSearch.Size = New System.Drawing.Size(308, 88)
        Me.flexSearch.StyleInfo = resources.GetString("flexSearch.StyleInfo")
        Me.flexSearch.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(308, 20)
        Me.txtSearch.TabIndex = 0
        '
        'lblCustomSearch
        '
        Me.lblCustomSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCustomSearch.Location = New System.Drawing.Point(0, 161)
        Me.lblCustomSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomSearch.Name = "lblCustomSearch"
        Me.lblCustomSearch.Size = New System.Drawing.Size(308, 14)
        Me.lblCustomSearch.TabIndex = 15
        Me.lblCustomSearch.Text = "Search"
        Me.lblCustomSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNeedsAttention
        '
        Me.lblNeedsAttention.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNeedsAttention.Location = New System.Drawing.Point(0, 0)
        Me.lblNeedsAttention.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNeedsAttention.Name = "lblNeedsAttention"
        Me.lblNeedsAttention.Size = New System.Drawing.Size(308, 14)
        Me.lblNeedsAttention.TabIndex = 15
        Me.lblNeedsAttention.Text = "Needs Attention"
        Me.lblNeedsAttention.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.Khaki
        Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pictureBox3.Location = New System.Drawing.Point(0, 419)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(308, 110)
        Me.pictureBox3.TabIndex = 0
        Me.pictureBox3.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.LemonChiffon
        Me.pictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pictureBox4.Location = New System.Drawing.Point(0, 529)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(308, 110)
        Me.pictureBox4.TabIndex = 0
        Me.pictureBox4.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox5.Image = CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image)
        Me.pictureBox5.Location = New System.Drawing.Point(1210, 8)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(14, 14)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox5.TabIndex = 6
        Me.pictureBox5.TabStop = False
        Me.pictureBox5.Visible = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image)
        Me.pictureBox6.Location = New System.Drawing.Point(1257, 8)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox6.TabIndex = 5
        Me.pictureBox6.TabStop = False
        Me.pictureBox6.Visible = False
        '
        'pictureBox7
        '
        Me.pictureBox7.Image = CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image)
        Me.pictureBox7.Location = New System.Drawing.Point(1230, 8)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(24, 24)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox7.TabIndex = 4
        Me.pictureBox7.TabStop = False
        Me.pictureBox7.Visible = False
        '
        'C1Sizer2
        '
        Me.C1Sizer2.Controls.Add(Me.c1Sizer1)
        Me.C1Sizer2.Controls.Add(Me.pnlTopButtons)
        Me.C1Sizer2.Controls.Add(Me.CtrFullSchedule1)
        Me.C1Sizer2.Controls.Add(Me.CtrJobComm1)
        Me.C1Sizer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer2.GridDefinition = "2.84431137724551:False:False;39.9700598802395:False:False;55.0898203592814:False:" & _
    "False;" & Global.Microsoft.VisualBasic.ChrW(9) & "24.0437158469945:False:False;44.184231069477:False:False;30.6791569086651" & _
    ":False:False;"
        Me.C1Sizer2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer2.Location = New System.Drawing.Point(0, 0)
        Me.C1Sizer2.Name = "C1Sizer2"
        Me.C1Sizer2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.C1Sizer2.Size = New System.Drawing.Size(1281, 668)
        Me.C1Sizer2.TabIndex = 15
        Me.C1Sizer2.TabStop = False
        '
        'CtrFullSchedule1
        '
        Me.CtrFullSchedule1.AllowDrop = True
        Me.CtrFullSchedule1.Location = New System.Drawing.Point(885, 26)
        Me.CtrFullSchedule1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CtrFullSchedule1.Name = "CtrFullSchedule1"
        Me.CtrFullSchedule1.Size = New System.Drawing.Size(393, 639)
        Me.CtrFullSchedule1.TabIndex = 12
        '
        'CtrJobComm1
        '
        Me.CtrJobComm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CtrJobComm1.Enabled = False
        Me.CtrJobComm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrJobComm1.Location = New System.Drawing.Point(315, 26)
        Me.CtrJobComm1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CtrJobComm1.Name = "CtrJobComm1"
        Me.CtrJobComm1.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CtrJobComm1.Size = New System.Drawing.Size(566, 639)
        Me.CtrJobComm1.TabIndex = 11
        '
        'ds1
        '
        Me.ds1.DataSetName = "TKSIJOBSDataSet"
        Me.ds1.EnforceConstraints = False
        Me.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TJobTableAdapter1
        '
        Me.TJobTableAdapter1.ClearBeforeFill = True
        '
        'TPOHeaderTableAdapter1
        '
        Me.TPOHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TCustomrTableAdapter
        '
        Me.TCustomrTableAdapter.ClearBeforeFill = True
        '
        'TVendorTableAdapter
        '
        Me.TVendorTableAdapter.ClearBeforeFill = True
        '
        'TblJobActivityTableAdapter1
        '
        Me.TblJobActivityTableAdapter1.ClearBeforeFill = True
        '
        'TblActivityTypeTableAdapter1
        '
        Me.TblActivityTypeTableAdapter1.ClearBeforeFill = True
        '
        'AppointmentsTableAdapter1
        '
        Me.AppointmentsTableAdapter1.ClearBeforeFill = True
        '
        'TAddressTableAdapter1
        '
        Me.TAddressTableAdapter1.ClearBeforeFill = True
        '
        'TblInstallerDatesTableAdapter1
        '
        Me.TblInstallerDatesTableAdapter1.ClearBeforeFill = True
        '
        'frmScheduleJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1172, 685)
        Me.Controls.Add(Me.C1Sizer2)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.pictureBox7)
        Me.Name = "frmScheduleJobs"
        Me.Text = "Schedule Jobs"
        CType(Me.flexNeedAttention, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlTopButtons.ResumeLayout(False)
        Me.c1Sizer1.ResumeLayout(False)
        CType(Me.C1Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flexSWO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flexOnHold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomSearch.ResumeLayout(False)
        Me.pnlCustomSearch.PerformLayout()
        CType(Me.flexSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Sizer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer2.ResumeLayout(False)
        CType(Me.ds1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents c1Sizer1 As System.Windows.Forms.Panel 'C1.Win.C1Sizer.C1Sizer
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox6 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents flexNeedAttention As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ds1 As TKSISchedule.TKSIJOBSDataSet
    Friend WithEvents TJobTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter
    Friend WithEvents TPOHeaderTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter
    Friend WithEvents flexSWO As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents flexOnHold As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CtrJobComm1 As TKSISchedule.ctrJobComm
    Friend WithEvents TCustomrTableAdapter As TKSISchedule.TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter
    Friend WithEvents TVendorTableAdapter As TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter
    'Friend WithEvents C1Calendar1 As C1.Win.C1Schedule.C1Calendar
    Friend WithEvents CtrFullSchedule1 As TKSISchedule.ctrFullSchedule
    Friend WithEvents btnShowSchedule As System.Windows.Forms.Button
    Friend WithEvents pnlTopButtons As System.Windows.Forms.Panel
    Friend WithEvents btnShowJobComm As System.Windows.Forms.Button
    Friend WithEvents TblJobActivityTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents TblActivityTypeTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblActivityTypeTableAdapter
    Friend WithEvents C1Calendar1 As C1.Win.C1Schedule.C1Calendar
    Friend WithEvents AppointmentsTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents C1Sizer2 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlCustomSearch As System.Windows.Forms.Panel
    Friend WithEvents flexSearch As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents TAddressTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tAddressTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuOpenJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TblInstallerDatesTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblInstallerDatesTableAdapter
    Friend WithEvents lblNeedsAttention As System.Windows.Forms.Label
    Friend WithEvents lblOnHold As System.Windows.Forms.Label
    Friend WithEvents lblCustomSearch As System.Windows.Forms.Label
    Friend WithEvents lblSWO As System.Windows.Forms.Label

End Class
