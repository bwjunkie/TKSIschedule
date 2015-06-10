Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Module modPDFFunctions
    Public Function POtoPDF(po As tPOHeader)
        Dim tempPDF As String = Path.GetTempFileName & ".PDF"
        Dim doc As iTextSharp.text.Document
        doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 70, 70, 30, 30)

        Dim msDoc As New FileStream(tempPDF, FileMode.Create)
        Dim w As PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, msDoc)
        w.CloseStream = False
        doc.Open()

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
        str = po.sPONum
        tableTitle.AddCell(createCell(str, 1))
        doc.Add(tableTitle)

        'iFontSize = 7
        'str = "6528 S. Racine Cir"
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = ""
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'str = "Centennial, CO 80111"
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = drEmp.Address
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'str = "303-799-9200"
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = drEmp.CityStateZip
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'str = ""
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = "Phone: " & drEmp.Phone
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'str = ""
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = "SS# " & drEmp.SS
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'str = ""
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = "Claims: " & drEmp.Claims
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'str = "Pay Period: " & sDate
        'tableTitle = New PdfPTable(2)
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(str, 1))
        'str = "Status: " & drEmp.Status
        'tableTitle.AddCell(createCell(str, 1))
        'doc.Add(tableTitle)

        'tableTitle = New PdfPTable(1)   'spacer
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(" ", 1))
        'doc.Add(tableTitle)

        Dim line1 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        'doc.Add(New Chunk(line1))

        'tableTitle = New PdfPTable(1)   'spacer
        'tableTitle.WidthPercentage = 100
        'tableTitle.LockedWidth = False
        'tableTitle.AddCell(createCell(" ", 1))
        'doc.Add(tableTitle)

        'iFontSize = 7

        'Dim daAdd As New TKSIJOBSDataSetTableAdapters.tAddressTableAdapter


        'Dim decPaymentsSum As Decimal = 0
        'For Each comm1 As CommissionList In listComm1.commlist
        '    Dim table As New PdfPTable(2)
        '    table.WidthPercentage = 100
        '    table.LockedWidth = False ' True
        '    Dim cell1 As PdfPCell
        '    cell1 = createCell(comm1.JobDetails, 1)
        '    cell1.BackgroundColor = New iTextSharp.text.BaseColor(244, 244, 244)
        '    table.AddCell(cell1)

        '    ' If jobcost then
        '    If comm1.CommTotal = 0 Then
        '        table.AddCell(createCell("JOBCOST", 1))
        '    Else
        '        table.AddCell(createCell("Due on Job: " & TwoDecimal(comm1.CommTotal), 1))
        '    End If

        '    Dim strAddress As String = "** Address **"
        '    Dim drJob As TKSIJOBSDataSet.tJobRow = Me.ds1.tJob.FindBynID(comm1.nJobID)
        '    If drJob IsNot Nothing Then
        '        If daAdd.Fill(Me.ds1.tAddress, drJob.nAddressID) > 0 Then
        '            Dim dradd As TKSIJOBSDataSet.tAddressRow = drJob.tAddressRow
        '            dradd = drJob.tAddressRow
        '            strAddress = dradd.sAddress1 & " " & dradd.sAddress2 & ", " & dradd.sCity
        '        End If
        '    End If
        '    table.AddCell(createCell(strAddress, 1))

        '    If comm1.PaymentTotals.PaymentCount = 1 Then
        '        table.AddCell(createCell("PAYMENT: " & TwoDecimal(comm1.decPaymentsThisDate), 1))
        '    Else
        '        table.AddCell(createCell("PARTIAL PAYMENT: " & TwoDecimal(comm1.decPaymentsThisDate), 1))
        '    End If

        '    If comm1.PaymentTotals.PaymentTotal = comm1.CommTotal Then
        '        table.AddCell(createCell(" ", 1))
        '        table.AddCell(createCell("PAID IN FULL", 1))
        '    Else
        '        table.AddCell(createCell(" ", 1))
        '        table.AddCell(createCell("Balance Owed: " & TwoDecimal(comm1.CommTotal - comm1.PaymentTotals.PaymentTotal), 1))
        '    End If

        '    table.AddCell(createCell(" ", 2)) 'spacer
        '    doc.Add(table)
        '    decPaymentsSum += comm1.decPaymentsThisDate
        'Next

        line1 = New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        doc.Add(New Chunk(line1))

        'Dim strTotal As String = "Sub-Total: " & TwoDecimal(decPaymentsSum)
        'Dim tableTotal As New PdfPTable(9)
        'With tableTotal
        '    .WidthPercentage = 100
        '    .LockedWidth = False
        '    .AddCell(createCell("", 7))
        '    .AddCell(createCell(strTotal, 2))
        '    .AddCell(createCell(" ", 9))
        'End With
        'doc.Add(tableTotal)

        'Dim strDraw As String = "Previous Draws: " & TwoDecimal(drawstotal1.DrawGrandTotal - drawstotal1.DrawTotalToday)
        'tableTotal = New PdfPTable(9)
        'With tableTotal
        '    .WidthPercentage = 100
        '    .LockedWidth = False
        '    .AddCell(createCell("", 7))
        '    .AddCell(createCell(strDraw, 2))
        '    .AddCell(createCell(" ", 9))
        'End With
        'doc.Add(tableTotal)

        'Dim strDrawsToday As String = "Todays Draws: " & TwoDecimal(drawstotal1.DrawTotalToday)
        'tableTotal = New PdfPTable(9)
        'With tableTotal
        '    .WidthPercentage = 100
        '    .LockedWidth = False
        '    .AddCell(createCell("", 7))
        '    .AddCell(createCell(strDrawsToday, 2))
        '    .AddCell(createCell(" ", 9))
        'End With
        'doc.Add(tableTotal)

        'Dim strGrandTotal As String = "Total Paid: " & TwoDecimal(decPaymentsSum + drawstotal1.DrawTotalToday)
        'tableTotal = New PdfPTable(9)
        'With tableTotal
        '    .WidthPercentage = 100
        '    .LockedWidth = False
        '    .AddCell(createCell("", 7))
        '    .AddCell(createCell(strGrandTotal, 2))
        'End With
        'doc.Add(tableTotal)

        w.DirectContent.BeginText()

        w.DirectContent.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED), 7)
        w.DirectContent.SetTextMatrix(doc.Left, doc.GetBottom(0))
        w.DirectContent.ShowText("Reported Generated: " & Now.ToString)
        w.DirectContent.EndText()

        doc.Close()
        w.Flush()
        msDoc.Flush()
        w.Close()
        msDoc.Close()
        Process.Start(tempPDF)
    End Function
End Module
