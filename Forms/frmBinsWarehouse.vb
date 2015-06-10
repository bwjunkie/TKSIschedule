Imports System.Windows.Forms
Imports System.Drawing

Public Class frmBinsWarehouse
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
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnPrintLabel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocumentBarCodeLabel As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnGenerateBinLabel As System.Windows.Forms.Button
    Friend WithEvents cmbLocPrefix As System.Windows.Forms.ComboBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBinNewNum As System.Windows.Forms.TextBox
    Friend WithEvents c1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents c5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvLabels As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrintLabel = New System.Windows.Forms.Button()
        Me.txtBinNewNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocumentBarCodeLabel = New System.Drawing.Printing.PrintDocument()
        Me.btnGenerateBinLabel = New System.Windows.Forms.Button()
        Me.cmbLocPrefix = New System.Windows.Forms.ComboBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.c5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLabels = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(584, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(216, 32)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh Bins"
        '
        'btnPrintLabel
        '
        Me.btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintLabel.Location = New System.Drawing.Point(592, 160)
        Me.btnPrintLabel.Name = "btnPrintLabel"
        Me.btnPrintLabel.Size = New System.Drawing.Size(200, 32)
        Me.btnPrintLabel.TabIndex = 2
        Me.btnPrintLabel.Text = "Print Bin Label"
        '
        'txtBinNewNum
        '
        Me.txtBinNewNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBinNewNum.Location = New System.Drawing.Point(696, 304)
        Me.txtBinNewNum.Name = "txtBinNewNum"
        Me.txtBinNewNum.Size = New System.Drawing.Size(96, 26)
        Me.txtBinNewNum.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(592, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Bin Prefix"
        '
        'PrintDocumentBarCodeLabel
        '
        '
        'btnGenerateBinLabel
        '
        Me.btnGenerateBinLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerateBinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateBinLabel.Location = New System.Drawing.Point(592, 336)
        Me.btnGenerateBinLabel.Name = "btnGenerateBinLabel"
        Me.btnGenerateBinLabel.Size = New System.Drawing.Size(200, 32)
        Me.btnGenerateBinLabel.TabIndex = 8
        Me.btnGenerateBinLabel.Text = "Generate New Bin Label"
        '
        'cmbLocPrefix
        '
        Me.cmbLocPrefix.Items.AddRange(New Object() {"MISC", "HRDW", "ROW-", "OTHR"})
        Me.cmbLocPrefix.Location = New System.Drawing.Point(696, 280)
        Me.cmbLocPrefix.Name = "cmbLocPrefix"
        Me.cmbLocPrefix.Size = New System.Drawing.Size(96, 21)
        Me.cmbLocPrefix.TabIndex = 6
        Me.cmbLocPrefix.Text = "MISC"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Menu"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Delete Bin"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(592, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Bin # 3 digit"
        '
        'c1
        '
        Me.c1.Text = "id"
        Me.c1.Width = 0
        '
        'c2
        '
        Me.c2.Text = "PO"
        Me.c2.Width = 0
        '
        'c3
        '
        Me.c3.Text = "Bin Label"
        Me.c3.Width = 140
        '
        'c4
        '
        Me.c4.Text = "PO"
        Me.c4.Width = 160
        '
        'c5
        '
        Me.c5.Text = ""
        Me.c5.Width = 160
        '
        'lvLabels
        '
        Me.lvLabels.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c2, Me.c3, Me.c4, Me.c5})
        Me.lvLabels.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLabels.FullRowSelect = True
        Me.lvLabels.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLabels.HideSelection = False
        Me.lvLabels.Location = New System.Drawing.Point(0, 0)
        Me.lvLabels.MultiSelect = False
        Me.lvLabels.Name = "lvLabels"
        Me.lvLabels.Size = New System.Drawing.Size(576, 445)
        Me.lvLabels.TabIndex = 0
        Me.lvLabels.UseCompatibleStateImageBehavior = False
        Me.lvLabels.View = System.Windows.Forms.View.Details
        '
        'frmBinsWarehouse
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLocPrefix)
        Me.Controls.Add(Me.btnGenerateBinLabel)
        Me.Controls.Add(Me.txtBinNewNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintLabel)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lvLabels)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmBinsWarehouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bins / Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim line1 As String = ""
    Dim line2 As String = ""
    Dim line3 As String = ""
    Dim line4BarCode As String = ""
    Dim daLocationBins As New TKSIJOBSDataSetTableAdapters.tblLocationBinsTableAdapter
    Dim daLocationLabelJOIN As New TKSIJOBSDataSetTableAdapters.tblLocationLabelJOINTableAdapter
    Dim daTrailerDetail As New TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
    Dim daTrailerHeader As New TKSIJOBSDataSetTableAdapters.tblTrailerHeaderTableAdapter

    Private dsTKSI1 As New TKSIJOBSDataSet

    Private Sub txtPOSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBinNewNum.TextChanged
        'If Me.txtPOSearch.Text.Trim.Length > 2 Then
        '    Me.daPObysPONum.SelectCommand.Parameters("@sPONum").Value = Me.txtPOSearch.Text.Trim & "%"
        '    Me.DsTKSI1.tPOHeader.Clear()
        '    Me.daPObysPONum.Fill(Me.DsTKSI1.tPOHeader)
        '    PopulateListBox()
        'End If
    End Sub

    Private Sub PopulateListBox()
        Me.lvLabels.Items.Clear()
        Dim item1 As ListViewItem
        Dim drLocBin As TKSIJOBSDataSet.tblLocationBinsRow

        For Each drLocBin In Me.dsTKSI1.tblLocationBins
            item1 = Me.lvLabels.Items.Add(drLocBin.LocationNumber)
            With item1
                .SubItems.Add("")
                .SubItems.Add(drLocBin.LabelID)
                .SubItems.Add("")
                .SubItems.Add("")

                .BackColor = Color.LightBlue
            End With

            Dim strLastPO As String = ""
            Dim strPO As String = ""
            Dim drJOIN As TKSIJOBSDataSet.tblLocationLabelJOINRow
            For Each drJOIN In drLocBin.GettblLocationLabelJOINRows

                strPO = GetPOForLocationJOIN(drJOIN.TrailerlLabelID)
                If strPO = strLastPO Then
                    'dont add this po again
                Else
                    item1 = Me.lvLabels.Items.Add(drLocBin.LocationNumber)
                    With item1
                        .SubItems.Add(drJOIN.TrailerlLabelID)
                        .SubItems.Add("")
                        .SubItems.Add(strPO)
                        .SubItems.Add(drJOIN.Notes)
                        .BackColor = Color.White
                    End With
                    strLastPO = strPO
                End If
            Next
        Next

        If Me.lvLabels.Items.Count > 0 Then
            Me.lvLabels.Items(0).Selected = True
            'Else
            'Me.lvLabels.Items(0).Selected = False
        End If
    End Sub

    Private Function GetPOForLocationJOIN(ByVal strDetailID As String) As String
        Try
            Dim drDet As TKSIJOBSDataSet.tblTrailerDetailRow
            drDet = Me.dsTKSI1.tblTrailerDetail.FindByLabelID(strDetailID)
            If Not drDet Is Nothing Then
                If Not drDet.tblTrailerHeaderRow Is Nothing Then
                    Return drDet.tblTrailerHeaderRow.PO
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            Return "ERROR..."
        End Try

    End Function

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadDefaultFormData()
    End Sub

    Private Sub LoadDefaultFormData()
        Me.dsTKSI1.tblLocationBins.Clear()
        Me.dsTKSI1.tblLocationLabelJOIN.Clear()

        Me.daLocationBins.Fill(Me.dsTKSI1.tblLocationBins)
        Me.daLocationLabelJOIN.Fill(Me.dsTKSI1.tblLocationLabelJOIN)

        Me.dsTKSI1.tblTrailerDetail.Clear()
        Me.daTrailerDetail.Fill(Me.dsTKSI1.tblTrailerDetail)

        Me.dsTKSI1.tblTrailerHeader.Clear()
        Me.daTrailerHeader.Fill(Me.dsTKSI1.tblTrailerHeader)

        PopulateListBox()
    End Sub

    Private Sub frmLabelsHardware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefaultFormData()
    End Sub

    Private Sub btnPrintLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabel.Click
        Try
            If Me.lvLabels.SelectedItems.Count = 1 Then
                If Me.lvLabels.SelectedItems(0).SubItems(1).Text.Trim.Length = 0 Then

                    'make sure they have a bin selected and not an item
                    Dim BINID As String = ""
                    BINID = Me.lvLabels.SelectedItems(0).Text
                    If IsNumeric(BINID) Then
                        Dim drLoc As TKSIJOBSDataSet.tblLocationBinsRow
                        drLoc = Me.dsTKSI1.tblLocationBins.FindByLocationNumber(BINID)
                        If Not drLoc Is Nothing Then
                            Me.PrintLabel(drLoc)
                        End If

                    End If

                Else
                    Windows.Forms.MessageBox.Show("Select the header line to print a bin label.")
                End If
            Else
                Windows.Forms.MessageBox.Show("Select a Bin to print label.")
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    'Private Sub CreateShippingTrailerRecords(ByVal drPO As tksijobsdataset.tPOHeaderRow, ByVal damageNotes As String, ByVal blnIncomplete As Boolean)

    '    Me.DsTKSI1.tblTrailerHeader.Clear()
    '    Me.daTrailerHeader.SelectCommand.Parameters("@PO").Value = drPO.sPONum
    '    Me.daTrailerHeader.Fill(Me.DsTKSI1.tblTrailerHeader)

    '    If Me.DsTKSI1.tblTrailerHeader.Rows.Count = 0 Then
    '        'there is NO shipping lines at all, so create one with receive date of today
    '        'and print lablel
    '        Dim drD As tksijobsdataset.tblTrailerDetailRow
    '        drD = CreateNewShippingTrailerInfo(drPO, damageNotes)
    '        PrintLabel(drD, drPO)

    '    Else
    '        If Windows.Forms.MessageBox.Show("Is this a additional item/box for this PO?", "2nd box?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Dim drD As tksijobsdataset.tblTrailerDetailRow
    '            drD = CreateNewShippingTrailerInfo(drPO, damageNotes, True)
    '            PrintLabel(drD, drPO)
    '        Else
    '            'already has trailer rows, just reprint label
    '            Dim drTH As tksijobsdataset.tblTrailerHeaderRow
    '            drTH = Me.DsTKSI1.tblTrailerHeader(0)

    '            Me.DsTKSI1.tblTrailerDetail.Clear()
    '            Me.daTrailerDetail.SelectCommand.Parameters("@PO").Value = drTH.PO
    '            Me.daTrailerDetail.Fill(Me.DsTKSI1.tblTrailerDetail)
    '            If Me.DsTKSI1.tblTrailerDetail.Rows.Count > 0 Then
    '                PrintLabel(Me.DsTKSI1.tblTrailerDetail(0), drPO)
    '                If Me.txtDamageNotes.Text.Trim.Length > 0 Then
    '                    Windows.Forms.MessageBox.Show("This shipping record has alredy been created, use the shipping screen to create damage notes.")
    '                End If
    '            Else
    '                drTH.Delete()
    '                Me.daTrailerHeader.Update(Me.DsTKSI1.tblTrailerHeader)
    '                Me.DsTKSI1.tblTrailerHeader.AcceptChanges()
    '                Windows.Forms.MessageBox.Show("Old label data had to be cleaned up, please try again...")
    '                'Windows.Forms.MessageBox.Show("Could not locate shipping item to print.")
    '            End If
    '        End If

    '    End If

    '    Try
    '        If blnIncomplete Then
    '            drPO.sBackOrder = "Yes"
    '        End If
    '        If drPO.IsDRECNull Then
    '            drPO.DREC = Today.Date
    '        End If
    '        Me.daPO.Update(Me.DsTKSI1.tPOHeader)
    '        Me.DsTKSI1.tPOHeader.AcceptChanges()
    '    Catch ex As Exception
    '        Throw New Exception("Erro updating PO information with date received.")
    '    End Try

    '    Me.txtDamageNotes.Text = ""
    '    'set incomplete checkbox back to unchecked
    '    Me.chkIncomplete.Checked = False
    'End Sub

    'Private Function CreateNewShippingTrailerInfo(ByVal drPO As tksijobsdataset.tPOHeaderRow, ByVal damagenotes As String, Optional ByVal blnSecondDetailLineOnSameHeader As Boolean = False) As tksijobsdataset.tblTrailerDetailRow
    '    'create all new trailer and shipping item rows 
    '    Dim tempSupplierSO As Long = 0
    '    tempSupplierSO = "99" & drPO.nID
    '    Dim tempPalletNum As String = ""
    '    tempPalletNum = drPO.sPONum & drPO.nID

    '    If Not blnSecondDetailLineOnSameHeader Then
    '        'first record or new record for new header
    '        Dim drH As tksijobsdataset.tblTrailerHeaderRow
    '        drH = Me.DsTKSI1.tblTrailerHeader.NewtblTrailerHeaderRow
    '        With drH
    '            .PalletNum = tempPalletNum
    '            .SO = tempSupplierSO
    '            .PO = drPO.sPONum
    '            .ShipDate = Today.Date
    '            .TrailerControl = 0
    '            .FreightTermsCode = drPO.sVia
    '            .FreightCode = drPO.sShipto3
    '            .ShipType = 0
    '            .TrailerNumber = drPO.sVia
    '        End With
    '        Me.DsTKSI1.tblTrailerHeader.Rows.Add(drH)
    '    End If

    '    'trailer detail
    '    Dim drD As tksijobsdataset.tblTrailerDetailRow
    '    'create new label id row
    '    drD = Me.DsTKSI1.tblTrailerDetail.NewtblTrailerDetailRow
    '    With drD
    '        .ShipNum = tempPalletNum
    '        .OrderLineNumber = 1
    '        .ShippedQuantity = 1
    '        .LoadedDate = Date.Today
    '        .LabelID = drPO.sPONum & "-" & Now.Hour & Now.Millisecond

    '        .DateScannedTKSI = Now
    '        Try
    '            If damagenotes.Trim.Length > 0 Then
    '                .DamageNotes = damagenotes
    '            Else
    '                .DamageNotes = ""
    '            End If
    '        Catch ex As Exception
    '            .DamageNotes = ""
    '        End Try

    '        Try
    '            .DetailDescription = drPO.sItemDesc
    '            .Other = ""
    '        Catch ex As Exception
    '            .Other = ""
    '            .DetailDescription = "Misc..."
    '        End Try
    '        'all other leave default NULL
    '    End With
    '    Me.DsTKSI1.tblTrailerDetail.Rows.Add(drD)

    '    If Not blnSecondDetailLineOnSameHeader Then
    '        Dim drSH As tksijobsdataset.tblShippingHeaderRow
    '        drSH = Me.DsTKSI1.tblShippingHeader.NewtblShippingHeaderRow
    '        With drSH
    '            .SupplierSONum = tempSupplierSO
    '            .PO = drPO.sPONum
    '            .SupplierCode = "HDWR"
    '            .StyleCode = drPO.sItemDesc
    '            .StyleDesc = drPO.sItemDesc
    '            .TotalCabs = 0
    '            .OrderLines = 1
    '            .OrderStatus = 0
    '            .DateClosed = Date.Today
    '            .DateImported = Now
    '            .DateCompletion = Now
    '            .DateCompletion = Date.Today

    '        End With
    '        Me.DsTKSI1.tblShippingHeader.Rows.Add(drSH)

    '        'shipping detail item
    '        Dim drSD As tksijobsdataset.tblShippingItemsRow
    '        'create new label id row
    '        drSD = Me.DsTKSI1.tblShippingItems.NewtblShippingItemsRow
    '        With drSD
    '            .CabType = ""
    '            .ColorCode = ""
    '            .ColorDesc = ""
    '            .SetDateDeliveredNull()
    '            .DateReceived = Now
    '            .SpecialNote1 = ""
    '            .SpecialNote2 = ""
    '            .StyleCode = ""
    '            .StyleDesc = drPO.sItemDesc
    '            .SupplierSO = tempSupplierSO
    '            .LineNumber = 1
    '            .ProdCode = ""
    '            .ProdDesc = drPO.sItemDesc
    '            .Quantity = 1
    '            .QuantityDel = 0
    '            .QuantityRec = 1
    '            .DateImported = Now
    '            .DateLastChanged = Now
    '        End With
    '        Me.DsTKSI1.tblShippingItems.Rows.Add(drSD)
    '    End If

    '    If Not blnSecondDetailLineOnSameHeader Then
    '        Me.daTrailerHeader.Update(Me.DsTKSI1.tblTrailerHeader)
    '        Me.DsTKSI1.tblTrailerHeader.AcceptChanges()
    '    End If

    '    Me.daTrailerDetail.Update(Me.DsTKSI1.tblTrailerDetail)
    '    Me.DsTKSI1.tblTrailerDetail.AcceptChanges()

    '    If Not blnSecondDetailLineOnSameHeader Then
    '        Me.daShippingHeader.Update(Me.DsTKSI1.tblShippingHeader)
    '        Me.DsTKSI1.tblShippingHeader.AcceptChanges()

    '        Me.daShippingItems.Update(Me.DsTKSI1.tblShippingItems)
    '        Me.DsTKSI1.tblShippingItems.AcceptChanges()
    '    End If

    '    'return back trailer detail row
    '    Return drD
    'End Function


    Private Sub PrintLabel(ByVal drLoc As TKSIJOBSDataSet.tblLocationBinsRow)
        line4BarCode = drLoc.LabelID
        line3 = drLoc.LocationPrefix & " " & drLoc.LocationNumber

        With Me.PrintDocumentBarCodeLabel

            .DocumentName = "Shipping Label"

            .PrinterSettings.PrinterName = "\\Mark-PC\ZebraLP2office"

            .PrinterSettings.DefaultPageSettings.Margins.Left = 20
            .PrinterSettings.DefaultPageSettings.Margins.Right = 20
            .PrinterSettings.DefaultPageSettings.Margins.Top = 20
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 20

        End With
        Me.PrintDocumentBarCodeLabel.Print()
    End Sub

    Private Function DrawLabelGraphics(ByVal g As Graphics) As Boolean

        'If Me.chkOversizeLabe.Checked Then
        '    g.DrawString(Me.line3, New Font("Arial", "92", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 20, 20)
        '    g.DrawString("*" & Me.line4BarCode & "*", New Font("Bar Code 39 d", "92", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 20, 260)

        'Else
        g.DrawString(Me.line3, New Font("Arial", "28", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 20, 20)
        g.DrawString("*" & Me.line4BarCode & "*", New Font("Bar Code 39 d", "28", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 20, 60)
        'End If

        'g.DrawString(Me.line2, New Font("Arial", "14", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 26)
        'g.DrawString(Me.line3, New Font("Arial", "14", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 51)
        'g.DrawString("*" & Me.line4BarCode & "*", New Font("Bar Code 39 d", "16", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 76)
        'g.DrawString("*" & Me.line4BarCode & "*", New Font("Arial", "10", FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, 106)

        Return False
    End Function

    Private Sub PrintDocumentBarCodeLabel_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentBarCodeLabel.PrintPage
        e.HasMorePages = Me.DrawLabelGraphics(e.Graphics)
    End Sub



    Private Sub btnGenerateBinLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateBinLabel.Click
        Try
            If Me.cmbLocPrefix.Text.Trim.Length > 0 Then
                If IsNumeric(Me.txtBinNewNum.Text.Trim) Then
                    Dim drLoc As TKSIJOBSDataSet.tblLocationBinsRow
                    drLoc = Me.dsTKSI1.tblLocationBins.NewtblLocationBinsRow
                    With drLoc
                        .LocationNumber = Me.txtBinNewNum.Text.Trim
                        .LocationPrefix = Me.cmbLocPrefix.Text.Trim
                        .LabelID = .LocationPrefix & .LocationNumber
                        .DateModified = Now
                        .Description = ""
                    End With
                    Me.dsTKSI1.tblLocationBins.Rows.Add(drLoc)
                    Me.daLocationBins.Update(Me.dsTKSI1.tblLocationBins)
                    Me.dsTKSI1.tblLocationBins.AcceptChanges()

                    Me.PrintLabel(drLoc)

                    Me.PopulateListBox()
                Else
                    Windows.Forms.MessageBox.Show("Bin # must be a number only, no letters.")
                End If

            Else
                Windows.Forms.MessageBox.Show("Choose a label type first... ex. 'ROW-' 'HRDW'")
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GetNextLocationNumber() As Decimal
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("select max(locationnumber) from tbllocationbins", New System.Data.SqlClient.SqlConnection(cnSQL))
            Dim iResult As Integer = -1
            Try
                cmd.Connection.Open()
            Catch
            End Try

            iResult = cmd.ExecuteScalar
            Try
                cmd.Connection.Close()
            Catch
            End Try

            Return iResult + 1
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("GetNextLocationNumber " & ex.Message)
            Return 99
        End Try

    End Function

    Private Sub DeleteBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            If Me.lvLabels.SelectedItems.Count = 1 Then
                If Me.lvLabels.SelectedItems(0).SubItems(1).Text.Trim.Length = 0 Then

                    'make sure they have a bin selected and not an item
                    Dim BINID As String = ""
                    BINID = Me.lvLabels.SelectedItems(0).Text
                    If IsNumeric(BINID) Then
                        Dim drLoc As TKSIJOBSDataSet.tblLocationBinsRow
                        drLoc = Me.dsTKSI1.tblLocationBins.FindByLocationNumber(BINID)
                        drLoc.Delete()
                        Me.daLocationBins.Update(Me.dsTKSI1.tblLocationBins)
                        Me.dsTKSI1.tblLocationBins.AcceptChanges()
                        Me.PopulateListBox()

                    End If

                Else
                    Windows.Forms.MessageBox.Show("Select the header line to remove.")
                End If
            Else
                Windows.Forms.MessageBox.Show("Select a Bin.")
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
