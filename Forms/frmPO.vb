Option Strict Off
Option Explicit On 
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1FlexGrid.Classic

Friend Class frmPO
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
    Public WithEvents cmdPrintPO As System.Windows.Forms.Button
    Public WithEvents flexPOHeader As C1FlexGridClassic
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPO))
        Me.cmdPrintPO = New System.Windows.Forms.Button()
        Me.flexPOHeader = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        CType(Me.flexPOHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrintPO
        '
        Me.cmdPrintPO.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintPO.Location = New System.Drawing.Point(11, 641)
        Me.cmdPrintPO.Name = "cmdPrintPO"
        Me.cmdPrintPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintPO.Size = New System.Drawing.Size(170, 31)
        Me.cmdPrintPO.TabIndex = 0
        Me.cmdPrintPO.Text = "Print PO"
        Me.cmdPrintPO.UseVisualStyleBackColor = False
        '
        'flexPOHeader
        '
        Me.flexPOHeader.ColumnInfo = "10,0,0,0,0,105,Columns:"
        Me.flexPOHeader.FixedCols = 0
        Me.flexPOHeader.FixedRows = 0
        Me.flexPOHeader.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.flexPOHeader.Location = New System.Drawing.Point(11, 0)
        Me.flexPOHeader.Name = "flexPOHeader"
        Me.flexPOHeader.NodeClosedPicture = Nothing
        Me.flexPOHeader.NodeOpenPicture = Nothing
        Me.flexPOHeader.OutlineCol = -1
        Me.flexPOHeader.Size = New System.Drawing.Size(998, 633)
        Me.flexPOHeader.StyleInfo = resources.GetString("flexPOHeader.StyleInfo")
        Me.flexPOHeader.TabIndex = 1
        Me.flexPOHeader.TreeColor = System.Drawing.Color.DarkGray
        '
        'frmPO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1021, 744)
        Me.Controls.Add(Me.cmdPrintPO)
        Me.Controls.Add(Me.flexPOHeader)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(16, 96)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPO"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PO"
        CType(Me.flexPOHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
    ' Look and Feel

    Dim mDocTitle As String
    Dim mBackColor As Color
	Dim msStatus As String
    'Dim PO1 As PO

    ' Dim mForeColor As Integer = Color.White
	Const mFontName As String = "Arial"
    'Const mFontSize As String = "10"
    Dim mCellAlignment As AlignmentSettings = AlignmentSettings.flexAlignCenterCenter

    Friend drPO As dsTKSI.tPOHeaderRow
    Private oJob As New JobObj

    'Friend Sub setPO(ByRef vData As PO)
    '	PO1 = vData
    'End Sub

    Friend Property Status() As String
        Get
            Return msStatus
        End Get
        Set(ByVal Value As String)
            msStatus = Value
        End Set
    End Property

    Sub SetHeaderGrid()
        'on error Resume Next
        mDocTitle = "INVOICE"
        mBackColor = Color.Blue ' &H80000 ' Blue
        ' flexPOheader
        Dim x As Integer
        With flexPOHeader

            .Redraw = False

            ' overall grid settings
            .FixedRows = 0
            .FixedCols = 0
            .Rows = 43
            .Cols = 8
            .ScrollBars = ScrollBars.Both
            .GridColor = Color.Transparent ' = .BackColor
            '  .Appearance=
            .BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
            .FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
            .Editable = True
            '.RowHeight(9) = 10
            .SheetBorder = System.Drawing.Color.White
            .BackColorBkg = System.Drawing.Color.White
            .FillStyle = FillStyleSettings.flexFillSingle
            .MergeCells = MergeSettings.flexMergeFree

            ' set columns width
            .set_ColWidth(0, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(1, 1400 / global_OldGridNewGridRation)
            .set_ColWidth(2, 1600 / global_OldGridNewGridRation)
            .set_ColWidth(4, 1000 / global_OldGridNewGridRation)
            .set_ColWidth(5, 1200 / global_OldGridNewGridRation)
            .set_ColWidth(6, 1400 / global_OldGridNewGridRation)
            .set_ColWidth(7, 1600 / global_OldGridNewGridRation)
            .set_RowHeight(0, 500 / global_OldGridNewGridRation)
            .set_RowHeight(26, 440 / global_OldGridNewGridRation)
            ' Place title
            .set_MergeRow(0, True)
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
            .set_MergeRow(12, True)
            .set_MergeRow(13, True)
            .set_MergeRow(14, True)
            .set_MergeRow(15, True)
            .set_MergeRow(16, True)
            .set_MergeRow(17, True)
            .set_MergeRow(18, True)
            .set_MergeRow(19, True)
            .set_MergeRow(20, True)
            .set_MergeRow(21, True)
            .set_MergeRow(22, True)
            .set_MergeRow(23, True)
            .set_MergeRow(24, True)
            .set_MergeRow(25, True)
            .set_MergeRow(26, True)
            .set_MergeRow(27, True)
            .set_MergeRow(28, True)
            .set_MergeRow(29, True)
            .set_MergeRow(30, True)
            .set_MergeRow(31, True)
            .set_MergeRow(32, True)
            .set_MergeRow(33, True)
            .set_MergeRow(34, True)
            .set_MergeRow(35, True)
            .set_MergeRow(36, True)
            .set_MergeRow(37, True)
            .set_MergeRow(38, True)
            .set_MergeRow(39, True)
            .set_MergeRow(40, True)
            .set_MergeRow(41, True)
            .set_MergeRow(42, True)
            '.set_MergeRow(43, True)
            '.set_MergeRow(44, True)
            '.set_MergeRow(45, True)
            '.set_MergeRow(46, True)


            .Select(0, 0, 0, 0)
            .CellFontSize = CSng("16")
            .CellFontBold = True
            .CellFontSize = 16
            .set_Cell(CellPropertySettings.flexcpText, 0, 0, "TKSI")
            '  .CellFont = New Font("Arial Black", 14)
            '.set_Cell(CellPropertySettings.flexcpForeColor, 0, 0, 0, 1, mBackColor)
            ' .set_Cell(CellPropertySettings.flexcpFontSize, 0, 0, 0, 1, CSng(18))
            .Select(0, 6, 0, 7)
            .CellAlignment = AlignmentSettings.flexAlignRightCenter
            .CellFontSize = CSng("16")
            .CellFontBold = True
            .CellFontSize = 16
            '   .set_Cell(CellPropertySettings.flexcpText, 0, 7, "PO")

            ' .set_Cell(CellPropertySettings.flexcpFontSize, 0, 7, 14)
            ' .set_Cell(CellPropertySettings.flexcpForeColor, 0, 7, mBackColor)

            '  .Select(0, 5, 0, 7)
            '  .CellAlignment = AlignmentSettings.flexAlignRightCenter

            .set_Cell(CellPropertySettings.flexcpFontBold, 1, 0, 1, 2, True)
            .CellFontSize = 10
            '.set_Cell(CellPropertySettings.flexcpFontSize, 1, 0, 1, 2, "10")
            .set_Cell(CellPropertySettings.flexcpText, 1, 0, 1, 2, "The Kitchen Showcase, Inc.")
            .set_Cell(CellPropertySettings.flexcpText, 2, 0, 2, 2, "6528 S. Racine. Cir.")
            .set_Cell(CellPropertySettings.flexcpText, 3, 0, 3, 2, "Centennial, CO 80111")
            .set_Cell(CellPropertySettings.flexcpText, 4, 0, 4, 2, "(303) 799-9200")
            .set_Cell(CellPropertySettings.flexcpText, 5, 0, 5, 2, "FAX (303) 799-1234")

            ' invoice No.

            .set_TextMatrix(2, 6, "NO.")
            .set_TextMatrix(3, 6, "DATE")
            .Select(3, 7)
            .Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point) '= VB6.FontChangeSize(.Font, CDec("10"))

            .set_TextMatrix(4, 6, "F.O.B.")
            .set_TextMatrix(5, 6, "VIA")
            .set_TextMatrix(6, 6, "TERMS")
            For x = 2 To 6
                .Select(x, 6)
                .CellBackColor = System.Drawing.Color.White
                .CellForeColor = System.Drawing.Color.Black
                .CellFontName = mFontName
                .CellFontSize = CSng("10")
                'UPGRADE_WARNING: Couldn't resolve default property of object mCellAlignment. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                .CellAlignment = mCellAlignment
                .CellFontBold = True
                ' .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)
            Next x


            ' draw borders
            .Select(2, 7, 6, 7)
            ' .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)

            .set_TextMatrix(8, 0, "TO:")
            .Select(8, 0)
            .CellBackColor = System.Drawing.Color.White
            .CellForeColor = System.Drawing.Color.Black
            .CellFontName = mFontName

            .CellFontSize = CSng("10")
            'UPGRADE_WARNING: Couldn't resolve default property of object mCellAlignment. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .CellAlignment = mCellAlignment
            .CellFontBold = True


            .Select(8, 1, 11, 2)
            .set_TextMatrix(8, 5, "SHIP TO:")
            .Select(8, 5)
            .CellBackColor = System.Drawing.Color.White
            .CellForeColor = System.Drawing.Color.Black
            .CellFontName = mFontName
            .CellFontSize = CSng("10")
            'UPGRADE_WARNING: Couldn't resolve default property of object mCellAlignment. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .CellAlignment = mCellAlignment
            .CellFontBold = True
            .Select(8, 6, 11, 7)
            ' .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)

            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 13, 0, 13, 2, "PLEASE SHIP THE FOLLOWING:")

            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 13, 5, 13, 7, "DATE REQUIRED:")

            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 14, 0, 14, 1, "ITEM")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 14, 2, 14, 6, "DESCRIPTION")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 14, 7, 14, 7, "COST")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpBackColor, 14, 0, 14, 7, global_ColorFromHex(&H88, &H88, &H88))
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpForeColor, 14, 0, 14, 7, Color.White)
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpAlignment, 14, 0, 14, 7, AlignmentSettings.flexAlignCenterCenter)
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpFontBold, 14, 0, 14, 7, True)


            ' apply common formatting
            .Select(15, 0, 42, 1)
            '  .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 0, 1, 0, 0, 0)
            .Select(15, 2, 42, 6)
            '  .CellBorder(System.Convert.ToUInt32(Color.Black), 0, 0, 0, 0, 0, 0)
            .Select(15, 7, 42, 7)
            '  .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 0, 1, 0, 0, 0)
            .Select(42, 0, 42, 3)
            ' .CellBorder(System.Convert.ToUInt32(Color.Black), 1, 1, 1, 1, 0, 0)
            .Select(42, 4, 42, 7)
            '  .CellBorder(System.Convert.ToUInt32(Color.Black), 0, 1, 1, 1, 0, 0)

            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 40, 0, 40, 3, "IMPORTANT - OUR ORDER NUMBER")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpFontName, 40, 0, 40, 0, "arial")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            ' .set_Cell(CellPropertySettings.flexcpFontSize, 44, 0, 44, 0, "8")
            .CellFontSize = 8
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpForeColor, 40, 0, 40, 0, Color.Black)
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpAlignment, 40, 0, 40, 0, AlignmentSettings.flexAlignCenterCenter)

            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 41, 0, 41, 3, "MUST APPEAR ON INVOICES AND PACKAGES.")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            ' .set_Cell(CellPropertySettings.flexcpFontName, 45, 0, 45, 0, "arial")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            ' .set_Cell(CellPropertySettings.flexcpFontSize, 45, 0, 45, 0, "8")
            .CellFont = New Font("Arial", 8)
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpForeColor, 41, 0, 41, 0, Color.Black)
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpAlignment, 41, 0, 41, 0, AlignmentSettings.flexAlignCenterCenter)

            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpText, 42, 0, 42, 3, "ACKNOWLEDGE IF UNABLE TO SHIP ON TIME.")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .CellFont = New Font("Arial", 8)
            '  .set_Cell(CellPropertySettings.flexcpFontName, 46, 0, 46, 0, "arial")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            '  .set_Cell(CellPropertySettings.flexcpFontSize, 46, 0, 46, 0, "8")
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpForeColor, 42, 0, 42, 0, Color.Black)
            'UPGRADE_WARNING: Couldn't resolve default property of object flexPOHeader.Cell(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            .set_Cell(CellPropertySettings.flexcpAlignment, 42, 0, 42, 0, AlignmentSettings.flexAlignCenterCenter)

        End With
        flexPOHeader.Redraw = True
    End Sub

    'Private Function CheckForFinanceCharge() As Boolean
    '    Try
    '        Dim drLine As dsTKSI.tPOLineRow
    '        For Each drLine In drPO.GettPOLineRows
    '            If drLine.sDesc.ToUpper.Contains("FINANCE") Then
    '                If drLine.nAccountID = 4040 Then
    '                    Return True
    '                End If
    '            End If
    '        Next

    '        Return False
    '    Catch
    '    End Try

    'End Function

    Private Sub cmdPrintPO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintPO.Click

        'Try
        '    If CheckForFinanceCharge Then
        '        MessageBox.Show("Cannot print Installer  PO's with a finance charge.")
        '        Exit Sub
        '    End If
        'Catch ex As Exception

        'End Try
        'on error Resume Next
        flexPOHeader.PrintGrid("", True, 1, 40, 60)
    End Sub

    Private Sub frmPO_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetHeaderGrid()
        loaddata()
        mBackColor = Color.Red ' &HC0 ' Red

    End Sub

    Friend Sub loaddata()
        'on error Resume Next
        Dim x As Integer 'counter for loops

        With flexPOHeader

            .Select(0, 7, 0, 7)
            .CellAlignment = AlignmentSettings.flexAlignRightCenter
            .CellFontSize = CSng("16")
            .CellFontBold = True
            .CellFontSize = 16
            .set_Cell(CellPropertySettings.flexcpText, 0, 6, 0, 7, drPO.sPOType & " ") 'PO1.rsPO.Fields("spotype").Value & "")

            .set_TextMatrix(2, 7, drPO.sPONum & " ") 'PO1.rsPO.Fields("sPONum").Value & "")
            If Not drPO.IsdPODateNull Then .set_TextMatrix(3, 7, drPO.dPODate.ToShortDateString & " ") ' PO1.rsPO.Fields("dPOdate").Value)
            .set_TextMatrix(4, 7, drPO.sFOB) ' PO1.rsPO.Fields("sFOB").Value & "")
            .set_TextMatrix(5, 7, drPO.sVia) 'PO1.rsPO.Fields("sVIA").Value & "")
            .set_TextMatrix(6, 7, drPO.sTerms)  'PO1.rsPO.Fields("sterms").Value & "")

            .set_Cell(CellPropertySettings.flexcpText, 8, 6, 8, 7, drPO.sShipTo2 & " ") 'PO1.rsPO.Fields("sshipto2").Value & " ")
            .set_Cell(CellPropertySettings.flexcpText, 9, 6, 9, 7, drPO.sShipto3 & " ") 'PO1.rsPO.Fields("sshipto3").Value & " ")
            .set_Cell(CellPropertySettings.flexcpText, 10, 6, 10, 7, drPO.sShipTo1 & " ") 'PO1.rsPO.Fields("sshipto1").Value & " ")
            .set_Cell(CellPropertySettings.flexcpText, 11, 6, 11, 7, drPO.sShipToCity & " " & drPO.sShipToState & ", " & drPO.sShipToZip)
            .set_Cell(CellPropertySettings.flexcpText, 8, 1, 8, 2, drPO.tVendorRow.sName & " ")  'PO1.rsVendor.Fields("sname").Value & " ")
            .set_Cell(CellPropertySettings.flexcpText, 9, 1, 9, 2, drPO.tVendorRow.sStreet1 & " ")  'PO1.rsVendor.Fields("sstreet1").Value & " ")
            .set_Cell(CellPropertySettings.flexcpText, 10, 1, 10, 2, drPO.tVendorRow.sStreet2 & " ")
            .set_Cell(CellPropertySettings.flexcpText, 11, 1, 11, 2, drPO.tVendorRow.sCity & " " & drPO.tVendorRow.sProvState & ", " & drPO.tVendorRow.sPostalZip)

            .SetCellStyle(1, 6, "borderbottom")

            .SetCellStyle(2, 6, "borderall")
            .SetCellStyle(3, 6, "borderall")
            .SetCellStyle(4, 6, "borderall")
            .SetCellStyle(5, 6, "borderall")
            .SetCellStyle(6, 6, "borderall")

            .SetCellStyle(2, 5, "borderright")
            .SetCellStyle(3, 5, "borderright")
            .SetCellStyle(4, 5, "borderright")
            .SetCellStyle(5, 5, "borderright")
            .SetCellStyle(6, 5, "borderright")

            .SetCellStyle(8, 5, "borderright")
            .SetCellStyle(9, 5, "borderright")
            .SetCellStyle(10, 5, "borderright")
            .SetCellStyle(11, 5, "borderright")

            .SetCellStyle(7, 6, "borderbottom")
            .SetCellStyle(7, 7, "borderbottom")

            .SetCellStyle(8, 6, "borderright")
            .SetCellStyle(9, 6, "borderright")
            .SetCellStyle(10, 6, "borderright")
            .SetCellStyle(11, 6, "borderall")

            '  TO:
            .SetCellStyle(8, 0, "borderright")
            .SetCellStyle(9, 0, "borderright")
            .SetCellStyle(10, 0, "borderright")
            .SetCellStyle(11, 0, "borderright")

            .SetCellStyle(7, 1, "borderbottom")
            .SetCellStyle(7, 2, "borderbottom")

            .SetCellStyle(8, 1, "borderright")
            .SetCellStyle(9, 1, "borderright")
            .SetCellStyle(10, 1, "borderright")

            .SetCellStyle(11, 1, "borderall")


            Dim icount1 As Integer = 0
            For icount1 = 15 To flexPOHeader.Rows - 5

                Me.flexPOHeader.SetCellStyle(icount1, 1, "borderright")
                Me.flexPOHeader.SetCellStyle(icount1, 7, "borderright")
                Me.flexPOHeader.SetCellStyle(icount1, 6, "borderright")
            Next
            Me.flexPOHeader.SetCellStyle(icount1, 1, "borderall")
            Me.flexPOHeader.SetCellStyle(icount1, 7, "borderall")
            Me.flexPOHeader.SetCellStyle(icount1, 6, "borderall")
            Me.flexPOHeader.SetCellStyle(icount1, 0, "borderbottom")
            Me.flexPOHeader.SetCellStyle(icount1, 2, "borderbottom")
            Me.flexPOHeader.SetCellStyle(icount1, 3, "borderbottom")
            Me.flexPOHeader.SetCellStyle(icount1, 4, "borderbottom")
            Me.flexPOHeader.SetCellStyle(icount1, 5, "borderbottom")


            If Not drPO.IsdRequiredNull Then .set_Cell(CellPropertySettings.flexcpText, 13, 5, 13, 7, "DATE REQUIRED: " & drPO.dRequired.ToShortDateString)

        End With

        Dim drLine As dsTKSI.tPOLineRow
        x = 0
        For Each drLine In drPO.GettPOLineRows

            '  flexPOHeader.set_Cell(CellPropertySettings.flexcpText, 16 + x, 2, 16 + x, 6, "") 'PO1.rsPOLine.Fields("sDesc").Value & "")
            flexPOHeader.set_Cell(CellPropertySettings.flexcpText, 16 + x, 2, 16 + x, 6, drLine.sDesc & " ") 'PO1.rsPOLine.Fields("sDesc").Value & "")

            If drLine.nCost > 0 And UCase(drLine.sType) <> "COMMENT" Then
                'flexPOHeader.set_TextMatrix(16 + x, 7, drLine.nCost) 'PO1.rsPOLine.Fields("ncost").Value)
            End If

            Me.flexPOHeader.SetCellStyle(x + 16, 1, "borderright")
            Me.flexPOHeader.SetCellStyle(x + 16, 7, "borderright")
            Me.flexPOHeader.SetCellStyle(x + 16, 6, "borderright")
            Me.flexPOHeader.SetCellStyle(x + 16, 2, "borderright")
            x = x + 1
            'PO1.rsPOLine.MoveNext()
            'Loop
        Next
        'PO1.rsPOLine.MoveFirst()
        'End If
        'End If
        If drPO.nBoxes > 0 Then
            flexPOHeader.set_Cell(CellPropertySettings.flexcpText, 18 + x, 2, 18 + x, 6, "BOXES : " & drPO.nBoxes)
        End If
        '   Me.flexPOHeader.SetCellStyle(x + 18, 2, "borderright")
        flexPOHeader.set_Cell(CellPropertySettings.flexcpText, 20 + x, 2, 20 + x, 6, "TOTAL")
        Me.flexPOHeader.SetCellStyle(x + 20, 2, "borderright")

        'flexPOHeader.set_TextMatrix(20 + x, 2, "TOTAL")
        flexPOHeader.set_TextMatrix(20 + x, 7, Format(oJob.GetPOCost(drPO), "currency"))

    End Sub


End Class