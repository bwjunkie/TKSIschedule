<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPrev
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.C1PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl ' C1.Win.C1Preview.C1PrintPreviewControl
        'CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.OutlineView
        '
        'Me.C1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.C1PrintPreviewControl1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        'Me.C1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView"
        'Me.C1PrintPreviewControl1.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        'Me.C1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        'Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        'Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        ''
        ''C1PrintPreviewControl1.PreviewTextSearchPanel
        ''
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0
        'Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        ''
        'C1PrintPreviewControl1.ThumbnailView
        '
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.HideSelection = False
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView"
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.OwnerDraw = True
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 567)
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.ThumbnailSize = New System.Drawing.Size(96, 96)
        'Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(922, 640)
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        'frmPrintPrev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 640)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Name = "frmPrintPrev"
        Me.Text = "frmPrintPrev"
        ' CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl ' C1.Win.C1Preview.C1PrintPreviewControl
End Class
