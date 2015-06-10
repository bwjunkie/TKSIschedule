Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports C1.Win.C1FlexGrid.Classic
Imports System.Drawing

Friend Class rptCurrentAcct
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
    Public WithEvents optSortName As System.Windows.Forms.RadioButton
	Public WithEvents optSortPO As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents optAll As System.Windows.Forms.RadioButton
	Public WithEvents optPast As System.Windows.Forms.RadioButton
	Public WithEvents fraPast As System.Windows.Forms.GroupBox
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents cmdUpdate As System.Windows.Forms.Button
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TKSIJOBSDataSet As TKSIJOBSDataSet
    Friend WithEvents TblJobActivityTableAdapter As TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents gridCA As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents TVendorTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter
    Friend WithEvents daJobALLSortCustName As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddressRecent As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPODDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineDDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCustomerALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendorALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPODDELNullSortPO As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOUpdate As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCurrentAcct))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optSortName = New System.Windows.Forms.RadioButton()
        Me.optSortPO = New System.Windows.Forms.RadioButton()
        Me.fraPast = New System.Windows.Forms.GroupBox()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optPast = New System.Windows.Forms.RadioButton()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPOUpdate = New System.Data.SqlClient.SqlDataAdapter()
        Me.TKSIJOBSDataSet = New TKSISchedule.TKSIJOBSDataSet()
        Me.TblJobActivityTableAdapter = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.gridCA = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.TVendorTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter()
        Me.daJobALLSortCustName = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.daAddressRecent = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.daPODDELnull = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineDDELnull = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.daCustomerALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.daVendorALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.daPODDELNullSortPO = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Frame1.SuspendLayout()
        Me.fraPast.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TKSIJOBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.optSortName)
        Me.Frame1.Controls.Add(Me.optSortPO)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(432, 778)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(241, 50)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Sort Type"
        '
        'optSortName
        '
        Me.optSortName.BackColor = System.Drawing.SystemColors.Control
        Me.optSortName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSortName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSortName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSortName.Location = New System.Drawing.Point(115, 20)
        Me.optSortName.Name = "optSortName"
        Me.optSortName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSortName.Size = New System.Drawing.Size(107, 21)
        Me.optSortName.TabIndex = 10
        Me.optSortName.TabStop = True
        Me.optSortName.Text = "By Customer"
        Me.optSortName.UseVisualStyleBackColor = False
        '
        'optSortPO
        '
        Me.optSortPO.BackColor = System.Drawing.SystemColors.Control
        Me.optSortPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSortPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSortPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSortPO.Location = New System.Drawing.Point(10, 20)
        Me.optSortPO.Name = "optSortPO"
        Me.optSortPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSortPO.Size = New System.Drawing.Size(87, 21)
        Me.optSortPO.TabIndex = 9
        Me.optSortPO.TabStop = True
        Me.optSortPO.Text = "By Job#"
        Me.optSortPO.UseVisualStyleBackColor = False
        '
        'fraPast
        '
        Me.fraPast.BackColor = System.Drawing.SystemColors.Control
        Me.fraPast.Controls.Add(Me.optAll)
        Me.fraPast.Controls.Add(Me.optPast)
        Me.fraPast.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraPast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPast.Location = New System.Drawing.Point(202, 778)
        Me.fraPast.Name = "fraPast"
        Me.fraPast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraPast.Size = New System.Drawing.Size(212, 50)
        Me.fraPast.TabIndex = 5
        Me.fraPast.TabStop = False
        Me.fraPast.Text = "Delivery Filter"
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.SystemColors.Control
        Me.optAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAll.Location = New System.Drawing.Point(144, 20)
        Me.optAll.Name = "optAll"
        Me.optAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAll.Size = New System.Drawing.Size(59, 21)
        Me.optAll.TabIndex = 7
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'optPast
        '
        Me.optPast.BackColor = System.Drawing.SystemColors.Control
        Me.optPast.Cursor = System.Windows.Forms.Cursors.Default
        Me.optPast.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optPast.Location = New System.Drawing.Point(10, 20)
        Me.optPast.Name = "optPast"
        Me.optPast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optPast.Size = New System.Drawing.Size(78, 21)
        Me.optPast.TabIndex = 6
        Me.optPast.TabStop = True
        Me.optPast.Text = "Past Due"
        Me.optPast.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(10, 778)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(154, 29)
        Me.cmdRefresh.TabIndex = 4
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUpdate.Location = New System.Drawing.Point(720, 815)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUpdate.Size = New System.Drawing.Size(163, 29)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Save/Update Changes"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(720, 778)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(163, 29)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
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
        Me.sqlConn.ConnectionString = "Data Source=DELL-SERVER;Initial Catalog=TKSIJOBS;Persist Security Info" & _
    "=True;User ID=tksidatauser;Password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@sCurActNote", System.Data.SqlDbType.VarChar, 255, "sCurActNote"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCurActNote", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCurActNote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daPOUpdate
        '
        Me.daPOUpdate.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPOUpdate.UpdateCommand = Me.SqlUpdateCommand1
        '
        'TKSIJOBSDataSet
        '
        Me.TKSIJOBSDataSet.DataSetName = "TKSIJOBSDataSet"
        Me.TKSIJOBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblJobActivityTableAdapter
        '
        Me.TblJobActivityTableAdapter.ClearBeforeFill = True
        '
        'gridCA
        '
        Me.gridCA.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeNone
        Me.gridCA.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.gridCA.Cols = 6
        Me.gridCA.ColumnInfo = "6,0,0,0,0,100,Columns:"
        Me.gridCA.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridCA.FixedCols = 0
        Me.gridCA.FixedRows = 0
        Me.gridCA.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridCA.Location = New System.Drawing.Point(0, 0)
        Me.gridCA.Name = "gridCA"
        Me.gridCA.NodeClosedPicture = Nothing
        Me.gridCA.NodeOpenPicture = Nothing
        Me.gridCA.OutlineCol = -1
        Me.gridCA.Rows = 0
        Me.gridCA.Size = New System.Drawing.Size(903, 750)
        Me.gridCA.StyleInfo = resources.GetString("gridCA.StyleInfo")
        Me.gridCA.TabIndex = 9
        Me.gridCA.TreeColor = System.Drawing.Color.DarkGray
        '
        'TVendorTableAdapter1
        '
        Me.TVendorTableAdapter1.ClearBeforeFill = True
        '
        'daJobALLSortCustName
        '
        Me.daJobALLSortCustName.SelectCommand = Me.SqlSelectCommand17
        Me.daJobALLSortCustName.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand17
        '
        Me.SqlSelectCommand17.CommandText = resources.GetString("SqlSelectCommand17.CommandText")
        Me.SqlSelectCommand17.Connection = Me.sqlConn
        '
        'daAddressRecent
        '
        Me.daAddressRecent.SelectCommand = Me.SqlCommand4
        Me.daAddressRecent.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
        Me.SqlCommand4.Connection = Me.sqlConn
        '
        'daPODDELnull
        '
        Me.daPODDELnull.SelectCommand = Me.SqlSelectCommand16
        Me.daPODDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = resources.GetString("SqlSelectCommand16.CommandText")
        Me.SqlSelectCommand16.Connection = Me.sqlConn
        '
        'daPOLineDDELnull
        '
        Me.daPOLineDDELnull.SelectCommand = Me.SqlSelectCommand15
        Me.daPOLineDDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = resources.GetString("SqlSelectCommand15.CommandText")
        Me.SqlSelectCommand15.Connection = Me.sqlConn
        '
        'daCustomerALL
        '
        Me.daCustomerALL.SelectCommand = Me.SqlSelectCommand14
        Me.daCustomerALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT lID, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax, dCrLimit, dAmtYTD FROM tCustomr"
        Me.SqlSelectCommand14.Connection = Me.sqlConn
        '
        'daVendorALL
        '
        Me.daVendorALL.SelectCommand = Me.SqlSelectCommand13
        Me.daVendorALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT DISTINCT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPos" & _
    "talZip, sPhone1, sPhone2, sFax FROM tVendor ORDER BY sName"
        Me.SqlSelectCommand13.Connection = Me.sqlConn
        '
        'daPODDELNullSortPO
        '
        Me.daPODDELNullSortPO.SelectCommand = Me.SqlCommand1
        Me.daPODDELNullSortPO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.sqlConn
        '
        'rptCurrentAcct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(903, 700)
        Me.Controls.Add(Me.gridCA)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.fraPast)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdPrint)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptCurrentAcct"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Current Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame1.ResumeLayout(False)
        Me.fraPast.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TKSIJOBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private ojob As New JobObj
    Dim nLastPO As Integer = 0
    Dim altColor As Color = Color.White

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        gridCA.set_ColHidden(6, True)
        gridCA.PrintGrid("CURRENT ACOUNTS , PRINTED:" & Today, True, 1, 5, 5)
        gridCA.set_ColHidden(6, False)
    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        gridCALoad()
    End Sub

    Private Sub cmdUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUpdate.Click
        UpdateDDel()
    End Sub

    Private Sub rptCurrentAcct_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        optPast.Checked = False
        optAll.Checked = True
        optSortPO.Checked = False
        optSortName.Checked = True
        gridCALoad()

    End Sub

    Private Function SelectAddressAndJobsAndPOsByDDELNULLSortPO(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                .tAddress.Clear()
                Me.daAddressRecent.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobALLSortCustName.Fill(.tJob)

                .tPOHeader.Clear()
                Me.daPODDELNullSortPO.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLineDDELnull.Fill(.tPOLine)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function SelectAddressAndJobsAndPOsByDDELNULL(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                .tAddress.Clear()
                Me.daAddressRecent.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobALLSortCustName.Fill(.tJob)

                .tPOHeader.Clear()
                Me.daPODDELnull.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLineDDELnull.Fill(.tPOLine)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub gridCALoad()
        Try
            Me.TVendorTableAdapter1.Fill(Me.TKSIJOBSDataSet.tVendor)
            Me.TblJobActivityTableAdapter.FillBy(Me.TKSIJOBSDataSet.tblJobActivity)

            If optSortPO.Checked = True Then
                If Not SelectAddressAndJobsAndPOsByDDELNULLSortPO(Me.DsTKSI1) Then
                    Windows.Forms.MessageBox.Show("Error loading current account data.")
                    Exit Sub
                End If
            Else
                If Not SelectAddressAndJobsAndPOsByDDELNULL(Me.DsTKSI1) Then
                    Windows.Forms.MessageBox.Show("Error loading current account data.")
                    Exit Sub
                End If
            End If


            With gridCA
                .Redraw = False
                .Cols = 9
                .Rows = 0
                .FixedRows = 0
                .GridLines = GridStyleSettings.flexGridNone
                .set_ColHidden(0, True)
                .set_ColWidth(1, 90)
                .set_ColWidth(2, 130)
                .set_ColWidth(3, 90)
                .set_ColWidth(4, 70)
                .set_ColWidth(5, 50)
                .set_ColWidth(6, 75)
                .set_ColWidth(7, 110)
                .set_ColWidth(8, 150)
                .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None

                .WordWrap = True
            End With

            'Dim draPO As dsTKSI.tPOHeaderRow()

            gridCA.MergeCells = MergeSettings.flexMergeFixedOnly

            'If optSortPO.Checked = True Then
            '    draPO = Me.DsTKSI1.tPOHeader.Select("", iif(ISNUMERIC(SUBSTRING(sPONum, 1, 5)) ,substring(sPONum, 1, 5),'0' + substring(sPONum, 1, 4))")

            '    If draPO.Length > 0 Then
            '        Dim drPO As dsTKSI.tPOHeaderRow
            '        For Each drPO In draPO
            '            Me.FillGrid(drPO)
            '        Next
            '        gridCA.Select(0, 0)
            '    Else
            '        gridCA.Rows = 0 'new selection criteria yeild no data so clear old data
            '    End If
            'Else
            'Dim strLine As String
            If Me.DsTKSI1.tPOHeader.Rows.Count > 0 Then
                Dim drPO As dsTKSI.tPOHeaderRow
                For Each drPO In Me.DsTKSI1.tPOHeader
                    Me.FillGrid(drPO)
                Next
                gridCA.Select(0, 0)
            Else
                gridCA.Rows = 0 'new selection criteria yeild no data so clear old data
            End If
            ' End If

            gridCA.Redraw = True
            If gridCA.Rows > 0 Then
                gridCA.Select(0, 2)
                gridCA.AddItem("" & vbTab & "Date Printed : " & vbTab & Today & vbTab & "CURRENT ACCOUNTS" & vbTab & "" & vbTab & "Sales" & vbTab & "Date Del" & vbTab & "Acct Note" & vbTab & "Receiving Note", 0)
                gridCA.set_RowHeight(0, 30)
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillGrid(ByVal drPO As dsTKSI.tPOHeaderRow)
        'Dim flexcpalignleftcenter As Object
        'Dim alpha As String
        Dim strLine As String = ""
        Dim x As Long = 0
        With gridCA
            strLine = drPO.nID & vbTab
            strLine = strLine & drPO.sPONum & vbTab
            If Not drPO.tJobRow.tCustomrRow Is Nothing Then
                strLine = strLine & Mid(drPO.tJobRow.tCustomrRow.sName, 1, 18) & vbTab
            Else
                strLine = strLine & "" & vbTab
            End If
            strLine = strLine & Mid(drPO.tVendorRow.sName, 1, 11) & vbTab

            If Not drPO.IsdRequiredNull Then
                strLine = strLine & drPO.dRequired.ToShortDateString & vbTab
            Else
                strLine = strLine & "" & vbTab
            End If

            strLine = strLine & drPO.tJobRow.sSalesperson & vbTab
            If Not drPO.IsDDELNull Then
                strLine = strLine & drPO.DDEL & vbTab
            Else
                strLine = strLine & "" & vbTab
            End If

            If drPO.sBackOrder.Length > 0 Then
                strLine = strLine & "BO "
            End If

            strLine = strLine & Replace(drPO.sCurActNote, "BO", "") & vbTab

            If nLastPO = drPO.nJobID Then
                'dont show same activity info again for different PO on same job
            Else

                Dim blnIgnoreVendor As Boolean = False
                Dim drVen As TKSIJOBSDataSet.tVendorRow
                drVen = Me.TKSIJOBSDataSet.tVendor.FindBylid(drPO.nVendorID)
                If Not drVen Is Nothing Then
                    blnIgnoreVendor = drVen.IgnoreScheduling
                End If

                If Not blnIgnoreVendor Then
                    Dim draActivity As TKSIJOBSDataSet.tblJobActivityRow()
                    Dim drAct As TKSIJOBSDataSet.tblJobActivityRow
                    draActivity = Me.TKSIJOBSDataSet.tblJobActivity.Select("njobid=" & drPO.nJobID, "dateEntered desc")
                    Dim k As Integer = 0
                    For Each drAct In draActivity
                        strLine = strLine & drAct.dateEntered.Month & "/" & drAct.dateEntered.Day & " " & drAct.ActivityDetail & vbCrLf
                    Next
                End If

                If altColor = Color.LightGray Then
                    altColor = Color.White
                Else
                    altColor = Color.LightGray
                End If
            End If

            .AddItem(strLine)
            .set_RowHeight(.Rows - 1, 30)
            For x = 0 To 8
                .Select(.Rows - 1, x)
                .CellAlignment = AlignmentSettings.flexAlignLeftCenter
                .CellBackColor = altColor
            Next

            If Not drPO.IsdRequiredNull Then
                If drPO.dRequired < Today Then
                    .set_Cell(CellPropertySettings.flexcpFontBold, .Rows - 1, 0, .Rows - 1, 8, True)
                    .set_Cell(CellPropertySettings.flexcpAlignment, .Rows - 1, 0, .Rows - 1, 8, CellPropertySettings.flexcpLeft)

                    For x = 0 To 8
                        .Select(.Rows - 1, x)
                        .CellFontSize = 9
                    Next
                    .set_Cell(CellPropertySettings.flexcpFontName, .Rows - 1, 0, .Rows - 1, 8, "Courier")
                Else
                    If optAll.Checked = True Then
                        .set_Cell(CellPropertySettings.flexcpFontBold, .Rows - 1, 0, .Rows - 1, 8, False)
                        .set_Cell(CellPropertySettings.flexcpAlignment, .Rows - 1, 0, .Rows - 1, 8, CellPropertySettings.flexcpLeft)

                        For x = 0 To 8
                            .Select(.Rows - 1, x)
                            .CellFontSize = 8
                        Next
                        .set_Cell(CellPropertySettings.flexcpFontName, .Rows - 1, 0, .Rows - 1, 8, "Courier")
                    Else
                        .Rows = .Rows - 1
                    End If
                End If
                nLastPO = drPO.nJobID
            End If

        End With
    End Sub

    Private Sub rptCurrentAcct_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Me.gridCA.FinishEditing()
        If MsgBoxResult.Yes = MsgBox("Do you want to update values before closing?", MsgBoxStyle.YesNo, "Update?") Then
            UpdateDDel(False)
        End If
    End Sub

    Private Sub gridCA_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles gridCA.DoubleClick
        If gridCA.MouseCol < 5 Then
            gridCA.Select(gridCA.RowSel, 0)
            If IsNumeric(gridCA.Text) Then
                If CInt(gridCA.Text) > 0 Then
                    ShowPO(CInt(gridCA.Text))
                End If
            Else
                MsgBox("Error: grid ID is incorrect")
            End If
        End If

    End Sub

    Private Sub ShowPO(ByRef POID As Integer)
        Dim drPO As dsTKSI.tPOHeaderRow
        drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
        If Not drPO Is Nothing Then
            '   Dim frmPO1 As frmPOnet
            If POID > 0 Then
                OpenPOScreen(POID, True)
            End If
        End If
    End Sub

    Private Sub UpdateDDel(Optional ByRef reload As Boolean = True) 'update Date delivered field only

        Dim frmB As New frmWorking
        frmB.Text = frmB.Text & " Current Accounts..."
        Try
            frmB.Show()
            Dim Y As Integer
            With gridCA
                For Y = 0 To .Rows - 1

                    If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)) Then
                        Dim drPO As dsTKSI.tPOHeaderRow
                        drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))

                        If Not drPO Is Nothing Then
                            If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 6, Y, 6)) Then
                                drPO.DDEL = CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 6, Y, 6))

                                ExecuteNETAutoEmailerForBackorders(drPO.sPONum)

                            End If
                            If drPO.IsDRECNull Then
                                If IsDate2(.get_Cell(CellPropertySettings.flexcpText, Y, 6, Y, 6)) Then
                                    drPO.DREC = CDate(.get_Cell(CellPropertySettings.flexcpText, Y, 6, Y, 6))
                                End If
                            End If

                            Dim sNote As String = ""
                            sNote = .get_Cell(CellPropertySettings.flexcpText, Y, 7, Y, 7)

                            If UCase(sNote.Trim) <> UCase(drPO.sCurActNote.Trim) Then

                                'get only the newly typed info
                                Dim strNew As String = ""
                                strNew = Replace(sNote.Trim, drPO.sCurActNote.Trim, "")

                                drPO.sCurActNote = .get_Cell(CellPropertySettings.flexcpText, Y, 7, Y, 7) & ""
                            End If

                        Else
                            MsgBox("Error: could not locate PO")
                        End If
                    End If
                Next

                Me.daPOUpdate.Update(Me.DsTKSI1.tPOHeader)
                Me.DsTKSI1.tPOHeader.AcceptChanges()

            End With

            gridCALoad()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmB.Close()
        End Try

    End Sub

    Private Sub ExecuteNETAutoEmailerForBackorders(ByVal strPO As String)
        Try
            Dim frm1 As New frmNotifyBackorder
            frm1.sPOfilter = strPO
            frm1.Show()
            frm1.Close()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub gridCA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridCA.MouseDown
        Select Case gridCA.MouseCol
            Case 7
                gridCA.Select(gridCA.MouseRow, 7)
                gridCA.EditCell()
            Case 6
                gridCA.Select(gridCA.MouseRow, 6)
                gridCA.set_TextMatrix(gridCA.MouseRow, 6, Month(Now) & "/" & VB.Day(Now) & "/" & Year(Now))
                gridCA.EditCell()
        End Select
    End Sub
End Class