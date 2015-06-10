Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
'Imports Microsoft.Office.Interop
Imports System.Linq
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmCashReceipts
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
    Friend WithEvents cashrec As System.Windows.Forms.ColumnHeader
    Friend WithEvents taxable As System.Windows.Forms.ColumnHeader
    Friend WithEvents Reference As System.Windows.Forms.ColumnHeader
    Friend WithEvents Customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents chargeAR As System.Windows.Forms.ColumnHeader
    Friend WithEvents c4010 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c4070 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c4020 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c4030 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c4040 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tax As System.Windows.Forms.ColumnHeader
    Friend WithEvents citytax As System.Windows.Forms.ColumnHeader
    Friend WithEvents Misc As System.Windows.Forms.ColumnHeader
    Friend WithEvents overshort As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLinesPerPageWord As System.Windows.Forms.TextBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvOrders = New System.Windows.Forms.ListView()
        Me.DAY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cashrec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.overshort = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.taxable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Reference = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chargeAR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4010 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4070 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4020 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4030 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4040 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.citytax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Misc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefeshList = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLinesPerPageWord = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvOrders
        '
        Me.lvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DAY, Me.cashrec, Me.overshort, Me.taxable, Me.Reference, Me.Customer, Me.chargeAR, Me.c4010, Me.c4070, Me.c4020, Me.c4030, Me.c4040, Me.tax, Me.citytax, Me.Misc})
        Me.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOrders.FullRowSelect = True
        Me.lvOrders.GridLines = True
        Me.lvOrders.HideSelection = False
        Me.lvOrders.Location = New System.Drawing.Point(0, 65)
        Me.lvOrders.MultiSelect = False
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.Size = New System.Drawing.Size(872, 397)
        Me.lvOrders.TabIndex = 0
        Me.lvOrders.UseCompatibleStateImageBehavior = False
        Me.lvOrders.View = System.Windows.Forms.View.Details
        '
        'DAY
        '
        Me.DAY.Text = "DAY"
        Me.DAY.Width = 50
        '
        'cashrec
        '
        Me.cashrec.Text = "Cash Rec."
        Me.cashrec.Width = 70
        '
        'overshort
        '
        Me.overshort.Text = "Over/Short"
        '
        'taxable
        '
        Me.taxable.Text = "Taxable Sale"
        Me.taxable.Width = 70
        '
        'Reference
        '
        Me.Reference.Text = "Reference No"
        Me.Reference.Width = 90
        '
        'Customer
        '
        Me.Customer.Text = "Customer Name"
        Me.Customer.Width = 180
        '
        'chargeAR
        '
        Me.chargeAR.Text = "Charge to A/R"
        Me.chargeAR.Width = 70
        '
        'c4010
        '
        Me.c4010.Text = "4010"
        Me.c4010.Width = 70
        '
        'c4070
        '
        Me.c4070.Text = "4070"
        Me.c4070.Width = 70
        '
        'c4020
        '
        Me.c4020.Text = "4020"
        Me.c4020.Width = 70
        '
        'c4030
        '
        Me.c4030.Text = "4030"
        Me.c4030.Width = 70
        '
        'c4040
        '
        Me.c4040.Text = "4040"
        Me.c4040.Width = 70
        '
        'tax
        '
        Me.tax.Text = "TAX"
        Me.tax.Width = 70
        '
        'citytax
        '
        Me.citytax.Text = "City Tax"
        Me.citytax.Width = 70
        '
        'Misc
        '
        Me.Misc.Text = "Misc"
        Me.Misc.Width = 70
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 65)
        Me.Panel1.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(547, 37)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(307, 18)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash Receipts and Sales Report"
        '
        'btnRefeshList
        '
        Me.btnRefeshList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefeshList.Location = New System.Drawing.Point(19, 9)
        Me.btnRefeshList.Name = "btnRefeshList"
        Me.btnRefeshList.Size = New System.Drawing.Size(125, 37)
        Me.btnRefeshList.TabIndex = 1
        Me.btnRefeshList.Text = "Refresh"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPDF)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtLinesPerPageWord)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnRefeshList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 462)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 56)
        Me.Panel2.TabIndex = 2
        '
        'btnPDF
        '
        Me.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPDF.Location = New System.Drawing.Point(458, 9)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(125, 37)
        Me.btnPDF.TabIndex = 5
        Me.btnPDF.Text = "To PDF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lines per page:"
        '
        'txtLinesPerPageWord
        '
        Me.txtLinesPerPageWord.Location = New System.Drawing.Point(317, 24)
        Me.txtLinesPerPageWord.Name = "txtLinesPerPageWord"
        Me.txtLinesPerPageWord.Size = New System.Drawing.Size(106, 22)
        Me.txtLinesPerPageWord.TabIndex = 3
        Me.txtLinesPerPageWord.Text = "50"
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Location = New System.Drawing.Point(173, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 37)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCashReceipts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(872, 518)
        Me.Controls.Add(Me.lvOrders)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmCashReceipts"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend dateStart As Date = Now.Date.AddMonths(-1).Date
    Friend dateEnd As Date = Today.Date
    Public ev As PdfPageEventHelper

    Private Structure JobCollection
        Friend JobDetailList As ArrayList

        Friend Sub AddJob(ByVal JobDetail1 As JobDetail)
            If Me.JobDetailList Is Nothing Then
                Me.JobDetailList = New ArrayList
            End If
            Me.JobDetailList.Add(JobDetail1)
            Me.Total4010 += JobDetail1.s4010
            Me.total4020 += JobDetail1.s4020
            Me.total4030 += JobDetail1.s4030
            Me.total4040 += JobDetail1.s4040
            Me.Total4070 += JobDetail1.s4070
            Me.TotalAR += JobDetail1.ChargeToAR
            Me.TotalSales += JobDetail1.TaxableSale
            Me.TotalTax += JobDetail1.TAX
            Me.TotalNonTaxable += JobDetail1.NonTaxable
        End Sub

        Friend Total4010 As Double
        Friend Total4070 As Double
        Friend total4020 As Double
        Friend total4030 As Double
        Friend total4040 As Double
        Friend TotalTax As Double
        Friend TotalSales As Double
        Friend TotalAR As Double
        Friend TotalNonTaxable As Double

        Structure JobDetail
            Public Sub New(ByVal JOBID As String)
                Me.JOBID = ""
                Me.Day = ""
                Me.CashReceived = 0
                Me.TaxableSale = 0
                Me.Reference = ""
                Me.Customer = ""
                Me.ChargeToAR = 0
                Me.s4010 = 0
                Me.s4070 = 0
                Me.s4030 = 0
                Me.s4040 = 0
                Me.TAX = 0
                Me.misc = 0
                Me.NonTaxable = 0
                Me.alTaxDistrict = New List(Of TaxDistrict)
                Me.JobTaxRate = 0
                Me.blnTAXID = False
            End Sub

            Dim JOBID As String
            Dim Day As String
            Dim CashReceived As Double
            Dim TaxableSale As Double
            Dim Reference As String
            Dim Customer As String
            Dim ChargeToAR As Double
            Dim s4010 As Double
            Dim s4070 As Double
            Dim s4030 As Double
            Dim s4020 As Double
            Dim s4040 As Double
            Dim TAX As Double
            Dim alTaxDistrict As List(Of TaxDistrict)
            Dim misc As Double
            Dim JobTaxRate As Single
            Dim RegionID As Long
            Dim blnTAXID As Boolean
            Dim NonTaxable As Double
        End Structure

    End Structure

    Private JobCollection1 As JobCollection

    Structure TaxDistrict
        Dim distID As Long
        Dim DistrictName As String
        Dim Amount As Double
        Dim reportSumAmount As Double
    End Structure

    Private alTaxDistrictColumns As List(Of TaxDistrict)

    Private Sub frmCashReceipts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            SaveSetting("TKSISchedule", "TKSI" & Me.Name.Trim, "cashreceipts", Me.txtLinesPerPageWord.Text.Trim)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmOrdersInWarehouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataAndDisplay()
        Try
            Dim sLinesPerPrint As String = GetSetting("TKSISchedule", "TKSI" & Me.Name.Trim, "cashreceipts")
            If sLinesPerPrint.Length > 0 Then
                Me.txtLinesPerPageWord.Text = sLinesPerPrint
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private oJob As New JobObj

    Private Sub LoadDataAndDisplay()

        If Not oJob.SelectDSIMPLYRangeALLData(Me.DsTKSI1, Me.dateStart, Me.dateEnd) Then
            Windows.Forms.MessageBox.Show("Error loading database info.")
            Exit Sub
        End If

        If Not oJob.SelectAllTaxInfo(Me.DsTKSI1) Then
            Windows.Forms.MessageBox.Show("Error loading database info.")
            Exit Sub
        End If

        PopulateJobList()
        DrawListViewFromJobList(Me.JobCollection1)
    End Sub

    Private Function listStateRTDColsOrdered() As List(Of String)
        Dim listReturn As New List(Of String)
        For Each r1 As TaxDistrict In getStateRTDColsOrdered()
            listReturn.Add(r1.DistrictName)
        Next
        Return listReturn
    End Function

    Private Function getStateRTDColsOrdered() As List(Of TaxDistrict)
        Dim listReturn As New List(Of TaxDistrict)
        Dim qryStateRTD As IOrderedEnumerable(Of TaxDistrict) = (From row In Me.alTaxDistrictColumns Where row.DistrictName.ToUpper = "STATE" Or row.DistrictName.Contains("RTD") Select row Order By row.DistrictName Descending)
        For Each r1 As TaxDistrict In qryStateRTD
            listReturn.Add(r1)
        Next

        Dim qryNotStateRTD As IOrderedEnumerable(Of TaxDistrict) = (From row In Me.alTaxDistrictColumns Where row.DistrictName.ToUpper <> "STATE" And (Not row.DistrictName.Contains("RTD")) Select row Order By row.DistrictName)
        For Each r1 As TaxDistrict In qryNotStateRTD
            listReturn.Add(r1)
        Next
        Return listReturn
    End Function

    Private Sub DrawListViewFromJobList(ByVal JobCollection1 As JobCollection)
        'drJob.IssJobDescNull
        Dim job1 As New JobCollection.JobDetail

        Me.lvOrders.Items.Clear()
        Me.lvOrders.Columns.Clear()
        With lvOrders.Columns
            .Add("jobKEY", 0, HorizontalAlignment.Left)
            .Add("DAY", 40, HorizontalAlignment.Left)
            '.Add("Cash Recvd", 70, HorizontalAlignment.Left)
            .Add("Taxable Sale", 90, HorizontalAlignment.Left)
            .Add("TAX ID Sale", 80, HorizontalAlignment.Left)
            .Add("Reference", 60, HorizontalAlignment.Left)
            .Add("Customer", 170, HorizontalAlignment.Left)
            .Add("Charge AR", 90, HorizontalAlignment.Left)
            .Add("4010", 70, HorizontalAlignment.Left)
            .Add("4070", 70, HorizontalAlignment.Left)
            .Add("4020", 70, HorizontalAlignment.Left)
            .Add("4030", 70, HorizontalAlignment.Left)
            .Add("4040", 70, HorizontalAlignment.Left)
            .Add("TAX", 70, HorizontalAlignment.Left)

            'For Each Str As String In StateRTDColsOrdered()
            '    .Add(Str, 90, HorizontalAlignment.Left)
            'Next
            Dim i As Long
            Dim oTaxDist As TaxDistrict
            For i = 0 To Me.alTaxDistrictColumns.Count - 1
                oTaxDist = Me.alTaxDistrictColumns(i)
                .Add(oTaxDist.DistrictName, 90, HorizontalAlignment.Left)
            Next
        End With

        Dim tempItem As New ListViewItem
        If JobCollection1.JobDetailList IsNot Nothing Then
            For Each job1 In JobCollection1.JobDetailList
                tempItem = New ListViewItem
                tempItem.Text = job1.JOBID
                With tempItem.SubItems
                    .Add(job1.Day)
                    '.Add(Format(job1.CashReceived, "currency"))
                    .Add(Format(job1.TaxableSale.ToString, "currency"))
                    .Add(Format(job1.NonTaxable.ToString, "currency"))
                    .Add(job1.Reference.ToString)
                    .Add(job1.Customer.ToString)
                    .Add(Format(job1.ChargeToAR.ToString, "currency"))
                    .Add(Format(job1.s4010.ToString, "currency"))
                    .Add(Format(job1.s4070.ToString, "currency"))
                    .Add(Format(job1.s4020.ToString, "currency"))
                    .Add(Format(job1.s4030, "currency"))
                    .Add(Format(job1.s4040, "currency"))
                    .Add(Format(job1.TAX, "currency"))

                    'loop through all column headers in module level arraylist 
                    'if this job has a tax rate that matches then post the data
                    Dim j As Long
                    Dim oTaxDist As TaxDistrict
                    For j = 0 To Me.alTaxDistrictColumns.Count - 1
                        oTaxDist = Me.alTaxDistrictColumns(j)
                        Dim i As Long
                        Dim oTaxDist1 As TaxDistrict
                        Dim blnFoundColumn As Boolean
                        For i = 0 To job1.alTaxDistrict.Count - 1
                            oTaxDist1 = job1.alTaxDistrict(i)
                            If oTaxDist.distID = oTaxDist1.distID Then
                                blnFoundColumn = True
                                If oTaxDist1.Amount = 0 Then
                                    .Add("")
                                Else
                                    .Add(Format(oTaxDist1.Amount, "currency"))
                                End If
                            End If
                        Next
                        If Not blnFoundColumn Then
                            .Add("")
                        End If
                    Next
                End With
                Me.lvOrders.Items.Add(tempItem)
                Me.lblDate.Text = Now
            Next
        Else
            MessageBox.Show("please select criteria first.")
        End If


        tempItem = New ListViewItem
        tempItem.BackColor = Color.SkyBlue
        With tempItem.SubItems
            .Add("")
            '.Add("")
            .Add(Format(Me.JobCollection1.TotalSales, "currency"))
            .Add(Format(Me.JobCollection1.TotalNonTaxable, "currency"))
            .Add("")
            .Add("_Totals")
            .Add(Format(Me.JobCollection1.TotalAR, "currency"))
            .Add(Format(Me.JobCollection1.Total4010, "currency"))
            .Add(Format(Me.JobCollection1.Total4070, "currency"))
            .Add(Format(Me.JobCollection1.total4020, "currency"))
            .Add(Format(Me.JobCollection1.total4030, "currency"))
            .Add(Format(Me.JobCollection1.total4040, "currency"))
            .Add(Format(Me.JobCollection1.TotalTax, "currency"))

            'loop through all column headers in module level arraylist 
            'if this job has a tax rate that matches then post the data
            Dim j As Long
            Dim oTaxDist As TaxDistrict
            For j = 0 To Me.alTaxDistrictColumns.Count - 1
                oTaxDist = Me.alTaxDistrictColumns(j)

                .Add(Format(oTaxDist.reportSumAmount, "currency"))


            Next
        End With
        Me.lvOrders.Items.Add(tempItem)
    End Sub

    Private Sub PopulateJobList()
        Me.JobCollection1 = New JobCollection
        Me.alTaxDistrictColumns = New List(Of TaxDistrict)

        Dim drJob As dsTKSI.tJobRow
        lvOrders.Items.Clear()

        For Each drJob In Me.DsTKSI1.tJob
            Dim job2 As New JobCollection.JobDetail(drJob.nID)
            CalculateJobData(drJob, job2)
            CalculatePOCostData(drJob, job2)
            calculateTaxDistrictData(job2)
            Me.JobCollection1.AddJob(job2)
        Next
    End Sub

    Private Sub calculateTaxDistrictData(ByRef job2 As JobCollection.JobDetail)
        job2.alTaxDistrict = New List(Of TaxDistrict)
        job2.alTaxDistrict = Me.alTaxDistrictColumns.ToArray.ToList

        Dim drJobTax As dsTKSI.tblJobTaxRow
        Dim sumTaxes As Single
        For Each drJobTax In Me.DsTKSI1.tblJobTax
            If drJobTax.nJobID = job2.JOBID Then
                sumTaxes += drJobTax.TaxPercent
                AddDistrictTaxToArraylist(drJobTax, job2)
            End If
        Next
        sumTaxes = Decimal.Round(CDec(sumTaxes), 2)
        If Not (sumTaxes = Decimal.Round(CDec(job2.JobTaxRate), 2)) Then
            Windows.Forms.MessageBox.Show("Tax Rate does not equal districts chosen, please edit job taxes. JOB: " & job2.Customer)
        End If
    End Sub

    Private Sub AddDistrictTaxToArraylist(ByVal drJobTax As dsTKSI.tblJobTaxRow, ByRef job2 As JobCollection.JobDetail)
        Dim i As Long
        Dim oTaxDist As TaxDistrict
        Dim blnFoundDistrict As Boolean
        For i = 0 To job2.alTaxDistrict.Count - 1
            oTaxDist = job2.alTaxDistrict(i)
            If oTaxDist.DistrictName = drJobTax.TaxName Then
                blnFoundDistrict = True
                'Dim totalsale As Double
                'totalsale = job2.TAX / (regionRate / 100)
                oTaxDist.Amount = Decimal.Round((CDec(job2.TaxableSale * (drJobTax.TaxPercent / 100))), 2)
                oTaxDist.reportSumAmount += oTaxDist.Amount
                job2.alTaxDistrict(i) = oTaxDist
                oTaxDist.Amount = 0
                Me.alTaxDistrictColumns(i) = oTaxDist
                Exit For
            End If
        Next
        If Not blnFoundDistrict Then
            oTaxDist = New TaxDistrict
            With oTaxDist
                .distID = drJobTax.ID
                'Dim totalsale As Double
                'totalsale = job2.TAX / (regionRate / 100)
                .Amount = Decimal.Round(CDec((job2.TaxableSale * (drJobTax.TaxPercent / 100))), 2)
                .reportSumAmount += .Amount
                .DistrictName = drJobTax.TaxName
            End With
            job2.alTaxDistrict.Add(oTaxDist)
            oTaxDist.Amount = 0
            'new tax district column so update the global header file so report will show this new column
            Me.alTaxDistrictColumns.Add(oTaxDist)
        End If
    End Sub

    Private Sub CalculateJobData(ByVal drJob As dsTKSI.tJobRow, ByRef job1 As JobCollection.JobDetail)
        With drJob
            job1.JOBID = .nID
            job1.Customer = .tCustomrRow.sName

            If Len(drJob.sInvNotes) > 0 Then
                job1.blnTAXID = True
                job1.Customer = Mid(job1.Customer, 1, 12) & "-" & drJob.sInvNotes
            Else
                job1.blnTAXID = False
            End If

            job1.Reference = .sJobNo
            job1.JobTaxRate = .nTaxRate

            If Not .GettSOHeaderRows Is Nothing Then
                If .GettSOHeaderRows.Length > 0 Then
                    If Not .GettSOHeaderRows(0).IsdsimplyNull Then
                        'job1.PaidStatus = "Y"
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub CalculatePOCostData(ByVal drJob As dsTKSI.tJobRow, ByRef job1 As JobCollection.JobDetail)
        If Not drJob.GettSOHeaderRows Is Nothing Then
            Dim drPO As dsTKSI.tSOHeaderRow

            For Each drPO In drJob.GettSOHeaderRows
                Dim dra As dsTKSI.tSOLineRow()
                Dim dr As dsTKSI.tSOLineRow
                dra = drPO.GettSOLineRows

                If Not drPO.IsdsimplyNull Then
                    job1.Day = drPO.dsimply.Date.Month.ToString & "/" & drPO.dsimply.Day.ToString
                    If dra.Length > 0 Then
                        For Each dr In dra

                            'customer deposits and payments are negetive amount on invoice SO line
                            If dr.sType = "Comment" And dr.nAmount < 0 Then
                                job1.CashReceived = job1.CashReceived - dr.nAmount
                            End If

                            If dr.sType = "Item" Then
                                job1.ChargeToAR = job1.ChargeToAR + dr.nAmount
                            End If

                            Select Case dr.nAccountID
                                Case 4010, 4210
                                    job1.s4010 = job1.s4010 + dr.nAmount
                                    If Not job1.blnTAXID Then
                                        job1.TaxableSale = job1.TaxableSale + dr.nAmount
                                    Else
                                        job1.NonTaxable += dr.nAmount
                                    End If

                                Case 4070, 4270
                                    job1.s4070 = job1.s4070 + dr.nAmount
                                    If Not job1.blnTAXID Then
                                        job1.TaxableSale = job1.TaxableSale + dr.nAmount
                                    Else
                                        job1.NonTaxable += dr.nAmount
                                    End If
                                Case 4040, 4240
                                    job1.s4040 = job1.s4040 + dr.nAmount
                                Case 4020, 4220
                                    job1.s4020 = job1.s4020 + dr.nAmount
                                    If Not job1.blnTAXID Then
                                        job1.TaxableSale = job1.TaxableSale + dr.nAmount
                                    Else
                                        job1.NonTaxable += dr.nAmount
                                    End If
                                Case 4030, 4230
                                    job1.s4030 = job1.s4030 + dr.nAmount
                                    If Not job1.blnTAXID Then
                                        job1.TaxableSale = job1.TaxableSale + dr.nAmount
                                    Else
                                        job1.NonTaxable += dr.nAmount
                                    End If
                                Case 2600, 2610, 2620, 2630, 2640, 2650, 2660, 2670, 268, 2690
                                    job1.TAX = job1.TAX + dr.nAmount
                            End Select
                        Next
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub btnRefeshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefeshList.Click
        LoadDataAndDisplay()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If ISDebugMachine Then
            DisplayInWordPAD()
        Else
            If HasWordInstalled() Then
                DisplayInWord()
            Else
                DisplayInWordPAD()
            End If
        End If
    End Sub

    Private Sub DisplayInWord()
        Dim frmBusy1 As New frmWorking
        frmBusy1.Text = frmBusy1.Text & " Printing..."
        frmBusy1.Show()
        Try
            Dim StateRTDColsOrdered As List(Of TaxDistrict) = getStateRTDColsOrdered()

            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Add
            oWord.Visible = False
            Try
                oDoc.Application.ActivePrinter = "\\TKSI1\SHARP AR-M237 PCL6"
                oDoc.PageSetup.PaperSize = Word.WdPaperSize.wdPaper11x17
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(17)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)
            Catch ex As Exception

            End Try

            With oWord.Selection
                '.PageSetup.TextColumns.SetCount(2)
                .PageSetup.TopMargin = 50
                .PageSetup.BottomMargin = 50
                .PageSetup.LeftMargin = 50
                .PageSetup.RightMargin = 50
                .PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape
                oDoc.PageSetup.PageWidth = oWord.Application.InchesToPoints(17)
                oDoc.PageSetup.PageHeight = oWord.Application.InchesToPoints(11)

                Dim tabLength As Double
                tabLength = 0.5
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.2
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8

                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 1.9
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.8
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                tabLength = tabLength + 0.7
                .ParagraphFormat.TabStops.Add(Position:=oWord.Application.InchesToPoints(tabLength), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                .TypeText("CASH RECEIPTS AND SALES JOURNAL " & vbTab & Now.ToLongDateString & " " & Now.ToLongTimeString)
                .TypeParagraph()
                .TypeParagraph()
                .Font.Size = 8

                Dim strHeader As String = "DAY" & vbTab & "" & vbTab & "Taxable Sale" & vbTab & "TAXID$" & vbTab & "Reference" _
                    & vbTab & "Customer Name" & vbTab & "Charge A/R" & vbTab & "4010" & vbTab _
                    & "4070" & vbTab & "4020" & vbTab & "4030" & vbTab & "4040" & vbTab _
                    & "TAX"

                Dim i As Long
                Dim oTaxDist As TaxDistrict

                For Each tax1 As TaxDistrict In StateRTDColsOrdered
                    strHeader = String.Concat(strHeader, vbTab, Mid(tax1.DistrictName, 1, 7))
                Next

                .TypeText(strHeader)
                .TypeParagraph()
                .TypeParagraph()

                Dim job1 As New JobCollection.JobDetail

                Dim iLinesPerPage As Integer = 50
                Integer.TryParse(Me.txtLinesPerPageWord.Text.Trim, iLinesPerPage)
                Dim iJobCount As Integer = 0
                For Each job1 In JobCollection1.JobDetailList
                    iJobCount += 1
                    If iJobCount > iLinesPerPage Then
                        .InsertBreak(Word.WdBreakType.wdPageBreak)

                        .TypeText(strHeader)
                        .TypeParagraph()
                        .TypeParagraph()
                        iJobCount = 0
                    End If
                    'only work on records that are newer than date selected by user

                    .Font.Size = 9
                    .TypeText(Mid(job1.Day.ToString, 1, 7) & vbTab)
                    .TypeText(vbTab)
                    .TypeText(Format((job1.TaxableSale.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.NonTaxable.ToString), "currency") & vbTab)

                    .TypeText(Mid(job1.Reference.ToString, 1, 12) & vbTab)
                    .TypeText(Mid(job1.Customer.ToString, 1, 30) & vbTab)
                    .TypeText(Format((job1.ChargeToAR.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.s4010.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.s4070.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.s4020.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.s4030.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.s4040.ToString), "currency") & vbTab)
                    .TypeText(Format((job1.TAX.ToString), "currency") & vbTab)

                    'loop through all column headers in module level arraylist 
                    'if this job has a tax rate that matches then post the data
                    Dim k As Long
                    Dim oTaxDistA As TaxDistrict

                    For k = 0 To StateRTDColsOrdered.Count - 1
                        oTaxDistA = StateRTDColsOrdered(k)
                        Dim oTaxDist1 As TaxDistrict
                        Dim blnFoundColumn As Boolean
                        For i = 0 To job1.alTaxDistrict.Count - 1
                            oTaxDist1 = job1.alTaxDistrict(i)
                            If oTaxDistA.distID = oTaxDist1.distID Then
                                blnFoundColumn = True
                                If oTaxDist1.Amount = 0 Then
                                    .TypeText("" & vbTab)
                                Else
                                    .TypeText(Format(oTaxDist1.Amount, "currency") & vbTab)
                                End If
                            End If
                        Next
                        If Not blnFoundColumn Then
                            .TypeText(vbTab)
                        End If
                    Next
                    .TypeParagraph()

                Next
                .TypeParagraph()

                .TypeText(vbTab & vbTab & Format(Me.JobCollection1.TotalSales, "currency") & _
                vbTab & Format(Me.JobCollection1.TotalNonTaxable, "currency") & vbTab & vbTab & _
                vbTab & Format(Me.JobCollection1.TotalAR, "currency") & vbTab & _
                    Format(Me.JobCollection1.Total4010, "currency") & vbTab & _
                    Format(Me.JobCollection1.Total4070, "currency") & vbTab & _
                    Format(Me.JobCollection1.total4020, "currency") & vbTab & _
                    Format(Me.JobCollection1.total4030, "currency") & vbTab & _
                    Format(Me.JobCollection1.total4040, "currency") & vbTab & _
                    Format(Me.JobCollection1.TotalTax, "currency"))
                Dim j As Long
                For j = 0 To StateRTDColsOrdered.Count - 1
                    oTaxDist = StateRTDColsOrdered(j)
                    .TypeText(vbTab & Format(oTaxDist.reportSumAmount, "currency"))
                Next
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

    Public Shared intTblWidth() As Single = {25, 35, 35, 45, 80, 45, 25, 25, 25, 25, 25, 40, 40, 30, 30, 30, 35, 35}

    Private Sub DisplayInPDF()
        Dim frmBusy1 As New frmWorking
        frmBusy1.Text = frmBusy1.Text & " Printing to PDF..."
        frmBusy1.Show()
        Try
            intTblWidth = {25, 35, 35, 45, 80, 45, 25, 25, 25, 25, 25, 40, 40, 30, 30, 30, 35, 35}
            Dim StateRTDColsOrdered As List(Of TaxDistrict) = getStateRTDColsOrdered()

            Dim tempPDF As String = Path.GetTempFileName & ".PDF"
            Dim doc As iTextSharp.text.Document
            doc = New iTextSharp.text.Document(iTextSharp.text.PageSize._11X17.Rotate, 30, 30, 30, 30)

            Dim msDoc As New FileStream(tempPDF, FileMode.Create)
            Dim w As PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, msDoc)
            Dim events1 As New _events
            events1.listDistrict = listStateRTDColsOrdered()
            ' events1.doc = doc
            w.PageEvent = events1

            w.CloseStream = False
            doc.Open()
            Dim iFontSize As Integer = 9
            Dim font1 As iTextSharp.text.Font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, iFontSize)

            Dim createCell As Func(Of String, Integer, PdfPCell) = Function(_sText As String, _colspan As Integer)
                                                                       Dim celltemp As New PdfPCell(New Phrase(_sText, font1))
                                                                       celltemp.Colspan = _colspan
                                                                       celltemp.Border = 0
                                                                       Return celltemp
                                                                   End Function


            Dim iPageWidth As Integer = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin


       


            'Dim table As New PdfPTable(17)
            'With table
            '    .SetWidths(intTblWidth)
            '    .TotalWidth = iPageWidth
            '    .WidthPercentage = 100
            '    .LockedWidth = False
            '    .AddCell(createCell("DAY", 1))
            '    .AddCell(createCell("Taxable Sale", 1))
            '    .AddCell(createCell("TAXID$", 1))
            '    .AddCell(createCell("Reference", 1))
            '    .AddCell(createCell("Customer Name", 1))
            '    .AddCell(createCell("Charge A/R", 1))
            '    .AddCell(createCell("4010", 1))
            '    .AddCell(createCell("4070", 1))
            '    .AddCell(createCell("4020", 1))
            '    .AddCell(createCell("4030", 1))
            '    .AddCell(createCell("4040", 1))
            '    .AddCell(createCell("TAX", 1))
            '    Dim i As Long
            '    Dim oTaxDist As TaxDistrict
            '    For Each tax1 As TaxDistrict In StateRTDColsOrdered
            '        .AddCell(createCell(Mid(tax1.DistrictName, 1, 7), 1))
            '    Next
            '    .SpacingAfter = 5
            '    '  .SpacingBefore = 20
            'End With
            'doc.Add(table)

            'Dim line1 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
            'doc.Add(New Chunk(line1))

            Dim job1 As New JobCollection.JobDetail
            Dim iLinesPerPage As Integer = 50
            Integer.TryParse(Me.txtLinesPerPageWord.Text.Trim, iLinesPerPage)
            Dim iJobCount As Integer = 0

            For Each job1 In JobCollection1.JobDetailList

                Dim tabledata As New PdfPTable(18)
                With tabledata
                    .SetWidths(intTblWidth)
                    .TotalWidth = iPageWidth
                    .WidthPercentage = 100
                    .LockedWidth = True
                    .AddCell(createCell(job1.Day.ToString, 1))
                    .AddCell(createCell(Format((job1.TaxableSale.ToString), "currency"), 1))
                    .AddCell(createCell(Format((job1.NonTaxable.ToString), "currency"), 1))
                    .AddCell(createCell(job1.Reference, 1))
                    .AddCell(createCell(Mid(job1.Customer, 1, 22), 1))
                    .AddCell(createCell(job1.ChargeToAR, 1))
                    .AddCell(createCell(job1.s4010, 1))
                    .AddCell(createCell(job1.s4070, 1))
                    .AddCell(createCell(job1.s4020, 1))
                    .AddCell(createCell(job1.s4030, 1))
                    .AddCell(createCell(job1.TAX, 1))

                    'loop through all column headers in module level arraylist 
                    'if this job has a tax rate that matches then post the data
                    Dim k As Integer
                    Dim oTaxDistA As TaxDistrict

                    For k = 0 To StateRTDColsOrdered.Count - 1
                        oTaxDistA = StateRTDColsOrdered(k)
                        Dim oTaxDist1 As TaxDistrict
                        Dim blnFoundColumn As Boolean
                        Dim i As Integer = 0
                        For i = 0 To job1.alTaxDistrict.Count - 1
                            oTaxDist1 = job1.alTaxDistrict(i)
                            If oTaxDistA.distID = oTaxDist1.distID Then
                                blnFoundColumn = True
                                If oTaxDist1.Amount = 0 Then
                                    .AddCell(createCell("", 1))
                                Else
                                    .AddCell(createCell(Format(oTaxDist1.Amount, "currency"), 1))
                                End If
                            End If
                        Next
                        If Not blnFoundColumn Then
                            .AddCell(createCell("", 1))
                        End If
                    Next
                    .SpacingAfter = 2
                    .SpacingBefore = 2
                    .TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin
                End With
                doc.Add(tabledata)
            Next
            Dim line2 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
            doc.Add(New Chunk(line2))

            Dim tableSummary As New PdfPTable(18)
            With tableSummary
                .SetWidths(intTblWidth)
                .TotalWidth = iPageWidth
                .WidthPercentage = 100
                .LockedWidth = True
                .AddCell(createCell("", 1))

                .AddCell(createCell(Format(Me.JobCollection1.TotalSales, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.TotalNonTaxable, "currency"), 1))
                .AddCell(createCell("", 1))
                .AddCell(createCell("", 1))
                .AddCell(createCell(Format(Me.JobCollection1.TotalAR, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.Total4010, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.Total4070, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.total4020, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.total4030, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.total4040, "currency"), 1))
                .AddCell(createCell(Format(Me.JobCollection1.TotalTax, "currency"), 1))

                Dim j As Integer

                For j = 0 To StateRTDColsOrdered.Count - 1
                    Dim oTaxDist As TaxDistrict
                    oTaxDist = StateRTDColsOrdered(j)
                    .AddCell(createCell(Format(oTaxDist.reportSumAmount, "currency"), 1))
                Next
            End With
            doc.Add(tableSummary)

            doc.Close()
            w.Flush()
            msDoc.Flush()
            w.Close()
            msDoc.Close()

            '-----------show PDF to user in default application for viewing (usually Acrobat)
            Process.Start(tempPDF)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmBusy1.Close()
        End Try
    End Sub

    Private Sub DisplayInWordPAD()
        Dim frmBusy1 As New frmWorking
        frmBusy1.Text = frmBusy1.Text & " Printing..."
        frmBusy1.Show()
        Try

            Dim StateRTDColsOrdered As List(Of TaxDistrict) = getStateRTDColsOrdered()

            Dim strFileNameTemp As String = global_TempReportFolder & "\CashReceiptsWordpad.txt"
            Dim sw As New StreamWriter(strFileNameTemp)

            sw.WriteLine("CASH RECEIPTS AND SALES JOURNAL " & vbTab & Now.ToLongDateString & " " & Now.ToLongTimeString)
            sw.WriteLine("")
            sw.WriteLine("")

            Dim strHeader As String = "DAY" & vbTab & "" & vbTab & "Taxable Sale" & vbTab & "TAXID$" & vbTab & "Reference" _
                    & vbTab & "Customer Name" & vbTab & "Charge A/R" & vbTab & "4010" & vbTab _
                    & "4070" & vbTab & "4020" & vbTab & "4030" & vbTab & "4040" & vbTab _
                    & "TAX"

            Dim i As Long
            Dim oTaxDist As TaxDistrict

            For Each Str As TaxDistrict In StateRTDColsOrdered
                strHeader = String.Concat(strHeader, vbTab, Mid(Str.DistrictName, 1, 8))
            Next

            sw.WriteLine(strHeader)
            sw.WriteLine("")
            sw.WriteLine("")

            Dim job1 As New JobCollection.JobDetail

            Dim iLinesPerPage As Integer = 50
            Integer.TryParse(Me.txtLinesPerPageWord.Text.Trim, iLinesPerPage)
            Dim iJobCount As Integer = 0
            Dim strLine As String = ""
            For Each job1 In JobCollection1.JobDetailList
                iJobCount += 1
                If iJobCount > iLinesPerPage Then
                    sw.WriteLine(strHeader)
                    sw.WriteLine("")
                    sw.WriteLine("")
                    iJobCount = 0
                End If

                strLine = (Mid(job1.Day.ToString, 1, 7) & vbTab)
                strLine = strLine & (vbTab)
                strLine = strLine & (Format((job1.TaxableSale.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.NonTaxable.ToString), "currency") & vbTab)

                strLine = strLine & (Mid(job1.Reference.ToString, 1, 12) & vbTab)
                strLine = strLine & (Mid(job1.Customer.ToString, 1, 30) & vbTab)
                strLine = strLine & (Format((job1.ChargeToAR.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.s4010.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.s4070.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.s4020.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.s4030.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.s4040.ToString), "currency") & vbTab)
                strLine = strLine & (Format((job1.TAX.ToString), "currency") & vbTab)

                'loop through all column headers in module level arraylist 
                'if this job has a tax rate that matches then post the data
                Dim k As Long
                Dim oTaxDistA As TaxDistrict

                For k = 0 To StateRTDColsOrdered.Count - 1
                    oTaxDistA = StateRTDColsOrdered(k)
                    Dim oTaxDist1 As TaxDistrict
                    Dim blnFoundColumn As Boolean
                    For i = 0 To job1.alTaxDistrict.Count - 1
                        oTaxDist1 = job1.alTaxDistrict(i)
                        If oTaxDistA.distID = oTaxDist1.distID Then
                            blnFoundColumn = True
                            If oTaxDist1.Amount = 0 Then
                                strLine = strLine & ("" & vbTab)
                            Else
                                strLine = strLine & (Format(oTaxDist1.Amount, "currency") & vbTab)
                            End If
                        End If
                    Next
                    If Not blnFoundColumn Then
                        strLine = strLine & (vbTab)
                    End If
                Next
                sw.WriteLine(strLine)
                strLine = ""
                sw.WriteLine("")

            Next
            sw.WriteLine("")

            strLine = (vbTab & vbTab & Format(Me.JobCollection1.TotalSales, "currency") & _
            vbTab & Format(Me.JobCollection1.TotalNonTaxable, "currency") & vbTab & vbTab & _
            vbTab & Format(Me.JobCollection1.TotalAR, "currency") & vbTab & _
                Format(Me.JobCollection1.Total4010, "currency") & vbTab & _
                Format(Me.JobCollection1.Total4070, "currency") & vbTab & _
                Format(Me.JobCollection1.total4020, "currency") & vbTab & _
                Format(Me.JobCollection1.total4030, "currency") & vbTab & _
                Format(Me.JobCollection1.total4040, "currency") & vbTab & _
                Format(Me.JobCollection1.TotalTax, "currency"))
            Dim j As Long
            For j = 0 To StateRTDColsOrdered.Count - 1
                oTaxDist = StateRTDColsOrdered(j)
                strLine = strLine & (vbTab & Format(oTaxDist.reportSumAmount, "currency"))
            Next

            sw.WriteLine(strLine)
            strLine = ""
            sw.Flush()
            sw.Close()

            Process.Start(strFileNameTemp)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmBusy1.Close()
        End Try
    End Sub

    Private Sub lvOrders_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvOrders.ColumnClick
        If (Me.lvOrders.Columns(e.Column).Text = "Customer") Or (Me.lvOrders.Columns(e.Column).Text = "DAY") Then
            ' Create a new instance of our Sorter class. Pass the number
            ' of the column that was clicked.
            Dim Sorter As ListViewSorter = _
                New ListViewSorter(e.Column, ListViewSorter.EnumSortOrder.Ascending)
            ' Tell the ListView to use the Sort
            sender.ListViewItemSorter = Sorter
        End If

    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        DisplayInPDF()
    End Sub

