<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSWOParts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblManufacture = New System.Windows.Forms.Label
        Me.lblPO = New System.Windows.Forms.Label
        Me.lblShipVia = New System.Windows.Forms.Label
        Me.lblShipWeekOf = New System.Windows.Forms.Label
        Me.lblOrderDate = New System.Windows.Forms.Label
        Me.lblSales = New System.Windows.Forms.Label
        Me.lblTerms = New System.Windows.Forms.Label
        Me.lblSalesTax = New System.Windows.Forms.Label
        Me.ContextMenuManufacture = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripCrestwood = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripKitchenCraft = New System.Windows.Forms.ToolStripMenuItem
        Me.txtSalesTax = New System.Windows.Forms.TextBox
        Me.txtOrderDate = New System.Windows.Forms.TextBox
        Me.txtShipWeek = New System.Windows.Forms.TextBox
        Me.txtShipVia = New System.Windows.Forms.TextBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.txtTitletksi = New System.Windows.Forms.TextBox
        Me.lblBillTo = New System.Windows.Forms.Label
        Me.lblShipTo = New System.Windows.Forms.Label
        Me.txtBillTo = New System.Windows.Forms.TextBox
        Me.txtShipto = New System.Windows.Forms.TextBox
        Me.lblCompletionDate = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblMapleMelIntDoveDwr = New System.Windows.Forms.Label
        Me.lblLaminate = New System.Windows.Forms.Label
        Me.lblDoorStyleWall = New System.Windows.Forms.Label
        Me.lblFinishMod = New System.Windows.Forms.Label
        Me.lblWood = New System.Windows.Forms.Label
        Me.lblHinge = New System.Windows.Forms.Label
        Me.lblDoorStyleBase = New System.Windows.Forms.Label
        Me.chkMapleMelamIntDwr = New System.Windows.Forms.CheckBox
        Me.chkWoodDoveDwr = New System.Windows.Forms.CheckBox
        Me.chkMapleMelDoveDwr = New System.Windows.Forms.CheckBox
        Me.chkWhiteMelInt = New System.Windows.Forms.CheckBox
        Me.txtTitleOrder = New System.Windows.Forms.TextBox
        Me.cmbManufacture = New System.Windows.Forms.ComboBox
        Me.cmbSales = New System.Windows.Forms.ComboBox
        Me.lblRetailFactor = New System.Windows.Forms.Label
        Me.txtRetailFactor = New System.Windows.Forms.TextBox
        Me.txtRetailShipping = New System.Windows.Forms.TextBox
        Me.lblRetailShip = New System.Windows.Forms.Label
        Me.lblRetailTotal = New System.Windows.Forms.Label
        Me.txtRetailTotal = New System.Windows.Forms.TextBox
        Me.txtCostTotal = New System.Windows.Forms.TextBox
        Me.lblCostTotal = New System.Windows.Forms.Label
        Me.txtCostShipping = New System.Windows.Forms.TextBox
        Me.txtCostFactor = New System.Windows.Forms.TextBox
        Me.lblCostFactor = New System.Windows.Forms.Label
        Me.lblCostShip = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.TblSWOOrderDetailDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblSWOOrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TksijobsDataSet1 = New TKSISchedule.TKSIJOBSDataSet
        Me.txtTAX = New System.Windows.Forms.TextBox
        Me.txtADD = New System.Windows.Forms.TextBox
        Me.lblAdd = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.txtTerms = New System.Windows.Forms.ComboBox
        Me.txtDoorStyleWall = New System.Windows.Forms.TextBox
        Me.txtDoorStyleBase = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtHinge = New System.Windows.Forms.TextBox
        Me.txtWood = New System.Windows.Forms.TextBox
        Me.txtLaminate = New System.Windows.Forms.TextBox
        Me.txtFinishMod = New System.Windows.Forms.TextBox
        Me.txtCompletionDate = New System.Windows.Forms.TextBox
        Me.lblSDANo = New System.Windows.Forms.Label
        Me.txtSDA = New System.Windows.Forms.TextBox
        Me.txtJobContact = New System.Windows.Forms.TextBox
        Me.lblJobContact = New System.Windows.Forms.Label
        Me.TblSWOPendingTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOPendingTableAdapter
        Me.TVendorTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter
        Me.TEmployeeTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tEmployeeTableAdapter
        Me.TblSWOOrderDetailTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOOrderDetailTableAdapter
        Me.TJobTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter
        Me.TblSWOOrderTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOOrderTableAdapter
        Me.btnPrintPartsForm = New System.Windows.Forms.Button
        Me.txtUpcharge1 = New System.Windows.Forms.TextBox
        Me.lblUpcharge1 = New System.Windows.Forms.Label
        Me.ContextMenuStripUpcharge = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.txtUpcharge2 = New System.Windows.Forms.TextBox
        Me.lblUpcharge2 = New System.Windows.Forms.Label
        Me.ContextMenuStripUpcharge2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.txtUpcharge3 = New System.Windows.Forms.TextBox
        Me.lblUpcharge3 = New System.Windows.Forms.Label
        Me.ContextMenuStripUpcharge3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContextMenuManufacture.SuspendLayout()
        CType(Me.TblSWOOrderDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSWOOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripUpcharge.SuspendLayout()
        Me.ContextMenuStripUpcharge2.SuspendLayout()
        Me.ContextMenuStripUpcharge3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblManufacture
        '
        Me.lblManufacture.AutoSize = True
        Me.lblManufacture.BackColor = System.Drawing.Color.Lavender
        Me.lblManufacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblManufacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacture.Location = New System.Drawing.Point(276, 48)
        Me.lblManufacture.Name = "lblManufacture"
        Me.lblManufacture.Padding = New System.Windows.Forms.Padding(0, 0, 213, 25)
        Me.lblManufacture.Size = New System.Drawing.Size(288, 39)
        Me.lblManufacture.TabIndex = 28
        Me.lblManufacture.Text = "Manufacturer"
        '
        'lblPO
        '
        Me.lblPO.BackColor = System.Drawing.Color.Lavender
        Me.lblPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPO.Location = New System.Drawing.Point(567, 48)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Padding = New System.Windows.Forms.Padding(0, 0, 130, 25)
        Me.lblPO.Size = New System.Drawing.Size(299, 39)
        Me.lblPO.TabIndex = 57
        Me.lblPO.Text = "PO #"
        '
        'lblShipVia
        '
        Me.lblShipVia.AutoSize = True
        Me.lblShipVia.BackColor = System.Drawing.Color.Lavender
        Me.lblShipVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipVia.Location = New System.Drawing.Point(730, 89)
        Me.lblShipVia.Name = "lblShipVia"
        Me.lblShipVia.Padding = New System.Windows.Forms.Padding(0, 0, 81, 25)
        Me.lblShipVia.Size = New System.Drawing.Size(136, 39)
        Me.lblShipVia.TabIndex = 60
        Me.lblShipVia.Text = "Ship Via  "
        '
        'lblShipWeekOf
        '
        Me.lblShipWeekOf.AutoSize = True
        Me.lblShipWeekOf.BackColor = System.Drawing.Color.Lavender
        Me.lblShipWeekOf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipWeekOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipWeekOf.Location = New System.Drawing.Point(567, 89)
        Me.lblShipWeekOf.Name = "lblShipWeekOf"
        Me.lblShipWeekOf.Padding = New System.Windows.Forms.Padding(0, 0, 86, 25)
        Me.lblShipWeekOf.Size = New System.Drawing.Size(161, 39)
        Me.lblShipWeekOf.TabIndex = 59
        Me.lblShipWeekOf.Text = "Ship Week Of"
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.BackColor = System.Drawing.Color.Lavender
        Me.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDate.Location = New System.Drawing.Point(428, 89)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Padding = New System.Windows.Forms.Padding(0, 0, 74, 25)
        Me.lblOrderDate.Size = New System.Drawing.Size(136, 39)
        Me.lblOrderDate.TabIndex = 62
        Me.lblOrderDate.Text = "Order Date"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.BackColor = System.Drawing.Color.Lavender
        Me.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(276, 89)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Padding = New System.Windows.Forms.Padding(0, 0, 81, 25)
        Me.lblSales.Size = New System.Drawing.Size(150, 39)
        Me.lblSales.TabIndex = 61
        Me.lblSales.Text = "Salesperson"
        '
        'lblTerms
        '
        Me.lblTerms.BackColor = System.Drawing.Color.Lavender
        Me.lblTerms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms.Location = New System.Drawing.Point(567, 130)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(300, 39)
        Me.lblTerms.TabIndex = 65
        Me.lblTerms.Text = "Terms for TKSI Customers"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.BackColor = System.Drawing.Color.Lavender
        Me.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTax.Location = New System.Drawing.Point(276, 130)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(150, 39)
        Me.lblSalesTax.TabIndex = 64
        Me.lblSalesTax.Text = "Sales Tax Rate"
        '
        'ContextMenuManufacture
        '
        Me.ContextMenuManufacture.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripCrestwood, Me.ToolStripKitchenCraft})
        Me.ContextMenuManufacture.Name = "ContextMenuManufacture"
        Me.ContextMenuManufacture.Size = New System.Drawing.Size(163, 48)
        '
        'ToolStripCrestwood
        '
        Me.ToolStripCrestwood.Name = "ToolStripCrestwood"
        Me.ToolStripCrestwood.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripCrestwood.Text = "Crestwood"
        '
        'ToolStripKitchenCraft
        '
        Me.ToolStripKitchenCraft.Name = "ToolStripKitchenCraft"
        Me.ToolStripKitchenCraft.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripKitchenCraft.Text = "Kitchen Craft"
        '
        'txtSalesTax
        '
        Me.txtSalesTax.BackColor = System.Drawing.Color.White
        Me.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSalesTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesTax.Location = New System.Drawing.Point(295, 146)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.Size = New System.Drawing.Size(111, 19)
        Me.txtSalesTax.TabIndex = 6
        '
        'txtOrderDate
        '
        Me.txtOrderDate.BackColor = System.Drawing.Color.White
        Me.txtOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderDate.Location = New System.Drawing.Point(444, 105)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.Size = New System.Drawing.Size(108, 15)
        Me.txtOrderDate.TabIndex = 3
        Me.txtOrderDate.TabStop = False
        '
        'txtShipWeek
        '
        Me.txtShipWeek.BackColor = System.Drawing.Color.White
        Me.txtShipWeek.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShipWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipWeek.Location = New System.Drawing.Point(584, 105)
        Me.txtShipWeek.Name = "txtShipWeek"
        Me.txtShipWeek.Size = New System.Drawing.Size(128, 15)
        Me.txtShipWeek.TabIndex = 4
        '
        'txtShipVia
        '
        Me.txtShipVia.BackColor = System.Drawing.Color.White
        Me.txtShipVia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShipVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipVia.Location = New System.Drawing.Point(738, 105)
        Me.txtShipVia.Name = "txtShipVia"
        Me.txtShipVia.Size = New System.Drawing.Size(116, 15)
        Me.txtShipVia.TabIndex = 5
        '
        'txtPO
        '
        Me.txtPO.BackColor = System.Drawing.Color.Lavender
        Me.txtPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPO.Enabled = False
        Me.txtPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.Location = New System.Drawing.Point(584, 61)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(247, 15)
        Me.txtPO.TabIndex = 1
        Me.txtPO.TabStop = False
        '
        'txtTitletksi
        '
        Me.txtTitletksi.BackColor = System.Drawing.Color.White
        Me.txtTitletksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitletksi.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitletksi.Location = New System.Drawing.Point(14, 21)
        Me.txtTitletksi.Multiline = True
        Me.txtTitletksi.Name = "txtTitletksi"
        Me.txtTitletksi.Size = New System.Drawing.Size(247, 148)
        Me.txtTitletksi.TabIndex = 76
        Me.txtTitletksi.TabStop = False
        Me.txtTitletksi.Text = "The Kitchen Showcase, Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6528 South Racine Circle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centennial, CO 80111" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(303)" & _
            " 799-9200" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAX (303) 799-1234" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "www.thekitchenshowcase.com"
        '
        'lblBillTo
        '
        Me.lblBillTo.AutoSize = True
        Me.lblBillTo.BackColor = System.Drawing.Color.Lavender
        Me.lblBillTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBillTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillTo.Location = New System.Drawing.Point(12, 176)
        Me.lblBillTo.Name = "lblBillTo"
        Me.lblBillTo.Padding = New System.Windows.Forms.Padding(0, 0, 363, 80)
        Me.lblBillTo.Size = New System.Drawing.Size(414, 94)
        Me.lblBillTo.TabIndex = 77
        Me.lblBillTo.Text = "BILL TO:"
        '
        'lblShipTo
        '
        Me.lblShipTo.AutoSize = True
        Me.lblShipTo.BackColor = System.Drawing.Color.Lavender
        Me.lblShipTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipTo.Location = New System.Drawing.Point(428, 176)
        Me.lblShipTo.Name = "lblShipTo"
        Me.lblShipTo.Padding = New System.Windows.Forms.Padding(0, 0, 385, 80)
        Me.lblShipTo.Size = New System.Drawing.Size(439, 94)
        Me.lblShipTo.TabIndex = 78
        Me.lblShipTo.Text = "SHIP TO:"
        '
        'txtBillTo
        '
        Me.txtBillTo.BackColor = System.Drawing.Color.Lavender
        Me.txtBillTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBillTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillTo.Location = New System.Drawing.Point(32, 194)
        Me.txtBillTo.Multiline = True
        Me.txtBillTo.Name = "txtBillTo"
        Me.txtBillTo.Size = New System.Drawing.Size(382, 61)
        Me.txtBillTo.TabIndex = 8
        Me.txtBillTo.TabStop = False
        '
        'txtShipto
        '
        Me.txtShipto.BackColor = System.Drawing.Color.Lavender
        Me.txtShipto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShipto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipto.Location = New System.Drawing.Point(452, 194)
        Me.txtShipto.Multiline = True
        Me.txtShipto.Name = "txtShipto"
        Me.txtShipto.Size = New System.Drawing.Size(402, 61)
        Me.txtShipto.TabIndex = 9
        Me.txtShipto.TabStop = False
        '
        'lblCompletionDate
        '
        Me.lblCompletionDate.BackColor = System.Drawing.Color.Lavender
        Me.lblCompletionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompletionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletionDate.Location = New System.Drawing.Point(12, 360)
        Me.lblCompletionDate.Name = "lblCompletionDate"
        Me.lblCompletionDate.Size = New System.Drawing.Size(190, 39)
        Me.lblCompletionDate.TabIndex = 91
        Me.lblCompletionDate.Text = "Completion Date"
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Lavender
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(204, 360)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(222, 39)
        Me.lblDescription.TabIndex = 90
        Me.lblDescription.Text = "Description"
        '
        'lblMapleMelIntDoveDwr
        '
        Me.lblMapleMelIntDoveDwr.BackColor = System.Drawing.Color.Lavender
        Me.lblMapleMelIntDoveDwr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMapleMelIntDoveDwr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMapleMelIntDoveDwr.Location = New System.Drawing.Point(567, 319)
        Me.lblMapleMelIntDoveDwr.Name = "lblMapleMelIntDoveDwr"
        Me.lblMapleMelIntDoveDwr.Size = New System.Drawing.Size(300, 80)
        Me.lblMapleMelIntDoveDwr.TabIndex = 23
        Me.lblMapleMelIntDoveDwr.Text = "       Maple Melamine Interior w/Wood Dwr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       White Melamine Interior" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      " & _
            " Maple Melamine Interior w/Mel Dwr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Wood Dovetail Soft Close Drawers"
        '
        'lblLaminate
        '
        Me.lblLaminate.BackColor = System.Drawing.Color.Lavender
        Me.lblLaminate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLaminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaminate.Location = New System.Drawing.Point(730, 278)
        Me.lblLaminate.Name = "lblLaminate"
        Me.lblLaminate.Size = New System.Drawing.Size(137, 39)
        Me.lblLaminate.TabIndex = 84
        Me.lblLaminate.Text = "Laminate"
        '
        'lblDoorStyleWall
        '
        Me.lblDoorStyleWall.BackColor = System.Drawing.Color.Lavender
        Me.lblDoorStyleWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDoorStyleWall.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorStyleWall.Location = New System.Drawing.Point(12, 278)
        Me.lblDoorStyleWall.Name = "lblDoorStyleWall"
        Me.lblDoorStyleWall.Size = New System.Drawing.Size(414, 39)
        Me.lblDoorStyleWall.TabIndex = 82
        Me.lblDoorStyleWall.Text = "Door Style-Wall"
        '
        'lblFinishMod
        '
        Me.lblFinishMod.BackColor = System.Drawing.Color.Lavender
        Me.lblFinishMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinishMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishMod.Location = New System.Drawing.Point(567, 278)
        Me.lblFinishMod.Name = "lblFinishMod"
        Me.lblFinishMod.Size = New System.Drawing.Size(161, 39)
        Me.lblFinishMod.TabIndex = 12
        Me.lblFinishMod.Text = "Finish"
        '
        'lblWood
        '
        Me.lblWood.BackColor = System.Drawing.Color.Lavender
        Me.lblWood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWood.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWood.Location = New System.Drawing.Point(428, 278)
        Me.lblWood.Name = "lblWood"
        Me.lblWood.Size = New System.Drawing.Size(136, 39)
        Me.lblWood.TabIndex = 103
        Me.lblWood.Text = "Wood"
        '
        'lblHinge
        '
        Me.lblHinge.BackColor = System.Drawing.Color.Lavender
        Me.lblHinge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHinge.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHinge.Location = New System.Drawing.Point(428, 319)
        Me.lblHinge.Name = "lblHinge"
        Me.lblHinge.Size = New System.Drawing.Size(136, 39)
        Me.lblHinge.TabIndex = 104
        Me.lblHinge.Text = "Hinge"
        '
        'lblDoorStyleBase
        '
        Me.lblDoorStyleBase.BackColor = System.Drawing.Color.Lavender
        Me.lblDoorStyleBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDoorStyleBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoorStyleBase.Location = New System.Drawing.Point(12, 319)
        Me.lblDoorStyleBase.Name = "lblDoorStyleBase"
        Me.lblDoorStyleBase.Size = New System.Drawing.Size(414, 39)
        Me.lblDoorStyleBase.TabIndex = 108
        Me.lblDoorStyleBase.Text = "Door Style-Base"
        '
        'chkMapleMelamIntDwr
        '
        Me.chkMapleMelamIntDwr.AutoSize = True
        Me.chkMapleMelamIntDwr.BackColor = System.Drawing.Color.Lavender
        Me.chkMapleMelamIntDwr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMapleMelamIntDwr.Location = New System.Drawing.Point(581, 352)
        Me.chkMapleMelamIntDwr.Name = "chkMapleMelamIntDwr"
        Me.chkMapleMelamIntDwr.Size = New System.Drawing.Size(15, 14)
        Me.chkMapleMelamIntDwr.TabIndex = 27
        Me.chkMapleMelamIntDwr.TabStop = False
        Me.chkMapleMelamIntDwr.UseVisualStyleBackColor = False
        '
        'chkWoodDoveDwr
        '
        Me.chkWoodDoveDwr.AutoSize = True
        Me.chkWoodDoveDwr.BackColor = System.Drawing.Color.Lavender
        Me.chkWoodDoveDwr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWoodDoveDwr.Location = New System.Drawing.Point(581, 368)
        Me.chkWoodDoveDwr.Name = "chkWoodDoveDwr"
        Me.chkWoodDoveDwr.Size = New System.Drawing.Size(15, 14)
        Me.chkWoodDoveDwr.TabIndex = 24
        Me.chkWoodDoveDwr.TabStop = False
        Me.chkWoodDoveDwr.UseVisualStyleBackColor = False
        '
        'chkMapleMelDoveDwr
        '
        Me.chkMapleMelDoveDwr.AutoSize = True
        Me.chkMapleMelDoveDwr.BackColor = System.Drawing.Color.Lavender
        Me.chkMapleMelDoveDwr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMapleMelDoveDwr.Location = New System.Drawing.Point(581, 322)
        Me.chkMapleMelDoveDwr.Name = "chkMapleMelDoveDwr"
        Me.chkMapleMelDoveDwr.Size = New System.Drawing.Size(15, 14)
        Me.chkMapleMelDoveDwr.TabIndex = 23
        Me.chkMapleMelDoveDwr.TabStop = False
        Me.chkMapleMelDoveDwr.UseVisualStyleBackColor = False
        '
        'chkWhiteMelInt
        '
        Me.chkWhiteMelInt.AutoSize = True
        Me.chkWhiteMelInt.BackColor = System.Drawing.Color.Lavender
        Me.chkWhiteMelInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWhiteMelInt.Location = New System.Drawing.Point(581, 337)
        Me.chkWhiteMelInt.Name = "chkWhiteMelInt"
        Me.chkWhiteMelInt.Size = New System.Drawing.Size(15, 14)
        Me.chkWhiteMelInt.TabIndex = 26
        Me.chkWhiteMelInt.TabStop = False
        Me.chkWhiteMelInt.UseVisualStyleBackColor = False
        '
        'txtTitleOrder
        '
        Me.txtTitleOrder.BackColor = System.Drawing.Color.White
        Me.txtTitleOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitleOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleOrder.Location = New System.Drawing.Point(367, 5)
        Me.txtTitleOrder.Multiline = True
        Me.txtTitleOrder.Name = "txtTitleOrder"
        Me.txtTitleOrder.Size = New System.Drawing.Size(199, 40)
        Me.txtTitleOrder.TabIndex = 115
        Me.txtTitleOrder.TabStop = False
        Me.txtTitleOrder.Text = "ORDER FORM"
        '
        'cmbManufacture
        '
        Me.cmbManufacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbManufacture.FormattingEnabled = True
        Me.cmbManufacture.Location = New System.Drawing.Point(293, 61)
        Me.cmbManufacture.Name = "cmbManufacture"
        Me.cmbManufacture.Size = New System.Drawing.Size(262, 24)
        Me.cmbManufacture.TabIndex = 0
        '
        'cmbSales
        '
        Me.cmbSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSales.FormattingEnabled = True
        Me.cmbSales.Location = New System.Drawing.Point(292, 102)
        Me.cmbSales.Name = "cmbSales"
        Me.cmbSales.Size = New System.Drawing.Size(122, 24)
        Me.cmbSales.TabIndex = 2
        '
        'lblRetailFactor
        '
        Me.lblRetailFactor.BackColor = System.Drawing.Color.Lavender
        Me.lblRetailFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetailFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetailFactor.Location = New System.Drawing.Point(467, 650)
        Me.lblRetailFactor.Name = "lblRetailFactor"
        Me.lblRetailFactor.Size = New System.Drawing.Size(139, 23)
        Me.lblRetailFactor.TabIndex = 118
        Me.lblRetailFactor.Text = "FCTR"
        '
        'txtRetailFactor
        '
        Me.txtRetailFactor.BackColor = System.Drawing.Color.Lavender
        Me.txtRetailFactor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRetailFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailFactor.Location = New System.Drawing.Point(500, 652)
        Me.txtRetailFactor.Name = "txtRetailFactor"
        Me.txtRetailFactor.Size = New System.Drawing.Size(104, 19)
        Me.txtRetailFactor.TabIndex = 29
        Me.txtRetailFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetailShipping
        '
        Me.txtRetailShipping.BackColor = System.Drawing.Color.Lavender
        Me.txtRetailShipping.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRetailShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailShipping.Location = New System.Drawing.Point(512, 678)
        Me.txtRetailShipping.Name = "txtRetailShipping"
        Me.txtRetailShipping.Size = New System.Drawing.Size(91, 19)
        Me.txtRetailShipping.TabIndex = 30
        Me.txtRetailShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRetailShip
        '
        Me.lblRetailShip.BackColor = System.Drawing.Color.Lavender
        Me.lblRetailShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetailShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetailShip.Location = New System.Drawing.Point(467, 676)
        Me.lblRetailShip.Name = "lblRetailShip"
        Me.lblRetailShip.Size = New System.Drawing.Size(139, 23)
        Me.lblRetailShip.TabIndex = 122
        Me.lblRetailShip.Text = "Shipping"
        '
        'lblRetailTotal
        '
        Me.lblRetailTotal.BackColor = System.Drawing.Color.Lavender
        Me.lblRetailTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetailTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetailTotal.Location = New System.Drawing.Point(622, 701)
        Me.lblRetailTotal.Name = "lblRetailTotal"
        Me.lblRetailTotal.Size = New System.Drawing.Size(139, 23)
        Me.lblRetailTotal.TabIndex = 123
        Me.lblRetailTotal.Text = "Total"
        '
        'txtRetailTotal
        '
        Me.txtRetailTotal.BackColor = System.Drawing.Color.Lavender
        Me.txtRetailTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRetailTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailTotal.Location = New System.Drawing.Point(657, 704)
        Me.txtRetailTotal.Name = "txtRetailTotal"
        Me.txtRetailTotal.ReadOnly = True
        Me.txtRetailTotal.Size = New System.Drawing.Size(103, 19)
        Me.txtRetailTotal.TabIndex = 33
        Me.txtRetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostTotal
        '
        Me.txtCostTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCostTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostTotal.Location = New System.Drawing.Point(820, 705)
        Me.txtCostTotal.Name = "txtCostTotal"
        Me.txtCostTotal.ReadOnly = True
        Me.txtCostTotal.Size = New System.Drawing.Size(60, 19)
        Me.txtCostTotal.TabIndex = 36
        Me.txtCostTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCostTotal
        '
        Me.lblCostTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCostTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostTotal.Location = New System.Drawing.Point(785, 702)
        Me.lblCostTotal.Name = "lblCostTotal"
        Me.lblCostTotal.Size = New System.Drawing.Size(96, 23)
        Me.lblCostTotal.TabIndex = 129
        Me.lblCostTotal.Text = "Total"
        '
        'txtCostShipping
        '
        Me.txtCostShipping.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCostShipping.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostShipping.Location = New System.Drawing.Point(818, 676)
        Me.txtCostShipping.Name = "txtCostShipping"
        Me.txtCostShipping.Size = New System.Drawing.Size(60, 19)
        Me.txtCostShipping.TabIndex = 35
        Me.txtCostShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostFactor
        '
        Me.txtCostFactor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCostFactor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostFactor.Location = New System.Drawing.Point(818, 652)
        Me.txtCostFactor.Name = "txtCostFactor"
        Me.txtCostFactor.Size = New System.Drawing.Size(61, 19)
        Me.txtCostFactor.TabIndex = 34
        Me.txtCostFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCostFactor
        '
        Me.lblCostFactor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCostFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostFactor.Location = New System.Drawing.Point(785, 650)
        Me.lblCostFactor.Name = "lblCostFactor"
        Me.lblCostFactor.Size = New System.Drawing.Size(96, 23)
        Me.lblCostFactor.TabIndex = 125
        Me.lblCostFactor.Text = "FCTR"
        '
        'lblCostShip
        '
        Me.lblCostShip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCostShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostShip.Location = New System.Drawing.Point(785, 674)
        Me.lblCostShip.Name = "lblCostShip"
        Me.lblCostShip.Size = New System.Drawing.Size(96, 23)
        Me.lblCostShip.TabIndex = 128
        Me.lblCostShip.Text = "Ship"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(14, 694)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(210, 30)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TblSWOOrderDetailDataGridView
        '
        Me.TblSWOOrderDetailDataGridView.AllowUserToAddRows = False
        Me.TblSWOOrderDetailDataGridView.AllowUserToDeleteRows = False
        Me.TblSWOOrderDetailDataGridView.AutoGenerateColumns = False
        Me.TblSWOOrderDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.Total})
        Me.TblSWOOrderDetailDataGridView.DataSource = Me.TblSWOOrderDetailBindingSource
        Me.TblSWOOrderDetailDataGridView.Location = New System.Drawing.Point(12, 403)
        Me.TblSWOOrderDetailDataGridView.Name = "TblSWOOrderDetailDataGridView"
        Me.TblSWOOrderDetailDataGridView.RowHeadersVisible = False
        Me.TblSWOOrderDetailDataGridView.Size = New System.Drawing.Size(867, 230)
        Me.TblSWOOrderDetailDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "gID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "gID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "gSWOOrderID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "gSWOOrderID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LineNum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ItemDesc"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item / Description"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 230
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Dwr"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dwr"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Door"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Door"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Hinge"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Hinge"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fin"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fin"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "End1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "End"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 120
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Retail"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Retail"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 110
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'TblSWOOrderDetailBindingSource
        '
        Me.TblSWOOrderDetailBindingSource.DataMember = "tblSWOOrderDetail"
        Me.TblSWOOrderDetailBindingSource.DataSource = Me.TksijobsDataSet1
        '
        'TksijobsDataSet1
        '
        Me.TksijobsDataSet1.DataSetName = "TKSIJOBSDataSet"
        Me.TksijobsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTAX
        '
        Me.txtTAX.BackColor = System.Drawing.Color.Lavender
        Me.txtTAX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTAX.Location = New System.Drawing.Point(655, 676)
        Me.txtTAX.Name = "txtTAX"
        Me.txtTAX.ReadOnly = True
        Me.txtTAX.Size = New System.Drawing.Size(103, 19)
        Me.txtTAX.TabIndex = 32
        Me.txtTAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtADD
        '
        Me.txtADD.BackColor = System.Drawing.Color.Lavender
        Me.txtADD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADD.Location = New System.Drawing.Point(500, 703)
        Me.txtADD.Name = "txtADD"
        Me.txtADD.Size = New System.Drawing.Size(104, 19)
        Me.txtADD.TabIndex = 31
        Me.txtADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAdd
        '
        Me.lblAdd.BackColor = System.Drawing.Color.Lavender
        Me.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(467, 701)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(139, 23)
        Me.lblAdd.TabIndex = 134
        Me.lblAdd.Text = "ADD"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.Lavender
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(622, 674)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(139, 23)
        Me.lblTax.TabIndex = 135
        Me.lblTax.Text = "TAX"
        '
        'txtTerms
        '
        Me.txtTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerms.FormattingEnabled = True
        Me.txtTerms.Items.AddRange(New Object() {"Net 10 Prx", "PIA", "50-50", "Warranty", "Jobcost"})
        Me.txtTerms.Location = New System.Drawing.Point(584, 143)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.Size = New System.Drawing.Size(270, 24)
        Me.txtTerms.TabIndex = 8
        '
        'txtDoorStyleWall
        '
        Me.txtDoorStyleWall.BackColor = System.Drawing.Color.Lavender
        Me.txtDoorStyleWall.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDoorStyleWall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoorStyleWall.Location = New System.Drawing.Point(32, 292)
        Me.txtDoorStyleWall.Name = "txtDoorStyleWall"
        Me.txtDoorStyleWall.Size = New System.Drawing.Size(374, 15)
        Me.txtDoorStyleWall.TabIndex = 10
        Me.txtDoorStyleWall.TabStop = False
        '
        'txtDoorStyleBase
        '
        Me.txtDoorStyleBase.BackColor = System.Drawing.Color.Lavender
        Me.txtDoorStyleBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDoorStyleBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoorStyleBase.Location = New System.Drawing.Point(32, 333)
        Me.txtDoorStyleBase.Name = "txtDoorStyleBase"
        Me.txtDoorStyleBase.Size = New System.Drawing.Size(374, 15)
        Me.txtDoorStyleBase.TabIndex = 14
        Me.txtDoorStyleBase.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(228, 377)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(178, 15)
        Me.txtDescription.TabIndex = 17
        Me.txtDescription.TabStop = False
        '
        'txtHinge
        '
        Me.txtHinge.BackColor = System.Drawing.Color.Lavender
        Me.txtHinge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHinge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHinge.Location = New System.Drawing.Point(444, 335)
        Me.txtHinge.Name = "txtHinge"
        Me.txtHinge.Size = New System.Drawing.Size(108, 15)
        Me.txtHinge.TabIndex = 15
        Me.txtHinge.TabStop = False
        '
        'txtWood
        '
        Me.txtWood.BackColor = System.Drawing.Color.Lavender
        Me.txtWood.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWood.Location = New System.Drawing.Point(444, 292)
        Me.txtWood.Name = "txtWood"
        Me.txtWood.Size = New System.Drawing.Size(108, 15)
        Me.txtWood.TabIndex = 11
        Me.txtWood.TabStop = False
        '
        'txtLaminate
        '
        Me.txtLaminate.BackColor = System.Drawing.Color.Lavender
        Me.txtLaminate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLaminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLaminate.Location = New System.Drawing.Point(738, 292)
        Me.txtLaminate.Name = "txtLaminate"
        Me.txtLaminate.Size = New System.Drawing.Size(116, 15)
        Me.txtLaminate.TabIndex = 13
        Me.txtLaminate.TabStop = False
        '
        'txtFinishMod
        '
        Me.txtFinishMod.BackColor = System.Drawing.Color.Lavender
        Me.txtFinishMod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFinishMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinishMod.Location = New System.Drawing.Point(584, 292)
        Me.txtFinishMod.Name = "txtFinishMod"
        Me.txtFinishMod.Size = New System.Drawing.Size(129, 15)
        Me.txtFinishMod.TabIndex = 21
        Me.txtFinishMod.TabStop = False
        '
        'txtCompletionDate
        '
        Me.txtCompletionDate.BackColor = System.Drawing.Color.White
        Me.txtCompletionDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompletionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompletionDate.Location = New System.Drawing.Point(32, 377)
        Me.txtCompletionDate.Name = "txtCompletionDate"
        Me.txtCompletionDate.Size = New System.Drawing.Size(157, 15)
        Me.txtCompletionDate.TabIndex = 16
        '
        'lblSDANo
        '
        Me.lblSDANo.BackColor = System.Drawing.Color.Lavender
        Me.lblSDANo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSDANo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSDANo.Location = New System.Drawing.Point(428, 360)
        Me.lblSDANo.Name = "lblSDANo"
        Me.lblSDANo.Size = New System.Drawing.Size(136, 39)
        Me.lblSDANo.TabIndex = 136
        Me.lblSDANo.Text = "SDA #"
        '
        'txtSDA
        '
        Me.txtSDA.BackColor = System.Drawing.Color.White
        Me.txtSDA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDA.Location = New System.Drawing.Point(444, 378)
        Me.txtSDA.Name = "txtSDA"
        Me.txtSDA.Size = New System.Drawing.Size(108, 15)
        Me.txtSDA.TabIndex = 18
        '
        'txtJobContact
        '
        Me.txtJobContact.BackColor = System.Drawing.Color.White
        Me.txtJobContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJobContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobContact.Location = New System.Drawing.Point(444, 147)
        Me.txtJobContact.Name = "txtJobContact"
        Me.txtJobContact.Size = New System.Drawing.Size(108, 15)
        Me.txtJobContact.TabIndex = 7
        '
        'lblJobContact
        '
        Me.lblJobContact.BackColor = System.Drawing.Color.Lavender
        Me.lblJobContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJobContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobContact.Location = New System.Drawing.Point(428, 130)
        Me.lblJobContact.Name = "lblJobContact"
        Me.lblJobContact.Size = New System.Drawing.Size(136, 39)
        Me.lblJobContact.TabIndex = 138
        Me.lblJobContact.Text = "Job Contact  "
        '
        'TblSWOPendingTableAdapter1
        '
        Me.TblSWOPendingTableAdapter1.ClearBeforeFill = True
        '
        'TVendorTableAdapter1
        '
        Me.TVendorTableAdapter1.ClearBeforeFill = True
        '
        'TEmployeeTableAdapter1
        '
        Me.TEmployeeTableAdapter1.ClearBeforeFill = True
        '
        'TblSWOOrderDetailTableAdapter1
        '
        Me.TblSWOOrderDetailTableAdapter1.ClearBeforeFill = True
        '
        'TJobTableAdapter1
        '
        Me.TJobTableAdapter1.ClearBeforeFill = True
        '
        'TblSWOOrderTableAdapter1
        '
        Me.TblSWOOrderTableAdapter1.ClearBeforeFill = True
        '
        'btnPrintPartsForm
        '
        Me.btnPrintPartsForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrintPartsForm.Location = New System.Drawing.Point(708, 5)
        Me.btnPrintPartsForm.Name = "btnPrintPartsForm"
        Me.btnPrintPartsForm.Size = New System.Drawing.Size(159, 23)
        Me.btnPrintPartsForm.TabIndex = 139
        Me.btnPrintPartsForm.Text = "Print Parts Order Form"
        Me.btnPrintPartsForm.UseVisualStyleBackColor = False
        '
        'txtUpcharge1
        '
        Me.txtUpcharge1.BackColor = System.Drawing.Color.White
        Me.txtUpcharge1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUpcharge1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpcharge1.Location = New System.Drawing.Point(381, 652)
        Me.txtUpcharge1.Name = "txtUpcharge1"
        Me.txtUpcharge1.Size = New System.Drawing.Size(61, 19)
        Me.txtUpcharge1.TabIndex = 140
        Me.txtUpcharge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUpcharge1.Visible = False
        '
        'lblUpcharge1
        '
        Me.lblUpcharge1.BackColor = System.Drawing.Color.Lavender
        Me.lblUpcharge1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpcharge1.ContextMenuStrip = Me.ContextMenuStripUpcharge
        Me.lblUpcharge1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpcharge1.Location = New System.Drawing.Point(313, 650)
        Me.lblUpcharge1.Name = "lblUpcharge1"
        Me.lblUpcharge1.Size = New System.Drawing.Size(137, 23)
        Me.lblUpcharge1.TabIndex = 141
        '
        'ContextMenuStripUpcharge
        '
        Me.ContextMenuStripUpcharge.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ContextMenuStripUpcharge.Name = "ContextMenuStripUpcharge"
        Me.ContextMenuStripUpcharge.Size = New System.Drawing.Size(135, 136)
        Me.ContextMenuStripUpcharge.Text = "test"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem1.Text = "Wood"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem2.Text = "Glaze"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem3.Text = "Paint"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem4.Text = "Distress"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem5.Text = "EO"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem6.Text = "Other"
        '
        'txtUpcharge2
        '
        Me.txtUpcharge2.BackColor = System.Drawing.Color.White
        Me.txtUpcharge2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUpcharge2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpcharge2.Location = New System.Drawing.Point(381, 678)
        Me.txtUpcharge2.Name = "txtUpcharge2"
        Me.txtUpcharge2.Size = New System.Drawing.Size(61, 19)
        Me.txtUpcharge2.TabIndex = 142
        Me.txtUpcharge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUpcharge2.Visible = False
        '
        'lblUpcharge2
        '
        Me.lblUpcharge2.BackColor = System.Drawing.Color.Lavender
        Me.lblUpcharge2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpcharge2.ContextMenuStrip = Me.ContextMenuStripUpcharge2
        Me.lblUpcharge2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpcharge2.Location = New System.Drawing.Point(313, 676)
        Me.lblUpcharge2.Name = "lblUpcharge2"
        Me.lblUpcharge2.Size = New System.Drawing.Size(137, 23)
        Me.lblUpcharge2.TabIndex = 143
        '
        'ContextMenuStripUpcharge2
        '
        Me.ContextMenuStripUpcharge2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12})
        Me.ContextMenuStripUpcharge2.Name = "ContextMenuStripUpcharge"
        Me.ContextMenuStripUpcharge2.Size = New System.Drawing.Size(135, 136)
        Me.ContextMenuStripUpcharge2.Text = "test"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem7.Text = "Wood"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem8.Text = "Glaze"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem9.Text = "Paint"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem10.Text = "Distress"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem11.Text = "EO"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem12.Text = "Other"
        '
        'txtUpcharge3
        '
        Me.txtUpcharge3.BackColor = System.Drawing.Color.White
        Me.txtUpcharge3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUpcharge3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpcharge3.Location = New System.Drawing.Point(381, 703)
        Me.txtUpcharge3.Name = "txtUpcharge3"
        Me.txtUpcharge3.Size = New System.Drawing.Size(61, 19)
        Me.txtUpcharge3.TabIndex = 144
        Me.txtUpcharge3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUpcharge3.Visible = False
        '
        'lblUpcharge3
        '
        Me.lblUpcharge3.BackColor = System.Drawing.Color.Lavender
        Me.lblUpcharge3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpcharge3.ContextMenuStrip = Me.ContextMenuStripUpcharge3
        Me.lblUpcharge3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpcharge3.Location = New System.Drawing.Point(313, 701)
        Me.lblUpcharge3.Name = "lblUpcharge3"
        Me.lblUpcharge3.Size = New System.Drawing.Size(137, 23)
        Me.lblUpcharge3.TabIndex = 145
        '
        'ContextMenuStripUpcharge3
        '
        Me.ContextMenuStripUpcharge3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18})
        Me.ContextMenuStripUpcharge3.Name = "ContextMenuStripUpcharge"
        Me.ContextMenuStripUpcharge3.Size = New System.Drawing.Size(135, 136)
        Me.ContextMenuStripUpcharge3.Text = "test"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem13.Text = "Wood"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem14.Text = "Glaze"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem15.Text = "Paint"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem16.Text = "Distress"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem17.Text = "EO"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem18.Text = "Other"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 637)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Upcharges (right-click)"
        '
        'frmSWOParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 737)
        Me.Controls.Add(Me.txtUpcharge3)
        Me.Controls.Add(Me.lblUpcharge3)
        Me.Controls.Add(Me.txtUpcharge2)
        Me.Controls.Add(Me.lblUpcharge2)
        Me.Controls.Add(Me.txtUpcharge1)
        Me.Controls.Add(Me.lblUpcharge1)
        Me.Controls.Add(Me.btnPrintPartsForm)
        Me.Controls.Add(Me.txtJobContact)
        Me.Controls.Add(Me.lblJobContact)
        Me.Controls.Add(Me.txtSDA)
        Me.Controls.Add(Me.lblSDANo)
        Me.Controls.Add(Me.txtCompletionDate)
        Me.Controls.Add(Me.txtFinishMod)
        Me.Controls.Add(Me.txtLaminate)
        Me.Controls.Add(Me.txtWood)
        Me.Controls.Add(Me.txtHinge)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtDoorStyleBase)
        Me.Controls.Add(Me.txtDoorStyleWall)
        Me.Controls.Add(Me.txtTAX)
        Me.Controls.Add(Me.txtADD)
        Me.Controls.Add(Me.txtTerms)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.TblSWOOrderDetailDataGridView)
        Me.Controls.Add(Me.txtCostTotal)
        Me.Controls.Add(Me.lblCostTotal)
        Me.Controls.Add(Me.txtCostShipping)
        Me.Controls.Add(Me.txtCostFactor)
        Me.Controls.Add(Me.lblCostFactor)
        Me.Controls.Add(Me.lblCostShip)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtRetailTotal)
        Me.Controls.Add(Me.lblRetailTotal)
        Me.Controls.Add(Me.txtRetailShipping)
        Me.Controls.Add(Me.txtRetailFactor)
        Me.Controls.Add(Me.lblRetailFactor)
        Me.Controls.Add(Me.cmbSales)
        Me.Controls.Add(Me.cmbManufacture)
        Me.Controls.Add(Me.txtTitleOrder)
        Me.Controls.Add(Me.chkWhiteMelInt)
        Me.Controls.Add(Me.chkMapleMelDoveDwr)
        Me.Controls.Add(Me.chkWoodDoveDwr)
        Me.Controls.Add(Me.chkMapleMelamIntDwr)
        Me.Controls.Add(Me.lblDoorStyleBase)
        Me.Controls.Add(Me.lblFinishMod)
        Me.Controls.Add(Me.lblHinge)
        Me.Controls.Add(Me.lblWood)
        Me.Controls.Add(Me.lblCompletionDate)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblMapleMelIntDoveDwr)
        Me.Controls.Add(Me.lblLaminate)
        Me.Controls.Add(Me.lblDoorStyleWall)
        Me.Controls.Add(Me.txtShipto)
        Me.Controls.Add(Me.txtBillTo)
        Me.Controls.Add(Me.lblShipTo)
        Me.Controls.Add(Me.lblBillTo)
        Me.Controls.Add(Me.txtTitletksi)
        Me.Controls.Add(Me.txtShipVia)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.txtShipWeek)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblTerms)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblShipVia)
        Me.Controls.Add(Me.lblShipWeekOf)
        Me.Controls.Add(Me.lblPO)
        Me.Controls.Add(Me.lblManufacture)
        Me.Controls.Add(Me.lblRetailShip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSWOParts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Parts Order"
        Me.ContextMenuManufacture.ResumeLayout(False)
        CType(Me.TblSWOOrderDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSWOOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripUpcharge.ResumeLayout(False)
        Me.ContextMenuStripUpcharge2.ResumeLayout(False)
        Me.ContextMenuStripUpcharge3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblManufacture As System.Windows.Forms.Label
    Friend WithEvents lblPO As System.Windows.Forms.Label
    Friend WithEvents lblShipVia As System.Windows.Forms.Label
    Friend WithEvents lblShipWeekOf As System.Windows.Forms.Label
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents txtShipWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtShipVia As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents txtTitletksi As System.Windows.Forms.TextBox
    Friend WithEvents lblBillTo As System.Windows.Forms.Label
    Friend WithEvents lblShipTo As System.Windows.Forms.Label
    Friend WithEvents txtBillTo As System.Windows.Forms.TextBox
    Friend WithEvents txtShipto As System.Windows.Forms.TextBox
    Friend WithEvents lblCompletionDate As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblMapleMelIntDoveDwr As System.Windows.Forms.Label
    Friend WithEvents lblLaminate As System.Windows.Forms.Label
    Friend WithEvents lblDoorStyleWall As System.Windows.Forms.Label
    Friend WithEvents lblFinishMod As System.Windows.Forms.Label
    Friend WithEvents lblWood As System.Windows.Forms.Label
    Friend WithEvents lblHinge As System.Windows.Forms.Label
    Friend WithEvents lblDoorStyleBase As System.Windows.Forms.Label
    Friend WithEvents chkMapleMelamIntDwr As System.Windows.Forms.CheckBox
    Friend WithEvents chkWoodDoveDwr As System.Windows.Forms.CheckBox
    Friend WithEvents chkMapleMelDoveDwr As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhiteMelInt As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuManufacture As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripCrestwood As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripKitchenCraft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTitleOrder As System.Windows.Forms.TextBox
    Friend WithEvents TblSWOPendingTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOPendingTableAdapter
    Friend WithEvents TksijobsDataSet1 As TKSISchedule.TKSIJOBSDataSet
    Friend WithEvents cmbManufacture As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSales As System.Windows.Forms.ComboBox
    Friend WithEvents lblRetailFactor As System.Windows.Forms.Label
    Friend WithEvents txtRetailFactor As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailShipping As System.Windows.Forms.TextBox
    Friend WithEvents lblRetailShip As System.Windows.Forms.Label
    Friend WithEvents lblRetailTotal As System.Windows.Forms.Label
    Friend WithEvents txtRetailTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCostTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCostTotal As System.Windows.Forms.Label
    Friend WithEvents txtCostShipping As System.Windows.Forms.TextBox
    Friend WithEvents txtCostFactor As System.Windows.Forms.TextBox
    Friend WithEvents lblCostFactor As System.Windows.Forms.Label
    Friend WithEvents lblCostShip As System.Windows.Forms.Label
    Friend WithEvents TVendorTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter
    Friend WithEvents TEmployeeTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tEmployeeTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TblSWOOrderDetailTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOOrderDetailTableAdapter
    Friend WithEvents TblSWOOrderDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSWOOrderDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtTAX As System.Windows.Forms.TextBox
    Friend WithEvents txtADD As System.Windows.Forms.TextBox
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents TJobTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter
    Friend WithEvents TblSWOOrderTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOOrderTableAdapter
    Friend WithEvents txtTerms As System.Windows.Forms.ComboBox
    Friend WithEvents txtDoorStyleWall As System.Windows.Forms.TextBox
    Friend WithEvents txtDoorStyleBase As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtHinge As System.Windows.Forms.TextBox
    Friend WithEvents txtWood As System.Windows.Forms.TextBox
    Friend WithEvents txtLaminate As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishMod As System.Windows.Forms.TextBox
    Friend WithEvents txtCompletionDate As System.Windows.Forms.TextBox
    Friend WithEvents lblSDANo As System.Windows.Forms.Label
    Friend WithEvents txtSDA As System.Windows.Forms.TextBox
    Friend WithEvents txtJobContact As System.Windows.Forms.TextBox
    Friend WithEvents lblJobContact As System.Windows.Forms.Label
    Friend WithEvents btnPrintPartsForm As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUpcharge1 As System.Windows.Forms.TextBox
    Friend WithEvents lblUpcharge1 As System.Windows.Forms.Label
    Friend WithEvents txtUpcharge2 As System.Windows.Forms.TextBox
    Friend WithEvents lblUpcharge2 As System.Windows.Forms.Label
    Friend WithEvents txtUpcharge3 As System.Windows.Forms.TextBox
    Friend WithEvents lblUpcharge3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStripUpcharge As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripUpcharge2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripUpcharge3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
