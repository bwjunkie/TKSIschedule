Imports System.Windows.Forms
Imports System.Drawing

Friend Class CustDetail
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        'This call is required by the Windows Form Designer.
		InitializeComponent()
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
    Public WithEvents cmdClose As System.Windows.Forms.Button
    Public WithEvents lblCustName As System.Windows.Forms.Label
    Public WithEvents lblJobTitle As System.Windows.Forms.Label
    Public WithEvents _lblLabels_10 As System.Windows.Forms.Label
    Public WithEvents _lblLabels_12 As System.Windows.Forms.Label
    Public WithEvents _lblLabels_11 As System.Windows.Forms.Label
    Public WithEvents _lblLabels_7 As System.Windows.Forms.Label
    Public WithEvents _lblLabels_6 As System.Windows.Forms.Label
    Public WithEvents _lblLabels_5 As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Public WithEvents txtFax As System.Windows.Forms.TextBox
    Public WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Public WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Public WithEvents txtZip As System.Windows.Forms.TextBox
    Public WithEvents txtState As System.Windows.Forms.TextBox
    Public WithEvents txtCity As System.Windows.Forms.TextBox
    Public WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Public WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents lvJobs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents daJobByNCustID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddressByNCustID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents btnSaveNote As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNote As System.Windows.Forms.TextBox
    Friend WithEvents daCustByLID As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustDetail))
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtPhone2 = New System.Windows.Forms.TextBox
        Me.txtPhone1 = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.lblCustName = New System.Windows.Forms.Label
        Me.lblJobTitle = New System.Windows.Forms.Label
        Me._lblLabels_10 = New System.Windows.Forms.Label
        Me._lblLabels_12 = New System.Windows.Forms.Label
        Me._lblLabels_11 = New System.Windows.Forms.Label
        Me._lblLabels_7 = New System.Windows.Forms.Label
        Me._lblLabels_6 = New System.Windows.Forms.Label
        Me._lblLabels_5 = New System.Windows.Forms.Label
        Me.DsTKSI1 = New TKSISchedule.dsTKSI
        Me.lvJobs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daJobByNCustID = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daAddressByNCustID = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daCustByLID = New System.Data.SqlClient.SqlDataAdapter
        Me.btnSaveNote = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtInvoiceNote = New System.Windows.Forms.TextBox
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(20, 578)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'txtFax
        '
        Me.txtFax.AcceptsReturn = True
        Me.txtFax.BackColor = System.Drawing.SystemColors.Window
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFax.Location = New System.Drawing.Point(168, 88)
        Me.txtFax.MaxLength = 0
        Me.txtFax.Name = "txtFax"
        Me.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFax.Size = New System.Drawing.Size(361, 17)
        Me.txtFax.TabIndex = 12
        '
        'txtPhone2
        '
        Me.txtPhone2.AcceptsReturn = True
        Me.txtPhone2.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone2.Location = New System.Drawing.Point(168, 64)
        Me.txtPhone2.MaxLength = 0
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone2.Size = New System.Drawing.Size(361, 17)
        Me.txtPhone2.TabIndex = 11
        '
        'txtPhone1
        '
        Me.txtPhone1.AcceptsReturn = True
        Me.txtPhone1.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone1.Location = New System.Drawing.Point(168, 40)
        Me.txtPhone1.MaxLength = 0
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone1.Size = New System.Drawing.Size(361, 17)
        Me.txtPhone1.TabIndex = 9
        '
        'txtZip
        '
        Me.txtZip.AcceptsReturn = True
        Me.txtZip.BackColor = System.Drawing.SystemColors.Window
        Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtZip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZip.Location = New System.Drawing.Point(416, 160)
        Me.txtZip.MaxLength = 0
        Me.txtZip.Name = "txtZip"
        Me.txtZip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZip.Size = New System.Drawing.Size(113, 17)
        Me.txtZip.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.AcceptsReturn = True
        Me.txtState.BackColor = System.Drawing.SystemColors.Window
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtState.Location = New System.Drawing.Point(328, 160)
        Me.txtState.MaxLength = 0
        Me.txtState.Name = "txtState"
        Me.txtState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtState.Size = New System.Drawing.Size(81, 17)
        Me.txtState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCity.Location = New System.Drawing.Point(168, 160)
        Me.txtCity.MaxLength = 0
        Me.txtCity.Name = "txtCity"
        Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCity.Size = New System.Drawing.Size(153, 17)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress2
        '
        Me.txtAddress2.AcceptsReturn = True
        Me.txtAddress2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress2.Location = New System.Drawing.Point(168, 136)
        Me.txtAddress2.MaxLength = 0
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress2.Size = New System.Drawing.Size(361, 17)
        Me.txtAddress2.TabIndex = 3
        '
        'txtAddress1
        '
        Me.txtAddress1.AcceptsReturn = True
        Me.txtAddress1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress1.Location = New System.Drawing.Point(168, 112)
        Me.txtAddress1.MaxLength = 0
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress1.Size = New System.Drawing.Size(361, 17)
        Me.txtAddress1.TabIndex = 1
        '
        'lblCustName
        '
        Me.lblCustName.BackColor = System.Drawing.Color.White
        Me.lblCustName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCustName.Location = New System.Drawing.Point(16, 8)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustName.Size = New System.Drawing.Size(441, 25)
        Me.lblCustName.TabIndex = 17
        '
        'lblJobTitle
        '
        Me.lblJobTitle.BackColor = System.Drawing.SystemColors.Window
        Me.lblJobTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblJobTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobTitle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblJobTitle.Location = New System.Drawing.Point(14, 242)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblJobTitle.Size = New System.Drawing.Size(465, 17)
        Me.lblJobTitle.TabIndex = 16
        Me.lblJobTitle.Text = "Jobs for this customer:"
        '
        '_lblLabels_10
        '
        Me._lblLabels_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblLabels_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabels_10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabels_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblLabels_10.Location = New System.Drawing.Point(16, 88)
        Me._lblLabels_10.Name = "_lblLabels_10"
        Me._lblLabels_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabels_10.Size = New System.Drawing.Size(136, 17)
        Me._lblLabels_10.TabIndex = 15
        Me._lblLabels_10.Text = "Fax"
        '
        '_lblLabels_12
        '
        Me._lblLabels_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblLabels_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabels_12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabels_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblLabels_12.Location = New System.Drawing.Point(16, 64)
        Me._lblLabels_12.Name = "_lblLabels_12"
        Me._lblLabels_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabels_12.Size = New System.Drawing.Size(136, 17)
        Me._lblLabels_12.TabIndex = 10
        Me._lblLabels_12.Text = "Phone 2"
        '
        '_lblLabels_11
        '
        Me._lblLabels_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblLabels_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabels_11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabels_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblLabels_11.Location = New System.Drawing.Point(16, 39)
        Me._lblLabels_11.Name = "_lblLabels_11"
        Me._lblLabels_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabels_11.Size = New System.Drawing.Size(136, 17)
        Me._lblLabels_11.TabIndex = 8
        Me._lblLabels_11.Text = "Phone 1"
        '
        '_lblLabels_7
        '
        Me._lblLabels_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblLabels_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabels_7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabels_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblLabels_7.Location = New System.Drawing.Point(16, 160)
        Me._lblLabels_7.Name = "_lblLabels_7"
        Me._lblLabels_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabels_7.Size = New System.Drawing.Size(136, 17)
        Me._lblLabels_7.TabIndex = 4
        Me._lblLabels_7.Text = "City-State-Zip"
        '
        '_lblLabels_6
        '
        Me._lblLabels_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblLabels_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabels_6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabels_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblLabels_6.Location = New System.Drawing.Point(16, 136)
        Me._lblLabels_6.Name = "_lblLabels_6"
        Me._lblLabels_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabels_6.Size = New System.Drawing.Size(136, 17)
        Me._lblLabels_6.TabIndex = 2
        Me._lblLabels_6.Text = "Address 2:"
        '
        '_lblLabels_5
        '
        Me._lblLabels_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblLabels_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLabels_5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLabels_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblLabels_5.Location = New System.Drawing.Point(16, 112)
        Me._lblLabels_5.Name = "_lblLabels_5"
        Me._lblLabels_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLabels_5.Size = New System.Drawing.Size(136, 17)
        Me._lblLabels_5.TabIndex = 0
        Me._lblLabels_5.Text = "Address 1:"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvJobs
        '
        Me.lvJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvJobs.FullRowSelect = True
        Me.lvJobs.HideSelection = False
        Me.lvJobs.Location = New System.Drawing.Point(16, 262)
        Me.lvJobs.Name = "lvJobs"
        Me.lvJobs.Size = New System.Drawing.Size(608, 292)
        Me.lvJobs.TabIndex = 18
        Me.lvJobs.UseCompatibleStateImageBehavior = False
        Me.lvJobs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Customers - Jobs"
        Me.ColumnHeader3.Width = 580
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCUSTID", System.Data.SqlDbType.Int, 4, "nCustID")})
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=ORANGE;packet size=4096;user id=tksidatauser;data source=DELL-SERVER;per" & _
            "sist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID"), New System.Data.SqlClient.SqlParameter("@sJobDesc", System.Data.SqlDbType.VarChar, 255, "sJobDesc"), New System.Data.SqlClient.SqlParameter("@dCreated", System.Data.SqlDbType.DateTime, 4, "dCreated"), New System.Data.SqlClient.SqlParameter("@dJobCreated", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@sJobNo", System.Data.SqlDbType.VarChar, 255, "sJobNo"), New System.Data.SqlClient.SqlParameter("@nCustID", System.Data.SqlDbType.Int, 4, "nCustID"), New System.Data.SqlClient.SqlParameter("@sPhone", System.Data.SqlDbType.VarChar, 255, "sPhone"), New System.Data.SqlClient.SqlParameter("@sJobContact", System.Data.SqlDbType.VarChar, 255, "sJobContact"), New System.Data.SqlClient.SqlParameter("@sCounty", System.Data.SqlDbType.VarChar, 255, "sCounty"), New System.Data.SqlClient.SqlParameter("@nTotalWholesale", System.Data.SqlDbType.Float, 8, "nTotalWholesale"), New System.Data.SqlClient.SqlParameter("@sBuildingPermit", System.Data.SqlDbType.VarChar, 255, "sBuildingPermit"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 255, "sTerms"), New System.Data.SqlClient.SqlParameter("@dDrawing", System.Data.SqlDbType.VarChar, 255, "dDrawing"), New System.Data.SqlClient.SqlParameter("@nMaterialsCharge", System.Data.SqlDbType.Float, 8, "nMaterialsCharge"), New System.Data.SqlClient.SqlParameter("@nTaxRate", System.Data.SqlDbType.Float, 8, "nTaxRate"), New System.Data.SqlClient.SqlParameter("@nLaborCharge", System.Data.SqlDbType.Float, 8, "nLaborCharge"), New System.Data.SqlClient.SqlParameter("@sContractSigned", System.Data.SqlDbType.VarChar, 255, "sContractSigned"), New System.Data.SqlClient.SqlParameter("@sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, "sDisclaimerSigned"), New System.Data.SqlClient.SqlParameter("@sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, "sDrawingsSigned"), New System.Data.SqlClient.SqlParameter("@sComplete", System.Data.SqlDbType.VarChar, 255, "sComplete"), New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson"), New System.Data.SqlClient.SqlParameter("@sOtherNotes", System.Data.SqlDbType.VarChar, 3000, "sOtherNotes"), New System.Data.SqlClient.SqlParameter("@dCommPaid", System.Data.SqlDbType.DateTime, 4, "dCommPaid"), New System.Data.SqlClient.SqlParameter("@sCommLocked", System.Data.SqlDbType.VarChar, 50, "sCommLocked"), New System.Data.SqlClient.SqlParameter("@dCrLimit", System.Data.SqlDbType.Money, 8, "dCrLimit"), New System.Data.SqlClient.SqlParameter("@dAmtYTD", System.Data.SqlDbType.Money, 8, "dAmtYTD"), New System.Data.SqlClient.SqlParameter("@sInvNotes", System.Data.SqlDbType.VarChar, 255, "sInvNotes"), New System.Data.SqlClient.SqlParameter("@lngCommissionStruct", System.Data.SqlDbType.Int, 4, "lngCommissionStruct")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID"), New System.Data.SqlClient.SqlParameter("@sJobDesc", System.Data.SqlDbType.VarChar, 255, "sJobDesc"), New System.Data.SqlClient.SqlParameter("@dCreated", System.Data.SqlDbType.DateTime, 4, "dCreated"), New System.Data.SqlClient.SqlParameter("@dJobCreated", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@sJobNo", System.Data.SqlDbType.VarChar, 255, "sJobNo"), New System.Data.SqlClient.SqlParameter("@nCustID", System.Data.SqlDbType.Int, 4, "nCustID"), New System.Data.SqlClient.SqlParameter("@sPhone", System.Data.SqlDbType.VarChar, 255, "sPhone"), New System.Data.SqlClient.SqlParameter("@sJobContact", System.Data.SqlDbType.VarChar, 255, "sJobContact"), New System.Data.SqlClient.SqlParameter("@sCounty", System.Data.SqlDbType.VarChar, 255, "sCounty"), New System.Data.SqlClient.SqlParameter("@nTotalWholesale", System.Data.SqlDbType.Float, 8, "nTotalWholesale"), New System.Data.SqlClient.SqlParameter("@sBuildingPermit", System.Data.SqlDbType.VarChar, 255, "sBuildingPermit"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 255, "sTerms"), New System.Data.SqlClient.SqlParameter("@dDrawing", System.Data.SqlDbType.VarChar, 255, "dDrawing"), New System.Data.SqlClient.SqlParameter("@nMaterialsCharge", System.Data.SqlDbType.Float, 8, "nMaterialsCharge"), New System.Data.SqlClient.SqlParameter("@nTaxRate", System.Data.SqlDbType.Float, 8, "nTaxRate"), New System.Data.SqlClient.SqlParameter("@nLaborCharge", System.Data.SqlDbType.Float, 8, "nLaborCharge"), New System.Data.SqlClient.SqlParameter("@sContractSigned", System.Data.SqlDbType.VarChar, 255, "sContractSigned"), New System.Data.SqlClient.SqlParameter("@sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, "sDisclaimerSigned"), New System.Data.SqlClient.SqlParameter("@sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, "sDrawingsSigned"), New System.Data.SqlClient.SqlParameter("@sComplete", System.Data.SqlDbType.VarChar, 255, "sComplete"), New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson"), New System.Data.SqlClient.SqlParameter("@sOtherNotes", System.Data.SqlDbType.VarChar, 3000, "sOtherNotes"), New System.Data.SqlClient.SqlParameter("@dCommPaid", System.Data.SqlDbType.DateTime, 4, "dCommPaid"), New System.Data.SqlClient.SqlParameter("@sCommLocked", System.Data.SqlDbType.VarChar, 50, "sCommLocked"), New System.Data.SqlClient.SqlParameter("@dCrLimit", System.Data.SqlDbType.Money, 8, "dCrLimit"), New System.Data.SqlClient.SqlParameter("@dAmtYTD", System.Data.SqlDbType.Money, 8, "dAmtYTD"), New System.Data.SqlClient.SqlParameter("@sInvNotes", System.Data.SqlDbType.VarChar, 255, "sInvNotes"), New System.Data.SqlClient.SqlParameter("@lngCommissionStruct", System.Data.SqlDbType.Int, 4, "lngCommissionStruct"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dAmtYTD", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCommPaid", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCrLimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDrawing", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dJobCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_lngCommissionStruct", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAddressID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCustID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nLaborCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nMaterialsCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTaxRate", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotalWholesale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBuildingPermit", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCommLocked", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sComplete", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sContractSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCounty", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sInvNotes", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobContact", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobDesc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobNo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOtherNotes", System.Data.SqlDbType.VarChar, 3000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOtherNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sSalesperson", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dAmtYTD", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCommPaid", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCrLimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDrawing", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dJobCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_lngCommissionStruct", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAddressID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCustID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nLaborCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nMaterialsCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTaxRate", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotalWholesale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBuildingPermit", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCommLocked", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sComplete", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sContractSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCounty", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sInvNotes", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobContact", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobDesc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobNo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOtherNotes", System.Data.SqlDbType.VarChar, 3000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOtherNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sSalesperson", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daJobByNCustID
        '
        Me.daJobByNCustID.DeleteCommand = Me.SqlDeleteCommand1
        Me.daJobByNCustID.InsertCommand = Me.SqlInsertCommand1
        Me.daJobByNCustID.SelectCommand = Me.SqlSelectCommand1
        Me.daJobByNCustID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        Me.daJobByNCustID.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NCUSTID", System.Data.SqlDbType.Int, 4, "nCustID")})
        '
        'daAddressByNCustID
        '
        Me.daAddressByNCustID.SelectCommand = Me.SqlSelectCommand2
        Me.daAddressByNCustID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT lID, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
            "Phone1, sPhone2, sFax, dCrLimit, dAmtYTD FROM dbo.tCustomr WHERE (lID = @LID)"
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@LID", System.Data.SqlDbType.Int, 4, "lID")})
        '
        'daCustByLID
        '
        Me.daCustByLID.SelectCommand = Me.SqlSelectCommand3
        Me.daCustByLID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD")})})
        '
        'btnSaveNote
        '
        Me.btnSaveNote.Location = New System.Drawing.Point(549, 181)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNote.TabIndex = 2
        Me.btnSaveNote.Text = "Save Note"
        Me.btnSaveNote.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(15, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Invoice Notes:"
        '
        'txtInvoiceNote
        '
        Me.txtInvoiceNote.Location = New System.Drawing.Point(157, 184)
        Me.txtInvoiceNote.Multiline = True
        Me.txtInvoiceNote.Name = "txtInvoiceNote"
        Me.txtInvoiceNote.Size = New System.Drawing.Size(386, 44)
        Me.txtInvoiceNote.TabIndex = 1
        '
        'CustDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(639, 623)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtInvoiceNote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveNote)
        Me.Controls.Add(Me.lvJobs)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtPhone2)
        Me.Controls.Add(Me.txtPhone1)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.lblJobTitle)
        Me.Controls.Add(Me._lblLabels_10)
        Me.Controls.Add(Me._lblLabels_12)
        Me.Controls.Add(Me._lblLabels_11)
        Me.Controls.Add(Me._lblLabels_7)
        Me.Controls.Add(Me._lblLabels_6)
        Me.Controls.Add(Me._lblLabels_5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(74, 23)
        Me.Name = "CustDetail"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Customer"
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private oJob As New JobObj
    Friend lCustID As Integer
    Private daCustExt As New dsTKSITableAdapters.tblCustomerExtendedTableAdapter

    Private Sub lvJobs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvJobs.DoubleClick
        Try
            If Me.lvJobs.SelectedItems.Count > 0 Then
                Dim jobid As Long = Me.lvJobs.SelectedItems(0).SubItems(1).Text
                Dim addressid As Long = Me.lvJobs.SelectedItems(0).Text
                If addressid > 0 Then
                    OpenJobScreen(addressid, jobid, False)
                  
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub CustDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.sqlConn.ConnectionString = cnSQL
            With Me.DsTKSI1
                .tAddress.Clear()
                .tJob.Clear()
                .tCustomr.Clear()

                Me.daAddressByNCustID.SelectCommand.Parameters("@NCUSTID").Value = lCustID
                Me.daAddressByNCustID.Fill(.tAddress)

                Me.daJobByNCustID.SelectCommand.Parameters("@NCUSTID").Value = Me.lCustID
                Me.daJobByNCustID.Fill(.tJob)

                Me.daCustByLID.SelectCommand.Parameters("@LID").Value = Me.lCustID
                Me.daCustByLID.Fill(.tCustomr)

                If Me.daCustExt.FillByLID(Me.DsTKSI1.tblCustomerExtended, Me.lCustID) > 0 Then
                    Me.txtInvoiceNote.Text = Me.DsTKSI1.tblCustomerExtended(0).InvoiceNotes
                End If

            End With
            With Me.lvJobs
                Dim drJob As dsTKSI.tJobRow
                Dim drCust As dsTKSI.tCustomrRow

                .Items.Clear()
                .Refresh()

                drCust = Me.DsTKSI1.tCustomr.FindBylID(Me.lCustID)
                If Not drCust Is Nothing Then
                    Me.lblCustName.Text = drCust.sName
                    Me.txtAddress1.Text = drCust.sStreet1
                    Me.txtAddress2.Text = drCust.sStreet2
                    Me.txtCity.Text = drCust.sCity
                    Me.txtState.Text = drCust.sProvState
                    Me.txtZip.Text = drCust.sPostalZip
                    Me.txtPhone1.Text = drCust.sPhone1
                    Me.txtPhone2.Text = drCust.sPhone2
                    Me.txtFax.Text = drCust.sFax

                    Dim i As Long = 0
                    Dim item1 As ListViewItem
                    Dim lastAddress As Long = 0
                    For Each drJob In drCust.GettJobRows
                        If Not drJob.tAddressRow Is Nothing Then
                            If (drJob.nAddressID <> lastAddress) Then
                                'print address first then job indented
                                item1 = Me.lvJobs.Items.Add(drJob.nAddressID)
                                'this is just an address line so put 0 as jobid
                                item1.SubItems.Add("0")
                                item1.SubItems.Add(drJob.tAddressRow.sLocCode & " - " & drJob.tAddressRow.sAddress1)
                                item1.Font = New Font(item1.Font, FontStyle.Bold)
                            Else
                                'just show job as below  
                            End If
                            item1 = Me.lvJobs.Items.Add(drJob.nAddressID)
                            item1.SubItems.Add(drJob.nID)
                            item1.SubItems.Add("       JOB: " & drJob.sJobNo & " - " & drJob.sJobDesc)
                        Else
                            item1 = Me.lvJobs.Items.Add(drJob.nAddressID)
                            item1.SubItems.Add(drJob.nID)
                            item1.SubItems.Add("NO ADDRESS JOB: " & drJob.sJobNo & " - " & drJob.sJobDesc)

                        End If
                        lastAddress = drJob.nAddressID
                    Next
                End If
                .Refresh()

            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNote.Click
        Try
            If daCustExt.FillByLID(Me.DsTKSI1.tblCustomerExtended, Me.lCustID) > 0 Then
                Me.DsTKSI1.tblCustomerExtended(0).InvoiceNotes = Me.txtInvoiceNote.Text.Trim

            Else
                Dim drCustEx As dsTKSI.tblCustomerExtendedRow
                drCustEx = Me.DsTKSI1.tblCustomerExtended.AddtblCustomerExtendedRow(Me.lCustID, Me.txtInvoiceNote.Text.Trim)

            End If
            daCustExt.Update(Me.DsTKSI1.tblCustomerExtended)
        Catch ex As Exception
            MessageBox.Show("Error saving invoice notes. " & ex.Message)
        End Try

    End Sub
End Class