End Class

Class _events
    Inherits PdfPageEventHelper

    Public listDistrict As List(Of String)
    Protected total As PdfTemplate
    Protected helv As BaseFont
    Private settingFont As Boolean = False

    Public Overrides Sub OnOpenDocument(writer As PdfWriter, document As Document)
        total = writer.DirectContent.CreateTemplate(100, 100)
        total.BoundingBox = New iTextSharp.text.Rectangle(-20, -20, 100, 100)
        helv = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED)
    End Sub


    Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)

        Try
            Dim createCell As Func(Of String, Integer, PdfPCell) = Function(_sText As String, _colspan As Integer)
                                                                       Dim f1 As iTextSharp.text.Font = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.NORMAL)
                                                                       Dim celltemp As New PdfPCell(New Phrase(_sText, f1))
                                                                       celltemp.Colspan = _colspan
                                                                       celltemp.Border = 0
                                                                       Return celltemp
                                                                   End Function

            If document.IsOpen Then
                Dim helv As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED)

            End If
            Dim cb As PdfContentByte = writer.DirectContent
            cb.SaveState()
            Dim text As String = "Page " & writer.PageNumber.ToString & " of "
            Dim textBase As Decimal = document.Bottom - 20
            Dim textSize As Decimal = 12

            cb.BeginText()
            cb.SetFontAndSize(helv, 12)

            If writer.PageNumber = 1 Then

                cb.SetTextMatrix(document.Left, textBase)
                cb.ShowText(text)
                cb.EndText()
                cb.AddTemplate(total, document.Left + textSize, textBase)

            Else

                Dim adjust As Decimal = helv.GetWidthPoint("0", 12)
                cb.SetTextMatrix(document.Right - textSize - adjust, textBase)
                cb.ShowText(text)
                cb.EndText()
                cb.AddTemplate(total, document.Right - adjust, textBase)



                'Dim tableTitle As New PdfPTable(1)
                'With tableTitle
                '    Dim str As String = "CASH RECEIPTS AND SALES JOURNAL " & Now.ToLongDateString & " " & Now.ToLongTimeString
                '    .WidthPercentage = 100
                '    .LockedWidth = False
                '    Dim f1 As Font = New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.NORMAL)

                '    Dim celltemp As New PdfPCell(New Phrase(str, f1))
                '    celltemp.Colspan = 1
                '    celltemp.Border = 0
                '    .AddCell(celltemp)
                '    .SpacingAfter = 5
                '    .SpacingBefore = 5
                'End With

                'document.Add(tableTitle)

                'Dim iPageWidth As Integer = document.PageSize.Width - document.LeftMargin - document.RightMargin
                'Dim table As New PdfPTable(18)
                'With table
                '    .SetWidths(frmCashReceipts.intTblWidth)
                '    .TotalWidth = iPageWidth
                '    .WidthPercentage = 100
                '    .LockedWidth = False ' True
                '    .AddCell(createCell("DAY", 1))
                '    .AddCell(createCell("Taxable Sale", 1))
                '    .AddCell(createCell("TAXID$", 1))
                '    .AddCell(createCell("Reference", 1))
                '    .AddCell(createCell("Customer Name", 1))
                '    .AddCell(createCell("Charge A/R", 1))
                '    .AddCell(createCell("4010", 1))
                '    .AddCell(createCell("4070", 1))
                '    .AddCell(createCell("4020", 1))
                '    .AddCell(createCell("4030", 1))
                '    .AddCell(createCell("4040", 1))
                '    .AddCell(createCell("TAX", 1))
                '    For Each tax1 As String In listDistrict
                '        .AddCell(createCell(Mid(tax1, 1, 7), 1))
                '    Next
                '    .SpacingAfter = 5
                '    .SpacingBefore = 5
                'End With

                'document.Add(table)

                'Dim line2 As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
                'document.Add(New Chunk(line2))

            End If
            cb.RestoreState()
        Catch ex As Exception
            MessageBox.Show(" cash headers error " & ex.Message)
        End Try

    End Sub





    'Dim table As New PdfPTable(1)
    ''table.WidthPercentage = 100; //PdfPTable.writeselectedrows below didn't like this
    'table.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin
    ''this centers [table]
    'Dim table2 As New PdfPTable(1)

    ''logo
    'Dim cell2 As New PdfPCell(
    'cell2.Colspan = 1
    'table2.AddCell(cell2)

    ''title
    'cell2 = New PdfPCell(New Phrase(vbLf & "TITLE", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, Font.BOLD Or Font.UNDERLINE)))
    'cell2.HorizontalAlignment = Element.ALIGN_CENTER
    'cell2.Colspan = 2
    'table2.AddCell(cell2)

    'Dim cell As New PdfPCell(table2)
    'table.AddCell(cell)

    'table.WriteSelectedRows(0, -1, document.LeftMargin, document.PageSize.Height - 36, writer.DirectContent)

End Class

