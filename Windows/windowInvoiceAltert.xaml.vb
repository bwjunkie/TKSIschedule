Imports System.Data

Public Class windowInvoiceAltert

    Dim dsTKSI1 As New dsTKSI
    Dim daEmployeeALL As New dsTKSITableAdapters.tEmployeeTableAdapter
    Dim daAddressALL As New dsTKSITableAdapters.tAddressTableAdapter
    Dim daJobALL As New dsTKSITableAdapters.tJobTableAdapter
    Dim daPOHeaderALL1 As New dsTKSITableAdapters.tPOHeaderTableAdapter
    Dim daPOLineALL As New dsTKSITableAdapters.tPOLineTableAdapter
    Dim daSOHeaderALL As New dsTKSITableAdapters.tSOHeaderTableAdapter
    Dim daSOLineALL As New dsTKSITableAdapters.tSOLineTableAdapter
    Dim daVendorALL As New dsTKSITableAdapters.tVendorTableAdapter

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private Sub gridReportALL()
        Dim frmBusy1 As New frmWorking
        Try

            frmBusy1.Show()

            Dim dt1 As New DataTable
            Dim temp As Decimal = 0

            Dim contract As Decimal = 0
            Dim invoiceExists As Boolean
            Dim LastJobID As Integer

            Dim qJob = (From row In dc.tJobs Where Not row.sTerms.ToUpper.StartsWith("NET") And Not row.sTerms.StartsWith("PIA") And (row.nMaterialsCharge > 1 Or row.nLaborCharge > 1))

            Dim strSQL As String = " SELECT MAX(tPOHeader.dRequired) AS drequired, tJob.nID FROM tPOHeader INNER JOIN  tJob ON tPOHeader.nJobID = tJob.nID GROUP BY tJob.nID, tJob.nMaterialsCharge, tJob.sTerms, tJob.nLaborCharge HAVING (tJob.nMaterialsCharge <> 0) AND (tJob.sTerms <> 'Net 10 PRX') OR (tJob.sTerms <> 'Net 10 PRX') AND (tJob.nLaborCharge <> 0) ORDER BY drequired"
            Dim da As New System.Data.SqlClient.SqlDataAdapter
            da.SelectCommand = New SqlClient.SqlCommand(strSQL, New SqlClient.SqlConnection(cnSQL))
            da.Fill(dt1)

            LastJobID = 0

            Dim listJobs As New List(Of clsShowJob)

            For Each dr In qJob
                Dim qpo = (From row In dr.tPOHeaders Where row.dRequired IsNot Nothing Order By row.dRequired Descending Select row.nID, row.dRequired)
                If qpo.Count > 0 Then
                    Dim drPO = qpo.First

                    Dim blnSkipLoop As Boolean = False

                    If LastJobID = dr.nID Then
                        blnSkipLoop = True

                    Else
                        LastJobID = dr.nID
                    End If


                    If dr.dJobCreated < Today.AddMonths(-12) Then
                        blnSkipLoop = True
                    End If

                    temp = 0

                    If Me.dsTKSI1.tSOHeader.Rows.Count = 0 Then
                        invoiceExists = False
                    Else
                        invoiceExists = True
                    End If

                    For Each drSO In dr.tSOHeaders
                        For Each drSOline In drSO.tSOLines
                            If UCase(drSOline.sType) = "COMMENT" And drSOline.nAmount < 0 Then
                                temp += drSOline.nAmount
                            End If
                        Next
                    Next

                    If -(temp) >= dr.nMaterialsCharge And -temp > 0 Then
                        blnSkipLoop = True
                    End If

                    If Not blnSkipLoop Then
                        Dim clsJob1 As New clsShowJob(dr, drPO.dRequired, temp)
                        If (clsJob1.blnTwoWeekLetter And chkShowHighlightedOnly.IsChecked) Or (Not chkShowHighlightedOnly.IsChecked) Then
                            listJobs.Add(clsJob1)
                        Else
                            'dont show
                        End If
                    End If
                Else
                    'skip '????
                End If
            Next

            Me.lbReport.ItemsSource = listJobs

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmBusy1.Close()
        End Try
    End Sub

    Private Sub chkShowHighlightedOnly_Click_1(sender As Object, e As Windows.RoutedEventArgs)
        gridReportALL()
    End Sub

    Private Sub windowInvoiceAltert_Loaded(sender As Object, e As Windows.RoutedEventArgs) Handles Me.Loaded
        With Me.dsTKSI1
           
        End With
        gridReportALL()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As Windows.RoutedEventArgs)
        Try
            Dim cntx As clsShowJob = sender.datacontext
            PrintLetter(cntx)
        Catch ex As Exception
            MessageBox.Show("error in btnPrintLetter : " & ex.Message)
        End Try

    End Sub

    Private Sub PrintLetter(cJob As clsShowJob)
        Dim dBalance As Decimal
        Try
            dBalance = cJob.ContractBalance
        Catch ex As Exception
            MessageBox.Show("error getting invoice balance for: " & cJob.CustName & "  " & ex.Message)
        End Try

        If Not BuildLetterInWord(cJob, dBalance) Then
            BuildLetterInWordpad(cJob, dBalance)
        End If

    End Sub

    Private Function BuildLetterInWordpad(cJob As clsShowJob, dBalance As Decimal)
        Dim sw As IO.StreamWriter
        Try
            Dim strTempFile As String = IO.Path.GetTempFileName
            sw = New IO.StreamWriter(strTempFile, True)


            sw.WriteLine("")
            sw.WriteLine("")

            Dim strLetter As String = ""
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine(MonthName(Now.Month) & " " & Now.Day & ", " & Now.Year)
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine(cJob.CustName)
            sw.WriteLine("")
            sw.WriteLine(cJob.CustAddress)
            sw.WriteLine("")
            sw.WriteLine(cJob.CustCityStateZip)
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("Dear " & cJob.CustFirstName & ", ")
            sw.WriteLine("")
            sw.WriteLine("")

            sw.WriteLine("     We have received confirmation that your cabinetry will be arriving in the next one or two weeks. ")
            sw.WriteLine("This is a reminder to you that the remaining balance of your invoice is due at time of delivery. ")
            sw.WriteLine("Your check should be made payable to The Kitchen Showcase, Inc. in the amount of " & Format(dBalance, "currency") & ". ")
            sw.WriteLine("You will be receiving a call from our service department to schedule a delivery time.")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("Thank you very much for your cooperation,")
            sw.WriteLine("")
            '    sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("The Kitchen Showcase, Inc.")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("Enclosure")
            sw.WriteLine("")
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

    Private Function BuildLetterInWord(cJob As clsShowJob, dBalance As Decimal) As Boolean
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Add
            oWord.Visible = False

            Dim settings As New System.Drawing.Printing.PrinterSettings
            Try
                oDoc.Application.ActivePrinter = settings.PrinterName
                oDoc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperLetter
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(8.5)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)
            Catch ex As Exception

            End Try

            With oWord.Selection

                .PageSetup.TopMargin = 50
                .PageSetup.BottomMargin = 50
                .PageSetup.LeftMargin = 50
                .PageSetup.RightMargin = 50
                .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(8.5)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)

                .WholeStory()
                .TypeParagraph()
                .Font.Size = 12

                Dim strLetter As String = ""
                .TypeParagraph()
                .TypeParagraph()
                .TypeText(MonthName(Now.Month) & " " & Now.Day & ", " & Now.Year)
                .TypeParagraph()
                .TypeParagraph()
                .TypeText(cJob.CustName)
                .TypeParagraph()
                .TypeText(cJob.CustAddress)
                .TypeParagraph()
                .TypeText(cJob.CustCityStateZip)
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("Dear " & cJob.CustFirstName & ", ")
                .TypeParagraph()
                .TypeParagraph()

                .TypeText("     We have received confirmation that your cabinetry will be arriving in the next one or two weeks. ")
                .TypeText("This is a reminder to you that the remaining balance of your invoice is due at time of delivery. ")
                .TypeText("Your check should be made payable to The Kitchen Showcase, Inc. in the amount of ")
                .TypeText(Format(dBalance, "currency")) '6,301.85
                .TypeText(". ")
                .TypeText("You will be receiving a call from our service department to schedule a delivery time.")
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("Thank you very much for your cooperation,")
                .TypeParagraph()
                .TypeParagraph()
                '    .TypeParagraph()
                .TypeParagraph()
                .TypeText("The Kitchen Showcase, Inc.")
                .TypeParagraph()
                .TypeText("")
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("Enclosure")
                .TypeParagraph()

            End With
            oWord.Visible = True
            Try
                oWord.Activate()
                oWord.Selection.HomeKey(Word.WdUnits.wdStory)
            Catch ex As Exception
            End Try

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Sub btnOpenJobClick(sender As Object, e As Windows.RoutedEventArgs)
        Try
            Dim cntx As clsShowJob = sender.datacontext
            OpenJobScreen(cntx.AddressID, cntx.JobID, False)
        Catch ex As Exception
            MessageBox.Show("error in btnOpenJobClick : " & ex.Message)
        End Try
    End Sub
