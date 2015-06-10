Imports System.Windows.Forms
Imports System.Drawing

Public Class ctrPOHeader
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents cmPOType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblMaterialSale As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMaterialSale As System.Windows.Forms.TextBox
    Friend WithEvents txtFreightSale As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxes As System.Windows.Forms.TextBox
    Friend WithEvents txtFactor As System.Windows.Forms.TextBox
    Friend WithEvents txtItems As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTo5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTo4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtShip5 As System.Windows.Forms.TextBox
    Friend WithEvents txtShip4 As System.Windows.Forms.TextBox
    Friend WithEvents txtShip3 As System.Windows.Forms.TextBox
    Friend WithEvents txtShip2 As System.Windows.Forms.TextBox
    Friend WithEvents txtShip1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lblPO As System.Windows.Forms.Label
    Friend WithEvents txtDateReq As System.Windows.Forms.TextBox
    Friend WithEvents txtConf As System.Windows.Forms.TextBox
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents txtVIA As System.Windows.Forms.TextBox
    Friend WithEvents txtFOB As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPOnum As System.Windows.Forms.TextBox
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents btnEditVendor As System.Windows.Forms.Button
    Friend WithEvents pnlSales1 As System.Windows.Forms.Panel
    Friend WithEvents pnlSaleInfo As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmPOType = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPO = New System.Windows.Forms.Label
        Me.cmbAccount = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.pnlRight = New System.Windows.Forms.Panel
        Me.txtShip5 = New System.Windows.Forms.TextBox
        Me.txtShip4 = New System.Windows.Forms.TextBox
        Me.txtShip3 = New System.Windows.Forms.TextBox
        Me.txtShip2 = New System.Windows.Forms.TextBox
        Me.txtShip1 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.txtDateReq = New System.Windows.Forms.TextBox
        Me.txtConf = New System.Windows.Forms.TextBox
        Me.txtTerms = New System.Windows.Forms.TextBox
        Me.txtVIA = New System.Windows.Forms.TextBox
        Me.txtFOB = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtPOnum = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnlSales1 = New System.Windows.Forms.Panel
        Me.txtTo5 = New System.Windows.Forms.TextBox
        Me.txtTo4 = New System.Windows.Forms.TextBox
        Me.txtTo3 = New System.Windows.Forms.TextBox
        Me.txtTo2 = New System.Windows.Forms.TextBox
        Me.txtTo1 = New System.Windows.Forms.TextBox
        Me.txtMisc = New System.Windows.Forms.TextBox
        Me.txtItems = New System.Windows.Forms.TextBox
        Me.pnlSaleInfo = New System.Windows.Forms.Panel
        Me.txtFactor = New System.Windows.Forms.TextBox
        Me.txtBoxes = New System.Windows.Forms.TextBox
        Me.txtAdd = New System.Windows.Forms.TextBox
        Me.txtFreightSale = New System.Windows.Forms.TextBox
        Me.txtMaterialSale = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnEditVendor = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMaterialSale = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlSales1.SuspendLayout()
        Me.pnlSaleInfo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmPOType
        '
        Me.cmPOType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmPOType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmPOType.Items.AddRange(New Object() {"PO", "Jobcost", "Warranty", "SWO-PO", "SWO-Jobcost", "SWO-Warranty"})
        Me.cmPOType.Location = New System.Drawing.Point(680, 0)
        Me.cmPOType.Name = "cmPOType"
        Me.cmPOType.Size = New System.Drawing.Size(224, 28)
        Me.cmPOType.TabIndex = 0
        Me.cmPOType.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblPO)
        Me.Panel1.Controls.Add(Me.cmbAccount)
        Me.Panel1.Controls.Add(Me.cmPOType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 40)
        Me.Panel1.TabIndex = 1
        '
        'lblPO
        '
        Me.lblPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPO.ForeColor = System.Drawing.Color.Black
        Me.lblPO.Location = New System.Drawing.Point(0, 0)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(208, 32)
        Me.lblPO.TabIndex = 2
        Me.lblPO.Text = "TKSI"
        Me.lblPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccount
        '
        Me.cmbAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccount.Items.AddRange(New Object() {"4010", "4030", "4040", "4020", "0009"})
        Me.cmbAccount.Location = New System.Drawing.Point(424, 0)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.Size = New System.Drawing.Size(248, 28)
        Me.cmbAccount.TabIndex = 1
        Me.cmbAccount.TabStop = False
        Me.cmbAccount.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pnlRight)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.pnlSales1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 248)
        Me.Panel2.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(544, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 248)
        Me.Panel5.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "SHIP TO:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "DATE REQ:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "CONF#"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "TERMS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(0, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 17)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "VIA"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "F.O.B."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 17)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "DATE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 17)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "NO."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.txtShip5)
        Me.pnlRight.Controls.Add(Me.txtShip4)
        Me.pnlRight.Controls.Add(Me.txtShip3)
        Me.pnlRight.Controls.Add(Me.txtShip2)
        Me.pnlRight.Controls.Add(Me.txtShip1)
        Me.pnlRight.Controls.Add(Me.TextBox6)
        Me.pnlRight.Controls.Add(Me.txtDateReq)
        Me.pnlRight.Controls.Add(Me.txtConf)
        Me.pnlRight.Controls.Add(Me.txtTerms)
        Me.pnlRight.Controls.Add(Me.txtVIA)
        Me.pnlRight.Controls.Add(Me.txtFOB)
        Me.pnlRight.Controls.Add(Me.txtDate)
        Me.pnlRight.Controls.Add(Me.txtPOnum)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(664, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.pnlRight.Size = New System.Drawing.Size(240, 248)
        Me.pnlRight.TabIndex = 0
        '
        'txtShip5
        '
        Me.txtShip5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShip5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShip5.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtShip5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShip5.Location = New System.Drawing.Point(8, 204)
        Me.txtShip5.Name = "txtShip5"
        Me.txtShip5.Size = New System.Drawing.Size(224, 17)
        Me.txtShip5.TabIndex = 25
        Me.txtShip5.TabStop = False
        '
        'txtShip4
        '
        Me.txtShip4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShip4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShip4.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtShip4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShip4.Location = New System.Drawing.Point(8, 187)
        Me.txtShip4.Name = "txtShip4"
        Me.txtShip4.Size = New System.Drawing.Size(224, 17)
        Me.txtShip4.TabIndex = 24
        Me.txtShip4.TabStop = False
        '
        'txtShip3
        '
        Me.txtShip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShip3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShip3.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtShip3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShip3.Location = New System.Drawing.Point(8, 170)
        Me.txtShip3.Name = "txtShip3"
        Me.txtShip3.Size = New System.Drawing.Size(224, 17)
        Me.txtShip3.TabIndex = 9
        Me.txtShip3.TabStop = False
        '
        'txtShip2
        '
        Me.txtShip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShip2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShip2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtShip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShip2.Location = New System.Drawing.Point(8, 153)
        Me.txtShip2.Name = "txtShip2"
        Me.txtShip2.Size = New System.Drawing.Size(224, 17)
        Me.txtShip2.TabIndex = 8
        Me.txtShip2.TabStop = False
        '
        'txtShip1
        '
        Me.txtShip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShip1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtShip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShip1.Location = New System.Drawing.Point(8, 136)
        Me.txtShip1.Name = "txtShip1"
        Me.txtShip1.Size = New System.Drawing.Size(224, 17)
        Me.txtShip1.TabIndex = 7
        Me.txtShip1.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(8, 119)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(224, 17)
        Me.TextBox6.TabIndex = 20
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDateReq
        '
        Me.txtDateReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDateReq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateReq.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDateReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateReq.Location = New System.Drawing.Point(8, 102)
        Me.txtDateReq.Name = "txtDateReq"
        Me.txtDateReq.Size = New System.Drawing.Size(224, 17)
        Me.txtDateReq.TabIndex = 6
        Me.txtDateReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConf
        '
        Me.txtConf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConf.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConf.Location = New System.Drawing.Point(8, 85)
        Me.txtConf.Name = "txtConf"
        Me.txtConf.Size = New System.Drawing.Size(224, 17)
        Me.txtConf.TabIndex = 5
        Me.txtConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTerms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTerms.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerms.Location = New System.Drawing.Point(8, 68)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.Size = New System.Drawing.Size(224, 17)
        Me.txtTerms.TabIndex = 4
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVIA
        '
        Me.txtVIA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVIA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVIA.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtVIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVIA.Location = New System.Drawing.Point(8, 51)
        Me.txtVIA.Name = "txtVIA"
        Me.txtVIA.Size = New System.Drawing.Size(224, 17)
        Me.txtVIA.TabIndex = 3
        Me.txtVIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFOB
        '
        Me.txtFOB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFOB.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFOB.Location = New System.Drawing.Point(8, 34)
        Me.txtFOB.Name = "txtFOB"
        Me.txtFOB.Size = New System.Drawing.Size(224, 17)
        Me.txtFOB.TabIndex = 2
        Me.txtFOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(8, 17)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(224, 17)
        Me.txtDate.TabIndex = 1
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPOnum
        '
        Me.txtPOnum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPOnum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPOnum.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPOnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOnum.Location = New System.Drawing.Point(8, 0)
        Me.txtPOnum.Name = "txtPOnum"
        Me.txtPOnum.Size = New System.Drawing.Size(224, 17)
        Me.txtPOnum.TabIndex = 0
        Me.txtPOnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(376, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(528, 248)
        Me.Panel6.TabIndex = 3
        '
        'pnlSales1
        '
        Me.pnlSales1.Controls.Add(Me.txtTo5)
        Me.pnlSales1.Controls.Add(Me.txtTo4)
        Me.pnlSales1.Controls.Add(Me.txtTo3)
        Me.pnlSales1.Controls.Add(Me.txtTo2)
        Me.pnlSales1.Controls.Add(Me.txtTo1)
        Me.pnlSales1.Controls.Add(Me.txtMisc)
        Me.pnlSales1.Controls.Add(Me.txtItems)
        Me.pnlSales1.Controls.Add(Me.pnlSaleInfo)
        Me.pnlSales1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSales1.Location = New System.Drawing.Point(136, 0)
        Me.pnlSales1.Name = "pnlSales1"
        Me.pnlSales1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.pnlSales1.Size = New System.Drawing.Size(240, 248)
        Me.pnlSales1.TabIndex = 2
        '
        'txtTo5
        '
        Me.txtTo5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTo5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo5.Location = New System.Drawing.Point(8, 208)
        Me.txtTo5.Name = "txtTo5"
        Me.txtTo5.Size = New System.Drawing.Size(224, 17)
        Me.txtTo5.TabIndex = 21
        Me.txtTo5.TabStop = False
        '
        'txtTo4
        '
        Me.txtTo4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTo4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo4.Location = New System.Drawing.Point(8, 192)
        Me.txtTo4.Name = "txtTo4"
        Me.txtTo4.Size = New System.Drawing.Size(224, 17)
        Me.txtTo4.TabIndex = 20
        Me.txtTo4.TabStop = False
        '
        'txtTo3
        '
        Me.txtTo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTo3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo3.Location = New System.Drawing.Point(8, 173)
        Me.txtTo3.Name = "txtTo3"
        Me.txtTo3.Size = New System.Drawing.Size(224, 17)
        Me.txtTo3.TabIndex = 19
        Me.txtTo3.TabStop = False
        '
        'txtTo2
        '
        Me.txtTo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo2.Location = New System.Drawing.Point(8, 156)
        Me.txtTo2.Name = "txtTo2"
        Me.txtTo2.Size = New System.Drawing.Size(224, 17)
        Me.txtTo2.TabIndex = 18
        Me.txtTo2.TabStop = False
        '
        'txtTo1
        '
        Me.txtTo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTo1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo1.Location = New System.Drawing.Point(8, 139)
        Me.txtTo1.Name = "txtTo1"
        Me.txtTo1.Size = New System.Drawing.Size(224, 17)
        Me.txtTo1.TabIndex = 17
        Me.txtTo1.TabStop = False
        '
        'txtMisc
        '
        Me.txtMisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMisc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMisc.Location = New System.Drawing.Point(8, 104)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(224, 17)
        Me.txtMisc.TabIndex = 16
        Me.txtMisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItems
        '
        Me.txtItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItems.Location = New System.Drawing.Point(8, 88)
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(224, 17)
        Me.txtItems.TabIndex = 15
        Me.txtItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlSaleInfo
        '
        Me.pnlSaleInfo.Controls.Add(Me.txtFactor)
        Me.pnlSaleInfo.Controls.Add(Me.txtBoxes)
        Me.pnlSaleInfo.Controls.Add(Me.txtAdd)
        Me.pnlSaleInfo.Controls.Add(Me.txtFreightSale)
        Me.pnlSaleInfo.Controls.Add(Me.txtMaterialSale)
        Me.pnlSaleInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSaleInfo.Location = New System.Drawing.Point(8, 0)
        Me.pnlSaleInfo.Name = "pnlSaleInfo"
        Me.pnlSaleInfo.Size = New System.Drawing.Size(224, 88)
        Me.pnlSaleInfo.TabIndex = 1
        Me.pnlSaleInfo.Visible = False
        '
        'txtFactor
        '
        Me.txtFactor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFactor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFactor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactor.Location = New System.Drawing.Point(0, 68)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(224, 17)
        Me.txtFactor.TabIndex = 14
        Me.txtFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxes
        '
        Me.txtBoxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBoxes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxes.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxes.Location = New System.Drawing.Point(0, 51)
        Me.txtBoxes.Name = "txtBoxes"
        Me.txtBoxes.Size = New System.Drawing.Size(224, 17)
        Me.txtBoxes.TabIndex = 13
        Me.txtBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdd
        '
        Me.txtAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(0, 34)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(224, 17)
        Me.txtAdd.TabIndex = 12
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFreightSale
        '
        Me.txtFreightSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFreightSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFreightSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFreightSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFreightSale.Location = New System.Drawing.Point(0, 17)
        Me.txtFreightSale.Name = "txtFreightSale"
        Me.txtFreightSale.Size = New System.Drawing.Size(224, 17)
        Me.txtFreightSale.TabIndex = 11
        Me.txtFreightSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaterialSale
        '
        Me.txtMaterialSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMaterialSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaterialSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMaterialSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialSale.Location = New System.Drawing.Point(0, 0)
        Me.txtMaterialSale.Name = "txtMaterialSale"
        Me.txtMaterialSale.Size = New System.Drawing.Size(224, 17)
        Me.txtMaterialSale.TabIndex = 10
        Me.txtMaterialSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditVendor)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblMaterialSale)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(136, 248)
        Me.Panel3.TabIndex = 0
        '
        'btnEditVendor
        '
        Me.btnEditVendor.BackColor = System.Drawing.Color.White
        Me.btnEditVendor.Location = New System.Drawing.Point(32, 176)
        Me.btnEditVendor.Name = "btnEditVendor"
        Me.btnEditVendor.Size = New System.Drawing.Size(104, 24)
        Me.btnEditVendor.TabIndex = 18
        Me.btnEditVendor.TabStop = False
        Me.btnEditVendor.Text = "Edit Vendor"
        Me.btnEditVendor.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Desc:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Items:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Factor:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Boxes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add: $"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Freight Sale: $"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaterialSale
        '
        Me.lblMaterialSale.BackColor = System.Drawing.Color.Black
        Me.lblMaterialSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaterialSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMaterialSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialSale.ForeColor = System.Drawing.Color.White
        Me.lblMaterialSale.Location = New System.Drawing.Point(0, 0)
        Me.lblMaterialSale.Name = "lblMaterialSale"
        Me.lblMaterialSale.Size = New System.Drawing.Size(136, 17)
        Me.lblMaterialSale.TabIndex = 0
        Me.lblMaterialSale.Text = "Material Sale: $"
        Me.lblMaterialSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctrPOHeader
        '
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctrPOHeader"
        Me.Size = New System.Drawing.Size(904, 288)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.pnlSales1.ResumeLayout(False)
        Me.pnlSales1.PerformLayout()
        Me.pnlSaleInfo.ResumeLayout(False)
        Me.pnlSaleInfo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private drPO As dsTKSI.tPOHeaderRow
    Private ojob As New JobObj

    Public Sub LoadPoHeader(ByVal drPO1 As dsTKSI.tPOHeaderRow)
        Me.drPO = drPO1
        With Me.drPO

            Me.txtPOnum.Text = .sPONum
            Me.txtAdd.Text = TwoDecimal(.nAdd)
            Me.txtBoxes.Text = .nBoxes
            Me.txtFactor.Text = ojob.Factor(drPO)
            Me.txtFreightSale.Text = .nRetailFreight
            Me.txtItems.Text = .sItems
            Me.txtMaterialSale.Text = .nRetailSale
            Me.txtMisc.Text = .sItemDesc
            Me.txtFOB.Text = .sFOB.Trim
            Me.txtTerms.Text = .sTerms
            Me.txtVIA.Text = .sVia
            If Not .IsdRequiredNull Then Me.txtDateReq.Text = .dRequired.ToShortDateString
            If Not .IsdPODateNull Then Me.txtDate.Text = .dPODate.ToShortDateString
            Me.txtConf.Text = .sConf
            Me.cmPOType.Text = .sPOType
            Me.cmbAccount.Text = .nAccount

            Me.txtShip1.Text = .sShipTo2
            Me.txtShip2.Text = .sShipto3
            Me.txtShip3.Text = .sShipTo1

            Me.txtShip4.Text = .sShipToCity
            If .sShiptoCounty.Length > 0 Then Me.txtShip4.Text = Me.txtShip4.Text & ", " & .sShiptoCounty
            Me.txtShip5.Text = .sShipToState
            If .sShipToZip.Length > 0 Then Me.txtShip5.Text = Me.txtShip5.Text & ", " & .sShipToZip
            Me.txtTo1.Text = .tVendorRow.sName
            Me.txtTo2.Text = .tVendorRow.sStreet1
            Me.txtTo3.Text = .tVendorRow.sStreet2
            Me.txtTo4.Text = .tVendorRow.sCity
            If .tVendorRow.sProvState.Length > 0 Then Me.txtTo4.Text = Me.txtTo4.Text & ", " & .tVendorRow.sProvState
            Me.txtTo5.Text = .tVendorRow.sProvState
            If .tVendorRow.sCountry.Length > 0 Then Me.txtTo5.Text = Me.txtTo5.Text & " " & .tVendorRow.sCountry
            'If Not .IsDDELNull Then
            '    Me.btnMarkAsDelivered.Visible = False
            'End If
        End With


    End Sub

    Private Sub DisplayVendor()
        With Me.drPO
            Me.txtTo1.Text = .tVendorRow.sName
            Me.txtTo2.Text = .tVendorRow.sStreet1
            Me.txtTo3.Text = .tVendorRow.sStreet2
            Me.txtTo4.Text = .tVendorRow.sCity & ", " & .tVendorRow.sProvState
            Me.txtTo5.Text = .tVendorRow.sProvState & " " & .tVendorRow.sCountry
        End With

    End Sub

    Public Function SavePOHeader() As dsTKSI.tPOHeaderRow
        Try
            With Me.drPO
                .sPONum = Me.txtPOnum.Text

                Dim iStartDigit As Integer = 7  'starting place for numeric digits after the dash, previously to 2010 it was 7
                'now it will be 8
                If IsNumeric(Mid(.sPONum, 1, 5)) Then
                    iStartDigit = 8
                Else
                    iStartDigit = 7
                End If

                If IsNumeric(Mid(Me.txtPOnum.Text, iStartDigit, 2)) Then
                    .nPOSort = CInt(Mid(Me.txtPOnum.Text, iStartDigit, 2))
                Else
                    If IsNumeric(Mid(Me.txtPOnum.Text, iStartDigit, 1)) Then
                        .nPOSort = CInt(Mid(Me.txtPOnum.Text, iStartDigit, 1))
                    End If
                End If


                Try
                    If IsNumeric(Me.txtAdd.Text.Trim) Then .nAdd = Decimal.Round(CDec(Me.txtAdd.Text.Trim), 2)
                    If IsNumeric(Me.txtBoxes.Text.Trim) Then .nBoxes = Me.txtBoxes.Text.Trim
                    If IsNumeric(Me.txtMaterialSale.Text.Trim) Then .nRetailSale = Me.txtMaterialSale.Text.Trim
                    If IsNumeric(Me.txtFreightSale.Text.Trim) Then .nRetailFreight = Decimal.Round(CDec(Me.txtFreightSale.Text.Trim), 2)
                Catch ex As Exception
                End Try

                .sFOB = Me.txtFOB.Text.Trim
                .sItemDesc = Me.txtMisc.Text.Trim
                .sItems = Me.txtItems.Text.Trim
                .sPOType = Me.cmPOType.Text.Trim
                .sFilter = Me.cmbAccount.Text.Trim
                .sTerms = Me.txtTerms.Text.Trim
                .sVia = Me.txtVIA.Text.Trim
                If IsDate2(Me.txtDateReq.Text.Trim) Then .dRequired = Me.txtDateReq.Text.Trim
                If IsDate2(Me.txtDate.Text.Trim) Then .dPODate = Me.txtDate.Text.Trim
                .sConf = Me.txtConf.Text.Trim

                .sShipTo2 = Me.txtShip1.Text.Trim
                .sShipto3 = Me.txtShip2.Text.Trim
                .sShipTo1 = Me.txtShip3.Text.Trim


                ' Me.txtShip4.Text = .sShipToCity & ", " & .sShiptoCounty
                ' Me.txtShip5.Text = .sShipToState & ", " & .sShipToZip
                '.tVendorRow.sName = Me.txtTo1.Text.Trim
                '.tVendorRow.sStreet1 = Me.txtTo2.Text.Trim
                '.tVendorRow.sStreet2 = Me.txtTo3.Text.Trim
                'Me.txtTo4.Text = .tVendorRow.sCity & ", " & .tVendorRow.sProvState
                'Me.txtTo5.Text = .tVendorRow.sProvState & " " & .tVendorRow.sCountry
                If IsNumeric(Me.cmbAccount.Text) Then .nAccount = Me.cmbAccount.Text
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Save PO error: " & ex.Message)
        End Try

    End Function

    Friend Sub DeleteHeader()
        Me.drPO.Delete()
    End Sub

    Private Sub ctrPOHeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case sUserlevel
            Case Is <= UserRights.AdminAsst
                Me.pnlSaleInfo.Visible = True
                Me.cmbAccount.Visible = True
                Me.cmPOType.Visible = True
        End Select
    End Sub

    Private Sub btnEditVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditVendor.Click
        Try
            Dim frmVend As New VendorSearch
            frmVend.ShowDialog()
            If frmVend.OK Then
                Me.drPO.nVendorID = frmVend.ID
                Me.DisplayVendor()
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccount.SelectedIndexChanged

    End Sub

    Private Sub cmbAccount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAccount.Leave
        If sUserlevel >= UserRights.Sales Then
            MessageBox.Show("Changes will not be saved.")
            Exit Sub
        End If

        Select Case Me.cmbAccount.Text
            Case "4040"  'sale install
                If Windows.Forms.MessageBox.Show("Do you want Installation PO Lines to be added now?", "Auto Lines?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
                    RaiseEvent installLines()
                End If

            Case "4030" 'sale hardware

        End Select

    End Sub

    Friend Event installLines()
    Friend Event HardwareLines()

    Private Sub btnMarkAsDelivered_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.drPO.DDEL = Now
    End Sub
End Class
