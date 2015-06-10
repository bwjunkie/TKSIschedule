Option Strict Off
Option Explicit On
Option Compare Text
Imports C1.Win.C1FlexGrid.Classic
Imports System.Windows.Forms
Imports System.Drawing

Friend Class rptUnInvoiced
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
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
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents gridReport As C1FlexGridClassic
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptUnInvoiced))
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.gridReport = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(8, 23)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(89, 24)
        Me.cmdRefresh.TabIndex = 2
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(584, 592)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(105, 24)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "PRINT"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'gridReport
        '
        Me.gridReport.ColumnInfo = "10,0,0,0,0,100,Columns:"
        Me.gridReport.FixedCols = 0
        Me.gridReport.FixedRows = 0
        Me.gridReport.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridReport.Location = New System.Drawing.Point(8, 48)
        Me.gridReport.Name = "gridReport"
        Me.gridReport.NodeClosedPicture = Nothing
        Me.gridReport.NodeOpenPicture = Nothing
        Me.gridReport.OutlineCol = -1
        Me.gridReport.Size = New System.Drawing.Size(681, 537)
        Me.gridReport.StyleInfo = resources.GetString("gridReport.StyleInfo")
        Me.gridReport.TabIndex = 0
        Me.gridReport.TreeColor = System.Drawing.Color.DarkGray
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptUnInvoiced
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(849, 626)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.gridReport)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "rptUnInvoiced"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Un-Invoiced Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private sReportType As String
    Private bLoading As Boolean
    Private sGridSales, sGridDates As String
    Private PaymentsCount As Integer
    Private LastPODateReq As Date

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'on error Resume Next
        gridReport.PrintGrid("", 1, 1, 10, 10)
    End Sub

    Private oJob As New JobObj
    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private Sub gridReportALL(ByRef stype As String)

        Dim frmBusy1 As New winBusy
        frmBusy1.Show()
        Try
            gridReport.Redraw = False

            Dim Y As Integer

            Dim contract As Decimal
            Dim SALE4040, SALE4010, SALE4030, SALE4070 As Decimal
            Dim SALETOTAL As Decimal
            Dim partialPaid As Boolean = False
            Dim fullPaid As Boolean = False
            Dim invoiceExists As Boolean = False


            With gridReport
                .Redraw = False
                .Cols = 10
                .Rows = 0
                .Rows = 7
                .GridLines = GridStyleSettings.flexGridNone

                Dim qPO2years = (From row In dc.tPOHeaders Where (row.tJob.dJobCreated > Now.AddYears(-2)) And (row.tJob.nMaterialsCharge > 0 Or row.tJob.nLaborCharge > 0))

                Dim qJobs2years = (From row In qPO2years Select row.tJob)

                Dim qPOWithCabs = (From row In qPO2years Where (row.nAccount = 4010))  'has some cabinets

                Dim qJobsWithCabs = (From row In qPOWithCabs Select row.tJob)

                Dim qJobsWithoutCabs = qJobs2years.Except(qJobsWithCabs)

                Dim qJobsWithoutCabsSomethingDelivered = (From row In qJobsWithoutCabs Join rowpo In qPO2years On row.nID Equals rowpo.nJobID Where rowpo.DDEL IsNot Nothing Select row)

                Dim qJobsWithCabsDelivered = (From row In qJobsWithCabs Join rowpo In qPOWithCabs On row.nID Equals rowpo.nJobID Where rowpo.DDEL IsNot Nothing Select row)

                Dim qJobsToShow = qJobsWithoutCabsSomethingDelivered.Union(qJobsWithCabsDelivered)

                'Me.DsTKSI1.tJob.Clear()
                'Me.daJobBySaleDREC2Years.Fill(Me.DsTKSI1.tJob)
                'Me.DsTKSI1.tCustomr.Clear()
                'Me.daCust.Fill(Me.DsTKSI1.tCustomr)

                .set_Cell(CellPropertySettings.flexcpText, 0, 1, 0, 6, "REPORT: Billable Job's with a date delivered but customer payment is low or none.")
                .set_Cell(CellPropertySettings.flexcpText, 1, 1, 1, 2, "")
                .set_ColWidth(1, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(2, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(3, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(4, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(5, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(6, 1000 / global_OldGridNewGridRation)
                .set_ColWidth(7, 600 / global_OldGridNewGridRation)
                .set_ColWidth(8, 1200 / global_OldGridNewGridRation)
                .set_ColWidth(9, 1200 / global_OldGridNewGridRation)
                .set_ColHidden(0, True)
                .set_ColHidden(1, False)
                .set_ColHidden(2, False)
                .set_ColHidden(3, False)
                .set_ColHidden(4, False)
                .set_ColHidden(5, False)
                .set_ColHidden(6, False)
                .set_ColHidden(7, False)
                .set_ColHidden(8, False)
                .set_ColHidden(9, False)

                .MergeCells = MergeSettings.flexMergeFree
                .set_MergeRow(0, True)
                .set_MergeRow(1, True)
                .set_MergeRow(2, True)
                .set_MergeRow(3, True)
                .FrozenRows = 4
                Y = 3
                .set_Cell(CellPropertySettings.flexcpText, Y, 1, Y, 2, "Job Details")
                .set_Cell(CellPropertySettings.flexcpBackColor, Y, 7, Y, 7, Color.Yellow)
                .set_Cell(CellPropertySettings.flexcpText, Y, 8, Y, 9, "= No invoice created.")
                .set_Cell(CellPropertySettings.flexcpBackColor, Y - 1, 7, Y - 1, 7, Color.LightGray) ' global_ColorFromHex(&HEE, &HEE, &HEE))
                .set_Cell(CellPropertySettings.flexcpText, Y - 1, 8, Y - 1, 9, "= Invoice partially paid.")
                .set_Cell(CellPropertySettings.flexcpBackColor, Y - 2, 7, Y - 2, 7, Color.Tan) ' global_ColorFromHex(&HCC, &HDD, &HEE))
                .set_Cell(CellPropertySettings.flexcpText, Y - 2, 8, Y - 2, 9, "= Invoice not paid.")

                ' Dim drJOB As dsTKSI.tJobRow
                For Each drJOB In (From row In qJobsToShow Order By row.tCustomr.sName) ' Me.DsTKSI1.tJob
                    invoiceExists = False
                    partialPaid = False
                    fullPaid = False

                    'Me.DsTKSI1.tPOHeader.Clear()
                    'Me.daPOheaderByNJobID.SelectCommand.Parameters("@NJOBID").Value = drJOB.nID
                    'Me.daPOheaderByNJobID.Fill(Me.DsTKSI1.tPOHeader)

                    'Me.DsTKSI1.tSOHeader.Clear()
                    'Me.daSOHeaderByNJOBID.SelectCommand.Parameters("@NJOBID").Value = drJOB.nID
                    'Me.daSOHeaderByNJOBID.Fill(Me.DsTKSI1.tSOHeader)


                    'Me.DsTKSI1.tSOLine.Clear()
                    'Me.daSOLineByNJOBID.SelectCommand.Parameters("@NJOBID").Value = drJOB.nID
                    'Me.daSOLineByNJOBID.Fill(Me.DsTKSI1.tSOLine)

                    'Me.DsTKSI1.tPOLine.Clear()
                    'Me.daPOLineByNJobID.SelectCommand.Parameters("@NJOBID").Value = drJOB.nID
                    'Me.daPOLineByNJobID.Fill(Me.DsTKSI1.tPOLine)


                    Dim totalCustPayment As Decimal = 0
                    If drJOB.tSOHeaders.Count = 0 Then
                        invoiceExists = False
                    Else
                        invoiceExists = True
                        '  Dim drSO As dsTKSI.tSOHeaderRow
                        Dim drSO As tSOHeader
                        Try
                            drSO = drJOB.tSOHeaders.Single '.GettSOHeaderRows(0)
                        Catch ex As Exception
                            drSO = drJOB.tSOHeaders.First
                            MessageBox.Show("error: Job has two invoices, " & drJOB.sJobNo)
                        End Try

                        'Dim drLine As dsTKSI.tSOLineRow
                        For Each drLine In drSO.tSOLines '.GettSOLineRows
                            If drLine.nAmount < 0 Then
                                partialPaid = True
                                totalCustPayment += drLine.nAmount
                            End If
                        Next
                        If -totalCustPayment >= drJOB.nLaborCharge + drJOB.nMaterialsCharge - 1 Then
                            fullPaid = True
                        End If
                    End If

                    SALE4010 = 0
                    SALE4030 = 0
                    SALE4040 = 0
                    SALE4070 = 0
                    SALETOTAL = 0
                    oJob.InitAccountTotals(drJOB)

                    If Not fullPaid Then

                        .Rows = .Rows + 4
                        Y = .Rows - 4
                        .MergeCells = MergeSettings.flexMergeFree
                        .set_MergeRow(Y, True)

                        .set_TextMatrix(Y, 0, drJOB.nID) 'rsJob.Fields("nid").Value)
                        .set_TextMatrix(Y + 1, 0, drJOB.nAddressID)  'rsJob.Fields("naddressid").Value)

                        If drJOB.tPOHeaders.Count > 0 Then '.GettPOHeaderRows.Length > 0 Then
                            If drJOB.tPOHeaders.First.dRequired IsNot Nothing Then '.GettPOHeaderRows(0).IsdRequiredNull Then
                                .set_TextMatrix(Y, 9, CDate(drJOB.tPOHeaders.First.dRequired).ToString("d"))  ' .GettPOHeaderRows(0).dRequired.ToShortDateString)
                            End If
                        End If
                        Try

                            .set_Cell(CellPropertySettings.flexcpText, Y, 1, Y, 7, "Job: " & drJOB.sJobNo & " - " & drJOB.tCustomr.sName & " - " & drJOB.sJobDesc)

                        Catch ex As Exception
                            .set_Cell(CellPropertySettings.flexcpText, Y, 1, Y, 7, "Job: " & drJOB.sJobNo & " - ERROR IN CUSTOMER - " & drJOB.sJobDesc)
                        End Try
                        .set_Cell(CellPropertySettings.flexcpText, Y + 2, 2, Y + 2, 8, "" & drJOB.sInvNotes)
                        .set_TextMatrix(Y, 8, CDate(drJOB.dJobCreated).ToString("d")) ' rsJob.Fields("djobcreated").Value)
                        .set_Cell(CellPropertySettings.flexcpFontBold, Y, 1, Y, 7, True)
                        If partialPaid Then
                            .set_Cell(CellPropertySettings.flexcpBackColor, Y, 1, Y, 8, Color.LightGray) 'global_ColorFromHex(&HEE, &HEE, &HEE))
                        Else
                            If invoiceExists Then
                                .set_Cell(CellPropertySettings.flexcpBackColor, Y, 1, Y, 8, Color.Tan) 'global_ColorFromHex(&HCC, &HDD, &HEE))
                            Else
                                .set_Cell(CellPropertySettings.flexcpBackColor, Y, 1, Y, 8, Color.Yellow)
                            End If
                        End If
                        .set_Cell(CellPropertySettings.flexcpText, Y + 1, 5, Y + 1, 6, "CustPayment$: " & -(totalCustPayment))
                        contract = drJOB.nMaterialsCharge + (drJOB.nMaterialsCharge * drJOB.nTaxRate / 100) + drJOB.nLaborCharge
                        .set_Cell(CellPropertySettings.flexcpText, Y + 1, 1, Y + 1, 2, "Contract$: " & System.Math.Round(contract, 2))
                        .set_Cell(CellPropertySettings.flexcpText, Y + 1, 3, Y + 1, 4, "Total PO: " & oJob.POsSalesTotal(drJOB))

                        .set_MergeRow(Y + 1, True)
                        .set_MergeRow(Y + 2, True)
                    Else
                        'dont show job cause its paid in full
                    End If
reloop:
                Next
                .Rows = .Rows + 3
            End With

            gridReport.Select(0, 0)
            gridReport.Redraw = True
            gridReport.Visible = True
        Catch ex As Exception
            MessageBox.Show("error  " & ex.Message)
        Finally
            frmBusy1.Close()
        End Try
    

    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        RefreshReport()
    End Sub

    Private Sub rptInvAlert2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        RefreshReport()
    End Sub

    Private Sub gridReport_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridReport.Click
        Dim x As Object
        Dim Y As Object
        Dim jobid, AddressID As Integer

        With gridReport

            If .MouseRow > -1 And .MouseCol > -1 Then
                Y = .MouseRow
                x = .MouseCol
                If Mid(.get_TextMatrix(Y, x), 1, 3) = "Job" Then
                    If IsNumeric(.get_TextMatrix(Y + 1, 0)) Then
                        jobid = CInt(.get_TextMatrix(Y, 0))
                        AddressID = CInt(.get_TextMatrix(Y + 1, 0))

                        OpenJobScreen(AddressID, jobid, False)

                    End If
                End If
            End If
        End With
    End Sub

    Private Sub Option1_Click()
        RefreshReport()
    End Sub

    Private Sub RefreshReport()
        gridReportALL("DeliveredUnpaid")
    End Sub

End Class