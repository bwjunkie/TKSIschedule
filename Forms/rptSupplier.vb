Option Strict Off
Option Explicit On
Option Compare Text
Imports VB = Microsoft.VisualBasic
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports System.Drawing
Imports System.Windows.Forms

Friend Class rptSupplier
	Inherits System.Windows.Forms.Form
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
    Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents txtPOsearch As System.Windows.Forms.TextBox
	Public WithEvents cmdPOSearch As System.Windows.Forms.Button
    Public WithEvents gridSupplier As C1FlexGridClassic
	Public WithEvents cmdRecord As System.Windows.Forms.Button
	Public WithEvents cmbType As System.Windows.Forms.ComboBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents gridDate As C1FlexGridClassic
    Public WithEvents gridReport As C1FlexGridClassic
	Public WithEvents lblPOsearch As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TksijobsDataSet1 As TKSISchedule.TKSIJOBSDataSet
    Friend WithEvents TblJobActivityTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents daPOHeaderByDateRequired As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLinesByDateRequired As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderByDateReqRangeVendorID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLinesByDateRequiredVendorID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderCONF As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLinesByCONF As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lblTruck As System.Windows.Forms.Label
    Friend WithEvents txtTruckNum As System.Windows.Forms.TextBox
    Public WithEvents btnExportToText As System.Windows.Forms.Button
    Friend WithEvents daVendor As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSupplier))
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.txtPOsearch = New System.Windows.Forms.TextBox()
        Me.cmdPOSearch = New System.Windows.Forms.Button()
        Me.gridSupplier = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.cmdRecord = New System.Windows.Forms.Button()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.gridDate = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.gridReport = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.lblPOsearch = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daVendor = New System.Data.SqlClient.SqlDataAdapter()
        Me.TksijobsDataSet1 = New TKSISchedule.TKSIJOBSDataSet()
        Me.TblJobActivityTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.daPOHeaderByDateRequired = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLinesByDateRequired = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderByDateReqRangeVendorID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLinesByDateRequiredVendorID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderCONF = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLinesByCONF = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.lblTruck = New System.Windows.Forms.Label()
        Me.txtTruckNum = New System.Windows.Forms.TextBox()
        Me.btnExportToText = New System.Windows.Forms.Button()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(648, 616)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(137, 25)
        Me.cmdRefresh.TabIndex = 10
        Me.cmdRefresh.Text = "Refresh Report"
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'txtPOsearch
        '
        Me.txtPOsearch.AcceptsReturn = True
        Me.txtPOsearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtPOsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPOsearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOsearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPOsearch.Location = New System.Drawing.Point(216, 616)
        Me.txtPOsearch.MaxLength = 0
        Me.txtPOsearch.Name = "txtPOsearch"
        Me.txtPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPOsearch.Size = New System.Drawing.Size(105, 20)
        Me.txtPOsearch.TabIndex = 8
        '
        'cmdPOSearch
        '
        Me.cmdPOSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPOSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPOSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPOSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPOSearch.Location = New System.Drawing.Point(320, 616)
        Me.cmdPOSearch.Name = "cmdPOSearch"
        Me.cmdPOSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPOSearch.Size = New System.Drawing.Size(65, 25)
        Me.cmdPOSearch.TabIndex = 7
        Me.cmdPOSearch.Text = "PO Search"
        Me.cmdPOSearch.UseVisualStyleBackColor = False
        '
        'gridSupplier
        '
        Me.gridSupplier.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.gridSupplier.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gridSupplier.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridSupplier.Location = New System.Drawing.Point(8, 344)
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.NodeClosedPicture = Nothing
        Me.gridSupplier.NodeOpenPicture = Nothing
        Me.gridSupplier.OutlineCol = -1
        Me.gridSupplier.Size = New System.Drawing.Size(112, 265)
        Me.gridSupplier.StyleInfo = resources.GetString("gridSupplier.StyleInfo")
        Me.gridSupplier.TabIndex = 6
        Me.gridSupplier.TreeColor = System.Drawing.Color.DarkGray
        '
        'cmdRecord
        '
        Me.cmdRecord.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRecord.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRecord.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRecord.Location = New System.Drawing.Point(504, 616)
        Me.cmdRecord.Name = "cmdRecord"
        Me.cmdRecord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRecord.Size = New System.Drawing.Size(129, 25)
        Me.cmdRecord.TabIndex = 5
        Me.cmdRecord.Text = "Record Changes"
        Me.cmdRecord.UseVisualStyleBackColor = False
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbType.Items.AddRange(New Object() {"Standard", "Confirmation", "Receiving", "All"})
        Me.cmbType.Location = New System.Drawing.Point(8, 8)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbType.Size = New System.Drawing.Size(120, 22)
        Me.cmbType.TabIndex = 4
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(8, 616)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(105, 25)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'gridDate
        '
        Me.gridDate.ColumnInfo = "10,1,0,90,0,100,Columns:"
        Me.gridDate.ColWidthMin = 90
        Me.gridDate.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gridDate.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridDate.Location = New System.Drawing.Point(8, 56)
        Me.gridDate.Name = "gridDate"
        Me.gridDate.NodeClosedPicture = Nothing
        Me.gridDate.NodeOpenPicture = Nothing
        Me.gridDate.OutlineCol = -1
        Me.gridDate.Size = New System.Drawing.Size(112, 281)
        Me.gridDate.StyleInfo = resources.GetString("gridDate.StyleInfo")
        Me.gridDate.TabIndex = 1
        Me.gridDate.TreeColor = System.Drawing.Color.DarkGray
        '
        'gridReport
        '
        Me.gridReport.BackColorSel = System.Drawing.Color.Yellow
        Me.gridReport.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridReport.FixedCols = 0
        Me.gridReport.FixedRows = 0
        Me.gridReport.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gridReport.ForeColorSel = System.Drawing.Color.Black
        Me.gridReport.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridReport.Location = New System.Drawing.Point(128, 8)
        Me.gridReport.Name = "gridReport"
        Me.gridReport.NodeClosedPicture = Nothing
        Me.gridReport.NodeOpenPicture = Nothing
        Me.gridReport.OutlineCol = -1
        Me.gridReport.Size = New System.Drawing.Size(697, 601)
        Me.gridReport.StyleInfo = resources.GetString("gridReport.StyleInfo")
        Me.gridReport.TabIndex = 0
        Me.gridReport.TreeColor = System.Drawing.Color.DarkGray
        '
        'lblPOsearch
        '
        Me.lblPOsearch.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOsearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPOsearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOsearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPOsearch.Location = New System.Drawing.Point(392, 616)
        Me.lblPOsearch.Name = "lblPOsearch"
        Me.lblPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPOsearch.Size = New System.Drawing.Size(89, 17)
        Me.lblPOsearch.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week of:"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERV" & _
    "ER;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@dCreateRecord", System.Data.SqlDbType.DateTime, 4, "dCreateRecord"), New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID"), New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipto3", System.Data.SqlDbType.VarChar, 50, "sShipto3"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShiptoCounty", System.Data.SqlDbType.VarChar, 50, "sShiptoCounty"), New System.Data.SqlClient.SqlParameter("@nBoxes", System.Data.SqlDbType.Int, 4, "nBoxes"), New System.Data.SqlClient.SqlParameter("@dPODate", System.Data.SqlDbType.DateTime, 4, "dPODate"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@sEnteredBy", System.Data.SqlDbType.VarChar, 50, "sEnteredBy"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Float, 8, "nTotal"), New System.Data.SqlClient.SqlParameter("@sVia", System.Data.SqlDbType.VarChar, 50, "sVia"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@nRetailSale", System.Data.SqlDbType.Float, 8, "nRetailSale"), New System.Data.SqlClient.SqlParameter("@nSaleAccount", System.Data.SqlDbType.Int, 4, "nSaleAccount"), New System.Data.SqlClient.SqlParameter("@nRetailFreight", System.Data.SqlDbType.Float, 8, "nRetailFreight"), New System.Data.SqlClient.SqlParameter("@sConf", System.Data.SqlDbType.VarChar, 50, "sConf"), New System.Data.SqlClient.SqlParameter("@nAdd", System.Data.SqlDbType.Float, 8, "nAdd"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@DFAXED", System.Data.SqlDbType.DateTime, 4, "DFAXED"), New System.Data.SqlClient.SqlParameter("@nAccount", System.Data.SqlDbType.Int, 4, "nAccount"), New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@sItems", System.Data.SqlDbType.VarChar, 50, "sItems"), New System.Data.SqlClient.SqlParameter("@sItemDesc", System.Data.SqlDbType.VarChar, 50, "sItemDesc"), New System.Data.SqlClient.SqlParameter("@sPOType", System.Data.SqlDbType.VarChar, 50, "sPOType"), New System.Data.SqlClient.SqlParameter("@nsalesadjust", System.Data.SqlDbType.Money, 8, "nsalesadjust"), New System.Data.SqlClient.SqlParameter("@sAdjustReason", System.Data.SqlDbType.VarChar, 255, "sAdjustReason"), New System.Data.SqlClient.SqlParameter("@sCurActNote", System.Data.SqlDbType.VarChar, 255, "sCurActNote"), New System.Data.SqlClient.SqlParameter("@nPOSort", System.Data.SqlDbType.Int, 4, "nPOSort")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@DFAXED", System.Data.SqlDbType.DateTime, 4, "DFAXED"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DFAXED", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DFAXED", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DFAXED", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DFAXED", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bSimply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreateRecord", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreateRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dPODate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dPODate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dRequired", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dSimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAdd", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAdd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nBoxes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nBoxes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOSort", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOSort", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailFreight", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailFreight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailSale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSaleAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSaleAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nVendorID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nVendorID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nsalesadjust", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nsalesadjust", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sAdjustReason", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAdjustReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sConf", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCurActNote", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCurActNote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sEnteredBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sEnteredBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItemDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItemDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItems", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItems", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPOType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPOType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipto3", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipto3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShiptoCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShiptoCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daPOHeaderALL
        '
        Me.daPOHeaderALL.DeleteCommand = Me.SqlDeleteCommand1
        Me.daPOHeaderALL.InsertCommand = Me.SqlInsertCommand1
        Me.daPOHeaderALL.SelectCommand = Me.SqlSelectCommand1
        Me.daPOHeaderALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPOHeaderALL.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax FROM dbo.tVendor"
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        '
        'daVendor
        '
        Me.daVendor.SelectCommand = Me.SqlSelectCommand2
        Me.daVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        '
        'TksijobsDataSet1
        '
        Me.TksijobsDataSet1.DataSetName = "TKSIJOBSDataSet"
        Me.TksijobsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblJobActivityTableAdapter1
        '
        Me.TblJobActivityTableAdapter1.ClearBeforeFill = True
        '
        'daPOHeaderByDateRequired
        '
        Me.daPOHeaderByDateRequired.SelectCommand = Me.SqlCommand5
        Me.daPOHeaderByDateRequired.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = resources.GetString("SqlCommand5.CommandText")
        Me.SqlCommand5.Connection = Me.sqlConn
        Me.SqlCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@STARTDATE", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@ENDDATE", System.Data.SqlDbType.DateTime, 4, "dRequired")})
        '
        'daPOLinesByDateRequired
        '
        Me.daPOLinesByDateRequired.SelectCommand = Me.SqlCommand6
        Me.daPOLinesByDateRequired.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Connection = Me.sqlConn
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@STARTDATE", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@ENDDATE", System.Data.SqlDbType.DateTime, 4, "dRequired")})
        '
        'daPOHeaderByDateReqRangeVendorID
        '
        Me.daPOHeaderByDateReqRangeVendorID.SelectCommand = Me.SqlCommand1
        Me.daPOHeaderByDateReqRangeVendorID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.sqlConn
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@STARTDATE", System.Data.SqlDbType.SmallDateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@ENDDATE", System.Data.SqlDbType.SmallDateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID")})
        '
        'daPOLinesByDateRequiredVendorID
        '
        Me.daPOLinesByDateRequiredVendorID.SelectCommand = Me.SqlCommand2
        Me.daPOLinesByDateRequiredVendorID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Connection = Me.sqlConn
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@STARTDATE", System.Data.SqlDbType.SmallDateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@ENDDATE", System.Data.SqlDbType.SmallDateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@nvendorid", System.Data.SqlDbType.Int, 4, "nVendorID")})
        '
        'daPOHeaderCONF
        '
        Me.daPOHeaderCONF.SelectCommand = Me.SqlCommand3
        Me.daPOHeaderCONF.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        Me.SqlCommand3.Connection = Me.sqlConn
        '
        'daPOLinesByCONF
        '
        Me.daPOLinesByCONF.SelectCommand = Me.SqlCommand4
        Me.daPOLinesByCONF.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
        Me.SqlCommand4.Connection = Me.sqlConn
        '
        'lblTruck
        '
        Me.lblTruck.AutoSize = True
        Me.lblTruck.Location = New System.Drawing.Point(466, 40)
        Me.lblTruck.Name = "lblTruck"
        Me.lblTruck.Size = New System.Drawing.Size(40, 14)
        Me.lblTruck.TabIndex = 11
        Me.lblTruck.Text = "Truck: "
        Me.lblTruck.Visible = False
        '
        'txtTruckNum
        '
        Me.txtTruckNum.Location = New System.Drawing.Point(509, 37)
        Me.txtTruckNum.Name = "txtTruckNum"
        Me.txtTruckNum.Size = New System.Drawing.Size(160, 20)
        Me.txtTruckNum.TabIndex = 12
        Me.txtTruckNum.Visible = False
        '
        'btnExportToText
        '
        Me.btnExportToText.BackColor = System.Drawing.SystemColors.Control
        Me.btnExportToText.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExportToText.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExportToText.Location = New System.Drawing.Point(8, 647)
        Me.btnExportToText.Name = "btnExportToText"
        Me.btnExportToText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportToText.Size = New System.Drawing.Size(105, 40)
        Me.btnExportToText.TabIndex = 13
        Me.btnExportToText.Text = "Export Conf To Text"
        Me.btnExportToText.UseVisualStyleBackColor = False
        Me.btnExportToText.Visible = False
        '
        'rptSupplier
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1112, 875)
        Me.Controls.Add(Me.btnExportToText)
        Me.Controls.Add(Me.txtTruckNum)
        Me.Controls.Add(Me.lblTruck)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.txtPOsearch)
        Me.Controls.Add(Me.cmdPOSearch)
        Me.Controls.Add(Me.gridSupplier)
        Me.Controls.Add(Me.cmdRecord)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.gridDate)
        Me.Controls.Add(Me.gridReport)
        Me.Controls.Add(Me.lblPOsearch)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptSupplier"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "SUPPLIER REPORT By Week"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private sReportType As String
    Private bLoading As Boolean
    Private dGridDate As Date
    Private lGridSupplier As Integer
    Dim lastcheck As Integer
    Dim lastInv As Integer
    Private discount As Single
    Private bLoad1Supplier As Boolean
    Private lSupplierSelected As Integer
    Private lTruckSelected As Integer

    Private oJob As New JobObj

    Private Property ReportType() As String
        Get
            Return sReportType
        End Get
        Set(ByVal Value As String)
            sReportType = Value
        End Set
    End Property

    Private Sub cmbType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbType.SelectedIndexChanged
        sReportType = cmbType.Text
        If sReportType = "Confirmation" Then
            Me.gridDate.Visible = False
            Me.gridSupplier.Visible = False
            LoadReport()
        End If
        If Not bLoading Then

            SaveChanges()

            If sReportType = "Confirmation" Then
                Me.gridDate.Visible = False
                Me.gridSupplier.Visible = False
            Else
                Me.gridDate.Visible = True
                Me.gridSupplier.Visible = True
            End If
            LoadReport()
        End If
    End Sub

    Private Sub cmdPOSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPOSearch.Click
        Try
            lblPOsearch.Text = GetDateRequired(Me.txtPOsearch.Text)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
 
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        SaveChanges()
        With gridReport
            .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            Me.BackColor = Color.White
            .BackColor = Color.Transparent
            .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            .SheetBorder = Color.Transparent
        End With

        gridReport.PrintGrid("", 1, 0, 10, 10)
    End Sub

    Private alPONeedingActivityUpdate As New ArrayList
    Private alJobActivity As New ArrayList

    Private Class JobActivityLine
        Public nJobID As Integer = 0
        Public stype As String = ""
        Public sDetail As String = ""
        Public blnHasCabs As Boolean = False
        Public blnWholeJobRecieved As Boolean = False
    End Class

    Private Sub AddJobNoToActivityArray(ByVal drPO As dsTKSI.tPOHeaderRow)
        'we only want to write one line of activity per job number that has been handled by the scanning process

        Dim drJob As dsTKSI.tJobRow
        drJob = drPO.tJobRow

        Dim act1 As JobActivityLine
        Dim i As Integer
        Dim blnFoundActivity As Boolean = False

        Dim sActivityType As String = ""
        'only update activity log on jobs that are specificaly getting flagged as Received
        If drPO.nBoxes > 0 Then
            'this is a cabinetry PO
            sActivityType = "Job Received"
        ElseIf drPO.nAccount = 4010 Then
            'is cabinetry type of accounting code but has no boxes count on PO
            sActivityType = "Misc Received"
        Else
            sActivityType = "Hardware Received"
        End If

        For i = 0 To Me.alJobActivity.Count - 1
            act1 = Me.alJobActivity(i)
            If act1.nJobID = drJob.nID Then
                blnFoundActivity = True
                'activity has already been added, only overwrite if this is more important
                If InStr(act1.sDetail, "Damage") > 0 Then
                    'dont overwrite existing damage note
                ElseIf act1.stype = "Hardware Received" Then
                    'overwrite with anything
                    If act1.blnHasCabs Then
                        act1.stype = sActivityType
                        act1.sDetail = act1.stype
                    Else
                        act1.stype = "Job Received"
                        act1.sDetail = act1.stype
                    End If

                    Me.alJobActivity(i) = act1
                ElseIf act1.stype = "Misc Received" And sActivityType = "Job Received" Then
                    'always overwrite with job received if we did get cabinets
                    act1.stype = sActivityType
                    act1.sDetail = act1.stype
                    Me.alJobActivity(i) = act1
                End If
                Exit For
            End If
        Next

        If Not blnFoundActivity Then

            'add a new activity line
            act1 = New JobActivityLine

            'when first adding activity, check if the whole job is just misc pieces or does it have cabinetry?
            'also are the other POs recieved as well?
            'misc items should flag as job recieved only if all other items are received
            Dim drPO1 As dsTKSI.tPOHeaderRow
            act1.blnWholeJobRecieved = True
            For Each drPO1 In drJob.GettPOHeaderRows
                If drPO1.nBoxes > 0 Then
                    act1.blnHasCabs = True
                End If
                'disregard labor POs when determining if the whole job has been received
                If drPO1.IsDRECNull And drPO1.nAccount < 4040 Then
                    act1.blnWholeJobRecieved = False
                End If
            Next


            If act1.blnHasCabs Then
                act1.stype = sActivityType
                act1.sDetail = act1.stype
            ElseIf Not act1.blnWholeJobRecieved Then
                act1.stype = sActivityType
                act1.sDetail = act1.stype
            Else
                'even if parts received are misc, flag as job received if everything is in
                act1.stype = "Job Received"
                act1.sDetail = act1.stype
            End If

            act1.nJobID = drJob.nID
            Me.alJobActivity.Add(act1)
        End If
    End Sub

    Private Sub cmdRec_Click()
        Try
            alPONeedingActivityUpdate = New ArrayList
            alJobActivity = New ArrayList

            Dim Y As Integer
            Dim drPO As dsTKSI.tPOHeaderRow

            With gridReport
                .Redraw = False
                For Y = 4 To .Rows - 1
                    If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)) Then

                        If CBool(.get_TextMatrix(Y, 20)) = True Then
                            If sReportType = "Receiving" Then
                                If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) Or Len(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) < 1 Then

                                    drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))
                                    If Not drPO Is Nothing Then

                                        If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) Then
                                            If drPO.IsDRECNull Then
                                                drPO.DREC = .get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)

                                                'save the group of POs getting flagged in temporary storage
                                                alPONeedingActivityUpdate.Add(drPO)
                                            Else
                                                If drPO.DREC <> CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) Then
                                                    drPO.DREC = .get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)
                                                End If
                                            End If

                                        Else
                                            If Not drPO.IsDRECNull Then drPO.SetDRECNull()
                                        End If

                                        If IsNumeric(Me.txtTruckNum.Text) Then '.get_TextMatrix(2, 15)) Then

                                            If drPO.nTruck <> CLng(Me.txtTruckNum.Text) Then '.get_TextMatrix(2, 15)) Then
                                                drPO.nTruck = CInt(Me.txtTruckNum.Text) ' .get_TextMatrix(2, 15)
                                            End If

                                        End If

                                        If UCase(drPO.SRECNOTES) <> UCase(.get_Cell(CellPropertySettings.flexcpText, Y, 15, Y, 15)) Then
                                            drPO.SRECNOTES = .get_Cell(CellPropertySettings.flexcpText, Y, 15, Y, 15)
                                        End If

                                        If UCase(.get_TextMatrix(Y, 22)) = "YES" Then

                                            If UCase(drPO.sBackOrder) <> "YES" Then
                                                drPO.sBackOrder = "Yes"
                                                '' this needs to show up in needs attention even after its shipped 
                                            End If

                                        End If

                                    End If
                                End If
                            End If
                            If ReportType = "Standard" Or ReportType = "Confirmation" Then
                                If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 16, Y, 16)) Or Len(.get_Cell(CellPropertySettings.flexcpText, Y, 16, Y, 16)) < 1 Then

                                    drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))
                                    If Not drPO Is Nothing Then
                                        If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 16, Y, 16)) Then
                                            'if original value is null then put new value in
                                            'if its not null then check to see if they are different
                                            If Not drPO.IsDFAXEDNull Then
                                                If drPO.DFAXED <> CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 16, Y, 16)) Then
                                                    drPO.DFAXED = .get_Cell(CellPropertySettings.flexcpText, Y, 16, Y, 16)
                                                End If
                                            Else
                                                drPO.DFAXED = .get_Cell(CellPropertySettings.flexcpText, Y, 16, Y, 16)
                                            End If
                                        Else
                                            If Not drPO.IsDFAXEDNull Then drPO.SetDFAXEDNull()

                                        End If

                                    End If
                                End If
                            End If
                        End If
                    End If
                Next

                Try

                    Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
                    Me.DsTKSI1.tPOHeader.AcceptChanges()

                    If sReportType = "Receiving" Then
                        For Each drPO In Me.alPONeedingActivityUpdate
                            'only update activity log on jobs that are specificaly getting flagged as Received
                            AddJobNoToActivityArray(drPO)
                        Next

                        UpdateJobActivityToSQL(Me.alJobActivity)
                    End If

                Catch ex As Exception
                    Windows.Forms.MessageBox.Show("Error saving data... " & ex.Message)
                End Try

                .Redraw = True
            End With

            LoadReport()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateJobActivityToSQL(ByVal alActivity As ArrayList)
        Dim act1 As JobActivityLine
        For Each act1 In alActivity
            Dim drAct As TKSIJOBSDataSet.tblJobActivityRow
            drAct = Me.TksijobsDataSet1.tblJobActivity.NewtblJobActivityRow
            With drAct
                .ActivityDetail = act1.sDetail
                .nJobID = act1.nJobID
                .ActivityType = UCase(act1.stype)
                .dateEntered = Now
                .gID = Guid.NewGuid
                .Other = ""
            End With
            Me.TksijobsDataSet1.tblJobActivity.AddtblJobActivityRow(drAct)

        Next

        Me.TblJobActivityTableAdapter1.Update(Me.TksijobsDataSet1.tblJobActivity)

    End Sub

    Private Sub cmdRecord_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRecord.Click
        SaveChanges()
    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        If Not bLoading Then
            SaveChanges()
        End If
        If Not bLoading Then
            'LoadReport()
        End If
        bLoading = False
    End Sub

    Private Sub SaveChanges()
        '-'on error Resume Next
        Try

            cmdRec_Click()

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub rptSupplier_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Try
            'this data does not get refreshed using different parameters during report useage
            'so only load once
            oJob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1)

            bLoad1Supplier = False
            bLoading = True
            gridDateInit()
            gridSupplierInit()
            sReportType = "Standard"
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadReport()
        Try

            Select Case sReportType
                Case "Standard"
                    gridClicks()
                Case "Confirmation"
                    gridReportALL("Confirmation")
                Case "Receiving"
                    gridClicks()
                Case "All"
                    gridReportALL("All")
            End Select
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub gridDateInit()
        Try
            gridDate.Redraw = False
            gridDate.Rows = 0
            gridDate.Cols = 2
            gridDate.set_ColWidth(1, 3000)
            getdates()
            gridDate.Redraw = True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub gridSupplierInit()
        Try
            With gridSupplier
                .Cols = 3
                .Rows = 0
                .set_ColHidden(0, True)
                .set_ColHidden(1, True)
                .set_ColWidth(2, 3000)
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub getdates()
        Dim today_Renamed, thisWednesday As Date
        Dim add_Renamed, dayofweek, i As Integer
        Dim strDate As String
        For i = -8 To 15
            today_Renamed = DateAdd(Microsoft.VisualBasic.DateInterval.Day, i * 7, Today) 'two weeks ago to 5 weeks from now
            dayofweek = Weekday(today_Renamed)
            add_Renamed = 4 - dayofweek ' difference between current day of week and wednesday
            thisWednesday = DateAdd(Microsoft.VisualBasic.DateInterval.Day, add_Renamed, today_Renamed)
            If i = 0 Then
                strDate = "This Week"
            Else

                strDate = CStr(thisWednesday)
            End If
            gridDate.AddItem(thisWednesday & vbTab & strDate)
            gridDate.set_ColHidden(1, True)
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    Private Sub rptSupplier_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        If Windows.Forms.MessageBox.Show("Save Changes?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
            SaveChanges()
        End If
    End Sub

    Private Sub gridDate_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridDate.Click
        If gridDate.RowSel > -1 Then
            SaveChanges()
            ' gridClicks()
            bLoad1Supplier = False
        End If
    End Sub

    Sub openpo()
        '-'on error Resume Next
        gridReport.Select(gridReport.RowSel, 0)
        If IsNumeric(gridReport.Text) Then
            If CInt(gridReport.Text) > 0 Then
                Dim poid = CInt(gridReport.Text)
                Dim drPO As dsTKSI.tPOHeaderRow
                drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
                If Not drPO Is Nothing Then
                    OpenPOScreen(poid, True)
                End If
            End If
        Else
            MsgBox("Error: grid ID is incorrect")
        End If
    End Sub

    Private Sub gridClicks()

        If sReportType = "Confirmation" Then
            MsgBox("Date doesn't affect the Confirmation report.")
        Else
            If gridDate.RowSel > -1 Then
                gridDate.Select(gridDate.RowSel, 0)
                If IsDate2(gridDate.Text) Then
                    dGridDate = CDate(gridDate.Text)
                    gridReportALL((cmbType.Text))
                Else
                    gridReport.Rows = 0
                End If
            End If
        End If
    End Sub
    Friend Function SelectPOandLinesByDateRequiredRangeCONF(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                .tPOHeader.Clear()
                'Me.daPOHeaderCONF.SelectCommand.Parameters("@STARTDATE").Value = startdate
                'Me.daPOHeaderCONF.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOHeaderCONF.Fill(.tPOHeader)

                .tPOLine.Clear()
                'Me.daPOLinesByCONF.SelectCommand.Parameters("@STARTDATE").Value = startdate
                'Me.daPOLinesByCONF.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOLinesByCONF.Fill(.tPOLine)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectPOandLinesByDateRequiredRange1(ByVal DsTKSI1 As dsTKSI, ByVal startdate As Date, ByVal enddate As Date) As Boolean
        Try
            With DsTKSI1
                .tPOHeader.Clear()
                Me.daPOHeaderByDateRequired.SelectCommand.Parameters("@STARTDATE").Value = startdate
                Me.daPOHeaderByDateRequired.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOHeaderByDateRequired.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLinesByDateRequired.SelectCommand.Parameters("@STARTDATE").Value = startdate
                Me.daPOLinesByDateRequired.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOLinesByDateRequired.Fill(.tPOLine)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectPOandLinesByDateRequiredRangeVendorID(ByVal DsTKSI1 As dsTKSI, ByVal startdate As Date, ByVal enddate As Date, ByVal nvendorID As Integer) As Boolean
        Try
            With DsTKSI1
                .tPOHeader.Clear()
                Me.daPOHeaderByDateReqRangeVendorID.SelectCommand.Parameters("@STARTDATE").Value = startdate
                Me.daPOHeaderByDateReqRangeVendorID.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOHeaderByDateReqRangeVendorID.SelectCommand.Parameters("@nVendorID").Value = nvendorID
                Me.daPOHeaderByDateReqRangeVendorID.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLinesByDateRequiredVendorID.SelectCommand.Parameters("@STARTDATE").Value = startdate
                Me.daPOLinesByDateRequiredVendorID.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOLinesByDateRequiredVendorID.SelectCommand.Parameters("@nvendorid").Value = nvendorID
                Me.daPOLinesByDateRequiredVendorID.Fill(.tPOLine)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub gridReportALL(Optional ByRef sReportType As String = "")

        'Dim draPOheader As dsTKSI.tPOHeaderRow()

        Dim lasttruck As Long = -1
        Dim lastvendor As Long = -1
        Dim totalFRsale As Decimal = 0
        Dim totalPOSale As Decimal = 0
        Dim strtotals As String = ""
        Dim strsupplier As String = ""

        If sReportType = "" Then
            If Len(ReportType) = 0 Then ' leave reportType to what it was unless it wasnt anything yet
                ReportType = "Standard"
            End If
        Else
            ReportType = sReportType
        End If

        gridReport.Redraw = False
        Dim x, Y As Integer

        Dim totalboxes As Integer
        Dim totalPOCOST As Decimal
        Dim totalFRCost As Decimal

        'dont do 12:00 date
        If InStr(dGridDate, ":") = 0 Then

            'If Not Me.SelectPOandLinesByDateRequiredRange1(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate)) Then
            '    Windows.Forms.MessageBox.Show("Failed to load supplier data.")
            '    Exit Sub
            'End If
        End If

        gridSupplier.Rows = 0
        With gridReport
            '  .Width = Me.Width - 240
            .Cols = 23
            .Rows = 0
            .Rows = 5
            .GridLines = GridStyleSettings.flexGridSkipHorz
            Y = .Rows - 1

            .set_ColWidth(1, 900 / global_OldGridNewGridRation)
            .set_ColWidth(2, 1100 / global_OldGridNewGridRation)
            .set_ColWidth(3, 1400 / global_OldGridNewGridRation)
            .set_ColWidth(4, 700 / global_OldGridNewGridRation)
            .set_ColWidth(5, 1000 / global_OldGridNewGridRation)
            .set_ColWidth(6, 900 / global_OldGridNewGridRation)
            .set_ColWidth(7, 900 / global_OldGridNewGridRation)
            .set_ColWidth(8, 900 / global_OldGridNewGridRation)
            .set_ColWidth(9, 900 / global_OldGridNewGridRation)
            .set_ColWidth(10, 700 / global_OldGridNewGridRation)
            .set_ColWidth(11, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(12, 700 / global_OldGridNewGridRation)
            .set_ColWidth(13, 700 / global_OldGridNewGridRation)
            .set_ColWidth(14, 1000 / global_OldGridNewGridRation)
            .set_ColWidth(15, 2900 / global_OldGridNewGridRation)
            .set_ColWidth(16, 900 / global_OldGridNewGridRation)
            .set_ColWidth(17, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(18, 1100 / global_OldGridNewGridRation)
            .set_ColWidth(19, 900 / global_OldGridNewGridRation)
            .set_ColWidth(21, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(22, 900 / global_OldGridNewGridRation)

            Select Case ReportType
                Case "All"
                    'If bLoad1Supplier Then
                    '     draPOheader = Me.DsTKSI1.tPOHeader.Select("nVendorID=" & lSupplierSelected, "nVendorID,nTruck,sponum")

                    ' Else
                    '     draPOheader = Me.DsTKSI1.tPOHeader.Select("", "nVendorID,nTruck,sponum")
                    ' End If
                    If InStr(dGridDate, ":") = 0 Then
                        If bLoad1Supplier Then
                            If Not Me.SelectPOandLinesByDateRequiredRangeVendorID(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate), lSupplierSelected) Then
                                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                                Exit Sub
                            End If
                        Else
                            If Not Me.SelectPOandLinesByDateRequiredRange1(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate)) Then
                                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                                Exit Sub
                            End If
                        End If
                    End If

                    Me.Text = "ALL PO ORDERS"
                    .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "ALL PO ORDERS")
                    .set_ColHidden(0, True)
                    .set_ColHidden(1, False)
                    .set_ColHidden(2, False)
                    .set_ColHidden(3, False)
                    .set_ColHidden(4, False)
                    .set_ColHidden(5, False)
                    .set_ColHidden(6, False)
                    .set_ColHidden(7, True)
                    .set_ColHidden(8, True)
                    .set_ColHidden(9, True)
                    .set_ColHidden(10, True)
                    .set_ColHidden(11, True)
                    .set_ColHidden(12, False)
                    .set_ColHidden(13, False)
                    .set_ColHidden(14, True)
                    .set_ColHidden(15, True)
                    .set_ColHidden(16, False)
                    .set_ColHidden(17, True)
                    .set_ColHidden(18, True)
                    .set_ColHidden(19, True)
                    .set_ColHidden(20, True)
                    .set_ColHidden(21, True)

                Case "Confirmation"
                    Try
                        Me.btnExportToText.Visible = True
                    Catch 
                    End Try

                    Dim frmwork As New frmWorking
                    frmwork.Text = frmwork.Text & " Confirmation..."
                    frmwork.Show()
                    Try
                        If Not oJob.SelectALLData(Me.DsTKSI1) Then
                            Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                            Exit Sub
                        End If
                        Me.Text = "CONFIRMATION REPORT"
                        .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "CONFIRMATION REPORT")
                        .set_ColHidden(0, True)
                        .set_ColHidden(1, False)
                        .set_ColHidden(2, False)
                        .set_ColHidden(3, False)
                        .set_ColHidden(4, False)
                        .set_ColHidden(5, False)
                        .set_ColHidden(6, False)
                        .set_ColHidden(7, True)
                        .set_ColHidden(8, True)
                        .set_ColHidden(9, True)
                        .set_ColHidden(10, True)
                        .set_ColHidden(11, True)
                        .set_ColHidden(12, False)
                        .set_ColHidden(13, False)
                        .set_ColHidden(14, True)
                        .set_ColHidden(15, True)
                        .set_ColHidden(16, False)
                        .set_ColHidden(17, True)
                        .set_ColHidden(18, True)
                        .set_ColHidden(19, True)
                        .set_ColHidden(20, True)
                        .set_ColHidden(21, False)
                        .set_ColHidden(22, True)
                        'needs fix
                        'If InStr(dGridDate, ":") = 0 Then
                        If Not Me.SelectPOandLinesByDateRequiredRangeCONF(Me.DsTKSI1) Then
                            Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                            Exit Sub
                        End If
                        ' End If


                        'draPOheader = Me.DsTKSI1.tPOHeader.Select("sConf=''", "nVendorID,nTruck,sponum")

                    Catch ex As Exception
                        Windows.Forms.MessageBox.Show(ex.Message)
                    End Try
                    frmwork.Close()

                Case "Receiving"
                    If InStr(dGridDate, ":") = 0 Then
                        If bLoad1Supplier Then
                            If Not Me.SelectPOandLinesByDateRequiredRangeVendorID(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate), lSupplierSelected) Then
                                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                                Exit Sub
                            End If
                        Else
                            If Not Me.SelectPOandLinesByDateRequiredRange1(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate)) Then
                                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                                Exit Sub
                            End If
                        End If
                    End If


                    .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "Receiving")
                    .set_Cell(CellPropertySettings.flexcpText, 2, 1, 2, 3, "WEEK OF: " & dGridDate)

                    Me.lblTruck.Visible = True
                    Me.txtTruckNum.Visible = True
                    '  .set_Cell(CellPropertySettings.flexcpText, 2, 14, 2, 14, "Truck")
                    '.set_Cell(CellPropertySettings.flexcpText, 2, 15, 2, 15, "")

                    '.set_Cell(CellPropertySettings.flexcpAlignment, 2, 15, 2, 15, AlignmentSettings.flexAlignLeftCenter)
                    '.set_Cell(CellPropertySettings.flexcpBackColor, 2, 14, 2, 15, Color.Yellow)
                    '.Select(2, 14, 2, 15)
                    ' .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)
                    .set_ColHidden(0, True)
                    .set_ColHidden(1, True)
                    .set_ColHidden(2, False)
                    .set_ColHidden(3, False)
                    .set_ColHidden(4, False)
                    .set_ColHidden(5, False)
                    .set_ColHidden(6, False)
                    .set_ColHidden(7, True)
                    .set_ColHidden(8, True)
                    .set_ColHidden(9, True)
                    .set_ColHidden(10, True)
                    .set_ColHidden(11, True)
                    .set_ColHidden(12, True)
                    .set_ColHidden(13, True)
                    .set_ColHidden(14, False)
                    .set_ColHidden(15, False)
                    .set_ColHidden(16, True)
                    .set_ColHidden(17, True)
                    .set_ColHidden(18, True)
                    .set_ColHidden(19, True)
                    .set_ColHidden(20, True)
                    .set_ColHidden(21, True)
                    .set_ColHidden(22, False)
                Case Else
                    If InStr(dGridDate, ":") = 0 Then
                        If bLoad1Supplier Then
                            If Not Me.SelectPOandLinesByDateRequiredRangeVendorID(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate), lSupplierSelected) Then
                                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                                Exit Sub
                            End If
                        Else
                            If Not Me.SelectPOandLinesByDateRequiredRange1(Me.DsTKSI1, DateAdd(DateInterval.Day, -3, dGridDate), DateAdd(DateInterval.Day, 3, dGridDate)) Then
                                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                                Exit Sub
                            End If
                        End If
                    End If

                    .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "SUPPLIER REPORT")
                    .set_Cell(CellPropertySettings.flexcpText, 2, 1, 2, 3, "WEEK OF: " & dGridDate)

                    .set_ColHidden(0, True)
                    .set_ColHidden(1, False)
                    .set_ColHidden(2, False)
                    .set_ColHidden(3, False)
                    .set_ColHidden(4, False)
                    .set_ColHidden(5, False)
                    .set_ColHidden(6, False)
                    .set_ColHidden(7, False)
                    .set_ColHidden(8, False)
                    .set_ColHidden(9, True)
                    .set_ColHidden(10, True)
                    .set_ColHidden(11, True)
                    .set_ColHidden(12, False)
                    .set_ColHidden(13, False)
                    .set_ColHidden(14, True)
                    .set_ColHidden(15, True)
                    .set_ColHidden(16, False)
                    .set_ColHidden(17, True)
                    .set_ColHidden(18, True)
                    .set_ColHidden(19, True)
                    .set_ColHidden(20, True)
                    .set_ColHidden(21, True)
                    .set_ColHidden(22, True)
            End Select


        End With

        With gridReport
            .MergeCells = MergeSettings.flexMergeFree

            .set_MergeRow(0, True)
            .set_MergeRow(1, True)
            .set_MergeRow(2, True)
            .set_MergeRow(3, True)

            .set_TextMatrix(4, 1, "Conf #")
            .set_TextMatrix(4, 2, "PO #")
            .set_TextMatrix(4, 3, "Builder")
            .set_TextMatrix(4, 4, "Boxes #")
            .set_TextMatrix(4, 5, "PO Cost")
            .set_TextMatrix(4, 6, "Frt Cost")
            .set_TextMatrix(4, 7, "PO Sale")
            .set_TextMatrix(4, 8, "Sale Frt.")
            .set_TextMatrix(4, 9, "Date Req.")
            .set_TextMatrix(4, 10, "PO Date")
            .set_TextMatrix(4, 11, "Supplier")
            .set_TextMatrix(4, 12, "Factor")
            .set_TextMatrix(4, 13, "Salesperson")
            .set_TextMatrix(4, 14, "Date Rec.")
            .set_TextMatrix(4, 15, "Rec. Notes")
            .set_TextMatrix(4, 16, "Fax Date")
            .set_TextMatrix(4, 17, "Date>Simply")
            .set_TextMatrix(4, 18, "Invoice#")
            .set_TextMatrix(4, 21, "Req Date")
            .set_TextMatrix(4, 22, "BackOrder")
            .set_ColDataType(19, GetType(Boolean))
            .set_ColDataType(20, GetType(Boolean))


        End With
        'gridReport.FrozenRows = 5
        gridReport.FrozenRows = 0
        gridReport.set_MergeRow(0, True)
        gridReport.set_MergeRow(1, True)
        gridReport.set_MergeRow(2, True)
        gridReport.set_MergeRow(3, True)


        Dim cs As CellStyle = gridReport.Styles.Add("red")
        cs.BackColor = Color.Red

        Dim csgr As CellStyle = gridReport.Styles.Add("green")
        csgr.BackColor = Color.Green

        ' create style with bold font
        Dim csbold As CellStyle = gridReport.Styles.Add("bold")
        csbold.Font = New Font("Tahoma", 8, FontStyle.Bold)

        Dim b1 As CellBorder = csbold.Border
        b1.Style = BorderStyleEnum.None

        ' assign bold style to a cell range
        Dim rg As CellRange = gridReport.GetCellRange(0, 0, 3, gridReport.Cols - 1)
        rg.Style = gridReport.Styles("bold")

        With gridReport
            Dim drPO As dsTKSI.tPOHeaderRow
            For Each drPO In Me.DsTKSI1.tPOHeader

                Y = gridReport.Rows - 1

                If lastvendor <> drPO.nVendorID Or drPO.nTruck <> lasttruck Then
                    'setup vendor TOTALS
                    strsupplier = drPO.nVendorID & vbTab & drPO.nTruck & vbTab

                    If drPO.nTruck > 1 Then
                        strsupplier = strsupplier & "(" & drPO.nTruck & ")"
                    End If
                    strsupplier = strsupplier & drPO.tVendorRow.sName
                    'If drPO.tJobRow.tCustomrRow.sName.ToUpper.Contains("ELDORADO") Then
                    '    strsupplier = strsupplier
                    'End If
                    gridSupplier.AddItem(strsupplier)
                    'supliergrid truck difference
                    strtotals = "TOTALS --  BOXES: " & totalboxes & "     COST: " & totalPOCOST & "    FREIGHT: " & totalFRCost
                    If gridReport.Rows > 6 Then
                        .Rows = .Rows + 1
                        .set_TextMatrix(.Rows - 1, 3, "TOTALS:")
                        .set_TextMatrix(.Rows - 1, 4, totalboxes)
                        .set_TextMatrix(.Rows - 1, 5, totalPOCOST)
                        .set_TextMatrix(.Rows - 1, 6, totalFRCost)
                        .set_TextMatrix(.Rows - 1, 7, totalPOSale)
                        .set_TextMatrix(.Rows - 1, 8, totalFRsale)
                        Y = gridReport.Rows - 1
                        .set_MergeRow(gridReport.Rows - 1, True)
                        .set_Cell(CellPropertySettings.flexcpAlignment, Y, 1, Y, 14, AlignmentSettings.flexAlignLeftCenter)
                        .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 14, True)
                        .set_RowHeight(.Rows - 1, 700 / global_OldGridNewGridRation)
                    End If
                    totalPOCOST = 0
                    totalFRCost = 0
                    totalboxes = 0
                    totalPOSale = 0
                    totalFRsale = 0
                    gridReport.AddItem("" & vbTab & "")
                    If Not drPO.tVendorRow Is Nothing Then
                        gridReport.AddItem("" & vbTab & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & vbTab & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & vbTab & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & vbTab & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & vbTab & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck)
                    Else
                        gridReport.AddItem("" & vbTab & "NO VENDOR" & vbTab & "NO VENDOR")
                    End If

                    Y = gridReport.Rows - 1
                    gridReport.set_MergeRow(gridReport.Rows - 1, True)
                    gridReport.set_Cell(CellPropertySettings.flexcpAlignment, Y, 1, Y, 2, AlignmentSettings.flexAlignLeftCenter)
                    gridReport.set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 2, True)

                End If
                lastvendor = drPO.nVendorID
                lasttruck = drPO.nTruck


                gridReport.Rows = gridReport.Rows + 1
                Y = gridReport.Rows - 1

                .set_RowHeight(Y, 400 / global_OldGridNewGridRation)
                .set_TextMatrix(Y, 0, drPO.nID)
                .set_TextMatrix(Y, 1, drPO.sConf & "")
                .set_TextMatrix(Y, 2, drPO.sPONum & "")

                If Not drPO.tJobRow.tCustomrRow Is Nothing Then .set_TextMatrix(Y, 3, drPO.tJobRow.tCustomrRow.sName & "") 'BUILDER NAME


                'If Not drPO.IsDRECNull Then

                '    .let_Cell(VSFlex7.CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, &H99FFFF)
                '    .let_Cell(VSFlex7.CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                'End If
                'If Not drPO.IsDDELNull Then

                '    .let_Cell(VSFlex7.CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, &H99FF99)
                '    .let_Cell(VSFlex7.CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                'End If


                If Not drPO.IsDRECNull Then

                    .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, Color.Yellow) ' global_ColorFromHex(&H99, &HFF, &HFF))
                    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                End If
                If Not drPO.IsDDELNull Then

                    .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, Color.PaleGreen) 'global_ColorFromHex(&H99, &HFF, &H99))
                    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                End If
                .set_TextMatrix(Y, 4, drPO.nBoxes)
                .set_TextMatrix(Y, 5, oJob.GetPOCostByCode(drPO, 5010) + oJob.GetPOCostByCode(drPO, 5020) + oJob.GetPOCostByCode(drPO, 5030) + oJob.GetPOCostByCode(drPO, 5260) + oJob.GetPOCostByCode(drPO, 5270) + oJob.GetPOCostByCode(drPO, 5490) + oJob.GetPOCostByCode(drPO, 4700) + oJob.GetPOCostByCode(drPO, 5040))
                .set_TextMatrix(Y, 6, oJob.GetPOCostByCode(drPO, 5070)) 'PO FREIGHT COST

                totalboxes = totalboxes + drPO.nBoxes
                If IsNumeric(.get_TextMatrix(Y, 5)) Then
                    totalPOCOST = totalPOCOST + CDbl(.get_TextMatrix(Y, 5))
                End If
                If IsNumeric(.get_TextMatrix(Y, 6)) Then
                    totalFRCost = totalFRCost + CDbl(.get_TextMatrix(Y, 6))
                End If
                .set_TextMatrix(Y, 7, drPO.nRetailSale + drPO.nAdd)
                If IsNumeric(.get_TextMatrix(Y, 7)) Then
                    totalPOSale = totalPOSale + .get_TextMatrix(Y, 7)
                End If
                .set_TextMatrix(Y, 8, drPO.nRetailFreight)
                If IsNumeric(.get_TextMatrix(Y, 8)) Then
                    totalFRsale = totalFRsale + .get_TextMatrix(Y, 8)
                End If
                If Not drPO.IsdRequiredNull Then .set_TextMatrix(Y, 9, drPO.dRequired.ToShortDateString)


                .set_TextMatrix(Y, 10, drPO.dPODate.ToShortDateString)

                If Not drPO.tVendorRow Is Nothing Then .set_TextMatrix(Y, 11, drPO.tVendorRow.sName)
                .set_TextMatrix(Y, 12, oJob.Factor(drPO))
                .set_TextMatrix(Y, 13, drPO.tJobRow.sSalesperson)
                If Not drPO.IsDRECNull Then .set_TextMatrix(Y, 14, drPO.DREC.ToShortDateString)
                .set_TextMatrix(Y, 15, drPO.SRECNOTES)
                If Not drPO.IsDFAXEDNull Then .set_TextMatrix(Y, 16, drPO.DFAXED.ToShortDateString)
                If sReportType = "Confirmation" Then

                    If Not drPO.IsDFAXEDNull Then
                        If drPO.DFAXED <= DateAdd(DateInterval.Day, -4, Today) Then
                            .set_Cell(CellPropertySettings.flexcpBackColor, Y, 1, Y, 16, Color.LightSkyBlue) ' global_ColorFromHex(&HFF, &HDD, &H77))
                            ' .let_Cell(VSFlex7.CellPropertySettings.flexcpBackColor, Y, 1, Y, 16, &HFFDD77)
                        End If
                    End If
                End If


                If Not drPO.IsdSimplyNull Then .set_TextMatrix(Y, 17, drPO.dSimply.ToShortDateString)
                .set_TextMatrix(Y, 18, drPO.nInvNo)
                .set_TextMatrix(Y, 19, drPO.bSimply)
                .set_TextMatrix(Y, 20, False)
                If Not drPO.IsdRequiredNull Then .set_TextMatrix(Y, 21, drPO.dRequired.ToShortDateString)
                .set_TextMatrix(Y, 22, drPO.sBackOrder)
                .Select(Y, 21)
                .CellAlignment = AlignmentSettings.flexAlignRightCenter
                ' .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 0, 0, 0, 0, 0)

                .Select(Y, 22)
                .CellAlignment = AlignmentSettings.flexAlignRightCenter
                If UCase(drPO.sBackOrder) = "YES" Then
                    .CellBackColor = Color.LightGray ' System.Drawing.ColorTranslator.FromOle(&H999999)
                End If

                .Select(Y, x, Y, 18)
                .CellAlignment = AlignmentSettings.flexAlignLeftCenter
                '   .CellBorder(System.Convert.ToUInt32(Color.Black), 0, 1, 0, 0, 0, 0)

                x = 0

            Next
            If totalboxes > 0 Or totalPOCOST > 0 Then
                strtotals = "TOTALS --  BOXES: " & totalboxes & "     COST: " & totalPOCOST & "    FREIGHT: " & totalFRCost
                If gridReport.Rows > 6 Then
                    .Rows = .Rows + 1
                    .set_TextMatrix(.Rows - 1, 3, "TOTALS:")
                    .set_TextMatrix(.Rows - 1, 4, totalboxes)
                    .set_TextMatrix(.Rows - 1, 5, totalPOCOST)
                    .set_TextMatrix(.Rows - 1, 6, totalFRCost)
                    .set_TextMatrix(.Rows - 1, 7, totalPOSale)
                    .set_TextMatrix(.Rows - 1, 8, totalFRsale)

                    Y = gridReport.Rows - 1
                    .set_MergeRow(gridReport.Rows - 1, True)
                    .set_Cell(CellPropertySettings.flexcpAlignment, Y, 1, Y, 14, AlignmentSettings.flexAlignLeftCenter)
                    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 14, True)
                    .set_RowHeight(.Rows - 1, 700 / global_OldGridNewGridRation)
                End If
            End If
            .Select(0, 0)
            .ScrollPosition = New Point(1, 1)
            .Redraw = True
        End With
    End Sub

    Private Sub gridreport_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridReport.MouseDown
        With gridReport
            '    MessageBox.Show(.MouseRow & " c: " & .MouseCol)
            If .MouseRow > -1 Then
                If IsNumeric(.get_TextMatrix(.MouseRow, 0)) Then
                    Try
                        Select Case .MouseCol
                            Case 22
                                .Select(.MouseRow, 22)
                                .CellBackColor = Color.LightGray ' System.Drawing.ColorTranslator.FromOle(&H999999)
                                .set_TextMatrix(.MouseRow, 22, "Yes")
                                .set_TextMatrix(.MouseRow, 20, True)

                            Case 14
                                If ReportType = "Receiving" And .MouseRow > -1 Then
                                    .Select(.MouseRow, 14)
                                    .set_TextMatrix(.MouseRow, 14, Month(Now) & "/" & VB.Day(Now) & "/" & Year(Now))
                                    .EditCell()
                                    .set_TextMatrix(.MouseRow, 20, True)
                                    .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)

                                End If
                            Case 15
                                If ReportType = "Receiving" And .MouseRow > -1 Then
                                    .Select(.MouseRow, 15)
                                    .EditCell()
                                    .set_TextMatrix(.MouseRow, 20, True)
                                    .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)

                                End If
                            Case 16
                                If (ReportType = "Standard" Or ReportType = "Confirmation") And .MouseRow > -1 Then
                                    .Select(.MouseRow, 16)
                                    .set_TextMatrix(.MouseRow, 16, Month(Now) & "/" & VB.Day(Now) & "/" & Year(Now))
                                    .EditCell()
                                    .set_TextMatrix(.MouseRow, 20, True)

                                    .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)
                                End If
                            Case 2

                                openpo()
                                SaveChanges()
                            Case 15
                                If .MouseRow = 2 And ReportType = "Receiving" Then
                                    .Select(.MouseRow, 15)
                                    .EditCell()
                                End If
                        End Select
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Else

                End If
            End If
        End With
    End Sub

    Private Sub gridSupplier_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridSupplier.Click

        With gridSupplier
            If .RowSel > -1 Then
                bLoad1Supplier = True
                lSupplierSelected = CInt(.get_TextMatrix(.RowSel, 0))
                lTruckSelected = CInt(.get_TextMatrix(.RowSel, 1))
                SaveChanges()
            End If
        End With
        gridReportALL()
    End Sub

    Private Sub gridSupplier_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridSupplier.SelChange

    End Sub

    Private Sub btnExportToText_Click(sender As Object, e As EventArgs) Handles btnExportToText.Click

        Dim lasttruck As Long = -1
        Dim lastvendor As Long = -1
        Dim totalFRsale As Decimal = 0
        Dim totalPOSale As Decimal = 0
        Dim strtotals As String = ""
        Dim strsupplier As String = ""

        Dim frmwork As New frmWorking
        frmwork.Text = frmwork.Text & " Confirmation..."
        frmwork.Show()

        Dim strFinal As String = "CONFIRMATION REPORT"
        Try
            If Not oJob.SelectALLData(Me.DsTKSI1) Then
                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                Exit Sub
            End If
        
            If Not Me.SelectPOandLinesByDateRequiredRangeCONF(Me.DsTKSI1) Then
                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                Exit Sub
            End If
          
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        frmwork.Close()

        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In Me.DsTKSI1.tPOHeader

            If lastvendor <> drPO.nVendorID Or drPO.nTruck <> lasttruck Then
                strsupplier = drPO.tVendorRow.sName
                strFinal = String.Concat(strFinal, vbCrLf, strsupplier)
            End If
            lastvendor = drPO.nVendorID
            lasttruck = drPO.nTruck

            strFinal = String.Concat(strFinal, vbCrLf, drPO.sConf)
            strFinal = String.Concat(strFinal, vbTab, drPO.sPONum)
            strFinal = String.Concat(strFinal, vbTab, drPO.tJobRow.tCustomrRow.sName)
            strFinal = String.Concat(strFinal, vbTab, drPO.nBoxes)
            strFinal = String.Concat(strFinal, vbTab, drPO.dRequired.ToShortDateString)
            strFinal = String.Concat(strFinal, vbTab, drPO.tJobRow.sSalesperson)
            strFinal = String.Concat(strFinal, vbTab, drPO.nInvNo)
            strFinal = String.Concat(strFinal, vbTab, drPO.sBackOrder)
            strFinal = String.Concat(strFinal, vbTab, drPO.sConf)

            If Not drPO.IsDRECNull Then
                '   .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, Color.Yellow) ' global_ColorFromHex(&H99, &HFF, &HFF))
                '   .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
            End If
            If Not drPO.IsDDELNull Then
                '    .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, Color.PaleGreen) 'global_ColorFromHex(&H99, &HFF, &H99))
                '    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
            End If

        Next

        Dim destDir As String = "c:\tksi\"
        If Not IO.Directory.Exists(destDir) Then
            IO.Directory.CreateDirectory(destDir)
        End If

        Dim destSave = destDir & "ConfExport" & Mid(Guid.NewGuid.ToString, 1, 4) & ".txt"
        Dim sw As New IO.StreamWriter(destsave)
        sw.WriteLine(strFinal)
        sw.Close()

        Process.Start(destSave)
    End Sub
End Class