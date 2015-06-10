Imports System.Windows.Forms
Imports System.Drawing

Public Class frmLabelsHardware
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
    Friend WithEvents lvLabels As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPO As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daPObysPONum As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtPOSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnPrintLabel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocumentBarCodeLabel As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDamageNotes As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daShippingHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daShippingItems As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daTrailerHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents chkIncomplete As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TPOHeaderTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter
    Friend WithEvents TksijobsDataSet1 As TKSISchedule.TKSIJOBSDataSet
    Friend WithEvents TblJobActivityTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents daPObyJOBID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtAnyText As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintAnyLabel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabelsHardware))
        Me.lvLabels = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrintLabel = New System.Windows.Forms.Button()
        Me.txtPOSearch = New System.Windows.Forms.TextBox()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPO = New System.Data.SqlClient.SqlDataAdapter()
        Me.daPObysPONum = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocumentBarCodeLabel = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDamageNotes = New System.Windows.Forms.TextBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daShippingHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daShippingItems = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daTrailerHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.chkIncomplete = New System.Windows.Forms.CheckBox()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daVendor = New System.Data.SqlClient.SqlDataAdapter()
        Me.TPOHeaderTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter()
        Me.TksijobsDataSet1 = New TKSISchedule.TKSIJOBSDataSet()
        Me.TblJobActivityTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.daPObyJOBID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.txtAnyText = New System.Windows.Forms.TextBox()
        Me.btnPrintAnyLabel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvLabels
        '
        Me.lvLabels.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvLabels.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLabels.FullRowSelect = True
        Me.lvLabels.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLabels.HideSelection = False
        Me.lvLabels.Location = New System.Drawing.Point(0, 0)
        Me.lvLabels.MultiSelect = False
        Me.lvLabels.Name = "lvLabels"
        Me.lvLabels.Size = New System.Drawing.Size(784, 445)
        Me.lvLabels.TabIndex = 0
        Me.lvLabels.UseCompatibleStateImageBehavior = False
        Me.lvLabels.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PO"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantity (Labels)"
        Me.ColumnHeader5.Width = 177
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Builder"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 160
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(797, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(136, 32)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh Hardware"
        '
        'btnPrintLabel
        '
        Me.btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintLabel.Location = New System.Drawing.Point(797, 233)
        Me.btnPrintLabel.Name = "btnPrintLabel"
        Me.btnPrintLabel.Size = New System.Drawing.Size(200, 32)
        Me.btnPrintLabel.TabIndex = 2
        Me.btnPrintLabel.Text = "Print Label"
        '
        'txtPOSearch
        '
        Me.txtPOSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSearch.Location = New System.Drawing.Point(797, 89)
        Me.txtPOSearch.Name = "txtPOSearch"
        Me.txtPOSearch.Size = New System.Drawing.Size(200, 26)
        Me.txtPOSearch.TabIndex = 0
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERV" & _
    "ER;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@SBACKORDER", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daPO
        '
        Me.daPO.SelectCommand = Me.SqlSelectCommand5
        Me.daPO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPO.UpdateCommand = Me.SqlUpdateCommand1
        '
        'daPObysPONum
        '
        Me.daPObysPONum.SelectCommand = Me.SqlCommand1
        Me.daPObysPONum.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.sqlConn
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum")})
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(797, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search PO"
        '
        'PrintDocumentBarCodeLabel
        '
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(797, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Notes"
        '
        'txtDamageNotes
        '
        Me.txtDamageNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDamageNotes.Location = New System.Drawing.Point(797, 161)
        Me.txtDamageNotes.Name = "txtDamageNotes"
        Me.txtDamageNotes.Size = New System.Drawing.Size(200, 26)
        Me.txtDamageNotes.TabIndex = 1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO")})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierCode", System.Data.SqlDbType.VarChar, 50, "SupplierCode"), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO"), New System.Data.SqlClient.SqlParameter("@SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateCompletion", System.Data.SqlDbType.DateTime, 8, "DateCompletion"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.DateTime, 8, "DateClosed"), New System.Data.SqlClient.SqlParameter("@DateOrder", System.Data.SqlDbType.DateTime, 8, "DateOrder"), New System.Data.SqlClient.SqlParameter("@OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.sqlConn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierCode", System.Data.SqlDbType.VarChar, 50, "SupplierCode"), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO"), New System.Data.SqlClient.SqlParameter("@SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateCompletion", System.Data.SqlDbType.DateTime, 8, "DateCompletion"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.DateTime, 8, "DateClosed"), New System.Data.SqlClient.SqlParameter("@DateOrder", System.Data.SqlDbType.DateTime, 8, "DateOrder"), New System.Data.SqlClient.SqlParameter("@OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateCompletion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateCompletion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateImported", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateImported", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateOrder", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateCompletion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateCompletion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateImported", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateImported", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateOrder", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daShippingHeader
        '
        Me.daShippingHeader.DeleteCommand = Me.SqlDeleteCommand1
        Me.daShippingHeader.InsertCommand = Me.SqlInsertCommand1
        Me.daShippingHeader.SelectCommand = Me.SqlSelectCommand1
        Me.daShippingHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblShippingHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierCode", "SupplierCode"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("SupplierSONum", "SupplierSONum"), New System.Data.Common.DataColumnMapping("OrderStatus", "OrderStatus"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("StyleDesc", "StyleDesc"), New System.Data.Common.DataColumnMapping("DateImported", "DateImported"), New System.Data.Common.DataColumnMapping("DateCompletion", "DateCompletion"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("DateOrder", "DateOrder"), New System.Data.Common.DataColumnMapping("OrderLines", "OrderLines"), New System.Data.Common.DataColumnMapping("TotalCabs", "TotalCabs")})})
        Me.daShippingHeader.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO")})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.sqlConn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierSO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@ProdDesc", System.Data.SqlDbType.VarChar, 50, "ProdDesc"), New System.Data.SqlClient.SqlParameter("@CabType", System.Data.SqlDbType.VarChar, 50, "CabType"), New System.Data.SqlClient.SqlParameter("@ColorDesc", System.Data.SqlDbType.VarChar, 50, "ColorDesc"), New System.Data.SqlClient.SqlParameter("@ColorCode", System.Data.SqlDbType.VarChar, 50, "ColorCode"), New System.Data.SqlClient.SqlParameter("@ProdCode", System.Data.SqlDbType.VarChar, 50, "ProdCode"), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateReceived", System.Data.SqlDbType.DateTime, 8, "DateReceived"), New System.Data.SqlClient.SqlParameter("@DateDelivered", System.Data.SqlDbType.DateTime, 8, "DateDelivered"), New System.Data.SqlClient.SqlParameter("@DateLastChanged", System.Data.SqlDbType.DateTime, 8, "DateLastChanged"), New System.Data.SqlClient.SqlParameter("@SpecialNote1", System.Data.SqlDbType.VarChar, 255, "SpecialNote1"), New System.Data.SqlClient.SqlParameter("@SpecialNote2", System.Data.SqlDbType.VarChar, 255, "SpecialNote2"), New System.Data.SqlClient.SqlParameter("@QuantityRec", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityRec", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@QuantityDel", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityDel", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.sqlConn
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierSO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@ProdDesc", System.Data.SqlDbType.VarChar, 50, "ProdDesc"), New System.Data.SqlClient.SqlParameter("@CabType", System.Data.SqlDbType.VarChar, 50, "CabType"), New System.Data.SqlClient.SqlParameter("@ColorDesc", System.Data.SqlDbType.VarChar, 50, "ColorDesc"), New System.Data.SqlClient.SqlParameter("@ColorCode", System.Data.SqlDbType.VarChar, 50, "ColorCode"), New System.Data.SqlClient.SqlParameter("@ProdCode", System.Data.SqlDbType.VarChar, 50, "ProdCode"), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateReceived", System.Data.SqlDbType.DateTime, 8, "DateReceived"), New System.Data.SqlClient.SqlParameter("@DateDelivered", System.Data.SqlDbType.DateTime, 8, "DateDelivered"), New System.Data.SqlClient.SqlParameter("@DateLastChanged", System.Data.SqlDbType.DateTime, 8, "DateLastChanged"), New System.Data.SqlClient.SqlParameter("@SpecialNote1", System.Data.SqlDbType.VarChar, 255, "SpecialNote1"), New System.Data.SqlClient.SqlParameter("@SpecialNote2", System.Data.SqlDbType.VarChar, 255, "SpecialNote2"), New System.Data.SqlClient.SqlParameter("@QuantityRec", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityRec", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@QuantityDel", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityDel", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CabType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CabType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ColorCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ColorCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ColorDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ColorDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateDelivered", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateDelivered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateImported", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateImported", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateLastChanged", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateLastChanged", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateReceived", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateReceived", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProdCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProdDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityDel", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityDel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityRec", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityRec", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SpecialNote1", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialNote1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SpecialNote2", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialNote2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierSO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.sqlConn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CabType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CabType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ColorCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ColorCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ColorDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ColorDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateDelivered", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateDelivered", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateImported", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateImported", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateLastChanged", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateLastChanged", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateReceived", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateReceived", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProdCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProdDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProdDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityDel", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityDel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityRec", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityRec", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SpecialNote1", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialNote1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SpecialNote2", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialNote2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierSO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daShippingItems
        '
        Me.daShippingItems.DeleteCommand = Me.SqlDeleteCommand2
        Me.daShippingItems.InsertCommand = Me.SqlInsertCommand2
        Me.daShippingItems.SelectCommand = Me.SqlSelectCommand2
        Me.daShippingItems.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblShippingItems", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierSO", "SupplierSO"), New System.Data.Common.DataColumnMapping("LineNumber", "LineNumber"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("ProdDesc", "ProdDesc"), New System.Data.Common.DataColumnMapping("CabType", "CabType"), New System.Data.Common.DataColumnMapping("ColorDesc", "ColorDesc"), New System.Data.Common.DataColumnMapping("ColorCode", "ColorCode"), New System.Data.Common.DataColumnMapping("ProdCode", "ProdCode"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("StyleDesc", "StyleDesc"), New System.Data.Common.DataColumnMapping("DateImported", "DateImported"), New System.Data.Common.DataColumnMapping("DateReceived", "DateReceived"), New System.Data.Common.DataColumnMapping("DateDelivered", "DateDelivered"), New System.Data.Common.DataColumnMapping("DateLastChanged", "DateLastChanged"), New System.Data.Common.DataColumnMapping("SpecialNote1", "SpecialNote1"), New System.Data.Common.DataColumnMapping("SpecialNote2", "SpecialNote2"), New System.Data.Common.DataColumnMapping("QuantityRec", "QuantityRec"), New System.Data.Common.DataColumnMapping("QuantityDel", "QuantityDel")})})
        Me.daShippingItems.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT PalletNum, SO, PO, ShipDate, TrailerControl, FreightTermsCode, FreightCode" & _
    ", ShipType, TrailerNumber FROM dbo.tblTrailerHeader WHERE (PO = @PO) ORDER BY Tr" & _
    "ailerControl, PO"
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO")})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.sqlConn
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PalletNum", System.Data.SqlDbType.VarChar, 30, "PalletNum"), New System.Data.SqlClient.SqlParameter("@SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO"), New System.Data.SqlClient.SqlParameter("@ShipDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"), New System.Data.SqlClient.SqlParameter("@TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FreightTermsCode", System.Data.SqlDbType.VarChar, 20, "FreightTermsCode"), New System.Data.SqlClient.SqlParameter("@FreightCode", System.Data.SqlDbType.VarChar, 20, "FreightCode"), New System.Data.SqlClient.SqlParameter("@ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TrailerNumber", System.Data.SqlDbType.VarChar, 20, "TrailerNumber")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.sqlConn
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PalletNum", System.Data.SqlDbType.VarChar, 30, "PalletNum"), New System.Data.SqlClient.SqlParameter("@SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO"), New System.Data.SqlClient.SqlParameter("@ShipDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"), New System.Data.SqlClient.SqlParameter("@TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FreightTermsCode", System.Data.SqlDbType.VarChar, 20, "FreightTermsCode"), New System.Data.SqlClient.SqlParameter("@FreightCode", System.Data.SqlDbType.VarChar, 20, "FreightCode"), New System.Data.SqlClient.SqlParameter("@ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TrailerNumber", System.Data.SqlDbType.VarChar, 20, "TrailerNumber"), New System.Data.SqlClient.SqlParameter("@Original_PalletNum", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PalletNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightTermsCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightTermsCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerNumber", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrailerNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.sqlConn
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_PalletNum", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PalletNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightTermsCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightTermsCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerNumber", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrailerNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daTrailerHeader
        '
        Me.daTrailerHeader.DeleteCommand = Me.SqlDeleteCommand3
        Me.daTrailerHeader.InsertCommand = Me.SqlInsertCommand3
        Me.daTrailerHeader.SelectCommand = Me.SqlSelectCommand4
        Me.daTrailerHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTrailerHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PalletNum", "PalletNum"), New System.Data.Common.DataColumnMapping("SO", "SO"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("ShipDate", "ShipDate"), New System.Data.Common.DataColumnMapping("TrailerControl", "TrailerControl"), New System.Data.Common.DataColumnMapping("FreightTermsCode", "FreightTermsCode"), New System.Data.Common.DataColumnMapping("FreightCode", "FreightCode"), New System.Data.Common.DataColumnMapping("ShipType", "ShipType"), New System.Data.Common.DataColumnMapping("TrailerNumber", "TrailerNumber")})})
        Me.daTrailerHeader.UpdateCommand = Me.SqlUpdateCommand4
        '
        'chkIncomplete
        '
        Me.chkIncomplete.BackColor = System.Drawing.Color.Yellow
        Me.chkIncomplete.Location = New System.Drawing.Point(893, 209)
        Me.chkIncomplete.Name = "chkIncomplete"
        Me.chkIncomplete.Size = New System.Drawing.Size(104, 16)
        Me.chkIncomplete.TabIndex = 7
        Me.chkIncomplete.Text = "Incomplete PO"
        Me.chkIncomplete.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax FROM dbo.tVendor"
        Me.SqlSelectCommand6.Connection = Me.sqlConn
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.sqlConn
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@lid", System.Data.SqlDbType.Int, 4, "lid"), New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@sStreet1", System.Data.SqlDbType.VarChar, 50, "sStreet1"), New System.Data.SqlClient.SqlParameter("@sStreet2", System.Data.SqlDbType.VarChar, 50, "sStreet2"), New System.Data.SqlClient.SqlParameter("@sCity", System.Data.SqlDbType.VarChar, 50, "sCity"), New System.Data.SqlClient.SqlParameter("@sProvState", System.Data.SqlDbType.VarChar, 50, "sProvState"), New System.Data.SqlClient.SqlParameter("@sCountry", System.Data.SqlDbType.VarChar, 50, "sCountry"), New System.Data.SqlClient.SqlParameter("@sPostalZip", System.Data.SqlDbType.VarChar, 50, "sPostalZip"), New System.Data.SqlClient.SqlParameter("@sPhone1", System.Data.SqlDbType.VarChar, 50, "sPhone1"), New System.Data.SqlClient.SqlParameter("@sPhone2", System.Data.SqlDbType.VarChar, 50, "sPhone2"), New System.Data.SqlClient.SqlParameter("@sFax", System.Data.SqlDbType.VarChar, 50, "sFax")})
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.sqlConn
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@lid", System.Data.SqlDbType.Int, 4, "lid"), New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@sStreet1", System.Data.SqlDbType.VarChar, 50, "sStreet1"), New System.Data.SqlClient.SqlParameter("@sStreet2", System.Data.SqlDbType.VarChar, 50, "sStreet2"), New System.Data.SqlClient.SqlParameter("@sCity", System.Data.SqlDbType.VarChar, 50, "sCity"), New System.Data.SqlClient.SqlParameter("@sProvState", System.Data.SqlDbType.VarChar, 50, "sProvState"), New System.Data.SqlClient.SqlParameter("@sCountry", System.Data.SqlDbType.VarChar, 50, "sCountry"), New System.Data.SqlClient.SqlParameter("@sPostalZip", System.Data.SqlDbType.VarChar, 50, "sPostalZip"), New System.Data.SqlClient.SqlParameter("@sPhone1", System.Data.SqlDbType.VarChar, 50, "sPhone1"), New System.Data.SqlClient.SqlParameter("@sPhone2", System.Data.SqlDbType.VarChar, 50, "sPhone2"), New System.Data.SqlClient.SqlParameter("@sFax", System.Data.SqlDbType.VarChar, 50, "sFax"), New System.Data.SqlClient.SqlParameter("@Original_lid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCountry", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPostalZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPostalZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sProvState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sProvState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.sqlConn
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_lid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCountry", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPostalZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPostalZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sProvState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sProvState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daVendor
        '
        Me.daVendor.DeleteCommand = Me.SqlDeleteCommand5
        Me.daVendor.InsertCommand = Me.SqlInsertCommand5
        Me.daVendor.SelectCommand = Me.SqlSelectCommand6
        Me.daVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        Me.daVendor.UpdateCommand = Me.SqlUpdateCommand6
        '
        'TPOHeaderTableAdapter1
        '
        Me.TPOHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TksijobsDataSet1
        '
        Me.TksijobsDataSet1.DataSetName = "TKSIJOBSDataSet"
        Me.TksijobsDataSet1.EnforceConstraints = False
        Me.TksijobsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblJobActivityTableAdapter1
        '
        Me.TblJobActivityTableAdapter1.ClearBeforeFill = True
        '
        'daPObyJOBID
        '
        Me.daPObyJOBID.SelectCommand = Me.SqlCommand2
        Me.daPObyJOBID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Connection = Me.sqlConn
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NJOBID", System.Data.SqlDbType.Int, 4, "nJobID")})
        '
        'txtAnyText
        '
        Me.txtAnyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnyText.Location = New System.Drawing.Point(1051, 202)
        Me.txtAnyText.Name = "txtAnyText"
        Me.txtAnyText.Size = New System.Drawing.Size(200, 26)
        Me.txtAnyText.TabIndex = 8
        '
        'btnPrintAnyLabel
        '
        Me.btnPrintAnyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintAnyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAnyLabel.Location = New System.Drawing.Point(1051, 234)
        Me.btnPrintAnyLabel.Name = "btnPrintAnyLabel"
        Me.btnPrintAnyLabel.Size = New System.Drawing.Size(200, 32)
        Me.btnPrintAnyLabel.TabIndex = 9
        Me.btnPrintAnyLabel.Text = "Print Any Label w/ barcode"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1052, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Any Text"
        '
        'frmLabelsHardware
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1395, 445)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAnyText)
        Me.Controls.Add(Me.btnPrintAnyLabel)
        Me.Controls.Add(Me.chkIncomplete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDamageNotes)
        Me.Controls.Add(Me.txtPOSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintLabel)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lvLabels)
        Me.Name = "frmLabelsHardware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Labels / Hardware PO"
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private daTrailerDetail As New dsTKSITableAdapters.tblTrailerDetailTableAdapter

    Private Sub txtPOSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOSearch.TextChanged
        If Me.txtPOSearch.Text.Trim.Length > 3 Then
            Me.daPObysPONum.SelectCommand.Parameters("@sPONum").Value = Me.txtPOSearch.Text.Trim & "%"
            Me.DsTKSI1.tPOHeader.Clear()
            Me.daPObysPONum.Fill(Me.DsTKSI1.tPOHeader)
            PopulateListBox()
        End If
    End Sub

    Private Sub PopulateListBox()
        Dim dtTrailerD As New dsTKSI.tblTrailerDetailDataTable
        Dim daTrD As New dsTKSITableAdapters.tblTrailerDetailTableAdapter

        Me.lvLabels.Items.Clear()
        Dim item1 As ListViewItem
        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In Me.DsTKSI1.tPOHeader
            Dim sLabelCount As String = ""
            If daTrD.FillByLikePO(dtTrailerD, drPO.sPONum) > 0 Then
                sLabelCount = " (" & dtTrailerD.Rows.Count & ") "
            End If

            item1 = Me.lvLabels.Items.Add(drPO.nID)
            With item1
                .SubItems.Add(drPO.sPONum)
                .SubItems.Add(drPO.sItems & sLabelCount)
                .SubItems.Add(drPO.sShipto3)
                .SubItems.Add(drPO.tVendorRow.sName & " " & drPO.sItemDesc)
            End With

        Next
        Me.lvLabels.Columns(0).Width = 100
        Me.lvLabels.Columns(1).Width = 100
        Me.lvLabels.Columns(2).Width = 150
        Me.lvLabels.Columns(3).Width = 250
        Me.lvLabels.Columns(4).Width = 330
        If Me.lvLabels.Items.Count = 1 Then
            Me.lvLabels.Items(0).Selected = True
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.txtPOSearch.Text = ""
        LoadDefaultFormData()
    End Sub

    Private Sub LoadDefaultFormData()
        Me.DsTKSI1.tPOHeader.Clear()
        Me.daPO.Fill(Me.DsTKSI1.tPOHeader)

        Me.DsTKSI1.tVendor.Clear()
        Me.daVendor.Fill(Me.DsTKSI1.tVendor)

        PopulateListBox()
    End Sub

    Private Sub frmLabelsHardware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefaultFormData()
    End Sub

    Private Sub btnPrintLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabel.Click
        Try
            If Me.lvLabels.SelectedItems.Count = 1 Then
                Dim POID As String = ""
                POID = Me.lvLabels.SelectedItems(0).Text
                If IsNumeric(POID) Then
                    Dim drPO As dsTKSI.tPOHeaderRow
                    drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
                    If Not drPO Is Nothing Then
                        CreateShippingTrailerRecords(drPO, Me.txtDamageNotes.Text, Me.chkIncomplete.Checked)
                    Else
                        'have POID but cant find PO record, this is exception
                        Throw New Exception("Could not find POID..." & POID)
                    End If
                Else
                    'no valid selection
                    Windows.Forms.MessageBox.Show("Select a valid PO to print.")
                End If
            Else
                Windows.Forms.MessageBox.Show("Select a PO to print.")
            End If

            PopulateListBox()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CreateShippingTrailerRecords(ByVal drPO As dsTKSI.tPOHeaderRow, ByVal damageNotes As String, ByVal blnIncomplete As Boolean)

        Me.DsTKSI1.tblTrailerHeader.Clear()
        Me.daTrailerHeader.SelectCommand.Parameters("@PO").Value = drPO.sPONum
        Me.daTrailerHeader.Fill(Me.DsTKSI1.tblTrailerHeader)

        If Me.DsTKSI1.tblTrailerHeader.Rows.Count = 0 Then
            'there is NO shipping lines at all, so create one with receive date of today
            'and print lablel
            Dim drD As dsTKSI.tblTrailerDetailRow
            drD = CreateNewShippingTrailerInfo(drPO, damageNotes)
            PrintLabel(drD, drPO)

        Else
            If Windows.Forms.MessageBox.Show("2nd Label?", "2nd label?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim drD As dsTKSI.tblTrailerDetailRow
                drD = CreateNewShippingTrailerInfo(drPO, damageNotes, True)
                PrintLabel(drD, drPO)
            Else
                'do nothing
            End If
            'Else
            '    'already has trailer rows, just reprint label
            '    Dim drTH As dsTKSI.tblTrailerHeaderRow
            '    drTH = Me.DsTKSI1.tblTrailerHeader(0)

            '    Me.DsTKSI1.tblTrailerDetail.Clear()
            '    ' Me.daTrailerDetail.SelectCommand.Parameters("@PO").Value = drTH.PO
            '    Me.daTrailerDetail.FillByLikePO(Me.DsTKSI1.tblTrailerDetail, drTH.PO)
            '    If Me.DsTKSI1.tblTrailerDetail.Rows.Count > 0 Then
            '        PrintLabel(Me.DsTKSI1.tblTrailerDetail(0), drPO)
            '        If Me.txtDamageNotes.Text.Trim.Length > 0 Then
            '            Windows.Forms.MessageBox.Show("This shipping record has alredy been created, use the shipping screen to create damage notes.")
            '        End If
            '    Else
            '        drTH.Delete()
            '        Me.daTrailerHeader.Update(Me.DsTKSI1.tblTrailerHeader)
            '        Me.DsTKSI1.tblTrailerHeader.AcceptChanges()
            '        Windows.Forms.MessageBox.Show("Old label data had to be cleaned up, please try again...")
            '        'Windows.Forms.MessageBox.Show("Could not locate shipping item to print.")
            '    End If
            'End If

        End If

        Try
            Dim sActivity As String = ""

            If blnIncomplete Then
                drPO.sBackOrder = "Yes"
            End If
            If drPO.IsDRECNull Then
                'normally we put in Hardware received, but if this is the only PO in the job that 
                'represents parts (ignore labor pos) then we should consider this as 'JOB RECEIVED' instead of 'HARDWARE RECEIVED'                '
                Dim blnHasCabinetry As Boolean = False
                Try
                    Dim dtPO As New dsTKSI.tPOHeaderDataTable
                    Dim drPO3 As dsTKSI.tPOHeaderRow
                    Me.daPObyJOBID.SelectCommand.Parameters("@NJOBID").Value = drPO.nJobID
                    Me.daPObyJOBID.Fill(dtPO)
                    For Each drPO3 In dtPO
                        If drPO3.nAccount = "4010" Then
                            blnHasCabinetry = True
                        End If
                    Next
                Catch ex As Exception
                End Try

                If blnHasCabinetry Then
                    sActivity = "Hardware Received"
                Else
                    sActivity = "Job Received"
                End If
                drPO.DREC = Today.Date

            End If
            Me.daPO.Update(Me.DsTKSI1.tPOHeader)
            Me.DsTKSI1.tPOHeader.AcceptChanges()

            Me.TPOHeaderTableAdapter1.FillByNJOBID(Me.TksijobsDataSet1.tPOHeader, drPO.nJobID)
            Dim drPO1 As TKSIJOBSDataSet.tPOHeaderRow
            Dim blnAllReceived As Boolean = True
            For Each drPO1 In Me.TksijobsDataSet1.tPOHeader
                If drPO1.IsDRECNull Then
                    blnAllReceived = False
                    Exit For
                End If
            Next
            If blnAllReceived Then
                sActivity = "Job Received"
            End If

            Try
                Dim drAct As TKSIJOBSDataSet.tblJobActivityRow
                drAct = Me.TksijobsDataSet1.tblJobActivity.NewtblJobActivityRow
                With drAct
                    .ActivityDetail = sActivity
                    .ActivityType = sActivity
                    .gID = Guid.NewGuid
                    .Other = ""
                    .nJobID = drPO.nJobID
                    .dateEntered = Now
                End With
                Me.TksijobsDataSet1.tblJobActivity.Rows.Add(drAct)
                Me.TblJobActivityTableAdapter1.Update(Me.TksijobsDataSet1.tblJobActivity)
            Catch ex As Exception
                Throw New Exception("Error updating PO information with date received.")
            End Try

        Catch ex As Exception
            Throw New Exception("Error updating PO information with date received.")
        End Try

        Me.txtDamageNotes.Text = ""
        'set incomplete checkbox back to unchecked
        Me.chkIncomplete.Checked = False
    End Sub

    Private Function CreateNewShippingTrailerInfo(ByVal drPO As dsTKSI.tPOHeaderRow, ByVal damagenotes As String, Optional ByVal blnSecondDetailLineOnSameHeader As Boolean = False) As dsTKSI.tblTrailerDetailRow
        'create all new trailer and shipping item rows 
        Dim tempSupplierSO As Long = 0
        Dim r1 As New Random
        Dim strRandom As String = Mid(r1.Next(), 1, 3)
        tempSupplierSO = drPO.nID & strRandom
        Dim tempPalletNum As String = ""
        tempPalletNum = drPO.sPONum '& "-" & strRandom

        If Not blnSecondDetailLineOnSameHeader Then
            'first record or new record for new header
            Dim drH As dsTKSI.tblTrailerHeaderRow
            drH = Me.DsTKSI1.tblTrailerHeader.NewtblTrailerHeaderRow
            With drH
                .PalletNum = tempPalletNum
                .SO = tempSupplierSO
                .PO = drPO.sPONum
                .ShipDate = Today.Date
                .TrailerControl = 0
                .FreightTermsCode = drPO.sVia
                .FreightCode = drPO.sShipto3
                .ShipType = 0
                .TrailerNumber = drPO.sVia
            End With
            Me.DsTKSI1.tblTrailerHeader.Rows.Add(drH)

            Dim drSH As dsTKSI.tblShippingHeaderRow
            drSH = Me.DsTKSI1.tblShippingHeader.NewtblShippingHeaderRow
            With drSH
                .SupplierSONum = tempSupplierSO
                .PO = drPO.sPONum
                '.SupplierSONum = tempSupplierSO
                .SupplierCode = "HDWR"
                .StyleCode = drPO.sItemDesc
                .StyleDesc = drPO.sItemDesc
                .TotalCabs = 0
                .OrderLines = 1
                .OrderStatus = 0
                .DateClosed = Date.Today
                .DateImported = Now
                .DateCompletion = Now
                .DateCompletion = Date.Today

            End With
            Me.DsTKSI1.tblShippingHeader.Rows.Add(drSH)

            'shipping detail item
            Dim drSD As dsTKSI.tblShippingItemsRow
            'create new label id row
            drSD = Me.DsTKSI1.tblShippingItems.NewtblShippingItemsRow
            With drSD
                .CabType = ""
                .ColorCode = ""
                .ColorDesc = ""
                .SetDateDeliveredNull()
                .DateReceived = Now
                .SpecialNote1 = ""
                .SpecialNote2 = ""
                .StyleCode = ""
                .StyleDesc = drPO.sItemDesc
                .SupplierSO = tempSupplierSO
                .LineNumber = 1
                .ProdCode = ""
                .ProdDesc = drPO.sItemDesc
                .Quantity = 1
                .QuantityDel = 0
                .QuantityRec = 1
                .DateImported = Now
                .DateLastChanged = Now
            End With
            Me.DsTKSI1.tblShippingItems.Rows.Add(drSD)

            Me.daTrailerHeader.Update(Me.DsTKSI1.tblTrailerHeader)
            Me.DsTKSI1.tblTrailerHeader.AcceptChanges()

            Me.daShippingHeader.Update(Me.DsTKSI1.tblShippingHeader)
            Me.DsTKSI1.tblShippingHeader.AcceptChanges()

            Me.daShippingItems.Update(Me.DsTKSI1.tblShippingItems)
            Me.DsTKSI1.tblShippingItems.AcceptChanges()
        End If

        'trailer detail
        Dim drD As dsTKSI.tblTrailerDetailRow
        'create new label id row
        drD = Me.DsTKSI1.tblTrailerDetail.NewtblTrailerDetailRow
        With drD
            .ShipNum = tempPalletNum
            .OrderLineNumber = 1
            .ShippedQuantity = 1
            .LoadedDate = Date.Today
            .LabelID = drPO.sPONum & "-" & Now.Hour & Now.Millisecond
            .po = drPO.sPONum
            .SupplierSO = tempSupplierSO ' drPO.sPONum
            .DateScannedTKSI = Now
            Try
                If damagenotes.Trim.Length > 0 Then
                    .DamageNotes = damagenotes
                Else
                    .DamageNotes = ""
                End If
            Catch ex As Exception
                .DamageNotes = ""
            End Try

            Try
                .DetailDescription = drPO.sItemDesc
                .Other = ""
            Catch ex As Exception
                .Other = ""
                .DetailDescription = "Misc..."
            End Try
            'all other leave default NULL
        End With
        Me.DsTKSI1.tblTrailerDetail.Rows.Add(drD)

        Dim iResult As Integer = Me.daTrailerDetail.Update(Me.DsTKSI1.tblTrailerDetail)

        'return back trailer detail row
        Return drD
    End Function

    Dim line1 As String = ""
    Dim line2 As String = ""
    Dim line3 As String = ""
    Dim line4BarCode As String = ""
    Dim intLabelfontsize As Integer = 14

    Private Sub PrintLabel(ByVal drTD As dsTKSI.tblTrailerDetailRow, ByVal drPO As dsTKSI.tPOHeaderRow)
        line4BarCode = drTD.LabelID
        line3 = drTD.po
        Try
            line3 = line3 & "  Line: " & drTD.OrderLineNumber
        Catch ex As Exception
        End Try

        ' If Not drTD.IsDamageNotesNull Then
        line3 = line3 & "   " & drTD.DamageNotes
        '  End If

        Try
            line1 = drTD.tblTrailerHeaderRow.FreightCode & " / " & drPO.tVendorRow.sName

            Dim drShipItem As dsTKSI.tblShippingItemsRow
            If drTD.IsSupplierSONull Then
                drShipItem = Me.DsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drTD.tblTrailerHeaderRow.SO, drTD.OrderLineNumber)

            Else
                drShipItem = Me.DsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drTD.SupplierSO, drTD.OrderLineNumber)

            End If

            If drShipItem Is Nothing Then
                Me.daShippingItems.SelectCommand.Parameters("@PO").Value = drTD.tblTrailerHeaderRow.PO
                Me.daShippingItems.Fill(Me.DsTKSI1.tblShippingItems)
                If drTD.IsSupplierSONull Then
                    drShipItem = Me.DsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drTD.tblTrailerHeaderRow.SO, drTD.OrderLineNumber)
                Else
                    drShipItem = Me.DsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drTD.SupplierSO, drTD.OrderLineNumber)
                End If
            End If

            If Not drShipItem Is Nothing Then
                line2 = drShipItem.ProdDesc
            Else
                line2 = ""
            End If


        Catch ex As Exception
            line2 = "error"
        End Try

        With Me.PrintDocumentBarCodeLabel

            .DocumentName = "Shipping Label"
            If Not ISDebugMachine Then
                .PrinterSettings.PrinterName = "\\Mark-PC\ZebraLP2office"
            End If

            .PrinterSettings.DefaultPageSettings.Margins.Left = 20
            .PrinterSettings.DefaultPageSettings.Margins.Right = 5
            .PrinterSettings.DefaultPageSettings.Margins.Top = 20
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 5

        End With
        Me.PrintDocumentBarCodeLabel.Print()
    End Sub

    Private Sub PrintAnyLabel(_line1 As String)
        Me.line1 = ""
        Me.line2 = ""
        Me.line3 = ""
        Me.intLabelfontsize = 22
        With Me.PrintDocumentBarCodeLabel
            Me.line4BarCode = _line1
            .DocumentName = "Any Label"
            If Not ISDebugMachine Then
                .PrinterSettings.PrinterName = "\\Mark-PC\ZebraLP2office"
            End If

            .PrinterSettings.DefaultPageSettings.Margins.Left = 20
            .PrinterSettings.DefaultPageSettings.Margins.Right = 5
            .PrinterSettings.DefaultPageSettings.Margins.Top = 20
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 5

        End With
        Me.PrintDocumentBarCodeLabel.Print()
    End Sub

    Private Function DrawLabelGraphics(ByVal g As Graphics) As Boolean
        g.DrawString(Me.line1, New Font("Arial", Me.intLabelfontsize.ToString, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 1)
        g.DrawString(Me.line2, New Font("Arial", Me.intLabelfontsize.ToString, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 26)
        g.DrawString(Me.line3, New Font("Arial", Me.intLabelfontsize.ToString, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 51)
        g.DrawString("*" & Me.line4BarCode & "*", New Font("Bar Code 39 d", (Me.intLabelfontsize + 2).ToString, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 15, 76)
        g.DrawString("*" & Me.line4BarCode & "*", New Font("Arial", (Me.intLabelfontsize - 4).ToString, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 15, 106)

        Return False
    End Function

    Private Sub PrintDocumentBarCodeLabel_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentBarCodeLabel.PrintPage
        e.HasMorePages = Me.DrawLabelGraphics(e.Graphics)
    End Sub

    Private Sub btnPrintAnyLabel_Click(sender As Object, e As EventArgs) Handles btnPrintAnyLabel.Click
        PrintAnyLabel(Me.txtAnyText.Text.Trim)
    End Sub
End Class
