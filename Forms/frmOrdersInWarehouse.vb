Imports Microsoft.Office.Interop
Imports System.Windows.Forms

Public Class frmOrdersInWarehouse
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.sqlConn.ConnectionString = cnSQL
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents JobNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents JobNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents JobAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents CabCo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReceivedDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents SalespersonName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cost5010 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cost5070 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cost5030 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cost As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents PaidStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lvTotals As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefeshList As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents Bin As System.Windows.Forms.ColumnHeader
    Friend WithEvents daLocationBins As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lvOrders As System.Windows.Forms.ListView
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daPOLineDRECnotNULLDDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOheaderDRECnotNULLDDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand38 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOHeaderDRECnotNULLDDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineDRECnotNULLDDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daLocationBinJOIN As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobALLSortCustName As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddressALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCustomerALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendorALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents clmCreditLimit As System.Windows.Forms.ColumnHeader
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdersInWarehouse))
        Me.lvOrders = New System.Windows.Forms.ListView
        Me.JobNum = New System.Windows.Forms.ColumnHeader
        Me.JobNAME = New System.Windows.Forms.ColumnHeader
        Me.JobAddress = New System.Windows.Forms.ColumnHeader
        Me.CabCo = New System.Windows.Forms.ColumnHeader
        Me.ReceivedDate = New System.Windows.Forms.ColumnHeader
        Me.Bin = New System.Windows.Forms.ColumnHeader
        Me.SalespersonName = New System.Windows.Forms.ColumnHeader
        Me.Cost5010 = New System.Windows.Forms.ColumnHeader
        Me.Cost5070 = New System.Windows.Forms.ColumnHeader
        Me.Cost5030 = New System.Windows.Forms.ColumnHeader
        Me.Cost = New System.Windows.Forms.ColumnHeader
        Me.PaidStatus = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblDate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRefeshList = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnPrint = New System.Windows.Forms.Button
        Me.lvTotals = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.DsTKSI1 = New TKSISchedule.dsTKSI
        Me.sqlConn = New System.Data.SqlClient.SqlConnection
        Me.daLocationBins = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daPOLineDRECnotNULLDDELnull = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand20 = New System.Data.SqlClient.SqlCommand
        Me.daPOheaderDRECnotNULLDDELnull = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand38 = New System.Data.SqlClient.SqlCommand
        Me.daSOHeaderDRECnotNULLDDELnull = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand31 = New System.Data.SqlClient.SqlCommand
        Me.daSOLineDRECnotNULLDDELnull = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand24 = New System.Data.SqlClient.SqlCommand
        Me.daLocationBinJOIN = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daJobALLSortCustName = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand17 = New System.Data.SqlClient.SqlCommand
        Me.daAddressALL = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand18 = New System.Data.SqlClient.SqlCommand
        Me.daCustomerALL = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.daVendorALL = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.clmCreditLimit = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvOrders
        '
        Me.lvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.JobNum, Me.JobNAME, Me.JobAddress, Me.CabCo, Me.ReceivedDate, Me.Bin, Me.SalespersonName, Me.Cost5010, Me.Cost5070, Me.Cost5030, Me.Cost, Me.PaidStatus, Me.clmCreditLimit})
        Me.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOrders.FullRowSelect = True
        Me.lvOrders.GridLines = True
        Me.lvOrders.HideSelection = False
        Me.lvOrders.Location = New System.Drawing.Point(0, 56)
        Me.lvOrders.MultiSelect = False
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.Size = New System.Drawing.Size(1081, 477)
        Me.lvOrders.TabIndex = 0
        Me.lvOrders.UseCompatibleStateImageBehavior = False
        Me.lvOrders.View = System.Windows.Forms.View.Details
        '
        'JobNum
        '
        Me.JobNum.Text = "JOB#"
        Me.JobNum.Width = 70
        '
        'JobNAME
        '
        Me.JobNAME.Text = "NAME"
        Me.JobNAME.Width = 110
        '
        'JobAddress
        '
        Me.JobAddress.Text = "JobAddress"
        Me.JobAddress.Width = 150
        '
        'CabCo
        '
        Me.CabCo.Text = "CAB. CO."
        Me.CabCo.Width = 70
        '
        'ReceivedDate
        '
        Me.ReceivedDate.Text = "REC/DATE"
        Me.ReceivedDate.Width = 90
        '
        'Bin
        '
        Me.Bin.Text = "BIN"
        Me.Bin.Width = 93
        '
        'SalespersonName
        '
        Me.SalespersonName.Text = "SP NAME"
        Me.SalespersonName.Width = 70
        '
        'Cost5010
        '
        Me.Cost5010.Text = "5010"
        Me.Cost5010.Width = 66
        '
        'Cost5070
        '
        Me.Cost5070.Text = "5070"
        Me.Cost5070.Width = 68
        '
        'Cost5030
        '
        Me.Cost5030.Text = "5030"
        Me.Cost5030.Width = 70
        '
        'Cost
        '
        Me.Cost.Text = "COST"
        Me.Cost.Width = 73
        '
        'PaidStatus
        '
        Me.PaidStatus.Text = "Paid"
        Me.PaidStatus.Width = 40
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1081, 56)
        Me.Panel1.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(328, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(256, 16)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orders In Warehouse"
        '
        'btnRefeshList
        '
        Me.btnRefeshList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefeshList.Location = New System.Drawing.Point(16, 24)
        Me.btnRefeshList.Name = "btnRefeshList"
        Me.btnRefeshList.Size = New System.Drawing.Size(104, 32)
        Me.btnRefeshList.TabIndex = 1
        Me.btnRefeshList.Text = "Refresh"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.lvTotals)
        Me.Panel2.Controls.Add(Me.btnRefeshList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1081, 80)
        Me.Panel2.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Location = New System.Drawing.Point(144, 24)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 32)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        '
        'lvTotals
        '
        Me.lvTotals.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvTotals.Dock = System.Windows.Forms.DockStyle.Right
        Me.lvTotals.FullRowSelect = True
        Me.lvTotals.GridLines = True
        Me.lvTotals.HideSelection = False
        Me.lvTotals.Location = New System.Drawing.Point(705, 0)
        Me.lvTotals.MultiSelect = False
        Me.lvTotals.Name = "lvTotals"
        Me.lvTotals.Size = New System.Drawing.Size(376, 80)
        Me.lvTotals.TabIndex = 0
        Me.lvTotals.UseCompatibleStateImageBehavior = False
        Me.lvTotals.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Totals"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "5010"
        Me.ColumnHeader2.Width = 72
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "5070"
        Me.ColumnHeader3.Width = 72
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "5030"
        Me.ColumnHeader4.Width = 72
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "COST"
        Me.ColumnHeader5.Width = 75
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
        Me.sqlConn.ConnectionString = "workstation id=TZ250;packet size=4096;user id=tksidatauser;data source=DELL-SERVER;pers" & _
            "ist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
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
        'daPOLineDRECnotNULLDDELnull
        '
        Me.daPOLineDRECnotNULLDDELnull.SelectCommand = Me.SqlCommand20
        Me.daPOLineDRECnotNULLDDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlCommand20
        '
        Me.SqlCommand20.CommandText = resources.GetString("SqlCommand20.CommandText")
        Me.SqlCommand20.Connection = Me.sqlConn
        '
        'daPOheaderDRECnotNULLDDELnull
        '
        Me.daPOheaderDRECnotNULLDDELnull.SelectCommand = Me.SqlCommand38
        Me.daPOheaderDRECnotNULLDDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand38
        '
        Me.SqlCommand38.CommandText = resources.GetString("SqlCommand38.CommandText")
        Me.SqlCommand38.Connection = Me.sqlConn
        '
        'daSOHeaderDRECnotNULLDDELnull
        '
        Me.daSOHeaderDRECnotNULLDDELnull.SelectCommand = Me.SqlCommand31
        Me.daSOHeaderDRECnotNULLDDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        '
        'SqlCommand31
        '
        Me.SqlCommand31.CommandText = resources.GetString("SqlCommand31.CommandText")
        Me.SqlCommand31.Connection = Me.sqlConn
        '
        'daSOLineDRECnotNULLDDELnull
        '
        Me.daSOLineDRECnotNULLDDELnull.SelectCommand = Me.SqlCommand24
        Me.daSOLineDRECnotNULLDDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlCommand24
        '
        Me.SqlCommand24.CommandText = resources.GetString("SqlCommand24.CommandText")
        Me.SqlCommand24.Connection = Me.sqlConn
        '
        'daLocationBinJOIN
        '
        Me.daLocationBinJOIN.SelectCommand = Me.SqlSelectCommand2
        Me.daLocationBinJOIN.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblLocationLabelJOIN", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("LocationNumber", "LocationNumber"), New System.Data.Common.DataColumnMapping("TrailerlLabelID", "TrailerlLabelID"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("DateEntered", "DateEntered"), New System.Data.Common.DataColumnMapping("Notes", "Notes")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
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
        'daAddressALL
        '
        Me.daAddressALL.SelectCommand = Me.SqlSelectCommand18
        Me.daAddressALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlSelectCommand18
        '
        Me.SqlSelectCommand18.CommandText = "SELECT DISTINCT nID, sAddress1, sAddress2, sCity, sState, sCounty, sZip, sLocCode" & _
            " FROM tAddress"
        Me.SqlSelectCommand18.Connection = Me.sqlConn
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
        'clmCreditLimit
        '
        Me.clmCreditLimit.Text = "Account"
        Me.clmCreditLimit.Width = 53
        '
        'frmOrdersInWarehouse
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1081, 613)
        Me.Controls.Add(Me.lvOrders)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmOrdersInWarehouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Structure JobCollection
        Friend JobDetailList As ArrayList

        Friend Sub AddJob(ByVal JobDetail1 As JobDetail)
            If JobDetail1.TotalCost > 0 Then

                If Me.JobDetailList Is Nothing Then
                    Me.JobDetailList = New ArrayList
                End If

                Me.JobDetailList.Add(JobDetail1)

                Me.Total5010 = Me.Total5010 + JobDetail1.Cost5010
                Me.Total5030 = Me.Total5030 + JobDetail1.Cost5030
                Me.total5070 = Me.total5070 + JobDetail1.Cost5070
                Me.TotalCost = Me.TotalCost + JobDetail1.TotalCost

                If JobDetail1.PaidStatus = "Y" Then
                    Me.Total5010Unpaid = Me.Total5010Unpaid + JobDetail1.Cost5010
                    Me.Total5030Unpaid = Me.Total5030Unpaid + JobDetail1.Cost5030
                    Me.Total5070Unpaid = Me.Total5070Unpaid + JobDetail1.Cost5070
                    Me.TotalCostUnpaid = Me.TotalCostUnpaid + JobDetail1.TotalCost
                End If

            End If
        End Sub

        Friend Total5010 As Double
        Friend Total5030 As Double
        Friend total5070 As Double
        Friend TotalCost As Double
        Friend Total5010Unpaid As Double
        Friend Total5030Unpaid As Double
        Friend Total5070Unpaid As Double
        Friend TotalCostUnpaid As Double


        Structure JobDetail
            Public Sub New(ByVal JOBID As String)
                Me.JOBID = ""
                Me.Number = ""
                Me.Name = ""
                Me.Bin = ""
                Me.Address = ""
                Me.Contact = ""
                Me.CabinetCompany = ""
                Me.ReceivedDate = ""
                Me.SalesPersonName = ""
                Me.Cost5030 = 0
                Me.Cost5010 = 0
                Me.Cost5070 = 0
                Me.TotalCost = 0
                Me.PaidStatus = ""
                Me.CreditLimit = 0
            End Sub

            Dim JOBID As String
            Dim Number As String
            Dim Name As String
            Dim CreditLimit As Single
            Dim Address As String
            Dim Contact As String
            Dim CabinetCompany As String
            Dim ReceivedDate As String
            Dim Bin As String
            Dim SalesPersonName As String
            Dim Cost5010 As Double
            Dim Cost5070 As Double
            Dim Cost5030 As Double
            Dim TotalCost As Double
            Dim PaidStatus As String
        End Structure

    End Structure

    Private JobCollection1 As JobCollection
    Private oJob As New JobObj

    Private Sub frmOrdersInWarehouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataAndDisplay()
    End Sub

    Private Function SelectAllJobAddressCustomerVendor(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1
                .tAddress.Clear()
                Me.daAddressALL.Fill(.tAddress)
                .tJob.Clear()
                Me.daJobALLSortCustName.Fill(.tJob)
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

    Private Sub LoadDataAndDisplay()
        If Not SelectAllJobAddressCustomerVendor(Me.DsTKSI1) Then
            Windows.Forms.MessageBox.Show("Error loading Job info this report.")
            Exit Sub
        End If

        With Me.DsTKSI1
            .tPOHeader.Clear()
            Me.daPOheaderDRECnotNULLDDELnull.Fill(.tPOHeader)

            .tSOHeader.Clear()
            Me.daSOHeaderDRECnotNULLDDELnull.Fill(.tSOHeader)

            .tSOLine.Clear()
            Me.daSOLineDRECnotNULLDDELnull.Fill(.tSOLine)

            .tPOLine.Clear()
            Me.daPOLineDRECnotNULLDDELnull.Fill(.tPOLine)

            .tblLocationBins.Clear()
            Me.daLocationBins.Fill(.tblLocationBins)

            .tblLocationLabelJOIN.Clear()
            Me.daLocationBinJOIN.Fill(.tblLocationLabelJOIN)
        End With


        'If Not oJob.SelectPOSOByDRecNotNullDDelNULL(Me.DsTKSI1) Then
        '    Windows.Forms.MessageBox.Show("Error loading PO info this report.")
        '    Exit Sub
        'End If

        PopulateJobList()
        DrawListViewFromJobList(Me.JobCollection1)
    End Sub

    Private Sub DrawListViewFromJobList(ByVal JobCollection1 As JobCollection)
        'drJob.IssJobDescNull
        Dim job1 As New JobCollection.JobDetail

        Me.lvOrders.Items.Clear()
        For Each job1 In JobCollection1.JobDetailList
            Dim tempItem As New ListViewItem
            tempItem.Text = job1.JOBID
            With tempItem.SubItems
                .Add(job1.Name.ToString)
                .Add(job1.Address.ToString)

                '.Add(job1.Contact.ToString)
                .Add(job1.CabinetCompany.ToString)
                .Add(job1.ReceivedDate.ToString)
                .Add(job1.Bin)
                .Add(job1.SalesPersonName.ToString)
                .Add(job1.Cost5010.ToString)
                .Add(job1.Cost5070.ToString)
                .Add(job1.Cost5030.ToString)
                .Add(job1.TotalCost.ToString)
                .Add(job1.PaidStatus.ToString)
                If job1.CreditLimit > 0 Then
                    .Add("Yes")
                Else
                    .Add("No")
                End If

            End With
            Me.lvOrders.Items.Add(tempItem)
            Me.lblDate.Text = Now
        Next

        lvTotals.Items.Clear()
        Dim itemTemp As New ListViewItem
        itemTemp.Text = "Total"
        With itemTemp.SubItems
            '.Add("Total")
            .Add(Format(JobCollection1.Total5010, "currency"))
            .Add(Format(JobCollection1.total5070, "currency"))
            .Add(Format(JobCollection1.Total5030, "currency"))
            .Add(Format(JobCollection1.TotalCost, "currency"))
        End With
        Me.lvTotals.Items.Add(itemTemp)

        itemTemp = New ListViewItem
        itemTemp.Text = "Total Paid:"
        With itemTemp.SubItems
            '.Add("Total")
            .Add(Format(JobCollection1.Total5010Unpaid, "currency"))
            .Add(Format(JobCollection1.Total5070Unpaid, "currency"))
            .Add(Format(JobCollection1.Total5030Unpaid, "currency"))
            .Add(Format(JobCollection1.TotalCostUnpaid, "currency"))
        End With
        Me.lvTotals.Items.Add(itemTemp)

        itemTemp = New ListViewItem
        itemTemp.Text = ""
        With itemTemp.SubItems
            '.Add("Total")
            .Add(Format(JobCollection1.Total5010 - JobCollection1.Total5010Unpaid, "currency"))
            .Add(Format(JobCollection1.total5070 - JobCollection1.Total5070Unpaid, "currency"))
            .Add(Format(JobCollection1.Total5030 - JobCollection1.Total5030Unpaid, "currency"))
            .Add(Format(JobCollection1.TotalCost - JobCollection1.TotalCostUnpaid, "currency"))
        End With
        Me.lvTotals.Items.Add(itemTemp)

    End Sub

    Private Sub PopulateJobList()
        Me.JobCollection1 = New JobCollection
        Dim drJob As dsTKSI.tJobRow
        lvOrders.Items.Clear()
        'Dim draJob As dsTKSI.tJobRow()
        'draJob = Me.DsTKSI1.tJob.Select("", "sJobNo")
        For Each drJob In Me.DsTKSI1.tJob ' draJob
            'If Mid(drJob.sJobNo, 1, 5) = "11505" Then
            'Stop
            'End If

            Dim job2 As New JobCollection.JobDetail(drJob.nID)
            CalculateJobData(drJob, job2)
            CalculatePOCostData(drJob, job2)
            job2.Bin = GetBinForPO(drJob)
            Me.JobCollection1.AddJob(job2)
        Next
    End Sub

    Private Function GetBinForPO(ByVal drjob As dsTKSI.tJobRow) As String
        Try
            'Dim draJOIN As dsTKSI.tblLocationLabelJOINRow()
            'draJOIN = Me.DsTKSI1.tblLocationLabelJOIN.Select("substring(PO,1,5) = '" & drjob.sJobNo & "'")
            'If draJOIN.Length > 0 Then

            Dim drJoin As dsTKSI.tblLocationLabelJOINRow
            Dim strReturn As String = ""
            Dim strLastBin As String = ""
            For Each drJoin In Me.DsTKSI1.tblLocationLabelJOIN
                If Mid(drJoin.PO, 1, 6).TrimEnd("-") = Mid(drjob.sJobNo, 1, 6).TrimEnd("-") Then
                    If strLastBin = drJoin.tblLocationBinsRow.LabelID Then
                        'dont show same bin twice for this job, even though someone scanned several items from same job into same bine, which wasnt necessary
                    Else
                        strReturn = strReturn & LocationToShortName(drJoin.tblLocationBinsRow.LabelID) & " "
                    End If

                    strLastBin = drJoin.tblLocationBinsRow.LabelID
                End If
            Next
            Return strReturn

            'Else
            '    Return ""
            'End If
        Catch ex As Exception
            Return "ERROR.."
        End Try

    End Function

    Private Sub CalculateJobData(ByVal drJob As dsTKSI.tJobRow, ByRef job1 As JobCollection.JobDetail)
        With drJob
            job1.JOBID = .sJobNo
            job1.Name = .tCustomrRow.sName
            job1.CreditLimit = .tCustomrRow.dCrLimit
            If Not .tAddressRow Is Nothing Then
                job1.Address = .tAddressRow.sAddress1
            Else
                job1.Address = "UNKNOWN"
            End If

            job1.Contact = .sJobContact
            job1.SalesPersonName = .sSalesperson

            job1.PaidStatus = "N"

            Dim jobSum As Double
            Dim blnFoundInvoice As Boolean
            blnFoundInvoice = False
            jobSum = 0

            Dim drSO As dsTKSI.tSOHeaderRow
            For Each drSO In .GettSOHeaderRows
                Dim drSOLine As dsTKSI.tSOLineRow
                For Each drSOLine In drSO.GettSOLineRows
                    If drSOLine.sType = "Comment" Then
                        jobSum = Decimal.Round(CDec(jobSum + drSOLine.nAmount), 3)
                        blnFoundInvoice = True
                    End If
                Next
            Next
            'If Mid(drJob.sJobNo, 1, 5) = "11505" Then
            'Stop
            'End If
            If jobSum = 0 And blnFoundInvoice = True Then
                job1.PaidStatus = "Y"
            End If

        End With
    End Sub

    Private Sub CalculatePOCostData(ByVal drJob As dsTKSI.tJobRow, ByRef job1 As JobCollection.JobDetail)
        If Not drJob.GettPOHeaderRows Is Nothing Then
            Dim drPO As dsTKSI.tPOHeaderRow
            'Dim lastRECDate As Date
            'Dim lastCabCo As String

            For Each drPO In drJob.GettPOHeaderRows
                Dim dra As dsTKSI.tPOLineRow()
                Dim dr As dsTKSI.tPOLineRow
                dra = drPO.GettPOLineRows
                If dra.Length > 0 Then
                    For Each dr In dra
                        Select Case dr.nAccountID
                            Case 5010
                                job1.Cost5010 = job1.Cost5010 + dr.nCost
                                job1.TotalCost = job1.TotalCost + dr.nCost
                            Case 5070
                                job1.Cost5070 = job1.Cost5070 + dr.nCost
                                job1.TotalCost = job1.TotalCost + dr.nCost
                            Case 5030
                                job1.Cost5030 = job1.Cost5030 + dr.nCost
                                job1.TotalCost = job1.TotalCost + dr.nCost
                        End Select
                    Next
                End If

                If Not drPO.IsDRECNull Then
                    job1.ReceivedDate = drPO.DREC.ToShortDateString.ToString
                End If

                'only show each cabinet company involved with this Job once on the sheet
                'even if the same cabinet company is on two different PO's
                If InStr(job1.CabinetCompany, Mid(drPO.tVendorRow.sName, 1, 8)) = 0 Then
                    job1.CabinetCompany = job1.CabinetCompany & Mid(drPO.tVendorRow.sName, 1, 8) & " "
                End If
            Next
        End If
    End Sub

    Private Sub btnRefeshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefeshList.Click
        LoadDataAndDisplay()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim oWord As New Word.Application
        Dim oDoc As Word.Document
        oDoc = oWord.Documents.Add
        oWord.Visible = True
        'Dim tempItem As ListViewItem
        Dim x As Single
        With oWord.Selection
            '.PageSetup.TextColumns.SetCount(2)
            .PageSetup.TopMargin = 32
            .PageSetup.BottomMargin = 32
            .PageSetup.LeftMargin = 32
            .PageSetup.RightMargin = 32
            .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape
            x = 0.5
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 1.2
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 1.6
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            '.ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(3.8), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.8
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.9
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.6
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.9
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.8
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.8
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.8
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            x += 0.8
            .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(x), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

            .TypeText("Orders In Warehouse Report  " & vbTab & Now.ToLongDateString & " " & Now.ToLongTimeString)
            .TypeParagraph()
            .TypeParagraph()
            .Font.Size = 10
            .TypeText("JOB#" & vbTab & "NAME" & vbTab & "JobAddress" & _
                 vbTab & "CAB.CO" & vbTab & "REC DT" & vbTab & "BIN" & vbTab _
                & "SP NAME" & vbTab & "5010" & vbTab & "5070" & vbTab & "5030" & vbTab _
                & "COST" & vbTab & "Paid")

            .TypeParagraph()
            .TypeParagraph()

            Dim job1 As New JobCollection.JobDetail

            For Each job1 In JobCollection1.JobDetailList
                'only work on records that are newer than date selected by user

                .Font.Size = 9
                .TypeText(Mid(job1.JOBID.ToString, 1, 7) & vbTab)
                .TypeText(Mid(job1.Name.ToString, 1, 16) & vbTab)
                .TypeText(Mid(job1.Address.ToString, 1, 20) & vbTab)
                '.TypeText(Mid(job1.Contact.ToString, 1, 12) & vbTab)
                .TypeText(Mid(job1.CabinetCompany.ToString, 1, 6) & vbTab)
                .TypeText(Mid(job1.ReceivedDate.ToString, 1, 14) & vbTab)
                .TypeText(Mid(job1.Bin, 1, 12) & vbTab)
                .TypeText(Mid(job1.SalesPersonName.ToString, 1, 12) & vbTab)
                .TypeText(Format(Mid(job1.Cost5010.ToString, 1, 13), "currency") & vbTab)
                .TypeText(Format(Mid(job1.Cost5070.ToString, 1, 13), "currency") & vbTab)
                .TypeText(Format(Mid(job1.Cost5030.ToString, 1, 13), "currency") & vbTab)
                .TypeText(Format(Mid(job1.TotalCost.ToString, 1, 13), "currency") & vbTab)
                .TypeText(Mid(job1.PaidStatus.ToString, 1, 4))
                .TypeParagraph()

            Next

            .TypeParagraph()
            .TypeParagraph()
            .TypeText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)

            .TypeText("TOTALS:" & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5010.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.total5070.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5030.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.TotalCost.ToString, 1, 13), "currency") & vbTab)

            .TypeParagraph()
            .TypeText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)

            .TypeText("PAID:" & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5010Unpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5070Unpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5030Unpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.TotalCostUnpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeParagraph()
            .TypeText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)

            .TypeText("" & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5010 - JobCollection1.Total5010Unpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.total5070.ToString - JobCollection1.Total5070Unpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.Total5030.ToString - JobCollection1.Total5030Unpaid.ToString, 1, 13), "currency") & vbTab)
            .TypeText(Format(Mid(JobCollection1.TotalCost.ToString - JobCollection1.TotalCostUnpaid.ToString, 1, 13), "currency") & vbTab)
            '.WholeStory()
            '.ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(1.7), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
            '.ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(3.5), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

        End With
        oWord.Visible = True
    End Sub

End Class
