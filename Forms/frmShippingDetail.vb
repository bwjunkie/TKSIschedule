Imports System.Windows.Forms
Imports System.Drawing

Public Class frmShippingDetail
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
    Friend WithEvents lblPO As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daShippingHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daShippingItems As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents daTrailerHeader As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lvReceiving As System.Windows.Forms.ListView
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.lvReceiving = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.daShippingHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daShippingItems = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.daTrailerHeader = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPO
        '
        Me.lblPO.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPO.Location = New System.Drawing.Point(0, 0)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(235, 0)
        Me.lblPO.TabIndex = 0
        Me.lblPO.Text = "PO"
        '
        'lvReceiving
        '
        Me.lvReceiving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReceiving.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvReceiving.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvReceiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceiving.FullRowSelect = True
        Me.lvReceiving.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvReceiving.Location = New System.Drawing.Point(0, -33)
        Me.lvReceiving.Name = "lvReceiving"
        Me.lvReceiving.Size = New System.Drawing.Size(608, 526)
        Me.lvReceiving.TabIndex = 1
        Me.lvReceiving.UseCompatibleStateImageBehavior = False
        Me.lvReceiving.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Line / Code"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 330
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 120
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=TZ250;packet size=4096;user id=tksidatauser;data source=DELL-SERVE" & _
    "R;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'daShippingHeader
        '
        Me.daShippingHeader.SelectCommand = Me.SqlSelectCommand1
        Me.daShippingHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblShippingHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierCode", "SupplierCode"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("SupplierSONum", "SupplierSONum"), New System.Data.Common.DataColumnMapping("OrderStatus", "OrderStatus"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("StyleDesc", "StyleDesc"), New System.Data.Common.DataColumnMapping("DateImported", "DateImported"), New System.Data.Common.DataColumnMapping("DateCompletion", "DateCompletion"), New System.Data.Common.DataColumnMapping("DateClosed", "DateClosed"), New System.Data.Common.DataColumnMapping("DateOrder", "DateOrder"), New System.Data.Common.DataColumnMapping("OrderLines", "OrderLines"), New System.Data.Common.DataColumnMapping("TotalCabs", "TotalCabs")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO")})
        '
        'daShippingItems
        '
        Me.daShippingItems.SelectCommand = Me.SqlSelectCommand2
        Me.daShippingItems.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblShippingItems", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierSO", "SupplierSO"), New System.Data.Common.DataColumnMapping("LineNumber", "LineNumber"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("ProdDesc", "ProdDesc"), New System.Data.Common.DataColumnMapping("CabType", "CabType"), New System.Data.Common.DataColumnMapping("ColorDesc", "ColorDesc"), New System.Data.Common.DataColumnMapping("ColorCode", "ColorCode"), New System.Data.Common.DataColumnMapping("ProdCode", "ProdCode"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("StyleDesc", "StyleDesc"), New System.Data.Common.DataColumnMapping("DateImported", "DateImported"), New System.Data.Common.DataColumnMapping("DateReceived", "DateReceived"), New System.Data.Common.DataColumnMapping("DateDelivered", "DateDelivered"), New System.Data.Common.DataColumnMapping("DateLastChanged", "DateLastChanged"), New System.Data.Common.DataColumnMapping("SpecialNote1", "SpecialNote1"), New System.Data.Common.DataColumnMapping("SpecialNote2", "SpecialNote2"), New System.Data.Common.DataColumnMapping("QuantityRec", "QuantityRec"), New System.Data.Common.DataColumnMapping("QuantityDel", "QuantityDel")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 50, "PO")})
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'daTrailerHeader
        '
        Me.daTrailerHeader.SelectCommand = Me.SqlSelectCommand4
        Me.daTrailerHeader.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTrailerHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PalletNum", "PalletNum"), New System.Data.Common.DataColumnMapping("SO", "SO"), New System.Data.Common.DataColumnMapping("PO", "PO"), New System.Data.Common.DataColumnMapping("ShipDate", "ShipDate"), New System.Data.Common.DataColumnMapping("TrailerControl", "TrailerControl"), New System.Data.Common.DataColumnMapping("FreightTermsCode", "FreightTermsCode"), New System.Data.Common.DataColumnMapping("FreightCode", "FreightCode"), New System.Data.Common.DataColumnMapping("ShipType", "ShipType"), New System.Data.Common.DataColumnMapping("TrailerNumber", "TrailerNumber")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT PalletNum, SO, PO, ShipDate, TrailerControl, FreightTermsCode, FreightCode" & _
    ", ShipType, TrailerNumber FROM dbo.tblTrailerHeader WHERE (PO = @PO) ORDER BY Tr" & _
    "ailerControl, PO"
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PO", System.Data.SqlDbType.VarChar, 30, "PO")})
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 0)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Received"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGreen
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 0)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Delivered"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 0)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Not Received"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmShippingDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(608, 493)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPO)
        Me.Controls.Add(Me.lvReceiving)
        Me.Name = "frmShippingDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Detail"
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private sPOnum As String = ""
    Private daTrailerDetail As New dsTKSITableAdapters.tblTrailerDetailTableAdapter
  
    Public Sub LoadByPO(_spoNum As String)
        sPOnum = _spoNum
    End Sub

    Private Sub frmShippingDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DsTKSI1.tblTrailerDetail.Clear()
        Me.daTrailerDetail.FillByLikePO(Me.DsTKSI1.tblTrailerDetail, Me.sPOnum)

        Me.DsTKSI1.tblTrailerHeader.Clear()
        Me.daTrailerHeader.SelectCommand.Parameters("@PO").Value = Me.sPOnum
        Me.daTrailerHeader.Fill(Me.DsTKSI1.tblTrailerHeader)

        Dim drHeader As dsTKSI.tblTrailerHeaderRow
        Dim drDetail As dsTKSI.tblTrailerDetailRow

        Dim lastPO As String = ""

        Dim itemcolor As Color

        For Each drDetail In Me.DsTKSI1.tblTrailerDetail
            itemcolor = Color.White
            drHeader = drDetail.tblTrailerHeaderRow

            If drDetail.IsDeliveredTKSINull Then
                If drDetail.IsDateScannedTKSINull Then
                    'list the item
                    'white not recieved or delivered
                Else
                    itemcolor = Color.Yellow
                End If
            Else
                itemcolor = Me.Label2.BackColor
            End If

            Dim item1 As New ListViewItem(drDetail.OrderLineNumber)
            item1.SubItems.Add(drDetail.DetailDescription)
            If drDetail.IsDateScannedTKSINull Then
                item1.SubItems.Add("")
            Else
                item1.SubItems.Add(drDetail.DateScannedTKSI.ToShortDateString)
            End If

            item1.BackColor = itemcolor
            Me.lvReceiving.Items.Add(item1)

            If drDetail.DamageNotes.Trim.Length > 0 Then
                item1 = New ListViewItem(drDetail.OrderLineNumber)
                item1.SubItems.Add(drDetail.DamageNotes)
                item1.BackColor = Color.White
                Me.lvReceiving.Items.Add(item1)
            End If
        Next

    End Sub
End Class
