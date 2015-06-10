Imports System.Drawing
Imports System.Drawing.Printing

Public Class clsWordDoc

    Public Class VendorAndLines
        Public strVendor As String = ""
        Public listWordLines As New List(Of String)
        Public strPayPeriod As String = "Pay Period: "
        Public decGrandTotal As Decimal = 0
    End Class

    Public Sub CreateFlexInstallerReport(listVendor1 As List(Of VendorAndLines))
        Try

            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Add
            oWord.Visible = True
            Try
                Try
                    Dim settings As New PrinterSettings
                    oDoc.Application.ActivePrinter = settings.PrinterName
                Catch
                End Try
                oDoc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperLetter
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(8.5)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)
            Catch ex As Exception
            End Try

            With oWord.Selection
                '.PageSetup.TextColumns.SetCount(2)
                .PageSetup.TopMargin = 50
                .PageSetup.BottomMargin = 50
                .PageSetup.LeftMargin = 50
                .PageSetup.RightMargin = 50
                .PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(8.5)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)


                Dim tabLength As Double
                tabLength = 0.9
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 2.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 2.4
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                Dim iLoop As Integer = 0
                For Each venline1 In listVendor1
                    iLoop += 1
                    If iLoop > 1 Then
                        .InsertBreak(Word.WdBreakType.wdPageBreak)  'only page break if starting a new page after the first one
                    End If

                    WordAddPara("THE KITCHEN SHOWCASE, INC.", oDoc, Word.WdParagraphAlignment.wdAlignParagraphLeft, 18)
                    WordAddPara("6528 South Racine Circle", oDoc)
                    WordAddPara("Centennial, CO.  80111", oDoc)
                    WordAddPara("(303) 799-9200", oDoc)
                    WordAddPara("", oDoc)

                    WordAddPara(venline1.strVendor, oDoc, Word.WdParagraphAlignment.wdAlignParagraphCenter, 11, True)
                    WordAddPara("Pay Period: " & venline1.strPayPeriod, oDoc, Word.WdParagraphAlignment.wdAlignParagraphCenter)

                    Dim strSeperator As String = "-----------------------------------------------------------------------------------------------------------------------------------"
                    WordAddPara(strSeperator, oDoc, Word.WdParagraphAlignment.wdAlignParagraphCenter)

                    WordAddPara("JOB #:" & vbTab & "ACCT NAME:" & vbTab & "ADDRESS" & vbTab & "AMOUNT", oDoc, Word.WdParagraphAlignment.wdAlignParagraphLeft, 11, True)
                    For Each strLine In venline1.listWordLines
                        WordAddPara(strLine, oDoc, Word.WdParagraphAlignment.wdAlignParagraphLeft)
                    Next

                    WordAddPara(vbTab & vbTab & vbTab & "------------", oDoc, Word.WdParagraphAlignment.wdAlignParagraphLeft)
                    WordAddPara(vbTab & vbTab & vbTab & Format(venline1.decGrandTotal, "currency"), oDoc, Word.WdParagraphAlignment.wdAlignParagraphLeft)

                Next

                oWord.Visible = True
                Try
                    oWord.Activate()
                    oWord.Selection.HomeKey(Word.WdUnits.wdStory)
                Catch ex As Exception
                End Try
            End With

        Catch ex As Exception
            MessageBox.Show("error while creating word doc " & ex.Message)
        End Try
    End Sub

    Private Sub WordAddPara(_text As String, oDoc As Word.Document, Optional _align As Word.WdParagraphAlignment = Word.WdParagraphAlignment.wdAlignParagraphLeft, Optional _fontsize As Integer = 11, Optional _bold As Boolean = False)
        'If _align = Word.WdParagraphAlignment.wdAlignParagraphCenter Then
        '    _text = vbTab & vbTab & _text
        'End If
        oDoc.Application.Selection.Font.Size = _fontsize
        oDoc.Application.Selection.ParagraphFormat.Alignment = _align
        oDoc.Application.Selection.SelectCurrentAlignment()
        If _bold Then
            oDoc.Application.Selection.Font.Bold = True
        Else
            oDoc.Application.Selection.Font.Bold = False
        End If
        oDoc.Application.Selection.TypeText(_text)
        oDoc.Application.Selection.TypeParagraph()
        'Dim par1 = oDoc.Content.Paragraphs.Add
        'If _fontsize = 11 And _text.Length > 24 Then
        '    oDoc.Application.Selection.Font.Size = 8
        'End If
        ''oPara(0).Range.Font.Bold = True
        ''oPara(0).Range.Font.Size = 22
        ''oPara(0).Range.Text = vbNewLine
        'par1.Range.Font.Size = _fontsize
        'par1.Range.ParagraphFormat.Alignment = _align
        'par1.Range.Text = _text & vbNewLine
    End Sub

End Class
