Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Drawing
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
Imports C1.Win.C1FlexGrid.Classic

Friend Class rptBO
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
    Public WithEvents txtPOsearch As System.Windows.Forms.TextBox
	Public WithEvents cmdPOSearch As System.Windows.Forms.Button
	Public WithEvents cmdRecord As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents gridReport As C1FlexGridClassic
	Public WithEvents lblPOsearch As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents daPOHeaderALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBO))
        Me.txtPOsearch = New System.Windows.Forms.TextBox()
        Me.cmdPOSearch = New System.Windows.Forms.Button()
        Me.cmdRecord = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.gridReport = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.lblPOsearch = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.daPOHeaderALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPOsearch
        '
        Me.txtPOsearch.AcceptsReturn = True
        Me.txtPOsearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtPOsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPOsearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOsearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPOsearch.Location = New System.Drawing.Point(259, 748)
        Me.txtPOsearch.MaxLength = 0
        Me.txtPOsearch.Name = "txtPOsearch"
        Me.txtPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPOsearch.Size = New System.Drawing.Size(126, 23)
        Me.txtPOsearch.TabIndex = 4
        '
        'cmdPOSearch
        '
        Me.cmdPOSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPOSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPOSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPOSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPOSearch.Location = New System.Drawing.Point(384, 748)
        Me.cmdPOSearch.Name = "cmdPOSearch"
        Me.cmdPOSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPOSearch.Size = New System.Drawing.Size(78, 30)
        Me.cmdPOSearch.TabIndex = 3
        Me.cmdPOSearch.Text = "PO Search"
        Me.cmdPOSearch.UseVisualStyleBackColor = False
        '
        'cmdRecord
        '
        Me.cmdRecord.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRecord.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRecord.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRecord.Location = New System.Drawing.Point(691, 748)
        Me.cmdRecord.Name = "cmdRecord"
        Me.cmdRecord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRecord.Size = New System.Drawing.Size(193, 30)
        Me.cmdRecord.TabIndex = 2
        Me.cmdRecord.Text = "Record Changes"
        Me.cmdRecord.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(10, 748)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(126, 30)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'gridReport
        '
        Me.gridReport.BackColorSel = System.Drawing.Color.Yellow
        Me.gridReport.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridReport.FixedCols = 0
        Me.gridReport.FixedRows = 0
        Me.gridReport.ForeColorSel = System.Drawing.Color.Black
        Me.gridReport.GridColor = System.Drawing.Color.Black
        Me.gridReport.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridReport.GridLines = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridSkipHorz
        Me.gridReport.Location = New System.Drawing.Point(10, 10)
        Me.gridReport.Name = "gridReport"
        Me.gridReport.NodeClosedPicture = Nothing
        Me.gridReport.NodeOpenPicture = Nothing
        Me.gridReport.OutlineCol = -1
        Me.gridReport.Size = New System.Drawing.Size(942, 730)
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
        Me.lblPOsearch.Location = New System.Drawing.Point(470, 748)
        Me.lblPOsearch.Name = "lblPOsearch"
        Me.lblPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPOsearch.Size = New System.Drawing.Size(107, 21)
        Me.lblPOsearch.TabIndex = 5
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'daPOHeaderALL
        '
        Me.daPOHeaderALL.DeleteCommand = Me.SqlDeleteCommand1
        Me.daPOHeaderALL.InsertCommand = Me.SqlInsertCommand1
        Me.daPOHeaderALL.SelectCommand = Me.SqlSelectCommand1
        Me.daPOHeaderALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPOHeaderALL.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DFAXED", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DFAXED", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bSimply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreateRecord", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreateRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dPODate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dPODate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dRequired", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dSimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAdd", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAdd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nBoxes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nBoxes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOSort", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOSort", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailFreight", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailFreight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailSale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSaleAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSaleAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nVendorID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nVendorID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nsalesadjust", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nsalesadjust", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sAdjustReason", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAdjustReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sConf", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCurActNote", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCurActNote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sEnteredBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sEnteredBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItemDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItemDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItems", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItems", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPOType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPOType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipto3", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipto3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShiptoCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShiptoCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERV" & _
    "ER;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@dCreateRecord", System.Data.SqlDbType.DateTime, 4, "dCreateRecord"), New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID"), New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipto3", System.Data.SqlDbType.VarChar, 50, "sShipto3"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShiptoCounty", System.Data.SqlDbType.VarChar, 50, "sShiptoCounty"), New System.Data.SqlClient.SqlParameter("@nBoxes", System.Data.SqlDbType.Int, 4, "nBoxes"), New System.Data.SqlClient.SqlParameter("@dPODate", System.Data.SqlDbType.DateTime, 4, "dPODate"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@sEnteredBy", System.Data.SqlDbType.VarChar, 50, "sEnteredBy"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Float, 8, "nTotal"), New System.Data.SqlClient.SqlParameter("@sVia", System.Data.SqlDbType.VarChar, 50, "sVia"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@nRetailSale", System.Data.SqlDbType.Float, 8, "nRetailSale"), New System.Data.SqlClient.SqlParameter("@nSaleAccount", System.Data.SqlDbType.Int, 4, "nSaleAccount"), New System.Data.SqlClient.SqlParameter("@nRetailFreight", System.Data.SqlDbType.Float, 8, "nRetailFreight"), New System.Data.SqlClient.SqlParameter("@sConf", System.Data.SqlDbType.VarChar, 50, "sConf"), New System.Data.SqlClient.SqlParameter("@nAdd", System.Data.SqlDbType.Float, 8, "nAdd"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@DFAXED", System.Data.SqlDbType.DateTime, 4, "DFAXED"), New System.Data.SqlClient.SqlParameter("@nAccount", System.Data.SqlDbType.Int, 4, "nAccount"), New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@sItems", System.Data.SqlDbType.VarChar, 50, "sItems"), New System.Data.SqlClient.SqlParameter("@sItemDesc", System.Data.SqlDbType.VarChar, 50, "sItemDesc"), New System.Data.SqlClient.SqlParameter("@sPOType", System.Data.SqlDbType.VarChar, 50, "sPOType"), New System.Data.SqlClient.SqlParameter("@nsalesadjust", System.Data.SqlDbType.Money, 8, "nsalesadjust"), New System.Data.SqlClient.SqlParameter("@sAdjustReason", System.Data.SqlDbType.VarChar, 255, "sAdjustReason"), New System.Data.SqlClient.SqlParameter("@sCurActNote", System.Data.SqlDbType.VarChar, 255, "sCurActNote"), New System.Data.SqlClient.SqlParameter("@nPOSort", System.Data.SqlDbType.Int, 4, "nPOSort")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'rptBO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1072, 786)
        Me.Controls.Add(Me.txtPOsearch)
        Me.Controls.Add(Me.cmdPOSearch)
        Me.Controls.Add(Me.cmdRecord)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.gridReport)
        Me.Controls.Add(Me.lblPOsearch)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptBO"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Back Order Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 

    Private bLoading As Boolean
    Private bChanges As Boolean

    Private oJob As New JobObj
	
    Private Sub cmdPOSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPOSearch.Click

        Try
            lblPOsearch.Text = GetDateRequired(Me.txtPOsearch.Text)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

       
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        If bChanges Then SaveChanges()
        gridReport.PrintGrid("", 1, 0, 10, 10)
    End Sub

    Private Sub cmdRec_Click()
        Dim Y As Integer

        Dim drPO As dsTKSI.tPOHeaderRow
        With gridReport
            .Redraw = False
            For Y = 4 To .Rows - 1
                If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)) Then
                    If CBool(.get_TextMatrix(Y, 20)) = True Then
                        If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) Or Len(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) < 1 Then
                            drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))
                            'rsPO.Filter = "nid=" & .get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)
                            If Not drPO Is Nothing Then ' rsPO.EOF Then
                                If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)) Then
                                    If Not drPO.IsDRECNull Then
                                        If drPO.DREC <> CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14)).ToShortDateString Then
                                            drPO.DREC = CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14))
                                        End If
                                    Else
                                        drPO.DREC = CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 14, Y, 14))
                                    End If

                                Else
                                    If Not drPO.IsDRECNull Then
                                        drPO.SetDRECNull() ' rsPO.Fields("drec").Value = System.DBNull.Value
                                    End If
                                End If
                                If IsNumeric(.get_TextMatrix(2, 15)) Then
                                    If drPO.nTruck <> .get_TextMatrix(2, 15) Then
                                        drPO.nTruck = .get_TextMatrix(2, 15)
                                    End If
                                End If
                                If drPO.SRECNOTES <> .get_Cell(CellPropertySettings.flexcpText, Y, 15, Y, 15) Then
                                    drPO.SRECNOTES = .get_Cell(CellPropertySettings.flexcpText, Y, 15, Y, 15)
                                End If

                                If UCase(.get_TextMatrix(Y, 22)) = "YES" Then
                                    If UCase(drPO.sBackOrder) <> "YES" Then
                                        drPO.sBackOrder = "Yes"
                                    End If
                                Else
                                    If UCase(drPO.sBackOrder) <> "NO" Then
                                        drPO.sBackOrder = "No"
                                    End If
                                End If
                                'rsPO.Update()

                                Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
                                Me.DsTKSI1.tPOHeader.AcceptChanges()
                            End If
                        End If

                    End If
                End If
            Next
            bChanges = False
            .Redraw = True
        End With

        Me.gridReportALL()

    End Sub

    Private Sub cmdRecord_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRecord.Click
        'on error Resume Next
        If bChanges Then SaveChanges()
    End Sub

    Private Sub rptBO_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        ''on error Resume Next
        ''update data on report for possible changes made in other screens
        'If Not bLoading And bChanges Then
        '    SaveChanges()
        'End If
        'If Not bLoading Then
        '    LoadReport()
        'End If
        'bLoading = False
    End Sub

    Private Sub SaveChanges()
        If bChanges Then
            cmdRec_Click()
        End If
    End Sub

    Private Sub rptBO_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If Not oJob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1) Then
            Windows.Forms.MessageBox.Show("Error loading basic database information for this report.")
            Me.Hide()
        Else
            bChanges = False
            bLoading = True
            gridReportALL()
        End If

    End Sub

    Private Sub rptBO_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        If bChanges Then SaveChanges()
    End Sub

    Sub openpo()
        'on error Resume Next
        gridReport.Select(gridReport.RowSel, 0)
        If IsNumeric(gridReport.Text) Then
            If CInt(gridReport.Text) > 0 Then
                Dim poid = CInt(gridReport.Text)
                Dim drPO As dsTKSI.tPOHeaderRow
                drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
                If Not drPO Is Nothing Then
                    ' Dim frmPO1 As frmPOnet
                    If POID > 0 Then
                        OpenPOScreen(poid, True)
                    End If
                End If
            End If
        Else
            MsgBox("Error: grid ID is incorrect")
        End If
    End Sub

    Private Sub gridReportALL()

        If Not oJob.SelectPOandLinesByBackorderYES(Me.DsTKSI1) Then
            Windows.Forms.MessageBox.Show("Error loading report information.")
            Exit Sub
        End If

        Dim totalFRsale As Decimal
        Dim totalPOSale As Decimal

        gridReport.Redraw = False
        Dim x, Y As Integer
        'Dim curPOcost As Decimal

        Dim totalboxes As Integer
        Dim totalPOCOST As Decimal
        Dim totalFRCost As Decimal
        '   Dim oPO As New po


        With gridReport

            .Cols = 23
            .Rows = 0
            .Rows = 5
            .GridLines = GridStyleSettings.flexGridNone
            Y = .Rows - 1

            .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "Back Order Report")
            .set_Cell(CellPropertySettings.flexcpText, 2, 15, 2, 15, "")
            .set_Cell(CellPropertySettings.flexcpAlignment, 2, 15, 2, 15, AlignmentSettings.flexAlignLeftCenter)

            .set_ColWidth(1, 90)
            .set_ColWidth(2, 110)
            .set_ColWidth(3, 150)
            .set_ColWidth(4, 70)
            .set_ColWidth(5, 100)
            .set_ColWidth(6, 90)
            .set_ColWidth(7, 90)
            .set_ColWidth(8, 90)
            .set_ColWidth(9, 90)
            .set_ColWidth(10, 70)
            .set_ColWidth(11, 130)
            .set_ColWidth(12, 70)
            .set_ColWidth(13, 70)
            .set_ColWidth(14, 100)
            .set_ColWidth(15, 290)
            .set_ColWidth(16, 90)
            .set_ColWidth(17, 120)
            .set_ColWidth(18, 110)
            .set_ColWidth(19, 90)
            .set_ColWidth(21, 120)
            .set_ColWidth(22, 90)

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
            .set_ColHidden(21, False)
            .set_ColHidden(22, False)


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
            .set_ColDataType(19, GetType(Boolean)) ' DataTypeSettings.flexDTBoolean)
            .set_ColDataType(20, GetType(Boolean))
        End With

        gridReport.FrozenRows = 5

        With gridReport
            Dim drPO As dsTKSI.tPOHeaderRow
            For Each drPO In Me.DsTKSI1.tPOHeader
                Y = gridReport.Rows - 1
                totalPOCOST = 0
                totalFRCost = 0
                totalboxes = 0
                totalPOSale = 0
                totalFRsale = 0
                gridReport.AddItem("" & vbTab & "")
                If Not drPO.tVendorRow Is Nothing Then 'rsSupplier.EOF Then
                    gridReport.AddItem("" & vbTab & drPO.tVendorRow.sName & vbTab & drPO.tVendorRow.sName & vbTab & drPO.tVendorRow.sName & vbTab & drPO.tVendorRow.sName & " - TRUCK: " & drPO.nTruck & vbTab & drPO.tVendorRow.sName & vbTab & drPO.tVendorRow.sName)
                Else
                    gridReport.AddItem("" & vbTab & "NO VENDOR" & vbTab & "NO VENDOR")
                End If
                Y = gridReport.Rows - 1
                gridReport.set_MergeRow(gridReport.Rows - 1, True)
                gridReport.set_Cell(CellPropertySettings.flexcpAlignment, Y, 1, Y, 2, AlignmentSettings.flexAlignLeftCenter)
                gridReport.set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 2, True)
                gridReport.Rows = gridReport.Rows + 1
                Y = gridReport.Rows - 1

                .set_RowHeight(Y, 30)
                .set_TextMatrix(Y, 0, drPO.nID) 'rsPOheader.Fields("nid").Value)
                .set_TextMatrix(Y, 1, drPO.sConf) 'rsPOheader.Fields("sConf").Value & "")
                .set_TextMatrix(Y, 2, drPO.sPONum) ' rsPOheader.Fields("sPONum").Value & "")
                '                If Not rsCust.EOF Then .set_TextMatrix(Y, 3, rsCust.Fields("sname").Value & "") 'BUILDER NAME
                If Not drPO.tJobRow.tCustomrRow Is Nothing Then .set_TextMatrix(Y, 3, drPO.tJobRow.tCustomrRow.sName)
                If Not drPO.IsDRECNull Then ' IsDBNull(rsPOheader.Fields("drec").Value) Then
                    .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, global_ColorFromHex(&H99, &HFF, &HFF))
                    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                End If

                If Not drPO.IsDDELNull Then  'IsDBNull(rsPOheader.Fields("ddel").Value) Then
                    .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, global_ColorFromHex(&H99, &HFF, &H99))
                    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                End If
                .set_TextMatrix(Y, 4, drPO.nBoxes) 'rsPOheader.Fields("nBoxes").Value)
                .set_TextMatrix(Y, 5, oJob.GetPOCostByCode(drPO, 5010) + oJob.GetPOCostByCode(drPO, 5020) + oJob.GetPOCostByCode(drPO, 5030) + oJob.GetPOCostByCode(drPO, 5260) + oJob.GetPOCostByCode(drPO, 5270) + oJob.GetPOCostByCode(drPO, 5490) + oJob.GetPOCostByCode(drPO, 4700) + oJob.GetPOCostByCode(drPO, 5040))
                .set_TextMatrix(Y, 6, oJob.GetPOCostByCode(drPO, 5070)) 'PO FREIGHT COST

                totalboxes = totalboxes + drPO.nBoxes 'rsPOheader.Fields("nboxes").Value
                If IsNumeric(.get_TextMatrix(Y, 5)) Then
                    totalPOCOST = totalPOCOST + CDbl(.get_TextMatrix(Y, 5))
                End If
                If IsNumeric(.get_TextMatrix(Y, 6)) Then
                    totalFRCost = totalFRCost + CDbl(.get_TextMatrix(Y, 6))
                End If
                .set_TextMatrix(Y, 7, drPO.nRetailSale + drPO.nAdd) 'oJob.posale(drPO, "YES")) 'rsPOheader))
                If IsNumeric(.get_TextMatrix(Y, 7)) Then
                    totalPOSale = totalPOSale + .get_TextMatrix(Y, 7)
                End If
                .set_TextMatrix(Y, 8, drPO.nRetailFreight) ' rsPOheader.Fields("nretailfreight").Value)
                If IsNumeric(.get_TextMatrix(Y, 8)) Then
                    totalFRsale = totalFRsale + .get_TextMatrix(Y, 8)
                End If
                If Not drPO.IsdRequiredNull Then .set_TextMatrix(Y, 9, drPO.dRequired.ToShortDateString) 'rsPOheader.Fields("drequired").Value & "")
                If Not drPO.IsdPODateNull Then .set_TextMatrix(Y, 10, drPO.dPODate.ToShortDateString) 'rsPOheader.Fields("dpodate").Value)
                If Not drPO.tVendorRow Is Nothing Then .set_TextMatrix(Y, 11, drPO.tVendorRow.sName) 'rsSupplier.Fields("sname").Value & "")
                .set_TextMatrix(Y, 12, oJob.Factor(drPO))
                .set_TextMatrix(Y, 13, drPO.tJobRow.sSalesperson) 'rsJob.Fields("sSalesperson").Value & "")
                If Not drPO.IsDRECNull Then .set_TextMatrix(Y, 14, drPO.DREC.ToShortDateString) 'rsPOheader.Fields("dRec").Value & "")
                .set_TextMatrix(Y, 15, drPO.SRECNOTES) 'rsPOheader.Fields("sRecNotes").Value & "")
                If Not drPO.IsDFAXEDNull Then .set_TextMatrix(Y, 16, drPO.DFAXED.ToShortDateString) ' rsPOheader.Fields("dfaxed").Value & "")
                If Not drPO.IsdSimplyNull Then .set_TextMatrix(Y, 17, drPO.dSimply.ToShortDateString) 'rsPOheader.Fields("dSimply").Value & "")
                .set_TextMatrix(Y, 18, drPO.nInvNo) 'rsPOheader.Fields("nInvNo").Value & "")
                .set_TextMatrix(Y, 19, drPO.bSimply) 'rsPOheader.Fields("bSimply").Value & "")
                .set_TextMatrix(Y, 20, False)
                .set_TextMatrix(Y, 21, drPO.dRequired.ToShortDateString) 'rsPOheader.Fields("drequired").Value & "")
                .set_TextMatrix(Y, 22, drPO.sBackOrder) 'rsPOheader.Fields("sBackorder").Value & "")
                .Select(Y, 21)
                .CellAlignment = AlignmentSettings.flexAlignRightCenter

                '.CellBorder(System.Convert.ToUInt32(Color.Black), 1, 0, 0, 0, 0, 0)

                .Select(Y, 22)
                .CellAlignment = AlignmentSettings.flexAlignRightCenter
                If UCase(drPO.sBackOrder) = "YES" Then
                    .CellBackColor = global_ColorFromHex(&H99, &H99, &H99)
                End If
                ' For X = 0 To 18
                .Select(Y, x, Y, 18)
                .CellAlignment = AlignmentSettings.flexAlignLeftCenter
                '.CellBorder(System.Convert.ToUInt32(Color.Black), 0, 1, 0, 0, 0, 0)

                x = 0

            Next
            If gridReport.Rows > 6 Then
                .Rows = .Rows + 1
                Y = gridReport.Rows - 1
                .set_MergeRow(gridReport.Rows - 1, True)
                .set_Cell(CellPropertySettings.flexcpAlignment, Y, 1, Y, 14, AlignmentSettings.flexAlignLeftCenter)
                .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 14, True)
                .set_RowHeight(.Rows - 1, 50)
            End If

            .Select(0, 0)
            .Redraw = True
        End With
    End Sub

    Private Sub gridreport_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridReport.MouseDown
        Try
            With gridReport
                If .MouseRow > -1 Then
                    If IsNumeric(.get_TextMatrix(.MouseRow, 0)) Then
                        Select Case .MouseCol
                            Case 22
                                .Select(.MouseRow, 22)
                                .CellBackColor = global_ColorFromHex(&H99, &H99, &H99)
                                If .get_TextMatrix(.MouseRow, 22) = "Yes" Then
                                    .set_TextMatrix(.MouseRow, 22, "No")
                                Else
                                    .set_TextMatrix(.MouseRow, 22, "Yes")
                                End If
                                .set_TextMatrix(.MouseRow, 20, True)
                                bChanges = True
                            Case 14
                                If .MouseRow > -1 Then
                                    .Select(.MouseRow, 14)
                                    .set_TextMatrix(.MouseRow, 14, Month(Now) & "/" & VB.Day(Now) & "/" & Year(Now))
                                    .EditCell()
                                    .set_TextMatrix(.MouseRow, 20, True)
                                    .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)
                                    bChanges = True
                                End If
                            Case 15
                                If .MouseRow > -1 Then
                                    .Select(.MouseRow, 15)
                                    .EditCell()
                                    .set_TextMatrix(.MouseRow, 20, True)
                                    .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)
                                    bChanges = True
                                End If

                            Case 2
                                If bChanges Then SaveChanges()
                                openpo()
                            Case 15
                                If .MouseRow = 2 Then
                                    .Select(.MouseRow, 15)
                                    .EditCell()
                                End If
                        End Select
                    Else

                    End If
                End If
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class