Imports System.Drawing
Imports System.Windows.Forms

Public Class frmShippingScan

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents lvReceiving As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daTrailerHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daShippingHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents timerRefreshScreen As System.Windows.Forms.Timer
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblJob As System.Windows.Forms.Panel
    Friend WithEvents txtJobWorking As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents chkHideScanned As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMarkReceived As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lvReceiving2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvReceiving3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrintReport As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents daPObySPONUM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents btnUnMarkDelivered As System.Windows.Forms.Button
    Friend WithEvents PrintDocumentBarCodeLabel As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmbDamage3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDamageDetail As System.Windows.Forms.TextBox
    Friend WithEvents cmbDamage2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbDamage As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveDamage As System.Windows.Forms.Button
    Friend WithEvents daPOlikeSPONUM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daShippingDetail As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShippingScan))
        Me.lvReceiving = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblJob = New System.Windows.Forms.Panel()
        Me.cmbDamage3 = New System.Windows.Forms.ComboBox()
        Me.txtDamageDetail = New System.Windows.Forms.TextBox()
        Me.cmbDamage2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDamage = New System.Windows.Forms.ComboBox()
        Me.btnSaveDamage = New System.Windows.Forms.Button()
        Me.btnUnMarkDelivered = New System.Windows.Forms.Button()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.btnMarkReceived = New System.Windows.Forms.Button()
        Me.chkHideScanned = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtJobWorking = New System.Windows.Forms.TextBox()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.daTrailerHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daShippingHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.timerRefreshScreen = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvReceiving2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvReceiving3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.daPObySPONUM = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.PrintDocumentBarCodeLabel = New System.Drawing.Printing.PrintDocument()
        Me.daPOlikeSPONUM = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daVendor = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.daShippingDetail = New System.Data.SqlClient.SqlDataAdapter()
        Me.lblJob.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvReceiving
        '
        Me.lvReceiving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReceiving.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvReceiving.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvReceiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiving.FullRowSelect = True
        Me.lvReceiving.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvReceiving.HideSelection = False
        Me.lvReceiving.Location = New System.Drawing.Point(0, 28)
        Me.lvReceiving.MultiSelect = False
        Me.lvReceiving.Name = "lvReceiving"
        Me.lvReceiving.Size = New System.Drawing.Size(336, 457)
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
        Me.ColumnHeader4.Width = 260
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "  JOB:"
        '
        'lblJob
        '
        Me.lblJob.Controls.Add(Me.cmbDamage3)
        Me.lblJob.Controls.Add(Me.txtDamageDetail)
        Me.lblJob.Controls.Add(Me.cmbDamage2)
        Me.lblJob.Controls.Add(Me.Label7)
        Me.lblJob.Controls.Add(Me.cmbDamage)
        Me.lblJob.Controls.Add(Me.btnSaveDamage)
        Me.lblJob.Controls.Add(Me.btnUnMarkDelivered)
        Me.lblJob.Controls.Add(Me.btnPrintReport)
        Me.lblJob.Controls.Add(Me.btnMarkReceived)
        Me.lblJob.Controls.Add(Me.chkHideScanned)
        Me.lblJob.Controls.Add(Me.btnRefresh)
        Me.lblJob.Controls.Add(Me.txtJobWorking)
        Me.lblJob.Controls.Add(Me.Label1)
        Me.lblJob.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblJob.Location = New System.Drawing.Point(740, 0)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(288, 485)
        Me.lblJob.TabIndex = 3
        '
        'cmbDamage3
        '
        Me.cmbDamage3.Items.AddRange(New Object() {"", "Repairable", "Sent Back", "Reorder"})
        Me.cmbDamage3.Location = New System.Drawing.Point(192, 194)
        Me.cmbDamage3.Name = "cmbDamage3"
        Me.cmbDamage3.Size = New System.Drawing.Size(86, 24)
        Me.cmbDamage3.TabIndex = 22
        '
        'txtDamageDetail
        '
        Me.txtDamageDetail.Location = New System.Drawing.Point(19, 222)
        Me.txtDamageDetail.Name = "txtDamageDetail"
        Me.txtDamageDetail.Size = New System.Drawing.Size(250, 22)
        Me.txtDamageDetail.TabIndex = 23
        '
        'cmbDamage2
        '
        Me.cmbDamage2.Items.AddRange(New Object() {"", "Side", "Back", "Door", "Door Front", "Frame", "Shelf", "Drawer"})
        Me.cmbDamage2.Location = New System.Drawing.Point(106, 194)
        Me.cmbDamage2.Name = "cmbDamage2"
        Me.cmbDamage2.Size = New System.Drawing.Size(86, 24)
        Me.cmbDamage2.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(19, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Damage Notes"
        '
        'cmbDamage
        '
        Me.cmbDamage.Items.AddRange(New Object() {"", "Scratched", "Missing Part", "Broken", "Wrong Color", "Wrong Size"})
        Me.cmbDamage.Location = New System.Drawing.Point(19, 194)
        Me.cmbDamage.Name = "cmbDamage"
        Me.cmbDamage.Size = New System.Drawing.Size(96, 24)
        Me.cmbDamage.TabIndex = 26
        '
        'btnSaveDamage
        '
        Me.btnSaveDamage.Location = New System.Drawing.Point(19, 258)
        Me.btnSaveDamage.Name = "btnSaveDamage"
        Me.btnSaveDamage.Size = New System.Drawing.Size(173, 28)
        Me.btnSaveDamage.TabIndex = 21
        Me.btnSaveDamage.Text = "Save Damage Notes"
        '
        'btnUnMarkDelivered
        '
        Me.btnUnMarkDelivered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUnMarkDelivered.Location = New System.Drawing.Point(19, 369)
        Me.btnUnMarkDelivered.Name = "btnUnMarkDelivered"
        Me.btnUnMarkDelivered.Size = New System.Drawing.Size(250, 37)
        Me.btnUnMarkDelivered.TabIndex = 8
        Me.btnUnMarkDelivered.Text = "&UN-Mark Item"
        Me.btnUnMarkDelivered.UseVisualStyleBackColor = False
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.Location = New System.Drawing.Point(19, 480)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(250, 55)
        Me.btnPrintReport.TabIndex = 7
        Me.btnPrintReport.Text = "Print Completed Truck Report"
        '
        'btnMarkReceived
        '
        Me.btnMarkReceived.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMarkReceived.Location = New System.Drawing.Point(19, 314)
        Me.btnMarkReceived.Name = "btnMarkReceived"
        Me.btnMarkReceived.Size = New System.Drawing.Size(250, 37)
        Me.btnMarkReceived.TabIndex = 6
        Me.btnMarkReceived.Text = "&Mark Delivered"
        Me.btnMarkReceived.UseVisualStyleBackColor = False
        '
        'chkHideScanned
        '
        Me.chkHideScanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideScanned.Location = New System.Drawing.Point(19, 83)
        Me.chkHideScanned.Name = "chkHideScanned"
        Me.chkHideScanned.Size = New System.Drawing.Size(192, 28)
        Me.chkHideScanned.TabIndex = 5
        Me.chkHideScanned.Text = "Hide Delivered Items"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(19, 129)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(173, 28)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "&Refresh"
        '
        'txtJobWorking
        '
        Me.txtJobWorking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobWorking.Location = New System.Drawing.Point(19, 28)
        Me.txtJobWorking.Name = "txtJobWorking"
        Me.txtJobWorking.Size = New System.Drawing.Size(183, 30)
        Me.txtJobWorking.TabIndex = 3
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=TZ250;packet size=4096;user id=tksidatauser;data source=DELL-SERVE" & _
    "R;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'daTrailerHeader
        '
        Me.daTrailerHeader.DeleteCommand = Me.SqlDeleteCommand1
        Me.daTrailerHeader.InsertCommand = Me.SqlInsertCommand1
        Me.daTrailerHeader.SelectCommand = Me.SqlSelectCommand1
        Me.daTrailerHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTrailerHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PalletNum", "PalletNum"), New System.Data.Common.DataColumnMapping("SO", "SO"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("ShipDate", "ShipDate"), New System.Data.Common.DataColumnMapping("TrailerControl", "TrailerControl"), New System.Data.Common.DataColumnMapping("FreightTermsCode", "FreightTermsCode"), New System.Data.Common.DataColumnMapping("FreightCode", "FreightCode"), New System.Data.Common.DataColumnMapping("ShipType", "ShipType"), New System.Data.Common.DataColumnMapping("TrailerNumber", "TrailerNumber")})})
        Me.daTrailerHeader.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_PalletNum", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PalletNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightTermsCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightTermsCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerNumber", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrailerNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PalletNum", System.Data.SqlDbType.VarChar, 30, "PalletNum"), New System.Data.SqlClient.SqlParameter("@SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO"), New System.Data.SqlClient.SqlParameter("@ShipDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"), New System.Data.SqlClient.SqlParameter("@TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FreightTermsCode", System.Data.SqlDbType.VarChar, 20, "FreightTermsCode"), New System.Data.SqlClient.SqlParameter("@FreightCode", System.Data.SqlDbType.VarChar, 20, "FreightCode"), New System.Data.SqlClient.SqlParameter("@ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TrailerNumber", System.Data.SqlDbType.VarChar, 20, "TrailerNumber")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT PalletNum, SO, PO, ShipDate, TrailerControl, FreightTermsCode, FreightCode" & _
    ", ShipType, TrailerNumber FROM dbo.tblTrailerHeader ORDER BY PO, PalletNum"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PalletNum", System.Data.SqlDbType.VarChar, 30, "PalletNum"), New System.Data.SqlClient.SqlParameter("@SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO"), New System.Data.SqlClient.SqlParameter("@ShipDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"), New System.Data.SqlClient.SqlParameter("@TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@FreightTermsCode", System.Data.SqlDbType.VarChar, 20, "FreightTermsCode"), New System.Data.SqlClient.SqlParameter("@FreightCode", System.Data.SqlDbType.VarChar, 20, "FreightCode"), New System.Data.SqlClient.SqlParameter("@ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TrailerNumber", System.Data.SqlDbType.VarChar, 20, "TrailerNumber"), New System.Data.SqlClient.SqlParameter("@Original_PalletNum", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PalletNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FreightTermsCode", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FreightTermsCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipType", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ShipType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerControl", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TrailerControl", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TrailerNumber", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrailerNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daShippingHeader
        '
        Me.daShippingHeader.DeleteCommand = Me.SqlDeleteCommand3
        Me.daShippingHeader.InsertCommand = Me.SqlInsertCommand3
        Me.daShippingHeader.SelectCommand = Me.SqlSelectCommand3
        Me.daShippingHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblShippingHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierCode", "SupplierCode"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("SupplierSONum", "SupplierSONum"), New System.Data.Common.DataColumnMapping("OrderStatus", "OrderStatus"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("StyleDesc", "StyleDesc"), New System.Data.Common.DataColumnMapping("DateImported", "DateImported"), New System.Data.Common.DataColumnMapping("DateCompletion", "DateCompletion"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("DateOrder", "DateOrder"), New System.Data.Common.DataColumnMapping("OrderLines", "OrderLines"), New System.Data.Common.DataColumnMapping("TotalCabs", "TotalCabs")})})
        Me.daShippingHeader.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.sqlConn
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateCompletion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateCompletion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateImported", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateImported", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateOrder", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.sqlConn
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierCode", System.Data.SqlDbType.VarChar, 50, "SupplierCode"), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO"), New System.Data.SqlClient.SqlParameter("@SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateCompletion", System.Data.SqlDbType.DateTime, 8, "DateCompletion"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.DateTime, 8, "DateClosed"), New System.Data.SqlClient.SqlParameter("@DateOrder", System.Data.SqlDbType.DateTime, 8, "DateOrder"), New System.Data.SqlClient.SqlParameter("@OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT SupplierCode, PO, SupplierSONum, OrderStatus, StyleCode, StyleDesc, DateIm" & _
    "ported, DateCompletion, DateClosed, DateOrder, OrderLines, TotalCabs FROM dbo.tb" & _
    "lShippingHeader ORDER BY PO"
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.sqlConn
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierCode", System.Data.SqlDbType.VarChar, 50, "SupplierCode"), New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO"), New System.Data.SqlClient.SqlParameter("@SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateCompletion", System.Data.SqlDbType.DateTime, 8, "DateCompletion"), New System.Data.SqlClient.SqlParameter("@DateClosed", System.Data.SqlDbType.DateTime, 8, "DateClosed"), New System.Data.SqlClient.SqlParameter("@DateOrder", System.Data.SqlDbType.DateTime, 8, "DateOrder"), New System.Data.SqlClient.SqlParameter("@OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PO", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierSONum", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateClosed", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateClosed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateCompletion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateCompletion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateImported", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateImported", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateOrder", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderLines", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderLines", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderStatus", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "OrderStatus", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_StyleDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "StyleDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierCode", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCabs", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TotalCabs", System.Data.DataRowVersion.Original, Nothing)})
        '
        'timerRefreshScreen
        '
        Me.timerRefreshScreen.Enabled = True
        Me.timerRefreshScreen.Interval = 48000
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(740, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Shipping: "
        '
        'lvReceiving2
        '
        Me.lvReceiving2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReceiving2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvReceiving2.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvReceiving2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiving2.FullRowSelect = True
        Me.lvReceiving2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvReceiving2.HideSelection = False
        Me.lvReceiving2.Location = New System.Drawing.Point(336, 28)
        Me.lvReceiving2.MultiSelect = False
        Me.lvReceiving2.Name = "lvReceiving2"
        Me.lvReceiving2.Size = New System.Drawing.Size(307, 457)
        Me.lvReceiving2.TabIndex = 5
        Me.lvReceiving2.UseCompatibleStateImageBehavior = False
        Me.lvReceiving2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 240
        '
        'lvReceiving3
        '
        Me.lvReceiving3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReceiving3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvReceiving3.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvReceiving3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiving3.FullRowSelect = True
        Me.lvReceiving3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvReceiving3.HideSelection = False
        Me.lvReceiving3.Location = New System.Drawing.Point(643, 28)
        Me.lvReceiving3.MultiSelect = False
        Me.lvReceiving3.Name = "lvReceiving3"
        Me.lvReceiving3.Size = New System.Drawing.Size(303, 457)
        Me.lvReceiving3.TabIndex = 6
        Me.lvReceiving3.UseCompatibleStateImageBehavior = False
        Me.lvReceiving3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Width = 240
        '
        'PrintDocument1
        '
        '
        'daPObySPONUM
        '
        Me.daPObySPONUM.SelectCommand = Me.SqlSelectCommand5
        Me.daPObySPONUM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPObySPONUM.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum")})
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.sqlConn
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'PrintDocumentBarCodeLabel
        '
        '
        'daPOlikeSPONUM
        '
        Me.daPOlikeSPONUM.SelectCommand = Me.SqlCommand1
        Me.daPOlikeSPONUM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPOlikeSPONUM.UpdateCommand = Me.SqlCommand2
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.sqlConn
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum")})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Connection = Me.sqlConn
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daVendor
        '
        Me.daVendor.SelectCommand = Me.SqlCommand3
        Me.daVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT     lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZi" & _
    "p, sPhone1, sPhone2, sFax, IgnoreScheduling" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         tVendor"
        Me.SqlCommand3.Connection = Me.sqlConn
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM dbo.tblShippingItems WHERE (LineNumber = @Original_LineNumber)"
        Me.SqlDeleteCommand4.Connection = Me.sqlConn
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.sqlConn
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierSO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@ProdDesc", System.Data.SqlDbType.VarChar, 50, "ProdDesc"), New System.Data.SqlClient.SqlParameter("@CabType", System.Data.SqlDbType.VarChar, 50, "CabType"), New System.Data.SqlClient.SqlParameter("@ColorDesc", System.Data.SqlDbType.VarChar, 50, "ColorDesc"), New System.Data.SqlClient.SqlParameter("@ColorCode", System.Data.SqlDbType.VarChar, 50, "ColorCode"), New System.Data.SqlClient.SqlParameter("@ProdCode", System.Data.SqlDbType.VarChar, 50, "ProdCode"), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateReceived", System.Data.SqlDbType.DateTime, 8, "DateReceived"), New System.Data.SqlClient.SqlParameter("@DateDelivered", System.Data.SqlDbType.DateTime, 8, "DateDelivered"), New System.Data.SqlClient.SqlParameter("@DateLastChanged", System.Data.SqlDbType.DateTime, 8, "DateLastChanged"), New System.Data.SqlClient.SqlParameter("@SpecialNote1", System.Data.SqlDbType.VarChar, 255, "SpecialNote1"), New System.Data.SqlClient.SqlParameter("@SpecialNote2", System.Data.SqlDbType.VarChar, 255, "SpecialNote2"), New System.Data.SqlClient.SqlParameter("@QuantityRec", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityRec", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@QuantityDel", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityDel", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.sqlConn
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SupplierSO", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "SupplierSO", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@LineNumber", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LineNumber", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@ProdDesc", System.Data.SqlDbType.VarChar, 50, "ProdDesc"), New System.Data.SqlClient.SqlParameter("@CabType", System.Data.SqlDbType.VarChar, 50, "CabType"), New System.Data.SqlClient.SqlParameter("@ColorDesc", System.Data.SqlDbType.VarChar, 50, "ColorDesc"), New System.Data.SqlClient.SqlParameter("@ColorCode", System.Data.SqlDbType.VarChar, 50, "ColorCode"), New System.Data.SqlClient.SqlParameter("@ProdCode", System.Data.SqlDbType.VarChar, 50, "ProdCode"), New System.Data.SqlClient.SqlParameter("@StyleCode", System.Data.SqlDbType.VarChar, 50, "StyleCode"), New System.Data.SqlClient.SqlParameter("@StyleDesc", System.Data.SqlDbType.VarChar, 50, "StyleDesc"), New System.Data.SqlClient.SqlParameter("@DateImported", System.Data.SqlDbType.DateTime, 8, "DateImported"), New System.Data.SqlClient.SqlParameter("@DateReceived", System.Data.SqlDbType.DateTime, 8, "DateReceived"), New System.Data.SqlClient.SqlParameter("@DateDelivered", System.Data.SqlDbType.DateTime, 8, "DateDelivered"), New System.Data.SqlClient.SqlParameter("@DateLastChanged", System.Data.SqlDbType.DateTime, 8, "DateLastChanged"), New System.Data.SqlClient.SqlParameter("@SpecialNote1", System.Data.SqlDbType.VarChar, 255, "SpecialNote1"), New System.Data.SqlClient.SqlParameter("@SpecialNote2", System.Data.SqlDbType.VarChar, 255, "SpecialNote2"), New System.Data.SqlClient.SqlParameter("@QuantityRec", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityRec", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@QuantityDel", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "QuantityDel", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO")})
        '
        'daShippingDetail
        '
        Me.daShippingDetail.DeleteCommand = Me.SqlDeleteCommand4
        Me.daShippingDetail.InsertCommand = Me.SqlInsertCommand4
        Me.daShippingDetail.SelectCommand = Me.SqlSelectCommand4
        Me.daShippingDetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblShippingItems", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierSO", "SupplierSO"), New System.Data.Common.DataColumnMapping("LineNumber", "LineNumber"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("ProdDesc", "ProdDesc"), New System.Data.Common.DataColumnMapping("CabType", "CabType"), New System.Data.Common.DataColumnMapping("ColorDesc", "ColorDesc"), New System.Data.Common.DataColumnMapping("ColorCode", "ColorCode"), New System.Data.Common.DataColumnMapping("ProdCode", "ProdCode"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("StyleDesc", "StyleDesc"), New System.Data.Common.DataColumnMapping("DateImported", "DateImported"), New System.Data.Common.DataColumnMapping("DateReceived", "DateReceived"), New System.Data.Common.DataColumnMapping("DateDelivered", "DateDelivered"), New System.Data.Common.DataColumnMapping("DateLastChanged", "DateLastChanged"), New System.Data.Common.DataColumnMapping("SpecialNote1", "SpecialNote1"), New System.Data.Common.DataColumnMapping("SpecialNote2", "SpecialNote2"), New System.Data.Common.DataColumnMapping("QuantityRec", "QuantityRec"), New System.Data.Common.DataColumnMapping("QuantityDel", "QuantityDel")})})
        Me.daShippingDetail.UpdateCommand = Me.SqlUpdateCommand4
        '
        'frmShippingScan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1028, 485)
        Me.Controls.Add(Me.lvReceiving3)
        Me.Controls.Add(Me.lvReceiving2)
        Me.Controls.Add(Me.lvReceiving)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJob)
        Me.Name = "frmShippingScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.lblJob.ResumeLayout(False)
        Me.lblJob.PerformLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private selectedTruck As String = ""
    Private PrintPages As Integer
    Private InsCountPrinted As Integer
    Private FinalPageCount As Integer
    Private yy As Integer
    Private Lines As ArrayList
    Dim daLocBin As New dsTKSITableAdapters.tblLocationBinsTableAdapter
    Dim daLocBinJOIN As New dsTKSITableAdapters.tblLocationLabelJOINTableAdapter
    Dim daTrailerDetail As New dsTKSITableAdapters.tblTrailerDetailTableAdapter
    Dim daShipHead As New dsTKSITableAdapters.tblShippingHeaderTableAdapter

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

    Private Sub timerRefreshScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerRefreshScreen.Tick
        RefreshItemsList()
    End Sub

    Dim alPOlist As New ArrayList
    Private Structure structPOlist
        Dim sPO As String
        Dim blnHasShippingLines As Boolean
        Dim otherInfo As String
    End Structure

    Private Sub CheckPOinHasShippingItemslist(ByVal sPOtocheck As String)
        Dim structPOlist1 As structPOlist
        Dim i As Integer = 0
        For i = 0 To Me.alPOlist.Count - 1
            structPOlist1 = Me.alPOlist(i)
            If sPOtocheck = structPOlist1.sPO Then
                'has shipping lines
                structPOlist1.blnHasShippingLines = True
                Me.alPOlist(i) = structPOlist1
            End If
        Next
        'For Each structPOlist1 In Me.alPOlist
        '    If sPOtocheck = structPOlist1.sPO Then
        '        'has shipping lines
        '        structPOlist1.blnHasShippingLines = True
        '    End If
        'Next
    End Sub

    Private Sub RefreshItemsList()

        If Me.txtJobWorking.Text.Trim.Length > 2 Then
            Try
                Me.DsTKSI1.tblLocationLabelJOIN.Clear()
                '  Me.daLocationLabelJOIN.SelectCommand.Parameters("PO").Value = Me.txtJobWorking.Text.Trim & "%"
                ' Me.daLocationLabelJOIN.Fill(Me.DsTKSI1.tblLocationLabelJOIN)
                Me.daLocBinJOIN.FillByPOHeaderLike(Me.DsTKSI1.tblLocationLabelJOIN, Me.txtJobWorking.Text.Trim & "%")

            Catch ex As Exception

            End Try

            Try
                'build a list of all POs in this job
                'later when populating screen with shipping items
                'mark which POs in this list have shipping items and which do not
                'so that we may show the POs that do not have any shipping items at the top
                'previously the POs with no shipping items wouldnt show anywhere in this screen

                Me.DsTKSI1.tPOHeader.Clear()
                Me.daPOlikeSPONUM.SelectCommand.Parameters("@sPONum").Value = Me.txtJobWorking.Text.Trim & "%"
                Me.daPOlikeSPONUM.Fill(Me.DsTKSI1.tPOHeader)
                Me.alPOlist.Clear()

                Me.DsTKSI1.tVendor.Clear()
                Me.daVendor.Fill(Me.DsTKSI1.tVendor)

                Dim dr As dsTKSI.tPOHeaderRow
                For Each dr In Me.DsTKSI1.tPOHeader
                    'ignore labor POs we dont want them showing up at the top even though they dont have
                    'any shipping lines
                    If dr.nAccount <> 4040 And dr.dPODate > Now.AddYears(-2) Then

                        Dim structPOlist1 As structPOlist
                        With structPOlist1
                            .sPO = dr.sPONum
                            .blnHasShippingLines = False
                            .otherInfo = dr.tVendorRow.sName
                        End With
                        Me.alPOlist.Add(structPOlist1)
                    End If
                Next

            Catch ex As Exception
            End Try

            Me.lvReceiving.Items.Clear()
            Me.lvReceiving2.Items.Clear()
            Me.lvReceiving3.Items.Clear()

            Me.lvReceiving.SuspendLayout()
            Me.lvReceiving2.SuspendLayout()
            Me.lvReceiving3.SuspendLayout()

            With Me.DsTKSI1
                .tblTrailerDetail.Clear()
                .tblShippingItems.Clear()
                If Me.txtJobWorking.Text.Trim.Length > 0 Then
                    If Me.daTrailerDetail.FillByPOlocaltable(Me.DsTKSI1.tblTrailerDetail, Me.txtJobWorking.Text.Trim & "%") > 0 Then
                        'use these modern settings (KC new settings)
                    Else
                        'use standard (crestwood)
                        Me.DsTKSI1.tblTrailerDetail.Clear()
                        Me.daTrailerDetail.FillByLikePO(Me.DsTKSI1.tblTrailerDetail, Me.txtJobWorking.Text.Trim & "%")
                    End If

                    Me.DsTKSI1.tblShippingItems.Clear()
                    Me.daShippingDetail.SelectCommand.Parameters("@PO").Value = Me.txtJobWorking.Text.Trim & "%"
                    Me.daShippingDetail.Fill(Me.DsTKSI1.tblShippingItems)

                End If
            End With

            Dim drHeader As dsTKSI.tblTrailerHeaderRow
            Dim drDetail As dsTKSI.tblTrailerDetailRow

            Dim lastPO As String = ""
            Dim drOrderLine As dsTKSI.tblShippingItemsRow

            'move to second listview after 2nd PO
            Dim lvToAddTo As ListView
            Dim i As Long = 0
            Dim colorOfItem As Color = Color.Red
            Dim blnAddItemToListView As Boolean = True

            Dim daShipItem As New TKSIJOBSDataSetTableAdapters.tblShippingItemsTableAdapter
            Dim daShipHead1 As New TKSIJOBSDataSetTableAdapters.tblShippingHeaderTableAdapter

            For Each drDetail In Me.DsTKSI1.tblTrailerDetail
                'reset color on loop
                colorOfItem = Color.White

                blnAddItemToListView = True
                drHeader = drDetail.tblTrailerHeaderRow
                'For Each drHeader In Me.DsTKSI1.tblTrailerHeader
                'Draw new header line for each new PO Number

                Dim itemHeader As ListViewItem
                Dim strCurrentPO As String = ""

                If Not drDetail.IspoNull Then
                    strCurrentPO = drDetail.po
                ElseIf Not drDetail.IsSupplierSONull Then
                    If daShipHead.FillBySupplierSO(Me.DsTKSI1.tblShippingHeader, drDetail.SupplierSO) > 0 Then
                        strCurrentPO = Me.DsTKSI1.tblShippingHeader(0).PO
                    Else
                        If Not drHeader Is Nothing Then
                            strCurrentPO = drHeader.PO
                        End If
                    End If
                End If

                If lastPO <> strCurrentPO Then
                    'new unique po num, check to see if in list of flagged POs with or without shipping items
                    CheckPOinHasShippingItemslist(strCurrentPO)

                    i += 1
                    If i = 1 Then
                        lvToAddTo = Me.lvReceiving
                    ElseIf i = 2 Then
                        lvToAddTo = Me.lvReceiving2
                    Else
                        lvToAddTo = Me.lvReceiving3
                    End If

                    itemHeader = New ListViewItem(drHeader.TrailerControl)
                    itemHeader.SubItems.Add(strCurrentPO)
                    itemHeader.BackColor = Color.LightGray
                    itemHeader.Font = New Font(itemHeader.Font, FontStyle.Bold)
                    lvToAddTo.Items.Add(itemHeader)
                    Me.Label2.Text = "Shipping PO's: " & strCurrentPO
                End If

                Dim str As String = ""
                str = (drDetail.OrderLineNumber)

                Dim draBin As dsTKSI.tblLocationLabelJOINRow()
                draBin = Me.DsTKSI1.tblLocationLabelJOIN.Select("TrailerlLabelID='" & drDetail.LabelID & "'")
                If draBin.Length > 0 Then

                    Try
                        itemHeader.SubItems(1).Text = itemHeader.SubItems(1).Text & LocationToShortName(draBin(0).tblLocationBinsRow.LabelID)
                        str = str & LocationToShortName(draBin(0).tblLocationBinsRow.LabelID)
                    Catch ex As Exception
                        'dont crash on this error showing bin locations
                        Me.Text = ex.Message
                    End Try
                Else
                    str = str & "     - "
                End If

                drOrderLine = Me.DsTKSI1.tblShippingItems.FindBySupplierSOLineNumber(drHeader.SO, drDetail.OrderLineNumber)

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
                        If daShipHead1.FillBySO(dtHead, drDetail.SupplierSO) > 0 Then
                            str = str & dtHead(0).StyleDesc & "  **"
                        Else
                            str = str & Replace(drDetail.DetailDescription, "000", "")
                        End If
                    End If

                Else
                    str = str & Replace(drDetail.DetailDescription, "000", "")
                End If

                str = str & drDetail.DetailDescription

                If drDetail.IsDeliveredTKSINull Then
                    If drDetail.IsDateScannedTKSINull Then
                        colorOfItem = Color.White
                    Else
                        colorOfItem = Color.Yellow

                    End If
                Else
                    colorOfItem = Color.LightGreen

                    If Me.chkHideScanned.Checked Then
                        If Not drDetail.IsDeliveredTKSINull Then
                            blnAddItemToListView = False
                        End If
                    End If
                End If

                If blnAddItemToListView Then
                    Dim item1 As ListViewItem
                    item1 = New ListViewItem(drDetail.LabelID)
                    item1.SubItems.Add(str)
                    item1.BackColor = colorOfItem
                    lvToAddTo.Items.Add(item1)
                End If

                lastPO = strCurrentPO

            Next

            'populate top of first list view with POs that dont have any shipping lines and are flagged in arraylist as such
            Dim structPO1 As structPOlist
            Dim j As Integer = 0
            For Each structPO1 In Me.alPOlist
                If Not structPO1.blnHasShippingLines Then
                    Dim itemheader As New ListViewItem
                    itemheader.Text = ""
                    itemheader.SubItems.Add(structPO1.sPO & " - " & structPO1.otherInfo)
                    itemheader.BackColor = Color.LightGray
                    itemheader.Font = New Font(itemheader.Font, FontStyle.Bold)
                    Me.lvReceiving.Items.Insert(j, itemheader)
                    j += 1
                End If
            Next

            Me.lvReceiving.ResumeLayout(True)
            Me.lvReceiving2.ResumeLayout(True)
            Me.lvReceiving3.ResumeLayout(True)

            Me.lvReceiving.Refresh()
            Me.lvReceiving2.Refresh()
            Me.lvReceiving3.Refresh()
        End If

    End Sub

    Private Sub frmReceivingStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DsTKSI1.tblTrailerHeader.Clear()
        Me.daTrailerHeader.Fill(Me.DsTKSI1.tblTrailerHeader)

        Me.DsTKSI1.tblShippingHeader.Clear()
        Me.daShippingHeader.Fill(Me.DsTKSI1.tblShippingHeader)


        Me.DsTKSI1.tblLocationBins.Clear()
        ' Me.daLocationBins.Fill(Me.DsTKSI1.tblLocationBins)
        daLocBin.Fill(Me.DsTKSI1.tblLocationBins)


    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshItemsList()
    End Sub

    Private Sub btnMarkDelivered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkReceived.Click
        MarkItemDelivered(True)
    End Sub

    Private Sub MarkItemDelivered(ByVal blnMarkDelivered As Boolean)
        Dim blnOneItemToMark As Boolean = False
        Dim label As String = ""
        Dim lv As ListView
        If Me.lvReceiving.SelectedItems.Count >= 1 Then
            label = Me.lvReceiving.SelectedItems(0).Text
            lv = Me.lvReceiving
            blnOneItemToMark = True
        End If
        If Me.lvReceiving2.SelectedItems.Count >= 1 Then
            label = Me.lvReceiving2.SelectedItems(0).Text
            blnOneItemToMark = True
            lv = Me.lvReceiving2
        End If
        If Me.lvReceiving3.SelectedItems.Count >= 1 Then
            label = Me.lvReceiving3.SelectedItems(0).Text
            blnOneItemToMark = True
            lv = Me.lvReceiving3
        End If

        If blnOneItemToMark Then
            Me.timerRefreshScreen.Stop()
            Me.timerRefreshScreen.Start()

            Dim drDetail As dsTKSI.tblTrailerDetailRow
            drDetail = Me.DsTKSI1.tblTrailerDetail.FindByLabelID(label)
            If Not drDetail Is Nothing Then

                Try

                    If blnMarkDelivered Then
                        If drDetail.IsDateScannedTKSINull Then
                            drDetail.DateScannedTKSI = Now
                        End If
                        If drDetail.IsDeliveredTKSINull Then
                            drDetail.DeliveredTKSI = Now
                        End If
                        lv.SelectedItems(0).BackColor = Color.LightGreen
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

                    Me.daTrailerDetail.Update(Me.DsTKSI1.tblTrailerDetail)
                    Me.DsTKSI1.tblTrailerDetail.AcceptChanges()

                    lv.SelectedItems(0).Selected = False

                    'Else
                    '    Windows.Forms.MessageBox.Show("Error could not locate order line for this label.")
                    'End If

                Catch ex As Exception
                    Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Else
                Windows.Forms.MessageBox.Show("could not locate line item to set delivered.")
            End If

        End If
    End Sub

    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click

        Try
            Me.PopulateArrayWithReportData()


            Dim print1 As New System.Drawing.Printing.PageSettings
            print1.Landscape = False

    

            If ISDebugMachine Then

            Else
                print1.PrinterSettings.PrinterName = global_DefaultPrinter() ' "\\Mark-PC\Mark-HP"
            End If

            With print1
                Try
                    Dim paper As Long
                    paper = GetLetterPaperEnum(print1)
                    If paper >= 0 Then
                        .PaperSize = .PrinterSettings.PaperSizes(paper)
                    End If
                Catch ex As Exception
                End Try
                .PrinterSettings.FromPage = 1
                .PrinterSettings.ToPage = 500
                .PrinterSettings.MinimumPage = 1
                .PrinterSettings.MaximumPage = 500
                If ISDebugMachine Then

                Else
                    .PrinterSettings.PrinterName = global_DefaultPrinter() '"\\Mark-PC\Mark-HP"
                End If

                .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                .Margins.Bottom = 40
                .Margins.Left = 30
                .Margins.Top = 40
                .Margins.Right = 30
            End With

            With Me.PrintDocument1
                .DefaultPageSettings = print1
                .DocumentName = "Delivery Report"
                '.Print()

                Dim preview As New frmPrintPreview
                If Me.FinalPageCount = 0 Then Me.FinalPageCount = 20
                preview.FinalPageCount = Me.FinalPageCount
                preview.PrintPreviewControl1.Document = Me.PrintDocument1
                preview.WindowState = FormWindowState.Maximized
                preview.PrintPreviewControl1.Document.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                preview.ShowDialog()
            End With

            If Windows.Forms.MessageBox.Show("Do you want to update Supplier Report Delivered Date?", "Update Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Me.UpdateTKSIDelivery()
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PopulateArrayWithReportData()
        Dim frmbusy1 As New frmWorking
        frmbusy1.Text = frmbusy1.Text & " Shipping Scan..."
        frmbusy1.Show()
        Try
            Lines = New ArrayList

            Dim drHeader As dsTKSI.tblTrailerHeaderRow
            Dim drDetail As dsTKSI.tblTrailerDetailRow
            Dim lastPO As String = ""
            'Dim drOrderLine As dsTKSI.tblShippingItemsRow
            Dim printLine As DetailLine

            'trailer header is not 1 for 1 for unique PO numbers
            'there can be 2 trailer headers for one PO
            'so we have to loop the trailer details sorted by PO to be unique set of PO
            For Each drDetail In Me.DsTKSI1.tblTrailerDetail
                drHeader = drDetail.tblTrailerHeaderRow

                Dim sPO As String = ""
                If drDetail.IspoNull Then
                    sPO = drHeader.PO
                Else
                    sPO = drDetail.po
                End If

                Dim blnAlreadyDeliveredOnAPreviousDay As Boolean = False
                'dont print out stuff that was delivered on previous days
                If drDetail.IsDeliveredTKSINull Then
                    blnAlreadyDeliveredOnAPreviousDay = False
                Else
                    If drDetail.DeliveredTKSI > Date.Today.AddDays(-3) Then
                        blnAlreadyDeliveredOnAPreviousDay = False
                    Else
                        blnAlreadyDeliveredOnAPreviousDay = True
                    End If
                End If

                If Not blnAlreadyDeliveredOnAPreviousDay Then


                    If UCase(Mid(sPO, 1, Me.txtJobWorking.Text.Trim.Length)) = UCase(Me.txtJobWorking.Text) Then
                        'Dim drItemHeader As dsTKSI.tblShippingHeaderRow
                        If lastPO <> sPO Then

                            'drItemHeader = Me.DsTKSI1.tblShippingHeader.FindByPOSupplierSONum(drHeader.PO, drHeader.SO)
                            'If Not drItemHeader Is Nothing Then
                            printLine = New DetailLine
                            With printLine
                                .damageNotes = ""
                                '  If Not drDetail.IsDamageNotesNull Then .damageNotes = drDetail.DamageNotes
                                .damageNotes = drDetail.DamageNotes
                                .NotReceivedCount = 0 'drItemHeader.OrderLines - drHeader.GettblTrailerDetailRows.Length
                                .PO = sPO
                                .poLineNumber = drDetail.OrderLineNumber
                                .ReceivedCount = 0 'drHeader.GettblTrailerDetailRows.Length
                                .newPOLine = True
                                .styleInfo = drDetail.DetailDescription ' drItemHeader.StyleDesc

                                'figure # of line items that did not get scanned
                                Dim drDetail2 As dsTKSI.tblTrailerDetailRow
                                For Each drDetail2 In Me.DsTKSI1.tblTrailerDetail
                                    Dim sPO2 As String = ""
                                    If drDetail2.IspoNull Then
                                        sPO2 = drDetail2.tblTrailerHeaderRow.PO
                                    Else
                                        sPO2 = drDetail2.po
                                    End If

                                    If sPO2 = sPO Then
                                        If drDetail2.IsDeliveredTKSINull Then
                                            .UnScannedLines += 1
                                        Else
                                            .ScannedLines += 1
                                        End If
                                    End If
                                Next

                            End With

                            Me.Lines.Add(printLine)

                        End If

                        If drDetail.IsDeliveredTKSINull Then
                            'not Scanned Received
                            printLine = New DetailLine
                            With printLine
                                .damageNotes = "NOT DELIVERED "
                                .damageNotes = drDetail.DamageNotes
                                .NotReceivedCount = 1
                                .PO = sPO
                                .poLineNumber = drDetail.OrderLineNumber
                                .ReceivedCount = 0
                                .newPOLine = False
                                .styleInfo = drDetail.DetailDescription
                                .UnScannedLines = 0
                                .ScannedLines = 1
                                .ItemsNotOntruck = 0
                                .OrderConfLines = 0
                            End With
                            Me.Lines.Add(printLine)

                        Else
                            ' marked as delivered
                            printLine = New DetailLine
                            With printLine
                                .damageNotes = ""
                                .damageNotes = drDetail.DamageNotes
                                .NotReceivedCount = 0
                                .PO = sPO
                                .poLineNumber = drDetail.OrderLineNumber
                                .ReceivedCount = 1
                                .newPOLine = False
                                .styleInfo = drDetail.DetailDescription 'drOrderLine.ProdDesc
                                .UnScannedLines = 0
                                .ScannedLines = 1
                                .ItemsNotOntruck = 0
                                .OrderConfLines = 0
                            End With
                            Me.Lines.Add(printLine)
                        End If

                    Else
                        'line item on wrong truck, dont bother 
                    End If
                Else
                    'line item already delivered on previous day
                End If

                lastPO = sPO
            Next

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            frmbusy1.Close()
        End Try
    End Sub

    Private Sub UpdateTKSIDelivery()

        Dim det1 As DetailLine

        For Each det1 In Me.Lines
            With det1
                If .newPOLine Then
                    If .ScannedLines > .UnScannedLines And .ScannedLines > .ItemsNotOntruck And .ScannedLines > 0 Then
                        Me.DsTKSI1.tPOHeader.Clear()
                        Me.daPObySPONUM.SelectCommand.Parameters("@sPONum").Value = det1.PO
                        Me.daPObySPONUM.Fill(Me.DsTKSI1.tPOHeader)
                        Dim dr As dsTKSI.tPOHeaderRow
                        If Me.DsTKSI1.tPOHeader.Rows.Count = 1 Then

                            dr = Me.DsTKSI1.tPOHeader.Rows(0)

                            If det1.damageNotes.Length > 0 Then
                                dr.SDELNOTES = Replace(dr.SDELNOTES, "NOT DELIVERED ", "") & " " & det1.damageNotes
                            End If

                            If dr.IsDDELNull Then
                                dr.DDEL = Now.Date
                            End If

                            If dr.IsDRECNull Then
                                dr.DREC = Now.Date
                            End If
                        End If


                        Me.daPObySPONUM.Update(Me.DsTKSI1.tPOHeader)
                        Me.DsTKSI1.tPOHeader.AcceptChanges()
                    Else
                        'Windows.Forms.MessageBox.Show(det1.PO & " not updated.")
                    End If
                End If

            End With
        Next

        If Me.Lines.Count > 0 Then
            Dim strPO As String = ""
            strPO = CType(Me.Lines(0), DetailLine).PO
            ExecuteNETAutoEmailerForBackorders(strPO)
        End If

    End Sub

    Private Sub ExecuteNETAutoEmailerForBackorders(ByVal sPOfilter As String)
        'Shell(Application.StartupPath & "\tksi.net.exe /notifybackorder", AppWinStyle.MinimizedNoFocus)
        Try
            Dim frm1 As New frmNotifyBackorder
            frm1.sPOfilter = sPOfilter
            frm1.Show()
            frm1.Close()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintPages = PrintPages + 1
        e.HasMorePages = DrawAll(e.Graphics)
        If Not e.HasMorePages Then
            FinalPageCount = PrintPages
            PrintPages = 0
            InsCountPrinted = 0
        End If
    End Sub

    Private Function DrawAll(ByVal g As Graphics) As Boolean

        'Dim grandtotalCount As Long

        yy = 50

        Dim row1 As New ArrayList
        'Dim sDraw As String
        row1.Add("PO Delivery Report : " & Now.ToShortDateString & "   " & Me.txtJobWorking.Text)
        printRow(g, row1)

        row1 = New ArrayList

        row1.Add("PO")
        row1.Add("Unscanned")
        row1.Add("Lines on diff Trk")
        row1.Add("Total Order Lines")
        row1.Add("")

        printRow(g, row1)

        printHorLine(g)

        'Dim lastType As String
        Dim detail1 As DetailLine

        Dim thisGraphicsPrintCount As Long
        Dim loopCount As Long
        For Each detail1 In Me.Lines
            loopCount = loopCount + 1
            If ((loopCount > InsCountPrinted) Or (InsCountPrinted = 0)) Then
                If yy > 1000 Then
                    InsCountPrinted = InsCountPrinted + thisGraphicsPrintCount
                    Return True
                End If
                thisGraphicsPrintCount = thisGraphicsPrintCount + 1

                row1 = New ArrayList
                With row1
                    If detail1.newPOLine Then
                        .Add(detail1.PO)
                    Else
                        .Add("")
                    End If

                    If detail1.UnScannedLines = 0 Then
                        .Add("")
                    Else
                        .Add(detail1.UnScannedLines)
                    End If

                    If detail1.ItemsNotOntruck = 0 Then
                        .Add("")
                    Else
                        .Add(detail1.ItemsNotOntruck)
                    End If

                    If detail1.OrderConfLines = 0 Then
                        .Add("")
                    Else
                        .Add(detail1.OrderConfLines)
                    End If


                    .Add(detail1.damageNotes & "       Ln:" & detail1.poLineNumber & " - " & detail1.styleInfo)

                    .Add("")
                End With

                printRow(g, row1)
            End If
            If loopCount > 10000 Then Return False
        Next

        printHorLine(g)

    End Function

    Private Sub printRow(ByVal g As Graphics, ByVal col1 As ArrayList)
        Dim xx As Double
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
                    xx = xx + 120
                Case 5
                    xx = xx + 120
                Case Else
                    xx = xx + 120
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

    Private Sub lvReceiving_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvReceiving.DoubleClick, lvReceiving2.DoubleClick, lvReceiving3.DoubleClick
        Me.MarkItemDelivered(True)
    End Sub

    Private Sub btnUnMarkDelivered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnMarkDelivered.Click
        Dim blnOneItemToMark As Boolean = False
        Dim label As String = ""
        Dim lv As ListView
        If Me.lvReceiving.SelectedItems.Count >= 1 Then
            label = Me.lvReceiving.SelectedItems(0).Text
            lv = Me.lvReceiving
            blnOneItemToMark = True
        End If
        If Me.lvReceiving2.SelectedItems.Count >= 1 Then
            label = Me.lvReceiving2.SelectedItems(0).Text
            blnOneItemToMark = True
            lv = Me.lvReceiving2
        End If
        If Me.lvReceiving3.SelectedItems.Count >= 1 Then
            label = Me.lvReceiving3.SelectedItems(0).Text
            blnOneItemToMark = True
            lv = Me.lvReceiving3
        End If

        If blnOneItemToMark Then
            Me.timerRefreshScreen.Stop()
            Me.timerRefreshScreen.Start()

            Dim drDetail As dsTKSI.tblTrailerDetailRow
            drDetail = Me.DsTKSI1.tblTrailerDetail.FindByLabelID(label)
            If Not drDetail Is Nothing Then

                Try
                    If Not drDetail.IsDeliveredTKSINull Then
                        drDetail.SetDeliveredTKSINull()
                    End If
                    Me.daTrailerDetail.Update(Me.DsTKSI1.tblTrailerDetail)
                    Me.DsTKSI1.tblTrailerDetail.AcceptChanges()

                    If drDetail.IsDateScannedTKSINull Then
                        lv.SelectedItems(0).BackColor = Color.Yellow
                    Else
                        lv.SelectedItems(0).BackColor = Color.White
                    End If

                    lv.SelectedItems.Clear()

                Catch ex As Exception
                    Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Else
                Windows.Forms.MessageBox.Show("could not locate line item to mark UN Delivered.")
            End If

        End If
    End Sub

    Private Sub PrintLabel(ByVal drTD As dsTKSI.tblTrailerDetailRow)
        line4BarCode = drTD.LabelID
        line3 = drTD.tblTrailerHeaderRow.PO
        '  If Not drTD.IsDamageNotesNull Then
        line3 = line3 & "   " & drTD.DamageNotes
        '  End If

        Try
            line1 = drTD.tblTrailerHeaderRow.FreightCode
            line2 = ""
        Catch ex As Exception
            line2 = "error"
        End Try

        With Me.PrintDocumentBarCodeLabel

            .DocumentName = "Shipping Label"
            .PrinterSettings.PrinterName = "\\Warehouse1\ZebraLP2dock"
            .PrinterSettings.DefaultPageSettings.Margins.Left = 20
            .PrinterSettings.DefaultPageSettings.Margins.Right = 5
            .PrinterSettings.DefaultPageSettings.Margins.Top = 20
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 5

        End With
        Me.PrintDocumentBarCodeLabel.Print()
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

    Private Sub PrintDocumentBarCodeLabel_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentBarCodeLabel.PrintPage
        e.HasMorePages = Me.DrawLabelGraphics(e.Graphics)
    End Sub

    Private Sub btnSaveDamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDamage.Click
        MarkItemDelivered(False)
    End Sub
End Class
