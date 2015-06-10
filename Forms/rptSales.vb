Option Strict Off
Option Explicit On
Option Compare Text
Imports C1.Win.C1FlexGrid.Classic
Imports System.Linq
Imports System.Data.Linq

Friend Class rptSales
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
    Public WithEvents txtTo2 As System.Windows.Forms.TextBox
	Public WithEvents txtFrom2 As System.Windows.Forms.TextBox
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents txtTo As System.Windows.Forms.TextBox
	Public WithEvents txtFrom As System.Windows.Forms.TextBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents gridReport As C1FlexGridClassic
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daJob As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLine As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents btnSendToWord As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSales))
        Me.txtTo2 = New System.Windows.Forms.TextBox()
        Me.txtFrom2 = New System.Windows.Forms.TextBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.gridReport = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.daJob = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLine = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.btnSendToWord = New System.Windows.Forms.Button()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTo2
        '
        Me.txtTo2.AcceptsReturn = True
        Me.txtTo2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTo2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTo2.Location = New System.Drawing.Point(10, 276)
        Me.txtTo2.MaxLength = 0
        Me.txtTo2.Name = "txtTo2"
        Me.txtTo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTo2.Size = New System.Drawing.Size(87, 23)
        Me.txtTo2.TabIndex = 4
        '
        'txtFrom2
        '
        Me.txtFrom2.AcceptsReturn = True
        Me.txtFrom2.BackColor = System.Drawing.SystemColors.Window
        Me.txtFrom2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFrom2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFrom2.Location = New System.Drawing.Point(10, 226)
        Me.txtFrom2.MaxLength = 0
        Me.txtFrom2.Name = "txtFrom2"
        Me.txtFrom2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFrom2.Size = New System.Drawing.Size(87, 23)
        Me.txtFrom2.TabIndex = 3
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(10, 335)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(87, 29)
        Me.cmdRefresh.TabIndex = 6
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'txtTo
        '
        Me.txtTo.AcceptsReturn = True
        Me.txtTo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTo.Location = New System.Drawing.Point(10, 118)
        Me.txtTo.MaxLength = 0
        Me.txtTo.Name = "txtTo"
        Me.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTo.Size = New System.Drawing.Size(87, 23)
        Me.txtTo.TabIndex = 2
        '
        'txtFrom
        '
        Me.txtFrom.AcceptsReturn = True
        Me.txtFrom.BackColor = System.Drawing.SystemColors.Window
        Me.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFrom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFrom.Location = New System.Drawing.Point(10, 69)
        Me.txtFrom.MaxLength = 0
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFrom.Size = New System.Drawing.Size(87, 23)
        Me.txtFrom.TabIndex = 1
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(10, 551)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(87, 30)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'gridReport
        '
        Me.gridReport.ColumnInfo = "10,0,0,0,0,110,Columns:"
        Me.gridReport.FixedCols = 0
        Me.gridReport.FixedRows = 0
        Me.gridReport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridReport.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridReport.Location = New System.Drawing.Point(106, 10)
        Me.gridReport.Name = "gridReport"
        Me.gridReport.NodeClosedPicture = Nothing
        Me.gridReport.NodeOpenPicture = Nothing
        Me.gridReport.OutlineCol = -1
        Me.gridReport.Size = New System.Drawing.Size(907, 769)
        Me.gridReport.StyleInfo = resources.GetString("gridReport.StyleInfo")
        Me.gridReport.TabIndex = 0
        Me.gridReport.TreeColor = System.Drawing.Color.DarkGray
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(10, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date To:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(10, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date From:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date From:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(10, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(87, 129)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "MONTH"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(10, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(87, 129)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "WEEK"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.sqlConn.ConnectionString = "workstation id=TZ250;packet size=4096;user id=tksidatauser;data source=DELL-SERVE" & _
    "R;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'daJob
        '
        Me.daJob.SelectCommand = Me.SqlSelectCommand1
        Me.daJob.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datefrom", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@dateto", System.Data.SqlDbType.DateTime, 4, "dJobCreated")})
        '
        'daPOHeader
        '
        Me.daPOHeader.SelectCommand = Me.SqlSelectCommand2
        Me.daPOHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datefrom", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@dateto", System.Data.SqlDbType.DateTime, 4, "dJobCreated")})
        '
        'daPOLine
        '
        Me.daPOLine.SelectCommand = Me.SqlSelectCommand3
        Me.daPOLine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datefrom", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@dateto", System.Data.SqlDbType.DateTime, 4, "dJobCreated")})
        '
        'btnSendToWord
        '
        Me.btnSendToWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSendToWord.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSendToWord.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendToWord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSendToWord.Location = New System.Drawing.Point(10, 599)
        Me.btnSendToWord.Name = "btnSendToWord"
        Me.btnSendToWord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSendToWord.Size = New System.Drawing.Size(87, 45)
        Me.btnSendToWord.TabIndex = 13
        Me.btnSendToWord.Text = "Send To Word"
        Me.btnSendToWord.UseVisualStyleBackColor = False
        '
        'rptSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1040, 733)
        Me.Controls.Add(Me.btnSendToWord)
        Me.Controls.Add(Me.txtTo2)
        Me.Controls.Add(Me.txtFrom2)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.gridReport)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptSales"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Weekly Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private bLoading As Boolean
    Private dGridDate As Date

    Private dDateFrom, dDAteto As Date
    Private dDateFrom2, dDateTo2 As Date

    Private bChanges As Boolean
    Private discount As Single

    Private oJob As New JobObj

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        gridReport.PrintGrid("", True, 0, 20, 20)
    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        gridClicks()
    End Sub

    Private Sub rptSales_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim bLoad1Supplier As Object
        bChanges = False
        bLoad1Supplier = False
        bLoading = True
    End Sub

    Private Sub LoadReport()
        If Not bLoading Then gridReportALL()
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
            ' Dim frmPO1 As frmPOnet
            If POID > 0 Then
                OpenPOScreen(drPO.nID, True)
            End If
        End If
    End Sub

    Private Sub gridClicks()
        If IsDate2(txtFrom.Text) And IsDate2(txtTo.Text) Then
            dDateFrom = CDate(txtFrom.Text)
            dDAteto = CDate(txtTo.Text)
            If IsDate2(txtFrom2.Text) And IsDate2(txtTo2.Text) Then
                dDateFrom2 = CDate(txtFrom2.Text)
                dDateTo2 = CDate(txtTo2.Text)
            End If
            gridReportALL()
        End If
    End Sub

    Private Function GetSalesPersonJobCostTotal(ByVal salesperson As String) As Decimal
        Try
            Dim drJob As dsTKSI.tJobRow
            Dim drPO As dsTKSI.tPOHeaderRow
            Dim drPOLine As dsTKSI.tPOLineRow

            Dim totalJobcost As Decimal = 0
            For Each drJob In Me.DsTKSI1.tJob
                If UCase(drJob.sSalesperson.Trim) = UCase(salesperson.Trim) Then
                    For Each drPO In drJob.GettPOHeaderRows
                        If drPO.sPOType.Trim = "Jobcost" Or drPO.sPOType.Trim = "SWO-Jobcost" Then
                            For Each drPOLine In drPO.GettPOLineRows
                                totalJobcost += drPOLine.nCost
                            Next
                        End If
                    Next
                End If
            Next

            Return totalJobcost
        Catch ex As Exception
            Return -1
        End Try

    End Function

    Private Sub gridReportALL()
        Try
            Dim grandtotalmonth As Decimal
            Dim monthsales As Decimal
            Dim strSQLmonth As Object
            Dim strSQL As Object

            gridReport.Redraw = False
            Dim x As Integer
            Dim Sales As Decimal

            Dim grandtotal As Decimal

            Me.DsTKSI1.tJob.Clear()
            Me.daJob.SelectCommand.Parameters("@datefrom").Value = dDateFrom
            Me.daJob.SelectCommand.Parameters("@dateto").Value = dDAteto
            Me.daJob.Fill(Me.DsTKSI1.tJob)

            Me.DsTKSI1.tPOHeader.Clear()
            Me.daPOHeader.SelectCommand.Parameters("@datefrom").Value = dDateFrom
            Me.daPOHeader.SelectCommand.Parameters("@dateto").Value = dDAteto
            Me.daPOHeader.Fill(Me.DsTKSI1.tPOHeader)

            Me.DsTKSI1.tPOLine.Clear()
            Me.daPOLine.SelectCommand.Parameters("@datefrom").Value = dDateFrom
            Me.daPOLine.SelectCommand.Parameters("@dateto").Value = dDAteto
            Me.daPOLine.Fill(Me.DsTKSI1.tPOLine)

            With gridReport
                .Cols = 7
                .Rows = 0
                .Rows = 24
                .GridLines = GridStyleSettings.flexGridNone

               .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 2, "Weekly Sales")
               .set_Cell(CellPropertySettings.flexcpText, 1, 3, 1, 5, "Dates : " & dDateFrom & "   -  To:   " & dDAteto)

                .set_ColWidth(0, 100 / global_OldGridNewGridRation)
                .set_ColWidth(1, 2200 / global_OldGridNewGridRation)
                .set_ColWidth(2, 100 / global_OldGridNewGridRation)
                .set_ColWidth(3, 2200 / global_OldGridNewGridRation)
                .set_ColWidth(4, 100 / global_OldGridNewGridRation)
                .set_ColWidth(5, 2200 / global_OldGridNewGridRation)
                .set_ColWidth(6, 2200 / global_OldGridNewGridRation)

                .set_RowHeight(0, 5)
                .set_RowHeight(3, 15)
                .set_RowHeight(2, 15)

                .set_ColHidden(0, False)
                .set_ColHidden(1, False)
                .set_ColHidden(2, False)
                .set_ColHidden(3, False)
                .set_ColHidden(4, False)
                .set_ColHidden(5, False)
                .set_ColHidden(6, False)

                .MergeCells = MergeSettings.flexMergeFree
                .set_MergeRow(0, True)
                .set_MergeRow(1, True)
                .set_MergeRow(2, True)
                .set_MergeRow(3, True)

                .set_TextMatrix(4, 1, "Salesperson")
                .set_TextMatrix(4, 2, "")
                .set_TextMatrix(4, 3, "Weekly Sales")
                .set_TextMatrix(4, 4, "")
                .set_TextMatrix(4, 5, "Month to Date")

                .FrozenRows = 5

                PopulateSalesNames()

                Dim dc As linqTKSIDataContext = GetLinqDataContext()

                'get selected weeks sales that are marked as PO (not SWO warranty etc.)
                For x = 5 To .Rows - 1
                    If Len(.get_TextMatrix(x, 1)) > 0 Then
                        Dim sSalestemp As String = .get_TextMatrix(x, 1)
                       Sales = 0
                        monthsales = 0
                        Dim q = (From row In dc.tPOHeaders Where row.tJob.sSalesperson.ToUpper = sSalestemp.ToUpper And row.dPODate >= dDateFrom And row.dPODate <= dDAteto Select row.nRetailSale, row.nAdd, row.nsalesadjust)
                        If q.Count > 0 Then
                            Dim decRetailSale As Decimal = q.Sum(Function(v) v.nRetailSale)
                            Dim decRetailAdd As Decimal = q.Sum(Function(v) v.nAdd)
                            Dim decRetailAdjust As Decimal = q.Sum(Function(v) v.nsalesadjust)
                            Sales = Sales + decRetailSale
                            Sales = Sales + decRetailAdd
                            Sales = Sales + decRetailAdjust
                            .set_Cell(CellPropertySettings.flexcpFontBold, x, 3, x, 3, True)
                            grandtotal = grandtotal + Sales
                        End If
                        .set_TextMatrix(x, 3, TwoDecimal(Sales & ""))
                        .set_Cell(CellPropertySettings.flexcpAlignment, x, 3, x, 3, AlignmentSettings.flexAlignLeftCenter)

                        Dim qMonth = (From row In dc.tPOHeaders Where row.tJob.sSalesperson.ToUpper = (sSalestemp.ToUpper) And row.dPODate >= dDateFrom2 And row.dPODate <= dDateTo2 Select row.nRetailSale, row.nAdd, row.nsalesadjust)
                        If qMonth.Count > 0 Then
                            Dim decRetailSaleMonth As Decimal = qMonth.Sum(Function(v) v.nRetailSale)
                            Dim decRetailAddMonth As Decimal = qMonth.Sum(Function(v) v.nAdd)
                            Dim decRetailAdjustMonth As Decimal = qMonth.Sum(Function(v) v.nsalesadjust)
                            monthsales = monthsales + decRetailSaleMonth
                            monthsales = monthsales + decRetailAddMonth
                            monthsales = monthsales + decRetailAdjustMonth
                            .set_Cell(CellPropertySettings.flexcpFontBold, x, 3, x, 3, True)
                            grandtotalmonth = (grandtotalmonth + monthsales)
                        End If
                        .set_TextMatrix(x, 5, TwoDecimal(monthsales & ""))
                        .set_Cell(CellPropertySettings.flexcpAlignment, x, 5, x, 5, AlignmentSettings.flexAlignLeftCenter)
                    End If
                Next
                .set_MergeRow(x - 1, True)
                .Select(x - 1, 0, x - 1, 5)

                .set_TextMatrix(x - 1, 1, "Grand Total:")
                .set_TextMatrix(x - 1, 3, TwoDecimal(grandtotal & ""))
                .set_TextMatrix(x - 1, 5, TwoDecimal(grandtotalmonth & ""))
                .set_Cell(CellPropertySettings.flexcpAlignment, x - 1, 3, x - 1, 3, AlignmentSettings.flexAlignLeftCenter)
                .set_Cell(CellPropertySettings.flexcpAlignment, x - 1, 5, x - 1, 5, AlignmentSettings.flexAlignLeftCenter)
                .Redraw = True
            End With
            bLoading = False
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub PopulateSalesNames()

        Dim x As Integer
        x = 6
        Dim dc As linqTKSIDataContext = GetLinqDataContext()

        Dim q = (From row In dc.tEmployees Where row.archive = False Order By row.sequence)
        For Each emp In q
            If emp.nickname IsNot Nothing Then
                With Me.gridReport
                    .Rows = x + 2

                    Dim JobCostTotal As Decimal
                    Try
                        JobCostTotal = GetSalesPersonJobCostTotal(emp.nickname)
                    Catch ex As Exception
                        JobCostTotal = -1
                    End Try

                    .set_TextMatrix(x, 1, emp.nickname)
                    .set_TextMatrix(x, 6, "(" & Format(JobCostTotal, "currency") & ")")
                End With
                x = x + 2
            End If
        Next
      
    End Sub

    Private Sub gridreport_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles gridReport.MouseDown
        With gridReport
            ' eventArgs.Y = .MouseRow
            ' eventArgs.X = .MouseCol
            If .MouseRow > 0 Then
                If .MouseCol = 1 Then
                    If Len(.get_TextMatrix(.MouseRow, .MouseCol)) > 1 Then
                        ShowSalesDetail(.get_TextMatrix(.MouseRow, .MouseCol))
                    End If
                End If
                If .MouseCol = 3 Then
                    'ManualAdjust .TextMatrix(Y, X), .TextMatrix(Y, 1)  'salestotal and salesperson
                End If
            End If
        End With
    End Sub

    Private Sub ShowSalesDetail(Salesperson As String)
        ' Dim strSQL As String
        Dim dc As linqTKSIDataContext = GetLinqDataContext()

        '   strSQL = "select tpoheader.nid,sponum,nretailsale,nadd,dpodate,nsalesadjust,sadjustreason " & "FROM tPOheader " & "INNER JOIN tJob " & "ON tPOheader.njobid=tjob.nid " & "WHERE tpoheader.dpodate >='" & dDateFrom & "' AND tpoheader.dpodate <= '" & dDAteto & "' " & " " & "AND sSalesperson like '" & Salesperson & "'"

        Dim q = (From row In dc.tPOHeaders Where row.tJob.sSalesperson.ToUpper = Salesperson.ToUpper And row.dPODate >= dDateFrom And row.dPODate <= dDAteto Select row.nID, row.sPONum, row.nRetailSale, row.nAdd, row.dPODate, row.nsalesadjust, row.sAdjustReason)


        Dim frmDetail As New SalesDetail
        If q.Count > 0 Then
            For Each po1 In q
                'title
                frmDetail.lblSales.Text = "Sales Detail for " & Salesperson
                frmDetail.gridDetail.set_TextMatrix(0, 1, "PO Number")
                frmDetail.gridDetail.set_TextMatrix(0, 2, "Sale$")
                frmDetail.gridDetail.set_TextMatrix(0, 3, "Add$")
                frmDetail.gridDetail.set_TextMatrix(0, 4, "Date")
                frmDetail.gridDetail.set_TextMatrix(0, 5, "Adjustment")
                frmDetail.gridDetail.set_TextMatrix(0, 6, "Reason")
                Try
                    frmDetail.gridDetail.AddItem(po1.nID & vbTab & po1.sPONum & "" & vbTab & TwoDecimal(po1.nRetailSale) & vbTab & TwoDecimal(po1.nAdd) & vbTab & po1.dPODate & vbTab & TwoDecimal(po1.nsalesadjust) & vbTab & po1.sAdjustReason & "")
                Catch ex As Exception
                    frmDetail.gridDetail.AddItem(po1.nID & vbTab & "" & vbTab & "")
                End Try
            Next

            frmDetail.ShowDialog()

        Else
            MessageBox.Show("No POs to show for: " & Salesperson)
        End If



    End Sub

    Private Sub txtFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrom.TextChanged
        If txtFrom.Text.Length > 5 Then
            If IsDate2(Me.txtFrom.Text) Then
                Me.txtTo.Text = DateAdd(DateInterval.Day, 4, CDate(Me.txtFrom.Text))
                Me.txtFrom2.Text = DatePart(DateInterval.Month, CDate(Me.txtFrom.Text)) & "/1/" & DatePart(DateInterval.Year, CDate(Me.txtFrom.Text))

            End If
        End If

    End Sub

    Private Sub txtFrom2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrom2.TextChanged
        If txtFrom2.Text.Length > 5 Then
            If IsDate2(Me.txtFrom2.Text) Then
                Me.txtTo2.Text = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, CDate(Me.txtFrom2.Text)))
            End If
        End If

    End Sub

    Private Function BuildLetterInWordpad()

        Dim sw As IO.StreamWriter
        Try
            Dim strTempFile As String = IO.Path.GetTempFileName
            sw = New IO.StreamWriter(strTempFile, True)
            sw.WriteLine("")
            Dim strLetter As String = ""

            Try
                Dim grandtotalmonth As Decimal = 0
                Dim monthsales As Decimal = 0
                Dim strSQLmonth As Object
                Dim strSQL As Object

                Dim Sales As Object

                Dim grandtotal As Decimal = 0

                Me.DsTKSI1.tJob.Clear()
                Me.daJob.SelectCommand.Parameters("@datefrom").Value = dDateFrom
                Me.daJob.SelectCommand.Parameters("@dateto").Value = dDAteto
                Me.daJob.Fill(Me.DsTKSI1.tJob)

                Me.DsTKSI1.tPOHeader.Clear()
                Me.daPOHeader.SelectCommand.Parameters("@datefrom").Value = dDateFrom
                Me.daPOHeader.SelectCommand.Parameters("@dateto").Value = dDAteto
                Me.daPOHeader.Fill(Me.DsTKSI1.tPOHeader)

                Me.DsTKSI1.tPOLine.Clear()
                Me.daPOLine.SelectCommand.Parameters("@datefrom").Value = dDateFrom
                Me.daPOLine.SelectCommand.Parameters("@dateto").Value = dDAteto
                Me.daPOLine.Fill(Me.DsTKSI1.tPOLine)

                sw.WriteLine("Weekly Sales" & vbTab & "Dates " & dDateFrom & " to " & dDAteto)
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("Salesperson" & vbTab & "Weekly Sales" & vbTab & "Month to Date")
                sw.WriteLine("-----------------------------------------------------------")
                sw.WriteLine("")
                sw.Flush()

                Dim dc As linqTKSIDataContext = GetLinqDataContext()
                Dim qsales = (From row In dc.tEmployees Where row.archive = False Order By row.sequence)
                For Each salesper In qsales
                    Dim strSalesper As String = salesper.nickname
                    Dim JobCostTotal As Decimal
                    Try
                        JobCostTotal = GetSalesPersonJobCostTotal(strSalesper)
                    Catch ex As Exception
                        JobCostTotal = -1
                    End Try
                    Sales = 0
                    monthsales = 0

                    Dim strLine As String = ""
                    Sales = 0
                            monthsales = 0
                    Dim q = (From row In dc.tPOHeaders Where row.tJob.sSalesperson.ToUpper = strSalesper.ToUpper And row.dPODate >= dDateFrom And row.dPODate <= dDAteto Select row.nRetailSale, row.nAdd, row.nsalesadjust)
                            If q.Count > 0 Then
                                Dim decRetailSale As Decimal = q.Sum(Function(v) v.nRetailSale)
                                Dim decRetailAdd As Decimal = q.Sum(Function(v) v.nAdd)
                                Dim decRetailAdjust As Decimal = q.Sum(Function(v) v.nsalesadjust)
                                Sales = Sales + decRetailSale
                                Sales = Sales + decRetailAdd
                                Sales = Sales + decRetailAdjust
                                grandtotal = grandtotal + Sales
                            End If

                    Dim qMonth = (From row In dc.tPOHeaders Where row.tJob.sSalesperson.ToUpper = (strSalesper.ToUpper) And row.dPODate >= dDateFrom2 And row.dPODate <= dDateTo2 Select row.nRetailSale, row.nAdd, row.nsalesadjust)
                            If qMonth.Count > 0 Then
                                Dim decRetailSaleMonth As Decimal = qMonth.Sum(Function(v) v.nRetailSale)
                                Dim decRetailAddMonth As Decimal = qMonth.Sum(Function(v) v.nAdd)
                                Dim decRetailAdjustMonth As Decimal = qMonth.Sum(Function(v) v.nsalesadjust)
                                monthsales = monthsales + decRetailSaleMonth
                                monthsales = monthsales + decRetailAddMonth
                                monthsales = monthsales + decRetailAdjustMonth
                                grandtotalmonth = (grandtotalmonth + monthsales)
                            End If

                    Try
                        strLine = String.Concat(strSalesper.PadRight(12, " "), vbTab, Format(Sales.ToString, "currency").PadRight(12, " "), vbTab, Format(monthsales.ToString, "currency").PadRight(12, " "), vbTab, ("(" & JobCostTotal.ToString & ")").PadRight(12, " "))

                        sw.WriteLine(strLine)
                    Catch ex As Exception

                    End Try

                Next
           
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("Grand Total: " & vbTab & Format(grandtotal, "currency").ToString.PadRight(12, " ") & vbTab & Format(grandtotalmonth, "currency").ToString.PadRight(12, " "))
    
            Catch ex As Exception
                Windows.Forms.MessageBox.Show(ex.Message)
            End Try
          
            sw.Flush()
            sw.Close()
            Dim value As ProcessStartInfo
            value = New ProcessStartInfo("wordpad.exe", strTempFile)
            Process.Start(value)
        Catch ex As Exception
            MessageBox.Show("error building wordpad document: " & ex.Message)
        Finally
            Try
                sw.Close()
            Catch
            End Try
        End Try

    End Function

    Private Sub btnSendToWord_Click(sender As Object, e As EventArgs) Handles btnSendToWord.Click
        BuildLetterInWordpad()
    End Sub
End Class