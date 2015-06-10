Option Strict Off
Option Explicit On
Option Compare Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid

Friend Class rptSIMPLY
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents chkViewMoreDates As System.Windows.Forms.CheckBox
    Public WithEvents cmdInvSync As System.Windows.Forms.Button
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents gridSupplier As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Public WithEvents gridDate As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents gridReport As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents cmdRecord As System.Windows.Forms.Button
    Public WithEvents cmdApplyShippingPerBox As System.Windows.Forms.Button
    Public WithEvents txtShipping As System.Windows.Forms.TextBox
    Public WithEvents cmdPOsearch As System.Windows.Forms.Button
    Public WithEvents txtPOsearch As System.Windows.Forms.TextBox
    Public WithEvents lblPOsearch As System.Windows.Forms.Label
    Public WithEvents chkHideSimply As System.Windows.Forms.CheckBox
    Friend WithEvents daPOHeaderALL As System.Data.SqlClient.SqlDataAdapter

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSIMPLY))
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkViewMoreDates = New System.Windows.Forms.CheckBox()
        Me.cmdInvSync = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.gridSupplier = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.gridDate = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gridReport = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkHideSimply = New System.Windows.Forms.CheckBox()
        Me.cmdRecord = New System.Windows.Forms.Button()
        Me.cmdApplyShippingPerBox = New System.Windows.Forms.Button()
        Me.txtShipping = New System.Windows.Forms.TextBox()
        Me.cmdPOsearch = New System.Windows.Forms.Button()
        Me.txtPOsearch = New System.Windows.Forms.TextBox()
        Me.lblPOsearch = New System.Windows.Forms.Label()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
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
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bSimply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dSimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.chkViewMoreDates)
        Me.Panel2.Controls.Add(Me.cmdInvSync)
        Me.Panel2.Controls.Add(Me.cmdPrint)
        Me.Panel2.Controls.Add(Me.gridSupplier)
        Me.Panel2.Controls.Add(Me.gridDate)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel2.Size = New System.Drawing.Size(180, 875)
        Me.Panel2.TabIndex = 11
        '
        'chkViewMoreDates
        '
        Me.chkViewMoreDates.BackColor = System.Drawing.SystemColors.Control
        Me.chkViewMoreDates.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkViewMoreDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewMoreDates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkViewMoreDates.Location = New System.Drawing.Point(34, 601)
        Me.chkViewMoreDates.Name = "chkViewMoreDates"
        Me.chkViewMoreDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkViewMoreDates.Size = New System.Drawing.Size(113, 19)
        Me.chkViewMoreDates.TabIndex = 8
        Me.chkViewMoreDates.Text = "View Past Dates"
        Me.chkViewMoreDates.UseVisualStyleBackColor = False
        '
        'cmdInvSync
        '
        Me.cmdInvSync.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInvSync.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInvSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvSync.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInvSync.Location = New System.Drawing.Point(7, 561)
        Me.cmdInvSync.Margin = New System.Windows.Forms.Padding(20)
        Me.cmdInvSync.Name = "cmdInvSync"
        Me.cmdInvSync.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInvSync.Size = New System.Drawing.Size(166, 28)
        Me.cmdInvSync.TabIndex = 7
        Me.cmdInvSync.Text = "Invoice# Sync"
        Me.cmdInvSync.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(7, 523)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(20)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(166, 29)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'gridSupplier
        '
        Me.gridSupplier.BackColorSel = System.Drawing.Color.LightYellow
        Me.gridSupplier.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridSupplier.FixedCols = 0
        Me.gridSupplier.FixedRows = 0
        Me.gridSupplier.ForeColorSel = System.Drawing.Color.Black
        Me.gridSupplier.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridSupplier.Location = New System.Drawing.Point(4, 261)
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.NodeClosedPicture = Nothing
        Me.gridSupplier.NodeOpenPicture = Nothing
        Me.gridSupplier.OutlineCol = -1
        Me.gridSupplier.Size = New System.Drawing.Size(172, 245)
        Me.gridSupplier.StyleInfo = resources.GetString("gridSupplier.StyleInfo")
        Me.gridSupplier.TabIndex = 5
        Me.gridSupplier.TreeColor = System.Drawing.Color.DarkGray
        '
        'gridDate
        '
        Me.gridDate.BackColorSel = System.Drawing.Color.Yellow
        Me.gridDate.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridDate.FixedCols = 0
        Me.gridDate.FixedRows = 0
        Me.gridDate.ForeColorSel = System.Drawing.Color.Black
        Me.gridDate.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridDate.Location = New System.Drawing.Point(4, 21)
        Me.gridDate.Name = "gridDate"
        Me.gridDate.NodeClosedPicture = Nothing
        Me.gridDate.NodeOpenPicture = Nothing
        Me.gridDate.OutlineCol = -1
        Me.gridDate.Size = New System.Drawing.Size(172, 240)
        Me.gridDate.StyleInfo = resources.GetString("gridDate.StyleInfo")
        Me.gridDate.TabIndex = 1
        Me.gridDate.TreeColor = System.Drawing.Color.DarkGray
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(172, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week of:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.gridReport)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(180, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel3.Size = New System.Drawing.Size(1328, 875)
        Me.Panel3.TabIndex = 12
        '
        'gridReport
        '
        Me.gridReport.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridReport.FixedCols = 0
        Me.gridReport.FixedRows = 0
        Me.gridReport.GridColor = System.Drawing.Color.Black
        Me.gridReport.GridColorFixed = System.Drawing.Color.Black
        Me.gridReport.GridLines = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridSkipHorz
        Me.gridReport.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridFlatHorz
        Me.gridReport.Location = New System.Drawing.Point(4, 4)
        Me.gridReport.Name = "gridReport"
        Me.gridReport.NodeClosedPicture = Nothing
        Me.gridReport.NodeOpenPicture = Nothing
        Me.gridReport.OutlineCol = -1
        Me.gridReport.Size = New System.Drawing.Size(1320, 805)
        Me.gridReport.StyleInfo = resources.GetString("gridReport.StyleInfo")
        Me.gridReport.TabIndex = 0
        Me.gridReport.TreeColor = System.Drawing.Color.DarkGray
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.chkHideSimply)
        Me.Panel4.Controls.Add(Me.cmdRecord)
        Me.Panel4.Controls.Add(Me.cmdApplyShippingPerBox)
        Me.Panel4.Controls.Add(Me.txtShipping)
        Me.Panel4.Controls.Add(Me.cmdPOsearch)
        Me.Panel4.Controls.Add(Me.txtPOsearch)
        Me.Panel4.Controls.Add(Me.lblPOsearch)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(4, 809)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel4.Size = New System.Drawing.Size(1320, 62)
        Me.Panel4.TabIndex = 1
        '
        'chkHideSimply
        '
        Me.chkHideSimply.BackColor = System.Drawing.SystemColors.Control
        Me.chkHideSimply.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHideSimply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideSimply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHideSimply.Location = New System.Drawing.Point(402, 34)
        Me.chkHideSimply.Margin = New System.Windows.Forms.Padding(9)
        Me.chkHideSimply.Name = "chkHideSimply"
        Me.chkHideSimply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHideSimply.Size = New System.Drawing.Size(228, 17)
        Me.chkHideSimply.TabIndex = 10
        Me.chkHideSimply.Text = "Hide PO's sent to Sage"
        Me.chkHideSimply.UseVisualStyleBackColor = False
        '
        'cmdRecord
        '
        Me.cmdRecord.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRecord.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRecord.Location = New System.Drawing.Point(402, 2)
        Me.cmdRecord.Name = "cmdRecord"
        Me.cmdRecord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRecord.Size = New System.Drawing.Size(228, 24)
        Me.cmdRecord.TabIndex = 3
        Me.cmdRecord.Text = "Send to Sage Accounting"
        Me.cmdRecord.UseVisualStyleBackColor = False
        '
        'cmdApplyShippingPerBox
        '
        Me.cmdApplyShippingPerBox.BackColor = System.Drawing.SystemColors.Control
        Me.cmdApplyShippingPerBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdApplyShippingPerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApplyShippingPerBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdApplyShippingPerBox.Location = New System.Drawing.Point(123, 32)
        Me.cmdApplyShippingPerBox.Name = "cmdApplyShippingPerBox"
        Me.cmdApplyShippingPerBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdApplyShippingPerBox.Size = New System.Drawing.Size(164, 23)
        Me.cmdApplyShippingPerBox.TabIndex = 5
        Me.cmdApplyShippingPerBox.Text = "Full Truck Shipping Recalc"
        Me.cmdApplyShippingPerBox.UseVisualStyleBackColor = False
        '
        'txtShipping
        '
        Me.txtShipping.AcceptsReturn = True
        Me.txtShipping.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipping.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipping.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipping.Location = New System.Drawing.Point(6, 32)
        Me.txtShipping.MaxLength = 0
        Me.txtShipping.Name = "txtShipping"
        Me.txtShipping.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipping.Size = New System.Drawing.Size(112, 21)
        Me.txtShipping.TabIndex = 4
        '
        'cmdPOsearch
        '
        Me.cmdPOsearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPOsearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPOsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPOsearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPOsearch.Location = New System.Drawing.Point(123, 3)
        Me.cmdPOsearch.Name = "cmdPOsearch"
        Me.cmdPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPOsearch.Size = New System.Drawing.Size(74, 23)
        Me.cmdPOsearch.TabIndex = 2
        Me.cmdPOsearch.Text = "PO Search"
        Me.cmdPOsearch.UseVisualStyleBackColor = False
        '
        'txtPOsearch
        '
        Me.txtPOsearch.AcceptsReturn = True
        Me.txtPOsearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtPOsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPOsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOsearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPOsearch.Location = New System.Drawing.Point(6, 3)
        Me.txtPOsearch.MaxLength = 0
        Me.txtPOsearch.Name = "txtPOsearch"
        Me.txtPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPOsearch.Size = New System.Drawing.Size(112, 21)
        Me.txtPOsearch.TabIndex = 1
        '
        'lblPOsearch
        '
        Me.lblPOsearch.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOsearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPOsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOsearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPOsearch.Location = New System.Drawing.Point(202, 3)
        Me.lblPOsearch.Name = "lblPOsearch"
        Me.lblPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPOsearch.Size = New System.Drawing.Size(89, 21)
        Me.lblPOsearch.TabIndex = 7
        '
        'rptSIMPLY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1508, 875)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptSIMPLY"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Sage By Week Supplier Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private bLoading As Boolean
    Private dGridDate As Date
    Private lGridSupplier As Integer
    Dim lastcheck As Integer
    Dim lastInv As Integer
    Private bChanges As Boolean
    Private discount As Double
    Private bLoad1Supplier As Boolean
    Private lSupplierSelected As Integer
    Private lTruckSelected As Integer

    Private totalboxes As Long

    Private oJob As New JobObj

    Private Sub chkViewMoreDates_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkViewMoreDates.CheckedChanged
        gridDateInit(-24)
    End Sub

    Private Sub cmdApplyShippingPerBox_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdApplyShippingPerBox.Click

        If bChanges Then SaveChanges()
        Dim i As Short
        If IsNumeric(Me.txtShipping.Text) Then
            For i = 0 To gridReport.Rows - 1
                If Len(Me.gridReport.get_TextMatrix(i, 0)) > 3 Then
                    If IsNumeric(Me.gridReport.get_TextMatrix(i, 0)) Then
                        ApplyShippingToBoxes(CInt(Me.gridReport.get_TextMatrix(i, 0)), CDbl(Me.txtShipping.Text) / totalboxes)
                    End If
                End If
            Next
        Else
            MsgBox("Shipping box must have a total dollar amount.")
        End If
        gridReportALL()

    End Sub

    Private Sub ApplyShippingToBoxes(ByVal POID As Long, ByRef dblShip As Double)
        Dim drPO As dsTKSI.tPOHeaderRow
        drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
        If Not drPO Is Nothing Then
            If drPO.nBoxes > 0 Then
                oJob.UpdateShipping(Me.DsTKSI1, drPO, dblShip)
            End If
        End If

    End Sub

    Private Sub cmdInvSync_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInvSync.Click
        Dim frmbusy1 As New frmWorking

        Try
            frmbusy1.Show()
            Dim Y As Object
            Dim POID, VENID As Integer
            Dim FREIGHT, cost, discount As Decimal

            Dim sage1 As New clsSageAccountingTools
            If sage1.CompanyLoaded Then
                With gridReport
                    .Redraw = False
                    For Y = 4 To .Rows - 1
                        If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)) Then
                            POID = .get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)
                            cost = CDec(.get_TextMatrix(Y, 5))
                            FREIGHT = CDec(.get_TextMatrix(Y, 6))
                            discount = cost * 0.02

                            Dim drPO As dsTKSI.tPOHeaderRow
                            drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
                            If Not drPO Is Nothing Then
                                VENID = drPO.nVendorID
                                Dim purinv = sage1.GetInvFromPO(drPO.sPONum)
                                If purinv IsNot Nothing Then
                                    If purinv.Length > 0 Then
                                        drPO.nInvNo = purinv
                                    End If
                                End If
                            End If
                        End If
                    Next

                    Try
                        Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
                        Me.DsTKSI1.tPOHeader.AcceptChanges()
                    Catch ex As Exception
                        Windows.Forms.MessageBox.Show("Error saving some data... " & ex.Message)
                    End Try
                    .Redraw = True
                End With
            End If

            LoadReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Try
                frmbusy1.Close()
            Catch
            End Try
        End Try
    End Sub

    Private Sub cmdPOSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPOsearch.Click
        Try
            lblPOsearch.Text = GetDateRequired(Me.txtPOsearch.Text)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        If bChanges Then SaveChanges()
        gridReport.set_ColHidden(21, True)
        gridReport.PrintGrid("", 1, 0, 10, 10)
        gridReport.set_ColHidden(21, False)
    End Sub

    Private Sub cmdRec_Click()

        Dim Y As Integer
        Dim frmDisc As New frmDiscount1
        If bChanges Then
            frmDisc.ShowDialog()
            If frmDisc.blnOK Then
                discount = frmDisc.txtDiscount.Text
            Else
                Exit Sub
                Windows.Forms.MessageBox.Show("no changes made")
            End If
        End If
        With gridReport
            .Redraw = False
            For Y = 4 To .Rows - 1
                If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)) Then
                    If CBool(.get_TextMatrix(Y, 20)) = True Then
                        If CBool(.get_TextMatrix(Y, 19)) = False Or UCase(.get_TextMatrix(Y, 21)) = "YES" Then
                            If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)) Then
                                Dim drPO As dsTKSI.tPOHeaderRow
                                drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))
                                If Not drPO Is Nothing Then
                                    If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)) Then
                                        If UpdateSimply(drPO, discount) Then
                                            drPO.dSimply = .get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)
                                            drPO.bSimply = True
                                            .set_TextMatrix(Y, 19, True)
                                        End If
                                    Else 'if PO is in Simply already then update fields in job
                                        'database cause they should already have been updated
                                        drPO.bSimply = True ' rsPO.Fields("bSimply").Value = True
                                        If Not drPO.IsdSimplyNull Then
                                            drPO.dSimply = Today 'rsPO.Fields("dSimply").Value = Today
                                        End If

                                    End If
                                    Try
                                        Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
                                        Me.DsTKSI1.tPOHeader.AcceptChanges()
                                    Catch ex As Exception
                                        Windows.Forms.MessageBox.Show("Error saving some data... " & ex.Message)
                                    End Try
                                End If
                            End If
                        End If
                        If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)) Or Len(.get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)) < 1 Then

                            Dim drPO As dsTKSI.tPOHeaderRow
                            drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))
                            If Not drPO Is Nothing Then
                                If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)) Then
                                    If .get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18) > 0 Then
                                        drPO.nInvNo = .get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)
                                    End If
                                Else
                                    drPO.nInvNo = ""
                                End If
                            End If
                        End If
                    End If
                    Try
                        Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
                        Me.DsTKSI1.tPOHeader.AcceptChanges()
                    Catch ex As Exception
                        Windows.Forms.MessageBox.Show("Error saving some data... " & ex.Message)
                    End Try
                End If
            Next
            bChanges = False
            .Redraw = True
        End With

        LoadReport()
    End Sub

    Private Sub cmdRecord_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRecord.Click
        If bChanges Then
            SaveChanges()
        End If
    End Sub

    Private Sub cmdRefresh_Click()
        If bChanges Then
            SaveChanges()
        End If
        LoadReport()
        bLoading = False
    End Sub

    Private Sub SaveChanges()
        If bChanges Then
            cmdRec_Click()
        End If
    End Sub

    Private Sub rptSIMPLY_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'this data does not get refreshed using different parameters during report useage
        'so only load once
        oJob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1)
        bChanges = False
        bLoad1Supplier = False
        bLoading = True
        gridDateInit()
        gridSupplierInit()
    End Sub

    Private Sub LoadReport()
        gridReportALL()
    End Sub

    Private Sub gridDateInit(Optional ByRef startWeek As Short = -8)
        'gridDate.Redraw = False
        gridDate.Rows = 0
        gridDate.Cols = 2
        'gridDate.set_ColWidth(1, 1350)
        gridDate.set_ColWidth(0, 140)
        getdates(startWeek)
        gridDate.Redraw = True

    End Sub

    Private Sub gridSupplierInit()
        With gridSupplier
            .Cols = 3
            .Rows = 0
            .set_ColWidth(2, 140)
            .set_ColHidden(0, True)
            .set_ColHidden(1, True)

        End With

    End Sub
    Private Sub getdates(ByRef startWeek As Short)
        Dim today_Renamed, thisWednesday As Date
        Dim add_Renamed, dayofweek, i As Integer
        Dim strDate As String
        For i = startWeek To 15
            today_Renamed = DateAdd(DateInterval.Day, i * 7, Today) 'two weeks ago to 5 weeks from now
            dayofweek = Weekday(today_Renamed)
            add_Renamed = 4 - dayofweek ' difference between current day of week and wednesday
            thisWednesday = DateAdd(DateInterval.Day, add_Renamed, today_Renamed)
            If i = 0 Then
                strDate = "This Week"
            Else

                strDate = CStr(thisWednesday)
            End If
            gridDate.AddItem(thisWednesday & vbTab & strDate)
            gridDate.set_ColHidden(1, True)
        Next
    End Sub

    Private Sub rptSIMPLY_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        If bChanges Then SaveChanges()
    End Sub

    Sub openpo()
        gridReport.Select(gridReport.RowSel, 0)
        If IsNumeric(gridReport.Text) Then
            If CInt(gridReport.Text) > 0 Then
                ShowPO(CInt(gridReport.Text))
            End If
        Else
            MsgBox("Error: grid ID is incorrect")
        End If
    End Sub

    Private Sub ShowPO(ByRef POID As Integer)
        Dim drPO As dsTKSI.tPOHeaderRow
        drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
        If Not drPO Is Nothing Then
            If POID > 0 Then
                OpenPOScreen(drPO.nID, True)
                Me.LoadReport()
            End If
        End If
    End Sub

    Private Sub gridClicks()
        If gridDate.RowSel > -1 Then
            gridDate.Select(gridDate.RowSel, 0)
            If IsDate(gridDate.Text) Then
                dGridDate = CDate(gridDate.Text)
                gridReportALL()
            Else
                gridReport.Rows = 0
            End If
        End If
    End Sub

    Private Sub gridReportALL()
        Try
            Dim lasttruck As Long
            Dim lastvendor As Long
            Dim strtemp As String
            Dim totalFRsale As Decimal
            Dim totalPOSale As Decimal
            Dim strtotals As String
            Dim strsupplier As String
            Dim txtDate2 As String = ""
            Dim txtDate1 As String = ""

            gridReport.Redraw = False
            Dim x, Y As Integer
            Dim totalPOCOST As Decimal
            Dim totalFRCost As Decimal
            ' Dim oPO As New PO
            Dim date1 As Date
            Dim date2 As Date

            gridSupplier.Rows = 0
            totalboxes = 0

            If IsDate2(txtDate1) And IsDate2(txtDate2) Then
                date1 = CDate(txtDate1)
                date2 = CDate(txtDate2)
            Else
                If InStr(dGridDate, ":") > 0 Then
                    'show no data
                    dGridDate = CDate("1/1/1990")
                End If
                date1 = DateAdd(DateInterval.Day, -3, dGridDate)
                date2 = DateAdd(DateInterval.Day, 3, dGridDate)
            End If

            With gridReport

                '.Width = Me.Width - 220
                '.Height = Me.Height - 220

                .Cols = 22
                .Rows = 0
                .Rows = 5

                Dim csbold As CellStyle = gridReport.Styles.Add("bold1")
                csbold.Font = New Font("Tahoma", 8, FontStyle.Bold)

                Dim b1 As CellBorder = csbold.Border
                b1.Style = BorderStyleEnum.None
                csbold.BackColor = Color.White
                ' assign bold style to a cell range
                Dim rg As CellRange = gridReport.GetCellRange(0, 0, 3, gridReport.Cols - 1)
                rg.Style = gridReport.Styles("bold1")

                ' .GridLines = GridStyleSettings.flexGridNone
                Y = .Rows - 1

                .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "Payment (Simply Accounting)")
                .set_Cell(CellPropertySettings.flexcpText, 2, 1, 2, 3, "WEEK OF: " & dGridDate)
                .set_Cell(CellPropertySettings.flexcpText, 2, 14, 2, 14, "TRUCK#:")
                .set_Cell(CellPropertySettings.flexcpText, 2, 15, 2, 15, "")
                .set_Cell(CellPropertySettings.flexcpAlignment, 2, 15, 2, 15, AlignmentSettings.flexAlignLeftCenter)
                .set_Cell(CellPropertySettings.flexcpBackColor, 2, 14, 2, 15, cWhite)
                .Select(2, 14, 2, 15)
                ' .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D '(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)

                .set_ColWidth(1, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(2, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(3, 1500 / global_OldGridNewGridRation)
                .set_ColWidth(4, 500 / global_OldGridNewGridRation)
                .set_ColWidth(5, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(6, 700 / global_OldGridNewGridRation)
                .set_ColWidth(7, 900 / global_OldGridNewGridRation)
                .set_ColWidth(8, 700 / global_OldGridNewGridRation)
                .set_ColWidth(9, 900 / global_OldGridNewGridRation)
                .set_ColWidth(10, 700 / global_OldGridNewGridRation)
                .set_ColWidth(11, 1300 / global_OldGridNewGridRation)
                .set_ColWidth(12, 600 / global_OldGridNewGridRation)
                .set_ColWidth(13, 700 / global_OldGridNewGridRation)
                .set_ColWidth(14, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(15, 2500 / global_OldGridNewGridRation)
                .set_ColWidth(16, 900 / global_OldGridNewGridRation)
                .set_ColWidth(17, 900 / global_OldGridNewGridRation)
                .set_ColWidth(18, 900 / global_OldGridNewGridRation)
                .set_ColWidth(19, 800 / global_OldGridNewGridRation)
                .set_ColWidth(21, 700 / global_OldGridNewGridRation)

                .set_ColHidden(0, True)

                .set_ColHidden(1, True)
                .set_ColHidden(2, False)
                .set_ColHidden(3, False)
                .set_ColHidden(4, False)
                .set_ColHidden(5, False)
                .set_ColHidden(6, False)
                .set_ColHidden(7, False)
                .set_ColHidden(8, False)
                .set_ColHidden(9, False)
                .set_ColHidden(10, True)
                .set_ColHidden(11, True)
                .set_ColHidden(12, False)
                .set_ColHidden(13, False)
                .set_ColHidden(14, True)
                .set_ColHidden(15, True)
                .set_ColHidden(16, True)
                .set_ColHidden(17, False)
                .set_ColHidden(18, False)
                .set_ColHidden(19, True)
                .set_ColHidden(20, True)
                .set_ColHidden(21, False)

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
                .set_TextMatrix(4, 17, "Date>Sage")
                .set_TextMatrix(4, 18, "Invoice#")
                .set_TextMatrix(4, 21, "RESEND")
                .set_ColDataType(19, GetType(Boolean))
                .set_ColDataType(20, GetType(Boolean))
            End With
            gridReport.FrozenRows = 5

            If Not oJob.SelectPOandLinesByDateRequiredRange(Me.DsTKSI1, date1, date2) Then
                Windows.Forms.MessageBox.Show("error loading data needed to show this report.")
            End If

            With gridReport
                Dim drpo As dsTKSI.tPOHeaderRow
                For Each drpo In Me.DsTKSI1.tPOHeader
                    Dim blnDoThisLoop As Boolean = False
                    If bLoad1Supplier Then
                        If drpo.nTruck = lTruckSelected And drpo.nVendorID = Me.lSupplierSelected Then
                            blnDoThisLoop = True
                        Else
                            blnDoThisLoop = False
                        End If
                    Else
                        blnDoThisLoop = True
                    End If

                    If blnDoThisLoop Then
                        Y = gridReport.Rows - 1
                        If lastvendor <> drpo.nVendorID Or drpo.nTruck <> lasttruck Then
                            'setup vendor TOTALS
                            strsupplier = drpo.tVendorRow.lid & vbTab & drpo.nTruck & vbTab
                            If drpo.nTruck > 1 Then
                                strsupplier = strsupplier & "(" & drpo.nTruck & ")"
                            End If
                            strsupplier = strsupplier & drpo.tVendorRow.sName
                            gridSupplier.AddItem(strsupplier & vbTab & strsupplier & vbTab & strsupplier)
                            .set_MergeRow(gridReport.Rows - 1, True)
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
                            If Not drpo.tVendorRow Is Nothing Then
                                strtemp = drpo.tVendorRow.sName & " - TRUCK: " & drpo.nTruck & vbTab
                                gridReport.AddItem(strtemp & vbTab & strtemp) '& vbTab & strtemp & vbTab & strtemp & vbTab & strtemp & vbTab & strtemp & vbTab & strtemp & vbTab & strtemp & vbTab & strtemp)

                            Else
                                gridReport.AddItem("" & vbTab & "NO VENDOR" & vbTab & "NO VENDOR")
                            End If
                            Y = gridReport.Rows - 1
                            gridReport.set_MergeRow(gridReport.Rows - 1, True)
                            gridReport.set_Cell(CellPropertySettings.flexcpAlignment, Y, 0, Y, 8, AlignmentSettings.flexAlignLeftCenter)
                            gridReport.set_Cell(CellPropertySettings.flexcpFontBold, Y, 0, Y, 8, True)

                        End If
                        lastvendor = drpo.nVendorID
                        lasttruck = drpo.nTruck


                        If (drpo.IsdSimplyNull) Or Me.chkHideSimply.Checked = False Then
                            gridReport.Rows = gridReport.Rows + 1
                            Y = gridReport.Rows - 1

                            .set_RowHeight(Y, 400 / global_OldGridNewGridRation)
                            .set_TextMatrix(Y, 0, drpo.nID)
                            .set_TextMatrix(Y, 1, drpo.sConf)
                            .set_TextMatrix(Y, 2, drpo.sPONum)

                            If drpo.tJobRow Is Nothing Then
                                Throw New Exception(drpo.sPONum & " Job data needs refresh, please close this report window and re-open it.")
                            End If
                            If Not drpo.tJobRow.tCustomrRow Is Nothing Then .set_TextMatrix(Y, 3, drpo.tJobRow.tCustomrRow.sName & "") 'BUILDER NAME

                            If UCase(drpo.sBackOrder) = "YES" Then
                                .set_Cell(CellPropertySettings.flexcpBackColor, Y, 2, Y, 2, global_ColorFromHex(&HBB, &HBB, &HBB))
                            End If

                            If Not drpo.IsDDELNull Then
                                .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, global_ColorFromHex(&H99, &HFF, &H99)) ' global_ColorFromHex(&H99, &HFF, &H99))
                                .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                            ElseIf Not drpo.IsDRECNull Then
                                .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, cYellow)
                                .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                            End If

                            .set_TextMatrix(Y, 4, drpo.nBoxes)
                            .set_TextMatrix(Y, 5, oJob.GetPOCostByCode(drpo, 5010) + oJob.GetPOCostByCode(drpo, 5020) + oJob.GetPOCostByCode(drpo, 5030) + oJob.GetPOCostByCode(drpo, 5260) + oJob.GetPOCostByCode(drpo, 5270) + oJob.GetPOCostByCode(drpo, 5490) + oJob.GetPOCostByCode(drpo, 4700) + oJob.GetPOCostByCode(drpo, 5040))
                            .set_TextMatrix(Y, 6, System.Math.Round(oJob.GetPOCostByCode(drpo, 5070), 2)) 'PO FREIGHT COST

                            totalboxes = totalboxes + drpo.nBoxes
                            If IsNumeric(.get_TextMatrix(Y, 5)) Then
                                totalPOCOST = totalPOCOST + CDbl(.get_TextMatrix(Y, 5))
                            End If
                            If IsNumeric(.get_TextMatrix(Y, 6)) Then
                                totalFRCost = totalFRCost + CDbl(.get_TextMatrix(Y, 6))
                            End If
                            .set_TextMatrix(Y, 7, drpo.nRetailSale + drpo.nAdd)
                            If IsNumeric(.get_TextMatrix(Y, 7)) Then
                                totalPOSale = totalPOSale + .get_TextMatrix(Y, 7)
                            End If
                            .set_TextMatrix(Y, 8, drpo.nRetailFreight)
                            If IsNumeric(.get_TextMatrix(Y, 8)) Then
                                totalFRsale = totalFRsale + .get_TextMatrix(Y, 8)
                            End If
                            If Not drpo.IsdRequiredNull Then .set_TextMatrix(Y, 9, drpo.dRequired.ToShortDateString)
                            If Not drpo.IsdPODateNull Then .set_TextMatrix(Y, 10, drpo.dPODate.ToShortDateString)
                            If Not drpo.tVendorRow Is Nothing Then .set_TextMatrix(Y, 11, drpo.tVendorRow.sName)
                            .set_TextMatrix(Y, 12, oJob.Factor(drpo))
                            .set_TextMatrix(Y, 13, drpo.tJobRow.sSalesperson)
                            If Not drpo.IsDRECNull Then .set_TextMatrix(Y, 14, drpo.DREC.ToShortDateString)
                            .set_TextMatrix(Y, 15, drpo.SRECNOTES)
                            If Not drpo.IsDFAXEDNull Then .set_TextMatrix(Y, 16, drpo.DFAXED.ToShortDateString)
                            If Not drpo.IsdSimplyNull Then .set_TextMatrix(Y, 17, drpo.dSimply.ToShortDateString)
                            .set_TextMatrix(Y, 18, drpo.nInvNo)
                            .set_TextMatrix(Y, 19, drpo.bSimply)
                            .set_TextMatrix(Y, 20, False)
                            .set_TextMatrix(Y, 21, "NO")
                            .Select(Y, x, Y, 18)
                            .CellAlignment = AlignmentSettings.flexAlignLeftCenter
                            '.CellBorder(System.Convert.ToUInt32(Color.Black), 0, 1, 0, 0, 0, 0)
                            x = 0
                        Else
                            'dont show already sent to simply
                        End If

                    End If
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
                        .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 13, True)
                        .set_RowHeight(.Rows - 1, 700 / global_OldGridNewGridRation)
                    End If
                End If
                .Select(0, 0)
                .Redraw = True
                .ScrollPosition = New Point(0, 0)
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub gridreport_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridReport.MouseDown
        With gridReport
            If IsNumeric(.get_TextMatrix(.MouseRow, 0)) Then
                Select Case .MouseCol
                    Case 2
                        If bChanges Then SaveChanges()
                        openpo()
                    Case 17
                        If .MouseRow > -1 Then
                            .Select(.MouseRow, 17)
                            .set_TextMatrix(.MouseRow, 17, Today)
                            .EditCell()
                            .set_TextMatrix(.MouseRow, 20, True)
                            .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, cYellow)
                            bChanges = True
                        End If
                    Case 21
                        If .MouseRow > -1 Then
                            .Select(.MouseRow, 21)
                            .set_TextMatrix(.MouseRow, 21, "YES")
                            .EditCell()
                            If CBool(.get_TextMatrix(.MouseRow, 19)) = False Then
                                MsgBox("This PO has never been sent to Simply Accounting")
                            End If
                            .set_TextMatrix(.MouseRow, 20, True)
                            .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, cYellow)
                            bChanges = True
                        End If
                End Select
            End If
        End With
    End Sub

    Private Sub gridDate_Click(sender As Object, e As EventArgs) Handles gridDate.Click
        date_click()
    End Sub

    Private Sub date_click()

        Dim txtDate2 As Object
        Dim txtDate1 As Object

        If gridDate.RowSel > -1 Then
            If bChanges Then SaveChanges()
            txtDate1 = ""
            txtDate2 = ""
            gridClicks()
            bLoad1Supplier = False
        End If

    End Sub

    Private Sub gridSupplier_Click(sender As Object, e As EventArgs) Handles gridSupplier.Click
        supplier_click()
    End Sub

    Private Sub chkHideSimply_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideSimply.CheckedChanged
        date_click()
    End Sub

    Private Sub supplier_click()
        bLoad1Supplier = True

        If bChanges Then SaveChanges()
        With gridSupplier
            If .RowSel > -1 Then
                lSupplierSelected = CInt(.get_TextMatrix(.RowSel, 0))
                lTruckSelected = CInt(.get_TextMatrix(.RowSel, 1))
            End If
        End With

        gridReportALL()
    End Sub

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private Sub btnWordReport_Click(sender As Object, e As EventArgs)
        Dim frmBusy1 As New frmWorking
        frmBusy1.Text = frmBusy1.Text & " Printing..."
        frmBusy1.Show()
        Try
            Dim listVendor1 As New List(Of clsWordDoc.VendorAndLines)
            Try
                With gridReport
                    .Redraw = False

                    Dim currentVen As clsWordDoc.VendorAndLines
                    For Y = 4 To .Rows - 1
                        If IsDate(.get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)) Then

                            Dim sPoid As String = .get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)
                            Dim iPoID As Integer = 0
                            If Integer.TryParse(sPoid, iPoID) Then
                                Dim q = (From row In dc.tPOHeaders Where row.nID = iPoID)
                                If q.Count > 0 Then
                                    Dim drPO = q.First
                                    Dim strVendorType As String = "Unknown Vendor Type "
                                    If drPO.tVendor.vendorType IsNot Nothing Then
                                        strVendorType = drPO.tVendor.vendorType
                                    End If
                                    If strVendorType.ToUpper.Contains("INSTAL") Then
                                        Dim strThisVendor = drPO.tVendor.sName
                                        If currentVen Is Nothing Then
                                            currentVen = New clsWordDoc.VendorAndLines
                                        End If
                                        If strThisVendor <> currentVen.strVendor Then
                                            currentVen = New clsWordDoc.VendorAndLines
                                            listVendor1.Add(currentVen)
                                            currentVen.strVendor = strThisVendor
                                            currentVen.decGrandTotal = 0

                                            currentVen.strPayPeriod = Get15thOr30thWhicheverIsCloserToToday.ToShortDateString  ' dGridDate.ToShortDateString

                                        End If

                                        Dim decCostTotal As Decimal = oJob.GetPOCost(drPO)
                                        Dim decCost As Decimal = oJob.GetPOCostByCode(drPO, 5040)

                                        Dim strLine As String = drPO.tJob.sJobNo & vbTab & Mid(drPO.tJob.tCustomr.sName, 1, 34) & vbTab & Mid(drPO.tJob.tAddress.sAddress1, 1, 26) & vbTab & Format(decCost, "currency")
                                        If decCost <> decCostTotal Then
                                            MessageBox.Show(drPO.sPONum & " has a cost mismatch, not all costs are 5040")
                                        End If
                                        currentVen.listWordLines.Add(strLine)
                                        currentVen.decGrandTotal += decCost
                                    End If


                                End If
                            End If

                        End If

                    Next

                End With
            Catch ex As Exception
                MessageBox.Show("error calculating vendor totals " & ex.Message)
            End Try

            Dim Word1 As New clsWordDoc
            Word1.CreateFlexInstallerReport(listVendor1)


        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmBusy1.Close()
        End Try
    End Sub
End Class