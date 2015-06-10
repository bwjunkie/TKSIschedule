Option Strict Off
Option Explicit On
Friend Class frmAddDraw
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
    Public WithEvents txtDraw As System.Windows.Forms.TextBox
	Public WithEvents cmdAddDraw As System.Windows.Forms.Button
	Public WithEvents txtDate As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDraw = New System.Windows.Forms.TextBox
        Me.cmdAddDraw = New System.Windows.Forms.Button
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtDraw
        '
        Me.txtDraw.AcceptsReturn = True
        Me.txtDraw.AutoSize = False
        Me.txtDraw.BackColor = System.Drawing.SystemColors.Window
        Me.txtDraw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDraw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDraw.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDraw.Location = New System.Drawing.Point(16, 48)
        Me.txtDraw.MaxLength = 0
        Me.txtDraw.Name = "txtDraw"
        Me.txtDraw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDraw.Size = New System.Drawing.Size(185, 25)
        Me.txtDraw.TabIndex = 1
        Me.txtDraw.Text = ""
        '
        'cmdAddDraw
        '
        Me.cmdAddDraw.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddDraw.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddDraw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddDraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddDraw.Location = New System.Drawing.Point(16, 88)
        Me.cmdAddDraw.Name = "cmdAddDraw"
        Me.cmdAddDraw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddDraw.Size = New System.Drawing.Size(129, 25)
        Me.cmdAddDraw.TabIndex = 3
        Me.cmdAddDraw.Text = "Add"
        '
        'txtDate
        '
        Me.txtDate.AcceptsReturn = True
        Me.txtDate.AutoSize = False
        Me.txtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate.Location = New System.Drawing.Point(16, 16)
        Me.txtDate.MaxLength = 0
        Me.txtDate.Name = "txtDate"
        Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDate.Size = New System.Drawing.Size(185, 25)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(208, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount of Draw"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date"
        '
        'frmAddDraw
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(312, 134)
        Me.Controls.Add(Me.txtDraw)
        Me.Controls.Add(Me.cmdAddDraw)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmAddDraw"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Add Draw"
        Me.ResumeLayout(False)

    End Sub
#End Region 

    Public OK As Boolean
	Public drawDate As Date
	Public DrawAmount As Decimal
	
	Private Sub cmdAddDraw_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddDraw.Click
		If IsNumeric(Me.txtDraw.Text) Then
            If IsDate2(Me.txtDate.Text) Then
                Me.drawDate = CDate(Me.txtDate.Text)
                Me.DrawAmount = CDec(Me.txtDraw.Text)
                Me.OK = True
                Me.Hide()
            Else
                MsgBox("Enter a valid date for this draw.")
            End If
        Else
			MsgBox("Enter a valid Draw amount.")
		End If
	End Sub
	
	Private Sub frmAddDraw_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.txtDate.Text = CStr(Today)
		Me.txtDraw.Text = CStr(0)
	End Sub
End Class