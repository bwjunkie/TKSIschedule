Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports System.Drawing
Public Class frmDeposits
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents lvOrders As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRefeshList As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DAY As System.Windows.Forms.ColumnHeader
    Friend WithEvents depnum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cashrec As System.Windows.Forms.ColumnHeader
    Friend WithEvents overshort As System.Windows.Forms.ColumnHeader
    Friend WithEvents deposit As System.Windows.Forms.ColumnHeader
    Friend WithEvents reference As System.Windows.Forms.ColumnHeader
    Friend WithEvents customername As System.Windows.Forms.ColumnHeader
    Friend WithEvents invoiced As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvOrders = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.DAY = New System.Windows.Forms.ColumnHeader
        Me.depnum = New System.Windows.Forms.ColumnHeader
        Me.cashrec = New System.Windows.Forms.ColumnHeader
        Me.overshort = New System.Windows.Forms.ColumnHeader
        Me.deposit = New System.Windows.Forms.ColumnHeader
        Me.invoiced = New System.Windows.Forms.ColumnHeader
        Me.reference = New System.Windows.Forms.ColumnHeader
        Me.customername = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblDate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRefeshList = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnPrint = New System.Windows.Forms.Button
        Me.DsTKSI1 = New dsTKSI
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvOrders
        '
        Me.lvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.DAY, Me.depnum, Me.cashrec, Me.overshort, Me.deposit, Me.invoiced, Me.reference, Me.customername})
        Me.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOrders.FullRowSelect = True
        Me.lvOrders.GridLines = True
        Me.lvOrders.HideSelection = False
        Me.lvOrders.Location = New System.Drawing.Point(0, 56)
        Me.lvOrders.MultiSelect = False
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.Size = New System.Drawing.Size(872, 414)
        Me.lvOrders.TabIndex = 0
        Me.lvOrders.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'DAY
        '
        Me.DAY.Text = "DAY"
        Me.DAY.Width = 70
        '
        'depnum
        '
        Me.depnum.Text = ""
        Me.depnum.Width = 40
        '
        'cashrec
        '
        Me.cashrec.Text = "Cash Rec."
        Me.cashrec.Width = 90
        '
        'overshort
        '
        Me.overshort.Text = "Over/Short"
        Me.overshort.Width = 90
        '
        'deposit
        '
        Me.deposit.Text = "Deposit"
        Me.deposit.Width = 90
        '
        'invoiced
        '
        Me.invoiced.Text = "Invoiced"
        Me.invoiced.Width = 90
        '
        'reference
        '
        Me.reference.Text = "Reference #"
        Me.reference.Width = 90
        '
        'customername
        '
        Me.customername.Text = "Customer Name"
        Me.customername.Width = 222
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 56)
        Me.Panel1.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(408, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(256, 16)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deposits Report"
        '
        'btnRefeshList
        '
        Me.btnRefeshList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefeshList.Location = New System.Drawing.Point(16, 8)
        Me.btnRefeshList.Name = "btnRefeshList"
        Me.btnRefeshList.Size = New System.Drawing.Size(104, 32)
        Me.btnRefeshList.TabIndex = 1
        Me.btnRefeshList.Text = "Refresh"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnRefeshList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 48)
        Me.Panel2.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Location = New System.Drawing.Point(144, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 32)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frmDeposits
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(872, 518)
        Me.Controls.Add(Me.lvOrders)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmDeposits"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend dateStart As Date
    Friend dateEnd As Date
    Private JobCollection1 As JobCollection
    Private alTaxDistrictColumns As ArrayList
    Private oJob As New JobObj

    Private Structure JobCollection
        Friend JobDetailList As ArrayList

        Friend Sub AddJob(ByVal JobDetail1 As JobDetail)

            If Me.JobDetailList Is Nothing Then
                Me.JobDetailList = New ArrayList
            End If

            Me.JobDetailList.Add(JobDetail1)
            Me.cashRec += JobDetail1.CashReceived
            Me.overShort += JobDetail1.Overshort
            Me.Deposit += JobDetail1.deposit
            Me.Invoiced += JobDetail1.Invoiced

        End Sub

        Friend cashRec As Double
        Friend overShort As Double
        Friend Deposit As Double
        Friend Invoiced As Double

        Structure JobDetail
            Public Sub New(ByVal JOBID As String)
                Me.JobID = ""
                Me.Day = ""
                Me.CashReceived = 0
                Me.Invoiced = 0
                Me.Reference = ""
                Me.Customer = ""
                Me.deposit = 0
                Me.Overshort = 0

            End Sub

            Dim LineID As String
            Dim SOID As String
            Dim JobID As String
            Dim Day As String
            Dim CashReceived As Double
            Dim Reference As String
            Dim Customer As String
            Dim Overshort As Double
            Dim deposit As Double
            Dim Invoiced As Double
        End Structure

    End Structure

    Structure TaxDistrict
        Dim distID As Long
        Dim DistrictName As String
        Dim Amount As Double
        Dim reportSumAmount As Double
    End Structure

    Private Sub frmOrdersInWarehouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataAndDisplay()
    End Sub

    Private Sub LoadDataAndDisplay()
        'oJob.SelectDSIMPLYRangeALLData(Me.DsTKSI1, Me.dateStart, Me.dateEnd)
        oJob.SelectDepositsByDSimply(Me.DsTKSI1, Me.dateStart, Me.dateEnd)
        oJob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1)

        PopulateDepositList()
        DrawListViewFromJobList(Me.JobCollection1)
    End Sub

    Private Sub DrawListViewFromJobList(ByVal JobCollection1 As JobCollection)

        Me.lvOrders.Items.Clear()

        Dim job1 As New JobCollection.JobDetail
        Dim tempItem As New ListViewItem
        Dim lastDate As String = ""
        Dim miniTotal As Decimal = 0

        Try
            For Each job1 In JobCollection1.JobDetailList
                If job1.Day.Length > 0 And miniTotal <> 0 Then
                    'day has changed, print sub total
                    tempItem = New ListViewItem
                    tempItem.Text = ""
                    With tempItem.SubItems
                        .Add("Sub-Tot:")
                        .Add("")
                        .Add(Format(miniTotal, "currency"))
                    End With
                    tempItem.BackColor = Color.LightGreen
                    Me.lvOrders.Items.Add(tempItem)
                    miniTotal = 0

                    tempItem = New ListViewItem("")
                    Me.lvOrders.Items.Add(tempItem)

                    Try
                        Me.lblDate.Text = CDate(job1.Day).Month & "/" & CDate(job1.Day).Year & " DEPOSITS JOURNAL"
                    Catch ex As Exception
                    End Try
                End If

                tempItem = New ListViewItem
                tempItem.Text = job1.JobID
                With tempItem.SubItems
                    .Add(job1.Day)
                    .Add("")
                    .Add(Format(job1.CashReceived, "currency"))
                    .Add(Format(job1.Overshort.ToString, "currency"))
                    .Add(Format(job1.deposit, "currency"))
                    .Add(Format(job1.Invoiced, "currency"))
                    .Add(job1.Reference.ToString)
                    .Add(job1.Customer.ToString)
                End With
                Me.lvOrders.Items.Add(tempItem)

                lastDate = job1.Day
                miniTotal += job1.CashReceived
            Next

            'day has changed, print sub total
            tempItem = New ListViewItem
            tempItem.Text = ""
            With tempItem.SubItems
                .Add("Sub-Tot:")
                .Add("")
                .Add(Format(miniTotal, "currency"))
            End With
            tempItem.BackColor = Color.LightGreen
            Me.lvOrders.Items.Add(tempItem)

            tempItem = New ListViewItem("")
            Me.lvOrders.Items.Add(tempItem)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        tempItem = New ListViewItem
        tempItem.BackColor = Color.SkyBlue
        tempItem.Text = ""
        With tempItem.SubItems
            .Add("TOT.")
            .Add("")
            .Add(Format(Me.JobCollection1.cashRec, "currency"))
            .Add(Format(Me.JobCollection1.overShort, "currency"))
            .Add(Format(Me.JobCollection1.Deposit, "currency"))
            .Add(Format(Me.JobCollection1.Invoiced, "currency"))
        End With
        Me.lvOrders.Items.Add(tempItem)
    End Sub

    Private Sub PopulateDepositList()
        Me.JobCollection1 = New JobCollection
        'Dim drJob As dsTKSI.tJobRow
        lvOrders.Items.Clear()

        Dim drDep As dsTKSI.tDepositsRow
        Dim lastDate As Date = New Date(1900, 1, 1)

        For Each drDep In Me.DsTKSI1.tDeposits

            oJob.SelectSOandLinesBySOID(Me.DsTKSI1, drDep.nSOID)

            If Me.DsTKSI1.tSOHeader.Count = 0 Then
                MessageBox.Show("One deposit is invalid, possibly due to a deleted invoice on this date: " & _
                                          drDep.dDateDeposit.ToShortDateString & " (no job number available) this deposit will be skipped ")
            Else
                Dim depLine As New JobCollection.JobDetail(drDep.ID)
                With depLine
                    If drDep.dDateDeposit = lastDate Then
                        .Day = ""
                    Else
                        .Day = drDep.dDateDeposit.ToShortDateString
                    End If

                    Dim invoiceTotal As Decimal = 0
                    Dim custID As Long = 0
                    Dim drSO As dsTKSI.tSOHeaderRow
                    Dim drSOLine As dsTKSI.tSOLineRow

                    'get all lines for this invoice
                    'find the line that corresponds to THIS deposit we are working with
                    'add total invoice
                    For Each drSO In Me.DsTKSI1.tSOHeader
                        For Each drSOLine In drSO.GettSOLineRows
                            If drSOLine.nLineNumber = drDep.nLineNumber Then
                                .CashReceived = -drSOLine.nAmount
                            End If
                            If drSOLine.sType = "Item" Then
                                invoiceTotal += drSOLine.nAmount
                            End If
                        Next
                    Next

                    'find all other lines that are payments from the customer for this invoice but 
                    'are not the line that is this one deposit we are working with
                    Dim restOfInvoiceLinesAFTER As Decimal = 0
                    Dim restOfInvoiceLinesBEFORE As Decimal = 0

                    For Each drSO In Me.DsTKSI1.tSOHeader
                        For Each drSOLine In drSO.GettSOLineRows
                            'For Each drsoline In Me.DsTKSI1.tSOHeader  'draLine
                            If drSOLine.nAccountID = 0 And drSOLine.nAmount < 0 And drSOLine.sType = "Comment" Then
                                If drSOLine.nLineNumber > drDep.nLineNumber Then
                                    restOfInvoiceLinesAFTER -= drSOLine.nAmount
                                ElseIf drSOLine.nLineNumber < drDep.nLineNumber Then
                                    'dont do = cause we dont want to include the deposit we are working with in these totals
                                    restOfInvoiceLinesBEFORE -= drSOLine.nAmount
                                End If
                            End If
                        Next
                    Next

                    'if this money received is smaller than 85% of the total bill and its the first money received for this job
                    'OR if there was other money received but the total receive as of this day is STILL less than 85% of the total due
                    'then put this one in deposits/cashreceived column, and not invoiced/cashreceived
                    If ((restOfInvoiceLinesBEFORE + .CashReceived) < (invoiceTotal * 0.9)) Then
                        'this amount and any previous amounts are still below 90% of total invoice
                        'so all monies are flagged as account code 'customer deposits'
                        .deposit = .CashReceived
                        invoiceTotal = 0
                        .Overshort = 0
                    Else
                        If restOfInvoiceLinesBEFORE > (invoiceTotal * 0.9) Then
                            'the previous deposits were already above 90% so they would have removed all funds from the 
                            'deposits account, so we dont have to remove them now
                            'just show the balance remaining 
                            invoiceTotal = invoiceTotal - restOfInvoiceLinesBEFORE
                            .deposit = 0
                            .Overshort = .CashReceived - invoiceTotal
                        Else
                            'previous payments werent above 90% so they were put into deposits
                            'but now, with this new payment, we are above 90% so we need to remove
                            'all funds from the customer deposits account code 
                            .deposit = -restOfInvoiceLinesBEFORE
                            'deposit line is shown as negetive but is previous cash received
                            .Overshort = (.CashReceived - .deposit) - (invoiceTotal)
                        End If
                    End If
                    .Invoiced = invoiceTotal
                    invoiceTotal = 0
                    'End If

                    Dim drSOHeader As dsTKSI.tSOHeaderRow
                    For Each drSOHeader In Me.DsTKSI1.tSOHeader
                        .Reference = drSOHeader.sSONum
                        custID = drSOHeader.nCustID
                    Next

                    If Not drSO.tJobRow.tCustomrRow Is Nothing Then
                        .Customer = drSO.tJobRow.tCustomrRow.sName ' drCust.sName
                    End If

                    Me.JobCollection1.AddJob(depLine)
                End With
            End If


            lastDate = drDep.dDateDeposit
        Next
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmBusy1 As New frmWorking
        frmBusy1.Text = frmBusy1.Text & " Printing..."
        frmBusy1.Show()
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Add
            oWord.Visible = False
            Try

                oDoc.Application.ActivePrinter = global_DefaultPrinter() '"\\TKSI1\SHARP AR-M237 PCL6"
                oDoc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperLedger
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(17)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)
            Catch ex As Exception
            End Try

            'Dim tempItem As ListViewItem
            With oWord.Selection
                '.PageSetup.TextColumns.SetCount(2)
                .PageSetup.TopMargin = 50
                .PageSetup.BottomMargin = 50
                .PageSetup.LeftMargin = 50
                .PageSetup.RightMargin = 50
                .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(17)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)

                'Try
                '    oWord.ActivePrinter = "\\TKSI1\SHARP AR-M237 PCL6"
                '    oWord.ActiveDocument.print()
                '    .PageSetup.PaperSize = Word.WdPaperSize.wdPaperLedger
                'Catch ex As Exception
                'End Try

                Dim tabLength As Double
                tabLength = 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1

                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 2
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                Try
                    Try
                        .TypeText(Me.lblDate.Text & " (printed on:" & Now.ToShortDateString & ")")
                    Catch ex As Exception
                    End Try
                Catch ex As Exception

                End Try
                .TypeParagraph()
                .TypeParagraph()
                .Font.Size = 9
                .TypeText("DAY" & vbTab & "Cash Received" & vbTab & "Over/Short" & vbTab & "Deposit" _
                    & vbTab & "Invoiced" & vbTab & "Reference" & vbTab & "Customer")

                .TypeParagraph()
                .TypeParagraph()

                Dim job1 As New JobCollection.JobDetail

                Dim lastDate As String = ""
                Dim miniTotal As Decimal = 0

                For Each job1 In JobCollection1.JobDetailList
                    'only work on records that are newer than date selected by user
                    If job1.Day.Length > 0 And miniTotal <> 0 Then
                        'day has changed, print sub total
                        .TypeText("TOT: " & Format(miniTotal, "currency"))
                        .TypeParagraph()
                        .TypeParagraph()
                        miniTotal = 0
                    End If
                    .Font.Size = 9
                    .TypeText(Mid(job1.Day.ToString, 1, 12) & vbTab)
                    .TypeText(Format((job1.CashReceived.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.Overshort.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.deposit.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.Invoiced.ToString), "currency") & vbTab)

                    .TypeText(Mid(job1.Reference.ToString, 1, 14) & vbTab)
                    .TypeText(Mid(job1.Customer.ToString, 1, 36) & vbTab)

                    .TypeParagraph()
                    miniTotal += job1.CashReceived
                    lastDate = job1.Day
                Next

                'day has changed, print sub total
                .TypeText("TOT: " & Format(miniTotal, "currency"))
                .TypeParagraph()
                .TypeParagraph()

                .TypeText(vbTab & Format(Me.JobCollection1.cashRec, "currency") & _
                vbTab & Format(Me.JobCollection1.overShort, "currency") & _
                vbTab & Format(Me.JobCollection1.Deposit, "currency") & vbTab & _
                    Format(Me.JobCollection1.Invoiced, "currency"))
            End With
            oWord.Visible = True
            Try
                oWord.Activate()
                oWord.Selection.HomeKey(Word.WdUnits.wdStory)
            Catch ex As Exception
            End Try
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmBusy1.Close()
        End Try
    End Sub

    'Private Sub lvOrders_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvOrders.ColumnClick
    '    If (Me.lvOrders.Columns(e.Column).Text = "Customer") Or (Me.lvOrders.Columns(e.Column).Text = "DAY") Then
    '        ' Create a new instance of our Sorter class. Pass the number
    '        ' of the column that was clicked.
    '        Dim Sorter As ListViewSorter = _
    '            New ListViewSorter(e.Column, ListViewSorter.EnumSortOrder.Ascending)
    '        ' Tell the ListView to use the Sort
    '        sender.ListViewItemSorter = Sorter
    '    End If

    'End Sub

    Private Sub btnRefeshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefeshList.Click
        LoadDataAndDisplay()
    End Sub

End Class
