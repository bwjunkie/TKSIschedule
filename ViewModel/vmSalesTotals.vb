Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight.Command

Public Class vmSalesTotals
    Inherits MyViewModelBase

    Public dc As linqTKSIDataContext = GetLinqDataContext()

    Public ReadOnly Property SalesList As ObservableCollection(Of SalesTotal)
        Get
            Dim ret = New ObservableCollection(Of SalesTotal)
            If WeekFrom IsNot Nothing And WeekTo IsNot Nothing Then
                Dim q = (From row In dc.tEmployees Where row.archive = False Order By row.sequence)
                For Each emp In q
                    Dim salestotal1 As New SalesTotal(emp, WeekFrom, WeekTo, dc)
                    ret.Add(salestotal1)
                Next
            End If

            Return ret
        End Get
    End Property

    Dim _weekfrom As Date?
    Public Property WeekFrom As Date?
        Get
            Return _weekfrom
        End Get
        Set(value As Date?)
            _weekfrom = value
            If _weekfrom IsNot Nothing Then
                WeekTo = CDate(_weekfrom).AddDays(4).AddHours(23)
            End If
            RaisePropertyChanged("WeekFrom")
            RaisePropertyChanged("MonthFrom")
        End Set
    End Property

    Dim _weekto As Date?
    Public Property WeekTo As Date?
        Get
            Return _WeekTo
        End Get
        Set(value As Date?)
            _weekto = value
            RaisePropertyChanged("WeekTo")
            RaisePropertyChanged("MonthTo")
        End Set
    End Property

    Public ReadOnly Property MonthFrom As String
        Get
            Dim d As DateTime
            If WeekFrom IsNot Nothing Then
                d = New DateTime(CDate(WeekFrom).Year, CDate(WeekFrom).Month, 1)
                Return d.ToShortDateString
            End If

            Return ""
        End Get
    End Property

    Public ReadOnly Property MonthTo As String
        Get
            Dim d As DateTime
            If WeekTo IsNot Nothing Then
                d = New DateTime(CDate(WeekFrom).Year, CDate(WeekTo).Month, Date.DaysInMonth(CDate(WeekFrom).Year, CDate(WeekTo).Month))
                d = d.AddHours(23)  ' in case compare doesn't catch last day of month with few hours into the day
                Return d.ToShortDateString
            End If

            Return ""
        End Get
    End Property

    Public ReadOnly Property grandtotalweek As Decimal
        Get
            Try
                Dim q = (From row In SalesList Select row.weektotal).Sum
                Return q
            Catch ex As Exception
                Return -1.0
            End Try


        End Get
    End Property

    Public ReadOnly Property grandtotalmonth As Decimal
        Get
            Try
                Dim q = (From row In SalesList Select row.monthtotal).Sum
                Return q
            Catch ex As Exception
                Return -1.0
            End Try
        End Get
    End Property

    Private Sub refreshtotals()
        Dim busy1 As New winBusy
        Try
            busy1.Show()
            RaisePropertyChanged("SalesList")
            RaisePropertyChanged("grandtotalweek")
            RaisePropertyChanged("grandtotalmonth")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            busy1.Close()
        End Try


    End Sub

    Private Sub printreport()
        Dim busy1 As New winBusy
        Try
            busy1.Show()
            Dim fontsz = 11
            Dim fontst = 0

            Dim rep As New clsPDFCreate("Sales Totals ")
            With rep

                .AddParagraphToPDF(" ")
                .AddParagraphToPDF(rep.ColTextPad("", "Dates: " & CDate(WeekFrom).ToShortDateString & " to " & CDate(WeekTo).ToShortDateString, "", ""), fontsz, fontst)
                .AddParagraphToPDF(" ")
                .AddParagraphToPDF(rep.ColTextPad("Salesperson", "Weekly Sales", "Month to Date", ""), fontsz, fontst, 0, iTextSharp.text.Font.UNDERLINE)
                .AddParagraphToPDF(" ")
                For Each sal1 In SalesList

                    .AddParagraphToPDF(rep.ColTextPad(sal1.emp.nickname, sal1.weektotal.ToString("N2"), sal1.monthtotal.ToString("N2"), sal1.jobcosttotal), fontsz, fontst)
                    .AddParagraphToPDF(" ")
                Next
                .AddParagraphToPDF(" ")
                .AddParagraphToPDF(rep.ColTextPad("Grand Total: ", Me.grandtotalweek.ToString("N2"), Me.grandtotalmonth.ToString("N2"), ""), fontsz, fontst)

            End With

            rep.ShowPDF()
        Catch ex As Exception

        End Try
        busy1.Close()
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
                Dim Sales As Decimal = 0
                Dim grandtotal As Decimal = 0

                sw.WriteLine("Weekly Sales" & vbTab & "Dates " & WeekFrom.ToString & " to " & WeekTo.ToString)
                sw.WriteLine("")
                sw.WriteLine("")
                sw.WriteLine("Salesperson" & vbTab & "Weekly Sales" & vbTab & "Month to Date")
                sw.WriteLine("-----------------------------------------------------------")
                sw.WriteLine("")
                sw.Flush()

                Dim dc As linqTKSIDataContext = GetLinqDataContext()
                Dim qsales = (From row In dc.tEmployees Where row.archive = False Order By row.sequence)
                For Each salesper In SalesList
                    Dim strSalesper As String = salesper.emp.nickname
                    Dim JobCostTotal As Decimal
                    Try
                        JobCostTotal = salesper.jobcosttotal ' GetSalesPersonJobCostTotal(strSalesper)
                    Catch ex As Exception
                        JobCostTotal = -1
                    End Try
                    Sales = 0
                    monthsales = 0

                    Dim strLine As String = ""
                    Sales = salesper.weektotal ' 0
                    monthsales = salesper.monthtotal  ' 0
                    grandtotal += Sales
                    grandtotalmonth += monthsales

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

   

    Public Class SalesTotal
        Inherits MyViewModelBase

        Public Property emp As tEmployee
        Private dc As linqTKSIDataContext

        Public Property weekstart As Date
        Public Property weekend As Date

        Private qpo As IQueryable(Of tPOHeader)
        Private qpomonth As IQueryable(Of tPOHeader)

        Public ReadOnly Property monthstart As Date
            Get

                Dim d As New DateTime(weekstart.Year, weekstart.Month, 1)
                Return d
            End Get
        End Property
        Public ReadOnly Property monthend As Date
            Get
                Dim d As New DateTime(weekstart.Year, weekstart.Month, Date.DaysInMonth(weekstart.Year, weekstart.Month))
                d = d.AddHours(23)  ' in case compare doesn't catch last day of month with few hours into the day
                Return d
            End Get
        End Property

        Sub New(_emp As tEmployee, _weekstart As Date, _weekend As Date, _dc As linqTKSIDataContext)
            dc = _dc
            emp = _emp
            weekstart = _weekstart
            weekend = _weekend
            If weekend.Hour = 0 Then
                weekend = weekend.AddHours(23)
            End If
        End Sub

        Public ReadOnly Property weektotal As Decimal
            Get

                qpo = (From row In dc.tPOHeaders Where (row.tJob.sSalesperson = emp.nickname Or row.tJob.sSalesperson2 = emp.nickname) And row.dPODate >= weekstart And row.dPODate <= weekend)
                Dim sales As Decimal = 0
                If qpo.Count > 0 Then

                    For Each po In qpo
                        Dim totalThisPO = po.nRetailSale + po.nAdd + po.nsalesadjust
                        If po.tJob.sSalesperson2.Trim.Length > 0 Then
                            'split job between two sales
                            totalThisPO = totalThisPO / 2
                        End If
                        sales += totalThisPO

                    Next

                    'Dim decRetailSale As Decimal = qpo.Sum(Function(v) v.nRetailSale)
                    'Dim decRetailAdd As Decimal = qpo.Sum(Function(v) v.nAdd)
                    'Dim decRetailAdjust As Decimal = qpo.Sum(Function(v) v.nsalesadjust)
                    'sales = sales + decRetailSale
                    'sales = sales + decRetailAdd
                    'sales = sales + decRetailAdjust
                End If

                Return sales

            End Get
        End Property

        Public ReadOnly Property monthtotal As Decimal
            Get
                qpomonth = (From row In dc.tPOHeaders Where (row.tJob.sSalesperson = emp.nickname Or row.tJob.sSalesperson2 = emp.nickname) And row.dPODate >= monthstart And row.dPODate <= monthend)
                Dim sales As Decimal = 0
                If qpomonth.Count > 0 Then
                    For Each po In qpomonth
                        Dim totalThisPO = po.nRetailSale + po.nAdd + po.nsalesadjust
                        If po.tJob.sSalesperson2.Trim.Length > 0 Then
                            'split job between two sales
                            totalThisPO = totalThisPO / 2
                        End If
                        sales += totalThisPO

                    Next

                    'Dim decRetailSale As Decimal = qpomonth.Sum(Function(v) v.nRetailSale)
                    'Dim decRetailAdd As Decimal = qpomonth.Sum(Function(v) v.nAdd)
                    'Dim decRetailAdjust As Decimal = qpomonth.Sum(Function(v) v.nsalesadjust)
                    'sales = sales + decRetailSale
                    'sales = sales + decRetailAdd
                    'sales = sales + decRetailAdjust

                End If

                Return sales
            End Get
        End Property

        Public ReadOnly Property jobcosttotal As String
            Get
                qpo = (From row In dc.tPOHeaders Where (row.tJob.sSalesperson = emp.nickname Or row.tJob.sSalesperson2 = emp.nickname) And row.dPODate >= weekstart And row.dPODate <= weekend)

                Dim qjobcost = (From row In qpo Where row.sPOType.ToUpper.Contains("JOBCOST"))

                Dim totalJobcost As Decimal = 0
                If qjobcost.Count > 0 Then
                    For Each po In qjobcost
                        Dim totalThisPO As Decimal = 0
                        For Each Line In po.tPOLines
                            totalThisPO += Line.nCost
                        Next

                        If po.tJob.sSalesperson2.Trim.Length > 0 Then
                            'split job between two sales
                            totalThisPO = totalThisPO / 2
                        End If

                        totalJobcost += totalThisPO
                    Next
                End If

                Return "($" & totalJobcost.ToString("N2") & ")"

            End Get
        End Property

        Public ReadOnly Property cmdDetail As RelayCommand
            Get
                Return New RelayCommand(AddressOf ShowSalesDetail)
            End Get
        End Property

        Private Sub ShowSalesDetail()

            Dim Salesperson = Me.emp.nickname
            'Dim dc As linqTKSIDataContext = GetLinqDataContext()
            Dim q = (From row In dc.tPOHeaders Where row.tJob.sSalesperson.ToUpper = Salesperson.ToUpper And row.dPODate >= Me.weekstart And row.dPODate <= Me.weekend Select row.nID, row.sPONum, row.nRetailSale, row.nAdd, row.dPODate, row.nsalesadjust, row.sAdjustReason)

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
    End Class

#Region "relaycommands"
    Public ReadOnly Property cmdRefresh As RelayCommand
        Get
            Return New RelayCommand(AddressOf refreshtotals)
        End Get
    End Property

    Public ReadOnly Property cmdPrint As RelayCommand
        Get
            Return New RelayCommand(AddressOf printreport)
        End Get
    End Property

    Public ReadOnly Property cmdWord As RelayCommand
        Get
            Return New RelayCommand(AddressOf BuildLetterInWordpad)
        End Get
    End Property


#End Region

End Class
