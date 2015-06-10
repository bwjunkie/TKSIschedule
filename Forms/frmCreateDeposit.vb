Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data

Public Class frmCreateDeposit
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
    Friend WithEvents lvCreateDeposit As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daSOLine As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents butCreateDeposit As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents lvDepositDates As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents daSOLineOneDeposit As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents butCheckAll As System.Windows.Forms.Button
    Friend WithEvents butUncheckAll As System.Windows.Forms.Button
    Friend WithEvents pnlDepositDetail As System.Windows.Forms.Panel
    Friend WithEvents daDepositsDates As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daDeposits As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents Amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateRec As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents butPrintDeposit As System.Windows.Forms.Button
    Friend WithEvents PO As System.Windows.Forms.ColumnHeader
    Friend WithEvents DepositDetail As System.Windows.Forms.ColumnHeader
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daSOHeader As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daCustomer As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand6 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daJob As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents sales As System.Windows.Forms.ColumnHeader
    Friend WithEvents Customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OleDbSelectCommand7 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand6 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents daSOLineByHeaderID As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvCreateDeposit = New System.Windows.Forms.ListView
        Me.PO = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.DepositDetail = New System.Windows.Forms.ColumnHeader
        Me.Amount = New System.Windows.Forms.ColumnHeader
        Me.dateRec = New System.Windows.Forms.ColumnHeader
        Me.sales = New System.Windows.Forms.ColumnHeader
        Me.Customer = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.daSOLine = New System.Data.OleDb.OleDbDataAdapter
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.butCreateDeposit = New System.Windows.Forms.Button
        Me.lvDepositDates = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.daDepositsDates = New System.Data.OleDb.OleDbDataAdapter
        Me.daSOLineOneDeposit = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand
        Me.butCheckAll = New System.Windows.Forms.Button
        Me.butUncheckAll = New System.Windows.Forms.Button
        Me.pnlDepositDetail = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTotal = New System.Windows.Forms.Label
        Me.butPrintDeposit = New System.Windows.Forms.Button
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.daDeposits = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.daSOHeader = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand
        Me.daCustomer = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand6 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand
        Me.daJob = New System.Data.OleDb.OleDbDataAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.OleDbSelectCommand7 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand6 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand5 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand5 = New System.Data.OleDb.OleDbCommand
        Me.daSOLineByHeaderID = New System.Data.OleDb.OleDbDataAdapter
        Me.DsTKSI1 = New dsTKSI
        Me.pnlDepositDetail.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCreateDeposit
        '
        Me.lvCreateDeposit.CheckBoxes = True
        Me.lvCreateDeposit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PO, Me.ColumnHeader2, Me.DepositDetail, Me.Amount, Me.dateRec, Me.sales, Me.Customer, Me.ColumnHeader1})
        Me.lvCreateDeposit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCreateDeposit.FullRowSelect = True
        Me.lvCreateDeposit.HideSelection = False
        Me.lvCreateDeposit.Location = New System.Drawing.Point(0, 0)
        Me.lvCreateDeposit.Name = "lvCreateDeposit"
        Me.lvCreateDeposit.Size = New System.Drawing.Size(752, 445)
        Me.lvCreateDeposit.TabIndex = 0
        Me.lvCreateDeposit.View = System.Windows.Forms.View.Details
        '
        'PO
        '
        Me.PO.Text = ""
        Me.PO.Width = 20
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 0
        '
        'DepositDetail
        '
        Me.DepositDetail.Text = "Deposit Detail"
        Me.DepositDetail.Width = 240
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.Width = 110
        '
        'dateRec
        '
        Me.dateRec.Text = "Date Rec"
        Me.dateRec.Width = 110
        '
        'sales
        '
        Me.sales.Text = "Sales"
        Me.sales.Width = 70
        '
        'Customer
        '
        Me.Customer.Text = "Customer"
        Me.Customer.Width = 140
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "%Paid"
        Me.ColumnHeader1.Width = 55
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT tSOLine.bTaxable, tSOLine.nAccountID, tSOLine.nAmount, tSOLine.nLineNumber" & _
        ", tSOLine.nSOID, tSOLine.sDesc AS sDesc, tSOLine.sHidden, tSOLine.sType FROM ((t" & _
        "SOLine INNER JOIN tSOHeader ON tSOLine.nSOID = tSOHeader.nID) LEFT OUTER JOIN tD" & _
        "eposits ON tSOLine.nLineNumber = tDeposits.nLineNumber AND tSOLine.nSOID = tDepo" & _
        "sits.nSOID) WHERE (tSOLine.nAccountID = 0) AND (tSOLine.nAmount < 0) AND (tSOHea" & _
        "der.dinvoice > #6/1/2003#) AND (tDeposits.ID IS NULL) ORDER BY tSOHeader.dinvoic" & _
        "e"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tSOLine(bTaxable, nAccountID, nAmount, nLineNumber, nSOID, sDesc, sHi" & _
        "dden, sType) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, "bTaxable"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAccountID", System.Data.OleDb.OleDbType.Integer, 0, "nAccountID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAmount", System.Data.OleDb.OleDbType.Double, 0, "nAmount"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "sDesc"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("sHidden", System.Data.OleDb.OleDbType.Boolean, 2, "sHidden"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("sType", System.Data.OleDb.OleDbType.VarWChar, 50, "sType"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE tSOLine SET bTaxable = ?, nAccountID = ?, nAmount = ?, nLineNumber = ?, nS" & _
        "OID = ?, sDesc = ?, sHidden = ?, sType = ? WHERE (nLineNumber = ?) AND (nSOID = " & _
        "?) AND (bTaxable = ?) AND (nAccountID = ? OR ? IS NULL AND nAccountID IS NULL) A" & _
        "ND (nAmount = ? OR ? IS NULL AND nAmount IS NULL) AND (sDesc = ? OR ? IS NULL AN" & _
        "D sDesc IS NULL) AND (sHidden = ?) AND (sType = ? OR ? IS NULL AND sType IS NULL" & _
        ")"
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, "bTaxable"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAccountID", System.Data.OleDb.OleDbType.Integer, 0, "nAccountID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAmount", System.Data.OleDb.OleDbType.Double, 0, "nAmount"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "sDesc"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("sHidden", System.Data.OleDb.OleDbType.Boolean, 2, "sHidden"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("sType", System.Data.OleDb.OleDbType.VarWChar, 50, "sType"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bTaxable", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sHidden", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sHidden", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tSOLine WHERE (nLineNumber = ?) AND (nSOID = ?) AND (bTaxable = ?) AN" & _
        "D (nAccountID = ? OR ? IS NULL AND nAccountID IS NULL) AND (nAmount = ? OR ? IS " & _
        "NULL AND nAmount IS NULL) AND (sDesc = ? OR ? IS NULL AND sDesc IS NULL) AND (sH" & _
        "idden = ?) AND (sType = ? OR ? IS NULL AND sType IS NULL)"
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bTaxable", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sHidden", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sHidden", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        '
        'daSOLine
        '
        Me.daSOLine.DeleteCommand = Me.OleDbDeleteCommand1
        Me.daSOLine.InsertCommand = Me.OleDbInsertCommand1
        Me.daSOLine.SelectCommand = Me.OleDbSelectCommand1
        Me.daSOLine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("sType", "sType")})})
        Me.daSOLine.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'butCreateDeposit
        '
        Me.butCreateDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butCreateDeposit.Location = New System.Drawing.Point(288, 80)
        Me.butCreateDeposit.Name = "butCreateDeposit"
        Me.butCreateDeposit.Size = New System.Drawing.Size(192, 24)
        Me.butCreateDeposit.TabIndex = 2
        Me.butCreateDeposit.Text = "Save deposit for above date"
        '
        'lvDepositDates
        '
        Me.lvDepositDates.CheckBoxes = True
        Me.lvDepositDates.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvDepositDates.FullRowSelect = True
        Me.lvDepositDates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvDepositDates.HideSelection = False
        Me.lvDepositDates.Location = New System.Drawing.Point(8, 8)
        Me.lvDepositDates.Name = "lvDepositDates"
        Me.lvDepositDates.Size = New System.Drawing.Size(152, 216)
        Me.lvDepositDates.TabIndex = 3
        Me.lvDepositDates.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Width = 120
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT DISTINCT dDateDeposit FROM tDeposits order by dDateDeposit desc"
        '
        'daDepositsDates
        '
        Me.daDepositsDates.SelectCommand = Me.OleDbSelectCommand2
        Me.daDepositsDates.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tDeposits", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("dDateDeposit", "dDateDeposit"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("sOther", "sOther")})})
        '
        'daSOLineOneDeposit
        '
        Me.daSOLineOneDeposit.DeleteCommand = Me.OleDbCommand1
        Me.daSOLineOneDeposit.InsertCommand = Me.OleDbCommand2
        Me.daSOLineOneDeposit.SelectCommand = Me.OleDbCommand3
        Me.daSOLineOneDeposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("sType", "sType")})})
        Me.daSOLineOneDeposit.UpdateCommand = Me.OleDbCommand4
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "DELETE FROM tSOLine WHERE (nLineNumber = ?) AND (nSOID = ?) AND (bTaxable = ?) AN" & _
        "D (nAccountID = ? OR ? IS NULL AND nAccountID IS NULL) AND (nAmount = ? OR ? IS " & _
        "NULL AND nAmount IS NULL) AND (sDesc = ? OR ? IS NULL AND sDesc IS NULL) AND (sH" & _
        "idden = ?) AND (sType = ? OR ? IS NULL AND sType IS NULL)"
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bTaxable", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sHidden", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sHidden", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "INSERT INTO tSOLine(bTaxable, nAccountID, nAmount, nLineNumber, nSOID, sDesc, sHi" & _
        "dden, sType) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, "bTaxable"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAccountID", System.Data.OleDb.OleDbType.Integer, 0, "nAccountID"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAmount", System.Data.OleDb.OleDbType.Double, 0, "nAmount"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "sDesc"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sHidden", System.Data.OleDb.OleDbType.Boolean, 2, "sHidden"))
        Me.OleDbCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sType", System.Data.OleDb.OleDbType.VarWChar, 50, "sType"))
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = "SELECT tSOLine.bTaxable, tSOLine.nAccountID, tSOLine.nAmount, tSOLine.nLineNumber" & _
        ", tSOLine.nSOID, tSOLine.sDesc AS sDesc, tSOLine.sHidden, tSOLine.sType FROM ((t" & _
        "SOLine INNER JOIN tDeposits ON tSOLine.nLineNumber = tDeposits.nLineNumber AND t" & _
        "SOLine.nSOID = tDeposits.nSOID) INNER JOIN tSOHeader ON tSOLine.nSOID = tSOHeade" & _
        "r.nID) WHERE (tSOLine.nAccountID = 0) AND (tSOLine.nAmount < 0) AND (tDeposits.d" & _
        "DateDeposit = ?)"
        Me.OleDbCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("dDateDeposit", System.Data.OleDb.OleDbType.DBDate, 0, "dDateDeposit"))
        '
        'OleDbCommand4
        '
        Me.OleDbCommand4.CommandText = "UPDATE tSOLine SET bTaxable = ?, nAccountID = ?, nAmount = ?, nLineNumber = ?, nS" & _
        "OID = ?, sDesc = ?, sHidden = ?, sType = ? WHERE (nLineNumber = ?) AND (nSOID = " & _
        "?) AND (bTaxable = ?) AND (nAccountID = ? OR ? IS NULL AND nAccountID IS NULL) A" & _
        "ND (nAmount = ? OR ? IS NULL AND nAmount IS NULL) AND (sDesc = ? OR ? IS NULL AN" & _
        "D sDesc IS NULL) AND (sHidden = ?) AND (sType = ? OR ? IS NULL AND sType IS NULL" & _
        ")"
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, "bTaxable"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAccountID", System.Data.OleDb.OleDbType.Integer, 0, "nAccountID"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAmount", System.Data.OleDb.OleDbType.Double, 0, "nAmount"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "sDesc"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sHidden", System.Data.OleDb.OleDbType.Boolean, 2, "sHidden"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sType", System.Data.OleDb.OleDbType.VarWChar, 50, "sType"))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bTaxable", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sHidden", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sHidden", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        '
        'butCheckAll
        '
        Me.butCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butCheckAll.Location = New System.Drawing.Point(8, 8)
        Me.butCheckAll.Name = "butCheckAll"
        Me.butCheckAll.Size = New System.Drawing.Size(64, 20)
        Me.butCheckAll.TabIndex = 5
        Me.butCheckAll.Text = "Check All"
        '
        'butUncheckAll
        '
        Me.butUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butUncheckAll.Location = New System.Drawing.Point(8, 32)
        Me.butUncheckAll.Name = "butUncheckAll"
        Me.butUncheckAll.Size = New System.Drawing.Size(64, 20)
        Me.butUncheckAll.TabIndex = 6
        Me.butUncheckAll.Text = "UnCheck All"
        '
        'pnlDepositDetail
        '
        Me.pnlDepositDetail.Controls.Add(Me.lvCreateDeposit)
        Me.pnlDepositDetail.Controls.Add(Me.Panel2)
        Me.pnlDepositDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDepositDetail.Enabled = False
        Me.pnlDepositDetail.Location = New System.Drawing.Point(176, 0)
        Me.pnlDepositDetail.Name = "pnlDepositDetail"
        Me.pnlDepositDetail.Size = New System.Drawing.Size(752, 557)
        Me.pnlDepositDetail.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.butPrintDeposit)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.butCreateDeposit)
        Me.Panel2.Controls.Add(Me.butCheckAll)
        Me.Panel2.Controls.Add(Me.butUncheckAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 112)
        Me.Panel2.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(288, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(176, 24)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total:"
        '
        'butPrintDeposit
        '
        Me.butPrintDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butPrintDeposit.Location = New System.Drawing.Point(8, 80)
        Me.butPrintDeposit.Name = "butPrintDeposit"
        Me.butPrintDeposit.Size = New System.Drawing.Size(152, 24)
        Me.butPrintDeposit.TabIndex = 8
        Me.butPrintDeposit.Text = "Print Deposit"
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT dDateDeposit, ID, nLineNumber, nSOID, sOther FROM tDeposits WHERE (dDateDe" & _
        "posit > #6/1/2003#)"
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO tDeposits(dDateDeposit, nLineNumber, nSOID, sOther) VALUES (?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("dDateDeposit", System.Data.OleDb.OleDbType.DBDate, 0, "dDateDeposit"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("sOther", System.Data.OleDb.OleDbType.VarWChar, 50, "sOther"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE tDeposits SET dDateDeposit = ?, nLineNumber = ?, nSOID = ?, sOther = ? WHE" & _
        "RE (ID = ?) AND (dDateDeposit = ? OR ? IS NULL AND dDateDeposit IS NULL) AND (nL" & _
        "ineNumber = ? OR ? IS NULL AND nLineNumber IS NULL) AND (nSOID = ? OR ? IS NULL " & _
        "AND nSOID IS NULL) AND (sOther = ? OR ? IS NULL AND sOther IS NULL)"
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("dDateDeposit", System.Data.OleDb.OleDbType.DBDate, 0, "dDateDeposit"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("sOther", System.Data.OleDb.OleDbType.VarWChar, 50, "sOther"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDateDeposit", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDateDeposit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDateDeposit1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDateDeposit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOther", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOther", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOther1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOther", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM tDeposits WHERE (ID = ?) AND (dDateDeposit = ? OR ? IS NULL AND dDate" & _
        "Deposit IS NULL) AND (nLineNumber = ? OR ? IS NULL AND nLineNumber IS NULL) AND " & _
        "(nSOID = ? OR ? IS NULL AND nSOID IS NULL) AND (sOther = ? OR ? IS NULL AND sOth" & _
        "er IS NULL)"
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDateDeposit", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDateDeposit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDateDeposit1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDateDeposit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOther", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOther", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOther1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOther", System.Data.DataRowVersion.Original, Nothing))
        '
        'daDeposits
        '
        Me.daDeposits.DeleteCommand = Me.OleDbDeleteCommand3
        Me.daDeposits.InsertCommand = Me.OleDbInsertCommand3
        Me.daDeposits.SelectCommand = Me.OleDbSelectCommand3
        Me.daDeposits.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tDeposits", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("dDateDeposit", "dDateDeposit"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("sOther", "sOther")})})
        Me.daDeposits.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT dinvoice, dmailed, dShipped, dsimply, nCustID, nID, nJobID, nTaxRate, nTot" & _
        "al, sFOB, sName, sOurOrder, sShipTo1, sShipTo2, sShipToCity, sShipToCounty, sShi" & _
        "pToState, sShipToZip, sSONum, sTerms, sVIA, sYourOrder FROM tSOHeader WHERE (din" & _
        "voice > #6/1/2003#)"
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO tSOHeader(dinvoice, dmailed, dShipped, dsimply, nCustID, nJobID, nTax" & _
        "Rate, nTotal, sFOB, sName, sOurOrder, sShipTo1, sShipTo2, sShipToCity, sShipToCo" & _
        "unty, sShipToState, sShipToZip, sSONum, sTerms, sVIA, sYourOrder) VALUES (?, ?, " & _
        "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dinvoice", System.Data.OleDb.OleDbType.DBDate, 0, "dinvoice"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dmailed", System.Data.OleDb.OleDbType.DBDate, 0, "dmailed"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dShipped", System.Data.OleDb.OleDbType.DBDate, 0, "dShipped"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dsimply", System.Data.OleDb.OleDbType.DBDate, 0, "dsimply"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nCustID", System.Data.OleDb.OleDbType.Integer, 0, "nCustID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nJobID", System.Data.OleDb.OleDbType.Integer, 0, "nJobID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTaxRate", System.Data.OleDb.OleDbType.Integer, 0, "nTaxRate"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTotal", System.Data.OleDb.OleDbType.Integer, 0, "nTotal"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sFOB", System.Data.OleDb.OleDbType.VarWChar, 50, "sFOB"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sName", System.Data.OleDb.OleDbType.VarWChar, 50, "sName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sOurOrder", System.Data.OleDb.OleDbType.VarWChar, 50, "sOurOrder"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipTo1", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipTo1"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipTo2", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipTo2"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToCity", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToCity"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToCounty", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToCounty"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToState", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToState"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToZip", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToZip"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sSONum", System.Data.OleDb.OleDbType.VarWChar, 50, "sSONum"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sTerms", System.Data.OleDb.OleDbType.VarWChar, 50, "sTerms"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sVIA", System.Data.OleDb.OleDbType.VarWChar, 50, "sVIA"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sYourOrder", System.Data.OleDb.OleDbType.VarWChar, 50, "sYourOrder"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE tSOHeader SET dinvoice = ?, dmailed = ?, dShipped = ?, dsimply = ?, nCustI" & _
        "D = ?, nJobID = ?, nTaxRate = ?, nTotal = ?, sFOB = ?, sName = ?, sOurOrder = ?," & _
        " sShipTo1 = ?, sShipTo2 = ?, sShipToCity = ?, sShipToCounty = ?, sShipToState = " & _
        "?, sShipToZip = ?, sSONum = ?, sTerms = ?, sVIA = ?, sYourOrder = ? WHERE (nID =" & _
        " ?) AND (dShipped = ? OR ? IS NULL AND dShipped IS NULL) AND (dinvoice = ? OR ? " & _
        "IS NULL AND dinvoice IS NULL) AND (dmailed = ? OR ? IS NULL AND dmailed IS NULL)" & _
        " AND (dsimply = ? OR ? IS NULL AND dsimply IS NULL) AND (nCustID = ? OR ? IS NUL" & _
        "L AND nCustID IS NULL) AND (nJobID = ? OR ? IS NULL AND nJobID IS NULL) AND (nTa" & _
        "xRate = ? OR ? IS NULL AND nTaxRate IS NULL) AND (nTotal = ? OR ? IS NULL AND nT" & _
        "otal IS NULL) AND (sFOB = ? OR ? IS NULL AND sFOB IS NULL) AND (sName = ? OR ? I" & _
        "S NULL AND sName IS NULL) AND (sOurOrder = ? OR ? IS NULL AND sOurOrder IS NULL)" & _
        " AND (sSONum = ? OR ? IS NULL AND sSONum IS NULL) AND (sShipTo1 = ? OR ? IS NULL" & _
        " AND sShipTo1 IS NULL) AND (sShipTo2 = ? OR ? IS NULL AND sShipTo2 IS NULL) AND " & _
        "(sShipToCity = ? OR ? IS NULL AND sShipToCity IS NULL) AND (sShipToCounty = ? OR" & _
        " ? IS NULL AND sShipToCounty IS NULL) AND (sShipToState = ? OR ? IS NULL AND sSh" & _
        "ipToState IS NULL) AND (sShipToZip = ? OR ? IS NULL AND sShipToZip IS NULL) AND " & _
        "(sTerms = ? OR ? IS NULL AND sTerms IS NULL) AND (sVIA = ? OR ? IS NULL AND sVIA" & _
        " IS NULL) AND (sYourOrder = ? OR ? IS NULL AND sYourOrder IS NULL)"
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dinvoice", System.Data.OleDb.OleDbType.DBDate, 0, "dinvoice"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dmailed", System.Data.OleDb.OleDbType.DBDate, 0, "dmailed"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dShipped", System.Data.OleDb.OleDbType.DBDate, 0, "dShipped"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("dsimply", System.Data.OleDb.OleDbType.DBDate, 0, "dsimply"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nCustID", System.Data.OleDb.OleDbType.Integer, 0, "nCustID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nJobID", System.Data.OleDb.OleDbType.Integer, 0, "nJobID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTaxRate", System.Data.OleDb.OleDbType.Integer, 0, "nTaxRate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTotal", System.Data.OleDb.OleDbType.Integer, 0, "nTotal"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sFOB", System.Data.OleDb.OleDbType.VarWChar, 50, "sFOB"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sName", System.Data.OleDb.OleDbType.VarWChar, 50, "sName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sOurOrder", System.Data.OleDb.OleDbType.VarWChar, 50, "sOurOrder"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipTo1", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipTo1"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipTo2", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipTo2"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToCity", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToCity"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToCounty", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToCounty"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToState", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToState"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sShipToZip", System.Data.OleDb.OleDbType.VarWChar, 50, "sShipToZip"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sSONum", System.Data.OleDb.OleDbType.VarWChar, 50, "sSONum"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sTerms", System.Data.OleDb.OleDbType.VarWChar, 50, "sTerms"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sVIA", System.Data.OleDb.OleDbType.VarWChar, 50, "sVIA"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("sYourOrder", System.Data.OleDb.OleDbType.VarWChar, 50, "sYourOrder"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dShipped", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dShipped", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dShipped1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dShipped", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dinvoice", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dinvoice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dinvoice1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dinvoice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dmailed", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dmailed", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dmailed1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dmailed", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dsimply", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dsimply", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dsimply1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dsimply", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nJobID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nJobID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotal", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotal1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sFOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sFOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOurOrder", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOurOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOurOrder1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOurOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSONum", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSONum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSONum1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSONum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCounty", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCounty1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToZip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToZip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sVIA", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sVIA1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sYourOrder", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYourOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sYourOrder1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYourOrder", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM tSOHeader WHERE (nID = ?) AND (dShipped = ? OR ? IS NULL AND dShipped" & _
        " IS NULL) AND (dinvoice = ? OR ? IS NULL AND dinvoice IS NULL) AND (dmailed = ? " & _
        "OR ? IS NULL AND dmailed IS NULL) AND (dsimply = ? OR ? IS NULL AND dsimply IS N" & _
        "ULL) AND (nCustID = ? OR ? IS NULL AND nCustID IS NULL) AND (nJobID = ? OR ? IS " & _
        "NULL AND nJobID IS NULL) AND (nTaxRate = ? OR ? IS NULL AND nTaxRate IS NULL) AN" & _
        "D (nTotal = ? OR ? IS NULL AND nTotal IS NULL) AND (sFOB = ? OR ? IS NULL AND sF" & _
        "OB IS NULL) AND (sName = ? OR ? IS NULL AND sName IS NULL) AND (sOurOrder = ? OR" & _
        " ? IS NULL AND sOurOrder IS NULL) AND (sSONum = ? OR ? IS NULL AND sSONum IS NUL" & _
        "L) AND (sShipTo1 = ? OR ? IS NULL AND sShipTo1 IS NULL) AND (sShipTo2 = ? OR ? I" & _
        "S NULL AND sShipTo2 IS NULL) AND (sShipToCity = ? OR ? IS NULL AND sShipToCity I" & _
        "S NULL) AND (sShipToCounty = ? OR ? IS NULL AND sShipToCounty IS NULL) AND (sShi" & _
        "pToState = ? OR ? IS NULL AND sShipToState IS NULL) AND (sShipToZip = ? OR ? IS " & _
        "NULL AND sShipToZip IS NULL) AND (sTerms = ? OR ? IS NULL AND sTerms IS NULL) AN" & _
        "D (sVIA = ? OR ? IS NULL AND sVIA IS NULL) AND (sYourOrder = ? OR ? IS NULL AND " & _
        "sYourOrder IS NULL)"
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dShipped", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dShipped", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dShipped1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dShipped", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dinvoice", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dinvoice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dinvoice1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dinvoice", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dmailed", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dmailed", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dmailed1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dmailed", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dsimply", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dsimply", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dsimply1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dsimply", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nJobID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nJobID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotal", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotal1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sFOB", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sFOB1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOurOrder", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOurOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sOurOrder1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOurOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSONum", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSONum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSONum1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSONum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipTo21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCity", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCity1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCounty", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToCounty1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToState", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToState1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToZip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sShipToZip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sVIA", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sVIA1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sYourOrder", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYourOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sYourOrder1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYourOrder", System.Data.DataRowVersion.Original, Nothing))
        '
        'daSOHeader
        '
        Me.daSOHeader.DeleteCommand = Me.OleDbDeleteCommand2
        Me.daSOHeader.InsertCommand = Me.OleDbInsertCommand2
        Me.daSOHeader.SelectCommand = Me.OleDbSelectCommand4
        Me.daSOHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder")})})
        Me.daSOHeader.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand5
        '
        Me.OleDbSelectCommand5.CommandText = "SELECT dAmtYTD, dCrLimit, lID, sCity, sCountry, sFax, sName, sPhone1, sPhone2, sP" & _
        "ostalZip, sProvState, sStreet1, sStreet2 FROM tCustomr"
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO tCustomr(dAmtYTD, dCrLimit, lID, sCity, sCountry, sFax, sName, sPhone" & _
        "1, sPhone2, sPostalZip, sProvState, sStreet1, sStreet2) VALUES (?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dAmtYTD", System.Data.OleDb.OleDbType.VarWChar, 50, "dAmtYTD"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCrLimit", System.Data.OleDb.OleDbType.Currency, 0, "dCrLimit"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("lID", System.Data.OleDb.OleDbType.Integer, 0, "lID"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sCity", System.Data.OleDb.OleDbType.VarWChar, 50, "sCity"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sCountry", System.Data.OleDb.OleDbType.VarWChar, 50, "sCountry"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sFax", System.Data.OleDb.OleDbType.VarWChar, 50, "sFax"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sName", System.Data.OleDb.OleDbType.VarWChar, 50, "sName"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sPhone1", System.Data.OleDb.OleDbType.VarWChar, 50, "sPhone1"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sPhone2", System.Data.OleDb.OleDbType.VarWChar, 50, "sPhone2"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sPostalZip", System.Data.OleDb.OleDbType.VarWChar, 50, "sPostalZip"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sProvState", System.Data.OleDb.OleDbType.VarWChar, 50, "sProvState"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sStreet1", System.Data.OleDb.OleDbType.VarWChar, 50, "sStreet1"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sStreet2", System.Data.OleDb.OleDbType.VarWChar, 50, "sStreet2"))
        '
        'daCustomer
        '
        Me.daCustomer.InsertCommand = Me.OleDbInsertCommand4
        Me.daCustomer.SelectCommand = Me.OleDbSelectCommand5
        Me.daCustomer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2")})})
        '
        'OleDbSelectCommand6
        '
        Me.OleDbSelectCommand6.CommandText = "SELECT dAmtYTD, dCommPaid, dCreated, dCrLimit, dDrawing, dJobCreated, lngCommissi" & _
        "onStruct, nAddressID, nCustID, nID, nLaborCharge, nMaterialsCharge, nTaxRate, nT" & _
        "otalWholesale, sBuildingPermit, sCommLocked, sComplete, sContractSigned, sCounty" & _
        ", sDisclaimerSigned, sDrawingsSigned, sInvNotes, sJobContact, sJobDesc, sJobNo, " & _
        "sOtherNotes, sPhone, sSalesperson, sTerms FROM tJob"
        '
        'OleDbInsertCommand5
        '
        Me.OleDbInsertCommand5.CommandText = "INSERT INTO tJob(dAmtYTD, dCommPaid, dCreated, dCrLimit, dDrawing, dJobCreated, l" & _
        "ngCommissionStruct, nAddressID, nCustID, nLaborCharge, nMaterialsCharge, nTaxRat" & _
        "e, nTotalWholesale, sBuildingPermit, sCommLocked, sComplete, sContractSigned, sC" & _
        "ounty, sDisclaimerSigned, sDrawingsSigned, sInvNotes, sJobContact, sJobDesc, sJo" & _
        "bNo, sOtherNotes, sPhone, sSalesperson, sTerms) VALUES (?, ?, ?, ?, ?, ?, ?, ?, " & _
        "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("dAmtYTD", System.Data.OleDb.OleDbType.Currency, 0, "dAmtYTD"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCommPaid", System.Data.OleDb.OleDbType.DBDate, 0, "dCommPaid"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCreated", System.Data.OleDb.OleDbType.DBDate, 0, "dCreated"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCrLimit", System.Data.OleDb.OleDbType.Currency, 0, "dCrLimit"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("dDrawing", System.Data.OleDb.OleDbType.VarWChar, 255, "dDrawing"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("dJobCreated", System.Data.OleDb.OleDbType.DBDate, 0, "dJobCreated"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("lngCommissionStruct", System.Data.OleDb.OleDbType.Integer, 0, "lngCommissionStruct"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAddressID", System.Data.OleDb.OleDbType.Integer, 0, "nAddressID"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nCustID", System.Data.OleDb.OleDbType.Integer, 0, "nCustID"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLaborCharge", System.Data.OleDb.OleDbType.Double, 0, "nLaborCharge"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nMaterialsCharge", System.Data.OleDb.OleDbType.Double, 0, "nMaterialsCharge"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTaxRate", System.Data.OleDb.OleDbType.Double, 0, "nTaxRate"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTotalWholesale", System.Data.OleDb.OleDbType.Double, 0, "nTotalWholesale"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sBuildingPermit", System.Data.OleDb.OleDbType.VarWChar, 255, "sBuildingPermit"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sCommLocked", System.Data.OleDb.OleDbType.VarWChar, 50, "sCommLocked"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sComplete", System.Data.OleDb.OleDbType.VarWChar, 255, "sComplete"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sContractSigned", System.Data.OleDb.OleDbType.VarWChar, 255, "sContractSigned"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sCounty", System.Data.OleDb.OleDbType.VarWChar, 255, "sCounty"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDisclaimerSigned", System.Data.OleDb.OleDbType.VarWChar, 50, "sDisclaimerSigned"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDrawingsSigned", System.Data.OleDb.OleDbType.VarWChar, 255, "sDrawingsSigned"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sInvNotes", System.Data.OleDb.OleDbType.VarWChar, 255, "sInvNotes"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sJobContact", System.Data.OleDb.OleDbType.VarWChar, 255, "sJobContact"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sJobDesc", System.Data.OleDb.OleDbType.VarWChar, 255, "sJobDesc"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sJobNo", System.Data.OleDb.OleDbType.VarWChar, 255, "sJobNo"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sOtherNotes", System.Data.OleDb.OleDbType.VarWChar, 0, "sOtherNotes"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sPhone", System.Data.OleDb.OleDbType.VarWChar, 255, "sPhone"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sSalesperson", System.Data.OleDb.OleDbType.VarWChar, 50, "sSalesperson"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sTerms", System.Data.OleDb.OleDbType.VarWChar, 255, "sTerms"))
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE tJob SET dAmtYTD = ?, dCommPaid = ?, dCreated = ?, dCrLimit = ?, dDrawing " & _
        "= ?, dJobCreated = ?, lngCommissionStruct = ?, nAddressID = ?, nCustID = ?, nLab" & _
        "orCharge = ?, nMaterialsCharge = ?, nTaxRate = ?, nTotalWholesale = ?, sBuilding" & _
        "Permit = ?, sCommLocked = ?, sComplete = ?, sContractSigned = ?, sCounty = ?, sD" & _
        "isclaimerSigned = ?, sDrawingsSigned = ?, sInvNotes = ?, sJobContact = ?, sJobDe" & _
        "sc = ?, sJobNo = ?, sOtherNotes = ?, sPhone = ?, sSalesperson = ?, sTerms = ? WH" & _
        "ERE (nID = ?) AND (dAmtYTD = ? OR ? IS NULL AND dAmtYTD IS NULL) AND (dCommPaid " & _
        "= ? OR ? IS NULL AND dCommPaid IS NULL) AND (dCrLimit = ? OR ? IS NULL AND dCrLi" & _
        "mit IS NULL) AND (dCreated = ? OR ? IS NULL AND dCreated IS NULL) AND (dDrawing " & _
        "= ? OR ? IS NULL AND dDrawing IS NULL) AND (dJobCreated = ? OR ? IS NULL AND dJo" & _
        "bCreated IS NULL) AND (lngCommissionStruct = ? OR ? IS NULL AND lngCommissionStr" & _
        "uct IS NULL) AND (nAddressID = ? OR ? IS NULL AND nAddressID IS NULL) AND (nCust" & _
        "ID = ? OR ? IS NULL AND nCustID IS NULL) AND (nLaborCharge = ? OR ? IS NULL AND " & _
        "nLaborCharge IS NULL) AND (nMaterialsCharge = ? OR ? IS NULL AND nMaterialsCharg" & _
        "e IS NULL) AND (nTaxRate = ? OR ? IS NULL AND nTaxRate IS NULL) AND (nTotalWhole" & _
        "sale = ? OR ? IS NULL AND nTotalWholesale IS NULL) AND (sBuildingPermit = ? OR ?" & _
        " IS NULL AND sBuildingPermit IS NULL) AND (sCommLocked = ? OR ? IS NULL AND sCom" & _
        "mLocked IS NULL) AND (sComplete = ? OR ? IS NULL AND sComplete IS NULL) AND (sCo" & _
        "ntractSigned = ? OR ? IS NULL AND sContractSigned IS NULL) AND (sCounty = ? OR ?" & _
        " IS NULL AND sCounty IS NULL) AND (sDisclaimerSigned = ? OR ? IS NULL AND sDiscl" & _
        "aimerSigned IS NULL) AND (sDrawingsSigned = ? OR ? IS NULL AND sDrawingsSigned I" & _
        "S NULL) AND (sInvNotes = ? OR ? IS NULL AND sInvNotes IS NULL) AND (sJobContact " & _
        "= ? OR ? IS NULL AND sJobContact IS NULL) AND (sJobDesc = ? OR ? IS NULL AND sJo" & _
        "bDesc IS NULL) AND (sJobNo = ? OR ? IS NULL AND sJobNo IS NULL) AND (sPhone = ? " & _
        "OR ? IS NULL AND sPhone IS NULL) AND (sSalesperson = ? OR ? IS NULL AND sSalespe" & _
        "rson IS NULL) AND (sTerms = ? OR ? IS NULL AND sTerms IS NULL)"
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dAmtYTD", System.Data.OleDb.OleDbType.Currency, 0, "dAmtYTD"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCommPaid", System.Data.OleDb.OleDbType.DBDate, 0, "dCommPaid"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCreated", System.Data.OleDb.OleDbType.DBDate, 0, "dCreated"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dCrLimit", System.Data.OleDb.OleDbType.Currency, 0, "dCrLimit"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dDrawing", System.Data.OleDb.OleDbType.VarWChar, 255, "dDrawing"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("dJobCreated", System.Data.OleDb.OleDbType.DBDate, 0, "dJobCreated"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("lngCommissionStruct", System.Data.OleDb.OleDbType.Integer, 0, "lngCommissionStruct"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAddressID", System.Data.OleDb.OleDbType.Integer, 0, "nAddressID"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nCustID", System.Data.OleDb.OleDbType.Integer, 0, "nCustID"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLaborCharge", System.Data.OleDb.OleDbType.Double, 0, "nLaborCharge"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nMaterialsCharge", System.Data.OleDb.OleDbType.Double, 0, "nMaterialsCharge"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTaxRate", System.Data.OleDb.OleDbType.Double, 0, "nTaxRate"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("nTotalWholesale", System.Data.OleDb.OleDbType.Double, 0, "nTotalWholesale"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sBuildingPermit", System.Data.OleDb.OleDbType.VarWChar, 255, "sBuildingPermit"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sCommLocked", System.Data.OleDb.OleDbType.VarWChar, 50, "sCommLocked"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sComplete", System.Data.OleDb.OleDbType.VarWChar, 255, "sComplete"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sContractSigned", System.Data.OleDb.OleDbType.VarWChar, 255, "sContractSigned"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sCounty", System.Data.OleDb.OleDbType.VarWChar, 255, "sCounty"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDisclaimerSigned", System.Data.OleDb.OleDbType.VarWChar, 50, "sDisclaimerSigned"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDrawingsSigned", System.Data.OleDb.OleDbType.VarWChar, 255, "sDrawingsSigned"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sInvNotes", System.Data.OleDb.OleDbType.VarWChar, 255, "sInvNotes"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sJobContact", System.Data.OleDb.OleDbType.VarWChar, 255, "sJobContact"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sJobDesc", System.Data.OleDb.OleDbType.VarWChar, 255, "sJobDesc"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sJobNo", System.Data.OleDb.OleDbType.VarWChar, 255, "sJobNo"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sOtherNotes", System.Data.OleDb.OleDbType.VarWChar, 0, "sOtherNotes"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sPhone", System.Data.OleDb.OleDbType.VarWChar, 255, "sPhone"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sSalesperson", System.Data.OleDb.OleDbType.VarWChar, 50, "sSalesperson"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("sTerms", System.Data.OleDb.OleDbType.VarWChar, 255, "sTerms"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dAmtYTD", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dAmtYTD1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCommPaid", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCommPaid1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCrLimit", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCrLimit1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCreated", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCreated1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDrawing", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDrawing1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dJobCreated", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dJobCreated1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_lngCommissionStruct", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_lngCommissionStruct1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAddressID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAddressID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLaborCharge", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLaborCharge1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nMaterialsCharge", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nMaterialsCharge1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotalWholesale", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotalWholesale1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sBuildingPermit", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sBuildingPermit1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCommLocked", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCommLocked1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sComplete", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sComplete1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sContractSigned", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sContractSigned1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCounty", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCounty1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDisclaimerSigned", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDisclaimerSigned1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDrawingsSigned", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDrawingsSigned1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sInvNotes", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sInvNotes1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobContact", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobContact1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobDesc", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobDesc1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sPhone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sPhone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSalesperson", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSalesperson1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM tJob WHERE (nID = ?) AND (dAmtYTD = ? OR ? IS NULL AND dAmtYTD IS NUL" & _
        "L) AND (dCommPaid = ? OR ? IS NULL AND dCommPaid IS NULL) AND (dCrLimit = ? OR ?" & _
        " IS NULL AND dCrLimit IS NULL) AND (dCreated = ? OR ? IS NULL AND dCreated IS NU" & _
        "LL) AND (dDrawing = ? OR ? IS NULL AND dDrawing IS NULL) AND (dJobCreated = ? OR" & _
        " ? IS NULL AND dJobCreated IS NULL) AND (lngCommissionStruct = ? OR ? IS NULL AN" & _
        "D lngCommissionStruct IS NULL) AND (nAddressID = ? OR ? IS NULL AND nAddressID I" & _
        "S NULL) AND (nCustID = ? OR ? IS NULL AND nCustID IS NULL) AND (nLaborCharge = ?" & _
        " OR ? IS NULL AND nLaborCharge IS NULL) AND (nMaterialsCharge = ? OR ? IS NULL A" & _
        "ND nMaterialsCharge IS NULL) AND (nTaxRate = ? OR ? IS NULL AND nTaxRate IS NULL" & _
        ") AND (nTotalWholesale = ? OR ? IS NULL AND nTotalWholesale IS NULL) AND (sBuild" & _
        "ingPermit = ? OR ? IS NULL AND sBuildingPermit IS NULL) AND (sCommLocked = ? OR " & _
        "? IS NULL AND sCommLocked IS NULL) AND (sComplete = ? OR ? IS NULL AND sComplete" & _
        " IS NULL) AND (sContractSigned = ? OR ? IS NULL AND sContractSigned IS NULL) AND" & _
        " (sCounty = ? OR ? IS NULL AND sCounty IS NULL) AND (sDisclaimerSigned = ? OR ? " & _
        "IS NULL AND sDisclaimerSigned IS NULL) AND (sDrawingsSigned = ? OR ? IS NULL AND" & _
        " sDrawingsSigned IS NULL) AND (sInvNotes = ? OR ? IS NULL AND sInvNotes IS NULL)" & _
        " AND (sJobContact = ? OR ? IS NULL AND sJobContact IS NULL) AND (sJobDesc = ? OR" & _
        " ? IS NULL AND sJobDesc IS NULL) AND (sJobNo = ? OR ? IS NULL AND sJobNo IS NULL" & _
        ") AND (sPhone = ? OR ? IS NULL AND sPhone IS NULL) AND (sSalesperson = ? OR ? IS" & _
        " NULL AND sSalesperson IS NULL) AND (sTerms = ? OR ? IS NULL AND sTerms IS NULL)" & _
        ""
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dAmtYTD", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dAmtYTD1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCommPaid", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCommPaid1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCrLimit", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCrLimit1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCreated", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dCreated1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDrawing", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dDrawing1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dJobCreated", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_dJobCreated1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_lngCommissionStruct", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_lngCommissionStruct1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAddressID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAddressID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nCustID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLaborCharge", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLaborCharge1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nMaterialsCharge", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nMaterialsCharge1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTaxRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotalWholesale", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nTotalWholesale1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sBuildingPermit", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sBuildingPermit1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCommLocked", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCommLocked1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sComplete", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sComplete1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sContractSigned", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sContractSigned1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCounty", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sCounty1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDisclaimerSigned", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDisclaimerSigned1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDrawingsSigned", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDrawingsSigned1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sInvNotes", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sInvNotes1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobContact", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobContact1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobDesc", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobDesc1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobNo", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sJobNo1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sPhone", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sPhone1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSalesperson", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sSalesperson1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sTerms1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing))
        '
        'daJob
        '
        Me.daJob.DeleteCommand = Me.OleDbDeleteCommand4
        Me.daJob.InsertCommand = Me.OleDbInsertCommand5
        Me.daJob.SelectCommand = Me.OleDbSelectCommand6
        Me.daJob.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms")})})
        Me.daJob.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvDepositDates)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 557)
        Me.Panel1.TabIndex = 8
        '
        'OleDbSelectCommand7
        '
        Me.OleDbSelectCommand7.CommandText = "SELECT bTaxable, nAccountID, nAmount, nLineNumber, nSOID, sDesc, sHidden, sType F" & _
        "ROM tSOLine WHERE (nSOID = ?)"
        Me.OleDbSelectCommand7.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        '
        'OleDbInsertCommand6
        '
        Me.OleDbInsertCommand6.CommandText = "INSERT INTO tSOLine(bTaxable, nAccountID, nAmount, nLineNumber, nSOID, sDesc, sHi" & _
        "dden, sType) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, "bTaxable"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAccountID", System.Data.OleDb.OleDbType.Integer, 0, "nAccountID"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAmount", System.Data.OleDb.OleDbType.Double, 0, "nAmount"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "sDesc"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("sHidden", System.Data.OleDb.OleDbType.Boolean, 2, "sHidden"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("sType", System.Data.OleDb.OleDbType.VarWChar, 50, "sType"))
        '
        'OleDbUpdateCommand5
        '
        Me.OleDbUpdateCommand5.CommandText = "UPDATE tSOLine SET bTaxable = ?, nAccountID = ?, nAmount = ?, nLineNumber = ?, nS" & _
        "OID = ?, sDesc = ?, sHidden = ?, sType = ? WHERE (nLineNumber = ?) AND (nSOID = " & _
        "?) AND (bTaxable = ?) AND (nAccountID = ? OR ? IS NULL AND nAccountID IS NULL) A" & _
        "ND (nAmount = ? OR ? IS NULL AND nAmount IS NULL) AND (sDesc = ? OR ? IS NULL AN" & _
        "D sDesc IS NULL) AND (sHidden = ?) AND (sType = ? OR ? IS NULL AND sType IS NULL" & _
        ")"
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, "bTaxable"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAccountID", System.Data.OleDb.OleDbType.Integer, 0, "nAccountID"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nAmount", System.Data.OleDb.OleDbType.Double, 0, "nAmount"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, "nLineNumber"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("nSOID", System.Data.OleDb.OleDbType.Integer, 0, "nSOID"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, "sDesc"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sHidden", System.Data.OleDb.OleDbType.Boolean, 2, "sHidden"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("sType", System.Data.OleDb.OleDbType.VarWChar, 50, "sType"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bTaxable", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sHidden", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sHidden", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand5
        '
        Me.OleDbDeleteCommand5.CommandText = "DELETE FROM tSOLine WHERE (nLineNumber = ?) AND (nSOID = ?) AND (bTaxable = ?) AN" & _
        "D (nAccountID = ? OR ? IS NULL AND nAccountID IS NULL) AND (nAmount = ? OR ? IS " & _
        "NULL AND nAmount IS NULL) AND (sDesc = ? OR ? IS NULL AND sDesc IS NULL) AND (sH" & _
        "idden = ?) AND (sType = ? OR ? IS NULL AND sType IS NULL)"
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nLineNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nSOID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bTaxable", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bTaxable", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAccountID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nAmount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sDesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sHidden", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sHidden", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_sType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing))
        '
        'daSOLineByHeaderID
        '
        Me.daSOLineByHeaderID.DeleteCommand = Me.OleDbDeleteCommand5
        Me.daSOLineByHeaderID.InsertCommand = Me.OleDbInsertCommand6
        Me.daSOLineByHeaderID.SelectCommand = Me.OleDbSelectCommand7
        Me.daSOLineByHeaderID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("sType", "sType")})})
        Me.daSOLineByHeaderID.UpdateCommand = Me.OleDbUpdateCommand5
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frmCreateDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 557)
        Me.Controls.Add(Me.pnlDepositDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCreateDeposit"
        Me.Text = "Create Deposit"
        Me.pnlDepositDetail.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private depositTotal As Double
    Private mouseClick As Boolean

    Private ojob As New JobObj
    Private dt As New DataTable

    Private Sub frmCreateDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Not ojob.SelectALLData(Me.DsTKSI1) Then

        'Else
        If Not ojob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1) Then
            Windows.Forms.MessageBox.Show("Error reading database info")
            Exit Sub
        Else
            ojob.SelectALLSOHeaders(Me.DsTKSI1)
        End If

        LoadScreen()
    End Sub


    Private Sub LoadScreen()
        ojob.SelectDepositDateDistinct(dt)
        Me.lvCreateDeposit.Items.Clear()
        Me.lvDepositDates.Items.Clear()

        Dim drD As DataRow
        Dim itemtemp As ListViewItem

        Me.depositTotal = 0

        itemtemp = Me.lvDepositDates.Items.Add("-1")
        itemtemp.SubItems.Add("New Deposit")

        For Each drD In dt.Rows
            Try
                itemtemp = Me.lvDepositDates.Items.Add("0")
                itemtemp.SubItems.Add(CDate(drD(0)).ToShortDateString)
            Catch ex As Exception
            End Try
        Next

        Me.pnlDepositDetail.Enabled = False
    End Sub

    Private Function FigureJobPaymentPercentage(ByVal drsoline As dsTKSI.tSOLineRow) As Single
        Try
            Dim ds1 As New dsTKSI
            ds1.EnforceConstraints = False
            ojob.SelectSOandLinesBySOID(ds1, drsoline.nSOID)

            'Me.daSOLineByHeaderID.SelectCommand.Parameters(0).Value = drsoline.nSOID
            'Me.daSOLineByHeaderID.Fill(dt)

            Dim drLin As dsTKSI.tSOLineRow
            Dim paymentsfromCustomer As Single
            Dim chargesToJob As Single
            For Each drLin In ds1.tSOLine
                If drLin.sType = "Comment" Then
                    If drLin.nAmount > 0 Then
                        chargesToJob += drLin.nAmount
                    ElseIf drLin.nAmount < 0 Then
                        paymentsfromCustomer -= drLin.nAmount
                    End If
                End If
            Next
            If chargesToJob > 0 Then
                Return (paymentsfromCustomer / chargesToJob) * 100
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 999
        End Try
    End Function

    Private Sub AddDeposit(ByVal drsoline As dsTKSI.tSOLineRow)

        Dim sngJobPaymentPercent As Single
        sngJobPaymentPercent = FigureJobPaymentPercentage(drsoline)

        With drsoline
            Dim itemtemp As ListViewItem
            itemtemp = Me.lvCreateDeposit.Items.Add(drsoline.nSOID)
            With itemtemp
                .SubItems.Add(drsoline.nLineNumber)
                .SubItems.Add(drsoline.tSOHeaderRow.sSONum & " : " & drsoline.sDesc)
                .SubItems.Add(Format(drsoline.nAmount, "currency"))

                Dim datelocation As Long
                Dim endDate As Long
                Dim dateExtra As String
                datelocation = InStr(drsoline.sDesc, "/")
                If datelocation < 5 Then
                    datelocation = InStr(drsoline.sDesc, "-")
                End If

                If datelocation > 2 Then
                    dateExtra = Trim(Mid(drsoline.sDesc, datelocation - 2, datelocation + 8))
                    endDate = InStr(dateExtra, " ")
                    If endDate > 0 Then
                        dateExtra = Trim(Mid(dateExtra, 1, endDate))
                    End If

                    If Len(dateExtra) > 0 Then
                        Try
                            If IsDate(dateExtra) Then
                                .SubItems.Add(CDate(dateExtra).ToShortDateString)
                            Else
                                .SubItems.Add("1/1/2999")
                            End If
                        Catch ex As Exception
                            .SubItems.Add("1/1/2999")
                        End Try
                    Else
                        .SubItems.Add("1/1/2999")
                    End If
                Else
                    .SubItems.Add("1/1/2999")
                End If

                Try
                    .SubItems.Add(drsoline.tSOHeaderRow.tJobRow.sSalesperson)
                    .SubItems.Add(drsoline.tSOHeaderRow.tJobRow.tCustomrRow.sName)
                    .SubItems.Add(Decimal.Round(CDec(sngJobPaymentPercent), 0).ToString & "%")
                Catch ex As Exception
                End Try

                .Checked = True
            End With
        End With
    End Sub

    Private Sub ShowSelectedDeposit(ByVal selectedValue As String)
        Try
            Me.lvCreateDeposit.Items.Clear()
            If selectedValue = "New Deposit" Then
                ojob.SelectSOLinesNotDeposited(Me.DsTKSI1)
                Me.DateTimePicker1.Value = Today.Date
            Else
                ojob.SelectSOLinesOneDeposit(Me.DsTKSI1, CDate(selectedValue))
                Me.DateTimePicker1.Value = CDate(selectedValue)
            End If

            Me.depositTotal = 0

            Dim drSOLine As dsTKSI.tSOLineRow
            For Each drSOLine In Me.DsTKSI1.tSOLine
                Try
                    If (InStr(UCase(drSOLine.sDesc), "CHECK")) > 0 Or (InStr(UCase(drSOLine.sDesc), "CASH")) > 0 Then
                        Me.depositTotal += drSOLine.nAmount
                        AddDeposit(drSOLine)
                    End If
                Catch ex As Exception
                End Try
            Next
            Me.lblTotal.Text = Format(Me.depositTotal, "currency")
            Me.pnlDepositDetail.Enabled = True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("showselectedDeposit..." & ex.Message)
        End Try
    End Sub

    Private Sub butCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCheckAll.Click
        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvCreateDeposit.Items
            itemtemp.Checked = True
        Next
        RecalculateTotals()
    End Sub

    Private Sub butUncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUncheckAll.Click
        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvCreateDeposit.Items
            itemtemp.Checked = False
        Next
        RecalculateTotals()
    End Sub

    Private Sub CreateAllNewDepositsForDate(ByVal dDateDep As Date)
        Dim itemtemp As ListViewItem
        'examin all checked deposit items. add a record to tDeposits to assign this amount correctly
        Me.DsTKSI1.tDeposits.Clear()
        Me.DsTKSI1.tDeposits.AcceptChanges()

        For Each itemtemp In Me.lvCreateDeposit.CheckedItems
            Dim drDep As dsTKSI.tDepositsRow
            drDep = Me.DsTKSI1.tDeposits.NewRow
            With drDep
                .nSOID = itemtemp.Text
                .nLineNumber = itemtemp.SubItems(1).Text
                .dDateDeposit = dDateDep
                .sOther = ""
            End With
            Me.DsTKSI1.tDeposits.Rows.Add(drDep)
        Next
        ojob.UpdateDepositStartEnd(Me.DsTKSI1)
    End Sub

    Private Sub butCreateDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCreateDeposit.Click
        If Me.lvDepositDates.SelectedItems.Count = 1 Then
            If Me.lvDepositDates.SelectedItems(0).SubItems(1).Text = "New Deposit" Then
                CreateAllNewDepositsForDate(Me.DateTimePicker1.Value)
            Else
                Try
                    'delete existing deposits for selected date and re-created them based off of checked items
                    If IsDate2(Me.lvDepositDates.SelectedItems(0).SubItems(1).Text) Then
                        Dim dDate As Date
                        dDate = CDate(Me.lvDepositDates.SelectedItems(0).SubItems(1).Text)
                        Dim cmd As New SqlClient.SqlCommand
                        cmd.Connection = Me.ojob.sqlConn
                        cmd.Connection.Open()
                        cmd.CommandText = "delete * from tdeposits where ddatedeposit='" & dDate.ToShortDateString & "'"
                        cmd.ExecuteNonQuery()
                        cmd.Connection.Close()
                        CreateAllNewDepositsForDate(dDate)
                    End If
                Catch ex As Exception
                    Windows.Forms.MessageBox.Show("Failed to update... " & ex.Message)
                End Try

            End If

            LoadScreen()
        End If
    End Sub

    Private Sub lvDepositDates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDepositDates.SelectedIndexChanged
        Me.lvCreateDeposit.Items.Clear()
        Me.pnlDepositDetail.Enabled = False
        If Me.lvDepositDates.SelectedItems.Count = 1 Then
            ShowSelectedDeposit(Me.lvDepositDates.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub

    Private Sub lvCreateDeposit_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvCreateDeposit.ColumnClick
        If (Me.lvCreateDeposit.Columns(e.Column).Text = "Amount") Or (Me.lvCreateDeposit.Columns(e.Column).Text = "dateRec") Or (Me.lvCreateDeposit.Columns(e.Column).Text = "Customer") Or (Me.lvCreateDeposit.Columns(e.Column).Text = "Sales") Then
            ' Create a new instance of our Sorter class. Pass the number
            ' of the column that was clicked.
            Dim Sorter As ListViewSorter = _
                New ListViewSorter(e.Column, ListViewSorter.EnumSortOrder.Ascending)
            ' Tell the ListView to use the Sort
            sender.ListViewItemSorter = Sorter
        End If
    End Sub

    Private Sub lvCreateDeposit_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvCreateDeposit.ItemCheck
        If Me.mouseClick Then
            Try
                If e.NewValue = CheckState.Checked Then
                    Me.depositTotal += CDbl(CType(sender, ListView).Items(e.Index).SubItems(3).Text)
                Else
                    Me.depositTotal -= CDbl(CType(sender, ListView).Items(e.Index).SubItems(3).Text)
                End If
                Me.lblTotal.Text = Format(Me.depositTotal, "currency")
            Catch ex As Exception
                Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        Me.mouseClick = False

    End Sub

    Private Sub RecalculateTotals()
        depositTotal = 0
        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvCreateDeposit.CheckedItems
            Try
                Me.depositTotal += CDbl(itemtemp.SubItems(3).Text)
            Catch ex As Exception
                Me.lblTotal.Text = "ERROR"
                Exit Sub
            End Try
        Next
        Me.lblTotal.Text = Format(Me.depositTotal, "currency")
    End Sub

    Private Sub lvCreateDeposit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCreateDeposit.Click
        mouseClick = True
    End Sub

    Private Sub butPrintDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butPrintDeposit.Click
        Dim itemtemp As ListViewItem
        Dim oword As New Word.Application
        Try
            Dim oDoc As Word.Document
            oDoc = oword.Documents.Add
            oword.Visible = True
            With oword.Selection
                .Font.Size = 10
                .PageSetup.TopMargin = 50
                .PageSetup.BottomMargin = 50
                .PageSetup.LeftMargin = 50
                .PageSetup.RightMargin = 50
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(3.1), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(4.0), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(4.7), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(5.3), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)
                .ParagraphFormat.TabStops.Add(Position:=oword.Application.InchesToPoints(6.5), Alignment:=Word.WdTabAlignment.wdAlignTabLeft, Leader:=Word.WdTabLeader.wdTabLeaderSpaces)

                .Font.Bold = True

                .TypeText("DEPOSIT")
                .TypeText(vbTab)

                .TypeText("Date: " & Me.DateTimePicker1.Value.ToShortDateString)
                .TypeParagraph()
                .TypeParagraph()
                .TypeParagraph()

                .Font.Bold = False
                .TypeText("Job/Check Detail")
                .TypeText(vbTab)

                .TypeText("Amount")
                .TypeParagraph()
                .TypeText("------------------------------------------------------------------------------------------------")
                .TypeParagraph()
                .TypeParagraph()

                For Each itemtemp In Me.lvCreateDeposit.CheckedItems
                    .TypeText(itemtemp.SubItems(2).Text)
                    .TypeText(vbTab)
                    .TypeText(itemtemp.SubItems(3).Text)
                    .TypeText(vbTab)
                    .TypeText(itemtemp.SubItems(4).Text)
                    .TypeText(vbTab)
                    .TypeText(itemtemp.SubItems(5).Text)
                    .TypeText(vbTab)
                    .TypeText(Mid(itemtemp.SubItems(6).Text, 1, 16))
                    .TypeText(vbTab)
                    .TypeText(itemtemp.SubItems(7).Text)
                    'Try
                    '    '.TypeText(vbTab)
                    '    '.TypeText(itemtemp.SubItems(7).Text)
                    'Catch ex As Exception
                    'End Try
                    .TypeParagraph()
                Next
                .TypeParagraph()
                .TypeParagraph()
                .TypeText("Total: " & Format(Me.depositTotal, "currency"))
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
            oword.Quit()
        Finally

        End Try

    End Sub


End Class
