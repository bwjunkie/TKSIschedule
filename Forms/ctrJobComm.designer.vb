<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrJobComm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrJobComm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.flexJobComm = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDeliverPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCallNote = New C1.Win.C1Input.C1TextBox()
        Me.lvCallNote = New System.Windows.Forms.CheckedListBox()
        Me.pnlAddCallNote = New System.Windows.Forms.Panel()
        Me.flexParts = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TblTrailerDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TKSIJOBSDataSet = New TKSISchedule.TKSIJOBSDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnAddCallNote = New System.Windows.Forms.Button()
        Me.lblTop2 = New System.Windows.Forms.Label()
        Me.lblTop1 = New System.Windows.Forms.Label()
        Me.TblJobActivityDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblJobActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtShipDate = New C1.Win.C1Input.C1TextBox()
        Me.pnlTextboxes = New System.Windows.Forms.Panel()
        Me.btnShowMapImages = New System.Windows.Forms.Button()
        Me.chkAll8x11 = New System.Windows.Forms.CheckBox()
        Me.txtPaymentNotes = New C1.Win.C1Input.C1TextBox()
        Me.txtInvoiceDue = New C1.Win.C1Input.C1TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContact = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJobDesc = New C1.Win.C1Input.C1TextBox()
        Me.btnDeliver = New System.Windows.Forms.Button()
        Me.btnSaveJobComm = New System.Windows.Forms.Button()
        Me.btnPrintJob = New System.Windows.Forms.Button()
        Me.txtSales = New C1.Win.C1Input.C1TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPhone = New C1.Win.C1Input.C1TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJobsite = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTerms = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument8x11 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument11x17 = New System.Drawing.Printing.PrintDocument()
        Me.TblJobActivityTableAdapter = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.TAddressTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tAddressTableAdapter()
        Me.TblTrailerDetailTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter()
        Me.TblTrailerHeaderTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblTrailerHeaderTableAdapter()
        Me.TblTrailerDetailTableAdapter2 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter()
        Me.TblActivityTypeTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblActivityTypeTableAdapter()
        Me.TPOHeaderTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter()
        Me.TJobTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter()
        Me.TCustomrTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter()
        Me.TVendorTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter()
        CType(Me.flexJobComm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.txtCallNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddCallNote.SuspendLayout()
        CType(Me.flexParts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrailerDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TKSIJOBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobActivityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShipDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTextboxes.SuspendLayout()
        CType(Me.txtPaymentNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flexJobComm
        '
        Me.flexJobComm.ColumnInfo = "8,0,0,0,0,95,Columns:0{Width:96;Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:90;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Widt" & _
    "h:170;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:90;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.flexJobComm.ContextMenuStrip = Me.ContextMenuStrip1
        Me.flexJobComm.Dock = System.Windows.Forms.DockStyle.Top
        Me.flexJobComm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flexJobComm.Location = New System.Drawing.Point(9, 169)
        Me.flexJobComm.Name = "flexJobComm"
        Me.flexJobComm.Rows.DefaultSize = 19
        Me.flexJobComm.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.flexJobComm.Size = New System.Drawing.Size(771, 155)
        Me.flexJobComm.StyleInfo = resources.GetString("flexJobComm.StyleInfo")
        Me.flexJobComm.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeliverPO})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 26)
        '
        'mnuDeliverPO
        '
        Me.mnuDeliverPO.Name = "mnuDeliverPO"
        Me.mnuDeliverPO.Size = New System.Drawing.Size(167, 22)
        Me.mnuDeliverPO.Text = "Mark as Delivered"
        '
        'txtCallNote
        '
        Me.txtCallNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallNote.Location = New System.Drawing.Point(3, 226)
        Me.txtCallNote.Name = "txtCallNote"
        Me.txtCallNote.Size = New System.Drawing.Size(241, 22)
        Me.txtCallNote.TabIndex = 4
        Me.txtCallNote.Tag = Nothing
        '
        'lvCallNote
        '
        Me.lvCallNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCallNote.FormattingEnabled = True
        Me.lvCallNote.Items.AddRange(New Object() {"1 week out", "2 weeks out", "3 weeks out", "Call Back", "Left Messege", "Customer Pickup", "Out of town", "Spoke with customer", "BO Handled", "No Answer", "Credit", "Delivered (remove from current accounts)", "Spoke with Salesperson", "Use Alternate Phone #", "Will call us"})
        Me.lvCallNote.Location = New System.Drawing.Point(3, 6)
        Me.lvCallNote.Name = "lvCallNote"
        Me.lvCallNote.Size = New System.Drawing.Size(241, 174)
        Me.lvCallNote.TabIndex = 5
        '
        'pnlAddCallNote
        '
        Me.pnlAddCallNote.Controls.Add(Me.flexParts)
        Me.pnlAddCallNote.Controls.Add(Me.Label2)
        Me.pnlAddCallNote.Controls.Add(Me.DateTimePicker1)
        Me.pnlAddCallNote.Controls.Add(Me.btnAddCallNote)
        Me.pnlAddCallNote.Controls.Add(Me.txtCallNote)
        Me.pnlAddCallNote.Controls.Add(Me.lvCallNote)
        Me.pnlAddCallNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddCallNote.Location = New System.Drawing.Point(9, 501)
        Me.pnlAddCallNote.Name = "pnlAddCallNote"
        Me.pnlAddCallNote.Size = New System.Drawing.Size(771, 223)
        Me.pnlAddCallNote.TabIndex = 6
        '
        'flexParts
        '
        Me.flexParts.ColumnInfo = resources.GetString("flexParts.ColumnInfo")
        Me.flexParts.DataSource = Me.TblTrailerDetailBindingSource
        Me.flexParts.Location = New System.Drawing.Point(266, 6)
        Me.flexParts.Name = "flexParts"
        Me.flexParts.Rows.Count = 1
        Me.flexParts.Rows.DefaultSize = 17
        Me.flexParts.Size = New System.Drawing.Size(502, 242)
        Me.flexParts.TabIndex = 10
        '
        'TblTrailerDetailBindingSource
        '
        Me.TblTrailerDetailBindingSource.DataMember = "tblTrailerDetail"
        Me.TblTrailerDetailBindingSource.DataSource = Me.TKSIJOBSDataSet
        '
        'TKSIJOBSDataSet
        '
        Me.TKSIJOBSDataSet.DataSetName = "TKSIJOBSDataSet"
        Me.TKSIJOBSDataSet.EnforceConstraints = False
        Me.TKSIJOBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Call Back Date (optional)"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 201)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'btnAddCallNote
        '
        Me.btnAddCallNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCallNote.Location = New System.Drawing.Point(133, 185)
        Me.btnAddCallNote.Name = "btnAddCallNote"
        Me.btnAddCallNote.Size = New System.Drawing.Size(111, 33)
        Me.btnAddCallNote.TabIndex = 6
        Me.btnAddCallNote.Text = "&Add Call/Note"
        Me.btnAddCallNote.UseVisualStyleBackColor = True
        '
        'lblTop2
        '
        Me.lblTop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTop2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTop2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop2.Location = New System.Drawing.Point(9, 324)
        Me.lblTop2.Name = "lblTop2"
        Me.lblTop2.Size = New System.Drawing.Size(771, 26)
        Me.lblTop2.TabIndex = 7
        Me.lblTop2.Text = "Calls / Activity"
        Me.lblTop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTop1
        '
        Me.lblTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTop1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop1.Location = New System.Drawing.Point(4, 7)
        Me.lblTop1.Name = "lblTop1"
        Me.lblTop1.Size = New System.Drawing.Size(764, 26)
        Me.lblTop1.TabIndex = 8
        Me.lblTop1.Text = "Job Communication"
        '
        'TblJobActivityDataGridView
        '
        Me.TblJobActivityDataGridView.AutoGenerateColumns = False
        Me.TblJobActivityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblJobActivityDataGridView.DataSource = Me.TblJobActivityBindingSource
        Me.TblJobActivityDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TblJobActivityDataGridView.Location = New System.Drawing.Point(9, 350)
        Me.TblJobActivityDataGridView.Name = "TblJobActivityDataGridView"
        Me.TblJobActivityDataGridView.Size = New System.Drawing.Size(771, 151)
        Me.TblJobActivityDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "gID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "gID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nJobID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nJobID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dateEntered"
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "dateEntered"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ActivityType"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ActivityType"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 160
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ActivityDetail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ActivityDetail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 580
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Other"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Other"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'TblJobActivityBindingSource
        '
        Me.TblJobActivityBindingSource.DataMember = "tblJobActivity"
        Me.TblJobActivityBindingSource.DataSource = Me.TKSIJOBSDataSet
        '
        '
        'txtShipDate
        '
        Me.txtShipDate.AutoSize = False
        Me.txtShipDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShipDate.Enabled = False
        Me.txtShipDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipDate.Location = New System.Drawing.Point(93, 83)
        Me.txtShipDate.Name = "txtShipDate"
        Me.txtShipDate.Size = New System.Drawing.Size(230, 17)
        Me.txtShipDate.TabIndex = 57
        Me.txtShipDate.Tag = Nothing
        '
        'pnlTextboxes
        '
        Me.pnlTextboxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlTextboxes.Controls.Add(Me.btnShowMapImages)
        Me.pnlTextboxes.Controls.Add(Me.chkAll8x11)
        Me.pnlTextboxes.Controls.Add(Me.txtPaymentNotes)
        Me.pnlTextboxes.Controls.Add(Me.txtInvoiceDue)
        Me.pnlTextboxes.Controls.Add(Me.Label10)
        Me.pnlTextboxes.Controls.Add(Me.txtContact)
        Me.pnlTextboxes.Controls.Add(Me.Label6)
        Me.pnlTextboxes.Controls.Add(Me.Label5)
        Me.pnlTextboxes.Controls.Add(Me.txtJobDesc)
        Me.pnlTextboxes.Controls.Add(Me.btnDeliver)
        Me.pnlTextboxes.Controls.Add(Me.btnSaveJobComm)
        Me.pnlTextboxes.Controls.Add(Me.btnPrintJob)
        Me.pnlTextboxes.Controls.Add(Me.txtSales)
        Me.pnlTextboxes.Controls.Add(Me.Label9)
        Me.pnlTextboxes.Controls.Add(Me.txtPhone)
        Me.pnlTextboxes.Controls.Add(Me.Label8)
        Me.pnlTextboxes.Controls.Add(Me.Label7)
        Me.pnlTextboxes.Controls.Add(Me.txtJobsite)
        Me.pnlTextboxes.Controls.Add(Me.Label4)
        Me.pnlTextboxes.Controls.Add(Me.txtTerms)
        Me.pnlTextboxes.Controls.Add(Me.Label3)
        Me.pnlTextboxes.Controls.Add(Me.Label1)
        Me.pnlTextboxes.Controls.Add(Me.txtShipDate)
        Me.pnlTextboxes.Controls.Add(Me.lblTop1)
        Me.pnlTextboxes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTextboxes.Location = New System.Drawing.Point(9, 9)
        Me.pnlTextboxes.Name = "pnlTextboxes"
        Me.pnlTextboxes.Size = New System.Drawing.Size(771, 160)
        Me.pnlTextboxes.TabIndex = 11
        '
        'btnShowMapImages
        '
        Me.btnShowMapImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowMapImages.Location = New System.Drawing.Point(647, 85)
        Me.btnShowMapImages.Name = "btnShowMapImages"
        Me.btnShowMapImages.Size = New System.Drawing.Size(101, 22)
        Me.btnShowMapImages.TabIndex = 64
        Me.btnShowMapImages.Text = "Show Map"
        Me.btnShowMapImages.UseVisualStyleBackColor = True
        '
        'chkAll8x11
        '
        Me.chkAll8x11.AutoSize = True
        Me.chkAll8x11.Location = New System.Drawing.Point(663, 11)
        Me.chkAll8x11.Name = "chkAll8x11"
        Me.chkAll8x11.Size = New System.Drawing.Size(69, 17)
        Me.chkAll8x11.TabIndex = 62
        Me.chkAll8x11.Text = "All 8 x 11"
        Me.chkAll8x11.UseVisualStyleBackColor = True
        '
        'txtPaymentNotes
        '
        Me.txtPaymentNotes.AutoSize = False
        Me.txtPaymentNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentNotes.Location = New System.Drawing.Point(415, 127)
        Me.txtPaymentNotes.Name = "txtPaymentNotes"
        Me.txtPaymentNotes.Size = New System.Drawing.Size(209, 17)
        Me.txtPaymentNotes.TabIndex = 8
        Me.txtPaymentNotes.Tag = Nothing
        '
        'txtInvoiceDue
        '
        Me.txtInvoiceDue.AutoSize = False
        Me.txtInvoiceDue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInvoiceDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceDue.Location = New System.Drawing.Point(416, 106)
        Me.txtInvoiceDue.Name = "txtInvoiceDue"
        Me.txtInvoiceDue.Size = New System.Drawing.Size(208, 17)
        Me.txtInvoiceDue.TabIndex = 61
        Me.txtInvoiceDue.Tag = Nothing
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(330, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Inv Balance:"
        '
        'txtContact
        '
        Me.txtContact.AutoSize = False
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(416, 39)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(208, 17)
        Me.txtContact.TabIndex = 59
        Me.txtContact.Tag = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Balance Due:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Job Desc:"
        '
        'txtJobDesc
        '
        Me.txtJobDesc.AutoSize = False
        Me.txtJobDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJobDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobDesc.Location = New System.Drawing.Point(93, 106)
        Me.txtJobDesc.Name = "txtJobDesc"
        Me.txtJobDesc.Size = New System.Drawing.Size(230, 17)
        Me.txtJobDesc.TabIndex = 58
        Me.txtJobDesc.Tag = Nothing
        '
        'btnDeliver
        '
        Me.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeliver.Location = New System.Drawing.Point(523, 9)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.Size = New System.Drawing.Size(101, 22)
        Me.btnDeliver.TabIndex = 28
        Me.btnDeliver.Text = "Deliver"
        Me.btnDeliver.UseVisualStyleBackColor = True
        '
        'btnSaveJobComm
        '
        Me.btnSaveJobComm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveJobComm.Location = New System.Drawing.Point(647, 121)
        Me.btnSaveJobComm.Name = "btnSaveJobComm"
        Me.btnSaveJobComm.Size = New System.Drawing.Size(101, 22)
        Me.btnSaveJobComm.TabIndex = 27
        Me.btnSaveJobComm.Text = "Save"
        Me.btnSaveJobComm.UseVisualStyleBackColor = True
        '
        'btnPrintJob
        '
        Me.btnPrintJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintJob.Location = New System.Drawing.Point(647, 49)
        Me.btnPrintJob.Name = "btnPrintJob"
        Me.btnPrintJob.Size = New System.Drawing.Size(101, 22)
        Me.btnPrintJob.TabIndex = 26
        Me.btnPrintJob.Text = "Print Job"
        Me.btnPrintJob.UseVisualStyleBackColor = True
        '
        'txtSales
        '
        Me.txtSales.AutoSize = False
        Me.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSales.Enabled = False
        Me.txtSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.Location = New System.Drawing.Point(93, 61)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(230, 17)
        Me.txtSales.TabIndex = 56
        Me.txtSales.Tag = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(330, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.AutoSize = False
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(416, 62)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(208, 17)
        Me.txtPhone.TabIndex = 7
        Me.txtPhone.Tag = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(330, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Contact:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Jobsite:"
        '
        'txtJobsite
        '
        Me.txtJobsite.AutoSize = False
        Me.txtJobsite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJobsite.Enabled = False
        Me.txtJobsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobsite.Location = New System.Drawing.Point(94, 38)
        Me.txtJobsite.Name = "txtJobsite"
        Me.txtJobsite.Size = New System.Drawing.Size(230, 17)
        Me.txtJobsite.TabIndex = 55
        Me.txtJobsite.Tag = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Terms"
        '
        'txtTerms
        '
        Me.txtTerms.AutoSize = False
        Me.txtTerms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerms.Location = New System.Drawing.Point(416, 85)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.Size = New System.Drawing.Size(208, 17)
        Me.txtTerms.TabIndex = 5
        Me.txtTerms.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Salesperson:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ship Date:"
        '
        'PrintDocument8x11
        '
        '
        'PrintDocument11x17
        '
        '
        'TblJobActivityTableAdapter
        '
        Me.TblJobActivityTableAdapter.ClearBeforeFill = True
        '
        'TAddressTableAdapter1
        '
        Me.TAddressTableAdapter1.ClearBeforeFill = True
        '
        'TblTrailerDetailTableAdapter1
        '
        Me.TblTrailerDetailTableAdapter1.ClearBeforeFill = True
        '
        'TblTrailerHeaderTableAdapter1
        '
        Me.TblTrailerHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TblTrailerDetailTableAdapter2
        '
        Me.TblTrailerDetailTableAdapter2.ClearBeforeFill = True
        '
        'TblActivityTypeTableAdapter1
        '
        Me.TblActivityTypeTableAdapter1.ClearBeforeFill = True
        '
        'TPOHeaderTableAdapter1
        '
        Me.TPOHeaderTableAdapter1.ClearBeforeFill = True
        '
        'TJobTableAdapter1
        '
        Me.TJobTableAdapter1.ClearBeforeFill = True
        '
        'TCustomrTableAdapter1
        '
        Me.TCustomrTableAdapter1.ClearBeforeFill = True
        '
        'TVendorTableAdapter1
        '
        Me.TVendorTableAdapter1.ClearBeforeFill = True
        '
        'ctrJobComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.pnlAddCallNote)
        Me.Controls.Add(Me.TblJobActivityDataGridView)
        Me.Controls.Add(Me.lblTop2)
        Me.Controls.Add(Me.flexJobComm)
        Me.Controls.Add(Me.pnlTextboxes)
        Me.Name = "ctrJobComm"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.Size = New System.Drawing.Size(789, 733)
        CType(Me.flexJobComm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.txtCallNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddCallNote.ResumeLayout(False)
        Me.pnlAddCallNote.PerformLayout()
        CType(Me.flexParts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrailerDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TKSIJOBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobActivityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShipDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTextboxes.ResumeLayout(False)
        Me.pnlTextboxes.PerformLayout()
        CType(Me.txtPaymentNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTerms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flexJobComm As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCallNote As C1.Win.C1Input.C1TextBox
    Friend WithEvents pnlAddCallNote As System.Windows.Forms.Panel
    Friend WithEvents btnAddCallNote As System.Windows.Forms.Button
    Friend WithEvents lvCallNote As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblTop1 As System.Windows.Forms.Label
    Friend WithEvents lblTop2 As System.Windows.Forms.Label
    Friend WithEvents TKSIJOBSDataSet As TKSISchedule.TKSIJOBSDataSet
    Friend WithEvents TblJobActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobActivityTableAdapter As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents TblJobActivityDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtShipDate As C1.Win.C1Input.C1TextBox
    Friend WithEvents pnlTextboxes As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJobsite As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTerms As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSales As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAddressTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tAddressTableAdapter
    Friend WithEvents TblTrailerDetailTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
    Friend WithEvents TblTrailerHeaderTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblTrailerHeaderTableAdapter
    Friend WithEvents TblTrailerDetailTableAdapter2 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblTrailerDetailTableAdapter
    Friend WithEvents flexParts As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TblTrailerDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnPrintJob As System.Windows.Forms.Button
    Friend WithEvents TblActivityTypeTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblActivityTypeTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuDeliverPO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TPOHeaderTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tPOHeaderTableAdapter
    Friend WithEvents btnSaveJobComm As System.Windows.Forms.Button
    Friend WithEvents btnDeliver As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtJobDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentNotes As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtContact As C1.Win.C1Input.C1TextBox
    Friend WithEvents TJobTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tJobTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceDue As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1PrintDocument1 As System.Drawing.Printing.PrintDocument ' C1.C1Preview.C1PrintDocument
    Friend WithEvents PrintDocument8x11 As System.Drawing.Printing.PrintDocument
    Friend WithEvents chkAll8x11 As System.Windows.Forms.CheckBox
    Friend WithEvents PrintDocument11x17 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnShowMapImages As System.Windows.Forms.Button
    Friend WithEvents TCustomrTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter
    Friend WithEvents TVendorTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tVendorTableAdapter

End Class
