Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Media
Imports System.Windows
Imports System.Windows.Controls
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Linq

Public Class winCommissions

    Private ds1 As New TKSIJOBSDataSet
    Dim daJ As New TKSIJOBSDataSetTableAdapters.tJobTableAdapter
    Dim daPOh As New TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter
    Dim daPOLine As New TKSIJOBSDataSetTableAdapters.tPOLineTableAdapter
    Dim daSOh As New TKSIJOBSDataSetTableAdapters.tSOHeaderTableAdapter
    Dim daSOLine As New TKSIJOBSDataSetTableAdapters.tSOLineTableAdapter
    Dim daCust As New TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter
    Dim daComm As New TKSIJOBSDataSetTableAdapters.tblCommissionStructureTableAdapter
    Dim daPay As New TKSIJOBSDataSetTableAdapters.tPaymentsTableAdapter
    Dim daDraws As New TKSIJOBSDataSetTableAdapters.tDrawsTableAdapter
    Dim ocJobsNotShown As New List(Of CommissionList)

    Private Sub lbSalesperson_SelectionChanged_1(sender As Object, e As Windows.Controls.SelectionChangedEventArgs) Handles lbSalesperson.SelectionChanged, lbPayDates.SelectionChanged
        Me.RefreshReport()
    End Sub

    Private Sub RefreshReport()
        If lbSalesperson.SelectedItems.Count > 0 And lbPayDates.SelectedItems.Count > 0 Then
            Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
            drEmp = lbSalesperson.SelectedItem.row
            Dim sDate As String = lbPayDates.SelectedItem.ToString
            LoadReport(drEmp, sDate)
        End If
    End Sub

    Private Sub LoadReport(drEmp As TKSIJOBSDataSet.tEmployeeRow, sDate As String)
        '     ds1.EnforceConstraints = False
        Dim sSales As String = drEmp.nickname
        If UCase(sDate) = "ALL UNPAID" Then
            gridReportALL(sSales, sDate)
        Else
            gridReportDATE(sSales, sDate)
        End If
    End Sub

    Private Class DrawsTotals
        Public Property DrawGrandTotal As Decimal
        Public Property DrawTotalToday As Decimal

        Public Sub New(decGrandTotal As Decimal, decTodayTotal As Decimal)
            Me.DrawGrandTotal = decGrandTotal
            Me.DrawTotalToday = decTodayTotal
        End Sub
    End Class

    Private Function LoadDrawsBalance(sDate As String, sSales As String, ds1 As TKSIJOBSDataSet) As DrawsTotals

        Dim draDraws As TKSIJOBSDataSet.tDrawsRow()
        Dim drDraw As TKSIJOBSDataSet.tDrawsRow

        Dim returnDrawsTotal As New DrawsTotals(0, 0)

        If UCase(sDate) = "ALL UNPAID" Then
            draDraws = ds1.tDraws.Select("salesperson='" & sSales & "'")
        Else
            draDraws = ds1.tDraws.Select("salesperson='" & sSales & "' and drawdate<='" & CDate(sDate) & "'")
        End If

        For Each drDraw In draDraws
            'all dates equal or earlier than selected date
            returnDrawsTotal.DrawGrandTotal += drDraw.DrawAmount ' rs.Fields("drawAmount").Value
            'all draws for THIS pay period
            If Not UCase(sDate) = "ALL UNPAID" Then
                If IsDate2(sDate) Then
                    If drDraw.DrawDate = CDate(sDate) Then
                        returnDrawsTotal.DrawTotalToday += drDraw.DrawAmount
                    End If
                End If
            End If
            'rs.MoveNext()
            'Loop
        Next

        Return returnDrawsTotal

    End Function


    Private Function PaymentsTotal(ByRef drJob As TKSIJOBSDataSet.tJobRow, sDate As String) As CommissionList.clsPaymentsTotals
        Dim pay1 As New CommissionList.clsPaymentsTotals

        Dim drPay As TKSIJOBSDataSet.tPaymentsRow
        '  If daPayment.FillByJobid(Me.ds1.tPayments, drJob.nID) > 0 Then
        'show all payments that are up to today, if we are looking at a past AR sheet
        'entries we want the system to appear that it does not know about future payments
        For Each drPay In drJob.GettPaymentsRows
            If (sDate) <> "ALL UNPAID" Then
                If CDate(sDate) >= drPay.dDate Then
                    pay1.PaymentCount += 1
                    pay1.PaymentTotal += +drPay.nAmount
                    pay1.nPaymentID.Add(drPay.nID)
                End If
            Else
                pay1.PaymentCount += 1
                pay1.PaymentTotal += drPay.nAmount
                pay1.nPaymentID.Add(drPay.nID)
            End If
        Next
        '  End If

        Return pay1
    End Function

    Private Sub gridReportALL(sSales As String, sDate As String)
        Dim frmBusy As New frmWorking
        Try
            frmBusy.Show()

            tbTotalNotSelected.Text = ""
            tbTotalSelected.Text = ""

            Dim SALE4040, SALE4010, SALE4030, SALE4070 As Decimal
            Dim COST5030, SALETOTAL, COST5010, COST5040, COST5490 As Decimal
            Dim COSTTOTAL, COST5070, JobNet As Decimal
            Dim CommRate As Decimal = 0
            Dim JobMarkup As Decimal = 0

            ocJobsNotShown.Clear()
            'ToPay shows total commission due on job not subtracting any possible partial payments
            Dim ToPay As Decimal
            Dim blnInvoiceExists As Boolean = False
            'TotalToPay stores sum of all commissions still due AFTER partial payments
            Dim TotalToPay As Decimal
            'job balance due should show commissions still due to salesperson AFTER partial payments
            Dim JobBalanceDue As Decimal
            Dim drawstotal1 As DrawsTotals = LoadDrawsBalance(sDate, sSales, ds1)

            Dim drJob As TKSIJOBSDataSet.tJobRow
            Dim draJobs As TKSIJOBSDataSet.tJobRow()

            If UCase(sDate) = "ALL UNPAID" Then

                draJobs = ds1.tJob.Select("ssalesperson='" & sSales & "'", "dJobCreated")

                Me.lblTotalPaidOrToPayTitle.Content = "Total Unpaid"
                Me.lblSelectedTitle.Content = "Total to Pay"
                '  topaybut = "CLICK TO PAY"
            Else
                MessageBox.Show("Please select a date or ALL UNPAID")
                Exit Sub
            End If

            Me.lblCommissionsTitle.Content = "Commission: " & sDate
            Me.lblSalesperson.Content = "  Salesperson: " & sSales

            Dim listComm1 As New ocCommissions
            listComm1.commlist.Clear()

            For Each drJob In draJobs ' ds1.tJob
                'Dim blnThisisit As Boolean = False
                If drJob.sJobNo.Contains("13490B") Then
                    Dim blnThisisit As Boolean = True
                End If

                Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
                Dim iStructureToUse As Integer = 1
                Dim blnCommStructureNotSetProperly As Boolean = False
                If drJob.lngCommissionStruct = 0 Then
                    iStructureToUse = GetDefaultPriorityCommStructureID()
                    blnCommStructureNotSetProperly = True
                Else
                    iStructureToUse = drJob.lngCommissionStruct
                End If
                drComm = ds1.tblCommissionStructure.FindBylngID(iStructureToUse)

                If drComm Is Nothing Then
                    MessageBox.Show("Error loading comm structure for job ID: " & drJob.nID & "   comm structure: " & iStructureToUse)
                    Exit For
                End If

                Dim temp As Double = 0
                SALE4010 = 0
                SALE4030 = 0
                SALE4040 = 0
                SALE4070 = 0
                SALETOTAL = 0
                COST5010 = 0
                COST5030 = 0
                COST5040 = 0
                COST5070 = 0
                COST5490 = 0
                COSTTOTAL = 0
                getPOTotals(drJob, SALE4010, SALE4030, SALE4040, SALE4070, SALETOTAL, COST5010, COST5030, COST5040, COST5070, COST5490, COSTTOTAL)

                blnInvoiceExists = False
                Dim drSO As TKSIJOBSDataSet.tSOHeaderRow
                For Each drSO In drJob.GettSOHeaderRows
                    Dim drLine As TKSIJOBSDataSet.tSOLineRow
                    For Each drLine In drSO.GettSOLineRows
                        If UCase(drLine.sType) = "COMMENT" And drLine.nAmount < 0 Then
                            temp += drLine.nAmount
                        End If
                    Next
                    blnInvoiceExists = True
                Next

                'if any of the PO's in the job are this type, then show the whole job
                'or if the amount is negative then show
                'either scenario can cause us to want to show the job
                Dim blnShowJob As Boolean = False
                Dim blnHasPO As Boolean = False
                Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
                'If temp < 0 Then blnShowJob = True

                For Each drPO In drJob.GettPOHeaderRows
                    If UCase(drPO.sPOType) = "PO" Then
                        blnHasPO = True
                        'jobs that have customer payment and have ANY PO anywhere in the job  get shown
                        If blnInvoiceExists Then
                            If temp < 0 Then
                                blnShowJob = True
                                Exit For
                            End If
                        End If
                    End If
                Next

                If Not blnShowJob Then
                    For Each drPO In drJob.GettPOHeaderRows
                        If UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                            'jobs that have customer payment and are PO SWO-JOBCOST OR JOBCOST get shown
                            If Not blnInvoiceExists Then
                                'probably show this job, unless the PO says dont
                                If Not blnHasPO Then  'because if it has a billable PO and no invoice, then we still need to wait for the invoice to be received and paid before we pay the salesperson
                                    blnShowJob = True
                                End If
                            Else
                                If temp < 0 Then
                                    'has invoice and cust payment, so show job no matter what is happening with POs on this job
                                    blnShowJob = True
                                Else
                                    If Not blnHasPO Then
                                        blnShowJob = True
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If

                Dim Comm1 As New CommissionList
                Comm1.salesnickname = drJob.sSalesperson
                Comm1.nJobID = drJob.nID
                Comm1.nAddressID = drJob.nAddressID
                Comm1.JobDetails = "Job: " & drJob.sJobNo & " - " & drJob.tCustomrRow.sName & " - " & drJob.sJobDesc
                Comm1.sJobNo = drJob.sJobNo

                If blnShowJob Then
                    Comm1.PaymentTotals = PaymentsTotal(drJob, sDate)
                    Comm1.CustPayment = temp
                    Dim decContract As Decimal = Decimal.Round(CDec(drJob.nMaterialsCharge + (drJob.nMaterialsCharge * drJob.nTaxRate / 100) + drJob.nLaborCharge), 2)
                    Comm1.Contract = decContract

                    If IsNumeric(temp) Then
                        If -(temp) >= decContract - 1 And -temp > 0 Then
                            Comm1.colorPaymentFull = Brushes.PaleGreen
                        Else
                            Comm1.colorPaymentFull = Brushes.Yellow
                        End If
                    End If

                    Comm1.dDate = drJob.dJobCreated.ToShortDateString
                    Comm1.Total4010 = System.Decimal.Round(SALE4010, 2)
                    Comm1.Total4030 = System.Decimal.Round(SALE4030, 2)
                    Comm1.Total4040 = System.Decimal.Round(SALE4040, 2)
                    Comm1.Total5010 = System.Decimal.Round(COST5010, 2)
                    Comm1.Total5030 = System.Decimal.Round(COST5030, 2)
                    Comm1.Total5040 = System.Decimal.Round(COST5040, 2)
                    Comm1.TotalSale = TwoDecimal(SALETOTAL)
                    Comm1.TotalCost = TwoDecimal(COSTTOTAL)

                    If COST5010 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4010 - COST5010) / COST5010, 2).ToString.TrimStart("0")
                    End If
                    If COST5030 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4030 - COST5030) / COST5030, 2).ToString.TrimStart("0")
                    End If
                    If COST5040 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4040 - COST5040) / COST5040, 2).ToString.TrimStart("0")
                    End If

                    If COSTTOTAL > 0 Then
                        Dim costtotalminusfindersfee As Decimal = COSTTOTAL - COST5490
                        If costtotalminusfindersfee = 0 Then
                            JobMarkup = 0
                        Else
                            JobMarkup = SALETOTAL / (COSTTOTAL - COST5490) 'exclude finders fee from markup calculation
                        End If

                        Comm1.JobMarkup = (Decimal.Truncate(JobMarkup * 100)) / 100
                        If IsNumeric(Comm1.JobMarkup) Then
                            If JobMarkup >= drComm.dblLevel1 Then
                                CommRate = drComm.dblRate1
                                Comm1.colorJobMarkup = Brushes.PaleTurquoise
                            ElseIf JobMarkup >= drComm.dblLevel2 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate2
                            ElseIf JobMarkup >= drComm.dblLevel3 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate3
                            ElseIf JobMarkup >= drComm.dblLevel4 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate4
                            ElseIf JobMarkup >= drComm.dblLevel5 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate5
                            ElseIf JobMarkup >= drComm.dblLevel6 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate6
                            ElseIf JobMarkup >= drComm.dblLevel7 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate7
                            ElseIf JobMarkup >= drComm.dblLevel8 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate8
                            ElseIf JobMarkup >= drComm.dblLevel9 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate9
                            ElseIf JobMarkup >= drComm.dblLevel10 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate10
                            ElseIf JobMarkup >= drComm.dblLevel11 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate11
                            ElseIf JobMarkup >= drComm.dblLevel12 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate12
                            ElseIf JobMarkup >= drComm.dblLevel13 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate13
                            ElseIf JobMarkup >= drComm.dblLevel14 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate14
                            ElseIf JobMarkup >= drComm.dblLevel15 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate15
                            ElseIf JobMarkup >= drComm.dblLevel16 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate16
                            ElseIf JobMarkup >= drComm.dblLevel17 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate17
                            ElseIf JobMarkup >= drComm.dblLevel18 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate18
                            ElseIf JobMarkup >= drComm.dblLevel19 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate19
                            ElseIf JobMarkup >= drComm.dblLevel20 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate20
                            Else
                                CommRate = 0
                            End If


                            If blnCommStructureNotSetProperly Then
                                Comm1.colorJobMarkup = Brushes.Red
                            End If

                        End If
                    Else
                        'no cost cannot calculate job markup or commission
                        'just assign .33

                        JobMarkup = 1
                        CommRate = drComm.dblRate1

                    End If

                    Comm1.CommRate = CommRate
                    JobNet = (SALETOTAL) - (COSTTOTAL)

                    If JobNet < 0 Then
                        ToPay = JobNet * drComm.dblJobCostRate
                    Else
                        ToPay = CommRate * JobNet
                    End If
                    JobBalanceDue = Decimal.Round(ToPay - Comm1.PaymentTotals.PaymentTotal, 2)

                    Comm1.NetProfit = System.Decimal.Round(JobNet, 2)
                    Comm1.CommTotal = System.Decimal.Round(ToPay, 2)
                    Comm1.BalanceDue = JobBalanceDue

                    'is it already paid off? then dont show
                    '    If ((System.Decimal.Round(ToPay, 2) < System.Decimal.Round(CDec(Payments1.PaymentTotal), 2) + 0.02) And (System.Decimal.Round(ToPay, 2) > System.Decimal.Round(CDec(Payments1.PaymentTotal), 2) - 0.02)) And Payments1.PaymentCount > 0 Then
                    If ((ToPay < Comm1.PaymentTotals.PaymentTotal + 0.02) And (ToPay > Comm1.PaymentTotals.PaymentTotal - 0.02)) And Comm1.PaymentTotals.PaymentCount > 0 Then
                        ocJobsNotShown.Add(Comm1)
                    Else
                        listComm1.commlist.Add(Comm1)
                        TotalToPay = Decimal.Round(TotalToPay + JobBalanceDue, 2)
                    End If
                Else
                    ocJobsNotShown.Add(Comm1)
                End If
            Next
            Me.gridcomm.DataContext = listComm1
            Me.lbJobsNotShown.ItemsSource = Nothing
            Dim q = From row In ocJobsNotShown Order By row.sJobNo.PadLeft(8, "0")
            Me.lbJobsNotShown.ItemsSource = q

            Me.tbDraws.Text = TwoDecimal(drawstotal1.DrawGrandTotal)
            Me.tbTotalNotSelected.Text = TwoDecimal(TotalToPay)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Try
                frmBusy.Close()
            Catch
            End Try
        End Try
    End Sub

    Private Function GetDefaultPriorityCommStructureID() As Integer
        Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
        For Each drComm In ds1.tblCommissionStructure
            If drComm.lngPriority = 1 Then
                Return drComm.lngID
            End If
        Next
        Return 17
    End Function

    Private Sub gridReportDATE(sSales As String, sDate As String)
        Dim frmBusy As New frmWorking
        Try
            frmBusy.Show()
            tbTotalNotSelected.Text = ""
            tbTotalSelected.Text = ""

            Dim SALE4040, SALE4010, SALE4030, SALE4070 As Decimal
            Dim COST5030, SALETOTAL, COST5010, COST5040, COST5490 As Decimal
            Dim COSTTOTAL, COST5070, JobNet As Decimal
            Dim CommRate As Decimal = 0
            Dim JobMarkup As Decimal = 0
            Dim alJobsNotShown As New ArrayList

            'ToPay shows total commission due on job REGARDLESS of partial payments
            Dim ToPay As Decimal
            'TotalToPay stores sum of all commissions still due AFTER partial payments
            Dim TotalToPay As Decimal
            'job balance due should show commissions still due to salesperson AFTER partial payments

            Dim JobBalanceDue As Decimal
            'Dim topaybut As String
            Dim drawstotal1 As DrawsTotals = LoadDrawsBalance(sDate, sSales, ds1)

            Dim drJob As TKSIJOBSDataSet.tJobRow
            '     Dim draJobs As TKSIJOBSDataSet.tJobRow()

            Me.lblSelectedTitle.Content = "Total to Remove"
            Me.lblTotalPaidOrToPayTitle.Content = "Total"

            Me.lblCommissionsTitle.Content = "Commission: " & sDate
            Me.lblSalesperson.Content = "  Salesperson: " & sSales

            Dim listComm1 As ocCommissions = New ocCommissions
            listComm1.commlist.Clear()
            ocJobsNotShown.Clear()

            Dim listJob As New List(Of TKSIJOBSDataSet.tJobRow)
            For Each paytemp In (From row In ds1.tPayments Where row.salesnickname = sSales And row.dDate = CDate(sDate)) '' jobs taht this sales person has a payment for
                If (From row In listJob Where row.nID = paytemp.JOBID).Count = 0 Then  'dont duplidate entry
                    Dim qJob = (From row In ds1.tJob Where row.nID = paytemp.JOBID)
                    If qJob.Count = 1 Then

                        listJob.Add(qJob.First)  'jobs that this salesperson has a payment on (even if its not their job)
                    Else
                        MessageBox.Show("error payment exists with invalid jobid: " & paytemp.JOBID)
                        Exit For
                    End If
                End If
            Next

            '  draJobs = ds1.tJob.Select("ssalesperson='" & sSales & "'", "dJobCreated")

            Dim drPay As TKSIJOBSDataSet.tPaymentsRow
            For Each drJob In (From row In listJob Order By row.dJobCreated) ' draJobs

                Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
                Dim iStructureToUse As Integer = 1
                Dim blnCommStructureNotSetProperly As Boolean = False
                If drJob.lngCommissionStruct = 0 Then
                    iStructureToUse = GetDefaultPriorityCommStructureID()
                    blnCommStructureNotSetProperly = True
                Else
                    iStructureToUse = drJob.lngCommissionStruct
                End If
                drComm = ds1.tblCommissionStructure.FindBylngID(iStructureToUse)

                If drComm Is Nothing Then
                    MessageBox.Show("Error loading comm structure for job ID: " & drJob.nID & "   comm structure: " & iStructureToUse & " " & drJob.sJobNo)
                    Exit For
                End If

                Dim blnHasPaymentsForThisDate As Boolean = False
                Dim decPaymentsTotal As Decimal = 0
                Dim decpaymentsThisDate As Decimal = 0
                For Each drPay In drJob.GettPaymentsRows
                    If drPay.dDate = CDate(sDate) And drPay.salesnickname = sSales Then
                        If blnHasPaymentsForThisDate Then
                            MessageBox.Show(drJob.sJobNo & " has multiple payments on a single date, this should not happen, please rebuild the payment date for : " & sSales)
                        End If
                        blnHasPaymentsForThisDate = True
                        decpaymentsThisDate += drPay.nAmount
                    End If
                    decPaymentsTotal += drPay.nAmount
                Next

                Dim Comm1 As New CommissionList

                If drJob.sSalesperson <> sSales Then
                    Comm1.JobDetails = "(FROM SPLIT PAYMENT) "
                Else
                    Comm1.JobDetails = ""
                End If
                Comm1.JobDetails = Comm1.JobDetails & "Job: " & drJob.sJobNo & " - " & drJob.tCustomrRow.sName & " - " & drJob.sJobDesc

                Comm1.salesnickname = drJob.sSalesperson

                Comm1.nJobID = drJob.nID
                Comm1.nAddressID = drJob.nAddressID
                Comm1.sJobNo = drJob.sJobNo

                If blnHasPaymentsForThisDate Then
                    SALE4010 = 0
                    SALE4030 = 0
                    SALE4040 = 0
                    SALE4070 = 0
                    SALETOTAL = 0
                    COST5010 = 0
                    COST5030 = 0
                    COST5040 = 0
                    COST5070 = 0
                    COST5490 = 0
                    COSTTOTAL = 0
                    getPOTotals(drJob, SALE4010, SALE4030, SALE4040, SALE4070, SALETOTAL, COST5010, COST5030, COST5040, COST5070, COST5490, COSTTOTAL)

                    Dim decInvoiceAmount As Decimal = 0
                    Dim blnInvoiceExists As Boolean = False
                    Dim drSO As TKSIJOBSDataSet.tSOHeaderRow
                    For Each drSO In drJob.GettSOHeaderRows
                        Dim drLine As TKSIJOBSDataSet.tSOLineRow
                        For Each drLine In drSO.GettSOLineRows
                            If UCase(drLine.sType) = "COMMENT" And drLine.nAmount < 0 Then
                                decInvoiceAmount += drLine.nAmount
                            End If
                        Next
                        blnInvoiceExists = True
                    Next
                    Comm1.PaymentTotals = PaymentsTotal(drJob, sDate)
                    Comm1.decPaymentsFromAnyDates = decPaymentsTotal
                    Comm1.decPaymentsThisDate = decpaymentsThisDate
                    Comm1.CustPayment = decInvoiceAmount
                    Dim decContract As Decimal = Decimal.Round(CDec(drJob.nMaterialsCharge + (drJob.nMaterialsCharge * drJob.nTaxRate / 100) + drJob.nLaborCharge), 2)
                    Comm1.Contract = decContract

                    If -(decInvoiceAmount) >= (decContract - 1) And (-decInvoiceAmount > 0) Then
                        Comm1.colorPaymentFull = Brushes.PaleGreen
                    Else
                        Comm1.colorPaymentFull = Brushes.Yellow
                    End If

                    Comm1.dDate = drJob.dJobCreated.ToShortDateString
                    Comm1.Total4010 = System.Decimal.Round(SALE4010, 2)
                    Comm1.Total4030 = System.Decimal.Round(SALE4030, 2)
                    Comm1.Total4040 = System.Decimal.Round(SALE4040, 2)

                    Comm1.Total5010 = System.Decimal.Round(COST5010, 2)
                    Comm1.Total5030 = System.Decimal.Round(COST5030, 2)
                    Comm1.Total5040 = System.Decimal.Round(COST5040, 2)

                    Comm1.TotalSale = TwoDecimal(SALETOTAL)
                    Comm1.TotalCost = TwoDecimal(COSTTOTAL)

                    If COST5010 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4010 - COST5010) / COST5010, 2).ToString.TrimStart("0")
                    End If
                    If COST5030 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4030 - COST5030) / COST5030, 2).ToString.TrimStart("0")
                    End If
                    If COST5040 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4040 - COST5040) / COST5040, 2).ToString.TrimStart("0")
                    End If

                    If COSTTOTAL > 0 Then
                        Dim costtotalminusfindersfee As Decimal = COSTTOTAL - COST5490
                        If costtotalminusfindersfee = 0 Then
                            JobMarkup = 0
                        Else
                            JobMarkup = SALETOTAL / (COSTTOTAL - COST5490) 'exclude finders fee from markup calculation
                        End If

                        '  JobMarkup = SALETOTAL / (COSTTOTAL - COST5490) 'exclude finders fee from markup calculation
                        Comm1.JobMarkup = (Decimal.Truncate(JobMarkup * 100)) / 100
                        If IsNumeric(Comm1.JobMarkup) Then
                            If JobMarkup >= drComm.dblLevel1 Then
                                CommRate = drComm.dblRate1
                                Comm1.colorJobMarkup = Brushes.PaleTurquoise ' global_BrushFromHex(&HAA, &HFF, &HDD) 'Brushes.paleblue
                            ElseIf JobMarkup >= drComm.dblLevel2 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate2
                            ElseIf JobMarkup >= drComm.dblLevel3 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate3
                            ElseIf JobMarkup >= drComm.dblLevel4 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate4
                            ElseIf JobMarkup >= drComm.dblLevel5 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate5
                            ElseIf JobMarkup >= drComm.dblLevel6 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate6
                            ElseIf JobMarkup >= drComm.dblLevel7 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate7
                            ElseIf JobMarkup >= drComm.dblLevel8 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate8
                            ElseIf JobMarkup >= drComm.dblLevel9 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate9
                            ElseIf JobMarkup >= drComm.dblLevel10 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate10
                            ElseIf JobMarkup >= drComm.dblLevel11 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate11
                            ElseIf JobMarkup >= drComm.dblLevel12 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate12
                            ElseIf JobMarkup >= drComm.dblLevel13 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate13
                            ElseIf JobMarkup >= drComm.dblLevel14 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate14
                            ElseIf JobMarkup >= drComm.dblLevel15 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate15
                            ElseIf JobMarkup >= drComm.dblLevel16 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate16
                            ElseIf JobMarkup >= drComm.dblLevel17 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate17
                            ElseIf JobMarkup >= drComm.dblLevel18 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate18
                            ElseIf JobMarkup >= drComm.dblLevel19 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate19
                            ElseIf JobMarkup >= drComm.dblLevel20 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate20
                            Else
                                CommRate = 0
                            End If


                            If blnCommStructureNotSetProperly Then
                                Comm1.colorJobMarkup = Brushes.Red
                            End If

                        End If
                    Else
                        'no cost cannot calculate job markup or commission
                        'just assign .33

                        JobMarkup = 1
                        CommRate = drComm.dblRate1

                    End If

                    Comm1.CommRate = CommRate
                    JobNet = (SALETOTAL) - (COSTTOTAL)

                    If JobNet < 0 Then
                        ToPay = JobNet * drComm.dblJobCostRate
                    Else
                        ToPay = CommRate * JobNet
                    End If
                    JobBalanceDue = Decimal.Round(ToPay, 2) - decPaymentsTotal ' Payments1.PaymentTotal

                    Comm1.NetProfit = System.Decimal.Round(JobNet, 2)
                    Comm1.CommTotal = System.Decimal.Round(ToPay, 2)
                    Comm1.BalanceDue = System.Decimal.Round(JobBalanceDue, 2)

                    Comm1.ClickToPay = "PAID: " & System.Decimal.Round(decpaymentsThisDate, 2)
                    Comm1.decPortionToPay = 0

                    listComm1.commlist.Add(Comm1)
                    TotalToPay += decpaymentsThisDate
                Else
                    'doesnt have payments for this range
                    ocJobsNotShown.Add(Comm1)
                End If

            Next

            Me.gridcomm.DataContext = listComm1

            Me.lbJobsNotShown.ItemsSource = Nothing
            Dim q = From row In ocJobsNotShown Order By row.sJobNo.PadLeft(8, "0")
            Me.lbJobsNotShown.ItemsSource = q

            Me.tbDraws.Text = TwoDecimal(drawstotal1.DrawGrandTotal)
            Me.tbTotalNotSelected.Text = TwoDecimal(TotalToPay)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Try
                frmBusy.Close()
            Catch
            End Try

        End Try
    End Sub

    Private Sub getPOTotals(ByRef drJob As TKSIJOBSDataSet.tJobRow, ByRef SALE4010 As Decimal, ByRef SALE4030 As Decimal, ByRef SALE4040 As Decimal, ByRef SALE4070 As Decimal, ByRef SALETOTAL As Decimal, ByRef COST5010 As Decimal, ByRef COST5030 As Decimal, ByRef COST5040 As Decimal, ByRef COST5070 As Decimal, ByRef COST5490 As Decimal, ByRef COSTTOTAL As Decimal)

        Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
        For Each drPO In drJob.GettPOHeaderRows

            If UCase(drPO.sPOType) = "PO" Or UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                Select Case drPO.nAccount
                    Case 4010
                        SALE4010 += +drPO.nRetailSale + drPO.nAdd
                    Case 4020 'TOPS AND CABINETRY GO TOGETHER ON THIS SUMMARY 4010 and 4020
                        SALE4010 += drPO.nRetailSale + drPO.nAdd
                    Case 4030
                        SALE4030 += +drPO.nRetailSale + drPO.nAdd
                    Case 4040
                        SALE4040 += +drPO.nRetailSale + drPO.nAdd
                End Select
                SALETOTAL = SALETOTAL + drPO.nRetailSale + drPO.nAdd
                SALE4070 = SALE4070 + drPO.nRetailFreight

                Dim drPOLine As TKSIJOBSDataSet.tPOLineRow

                For Each drPOLine In drPO.GettPOLineRows
                    If UCase(drPOLine.sType) = "ITEM" Then

                        Select Case drPOLine.nAccountID
                            Case 5010
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5270
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5020
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5030
                                COST5030 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5040
                                COST5040 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5070
                                COST5070 += drPOLine.nCost
                                'somehow only include cost for shipping on PO that is a jobcost
                                'for jobs starting 2006 and newer
                                'does sale need to be included?
                                If drJob.dJobCreated > CDate("1/1/2006") Then
                                    If UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                                        COSTTOTAL += drPOLine.nCost
                                    End If
                                End If
                            Case 5490
                                If drPO.dPODate > CDate("11/1/2012") Then
                                    COST5490 += drPOLine.nCost
                                End If
                                COSTTOTAL += drPOLine.nCost
                            Case Else
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += +drPOLine.nCost

                        End Select
                    End If
                Next
            End If
        Next
    End Sub

    Dim dJobsAfter As Date = Now.AddYears(-2)
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.Top = 10
        Me.Left = 50
        Me.MaxHeight = global_ScreenHeight - 35
        ds1.EnforceConstraints = False
        Me.daCust.Fill(ds1.tCustomr)
        daComm.Fill(ds1.tblCommissionStructure)

        LoadPOSOinfo()

        daPay.FillByGTdjobcreated(ds1.tPayments, dJobsAfter)
        daDraws.Fill(ds1.tDraws)

    End Sub

    Private Sub LoadPOSOinfo()

        Dim daAdd As New TKSIJOBSDataSetTableAdapters.tAddressTableAdapter
        daAdd.FillByALL(ds1.tAddress)

        daCust.Fill(ds1.tCustomr)  'added , because of null

        daJ.FillByGTdjobcreated(ds1.tJob, dJobsAfter)
        daPOh.FillByGTdjobcreated(ds1.tPOHeader, dJobsAfter)
        daPOLine.FillByGTdjobcreated(ds1.tPOLine, dJobsAfter)
        Try
            daSOh.FillByGTdjobcreated(ds1.tSOHeader, dJobsAfter)
        Catch
            Try
                daSOh.FillByGTdjobcreated(ds1.tSOHeader, dJobsAfter)
            Catch
                MessageBox.Show("couldn't load invoices, try again or select a different date.")
            End Try

        End Try

        daSOLine.FillByGTdjobcreated(ds1.tSOLine, dJobsAfter)

    End Sub

    Public Class SplitPayment
        Public Property decAmount As Decimal
        Public Property strSalesNickname As String
        Public Property Jobid As Integer
    End Class

    Public Property listAdditionalSplitPaymentsNotForThisSalesperson As New ObservableCollection(Of SplitPayment)

    Private Sub btnClickTopay(sender As Object, e As RoutedEventArgs)
        Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
        drEmp = lbSalesperson.SelectedItem.row

        Dim comm1 As CommissionList = sender.datacontext
        Dim ToPay As Decimal = 0
        If Mid(comm1.ClickToPay, 1, 4) = "PAID" Then
            Dim decRemoving As Decimal = Decimal.Round(comm1.decPaymentsThisDate, 2)
            comm1.ClickToPay = "REMOVING: " & decRemoving
            comm1.colorClickToPay = Brushes.DarkRed

            If IsNumeric(Me.tbTotalSelected.Text) Then
                Me.tbTotalSelected.Text = CDec(tbTotalSelected.Text) + decRemoving
            Else
                tbTotalSelected.Text = decRemoving
            End If

        ElseIf Mid(comm1.ClickToPay, 1, 8) = "REMOVING" Then
            Dim decNotRemoving As Decimal = Decimal.Round(comm1.decPaymentsThisDate, 2)
            comm1.ClickToPay = "PAID: " & decNotRemoving
            comm1.colorClickToPay = Brushes.Gray

            If IsNumeric(Me.tbTotalSelected.Text) Then
                Me.tbTotalSelected.Text = CDec(tbTotalSelected.Text) - decNotRemoving
            Else
                tbTotalSelected.Text = decNotRemoving
            End If

        Else

            If drEmp.nickname <> comm1.salesnickname Then
                MessageBox.Show("you cannot pay additional amounts from this sales person screen, since this is not their job, you should use the job owners pay screen: " & comm1.salesnickname)
            Else
                If IsNumeric(comm1.BalanceDue) Then

                    ToPay = CDec(comm1.BalanceDue)

                    Dim paymentform As New CommPayment(drEmp.nickname, ToPay, comm1.nJobID)
                    '      paymentform.totalCanPay = ToPay
                    '      paymentform.sales = drEmp.nickname
                    paymentform.ShowDialog()

                    'Dim oPayment As New Payment
                    'oPayment.txtData.Text = ToPay
                    'oPayment.ShowDialog()
                    If paymentform.OK Then
                        ToPay = 0
                        For Each dic1 In paymentform.listReturnPaymentAmounts
                            If dic1.Key = drEmp.nickname Then
                                ToPay = dic1.Value
                            Else
                                Dim split1 As New SplitPayment
                                With split1
                                    .decAmount = dic1.Value
                                    .Jobid = comm1.nJobID
                                    .strSalesNickname = dic1.Key
                                End With
                                listAdditionalSplitPaymentsNotForThisSalesperson.Add(split1)
                                Me.lbSplitPayments.ItemsSource = listAdditionalSplitPaymentsNotForThisSalesperson

                            End If
                        Next
                        'ToPay = paymentform.txtAmount1.Text
                        If IsNumeric(ToPay) Then
                            comm1.ClickToPay = "PAY: " & TwoDecimal(ToPay)
                            comm1.colorClickToPay = Brushes.Blue
                            comm1.decPortionToPay = ToPay
                        Else
                            MessageBox.Show("Invalid amount to pay")
                        End If

                        If IsNumeric(Me.tbTotalSelected.Text) Then
                            Me.tbTotalSelected.Text = CDec(tbTotalSelected.Text) + ToPay
                        Else
                            tbTotalSelected.Text = ToPay
                        End If
                    Else
                        'payment for not OK'd
                    End If
                Else
                    MessageBox.Show("Balance Due is not valid")
                End If
            End If

        End If

    End Sub

    Private Sub JobNameButton_Click_1(sender As Object, e As Input.MouseButtonEventArgs)
        Try
            e.Handled = True
            Dim comm1 As CommissionList = sender.datacontext
            If comm1 IsNot Nothing Then

                OpenJobScreen(comm1.nAddressID, comm1.nJobID, True)

            End If
        Catch ex As Exception
            MessageBox.Show("error showing job on click " & ex.Message)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As RoutedEventArgs) Handles btnUpdate.Click
        Try
            Dim blnFailedToShow As Boolean = False
            Dim blnAddingNewDate As Boolean = True
            Dim drPay As TKSIJOBSDataSet.tPaymentsRow
            Dim drJob As TKSIJOBSDataSet.tJobRow
            Dim com1 As CommissionList
            Dim listComm1 As ocCommissions = Me.gridcomm.DataContext
            Dim blnHasSomePay As Boolean = False

            Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
            drEmp = lbSalesperson.SelectedItem.row

            If listComm1 IsNot Nothing Then
                For Each com1 In listComm1.commlist
                    drJob = ds1.tJob.FindBynID(com1.nJobID)
                    If Not drJob Is Nothing Then
                        If Mid(com1.ClickToPay, 1, 3) = "PAY" Then

                            If Me.datePayDate.SelectedDate > Now.AddYears(-2) Then
                                blnHasSomePay = True
                                drJob.dCommPaid = Me.datePayDate.SelectedDate
                                drPay = ds1.tPayments.NewtPaymentsRow
                                With drPay
                                    .JOBID = com1.nJobID
                                    .dDate = Me.datePayDate.SelectedDate
                                    .salesnickname = drEmp.nickname
                                    .nAmount = com1.decPortionToPay
                                End With
                                ds1.tPayments.Rows.Add(drPay)

                                For Each paysplit In listAdditionalSplitPaymentsNotForThisSalesperson
                                    If paysplit.Jobid = com1.nJobID Then
                                        drPay = ds1.tPayments.NewtPaymentsRow
                                        With drPay
                                            .JOBID = com1.nJobID
                                            .dDate = Me.datePayDate.SelectedDate
                                            .salesnickname = paysplit.strSalesNickname
                                            .nAmount = paysplit.decAmount
                                        End With
                                        ds1.tPayments.Rows.Add(drPay)
                                    End If
                                Next
                            Else
                                MessageBox.Show("No Pay Date")
                                blnFailedToShow = True
                            End If

                        ElseIf Mid(com1.ClickToPay, 1, 9) = "REMOVING:" Then

                            blnAddingNewDate = False

                            If com1.PaymentTotals.nPaymentID.Count > 0 Then
                                Dim blnFoundPayment As Boolean = False
                                For Each iPayment As Integer In com1.PaymentTotals.nPaymentID
                                    drPay = ds1.tPayments.FindBynID(iPayment)
                                    If drPay IsNot Nothing Then
                                        If drPay.dDate = CDate(Me.lbPayDates.SelectedItem) Then
                                            If blnFoundPayment Then
                                                MessageBox.Show("This payment amount appears more than once on this date or in the past, please verify amounts after finished.")
                                            End If
                                            blnFoundPayment = True
                                            drJob.SetdCommPaidNull()
                                            drPay.Delete()
                                        End If
                                    End If
                                Next
                            Else
                                MessageBox.Show("Payment not found. " & com1.JobDetails)

                            End If
                        End If
                    Else
                        MessageBox.Show("Job not found: " & com1.JobDetails)

                    End If

                Next

                If Not blnFailedToShow Then

                    Dim ipayupdate As Integer = daPay.Update(ds1.tPayments)
                    daJ.Update(ds1.tJob)

                    If blnAddingNewDate And datePayDate.SelectedDate IsNot Nothing Then
                        RefreshDateList(Me.datePayDate.SelectedDate)
                    End If

                    listAdditionalSplitPaymentsNotForThisSalesperson.Clear()

                    RefreshReport()
                End If
            End If



        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            ' frmwork.Close()
        End Try

    End Sub

    Private Sub RefreshDateList(dDate As Date)

        Dim listDates1 As paymentdates = Me.FindResource("listDates")
        Dim payDates As New paymentdates(dDate.ToShortDateString)
        listDates1 = payDates
        Me.lbPayDates.ItemsSource = listDates1

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As RoutedEventArgs) Handles btnPrint.Click
        Try
            Dim listComm1 As ocCommissions = Me.gridcomm.DataContext

            If lbSalesperson.SelectedItems.Count > 0 Then
                Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
                drEmp = lbSalesperson.SelectedItem.row

                If listComm1 IsNot Nothing Then
                    If lbPayDates.SelectedItems.Count > 0 Then
                       
                        Dim sDate As String = lbPayDates.SelectedItem.ToString

                        Dim drawstotal1 As DrawsTotals = LoadDrawsBalance(sDate, drEmp.nickname, ds1)

                        Try
                            PrintReport(drEmp, sDate, listComm1, drawstotal1)
                            ClosePDFFileAndPrint()
                        Catch ex As Exception
                            MessageBox.Show("error printing sales report:" & sDate)
                        End Try

                    Else
                        'print all unpaid
                        Try
                            Dim drawstotal1 As DrawsTotals
                            PrintReport(drEmp, "ALL UNPAID", listComm1, drawstotal1)
                            ClosePDFFileAndPrint()
                        Catch ex As Exception
                            MessageBox.Show("error printing ALL Unpaid report:" & drEmp.sName)
                        End Try
                    End If
                Else
                    MessageBox.Show("Error report is not yet loaded with data.")
                End If
            Else
                MessageBox.Show("Select a salesperson first.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPrintSalesPersonRpt_Click(sender As Object, e As RoutedEventArgs) Handles btnPrintSalesPersonRpt.Click
        Try
            Dim listComm1 As ocCommissions = Me.gridcomm.DataContext
            If listComm1 IsNot Nothing Then
                If lbSalesperson.SelectedItems.Count > 0 Then
                    Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
                    drEmp = lbSalesperson.SelectedItem.row
                    If lbPayDates.SelectedItems.Count > 0 Then
                        'run normal report
                        Dim sDate As String = lbPayDates.SelectedItem.ToString
                        Dim drawstotal1 As DrawsTotals = LoadDrawsBalance(sDate, drEmp.nickname, ds1)
                        Try
                            PrintSalesReport(drEmp, sDate, listComm1, drawstotal1)
                            ClosePDFFileAndPrint()
                        Catch ex As Exception
                            MessageBox.Show("error printing sales report:" & sDate)
                        End Try
                    Else
                        'run ALL UNPAID report
                        Dim drawstotalNull As DrawsTotals
                        Try
                            PrintSalesReport(drEmp, "ALL UNPAID", listComm1, drawstotalNull)
                            ClosePDFFileAndPrint()
                        Catch ex As Exception
                            MessageBox.Show("error printing All Unpaid sales report:" & drEmp.sName)
                        End Try
                    End If
                Else
                    MessageBox.Show("No salesperson has been selected.")
                End If
            Else
                MessageBox.Show("Report is not loaded with data.")
            End If
        Catch ex As Exception
            MessageBox.Show("error in btnPrintSalesPersonRpt_Click " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrintSalesPersonRptALL_Click(sender As Object, e As RoutedEventArgs) Handles btnPrintSalesPersonRptALL.Click
        Try
            PrintAllReports(True)
        Catch ex As Exception
            MessageBox.Show("error in btnPrintSalesPersonRpt_Click " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrintRptALL_Click(sender As Object, e As RoutedEventArgs) Handles btnPrintALL.Click
        Try
            PrintAllReports(False)
        Catch ex As Exception
            MessageBox.Show("error in btnPrintSalesPersonRpt_Click " & ex.Message)
        End Try
    End Sub

    Private Sub ClosePDFFileAndPrint()
        Try
            blnPDFFileInUse = False
            '-----Close Document 
            doc.Close()
            w.Flush()
            msDoc.Flush()
            w.Close()
            msDoc.Close()

            '-----------show PDF to user in default application for viewing (usually Acrobat)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Process.Start(tempPDF)
    End Sub

    Private Sub PrintAllReports(blnSalesReport As Boolean)
        Dim frmBusy As New winBusy
        frmBusy.Show()

        If lbPayDates.SelectedItems.Count > 0 Then
            Dim listsales As New salesperson
            Dim sDate As String = lbPayDates.SelectedItem.ToString
            Dim dDate As Date
            If Date.TryParse(sDate, dDate) Then

                Dim listNoReportPrinted As New List(Of String)

                For Each sales1 In listsales

                    Dim drawstotal1 As DrawsTotals = LoadDrawsBalance(sDate, sales1.nickname, ds1)

                    Dim calc1 As New commCalc
                    Dim listComm1 As ocCommissions = calc1.GetCommList(dDate, sales1.nickname, ds1)
                    If listComm1.commlist.Count > 0 Then  'dont print reports for salespeople with no sales
                        Try
                            If blnSalesReport Then
                                PrintSalesReport(sales1, sDate, listComm1, drawstotal1)
                            Else
                                PrintReport(sales1, sDate, listComm1, drawstotal1)
                            End If

                        Catch ex As Exception
                            MessageBox.Show("error printing sales report:" & sDate)
                        End Try
                    Else
                        listNoReportPrinted.Add(sales1.nickname)
                    End If
                Next

                If listNoReportPrinted.Count > 0 Then
                    PrintNotNeededList(listNoReportPrinted, sDate)
                End If

                ClosePDFFileAndPrint()

            Else
                MessageBox.Show("could not determine selected pay date to report on.")
            End If

        End If
        Try
            frmBusy.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private blnPDFFileInUse As Boolean = False
    Private doc As iTextSharp.text.Document
    Private msDoc As FileStream
    Private w As PdfWriter
    Private tempPDF As String = ""

    Private Sub PrintReport(_drEmp As TKSIJOBSDataSet.tEmployeeRow, _sDate As String, _listcomm1 As ocCommissions, _drawstotal1a As DrawsTotals)

        InitPDFFile()


        Dim iFontSize As Integer = 7
        Dim createCell As Func(Of String, Integer, PdfPCell) = Function(_sText As String, _colspan As Integer)
                                                                   Dim f1 As Font = New Font(Font.FontFamily.HELVETICA, iFontSize, Font.NORMAL)
                                                                   Dim cell1 As New PdfPCell(New Phrase(_sText, f1))
                                                                   cell1.Colspan = _colspan
                                                                   cell1.Border = 0
                                                                   Return cell1
                                                               End Function

        iFontSize = 9
        Dim str As String = "Commissions Report: " & _sDate
        Dim font1 As iTextSharp.text.Font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 9)

        Dim tableTitle As New PdfPTable(1)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False ' True
        tableTitle.AddCell(createCell(str, 1))
        str = "Salesperson: " & _drEmp.sName
        tableTitle.AddCell(createCell(str, 1))
        tableTitle.AddCell(createCell(" ", 1))
        doc.Add(tableTitle)

        iFontSize = 7

        Dim decPaymentsSum As Decimal = 0
        Dim decBalanceOwed As Decimal = 0

        For Each comm1 As CommissionList In _listcomm1.commlist
            Dim table As New PdfPTable(9)
            table.WidthPercentage = 100
            table.LockedWidth = False ' True
            Dim cell1 As PdfPCell = table.AddCell(createCell(comm1.JobDetails, 9))
            cell1.BackgroundColor = New BaseColor(244, 244, 244)

            With table
                .AddCell(createCell("", 1))
                .AddCell(createCell("", 1))
                .AddCell(createCell("Cabinetry:", 1))
                .AddCell(createCell(TwoDecimal(comm1.Total4010), 1))
                .AddCell(createCell("Cabinetry:", 1))
                .AddCell(createCell(TwoDecimal(comm1.Total5010), 1))

                .AddCell(createCell(TwoDecimal(comm1.Factor), 1))
                .AddCell(createCell("Net-Profit:$", 1))
                .AddCell(createCell(TwoDecimal(comm1.NetProfit), 1))

                .AddCell(createCell("CustPayment", 1))
                Dim colorCust As Color = DirectCast(comm1.colorPaymentFull, SolidColorBrush).Color
                cell1 = createCell(TwoDecimal(comm1.CustPayment), 1)
                cell1.BackgroundColor = New iTextSharp.text.BaseColor(colorCust.R, colorCust.G, colorCust.B)
                .AddCell(cell1)
                .AddCell(createCell("Hardware:", 1))
                .AddCell(createCell(comm1.Total4030, 1))
                .AddCell(createCell("Hardware:", 1))
                .AddCell(createCell(comm1.Total5030, 1))
                .AddCell(createCell("", 1))
                .AddCell(createCell("Comm Rate%", 1))
                .AddCell(createCell(TwoDecimal(comm1.CommRate), 1))

                .AddCell(createCell("Date:", 1))
                .AddCell(createCell(comm1.dDate, 1))
                .AddCell(createCell("Install:", 1))
                .AddCell(createCell(comm1.Total4040, 1))
                .AddCell(createCell("Install:", 1))
                .AddCell(createCell(comm1.Total5040, 1))
                .AddCell(createCell("", 1))
                .AddCell(createCell("Comm Total$", 1))
                .AddCell(createCell(comm1.CommTotal, 1))

                .AddCell(createCell("Contract$:", 1))
                .AddCell(createCell(TwoDecimal(comm1.Contract), 1))
                .AddCell(createCell("Total:", 1))
                .AddCell(createCell(TwoDecimal(comm1.TotalSale), 1))
                .AddCell(createCell("Total:", 1))
                .AddCell(createCell(TwoDecimal(comm1.TotalCost), 1))

                cell1 = createCell(TwoDecimal(comm1.JobMarkup), 1)
                Dim c1 As Color = DirectCast(comm1.colorJobMarkup, SolidColorBrush).Color
                cell1.BackgroundColor = New iTextSharp.text.BaseColor(c1.R, c1.G, c1.B)
                .AddCell(cell1)

                cell1 = createCell(comm1.ClickToPay, 2)
                cell1.BackgroundColor = New iTextSharp.text.BaseColor(244, 244, 244)
                cell1.HorizontalAlignment = Element.ALIGN_CENTER
                .AddCell(cell1)

                .AddCell(createCell("", 7))
                .AddCell(createCell("Balance Due: " & TwoDecimal(comm1.BalanceDue), 2))
                '    .AddCell(cell1)

                .AddCell(createCell(" ", 9))
            End With
            doc.Add(table)

            decPaymentsSum += comm1.decPaymentsThisDate
            decBalanceOwed += comm1.BalanceDue
        Next

        Dim line1 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        doc.Add(New Chunk(line1))

        If _sDate = "ALL UNPAID" Then
            Dim strTotalUnpaid As String = "Unpaid Total: " & TwoDecimal(decBalanceOwed)
            Dim tableTotalUnpaid As New PdfPTable(9)
            With tableTotalUnpaid
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strTotalUnpaid, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotalUnpaid)

            tableTotalUnpaid = New PdfPTable(9)
            With tableTotalUnpaid
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell("Draws not shown on All Unpaid", 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotalUnpaid)
        Else

            Dim strTotal As String = "Sub-Total: " & TwoDecimal(decPaymentsSum)
            Dim tableTotal As New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strTotal, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotal)

            Dim strDraw As String = ""
            Dim strDrawsToday As String = ""
            Dim strGrandTotal As String = "" '"Total Paid: " & TwoDecimal(decPaymentsSum + _drawstotal1.DrawTotalToday)

            If _drawstotal1a Is Nothing Then
                strDraw = "Draws not loaded on All Unpaid"
                strDrawsToday = "Draws not loaded"
                strGrandTotal = "Draws not loaded"
            Else
                strDraw = "Previous Draws: " & TwoDecimal(_drawstotal1a.DrawGrandTotal - _drawstotal1a.DrawTotalToday)
                strDrawsToday = "Todays Draws: " & TwoDecimal(_drawstotal1a.DrawTotalToday)
                strGrandTotal = "Total Paid: " & TwoDecimal(decPaymentsSum + _drawstotal1a.DrawTotalToday)
            End If

            tableTotal = New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strDraw, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotal)

            'Dim strDrawsToday As String =  "Todays Draws: " & TwoDecimal(_drawstotal1a.DrawTotalToday)
            tableTotal = New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strDrawsToday, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotal)

            tableTotal = New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strGrandTotal, 2))
            End With
            doc.Add(tableTotal)

        End If

      
        '----------Footer DateTime printed
        w.DirectContent.BeginText()
        w.DirectContent.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED), 7)
        w.DirectContent.SetTextMatrix(doc.Left, doc.GetBottom(0))
        w.DirectContent.ShowText("Reported Generated: " & Now.ToString)
        w.DirectContent.EndText()


        ''-----Close Document 
        'doc.Close()
        'w.Flush()
        'msDoc.Flush()
        'w.Close()
        'msDoc.Close()

        ''-----------show PDF to user in default application for viewing (usually Acrobat)
        'Process.Start(tempPDF)
    End Sub

    Private Sub PrintNotNeededList(_list As List(Of String), _sDate As String)

        InitPDFFile()

        'Dim tempPDF As String = Path.GetTempFileName & ".PDF"
        'Dim doc As iTextSharp.text.Document
        'doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 70, 70, 30, 30)

        'Dim msDoc As New FileStream(tempPDF, FileMode.Create)
        'Dim w As PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, msDoc)
        'w.CloseStream = False
        'doc.Open()

        Dim iFontSize As Integer = 7
        Dim createCell As Func(Of String, Integer, PdfPCell) = Function(_sText As String, _colspan As Integer)
                                                                   Dim f1 As Font = New Font(Font.FontFamily.HELVETICA, iFontSize, Font.NORMAL)
                                                                   Dim cell1 As New PdfPCell(New Phrase(_sText, f1))
                                                                   cell1.Colspan = _colspan
                                                                   cell1.Border = 0
                                                                   Return cell1
                                                               End Function

        iFontSize = 10
        Dim str As String = "No commissions report needed for salespeople listed on date: " & _sDate
        Dim font1 As iTextSharp.text.Font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 9)


        Dim tableTitle As New PdfPTable(1)
        With tableTitle
            .WidthPercentage = 100
            .LockedWidth = False ' True
            .AddCell(createCell(str, 1))
            .AddCell(createCell(" ", 1))
        End With

        doc.Add(tableTitle)

        Dim line1 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        doc.Add(New Chunk(line1))

        For Each strSales In _list
            Dim tableTitle2 As New PdfPTable(1)
            With tableTitle2
                .WidthPercentage = 100
                .LockedWidth = False ' True
                .AddCell(createCell(strSales, 1))
                .AddCell(createCell(" ", 1))

            End With

            doc.Add(tableTitle2)
        Next



        '----------Footer DateTime printed
        w.DirectContent.BeginText()
        w.DirectContent.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED), 7)
        w.DirectContent.SetTextMatrix(doc.Left, doc.GetBottom(0))
        w.DirectContent.ShowText("Reported Generated: " & Now.ToString)
        w.DirectContent.EndText()


        ''-----Close Document 
        'doc.Close()
        'w.Flush()
        'msDoc.Flush()
        'w.Close()
        'msDoc.Close()

        ''-----------show PDF to user in default application for viewing (usually Acrobat)
        'Process.Start(tempPDF)
    End Sub

    Private Sub InitPDFFile()
        If blnPDFFileInUse Then
            'use existing PDF objects
            doc.NewPage()
        Else
            doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 70, 70, 30, 30)
            tempPDF = Path.GetTempFileName & ".PDF"
            msDoc = New FileStream(tempPDF, FileMode.Create)
            w = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, msDoc)
            w.CloseStream = False
            doc.Open()
            blnPDFFileInUse = True
        End If
    End Sub

    Private Sub PrintSalesReport(_drEmp As TKSIJOBSDataSet.tEmployeeRow, _sDate As String, _listcomm1 As ocCommissions, _drawstotal1 As DrawsTotals)

        InitPDFFile()

        Dim iFontSize As Integer = 7
        Dim createCell As Func(Of String, Integer, PdfPCell) = Function(_sText As String, _colspan As Integer)
                                                                   Dim f1 As Font = New Font(Font.FontFamily.HELVETICA, iFontSize, Font.NORMAL)
                                                                   Dim cell1 As New PdfPCell(New Phrase(_sText, f1))
                                                                   cell1.Colspan = _colspan
                                                                   cell1.Border = 0
                                                                   Return cell1
                                                               End Function

        Dim font1 As iTextSharp.text.Font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 9)

        iFontSize = 12
        Dim str As String = "THE KITCHEN SHOWCASE, INC."
        Dim tableTitle As New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = _drEmp.sName
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        iFontSize = 7
        str = "6528 S. Racine Cir"
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = ""
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        str = "Centennial, CO 80111"
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = _drEmp.Address
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        str = "303-799-9200"
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = _drEmp.CityStateZip
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        str = ""
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = "Phone: " & _drEmp.Phone
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        str = ""
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = "SS# " & _drEmp.SS
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        str = ""
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = "Claims: " & _drEmp.Claims
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        str = "Pay Period: " & _sDate
        tableTitle = New PdfPTable(2)
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(str, 1))
        str = "Status: " & _drEmp.Status
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        tableTitle = New PdfPTable(1)   'spacer
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(" ", 1))
        doc.Add(tableTitle)

        Dim line1 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        doc.Add(New Chunk(line1))

        tableTitle = New PdfPTable(1)   'spacer
        tableTitle.WidthPercentage = 100
        tableTitle.LockedWidth = False
        tableTitle.AddCell(createCell(" ", 1))
        doc.Add(tableTitle)

        iFontSize = 7

        Dim daAdd As New TKSIJOBSDataSetTableAdapters.tAddressTableAdapter

        Dim decBalanceOwed As Decimal = 0
        Dim decPaymentsSum As Decimal = 0
        For Each comm1 As CommissionList In _listcomm1.commlist
            Dim table As New PdfPTable(2)
            table.WidthPercentage = 100
            table.LockedWidth = False ' True
            Dim cell1 As PdfPCell
            cell1 = createCell(comm1.JobDetails, 1)
            cell1.BackgroundColor = New iTextSharp.text.BaseColor(244, 244, 244)
            table.AddCell(cell1)

            ' If jobcost then
            If comm1.CommTotal = 0 Then
                table.AddCell(createCell("JOBCOST", 1))
            Else
                table.AddCell(createCell("Due on Job: " & TwoDecimal(comm1.CommTotal), 1))
            End If

            Dim strAddress As String = "** Address **"
            Dim drJob As TKSIJOBSDataSet.tJobRow = Me.ds1.tJob.FindBynID(comm1.nJobID)
            If drJob IsNot Nothing Then
                If daAdd.Fill(Me.ds1.tAddress, drJob.nAddressID) > 0 Then
                    Dim dradd As TKSIJOBSDataSet.tAddressRow = drJob.tAddressRow
                    dradd = drJob.tAddressRow
                    strAddress = dradd.sAddress1 & " " & dradd.sAddress2 & ", " & dradd.sCity
                End If
            End If
            table.AddCell(createCell(strAddress, 1))

            If comm1.PaymentTotals.PaymentCount = 1 Then
                table.AddCell(createCell("PAYMENT: " & TwoDecimal(comm1.decPaymentsThisDate), 1))
            Else
                table.AddCell(createCell("PARTIAL PAYMENT: " & TwoDecimal(comm1.decPaymentsThisDate), 1))
            End If

            If comm1.PaymentTotals.PaymentTotal = comm1.CommTotal Then
                table.AddCell(createCell(" ", 1))
                table.AddCell(createCell("PAID IN FULL", 1))
            Else
                table.AddCell(createCell(" ", 1))
                table.AddCell(createCell("Balance Owed: " & TwoDecimal(comm1.CommTotal - comm1.PaymentTotals.PaymentTotal), 1))
            End If

            table.AddCell(createCell(" ", 2)) 'spacer
            doc.Add(table)
            decPaymentsSum += comm1.decPaymentsThisDate
            decBalanceOwed += comm1.BalanceDue
        Next

        line1 = New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        doc.Add(New Chunk(line1))

        If _sDate = "ALL UNPAID" Then
            Dim strTotalUnpaid As String = "Unpaid Total: " & TwoDecimal(decBalanceOwed)
            Dim tableTotalUnpaid As New PdfPTable(9)
            With tableTotalUnpaid
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strTotalUnpaid, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotalUnpaid)

            tableTotalUnpaid = New PdfPTable(9)
            With tableTotalUnpaid
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell("Draws not shown on All Unpaid", 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotalUnpaid)
        Else

            Dim strTotal As String = "Sub-Total: " & TwoDecimal(decPaymentsSum)
            Dim tableTotal As New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strTotal, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotal)

            Dim strDraw As String = "Previous Draws: " & TwoDecimal(_drawstotal1.DrawGrandTotal - _drawstotal1.DrawTotalToday)
            tableTotal = New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strDraw, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotal)

            Dim strDrawsToday As String = "Todays Draws: " & TwoDecimal(_drawstotal1.DrawTotalToday)
            tableTotal = New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strDrawsToday, 2))
                .AddCell(createCell(" ", 9))
            End With
            doc.Add(tableTotal)

            Dim strGrandTotal As String = "Total Paid: " & TwoDecimal(decPaymentsSum + _drawstotal1.DrawTotalToday)
            tableTotal = New PdfPTable(9)
            With tableTotal
                .WidthPercentage = 100
                .LockedWidth = False
                .AddCell(createCell("", 7))
                .AddCell(createCell(strGrandTotal, 2))
            End With
            doc.Add(tableTotal)
        End If

        w.DirectContent.BeginText()

        w.DirectContent.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED), 7)
        w.DirectContent.SetTextMatrix(doc.Left, doc.GetBottom(0))
        w.DirectContent.ShowText("Reported Generated: " & Now.ToString)
        w.DirectContent.EndText()

        'doc.Close()
        'w.Flush()
        'msDoc.Flush()
        'w.Close()
        'msDoc.Close()
        'Process.Start(tempPDF)
    End Sub

    Private Sub btnAddDraw_Click(sender As Object, e As RoutedEventArgs) Handles btnAddDraw.Click
        If lbSalesperson.SelectedItems.Count > 0 And lbPayDates.SelectedItems.Count > 0 Then
            Dim frmDraw1 As New frmAddDraw
            frmDraw1.ShowDialog()
            If frmDraw1.OK Then

                Dim sDate As String = lbPayDates.SelectedItem.ToString
                Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
                drEmp = lbSalesperson.SelectedItem.row

                Dim drDraw As TKSIJOBSDataSet.tDrawsRow
                drDraw = Me.ds1.tDraws.NewtDrawsRow
                With drDraw
                    .DrawAmount = frmDraw1.DrawAmount
                    .DrawDate = frmDraw1.drawDate
                    .Salesperson = drEmp.nickname
                End With
                Me.ds1.tDraws.Rows.Add(drDraw)
                daDraws.Update(ds1.tDraws)
                RefreshReport()
            End If

        Else
            MessageBox.Show("Invalid salesperson or date selected from lists.")
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Try
            Dim comm1 As CommissionList = sender.datacontext
            If Not comm1 Is Nothing Then
                If comm1 IsNot Nothing Then

                    OpenJobScreen(comm1.nAddressID, comm1.nJobID, True)

                    LoadPOSOinfo() ''update PO info
                    RefreshReport()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Class clsJobComm
        Inherits clsJob
        Sub New(_sJobno As String)
            MyBase.New(_sJobno)
        End Sub

        Public ReadOnly Property paydatelist As String
            Get
                Dim strReturn As String = ""
                Dim dtPay As New dsTKSI.tPaymentsDataTable
                Dim daPayments As New dsTKSITableAdapters.tPaymentsTableAdapter
                If daPayments.FillByJOBID(dtPay, JobID) > 0 Then
                    For Each drP As dsTKSI.tPaymentsRow In dtPay
                        strReturn = strReturn & drP.dDate.ToShortDateString & " "
                    Next
                End If
                Return strReturn
            End Get
        End Property
    End Class

    Private Sub btnFind_Click(sender As Object, e As RoutedEventArgs) Handles btnFind.Click
        Try
            Me.tbFindResult.Text = ""
            If Me.txtFind.Text.Trim.Length > 4 Then
                Dim job1 As New clsJobComm(Me.txtFind.Text.Trim)
                If job1.JobID > 0 Then
                    Dim strPaid As String = job1.paydatelist
                    If strPaid.Length > 0 Then
                        Me.tbFindResult.Text = "Paid: " & job1.paydatelist.Trim & " (" & job1.Salesperson & ")"

                    Else
                        Me.tbFindResult.Text = "No Dates"
                    End If

                    For Each item1 In Me.lbComm.Items
                        If item1.GetType Is GetType(CommissionList) Then
                            Dim cmm As CommissionList = DirectCast(item1, CommissionList)
                            If cmm.nJobID = job1.JobID Then
                                Dim ocComm As ocCommissions = Me.gridcomm.DataContext
                                ocComm.selectedcomm = cmm

                                lbComm.ScrollIntoView(item1)
                                Me.tbFindResult.Text = cmm.salesnickname & " All Unpaid " & cmm.dDate
                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("error in Find: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As RoutedEventArgs) Handles btnRefresh.Click
        Dim frmBusy As New frmWorking
        frmBusy.Show()
        LoadPOSOinfo() ''update PO info
        RefreshReport()
        frmBusy.Close()
    End Sub

    Private Sub btnPrintALL_Click(sender As Object, e As RoutedEventArgs) Handles btnPrintALL.Click

        Dim listComm1 As ocCommissions = Me.gridcomm.DataContext
        If listComm1 IsNot Nothing Then
            Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
            drEmp = lbSalesperson.SelectedItem.row
            Dim sDate As String = lbPayDates.SelectedItem.ToString
            Dim drawstotal1 As DrawsTotals = LoadDrawsBalance(sDate, drEmp.nickname, ds1)
        End If


    End Sub

    Private Class commCalc

        Public Function GetCommList(_Date As Date, sSales As String, ds1 As TKSIJOBSDataSet) As ocCommissions

            Dim SALE4040, SALE4010, SALE4030, SALE4070 As Decimal
            Dim COST5030, SALETOTAL, COST5010, COST5040, COST5490 As Decimal
            Dim COSTTOTAL, COST5070, JobNet As Decimal
            Dim CommRate As Decimal = 0
            Dim JobMarkup As Decimal = 0
            Dim ToPay As Decimal
            'TotalToPay stores sum of all commissions still due AFTER partial payments
            Dim TotalToPay As Decimal
            'job balance due should show commissions still due to salesperson AFTER partial payments

            Dim JobBalanceDue As Decimal
            Dim drJob As TKSIJOBSDataSet.tJobRow

            Dim listComm1 As ocCommissions = New ocCommissions
            listComm1.commlist.Clear()

            Dim listJob As New List(Of TKSIJOBSDataSet.tJobRow)
            For Each paytemp In (From row In ds1.tPayments Where row.salesnickname = sSales And row.dDate = _Date) '' jobs  this sales person has a payment for
                If (From row In listJob Where row.nID = paytemp.JOBID).Count = 0 Then  'dont duplidate entry
                    Dim qJob = (From row In ds1.tJob Where row.nID = paytemp.JOBID)
                    If qJob.Count = 1 Then

                        listJob.Add(qJob.First)  'jobs that this salesperson has a payment on (even if its not their job)
                    Else
                        MessageBox.Show("error payment exists with invalid jobid: " & paytemp.JOBID)
                        Exit For
                    End If
                End If
            Next

            Dim drPay As TKSIJOBSDataSet.tPaymentsRow
            For Each drJob In (From row In listJob Order By row.dJobCreated)

                Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
                Dim iStructureToUse As Integer = 1
                Dim blnCommStructureNotSetProperly As Boolean = False
                If drJob.lngCommissionStruct = 0 Then
                    iStructureToUse = GetDefaultPriorityCommStructureID(ds1)
                    blnCommStructureNotSetProperly = True
                Else
                    iStructureToUse = drJob.lngCommissionStruct
                End If
                drComm = ds1.tblCommissionStructure.FindBylngID(iStructureToUse)

                If drComm Is Nothing Then
                    MessageBox.Show("Error loading comm structure for job ID: " & drJob.nID & "   comm structure: " & iStructureToUse & " " & drJob.sJobNo)
                    Exit For
                End If

                Dim blnHasPaymentsForThisDate As Boolean = False
                Dim decPaymentsTotal As Decimal = 0
                Dim decpaymentsThisDate As Decimal = 0
                For Each drPay In drJob.GettPaymentsRows
                    If drPay.dDate = _Date And drPay.salesnickname = sSales Then
                        If blnHasPaymentsForThisDate Then
                            MessageBox.Show(drJob.sJobNo & " has multiple payments on a single date, this should not happen, please rebuild the payment date for : " & sSales)
                        End If
                        blnHasPaymentsForThisDate = True
                        decpaymentsThisDate += drPay.nAmount
                    End If
                    decPaymentsTotal += drPay.nAmount
                Next

                Dim Comm1 As New CommissionList

                If drJob.sSalesperson <> sSales Then
                    Comm1.JobDetails = "(FROM SPLIT PAYMENT) "
                Else
                    Comm1.JobDetails = ""
                End If
                Comm1.JobDetails = Comm1.JobDetails & "Job: " & drJob.sJobNo & " - " & drJob.tCustomrRow.sName & " - " & drJob.sJobDesc

                Comm1.salesnickname = drJob.sSalesperson

                Comm1.nJobID = drJob.nID
                Comm1.nAddressID = drJob.nAddressID
                Comm1.sJobNo = drJob.sJobNo

                If blnHasPaymentsForThisDate Then
                    SALE4010 = 0
                    SALE4030 = 0
                    SALE4040 = 0
                    SALE4070 = 0
                    SALETOTAL = 0
                    COST5010 = 0
                    COST5030 = 0
                    COST5040 = 0
                    COST5070 = 0
                    COST5490 = 0
                    COSTTOTAL = 0
                    getPOTotals(drJob, SALE4010, SALE4030, SALE4040, SALE4070, SALETOTAL, COST5010, COST5030, COST5040, COST5070, COST5490, COSTTOTAL)

                    Dim decInvoiceAmount As Decimal = 0
                    Dim blnInvoiceExists As Boolean = False
                    Dim drSO As TKSIJOBSDataSet.tSOHeaderRow
                    For Each drSO In drJob.GettSOHeaderRows
                        Dim drLine As TKSIJOBSDataSet.tSOLineRow
                        For Each drLine In drSO.GettSOLineRows
                            If UCase(drLine.sType) = "COMMENT" And drLine.nAmount < 0 Then
                                decInvoiceAmount += drLine.nAmount
                            End If
                        Next
                        blnInvoiceExists = True
                    Next
                    Comm1.PaymentTotals = PaymentsTotal(drJob, _Date)
                    Comm1.decPaymentsFromAnyDates = decPaymentsTotal
                    Comm1.decPaymentsThisDate = decpaymentsThisDate
                    Comm1.CustPayment = decInvoiceAmount
                    Dim decContract As Decimal = Decimal.Round(CDec(drJob.nMaterialsCharge + (drJob.nMaterialsCharge * drJob.nTaxRate / 100) + drJob.nLaborCharge), 2)
                    Comm1.Contract = decContract

                    If -(decInvoiceAmount) >= (decContract - 1) And (-decInvoiceAmount > 0) Then
                        Comm1.colorPaymentFull = Brushes.PaleGreen
                    Else
                        Comm1.colorPaymentFull = Brushes.Yellow
                    End If

                    Comm1.dDate = drJob.dJobCreated.ToShortDateString
                    Comm1.Total4010 = System.Decimal.Round(SALE4010, 2)
                    Comm1.Total4030 = System.Decimal.Round(SALE4030, 2)
                    Comm1.Total4040 = System.Decimal.Round(SALE4040, 2)

                    Comm1.Total5010 = System.Decimal.Round(COST5010, 2)
                    Comm1.Total5030 = System.Decimal.Round(COST5030, 2)
                    Comm1.Total5040 = System.Decimal.Round(COST5040, 2)

                    Comm1.TotalSale = TwoDecimal(SALETOTAL)
                    Comm1.TotalCost = TwoDecimal(COSTTOTAL)

                    If COST5010 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4010 - COST5010) / COST5010, 2).ToString.TrimStart("0")
                    End If
                    If COST5030 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4030 - COST5030) / COST5030, 2).ToString.TrimStart("0")
                    End If
                    If COST5040 > 0 Then
                        Comm1.Factor = System.Decimal.Round((SALE4040 - COST5040) / COST5040, 2).ToString.TrimStart("0")
                    End If

                    If COSTTOTAL > 0 Then
                        Dim costtotalminusfindersfee As Decimal = COSTTOTAL - COST5490
                        If costtotalminusfindersfee = 0 Then
                            JobMarkup = 0
                        Else
                            JobMarkup = SALETOTAL / (COSTTOTAL - COST5490) 'exclude finders fee from markup calculation
                        End If

                        '  JobMarkup = SALETOTAL / (COSTTOTAL - COST5490) 'exclude finders fee from markup calculation
                        Comm1.JobMarkup = (Decimal.Truncate(JobMarkup * 100)) / 100
                        If IsNumeric(Comm1.JobMarkup) Then
                            If JobMarkup >= drComm.dblLevel1 Then
                                CommRate = drComm.dblRate1
                                Comm1.colorJobMarkup = Brushes.PaleTurquoise ' global_BrushFromHex(&HAA, &HFF, &HDD) 'Brushes.paleblue
                            ElseIf JobMarkup >= drComm.dblLevel2 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate2
                            ElseIf JobMarkup >= drComm.dblLevel3 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate3
                            ElseIf JobMarkup >= drComm.dblLevel4 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate4
                            ElseIf JobMarkup >= drComm.dblLevel5 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate5
                            ElseIf JobMarkup >= drComm.dblLevel6 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate6
                            ElseIf JobMarkup >= drComm.dblLevel7 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate7
                            ElseIf JobMarkup >= drComm.dblLevel8 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate8
                            ElseIf JobMarkup >= drComm.dblLevel9 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate9
                            ElseIf JobMarkup >= drComm.dblLevel10 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate10
                            ElseIf JobMarkup >= drComm.dblLevel11 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate11
                            ElseIf JobMarkup >= drComm.dblLevel12 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate12
                            ElseIf JobMarkup >= drComm.dblLevel13 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate13
                            ElseIf JobMarkup >= drComm.dblLevel14 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate14
                            ElseIf JobMarkup >= drComm.dblLevel15 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate15
                            ElseIf JobMarkup >= drComm.dblLevel16 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate16
                            ElseIf JobMarkup >= drComm.dblLevel17 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate17
                            ElseIf JobMarkup >= drComm.dblLevel18 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate18
                            ElseIf JobMarkup >= drComm.dblLevel19 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate19
                            ElseIf JobMarkup >= drComm.dblLevel20 Then
                                Comm1.colorJobMarkup = Brushes.Yellow
                                CommRate = drComm.dblRate20
                            Else
                                CommRate = 0
                            End If


                            If blnCommStructureNotSetProperly Then
                                Comm1.colorJobMarkup = Brushes.Red
                            End If

                        End If
                    Else
                        'no cost cannot calculate job markup or commission
                        'just assign .33

                        JobMarkup = 1
                        CommRate = drComm.dblRate1

                    End If

                    Comm1.CommRate = CommRate
                    JobNet = (SALETOTAL) - (COSTTOTAL)

                    If JobNet < 0 Then
                        ToPay = JobNet * drComm.dblJobCostRate
                    Else
                        ToPay = CommRate * JobNet
                    End If
                    JobBalanceDue = Decimal.Round(ToPay, 2) - decPaymentsTotal ' Payments1.PaymentTotal

                    Comm1.NetProfit = System.Decimal.Round(JobNet, 2)
                    Comm1.CommTotal = System.Decimal.Round(ToPay, 2)
                    Comm1.BalanceDue = System.Decimal.Round(JobBalanceDue, 2)

                    Comm1.ClickToPay = "PAID: " & System.Decimal.Round(decpaymentsThisDate, 2)
                    Comm1.decPortionToPay = 0

                    listComm1.commlist.Add(Comm1)
                    TotalToPay += decpaymentsThisDate
                Else
                    'doesnt have payments for this range

                End If

            Next

            Return listComm1
        End Function

        Private Function GetDefaultPriorityCommStructureID(ds1 As TKSIJOBSDataSet) As Integer
            Dim drComm As TKSIJOBSDataSet.tblCommissionStructureRow
            For Each drComm In ds1.tblCommissionStructure
                If drComm.lngPriority = 1 Then
                    Return drComm.lngID
                End If
            Next
            Return 17
        End Function

        Private Function PaymentsTotal(ByRef drJob As TKSIJOBSDataSet.tJobRow, _Date As Date) As CommissionList.clsPaymentsTotals
            Dim pay1 As New CommissionList.clsPaymentsTotals
            Dim drPay As TKSIJOBSDataSet.tPaymentsRow
            'show all payments that are up to today, if we are looking at a past AR sheet
            'entries we want the system to appear that it does not know about future payments
            For Each drPay In drJob.GettPaymentsRows

                If CDate(_Date) >= drPay.dDate Then
                    pay1.PaymentCount += 1
                    pay1.PaymentTotal += +drPay.nAmount
                    pay1.nPaymentID.Add(drPay.nID)
                End If

            Next

            Return pay1
        End Function

        Private Sub getPOTotals(ByRef drJob As TKSIJOBSDataSet.tJobRow, ByRef SALE4010 As Decimal, ByRef SALE4030 As Decimal, ByRef SALE4040 As Decimal, ByRef SALE4070 As Decimal, ByRef SALETOTAL As Decimal, ByRef COST5010 As Decimal, ByRef COST5030 As Decimal, ByRef COST5040 As Decimal, ByRef COST5070 As Decimal, ByRef COST5490 As Decimal, ByRef COSTTOTAL As Decimal)

            Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
            For Each drPO In drJob.GettPOHeaderRows

                If UCase(drPO.sPOType) = "PO" Or UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                    Select Case drPO.nAccount
                        Case 4010
                            SALE4010 += +drPO.nRetailSale + drPO.nAdd
                        Case 4020 'TOPS AND CABINETRY GO TOGETHER ON THIS SUMMARY 4010 and 4020
                            SALE4010 += drPO.nRetailSale + drPO.nAdd
                        Case 4030
                            SALE4030 += +drPO.nRetailSale + drPO.nAdd
                        Case 4040
                            SALE4040 += +drPO.nRetailSale + drPO.nAdd
                    End Select
                    SALETOTAL = SALETOTAL + drPO.nRetailSale + drPO.nAdd
                    SALE4070 = SALE4070 + drPO.nRetailFreight

                    Dim drPOLine As TKSIJOBSDataSet.tPOLineRow

                    For Each drPOLine In drPO.GettPOLineRows
                        If UCase(drPOLine.sType) = "ITEM" Then

                            Select Case drPOLine.nAccountID
                                Case 5010
                                    COST5010 += drPOLine.nCost
                                    COSTTOTAL += drPOLine.nCost

                                Case 5270
                                    COST5010 += drPOLine.nCost
                                    COSTTOTAL += drPOLine.nCost

                                Case 5020
                                    COST5010 += drPOLine.nCost
                                    COSTTOTAL += drPOLine.nCost

                                Case 5030
                                    COST5030 += drPOLine.nCost
                                    COSTTOTAL += drPOLine.nCost

                                Case 5040
                                    COST5040 += drPOLine.nCost
                                    COSTTOTAL += drPOLine.nCost

                                Case 5070
                                    COST5070 += drPOLine.nCost
                                    'somehow only include cost for shipping on PO that is a jobcost
                                    'for jobs starting 2006 and newer
                                    'does sale need to be included?
                                    If drJob.dJobCreated > CDate("1/1/2006") Then
                                        If UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                                            COSTTOTAL += drPOLine.nCost
                                        End If
                                    End If
                                Case 5490
                                    If drPO.dPODate > CDate("11/1/2012") Then
                                        COST5490 += drPOLine.nCost
                                    End If
                                    COSTTOTAL += drPOLine.nCost
                                Case Else
                                    COST5010 += drPOLine.nCost
                                    COSTTOTAL += +drPOLine.nCost

                            End Select
                        End If
                    Next
                End If
            Next
        End Sub
    End Class

End Class