End Class

Public Class clsShowJob
    Inherits clsJob
  
    Public Property strDateReq As String = ""
    Public Property strJobCustDesc As String = ""
    Public Property strCustPayment As String = "CustPayment$: "
    Public Property strContract As String = "Contract$: "
    Private drPOdate As Date

    Public ReadOnly Property colorHighlighted As Windows.Media.Brush
        Get
            If blnTwoWeekLetter Then
                colorHighlighted = Windows.Media.Brushes.LightBlue
            Else
                colorHighlighted = Windows.Media.Brushes.White
            End If
        End Get
    End Property

    Public ReadOnly Property visjob As Windows.Visibility
        Get
            If blnTwoWeekLetter Then
                visjob = Windows.Visibility.Visible
            Else
                visjob = Windows.Visibility.Hidden
            End If
        End Get
    End Property

    Public ReadOnly Property ContractBalance As Decimal
        Get
            Dim itemBalance As Decimal = 0
            Dim commentBalance As Decimal = 0
            If Me.drSO Is Nothing Then LoadSORow(Me.drJob.nID)
            If Not Me.drSO Is Nothing Then

                For Each drLine In Me.drSO.tSOLines
                    If UCase(drLine.sType) = "ITEM" Then
                        itemBalance = itemBalance + drLine.nAmount
                    ElseIf UCase(drLine.sType) = "COMMENT" Then
                        commentBalance = commentBalance + drLine.nAmount
                    ElseIf UCase(drLine.sType) = "BALANCE" Then

                    End If
                Next
                Return commentBalance
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property blnTwoWeekLetter As Boolean
        Get
            Dim dMonday As Integer = Weekday(Today, FirstDayOfWeek.Monday)
            If drPOdate >= DateAdd(Microsoft.VisualBasic.DateInterval.Day, 14 - dMonday, Today) Then
                If drPOdate <= DateAdd(Microsoft.VisualBasic.DateInterval.Day, 21 - dMonday, Today) Then
                    If Not drJob.sTerms.ToUpper.Contains("NET") Then 'only showing 50-50 and COD terms, no net
                        Return True
                    End If
                End If
            End If
            Return False
        End Get
    End Property

    Sub New(_drJob As tJob, _drPOdate As Date, decPayments As Decimal) ' dsTKSI.tJobRow, _drPO As dsTKSI.tPOHeaderRow, decPayments As Decimal)
        drPOdate = _drPOdate  'this is the last 'date required' PO 
        drJob = _drJob

        Me.strDateReq = _drPOdate.ToShortDateString

        If Not drJob.tCustomr Is Nothing Then
            Me.strJobCustDesc = "Job: " & drJob.sJobNo & " - " & drJob.tCustomr.sName & ", " & drJob.sJobDesc & " (" & drJob.sTerms & ")"
        End If

        Me.strCustPayment = "CustPayment: " & Format(-(decPayments), "currency")
        Me.strContract = "Contract: " & Format((drJob.nMaterialsCharge + (drJob.nMaterialsCharge * drJob.nTaxRate / 100) + drJob.nLaborCharge).ToString, "currency")

    End Sub
End Class


