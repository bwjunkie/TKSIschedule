Public Class frmCashReceiptDateCriteria
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents butGenerateReport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.butGenerateReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(96, 74)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(221, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'butGenerateReport
        '
        Me.butGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butGenerateReport.Location = New System.Drawing.Point(163, 120)
        Me.butGenerateReport.Name = "butGenerateReport"
        Me.butGenerateReport.Size = New System.Drawing.Size(154, 28)
        Me.butGenerateReport.TabIndex = 2
        Me.butGenerateReport.Text = "Generate Report"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Date:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Date:"
        '
        'frmCashReceiptDateCriteria
        '
        Me.AcceptButton = Me.butGenerateReport
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(347, 175)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butGenerateReport)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmCashReceiptDateCriteria"
        Me.Text = "Cash Receipts Report"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub butGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGenerateReport.Click
        Dim frm1 As New frmCashReceipts
        frm1.dateStart = Me.DateTimePicker1.Value.Date
        frm1.dateEnd = Me.DateTimePicker2.Value.Date.AddHours(23)
        frm1.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub frmDateCriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim startDefault As Date
        startDefault = Now.AddMonths(-1)
        With startDefault
            Me.DateTimePicker1.Value = .Month.ToString & "/1/" & .Year.ToString
            Me.DateTimePicker2.Value = .Month.ToString & "/" & Date.DaysInMonth(.Year, .Month).ToString & "/" & .Year.ToString
        End With

    End Sub
End Class
