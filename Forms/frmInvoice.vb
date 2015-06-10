Option Strict Off
Option Explicit On
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Linq
Imports System.Data.Linq

Friend Class frmInvoice
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
    Public WithEvents cmdInvoiced As System.Windows.Forms.Button
	Public WithEvents cmdAddBalance As System.Windows.Forms.Button
	Public WithEvents cmdDelComment As System.Windows.Forms.Button
    Public WithEvents gridComments As C1FlexGridClassic
    Public WithEvents cmdAddLine As System.Windows.Forms.Button
    Public WithEvents lblCommentBalance As System.Windows.Forms.Label
    Public WithEvents Picture2 As System.Windows.Forms.Panel
    Public WithEvents cmdDelLine As System.Windows.Forms.Button
    Public WithEvents cmdAddItem As System.Windows.Forms.Button
    Public WithEvents gridInvLines As C1FlexGridClassic
    Public WithEvents lblItemBalance As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents cmdDelInv As System.Windows.Forms.Button
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button
    Public WithEvents gridInv2 As C1FlexGridClassic
    Public WithEvents gridInv1 As C1FlexGridClassic
    Public WithEvents cmdSimply As System.Windows.Forms.Button
    Public WithEvents Picture3 As System.Windows.Forms.Panel
    Public WithEvents cmdChecks As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.cmdInvoiced = New System.Windows.Forms.Button()
        Me.Picture2 = New System.Windows.Forms.Panel()
        Me.cmdChecks = New System.Windows.Forms.Button()
        Me.cmdAddBalance = New System.Windows.Forms.Button()
        Me.cmdDelComment = New System.Windows.Forms.Button()
        Me.gridComments = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.cmdAddLine = New System.Windows.Forms.Button()
        Me.lblCommentBalance = New System.Windows.Forms.Label()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.cmdDelLine = New System.Windows.Forms.Button()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.gridInvLines = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.lblItemBalance = New System.Windows.Forms.Label()
        Me.cmdDelInv = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.gridInv2 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.gridInv1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.Picture3 = New System.Windows.Forms.Panel()
        Me.cmdSimply = New System.Windows.Forms.Button()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.Picture2.SuspendLayout()
        CType(Me.gridComments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture1.SuspendLayout()
        CType(Me.gridInvLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridInv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridInv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture3.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInvoiced
        '
        Me.cmdInvoiced.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInvoiced.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInvoiced.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvoiced.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInvoiced.Location = New System.Drawing.Point(336, 670)
        Me.cmdInvoiced.Name = "cmdInvoiced"
        Me.cmdInvoiced.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInvoiced.Size = New System.Drawing.Size(107, 29)
        Me.cmdInvoiced.TabIndex = 18
        Me.cmdInvoiced.Text = "Mark as Mailed"
        Me.cmdInvoiced.UseVisualStyleBackColor = False
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture2.Controls.Add(Me.cmdChecks)
        Me.Picture2.Controls.Add(Me.cmdAddBalance)
        Me.Picture2.Controls.Add(Me.cmdDelComment)
        Me.Picture2.Controls.Add(Me.gridComments)
        Me.Picture2.Controls.Add(Me.cmdAddLine)
        Me.Picture2.Controls.Add(Me.lblCommentBalance)
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture2.Location = New System.Drawing.Point(10, 325)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(870, 188)
        Me.Picture2.TabIndex = 10
        Me.Picture2.TabStop = True
        '
        'cmdChecks
        '
        Me.cmdChecks.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChecks.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChecks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChecks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChecks.Location = New System.Drawing.Point(479, 159)
        Me.cmdChecks.Name = "cmdChecks"
        Me.cmdChecks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChecks.Size = New System.Drawing.Size(127, 27)
        Me.cmdChecks.TabIndex = 16
        Me.cmdChecks.Text = "Scanned Checks"
        Me.cmdChecks.UseVisualStyleBackColor = False
        '
        'cmdAddBalance
        '
        Me.cmdAddBalance.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddBalance.Location = New System.Drawing.Point(86, 158)
        Me.cmdAddBalance.Name = "cmdAddBalance"
        Me.cmdAddBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddBalance.Size = New System.Drawing.Size(88, 27)
        Me.cmdAddBalance.TabIndex = 15
        Me.cmdAddBalance.Text = "Add Balance"
        Me.cmdAddBalance.UseVisualStyleBackColor = False
        '
        'cmdDelComment
        '
        Me.cmdDelComment.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelComment.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelComment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelComment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelComment.Location = New System.Drawing.Point(0, 158)
        Me.cmdDelComment.Name = "cmdDelComment"
        Me.cmdDelComment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelComment.Size = New System.Drawing.Size(78, 27)
        Me.cmdDelComment.TabIndex = 11
        Me.cmdDelComment.Text = "Delete Line"
        Me.cmdDelComment.UseVisualStyleBackColor = False
        '
        'gridComments
        '
        Me.gridComments.Cols = 6
        Me.gridComments.ColumnInfo = resources.GetString("gridComments.ColumnInfo")
        Me.gridComments.FixedCols = 0
        Me.gridComments.FixedRows = 0
        Me.gridComments.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridComments.Location = New System.Drawing.Point(0, 0)
        Me.gridComments.Name = "gridComments"
        Me.gridComments.NodeClosedPicture = Nothing
        Me.gridComments.NodeOpenPicture = Nothing
        Me.gridComments.OutlineCol = -1
        Me.gridComments.Size = New System.Drawing.Size(858, 159)
        Me.gridComments.StyleInfo = resources.GetString("gridComments.StyleInfo")
        Me.gridComments.TabIndex = 13
        Me.gridComments.TreeColor = System.Drawing.Color.DarkGray
        '
        'cmdAddLine
        '
        Me.cmdAddLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddLine.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddLine.Location = New System.Drawing.Point(182, 158)
        Me.cmdAddLine.Name = "cmdAddLine"
        Me.cmdAddLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddLine.Size = New System.Drawing.Size(107, 27)
        Me.cmdAddLine.TabIndex = 12
        Me.cmdAddLine.Text = "Add Comment"
        Me.cmdAddLine.UseVisualStyleBackColor = False
        '
        'lblCommentBalance
        '
        Me.lblCommentBalance.BackColor = System.Drawing.Color.White
        Me.lblCommentBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCommentBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommentBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCommentBalance.Location = New System.Drawing.Point(617, 158)
        Me.lblCommentBalance.Name = "lblCommentBalance"
        Me.lblCommentBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCommentBalance.Size = New System.Drawing.Size(172, 27)
        Me.lblCommentBalance.TabIndex = 14
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture1.Controls.Add(Me.cmdDelLine)
        Me.Picture1.Controls.Add(Me.cmdAddItem)
        Me.Picture1.Controls.Add(Me.gridInvLines)
        Me.Picture1.Controls.Add(Me.lblItemBalance)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Location = New System.Drawing.Point(10, 522)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(874, 142)
        Me.Picture1.TabIndex = 5
        Me.Picture1.TabStop = True
        '
        'cmdDelLine
        '
        Me.cmdDelLine.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelLine.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelLine.Location = New System.Drawing.Point(0, 115)
        Me.cmdDelLine.Name = "cmdDelLine"
        Me.cmdDelLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelLine.Size = New System.Drawing.Size(78, 27)
        Me.cmdDelLine.TabIndex = 7
        Me.cmdDelLine.Text = "Delete Line"
        Me.cmdDelLine.UseVisualStyleBackColor = False
        '
        'cmdAddItem
        '
        Me.cmdAddItem.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddItem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddItem.Location = New System.Drawing.Point(86, 115)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddItem.Size = New System.Drawing.Size(88, 27)
        Me.cmdAddItem.TabIndex = 6
        Me.cmdAddItem.Text = "Add Line"
        Me.cmdAddItem.UseVisualStyleBackColor = False
        '
        'gridInvLines
        '
        Me.gridInvLines.Cols = 6
        Me.gridInvLines.ColumnInfo = resources.GetString("gridInvLines.ColumnInfo")
        Me.gridInvLines.FixedCols = 0
        Me.gridInvLines.FixedRows = 0
        Me.gridInvLines.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridInvLines.Location = New System.Drawing.Point(0, -1)
        Me.gridInvLines.Name = "gridInvLines"
        Me.gridInvLines.NodeClosedPicture = Nothing
        Me.gridInvLines.NodeOpenPicture = Nothing
        Me.gridInvLines.OutlineCol = -1
        Me.gridInvLines.Size = New System.Drawing.Size(869, 111)
        Me.gridInvLines.StyleInfo = resources.GetString("gridInvLines.StyleInfo")
        Me.gridInvLines.TabIndex = 8
        Me.gridInvLines.TreeColor = System.Drawing.Color.DarkGray
        '
        'lblItemBalance
        '
        Me.lblItemBalance.BackColor = System.Drawing.Color.White
        Me.lblItemBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemBalance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItemBalance.Location = New System.Drawing.Point(643, 114)
        Me.lblItemBalance.Name = "lblItemBalance"
        Me.lblItemBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemBalance.Size = New System.Drawing.Size(145, 21)
        Me.lblItemBalance.TabIndex = 9
        '
        'cmdDelInv
        '
        Me.cmdDelInv.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelInv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelInv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelInv.Location = New System.Drawing.Point(10, 670)
        Me.cmdDelInv.Name = "cmdDelInv"
        Me.cmdDelInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelInv.Size = New System.Drawing.Size(97, 29)
        Me.cmdDelInv.TabIndex = 4
        Me.cmdDelInv.Text = "Delete Invoice"
        Me.cmdDelInv.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(115, 670)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(107, 29)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(230, 670)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(98, 29)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'gridInv2
        '
        Me.gridInv2.Cols = 7
        Me.gridInv2.ColumnInfo = "7,0,0,0,0,100,Columns:0{Width:120;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:40;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:120;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:120;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Wi" & _
    "dth:120;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:120;}" & Global.Microsoft.VisualBasic.ChrW(9) & "6{Width:120;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridInv2.FixedCols = 0
        Me.gridInv2.FixedRows = 0
        Me.gridInv2.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridInv2.Location = New System.Drawing.Point(10, 256)
        Me.gridInv2.Name = "gridInv2"
        Me.gridInv2.NodeClosedPicture = Nothing
        Me.gridInv2.NodeOpenPicture = Nothing
        Me.gridInv2.OutlineCol = -1
        Me.gridInv2.Rows = 11
        Me.gridInv2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.gridInv2.Size = New System.Drawing.Size(870, 64)
        Me.gridInv2.StyleInfo = resources.GetString("gridInv2.StyleInfo")
        Me.gridInv2.TabIndex = 1
        Me.gridInv2.TreeColor = System.Drawing.Color.DarkGray
        '
        'gridInv1
        '
        Me.gridInv1.Cols = 4
        Me.gridInv1.ColumnInfo = "4,0,0,0,0,100,Columns:0{Width:100;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:290;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:100;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:290;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridInv1.FixedCols = 0
        Me.gridInv1.FixedRows = 0
        Me.gridInv1.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridInv1.Location = New System.Drawing.Point(10, 10)
        Me.gridInv1.Name = "gridInv1"
        Me.gridInv1.NodeClosedPicture = Nothing
        Me.gridInv1.NodeOpenPicture = Nothing
        Me.gridInv1.OutlineCol = -1
        Me.gridInv1.Rows = 11
        Me.gridInv1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.gridInv1.Size = New System.Drawing.Size(870, 247)
        Me.gridInv1.StyleInfo = resources.GetString("gridInv1.StyleInfo")
        Me.gridInv1.TabIndex = 0
        Me.gridInv1.TreeColor = System.Drawing.Color.DarkGray
        '
        'Picture3
        '
        Me.Picture3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Picture3.Controls.Add(Me.cmdSimply)
        Me.Picture3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture3.Location = New System.Drawing.Point(637, 667)
        Me.Picture3.Name = "Picture3"
        Me.Picture3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture3.Size = New System.Drawing.Size(184, 40)
        Me.Picture3.TabIndex = 16
        Me.Picture3.TabStop = True
        '
        'cmdSimply
        '
        Me.cmdSimply.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSimply.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSimply.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSimply.Location = New System.Drawing.Point(25, 7)
        Me.cmdSimply.Name = "cmdSimply"
        Me.cmdSimply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSimply.Size = New System.Drawing.Size(126, 29)
        Me.cmdSimply.TabIndex = 17
        Me.cmdSimply.Text = "Send to Sage"
        Me.cmdSimply.UseVisualStyleBackColor = False
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(903, 765)
        Me.Controls.Add(Me.cmdInvoiced)
        Me.Controls.Add(Me.Picture2)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdDelInv)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.gridInv2)
        Me.Controls.Add(Me.gridInv1)
        Me.Controls.Add(Me.Picture3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Name = "frmInvoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.Picture2.ResumeLayout(False)
        CType(Me.gridComments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture1.ResumeLayout(False)
        CType(Me.gridInvLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridInv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridInv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture3.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ' Private mInv As New JobObj
    Private lInvNo As Integer
    Private mvarchanges As Boolean
    Private MarginTop As Integer
    Friend drSO As dsTKSI.tSOHeaderRow
    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Public Sub LoadInvoice(_SOid As Integer)
        Me.DsTKSI1 = New dsTKSI
        Me.DsTKSI1.EnforceConstraints = False
        Dim iresult As Integer = -1

        Dim daInv As New dsTKSITableAdapters.tSOHeaderTableAdapter
        iresult = daInv.FillByNID(Me.DsTKSI1.tSOHeader, _SOid)
        If iresult > 0 Then
            Me.drSO = Me.DsTKSI1.tSOHeader(0)

            Dim daJob As New dsTKSITableAdapters.tJobTableAdapter
            If daJob.FillByNID(Me.DsTKSI1.tJob, Me.drSO.nJobID) Then
                Dim daCust As New dsTKSITableAdapters.tCustomrTableAdapter
                daCust.Fill(Me.DsTKSI1.tCustomr)
                ' Dim daInvLines As New dsTKSITableAdapters.tSOLineTableAdapter
                ' daInvLines.FillByNSOID(Me.DsTKSI1.tSOLine, Me.drSO.nID)
            Else
                MessageBox.Show("error locating job for invoice, found : " & iresult)
            End If
        Else
            MessageBox.Show("error locating SO id : " & _SOid)
        End If

    End Sub

    Private Sub FormatInvoice()
        'on error Resume Next
        'Dim x As Integer
        With gridInv1
            .Redraw = False
            ' overall grid settings
            .GridLines = GridStyleSettings.flexGridNone
            .set_RowHeight(0, 4)
            .MergeCells = MergeSettings.flexMergeFree

            .set_MergeRow(0, True)
            .set_MergeRow(1, True)
            .set_MergeRow(2, True)
            .set_MergeRow(3, True)

            .Rows = 11
            .Select(6, 1, 10, 1)

            .Select(1, 2, 1, 2)
            .Text = "No."

            .Select(2, 2, 2, 2)
            .Text = "Date"
            .Select(3, 2, 3, 2)
            .Text = "Your Order #:"
            .Select(4, 2, 4, 2)
            .Text = "Our Order #:"
            .Select(6, 2, 6, 2)
            .Text = "Shipped To."

            .Select(6, 0, 6, 0)
            .Text = "Sold To"

            .Select(6, 3, 10, 3)
            .Select(1, 3, 4, 3)
           .set_Cell(CellPropertySettings.flexcpBackColor, 0, 0, 10, 3, global_ColorFromHex(&HEE, &HFF, &HEE))
            .Redraw = True
        End With
        With gridInv2
            .Redraw = False
            ' overall grid settingse
            .GridLines = GridStyleSettings.flexGridNone

            .Select(0, 0, 1, 1)

            .Text = "F.O.B."
            .Select(0, 2, 1, 2)
            .Text = "Terms"
            .Select(0, 3, 1, 3)
            .Text = "Date Shipped"
            .Select(0, 4, 1, 4)
            .Text = "Shipped VIA"
            .Select(0, 5, 1, 6)
            .Text = "Salesperson"

            .Select(2, 0, 2, 0)
            .Text = "P.O. No."

            .Select(2, 3, 2, 3)
            .Text = "Description"
     
            .Select(2, 5, 2, 5)
            .Text = "Account"
            '  .CellBorder(System.Convert.ToUInt32(&H0S), 1, 1, 1, 1, 0, 0)
            .Select(2, 6, 2, 6)
            .Text = "Amount"
            '  .CellBorder(System.Convert.ToUInt32(&H0S), 1, 1, 1, 1, 0, 0)
            .set_Cell(CellPropertySettings.flexcpAlignment, 0, 0, 2, 5, AlignmentSettings.flexAlignCenterCenter)
            .set_Cell(CellPropertySettings.flexcpBackColor, 0, 0, 2, 6, global_ColorFromHex(&HEE, &HFF, &HEE))

            Dim csbold As CellStyle = .Styles.Add("bold")
   

            Dim s1 As CellStyle = .GetCellStyle(1, 0)
            Dim b1 As CellBorder = s1.Border

            b1.Style = BorderStyleEnum.Dotted
            b1.Direction = BorderDirEnum.Horizontal

            ' assign bold style to a cell range
            Dim rg As CellRange = .GetCellRange(1, 0, 1, .Cols - 1)
            .SetCellStyle(1, 0, s1)

            rg.Style = .GetCellStyle(1, 0) ' csbold ' = b1 ' .Styles("bold")

            .Redraw = True
        End With
        With gridInvLines
            .Redraw = False
            .GridLines = GridStyleSettings.flexGridFlat
            ' overall grid settings
            .Redraw = True
        End With
        Me.Picture2.BackColor = global_ColorFromHex(&HEE, &HFF, &HEE)
        With gridComments
            .Redraw = False
            .GridLines = GridStyleSettings.flexGridFlat
            ' overall grid settings
            .Redraw = True
        End With
    End Sub

    Dim daSOLineAll As New dsTKSITableAdapters.tSOLineTableAdapter

    Private Sub UpdateSOLine(ByVal ds1 As dsTKSI, ByVal SOid As Integer, ByVal lLinenumber As Integer, Optional ByVal stype As String = "", Optional ByVal sDesc As String = "", Optional ByVal nAccountID As Object = Nothing, Optional ByVal curcost As Object = Nothing)
        Try
            Dim drSOline As dsTKSI.tSOLineRow
            drSOline = ds1.tSOLine.FindBynSOIDnLineNumber(SOid, lLinenumber)
            If Not drSOline Is Nothing Then
                With drSOline
                    .sType = stype
                    .sDesc = sDesc
                    .nAmount = 0
                    If Not curcost Is Nothing Then
                        If IsNumeric(curcost) Then
                            .nAmount = curcost
                        End If
                    End If
                    .nAccountID = nAccountID
                End With
            End If
            Me.daSOLineALL.Update(ds1.tSOLine)
            ds1.tSOLine.AcceptChanges()

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub UpdateFinanceChargeLineToPO(ByVal nJobID As Integer)
        Dim ds As New dsTKSI
        ds.EnforceConstraints = False

        Dim daSOH As New dsTKSITableAdapters.tSOHeaderTableAdapter
        Dim daSOLine As New dsTKSITableAdapters.tSOLineTableAdapter

        Dim daPOH As New dsTKSITableAdapters.tPOHeaderTableAdapter
        Dim daPOLine As New dsTKSITableAdapters.tPOLineTableAdapter

        Dim dblTotalFinanceChargeNeeded As Decimal = 0
        Dim drSOH As dsTKSI.tSOHeaderRow

        If daSOH.FillByNJobID(ds.tSOHeader, nJobID) > 0 Then
            drSOH = ds.tSOHeader(0)
            Dim drSOLine As dsTKSI.tSOLineRow
            If daSOLine.FillByNSOID(ds.tSOLine, drSOH.nID) > 0 Then
                For Each drSOLine In ds.tSOLine
                    Dim sDescCC As String = drSOLine.sDesc.ToUpper.Replace(" ", "")
                    If sDescCC.Contains("VISA") Or sDescCC.Contains("CREDITCARD") Or sDescCC.Contains("DISCOVER") Or sDescCC.Contains("MASTERCARD") Or sDescCC.Contains("AMEX") Then
                        dblTotalFinanceChargeNeeded += drSOLine.nAmount
                    End If
                Next
            End If
        End If


        If daPOH.FillByNJobID(ds.tPOHeader, nJobID) > 0 Then
            Dim drPO As dsTKSI.tPOHeaderRow
            Dim drPOLine As dsTKSI.tPOLineRow
            For Each drPO In ds.tPOHeader
                daPOLine.FillByNPOID(ds.tPOLine, drPO.nID)
                For Each drPOLine In ds.tPOLine
                    If drPOLine.sType.ToUpper.Contains("ITEM") Then
                        Dim sDescCC As String = drPOLine.sDesc.ToUpper.Replace(" ", "")
                        If sDescCC.Contains("FINANCECHARGE") Or drPOLine.nAccountID = 5570 Then
                            drPOLine.Delete()
                        End If
                    Else
                        'comment line dont bother
                    End If
                Next
                daPOLine.Update(ds.tPOLine)
            Next



            If dblTotalFinanceChargeNeeded <> 0 Then
                drPO = ds.tPOHeader(0)  'if needed add fresh finance charge line to PO
                daPOLine.FillByNPOID(ds.tPOLine, drPO.nID)
                AddPOLine(ds, drPO, "Item", "Finance Charge 3%", Math.Abs(dblTotalFinanceChargeNeeded) * 0.03, 5570)
            End If

        End If

    End Sub

    Private Function AddPOLine(ByVal ds1 As dsTKSI, ByVal drPO As dsTKSI.tPOHeaderRow, Optional ByRef stype As String = "", Optional ByRef sDesc As String = "", Optional ByVal nAmount As Decimal = 0, Optional ByVal nAccount As Integer = 0) As dsTKSI.tPOLineRow
        Try
            Dim lastLineNo As Integer
            If drPO.GettPOLineRows.Length > 0 Then
                lastLineNo = drPO.GettPOLineRows(drPO.GettPOLineRows.Length - 1).nLineNumber
            Else
                lastLineNo = 0
            End If

            Dim drLine As dsTKSI.tPOLineRow
            drLine = ds1.tPOLine.NewtPOLineRow
            With drLine
                .nPOID = drPO.nID
                .nLineNumber = lastLineNo + 1
                .sDesc = sDesc
                .sReceived = False
                .sType = stype
                .nAccountID = nAccount
                .nCost = nAmount

            End With
            Dim daPOLineALL As New dsTKSITableAdapters.tPOLineTableAdapter
            ds1.tPOLine.Rows.Add(drLine)
            daPOLineALL.Update(ds1.tPOLine)
            ds1.tPOLine.AcceptChanges()
            Return drLine
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error adding po line. " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub saveinv()
        Try
            Dim x As Integer

            With gridInvLines
                For x = 0 To .Rows - 1

                    If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, x, 0, x, 0)) And IsNumeric(.get_Cell(CellPropertySettings.flexcpText, x, 1, x, 1)) Then
                        UpdateSOLine(Me.DsTKSI1, .get_Cell(CellPropertySettings.flexcpText, x, 0, x, 0), .get_Cell(CellPropertySettings.flexcpText, x, 1, x, 1), .get_Cell(CellPropertySettings.flexcpText, x, 2, x, 2), .get_Cell(CellPropertySettings.flexcpText, x, 3, x, 3), .get_Cell(CellPropertySettings.flexcpText, x, 4, x, 4), .get_Cell(CellPropertySettings.flexcpText, x, 5, x, 5))

                    End If
                Next
            End With
            With gridComments
                For x = 0 To .Rows - 1

                    If IsNumeric(.get_Cell(CellPropertySettings.flexcpText, x, 0, x, 0)) And IsNumeric(.get_Cell(CellPropertySettings.flexcpText, x, 1, x, 1)) Then
                        If .get_Cell(CellPropertySettings.flexcpText, x, 2, x, 2) = "Balance" Then
                            UpdateSOLine(Me.DsTKSI1, .get_Cell(CellPropertySettings.flexcpText, x, 0, x, 0), .get_Cell(CellPropertySettings.flexcpText, x, 1, x, 1), .get_Cell(CellPropertySettings.flexcpText, x, 2, x, 2), .get_Cell(CellPropertySettings.flexcpText, x, 3, x, 3), "0", "0")
                        Else
                            UpdateSOLine(Me.DsTKSI1, .get_Cell(CellPropertySettings.flexcpText, x, 0, x, 0), .get_Cell(CellPropertySettings.flexcpText, x, 1, x, 1), .get_Cell(CellPropertySettings.flexcpText, x, 2, x, 2), .get_Cell(CellPropertySettings.flexcpText, x, 3, x, 3), .get_Cell(CellPropertySettings.flexcpText, x, 4, x, 4), .get_Cell(CellPropertySettings.flexcpText, x, 5, x, 5))
                        End If
                    End If
                Next

                UpdateFinanceChargeLineToPO(drSO.nJobID)

            End With
            With gridInv1
                If Len(.get_Cell(CellPropertySettings.flexcpText, 1, 3, 1, 3)) > 0 Then drSO.sSONum = .get_Cell(CellPropertySettings.flexcpText, 1, 3, 1, 3)
                If IsDate2(.get_Cell(CellPropertySettings.flexcpText, 2, 3, 2, 3)) Then
                    drSO.dinvoice = .get_Cell(CellPropertySettings.flexcpText, 2, 3, 2, 3)
                ElseIf Len(.get_Cell(CellPropertySettings.flexcpText, 2, 3, 2, 3)) = 0 Then
                    drSO.SetdinvoiceNull()
                End If
                If Len(.get_Cell(CellPropertySettings.flexcpText, 3, 3, 3, 3)) > 0 Then
                    drSO.sYourOrder = .get_Cell(CellPropertySettings.flexcpText, 3, 3, 3, 3)
                End If
                If Len(.get_Cell(CellPropertySettings.flexcpText, 4, 3, 4, 3)) > 0 Then
                    drSO.sOurOrder = .get_Cell(CellPropertySettings.flexcpText, 4, 3, 4, 3)
                End If
            End With
            With gridInv2
                drSO.sFOB = .get_Cell(CellPropertySettings.flexcpText, 1, 0, 1, 0)
                drSO.sTerms = .get_Cell(CellPropertySettings.flexcpText, 1, 2, 1, 2)
                If IsDate2(.get_Cell(CellPropertySettings.flexcpText, 1, 3, 1, 3)) Then
                    drSO.dShipped = .get_Cell(CellPropertySettings.flexcpText, 1, 3, 1, 3)
                Else
                    drSO.SetdShippedNull()
                End If
                drSO.sVIA = .get_Cell(CellPropertySettings.flexcpText, 1, 4, 1, 4)
                UpdateSO(Me.DsTKSI1)
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error in SaveSO ... " & ex.Message)
        End Try

    End Sub

    Dim daSOHeaderALL As New dsTKSITableAdapters.tSOHeaderTableAdapter

    Private Function UpdateSO(ByVal ds1 As dsTKSI) As Boolean
        Try
            Me.daSOHeaderALL.Update(ds1.tSOHeader)
            ds1.tSOHeader.AcceptChanges()
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub cmdAddBalance_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddBalance.Click
        saveinv()
        AddSOLine(Me.DsTKSI1, drSO, "Balance", "Balance Due")
        placedata()
        gridInvLines.Select(gridInvLines.Rows - 1, 2)

        Try
            With gridComments
                .Select(gridInvLines.Rows - 1, 2)
                .ScrollPosition = New Point(.ScrollableRectangle.Right, .ScrollableRectangle.Bottom)
            End With
        Catch
        End Try

        '  gridInvLines.EditCell()
    End Sub

    Private Function AddSOLine(ByVal ds1 As dsTKSI, ByVal drSO As dsTKSI.tSOHeaderRow, Optional ByVal stype As String = "Comment", Optional ByVal sDesc As String = "", Optional ByVal Account As Integer = 0, Optional ByVal Amount As Decimal = 0) As dsTKSI.tSOLineRow
        Try
            Dim lastLineNo As Integer
            If drSO.GettSOLineRows.Length > 0 Then
                lastLineNo = drSO.GettSOLineRows(drSO.GettSOLineRows.Length - 1).nLineNumber
            Else
                lastLineNo = 0
            End If

            Dim drLine As dsTKSI.tSOLineRow
            drLine = ds1.tSOLine.NewtSOLineRow
            With drLine
                .nSOID = drSO.nID
                .nLineNumber = lastLineNo + 1
                .sDesc = sDesc
                .sType = stype
                .nAmount = Amount
                .nAccountID = Account
                .bTaxable = False
                .sHidden = False
            End With
            ds1.tSOLine.Rows.Add(drLine)
            Me.daSOLineALL.Update(ds1.tSOLine)
            ds1.tSOLine.AcceptChanges()

            Return drLine
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Function

    Private Sub cmdAddItem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddItem.Click
        saveinv()
        AddSOLine(Me.DsTKSI1, Me.drSO, "Item", "Payment Received", 2060)
        placedata()
        gridInvLines.Select(gridInvLines.Rows - 1, 2)

        Try
            With gridInvLines
                .Select(gridInvLines.Rows - 1, 2)
                .ScrollPosition = New Point(.ScrollableRectangle.Right, .ScrollableRectangle.Bottom)
            End With
        Catch
        End Try

        '  gridInvLines.EditCell()
    End Sub

    Private Sub cmdAddLine_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddLine.Click
        saveinv()
        AddSOLine(Me.DsTKSI1, Me.drSO, "Comment")
        placedata()

        Try
            With gridComments
                .Select(gridInvLines.Rows - 1, 2)
                .ScrollPosition = New Point(.ScrollableRectangle.Right, .ScrollableRectangle.Bottom)

            End With
        Catch 
        End Try

        ' gridInvLines.EditCell()
    End Sub

    Private Function DeleteSO(ByVal ds1 As dsTKSI, ByVal SOID As Integer) As Boolean
        Try
            Dim drSO As dsTKSI.tSOHeaderRow
            Dim drSOLine As dsTKSI.tSOLineRow
            drSO = ds1.tSOHeader.FindBynID(SOID)
            If Not drSO Is Nothing Then
                For Each drSOLine In drSO.GettSOLineRows
                    drSOLine.Delete()
                Next
                drSO.Delete()
            End If
            Me.daSOLineALL.Update(ds1.tSOLine)
            ds1.tSOLine.AcceptChanges()

            Me.daSOHeaderALL.Update(ds1.tSOHeader)
            ds1.tSOHeader.AcceptChanges()
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub cmdDelComment_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelComment.Click
        Dim Invid, lineNo As Integer
        With gridComments
            If .RowSel > -1 Then
                .Select(.RowSel, 0)
                If IsNumeric(.Text) Then
                    Invid = CInt(.Text)
                    .Select(.RowSel, 1)
                    If IsNumeric(.Text) Then
                        lineNo = CInt(.Text)
                        DeleteSOLine(Me.DsTKSI1, Me.drSO.nID, lineNo)
                        placedata()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub cmdDelInv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelInv.Click
        If Windows.Forms.MessageBox.Show("Are you sure you want to delete this entire invoice?", "Delete Entire Invoice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeleteSO(Me.DsTKSI1, Me.drSO.nID) Then
                mvarchanges = False
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub cmdDelLine_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelLine.Click
        Dim Invid, lineNo As Integer
        With gridInvLines
            If .RowSel > -1 Then
                .Select(.RowSel, 0)
                If IsNumeric(.Text) Then
                    Invid = CInt(.Text)
                    .Select(.RowSel, 1)
                    If IsNumeric(.Text) Then
                        lineNo = CInt(.Text)
                        DeleteSOLine(Me.DsTKSI1, Me.drSO.nID, lineNo)
                        placedata()
                    End If
                End If
            End If
        End With

    End Sub

    Private Sub DeleteSOLine(ByVal ds1 As dsTKSI, ByVal SOid As Integer, ByVal lLinenumber As Integer)
        Dim drSOline As dsTKSI.tSOLineRow
        drSOline = ds1.tSOLine.FindBynSOIDnLineNumber(SOid, lLinenumber)
        If Not drSOline Is Nothing Then
            drSOline.Delete()
        End If
        Me.daSOLineALL.Update(ds1.tSOLine)
        ds1.tSOLine.AcceptChanges()
    End Sub

    Private Sub cmdInvoiced_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInvoiced.Click
        Me.drSO.dmailed = Today
        UpdateSO(Me.DsTKSI1)
        MsgBox("Has been marked as Invoiced/Mailed")
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        Dim daCustExt As New dsTKSITableAdapters.tblCustomerExtendedTableAdapter
        Dim blnPrint As Boolean = True
        If daCustExt.FillByLID(Me.DsTKSI1.tblCustomerExtended, Me.drSO.tJobRow.nCustID) > 0 Then
            Dim frm1 As New frmPromtUserYesNo
            With frm1
                .txtInvoiceNote.Text = Me.DsTKSI1.tblCustomerExtended(0).InvoiceNotes
                If .ShowDialog = Windows.Forms.DialogResult.Yes Then
                    blnPrint = True
                Else
                    blnPrint = False
                End If
            End With
        Else
            blnPrint = True
        End If

        If blnPrint Then
            Dim Inv As New frmInvPrint
            Inv.Header = aryHeader()
            Inv.alLines = alLines()
            Inv.Show()
            'Inv.gridInv.PrintGrid("", True, 1, 1, 1) ' 1, 1, 10, MarginTop)
            'Inv.Hide()
        End If
    End Sub

    Private Function aryHeader() As Object
        'on error Resume Next
        'load text out of grid into array
        Dim temp(20) As String
        With gridInv1
            temp(0) = .get_TextMatrix(1, 3) '.TextMatrix(6, 1)
            temp(1) = .get_TextMatrix(2, 3) '.TextMatrix(7, 1)
            temp(2) = .get_TextMatrix(3, 3)
            temp(3) = .get_TextMatrix(4, 3)
            temp(4) = .get_TextMatrix(6, 1)
            temp(5) = .get_TextMatrix(6, 3)
            temp(6) = .get_TextMatrix(7, 1)
            temp(7) = .get_TextMatrix(7, 3)
            temp(8) = .get_TextMatrix(8, 1)
            temp(9) = .get_TextMatrix(8, 3)
            temp(10) = .get_TextMatrix(9, 1)
            temp(11) = .get_TextMatrix(9, 3)

        End With
        With gridInv2
            temp(12) = .get_TextMatrix(1, 0)
            temp(13) = .get_TextMatrix(1, 2)
            temp(14) = .get_TextMatrix(1, 3)
            temp(15) = .get_TextMatrix(1, 4)
            temp(16) = .get_TextMatrix(1, 5)
        End With

        Return temp

    End Function

    Private Function alLines() As ArrayList
        Dim al As New ArrayList
        Dim x As Object
        Dim Lines As Object
        Dim temp(1, 1) As String
        Dim draLine As dsTKSI.tSOLineRow()
        draLine = Me.DsTKSI1.tSOLine.Select("sType='Item' and nSOID=" & Me.drSO.nID)
        'gives and idea of how many rows we should scan down on the grid 
        Lines = draLine.Length
        ReDim temp(Lines, 2)

        Try
            With gridComments
                For x = 0 To .Rows - 1
                    'temp(x, 0) = .get_TextMatrix(x, 3)
                    Dim line1 As New frmInvPrint.InvoiceLine
                    line1.value1 = .get_TextMatrix(x, 3)

                    If CDbl(.get_TextMatrix(x, 5)) = 0 And .get_TextMatrix(x, 2) = "Comment" Then
                    Else
                        'temp(x, 1) = .get_TextMatrix(x, 5) & ""
                        line1.value2 = .get_TextMatrix(x, 5) & ""
                    End If
                    al.Add(line1)
                Next
            End With
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Return temp
        Return al
    End Function

    Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        saveinv()
        placedata()
    
    End Sub

    Private Sub CMDSIMPLY_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimply.Click
        saveinv()
        Me.SendInvoiceToSage()

        Me.Close()
    End Sub

    Private Sub FlagSentToSageWithDate(inv As tSOHeader)
        Try

            Dim invoicedate As Date = Now
            If inv.dShipped IsNot Nothing Then
                invoicedate = inv.dShipped
            Else
                invoicedate = inv.dinvoice
            End If

            Dim frm1 As New frmAskSimplyDate
            frm1.txtDate.Text = invoicedate.ToShortDateString

            frm1.ShowDialog()
            If frm1.OK Then
                If IsDate2(frm1.txtDate.Text) Then
                    drSO.dsimply = CDate(frm1.txtDate.Text)  'just for archive

                    inv.dsimply = CDate(frm1.txtDate.Text)
                    inv.nSimplySequence = 1 'no longer needed in database
                    dc.SubmitChanges()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(" error in FlagSentToSageWithDate : " & ex.Message)
        End Try

    End Sub

    Private Function SendInvoiceToSage() As Boolean
        Dim frmbusy As New frmWorking
        Try
            frmbusy.Text = frmbusy.Text & " Updating Sage, please wait..."

            Dim q = (From row In dc.tSOHeaders Where row.nID = Me.drSO.nID)
            If q.Count > 0 Then
                Dim cust = q.First.tCustomr
                Try
                    Dim Sage1 As New clsSageAccountingTools
                    If Sage1.NewInvoice(q.First) Then
                        Sage1.Dispose()
                        Try
                            frmbusy.Close()
                        Catch
                        End Try
                        FlagSentToSageWithDate(q.First)
                        Return True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Sage message: " & ex.Message)
                End Try

            Else
                MessageBox.Show("invalid invoice, try to re-open")
            End If
        Catch ex As Exception
            MessageBox.Show("general err: " & ex.Message)
        Finally
            frmbusy.Close()
        End Try

    End Function

    Private Function GetNextSOSimplySequence(_dSimply As Date) As Integer
        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Try
            Dim q = (From row In dc.tSOHeaders Where row.dsimply = _dSimply Select row.nSimplySequence).Max
            Return q + 1
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Private Sub frmInvoice_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If Me.DsTKSI1 IsNot Nothing And Me.drSO IsNot Nothing Then

            Dim daSOLine As New dsTKSITableAdapters.tSOLineTableAdapter
            daSOLine.FillByNSOID(Me.DsTKSI1.tSOLine, Me.drSO.nID)

            MarginTop = LoadMarginDataFromTable()
            FormatInvoice()
            placedata()
            mvarchanges = False
            If sUserlevel >= UserRights.Shipping Then
                Me.gridComments.Editable = EditableSettings.flexEDNone
                Me.gridComments.AllowSelection = False
                Me.gridInv1.Editable = EditableSettings.flexEDNone
                Me.gridInv1.AllowSelection = False
                Me.gridInv2.Editable = EditableSettings.flexEDNone
                Me.gridInv2.AllowSelection = False
                Me.gridInvLines.Editable = EditableSettings.flexEDNone
                Me.gridInvLines.AllowSelection = False
                Me.cmdSave.Visible = False
                Me.cmdAddBalance.Visible = False
                Me.cmdAddItem.Visible = False
                Me.cmdSimply.Visible = False
                Me.cmdDelLine.Visible = False
                Me.cmdDelInv.Visible = False
            End If
        Else
            MessageBox.Show("error on Invoice_Load no data to load")
        End If


    End Sub

    Private Function LoadMarginDataFromTable() As Integer
        Try
            Dim dc As linqTKSIDataContext = GetLinqDataContext()

            Dim q = (From row In dc.tUserPrefrences Where row.AttributeName = "InvoiceTopMargin")
            If q.Count > 0 Then
                Return q.First.Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Function

    Private Sub placedata()

        Dim CommentBalance, ItemBalance As Decimal

        With gridInv1
            .Editable = EditableSettings.flexEDKbdMouse
            If Not drSO.tJobRow.tCustomrRow Is Nothing Then
                .set_TextMatrix(6, 1, drSO.tJobRow.tCustomrRow.sName & "")
                .set_TextMatrix(7, 1, drSO.tJobRow.tCustomrRow.sStreet1 & " " & drSO.tJobRow.tCustomrRow.sStreet2)
                .set_TextMatrix(8, 1, drSO.tJobRow.tCustomrRow.sCity & ", " & drSO.tJobRow.tCustomrRow.sProvState & " " & drSO.tJobRow.tCustomrRow.sPostalZip & "")
                .set_TextMatrix(9, 1, "")
            End If

            .set_TextMatrix(1, 3, drSO.sSONum)
            .set_TextMatrix(2, 3, drSO.dinvoice)
            .set_TextMatrix(3, 3, drSO.sYourOrder)
            .set_TextMatrix(4, 3, drSO.sOurOrder)
            .set_TextMatrix(5, 3, "")
            .set_TextMatrix(6, 3, drSO.sShipTo1 & " " & drSO.sShipTo2)
            .set_TextMatrix(7, 3, drSO.sShipToCity & " / " & drSO.sShipToState)
            .set_TextMatrix(8, 3, "Permit: " & drSO.tJobRow.sBuildingPermit)
            .set_TextMatrix(9, 3, "")
            .set_TextMatrix(10, 3, "")

            If Not drSO.IsdsimplyNull Then
                If IsDate2(drSO.dsimply) Then
                    Me.Picture3.BackColor = System.Drawing.Color.Red
                    Me.cmdSimply.Text = "RE-Send to Sage"
                End If
            End If
        End With

        With gridInv2
            .Editable = EditableSettings.flexEDKbdMouse
            .MergeCells = MergeSettings.flexMergeFree
            .set_TextMatrix(1, 0, drSO.sFOB)
            .set_TextMatrix(1, 2, drSO.tJobRow.sTerms)
            If Not drSO.IsdShippedNull Then
                .set_TextMatrix(1, 3, drSO.dShipped)
            End If
            .set_TextMatrix(1, 4, drSO.sVIA)
            .set_TextMatrix(1, 5, drSO.tJobRow.sSalesperson)
            .set_Cell(CellPropertySettings.flexcpAlignment, 0, 0, 2, 5, AlignmentSettings.flexAlignCenterCenter)
        End With

        With gridComments
            .FixedRows = 0
            .Rows = 0
            .Editable = EditableSettings.flexEDKbdMouse
            '.set_ColComboList(2, "Item|Comment|Balance")
        End With
        With gridInvLines
            .FixedRows = 0
            .Rows = 0
            .Editable = EditableSettings.flexEDKbdMouse
            '.set_ColComboList(2, "Item|Comment")

            If Me.drSO.GettSOLineRows.Length > 0 Then
                'mInv.rsInvline.Sort = "stype"
                Dim drLine As dsTKSI.tSOLineRow
                For Each drLine In drSO.GettSOLineRows
                    If UCase(drLine.sType) = "ITEM" Then
                        .AddItem(drLine.nSOID & vbTab & drLine.nLineNumber & vbTab & drLine.sType & vbTab & drLine.sDesc & vbTab & drLine.nAccountID & vbTab & drLine.nAmount)
                        ItemBalance = ItemBalance + drLine.nAmount
                    Else
                        gridComments.AddItem(drLine.nSOID & vbTab & drLine.nLineNumber & vbTab & drLine.sType & vbTab & drLine.sDesc & vbTab & drLine.nAccountID & vbTab & drLine.nAmount)
                        If UCase(drLine.sType) = "COMMENT" Then
                            CommentBalance = CommentBalance + drLine.nAmount
                        End If
                        If UCase(drLine.sType) = "BALANCE" Then
                            gridComments.set_TextMatrix(gridComments.Rows - 1, 5, TwoDecimal(CommentBalance))
                        End If
                    End If
                Next
                lblItemBalance.Text = "Balance= $" & TwoDecimal(ItemBalance)
                lblCommentBalance.Text = "Balance= $" & TwoDecimal(CommentBalance)
            End If
        End With
        If sUserlevel >= UserRights.Shipping Then
            Me.cmdAddBalance.Visible = False
            Me.cmdAddItem.Visible = False
            Me.cmdAddLine.Visible = False
            Me.cmdDelComment.Visible = False
            Me.cmdDelInv.Visible = False
            Me.cmdDelLine.Visible = False
            Me.cmdInvoiced.Visible = False
            Me.cmdPrint.Visible = False
            Me.cmdSave.Visible = False
            Me.cmdSimply.Visible = False
        End If
    End Sub

    Private Sub frmInvoice_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Dim temp As Object
        'on error Resume Next
        If sUserlevel >= UserRights.Shipping Then Exit Sub
        If mvarchanges Then
            temp = MessageBox.Show("Do you want to save changes?", "save?", MessageBoxButtons.YesNo)
            If temp = 6 Then
                saveinv()
            End If
        End If
    End Sub

    Private Sub gridInv1_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridInv1.MouseDown
        'on error Resume Next
        If sUserlevel >= UserRights.Shipping Then Exit Sub
        mvarchanges = True
        If eventArgs.Button = Button.MouseButtons.Right Then
            gridInv1.Select(gridInv1.MouseRow, gridInv1.MouseCol)
            '  gridInv1.EditCell()
        End If
    End Sub

    Private Sub gridInv2_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridInv2.MouseDown

        'on error Resume Next
        If sUserlevel = UserRights.Sales Or sUserlevel = UserRights.Shipping Then Exit Sub
        mvarchanges = True
        If eventArgs.Button = Button.MouseButtons.Right Then
            gridInv2.Select(gridInv2.MouseRow, gridInv2.MouseCol)
            '  gridInv2.EditCell()
        End If
    End Sub

    Private Sub gridInvLines_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As MouseEventArgs) Handles gridInvLines.MouseDown
        'on error Resume Next
        If sUserlevel >= UserRights.Shipping Then Exit Sub
        mvarchanges = True
    End Sub

    Private Sub cmdChecks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChecks.Click
        Try
            Dim frm1 As New frmDisplayScanImages
            frm1.drJob = Me.drSO.tJobRow
            frm1.ShowDialog()
        Catch
        End Try

    End Sub
End Class