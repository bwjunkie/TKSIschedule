Public Class frmTaxDistrict


    Inherits System.Windows.Forms.Form
    Public OK As Boolean

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
    Friend WithEvents butGenerateReport As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDistrictName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.butGenerateReport = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDistrictName = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtAccountCode = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'butGenerateReport
        '
        Me.butGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butGenerateReport.Location = New System.Drawing.Point(144, 136)
        Me.butGenerateReport.Name = "butGenerateReport"
        Me.butGenerateReport.Size = New System.Drawing.Size(128, 24)
        Me.butGenerateReport.TabIndex = 2
        Me.butGenerateReport.Text = "Save City / County"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rate"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "District Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Account Code"
        '
        'txtDistrictName
        '
        Me.txtDistrictName.Location = New System.Drawing.Point(88, 24)
        Me.txtDistrictName.Name = "txtDistrictName"
        Me.txtDistrictName.Size = New System.Drawing.Size(184, 20)
        Me.txtDistrictName.TabIndex = 6
        Me.txtDistrictName.Text = ""
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(88, 56)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(184, 20)
        Me.txtRate.TabIndex = 7
        Me.txtRate.Text = ""
        '
        'txtAccountCode
        '
        Me.txtAccountCode.Location = New System.Drawing.Point(88, 88)
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.Size = New System.Drawing.Size(184, 20)
        Me.txtAccountCode.TabIndex = 8
        Me.txtAccountCode.Text = ""
        '
        'frmTaxDistrict
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 173)
        Me.Controls.Add(Me.txtAccountCode)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtDistrictName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butGenerateReport)
        Me.Name = "frmTaxDistrict"
        Me.Text = "New TAX District"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub butGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGenerateReport.Click
        Me.OK = True
        Me.Hide()
    End Sub
End Class
