Option Strict Off
Option Explicit On
Imports System.Windows.Forms

Imports C1.Win.C1FlexGrid.Classic
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Threading
'Imports Instrumentation
'Imports openTwain
Imports WIA
'Imports TKSISchedule.TwainLib

Friend Class JobEdit
    Inherits System.Windows.Forms.Form
    'Implements IMessageFilter

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.sqlConn.ConnectionString = cnSQL

    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents txtJobTaxRate As System.Windows.Forms.TextBox
    Public WithEvents gridInvoices As C1FlexGridClassic
    Public WithEvents cmdDelJob As System.Windows.Forms.Button
    Public WithEvents cmdAddJob As System.Windows.Forms.Button
    Public WithEvents gridJobLoc As C1FlexGridClassic
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents cmdCommStruct As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button
    Public WithEvents cmdPOBalance As System.Windows.Forms.Button
    Public WithEvents cmdInvBalance As System.Windows.Forms.Button
    Public WithEvents txtInvBalance As System.Windows.Forms.TextBox
    Public WithEvents cmdAddInv As System.Windows.Forms.Button
    Public WithEvents cmdAddPO As System.Windows.Forms.Button
    Public WithEvents txtInvNotes As System.Windows.Forms.TextBox
    Public WithEvents cmdJobComSheet As System.Windows.Forms.Button
    Public WithEvents txtDesc As System.Windows.Forms.TextBox
    Public WithEvents txtOther As System.Windows.Forms.TextBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents lblDesc As System.Windows.Forms.Label
    Public WithEvents Picture4 As System.Windows.Forms.Panel
    Public WithEvents cmdSetTaxRate As System.Windows.Forms.Button
    Public WithEvents txtJobLabor As System.Windows.Forms.TextBox
    Public WithEvents txtJobMaterials As System.Windows.Forms.TextBox
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txtJobTotal As System.Windows.Forms.Label
    Public WithEvents Picture2 As System.Windows.Forms.Panel
    Public WithEvents txtBalance As System.Windows.Forms.TextBox
    Public WithEvents txtPhone As System.Windows.Forms.TextBox
    Public WithEvents cmbSalesper As System.Windows.Forms.ComboBox
    Public WithEvents cmbTerms As System.Windows.Forms.ComboBox
    Public WithEvents txtDrawingDate As System.Windows.Forms.TextBox
    Public WithEvents txtContact As System.Windows.Forms.TextBox
    Public WithEvents txtContractDate As System.Windows.Forms.TextBox
    Public WithEvents txtJobNo As System.Windows.Forms.TextBox
    Public WithEvents txtPermit As System.Windows.Forms.TextBox
    Public WithEvents cmbDisclaimer As System.Windows.Forms.ComboBox
    Public WithEvents cmbDrawing As System.Windows.Forms.ComboBox
    Public WithEvents cmbContract As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblSalesper As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lblContratd As System.Windows.Forms.Label
    Public WithEvents ContractLabel As System.Windows.Forms.Label
    Public WithEvents PermitLabel As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Picture3 As System.Windows.Forms.Panel
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents lblCreditUsed As System.Windows.Forms.Label
    Public WithEvents lblCreditLimit As System.Windows.Forms.Label
    Public WithEvents lblCustomer As System.Windows.Forms.Label
    Public WithEvents picStep1 As System.Windows.Forms.Panel
    Private WithEvents DsTKSI1 As TKSISchedule.dsTKSI
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents daLocationBins As System.Data.SqlClient.SqlDataAdapter
    Private WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Private WithEvents daLocationJOIN As System.Data.SqlClient.SqlDataAdapter
    Private WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents lblJobMargin As System.Windows.Forms.Label
    Friend WithEvents pnlLarge As System.Windows.Forms.Panel
    Friend WithEvents lvImages As System.Windows.Forms.ListView
    Private WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlScanbutton As System.Windows.Forms.Panel
    Friend WithEvents pnlCheckBoxes As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteImage As System.Windows.Forms.Button
    Friend WithEvents btnAttachImg As System.Windows.Forms.Button
    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chk11x17 As System.Windows.Forms.CheckBox
    Friend WithEvents lvJobSite As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents lblJobActivityNotes As System.Windows.Forms.Label
    Friend WithEvents TblJobActivityDataGridView As System.Windows.Forms.DataGridView
    Private WithEvents TblJobActivityBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents TKSIJOBSDataSet As TKSISchedule.TKSIJOBSDataSet
    Private WithEvents TblActivityTypeTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblActivityTypeTableAdapter
    Private WithEvents TblJobActivityTableAdapter As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents PrintDocument8x11 As System.Drawing.Printing.PrintDocument
    Friend WithEvents GIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NJobIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateEnteredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents PrintDocument11x17 As System.Drawing.Printing.PrintDocument
    Public WithEvents btnAddSWO As System.Windows.Forms.Button
    Public WithEvents btnSWODelete As System.Windows.Forms.Button
    Public WithEvents lblSWOPending As System.Windows.Forms.Label
    Friend WithEvents lvSWOPending As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TblSWOPendingTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOPendingTableAdapter
    Friend WithEvents TJobTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter
    Friend WithEvents TSOHeaderTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tSOHeaderTableAdapter
    Friend WithEvents TSOLineTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tSOLineTableAdapter
    Friend WithEvents TblCommissionStructureTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblCommissionStructureTableAdapter
    Friend WithEvents chkSplitComm As System.Windows.Forms.CheckBox
    Public WithEvents lblNoJobSelected As System.Windows.Forms.Label
    Friend WithEvents chkMap As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobEdit))
        Me.txtJobTaxRate = New System.Windows.Forms.TextBox()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.cmdDelJob = New System.Windows.Forms.Button()
        Me.cmdAddJob = New System.Windows.Forms.Button()
        Me.gridInvoices = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.gridJobLoc = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddSWO = New System.Windows.Forms.Button()
        Me.btnSWODelete = New System.Windows.Forms.Button()
        Me.lblSWOPending = New System.Windows.Forms.Label()
        Me.lvSWOPending = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.picStep1 = New System.Windows.Forms.Panel()
        Me.cmdCommStruct = New System.Windows.Forms.Button()
        Me.cmdPOBalance = New System.Windows.Forms.Button()
        Me.cmdInvBalance = New System.Windows.Forms.Button()
        Me.txtInvBalance = New System.Windows.Forms.TextBox()
        Me.cmdAddPO = New System.Windows.Forms.Button()
        Me.Picture4 = New System.Windows.Forms.Panel()
        Me.lblJobActivityNotes = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TblJobActivityDataGridView = New System.Windows.Forms.DataGridView()
        Me.GIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NJobIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEnteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblJobActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TKSIJOBSDataSet = New TKSISchedule.TKSIJOBSDataSet()
        Me.lvJobSite = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtInvNotes = New System.Windows.Forms.TextBox()
        Me.cmdJobComSheet = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.cmdAddInv = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Picture2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblJobMargin = New System.Windows.Forms.Label()
        Me.cmdSetTaxRate = New System.Windows.Forms.Button()
        Me.txtJobLabor = New System.Windows.Forms.TextBox()
        Me.txtJobMaterials = New System.Windows.Forms.TextBox()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJobTotal = New System.Windows.Forms.Label()
        Me.lblCreditLimit = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCreditUsed = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Picture3 = New System.Windows.Forms.Panel()
        Me.chkSplitComm = New System.Windows.Forms.CheckBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbSalesper = New System.Windows.Forms.ComboBox()
        Me.cmbTerms = New System.Windows.Forms.ComboBox()
        Me.txtDrawingDate = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtContractDate = New System.Windows.Forms.TextBox()
        Me.txtJobNo = New System.Windows.Forms.TextBox()
        Me.txtPermit = New System.Windows.Forms.TextBox()
        Me.cmbDisclaimer = New System.Windows.Forms.ComboBox()
        Me.cmbDrawing = New System.Windows.Forms.ComboBox()
        Me.cmbContract = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSalesper = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblContratd = New System.Windows.Forms.Label()
        Me.ContractLabel = New System.Windows.Forms.Label()
        Me.PermitLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.daLocationBins = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.daLocationJOIN = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.pnlLarge = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlScanbutton = New System.Windows.Forms.Panel()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.pnlCheckBoxes = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.chk11x17 = New System.Windows.Forms.CheckBox()
        Me.chkMap = New System.Windows.Forms.CheckBox()
        Me.btnAttachImg = New System.Windows.Forms.Button()
        Me.btnDeleteImage = New System.Windows.Forms.Button()
        Me.lvImages = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TblActivityTypeTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblActivityTypeTableAdapter()
        Me.TblJobActivityTableAdapter = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.PrintDocument8x11 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument11x17 = New System.Drawing.Printing.PrintDocument()
        Me.TblSWOPendingTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOPendingTableAdapter()
        Me.TJobTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter()
        Me.TSOHeaderTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tSOHeaderTableAdapter()
        Me.TSOLineTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tSOLineTableAdapter()
        Me.TblCommissionStructureTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblCommissionStructureTableAdapter()
        Me.lblNoJobSelected = New System.Windows.Forms.Label()
        Me.Picture1.SuspendLayout()
        CType(Me.gridInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridJobLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picStep1.SuspendLayout()
        Me.Picture4.SuspendLayout()
        CType(Me.TblJobActivityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TKSIJOBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture2.SuspendLayout()
        Me.Picture3.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLarge.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlScanbutton.SuspendLayout()
        Me.pnlCheckBoxes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJobTaxRate
        '
        Me.txtJobTaxRate.AcceptsReturn = True
        Me.txtJobTaxRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobTaxRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobTaxRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobTaxRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobTaxRate.Location = New System.Drawing.Point(112, 96)
        Me.txtJobTaxRate.MaxLength = 0
        Me.txtJobTaxRate.Name = "txtJobTaxRate"
        Me.txtJobTaxRate.ReadOnly = True
        Me.txtJobTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobTaxRate.Size = New System.Drawing.Size(46, 22)
        Me.txtJobTaxRate.TabIndex = 15
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture1.Controls.Add(Me.cmdDelJob)
        Me.Picture1.Controls.Add(Me.cmdAddJob)
        Me.Picture1.Controls.Add(Me.gridInvoices)
        Me.Picture1.Controls.Add(Me.gridJobLoc)
        Me.Picture1.Controls.Add(Me.Label3)
        Me.Picture1.Controls.Add(Me.Label2)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Location = New System.Drawing.Point(0, 0)
        Me.Picture1.Margin = New System.Windows.Forms.Padding(2)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(288, 686)
        Me.Picture1.TabIndex = 19
        Me.Picture1.TabStop = True
        '
        'cmdDelJob
        '
        Me.cmdDelJob.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelJob.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelJob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelJob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelJob.Location = New System.Drawing.Point(8, 390)
        Me.cmdDelJob.Name = "cmdDelJob"
        Me.cmdDelJob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelJob.Size = New System.Drawing.Size(90, 26)
        Me.cmdDelJob.TabIndex = 22
        Me.cmdDelJob.Text = "Delete Job"
        Me.cmdDelJob.UseVisualStyleBackColor = False
        '
        'cmdAddJob
        '
        Me.cmdAddJob.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddJob.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddJob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddJob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddJob.Location = New System.Drawing.Point(103, 390)
        Me.cmdAddJob.Name = "cmdAddJob"
        Me.cmdAddJob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddJob.Size = New System.Drawing.Size(80, 26)
        Me.cmdAddJob.TabIndex = 28
        Me.cmdAddJob.Text = "Add Job"
        Me.cmdAddJob.UseVisualStyleBackColor = False
        '
        'gridInvoices
        '
        Me.gridInvoices.Cols = 5
        Me.gridInvoices.ColumnInfo = "5,0,0,0,0,100,Columns:"
        Me.gridInvoices.FixedCols = 0
        Me.gridInvoices.FixedRows = 0
        Me.gridInvoices.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridInvoices.Location = New System.Drawing.Point(8, 501)
        Me.gridInvoices.Name = "gridInvoices"
        Me.gridInvoices.NodeClosedPicture = Nothing
        Me.gridInvoices.NodeOpenPicture = Nothing
        Me.gridInvoices.OutlineCol = -1
        Me.gridInvoices.Size = New System.Drawing.Size(272, 93)
        Me.gridInvoices.StyleInfo = resources.GetString("gridInvoices.StyleInfo")
        Me.gridInvoices.TabIndex = 45
        Me.gridInvoices.TreeColor = System.Drawing.Color.DarkGray
        '
        'gridJobLoc
        '
        Me.gridJobLoc.BackColorSel = System.Drawing.Color.Yellow
        Me.gridJobLoc.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridJobLoc.FixedCols = 0
        Me.gridJobLoc.FixedRows = 0
        Me.gridJobLoc.ForeColorSel = System.Drawing.Color.Black
        Me.gridJobLoc.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridJobLoc.Location = New System.Drawing.Point(8, 48)
        Me.gridJobLoc.Name = "gridJobLoc"
        Me.gridJobLoc.NodeClosedPicture = Nothing
        Me.gridJobLoc.NodeOpenPicture = Nothing
        Me.gridJobLoc.OutlineCol = -1
        Me.gridJobLoc.Size = New System.Drawing.Size(272, 329)
        Me.gridJobLoc.StyleInfo = resources.GetString("gridJobLoc.StyleInfo")
        Me.gridJobLoc.TabIndex = 0
        Me.gridJobLoc.TreeColor = System.Drawing.Color.DarkGray
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(8, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(185, 25)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Job Invoice's"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(272, 31)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "JOB PO's"
        '
        'btnAddSWO
        '
        Me.btnAddSWO.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddSWO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAddSWO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSWO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddSWO.Location = New System.Drawing.Point(382, 567)
        Me.btnAddSWO.Name = "btnAddSWO"
        Me.btnAddSWO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddSWO.Size = New System.Drawing.Size(98, 26)
        Me.btnAddSWO.TabIndex = 50
        Me.btnAddSWO.Text = "Add SWO"
        Me.btnAddSWO.UseVisualStyleBackColor = False
        '
        'btnSWODelete
        '
        Me.btnSWODelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnSWODelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSWODelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSWODelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSWODelete.Location = New System.Drawing.Point(382, 596)
        Me.btnSWODelete.Name = "btnSWODelete"
        Me.btnSWODelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSWODelete.Size = New System.Drawing.Size(98, 26)
        Me.btnSWODelete.TabIndex = 47
        Me.btnSWODelete.Text = "Delete"
        Me.btnSWODelete.UseVisualStyleBackColor = False
        '
        'lblSWOPending
        '
        Me.lblSWOPending.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblSWOPending.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSWOPending.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSWOPending.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblSWOPending.Location = New System.Drawing.Point(14, 551)
        Me.lblSWOPending.Name = "lblSWOPending"
        Me.lblSWOPending.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSWOPending.Size = New System.Drawing.Size(263, 23)
        Me.lblSWOPending.TabIndex = 46
        Me.lblSWOPending.Text = "Pending SWO / Parts"
        '
        'lvSWOPending
        '
        Me.lvSWOPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSWOPending.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvSWOPending.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSWOPending.FullRowSelect = True
        Me.lvSWOPending.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvSWOPending.HideSelection = False
        Me.lvSWOPending.Location = New System.Drawing.Point(13, 573)
        Me.lvSWOPending.Name = "lvSWOPending"
        Me.lvSWOPending.Size = New System.Drawing.Size(364, 102)
        Me.lvSWOPending.TabIndex = 51
        Me.lvSWOPending.UseCompatibleStateImageBehavior = False
        Me.lvSWOPending.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = ""
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 260
        '
        'picStep1
        '
        Me.picStep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picStep1.Controls.Add(Me.cmdCommStruct)
        Me.picStep1.Controls.Add(Me.btnAddSWO)
        Me.picStep1.Controls.Add(Me.cmdPOBalance)
        Me.picStep1.Controls.Add(Me.btnSWODelete)
        Me.picStep1.Controls.Add(Me.cmdInvBalance)
        Me.picStep1.Controls.Add(Me.txtInvBalance)
        Me.picStep1.Controls.Add(Me.cmdAddPO)
        Me.picStep1.Controls.Add(Me.Picture4)
        Me.picStep1.Controls.Add(Me.Picture2)
        Me.picStep1.Controls.Add(Me.lvSWOPending)
        Me.picStep1.Controls.Add(Me.txtBalance)
        Me.picStep1.Controls.Add(Me.Picture3)
        Me.picStep1.Controls.Add(Me.lblCustomer)
        Me.picStep1.Controls.Add(Me.lblSWOPending)
        Me.picStep1.Cursor = System.Windows.Forms.Cursors.Default
        Me.picStep1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picStep1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picStep1.Location = New System.Drawing.Point(288, 0)
        Me.picStep1.Margin = New System.Windows.Forms.Padding(2)
        Me.picStep1.Name = "picStep1"
        Me.picStep1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picStep1.Size = New System.Drawing.Size(528, 690)
        Me.picStep1.TabIndex = 18
        Me.picStep1.TabStop = True
        '
        'cmdCommStruct
        '
        Me.cmdCommStruct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCommStruct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCommStruct.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommStruct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCommStruct.Location = New System.Drawing.Point(296, 461)
        Me.cmdCommStruct.Name = "cmdCommStruct"
        Me.cmdCommStruct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCommStruct.Size = New System.Drawing.Size(98, 26)
        Me.cmdCommStruct.TabIndex = 27
        Me.cmdCommStruct.Text = "Comm Structre: "
        Me.cmdCommStruct.UseVisualStyleBackColor = False
        '
        'cmdPOBalance
        '
        Me.cmdPOBalance.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPOBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPOBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPOBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPOBalance.Location = New System.Drawing.Point(296, 516)
        Me.cmdPOBalance.Name = "cmdPOBalance"
        Me.cmdPOBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPOBalance.Size = New System.Drawing.Size(82, 26)
        Me.cmdPOBalance.TabIndex = 26
        Me.cmdPOBalance.Text = "PO Balance"
        Me.cmdPOBalance.UseVisualStyleBackColor = False
        '
        'cmdInvBalance
        '
        Me.cmdInvBalance.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInvBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInvBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInvBalance.Location = New System.Drawing.Point(296, 489)
        Me.cmdInvBalance.Name = "cmdInvBalance"
        Me.cmdInvBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInvBalance.Size = New System.Drawing.Size(82, 26)
        Me.cmdInvBalance.TabIndex = 25
        Me.cmdInvBalance.Text = "Inv. Balance"
        Me.cmdInvBalance.UseVisualStyleBackColor = False
        '
        'txtInvBalance
        '
        Me.txtInvBalance.AcceptsReturn = True
        Me.txtInvBalance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtInvBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvBalance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvBalance.ForeColor = System.Drawing.SystemColors.Window
        Me.txtInvBalance.Location = New System.Drawing.Point(379, 492)
        Me.txtInvBalance.MaxLength = 0
        Me.txtInvBalance.Name = "txtInvBalance"
        Me.txtInvBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInvBalance.Size = New System.Drawing.Size(128, 21)
        Me.txtInvBalance.TabIndex = 49
        '
        'cmdAddPO
        '
        Me.cmdAddPO.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddPO.Location = New System.Drawing.Point(296, 382)
        Me.cmdAddPO.Name = "cmdAddPO"
        Me.cmdAddPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddPO.Size = New System.Drawing.Size(98, 26)
        Me.cmdAddPO.TabIndex = 21
        Me.cmdAddPO.Text = "Add PO"
        Me.cmdAddPO.UseVisualStyleBackColor = False
        '
        'Picture4
        '
        Me.Picture4.BackColor = System.Drawing.Color.White
        Me.Picture4.Controls.Add(Me.lblJobActivityNotes)
        Me.Picture4.Controls.Add(Me.cmdSave)
        Me.Picture4.Controls.Add(Me.TblJobActivityDataGridView)
        Me.Picture4.Controls.Add(Me.lvJobSite)
        Me.Picture4.Controls.Add(Me.txtInvNotes)
        Me.Picture4.Controls.Add(Me.cmdJobComSheet)
        Me.Picture4.Controls.Add(Me.txtDesc)
        Me.Picture4.Controls.Add(Me.txtOther)
        Me.Picture4.Controls.Add(Me.cmdAddInv)
        Me.Picture4.Controls.Add(Me.Label17)
        Me.Picture4.Controls.Add(Me.Label16)
        Me.Picture4.Controls.Add(Me.lblDesc)
        Me.Picture4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture4.Location = New System.Drawing.Point(288, 48)
        Me.Picture4.Name = "Picture4"
        Me.Picture4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture4.Size = New System.Drawing.Size(225, 396)
        Me.Picture4.TabIndex = 2
        Me.Picture4.TabStop = True
        '
        'lblJobActivityNotes
        '
        Me.lblJobActivityNotes.BackColor = System.Drawing.SystemColors.Control
        Me.lblJobActivityNotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblJobActivityNotes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobActivityNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJobActivityNotes.Location = New System.Drawing.Point(8, 222)
        Me.lblJobActivityNotes.Name = "lblJobActivityNotes"
        Me.lblJobActivityNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblJobActivityNotes.Size = New System.Drawing.Size(209, 17)
        Me.lblJobActivityNotes.TabIndex = 63
        Me.lblJobActivityNotes.Text = "Job Activity/Delivery Notes"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(111, 334)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(98, 26)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'TblJobActivityDataGridView
        '
        Me.TblJobActivityDataGridView.AutoGenerateColumns = False
        Me.TblJobActivityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GIDDataGridViewTextBoxColumn, Me.NJobIDDataGridViewTextBoxColumn, Me.DateEnteredDataGridViewTextBoxColumn, Me.ActivityTypeDataGridViewTextBoxColumn, Me.ActivityDetailDataGridViewTextBoxColumn, Me.OtherDataGridViewTextBoxColumn})
        Me.TblJobActivityDataGridView.DataSource = Me.TblJobActivityBindingSource
        Me.TblJobActivityDataGridView.Location = New System.Drawing.Point(8, 240)
        Me.TblJobActivityDataGridView.Name = "TblJobActivityDataGridView"
        Me.TblJobActivityDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TblJobActivityDataGridView.RowHeadersVisible = False
        Me.TblJobActivityDataGridView.Size = New System.Drawing.Size(209, 78)
        Me.TblJobActivityDataGridView.TabIndex = 62
        '
        'GIDDataGridViewTextBoxColumn
        '
        Me.GIDDataGridViewTextBoxColumn.DataPropertyName = "gID"
        Me.GIDDataGridViewTextBoxColumn.HeaderText = "gID"
        Me.GIDDataGridViewTextBoxColumn.Name = "GIDDataGridViewTextBoxColumn"
        Me.GIDDataGridViewTextBoxColumn.Visible = False
        '
        'NJobIDDataGridViewTextBoxColumn
        '
        Me.NJobIDDataGridViewTextBoxColumn.DataPropertyName = "nJobID"
        Me.NJobIDDataGridViewTextBoxColumn.HeaderText = "nJobID"
        Me.NJobIDDataGridViewTextBoxColumn.Name = "NJobIDDataGridViewTextBoxColumn"
        Me.NJobIDDataGridViewTextBoxColumn.Visible = False
        '
        'DateEnteredDataGridViewTextBoxColumn
        '
        Me.DateEnteredDataGridViewTextBoxColumn.DataPropertyName = "dateEntered"
        Me.DateEnteredDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateEnteredDataGridViewTextBoxColumn.Name = "DateEnteredDataGridViewTextBoxColumn"
        Me.DateEnteredDataGridViewTextBoxColumn.Width = 50
        '
        'ActivityTypeDataGridViewTextBoxColumn
        '
        Me.ActivityTypeDataGridViewTextBoxColumn.DataPropertyName = "ActivityType"
        Me.ActivityTypeDataGridViewTextBoxColumn.HeaderText = "ActivityType"
        Me.ActivityTypeDataGridViewTextBoxColumn.Name = "ActivityTypeDataGridViewTextBoxColumn"
        Me.ActivityTypeDataGridViewTextBoxColumn.Visible = False
        '
        'ActivityDetailDataGridViewTextBoxColumn
        '
        Me.ActivityDetailDataGridViewTextBoxColumn.DataPropertyName = "ActivityDetail"
        Me.ActivityDetailDataGridViewTextBoxColumn.HeaderText = "ActivityDetail"
        Me.ActivityDetailDataGridViewTextBoxColumn.Name = "ActivityDetailDataGridViewTextBoxColumn"
        Me.ActivityDetailDataGridViewTextBoxColumn.Width = 140
        '
        'OtherDataGridViewTextBoxColumn
        '
        Me.OtherDataGridViewTextBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewTextBoxColumn.Name = "OtherDataGridViewTextBoxColumn"
        Me.OtherDataGridViewTextBoxColumn.Visible = False
        '
        'TblJobActivityBindingSource
        '
        Me.TblJobActivityBindingSource.DataMember = "tblJobActivity"
        Me.TblJobActivityBindingSource.DataSource = Me.TKSIJOBSDataSet
        '
        'TKSIJOBSDataSet
        '
        Me.TKSIJOBSDataSet.DataSetName = "TKSIJOBSDataSet"
        Me.TKSIJOBSDataSet.EnforceConstraints = False
        Me.TKSIJOBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvJobSite
        '
        Me.lvJobSite.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvJobSite.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvJobSite.Location = New System.Drawing.Point(9, 6)
        Me.lvJobSite.Name = "lvJobSite"
        Me.lvJobSite.Size = New System.Drawing.Size(207, 56)
        Me.lvJobSite.TabIndex = 61
        Me.lvJobSite.UseCompatibleStateImageBehavior = False
        Me.lvJobSite.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 180
        '
        'txtInvNotes
        '
        Me.txtInvNotes.AcceptsReturn = True
        Me.txtInvNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtInvNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvNotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvNotes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvNotes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInvNotes.Location = New System.Drawing.Point(8, 195)
        Me.txtInvNotes.MaxLength = 0
        Me.txtInvNotes.Name = "txtInvNotes"
        Me.txtInvNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInvNotes.Size = New System.Drawing.Size(209, 20)
        Me.txtInvNotes.TabIndex = 20
        '
        'cmdJobComSheet
        '
        Me.cmdJobComSheet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdJobComSheet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdJobComSheet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJobComSheet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdJobComSheet.Location = New System.Drawing.Point(111, 362)
        Me.cmdJobComSheet.Name = "cmdJobComSheet"
        Me.cmdJobComSheet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdJobComSheet.Size = New System.Drawing.Size(98, 26)
        Me.cmdJobComSheet.TabIndex = 24
        Me.cmdJobComSheet.Text = "Job Com Sheet"
        Me.cmdJobComSheet.UseVisualStyleBackColor = False
        '
        'txtDesc
        '
        Me.txtDesc.AcceptsReturn = True
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDesc.Location = New System.Drawing.Point(8, 88)
        Me.txtDesc.MaxLength = 254
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesc.Size = New System.Drawing.Size(209, 43)
        Me.txtDesc.TabIndex = 18
        '
        'txtOther
        '
        Me.txtOther.AcceptsReturn = True
        Me.txtOther.BackColor = System.Drawing.SystemColors.Window
        Me.txtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOther.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOther.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOther.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOther.Location = New System.Drawing.Point(8, 152)
        Me.txtOther.MaxLength = 0
        Me.txtOther.Name = "txtOther"
        Me.txtOther.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOther.Size = New System.Drawing.Size(209, 20)
        Me.txtOther.TabIndex = 19
        '
        'cmdAddInv
        '
        Me.cmdAddInv.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddInv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddInv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddInv.Location = New System.Drawing.Point(7, 362)
        Me.cmdAddInv.Name = "cmdAddInv"
        Me.cmdAddInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddInv.Size = New System.Drawing.Size(98, 26)
        Me.cmdAddInv.TabIndex = 23
        Me.cmdAddInv.Text = "Add Invoice"
        Me.cmdAddInv.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 179)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(209, 17)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Sales Tax ID"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(209, 17)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Payment Notes: (split details)"
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDesc.Location = New System.Drawing.Point(8, 72)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDesc.Size = New System.Drawing.Size(209, 17)
        Me.lblDesc.TabIndex = 41
        Me.lblDesc.Text = "General Job Description:"
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.Color.White
        Me.Picture2.Controls.Add(Me.Label18)
        Me.Picture2.Controls.Add(Me.lblJobMargin)
        Me.Picture2.Controls.Add(Me.cmdSetTaxRate)
        Me.Picture2.Controls.Add(Me.txtJobLabor)
        Me.Picture2.Controls.Add(Me.txtJobMaterials)
        Me.Picture2.Controls.Add(Me.Line1)
        Me.Picture2.Controls.Add(Me.Label10)
        Me.Picture2.Controls.Add(Me.Label9)
        Me.Picture2.Controls.Add(Me.Label8)
        Me.Picture2.Controls.Add(Me.Label7)
        Me.Picture2.Controls.Add(Me.txtJobTotal)
        Me.Picture2.Controls.Add(Me.txtJobTaxRate)
        Me.Picture2.Controls.Add(Me.lblCreditLimit)
        Me.Picture2.Controls.Add(Me.Label15)
        Me.Picture2.Controls.Add(Me.Label14)
        Me.Picture2.Controls.Add(Me.lblCreditUsed)
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture2.Location = New System.Drawing.Point(13, 341)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(268, 208)
        Me.Picture2.TabIndex = 1
        Me.Picture2.TabStop = True
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(105, 17)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Job Margin:"
        '
        'lblJobMargin
        '
        Me.lblJobMargin.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblJobMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJobMargin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblJobMargin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobMargin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJobMargin.Location = New System.Drawing.Point(112, 184)
        Me.lblJobMargin.Name = "lblJobMargin"
        Me.lblJobMargin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblJobMargin.Size = New System.Drawing.Size(145, 17)
        Me.lblJobMargin.TabIndex = 58
        '
        'cmdSetTaxRate
        '
        Me.cmdSetTaxRate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSetTaxRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSetTaxRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetTaxRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSetTaxRate.Location = New System.Drawing.Point(164, 96)
        Me.cmdSetTaxRate.Name = "cmdSetTaxRate"
        Me.cmdSetTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSetTaxRate.Size = New System.Drawing.Size(92, 20)
        Me.cmdSetTaxRate.TabIndex = 16
        Me.cmdSetTaxRate.Text = "Tax"
        Me.cmdSetTaxRate.UseVisualStyleBackColor = False
        '
        'txtJobLabor
        '
        Me.txtJobLabor.AcceptsReturn = True
        Me.txtJobLabor.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobLabor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobLabor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobLabor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobLabor.Location = New System.Drawing.Point(112, 120)
        Me.txtJobLabor.MaxLength = 0
        Me.txtJobLabor.Name = "txtJobLabor"
        Me.txtJobLabor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobLabor.Size = New System.Drawing.Size(145, 22)
        Me.txtJobLabor.TabIndex = 17
        '
        'txtJobMaterials
        '
        Me.txtJobMaterials.AcceptsReturn = True
        Me.txtJobMaterials.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobMaterials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobMaterials.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobMaterials.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobMaterials.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobMaterials.Location = New System.Drawing.Point(112, 72)
        Me.txtJobMaterials.MaxLength = 0
        Me.txtJobMaterials.Name = "txtJobMaterials"
        Me.txtJobMaterials.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobMaterials.Size = New System.Drawing.Size(144, 22)
        Me.txtJobMaterials.TabIndex = 14
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(8, 144)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(248, 1)
        Me.Line1.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(105, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Contract:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Labor:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Sales Tax %:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Materials:"
        '
        'txtJobTotal
        '
        Me.txtJobTotal.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtJobTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtJobTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtJobTotal.Location = New System.Drawing.Point(112, 152)
        Me.txtJobTotal.Name = "txtJobTotal"
        Me.txtJobTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobTotal.Size = New System.Drawing.Size(145, 17)
        Me.txtJobTotal.TabIndex = 24
        '
        'lblCreditLimit
        '
        Me.lblCreditLimit.BackColor = System.Drawing.SystemColors.Window
        Me.lblCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditLimit.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCreditLimit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditLimit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCreditLimit.Location = New System.Drawing.Point(112, 8)
        Me.lblCreditLimit.Name = "lblCreditLimit"
        Me.lblCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCreditLimit.Size = New System.Drawing.Size(144, 17)
        Me.lblCreditLimit.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(102, 17)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Used"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(102, 17)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Credit"
        '
        'lblCreditUsed
        '
        Me.lblCreditUsed.BackColor = System.Drawing.SystemColors.Window
        Me.lblCreditUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreditUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCreditUsed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditUsed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCreditUsed.Location = New System.Drawing.Point(112, 32)
        Me.lblCreditUsed.Name = "lblCreditUsed"
        Me.lblCreditUsed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCreditUsed.Size = New System.Drawing.Size(144, 17)
        Me.lblCreditUsed.TabIndex = 13
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsReturn = True
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBalance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBalance.Location = New System.Drawing.Point(379, 518)
        Me.txtBalance.MaxLength = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBalance.Size = New System.Drawing.Size(128, 22)
        Me.txtBalance.TabIndex = 20
        Me.txtBalance.Text = "0"
        '
        'Picture3
        '
        Me.Picture3.BackColor = System.Drawing.Color.White
        Me.Picture3.Controls.Add(Me.chkSplitComm)
        Me.Picture3.Controls.Add(Me.txtPhone)
        Me.Picture3.Controls.Add(Me.cmbSalesper)
        Me.Picture3.Controls.Add(Me.cmbTerms)
        Me.Picture3.Controls.Add(Me.txtDrawingDate)
        Me.Picture3.Controls.Add(Me.txtContact)
        Me.Picture3.Controls.Add(Me.txtContractDate)
        Me.Picture3.Controls.Add(Me.txtJobNo)
        Me.Picture3.Controls.Add(Me.txtPermit)
        Me.Picture3.Controls.Add(Me.cmbDisclaimer)
        Me.Picture3.Controls.Add(Me.cmbDrawing)
        Me.Picture3.Controls.Add(Me.cmbContract)
        Me.Picture3.Controls.Add(Me.Label1)
        Me.Picture3.Controls.Add(Me.Label5)
        Me.Picture3.Controls.Add(Me.lblSalesper)
        Me.Picture3.Controls.Add(Me.Label6)
        Me.Picture3.Controls.Add(Me.Label4)
        Me.Picture3.Controls.Add(Me.lblContratd)
        Me.Picture3.Controls.Add(Me.ContractLabel)
        Me.Picture3.Controls.Add(Me.PermitLabel)
        Me.Picture3.Controls.Add(Me.Label13)
        Me.Picture3.Controls.Add(Me.Label12)
        Me.Picture3.Controls.Add(Me.Label11)
        Me.Picture3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture3.Location = New System.Drawing.Point(13, 48)
        Me.Picture3.Name = "Picture3"
        Me.Picture3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture3.Size = New System.Drawing.Size(268, 287)
        Me.Picture3.TabIndex = 0
        Me.Picture3.TabStop = True
        '
        'chkSplitComm
        '
        Me.chkSplitComm.BackColor = System.Drawing.SystemColors.Control
        Me.chkSplitComm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSplitComm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSplitComm.Location = New System.Drawing.Point(8, 200)
        Me.chkSplitComm.Name = "chkSplitComm"
        Me.chkSplitComm.Size = New System.Drawing.Size(100, 22)
        Me.chkSplitComm.TabIndex = 49
        Me.chkSplitComm.Text = "Split Sales"
        Me.chkSplitComm.UseVisualStyleBackColor = False
        '
        'txtPhone
        '
        Me.txtPhone.AcceptsReturn = True
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.Location = New System.Drawing.Point(114, 128)
        Me.txtPhone.MaxLength = 0
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone.Size = New System.Drawing.Size(143, 22)
        Me.txtPhone.TabIndex = 6
        '
        'cmbSalesper
        '
        Me.cmbSalesper.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSalesper.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSalesper.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesper.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSalesper.Location = New System.Drawing.Point(114, 183)
        Me.cmbSalesper.Name = "cmbSalesper"
        Me.cmbSalesper.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSalesper.Size = New System.Drawing.Size(143, 24)
        Me.cmbSalesper.TabIndex = 8
        '
        'cmbTerms
        '
        Me.cmbTerms.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTerms.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTerms.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTerms.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTerms.Items.AddRange(New Object() {"Net 30", "50-50", "PIA"})
        Me.cmbTerms.Location = New System.Drawing.Point(114, 151)
        Me.cmbTerms.Name = "cmbTerms"
        Me.cmbTerms.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTerms.Size = New System.Drawing.Size(143, 22)
        Me.cmbTerms.TabIndex = 7
        '
        'txtDrawingDate
        '
        Me.txtDrawingDate.AcceptsReturn = True
        Me.txtDrawingDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtDrawingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrawingDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDrawingDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawingDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDrawingDate.Location = New System.Drawing.Point(114, 80)
        Me.txtDrawingDate.MaxLength = 0
        Me.txtDrawingDate.Name = "txtDrawingDate"
        Me.txtDrawingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDrawingDate.Size = New System.Drawing.Size(143, 22)
        Me.txtDrawingDate.TabIndex = 4
        '
        'txtContact
        '
        Me.txtContact.AcceptsReturn = True
        Me.txtContact.BackColor = System.Drawing.SystemColors.Window
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContact.Location = New System.Drawing.Point(114, 104)
        Me.txtContact.MaxLength = 0
        Me.txtContact.Name = "txtContact"
        Me.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContact.Size = New System.Drawing.Size(143, 22)
        Me.txtContact.TabIndex = 5
        '
        'txtContractDate
        '
        Me.txtContractDate.AcceptsReturn = True
        Me.txtContractDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtContractDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContractDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContractDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContractDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContractDate.Location = New System.Drawing.Point(114, 56)
        Me.txtContractDate.MaxLength = 0
        Me.txtContractDate.Name = "txtContractDate"
        Me.txtContractDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContractDate.Size = New System.Drawing.Size(143, 22)
        Me.txtContractDate.TabIndex = 3
        '
        'txtJobNo
        '
        Me.txtJobNo.AcceptsReturn = True
        Me.txtJobNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobNo.Location = New System.Drawing.Point(114, 8)
        Me.txtJobNo.MaxLength = 0
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobNo.Size = New System.Drawing.Size(143, 22)
        Me.txtJobNo.TabIndex = 1
        '
        'txtPermit
        '
        Me.txtPermit.AcceptsReturn = True
        Me.txtPermit.BackColor = System.Drawing.SystemColors.Window
        Me.txtPermit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPermit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPermit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPermit.Location = New System.Drawing.Point(114, 32)
        Me.txtPermit.MaxLength = 0
        Me.txtPermit.Name = "txtPermit"
        Me.txtPermit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPermit.Size = New System.Drawing.Size(143, 22)
        Me.txtPermit.TabIndex = 2
        '
        'cmbDisclaimer
        '
        Me.cmbDisclaimer.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDisclaimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDisclaimer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDisclaimer.Items.AddRange(New Object() {"Yes", "No", "N/A"})
        Me.cmbDisclaimer.Location = New System.Drawing.Point(176, 251)
        Me.cmbDisclaimer.Name = "cmbDisclaimer"
        Me.cmbDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDisclaimer.Size = New System.Drawing.Size(81, 24)
        Me.cmbDisclaimer.TabIndex = 11
        '
        'cmbDrawing
        '
        Me.cmbDrawing.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDrawing.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDrawing.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrawing.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDrawing.Items.AddRange(New Object() {"Yes", "No", "N/A"})
        Me.cmbDrawing.Location = New System.Drawing.Point(96, 251)
        Me.cmbDrawing.Name = "cmbDrawing"
        Me.cmbDrawing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDrawing.Size = New System.Drawing.Size(81, 24)
        Me.cmbDrawing.TabIndex = 10
        '
        'cmbContract
        '
        Me.cmbContract.BackColor = System.Drawing.SystemColors.Window
        Me.cmbContract.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbContract.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContract.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbContract.Items.AddRange(New Object() {"Yes", "No", "N/A"})
        Me.cmbContract.Location = New System.Drawing.Point(8, 251)
        Me.cmbContract.Name = "cmbContract"
        Me.cmbContract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbContract.Size = New System.Drawing.Size(89, 24)
        Me.cmbContract.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(8, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Job Phone"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(8, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Terms"
        '
        'lblSalesper
        '
        Me.lblSalesper.BackColor = System.Drawing.SystemColors.Control
        Me.lblSalesper.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSalesper.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesper.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSalesper.Location = New System.Drawing.Point(8, 184)
        Me.lblSalesper.Name = "lblSalesper"
        Me.lblSalesper.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSalesper.Size = New System.Drawing.Size(105, 17)
        Me.lblSalesper.TabIndex = 38
        Me.lblSalesper.Text = "Salesperson:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Drawing Date"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(8, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Job Contact"
        '
        'lblContratd
        '
        Me.lblContratd.BackColor = System.Drawing.SystemColors.Control
        Me.lblContratd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblContratd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContratd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblContratd.Location = New System.Drawing.Point(8, 56)
        Me.lblContratd.Name = "lblContratd"
        Me.lblContratd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblContratd.Size = New System.Drawing.Size(105, 17)
        Me.lblContratd.TabIndex = 35
        Me.lblContratd.Text = "Contract Date"
        '
        'ContractLabel
        '
        Me.ContractLabel.BackColor = System.Drawing.SystemColors.Control
        Me.ContractLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ContractLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContractLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ContractLabel.Location = New System.Drawing.Point(8, 8)
        Me.ContractLabel.Name = "ContractLabel"
        Me.ContractLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ContractLabel.Size = New System.Drawing.Size(105, 17)
        Me.ContractLabel.TabIndex = 34
        Me.ContractLabel.Text = "Job Number:"
        '
        'PermitLabel
        '
        Me.PermitLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PermitLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PermitLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PermitLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PermitLabel.Location = New System.Drawing.Point(8, 32)
        Me.PermitLabel.Name = "PermitLabel"
        Me.PermitLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PermitLabel.Size = New System.Drawing.Size(105, 17)
        Me.PermitLabel.TabIndex = 33
        Me.PermitLabel.Text = "Building Permit:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label13.Location = New System.Drawing.Point(176, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(81, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Disclaimer Sig:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label12.Location = New System.Drawing.Point(96, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(81, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Drawing Sig:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(8, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Contract Sig:"
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustomer.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCustomer.Location = New System.Drawing.Point(13, 8)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustomer.Size = New System.Drawing.Size(500, 33)
        Me.lblCustomer.TabIndex = 42
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'daLocationBins
        '
        Me.daLocationBins.SelectCommand = Me.SqlSelectCommand1
        Me.daLocationBins.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLocationBins", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("LocationNumber", "LocationNumber"), New System.Data.Common.DataColumnMapping("LocationPrefix", "LocationPrefix"), New System.Data.Common.DataColumnMapping("LabelID", "LabelID"), New System.Data.Common.DataColumnMapping("DateModified", "DateModified"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT LocationNumber, LocationPrefix, LabelID, DateModified, Description FROM db" & _
    "o.tblLocationBins"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=TZ250;packet size=4096;user id=tksidatauser;data source=DELL-SERVE" & _
    "R\SQLEXPRESS;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'daLocationJOIN
        '
        Me.daLocationJOIN.SelectCommand = Me.SqlSelectCommand2
        Me.daLocationJOIN.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLocationLabelJOIN", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("LocationNumber", "LocationNumber"), New System.Data.Common.DataColumnMapping("TrailerlLabelID", "TrailerlLabelID"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("DateEntered", "DateEntered"), New System.Data.Common.DataColumnMapping("Notes", "Notes")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO")})
        '
        'pnlLarge
        '
        Me.pnlLarge.Controls.Add(Me.Panel1)
        Me.pnlLarge.Controls.Add(Me.pnlScanbutton)
        Me.pnlLarge.Controls.Add(Me.lvImages)
        Me.pnlLarge.Location = New System.Drawing.Point(818, 0)
        Me.pnlLarge.Name = "pnlLarge"
        Me.pnlLarge.Size = New System.Drawing.Size(444, 630)
        Me.pnlLarge.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 450)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(425, 550)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pnlScanbutton
        '
        Me.pnlScanbutton.Controls.Add(Me.btnScan)
        Me.pnlScanbutton.Controls.Add(Me.pnlCheckBoxes)
        Me.pnlScanbutton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlScanbutton.Location = New System.Drawing.Point(0, 104)
        Me.pnlScanbutton.Name = "pnlScanbutton"
        Me.pnlScanbutton.Size = New System.Drawing.Size(444, 63)
        Me.pnlScanbutton.TabIndex = 3
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.SystemColors.Control
        Me.btnScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnScan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.Location = New System.Drawing.Point(0, 0)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(444, 35)
        Me.btnScan.TabIndex = 1
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'pnlCheckBoxes
        '
        Me.pnlCheckBoxes.Controls.Add(Me.btnPrint)
        Me.pnlCheckBoxes.Controls.Add(Me.chk11x17)
        Me.pnlCheckBoxes.Controls.Add(Me.chkMap)
        Me.pnlCheckBoxes.Controls.Add(Me.btnAttachImg)
        Me.pnlCheckBoxes.Controls.Add(Me.btnDeleteImage)
        Me.pnlCheckBoxes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCheckBoxes.Location = New System.Drawing.Point(0, 35)
        Me.pnlCheckBoxes.Name = "pnlCheckBoxes"
        Me.pnlCheckBoxes.Size = New System.Drawing.Size(444, 28)
        Me.pnlCheckBoxes.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Silver
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(352, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.btnPrint.Size = New System.Drawing.Size(80, 28)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'chk11x17
        '
        Me.chk11x17.AutoSize = True
        Me.chk11x17.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk11x17.Dock = System.Windows.Forms.DockStyle.Left
        Me.chk11x17.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk11x17.Location = New System.Drawing.Point(262, 0)
        Me.chk11x17.Name = "chk11x17"
        Me.chk11x17.Padding = New System.Windows.Forms.Padding(4, 0, 22, 0)
        Me.chk11x17.Size = New System.Drawing.Size(90, 28)
        Me.chk11x17.TabIndex = 11
        Me.chk11x17.Text = "11"" x 17"""
        Me.chk11x17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk11x17.UseVisualStyleBackColor = True
        '
        'chkMap
        '
        Me.chkMap.AutoSize = True
        Me.chkMap.BackColor = System.Drawing.SystemColors.Control
        Me.chkMap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMap.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkMap.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMap.Location = New System.Drawing.Point(184, 0)
        Me.chkMap.Name = "chkMap"
        Me.chkMap.Padding = New System.Windows.Forms.Padding(22, 0, 12, 0)
        Me.chkMap.Size = New System.Drawing.Size(78, 28)
        Me.chkMap.TabIndex = 10
        Me.chkMap.Text = "Map"
        Me.chkMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMap.UseVisualStyleBackColor = False
        '
        'btnAttachImg
        '
        Me.btnAttachImg.BackColor = System.Drawing.SystemColors.Control
        Me.btnAttachImg.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAttachImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAttachImg.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachImg.Location = New System.Drawing.Point(87, 0)
        Me.btnAttachImg.Name = "btnAttachImg"
        Me.btnAttachImg.Size = New System.Drawing.Size(97, 28)
        Me.btnAttachImg.TabIndex = 9
        Me.btnAttachImg.Text = "Attach Image"
        Me.btnAttachImg.UseVisualStyleBackColor = False
        '
        'btnDeleteImage
        '
        Me.btnDeleteImage.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeleteImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteImage.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteImage.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteImage.Name = "btnDeleteImage"
        Me.btnDeleteImage.Size = New System.Drawing.Size(87, 28)
        Me.btnDeleteImage.TabIndex = 7
        Me.btnDeleteImage.Text = "Delete Scan"
        Me.btnDeleteImage.UseVisualStyleBackColor = False
        '
        'lvImages
        '
        Me.lvImages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvImages.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvImages.FullRowSelect = True
        Me.lvImages.LargeImageList = Me.ImageList1
        Me.lvImages.Location = New System.Drawing.Point(0, 0)
        Me.lvImages.Name = "lvImages"
        Me.lvImages.Size = New System.Drawing.Size(444, 104)
        Me.lvImages.SmallImageList = Me.ImageList1
        Me.lvImages.TabIndex = 0
        Me.lvImages.UseCompatibleStateImageBehavior = False
        Me.lvImages.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 380
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TblActivityTypeTableAdapter1
        '
        Me.TblActivityTypeTableAdapter1.ClearBeforeFill = True
        '
        'TblJobActivityTableAdapter
        '
        Me.TblJobActivityTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument8x11
        '
        '
        'PrintDocument11x17
        '
        '
        'TblSWOPendingTableAdapter1
        '
        Me.TblSWOPendingTableAdapter1.ClearBeforeFill = True
        '
        'TJobTableAdapter1
        '
        Me.TJobTableAdapter1.ClearBeforeFill = True
        '
        'TSOHeaderTableAdapter1
        '
        Me.TSOHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TSOLineTableAdapter1
        '
        Me.TSOLineTableAdapter1.ClearBeforeFill = True
        '
        'TblCommissionStructureTableAdapter1
        '
        Me.TblCommissionStructureTableAdapter1.ClearBeforeFill = True
        '
        'lblNoJobSelected
        '
        Me.lblNoJobSelected.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoJobSelected.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoJobSelected.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoJobSelected.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNoJobSelected.Location = New System.Drawing.Point(295, 66)
        Me.lblNoJobSelected.Name = "lblNoJobSelected"
        Me.lblNoJobSelected.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNoJobSelected.Size = New System.Drawing.Size(500, 33)
        Me.lblNoJobSelected.TabIndex = 52
        Me.lblNoJobSelected.Text = "<- No Job Selected"
        '
        'JobEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1525, 823)
        Me.Controls.Add(Me.pnlLarge)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.picStep1)
        Me.Controls.Add(Me.lblNoJobSelected)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(73, 22)
        Me.Name = "JobEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Job Edit"
        Me.Picture1.ResumeLayout(False)
        CType(Me.gridInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridJobLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picStep1.ResumeLayout(False)
        Me.picStep1.PerformLayout()
        Me.Picture4.ResumeLayout(False)
        Me.Picture4.PerformLayout()
        CType(Me.TblJobActivityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TKSIJOBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture2.ResumeLayout(False)
        Me.Picture2.PerformLayout()
        Me.Picture3.ResumeLayout(False)
        Me.Picture3.PerformLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLarge.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlScanbutton.ResumeLayout(False)
        Me.pnlCheckBoxes.ResumeLayout(False)
        Me.pnlCheckBoxes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private blnTaxEditInProgress As Boolean
    Private drAdd As dsTKSI.tAddressRow
    Private drJob As dsTKSI.tJobRow
    Private oJob As New JobObj

    '  Private WithEvents _tw As openTwain.Twain
    Private _OutputDirectory As String = "C:\"
    Private _ExceptionFile As String = "cmdHarnessEx.txt"
    Private _SurpressDialogs As Boolean = True
    Private _KnownDialogsFile As String = "kDialogs.xml"

    Private WithEvents m_MessageTmr As System.Threading.Timer

    Private _promptText As String = "Twain:\>"
    Private _lastCmdId As Int32 = 0
    Private _UnrecognizedCmd As String = "Unrecognized command"

    Private _InProgress As Boolean = False

    Private _ActiveSourceId As Int32 = 0
    Private _ActiveSourceName As String = String.Empty

    Private _AvailableProfiles As New Dictionary(Of String, String)
    Private _ActiveProfileId As Int32 = 0
    Private _ActiveProfileName As String = String.Empty

    '  Private _ActiveProfile As openTwain.Profile

    Private m_tmrInterval As Int32 = 60000

    Private t As System.Threading.Thread

    Private blnScanningMaps As Boolean = False

    Private Sub cmdAddInv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddInv.Click
        Me.SaveJob()
        oJob.AddSO(Me.txtInvNotes.Text, drJob, Me.DsTKSI1)
        Me.PopulateJob(Me.drJob.nID)
    End Sub

    Private Sub cmdAddPO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddPO.Click
        ''save existing job before you continue to new PO screen
        Me.SaveJob()
        If Me.oJob.AddPO(Me.drJob, Me.DsTKSI1) Then
            Dim jobid As Long = Me.drJob.nID
            Me.LoadJobByAddress(drAdd.nID)
            Me.PopulateJob(jobid)
        End If
    End Sub

    Private Sub DoGroup(ByRef Row As Object, ByRef lvl As Object)
        gridJobLoc.set_IsSubtotal(Row, True)
        gridJobLoc.set_RowOutlineLevel(Row, lvl)
        If lvl = 0 Then Exit Sub
    End Sub

    Private Sub DoGroupInv(ByRef Row As Object, ByRef lvl As Object)
        gridInvoices.set_IsSubtotal(Row, True)
        gridInvoices.set_RowOutlineLevel(Row, lvl)
        If lvl = 0 Then Exit Sub
    End Sub

    Private Sub cmdAddJob_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddJob.Click
        Try
            If Not Me.drAdd Is Nothing Then
                Me.SaveJob()
                Dim CustID As Integer
                Dim CustSearch As New CustSearch
                CustSearch.ShowDialog()

                If CustSearch.OK Then
                    CustID = CustSearch.lID
                    If CustID > 0 Then
                        Dim drJob As dsTKSI.tJobRow
                        drJob = Me.DsTKSI1.tJob.NewtJobRow
                        With drJob
                            .dJobCreated = Today.Date
                            .dCreated = Today.Date
                            .nTaxRate = 0
                            .nTotalWholesale = 0
                            .nMaterialsCharge = 0
                            .nLaborCharge = 0
                            .nAddressID = drAdd.nID
                            .nCustID = CustID
                            .lngCommissionStruct = DataFunctions.GetDefaultPriorityCommStructureID()
                            .sJobNo = "NEW JOB"
                            .sInvNotes = ""
                            .sJobContact = ""
                            .sJobDesc = ""
                            .sOtherNotes = ""
                            .sPhone = ""
                            .sSalesperson = ""
                            .sTerms = ""
                            .sCounty = ""
                            .sBuildingPermit = ""
                            .sCommLocked = ""
                            .sComplete = ""
                            .sContractSigned = ""
                            .sDisclaimerSigned = ""
                            .sDrawingsSigned = ""
                            .dAmtYTD = 0
                            .dCrLimit = 0
                            .dDrawing = ""
                        End With

                        Me.DsTKSI1.tJob.Rows.Add(drJob)
                        oJob.UpdateJobTable(Me.DsTKSI1)

                        Me.picStep1.Visible = False
                        Me.LoadJobByAddress(Me.drAdd.nID, drJob.nID)
                    Else
                        MessageBox.Show("missing customer ID")
                    End If
                Else
                    'user cancelled customer box selection
                End If
            Else
                Windows.Forms.MessageBox.Show("No address loaded.")
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Addjob Error. " & ex.Message)
        End Try
    End Sub

    Private Sub cmdCommStruct_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCommStruct.Click
        Dim frmStruct As New frmCommStructEdit
        frmStruct.ShowDialog()
        If frmStruct.OK Then
            Me.TblCommissionStructureTableAdapter1.Fill(Me.TKSIJOBSDataSet.tblCommissionStructure)
            drJob.lngCommissionStruct = frmStruct.g_lngCommSelected
            oJob.UpdateJobTable(Me.DsTKSI1)

            Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
            drComm = Me.TKSIJOBSDataSet.tblCommissionStructure.FindBylngID(drJob.lngCommissionStruct)
            If Not drComm Is Nothing Then
                Me.cmdCommStruct.Text = "Structure: " & drComm.lngPriority
            End If

        End If
    End Sub

    Private Sub cmdDelJob_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelJob.Click
        Try
            Dim temp As Integer
            Dim msg As Object

            If gridJobLoc.get_RowOutlineLevel(gridJobLoc.RowSel) = 1 Then
                gridJobLoc.Select(gridJobLoc.RowSel, 1)
                If IsNumeric(gridJobLoc.Text) Then
                    temp = CInt(gridJobLoc.Text)
                    msg = MsgBox("Are you sure you want to delete JOB# " & gridJobLoc.get_TextMatrix(gridJobLoc.RowSel, 3) & "?", MsgBoxStyle.OkCancel)
                    If msg = 1 Then
                        If Not Me.drJob Is Nothing Then
                            If Me.drJob.GettPOHeaderRows.Length = 0 And Me.drJob.GettSOHeaderRows.Length = 0 Then
                                drJob.Delete()
                                oJob.UpdateJobTable(Me.DsTKSI1)
                                Me.drJob = Nothing
                                Me.LoadJobByAddress(drAdd.nID)
                                Me.picStep1.Visible = False
                            Else
                                Windows.Forms.MessageBox.Show("Delete PO's and Invoices first. (or you may have to double-click the job you want to delete before hitting delete)")
                            End If
                        End If

                    End If
                Else
                    MsgBox("No job selected to delete.")
                End If
            Else
                MsgBox("Select a job first")
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("No job selected. " & ex.Message)
            Try
                Me.DsTKSI1.RejectChanges()
            Catch ex1 As Exception
                Windows.Forms.MessageBox.Show("Error deleting job 1... " & ex.Message)
            End Try
        End Try

    End Sub

    Private Sub cmdUpdate_Click()
        UpdateBalance()
    End Sub

    Private Sub UpdateBalance()
        Try
            If Not drJob Is Nothing Then
                Me.txtBalance.Text = ((drJob.nMaterialsCharge + drJob.nLaborCharge) - POsSalesTotal(drJob)).ToString
            End If
        Catch ex As Exception
            ' Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function POsSalesTotal(ByVal drjob As dsTKSI.tJobRow) As Double

        Dim tempSale As Double
        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In drjob.GettPOHeaderRows
            tempSale += drPO.nRetailSale + drPO.nRetailFreight + drPO.nAdd
        Next
        Return tempSale

    End Function

    Private Sub cmdInvBalance_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInvBalance.Click
        Me.SaveJob()
        Me.LoadJobByAddress(drJob.nAddressID, drJob.nID)
    End Sub

    ' Private imgJobSheet As Image
    Private Sub cmdJobComSheet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJobComSheet.Click
        Me.SaveJob()

        Dim ctrJob1 As New ctrJobComm
        ctrJob1.LoadJob(drJob.nID)
        ' imgJobSheet = ctrJob1.BuildJobCommSheet()
        '  Me.alImagesToPrint8x11.Add(imgJobSheet)

        ctrJob1 = Nothing

        Dim settings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings

        Me.PrintDocument8x11.PrinterSettings.PrinterName = settings.PrinterName
        Dim print1 As New System.Drawing.Printing.PageSettings
        print1.Landscape = False
        With print1
            Try
                Dim paper As Long
                paper = GetLetterPaperEnum(print1)
                If paper >= 0 Then
                    .PaperSize = .PrinterSettings.PaperSizes(paper)
                End If
            Catch ex As Exception
            End Try
            .PrinterSettings.PrinterName = settings.PrinterName
            .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            .Margins.Bottom = 0
            .Margins.Left = 0
            .Margins.Top = 0
            .Margins.Right = 0
        End With
        Me.PrintDocument8x11.DefaultPageSettings = print1

        Dim frmprev As New frmPrintPrev
        frmprev.C1PrintPreviewControl1.Document = Me.PrintDocument8x11
        frmprev.ShowDialog()

    End Sub

    Private Sub cmdPOBalance_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPOBalance.Click
        SaveJob()
    End Sub

    Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        SaveJob()
        Me.LoadJobByAddress(drJob.nAddressID, drJob.nID)
    End Sub

    Private Sub SaveJob()
        If Not drJob Is Nothing Then



            drJob.sOtherNotes = txtOther.Text
            drJob.sJobNo = txtJobNo.Text
            drJob.sBuildingPermit = txtPermit.Text
            drJob.sContractSigned = cmbContract.Text
            drJob.sDrawingsSigned = cmbDrawing.Text
            drJob.sPhone = txtPhone.Text
            drJob.sJobDesc = txtDesc.Text
            drJob.sInvNotes = txtInvNotes.Text
            drJob.sJobContact = txtContact.Text
            drJob.sDisclaimerSigned = cmbDisclaimer.Text
            drJob.sSalesperson = cmbSalesper.Text
            drJob.sTerms = cmbTerms.Text
            drJob.nTaxRate = Decimal.Round(CDec(GetSumTaxesByJOB((drJob.nID))), 3)
            If IsNumeric(Me.txtJobLabor.Text) Then
                drJob.nLaborCharge = Me.txtJobLabor.Text
            End If

            If IsNumeric(txtJobMaterials.Text) Then
                drJob.nMaterialsCharge = CDbl(txtJobMaterials.Text)
            End If

            If IsDate2(txtDrawingDate.Text) Then
                drJob.dDrawing = txtDrawingDate.Text
            End If

            If IsDate2(txtContractDate.Text) Then
                drJob.dJobCreated = txtContractDate.Text
            End If

            oJob.UpdateJobTable(Me.DsTKSI1)

            Try
                ' If chkSplitComm.Checked Then
                Dim dc As linqTKSIDataContext = GetLinqDataContext()
                Dim q = (From row In dc.tJobs Where row.nID = drJob.nID)
                If q.Count > 0 Then
                    q.First.blnSplitCommission = chkSplitComm.Checked
                    '  q.First.blnSplitCommission = True
                    dc.SubmitChanges()
                End If
                '   End If
            Catch ex As Exception
                ' MessageBox.Show("error saving split commissions check " & ex.Message)
            End Try

            UpdateBalance()

        End If

    End Sub

    Private Sub cmdSetTaxRate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSetTaxRate.Click
        Try
            If Not drJob Is Nothing Then
                Me.SaveJob()
                Dim frm1 As New frmJobTaxEdit
                frm1.JobID = drJob.nID
                frm1.StartPosition = FormStartPosition.CenterScreen
                frm1.ShowDialog()
                Me.LoadJobByAddress(drAdd.nID, drJob.nID)
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetSumTaxesByJOB(iJob As Integer) As Double
        Try
            Dim dc As linqTKSIDataContext = GetLinqDataContext()
            Dim q = (From row In dc.tblJobTaxes Where row.nJobID = iJob Select row.TaxPercent)

            If q.Count > 0 Then
                Return q.Sum
            End If
        Catch ex As Exception
            MessageBox.Show("error in GetSumTaxesByJOB " & ex.Message)
        End Try


    End Function

    Private Sub JobEdit_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Try
            If sUserlevel >= UserRights.Shipping Then
                cmdAddJob.Visible = False
                cmdDelJob.Visible = False
                cmdSave.Visible = False
                cmdAddInv.Visible = False
                Me.cmdAddPO.Visible = False
                Me.cmdInvBalance.Visible = False
                Me.cmdJobComSheet.Visible = False
                Me.cmdPOBalance.Visible = False
                txtBalance.Visible = False
                txtInvBalance.Visible = False
                Me.cmdAddInv.Visible = False
                Me.cmdCommStruct.Visible = False
                Me.cmdDelJob.Visible = False
                Me.cmdPOBalance.Visible = False
                Me.cmdInvBalance.Visible = False
                Me.cmdSetTaxRate.Visible = False
                Me.cmdCommStruct.Visible = False

            ElseIf sUserlevel >= UserRights.AdminAsst Then
                Me.cmdCommStruct.Visible = False
            End If

            If sUserlevel <= UserRights.Shipping Then
                Me.cmdJobComSheet.Visible = True
            End If

            PopulateSalesCombo()

            Me.Location = New Point(30, 1)
            Me.Size = New Size(global_ScreenWidth - 50, global_ScreenHeight - 20)
        Catch ex As Exception
            MessageBox.Show(" error on 'load' job screen: " & ex.Message)
        End Try


    End Sub

    Private Sub PopulateSalesCombo()
        oJob.SelectEmployeeTable(Me.DsTKSI1)

        Dim drEmp As dsTKSI.tEmployeeRow
        For Each drEmp In Me.DsTKSI1.tEmployee
            If drEmp.archive = False Then
                Me.cmbSalesper.Items.Add(drEmp.nickname)
            End If
        Next
    End Sub

    Private Sub LoadSWOGrid()
        Try
            If Me.DsTKSI1.tAddress.Rows.Count > 0 Then
                Me.lvSWOPending.Items.Clear()
                Dim ds1 As New TKSIJOBSDataSet
                ds1.EnforceConstraints = False
                Me.TblSWOPendingTableAdapter1.FillByAddressID(ds1.tblSWOPending, Me.DsTKSI1.tAddress(0).nID)
                Dim lv As ListViewItem
                Dim drSWO As TKSIJOBSDataSet.tblSWOPendingRow
                For Each drSWO In ds1.tblSWOPending
                    ' If drSWO.sStatus <> "po" Then
                    Dim strRTF As String = ""
                    strRTF = ConvertRtfToText(drSWO.detail1)
                    lv = Me.lvSWOPending.Items.Add(drSWO.gid.ToString)
                    lv.SubItems.Add(drSWO.DateOfOrder.Month & "/" & drSWO.DateOfOrder.Day & " " & strRTF)
                    If drSWO.sStatus = "approved" Then
                        lv.BackColor = Color.LightGreen
                        lv.SubItems.Add("APPROVED")
                    ElseIf drSWO.sStatus = "po" Then
                        lv.BackColor = Color.Blue
                        lv.SubItems.Add("PO Created")
                    End If
                    If drSWO.sStatus = "" Or drSWO.sStatus = "sales" Then
                        lv.BackColor = Color.Yellow
                    End If
                    ' End If

                Next

            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadJobByAddress(ByRef AddressID As Integer, Optional ByVal jobid As Long = 0)
        Try
            oJob.SelectAddressJobPOSOByAddressID(Me.DsTKSI1, AddressID)

            If Me.DsTKSI1.tAddress.Rows.Count > 0 Then
                Me.FillJobGrid(Me.DsTKSI1.tAddress.Rows(0), jobid)

                LoadSWOGrid()
            End If

            If jobid > 0 Then
                Me.PopulateJob(jobid)
                picStep1.Visible = True
            Else
                picStep1.Visible = False
            End If

            If sUserlevel >= UserRights.Shipping Then
                With Me
                    .txtBalance.Enabled = True
                    .txtContact.Enabled = True
                    .txtContractDate.ReadOnly = True
                    .txtDesc.ReadOnly = True
                    .txtDrawingDate.ReadOnly = True
                    .txtJobLabor.ReadOnly = True
                    .txtJobMaterials.ReadOnly = True
                    .txtJobNo.ReadOnly = True
                    .txtJobTaxRate.ReadOnly = True
                    .txtOther.ReadOnly = True
                    .txtPermit.ReadOnly = True
                    .txtPhone.ReadOnly = True
                    .cmbContract.Enabled = True
                    .cmbDisclaimer.Enabled = True
                    .cmbDrawing.Enabled = True
                    .cmbSalesper.Enabled = True
                    .cmbTerms.Enabled = True
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(" error loading job screen: " & ex.Message)
        End Try


    End Sub

    Public Sub PopulateJob(ByVal JobID As Integer)
        Me.lblCustomer.Text = "No Job Selected"

        If Not Me.drAdd Is Nothing Then
            Me.drJob = Me.DsTKSI1.tJob.FindBynID(JobID)


            If Not Me.drJob Is Nothing Then
                oJob.SelectCustomerByJob(Me.DsTKSI1, drJob.nCustID)

                oJob = New JobObj
                oJob.InitAccountTotals(drJob)

                txtDesc.Text = drJob.sJobDesc
                cmbTerms.Text = drJob.sTerms
                If Not drJob.IsdJobCreatedNull Then
                    Me.txtContractDate.Text = drJob.dJobCreated.ToShortDateString
                Else
                    Me.txtContractDate.Text = ""
                End If

                txtJobNo.Text = drJob.sJobNo
                txtDrawingDate.Text = drJob.dDrawing
                txtPermit.Text = drJob.sBuildingPermit
                txtJobMaterials.Text = drJob.nMaterialsCharge.ToString
                txtJobLabor.Text = drJob.nLaborCharge.ToString

                'if tax combo wasnt populated by the new tax rate combo system with alternate table
                'then just put in the old tax rate from the legacy system

                txtJobTaxRate.Text = Decimal.Round(CDec(drJob.nTaxRate), 2)

                Me.txtContact.Text = drJob.sJobContact
                Me.txtPhone.Text = drJob.sPhone
                cmbContract.Text = drJob.sContractSigned
                cmbDrawing.Text = drJob.sDrawingsSigned
                cmbDisclaimer.Text = drJob.sDisclaimerSigned
                txtOther.Text = drJob.sOtherNotes
                cmbSalesper.Text = drJob.sSalesperson
                Me.Text = drJob.tAddressRow.sAddress1

                If Not drJob.tCustomrRow Is Nothing Then
                    Me.lblCreditLimit.Text = TwoDecimal(drJob.tCustomrRow.dCrLimit)
                    Try
                        Me.lblCreditUsed.Text = Format(GetBalanceDueForCustomer(), "currency")
                    Catch ex As Exception
                        Me.lblCreditUsed.Text = ("ERROR")
                    End Try

                    Me.lblCustomer.Text = "Job for: " & drJob.tCustomrRow.sName
                Else
                    Windows.Forms.MessageBox.Show("Customer not found for this job.")
                End If

                Me.txtInvNotes.Text = drJob.sInvNotes


                Me.TblCommissionStructureTableAdapter1.Fill(Me.TKSIJOBSDataSet.tblCommissionStructure)
                Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
                drComm = Me.TKSIJOBSDataSet.tblCommissionStructure.FindBylngID(drJob.lngCommissionStruct)
                If Not drComm Is Nothing Then
                    Me.cmdCommStruct.Text = "Structure: " & drComm.lngPriority
                End If

                Try
                    Dim dc As linqTKSIDataContext = GetLinqDataContext()
                    Dim q = (From row In dc.tJobs Where row.nID = drJob.nID)
                    If q.Count > 0 Then
                      
                            Me.chkSplitComm.Checked = q.First.blnSplitCommission

                    End If
                Catch ex As Exception

                End Try

                FillJobAddressTxt()
                jobtotal()

                Try
                    'Dim curPOcost, contract As Decimal
                    Dim SALE4040, SALE4010, SALE4030, SALE4070 As Decimal
                    Dim COST5030, SALETOTAL, COST5010, COST5040 As Decimal
                    Dim COSTTOTAL, COST5070 As Decimal
                    Dim JobMarkup As Single
                    getPOTotals(drJob, SALE4010, SALE4030, SALE4040, SALE4070, SALETOTAL, COST5010, COST5030, COST5040, COST5070, COSTTOTAL)
                    If COSTTOTAL > 0.1 Then
                        JobMarkup = SALETOTAL / COSTTOTAL
                        Me.lblJobMargin.Text = System.Decimal.Round(CDec(JobMarkup), 2)
                    Else
                        Me.lblJobMargin.Text = "0 Cost"
                    End If

                Catch ex As Exception

                End Try

                UpdateBalance()
                InitInvoices() 'also updates txt invoice balance total on form
                Me.picStep1.Visible = True

                LoadJobimages(Me.drJob)

                Try
                    Me.TblJobActivityTableAdapter.Fill(Me.TKSIJOBSDataSet.tblJobActivity, Me.drJob.nID)
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Function GetBalanceDueForCustomer() As Decimal

        Dim ds1 As New TKSIJOBSDataSet
        ds1.EnforceConstraints = False
        Dim iresult As Integer = 0
        iresult = Me.TSOHeaderTableAdapter1.FillByNCustID(ds1.tSOHeader, Me.drJob.nCustID)
        iresult = Me.TSOLineTableAdapter1.FillByCustIDCommentsOnly(ds1.tSOLine, Me.drJob.nCustID)

        Dim drSO As TKSIJOBSDataSet.tSOHeaderRow
        Dim totalBalanceDue As Decimal = 0
        For Each drSO In ds1.tSOHeader
            '   Me.TSOLineTableAdapter1.FillByNSOID(ds1.tSOLine, drSO.nID)
            Dim drLine As TKSIJOBSDataSet.tSOLineRow
            Dim minBalanceDue As Decimal = 9999999
            For Each drLine In drSO.GettSOLineRows
                If drLine.sType = "Comment" Then
                    'find the smallest balance figure for this invoice , some invoices have multiple balance lines

                    totalBalanceDue += drLine.nAmount

                End If
            Next
            ' If minBalanceDue < 9999998 Then
            ' totalBalanceDue += minBalanceDue
            ' End If
        Next
        Return totalBalanceDue

    End Function

    Private Sub LoadJobimages(ByVal drJob As dsTKSI.tJobRow)

        Me.lvImages.Items.Clear()
        Me.PictureBox1.Image = Nothing

        Dim sJob5 As String = Mid(Me.drJob.sJobNo, 1, 6)
        If IsNumeric(sJob5) Then
            'leave as 6 digit for folder/file creation
        ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
            sJob5 = Mid(sJob5, 1, 5)
        Else
            sJob5 = Mid(sJob5, 1, 4)
        End If

        If System.IO.Directory.Exists(sImagesPath & sJob5 & "\") Then
            If System.IO.Directory.Exists(sImagesPath & sJob5 & "\" & drJob.sJobNo & "\") Then
                Dim file1 As String
                For Each file1 In IO.Directory.GetFiles(sImagesPath & sJob5 & "\" & drJob.sJobNo & "\")
                    Dim item1 As New ListViewItem
                    item1.Text = file1
                    Me.lvImages.Items.Add(item1)
                Next
            End If

            If System.IO.Directory.Exists(sImagesPath & sJob5 & "\MAPS\") Then
                Dim file1 As String
                For Each file1 In IO.Directory.GetFiles(sImagesPath & sJob5 & "\MAPS\")
                    Dim item1 As New ListViewItem
                    item1.Text = file1
                    item1.BackColor = Color.Pink
                    Me.lvImages.Items.Add(item1)
                Next
            End If

        End If
    End Sub

    Private Sub FillJobAddressTxt()
        With Me.lvJobSite
            .Items.Clear()
            .Items.Add("JobSite: " & drAdd.sAddress1)
            .Items.Add(drAdd.sAddress2)
            .Items.Add(drAdd.sCity & ", " & drAdd.sState & " " & drAdd.sZip)
        End With
    End Sub

    Private Function GetBinLabel(ByVal sPO As String) As String
        Try
            Dim strReturn As String = ""
            Me.DsTKSI1.tblLocationLabelJOIN.Clear()
            Me.daLocationJOIN.SelectCommand.Parameters("@PO").Value = sPO
            Me.daLocationJOIN.Fill(Me.DsTKSI1.tblLocationLabelJOIN)
            Dim dr As dsTKSI.tblLocationLabelJOINRow
            For Each dr In Me.DsTKSI1.tblLocationLabelJOIN
                strReturn = strReturn & LocationToShortName(dr.tblLocationBinsRow.LabelID) & " "
            Next
            If Mid(strReturn, 1, 1) = " " Then
                strReturn = Mid(strReturn, 2, 20)
            End If
            Return Replace(Replace(Replace(strReturn, "(", ""), ")", ""), "  ", " ")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub FillJobGrid(ByVal dradd1 As dsTKSI.tAddressRow, Optional ByVal jobid As Long = 0)
        Me.drAdd = dradd1

        Dim strPO As Object

        gridJobLoc.Redraw = False
        With gridJobLoc
            .set_FixedAlignment(0, AlignmentSettings.flexAlignLeftCenter)
            .FixedCols = 0
            .FixedRows = 0
            .Cols = 8

            .set_ColWidth(3, 190)
            .set_ColWidth(4, 18)
            .set_ColWidth(5, 18)
            .set_ColWidth(6, 18)
            '.set_ColWidth(7, 195)

            .set_ColHidden(0, True)
            .set_ColHidden(1, True)
            .set_ColHidden(2, True)
            .Rows = 0
            .Rows = 1
            .Refresh()

            .set_ColDataType(4, GetType(String)) ' DataTypeSettings.flexDTString)
            .AllowBigSelection = False
            .WordWrap = True
            .Redraw = RedrawSettings.flexRDDirect
            Try
                Me.DsTKSI1.tblLocationBins.Clear()
                Me.daLocationBins.Fill(Me.DsTKSI1.tblLocationBins)
            Catch ex As Exception
            End Try

            For Each drAdd In Me.DsTKSI1.tAddress

                Dim strFile As String = "FILE: " & drAdd.sLocCode.ToString & " - " & drAdd.sAddress1.ToString
                .AddItem(drAdd.nID.ToString & vbTab & "" & vbTab & "" & vbTab & strFile)

                .set_RowHeight(.Rows - 1, 40)
                DoGroup(.Rows - 1, 0)
                .Tree.Column = 3

                Dim drjob As dsTKSI.tJobRow
                For Each drjob In (From row In drAdd.GettJobRows Order By row.sJobNo)

                    .AddItem(drAdd.nID.ToString & vbTab & drjob.nID.ToString & vbTab & "" & vbTab & "   JOB: " & drjob.sJobNo.ToString & vbTab & "" & vbTab & "" & vbTab & "" & vbTab & "")
                    DoGroup(.Rows - 1, 1)

                    'look for optional jobid to highlight as active
                    If drjob.nID = jobid Then

                        ' .set_Cell(CellPropertySettings.flexcpBackColor, .Rows - 1, 1, .Rows - 1, 3, cYellow)
                        .CellBackColor = cYellow
                        .Select(.Rows - 1, 3)
                    End If

                    Dim drPO As dsTKSI.tPOHeaderRow
                    For Each drPO In (From row In drjob.GettPOHeaderRows Order By row.sPONum.Replace("S", "").Replace("CR", "").Replace("W", "").Replace("O", "").Replace("A", "").Replace("B", "").Replace("C", "").Replace("D", "").PadLeft(13, "0"))

                        Dim strBin As String = ""
                        strBin = GetBinLabel(drPO.sPONum)
                        Dim spotitle As String = ""
                        If drPO.nAccount = 4040 Then
                            spotitle = "i PO: "
                        ElseIf drPO.nAccount = 4030 Then
                            spotitle = "h PO: "
                        Else

                            spotitle = "   PO: "
                        End If
                        strPO = drAdd.nID.ToString & vbTab & _
                        drjob.nID.ToString & vbTab & drPO.nID.ToString & _
                        vbTab & "  " & spotitle & drPO.sPONum.ToString & vbTab

                        If drPO.IsDRECNull Then
                            strPO = strPO & "" & vbTab
                        Else
                            strPO = strPO & "R" & vbTab
                        End If


                        If drPO.IsDDELNull Then
                            strPO = strPO & "" & vbTab
                        Else
                            strPO = strPO & "D" & vbTab
                        End If

                        If drPO.bSimply Then
                            strPO = strPO & "P"
                        Else
                            strPO = strPO & ""
                        End If

                        If drPO.IsDDELNull Then
                            strPO = strPO & vbTab & strBin
                        End If

                        .AddItem(strPO)
                        DoGroup(.Rows - 1, 2)
                    Next
                Next

                Me.Text = drAdd.sAddress1.ToString

            Next

            .set_Cell(CellPropertySettings.flexcpAlignment, 1, 1, .Rows - 1, 1, AlignmentSettings.flexAlignLeftCenter)

        End With

        gridJobLoc.Redraw = True

    End Sub

    Private Sub InitInvoices()
        Dim strSO As String
        Dim tempInvTotal As Decimal
        gridInvoices.Redraw = False
        Dim jobtotal1 As Decimal
        With gridInvoices
            .set_FixedAlignment(0, AlignmentSettings.flexAlignLeftCenter)
            .FixedCols = 0
            .FixedRows = 0
            .Cols = 5

            .Rows = 0
            .set_ColWidth(2, 220)
            .set_ColWidth(3, 35)
            .set_ColWidth(4, 35)

            .set_ColHidden(0, True)
            .set_ColHidden(1, True)

            .set_ColDataType(4, GetType(String))
            .AllowBigSelection = False
            .WordWrap = True
            .AddItem(drJob.nID & vbTab & "" & vbTab & "JOB: " & drJob.sJobNo & vbTab & "" & vbTab & "")

            DoGroupInv(.Rows - 1, 0)
            .Tree.Column = 2

            Dim drSo As dsTKSI.tSOHeaderRow
            For Each drSo In drJob.GettSOHeaderRows

                strSO = drSo.nJobID & vbTab & drSo.nID.ToString & vbTab & "  INV: " & drSo.sSONum.ToString & vbTab

                If drSo.IsdmailedNull Then
                    strSO = strSO & "" & vbTab
                Else
                    strSO = strSO & "I" & vbTab
                End If

                If drSo.IsdsimplyNull Then
                    strSO = strSO & ""
                Else
                    strSO = strSO & "S"
                End If

                .AddItem(strSO)
                DoGroupInv(.Rows - 1, 1)

            Next

            tempInvTotal = oJob.SOsByCode(9999, True)
            If IsNumeric(Me.txtJobTotal.Text) Then
                jobtotal1 = CDbl(Me.txtJobTotal.Text)
            End If

            Me.txtInvBalance.Text = TwoDecimal(tempInvTotal - jobtotal1)
        End With
        gridInvoices.Redraw = True

    End Sub

    Private Sub gridInvoices_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As C1.Win.C1FlexGrid.RangeEventArgs) Handles gridInvoices.BeforeRowColChange
        With gridInvoices
            If .Rows > 0 And eventArgs.OldRange.TopRow > -1 Then
                .set_Cell(CellPropertySettings.flexcpBackColor, eventArgs.OldRange.TopRow, 0, eventArgs.OldRange.TopRow, 2, cWhite)
                .set_Cell(CellPropertySettings.flexcpFontBold, eventArgs.OldRange.TopRow, 0, eventArgs.OldRange.TopRow, 2, False)
                .set_Cell(CellPropertySettings.flexcpBackColor, eventArgs.NewRange.TopRow, 0, eventArgs.NewRange.TopRow, 2, cYellow)
                .set_Cell(CellPropertySettings.flexcpFontBold, eventArgs.NewRange.TopRow, 0, eventArgs.NewRange.TopRow, 2, True)
            End If
        End With
    End Sub

    Private Sub gridInvoices_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles gridInvoices.DoubleClick

        Me.SaveJob()

        Dim level As Integer
        With gridInvoices
            level = .get_RowOutlineLevel(.RowSel)
            Select Case level
                Case 0
                    MsgBox("Choose an Invoice.")
                Case 1
                    .Select(.RowSel, 1)
                    If IsNumeric(.Text) And CDbl(.Text) > 0 Then
                        ShowInv(CInt(.Text))
                    Else
                        MsgBox("Error: grid ID is incorrect")
                    End If
            End Select
        End With
    End Sub

    Private Sub gridJobLoc_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As C1.Win.C1FlexGrid.RangeEventArgs) Handles gridJobLoc.BeforeRowColChange

        If gridJobLoc.Rows > 0 And eventArgs.OldRange.TopRow > -1 Then
            gridJobLoc.set_Cell(CellPropertySettings.flexcpBackColor, eventArgs.OldRange.TopRow, 0, eventArgs.OldRange.TopRow, 3, cWhite)
            gridJobLoc.set_Cell(CellPropertySettings.flexcpFontBold, eventArgs.OldRange.TopRow, 0, eventArgs.OldRange.TopRow, 3, False)
            gridJobLoc.set_Cell(CellPropertySettings.flexcpBackColor, eventArgs.NewRange.TopRow, 0, eventArgs.NewRange.TopRow, 3, cYellow)
            gridJobLoc.set_Cell(CellPropertySettings.flexcpFontBold, eventArgs.NewRange.TopRow, 0, eventArgs.NewRange.TopRow, 3, True)
        End If
    End Sub

    Private Sub gridJobLoc_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles gridJobLoc.DoubleClick
        Try
            Me.SaveJob()

            Dim level As Integer
            level = gridJobLoc.get_RowOutlineLevel(gridJobLoc.RowSel)
            Select Case level
                Case 0
                    MsgBox("Click a JOB or a PO.")
                Case 1
                    gridJobLoc.Select(gridJobLoc.RowSel, 1)
                    If IsNumeric(gridJobLoc.Text) Then
                        PopulateJob(CInt(gridJobLoc.Text))
                    End If
                Case 2
                    gridJobLoc.Select(gridJobLoc.RowSel, 2)
                    If IsNumeric(gridJobLoc.Text) And CDbl(gridJobLoc.Text) > 0 Then
                        ShowPO(CInt(gridJobLoc.Text))
                    Else
                        MsgBox("Error: grid ID is incorrect")
                    End If
            End Select
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error loading Job." & ex.Message)
        End Try

    End Sub

    Private Sub ShowPO(ByRef POID As Integer)
        Dim drPO As dsTKSI.tPOHeaderRow
        drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
        If Not drPO Is Nothing Then
            OpenPOScreen(drPO.nID, True)

            'if po screen deleted this row object then they related job will be 'nothing'
            If Not drPO.tJobRow Is Nothing Then
                Me.LoadJobByAddress(drPO.tJobRow.nAddressID, drPO.nJobID)
            Else
                Me.LoadJobByAddress(drAdd.nID)
            End If
        End If
    End Sub

    Private Sub ShowInv(ByRef SOID As Integer) 'SO and invoice are the same thing
        Try
            If Not Me.drJob Is Nothing Then
                Dim drSO As dsTKSI.tSOHeaderRow
                drSO = Me.DsTKSI1.tSOHeader.FindBynID(SOID)
                If Not drSO Is Nothing Then
                    Dim frmInv As frmInvoice
                    frmInv = New frmInvoice
                    frmInv.DsTKSI1 = Me.DsTKSI1
                    frmInv.drSO = drSO 'give frmPO a reference to the PO object
                    frmInv.ShowDialog()
                    Me.LoadJobByAddress(drJob.nAddressID, drJob.nID)
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtContractDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtContractDate.Enter
        txtContractDate.SelectionStart = 0
        txtContractDate.SelectionLength = Len(txtContractDate.Text)
    End Sub

    Private Sub txtDrawingDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDrawingDate.Enter
        txtDrawingDate.SelectionStart = 0
        txtDrawingDate.SelectionLength = Len(txtDrawingDate.Text)
    End Sub

    Private Sub txtJobLabor_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtJobLabor.Enter
        txtJobLabor.SelectionStart = 0
        txtJobLabor.SelectionLength = Len(txtJobLabor.Text)
    End Sub

    Private Sub txtJobMaterials_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtJobMaterials.Enter
        txtJobMaterials.SelectionStart = 0
        txtJobMaterials.SelectionLength = Len(txtJobMaterials.Text)
    End Sub

    Private Sub jobtotal()
        Try
            Dim lab, total, mat As Decimal
            Dim tax As Double

            If IsNumeric(txtJobLabor.Text) Then
                lab = CDec(txtJobLabor.Text)
            End If

            If IsNumeric(txtJobMaterials.Text) Then
                mat = CDec(txtJobMaterials.Text)
            End If

            If IsNumeric(Mid(txtJobTaxRate.Text, 1, 5)) Then
                tax = CDbl(Mid(txtJobTaxRate.Text, 1, 5))
            End If

            total = ((mat * (tax / 100)) + mat) + lab + 0.001
            Me.txtJobTotal.Text = TwoDecimal(total)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Could not calculate job total.")
        End Try

    End Sub

    Private Sub txtJobMaterials_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJobMaterials.TextChanged
        Try
            If IsNumeric(txtJobMaterials.Text) Then
                Me.drJob.nMaterialsCharge = CDec(txtJobMaterials.Text)
                jobtotal()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtJobLabor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJobLabor.TextChanged
        Try
            If IsNumeric(txtJobLabor.Text) Then
                drJob.nLaborCharge = CDec(txtJobLabor.Text)
                jobtotal()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtDrawingDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrawingDate.Leave
        Try
            If IsDate2(txtDrawingDate.Text) Then
                drJob.dDrawing = CDate(txtDrawingDate.Text)
            ElseIf Len(txtDrawingDate.Text) > 0 Then
                MsgBox("Did not save date, not correct format")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub JobEdit_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If sUserlevel >= UserRights.Shipping Then
                'dont save, they are not allowed to change this data
            Else
                Me.SaveJob()
                If CDbl(Me.txtBalance.Text) <> 0 Then MsgBox("BALANCE IS NOT ZERO!", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub getPOTotals(ByRef drJob As dsTKSI.tJobRow, ByRef SALE4010 As Decimal, ByRef SALE4030 As Decimal, ByRef SALE4040 As Decimal, ByRef SALE4070 As Decimal, ByRef SALETOTAL As Decimal, ByRef COST5010 As Decimal, ByRef COST5030 As Decimal, ByRef COST5040 As Decimal, ByRef COST5070 As Decimal, ByRef COSTTOTAL As Decimal)

        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In drJob.GettPOHeaderRows
            If UCase(drPO.sPOType) = "PO" Or UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                Select Case drPO.nAccount
                    Case 4010
                        SALE4010 += +drPO.nRetailSale + drPO.nAdd
                    Case 4020 'TOPS AND CABINETRY GO TOGETHER ON THIS SUMMARY 4010 and 4020
                        SALE4010 += drPO.nRetailSale + drPO.nAdd
                    Case 4030
                        SALE4030 += +drPO.nRetailSale + drPO.nAdd
                    Case 4040
                        SALE4040 += +drPO.nRetailSale + drPO.nAdd
                End Select
                SALETOTAL = SALETOTAL + drPO.nRetailSale + drPO.nAdd
                SALE4070 = SALE4070 + drPO.nRetailFreight
                Dim drPOLine As dsTKSI.tPOLineRow

                For Each drPOLine In drPO.GettPOLineRows
                    If UCase(drPOLine.sType) = "ITEM" Then

                        Select Case drPOLine.nAccountID
                            Case 5010
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5270
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5020
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5030
                                COST5030 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5040
                                COST5040 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5070
                                COST5070 += drPOLine.nCost
                                'somehow only include cost for shipping on PO that is a jobcost
                                'for jobs starting 2006 and newer
                                'does sale need to be included?
                                If drJob.dJobCreated > CDate("1/1/2006") Then
                                    If UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                                        COSTTOTAL += drPOLine.nCost
                                    End If
                                End If

                            Case Else
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += +drPOLine.nCost

                        End Select
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvImages.Click
        Dim item1 As ListViewItem

        'garbage collect so image doesnt get locked in file system forever
        Try
            If Not Me.PictureBox1 Is Nothing Then
                If Not Me.PictureBox1.Image Is Nothing Then
                    Me.PictureBox1.Image.Dispose()
                End If
            End If

        Catch ex As Exception
        End Try
        Try
            For Each item1 In Me.lvImages.SelectedItems
                If IO.File.Exists(item1.Text) Then
                    If item1.Text.ToUpper.Contains(".PDF") Then
                        Process.Start(item1.Text)
                    ElseIf item1.Text.ToUpper.Contains("JPG") Or item1.Text.ToUpper.Contains("TIF") Or item1.Text.ToUpper.Contains("BMP") Then
                        Try
                            Me.PictureBox1.Image = Image.FromFile(item1.Text)
                        Catch ex As Exception
                            MessageBox.Show("error showing image, it could be locked or not a valid image. " & item1.Text)
                        End Try

                    End If

                End If
            Next
        Catch

        End Try

    End Sub

    'Private Sub LoadImageListView()
    '    Me.lvImages.Items.Clear()

    '    Dim item1 As ListViewItem
    '    For Each item1 In Me.lvImages.SelectedItems
    '        If IO.File.Exists(item1.Text) Then
    '            Me.PictureBox1.Image = Image.FromFile(item1.Text)
    '        End If
    '    Next
    'End Sub

    Private Sub Acquire(ByVal bln11x17 As Boolean)
        Try
            'If Me.chkCredit.Checked And Me.chkMap.Checked Then
            '    MessageBox.Show("Credit and Map are both selected, this is not supported, please try again.")
            '    Exit Try
            'End If

            Dim WiaObj As WIA.CommonDialog
            Dim WiaDev As WIA.Device
            Dim wiaImg As WIA.ImageFile
            wiaImg = New WIA.ImageFile

            WiaObj = New WIA.CommonDialog

            If WiaDev Is Nothing Then ' WiaDev is defined globally
                WiaDev = WiaObj.ShowSelectDevice( _
                WIA.WiaDeviceType.ScannerDeviceType, True, False)
            End If
            Dim Itm As WIA.Item
            Dim ItmProp As WIA.Property

            For Each Itm In WiaDev.Items
                For Each ItmProp In Itm.Properties

                    Select Case ItmProp.Name
                        Case "Media Type"
                            ' ItmProp.Value = 128
                        Case "Bits Per Pixel"
                            ' ItmProp.Value = 1
                            '    Case "brightness"
                            '    Case "Threshold"
                    End Select

                    Select Case ItmProp.PropertyID
                        Case 6159 ' threshold
                            Try
                                ItmProp.Value = 160
                            Catch ex As Exception

                            End Try
                            'Dim k As Integer
                            'For k = 0 To 999
                            '    Try
                            '        ItmProp.Value = k
                            '        Debug.Print(k & " good")
                            '    Catch ex As Exception
                            '        'Debug.Print(k & "  no good")
                            '    End Try
                            'Next
                        Case 6154 'Brightness
                            Try
                                ItmProp.Value = 1
                            Catch ex As Exception
                                ' ItmProp.Value = 70
                            End Try

                        Case 6147 ' Horizontal Resolution

                            ItmProp.Value = 300
                        Case 6148 ' Vertical Resolution
                            ItmProp.Value = 300
                        Case 6151 ' Horizontal Extent (Scanning Area)
                            If bln11x17 Then
                                ItmProp.Value = 3300
                            Else
                                ItmProp.Value = 2550
                            End If

                        Case 6152 ' Vertical Extent (Scanning Area)
                            If bln11x17 Then
                                ItmProp.Value = 5100
                            Else
                                ItmProp.Value = 3300
                            End If
                            'ItmProp.Value = 3300
                            'ItmProp.Value = 5100
                        Case 6149 ' Horizontal Starting Position (Scanning Area)
                            ItmProp.Value = 0
                        Case 6150 ' Vertical Starting Position (Scanning Area)
                            ItmProp.Value = 0
                        Case 6146 ' Current Intent
                            ItmProp.Value = 4 ' Text or Line Art
                    End Select
                Next

                Dim sJob5 As String = Mid(Me.drJob.sJobNo, 1, 6)
                If IsNumeric(sJob5) Then
                    'leave as 6 digit for folder/file creation
                ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                    sJob5 = Mid(sJob5, 1, 5)
                Else
                    sJob5 = Mid(sJob5, 1, 4)
                End If

                If Not IO.Directory.Exists(sImagesPath & sJob5 & "\") Then
                    IO.Directory.CreateDirectory(sImagesPath & sJob5 & "\")
                End If
                If Not IO.Directory.Exists(sImagesPath & sJob5 & "\" & Me.drJob.sJobNo & "\") Then
                    IO.Directory.CreateDirectory(sImagesPath & sJob5 & "\" & Me.drJob.sJobNo & "\")
                End If


                Dim i As Integer = 0
                Try
                    Dim offset As Integer
                    For i = 1 To 100
                        offset = 0
                        Try
                            wiaImg = WiaObj.ShowTransfer(Itm)
                        Catch ex As Exception
                            'we just keep going until the scanner errors because there is nothing left in the feeder
                            Exit For
                        End Try

                        Dim strFileName As String = ""
                        If Me.chkMap.Checked Then

                            sJob5 = Mid(Me.drJob.sJobNo, 1, 6)
                            If IsNumeric(sJob5) Then
                                'leave as 6 digit for folder/file creation
                            ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                                sJob5 = Mid(sJob5, 1, 5)
                            Else
                                sJob5 = Mid(sJob5, 1, 4)
                            End If

                            If Not IO.Directory.Exists(sImagesPath & sJob5 & "\MAPS\") Then
                                IO.Directory.CreateDirectory(sImagesPath & sJob5 & "\MAPS\")
                            End If
                            Do
                                strFileName = sImagesPath & sJob5 & "\MAPS\" & i + offset & ".tif"
                                offset += 1
                            Loop Until Not IO.File.Exists(strFileName)
                            wiaImg.SaveFile(strFileName)
                        Else
                            Do
                                strFileName = sImagesPath & sJob5 & "\" & Me.drJob.sJobNo & "\" & i + offset & ".tif"
                                offset += 1
                            Loop Until Not IO.File.Exists(strFileName)
                            wiaImg.SaveFile(strFileName)
                        End If
                    Next
                Catch ex As Exception
                    Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Next

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.chkMap.Checked = False
        'Me.chkCredit.Checked = False

        Me.LoadJobimages(Me.drJob)

    End Sub

    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click

        Me.Acquire(Me.chk11x17.Checked)

    End Sub


    '#Region " twainlib event handlers  "

    '    Private Sub _tw_CloseDsOkEvent() _
    '    Handles _tw.CloseDsOkEvent
    '        'OK button from DsUi selected

    '        Try
    '            Me.Text = ("Ok selected")
    '            tw_EndingScan()
    '        Catch ex As Exception
    '            Me.Text = ("huh? " & ex.ToString)
    '        End Try

    '    End Sub

    '    Private Sub _tw_CloseRequestEvent() _
    '    Handles _tw.CloseRequestEvent
    '        'cancel button from DsUi selected
    '        Me.Text = ("Cancel selected")
    '        tw_EndingScan()

    '    End Sub

    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <remarks></remarks>
    '    Private Sub tw_Failure() _
    '    Handles _tw.FailureEvent

    '        Me.Text = ("Failure event")
    '        tw_EndingScan()

    '    End Sub

    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <remarks></remarks>
    '    Private Sub tw_TransferReady() _
    '    Handles _tw.TransferReadyEvent

    '        Try

    '            If Not _tw.Images.Count > 0 Then
    '                Me.Text = ("No results")

    '            Else 'look we have results...

    '                For Each path As String In _tw.Images
    '                    Me.Text = (path)
    '                Next

    '            End If

    '        Catch ex As Exception
    '            Me.Text = (ex.ToString)

    '        End Try

    '    End Sub

    '    ''' <summary>
    '    ''' 
    '    ''' </summary>
    '    ''' <remarks></remarks>
    '    Private Sub tw_EndingScan() _
    '    Handles _tw.EndScanEvent

    '        Me.Text = ("tw_EndingScan")

    '    End Sub

    '#End Region

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvImages.DoubleClick
        Dim frm1 As New frmFullpage
        frm1.PictureBox1.Image = Me.PictureBox1.Image.Clone
        frm1.Show()
    End Sub


    Private Sub btnAttachImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttachImg.Click
        If drJob Is Nothing Then
            MessageBox.Show("Select a job first.")
        Else
            Me.OpenFileDialog1.ShowDialog()

            If Me.OpenFileDialog1.FileName.Length > 0 Then
                If IO.File.Exists(Me.OpenFileDialog1.FileName) Then

                    Dim sJob5 As String = Mid(Me.drJob.sJobNo, 1, 6)
                    If IsNumeric(sJob5) Then
                        'leave as 6 digit for folder/file creation
                    ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                        sJob5 = Mid(sJob5, 1, 5)
                    Else
                        sJob5 = Mid(sJob5, 1, 4)
                    End If

                    If Not IO.Directory.Exists(sImagesPath & sJob5 & "\") Then
                        IO.Directory.CreateDirectory(sImagesPath & sJob5 & "\")
                    End If
                    If Not IO.Directory.Exists(sImagesPath & sJob5 & "\" & Me.drJob.sJobNo & "\") Then
                        IO.Directory.CreateDirectory(sImagesPath & sJob5 & "\" & Me.drJob.sJobNo & "\")
                    End If

                    Dim strImage As String = ""
                    strImage = Me.OpenFileDialog1.FileName

                    Dim blnIsPDF As Boolean = False
                    If strImage.ToUpper.Contains(".PDF") Then
                        blnIsPDF = True
                    End If

                    Dim offset As Integer = 0
                    Dim strFileName As String = ""
                    If Me.chkMap.Checked Then

                        If Not IO.Directory.Exists(sImagesPath & sJob5 & "\MAPS\") Then
                            IO.Directory.CreateDirectory(sImagesPath & sJob5 & "\MAPS\")
                        End If

                        Do
                            strFileName = sImagesPath & sJob5 & "\MAPS\" & 1 + offset

                            If blnIsPDF Then
                                strFileName = strFileName & ".pdf"
                            Else
                                strFileName = strFileName & ".tif"
                            End If

                            offset += 1
                        Loop Until Not IO.File.Exists(strFileName)

                        IO.File.Copy(strImage, strFileName)

                    Else

                        Do

                            strFileName = sImagesPath & sJob5 & "\" & Me.drJob.sJobNo & "\" & 1 + offset

                            If blnIsPDF Then
                                strFileName = strFileName & ".pdf"
                            Else
                                strFileName = strFileName & ".tif"
                            End If

                            offset += 1

                        Loop Until Not IO.File.Exists(strFileName)

                        IO.File.Copy(strImage, strFileName)
                    End If


                    Me.chkMap.Checked = False

                    Me.LoadJobimages(Me.drJob)
                End If
            End If
        End If

    End Sub


    Private Sub btnDeleteImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteImage.Click
        Try
            If Not Me.PictureBox1.IsDisposed Then
                If Not Me.PictureBox1.Image Is Nothing Then
                    Me.PictureBox1.Image.Dispose()
                End If
            End If

            Me.PictureBox1.Image = Nothing
            If Me.lvImages.SelectedItems.Count > 0 Then
                Dim strFile As String = Me.lvImages.SelectedItems(0).Text
                If IO.File.Exists(strFile) Then
                    IO.File.Delete(strFile)
                    Me.LoadJobimages(Me.drJob)
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Could not delete, file is in use.")
        End Try

    End Sub

    Private Sub TblJobActivityDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblJobActivityDataGridView.RowLeave
        If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then

            Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(0).Value = Guid.NewGuid
            Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(1).Value = Me.drJob.nID
            If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(2).Value Is DBNull.Value Then
                Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(2).Value = Now
            End If

            If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(3).Value Is DBNull.Value Then
                Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(3).Value = "MISC"
            End If

            If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(4).Value Is DBNull.Value Then
                Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(4).Value = ""
            End If

            Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(5).Value = ""

        End If
    End Sub

    Private Sub TblJobActivityDataGridView_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TblJobActivityDataGridView.Validated
        Try
            Me.Validate()
            Me.TblJobActivityBindingSource.EndEdit()
            Dim drAct As TKSIJOBSDataSet.tblJobActivityRow

            Me.TblJobActivityTableAdapter.Update(Me.TKSIJOBSDataSet.tblJobActivity)

            For Each drAct In Me.TKSIJOBSDataSet.tblJobActivity
                If drAct.ActivityType.Trim = "MISC" And drAct.ActivityDetail.Trim = "" Then
                    drAct.Delete()
                End If
            Next

            Me.TblJobActivityTableAdapter.Update(Me.TKSIJOBSDataSet.tblJobActivity)
        Catch ex As Exception
            '???
        End Try
    End Sub

    Private Sub PrintDocument8x11_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument8x11.PrintPage
        Me.iCurrentPagePrinting += 1
        Dim img1 As Image
        If Me.alImagesToPrint8x11.Count > 0 And Me.alImagesToPrint8x11.Count >= Me.iCurrentPagePrinting - 1 Then
            img1 = Me.alImagesToPrint8x11(Me.iCurrentPagePrinting - 1)
            e.Graphics.DrawImage(img1, 0, 0, 850, 1100)
        End If

        If Me.iCurrentPagePrinting >= Me.alImagesToPrint8x11.Count Then
            Me.iCurrentPagePrinting = 0
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If

    End Sub

    Private alImagesToPrint8x11 As New List(Of Image) ' ArrayList
    Private alImagesToPrint11x17 As New List(Of Image) ' ArrayList
    Private iCurrentPagePrinting As Integer = 0

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            alImagesToPrint8x11.Clear()
            alImagesToPrint11x17.Clear()

            If (Me.PictureBox1.Image.Width / Me.PictureBox1.Image.Height > 0.7) Then
                Me.alImagesToPrint8x11.Add(Me.PictureBox1.Image)
            Else
                Me.alImagesToPrint11x17.Add(Me.PictureBox1.Image)
            End If

            'begin printing
            Dim settings As New System.Drawing.Printing.PrinterSettings
            If Me.alImagesToPrint8x11.Count > 0 Then
                Me.PrintDocument8x11.PrinterSettings.PrinterName = settings.PrinterName
                Dim print1 As New System.Drawing.Printing.PageSettings
                print1.Landscape = False
                With print1
                    Try
                        Dim paper As Long
                        paper = GetLetterPaperEnum(print1)
                        If paper >= 0 Then
                            .PaperSize = .PrinterSettings.PaperSizes(paper)
                        End If
                    Catch ex As Exception
                    End Try
                    .PrinterSettings.PrinterName = settings.PrinterName
                    .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                    .Margins.Bottom = 0
                    .Margins.Left = 0
                    .Margins.Top = 0
                    .Margins.Right = 0
                End With

                Me.PrintDocument8x11.DefaultPageSettings = print1

                Me.PrintDocument8x11.Print()
            End If

            If Me.alImagesToPrint11x17.Count > 0 Then
                Me.PrintDocument11x17.PrinterSettings.PrinterName = settings.PrinterName
                Dim print2 As New System.Drawing.Printing.PageSettings
                print2.Landscape = False
                With print2
                    Try
                        Dim paper As Long
                        paper = GetLetterPaperEnum(print2, "11 x 17")
                        If paper >= 0 Then
                            .PaperSize = .PrinterSettings.PaperSizes(paper)
                        Else
                            paper = GetLetterPaperEnum(print2, "11x17")
                            If paper >= 0 Then
                                .PaperSize = .PrinterSettings.PaperSizes(paper)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                    .PrinterSettings.PrinterName = settings.PrinterName
                    .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                    .Margins.Bottom = 0
                    .Margins.Left = 0
                    .Margins.Top = 0
                    .Margins.Right = 0
                End With
                Me.PrintDocument11x17.DefaultPageSettings = print2

                Me.PrintDocument11x17.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("error printing: " & ex.Message)
        End Try


    End Sub

    Private Sub PrintDocument11x17_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument11x17.PrintPage
        Dim settings As New System.Drawing.Printing.PrinterSettings
        Me.PrintDocument11x17.PrinterSettings.PrinterName = settings.PrinterName
        Dim print2 As New System.Drawing.Printing.PageSettings
        print2.Landscape = False
        With print2
            Try
                Dim paper As Long
                paper = GetLetterPaperEnum(print2, "11 x 17")
                If paper >= 0 Then
                    .PaperSize = .PrinterSettings.PaperSizes(paper)
                Else
                    paper = GetLetterPaperEnum(print2, "11x17")
                    If paper >= 0 Then
                        .PaperSize = .PrinterSettings.PaperSizes(paper)
                    End If
                End If
            Catch ex As Exception
            End Try
            .PrinterSettings.PrinterName = settings.PrinterName
            .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            .Margins.Bottom = 0
            .Margins.Left = 0
            .Margins.Top = 0
            .Margins.Right = 0
        End With

        Me.PrintDocument11x17.DefaultPageSettings = print2

        Me.iCurrentPagePrinting += 1
        Dim img1 As Image
        img1 = Me.alImagesToPrint11x17(Me.iCurrentPagePrinting - 1)

        e.Graphics.DrawImage(img1, 0, 0, 1100, 1700)

        If Me.iCurrentPagePrinting >= Me.alImagesToPrint11x17.Count Then
            Me.iCurrentPagePrinting = 0
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Function CreateImageListArray() As List(Of String) ' ArrayList
        Dim item1 As ListViewItem
        Dim alImages As New List(Of String)
        For Each item1 In Me.lvImages.Items
            alImages.Add(item1.Text)
        Next
        Return alImages
    End Function

    Private Sub btnAddSWO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSWO.Click
        If Not Me.drJob Is Nothing Then
            Dim frm1 As New frmSWO1
            Dim gidSWO As Guid
            frm1.PictureBox1.Image = Me.PictureBox1.Image
            gidSWO = frm1.CreateSWO(Me.drJob.nID, Me.drJob.nAddressID, Me.drJob.nCustID, Me.drJob.sSalesperson, "SWO-PO", Me.cmbTerms.Text)
            frm1.LoadSWO(gidSWO, CreateImageListArray)
            frm1.ShowDialog()
            Me.LoadJobByAddress(Me.drJob.nAddressID, drJob.nID)
        Else
            Windows.Forms.MessageBox.Show("Select a previous Job before adding an SWO.")
        End If

    End Sub

    Private Sub lvSWOPending_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSWOPending.DoubleClick
        Try
            If Me.lvSWOPending.SelectedItems.Count > 0 Then
                Dim sGuid As String = Me.lvSWOPending.SelectedItems(0).Text
                Dim frm1 As New frmSWO1
                frm1.LoadSWO(New Guid(sGuid), CreateImageListArray)
                frm1.ShowDialog()
                Me.LoadJobByAddress(Me.drJob.nAddressID, drJob.nID)
            End If
        Catch
            Windows.Forms.MessageBox.Show("Images resetting, please re-load SWO.")
        End Try

    End Sub

    Private Sub btnSWODelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSWODelete.Click
        Try
            If Me.lvSWOPending.SelectedItems.Count > 0 Then
                Dim sGuid As String = Me.lvSWOPending.SelectedItems(0).Text
                If Windows.Forms.MessageBox.Show("Are you sure you want to delete this SWO?", "Delete SWO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Yes Then
                    Dim frm1 As New frmSWO1
                    frm1.DeleteSWO(New Guid(sGuid))
                    frm1.Close()
                    Me.LoadSWOGrid()
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("ERROR btnSWODelete_Click " & ex.Message)
        End Try

    End Sub

    Private Sub btnAddPartsOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Me.drJob Is Nothing Then
            Dim frm1 As New frmSWO1

            With frm1
                .txtSWOHeader.Text = "Parts Order"
                .btnApprove.Text = "Approve Parts"
                .btnRejectSWO.Text = "Reject Parts"

                .lblDateOfOrder.Visible = False
                .lblDateReq.Visible = False
                .txtDateofOrder.Visible = False
                .txtDateReq.Visible = False

                .lblSWOType.Visible = False
                .lblSWOType2.Visible = False
                .lblSWOType3.Visible = False

                .chkJobcost.Visible = False
                .chkSWO.Visible = False
                .chkWarranty.Visible = False

                .txtTripCharge.Visible = False
                .lbltripCharge.Visible = False
                .txtLabor.Visible = False
                .lblLabor.Visible = False

                .txtDetails1.Visible = False
                .txtDetails2.Visible = False
                .txtDetails3.Visible = False

                .txtDetails4.Visible = False
                .txtDetails5.Visible = False
                .txtDetails6.Visible = False

                .txtDetails7.Visible = False
                .txtDetails8.Visible = False
                .txtDetails9.Visible = False
                .lblSWODetails.Visible = False
                .btnPrintSWO.Visible = False

                .btnBold1.Visible = False
                .btnBold2.Visible = False
                .btnBold3.Visible = False
                .btnBold4.Visible = False
                .btnBold5.Visible = False
                .btnBold6.Visible = False
                .btnBold7.Visible = False
                .btnBold8.Visible = False
                .btnBold9.Visible = False

            End With
            Dim gidSWO As Guid

            gidSWO = frm1.CreateSWO(Me.drJob.nID, Me.drJob.nAddressID, Me.drJob.nCustID, Me.drJob.sSalesperson, "PO", Me.cmbTerms.Text)

            frm1.LoadSWO(gidSWO, CreateImageListArray)
            frm1.ShowDialog()

            Me.LoadJobByAddress(Me.drJob.nAddressID, drJob.nID)
        Else
            Windows.Forms.MessageBox.Show("Select a previous Job before adding an SWO.")
        End If
    End Sub

    'Private Sub btnNewStylePO_Click(sender As Object, e As EventArgs) Handles btnNewStylePO.Click
    '    gridJobLoc.Select(gridJobLoc.RowSel, 2)
    '    If IsNumeric(gridJobLoc.Text) Then
    '        Dim POID As Integer = CInt(gridJobLoc.Text)
    '        Dim wpfPO As New POwpf(POID, Me.dc)
    '        wpfPO.Show()
    '    Else
    '        MsgBox("Error: grid ID is incorrect")
    '    End If


    'End Sub

    'Private Sub lvImages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvImages.SelectedIndexChanged

    'End Sub
End Class
