Option Strict Off
Option Explicit On
Imports C1.Win.C1FlexGrid.Classic
Imports System.Windows.Forms
Imports System.Drawing

Friend Class frmInvPrint
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
    Public WithEvents cmdPrintInv As System.Windows.Forms.Button
    Friend WithEvents txtTopmargin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents gridInv As C1FlexGridClassic
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvPrint))
        Me.cmdPrintInv = New System.Windows.Forms.Button()
        Me.gridInv = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.txtTopmargin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.gridInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrintInv
        '
        Me.cmdPrintInv.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintInv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintInv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintInv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintInv.Location = New System.Drawing.Point(8, 504)
        Me.cmdPrintInv.Name = "cmdPrintInv"
        Me.cmdPrintInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintInv.Size = New System.Drawing.Size(121, 25)
        Me.cmdPrintInv.TabIndex = 0
        Me.cmdPrintInv.Text = "Print Invoice"
        Me.cmdPrintInv.UseVisualStyleBackColor = False
        '
        'gridInv
        '
        Me.gridInv.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.gridInv.Cols = 8
        Me.gridInv.ColumnInfo = "8,0,0,0,0,90,Columns:5{Style:""DataType:System.String;TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "6{S" & _
    "tyle:""DataType:System.String;TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "7{Style:""DataType:System.S" & _
    "tring;TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.gridInv.FixedCols = 0
        Me.gridInv.FixedRows = 0
        Me.gridInv.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gridInv.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.gridInv.GridLines = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridNone
        Me.gridInv.GridLinesFixed = C1.Win.C1FlexGrid.Classic.GridStyleSettings.flexGridNone
        Me.gridInv.Location = New System.Drawing.Point(8, 10)
        Me.gridInv.Margin = New System.Windows.Forms.Padding(90, 0, 90, 0)
        Me.gridInv.MergeCells = C1.Win.C1FlexGrid.Classic.MergeSettings.flexMergeFree
        Me.gridInv.Name = "gridInv"
        Me.gridInv.NodeClosedPicture = Nothing
        Me.gridInv.NodeOpenPicture = Nothing
        Me.gridInv.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarNone
        Me.gridInv.OutlineCol = -1
        Me.gridInv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridInv.Size = New System.Drawing.Size(578, 491)
        Me.gridInv.StyleInfo = resources.GetString("gridInv.StyleInfo")
        Me.gridInv.TabIndex = 1
        Me.gridInv.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
        Me.gridInv.TreeColor = System.Drawing.Color.DarkGray
        '
        'txtTopmargin
        '
        Me.txtTopmargin.Location = New System.Drawing.Point(500, 509)
        Me.txtTopmargin.Name = "txtTopmargin"
        Me.txtTopmargin.Size = New System.Drawing.Size(71, 21)
        Me.txtTopmargin.TabIndex = 2
        Me.txtTopmargin.Text = "770"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 511)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Top Margin"
        '
        'frmInvPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(830, 651)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTopmargin)
        Me.Controls.Add(Me.cmdPrintInv)
        Me.Controls.Add(Me.gridInv)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(16, 96)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvPrint"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Invoice"
        CType(Me.gridInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private aryHeader() As String
    'Private aryLines As Object
    'Friend alHeader As ArrayList
    Friend alLines As ArrayList

    Public Class InvoiceLine
        Public value1 As String = ""
        Public value2 As String = ""
    End Class

    Friend WriteOnly Property Header() As Object
        Set(ByVal Value As Object)
            aryHeader = Value
        End Set
    End Property

    'Friend WriteOnly Property Lines() As Object
    '    Set(ByVal Value As Object)
    '        aryLines = Value
    '    End Set
    'End Property

    Private Sub cmdPrintInv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintInv.Click
        gridInv.PrintGrid("", True, 1, 1, 1)
    End Sub

    Private Sub frmInvPrint_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'on error Resume Next
        LoadGrid()
        LoadLines()
    End Sub

    Private Sub LoadGrid()
        With gridInv
            .Redraw = False
            .Cols = 8
            .Rows = 13
            .MergeCells = MergeSettings.flexMergeFree
            .GridLines = GridStyleSettings.flexGridNone
            .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            .set_MergeRow(1, True)
            .set_MergeRow(2, True)
            .set_MergeRow(3, True)
            .set_MergeRow(4, True)
            .set_MergeRow(5, True)
            .set_MergeRow(6, True)
            .set_MergeRow(7, True)
            .set_MergeRow(8, True)
            .set_MergeRow(9, True)
            .set_MergeRow(10, True)
            .set_MergeRow(11, True)



            .set_ColWidth(0, 970 / global_OldGridNewGridRation)  'from 700
            .set_ColWidth(1, 1500 / global_OldGridNewGridRation) 'from 1500
            .set_ColWidth(2, 2200 / global_OldGridNewGridRation)
            .set_ColWidth(3, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(4, 2100 / global_OldGridNewGridRation)
            .set_ColWidth(5, 400 / global_OldGridNewGridRation) 'from 400
            .set_ColWidth(6, 300 / global_OldGridNewGridRation) 'from 300
            .set_ColWidth(7, 2070 / global_OldGridNewGridRation) 'from 2300

            Dim topmargin As Integer = Convert.ToInt32(Me.txtTopmargin.Text) 'default 770?
            .set_RowHeight(0, topmargin / global_OldGridNewGridRation) 'from 240 for print
            .set_RowHeight(1, 420 / global_OldGridNewGridRation)
            .set_RowHeight(2, 420 / global_OldGridNewGridRation)
            .set_RowHeight(3, 420 / global_OldGridNewGridRation)
            .set_RowHeight(4, 420 / global_OldGridNewGridRation)
            .set_RowHeight(5, 550 / global_OldGridNewGridRation)  'from 600
            .set_RowHeight(6, 280 / global_OldGridNewGridRation) ' from 300
            .set_RowHeight(7, 260 / global_OldGridNewGridRation) 'from 300
            .set_RowHeight(8, 300 / global_OldGridNewGridRation)
            .set_RowHeight(9, 300 / global_OldGridNewGridRation)
            .set_RowHeight(10, 100 / global_OldGridNewGridRation)
            .set_RowHeight(11, 500 / global_OldGridNewGridRation)
            .set_RowHeight(12, 700 / global_OldGridNewGridRation)

            'inv no, date, your order no, our order no
            .set_Cell(CellPropertySettings.flexcpText, 1, 6, 1, 7, aryHeader(0) & "")
            .set_Cell(CellPropertySettings.flexcpText, 2, 6, 2, 7, aryHeader(1) & "")
            .set_Cell(CellPropertySettings.flexcpText, 3, 6, 3, 7, aryHeader(2) & "")
            .set_Cell(CellPropertySettings.flexcpText, 4, 6, 4, 7, aryHeader(3) & "")

            'sold to address and shipped to:
            .set_Cell(CellPropertySettings.flexcpText, 6, 1, 6, 2, aryHeader(4) & "")
            .set_Cell(CellPropertySettings.flexcpText, 6, 5, 6, 7, aryHeader(5) & "")
            .set_Cell(CellPropertySettings.flexcpText, 7, 1, 7, 2, aryHeader(6) & "")
            .set_Cell(CellPropertySettings.flexcpText, 7, 5, 7, 7, aryHeader(7) & "")
            .set_Cell(CellPropertySettings.flexcpText, 8, 1, 8, 2, aryHeader(8) & "")
            .set_Cell(CellPropertySettings.flexcpText, 8, 5, 8, 7, aryHeader(9) & "")
            .set_Cell(CellPropertySettings.flexcpText, 9, 1, 9, 2, aryHeader(10) & "")
            .set_Cell(CellPropertySettings.flexcpText, 9, 5, 9, 7, aryHeader(11) & "")

            'fob,terms,date shipped,shipped via,salesperson
            .set_TextMatrix(11, 1, aryHeader(12) & "")
            .set_TextMatrix(11, 2, aryHeader(13) & "")
            .set_TextMatrix(11, 3, aryHeader(14) & "")
            .set_TextMatrix(11, 4, aryHeader(15) & "")
            .set_TextMatrix(11, 5, "")
            .set_Cell(CellPropertySettings.flexcpText, 11, 6, 11, 7, aryHeader(16) & "")
            .Redraw = True
        End With

    End Sub

    Private Sub LoadLines()
        Dim r As Object
        'Dim x As Integer
        With gridInv
            .Redraw = False
            ' .set_ColDataType(7, GetType(String)) 'currency
            Dim line1 As InvoiceLine
            .GridLines = GridStyleSettings.flexGridNone
            .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            Me.BackColor = Color.White
            .BackColor = Color.Transparent
            .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            .SheetBorder = Color.Transparent
            For Each line1 In Me.alLines
                'Next
                'For x = 0 To UBound(aryLines, 1) - 1
                .AddItem("")
                '   .set_ColDataType(7, GetType(String)) ' DataTypeSettings.flexDTCurrency)
                r = .Rows - 1
                .set_Cell(CellPropertySettings.flexcpText, r, 2, r, 4, line1.value1) ' aryLines(x, 0) & "")
                .set_Cell(CellPropertySettings.flexcpText, r, 7, r, 7, Format(line1.value2, "currency"))  'aryLines(x, 1) & "")
                If Mid(.get_Cell(CellPropertySettings.flexcpText, r, 2, r, 4), 1, 7) = "Balance" Or Mid(.get_Cell(CellPropertySettings.flexcpText, r, 2, r, 4), 1, 5) = "Total" Then
                    .set_Cell(CellPropertySettings.flexcpFontBold, r, 2, r, 4, True)
                    .set_Cell(CellPropertySettings.flexcpFontBold, r, 7, r, 7, True)
                End If
                .set_Cell(CellPropertySettings.flexcpAlignment, .Rows - 1, 2, .Rows - 1, 2, AlignmentSettings.flexAlignLeftCenter)
                .set_MergeRow(.Rows - 1, True)

                .set_Cell(CellPropertySettings.flexcpAlignment, .Rows - 1, 7, AlignmentSettings.flexAlignRightCenter)
                '   .set_ColDataType(7, GetType(String))
            Next
            .AddItem("")
            .AddItem("" & vbTab & "" & vbTab & "Thank you very much!" & vbTab & "Thank you very much!" & vbTab & "Thank you very much!")
            .set_MergeRow(.Rows - 1, True)

            '.set_ColDataType(7, GetType(Decimal)) 'DataTypeSettings.flexDTCurrency)
            '.set_ColFormat(7, "C2")

            .Redraw = True
        End With

    End Sub
End Class