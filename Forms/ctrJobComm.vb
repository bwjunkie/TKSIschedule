Imports C1.Win.C1FlexGrid
Imports C1.C1Preview
Imports C1.C1PrintDocument
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.IO

Public Class ctrJobComm

    Public Event ShowSchedule()

    Private csGreen As CellStyle
    Private csYellow As CellStyle
    Private csWhite As CellStyle
    Private csOrange As CellStyle
    Private csBlue As CellStyle
    Private drJ As TKSIJOBSDataSet.tJobRow

    Private Sub ctrJobComm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With Me.flexJobComm
            '.Cols.Count = 3
            '.Cols.Fixed = 0
            .Rows.Count = 0
            .Rows.Fixed = 0

            '.Cols(0).Visible = False
            '.Rows(0).Item(0) = "test"
            '.Rows(0).Item(1) = "test"

            ''allow merging (that's the whole point)
            'Dim i As Integer
            'flexJobComm.AllowMerging = AllowMergingEnum.Free
            'For i = 1 To flexJobComm.Cols.Count - 1
            '    flexJobComm.Cols(i).AllowMerging = True
            'Next
            'For i = 1 To flexJobComm.Rows.Count - 1
            '    flexJobComm.Rows(i).AllowMerging = True
            'Next
            '' .Rows(0).AllowDragging = True

        End With


        csWhite = Me.flexJobComm.Styles.Add("White")
        csWhite.BackColor = Color.White

        csGreen = Me.flexJobComm.Styles.Add("Green")
        csGreen.BackColor = Color.LightGreen

        csYellow = Me.flexJobComm.Styles.Add("Yellow")
        csYellow.BackColor = Color.Yellow

        csOrange = Me.flexJobComm.Styles.Add("Orange")
        csOrange.BackColor = Color.LightCoral

        csBlue = Me.flexJobComm.Styles.Add("Blue")
        csBlue.BackColor = Color.LightBlue

        Me.TblActivityTypeTableAdapter1.Fill(Me.TKSIJOBSDataSet.tblActivityType)

    End Sub

    Private Sub ClearTextBoxes()
        Try

            Me.txtPaymentNotes.Text = ""
            Me.lblTop1.Text = ""
            Me.txtInvoiceDue.Text = ""
        Catch
        End Try
    End Sub

    Public Sub LoadJob(ByVal JobID As Integer) ' As TKSIJOBSDataSet.tJobRow)

        Me.Enabled = True
        ClearTextBoxes()

        If Me.TJobTableAdapter1.FillByNID(Me.TKSIJOBSDataSet.tJob, JobID) > 0 Then
            Me.drJ = Me.TKSIJOBSDataSet.tJob(0)
            Me.TPOHeaderTableAdapter1.FillByNJOBID(Me.TKSIJOBSDataSet.tPOHeader, Me.drJ.nID)
            Me.TCustomrTableAdapter1.FillByLID(Me.TKSIJOBSDataSet.tCustomr, Me.drJ.nCustID)
            Me.TVendorTableAdapter1.Fill(Me.TKSIJOBSDataSet.tVendor)
            Me.TAddressTableAdapter1.Fill(Me.TKSIJOBSDataSet.tAddress, Me.drJ.nAddressID)
        End If

        Me.flexJobComm.Rows.Count = 0

        PopulateCheckListActivityView()

        Dim sAddress As String = ""
        Try
            'Dim tblAddress As TKSIJOBSDataSet.tAddressDataTable
            'tblAddress = Me.TAddressTableAdapter1.GetData(drJ.nAddressID)
            sAddress = Me.drJ.tAddressRow.sAddress1 & " " & Me.drJ.tAddressRow.sAddress2
        Catch ex As Exception
            sAddress = "error loading address"
        End Try

        If Not drJ.tCustomrRow Is Nothing Then
            Me.lblTop1.Text = "Job Communication   " & drJ.sJobNo & "    " & drJ.tCustomrRow.sName
        Else
            Me.lblTop1.Text = "Error no customer/builder info!"
        End If

        Me.txtContact.Text = drJ.sJobContact
        Me.txtTerms.Text = drJ.sTerms
        Me.txtJobDesc.Text = drJ.sJobDesc
        Me.txtPaymentNotes.Text = drJ.sOtherNotes

        Me.flexJobComm.AddItem("0" & ControlChars.Tab & "Required" & ControlChars.Tab & "PO" & ControlChars.Tab & "Supplier" & ControlChars.Tab & "Date Rec" & ControlChars.Tab & "Items" & ControlChars.Tab & "Quantity" & ControlChars.Tab & "FOB")
        Me.flexJobComm.Rows(0).Style = Me.flexJobComm.Rows(0).StyleFixed

        Dim dSoonestDateRequired As Date = CDate("1/1/2999")

        Dim drH As TKSIJOBSDataSet.tPOHeaderRow
        For Each drH In drJ.GettPOHeaderRows

            If drH.dRequired < dSoonestDateRequired Then
                dSoonestDateRequired = drH.dRequired
            End If

            Dim style1 As CellStyle
            If drH.IsDRECNull Then
                style1 = csWhite
            Else
                If drH.IsDDELNull Then
                    style1 = csYellow
                Else
                    style1 = csGreen
                End If
            End If

            Dim sDatereceived As String = ""
            If drH.IsDRECNull Then
                sDatereceived = ""
            Else
                sDatereceived = drH.DREC.ToShortDateString
            End If

            Dim sDateRequired As String = ""
            If drH.IsdPODateNull Then
                sDateRequired = ""
            Else
                sDateRequired = drH.dRequired.ToShortDateString
            End If

            Dim sVendor As String = ""
            If Not drH.tVendorRow Is Nothing Then
                sVendor = drH.tVendorRow.sName
            End If

            Dim r1 As Row
            r1 = Me.flexJobComm.AddItem(drH.nID & ControlChars.Tab & sDateRequired & ControlChars.Tab & drH.sPONum & ControlChars.Tab & sVendor & ControlChars.Tab & sDatereceived & ControlChars.Tab & drH.sItemDesc & ControlChars.Tab & drH.sItems & ControlChars.Tab & drH.sFOB)
            r1.Style = style1
        Next

        Me.txtJobsite.Enabled = True
        Me.txtJobsite.Text = sAddress
        Me.txtJobsite.Enabled = False

        Me.txtPhone.Text = drJ.sPhone

        Me.txtShipDate.Enabled = True
        Me.txtShipDate.Text = dSoonestDateRequired.ToShortDateString
        Me.txtShipDate.Enabled = False

        Me.txtSales.Enabled = True
        Me.txtSales.Text = drJ.sSalesperson
        Me.txtSales.Enabled = False

        CalcInvoiceTotalDueLinq()

        Me.TblJobActivityTableAdapter.Fill(Me.TKSIJOBSDataSet.tblJobActivity, Me.drJ.nID)

        Me.TblTrailerHeaderTableAdapter1.FillByJobCode5digit(Me.TKSIJOBSDataSet.tblTrailerHeader, Me.drJ.sJobNo & "%")
        Me.TblTrailerDetailTableAdapter1.FillByJobCode(Me.TKSIJOBSDataSet.tblTrailerDetail, Me.drJ.sJobNo & "%")

        Dim r2 As Row
        For Each r2 In Me.flexParts.Rows
            If IsDate(r2.Item(6)) Then
                r2.Style = csYellow
            End If
            If IsDate(r2.Item(7)) Then
                r2.Style = csGreen
            End If
        Next
    End Sub

    'Private Sub CalcInvoiceTotalDue()

    '    Try
    '        Dim dsTK As New dsTKSI
    '        dsTK.EnforceConstraints = False

    '        Dim ojob As New JobObj
    '        ojob.SelectAddressJobPOSOByAddressID(dsTK, drJ.nAddressID)

    '        Dim drJob1 As dsTKSI.tJobRow
    '        drJob1 = dsTK.tJob.FindBynID(drJ.nID)

    '        Dim CommentBalance As Decimal
    '        Dim ItemBalance As Decimal

    '        If Not drJob1 Is Nothing Then
    '            Try
    '                If drJob1.sTerms.ToUpper.Contains("PIA") Or drJob1.sTerms.ToUpper.Contains("NET") Then
    '                    'dont try to collect money 

    '                Else


    '                    'collect hourly even though no invoice has been generated yet
    '                    Dim balanceduetitle = ""
    '                    Dim blnUseBalanceDue As Boolean = False
    '                    Try
    '                        If drJob1.sTerms.ToUpper.Contains("NET") Then
    '                            balanceduetitle = drJob1.sTerms
    '                        ElseIf drJob1.sTerms.ToUpper.Contains("PIA") Then
    '                            balanceduetitle = "Paid In Advance"
    '                        Else   '50-50 or 50-40-10 or COD or whatever
    '                            balanceduetitle = "Balance Due:"
    '                            If drJob1.InvBalanceRemaining = 0 And drJob1.HasSWO_PO Then
    '                                balancedue = "Billable Hourly"
    '                            Else
    '                                balancedue = Format(drJob1.InvBalanceRemaining, "currency")
    '                            End If
    '                        End If
    '                    Catch
    '                    End Try

    '                    Me.txtPaymentNotes.Text = "BILLABLE HOURLY"

    '                End If
    '            Catch
    '                Me.txtPaymentNotes.Text = "*error*"
    '            End Try

    '            ojob.InitAccountTotals(drJob1)

    '            Dim drLine As dsTKSI.tSOLineRow
    '            If drJob1.GettSOHeaderRows.Length > 0 Then
    '                For Each drLine In drJob1.GettSOHeaderRows(0).GettSOLineRows
    '                    If UCase(drLine.sType) = "ITEM" Then
    '                        ItemBalance = ItemBalance + drLine.nAmount
    '                    Else
    '                        If UCase(drLine.sType) = "COMMENT" Then
    '                            CommentBalance = CommentBalance + drLine.nAmount
    '                        End If
    '                        If UCase(drLine.sType) = "BALANCE" Then

    '                        End If
    '                    End If
    '                Next

    '                Me.txtInvoiceDue.Text = TwoDecimal(CommentBalance)
    '            End If

    '        End If
    '    Catch ex As Exception
    '        Try
    '            Me.txtInvoiceDue.Text = "** ERROR In Calculating Invoice **"
    '        Catch
    '        End Try
    '    End Try

    'End Sub

    Private Sub CalcInvoiceTotalDueLinq()

        Try
            Dim dc As linqTKSIDataContext = GetLinqDataContext()

            Dim q = (From row In dc.tJobs Where row.nID = drJ.nID)
            If q.Count > 0 Then
                Dim _job As tJob = q.First
                Dim CommentBalance As Decimal
                Dim ItemBalance As Decimal

                If _job IsNot Nothing Then
                    Try

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

                        Me.txtPaymentNotes.Text = balanceduetitle & " " & balancedue

                    Catch
                        Me.txtPaymentNotes.Text = "*error*"
                    End Try

                    Dim dsTK As New dsTKSI
                    dsTK.EnforceConstraints = False

                    Dim ojob As New JobObj
                    ojob.SelectAddressJobPOSOByAddressID(dsTK, drJ.nAddressID)

                    Dim drJob1 As dsTKSI.tJobRow
                    drJob1 = dsTK.tJob.FindBynID(drJ.nID)

                    ojob.InitAccountTotals(drJob1)

                    Dim drLine As dsTKSI.tSOLineRow
                    If drJob1.GettSOHeaderRows.Length > 0 Then
                        For Each drLine In drJob1.GettSOHeaderRows(0).GettSOLineRows
                            If UCase(drLine.sType) = "ITEM" Then
                                ItemBalance = ItemBalance + drLine.nAmount
                            Else
                                If UCase(drLine.sType) = "COMMENT" Then
                                    CommentBalance = CommentBalance + drLine.nAmount
                                End If
                                If UCase(drLine.sType) = "BALANCE" Then

                                End If
                            End If
                        Next

                        Me.txtInvoiceDue.Text = TwoDecimal(CommentBalance)
                    End If

                End If
            End If
        
        Catch ex As Exception
            Try
                Me.txtInvoiceDue.Text = "** ERROR In Calculating Invoice **"
            Catch
            End Try
        End Try

    End Sub

    Private Sub PopulateCheckListActivityView()
        Me.lvCallNote.Items.Clear()

        Dim dr As TKSIJOBSDataSet.tblActivityTypeRow
        For Each dr In Me.TKSIJOBSDataSet.tblActivityType
            If InStr(dr.ActivityName, "Delivered") > 0 Or InStr(dr.ActivityName, "Received") > 0 Then

            Else
                Me.lvCallNote.Items.Add(dr.ActivityName, False)
            End If

        Next
    End Sub

    Private Sub TblJobActivityDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblJobActivityDataGridView.RowLeave
        If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(0).Value Is DBNull.Value Then

            Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(0).Value = Guid.NewGuid
            Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(1).Value = drJ.nID
            If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(2).Value Is DBNull.Value Then
                Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(2).Value = Now
            End If

            If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(3).Value Is DBNull.Value Then
                Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(3).Value = "MISC"
            End If

            If Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(4).Value Is DBNull.Value Then
                Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(4).Value = ""
            End If

            Me.TblJobActivityDataGridView.Rows(e.RowIndex).Cells(5).Value = ""

        End If


    End Sub

    Private Sub TblJobActivityDataGridView_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TblJobActivityDataGridView.Validated
        Try
            Me.Validate()
            Me.TblJobActivityBindingSource.EndEdit()
            Dim drAct As TKSIJOBSDataSet.tblJobActivityRow

            Me.TblJobActivityTableAdapter.Update(Me.TKSIJOBSDataSet.tblJobActivity)

            For Each drAct In Me.TKSIJOBSDataSet.tblJobActivity
                If drAct.ActivityType.Trim = "MISC" And drAct.ActivityDetail.Trim = "" Then
                    drAct.Delete()
                End If
            Next

            Me.TblJobActivityTableAdapter.Update(Me.TKSIJOBSDataSet.tblJobActivity)
        Catch ex As Exception
            '???
        End Try

    End Sub

    Private Sub btnAddCallNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCallNote.Click
        Dim item1 As String = ""
        Dim itemImportant As String = ""
        Dim itemDetail As String = ""
        Dim itemFirstInList As String = ""

        For Each item1 In Me.lvCallNote.CheckedItems
            If itemFirstInList.Length = 0 Then
                itemFirstInList = item1
            End If
            Dim drType As TKSIJOBSDataSet.tblActivityTypeRow
            drType = Me.TKSIJOBSDataSet.tblActivityType.FindByActivityName(item1)
            If Not drType Is Nothing Then
                If drType.CauseReminder Then
                    itemImportant = item1
                End If
            End If

            itemDetail = itemDetail & item1 & " "

        Next

        If itemImportant.Length = 0 Then
            itemImportant = itemFirstInList
        End If

        If UCase(itemImportant.Trim) = "WAITING ON ANOTHER JOB" Then
            If Me.txtCallNote.Text.Trim.Length < 5 Then
                Windows.Forms.MessageBox.Show("You must type in a 5 digit job number to use that feature.")
                Exit Sub
            Else
                itemDetail = itemDetail & " " & Me.txtCallNote.Text.Trim
                Me.txtCallNote.Text = ""
            End If
        End If

        Dim drA As TKSIJOBSDataSet.tblJobActivityRow
        drA = Me.TKSIJOBSDataSet.tblJobActivity.NewtblJobActivityRow
        With drA
            .ActivityDetail = itemDetail
            .ActivityType = UCase(itemImportant)
            .gID = Guid.NewGuid
            .dateEntered = Now
            .Other = ""
            .nJobID = drJ.nID
        End With
        Me.TKSIJOBSDataSet.tblJobActivity.Rows.Add(drA)

        If Me.txtCallNote.Text.Trim.Length > 0 Then
            drA = Me.TKSIJOBSDataSet.tblJobActivity.NewtblJobActivityRow
            With drA
                .ActivityDetail = Me.txtCallNote.Text.Trim
                .ActivityType = "MISC"
                .gID = Guid.NewGuid
                .dateEntered = Now
                .Other = ""
                .nJobID = drJ.nID
            End With
            Me.TKSIJOBSDataSet.tblJobActivity.Rows.Add(drA)
        End If


        If Me.DateTimePicker1.Value > Now Then
            drA = Me.TKSIJOBSDataSet.tblJobActivity.NewtblJobActivityRow
            With drA
                .ActivityDetail = "Call Back " & Me.DateTimePicker1.Value.ToShortDateString
                .ActivityType = "CALL BACK"
                .gID = Guid.NewGuid
                .dateEntered = Now
                .Other = ""
                .nJobID = drJ.nID
            End With
            Me.TKSIJOBSDataSet.tblJobActivity.Rows.Add(drA)
        End If

        Me.TblJobActivityTableAdapter.Update(Me.TKSIJOBSDataSet.tblJobActivity)
        Me.TblJobActivityDataGridView.Refresh()

        Me.lvCallNote.ClearSelected()

        Me.txtCallNote.Text = ""
        Me.DateTimePicker1.Value = Now

    End Sub

    Private alImagesToPrint8x11 As New List(Of Image)
    Private alImagesToPrint11x17 As New List(Of Image)
    Private iCurrentPagePrinting As Integer = 0

    Private Sub btnPrintJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintJob.Click
        Me.PrintJobToPDF(Me.chkAll8x11.Checked)
    End Sub

    Friend Sub PrintJobToPDF(ByVal bln8x11 As Boolean)

        Try
            Dim imageToPrint As Image
            iCurrentPagePrinting = 0
            Dim listImagesToPrint8x11 = New List(Of String)
            Dim listImagesToPrint11x17 = New List(Of String)

            Dim sJob5 As String = Mid(Me.drJ.sJobNo, 1, 6)
            If IsNumeric(sJob5) Then
                'leave as 6 digit for folder/file creation
            ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                sJob5 = Mid(sJob5, 1, 5)
            Else
                sJob5 = Mid(sJob5, 1, 4)
            End If

            If System.IO.Directory.Exists(sImagesPath & sJob5 & "\") Then
                If System.IO.Directory.Exists(sImagesPath & sJob5 & "\" & Me.drJ.sJobNo & "\") Then
                    Dim listFiles = IO.Directory.GetFiles(sImagesPath & sJob5 & "\" & Me.drJ.sJobNo)
                    If listFiles.Length > 0 Then

                        Dim qfile1 = (From row1 In listFiles Where row1.Length > 6 Select New With {.longfile = row1, .shortfile = IO.Path.GetFileName(row1)})

                        Dim qfile2 = (From row1 In qfile1 Order By row1.shortfile.PadLeft(2, "0") Select row1.longfile)

                        Dim file1 As String
                        For Each file1 In qfile2 ' IO.Directory.GetFiles(sImagesPath & sJob5 & "\" & Me.drJ.sJobNo)
                            If file1.ToUpper.Contains(".TIF") Or file1.ToUpper.Contains(".JPG") Then
                                ' listImagesToPrint8x11.Add(file1)

                                Dim fs As New IO.FileStream(file1, IO.FileMode.Open, IO.FileAccess.Read)
                                imageToPrint = Image.FromStream(fs, False, False)
                                Dim width = imageToPrint.PhysicalDimension.Width
                                Dim height = imageToPrint.PhysicalDimension.Height
                                '      Dim hres = imageToPrint.HorizontalResolution
                                imageToPrint.Dispose()
                                fs.Close()
                                imageToPrint = Nothing
                                fs = Nothing
                                If width > 2400 And height > 3000 Then
                                    'this is a large scan, use 11x17 paper
                                    listImagesToPrint11x17.Add(file1)
                                Else
                                    If (width / height > 0.7) Or bln8x11 Then
                                        listImagesToPrint8x11.Add(file1)
                                    Else
                                        listImagesToPrint11x17.Add(file1)
                                    End If
                                End If


                            ElseIf file1.ToUpper.Contains(".PDF") Then
                                Process.Start(file1)
                            End If
                        Next
                    End If


                    If System.IO.Directory.Exists(sImagesPath & sJob5 & "\MAPS\") Then
                        For Each file1 In IO.Directory.GetFiles(sImagesPath & sJob5 & "\MAPS\")
                            If file1.ToUpper.Contains(".TIF") Or file1.ToUpper.Contains(".JPG") Or file1.ToUpper.Contains(".BMP") Then
                                listImagesToPrint8x11.Add(file1)
                            End If
                        Next
                    End If
                End If
            End If

            Dim pdf1 As clsPDFCreate
            If listImagesToPrint11x17.Count > 0 Then
                pdf1 = New clsPDFCreate(sJob5, True, True)
              

            Else
                pdf1 = New clsPDFCreate(sJob5, True, False)
            End If
            pdf1.AddLetterPage()
            pdf1.PrintJobCommunicationSheetPDF(Me.drJ.nID)

            For Each img8x11 In listImagesToPrint8x11
                pdf1.AddLetterPage()
                pdf1.InsertImage8x11(img8x11)
            Next

            For Each img11x17 In listImagesToPrint11x17
                pdf1.AddTabloidPage()
                pdf1.InsertImage11x17(img11x17)
            Next

            pdf1.ShowPDF()

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error in printing process... " & ex.Message)
        End Try


    End Sub

    Friend Sub PrintJob(ByVal blnPreview As Boolean, ByVal bln8x11 As Boolean)

        Try
            Dim imageToPrint As Image
            iCurrentPagePrinting = 0
            alImagesToPrint8x11 = New List(Of Image)
            alImagesToPrint11x17 = New List(Of Image)

            Dim pdf1 As New clsPDFCreate("jobcomm", True, False)
            pdf1.PrintJobCommunicationSheetPDF(drJ.nID)
            pdf1.ShowPDF()

            Dim sJob5 As String = Mid(Me.drJ.sJobNo, 1, 6)
            If IsNumeric(sJob5) Then
                'leave as 6 digit for folder/file creation
            ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                sJob5 = Mid(sJob5, 1, 5)
            Else
                sJob5 = Mid(sJob5, 1, 4)
            End If

            If System.IO.Directory.Exists(sImagesPath & sJob5 & "\") Then
                If System.IO.Directory.Exists(sImagesPath & sJob5 & "\" & Me.drJ.sJobNo & "\") Then

                    Dim file1 As String
                    For Each file1 In IO.Directory.GetFiles(sImagesPath & sJob5 & "\" & Me.drJ.sJobNo)
                        If file1.ToUpper.Contains(".TIF") Or file1.ToUpper.Contains(".JPG") Then
                            Dim fs As New IO.FileStream(file1, IO.FileMode.Open, IO.FileAccess.Read)

                            imageToPrint = Image.FromStream(fs) ' New Bitmap(file1)

                            If (imageToPrint.Width / imageToPrint.Height > 0.7) Or bln8x11 Then
                                Me.alImagesToPrint8x11.Add(imageToPrint)
                            Else
                                Me.alImagesToPrint11x17.Add(imageToPrint)
                            End If
                        ElseIf file1.ToUpper.Contains(".PDF") Then
                            Process.Start(file1)
                        End If
                    Next

                    If System.IO.Directory.Exists(sImagesPath & sJob5 & "\MAPS\") Then
                        For Each file1 In IO.Directory.GetFiles(sImagesPath & sJob5 & "\MAPS\")
                            If file1.ToUpper.Contains(".TIF") Or file1.ToUpper.Contains(".JPG") Or file1.ToUpper.Contains(".BMP") Then
                                imageToPrint = New Bitmap(file1)
                                Me.alImagesToPrint8x11.Add(imageToPrint)
                            End If

                        Next
                    End If
                End If
            End If

            'begin printing
            Dim settings As New System.Drawing.Printing.PrinterSettings
            If Me.alImagesToPrint8x11.Count > 0 Then
                Me.PrintDocument8x11.PrinterSettings.PrinterName = settings.PrinterName
                Dim print1 As New System.Drawing.Printing.PageSettings
                print1.Landscape = False
                With print1
                    Try
                        Dim paper As Long
                        paper = GetLetterPaperEnum(print1)
                        If paper >= 0 Then
                            .PaperSize = .PrinterSettings.PaperSizes(paper)
                        End If
                    Catch ex As Exception
                    End Try
                    .PrinterSettings.PrinterName = settings.PrinterName
                    .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                    .Margins.Bottom = 0
                    .Margins.Left = 0
                    .Margins.Top = 0
                    .Margins.Right = 0
                End With
                Me.PrintDocument8x11.DefaultPageSettings = print1

                If blnPreview Then
                    Dim frmprev As New frmPrintPrev
                    frmprev.C1PrintPreviewControl1.Document = Me.PrintDocument8x11
                    frmprev.ShowDialog()
                Else
                    Me.PrintDocument8x11.Print()
                End If

            End If

            If Me.alImagesToPrint11x17.Count > 0 Then
                Me.PrintDocument11x17.PrinterSettings.PrinterName = settings.PrinterName
                Dim print2 As New System.Drawing.Printing.PageSettings
                print2.Landscape = False
                With print2
                    Try
                        Dim paper As Long
                        paper = GetLetterPaperEnum(print2, "11 x 17")
                        If paper >= 0 Then
                            .PaperSize = .PrinterSettings.PaperSizes(paper)
                        Else
                            paper = GetLetterPaperEnum(print2, "11x17")
                            If paper >= 0 Then
                                .PaperSize = .PrinterSettings.PaperSizes(paper)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                    .PrinterSettings.PrinterName = settings.PrinterName
                    .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                    .Margins.Bottom = 0
                    .Margins.Left = 0
                    .Margins.Top = 0
                    .Margins.Right = 0
                End With
                Me.PrintDocument11x17.DefaultPageSettings = print2
                'Me.PrintDocument11x17.Print()

                If blnPreview Then
                    Dim frmprev2 As New frmPrintPrev
                    frmprev2.C1PrintPreviewControl1.Document = Me.PrintDocument11x17
                    frmprev2.ShowDialog()
                Else
                    Me.PrintDocument11x17.Print()
                End If

            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error in printing process... " & ex.Message)
        End Try


    End Sub

    Private Sub mnuDeliverPO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDeliverPO.Click
        With Me.flexJobComm
            If .RowSel > 0 Then
                Dim nPOID As Integer = 0
                nPOID = .Rows(.RowSel)(0).ToString
                Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
                For Each drPO In drJ.GettPOHeaderRows
                    If drPO.nID = nPOID Then
                        If drPO.IsDDELNull Then
                            drPO.DDEL = Today.Date
                            Me.TPOHeaderTableAdapter1.Update(drPO.Table)

                        End If
                    End If
                Next

            End If
        End With

    End Sub

    Private Sub btnSaveJobComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveJobComm.Click
        If Not Me.drJ Is Nothing Then
            Me.drJ.sPhone = Me.txtPhone.Text.Trim
            Me.drJ.sJobContact = Me.txtContact.Text.Trim
            Me.drJ.sTerms = Me.txtTerms.Text.Trim
            Me.drJ.sOtherNotes = Me.txtPaymentNotes.Text.Trim
            Me.TJobTableAdapter1.Update(drJ.Table)
        End If
    End Sub

    Private Sub flexJobComm_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles flexJobComm.DoubleClick
        Dim nPOID As Integer = 0
        Dim oJob As New JobObj

        nPOID = Me.flexJobComm.Rows(Me.flexJobComm.RowSel)(0).ToString()

        Dim ds2 As New dsTKSI
        ds2.EnforceConstraints = False
        oJob.daPOByNID.SelectCommand.Parameters("@NID").Value = nPOID
        oJob.daPOByNID.Fill(ds2.tPOHeader)

        If ds2.tPOHeader.Rows.Count > 0 Then

            oJob.daPOLineByNJobID.SelectCommand.Parameters("@NJOBID").Value = ds2.tPOHeader(0).nJobID
            oJob.daPOLineByNJobID.Fill(ds2.tPOLine)
            Dim drPO As dsTKSI.tPOHeaderRow
            drPO = ds2.tPOHeader(0)

            OpenPOScreen(drPO.nID, True)

        End If

    End Sub

    Private Sub btnDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeliver.Click
        If Windows.Forms.MessageBox.Show("Are you sure you want to remove this entire Job (" & drJ.sJobNo & ") from Current Accounts?", "Remove CA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
            For Each drPO In drJ.GettPOHeaderRows
                If drPO.IsDDELNull Then
                    drPO.DDEL = Today.Date
                End If

            Next
            Me.TPOHeaderTableAdapter1.Update(drJ.Table.DataSet)
        End If

    End Sub

    Private Sub PrintDocument8x11_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument8x11.EndPrint
        Try
            For Each Image1 In Me.alImagesToPrint8x11
                Try

                    Image1.Dispose()
                Catch
                End Try
            Next
        Catch
        End Try
    End Sub

    Private Sub PrintDocument8x11_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument8x11.PrintPage
        Me.iCurrentPagePrinting += 1
        Dim img1 As Image
        img1 = Me.alImagesToPrint8x11(Me.iCurrentPagePrinting - 1)

        e.Graphics.DrawImage(img1, 0, 0, 850, 1100)

        If Me.iCurrentPagePrinting >= Me.alImagesToPrint8x11.Count Then
            Me.iCurrentPagePrinting = 0
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If

    End Sub

    Private Sub PrintDocument11x17_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument11x17.EndPrint
        Try
            For Each Image1 In Me.alImagesToPrint11x17
                Try
                    Image1.Dispose()
                Catch
                End Try
            Next
        Catch
        End Try
    End Sub

    Private Sub PrintDocument11x17_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument11x17.PrintPage
        Dim settings As New System.Drawing.Printing.PrinterSettings
        Me.PrintDocument11x17.PrinterSettings.PrinterName = settings.PrinterName

        Dim print2 As New System.Drawing.Printing.PageSettings
        print2.Landscape = False
        With print2
            Try
                Dim paper As Long
                paper = GetLetterPaperEnum(print2, "11 x 17")
                If paper >= 0 Then
                    .PaperSize = .PrinterSettings.PaperSizes(paper)
                Else
                    paper = GetLetterPaperEnum(print2, "11x17")
                    If paper >= 0 Then
                        .PaperSize = .PrinterSettings.PaperSizes(paper)
                    End If
                End If
            Catch ex As Exception
            End Try
            .PrinterSettings.PrinterName = settings.PrinterName
            .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages

            .Margins.Bottom = 0
            .Margins.Left = 0
            .Margins.Top = 0
            .Margins.Right = 0
        End With

        Me.PrintDocument11x17.DefaultPageSettings = print2

        Me.iCurrentPagePrinting += 1
        Dim img1 As Image
        img1 = Me.alImagesToPrint11x17(Me.iCurrentPagePrinting - 1)

        e.Graphics.DrawImage(img1, 30, 30, 1070, 1670)

        If Me.iCurrentPagePrinting >= Me.alImagesToPrint11x17.Count Then
            Me.iCurrentPagePrinting = 0
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnShowMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMapImages.Click
        Dim file1 As String = ""
        Dim img1 As Image

        Dim sJob5 As String = Mid(Me.drJ.sJobNo, 1, 6)
        If IsNumeric(sJob5) Then
            'leave as 6 digit for folder/file creation
        ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
            sJob5 = Mid(sJob5, 1, 5)
        Else
            sJob5 = Mid(sJob5, 1, 4)
        End If

        If System.IO.Directory.Exists(sImagesPath & sJob5 & "\MAPS\") Then
            For Each file1 In IO.Directory.GetFiles(sImagesPath & sJob5 & "\MAPS\")
                img1 = Image.FromFile(file1)
                Dim full1 As New frmFullpage
                full1.PictureBox1.Image = img1
                full1.Show()
            Next
        End If
    End Sub

    Private Sub btnShowAllImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmBusy As New frmWorking
        frmBusy.Text = frmBusy.Text & " Showing Images..."
        Try
            frmBusy.Show()

            Dim sJob5 As String = Mid(Me.drJ.sJobNo, 1, 6)
            If IsNumeric(sJob5) Then
                'leave as 6 digit for folder/file creation
            ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                sJob5 = Mid(sJob5, 1, 5)
            Else
                sJob5 = Mid(sJob5, 1, 4)
            End If

            Dim strJobPath As String = sImagesPath & sJob5 & "\"
            Dim strJobPath5digit As String = strJobPath & Me.drJ.sJobNo & "\"
            Dim strJobPathMaps As String = strJobPath & "MAPS\"

            Dim frm1 As Form


            frm1 = New Form
            With frm1
                .AutoScroll = True
                .AutoScaleBaseSize = New System.Drawing.Size(5, 13)
                .ClientSize = New System.Drawing.Size(860, 1200)
                .Name = "Show Job Images"
                .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                .Text = "Show Job Images"
            End With

            Dim file1 As String = ""
            Dim iOrderImages As Integer = 0

            Dim pdf1 As New clsPDFCreate("jobcomm", True, False)
            pdf1.PrintJobCommunicationSheetPDF(drJ.nID)
            pdf1.ShowPDF()


            iOrderImages += 1
            If System.IO.Directory.Exists(strJobPath) Then
                If System.IO.Directory.Exists(strJobPath5digit) Then
                    For Each file1 In IO.Directory.GetFiles(strJobPath5digit)

                        Dim fs As New IO.FileStream(file1, IO.FileMode.Open, IO.FileAccess.Read)

                        Me.AddImageToFormPreview(frm1, Image.FromStream(fs), iOrderImages)
                        iOrderImages += 1
                    Next
                End If

                If System.IO.Directory.Exists(strJobPathMaps) Then
                    For Each file1 In IO.Directory.GetFiles(strJobPathMaps)
                        Dim fs As New IO.FileStream(file1, IO.FileMode.Open, IO.FileAccess.Read)
                        Me.AddImageToFormPreview(frm1, Image.FromStream(fs), iOrderImages)
                        iOrderImages += 1
                    Next
                End If
            End If

            frm1.ShowDialog()

            frmBusy.Close()
            frmBusy = Nothing

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Try
                If Not frmBusy Is Nothing Then
                    frmBusy.Close()
                End If
            Catch ex As Exception
            End Try
        End Try

    End Sub

    Private Sub AddImageToFormPreview(ByVal frm1 As Form, ByVal img1 As Image, ByVal tabOrder As Integer)
        With frm1

            Dim PictureBox1 As System.Windows.Forms.PictureBox
            PictureBox1 = New System.Windows.Forms.PictureBox
            '
            PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            PictureBox1.Location = New System.Drawing.Point(0, 0)
            PictureBox1.Name = "PictureBox1"
            PictureBox1.Size = New System.Drawing.Size(850, 1100)
            PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            PictureBox1.TabIndex = tabOrder
            PictureBox1.TabStop = False
            PictureBox1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            .Controls.Add(PictureBox1)
            PictureBox1.Image = img1
            PictureBox1.BringToFront()
        End With
    End Sub

End Class
