Option Strict Off
Option Explicit On
Option Compare Text

Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports System.Drawing

Friend Class rptARWeeklySheet
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
    Public WithEvents txtTo As System.Windows.Forms.TextBox
    Public WithEvents txtFrom As System.Windows.Forms.TextBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvSales As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvReport As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSODateFromDateTo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineDateFromDateTo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCust As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPODateToDateFrom As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineDateToDateFrom As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddress As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobByDateFromDateTo As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents btnPrintAP As System.Windows.Forms.Button
    Public WithEvents btnPrintAll As System.Windows.Forms.Button
    Friend WithEvents lvAPSheet As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Public WithEvents btnShowAP As System.Windows.Forms.Button
    Public WithEvents btnShowAR As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendor As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DsTKSI1 = New dsTKSI
        Me.Label3 = New System.Windows.Forms.Label
        Me.lvSales = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lvReport = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConn = New System.Data.SqlClient.SqlConnection
        Me.daJobByDateFromDateTo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daSODateFromDateTo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daSOLineDateFromDateTo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.daCust = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.daPODateToDateFrom = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.daPOLineDateToDateFrom = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.daAddress = New System.Data.SqlClient.SqlDataAdapter
        Me.btnPrintAP = New System.Windows.Forms.Button
        Me.btnPrintAll = New System.Windows.Forms.Button
        Me.lvAPSheet = New System.Windows.Forms.ListView
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader31 = New System.Windows.Forms.ColumnHeader
        Me.btnShowAP = New System.Windows.Forms.Button
        Me.btnShowAR = New System.Windows.Forms.Button
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.daVendor = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTo
        '
        Me.txtTo.AcceptsReturn = True
        Me.txtTo.AutoSize = False
        Me.txtTo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTo.Location = New System.Drawing.Point(0, 96)
        Me.txtTo.MaxLength = 0
        Me.txtTo.Name = "txtTo"
        Me.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTo.Size = New System.Drawing.Size(73, 19)
        Me.txtTo.TabIndex = 2
        Me.txtTo.Text = ""
        '
        'txtFrom
        '
        Me.txtFrom.AcceptsReturn = True
        Me.txtFrom.AutoSize = False
        Me.txtFrom.BackColor = System.Drawing.SystemColors.Window
        Me.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFrom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFrom.Location = New System.Drawing.Point(0, 56)
        Me.txtFrom.MaxLength = 0
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFrom.Size = New System.Drawing.Size(73, 19)
        Me.txtFrom.TabIndex = 1
        Me.txtFrom.Text = ""
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(0, 552)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(80, 25)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "PRINT AR"
        Me.cmdPrint.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(0, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date From:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(0, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 105)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "WEEK"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Salesperson:"
        '
        'lvSales
        '
        Me.lvSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvSales.FullRowSelect = True
        Me.lvSales.GridLines = True
        Me.lvSales.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvSales.HideSelection = False
        Me.lvSales.Location = New System.Drawing.Point(0, 160)
        Me.lvSales.MultiSelect = False
        Me.lvSales.Name = "lvSales"
        Me.lvSales.Size = New System.Drawing.Size(80, 272)
        Me.lvSales.TabIndex = 15
        Me.lvSales.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 70
        '
        'lvReport
        '
        Me.lvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lvReport.FullRowSelect = True
        Me.lvReport.GridLines = True
        Me.lvReport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvReport.HideSelection = False
        Me.lvReport.Location = New System.Drawing.Point(88, 8)
        Me.lvReport.Name = "lvReport"
        Me.lvReport.Size = New System.Drawing.Size(940, 677)
        Me.lvReport.TabIndex = 16
        Me.lvReport.View = System.Windows.Forms.View.Details
        Me.lvReport.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "JOB #"
        Me.ColumnHeader3.Width = 53
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Builder / Customer"
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "4010 Cab"
        Me.ColumnHeader5.Width = 63
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "4020 Tops"
        Me.ColumnHeader6.Width = 63
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "4030 Hrdwr"
        Me.ColumnHeader7.Width = 63
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "4040 Inst"
        Me.ColumnHeader8.Width = 63
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "4070 Frt"
        Me.ColumnHeader9.Width = 63
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "% Tax"
        Me.ColumnHeader10.Width = 63
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "$ TAX"
        Me.ColumnHeader11.Width = 63
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "CITY/COUNTY"
        Me.ColumnHeader12.Width = 63
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PERMIT"
        Me.ColumnHeader13.Width = 63
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "P.O.#"
        Me.ColumnHeader14.Width = 80
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "TOTALS"
        Me.ColumnHeader15.Width = 90
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT dbo.tJob.nID, dbo.tJob.nAddressID, dbo.tJob.sJobDesc, dbo.tJob.dC" & _
        "reated, dbo.tJob.dJobCreated, dbo.tJob.sJobNo, dbo.tJob.nCustID, dbo.tJob.sPhone" & _
        ", dbo.tJob.sJobContact, dbo.tJob.sCounty, dbo.tJob.nTotalWholesale, dbo.tJob.sBu" & _
        "ildingPermit, dbo.tJob.sTerms, dbo.tJob.dDrawing, dbo.tJob.nMaterialsCharge, dbo" & _
        ".tJob.nTaxRate, dbo.tJob.nLaborCharge, dbo.tJob.sContractSigned, dbo.tJob.sDiscl" & _
        "aimerSigned, dbo.tJob.sDrawingsSigned, dbo.tJob.sComplete, dbo.tJob.sSalesperson" & _
        ", dbo.tJob.sOtherNotes, dbo.tJob.dCommPaid, dbo.tJob.sCommLocked, dbo.tJob.dCrLi" & _
        "mit, dbo.tJob.dAmtYTD, dbo.tJob.sInvNotes, dbo.tJob.lngCommissionStruct, dbo.tEm" & _
        "ployee.sequence FROM dbo.tJob INNER JOIN dbo.tPOHeader ON dbo.tJob.nID = dbo.tPO" & _
        "Header.nJobID INNER JOIN dbo.tEmployee ON dbo.tJob.sSalesperson = dbo.tEmployee." & _
        "nickname WHERE (dbo.tPOHeader.dPODate <= @dateTo) AND (dbo.tPOHeader.dPODate >= " & _
        "@dateFrom) ORDER BY dbo.tEmployee.sequence, dbo.tJob.nID"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateTo", System.Data.SqlDbType.DateTime, 4, "dPODate"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateFrom", System.Data.SqlDbType.DateTime, 4, "dPODate"))
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERVER;per" & _
        "sist security info=True;initial catalog=TKSIJOBS;password=tksi"
        '
        'daJobByDateFromDateTo
        '
        Me.daJobByDateFromDateTo.SelectCommand = Me.SqlSelectCommand1
        Me.daJobByDateFromDateTo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT tSOHeader.nID, tSOHeader.sSONum, tSOHeader.nCustID, tSOHeader.nJobID, tSOH" & _
        "eader.sName, tSOHeader.sFOB, tSOHeader.dShipped, tSOHeader.sVIA, tSOHeader.sShip" & _
        "To1, tSOHeader.sShipTo2, tSOHeader.sShipToCity, tSOHeader.sShipToState, tSOHeade" & _
        "r.sShipToZip, tSOHeader.sShipToCounty, tSOHeader.sTerms, tSOHeader.nTaxRate, tSO" & _
        "Header.dinvoice, tSOHeader.dsimply, tSOHeader.dmailed, tSOHeader.nTotal, tSOHead" & _
        "er.sOurOrder, tSOHeader.sYourOrder, tSOHeader.nSimplySequence FROM tSOHeader INN" & _
        "ER JOIN tJob ON tSOHeader.nJobID = tJob.nID WHERE (tJob.dJobCreated <= @dateTo) " & _
        "AND (tJob.dJobCreated >= @dateFrom)"
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateTo", System.Data.SqlDbType.DateTime, 4, "dJobCreated"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateFrom", System.Data.SqlDbType.DateTime, 4, "dJobCreated"))
        '
        'daSODateFromDateTo
        '
        Me.daSODateFromDateTo.SelectCommand = Me.SqlSelectCommand2
        Me.daSODateFromDateTo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT tSOLine.nSOID, tSOLine.nLineNumber, tSOLine.sDesc, tSOLine.bTaxable, tSOLi" & _
        "ne.sType, tSOLine.sHidden, tSOLine.nAmount, tSOLine.nAccountID FROM tSOLine INNE" & _
        "R JOIN tSOHeader ON tSOLine.nSOID = tSOHeader.nID INNER JOIN tJob ON tSOHeader.n" & _
        "JobID = tJob.nID WHERE (tJob.dJobCreated <= @dateTo) AND (tJob.dJobCreated >= @d" & _
        "ateFrom)"
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateTo", System.Data.SqlDbType.DateTime, 4, "dJobCreated"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateFrom", System.Data.SqlDbType.DateTime, 4, "dJobCreated"))
        '
        'daSOLineDateFromDateTo
        '
        Me.daSOLineDateFromDateTo.SelectCommand = Me.SqlSelectCommand3
        Me.daSOLineDateFromDateTo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT lID, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
        "Phone1, sPhone2, sFax, dCrLimit, dAmtYTD FROM tCustomr"
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        '
        'daCust
        '
        Me.daCust.SelectCommand = Me.SqlSelectCommand4
        Me.daCust.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT sName, Address, CityStateZip, Phone, SS, Claims, Status, Insurance, nickna" & _
        "me, sequence, archive, email FROM dbo.tEmployee ORDER BY sequence"
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        '
        'daEmployee
        '
        Me.daEmployee.SelectCommand = Me.SqlSelectCommand5
        Me.daEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tEmployee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("CityStateZip", "CityStateZip"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("SS", "SS"), New System.Data.Common.DataColumnMapping("Claims", "Claims"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Insurance", "Insurance"), New System.Data.Common.DataColumnMapping("nickname", "nickname"), New System.Data.Common.DataColumnMapping("sequence", "sequence"), New System.Data.Common.DataColumnMapping("archive", "archive"), New System.Data.Common.DataColumnMapping("email", "email")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT nID, nJobID, dCreateRecord, nVendorID, sPONum, sShipTo1, sShipTo2, sShipto" & _
        "3, sShipToCity, sShipToState, sShipToZip, sShiptoCounty, nBoxes, dPODate, sTerms" & _
        ", dRequired, sEnteredBy, nTotal, sVia, sFOB, nRetailSale, nSaleAccount, nRetailF" & _
        "reight, sConf, nAdd, DREC, DDEL, SRECNOTES, SDELNOTES, DFAXED, nAccount, nInvNo," & _
        " nCheckNo, dSimply, bSimply, nTruck, sFilter, sBackOrder, sItems, sItemDesc, sPO" & _
        "Type, nsalesadjust, sAdjustReason, sCurActNote, nPOSort FROM dbo.tPOHeader WHERE" & _
        " (dPODate <= @dateTo) AND (dPODate >= @dateFrom) ORDER BY nJobID, nPOSort"
        Me.SqlSelectCommand6.Connection = Me.sqlConn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateTo", System.Data.SqlDbType.DateTime, 4, "dPODate"))
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateFrom", System.Data.SqlDbType.DateTime, 4, "dPODate"))
        '
        'daPODateToDateFrom
        '
        Me.daPODateToDateFrom.SelectCommand = Me.SqlSelectCommand6
        Me.daPODateToDateFrom.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT dbo.tPOLine.nPOID, dbo.tPOLine.nLineNumber, dbo.tPOLine.sType, dbo.tPOLine" & _
        ".sDesc, dbo.tPOLine.nCost, dbo.tPOLine.nAccountID, dbo.tPOLine.sReceived FROM db" & _
        "o.tPOLine INNER JOIN dbo.tPOHeader ON dbo.tPOLine.nPOID = dbo.tPOHeader.nID WHER" & _
        "E (dbo.tPOHeader.dPODate <= @dateTo) AND (dbo.tPOHeader.dPODate >= @dateFrom) OR" & _
        "DER BY dbo.tPOLine.nPOID, dbo.tPOLine.nLineNumber"
        Me.SqlSelectCommand7.Connection = Me.sqlConn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateTo", System.Data.SqlDbType.DateTime, 4, "dPODate"))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dateFrom", System.Data.SqlDbType.DateTime, 4, "dPODate"))
        '
        'daPOLineDateToDateFrom
        '
        Me.daPOLineDateToDateFrom.SelectCommand = Me.SqlSelectCommand7
        Me.daPOLineDateToDateFrom.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT nID, sAddress1, sAddress2, sCity, sState, sCounty, sZip, sLocCode FROM tAd" & _
        "dress"
        Me.SqlSelectCommand8.Connection = Me.sqlConn
        '
        'daAddress
        '
        Me.daAddress.SelectCommand = Me.SqlSelectCommand8
        Me.daAddress.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'btnPrintAP
        '
        Me.btnPrintAP.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.btnPrintAP.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrintAP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintAP.Location = New System.Drawing.Point(0, 584)
        Me.btnPrintAP.Name = "btnPrintAP"
        Me.btnPrintAP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrintAP.Size = New System.Drawing.Size(80, 25)
        Me.btnPrintAP.TabIndex = 17
        Me.btnPrintAP.Text = "PRINT AP"
        Me.btnPrintAP.Visible = False
        '
        'btnPrintAll
        '
        Me.btnPrintAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrintAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrintAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintAll.Location = New System.Drawing.Point(0, 616)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrintAll.Size = New System.Drawing.Size(80, 25)
        Me.btnPrintAll.TabIndex = 18
        Me.btnPrintAll.Text = "PRINT ALL"
        '
        'lvAPSheet
        '
        Me.lvAPSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAPSheet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31})
        Me.lvAPSheet.FullRowSelect = True
        Me.lvAPSheet.GridLines = True
        Me.lvAPSheet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAPSheet.HideSelection = False
        Me.lvAPSheet.Location = New System.Drawing.Point(80, 16)
        Me.lvAPSheet.Name = "lvAPSheet"
        Me.lvAPSheet.Size = New System.Drawing.Size(940, 677)
        Me.lvAPSheet.TabIndex = 19
        Me.lvAPSheet.View = System.Windows.Forms.View.Details
        Me.lvAPSheet.Visible = False
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "PO #"
        Me.ColumnHeader17.Width = 56
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "CABS/Misc"
        Me.ColumnHeader18.Width = 80
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "5260.Dis"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "5270.Smp"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "5010.Cab"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "4700.Dsc"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "5020.Ctop"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "5030.Hrd"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "5040.Inst"
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "5070.Frt"
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Factor"
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Dlvry"
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Supplier"
        Me.ColumnHeader29.Width = 80
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Job Desc"
        Me.ColumnHeader30.Width = 70
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Commission"
        Me.ColumnHeader31.Width = 70
        '
        'btnShowAP
        '
        Me.btnShowAP.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.btnShowAP.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowAP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowAP.Location = New System.Drawing.Point(0, 472)
        Me.btnShowAP.Name = "btnShowAP"
        Me.btnShowAP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowAP.Size = New System.Drawing.Size(80, 25)
        Me.btnShowAP.TabIndex = 21
        Me.btnShowAP.Text = "Show AP"
        '
        'btnShowAR
        '
        Me.btnShowAR.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.btnShowAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowAR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowAR.Location = New System.Drawing.Point(0, 440)
        Me.btnShowAR.Name = "btnShowAR"
        Me.btnShowAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowAR.Size = New System.Drawing.Size(80, 25)
        Me.btnShowAR.TabIndex = 20
        Me.btnShowAR.Text = "Show AR"
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
        "Phone1, sPhone2, sFax FROM dbo.tVendor"
        Me.SqlSelectCommand9.Connection = Me.sqlConn
        '
        'daVendor
        '
        Me.daVendor.SelectCommand = Me.SqlSelectCommand9
        Me.daVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        '
        'rptARWeeklySheet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1028, 677)
        Me.Controls.Add(Me.btnShowAP)
        Me.Controls.Add(Me.btnShowAR)
        Me.Controls.Add(Me.lvAPSheet)
        Me.Controls.Add(Me.btnPrintAll)
        Me.Controls.Add(Me.btnPrintAP)
        Me.Controls.Add(Me.lvReport)
        Me.Controls.Add(Me.lvSales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptARWeeklySheet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "AR Sheet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private bLoading As Boolean
    Private dDateFrom, dDateto As Date
    Private bChanges As Boolean
    Private oJob As New JobObj

    Private blnARReportVisible As Boolean = True
    'used to hide and show the proper report to be run

    Private alJob As ArrayList

    Private Class JobHeader
        Public sJob As String = ""
        Public sJobDesc As String = ""
        Public sJobCity As String = ""
        Public sJobCnty As String = ""
        Public sCust As String = ""
        Public sAddress As String = ""
        Public sPermit As String = ""
        Public alAPlines As New ArrayList
        Public alARlines As New ArrayList
        Public sSalesperson As String = ""
        Public sSalesTaxID As String = ""
    End Class

    Public Class lineAP
        Public sCabsDesc As String = ""
        Public s5260 As String = ""
        Public s5270 As String = ""
        Public s5010 As String = ""
        Public s4700 As String = ""
        Public s5020 As String = ""
        Public s5030 As String = ""
        Public s5040 As String = ""
        Public s5070 As String = ""
        Public sFactor As String = ""
        Public sDate As String = ""
        Public sSupplier As String = ""
        Public sJobDesc As String = ""
        Public sComm As String = ""
        Public sPO As String = "" 'additional PO number after the 4 digits of job and dash ie -16SWO
    End Class

    Public Class lineAR
        Public s4010 As String = ""
        Public s4020 As String = ""
        Public s4030 As String = ""
        Public s4040 As String = ""
        Public s4070 As String = ""
        Public sTaxPercent As String = ""
        Public sTaxDollar As String = ""
        Public scitycnty As String = ""
        Public sPO As String = ""
        Public decTotalPO As Decimal = 0
    End Class

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim oword As New Word.Application
            oword.Visible = True
            Dim odoc As Word.Document
            odoc = oword.Documents.Add
            With oword.Selection
                .Font.Size = 9
                .Font.Name = "Courier"
                .PageSetup.TopMargin = 40
                .PageSetup.BottomMargin = 40
                .PageSetup.LeftMargin = 30
                .PageSetup.RightMargin = 20
                .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape

                Dim tabLength As Double
                tabLength = 0.4
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                Dim salesper As String
                salesper = Me.lvSales.SelectedItems(0).Text

                .TypeText("WEEK OF: " & Me.dDateFrom.ToShortDateString & " - " & Me.dDateto.ToShortDateString)
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("ACCOUNTS RECEIVABLE")
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("SALES PERSON: " & UCase(salesper))
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("----------------------------------------------------------------------------------------------------------------------------")
                .TypeParagraph()
                .TypeText("JOB#" & vbTab)
                .TypeText("BUILDER/CUST" & vbTab)
                .TypeText("4010" & vbTab)
                .TypeText("4020" & vbTab)
                .TypeText("4030" & vbTab)
                .TypeText("4040" & vbTab)
                .TypeText("4070" & vbTab)
                .TypeText("% TAX" & vbTab)
                .TypeText("$ TAX" & vbTab)
                .TypeText("CITY/CNTY" & vbTab)
                .TypeText("PERMIT" & vbTab)
                .TypeText("P.O.#" & vbTab)
                .TypeText("TOTALS" & vbTab)
                .TypeParagraph()
                .TypeText("----------------------------------------------------------------------------------------------------------------------------")
                .TypeParagraph()

                Dim jobTotal As Decimal = 0

                Dim job1 As New JobHeader
                For Each job1 In Me.alJob

                    jobTotal = 0

                    .Font.Bold = True
                    .TypeText(job1.sJob & vbTab)
                    .TypeText(job1.sCust & vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(Mid(job1.sSalesTaxID, 1, 8) & vbTab)
                    .TypeText(vbTab)
                    .TypeText(job1.sJobCity & vbTab)
                    .TypeText(job1.sPermit)
                    .TypeParagraph()
                    Dim i As Long = 0
                    Dim line1 As lineAR
                    For Each line1 In job1.alARlines
                        .Font.Bold = False
                        i += 1
                        .TypeText(vbTab)
                        If i = 1 Then
                            .TypeText(job1.sAddress & vbTab)
                        Else
                            .TypeText(vbTab)
                        End If

                        .TypeText(line1.s4010 & vbTab)
                        .TypeText(line1.s4020 & vbTab)
                        .TypeText(line1.s4030 & vbTab)
                        .TypeText(line1.s4040 & vbTab)
                        .TypeText(line1.s4070 & vbTab)

                        'TAX RATE
                        .TypeText(line1.sTaxPercent & vbTab)
                        .TypeText(line1.sTaxDollar & vbTab)

                        'couldnt fit on job line so show on first po line
                        If i = 1 Then
                            .TypeText(job1.sJobCnty & vbTab)
                        Else
                            .TypeText(vbTab)
                        End If

                        .TypeText(vbTab) 'permit on job line only
                        .TypeText(line1.sPO & vbTab) 'PO # only after dash part, not job # part

                        .TypeText(line1.decTotalPO)  'PO # only after dash part, not job # part
                        .TypeParagraph()
                        jobTotal += line1.decTotalPO
                    Next

                    .Font.Bold = True
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(jobTotal)
                    .TypeParagraph()

                    .TypeText("----------------------------------------------------------------------------------------------------------------------------")
                    .TypeParagraph()

                Next
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        gridClicks()
    End Sub

    Private Sub gridClicks()
        If IsDate2(txtFrom.Text) And IsDate2(txtTo.Text) Then
            dDateFrom = CDate(txtFrom.Text)
            dDateto = CDate(txtTo.Text)
            If Me.lvSales.SelectedItems.Count > 0 Then
                If Me.blnARReportVisible Then
                    gridReportAR()
                Else
                    gridReportAP()
                End If

            End If
        End If
    End Sub

    Private Sub gridReportAP()
        Try
            GenerateARAPArray()
            Me.lvAPSheet.Items.Clear()

            With Me.lvSales
                Dim salesper As String
                salesper = Me.lvSales.SelectedItems(0).Text

                Dim lastColor As Color = Color.LightGray

                Dim jobTotal As Decimal = 0
                Dim job1 As New JobHeader
                For Each job1 In Me.alJob
                    jobTotal = 0
                    Dim item1 As ListViewItem
                    item1 = Me.lvAPSheet.Items.Add("")
                    With item1
                        .SubItems.Add(job1.sJob)
                        .SubItems.Add(job1.sJobDesc)
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .Font = New Font(.Font, FontStyle.Bold)
                        .BackColor = lastColor
                    End With

                    Dim i As Long = 0
                    Dim lineAP1 As lineAP
                    For Each lineAP1 In job1.alAPlines
                        i += 1
                        Dim item2 As ListViewItem
                        item2 = Me.lvAPSheet.Items.Add("")
                        With item2
                            .SubItems.Add(lineAP1.sPO)
                            .SubItems.Add(lineAP1.sCabsDesc)
                            .SubItems.Add(lineAP1.s5260)
                            .SubItems.Add(lineAP1.s5270)
                            .SubItems.Add(lineAP1.s5010)
                            .SubItems.Add(lineAP1.s4700)
                            .SubItems.Add(lineAP1.s5020)
                            .SubItems.Add(lineAP1.s5030)
                            .SubItems.Add(lineAP1.s5040)
                            .SubItems.Add(lineAP1.s5070)
                            .SubItems.Add(lineAP1.sFactor)
                            .SubItems.Add(lineAP1.sDate)
                            .SubItems.Add(lineAP1.sSupplier)
                            .SubItems.Add(lineAP1.sComm)
                            .BackColor = lastColor
                        End With
                    Next

                    If lastColor.ToArgb = Color.LightGray.ToArgb Then
                        lastColor = Color.White
                    Else
                        lastColor = Color.LightGray
                    End If
                Next
            End With
            bLoading = False
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GenerateARAPArray(Optional ByVal blnNoSalesFilter As Boolean = False)
        If IsDate2(txtFrom.Text) And IsDate2(txtTo.Text) Then
            dDateFrom = CDate(txtFrom.Text)
            dDateto = CDate(txtTo.Text)
        End If
        If Me.lvSales.SelectedItems.Count = 0 Then
            Me.lvSales.Items(0).Selected = True
        End If

        Me.alJob = New ArrayList

        With Me.DsTKSI1
            .tJob.Clear()
            Me.daJobByDateFromDateTo.SelectCommand.Parameters("@datefrom").Value = Me.dDateFrom
            Me.daJobByDateFromDateTo.SelectCommand.Parameters("@dateTo").Value = Me.dDateto
            Me.daJobByDateFromDateTo.Fill(.tJob)

            .tSOHeader.Clear()
            Me.daSODateFromDateTo.SelectCommand.Parameters("@datefrom").Value = Me.dDateFrom
            Me.daSODateFromDateTo.SelectCommand.Parameters("@dateTo").Value = Me.dDateto
            Me.daSODateFromDateTo.Fill(.tSOHeader)

            .tSOLine.Clear()
            Me.daSOLineDateFromDateTo.SelectCommand.Parameters("@datefrom").Value = Me.dDateFrom
            Me.daSOLineDateFromDateTo.SelectCommand.Parameters("@dateTo").Value = Me.dDateto
            Me.daSOLineDateFromDateTo.Fill(.tSOLine)

            .tPOHeader.Clear()
            Me.daPODateToDateFrom.SelectCommand.Parameters("@datefrom").Value = Me.dDateFrom
            Me.daPODateToDateFrom.SelectCommand.Parameters("@dateTo").Value = Me.dDateto
            Me.daPODateToDateFrom.Fill(.tPOHeader)

            .tPOLine.Clear()
            Me.daPOLineDateToDateFrom.SelectCommand.Parameters("@datefrom").Value = Me.dDateFrom
            Me.daPOLineDateToDateFrom.SelectCommand.Parameters("@dateTo").Value = Me.dDateto
            Me.daPOLineDateToDateFrom.Fill(.tPOLine)
        End With

        Dim drJob As dsTKSI.tJobRow
        For Each drJob In Me.DsTKSI1.tJob
            If (drJob.sSalesperson = Me.lvSales.SelectedItems(0).Text) Or blnNoSalesFilter Then
                Dim job1 As New JobHeader
                With job1
                    .sSalesperson = drJob.sSalesperson
                    .sJob = drJob.sJobNo
                    .sCust = Mid(drJob.tCustomrRow.sName, 1, 20)
                    .sJobCity = Mid(drJob.tAddressRow.sCity, 1, 8)
                    .sPermit = drJob.sBuildingPermit
                    .sAddress = Mid(drJob.tAddressRow.sAddress1, 1, 20)
                    .sJobCnty = Mid(drJob.tAddressRow.sCounty, 1, 8)

                    .sSalesTaxID = drJob.sInvNotes
                    .sSalesTaxID = Replace(.sSalesTaxID, "#", "")
                    .sSalesTaxID = Replace(UCase(.sSalesTaxID), "SALES", "")
                    .sSalesTaxID = Replace(UCase(.sSalesTaxID), "TAX", "")
                    .sSalesTaxID = Replace(UCase(.sSalesTaxID), "ID", "")
                    .sSalesTaxID = Replace(.sSalesTaxID, ":", "")
                    .sSalesTaxID = Replace(.sSalesTaxID, " ", "")
                End With

                Dim bln5DigitJob As Boolean = False

                Dim drPO As dsTKSI.tPOHeaderRow
                For Each drPO In drJob.GettPOHeaderRows

                    If IsNumeric(Mid(drPO.sPONum, 1, 5)) Then
                        bln5DigitJob = True
                    Else
                        bln5DigitJob = False
                    End If

                    Dim lineAR1 As New lineAR
                    Dim decTaxable As Decimal = 0
                    decTaxable = drPO.nRetailSale + drPO.nRetailFreight + drPO.nAdd

                    With lineAR1
                        'for totals line
                        .decTotalPO = drPO.nRetailSale + drPO.nRetailFreight + drPO.nAdd

                        If Not decTaxable = 0 Then
                            Select Case drPO.nAccount
                                Case 4010, 4210
                                    .s4010 = Decimal.Round(CDec(drPO.nRetailSale + drPO.nAdd), 2)
                                Case 4020, 4220
                                    .s4020 = (Decimal.Round(CDec(drPO.nRetailSale + drPO.nAdd), 2))
                                Case 4030, 4230
                                    .s4030 = (Decimal.Round(CDec(drPO.nRetailSale + drPO.nAdd), 2))
                                Case 4040, 4240
                                    .s4040 = (Decimal.Round(CDec(drPO.nRetailSale + drPO.nAdd), 2))
                                    decTaxable = 0
                                Case 4070, 4270
                                    'leave for freight calc
                                Case Else
                                    .s4010 = Decimal.Round(CDec(drPO.nRetailSale + drPO.nAdd), 2) & "??"
                            End Select
                        End If

                        If drPO.nRetailFreight > 0 Then
                            '4070
                            .s4070 = (Decimal.Round(CDec(drPO.nRetailFreight), 2))
                        End If

                        If decTaxable > 0 Then
                            'TAX RATE
                            'non taxable reseller customers have tax rate set to 0 already so no need to check for them
                            .sTaxPercent = (Decimal.Round(CDec(drJob.nTaxRate), 2))
                            .sTaxDollar = (Decimal.Round(CDec(drJob.nTaxRate / 100 * (decTaxable)), 2))
                            'po total add tax
                            .decTotalPO += Decimal.Round(CDec(drJob.nTaxRate / 100 * (decTaxable)), 2)
                        End If

                        If bln5DigitJob Then
                            .sPO = Mid(drPO.sPONum, 7, 12) & " " & drPO.sVia
                        Else
                            .sPO = Mid(drPO.sPONum, 6, 12) & " " & drPO.sVia
                        End If

                        'PO # only after dash part, not job # part
                    End With
                    job1.alARlines.Add(lineAR1)

                    Dim lineAP1 As New lineAP
                    With lineAP1
                        If bln5DigitJob Then
                            .sPO = (Mid(drPO.sPONum, 7, 12))
                        Else
                            .sPO = (Mid(drPO.sPONum, 6, 12))
                        End If

                        .sCabsDesc = (Mid(drPO.sItemDesc, 1, 7))
                        Dim ncost As Decimal = 0
                        ncost = oJob.GetPOCostByCode(drPO, 5260)
                        If ncost > 0 Then
                            .s5260 = (Decimal.Round(ncost, 2))
                        End If
                        ncost = oJob.GetPOCostByCode(drPO, 5270)
                        If ncost > 0 Then
                            .s5270 = Decimal.Round(ncost, 2)
                        End If

                        ncost = oJob.GetPOCostByCode(drPO, 5010) + oJob.GetPOCostByCode(drPO, 5490)
                        If ncost > 0 Then
                            .s5010 = (Decimal.Round(ncost, 2))
                        End If

                        ncost = oJob.GetPOCostByCode(drPO, 4700)
                        If ncost > 0 Then
                            .s4700 = (Decimal.Round(ncost, 2))
                        End If
                        ncost = oJob.GetPOCostByCode(drPO, 5020)
                        If ncost > 0 Then
                            .s5020 = (Decimal.Round(ncost, 2))
                        End If
                        ncost = oJob.GetPOCostByCode(drPO, 5030)
                        If ncost > 0 Then
                            .s5030 = (Decimal.Round(ncost, 2))
                        End If
                        ncost = oJob.GetPOCostByCode(drPO, 5040)
                        If ncost > 0 Then
                            .s5040 = (Decimal.Round(ncost, 2))
                        End If
                        ncost = oJob.GetPOCostByCode(drPO, 5070)
                        If ncost > 0 Then
                            .s5070 = (Decimal.Round(ncost, 2))
                        End If
                        ncost = oJob.Factor(drPO)
                        If ncost > 0 Then
                            .sFactor = (Decimal.Round(ncost, 2))
                        End If
                        If Not drPO.IsdRequiredNull Then
                            .sDate = (drPO.dRequired.Month & "/" & drPO.dRequired.Day)
                        End If
                        If Not drPO.tVendorRow Is Nothing Then
                            .sSupplier = (Mid(drPO.tVendorRow.sName, 1, 7))
                        End If
                        .sComm = (drPO.sPOType)
                    End With
                    job1.alAPlines.Add(lineAP1)

                Next
                Me.alJob.Add(job1)
            End If
        Next
    End Sub

    Private Sub gridReportAR()
        Try
            GenerateARAPArray()
            Me.lvReport.Items.Clear()

            With Me.lvSales
                Dim salesper As String
                salesper = Me.lvSales.SelectedItems(0).Text
                Dim lastColor As Color = Color.LightGray
                Dim job1 As New JobHeader
                For Each job1 In Me.alJob

                    Dim jobtotal As Decimal = 0
                    Dim item1 As ListViewItem
                    item1 = Me.lvReport.Items.Add("")
                    With item1
                        .SubItems.Add(job1.sJob)
                        .SubItems.Add(job1.sCust)
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add(job1.sSalesTaxID)
                        .SubItems.Add("")
                        .SubItems.Add(job1.sJobCity)
                        .SubItems.Add(job1.sPermit)
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .Font = New Font(.Font, FontStyle.Bold)
                        .BackColor = lastColor
                    End With

                    Dim i As Long = 0
                    Dim line1 As lineAR
                    For Each line1 In job1.alARlines
                        jobtotal += line1.decTotalPO
                        i += 1
                        Dim item2 As ListViewItem
                        item2 = Me.lvReport.Items.Add("")
                        With item2
                            .SubItems.Add("")
                            'only show address on first row after job/cust line
                            If i = 1 Then
                                .SubItems.Add(Mid(job1.sAddress, 1, 20))
                            Else
                                .SubItems.Add("")
                            End If

                            .SubItems.Add(line1.s4010)
                            .SubItems.Add(line1.s4020)
                            .SubItems.Add(line1.s4030)
                            .SubItems.Add(line1.s4040)
                            .SubItems.Add(line1.s4070)
                            .SubItems.Add(line1.sTaxPercent)
                            .SubItems.Add(line1.sTaxDollar)

                            'couldnt fit on job line so show on first po line
                            If i = 1 Then
                                .SubItems.Add(job1.sJobCnty)
                            Else
                                .SubItems.Add("")
                            End If

                            .SubItems.Add("") 'permit on job line only
                            .SubItems.Add(line1.sPO) 'PO # only after dash part, not job # part
                            .SubItems.Add(line1.decTotalPO)
                            .BackColor = lastColor
                        End With
                    Next

                    item1 = Me.lvReport.Items.Add("")
                    With item1
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add(jobtotal)
                        .BackColor = lastColor
                        .Font = New Font(.Font, FontStyle.Bold)
                    End With

                    If lastColor.ToArgb = Color.LightGray.ToArgb Then
                        lastColor = Color.White
                    Else
                        lastColor = Color.LightGray
                    End If
                    'End If

                Next
            End With
            bLoading = False
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrom.TextChanged
        If txtFrom.Text.Length > 5 Then
            If IsDate2(Me.txtFrom.Text) Then
                Dim dateEntered As Date = CDate(Me.txtFrom.Text)
                'set dateTo to end of month or end of week, whichever is sooner
                Dim endOfMonth As Date = CDate(dateEntered.Month & "/1/" & dateEntered.Year).AddMonths(1).AddDays(-1)
                Dim endOfWeek As Date = dateEntered.AddDays(DayOfWeek.Friday - dateEntered.DayOfWeek)
                If endOfMonth < endOfWeek Then
                    Me.txtTo.Text = endOfMonth.ToShortDateString
                Else
                    Me.txtTo.Text = endOfWeek.ToShortDateString
                End If
            End If
        End If
    End Sub

    Private Sub rptARWeeklySheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me.DsTKSI1
            .tCustomr.Clear()
            Me.daCust.Fill(.tCustomr)

            .tEmployee.Clear()
            Me.daEmployee.Fill(.tEmployee)

            .tAddress.Clear()
            Me.daAddress.Fill(.tAddress)
            .tVendor.Clear()
            Me.daVendor.Fill(.tVendor)

        End With

        Dim drEmp As dsTKSI.tEmployeeRow
        For Each drEmp In Me.DsTKSI1.tEmployee
            If Not drEmp.archive Then
                Dim item1 As ListViewItem
                item1 = Me.lvSales.Items.Add(drEmp.nickname)
            End If
        Next

    End Sub

    Private Sub btnShowAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAR.Click
        blnARReportVisible = True
        Me.cmdPrint.Visible = True
        Me.btnPrintAP.Visible = False
        Me.lvReport.Visible = True
        Me.lvAPSheet.Visible = False
        Me.gridClicks()
    End Sub

    Private Sub btnShowAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAP.Click
        blnARReportVisible = False
        Me.cmdPrint.Visible = False
        Me.btnPrintAP.Visible = True
        Me.lvReport.Visible = False
        Me.lvAPSheet.Visible = True
        Me.gridClicks()
    End Sub

    Private Sub lvSales_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSales.Click
        Me.lvReport.Visible = False
        Me.lvAPSheet.Visible = False
        Me.btnPrintAP.Visible = False
        Me.cmdPrint.Visible = False
    End Sub

    Private Sub btnPrintAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAP.Click
        Try
            Dim oword As New Word.Application
            oword.Visible = True
            Dim odoc As Word.Document
            odoc = oword.Documents.Add
            With oword.Selection
                .Font.Size = 9
                .Font.Name = "Courier"
                .PageSetup.TopMargin = 40
                .PageSetup.BottomMargin = 40
                .PageSetup.LeftMargin = 30
                .PageSetup.RightMargin = 20
                .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape

                Dim tabLength As Double
                tabLength = 0.7
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.6
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                Dim salesper As String
                salesper = Me.lvSales.SelectedItems(0).Text

                .TypeText("WEEK OF: " & Me.dDateFrom.ToShortDateString & " - " & Me.dDateto.ToShortDateString)
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("ACCOUNTS PAYABLE")
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("SALES PERSON: " & UCase(salesper))
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("----------------------------------------------------------------------------------------------------------------------------")
                .TypeParagraph()
                .TypeText("JOB#" & vbTab)
                .TypeText("CABS/MISC" & vbTab)
                .TypeText("5260" & vbTab)
                .TypeText("5270" & vbTab)
                .TypeText("5010" & vbTab)
                .TypeText("4700" & vbTab)
                .TypeText("5020" & vbTab)
                .TypeText("5030" & vbTab)
                .TypeText("5040" & vbTab)
                .TypeText("5070" & vbTab)
                .TypeText("Factor" & vbTab)
                .TypeText("Date" & vbTab)
                .TypeText("Spplyr" & vbTab)
                .TypeText("Job" & vbTab)
                .TypeText("Comm" & vbTab)
                .TypeParagraph()
                .TypeText("----------------------------------------------------------------------------------------------------------------------------")
                .TypeParagraph()

                Dim job1 As New JobHeader
                For Each job1 In Me.alJob

                    .Font.Bold = True
                    .TypeText(job1.sJob & vbTab)
                    .TypeText(job1.sJobDesc)
                    .TypeParagraph()

                    Dim lineAP1 As lineAP
                    For Each lineAP1 In job1.alAPlines
                        .Font.Bold = False
                        .TypeText(lineAP1.sPO & vbTab)
                        .TypeText(lineAP1.sCabsDesc & vbTab)
                        .TypeText(lineAP1.s5260 & vbTab)
                        .TypeText(lineAP1.s5270 & vbTab)
                        .TypeText(lineAP1.s5010 & vbTab)
                        .TypeText(lineAP1.s4700 & vbTab)
                        .TypeText(lineAP1.s5020 & vbTab)
                        .TypeText(lineAP1.s5030 & vbTab)
                        .TypeText(lineAP1.s5040 & vbTab)
                        .TypeText(lineAP1.s5070 & vbTab)
                        .TypeText(lineAP1.sFactor & vbTab)
                        .TypeText(lineAP1.sDate & vbTab)
                        .TypeText(lineAP1.sSupplier & vbTab)
                        .TypeText(lineAP1.sComm & vbTab)
                        .TypeParagraph()
                    Next

                    .TypeText("----------------------------------------------------------------------------------------------------------------------------")
                    .TypeParagraph()
                Next
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAll.Click
        Me.CreatePageBreaksForPrintALL()
    End Sub

    Private Class OnePage
        Public alJob As New ArrayList
    End Class

    Private alPages As ArrayList

    Private Sub CreatePageBreaksForPrintALL()
        Try

            GenerateARAPArray(True)

            Dim totalLinesPerPage As Long = 0
            Dim job1 As New JobHeader
            Me.alPages = New ArrayList
            Dim onePage1 As New OnePage
            Dim i As Long = 0
            Dim lastSales As String = ""
            For Each job1 In Me.alJob
                i += 1
                If (((totalLinesPerPage + job1.alARlines.Count + 1) > 22) And totalLinesPerPage > 0) Then
                    'if page has been started and existing lines plus new lines will be too long then crate page break
                    'dont add it to the pages count if its empty
                    If onePage1.alJob.Count > 0 Then
                        If lastSales <> job1.sSalesperson Then
                            'happen to have new salesperson just at the end of page also
                            Me.alPages.Add(onePage1)
                            totalLinesPerPage = 0
                            onePage1 = New OnePage

                            'add this job to new sales person page
                            onePage1.alJob.Add(job1)
                        Else
                            onePage1.alJob.Add(job1)
                            Me.alPages.Add(onePage1)
                            totalLinesPerPage = 0
                            onePage1 = New OnePage
                        End If

                    End If
                ElseIf i > 1 And lastSales <> job1.sSalesperson Then
                    'if its a new sales person then shove onto new page
                    'but this current job loop has to be added to the NEW salesperson not the one that just ended
                    'dont add it to the pages count if its empty
                    If onePage1.alJob.Count > 0 Then
                        Me.alPages.Add(onePage1)
                        totalLinesPerPage = 0
                        onePage1 = New OnePage

                        'add this job to new sales person page
                        onePage1.alJob.Add(job1)
                    Else
                        onePage1.alJob.Add(job1)
                    End If

                Else
                    totalLinesPerPage += job1.alARlines.Count + 1
                    onePage1.alJob.Add(job1)
                End If
                lastSales = job1.sSalesperson
            Next

            'if it was in the middle of a page and loop finished make sure to add the last page
            If onePage1.alJob.Count > 0 Then
                Me.alPages.Add(onePage1)
                onePage1 = New OnePage
            End If

            PrintOutAllWord()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintOutAllWord()

        Dim oword As New Word.Application
        oword.Visible = True
        Dim odoc As Word.Document
        odoc = oword.Documents.Add
        With oword.Selection
            .Font.Size = 9
            .Font.Name = "Courier"
            .PageSetup.TopMargin = 40
            .PageSetup.BottomMargin = 40
            .PageSetup.LeftMargin = 30
            .PageSetup.RightMargin = 30
            .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape
            oword.Options.CheckSpellingAsYouType = False
            oword.Options.CheckGrammarAsYouType = False
            oword.Options.Pagination = False
        End With

        Dim salesper As String = ""

        Dim pagecount As Long = 0
        Dim onePage1 As OnePage
        For Each onePage1 In Me.alPages
            pagecount += 1
            With oword.Selection
                Dim tabLength As Double
                Dim job1 As JobHeader
                Dim jobTotal As Decimal = 0
                Dim j As Long = 0
                For Each job1 In onePage1.alJob
                    j += 1
                    salesper = job1.sSalesperson
                    If j = 1 Then
                        tabLength = 0.4
                        .ParagraphFormat.TabStops.ClearAll()
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 1.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.8
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.8
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.8
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 1
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                        .TypeText("WEEK OF: " & Me.dDateFrom.ToShortDateString & " - " & Me.dDateto.ToShortDateString)
                        .TypeParagraph()
                        .TypeText("ACCOUNTS RECEIVABLE")
                        .TypeParagraph()
                        .TypeText("SALES PERSON: " & salesper)

                        .TypeParagraph()
                        .TypeText("-------------------------------------------------------------------------------------------------------------------------------")
                        .TypeParagraph()
                        .TypeText("JOB#" & vbTab)
                        .TypeText("BUILDER/CUST" & vbTab)
                        .TypeText("4010" & vbTab)
                        .TypeText("4020" & vbTab)
                        .TypeText("4030" & vbTab)
                        .TypeText("4040" & vbTab)
                        .TypeText("4070" & vbTab)
                        .TypeText("% TAX" & vbTab)
                        .TypeText("$ TAX" & vbTab)
                        .TypeText("CITY/CNTY" & vbTab)
                        .TypeText("PERMIT" & vbTab)
                        .TypeText("P.O.#" & vbTab)
                        .TypeText("TOTALS" & vbTab)
                        .TypeParagraph()
                        .TypeText("-------------------------------------------------------------------------------------------------------------------------------")
                        .TypeParagraph()
                    End If

                    jobTotal = 0
                    .Font.Bold = True
                    .TypeText(job1.sJob & vbTab)
                    .TypeText(job1.sCust & vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(Mid(job1.sSalesTaxID, 1, 8) & vbTab)
                    .TypeText(vbTab)
                    .TypeText(job1.sJobCity & vbTab)
                    .TypeText(job1.sPermit)
                    .TypeParagraph()
                    Dim i As Long = 0
                    Dim line1 As lineAR
                    For Each line1 In job1.alARlines
                        .Font.Bold = False
                        i += 1
                        .TypeText(vbTab)
                        If i = 1 Then
                            .TypeText(job1.sAddress & vbTab)
                        Else
                            .TypeText(vbTab)
                        End If

                        .TypeText(line1.s4010 & vbTab)
                        .TypeText(line1.s4020 & vbTab)
                        .TypeText(line1.s4030 & vbTab)
                        .TypeText(line1.s4040 & vbTab)
                        .TypeText(line1.s4070 & vbTab)

                        'TAX RATE
                        .TypeText(line1.sTaxPercent & vbTab)
                        .TypeText(line1.sTaxDollar & vbTab)

                        'couldnt fit on job line so show on first po line
                        If i = 1 Then
                            .TypeText(job1.sJobCnty & vbTab)
                        Else
                            .TypeText(vbTab)
                        End If

                        .TypeText(vbTab) 'permit on job line only
                        .TypeText(line1.sPO & vbTab) 'PO # only after dash part, not job # part

                        .TypeText(line1.decTotalPO)  'PO # only after dash part, not job # part
                        .TypeParagraph()
                        jobTotal += line1.decTotalPO
                    Next

                    .Font.Bold = True
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(vbTab)
                    .TypeText(jobTotal)
                    .TypeParagraph()
                    .TypeText("-------------------------------------------------------------------------------------------------------------------------------")
                    .TypeParagraph()
                Next

                .Font.Bold = False
                .TypeText("Page: " & pagecount)
                .TypeParagraph()
                .InsertBreak(Word.WdBreakType.wdPageBreak)

                pagecount += 1
                j = 0
                For Each job1 In onePage1.alJob
                    j += 1
                    salesper = job1.sSalesperson
                    If j = 1 Then
                        .Font.Bold = False
                        tabLength = 0.7
                        .ParagraphFormat.TabStops.ClearAll()
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.7
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.8
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.8
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                        tabLength = tabLength + 0.6
                        .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)


                        .TypeText("WEEK OF: " & Me.dDateFrom.ToShortDateString & " - " & Me.dDateto.ToShortDateString)
                        .TypeParagraph()
                        .TypeText("ACCOUNTS PAYABLE")
                        .TypeParagraph()
                        .TypeText("SALES PERSON: " & UCase(salesper))
                        .TypeParagraph()
                        .TypeText("-------------------------------------------------------------------------------------------------------------------------------")
                        .TypeParagraph()
                        .TypeText("JOB#" & vbTab)
                        .TypeText("CABS/MISC" & vbTab)
                        .TypeText("5260" & vbTab)
                        .TypeText("5270" & vbTab)
                        .TypeText("5010" & vbTab)
                        .TypeText("4700" & vbTab)
                        .TypeText("5020" & vbTab)
                        .TypeText("5030" & vbTab)
                        .TypeText("5040" & vbTab)
                        .TypeText("5070" & vbTab)
                        .TypeText("Factor" & vbTab)
                        .TypeText("Date" & vbTab)
                        .TypeText("Spplyr" & vbTab)
                        .TypeText("Job" & vbTab)
                        .TypeText("Comm" & vbTab)
                        .TypeParagraph()
                        .TypeText("-------------------------------------------------------------------------------------------------------------------------------")
                        .TypeParagraph()
                    End If

                    .Font.Bold = True
                    .TypeText(job1.sJob & vbTab)
                    .TypeText(job1.sJobDesc)
                    .TypeParagraph()

                    Dim lineAP1 As lineAP
                    For Each lineAP1 In job1.alAPlines
                        .Font.Bold = False
                        .TypeText(lineAP1.sPO & vbTab)
                        .TypeText(lineAP1.sCabsDesc & vbTab)
                        .TypeText(lineAP1.s5260 & vbTab)
                        .TypeText(lineAP1.s5270 & vbTab)
                        .TypeText(lineAP1.s5010 & vbTab)
                        .TypeText(lineAP1.s4700 & vbTab)
                        .TypeText(lineAP1.s5020 & vbTab)
                        .TypeText(lineAP1.s5030 & vbTab)
                        .TypeText(lineAP1.s5040 & vbTab)
                        .TypeText(lineAP1.s5070 & vbTab)
                        .TypeText(lineAP1.sFactor & vbTab)
                        .TypeText(lineAP1.sDate & vbTab)
                        .TypeText(lineAP1.sSupplier & vbTab)
                        .TypeText(lineAP1.sComm & vbTab)
                        .TypeParagraph()
                    Next
                    'extra paragraph line to match with receivables sheet which has a bold total before end of job
                    .TypeParagraph()
                    .TypeText("-------------------------------------------------------------------------------------------------------------------------------")
                    .TypeParagraph()

                Next
                .Font.Bold = False
                .TypeText("Page: " & pagecount)
                .TypeParagraph()
                .InsertBreak(Word.WdBreakType.wdPageBreak)
            End With
        Next
    End Sub

End Class