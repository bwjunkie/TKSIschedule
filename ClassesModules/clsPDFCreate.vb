Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class clsPDFCreate

    Private strFilePDF As String = ""
    Private pdf As Document
    Private msDoc As FileStream

    Public Sub New(strTitle As String)

        strFilePDF = System.IO.Path.GetTempPath & "\" & strTitle.Replace("/", "").Replace("\", "").Replace(":", "").Replace("*", "") & "-ShipReceiveReport-" & Mid(Guid.NewGuid.ToString, 1, 4) & ".pdf"

        pdf = New Document(PageSize.LETTER, 30, 30, 30, 30)
        msDoc = New FileStream(strFilePDF, FileMode.CreateNew)
        Dim w As PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(pdf, msDoc)
        w.CloseStream = False
        pdf.Open()
        Dim iCourier As Integer = iTextSharp.text.Font.FontFamily.COURIER
        Dim iUL As Integer = iTextSharp.text.Font.UNDERLINE

        Dim iLoop As Integer = 0
        Dim blnOddLoop As Boolean = True

        With pdf
            Me.AddParagraphToPDF(strTitle)
        End With

    End Sub

    Public Sub New(strTitle As String, blnNoTitle As Boolean, bln11x17 As Boolean)

        strFilePDF = System.IO.Path.GetTempPath & "\" & strTitle.Replace("/", "").Replace("\", "").Replace(":", "").Replace("*", "") & "-ShipReceiveReport-" & Mid(Guid.NewGuid.ToString, 1, 4) & ".pdf"
        If bln11x17 Then
            pdf = New Document(PageSize._11X17, 20, 20, 20, 20)
        Else
            pdf = New Document(PageSize.LETTER, 20, 20, 20, 20)
        End If

        msDoc = New FileStream(strFilePDF, FileMode.CreateNew)

        Dim w As PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(pdf, msDoc)
        w.CloseStream = False
        pdf.Open()

        Dim iCourier As Integer = iTextSharp.text.Font.FontFamily.COURIER
        Dim iUL As Integer = iTextSharp.text.Font.UNDERLINE

        Dim iLoop As Integer = 0
        Dim blnOddLoop As Boolean = True

    End Sub

    Public Sub InsertImage8x11(_path As String)
        ' pdf.SetPageSize(PageSize.LETTER)
        ' pdf.NewPage()
        Dim i As Image = Image.GetInstance(_path)
        ' pdf.SetPageSize(PageSize.LETTER)

        ' i.ScaleToFit(pdf.PageSize.Width, pdf.PageSize.Height)
        i.SetAbsolutePosition(30, 0)

        Dim tbl As PdfPTable = New PdfPTable(1)
        tbl.AddCell(New PdfPCell(i))
        pdf.Add(tbl)
    End Sub

    Public Sub InsertImage11x17(_path As String)
        Dim i As Image = Image.GetInstance(_path)

        'pdf.SetPageSize(PageSize._11X17)
        'pdf.NewPage()
        'pdf.SetPageSize(PageSize._11X17)

        '.64 is true 11x17 '.75 is 8.5x11
        ' If i.Width / i.Height > 0.7 Then 'for 11x17 this will have white space on top and bottom so try to center somewhat
        'i.ScaleToFit(pdf.PageSize.Width - 100.0, pdf.PageSize.Height - 200.0)
        'Else
        i.ScaleToFit(pdf.PageSize.Width - 10.0, pdf.PageSize.Height - 10.0)
        'End If


        ' If i.XYRatio > 7 Then 'for 11x17 this will have white space on top and bottom so try to center somewhat
        'i.SetAbsolutePosition(5, 280)
        '   Else
        i.SetAbsolutePosition(5, 5)
        '  End If
        '  Dim tbl As PdfPTable = New PdfPTable(1)

        '        tbl.AddCell(New PdfPCell(i))
        '       pdf.Add(tbl)

        pdf.Add(i)

    End Sub

    Public Sub ShowPDF()
        Try
            Me.pdf.Close()
            Me.msDoc.Close()
        Catch 
        End Try

        If File.Exists(strFilePDF) Then
            Process.Start(strFilePDF)
        Else
            MessageBox.Show("report file missing " & strFilePDF)
        End If
    End Sub

    Public Sub PDFAddSeperatorLine()
        Dim sepLINE As New iTextSharp.text.pdf.draw.DottedLineSeparator
        sepLINE.LineWidth = 0.5
        sepLINE.Gap = 1
        sepLINE.Percentage = 98
        sepLINE.LineColor = BaseColor.BLACK
        Dim chnkLINE As New iTextSharp.text.Chunk(sepLINE)
        pdf.Add(chnkLINE)

    End Sub

    Public Sub PDFAddNewPage()
        pdf.NewPage()
    End Sub

    Public Sub PDFAddHalfSeperatorLine()
        Dim fnt As New Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.UNDERLINE)
        Dim p As New Paragraph(ColTextPad(" ", " ", " ", "", TitleJustifyRight(" ")), fnt)
        p.IndentationLeft = 0
        p.SpacingBefore = -9
        p.SpacingAfter = 1
        pdf.Add(p)

    End Sub

    Public Sub AddParagraphToPDF(str As String, Optional fontSize As Integer = 11, Optional fontA As Integer = iTextSharp.text.Font.FontFamily.COURIER, Optional iAlign As Integer = 0, Optional iStyle As Integer = iTextSharp.text.Font.NORMAL, Optional iTopMargin As Integer = -2, Optional iBottomMargin As Integer = -2)
        Dim fnt As New Font(fontA, fontSize, iStyle)
        Dim p As New Paragraph(str, fnt)
        p.Alignment = iAlign
        p.SpacingBefore = iTopMargin
        p.SpacingAfter = iBottomMargin
        pdf.Add(p)
    End Sub

    Public Sub AddParagraphToPDF(str As String, _font As iTextSharp.text.Font, _align As Integer)

        Dim p As New Paragraph(str, _font)
        p.Alignment = _align
        '  p.SpacingBefore = iTopMargin
        '  p.SpacingAfter = iBottomMargin
        pdf.Add(p)

    End Sub

    Public Function ColTextPad(col1 As String, col2 As String, col3 As String) As String
        Return col1.PadRight(55, " ") & col2.PadRight(18, " ") & col3
    End Function

    Public Function ColTextPad(col1 As String, col2 As String, col3 As String, col4 As String) As String
        Return col1.PadRight(24, " ") & col2.PadRight(21, " ") & col3.PadRight(22, " ") & col4
    End Function

    Public Function ColTextPad(col1 As String, col2 As String, col3 As String, col4 As String, col5 As String) As String
        Return col1.PadRight(18, " ") & col2.PadRight(12, " ") & col3.PadRight(12, " ") & col4.PadRight(12, " ") & col5
    End Function

    Private Function CurrencyJustify(ByVal amount As Decimal) As String
        Dim i As Integer = 0
        Dim strAmount As String = Format(amount, "currency")
        Return strAmount.PadLeft(11, " ")
    End Function

    Private Function TitleJustifyRight(ByVal title As String) As String
        Dim i As Integer = 0
        Return title.Trim.PadLeft(11, " ")
    End Function

    Private Function JustifyLeft(ByVal name As String, ByVal len As Integer) As String
        Dim i As Integer = 0
        Dim str As String = name
        If str.Length < len Then
            For i = 1 To len - str.Length
                str = str & " "
            Next
        End If
        Return str
    End Function

    Private helvSm As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9)
    Private helv11 As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11)

    Private helvSmbold As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD)
    Private helv11bold As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.BOLD)

    Private helv14 As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14)
    Private helv18 As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18)

    Private Sub AddCell(_tbl As PdfPTable, _text As String, _colspan As Integer)
        Dim cell1 = New PdfPCell(New Phrase(_text, helvSm))
        cell1.Colspan = _colspan
        cell1.BorderWidth = 0
        _tbl.AddCell(cell1)

    End Sub

    Private Sub AddCell(_tbl As PdfPTable, _tblinner As PdfPTable, _colspan As Integer)
        Dim cell1 = New PdfPCell(_tblinner)
        cell1.Colspan = _colspan
        cell1.BorderWidth = 0
        _tbl.AddCell(cell1)
    End Sub

    Private Sub AddCell(_tbl As PdfPTable, _text As String, _colspan As Integer, _font As iTextSharp.text.Font)
        Dim cell1 = New PdfPCell(New Phrase(_text, _font))
        cell1.Colspan = _colspan
        cell1.BorderWidth = 0
        _tbl.AddCell(cell1)
    End Sub

    Public Sub AddLetterPage()
        pdf.SetPageSize(PageSize.LETTER)
        pdf.NewPage()
        '   pdf.SetPageSize(PageSize.LETTER)
    End Sub

    Public Sub AddTabloidPage()
        pdf.SetPageSize(PageSize.TABLOID)
        pdf.NewPage()
        '  pdf.SetPageSize(PageSize.TABLOID)
    End Sub

    Public Sub PrintJobCommunicationSheetPDF(_jobid As Integer)

        Dim _job As tJob
        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Dim q = (From row In dc.tJobs Where row.nID = _jobid)

        If q.Count = 1 Then

            _job = q.Single

            AddParagraphToPDF("JOB COMMUNICATION SHEET", helv18, 1)
            AddParagraphToPDF(" ", helvSm, 1)

            Dim jobsite As String = _job.tAddress.sAddress1 & " " & _job.tAddress.sAddress2 & " " & _job.tAddress.sCity & ", " & _job.tAddress.sZip
            Dim customer As String = _job.tCustomr.sName
            Dim contact As String = _job.sJobContact
            Dim phone As String = _job.sPhone
            Dim jobdesc As String = _job.sJobDesc
            Dim terms As String = ""
            Dim balanceduetitle As String = ""
            Dim balancedue As String = ""
            If _job.sOtherNotes.Length > 0 Then
                terms = "*** " & _job.sOtherNotes & " ***     TERMS: " & _job.sTerms
            Else
                terms = _job.sTerms
            End If
            Dim blnUseBalanceDue As Boolean = False
            Try
                If _job.sTerms.ToUpper.Contains("NET") Then
                    balanceduetitle = _job.sTerms
                ElseIf _job.sTerms.ToUpper.Contains("PIA") Then
                    balanceduetitle = "Paid In Advance"
                Else   '50-50 or 50-40-10 or COD or whatever
                    balanceduetitle = "Balance Due:"
                    If _job.InvBalanceRemaining = 0 And _job.HasSWO_PO Then
                        balancedue = "Billable Hourly"
                    Else
                        balancedue = Format(_job.InvBalanceRemaining, "currency")
                    End If
                End If
            Catch
        End Try

            Dim tbl As PdfPTable = New PdfPTable(6)

            With tbl
                .WidthPercentage = 95
                AddCell(tbl, "Builder:", 1, helv11bold)
                AddCell(tbl, _job.tCustomr.sName, 3, helv11bold)
                AddCell(tbl, "JOB#", 1, helv11bold)
                AddCell(tbl, _job.sJobNo, 1, helv11bold)
                .CompleteRow()

                AddCell(tbl, " ", 6, helv11bold)
                .CompleteRow()

                AddCell(tbl, "Salesperson:", 1)
                AddCell(tbl, _job.sSalesperson & " " & _job.sSalesperson2, 1)
                AddCell(tbl, "Jobsite:", 1)
                AddCell(tbl, jobsite, 3)
                .CompleteRow()

                AddCell(tbl, "", 1)
                AddCell(tbl, "", 1)
                AddCell(tbl, "Contact:", 1)
                AddCell(tbl, contact, 3)
                .CompleteRow()

                AddCell(tbl, "", 1)
                AddCell(tbl, "", 1)
                AddCell(tbl, "PH#", 1)
                AddCell(tbl, phone, 3)
                .CompleteRow()

                AddCell(tbl, " ", 6)
                .CompleteRow()

                AddCell(tbl, "Job Desc:", 1)
                AddCell(tbl, _job.tCustomr.sName, 5)
                .CompleteRow()

                AddCell(tbl, "Terms:", 1, helv11bold)
                AddCell(tbl, terms, 5, helv11bold)
                .CompleteRow()

                If balancedue.Length > 0 Then
                    AddCell(tbl, balanceduetitle, 1, helv11bold)
                    AddCell(tbl, balancedue, 5, helv11bold)
                    .CompleteRow()
                End If

                pdf.Add(tbl)

            End With

            AddParagraphToPDF(" ", helv11bold, 0)

            Dim tbl7 As PdfPTable = New PdfPTable(7)
            With tbl7
                .LockedWidth = False

                .WidthPercentage = 95

                AddCell(tbl7, "DATE", 1)
                AddCell(tbl7, "PO", 1)
                AddCell(tbl7, "Supplier", 1)
                AddCell(tbl7, "Date Received", 1)
                AddCell(tbl7, "Items", 1)
                AddCell(tbl7, "Quantity", 1)
                AddCell(tbl7, "FOB", 1)
                .CompleteRow()

                For Each drPO In (From row In _job.tPOHeaders Order By row.sPONumSortable)

                    Dim received As String = ""
                    If drPO.DREC IsNot Nothing Then
                        received = CDate(drPO.DREC).ToShortDateString
                    End If

                    AddCell(tbl7, CDate(drPO.dRequired).ToShortDateString, 1)
                    AddCell(tbl7, drPO.sPONum, 1)
                    AddCell(tbl7, Mid(drPO.tVendor.sName, 1, 13), 1)
                    AddCell(tbl7, received, 1)
                    AddCell(tbl7, drPO.sPOType, 1)
                    AddCell(tbl7, drPO.nBoxes.ToString, 1)
                    AddCell(tbl7, drPO.sFOB, 1)
                    .CompleteRow()

                Next

                pdf.Add(tbl7)
            End With

            AddParagraphToPDF(" ", helv11bold, 0)

            AddParagraphToPDF(" ", helv11bold, 0)

            Dim tbl2holder As New PdfPTable(2)
            tbl2holder.WidthPercentage = 95

            Dim tbl3 As PdfPTable = New PdfPTable(2)
            With tbl3
                .WidthPercentage = 100
                AddCell(tbl3, "Job Activity:", 2, helv11bold)
                .CompleteRow()
                For Each activity1 In (From row In dc.tblJobActivities Where row.nJobID = _job.nID Order By row.dateEntered)
                    AddCell(tbl3, activity1.dateEntered.ToString("g"), 1)
                    AddCell(tbl3, activity1.ActivityDetail, 1)
                    .CompleteRow()
                Next
            End With
            AddCell(tbl2holder, tbl3, 1)

            Dim tbl1b As PdfPTable = New PdfPTable(1)
            With tbl1b
                .WidthPercentage = 100
                AddCell(tbl1b, "", 1, helv14)
                .AddCell("Dlvrd By: ")
                .CompleteRow()

                AddCell(tbl1b, "", 1, helv14)
                .AddCell("Date: ")
                .CompleteRow()

                AddCell(tbl1b, "", 1, helv14)
                .AddCell("Location: ")
                .CompleteRow()
            End With
            AddCell(tbl2holder, tbl1b, 1)
            tbl2holder.CompleteRow()

            pdf.Add(tbl2holder)

            AddParagraphToPDF(" ", helv14, 0)
            AddParagraphToPDF("CUSTOMER SIGNATURE: __________________________________", helv14, 0)

            Me.PDFAddSeperatorLine()

            Dim tbl3c As New PdfPTable(3)
            With tbl3c
                .WidthPercentage = 95
                AddCell(tbl3c, "TKSI RECEIPT", 2, helv14)
                AddCell(tbl3c, "DATE: " & Now.ToShortDateString, 1, helv14)
                .CompleteRow()

                AddCell(tbl3c, "Amount Received: ____________________________", 2, helv14)
                AddCell(tbl3c, "JOB:  " & _job.sJobNo, 1, helv14)
                .CompleteRow()

                AddCell(tbl3c, "Issued By: _________________________________", 3, helv14)
            End With

            pdf.Add(tbl3c)

        End If
    End Sub
End Class
