Option Strict Off
Option Explicit On
Friend Class VendorSearch
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
	
		'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.sqlConn.ConnectionString = cnSQL
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
    Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtLocSearch As System.Windows.Forms.TextBox
    Public WithEvents lblSearch As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents lvVendor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnKitchencraft As System.Windows.Forms.Button
    Friend WithEvents btnCrestwood As System.Windows.Forms.Button
    Friend WithEvents btnKoch As System.Windows.Forms.Button
    Friend WithEvents btnSWO As System.Windows.Forms.Button
    Friend WithEvents btnAristokraft As System.Windows.Forms.Button
    Friend WithEvents btnLarsons As System.Windows.Forms.Button
    Friend WithEvents btnLouis As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorSearch))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtLocSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daVendor = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.lvVendor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnKitchencraft = New System.Windows.Forms.Button()
        Me.btnCrestwood = New System.Windows.Forms.Button()
        Me.btnKoch = New System.Windows.Forms.Button()
        Me.btnSWO = New System.Windows.Forms.Button()
        Me.btnAristokraft = New System.Windows.Forms.Button()
        Me.btnLarsons = New System.Windows.Forms.Button()
        Me.btnLouis = New System.Windows.Forms.Button()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(8, 223)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(216, 25)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(244, 223)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(216, 25)
        Me.cmdOK.TabIndex = 3
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'txtLocSearch
        '
        Me.txtLocSearch.AcceptsReturn = True
        Me.txtLocSearch.BackColor = System.Drawing.Color.White
        Me.txtLocSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocSearch.Location = New System.Drawing.Point(8, 16)
        Me.txtLocSearch.MaxLength = 0
        Me.txtLocSearch.Name = "txtLocSearch"
        Me.txtLocSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocSearch.Size = New System.Drawing.Size(248, 22)
        Me.txtLocSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSearch.Size = New System.Drawing.Size(472, 40)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Type Search Criteria:"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax FROM dbo.tVendor ORDER BY sName"
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERV" & _
    "ER;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
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
        'daVendor
        '
        Me.daVendor.DeleteCommand = Me.SqlDeleteCommand1
        Me.daVendor.InsertCommand = Me.SqlInsertCommand1
        Me.daVendor.SelectCommand = Me.SqlSelectCommand1
        Me.daVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        Me.daVendor.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvVendor
        '
        Me.lvVendor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvVendor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvVendor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVendor.FullRowSelect = True
        Me.lvVendor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvVendor.HideSelection = False
        Me.lvVendor.Location = New System.Drawing.Point(8, 44)
        Me.lvVendor.MultiSelect = False
        Me.lvVendor.Name = "lvVendor"
        Me.lvVendor.Size = New System.Drawing.Size(464, 155)
        Me.lvVendor.TabIndex = 5
        Me.lvVendor.UseCompatibleStateImageBehavior = False
        Me.lvVendor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 240
        '
        'btnKitchencraft
        '
        Me.btnKitchencraft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKitchencraft.Location = New System.Drawing.Point(477, 0)
        Me.btnKitchencraft.Name = "btnKitchencraft"
        Me.btnKitchencraft.Size = New System.Drawing.Size(140, 28)
        Me.btnKitchencraft.TabIndex = 6
        Me.btnKitchencraft.Tag = "228"
        Me.btnKitchencraft.Text = "Kitchen Craft"
        Me.btnKitchencraft.UseVisualStyleBackColor = False
        '
        'btnCrestwood
        '
        Me.btnCrestwood.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCrestwood.Location = New System.Drawing.Point(477, 32)
        Me.btnCrestwood.Name = "btnCrestwood"
        Me.btnCrestwood.Size = New System.Drawing.Size(140, 28)
        Me.btnCrestwood.TabIndex = 7
        Me.btnCrestwood.Tag = "108"
        Me.btnCrestwood.Text = "Crestwood"
        Me.btnCrestwood.UseVisualStyleBackColor = False
        '
        'btnKoch
        '
        Me.btnKoch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKoch.Location = New System.Drawing.Point(477, 63)
        Me.btnKoch.Name = "btnKoch"
        Me.btnKoch.Size = New System.Drawing.Size(140, 28)
        Me.btnKoch.TabIndex = 8
        Me.btnKoch.Tag = "719"
        Me.btnKoch.Text = "Koch"
        Me.btnKoch.UseVisualStyleBackColor = False
        '
        'btnSWO
        '
        Me.btnSWO.Location = New System.Drawing.Point(477, 220)
        Me.btnSWO.Name = "btnSWO"
        Me.btnSWO.Size = New System.Drawing.Size(140, 28)
        Me.btnSWO.TabIndex = 9
        Me.btnSWO.Tag = "488"
        Me.btnSWO.Text = "SWO"
        Me.btnSWO.UseVisualStyleBackColor = True
        '
        'btnAristokraft
        '
        Me.btnAristokraft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAristokraft.Location = New System.Drawing.Point(477, 95)
        Me.btnAristokraft.Name = "btnAristokraft"
        Me.btnAristokraft.Size = New System.Drawing.Size(140, 28)
        Me.btnAristokraft.TabIndex = 10
        Me.btnAristokraft.Tag = "30"
        Me.btnAristokraft.Text = "Aristokraft"
        Me.btnAristokraft.UseVisualStyleBackColor = False
        '
        'btnLarsons
        '
        Me.btnLarsons.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLarsons.Location = New System.Drawing.Point(477, 169)
        Me.btnLarsons.Name = "btnLarsons"
        Me.btnLarsons.Size = New System.Drawing.Size(140, 28)
        Me.btnLarsons.TabIndex = 11
        Me.btnLarsons.Tag = "1232"
        Me.btnLarsons.Text = "Rugby"
        Me.btnLarsons.UseVisualStyleBackColor = False
        '
        'btnLouis
        '
        Me.btnLouis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLouis.Location = New System.Drawing.Point(477, 139)
        Me.btnLouis.Name = "btnLouis"
        Me.btnLouis.Size = New System.Drawing.Size(140, 28)
        Me.btnLouis.TabIndex = 12
        Me.btnLouis.Tag = "513"
        Me.btnLouis.Text = "Louis and Company"
        Me.btnLouis.UseVisualStyleBackColor = False
        '
        'VendorSearch
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(684, 277)
        Me.Controls.Add(Me.btnLouis)
        Me.Controls.Add(Me.btnLarsons)
        Me.Controls.Add(Me.btnAristokraft)
        Me.Controls.Add(Me.btnSWO)
        Me.Controls.Add(Me.btnKoch)
        Me.Controls.Add(Me.btnCrestwood)
        Me.Controls.Add(Me.btnKitchencraft)
        Me.Controls.Add(Me.txtLocSearch)
        Me.Controls.Add(Me.lvVendor)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblSearch)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "VendorSearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search for Vendor"
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public OK As Boolean
    Private lID As Integer
    Private dc As linqTKSIDataContext

    Public Sub New(_dc As linqTKSIDataContext)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.sqlConn.ConnectionString = cnSQL
        dc = _dc
    End Sub

    Public ReadOnly Property ID() As Integer
        Get
            ID = lID
        End Get
    End Property

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        OK = False
        Me.Hide()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        saveSelection()
    End Sub

    Private Sub saveSelection()
        If Me.lvVendor.SelectedItems.Count = 1 Then
            lID = Me.lvVendor.SelectedItems(0).Text
            If dc IsNot Nothing Then

            End If
            OK = True
            Me.Hide()
        Else
            OK = False
            Me.Hide()
        End If
   
    End Sub
    Private Sub VendorSearch_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Me.DsTKSI1.tVendor.Clear()
        Me.daVendor.Fill(Me.DsTKSI1.tVendor)
        Me.lvVendor.Items.Clear()
        Dim drVen As dsTKSI.tVendorRow
        For Each drVen In Me.DsTKSI1.tVendor
            Me.AddVendorListItem(drVen.lid, drVen.sName, drVen.sStreet1 & " " & drVen.sStreet2)
        Next

    End Sub

    Private Sub AddVendorListItem(ByVal LID As Long, ByVal sName As String, ByVal sStreet As String)
        Dim item1 As Windows.Forms.ListViewItem
        item1 = Me.lvVendor.Items.Add(LID)
        item1.SubItems.Add(sName)
        item1.SubItems.Add(sStreet)
    End Sub

    Private Sub gridVendor_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        saveSelection()
    End Sub

    'UPGRADE_WARNING: Event txtLocSearch.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub txtLocSearch_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocSearch.TextChanged
        Try
            If Len(txtLocSearch.Text) > 0 Then
                Me.lvVendor.Items.Clear()

                Dim draVen As dsTKSI.tVendorRow()
                draVen = Me.DsTKSI1.tVendor.Select("sName like '" & Me.txtLocSearch.Text.Trim & "%'")
                If draVen.Length > 0 Then
                    'we have some matches
                    Dim drVen As dsTKSI.tVendorRow
                    Dim i As Long = 0
                    For Each drVen In draVen
                        i += 1
                        Me.AddVendorListItem(drVen.lid, drVen.sName, drVen.sStreet1 & " " & drVen.sStreet2)
                    Next
                    If i = 1 And Me.lvVendor.Items.Count > 0 Then
                        Me.lvVendor.Items(0).Selected = True
                    End If
                End If
                ' mrsVendor.Filter = "sname like '" & CStr(txtLocSearch.Text) & "%'"
                ' mrsVendor.Requery()
            End If
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub btnKitchencraft_Click(sender As Object, e As EventArgs) Handles btnKitchencraft.Click, btnAristokraft.Click, btnCrestwood.Click, btnKoch.Click, btnLarsons.Click, btnSWO.Click, btnLouis.Click
        Dim sID As String = sender.tag
        Dim lidUser As Integer = -1
        If Integer.TryParse(sID, lidUser) Then
            lID = lidUser
            OK = True
            Me.Hide()

        End If
    End Sub
End Class