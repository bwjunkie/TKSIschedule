Public Class frmPrintPreview
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
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents butPrint As System.Windows.Forms.Button
    Friend WithEvents butNext As System.Windows.Forms.Button
    Friend WithEvents butPrev As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.butClose = New System.Windows.Forms.Button
        Me.butPrint = New System.Windows.Forms.Button
        Me.butNext = New System.Windows.Forms.Button
        Me.butPrev = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 40)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(704, 334)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.butPrev)
        Me.Panel1.Controls.Add(Me.butNext)
        Me.Panel1.Controls.Add(Me.butPrint)
        Me.Panel1.Controls.Add(Me.butClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 40)
        Me.Panel1.TabIndex = 1
        '
        'butClose
        '
        Me.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butClose.Location = New System.Drawing.Point(184, 8)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(168, 24)
        Me.butClose.TabIndex = 0
        Me.butClose.Text = "&Close"
        '
        'butPrint
        '
        Me.butPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butPrint.Location = New System.Drawing.Point(8, 8)
        Me.butPrint.Name = "butPrint"
        Me.butPrint.Size = New System.Drawing.Size(168, 24)
        Me.butPrint.TabIndex = 1
        Me.butPrint.Text = "&Print"
        '
        'butNext
        '
        Me.butNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butNext.Location = New System.Drawing.Point(584, 8)
        Me.butNext.Name = "butNext"
        Me.butNext.Size = New System.Drawing.Size(80, 24)
        Me.butNext.TabIndex = 2
        Me.butNext.Text = "Next - &>"
        '
        'butPrev
        '
        Me.butPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butPrev.Location = New System.Drawing.Point(496, 8)
        Me.butPrev.Name = "butPrev"
        Me.butPrev.Size = New System.Drawing.Size(80, 24)
        Me.butPrev.TabIndex = 3
        Me.butPrev.Text = "&< - Prev"
        '
        'frmPrintPreview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 374)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrintPreview"
        Me.Text = "Print Preview"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private currentPage As Integer
    Public FinalPageCount As Integer

    Private Sub butNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNext.Click
        currentPage += 1
        If currentPage > Me.FinalPageCount Then currentPage = Me.FinalPageCount + 1
        Me.PrintPreviewControl1.StartPage = currentPage

    End Sub

    Private Sub butPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butPrev.Click
        currentPage -= 1
        If currentPage < 0 Then currentPage = 0
        Me.PrintPreviewControl1.StartPage = currentPage
    End Sub

    Private Sub butPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butPrint.Click
        'Dim prnt As PrintDialog
        'prnt = New PrintDialog
        'prnt.Document = Me.PrintPreviewControl1.Document
        'prnt.ShowDialog()

        ' Me.PrintPreviewControl1.Document.PrinterSettings.PrinterName = prnt.PrinterSettings.PrinterName
        Me.PrintPreviewControl1.Document.Print()
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Hide()
    End Sub
End Class
