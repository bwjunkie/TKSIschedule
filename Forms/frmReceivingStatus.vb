Imports System.Linq
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data

Public Class frmReceivingStatus
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
    Friend WithEvents lvReceiving As System.Windows.Forms.ListView
    Friend WithEvents lvTruckList As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTrucks As System.Windows.Forms.Panel
    Friend WithEvents timerRefreshScreen As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnMarkReceived As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents chkHideScanned As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSaveDamage As System.Windows.Forms.Button
    Friend WithEvents btnPrintReport As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentBarCodeLabel As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmbDamage3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDamageDetail As System.Windows.Forms.TextBox
    Friend WithEvents cmbDamage2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbDamage As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUnmarkItem As System.Windows.Forms.Button
    Friend WithEvents btnJobTags As System.Windows.Forms.Button
    Friend WithEvents PrintDocJobTags As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBinAssign As System.Windows.Forms.ComboBox
    Friend WithEvents TblJobActivityTableAdapter1 As TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents TksijobsDataSet1 As TKSIJOBSDataSet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lvReceiving = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvTruckList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTrucks = New System.Windows.Forms.Panel()
        Me.cmbBinAssign = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnJobTags = New System.Windows.Forms.Button()
        Me.btnUnmarkItem = New System.Windows.Forms.Button()
        Me.cmbDamage3 = New System.Windows.Forms.ComboBox()
        Me.txtDamageDetail = New System.Windows.Forms.TextBox()
        Me.cmbDamage2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDamage = New System.Windows.Forms.ComboBox()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.btnSaveDamage = New System.Windows.Forms.Button()
        Me.chkHideScanned = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnMarkReceived = New System.Windows.Forms.Button()
        Me.timerRefreshScreen = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentBarCodeLabel = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocJobTags = New System.Drawing.Printing.PrintDocument()
        Me.TblJobActivityTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.TksijobsDataSet1 = New TKSISchedule.TKSIJOBSDataSet()
        Me.pnlTrucks.SuspendLayout()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvReceiving
        '
        Me.lvReceiving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReceiving.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvReceiving.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvReceiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiving.FullRowSelect = True
        Me.lvReceiving.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvReceiving.HideSelection = False
        Me.lvReceiving.Location = New System.Drawing.Point(0, 28)
        Me.lvReceiving.MultiSelect = False
        Me.lvReceiving.Name = "lvReceiving"
        Me.lvReceiving.Size = New System.Drawing.Size(664, 692)
        Me.lvReceiving.TabIndex = 0
        Me.lvReceiving.UseCompatibleStateImageBehavior = False
        Me.lvReceiving.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Line"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 370
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Width = 190
        '
        'lvTruckList
        '
        Me.lvTruckList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvTruckList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvTruckList.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvTruckList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lvTruckList.FullRowSelect = True
        Me.lvTruckList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvTruckList.HideSelection = False
        Me.lvTruckList.Location = New System.Drawing.Point(0, 28)
        Me.lvTruckList.MultiSelect = False
        Me.lvTruckList.Name = "lvTruckList"
        Me.lvTruckList.Size = New System.Drawing.Size(288, 175)
        Me.lvTruckList.TabIndex = 1
        Me.lvTruckList.UseCompatibleStateImageBehavior = False
        Me.lvTruckList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        Me.ColumnHeader2.Width = 220
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TRUCKS:"
        '
        'pnlTrucks
        '
        Me.pnlTrucks.Controls.Add(Me.cmbBinAssign)
        Me.pnlTrucks.Controls.Add(Me.Label3)
        Me.pnlTrucks.Controls.Add(Me.btnJobTags)
        Me.pnlTrucks.Controls.Add(Me.btnUnmarkItem)
        Me.pnlTrucks.Controls.Add(Me.cmbDamage3)
        Me.pnlTrucks.Controls.Add(Me.txtDamageDetail)
        Me.pnlTrucks.Controls.Add(Me.cmbDamage2)
        Me.pnlTrucks.Controls.Add(Me.Label7)
        Me.pnlTrucks.Controls.Add(Me.cmbDamage)
        Me.pnlTrucks.Controls.Add(Me.btnPrintReport)
        Me.pnlTrucks.Controls.Add(Me.btnSaveDamage)
        Me.pnlTrucks.Controls.Add(Me.chkHideScanned)
        Me.pnlTrucks.Controls.Add(Me.btnRefresh)
        Me.pnlTrucks.Controls.Add(Me.btnMarkReceived)
        Me.pnlTrucks.Controls.Add(Me.lvTruckList)
        Me.pnlTrucks.Controls.Add(Me.Label1)
        Me.pnlTrucks.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTrucks.Location = New System.Drawing.Point(664, 0)
        Me.pnlTrucks.Name = "pnlTrucks"
        Me.pnlTrucks.Size = New System.Drawing.Size(288, 720)
        Me.pnlTrucks.TabIndex = 3
        '
        'cmbBinAssign
        '
        Me.cmbBinAssign.Location = New System.Drawing.Point(86, 434)
        Me.cmbBinAssign.Name = "cmbBinAssign"
        Me.cmbBinAssign.Size = New System.Drawing.Size(96, 24)
        Me.cmbBinAssign.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 28)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Bin Assign"
        '
        'btnJobTags
        '
        Me.btnJobTags.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJobTags.Location = New System.Drawing.Point(115, 0)
        Me.btnJobTags.Name = "btnJobTags"
        Me.btnJobTags.Size = New System.Drawing.Size(120, 23)
        Me.btnJobTags.TabIndex = 22
        Me.btnJobTags.Text = "Job Tags"
        '
        'btnUnmarkItem
        '
        Me.btnUnmarkItem.Location = New System.Drawing.Point(10, 554)
        Me.btnUnmarkItem.Name = "btnUnmarkItem"
        Me.btnUnmarkItem.Size = New System.Drawing.Size(268, 37)
        Me.btnUnmarkItem.TabIndex = 21
        Me.btnUnmarkItem.Text = "&UN-Mark Item"
        '
        'cmbDamage3
        '
        Me.cmbDamage3.Items.AddRange(New Object() {"", "Backorder", "Repairable", "Sent Back", "Reorder"})
        Me.cmbDamage3.Location = New System.Drawing.Point(192, 323)
        Me.cmbDamage3.Name = "cmbDamage3"
        Me.cmbDamage3.Size = New System.Drawing.Size(86, 24)
        Me.cmbDamage3.TabIndex = 16
        '
        'txtDamageDetail
        '
        Me.txtDamageDetail.Location = New System.Drawing.Point(10, 351)
        Me.txtDamageDetail.Name = "txtDamageDetail"
        Me.txtDamageDetail.Size = New System.Drawing.Size(268, 22)
        Me.txtDamageDetail.TabIndex = 17
        '
        'cmbDamage2
        '
        Me.cmbDamage2.Items.AddRange(New Object() {"", "Side", "Back", "Door", "Frame", "Shelf", "Drawer Box", "Drawer Front"})
        Me.cmbDamage2.Location = New System.Drawing.Point(106, 323)
        Me.cmbDamage2.Name = "cmbDamage2"
        Me.cmbDamage2.Size = New System.Drawing.Size(86, 24)
        Me.cmbDamage2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Damage Notes"
        '
        'cmbDamage
        '
        Me.cmbDamage.Items.AddRange(New Object() {"", "Scratched", "Missing Part", "Broken", "Wrong Color", "Wrong Size"})
        Me.cmbDamage.Location = New System.Drawing.Point(10, 323)
        Me.cmbDamage.Name = "cmbDamage"
        Me.cmbDamage.Size = New System.Drawing.Size(96, 24)
        Me.cmbDamage.TabIndex = 20
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.Location = New System.Drawing.Point(10, 628)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(268, 55)
        Me.btnPrintReport.TabIndex = 10
        Me.btnPrintReport.Text = "Print Completed Truck Report"
        '
        'btnSaveDamage
        '
        Me.btnSaveDamage.Location = New System.Drawing.Point(10, 388)
        Me.btnSaveDamage.Name = "btnSaveDamage"
        Me.btnSaveDamage.Size = New System.Drawing.Size(153, 27)
        Me.btnSaveDamage.TabIndex = 8
        Me.btnSaveDamage.Text = "Save Damage Notes"
        '
        'chkHideScanned
        '
        Me.chkHideScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideScanned.Location = New System.Drawing.Point(10, 258)
        Me.chkHideScanned.Name = "chkHideScanned"
        Me.chkHideScanned.Size = New System.Drawing.Size(192, 28)
        Me.chkHideScanned.TabIndex = 6
        Me.chkHideScanned.Text = "Hide Received Items"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(173, 212)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 28)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        '
        'btnMarkReceived
        '
        Me.btnMarkReceived.Location = New System.Drawing.Point(10, 498)
        Me.btnMarkReceived.Name = "btnMarkReceived"
        Me.btnMarkReceived.Size = New System.Drawing.Size(268, 37)
        Me.btnMarkReceived.TabIndex = 3
        Me.btnMarkReceived.Text = "&Mark Item Received / Print Label"
        '
        'timerRefreshScreen
        '
        Me.timerRefreshScreen.Enabled = True
        Me.timerRefreshScreen.Interval = 96000
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(664, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Receiving: "
        '
        'PrintDocumentBarCodeLabel
        '
        '
        'PrintDocJobTags
        '
        '
        'TblJobActivityTableAdapter1
        '
        Me.TblJobActivityTableAdapter1.ClearBeforeFill = True
        '
        'TksijobsDataSet1
        '
        Me.TksijobsDataSet1.DataSetName = "TKSIJOBSDataSet"
        Me.TksijobsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmReceivingStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(952, 720)
        Me.Controls.Add(Me.lvReceiving)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlTrucks)
        Me.Name = "frmReceivingStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTrucks.ResumeLayout(False)
        Me.pnlTrucks.PerformLayout()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private selectedTruck As String = ""
    Private dsTKSI1 As New TKSIJOBSDataSet
    Dim daTrailerHead As New TKSIJOBSDataSetTableAdapters.tblTrailerHeaderTableAdapter
    Dim daTrailerDet As New TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
    Dim daVendor As New TKSIJOBSDataSetTableAdapters.tVendorTableAdapter
    Dim daShipHead As New TKSIJOBSDataSetTableAdapters.tblShippingHeaderTableAdapter
    Dim daShipItem As New TKSIJOBSDataSetTableAdapters.tblShippingItemsTableAdapter
    Dim daPOheader As New TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter

    Private Structure DetailLine
        Dim damageNotes As String
        Dim NotReceivedCount As Long
        Dim PO As String
        Dim poLineNumber As Long
        Dim ReceivedCount As Long
        Dim newPOLine As Boolean
        Dim styleInfo As String

        Dim ScannedLines As Integer
        Dim UnScannedLines As Integer
        Dim OrderConfLines As Integer
        Dim ItemsNotOntruck As Integer
    End Structure

    Private Structure JobTag
        Dim POprefix As String
        Dim alPOsuffix As ArrayList
        Dim customer As String
        Dim boxCount As Integer

        Sub New(ByVal PO As String, ByVal sCust As String, ByVal nBoxes As Integer)

            Dim job5 As String = Mid(PO, 1, 5)

            If IsNumeric(job5) Then
                'change to 6 digit
                job5 = Mid(PO, 1, 6)
            Else
                'leave as 5 digit
            End If

            Me.POprefix = job5   'Mid(PO, 1, 5)
            alPOsuffix = New ArrayList
            AddPO(PO)
            Me.boxCount = nBoxes
            Me.customer = sCust
        End Sub

        Sub AddPO(ByVal PO As String)
            Dim job5 As String = Mid(PO, 1, 5)
            If IsNumeric(job5) Then
                '6 digit po pattern
                Me.alPOsuffix.Add(Mid(PO, 7, 6))
            Else
                'leave as 5 digit
                Me.alPOsuffix.Add(Mid(PO, 6, 6))
            End If
        End Sub

    End Structure

    Private PrintPages As Integer
    Private InsCountPrinted As Integer
    Private FinalPageCount As Integer

    Private Sub timerRefreshScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerRefreshScreen.Tick
        RefreshItemsList()
    End Sub

    Private topItemRefresh As New ListViewItem
    Private alJobTags As New ArrayList

    Private Sub AddItemToJobLabelsArray(ByVal sPO As String)
        Try
            Dim job5 As String = Mid(sPO, 1, 5)
            Dim job5Suffix As String = ""
            If IsNumeric(job5) Then
                'use 6 digit pattern
                job5 = Mid(sPO, 1, 6)
                job5Suffix = Mid(sPO, 7, 6)
            Else
                'eave as 5 digit
                job5Suffix = Mid(sPO, 6, 6)
            End If

            Dim tag As JobTag
            Dim i As Integer
            For i = 0 To Me.alJobTags.Count - 1
                tag = Me.alJobTags(i)
                If UCase(tag.POprefix) = UCase(job5) Then
                    Dim str As String
                    For Each str In tag.alPOsuffix
                        If UCase(job5Suffix) = UCase(str) Then
                            'we already have this PO suffix, dont add it again but increase box count
                            Me.alJobTags(i) = tag
                            Exit Try
                        End If
                    Next
                End If
            Next

            For Each tag In Me.alJobTags
                If UCase(tag.POprefix) = UCase(job5) Then
                    'add this po to an existing tag
                    tag.AddPO(sPO)
                    Exit Try
                End If
            Next

            Try
                Dim daJob As New TKSIJOBSDataSetTableAdapters.tJobTableAdapter
                Dim sCust As String = ""
                Dim nboxes As Integer = 0
                Me.dsTKSI1.tJob.Clear()
                '   daJob.SelectCommand.Parameters("sJobNo").Value = job5
                daJob.FillBySJobNo(Me.dsTKSI1.tJob, job5)
                If Me.dsTKSI1.tJob.Rows.Count > 0 Then
                    Dim daPOh As New TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter

                    Me.dsTKSI1.tPOHeader.Clear()
                    '.SelectCommand.Parameters("njobid").Value = Me.DsTKSI1.tJob(0).nID
                    daPOh.FillByNJOBID(Me.dsTKSI1.tPOHeader, Me.dsTKSI1.tJob(0).nID)
                    Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
                    For Each drPO In Me.dsTKSI1.tPOHeader
                        If IsNumeric(drPO.nBoxes) Then
                            nboxes += drPO.nBoxes
                        End If
                    Next
                    If Not Me.dsTKSI1.tJob(0).tCustomrRow Is Nothing Then
                        sCust = Me.dsTKSI1.tJob(0).tCustomrRow.sName
                    End If
                End If

                If nboxes > 0 Then
                    'didnt find a match so create a new one
                    Dim tagNew As New JobTag(sPO, sCust, nboxes)
                    Me.alJobTags.Add(tagNew)
                End If

            Catch ex As Exception
                Me.Text = ex.Message
            End Try


        Catch ex As Exception
            Windows.Forms.MessageBox.Show("AddItemToJobLabelsArray - " & ex.Message)
        End Try

    End Sub

    Private Enum SupplierCode
        KitchenCraft
        Crestwood
    End Enum

    'Private Class TruckPOItem
    '    Public Property sPO As String = ""
    '    Public Property nLine As Integer = 0
    '    Public Property sDesc As String = "unknown"
    '    Public Property sPOInfo As String = ""
    '    Public Property sBin As String = ""
    '    Sub New(_PO As String, _line As Integer, _desc As String, _poinfo As String, _bin As String)
    '        sPO = _PO
    '        nLine = _line
    '        sDesc = _desc
    '        sPOInfo = _poinfo
    '        sBin = _bin
    '    End Sub
    'End Class

    ' Private listTruckItems As New List(Of TruckPOItem)

    Private Sub RefreshItemsList()

        'Dim frmBusy1 As New frmWorking
        'frmBusy1.Text = frmBusy1.Text & " Receiving ..."
        'frmBusy1.Show()

        Me.timerRefreshScreen.Stop()
        Me.timerRefreshScreen.Start()
        Me.lvReceiving.BeginUpdate()
        Dim frmBusy1 As New frmWorking
        Try
            frmBusy1.Show()
            If Me.selectedTruck.Length > 0 Then
                Me.dsTKSI1.tblLocationLabelJOIN.Clear()
                Dim daLBjoin As New TKSIJOBSDataSetTableAdapters.tblLocationLabelJOINTableAdapter
                daLBjoin.FillByTrailerControlDelNull(Me.dsTKSI1.tblLocationLabelJOIN, Me.selectedTruck)
                '  Me.daLocationLabelJOIN.SelectCommand.Parameters("TrailerControl").Value = Me.selectedTruck
                '  Me.daLocationLabelJOIN.Fill(Me.DsTKSI1.tblLocationLabelJOIN)
            End If

        Catch ex As Exception
            Me.Text = "err: loading location join label info"
        End Try

        Try
            If Me.lvReceiving.Items.Count > 0 Then
                If topItemRefresh Is Me.lvReceiving.TopItem Then
                    'let this loop continue since nothing has been moved around, its okay to refresh
                Else
                    'dont refresh because the top item hasnt moved
                    topItemRefresh = Me.lvReceiving.TopItem
                    Me.timerRefreshScreen.Enabled = False
                    Me.timerRefreshScreen.Enabled = True
                    Me.Text = Me.Text & "..."
                    Exit Sub
                End If
            End If

            Dim blnShowItemInList As Boolean = True

            Me.lvReceiving.Items.Clear()

            Me.lvReceiving.SuspendLayout()
            Me.SuspendLayout()

            Me.btnSaveDamage.Visible = True

            Dim eSupplier As SupplierCode

            With Me.dsTKSI1
                .tblTrailerDetail.Clear()
                If Me.lvTruckList.SelectedItems.Count > 0 Then
                    If Mid(Me.lvTruckList.SelectedItems(0).SubItems(1).Text, 1, 2) = "CW" Then
                        eSupplier = SupplierCode.Crestwood
                        Dim daTrailerDetailCW As New TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
                        daTrailerDetailCW.FillByDateFixedRangeCW(.tblTrailerDetail)
                    Else
                        eSupplier = SupplierCode.KitchenCraft
                        Dim daTrailerDetail As New TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
                        daTrailerDetail.FillByShipDateFixed(.tblTrailerDetail)
                    End If
                End If


            End With
            Dim drHeader As TKSIJOBSDataSet.tblTrailerHeaderRow
            Dim drDetail As TKSIJOBSDataSet.tblTrailerDetailRow
            Dim lastPO As String = ""
            'Dim drOrderLine As tksijobsdataset.tblShippingItemsRow
            Dim item1 As ListViewItem

            'reset job tags array
            Me.alJobTags.Clear()

            Dim itemH As ListViewItem
            Dim draDetail As TKSIJOBSDataSet.tblTrailerDetailRow()
            '  Dim var 'As EnumerableRowCollection(Of TKSIJOBSDataSet.tblTrailerDetailRow)
            If eSupplier = SupplierCode.KitchenCraft Then
                ' var = (From row In Me.dsTKSI1.tblTrailerDetail Order By row.po)
                draDetail = Me.dsTKSI1.tblTrailerDetail.Select("", "po")
            Else
                'var = (From row In Me.dsTKSI1.tblTrailerDetail)
                Dim dr As TKSIJOBSDataSet.tblTrailerDetailRow
                Dim listDR As New List(Of TKSIJOBSDataSet.tblTrailerDetailRow)
                For Each dr In Me.dsTKSI1.tblTrailerDetail
                    listDR.Add(dr)
                Next
                draDetail = listDR.ToArray 'Me.dsTKSI1.tblTrailerDetail.Select("", "")
            End If

            ' listTruckItems.Clear()

            For Each drDetail In draDetail ' Me.DsTKSI1.tblTrailerDetail
                Try

                    blnShowItemInList = True
                    drHeader = drDetail.tblTrailerHeaderRow

                    Dim strCurrentPO As String = ""
                    If Not drHeader Is Nothing Then  'sometimes header is null?

                        If drHeader.TrailerControl.ToString = Me.selectedTruck Then
                            'figure if this is crestwood or not
                            If eSupplier = SupplierCode.KitchenCraft Then

                                If drDetail.IspoNull Then
                                    'old data has Null for detail SO 4/25/13  
                                    strCurrentPO = drDetail.tblTrailerHeaderRow.SO.ToString
                                Else
                                    strCurrentPO = drDetail.po
                                End If

                                If lastPO <> strCurrentPO Then
                                    itemH = Me.lvReceiving.Items.Add(drHeader.TrailerControl)
                                    itemH.SubItems.Add(strCurrentPO)
                                End If

                            ElseIf eSupplier = SupplierCode.Crestwood Then

                                strCurrentPO = drHeader.PO
                                If lastPO <> strCurrentPO Then

                                    itemH = Me.lvReceiving.Items.Add(drHeader.TrailerControl)
                                    itemH.SubItems.Add(strCurrentPO)
                                End If
                            Else
                                MessageBox.Show("unknown supplier")
                                Exit For
                            End If

                            If itemH IsNot Nothing Then
                                itemH.SubItems.Add("")
                                itemH.SubItems.Add("")
                                itemH.BackColor = Color.LightGray
                                itemH.Font = New Font(itemH.Font, FontStyle.Bold)
                            End If

                            'JOB TAGS Array
                            AddItemToJobLabelsArray(strCurrentPO)

                            ''test to find out if this header item exists in the database as an order as well
                            ''drOrderLine = Me.DsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drHeader.SO, drHeader.GettblTrailerDetailRows(0).OrderLineNumber)
                            ''If Not drOrderLine Is Nothing Then

                            item1 = New ListViewItem(drDetail.LabelID)
                            item1.SubItems.Add("")
                            Dim str As String = ""
                            str = (drDetail.OrderLineNumber)

                            Dim strBin As String = ""
                            Try
                                Dim draLocJOIN As TKSIJOBSDataSet.tblLocationLabelJOINRow()
                                draLocJOIN = Me.dsTKSI1.tblLocationLabelJOIN.Select("TrailerLLabelID='" & drDetail.LabelID & "'")
                                If draLocJOIN.Length > 0 Then
                                    strBin = LocationToShortName(draLocJOIN(0).tblLocationBinsRow.LabelID)
                                    itemH.SubItems(3).Text = itemH.SubItems(3).Text & strBin
                                    str = str & strBin
                                End If
                            Catch
                            End Try

                            Try
                                If InStr(UCase(drDetail.DetailDescription), "LN:") > 0 Then
                                    str = str & " - " & Mid(drDetail.DetailDescription, InStr(UCase(drDetail.DetailDescription), "LN:") + 3, 2)
                                End If
                            Catch ex As Exception
                                str = str & "*err*"
                            End Try
                            item1.SubItems.Add(str)

                            str = ""
                            If drDetail.DetailDescription.ToUpper.Contains("ORDER DESC NOT FOUND") Then
                                'import routine puts this in when no shipping detail record is found
                                'try to look up by SO number to get description from header
                                Dim dtShipItem As New TKSIJOBSDataSet.tblShippingItemsDataTable
                                If daShipItem.FillBySO(dtShipItem, drDetail.SupplierSO) > 0 Then
                                    str = str & dtShipItem(0).ProdDesc
                                    If dtShipItem.Count > 1 Then
                                        str = str & " or " & dtShipItem(1).ProdDesc
                                    End If
                                Else
                                    Dim dtHead As New TKSIJOBSDataSet.tblShippingHeaderDataTable
                                    If daShipHead.FillBySO(dtHead, drDetail.SupplierSO) > 0 Then
                                        str = str & dtHead(0).StyleDesc & "  **"
                                    Else
                                        str = str & Replace(drDetail.DetailDescription, "000", "")
                                    End If
                                End If

                            Else
                                str = str & Replace(drDetail.DetailDescription, "000", "")
                            End If

                            item1.SubItems.Add(str)
                            item1.SubItems.Add(drHeader.PalletNum & "  (" & drDetail.LabelID & ")")

                            If drDetail.IsDeliveredTKSINull Then
                                If drDetail.IsDateScannedTKSINull Then
                                    'list the item
                                    'white not recieved or delivered
                                Else
                                    item1.BackColor = Color.Yellow

                                    If Me.chkHideScanned.Checked Then
                                        'dont add it
                                        blnShowItemInList = False
                                    Else
                                        blnShowItemInList = True
                                    End If
                                End If
                            Else
                                item1.BackColor = Color.Green
                                If Me.chkHideScanned.Checked Then
                                    blnShowItemInList = False
                                End If
                            End If

                            If InStr(drDetail.DetailDescription, "SHELVING") > 0 Then
                                blnShowItemInList = False
                            End If

                            If blnShowItemInList Then
                                Me.lvReceiving.Items.Add(item1)
                                item1 = New ListViewItem

                                '  listTruckItems.Add(New TruckPOItem(strCurrentPO, drDetail.OrderLineNumber, drDetail.DetailDescription, drHeader.PalletNum & "  (" & drDetail.LabelID & ")", strBin))
                            Else
                                'just dont add it to list view
                            End If

                        Else
                            'wrong truck dont show
                        End If
                    Else
                        'no po header record
                        Dim itemError As New ListViewItem("NO PO header found ")
                        itemError.SubItems.Add("ERROR")
                        itemError.SubItems.Add("ERROR")
                        Me.lvReceiving.Items.Add(itemError)
                    End If

                    lastPO = strCurrentPO

                Catch ex As Exception
                    Me.lvReceiving.Items.Clear()
                    Dim itemError As New ListViewItem("ERROR" & ex.Message)
                    itemError.SubItems.Add("ERROR" & ex.Message)
                    itemError.SubItems.Add("ERROR" & ex.Message)
                    Me.lvReceiving.Items.Add(itemError)
                End Try

            Next

            'load top item in cache to see if user has scrolled around
            'if user is scrolling we dont want to refresh the screen
            If Not Me.lvReceiving.TopItem Is Nothing Then
                topItemRefresh = Me.lvReceiving.TopItem()
            End If

        Catch ex As Exception
            Me.lvReceiving.Items.Clear()
            Dim itemError As New ListViewItem("ERROR" & ex.Message)
            itemError.SubItems.Add("ERROR" & ex.Message)
            itemError.SubItems.Add("ERROR" & ex.Message)
            Me.lvReceiving.Items.Add(itemError)
        Finally

            Try
                frmBusy1.Close()
            Catch
            End Try


            Me.lvReceiving.EndUpdate()
            Me.ResumeLayout()
            Me.lvReceiving.ResumeLayout()
            Me.Refresh()
            'frmBusy1.Close()
            Me.timerRefreshScreen.Stop()
            Me.timerRefreshScreen.Start()
        End Try

    End Sub

    Private Sub RefreshBinsSelection()
        Try

            Dim dalb As New TKSIJOBSDataSetTableAdapters.tblLocationBinsTableAdapter
            Me.cmbBinAssign.Items.Clear()
            Me.cmbBinAssign.DisplayMember = "LabelID"
            Me.dsTKSI1.tblLocationBins.Clear()

            dalb.Fill(Me.dsTKSI1.tblLocationBins)

            Dim drLoc As TKSIJOBSDataSet.tblLocationBinsRow
            For Each drLoc In Me.dsTKSI1.tblLocationBins
                Me.cmbBinAssign.Items.Add(drLoc)
            Next

        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub RefreshTruckList()
        Me.dsTKSI1.tblTrailerHeader.Clear()

        Me.daTrailerHead.FillBy30day(Me.dsTKSI1.tblTrailerHeader)

        Me.lvTruckList.Items.Clear()
        Dim lastTrailer As String = ""
        Dim drTHeader As TKSIJOBSDataSet.tblTrailerHeaderRow
        For Each drTHeader In Me.dsTKSI1.tblTrailerHeader
            If drTHeader.TrailerControl.ToString = lastTrailer Then
                'dont show, we only want one line per trailer control num
            Else
                Dim item1 As ListViewItem
                item1 = Me.lvTruckList.Items.Add(drTHeader.TrailerControl)
                Dim strSupplierCode As String = ""
                item1.BackColor = Color.White
                If drTHeader.FreightTermsCode.Trim = "CW" Then
                    strSupplierCode = "CW"
                Else
                    strSupplierCode = "KC"
                End If

                If drTHeader.ShipDate < Today.Date.AddDays(-10) Then
                    item1.BackColor = Color.LightGreen
                End If

                item1.SubItems.Add(strSupplierCode & " " & drTHeader.TrailerControl & "  " & _
                drTHeader.ShipDate.Month & "/" & drTHeader.ShipDate.Day & "  (" & _
                drTHeader.TrailerNumber & ")")

            End If
            lastTrailer = drTHeader.TrailerControl.ToString
        Next

        Me.Refresh()
    End Sub

    Private Sub frmReceivingStatus_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.timerRefreshScreen.Enabled = False
    End Sub

    Private Sub frmReceivingStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTruckList()
        RefreshBinsSelection()

        Me.dsTKSI1.EnforceConstraints = False
        Me.dsTKSI1.tblShippingHeader.Clear()
        Me.dsTKSI1.tblShippingItems.Clear()
        Me.dsTKSI1.tCustomr.Clear()
        Me.dsTKSI1.tVendor.Clear()

        Me.daShipHead.FillByGTDateImported(Me.dsTKSI1.tblShippingHeader, Now.AddYears(-1))
        'Me.daShippingDetail.Fill(Me.DsTKSI1.tblShippingItems)
        Dim daCustAll As New TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter
        daCustAll.Fill(Me.dsTKSI1.tCustomr)
        Me.daVendor.Fill(Me.dsTKSI1.tVendor)

        Me.timerRefreshScreen.Enabled = True
    End Sub

    Private Sub lvTruckList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTruckList.DoubleClick
        If Me.lvTruckList.SelectedItems.Count = 1 Then
            Me.selectedTruck = Me.lvTruckList.SelectedItems(0).Text
        End If
    End Sub

    Private Sub lvTruckList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTruckList.SelectedIndexChanged
        If Me.lvTruckList.SelectedItems.Count = 1 Then
            Me.selectedTruck = Me.lvTruckList.SelectedItems(0).Text
        End If
    End Sub

    Private Sub btnMarkReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkReceived.Click
        MarkItemReceived(True, True)
    End Sub

    Private Sub MarkItemReceived(ByVal blnUpdateReceived As Boolean, ByVal blnPrintLabel As Boolean)

        If Me.lvReceiving.SelectedItems.Count >= 1 Then
            'reset timer so user has extra time to mark other items without 
            'screen refresh too fast
            Me.timerRefreshScreen.Stop()
            Me.timerRefreshScreen.Start()

            Dim itemSel As ListViewItem
            itemSel = Me.lvReceiving.SelectedItems(0)

            If blnUpdateReceived Then
                itemSel.BackColor = Color.Yellow
            End If

            Dim label As String = ""
            label = itemSel.Text

            Dim drDetail As TKSIJOBSDataSet.tblTrailerDetailRow
            drDetail = Me.dsTKSI1.tblTrailerDetail.FindByLabelID(label)
            If Not drDetail Is Nothing Then
                If blnUpdateReceived Then
                    drDetail.DateScannedTKSI = Now
                End If

                Dim strDamage As String
                strDamage = Me.cmbDamage.Text.Trim & " " & Me.cmbDamage2.Text.Trim & " " & Me.cmbDamage3.Text.Trim & " " & Me.txtDamageDetail.Text.Trim
                If strDamage.Trim.Length > 0 Then
                    drDetail.DamageNotes = strDamage
                End If
                Me.cmbDamage.Text = ""
                Me.cmbDamage2.Text = ""
                Me.cmbDamage3.Text = ""
                Me.txtDamageDetail.Text = ""

                Dim daTrailerDetail As New TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
                daTrailerDetail.Update(Me.dsTKSI1.tblTrailerDetail)
                Me.dsTKSI1.tblTrailerDetail.AcceptChanges()

                If blnUpdateReceived Then
                    itemSel.BackColor = Color.Yellow
                End If

                If blnPrintLabel Then
                    PrintLabel(drDetail)
                End If
                itemSel.ForeColor = Color.Blue
                Me.lvReceiving.ResumeLayout(True)

            Else
                Windows.Forms.MessageBox.Show("could not locate line item to receive.")
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'set back to top so system doesnt think person is trying to still scroll
        If Me.lvReceiving.Items.Count > 0 Then
            Me.lvReceiving.Items(0).EnsureVisible()
        End If

        RefreshItemsList()
    End Sub

    Private Sub lvReceiving_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvReceiving.DoubleClick
        MarkItemReceived(True, False)
    End Sub

    Private Sub btnSaveDamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDamage.Click
        MarkItemReceived(False, False)
    End Sub

    Private Class POLog
        Public iScannedCount As Integer = 0
        Public iUnscannedCount As Integer = 0
        Public iItemsNotOnTruck As Integer = 0
        Public sPO As String = ""
        Public sdamageNotes As String = ""
        Sub New(_sPO As String, _iScannedCount As Integer, _iUnscannedCount As Integer, _iItemsNotOnTruck As Integer, _sDamageNotes As String)
            iScannedCount = _iScannedCount
            iUnscannedCount = _iUnscannedCount
            iItemsNotOnTruck = _iItemsNotOnTruck
            sPO = _sPO
            sdamageNotes = _sDamageNotes
        End Sub
    End Class

    Private listPOlog As New List(Of POLog)

    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        Try
            Dim frmbusy1 As New frmWorking
            frmbusy1.Show()
            Try
                'trailer header is not 1 for 1 for unique PO numbers
                'there can be 2 trailer headers for one PO
                'so we have to loop the trailer details sorted by PO to be unique set of PO

                Dim pdf As New clsPDFCreate("Receiving Report " & Now.ToString)
                pdf.AddParagraphToPDF("Truck: " & Me.selectedTruck & " - " & Me.lvTruckList.SelectedItems(0).SubItems(1).Text)
                pdf.PDFAddSeperatorLine()
                pdf.AddParagraphToPDF(pdf.ColTextPad("PO", "Unscanned", "Diff Truck", "Total Lines", "Style Info"))
                pdf.PDFAddSeperatorLine()
                'get unique list of POs contianed in this truck only

                Dim qLinesWithPOnotNull As EnumerableRowCollection(Of TKSIJOBSDataSet.tblTrailerDetailRow) = From row In Me.dsTKSI1.tblTrailerDetail Where (Not row.IspoNull) Select row
                Dim distinctPO As List(Of String) = (From d1 In qLinesWithPOnotNull Where d1.tblTrailerHeaderRow.TrailerControl = Me.selectedTruck Select d1.po).Distinct().OrderBy(Function(POcolumn) POcolumn.ToString).ToList

                Me.listPOlog.Clear()

                For Each poFilter As String In distinctPO
                    Try
                        'get all detail items for this PO, even some not on this truck
                        'Per One PO
                        Dim qLinesAnyTruckPerPO As EnumerableRowCollection(Of TKSIJOBSDataSet.tblTrailerDetailRow) = (From row In qLinesWithPOnotNull Where row.po = poFilter Select row).OrderBy(Function(order1) order1.OrderLineNumber)
                        Dim iCountLinesAnyTruck As Integer = qLinesAnyTruckPerPO.Count
                        Dim qLinesThisTruck As EnumerableRowCollection(Of TKSIJOBSDataSet.tblTrailerDetailRow) = (From row In qLinesAnyTruckPerPO Where row.tblTrailerHeaderRow.TrailerControl = Me.selectedTruck)
                        Dim iCountLinesThisTruck As Integer = qLinesThisTruck.Count
                        Dim iCountLinesDifferentTruck As Integer = iCountLinesAnyTruck - iCountLinesThisTruck
                        Dim qLineUnscanned As EnumerableRowCollection(Of TKSIJOBSDataSet.tblTrailerDetailRow) = From row In qLinesThisTruck Where row.IsDateScannedTKSINull And row.IsDeliveredTKSINull Select row
                        Dim iCountUnscanned As Integer = qLineUnscanned.Count

                        Dim POLog1 As POLog

                        If CheckForBadPONumbers(poFilter) Then
                            pdf.AddParagraphToPDF(pdf.ColTextPad(poFilter & " Bad PO Number", "", "Not in TKSI system", "", ""))
                        Else
                            pdf.AddParagraphToPDF(pdf.ColTextPad(poFilter, iCountUnscanned.ToString, iCountLinesDifferentTruck, iCountLinesAnyTruck, ""))
                            POLog1 = New POLog(poFilter, iCountLinesThisTruck - iCountUnscanned, iCountUnscanned, iCountLinesDifferentTruck, "")
                            listPOlog.Add(POLog1)
                        End If

                        Dim qLinesDamaged As EnumerableRowCollection(Of TKSIJOBSDataSet.tblTrailerDetailRow) = (From row In qLinesThisTruck Where row.DamageNotes.Length > 0 Select row)
                        qLinesDamaged.ToList.ForEach(Function(row)
                                                         Try
                                                             pdf.AddParagraphToPDF(pdf.ColTextPad("(" & row.OrderLineNumber & ")", "", "", "", "damage: " & row.DamageNotes))
                                                             If Not POLog1 Is Nothing Then
                                                                 POLog1.sdamageNotes = POLog1.sdamageNotes & " - " & row.DamageNotes
                                                             End If
                                                         Catch ex As Exception
                                                             pdf.AddParagraphToPDF("ERROR writing damage line- " & poFilter & " " & ex.Message)
                                                         End Try
                                                     End Function)

                        qLineUnscanned.ToList.ForEach(Function(row)
                                                          Try
                                                              If InStr(row.DetailDescription, "SHELVING") > 0 Then
                                                                  'dont show, crestswood bug,  lines on Shelving
                                                              Else
                                                                  pdf.AddParagraphToPDF(pdf.ColTextPad("(" & row.OrderLineNumber & ")", "", "", "", row.DetailDescription))
                                                              End If
                                                          Catch ex As Exception
                                                              pdf.AddParagraphToPDF("ERROR showing unscanned line- " & poFilter & " " & ex.Message)
                                                          End Try
                                                      End Function)
                    Catch ex As Exception
                        MessageBox.Show("Error while building report: " & ex.Message)
                        Exit For
                    End Try
                Next

                pdf.ShowPDF()

                ' hack for crestwood  data fix
                'if a "C" label id serial number has not been scanned
                'and the same pallet has a "U" label with the same
                'order ID and it has been scanned
                'then disregard the "C" label
                'note: ALL "U" items must be scanned

            Catch ex As Exception
                Windows.Forms.MessageBox.Show(ex.Message)
            Finally
                frmbusy1.Close()
            End Try

            If Windows.Forms.MessageBox.Show("Do you want to update Supplier Report Received Date?", "Update Received Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                UpdateTKSIReceiving()
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function CheckForBadPONumbers(ByVal PO As String) As Boolean
        Me.dsTKSI1.tPOHeader.Clear()
        Me.daPOheader.FillByPONum(Me.dsTKSI1.tPOHeader, PO) '.SelectCommand.Parameters("@sPONum").Value = PO
        ' Me.daPObySPONUM.Fill(Me.DsTKSI1.tPOHeader)
        'Dim dr As tksijobsdataset.tPOHeaderRow
        If Me.dsTKSI1.tPOHeader.Rows.Count = 1 Then
            'found PO
            Return False
        Else
            Return True
        End If
    End Function

    Private Class POWithDamage  'empty damage notes means no damage
        'Public drPO As tksijobsdataset.tPOHeaderRow
        Public nJobID As Integer = 0
        Public sDamageNotes As String = ""
        Public nBoxes As Integer = 0
        Public nAccount As Integer = 0
        Public dReceived As Date = Nothing
    End Class

    Private alPONeedingActivityUpdate As New ArrayList
    Private alJobActivity As New ArrayList

    Private Class JobActivityLine
        Public nJobID As Integer = 0
        Public stype As String = ""
        Public sDetail As String = ""
        Public blnHasCabs As Boolean = False
        Public blnWholeJobRecieved As Boolean = False
    End Class

    Private Sub AddJobNoToActivityArray(ByVal PO1 As POWithDamage)
        'we only want to write one line of activity per job number that has been handled by the scanning process

        'Dim drJob As tksijobsdataset.tJobRow
        'drJob = PO1.drPO.tJobRow

        Dim act1 As JobActivityLine
        Dim i As Integer
        Dim blnFoundActivity As Boolean = False

        Dim sActivityType As String = ""
        Dim sActivityDetail As String = ""

        If PO1.sDamageNotes.Length > 0 Then
            sActivityType = "Job Received"
            sActivityDetail = "Job Received / Damage: " & PO1.sDamageNotes
        Else
            If PO1.nBoxes > 0 Then
                'this is a cabinetry PO
                sActivityType = "Job Received"
                sActivityDetail = "Job Received"
            ElseIf PO1.nAccount = 4010 Then
                sActivityType = "Misc Received"
                sActivityDetail = "Misc Received"
            Else
                sActivityType = "Hardware Received"
                sActivityDetail = "Hardware Received"
            End If
        End If

        For i = 0 To Me.alJobActivity.Count - 1
            act1 = Me.alJobActivity(i)
            If act1.nJobID = PO1.nJobID Then
                blnFoundActivity = True
                'activity has already been added, only overwrite if this is more important
                If InStr(act1.sDetail, "Damage") > 0 Then
                    'dont overwrite existing damage note
                ElseIf PO1.sDamageNotes.Length > 0 Then
                    'overwrite anything other than damage with this new damaged item
                    act1.stype = "Job Received"
                    act1.sDetail = sActivityDetail
                    Me.alJobActivity(i) = act1

                ElseIf act1.stype = "Hardware Received" Then
                    'overwrite with anything
                    If act1.blnHasCabs Then
                        act1.stype = sActivityType
                        act1.sDetail = sActivityDetail
                    Else
                        act1.stype = "Job Received"
                        act1.sDetail = act1.stype

                    End If

                    Me.alJobActivity(i) = act1
                ElseIf act1.stype = "Misc Received" And sActivityType = "Job Received" Then
                    'always overwrite with job received if we did get cabinets
                    act1.stype = sActivityType
                    act1.sDetail = sActivityDetail
                    Me.alJobActivity(i) = act1
                End If

                Exit For
            End If
        Next

        If Not blnFoundActivity Then

            'add a new activity line
            act1 = New JobActivityLine

            Dim dtPO As New TKSIJOBSDataSet.tPOHeaderDataTable

            Dim daPOHeaderbyNJOBID As New TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter

            'Me.daPOHeaderByNJobID.SelectCommand.Parameters("NJOBID").Value = PO1.nJobID
            daPOHeaderbyNJOBID.FillByNJOBID(dtPO, PO1.nJobID)

            'when first adding activity, check if the whole job is just misc pieces or does it have cabinetry?
            'also are the other POs recieved as well?
            'misc items should flag as job recieved only if all other items are received
            Dim drPO1 As TKSIJOBSDataSet.tPOHeaderRow
            act1.blnWholeJobRecieved = True
            For Each drPO1 In dtPO
                If drPO1.nBoxes > 0 Then
                    act1.blnHasCabs = True
                End If
                'disregard labor POs when determining if the whole job has been received
                If drPO1.IsDRECNull And drPO1.nAccount < 4040 Then
                    act1.blnWholeJobRecieved = False
                End If
            Next

            If act1.blnHasCabs Then
                act1.stype = sActivityType
                act1.sDetail = sActivityDetail
            ElseIf Not act1.blnWholeJobRecieved Then
                act1.stype = sActivityType
                act1.sDetail = sActivityDetail
            Else
                'even if parts received are misc, flag as job received if everything is in
                act1.stype = "Job Received"
                act1.sDetail = "Job Received"
            End If

            act1.nJobID = PO1.nJobID
            Me.alJobActivity.Add(act1)
        End If
    End Sub

    Private Sub UpdateTKSIReceiving()
        Me.alPONeedingActivityUpdate.Clear()

        For Each polog1 As POLog In Me.listPOlog
            With polog1
                If (.iScannedCount > .iUnscannedCount And .iScannedCount > .iItemsNotOnTruck) Then
                    Me.dsTKSI1.tPOHeader.Clear()
                    Me.daPOheader.FillByPONum(Me.dsTKSI1.tPOHeader, polog1.sPO)
                    Dim dr As TKSIJOBSDataSet.tPOHeaderRow
                    If Me.dsTKSI1.tPOHeader.Rows.Count = 1 Then
                        dr = Me.dsTKSI1.tPOHeader.Rows(0)
                        If dr.IsDRECNull Then
                            dr.DREC = Now.Date
                            If dr.dRequired > Today.Date.AddDays(3) Or dr.dRequired < Today.Date.AddDays(-3) Then
                                dr.dRequired = Today.Date
                            End If
                            If dr.nTruck < 2 Then
                                dr.nTruck = Me.selectedTruck
                            End If
                        End If

                        'save the group of POs getting flagged in temporary storage
                        Dim PO1 As New POWithDamage
                        PO1.dReceived = dr.DREC
                        PO1.nAccount = dr.nAccount
                        PO1.nBoxes = dr.nBoxes
                        PO1.sDamageNotes = .sdamageNotes
                        PO1.nJobID = dr.nJobID
                        alPONeedingActivityUpdate.Add(PO1)
                        Me.daPOheader.Update(Me.dsTKSI1.tPOHeader)
                        Me.dsTKSI1.tPOHeader.AcceptChanges()
                        Me.alPONeedingActivityUpdate.Add(PO1)

                    Else
                        'Windows.Forms.MessageBox.Show(det1.PO & " could not update receiving date")
                    End If
                End If
            End With

        Next

        Dim po2 As POWithDamage
        For Each po2 In Me.alPONeedingActivityUpdate
            'only update activity log on jobs that are specificaly getting flagged as Received
            AddJobNoToActivityArray(po2)
        Next
        'ChangeMiscRecToJobRec(Me.alJobActivity)
        UpdateJobActivityToSQL(Me.alJobActivity)
    End Sub

    Private Sub UpdateJobActivityToSQL(ByVal alActivity As ArrayList)
        Dim act1 As JobActivityLine
        For Each act1 In alActivity
            Dim drAct As TKSIJOBSDataSet.tblJobActivityRow
            drAct = Me.TksijobsDataSet1.tblJobActivity.NewtblJobActivityRow
            With drAct
                .ActivityDetail = act1.sDetail
                .nJobID = act1.nJobID
                .ActivityType = UCase(act1.stype)
                .dateEntered = Now
                .gID = Guid.NewGuid
                .Other = ""
            End With
            Me.TksijobsDataSet1.tblJobActivity.AddtblJobActivityRow(drAct)

        Next

        Me.TblJobActivityTableAdapter1.Update(Me.TksijobsDataSet1.tblJobActivity)

    End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    PrintPages = PrintPages + 1
    '    e.HasMorePages = DrawAll(e.Graphics)
    '    If Not e.HasMorePages Then
    '        FinalPageCount = PrintPages
    '        PrintPages = 0
    '        InsCountPrinted = 0
    '    End If
    'End Sub

    Public Function GetLetterPaperEnum(ByVal print1 As System.Drawing.Printing.PageSettings, Optional ByVal sizeName As String = "Letter") As Integer
        Try
            Dim i As Integer
            For i = 0 To print1.PrinterSettings.PaperSizes.Count - 1
                'Windows.Forms.MessageBox.Show(print1.PrinterSettings.PaperSizes(i).PaperName)
                If print1.PrinterSettings.PaperSizes(i).PaperName = sizeName Then
                    Return i
                End If
            Next
            Return -1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    'Private Function DrawAll(ByVal g As Graphics) As Boolean

    '    'Dim grandtotalCount As Long

    '    yy = 50

    '    Dim row1 As New ArrayList

    '    'Dim sDraw As String
    '    row1.Add("Truck Receiving Report : " & Now.ToShortDateString & "   " & Me.lvTruckList.SelectedItems(0).SubItems(1).Text)
    '    printRow(g, row1)

    '    row1 = New ArrayList

    '    row1.Add("PO")
    '    row1.Add("Unscanned")
    '    row1.Add("Lines on diff Trk")
    '    row1.Add("Total Order Lines")
    '    row1.Add("Style Info")

    '    printRow(g, row1)

    '    printHorLine(g)

    '    'Dim lastType As String
    '    Dim detail1 As DetailLine

    '    Dim thisGraphicsPrintCount As Long
    '    Dim loopCount As Long
    '    For Each detail1 In Me.Lines
    '        loopCount = loopCount + 1
    '        If ((loopCount > InsCountPrinted) Or (InsCountPrinted = 0)) Then
    '            If yy > 1000 Then
    '                InsCountPrinted = InsCountPrinted + thisGraphicsPrintCount
    '                Return True
    '            End If
    '            thisGraphicsPrintCount = thisGraphicsPrintCount + 1

    '            row1 = New ArrayList
    '            With row1
    '                If detail1.newPOLine Then
    '                    .Add(detail1.PO)
    '                Else
    '                    .Add("  (" & detail1.poLineNumber & ")")
    '                End If

    '                .Add(detail1.UnScannedLines)
    '                .Add(detail1.ItemsNotOntruck)
    '                .Add(detail1.OrderConfLines)

    '                If detail1.poLineNumber = 0 Then
    '                    .Add(detail1.damageNotes)
    '                Else
    '                    .Add(detail1.damageNotes & "  (" & detail1.poLineNumber & ") " & detail1.styleInfo)
    '                End If

    '                .Add("")
    '            End With

    '            printRow(g, row1)
    '        End If
    '        If loopCount > 10000 Then Return False
    '    Next

    '    printHorLine(g)

    'End Function

    Private yy As Integer

    Private Sub printRow(ByVal g As Graphics, ByVal col1 As ArrayList)
        Dim xx As Decimal
        yy = yy + 17
        xx = 0

        'Dim str As String
        Dim i As Long
        For i = 0 To col1.Count - 1
            Select Case i
                Case 0
                    xx = xx + 40
                Case 1
                    xx = xx + 90
                Case 2
                    xx = xx + 90
                Case 3
                    xx = xx + 120
                Case 4
                    xx = xx + 100
                Case 5
                    xx = xx + 100
                Case Else
                    xx = xx + 100
            End Select
            g.DrawString(col1(i), New Font("Arial", "8", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, xx, yy)
        Next

    End Sub

    Private Sub printHorLine(ByVal g As Graphics)
        Dim xx As Integer
        yy = yy + 15
        xx = 20
        g.DrawLine(New Pen(Color.Black), xx, yy, 790, yy)
    End Sub

    Private Sub frmReceivingStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            If Windows.Forms.MessageBox.Show("Do you want to update receiving data now?", "Update now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                UpdateTKSIReceiving()
            End If
        End If
    End Sub

    Private Sub PrintLabel(ByVal drTD As TKSIJOBSDataSet.tblTrailerDetailRow)
        Try
            line1 = ""
            line2 = ""
            line3 = ""

            line4BarCode = drTD.LabelID
            line3 = drTD.tblTrailerHeaderRow.PO
            Try
                line3 = line3 & "  Line: " & drTD.OrderLineNumber
            Catch ex As Exception
            End Try

            '  If Not drTD.IsDamageNotesNull Then
            line3 = line3 & "   " & drTD.DamageNotes
            '   End If

            Try
                'Dim drPO As tksijobsdataset.tPOHeaderRow
                Me.dsTKSI1.tPOHeader.Clear()

                Me.daPOheader.FillByPONum(Me.dsTKSI1.tPOHeader, drTD.tblTrailerHeaderRow.PO)
                '   Me.daPObySPONUM.SelectCommand.Parameters("@sPONum").Value = drTD.tblTrailerHeaderRow.PO
                '   Me.daPObySPONUM.Fill(Me.dsTKSI1.tPOHeader)
                If Me.dsTKSI1.tPOHeader.Rows.Count > 0 Then
                    line1 = Me.dsTKSI1.tPOHeader(0).tVendorRow.sName
                End If

                Dim drShipItem As TKSIJOBSDataSet.tblShippingItemsRow
                If drTD.IsSupplierSONull Then
                    drShipItem = Me.dsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drTD.tblTrailerHeaderRow.SO, drTD.OrderLineNumber)
                Else
                    drShipItem = Me.dsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drTD.SupplierSO, drTD.OrderLineNumber)
                End If

                line2 = drShipItem.ProdDesc

            Catch ex As Exception
                line2 = "error"
            End Try

            With Me.PrintDocumentBarCodeLabel

                .DocumentName = "Shipping Label"
                If ISDebugMachine Then

                Else
                    .PrinterSettings.PrinterName = "\\Warehouse1\ZebraLP2dock"
                End If

                .PrinterSettings.DefaultPageSettings.Margins.Left = 20
                .PrinterSettings.DefaultPageSettings.Margins.Right = 5
                .PrinterSettings.DefaultPageSettings.Margins.Top = 20
                .PrinterSettings.DefaultPageSettings.Margins.Bottom = 5

            End With
            Me.PrintDocumentBarCodeLabel.Print()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error printing label. " & ex.Message)
        End Try

    End Sub

    Dim line1 As String = ""
    Dim line2 As String = ""
    Dim line3 As String = ""
    Dim line4BarCode As String = ""

    Private Function DrawLabelGraphics(ByVal g As Graphics) As Boolean
        g.DrawString(Me.line1, New Font("Arial", "14", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 1)
        g.DrawString(Me.line2, New Font("Arial", "14", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 26)
        g.DrawString(Me.line3, New Font("Arial", "14", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 51)
        g.DrawString("*" & Me.line4BarCode & "*", New Font("Bar Code 39 d", "16", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 76)
        g.DrawString("*" & Me.line4BarCode & "*", New Font("Arial", "10", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 106)

        Return False
    End Function

    Private Sub PrintDocumentBarCodeLabel_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentBarCodeLabel.PrintPage
        e.HasMorePages = Me.DrawLabelGraphics(e.Graphics)
    End Sub

    Private Sub btnUnmarkItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnmarkItem.Click
        If Me.lvReceiving.SelectedItems.Count >= 1 Then
            'reset timer so user has extra time to mark other items without 
            'screen refresh too fast
            Me.timerRefreshScreen.Stop()
            Me.timerRefreshScreen.Start()

            Dim itemSel As ListViewItem
            itemSel = Me.lvReceiving.SelectedItems(0)
            itemSel.BackColor = Color.White

            Dim label As String = ""
            label = itemSel.Text

            Dim drDetail As TKSIJOBSDataSet.tblTrailerDetailRow
            drDetail = Me.dsTKSI1.tblTrailerDetail.FindByLabelID(label)
            If Not drDetail Is Nothing Then

                drDetail.SetDateScannedTKSINull()
                drDetail.SetDeliveredTKSINull()

                Dim daTrailerDetail As New TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
                daTrailerDetail.Update(Me.dsTKSI1.tblTrailerDetail)
                Me.dsTKSI1.tblTrailerDetail.AcceptChanges()

                itemSel.BackColor = Color.White

                itemSel.ForeColor = Color.Blue

                Me.lvReceiving.ResumeLayout(True)

            Else
                Windows.Forms.MessageBox.Show("could not locate line item to unmark.")
            End If
        End If
    End Sub

    Private Sub btnJobTags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobTags.Click
        If Me.alJobTags.Count > 0 Then

            Dim pdf1 As New clsPDFCreate("Job Tags " & Me.selectedTruck)
            'Dim row1 As New ArrayList
            'pdf1.AddParagraphToPDF("Truck Receiving Report : " & Now.ToShortDateString & " " & Me.lvTruckList.SelectedItems(0).SubItems(1).Text)
            'pdf1.PDFAddSeperatorLine()
            Dim tag1 As JobTag

            Dim loopCount As Integer
            For Each tag1 In Me.alJobTags
                loopCount = loopCount + 1
                Dim additionalPOInfo As String = ""
                Dim str As String
                For Each str In tag1.alPOsuffix
                    additionalPOInfo = additionalPOInfo & " , " & str
                Next

                pdf1.PDFAddSeperatorLine()
                pdf1.AddParagraphToPDF(tag1.POprefix & "  " & additionalPOInfo, 24)
                pdf1.AddParagraphToPDF(tag1.customer, 24)
                pdf1.AddParagraphToPDF(tag1.boxCount & " Boxes", 24)


                If loopCount Mod 2 = 0 Then
                    'bottom of page already
                    pdf1.PDFAddNewPage()
                Else
                    pdf1.AddParagraphToPDF(" ", 24)
                    pdf1.AddParagraphToPDF(" ", 24)
                    pdf1.AddParagraphToPDF(" ", 24)
                    pdf1.AddParagraphToPDF(" ", 24)
                    pdf1.AddParagraphToPDF(" ", 24)
                    pdf1.AddParagraphToPDF(" ", 24)
                    pdf1.AddParagraphToPDF(" ", 24)

                End If
            Next

            pdf1.ShowPDF()

        Else
            Windows.Forms.MessageBox.Show("Choose a truck first.")
        End If
    End Sub

    Private Sub PrintDocJobTags_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocJobTags.PrintPage
        PrintPages = PrintPages + 1
        e.HasMorePages = DrawAllTags(e.Graphics)
        If Not e.HasMorePages Then
            FinalPageCount = PrintPages
            PrintPages = 0
            InsCountPrinted = 0
        End If
    End Sub

    Private Function DrawAllTags(ByVal g As Graphics) As Boolean

        ' Dim grandtotalCount As Long
        yy = 150
        Dim row1 As New ArrayList
        'Dim sDraw As String
        row1.Add("Truck Receiving Report : " & Now.ToShortDateString & "   " & Me.lvTruckList.SelectedItems(0).SubItems(1).Text)

        'Dim lastType As String
        Dim tag1 As JobTag

        Dim thisGraphicsPrintCount As Long
        Dim loopCount As Long
        For Each tag1 In Me.alJobTags

            loopCount = loopCount + 1
            If ((loopCount > InsCountPrinted) Or (InsCountPrinted = 0)) Then
                If yy > 1000 Then
                    InsCountPrinted = InsCountPrinted + thisGraphicsPrintCount
                    Return True
                End If
                thisGraphicsPrintCount = thisGraphicsPrintCount + 1

                Dim additionalPOInfo As String = ""
                Dim str As String
                For Each str In tag1.alPOsuffix
                    additionalPOInfo = additionalPOInfo & " , " & str
                Next
                g.DrawString(tag1.POprefix & "  " & additionalPOInfo, New Font("Arial", "48", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 100, yy)
                g.DrawString(tag1.customer, New Font("Arial", "48", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 100, yy + 90)
                g.DrawString(tag1.boxCount & " Boxes", New Font("Arial", "48", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 100, yy + 170)

                yy += 501
            End If
            If loopCount > 10000 Then Return False
        Next

    End Function

    Private Sub cmbBinAssign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBinAssign.SelectedIndexChanged
        Try
            If Not Me.cmbBinAssign.SelectedItem Is Nothing Then

                Me.timerRefreshScreen.Stop()
                Me.timerRefreshScreen.Start()

                Dim drLoc As TKSIJOBSDataSet.tblLocationBinsRow
                drLoc = Me.cmbBinAssign.SelectedItem
                Dim daLBjoin As New TKSIJOBSDataSetTableAdapters.tblLocationLabelJOINTableAdapter
                If Not drLoc Is Nothing Then
                    Dim itemSel As ListViewItem
                    itemSel = Me.lvReceiving.SelectedItems(0)
                    Dim label As String = ""
                    label = itemSel.Text
                    Dim drDetail As TKSIJOBSDataSet.tblTrailerDetailRow
                    drDetail = Me.dsTKSI1.tblTrailerDetail.FindByLabelID(label)
                    If Not drDetail Is Nothing Then
                        Dim draLocJOIN As TKSIJOBSDataSet.tblLocationLabelJOINRow()
                        draLocJOIN = Me.dsTKSI1.tblLocationLabelJOIN.Select("TrailerLLabelID='" & drDetail.LabelID & "'")
                        If draLocJOIN.Length > 0 Then
                            draLocJOIN(0).Delete()


                            daLBjoin.Update(Me.dsTKSI1.tblLocationLabelJOIN)
                            Me.dsTKSI1.tblLocationLabelJOIN.AcceptChanges()
                        End If
                        Dim drLocJOIN As TKSIJOBSDataSet.tblLocationLabelJOINRow
                        drLocJOIN = Me.dsTKSI1.tblLocationLabelJOIN.NewtblLocationLabelJOINRow
                        With drLocJOIN
                            .Notes = ""
                            .PO = drDetail.tblTrailerHeaderRow.PO
                            .TrailerlLabelID = drDetail.LabelID
                            .LocationNumber = drLoc.LocationNumber
                            .DateEntered = Now
                        End With
                        Me.dsTKSI1.tblLocationLabelJOIN.Rows.Add(drLocJOIN)

                        daLBjoin.Update(Me.dsTKSI1.tblLocationLabelJOIN)
                        Me.dsTKSI1.tblLocationLabelJOIN.AcceptChanges()

                        itemSel.SubItems(2).Text = itemSel.SubItems(2).Text & LocationToShortName(drLoc.LabelID)
                    End If
                End If
            End If
            Me.cmbBinAssign.SelectedItem = Nothing
            Me.cmbBinAssign.Text = ""
        Catch ex As Exception
            Me.Text = "cmbBinAssign_SelectedIndexChanged " & ex.Message
        End Try

    End Sub


    Private Sub daTrailerHeader_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs)

    End Sub
End Class
