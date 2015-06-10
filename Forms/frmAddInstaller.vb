Imports System.Drawing

Public Class frmAddInstaller
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtphone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone3 As System.Windows.Forms.TextBox
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents butColor As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtphone1 = New System.Windows.Forms.TextBox
        Me.txtPhone2 = New System.Windows.Forms.TextBox
        Me.txtPhone3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.butOK = New System.Windows.Forms.Button
        Me.butClose = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.butColor = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(72, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = ""
        '
        'txtphone1
        '
        Me.txtphone1.Location = New System.Drawing.Point(72, 40)
        Me.txtphone1.Name = "txtphone1"
        Me.txtphone1.Size = New System.Drawing.Size(200, 20)
        Me.txtphone1.TabIndex = 1
        Me.txtphone1.Text = ""
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(72, 64)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(200, 20)
        Me.txtPhone2.TabIndex = 2
        Me.txtPhone2.Text = ""
        '
        'txtPhone3
        '
        Me.txtPhone3.Location = New System.Drawing.Point(72, 88)
        Me.txtPhone3.Name = "txtPhone3"
        Me.txtPhone3.Size = New System.Drawing.Size(200, 20)
        Me.txtPhone3.TabIndex = 3
        Me.txtPhone3.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Phone 1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone 2"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone 3"
        '
        'butOK
        '
        Me.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butOK.Location = New System.Drawing.Point(192, 216)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(80, 24)
        Me.butOK.TabIndex = 8
        Me.butOK.Text = "Save"
        '
        'butClose
        '
        Me.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butClose.Location = New System.Drawing.Point(72, 216)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(80, 24)
        Me.butClose.TabIndex = 9
        Me.butClose.Text = "Close"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(72, 136)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(72, 112)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 20)
        Me.txtUsername.TabIndex = 10
        Me.txtUsername.Text = ""
        '
        'butColor
        '
        Me.butColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butColor.Location = New System.Drawing.Point(72, 168)
        Me.butColor.Name = "butColor"
        Me.butColor.Size = New System.Drawing.Size(200, 24)
        Me.butColor.TabIndex = 14
        Me.butColor.Text = "Color"
        '
        'frmAddInstaller
        '
        Me.AcceptButton = Me.butOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 254)
        Me.Controls.Add(Me.butColor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhone3)
        Me.Controls.Add(Me.txtPhone2)
        Me.Controls.Add(Me.txtphone1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmAddInstaller"
        Me.Text = "Add Installer"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public OK As Boolean
    Friend color1 As Long
    Public blnIsEdit As Boolean

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        If Len(Me.txtName.Text) > 0 Then
            Me.OK = True
            Me.Hide()
        Else
            Windows.Forms.MessageBox.Show("Type a new to add an installer.")
        End If
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Hide()
    End Sub

    Private Sub butColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butColor.Click
        Me.ColorDialog1.ShowDialog()
        Try
            Me.color1 = Me.ColorDialog1.Color.ToArgb
            Me.butColor.BackColor = Color.FromArgb(Me.color1)
        Catch ex As Exception

        End Try

    End Sub
End Class
