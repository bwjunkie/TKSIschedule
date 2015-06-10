Imports System.Windows.Forms
Imports System.Drawing

Public Class frmPOnet
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.sqlConn.ConnectionString = cnSQL
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
    Public WithEvents Picture4 As System.Windows.Forms.Panel
    Public WithEvents btnDupPO As System.Windows.Forms.Button
    Public WithEvents cmdAddPO As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button
    Public WithEvents cmdPrintPO As System.Windows.Forms.Button
    Public WithEvents Picture2 As System.Windows.Forms.Panel
    Public WithEvents cmdDelPO As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents CtrPOLines1 As ctrPOLines
    Friend WithEvents pnlNotes As System.Windows.Forms.Panel
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtDeliveryNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtRecNotes As System.Windows.Forms.TextBox
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents CtrPOHeader1 As ctrPOHeader
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daPOLineALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendorALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderByNID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineByNPOID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJobByNID As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents btnShipDetail As System.Windows.Forms.Button
    Public WithEvents btnUnDeliver As System.Windows.Forms.Button
    Friend WithEvents daTrailerHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents chkSpecialDeliverNeeded As System.Windows.Forms.CheckBox
    Friend WithEvents TblJobActivityTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter
    Friend WithEvents TksijobsDataSet1 As TKSISchedule.TKSIJOBSDataSet
    Public WithEvents btnDeliver As System.Windows.Forms.Button
    Friend WithEvents btnSendToSimply As System.Windows.Forms.Button
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOnet))
        Me.Picture4 = New System.Windows.Forms.Panel()
        Me.btnDeliver = New System.Windows.Forms.Button()
        Me.chkSpecialDeliverNeeded = New System.Windows.Forms.CheckBox()
        Me.btnUnDeliver = New System.Windows.Forms.Button()
        Me.btnShipDetail = New System.Windows.Forms.Button()
        Me.btnDupPO = New System.Windows.Forms.Button()
        Me.cmdAddPO = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrintPO = New System.Windows.Forms.Button()
        Me.Picture2 = New System.Windows.Forms.Panel()
        Me.btnSendToSimply = New System.Windows.Forms.Button()
        Me.cmdDelPO = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.CtrPOLines1 = New TKSISchedule.ctrPOLines()
        Me.pnlNotes = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRecNotes = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDeliveryNotes = New System.Windows.Forms.TextBox()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.CtrPOHeader1 = New TKSISchedule.ctrPOHeader()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.daPOLineALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daVendorALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderByNID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineByNPOID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daJobByNID = New System.Data.SqlClient.SqlDataAdapter()
        Me.daTrailerHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.TblJobActivityTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblJobActivityTableAdapter()
        Me.TksijobsDataSet1 = New TKSISchedule.TKSIJOBSDataSet()
        Me.Picture4.SuspendLayout()
        Me.Picture2.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlNotes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture4
        '
        Me.Picture4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture4.Controls.Add(Me.btnDeliver)
        Me.Picture4.Controls.Add(Me.chkSpecialDeliverNeeded)
        Me.Picture4.Controls.Add(Me.btnUnDeliver)
        Me.Picture4.Controls.Add(Me.btnShipDetail)
        Me.Picture4.Controls.Add(Me.btnDupPO)
        Me.Picture4.Controls.Add(Me.cmdAddPO)
        Me.Picture4.Controls.Add(Me.cmdSave)
        Me.Picture4.Controls.Add(Me.cmdPrintPO)
        Me.Picture4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Picture4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture4.Location = New System.Drawing.Point(169, 0)
        Me.Picture4.Name = "Picture4"
        Me.Picture4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture4.Size = New System.Drawing.Size(743, 58)
        Me.Picture4.TabIndex = 10
        Me.Picture4.TabStop = True
        '
        'btnDeliver
        '
        Me.btnDeliver.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeliver.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeliver.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeliver.Location = New System.Drawing.Point(160, 31)
        Me.btnDeliver.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeliver.Size = New System.Drawing.Size(60, 26)
        Me.btnDeliver.TabIndex = 17
        Me.btnDeliver.Text = "Deliver"
        Me.btnDeliver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeliver.UseVisualStyleBackColor = False
        Me.btnDeliver.Visible = False
        '
        'chkSpecialDeliverNeeded
        '
        Me.chkSpecialDeliverNeeded.AutoSize = True
        Me.chkSpecialDeliverNeeded.Location = New System.Drawing.Point(461, 8)
        Me.chkSpecialDeliverNeeded.Name = "chkSpecialDeliverNeeded"
        Me.chkSpecialDeliverNeeded.Size = New System.Drawing.Size(137, 18)
        Me.chkSpecialDeliverNeeded.TabIndex = 16
        Me.chkSpecialDeliverNeeded.Text = "Special Delivery Needs"
        Me.chkSpecialDeliverNeeded.UseVisualStyleBackColor = True
        '
        'btnUnDeliver
        '
        Me.btnUnDeliver.BackColor = System.Drawing.SystemColors.Control
        Me.btnUnDeliver.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUnDeliver.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnDeliver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUnDeliver.Location = New System.Drawing.Point(160, 6)
        Me.btnUnDeliver.Name = "btnUnDeliver"
        Me.btnUnDeliver.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUnDeliver.Size = New System.Drawing.Size(60, 26)
        Me.btnUnDeliver.TabIndex = 15
        Me.btnUnDeliver.Text = "Un-Deliver"
        Me.btnUnDeliver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUnDeliver.UseVisualStyleBackColor = False
        Me.btnUnDeliver.Visible = False
        '
        'btnShipDetail
        '
        Me.btnShipDetail.BackColor = System.Drawing.SystemColors.Control
        Me.btnShipDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShipDetail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShipDetail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShipDetail.Location = New System.Drawing.Point(96, 6)
        Me.btnShipDetail.Name = "btnShipDetail"
        Me.btnShipDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShipDetail.Size = New System.Drawing.Size(60, 26)
        Me.btnShipDetail.TabIndex = 14
        Me.btnShipDetail.Text = "Shipping"
        Me.btnShipDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShipDetail.UseVisualStyleBackColor = False
        '
        'btnDupPO
        '
        Me.btnDupPO.BackColor = System.Drawing.SystemColors.Control
        Me.btnDupPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDupPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDupPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDupPO.Location = New System.Drawing.Point(8, 6)
        Me.btnDupPO.Name = "btnDupPO"
        Me.btnDupPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDupPO.Size = New System.Drawing.Size(80, 26)
        Me.btnDupPO.TabIndex = 13
        Me.btnDupPO.Text = "Duplicate PO"
        Me.btnDupPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDupPO.UseVisualStyleBackColor = False
        Me.btnDupPO.Visible = False
        '
        'cmdAddPO
        '
        Me.cmdAddPO.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddPO.Location = New System.Drawing.Point(232, 6)
        Me.cmdAddPO.Name = "cmdAddPO"
        Me.cmdAddPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddPO.Size = New System.Drawing.Size(110, 26)
        Me.cmdAddPO.TabIndex = 10
        Me.cmdAddPO.Text = "Add Line"
        Me.cmdAddPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAddPO.UseVisualStyleBackColor = False
        Me.cmdAddPO.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(602, 6)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(110, 26)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        Me.cmdSave.Visible = False
        '
        'cmdPrintPO
        '
        Me.cmdPrintPO.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintPO.Location = New System.Drawing.Point(348, 6)
        Me.cmdPrintPO.Name = "cmdPrintPO"
        Me.cmdPrintPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintPO.Size = New System.Drawing.Size(110, 26)
        Me.cmdPrintPO.TabIndex = 7
        Me.cmdPrintPO.Text = "Print PO"
        Me.cmdPrintPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrintPO.UseVisualStyleBackColor = False
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture2.Controls.Add(Me.btnSendToSimply)
        Me.Picture2.Controls.Add(Me.cmdDelPO)
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture2.Location = New System.Drawing.Point(0, 0)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(169, 58)
        Me.Picture2.TabIndex = 9
        Me.Picture2.TabStop = True
        '
        'btnSendToSimply
        '
        Me.btnSendToSimply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSendToSimply.Location = New System.Drawing.Point(16, 30)
        Me.btnSendToSimply.Name = "btnSendToSimply"
        Me.btnSendToSimply.Size = New System.Drawing.Size(136, 26)
        Me.btnSendToSimply.TabIndex = 5
        Me.btnSendToSimply.Text = "Send to Simply"
        Me.btnSendToSimply.UseVisualStyleBackColor = False
        Me.btnSendToSimply.Visible = False
        '
        'cmdDelPO
        '
        Me.cmdDelPO.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelPO.Location = New System.Drawing.Point(16, 5)
        Me.cmdDelPO.Name = "cmdDelPO"
        Me.cmdDelPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelPO.Size = New System.Drawing.Size(136, 26)
        Me.cmdDelPO.TabIndex = 4
        Me.cmdDelPO.Text = "Delete PO"
        Me.cmdDelPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelPO.UseVisualStyleBackColor = False
        Me.cmdDelPO.Visible = False
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.Picture4)
        Me.pnlBottom.Controls.Add(Me.Picture2)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 535)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(912, 58)
        Me.pnlBottom.TabIndex = 11
        '
        'CtrPOLines1
        '
        Me.CtrPOLines1.AutoScroll = True
        Me.CtrPOLines1.BackColor = System.Drawing.Color.White
        Me.CtrPOLines1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrPOLines1.Location = New System.Drawing.Point(0, 288)
        Me.CtrPOLines1.Name = "CtrPOLines1"
        Me.CtrPOLines1.Padding = New System.Windows.Forms.Padding(8)
        Me.CtrPOLines1.Size = New System.Drawing.Size(912, 231)
        Me.CtrPOLines1.TabIndex = 2
        '
        'pnlNotes
        '
        Me.pnlNotes.Controls.Add(Me.Panel2)
        Me.pnlNotes.Controls.Add(Me.Panel3)
        Me.pnlNotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlNotes.Location = New System.Drawing.Point(0, 519)
        Me.pnlNotes.Name = "pnlNotes"
        Me.pnlNotes.Size = New System.Drawing.Size(912, 16)
        Me.pnlNotes.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtRecNotes)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Panel2.Location = New System.Drawing.Point(336, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel2.Size = New System.Drawing.Size(576, 16)
        Me.Panel2.TabIndex = 10
        Me.Panel2.TabStop = True
        '
        'txtRecNotes
        '
        Me.txtRecNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRecNotes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtRecNotes.Name = "txtRecNotes"
        Me.txtRecNotes.Size = New System.Drawing.Size(574, 15)
        Me.txtRecNotes.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtDeliveryNotes)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel3.Size = New System.Drawing.Size(336, 16)
        Me.Panel3.TabIndex = 9
        Me.Panel3.TabStop = True
        '
        'txtDeliveryNotes
        '
        Me.txtDeliveryNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeliveryNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDeliveryNotes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtDeliveryNotes.Name = "txtDeliveryNotes"
        Me.txtDeliveryNotes.Size = New System.Drawing.Size(334, 15)
        Me.txtDeliveryNotes.TabIndex = 0
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CtrPOHeader1
        '
        Me.CtrPOHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrPOHeader1.Location = New System.Drawing.Point(0, 0)
        Me.CtrPOHeader1.Name = "CtrPOHeader1"
        Me.CtrPOHeader1.Size = New System.Drawing.Size(912, 288)
        Me.CtrPOHeader1.TabIndex = 0
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERV" & _
    "ER\SQLEXPRESS;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'daPOLineALL
        '
        Me.daPOLineALL.DeleteCommand = Me.SqlCommand13
        Me.daPOLineALL.InsertCommand = Me.SqlCommand14
        Me.daPOLineALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        Me.daPOLineALL.UpdateCommand = Me.SqlCommand26
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = resources.GetString("SqlCommand13.CommandText")
        Me.SqlCommand13.Connection = Me.sqlConn
        Me.SqlCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccountID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCost", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCost", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDesc", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sReceived", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sReceived", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sType", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand14
        '
        Me.SqlCommand14.CommandText = resources.GetString("SqlCommand14.CommandText")
        Me.SqlCommand14.Connection = Me.sqlConn
        Me.SqlCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nPOID", System.Data.SqlDbType.Int, 4, "nPOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@sType", System.Data.SqlDbType.NVarChar, 255, "sType"), New System.Data.SqlClient.SqlParameter("@sDesc", System.Data.SqlDbType.NVarChar, 255, "sDesc"), New System.Data.SqlClient.SqlParameter("@nCost", System.Data.SqlDbType.Float, 8, "nCost"), New System.Data.SqlClient.SqlParameter("@nAccountID", System.Data.SqlDbType.Int, 4, "nAccountID"), New System.Data.SqlClient.SqlParameter("@sReceived", System.Data.SqlDbType.Bit, 1, "sReceived")})
        '
        'SqlCommand26
        '
        Me.SqlCommand26.CommandText = resources.GetString("SqlCommand26.CommandText")
        Me.SqlCommand26.Connection = Me.sqlConn
        Me.SqlCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nPOID", System.Data.SqlDbType.Int, 4, "nPOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@sType", System.Data.SqlDbType.NVarChar, 255, "sType"), New System.Data.SqlClient.SqlParameter("@sDesc", System.Data.SqlDbType.NVarChar, 255, "sDesc"), New System.Data.SqlClient.SqlParameter("@nCost", System.Data.SqlDbType.Float, 8, "nCost"), New System.Data.SqlClient.SqlParameter("@nAccountID", System.Data.SqlDbType.Int, 4, "nAccountID"), New System.Data.SqlClient.SqlParameter("@sReceived", System.Data.SqlDbType.Bit, 1, "sReceived"), New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccountID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCost", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCost", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDesc", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sReceived", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sReceived", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sType", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax FROM tVendor"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@lid", System.Data.SqlDbType.Int, 4, "lid"), New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@sStreet1", System.Data.SqlDbType.VarChar, 50, "sStreet1"), New System.Data.SqlClient.SqlParameter("@sStreet2", System.Data.SqlDbType.VarChar, 50, "sStreet2"), New System.Data.SqlClient.SqlParameter("@sCity", System.Data.SqlDbType.VarChar, 50, "sCity"), New System.Data.SqlClient.SqlParameter("@sProvState", System.Data.SqlDbType.VarChar, 50, "sProvState"), New System.Data.SqlClient.SqlParameter("@sCountry", System.Data.SqlDbType.VarChar, 50, "sCountry"), New System.Data.SqlClient.SqlParameter("@sPostalZip", System.Data.SqlDbType.VarChar, 50, "sPostalZip"), New System.Data.SqlClient.SqlParameter("@sPhone1", System.Data.SqlDbType.VarChar, 50, "sPhone1"), New System.Data.SqlClient.SqlParameter("@sPhone2", System.Data.SqlDbType.VarChar, 50, "sPhone2"), New System.Data.SqlClient.SqlParameter("@sFax", System.Data.SqlDbType.VarChar, 50, "sFax")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@lid", System.Data.SqlDbType.Int, 4, "lid"), New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@sStreet1", System.Data.SqlDbType.VarChar, 50, "sStreet1"), New System.Data.SqlClient.SqlParameter("@sStreet2", System.Data.SqlDbType.VarChar, 50, "sStreet2"), New System.Data.SqlClient.SqlParameter("@sCity", System.Data.SqlDbType.VarChar, 50, "sCity"), New System.Data.SqlClient.SqlParameter("@sProvState", System.Data.SqlDbType.VarChar, 50, "sProvState"), New System.Data.SqlClient.SqlParameter("@sCountry", System.Data.SqlDbType.VarChar, 50, "sCountry"), New System.Data.SqlClient.SqlParameter("@sPostalZip", System.Data.SqlDbType.VarChar, 50, "sPostalZip"), New System.Data.SqlClient.SqlParameter("@sPhone1", System.Data.SqlDbType.VarChar, 50, "sPhone1"), New System.Data.SqlClient.SqlParameter("@sPhone2", System.Data.SqlDbType.VarChar, 50, "sPhone2"), New System.Data.SqlClient.SqlParameter("@sFax", System.Data.SqlDbType.VarChar, 50, "sFax"), New System.Data.SqlClient.SqlParameter("@Original_lid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCountry", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPostalZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPostalZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sProvState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sProvState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_lid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCountry", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPostalZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPostalZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sProvState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sProvState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sStreet2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sStreet2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daVendorALL
        '
        Me.daVendorALL.DeleteCommand = Me.SqlDeleteCommand1
        Me.daVendorALL.InsertCommand = Me.SqlInsertCommand1
        Me.daVendorALL.SelectCommand = Me.SqlSelectCommand1
        Me.daVendorALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        Me.daVendorALL.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daPOHeaderByNID
        '
        Me.daPOHeaderByNID.SelectCommand = Me.SqlSelectCommand2
        Me.daPOHeaderByNID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT nPOID, nLineNumber, sType, sDesc, nCost, nAccountID, sReceived FROM tPOLin" & _
    "e WHERE (nPOID = @NPOID)"
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NPOID", System.Data.SqlDbType.Int, 4, "nPOID")})
        '
        'daPOLineByNPOID
        '
        Me.daPOLineByNPOID.SelectCommand = Me.SqlSelectCommand3
        Me.daPOLineByNPOID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.sqlConn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@dCreateRecord", System.Data.SqlDbType.DateTime, 4, "dCreateRecord"), New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID"), New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipto3", System.Data.SqlDbType.VarChar, 50, "sShipto3"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShiptoCounty", System.Data.SqlDbType.VarChar, 50, "sShiptoCounty"), New System.Data.SqlClient.SqlParameter("@nBoxes", System.Data.SqlDbType.Int, 4, "nBoxes"), New System.Data.SqlClient.SqlParameter("@dPODate", System.Data.SqlDbType.DateTime, 4, "dPODate"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@sEnteredBy", System.Data.SqlDbType.VarChar, 50, "sEnteredBy"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Float, 8, "nTotal"), New System.Data.SqlClient.SqlParameter("@sVia", System.Data.SqlDbType.VarChar, 50, "sVia"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@nRetailSale", System.Data.SqlDbType.Float, 8, "nRetailSale"), New System.Data.SqlClient.SqlParameter("@nSaleAccount", System.Data.SqlDbType.Int, 4, "nSaleAccount"), New System.Data.SqlClient.SqlParameter("@nRetailFreight", System.Data.SqlDbType.Float, 8, "nRetailFreight"), New System.Data.SqlClient.SqlParameter("@sConf", System.Data.SqlDbType.VarChar, 50, "sConf"), New System.Data.SqlClient.SqlParameter("@nAdd", System.Data.SqlDbType.Float, 8, "nAdd"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@DFAXED", System.Data.SqlDbType.DateTime, 4, "DFAXED"), New System.Data.SqlClient.SqlParameter("@nAccount", System.Data.SqlDbType.Int, 4, "nAccount"), New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@sItems", System.Data.SqlDbType.VarChar, 50, "sItems"), New System.Data.SqlClient.SqlParameter("@sItemDesc", System.Data.SqlDbType.VarChar, 50, "sItemDesc"), New System.Data.SqlClient.SqlParameter("@sPOType", System.Data.SqlDbType.VarChar, 50, "sPOType"), New System.Data.SqlClient.SqlParameter("@nsalesadjust", System.Data.SqlDbType.Money, 8, "nsalesadjust"), New System.Data.SqlClient.SqlParameter("@sAdjustReason", System.Data.SqlDbType.VarChar, 255, "sAdjustReason"), New System.Data.SqlClient.SqlParameter("@sCurActNote", System.Data.SqlDbType.VarChar, 255, "sCurActNote"), New System.Data.SqlClient.SqlParameter("@nPOSort", System.Data.SqlDbType.Int, 4, "nPOSort")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.sqlConn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID"), New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipto3", System.Data.SqlDbType.VarChar, 50, "sShipto3"), New System.Data.SqlClient.SqlParameter("@nBoxes", System.Data.SqlDbType.Int, 4, "nBoxes"), New System.Data.SqlClient.SqlParameter("@dPODate", System.Data.SqlDbType.DateTime, 4, "dPODate"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@sEnteredBy", System.Data.SqlDbType.VarChar, 50, "sEnteredBy"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Float, 8, "nTotal"), New System.Data.SqlClient.SqlParameter("@sVia", System.Data.SqlDbType.VarChar, 50, "sVia"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@nRetailSale", System.Data.SqlDbType.Float, 8, "nRetailSale"), New System.Data.SqlClient.SqlParameter("@nSaleAccount", System.Data.SqlDbType.Int, 4, "nSaleAccount"), New System.Data.SqlClient.SqlParameter("@nRetailFreight", System.Data.SqlDbType.Float, 8, "nRetailFreight"), New System.Data.SqlClient.SqlParameter("@sConf", System.Data.SqlDbType.VarChar, 50, "sConf"), New System.Data.SqlClient.SqlParameter("@nAdd", System.Data.SqlDbType.Float, 8, "nAdd"), New System.Data.SqlClient.SqlParameter("@nAccount", System.Data.SqlDbType.Int, 4, "nAccount"), New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@sItems", System.Data.SqlDbType.VarChar, 50, "sItems"), New System.Data.SqlClient.SqlParameter("@sItemDesc", System.Data.SqlDbType.VarChar, 50, "sItemDesc"), New System.Data.SqlClient.SqlParameter("@sPOType", System.Data.SqlDbType.VarChar, 50, "sPOType"), New System.Data.SqlClient.SqlParameter("@nsalesadjust", System.Data.SqlDbType.Money, 8, "nsalesadjust"), New System.Data.SqlClient.SqlParameter("@sAdjustReason", System.Data.SqlDbType.VarChar, 255, "sAdjustReason"), New System.Data.SqlClient.SqlParameter("@nPOSort", System.Data.SqlDbType.Int, 4, "nPOSort"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dPODate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dPODate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dRequired", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAdd", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAdd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nBoxes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nBoxes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOSort", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOSort", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailFreight", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailFreight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailSale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSaleAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSaleAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nVendorID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nVendorID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nsalesadjust", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nsalesadjust", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sAdjustReason", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAdjustReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sConf", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sEnteredBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sEnteredBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItemDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItemDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItems", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItems", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPOType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPOType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.sqlConn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DFAXED", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DFAXED", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bSimply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreateRecord", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreateRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dPODate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dPODate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dRequired", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dSimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAdd", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAdd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nBoxes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nBoxes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOSort", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOSort", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailFreight", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailFreight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailSale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSaleAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSaleAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nVendorID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nVendorID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nsalesadjust", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nsalesadjust", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sAdjustReason", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAdjustReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sConf", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCurActNote", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCurActNote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sEnteredBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sEnteredBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItemDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItemDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItems", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItems", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPOType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPOType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipto3", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipto3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShiptoCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShiptoCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daPOHeaderALL
        '
        Me.daPOHeaderALL.DeleteCommand = Me.SqlDeleteCommand2
        Me.daPOHeaderALL.InsertCommand = Me.SqlInsertCommand2
        Me.daPOHeaderALL.SelectCommand = Me.SqlSelectCommand4
        Me.daPOHeaderALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPOHeaderALL.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daJobByNID
        '
        Me.daJobByNID.SelectCommand = Me.SqlSelectCommand5
        Me.daJobByNID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'daTrailerHeader
        '
        Me.daTrailerHeader.DeleteCommand = Me.SqlCommand5
        Me.daTrailerHeader.InsertCommand = Me.SqlCommand6
        Me.daTrailerHeader.SelectCommand = Me.SqlCommand7
        Me.daTrailerHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTrailerHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PalletNum", "PalletNum"), New System.Data.Common.DataColumnMapping("SO", "SO"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("ShipDate", "ShipDate"), New System.Data.Common.DataColumnMapping("TrailerControl", "TrailerControl"), New System.Data.Common.DataColumnMapping("FreightTermsCode", "FreightTermsCode"), New System.Data.Common.DataColumnMapping("FreightCode", "FreightCode"), New System.Data.Common.DataColumnMapping("ShipType", "ShipType"), New System.Data.Common.DataColumnMapping("TrailerNumber", "TrailerNumber")})})
        Me.daTrailerHeader.UpdateCommand = Me.SqlCommand8
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = resources.GetString("SqlCommand5.CommandText")
        Me.SqlCommand5.Connection = Me.sqlConn
        Me.SqlCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_PalletNum", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PalletNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightTermsCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightTermsCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerNumber", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrailerNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Connection = Me.sqlConn
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PalletNum", System.Data.SqlDbType.VarChar, 30, "PalletNum"), New System.Data.SqlClient.SqlParameter("@SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO"), New System.Data.SqlClient.SqlParameter("@ShipDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"), New System.Data.SqlClient.SqlParameter("@TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FreightTermsCode", System.Data.SqlDbType.VarChar, 20, "FreightTermsCode"), New System.Data.SqlClient.SqlParameter("@FreightCode", System.Data.SqlDbType.VarChar, 20, "FreightCode"), New System.Data.SqlClient.SqlParameter("@ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TrailerNumber", System.Data.SqlDbType.VarChar, 20, "TrailerNumber")})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT PalletNum, SO, PO, ShipDate, TrailerControl, FreightTermsCode, FreightCode" & _
    ", ShipType, TrailerNumber FROM dbo.tblTrailerHeader WHERE (PO LIKE @PO)"
        Me.SqlCommand7.Connection = Me.sqlConn
        Me.SqlCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO")})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = resources.GetString("SqlCommand8.CommandText")
        Me.SqlCommand8.Connection = Me.sqlConn
        Me.SqlCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PalletNum", System.Data.SqlDbType.VarChar, 30, "PalletNum"), New System.Data.SqlClient.SqlParameter("@SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO"), New System.Data.SqlClient.SqlParameter("@ShipDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"), New System.Data.SqlClient.SqlParameter("@TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FreightTermsCode", System.Data.SqlDbType.VarChar, 20, "FreightTermsCode"), New System.Data.SqlClient.SqlParameter("@FreightCode", System.Data.SqlDbType.VarChar, 20, "FreightCode"), New System.Data.SqlClient.SqlParameter("@ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TrailerNumber", System.Data.SqlDbType.VarChar, 20, "TrailerNumber"), New System.Data.SqlClient.SqlParameter("@Original_PalletNum", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PalletNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightTermsCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightTermsCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerNumber", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrailerNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'TblJobActivityTableAdapter1
        '
        Me.TblJobActivityTableAdapter1.ClearBeforeFill = True
        '
        'TksijobsDataSet1
        '
        Me.TksijobsDataSet1.DataSetName = "TKSIJOBSDataSet"
        Me.TksijobsDataSet1.EnforceConstraints = False
        Me.TksijobsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmPOnet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(912, 593)
        Me.Controls.Add(Me.CtrPOLines1)
        Me.Controls.Add(Me.pnlNotes)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.CtrPOHeader1)
        Me.Name = "frmPOnet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Picture4.ResumeLayout(False)
        Me.Picture4.PerformLayout()
        Me.Picture2.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlNotes.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private oJob As JobObj
    Private drPO As dsTKSI.tPOHeaderRow
    Private blnDeletingThisPO As Boolean = False
    Private daTrailerDetail As New dsTKSITableAdapters.tblTrailerDetailTableAdapter

    Public Sub LoadPO(ByVal nPOID As Integer, nJOBID As Integer, Optional ByVal oJob1 As JobObj = Nothing)
        If oJob1 Is Nothing Then
            oJob = New JobObj
        Else
            oJob = oJob1
        End If

        'Me.drPO = drPO1
        'Me.DsTKSI1 = drPO.Table.DataSet()
        With Me.DsTKSI1
            .tVendor.Clear()
            Me.daVendorALL.Fill(Me.DsTKSI1.tVendor)

            .tPOHeader.Clear()
            Me.daPOHeaderByNID.SelectCommand.Parameters("@NID").Value = nPOID
            Me.daPOHeaderByNID.Fill(.tPOHeader)

            .tPOLine.Clear()
            Me.daPOLineByNPOID.SelectCommand.Parameters("@NPOID").Value = nPOID
            Me.daPOLineByNPOID.Fill(.tPOLine)

            .tJob.Clear()
            Me.daJobByNID.SelectCommand.Parameters("@NID").Value = nJOBID
            Me.daJobByNID.Fill(.tJob)

        End With

        Try
            If Me.TblJobActivityTableAdapter1.Fill(Me.TksijobsDataSet1.tblJobActivity, nJOBID) > 0 Then
                Dim drAct As TKSIJOBSDataSet.tblJobActivityRow
                For Each drAct In Me.TksijobsDataSet1.tblJobActivity
                    If UCase(drAct.ActivityType) = UCase("Special Delivery Needs") Then
                        Me.chkSpecialDeliverNeeded.Checked = True
                    End If
                Next
            End If
        Catch ex As Exception
        End Try

        If Me.DsTKSI1.tPOHeader.Rows.Count > 0 Then
            Me.drPO = Me.DsTKSI1.tPOHeader(0)
        Else
            Throw New Exception("Error locating PO ")
        End If

        Me.CtrPOHeader1.LoadPoHeader(drPO)
        Me.CtrPOLines1.LoadPOLines(drPO)

        If drPO.IsDRECNull Then
            Me.txtRecNotes.Text = "Has NOT been received"
        Else
            Me.txtRecNotes.Text = "Received Date: " & drPO.DREC.ToShortDateString & " - " & drPO.SRECNOTES.Trim
        End If
        If drPO.IsDDELNull Then
            Me.txtDeliveryNotes.Text = "Has NOT been delivered"
        Else
            Me.txtDeliveryNotes.Text = "Delivery Date: " & drPO.DDEL.ToShortDateString & " - " & drPO.SDELNOTES.Trim

        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        SavePO()
    End Sub

    Private Sub SavePO()
        Try
            Dim blnSave As Boolean = True
            Me.CtrPOLines1.SavePOLines()
            Me.CtrPOHeader1.SavePOHeader()
            If UCase(drPO.sPOType) = "PO" Or UCase(drPO.sPOType) = "SWO" Or UCase(drPO.sPOType) = "SWO-WARRANTY" Or UCase(drPO.sPOType) = "WARRANTY" Then
                If oJob.GetPOCost(drPO) > 0.01 Then
                    If drPO.nRetailFreight + drPO.nRetailSale + drPO.nAdd < 0.01 Then
                        Dim frm1 As New password
                        frm1.Text = "PO w/ cost and no sale."
                        frm1.txtPass.BackColor = Color.White
                        frm1.txtPass.ForeColor = Color.Black

                        frm1.ShowDialog()
                        If frm1.OK Then
                            If frm1.txtPass.Text.Trim = "5640" Or frm1.txtPass.Text.Trim = "181818" Then
                                blnSave = True
                            Else
                                blnSave = False
                                Windows.Forms.MessageBox.Show("Changes not yet saved.")
                            End If
                        Else
                            blnSave = False
                            Windows.Forms.MessageBox.Show("Changes not yet saved.")
                        End If
                    End If
                End If
            End If
            'always true except in the one case where user prmpt answers no
            If blnSave Then
                Me.UpdatePOandLines()
                Me.CtrPOHeader1.LoadPoHeader(Me.drPO)
                Me.CtrPOLines1.LoadPOLines(Me.drPO)
            End If

            Try
                Dim blnActivityLogCreated As Boolean = False
                Dim drAct As TKSIJOBSDataSet.tblJobActivityRow

                If Me.TblJobActivityTableAdapter1.Fill(Me.TksijobsDataSet1.tblJobActivity, Me.drPO.nJobID) > 0 Then
                    For Each drAct In Me.TksijobsDataSet1.tblJobActivity
                        If UCase(drAct.ActivityType) = UCase("Special Delivery Needs") Then
                            If Not Me.chkSpecialDeliverNeeded.Checked Then
                                'they removed the check box
                                drAct.Delete()
                                Me.TblJobActivityTableAdapter1.Update(Me.TksijobsDataSet1.tblJobActivity)
                                Exit Try
                            Else
                                'box is checked and there is already an activity log so we dont need to do anything
                                blnActivityLogCreated = True
                            End If
                        End If
                    Next
                End If
                If Me.chkSpecialDeliverNeeded.Checked And (Not blnActivityLogCreated) Then
                    'we didnt delete a record and exit and the box is checked so...
                    'we need to create a new activity log
                    drAct = Me.TksijobsDataSet1.tblJobActivity.NewtblJobActivityRow
                    With drAct
                        .dateEntered = Now
                        .Other = ""
                        .nJobID = Me.drPO.nJobID
                        .ActivityType = "Special Delivery Needs"
                        .ActivityDetail = "Special Delivery Needs"
                        .gID = Guid.NewGuid
                    End With
                    Me.TksijobsDataSet1.tblJobActivity.AddtblJobActivityRow(drAct)
                    Me.TblJobActivityTableAdapter1.Update(Me.TksijobsDataSet1.tblJobActivity)
                End If
            Catch ex As Exception
                Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("save error " & ex.Message)
        End Try
    End Sub

    Friend Function UpdatePOandLines()
        Try
            With Me.DsTKSI1
                Me.daPOLineALL.Update(.tPOLine)
                .tPOLine.AcceptChanges()
                Me.daPOHeaderALL.Update(.tPOHeader)
                .tPOHeader.AcceptChanges()


            End With
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try

    End Function

    Private Sub cmdAddPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddPO.Click
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment")
        Me.CtrPOLines1.LoadPOLines(Me.drPO)
    End Sub

    Private Sub cmdDelPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelPO.Click
        Try
            If Windows.Forms.MessageBox.Show("Do you want to completely delete this PO?", "Delete PO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.CtrPOLines1.DeleteAllLines()
                Me.CtrPOHeader1.DeleteHeader()

                Me.UpdatePOandLines()

                Me.blnDeletingThisPO = True
                Me.Hide()
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error during delete po. " & ex.Message)
        End Try

    End Sub

    Private Sub cmdPrintPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintPO.Click
        Try
            Dim drPrint As New frmPO
            drPrint.drPO = Me.drPO
            drPrint.Show()
            drPrint.flexPOHeader.PrintGrid("", True, 1, 40, 40)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmPOnet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFeaturesVisibleBasedOnLoginRights()
    End Sub

    Private Sub SetFeaturesVisibleBasedOnLoginRights()
        Try
            Select Case sUserlevel
                Case Is <= UserRights.AdminAsst
                    Me.cmdAddPO.Visible = True
                    Me.cmdDelPO.Visible = True
                    Me.cmdSave.Visible = True
                    Me.btnDupPO.Visible = True
                    Me.cmdPrintPO.Visible = True
                    Me.btnUnDeliver.Visible = True
                    Me.btnDeliver.Visible = True


                Case UserRights.Shipping
                    Me.cmdSave.Visible = True
                    Me.cmdPrintPO.Visible = True
                    Me.cmdAddPO.Visible = True
                    Me.btnUnDeliver.Visible = True

                Case UserRights.Sales

                Case Else
                    Windows.Forms.MessageBox.Show("Login information not found.")
                    Exit Sub
            End Select

            If sUserlevel <= UserRights.Admin Then
                Me.btnSendToSimply.Visible = True
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmPOnet_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not blnDeletingThisPO Then
            Select Case sUserlevel
                Case Is <= UserRights.Shipping
                    If Windows.Forms.MessageBox.Show("Save changes?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        SavePO()
                    End If
                Case Else

            End Select
        End If

    End Sub

    Private Sub CtrPOHeader1_installLines() Handles CtrPOHeader1.installLines
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Item")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Item")

        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "If you have any questions please")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "call " & drPO.tJobRow.sSalesperson & " at 303-799-9200")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "Job Contact:" & drPO.tJobRow.sJobContact)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "Phone: " & drPO.tJobRow.sPhone)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "PLEASE SIGN AND RETURN UPON")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "COMPLETION FOR FULL PAYMENT")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "SIGN ________________________")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "DATE ________________________")

        Me.CtrPOLines1.LoadPOLines(Me.drPO)
        Me.Activate()

    End Sub

    Private Sub ctrPOHeader_Hardwarelines() Handles CtrPOHeader1.HardwareLines
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Item")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Item")

        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "CALLED IN ")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "SPOKE TO ")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO)
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "IN STOCK ")
        oJob.AddPOLine(Me.DsTKSI1, Me.drPO, "Comment", "REF#    ")

        Me.CtrPOLines1.LoadPOLines(Me.drPO)
    End Sub

    Private Sub btnDupPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDupPO.Click

        'Dim nJobID As Long
        'Dim dCreateRecord As Date
        'Dim nVendorID As Long
        'Dim sPONum As String
        'Dim sShipTo1 As String
        'Dim sShipTo2 As String
        'Dim sShipto3 As String
        'Dim sShipToCity As String
        'Dim sShipToState As String
        'Dim sShiptoCounty As String
        'Dim nBoxes As Long
        'Dim dPODate As Date
        'Dim sTerms As String
        'Dim dRequired As Date
        'Dim sEnteredBy As String
        'Dim nTotal As Long
        'Dim sVia As String
        'Dim sFOB As String
        'Dim nRetailSale As Long
        'Dim nSaleAccount As Long
        'Dim nRetailFreight As Long
        'Dim sConf As String
        'Dim nAdd As Long
        'Dim DREC As Date
        'Dim DDEL As Date
        'Dim SRECNOTES As String
        'Dim SDELNOTES As String
        'Dim DFAXED As Date
        'Dim nAccount As Long
        'Dim nInvNo As Long
        'Dim nCheckNo As Long
        'Dim dSimply As Date
        'Dim bSimply As Boolean
        'Dim nTruck As Long
        'Dim sFilter As String
        'Dim sBackOrder As String
        'Dim sItems As String
        'Dim sItemDesc As String
        'Dim sPOType As String
        'Dim nsalesadjust As Long
        'Dim sAdjustReason As String
        'Dim sCurActNote As String
        'Dim nPOSort As Long

        'on error Resume Next
        Dim drPO1 As dsTKSI.tPOHeaderRow
        drPO1 = Me.DsTKSI1.tPOHeader.NewtPOHeaderRow

        With drPO
            drPO1.nJobID = .nJobID ' .rsPO("nJobID")
            drPO1.nVendorID = .nVendorID '.rsPO("nVendorID")
            drPO1.sPONum = .sPONum & "-BO" '.rsPO("sPONum")
            drPO1.sShipTo1 = .sShipTo1 '.rsPO("sShipTo1")
            drPO1.sShipTo2 = .sShipTo2 '.rsPO("sShipTo2")
            drPO1.sShipto3 = .sShipto3 '.rsPO("sShipto3")
            drPO1.sShipToCity = .sShipToCity '.rsPO("sShipToCity")
            drPO1.sShipToState = .sShipToState '.rsPO("sShipToState")
            drPO1.sShipToZip = .sShipToZip
            drPO1.sShiptoCounty = .sShiptoCounty
            drPO1.nBoxes = 0

            If Not .IsdPODateNull Then
                drPO1.dPODate = .dPODate '.rsPO("dPODate")
            End If

            If Not .IsdRequiredNull Then
                drPO1.dRequired = .dRequired ' .rsPO("dRequired")
            End If

            drPO1.sItemDesc = .sItemDesc
            drPO1.sItems = .sItems
            'sEnteredBy = .rsPO("sEnteredBy")
            drPO1.sVia = .sVia ' .rsPO("sVia")
            drPO1.sFOB = .sFOB '.rsPO("sFOB")
            drPO1.nRetailSale = 0 '.rsPO("nRetailSale")
            drPO1.nSaleAccount = .nSaleAccount ' .rsPO("nSaleAccount")
            drPO1.nRetailFreight = 0 '.rsPO("nRetailFreight")
            drPO1.sConf = "N/A" '.rsPO("sConf")
            drPO1.nAdd = 0 '.rsPO("nAdd")

            drPO1.SRECNOTES = .SRECNOTES ' .rsPO("SRECNOTES")
            drPO1.SDELNOTES = .SDELNOTES '.rsPO("SDELNOTES")

            drPO1.nAccount = .nAccount '.rsPO("nAccount")
            drPO1.nInvNo = .nInvNo '.rsPO("nInvNo")
            drPO1.nCheckNo = 0 '.rsPO("nCheckNo")

            If Not .IsdSimplyNull Then
                drPO1.dSimply = .dSimply '.rsPO("dSimply")
            End If

            drPO1.nTruck = 1 '.rsPO("nTruck")
            drPO1.sFilter = .sFilter '.rsPO("sFilter")
            drPO1.sBackOrder = .sBackOrder '.rsPO("sBackOrder")
            drPO1.sItems = .sItems '.rsPO("sItems")
            drPO1.sItemDesc = .sItemDesc '.rsPO("sItemDesc")
            drPO1.sPOType = .sPOType '.rsPO("sPOType")
            drPO1.nsalesadjust = .nsalesadjust '.rsPO("nsalesadjust")
            drPO1.sAdjustReason = .sAdjustReason '.rsPO("sAdjustReason")
            drPO1.sCurActNote = .sCurActNote '.rsPO("sCurActNote")
            drPO1.nPOSort = .nPOSort  '.rsPO("nPOSort")
            drPO1.bSimply = False
            drPO1.nTotal = .nTotal
            drPO1.sTerms = .sTerms
            drPO1.sEnteredBy = "DuplicatePO"
        End With
        Me.DsTKSI1.tPOHeader.Rows.Add(drPO1)
        Me.UpdatePOandLines()

        Dim drLine As dsTKSI.tPOLineRow
        For Each drLine In drPO.GettPOLineRows
            Dim drLine1 As dsTKSI.tPOLineRow
            drLine1 = Me.DsTKSI1.tPOLine.NewtPOLineRow
            With drLine1
                .nAccountID = drLine.nAccountID
                .nCost = drLine.nCost
                .nLineNumber = drLine.nLineNumber
                .nPOID = drPO1.nID
                .sDesc = drLine.sDesc
                .sType = drLine.sType
                .sReceived = drLine.sReceived
            End With
            Me.DsTKSI1.tPOLine.Rows.Add(drLine1)
            Me.UpdatePOandLines()
        Next

        If Not drPO1 Is Nothing Then
            Dim frmPO1 As frmPOnet
            frmPO1 = New frmPOnet
            frmPO1.LoadPO(drPO1.nID, drPO1.nJobID)
            frmPO1.Show()
        End If

    End Sub

    Private Sub btnShipDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShipDetail.Click
        Try
            Dim frm1 As New frmShippingDetail
            frm1.LoadByPO(Me.drPO.sPONum)
            frm1.ShowDialog()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUnDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnDeliver.Click
        Try
            Me.SavePO()
            Me.drPO.SetDDELNull()
            Me.UpdatePOandLines()

            Me.UndeliverTrailerDetailItems()

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UndeliverTrailerDetailItems()
        Try
            Me.DsTKSI1.tblTrailerHeader.Clear()
            Me.daTrailerHeader.SelectCommand.Parameters("@PO").Value = Me.drPO.sPONum
            Me.daTrailerHeader.Fill(Me.DsTKSI1.tblTrailerHeader)

            Me.DsTKSI1.tblTrailerDetail.Clear()
            'Me.daTrailerDetail.SelectCommand.Parameters("@PO").Value = Me.drPO.sPONum
            Me.daTrailerDetail.FillByLikePO(Me.DsTKSI1.tblTrailerDetail, Me.drPO.sPONum)

            Dim drDetail As dsTKSI.tblTrailerDetailRow
            For Each drDetail In Me.DsTKSI1.tblTrailerDetail
                If Not drDetail.IsDeliveredTKSINull Then
                    drDetail.SetDeliveredTKSINull()
                End If
            Next

            Me.daTrailerDetail.Update(Me.DsTKSI1.tblTrailerDetail)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error updating trailer details lines " & ex.Message)
        End Try
    End Sub


    Private Sub btnDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeliver.Click
        Try
            Me.SavePO()

            If Me.drPO.IsDDELNull Then
                Me.drPO.DDEL = Now
                MessageBox.Show("PO delivered, however shipping parts items may not be marked as delivered until scanned in.")
            Else
                MessageBox.Show("PO already has a delivered date.")
            End If

            Me.UpdatePOandLines()

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SendToSimply(_drPO As dsTKSI.tPOHeaderRow)

        Dim discount As Decimal
        Dim frmDisc As New frmDiscount1

        frmDisc.ShowDialog()
        If frmDisc.blnOK Then
            If IsNumeric(frmDisc.txtDiscount.Text.Trim) Then
                discount = frmDisc.txtDiscount.Text.Trim
            Else
                discount = 0
            End If

            If UpdateSimply(_drPO, discount) Then
              
                _drPO.dSimply = Now
                _drPO.bSimply = True
                If Me.daPOHeaderALL.Update(Me.DsTKSI1.tPOHeader) = 0 Then
                    MessageBox.Show("PO did not update simply data, please check date sent.")
                End If
                Me.DsTKSI1.tPOHeader.AcceptChanges()

                Dim dc As New linqTKSIDataContext
                Dim q = (From row In dc.tPOHeaders Where row.nID = _drPO.nID)
                If q.Count > 0 Then
                    q.First.dSimply = Today.Date
                    q.First.bSimply = True
                End If
                dc.SubmitChanges()
                MessageBox.Show("Sage Updated")
            Else
                MessageBox.Show("Did not update, please  check Sage/Peachtree. (PO line items must exist)")
            End If
        Else
            'user cancelled
        End If


    End Sub

    Private Sub btnSendToSimply_Click(sender As Object, e As EventArgs) Handles btnSendToSimply.Click
        Me.SendToSimply(Me.drPO)
    End Sub

    Private Sub CtrPOHeader1_Load(sender As Object, e As EventArgs) Handles CtrPOHeader1.Load

    End Sub
End Class
