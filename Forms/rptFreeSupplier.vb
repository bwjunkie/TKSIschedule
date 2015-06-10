Option Strict Off
Option Explicit On
Option Compare Text
Imports C1.Win.C1FlexGrid.Classic
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Friend Class rptFreeSupplier
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
    Public WithEvents txtDate2 As System.Windows.Forms.TextBox
    Public WithEvents txtDate1 As System.Windows.Forms.TextBox
    Public WithEvents txtPOsearch As System.Windows.Forms.TextBox
    Public WithEvents cmdPOsearch As System.Windows.Forms.Button
    Public WithEvents cmdRefresh As System.Windows.Forms.Button
    Public WithEvents gridSupplier As C1FlexGridClassic
    Public WithEvents cmdRecord As System.Windows.Forms.Button
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents gridReport As C1FlexGridClassic
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblPOsearch As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents chkHideSimply As System.Windows.Forms.CheckBox
    Public WithEvents btnWordReport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReportRangeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportRangeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnClearFilter As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents daPOHeaderALL As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFreeSupplier))
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.txtDate1 = New System.Windows.Forms.TextBox()
        Me.txtPOsearch = New System.Windows.Forms.TextBox()
        Me.cmdPOsearch = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.gridSupplier = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.cmdRecord = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.gridReport = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPOsearch = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.chkHideSimply = New System.Windows.Forms.CheckBox()
        Me.btnWordReport = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReportRangeStart = New System.Windows.Forms.DateTimePicker()
        Me.ReportRangeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDate2
        '
        Me.txtDate2.AcceptsReturn = True
        Me.txtDate2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate2.Location = New System.Drawing.Point(14, 76)
        Me.txtDate2.MaxLength = 0
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDate2.Size = New System.Drawing.Size(169, 22)
        Me.txtDate2.TabIndex = 9
        '
        'txtDate1
        '
        Me.txtDate1.AcceptsReturn = True
        Me.txtDate1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate1.Location = New System.Drawing.Point(14, 28)
        Me.txtDate1.MaxLength = 0
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDate1.Size = New System.Drawing.Size(169, 22)
        Me.txtDate1.TabIndex = 8
        '
        'txtPOsearch
        '
        Me.txtPOsearch.AcceptsReturn = True
        Me.txtPOsearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtPOsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPOsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOsearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPOsearch.Location = New System.Drawing.Point(318, 14)
        Me.txtPOsearch.MaxLength = 0
        Me.txtPOsearch.Name = "txtPOsearch"
        Me.txtPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPOsearch.Size = New System.Drawing.Size(113, 22)
        Me.txtPOsearch.TabIndex = 2
        '
        'cmdPOsearch
        '
        Me.cmdPOsearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPOsearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPOsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPOsearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPOsearch.Location = New System.Drawing.Point(437, 14)
        Me.cmdPOsearch.Name = "cmdPOsearch"
        Me.cmdPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPOsearch.Size = New System.Drawing.Size(73, 36)
        Me.cmdPOsearch.TabIndex = 3
        Me.cmdPOsearch.Text = "PO Search"
        Me.cmdPOsearch.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(14, 705)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(209, 30)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Refresh Data"
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'gridSupplier
        '
        Me.gridSupplier.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridSupplier.FixedCols = 0
        Me.gridSupplier.FixedRows = 0
        Me.gridSupplier.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridSupplier.Location = New System.Drawing.Point(14, 112)
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.NodeClosedPicture = Nothing
        Me.gridSupplier.NodeOpenPicture = Nothing
        Me.gridSupplier.OutlineCol = -1
        Me.gridSupplier.Size = New System.Drawing.Size(209, 555)
        Me.gridSupplier.StyleInfo = resources.GetString("gridSupplier.StyleInfo")
        Me.gridSupplier.TabIndex = 3
        Me.gridSupplier.TreeColor = System.Drawing.Color.DarkGray
        '
        'cmdRecord
        '
        Me.cmdRecord.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRecord.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRecord.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRecord.Location = New System.Drawing.Point(734, 13)
        Me.cmdRecord.Name = "cmdRecord"
        Me.cmdRecord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRecord.Size = New System.Drawing.Size(240, 30)
        Me.cmdRecord.TabIndex = 4
        Me.cmdRecord.Text = "Send to Sage"
        Me.cmdRecord.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(29, 13)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(181, 30)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'gridReport
        '
        Me.gridReport.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridReport.FixedCols = 0
        Me.gridReport.FixedRows = 0
        Me.gridReport.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridReport.Location = New System.Drawing.Point(246, 0)
        Me.gridReport.Name = "gridReport"
        Me.gridReport.NodeClosedPicture = Nothing
        Me.gridReport.NodeOpenPicture = Nothing
        Me.gridReport.OutlineCol = -1
        Me.gridReport.Size = New System.Drawing.Size(1065, 825)
        Me.gridReport.StyleInfo = resources.GetString("gridReport.StyleInfo")
        Me.gridReport.TabIndex = 0
        Me.gridReport.TreeColor = System.Drawing.Color.DarkGray
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(14, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(169, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(169, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "From:"
        '
        'lblPOsearch
        '
        Me.lblPOsearch.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOsearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPOsearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOsearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPOsearch.Location = New System.Drawing.Point(528, 14)
        Me.lblPOsearch.Name = "lblPOsearch"
        Me.lblPOsearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPOsearch.Size = New System.Drawing.Size(126, 17)
        Me.lblPOsearch.TabIndex = 6
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
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=orange;pe" & _
    "rsist security info=True;initial catalog=TKSIJOBS;password=tksi"
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
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
        'chkHideSimply
        '
        Me.chkHideSimply.AutoSize = True
        Me.chkHideSimply.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideSimply.Location = New System.Drawing.Point(29, 49)
        Me.chkHideSimply.Name = "chkHideSimply"
        Me.chkHideSimply.Size = New System.Drawing.Size(219, 20)
        Me.chkHideSimply.TabIndex = 13
        Me.chkHideSimply.Text = "Hide PO's already sent to Simply"
        Me.chkHideSimply.UseVisualStyleBackColor = True
        '
        'btnWordReport
        '
        Me.btnWordReport.BackColor = System.Drawing.SystemColors.Control
        Me.btnWordReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnWordReport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWordReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWordReport.Location = New System.Drawing.Point(6, 13)
        Me.btnWordReport.Name = "btnWordReport"
        Me.btnWordReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnWordReport.Size = New System.Drawing.Size(195, 42)
        Me.btnWordReport.TabIndex = 14
        Me.btnWordReport.Text = "Installer Report Date Range"
        Me.btnWordReport.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.lblPOsearch)
        Me.Panel1.Controls.Add(Me.chkHideSimply)
        Me.Panel1.Controls.Add(Me.cmdRecord)
        Me.Panel1.Controls.Add(Me.cmdPOsearch)
        Me.Panel1.Controls.Add(Me.txtPOsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(246, 825)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 122)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnClearFilter)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.gridSupplier)
        Me.Panel2.Controls.Add(Me.txtDate2)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.txtDate1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 947)
        Me.Panel2.TabIndex = 16
        '
        'btnClearFilter
        '
        Me.btnClearFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClearFilter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClearFilter.Location = New System.Drawing.Point(139, 669)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClearFilter.Size = New System.Drawing.Size(84, 21)
        Me.btnClearFilter.TabIndex = 20
        Me.btnClearFilter.Text = "Clear Vendor"
        Me.btnClearFilter.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "From"
        '
        'ReportRangeStart
        '
        Me.ReportRangeStart.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportRangeStart.CustomFormat = "MM/dd/yyyy"
        Me.ReportRangeStart.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReportRangeStart.Location = New System.Drawing.Point(46, 62)
        Me.ReportRangeStart.Margin = New System.Windows.Forms.Padding(8)
        Me.ReportRangeStart.Name = "ReportRangeStart"
        Me.ReportRangeStart.Size = New System.Drawing.Size(155, 22)
        Me.ReportRangeStart.TabIndex = 15
        '
        'ReportRangeEnd
        '
        Me.ReportRangeEnd.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportRangeEnd.CustomFormat = "MM/dd/yyyy"
        Me.ReportRangeEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReportRangeEnd.Location = New System.Drawing.Point(46, 93)
        Me.ReportRangeEnd.Name = "ReportRangeEnd"
        Me.ReportRangeEnd.Size = New System.Drawing.Size(155, 22)
        Me.ReportRangeEnd.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "To"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.btnWordReport)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.ReportRangeEnd)
        Me.Panel3.Controls.Add(Me.ReportRangeStart)
        Me.Panel3.Location = New System.Drawing.Point(14, 761)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 134)
        Me.Panel3.TabIndex = 21
        '
        'rptFreeSupplier
        '
        Me.AcceptButton = Me.cmdRefresh
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1311, 947)
        Me.Controls.Add(Me.gridReport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptFreeSupplier"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Free-Form Supplier Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private bLoading As Boolean
    Private dGridDate As Date
    Private lGridSupplier As Integer
    Dim lastcheck As Integer
    Dim lastInv As Integer
    Private bChanges As Boolean
    Private discount As Decimal
    Private bLoad1Supplier As Boolean
    Private lSupplierSelected As Integer
    Private lTruckSelected As Integer

    Private oJob As New JobObj

    Private Sub cmdClearFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        SaveChanges()
        ClearFilters()
        LoadReport()
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
        Dim drPO As dsTKSI.tPOHeaderRow
        Dim frmDisc As New frmDiscount1
        If bChanges Then
            frmDisc.ShowDialog()
            If frmDisc.blnOK Then
                If IsNumeric(frmDisc.txtDiscount.Text.Trim) Then
                    discount = frmDisc.txtDiscount.Text.Trim
                Else
                    discount = 0
                End If
            Else
                Exit Sub
            End If
        End If
        With gridReport
            .Redraw = False
            For Y = 4 To .Rows - 1
                If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0)) Then
                    If CBool(.get_TextMatrix(Y, 20)) = True Then
                        If CBool(.get_TextMatrix(Y, 19)) = False Or UCase(.get_TextMatrix(Y, 21)) = "YES" Then
                            If IsDate(.get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)) Then

                                drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))
                                If Not drPO Is Nothing Then
                                    If IsDate(.get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)) Then
                                        If UpdateSimply(drPO, discount) Then 'rsPO) Then
                                            drPO.dSimply = .get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17)
                                            drPO.bSimply = True

                                            .set_TextMatrix(Y, 19, True)
                                        End If
                                    Else 'if PO is in Simply already then update fields in job
                                        'database cause they should already have been updated
                                        drPO.bSimply = True
                                        If drPO.IsdSimplyNull Then
                                            drPO.dSimply = Today
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)) Or Len(.get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)) < 1 Then
                            drPO = Me.DsTKSI1.tPOHeader.FindBynID(.get_Cell(CellPropertySettings.flexcpText, Y, 0, Y, 0))

                            If Not drPO Is Nothing Then ' rsPO.EOF Then
                                If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)) Then
                                    If .get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18) > 0 Then
                                        If drPO.nInvNo <> .get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18) Then
                                            drPO.nInvNo = .get_Cell(CellPropertySettings.flexcpText, Y, 18, Y, 18)
                                        End If

                                    End If

                                Else

                                    If drPO.nInvNo.Length > 0 Then
                                        drPO.nInvNo = ""
                                    End If

                                End If

                            End If
                        End If
                    End If
                End If
            Next

            Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
            Me.DsTKSI1.tPOHeader.AcceptChanges()

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

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        SaveChanges()
        LoadReport()
        bLoading = False
    End Sub

    Private Sub SaveChanges()
        If bChanges Then
            cmdRec_Click()
        End If
    End Sub

    Private Sub rptFreeSupplier_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Try
            'this data does not get refreshed using different parameters during report useage
            'so only load once
            oJob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1)
            bChanges = False
            bLoad1Supplier = False
            bLoading = True
            gridDateInit()
            gridSupplierInit()
            ReportRangeStart.Value = Today.Date
            ReportRangeEnd.Value = Today.Date
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadReport()
        gridReportALL()
    End Sub

    Private Sub gridDateInit()
        getdates()
    End Sub

    Private Sub gridSupplierInit()
        With gridSupplier
            .Cols = 3
            .Rows = 0
            .set_ColHidden(0, True)
            .set_ColHidden(1, True)
            .set_ColWidth(2, 2000)
        End With
    End Sub

    Private Sub getdates()
        Dim today_Renamed As Date
        Dim thisWednesday As Date
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
        Next
    End Sub

    Private Sub rptFreeSupplier_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        If bChanges Then SaveChanges()
        ClearFilters()
    End Sub

    Private Sub ClearFilters()
        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In Me.DsTKSI1.tPOHeader
            If drPO.sFilter.Length > 0 Then
                drPO.sFilter = ""
            End If
        Next
        Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
        Me.DsTKSI1.tPOHeader.AcceptChanges()

    End Sub

    Private Sub gridDate_Click()
        Dim gridDate As Object
        If gridDate.RowSel > -1 Then
            If bChanges Then SaveChanges()
            txtDate1.Text = ""
            txtDate2.Text = ""
            gridClicks()
            bLoad1Supplier = False
        End If
    End Sub

    Sub openpo()
        gridReport.Select(gridReport.RowSel, 0)
        If IsNumeric(gridReport.Text) Then
            If CInt(gridReport.Text) > 0 Then
                OpenPOScreen(CInt(gridReport.Text), True)
                LoadReport()
            End If
        Else
            MsgBox("Error: grid ID is incorrect")
        End If
    End Sub

    'Private Sub ShowPO(ByVal POID As Long)
    '    Dim drPO As dsTKSI.tPOHeaderRow
    '    drPO = Me.DsTKSI1.tPOHeader.FindBynID(POID)
    '    If Not drPO Is Nothing Then
    '        ' Dim frmPO1 As frmPOnet
    '        If POID > 0 Then
    '          openpo
    '            Me.LoadReport()
    '        End If
    '    End If
    'End Sub

    Private Sub gridClicks()
        Dim gridDate As Object
        If gridDate.RowSel > -1 Then
            gridDate.Select(gridDate.RowSel, 0)
            If IsDate(gridDate.Text) Then
                dGridDate = gridDate.Text
                gridReportALL()
            Else
                gridReport.Rows = 0
            End If
        End If

    End Sub

    Private Sub gridReportALL()
        '  Dim draPOheader As dsTKSI.tPOHeaderRow()

        Dim lasttruck As Long
        Dim lastvendor As Long
        Dim strtemp As String
        Dim totalFRsale As Decimal
        Dim totalPOSale As Decimal
        Dim strtotals As String
        Dim strsupplier As String

        gridReport.Redraw = False
        Dim x, Y As Integer
        Dim totalboxes As Integer
        Dim totalPOCOST As Decimal
        Dim totalFRCost As Decimal
        '  Dim oPO As New PO
        '   Dim lFiltered As Integer

        Dim date1 As Date
        Dim date2 As Date
        gridSupplier.Rows = 0

        If IsDate2(txtDate1.Text) And IsDate2(txtDate2.Text) Then
            date1 = CDate(txtDate1.Text)
            date2 = CDate(txtDate2.Text)
        Else
            If InStr(dGridDate, ":") > 0 Then
                'show no data
                dGridDate = CDate("1/1/1990")
            End If
            date1 = DateAdd(DateInterval.Day, -3, dGridDate)
            date2 = DateAdd(DateInterval.Day, 3, dGridDate)
        End If

        Dim listPOHeader 'As List(Of dsTKSI.tPOHeaderRow)

        With gridReport

            .Cols = 23
            .Rows = 0
            .Rows = 5
            .GridLines = GridStyleSettings.flexGridNone
            Y = .Rows - 1
            'Figure number of items being filtered

            If Not oJob.SelectPOandLinesByDateRequiredRange(Me.DsTKSI1, date1, date2) Then
                Windows.Forms.MessageBox.Show("Failed to load supplier data.")
                Exit Sub
            End If

            '            SELECT     nID, nJobID, dCreateRecord, nVendorID, sPONum, sShipTo1, sShipTo2, sShipto3, sShipToCity, sShipToState, sShipToZip, sShiptoCounty, nBoxes, 
            '                      dPODate, sTerms, dRequired, sEnteredBy, nTotal, sVia, sFOB, nRetailSale, nSaleAccount, nRetailFreight, sConf, nAdd, DREC, DDEL, SRECNOTES, 
            '                      SDELNOTES, DFAXED, nAccount, nInvNo, nCheckNo, dSimply, bSimply, nTruck, sFilter, sBackOrder, sItems, sItemDesc, sPOType, nsalesadjust, 
            '                      sAdjustReason, sCurActNote, nPOSort
            'FROM         tPOHeader
            'WHERE     (dRequired >= @STARTDATE) AND (dRequired <= @ENDDATE)
            'ORDER BY nVendorID, nTruck, CASE WHEN ISNUMERIC(SUBSTRING(sPONum, 1, 5)) = 1 THEN substring(sPONum, 1, 5) ELSE '0' + substring(sPONum, 1, 4) 
            '                      END, nPOSort



            If bLoad1Supplier Then
                listPOHeader = (From row In Me.DsTKSI1.tPOHeader Where row.sFilter <> "YES" And row.nVendorID = lSupplierSelected Order By row.nVendorID, row.nTruck, global_POSortable(row.sPONum)).ToList

                '  draPOheader = Me.DsTKSI1.tPOHeader.Select("sFilter<>'YES' and nVendorID=" & lSupplierSelected, "nVendorID,nTruck,sponum")
            Else
                listPOHeader = (From row In Me.DsTKSI1.tPOHeader Where row.sFilter <> "YES" Order By row.nVendorID, row.nTruck, global_POSortable(row.sPONum)).ToList
                'draPOheader = Me.DsTKSI1.tPOHeader.Select("sFilter<>'YES'", "nVendorID,nTruck,sponum")
            End If



            '    Dim draPOFilterCount As dsTKSI.tPOHeaderRow()
            '    draPOFilterCount = Me.DsTKSI1.tPOHeader.Select("sFilter='YES'")
            '    lFiltered = draPOFilterCount.Length

            '  .set_Cell(CellPropertySettings.flexcpText, 1, 4, 1, 5, "Items Filtered = " & lFiltered)
            .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 3, "Payment (Simply Accounting)")
            .set_Cell(CellPropertySettings.flexcpText, 2, 1, 2, 3, "WEEK OF: " & date1 & " - " & date2)
            .set_Cell(CellPropertySettings.flexcpText, 2, 15, 2, 15, "")
            .set_Cell(CellPropertySettings.flexcpAlignment, 2, 15, 2, 15, AlignmentSettings.flexAlignLeftCenter)
            .set_Cell(CellPropertySettings.flexcpBackColor, 2, 14, 2, 15, Color.Yellow)
            .Select(2, 14, 2, 15)
            '  .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)


            .set_ColWidth(1, 1000 / global_OldGridNewGridRation)
            .set_ColWidth(2, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(3, 1600 / global_OldGridNewGridRation)
            .set_ColWidth(4, 750 / global_OldGridNewGridRation)
            .set_ColWidth(5, 1100 / global_OldGridNewGridRation)
            .set_ColWidth(6, 900 / global_OldGridNewGridRation)
            .set_ColWidth(7, 900 / global_OldGridNewGridRation)
            .set_ColWidth(8, 900 / global_OldGridNewGridRation)
            .set_ColWidth(9, 900 / global_OldGridNewGridRation)
            .set_ColWidth(10, 700 / global_OldGridNewGridRation)
            .set_ColWidth(11, 1300 / global_OldGridNewGridRation)
            .set_ColWidth(12, 700 / global_OldGridNewGridRation)
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
            .set_ColHidden(12, True)
            .set_ColHidden(13, False)
            .set_ColHidden(14, True)
            .set_ColHidden(15, True)
            .set_ColHidden(16, True)
            .set_ColHidden(17, False)
            .set_ColHidden(18, False)
            .set_ColHidden(19, True)
            .set_ColHidden(20, True)
            .set_ColHidden(21, False)
            .set_ColHidden(22, True)


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
            .set_TextMatrix(4, 21, "RESEND")
            .set_ColDataType(19, GetType(Boolean))
            .set_ColDataType(20, GetType(Boolean))
        End With
        gridReport.FrozenRows = 5

        With gridReport
            Dim drPO As dsTKSI.tPOHeaderRow
            For Each drPO In listPOHeader ' draPOheader
                Y = gridReport.Rows - 1
                If lastvendor <> drPO.nVendorID Then
                    'setup vendor TOTALS
                    strsupplier = drPO.tVendorRow.lid & vbTab & drPO.nTruck & vbTab
                    strsupplier = strsupplier & drPO.tVendorRow.sName
                    gridSupplier.AddItem(strsupplier)
                    'supplier grid truck difference
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
                        .set_Cell(CellPropertySettings.flexcpAlignment, Y, 3, Y, 3, AlignmentSettings.flexAlignRightCenter)
                        .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 13, True)
                        .set_RowHeight(.Rows - 1, 700 / global_OldGridNewGridRation)
                    End If
                    totalPOCOST = 0
                    totalFRCost = 0
                    totalboxes = 0
                    totalPOSale = 0
                    totalFRsale = 0
                    gridReport.AddItem("" & vbTab & "")
                    If Not drPO.tVendorRow Is Nothing Then
                        strtemp = drPO.tVendorRow.sName & vbTab
                        gridReport.AddItem(strtemp & strtemp & strtemp & strtemp & strtemp & strtemp & strtemp & strtemp & strtemp & strtemp)

                    Else
                        gridReport.AddItem("" & vbTab & "NO VENDOR" & vbTab & "NO VENDOR")
                    End If
                    Y = gridReport.Rows - 1
                    gridReport.set_MergeRow(gridReport.Rows - 1, True)
                    gridReport.set_Cell(CellPropertySettings.flexcpAlignment, Y, 0, Y, 8, AlignmentSettings.flexAlignLeftCenter)
                    gridReport.set_Cell(CellPropertySettings.flexcpFontBold, Y, 0, Y, 8, True)

                End If
                lastvendor = drPO.nVendorID
                lasttruck = drPO.nTruck



                If (drPO.IsdSimplyNull) Or Me.chkHideSimply.Checked = False Then

                    gridReport.Rows = gridReport.Rows + 1
                    Y = gridReport.Rows - 1

                    .set_RowHeight(Y, 400 / global_OldGridNewGridRation)
                    .set_TextMatrix(Y, 0, drPO.nID)
                    .set_TextMatrix(Y, 1, drPO.sConf)
                    .set_TextMatrix(Y, 2, drPO.sPONum)
                    If Not drPO.tJobRow.tCustomrRow Is Nothing Then .set_TextMatrix(Y, 3, drPO.tJobRow.tCustomrRow.sName) 'rsCust.Fields("sname").Value & "") 'BUILDER NAME
                    If Not drPO.IsDRECNull Then
                        .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, Color.Yellow) ' global_ColorFromHex(&H99, &HFF, &HFF))
                        .set_Cell(CellPropertySettings.flexcpFontBold, Y, 3, Y, 3, True)
                    End If
                    If Not drPO.IsDDELNull Then
                        .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 3, global_ColorFromHex(&H99, &HFF, &H99))
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
                    .set_TextMatrix(Y, 13, drPO.tJobRow.sSalesperson)
                    If Not drPO.IsDRECNull Then .set_TextMatrix(Y, 14, drPO.DREC.ToShortDateString)
                    .set_TextMatrix(Y, 15, drPO.SRECNOTES)
                    If Not drPO.IsDFAXEDNull Then .set_TextMatrix(Y, 16, drPO.DFAXED.ToShortDateString)
                    If Not drPO.IsdSimplyNull Then .set_TextMatrix(Y, 17, drPO.dSimply.ToShortDateString)
                    .set_TextMatrix(Y, 18, drPO.nInvNo)
                    .set_TextMatrix(Y, 19, drPO.bSimply)
                    .set_TextMatrix(Y, 20, False)
                    .set_TextMatrix(Y, 21, "NO")

                    .Select(Y, x, Y, 18)
                    .CellAlignment = AlignmentSettings.flexAlignLeftCenter
                    '  .CellBorder(System.Convert.ToUInt32(Color.Black), 0, 1, 0, 0, 0, 0)

                    .set_TextMatrix(Y, 22, drPO.sFilter)
                    If UCase(drPO.sFilter) = "YES" Then
                        .set_Cell(CellPropertySettings.flexcpBackColor, Y, 3, Y, 16, global_ColorFromHex(&H99, &H99, &H99))
                    End If

                Else
                    'dont show at all , filtered out because not showing "sent to simply" items

                End If
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
                    .set_Cell(CellPropertySettings.flexcpAlignment, Y, 1, Y, 14, AlignmentSettings.flexAlignRightCenter)
                    .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 13, True)
                    .set_RowHeight(.Rows - 1, 700 / global_OldGridNewGridRation)
                End If
            End If
            .Select(0, 0)
            .ScrollPosition = New Point(0, 0)
            .Redraw = True
        End With

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
                            .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)
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
                            .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.Yellow)
                            bChanges = True
                        End If
                    Case Else
                        If eventArgs.Button = 2 Then
                            .set_Cell(CellPropertySettings.flexcpBackColor, .MouseRow, 3, .MouseRow, 16, Color.LightGray)
                            .set_TextMatrix(.MouseRow, 22, "YES")

                            If IsNumeric(.get_TextMatrix(.MouseRow, 0)) Then
                                Dim drPO1 As dsTKSI.tPOHeaderRow
                                For Each drPO1 In Me.DsTKSI1.tPOHeader
                                    If drPO1.nID = CLng(.get_TextMatrix(.MouseRow, 0)) Then
                                        drPO1.sFilter = "YES"
                                    End If
                                Next
                            End If
                            Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader)
                            Me.DsTKSI1.tPOHeader.AcceptChanges()

                        End If
                End Select
            End If
        End With
    End Sub

    Private Sub gridSupplier_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridSupplier.Click
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

    Private Sub txtDate1_Leave(sender As Object, e As EventArgs) Handles txtDate1.Leave
        Try
            If txtDate1.Text.Split("/").Count = 2 Then
                txtDate1.Text = txtDate1.Text & "/2014"
            ElseIf txtDate1.Text.Split("-").Count = 2 Then
                txtDate1.Text = txtDate1.Text.Trim & "-2014"
            End If
        Catch
        End Try
    End Sub

    Private Sub txtDate2_Leave(sender As Object, e As EventArgs) Handles txtDate2.Leave
        Try
            If txtDate2.Text.Split("/").Count = 2 Then
                txtDate2.Text = txtDate2.Text.Trim & "/2014"
            ElseIf txtDate2.Text.Split("-").Count = 2 Then
                txtDate2.Text = txtDate2.Text.Trim & "-2014"
            End If
        Catch
        End Try
    End Sub

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private Sub btnWordReport_Click(sender As Object, e As EventArgs) Handles btnWordReport.Click
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
                            Dim dPayDate As Date
                            If Date.TryParse(.get_Cell(CellPropertySettings.flexcpText, Y, 17, Y, 17), dPayDate) Then
                                If dPayDate >= ReportRangeStart.Value And dPayDate <= ReportRangeEnd.Value Then
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

                                                    currentVen.strPayPeriod = modStart.Get15thOr30thWhicheverIsCloserToToday.ToShortDateString

                                                    'currentVen.strPayPeriod = txtDate1.Text
                                                    'If txtDate2.Text.Length > 1 And txtDate1.Text <> txtDate2.Text Then
                                                    '    currentVen.strPayPeriod = currentVen.strPayPeriod & " - " & txtDate2.Text
                                                    'End If
                                                End If

                                                Dim decCostTotal As Decimal = oJob.GetPOCost(drPO)
                                                Dim decCost As Decimal = oJob.GetPOCostByCode(drPO, 5040)

                                                Dim strLine As String = drPO.sPONum & vbTab & Mid(drPO.tJob.tCustomr.sName, 1, 34) & vbTab & Mid(drPO.tJob.tAddress.sAddress1, 1, 26) & vbTab & Format(decCost, "currency")
                                                If decCost <> decCostTotal Then
                                                    MessageBox.Show(drPO.sPONum & " has a cost mismatch, not all costs are 5040")
                                                End If
                                                currentVen.listWordLines.Add(strLine)
                                                currentVen.decGrandTotal += decCost
                                            End If


                                        End If
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

    Private Sub txtDate1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate1.KeyDown
        Try
            If e.KeyCode = Keys.Tab Then
                Me.txtDate2.Focus()

            End If
        Catch
        End Try

    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        Me.lSupplierSelected = 0
        Me.bLoad1Supplier = False
        LoadReport()
    End Sub
End Class