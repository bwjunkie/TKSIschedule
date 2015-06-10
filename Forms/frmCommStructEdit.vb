Option Strict Off
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms

Friend Class frmCommStructEdit
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
    Public WithEvents cmdUseDefault As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents lvComm As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TblCommissionStructureTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblCommissionStructureTableAdapter
    Friend WithEvents TksijobsDataSet1 As TKSISchedule.TKSIJOBSDataSet
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdUseDefault = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvComm = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TblCommissionStructureTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblCommissionStructureTableAdapter()
        Me.TksijobsDataSet1 = New TKSISchedule.TKSIJOBSDataSet()
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUseDefault
        '
        Me.cmdUseDefault.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUseDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUseDefault.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUseDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUseDefault.Location = New System.Drawing.Point(48, 256)
        Me.cmdUseDefault.Name = "cmdUseDefault"
        Me.cmdUseDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUseDefault.Size = New System.Drawing.Size(121, 25)
        Me.cmdUseDefault.TabIndex = 3
        Me.cmdUseDefault.Text = "Reset to Default"
        Me.cmdUseDefault.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(216, 256)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(145, 25)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "Use Selected Commission"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(394, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a structure:  (do not use a special structure just for split sales)"
        '
        'lvComm
        '
        Me.lvComm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvComm.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvComm.FullRowSelect = True
        Me.lvComm.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvComm.HideSelection = False
        Me.lvComm.Location = New System.Drawing.Point(0, 25)
        Me.lvComm.Name = "lvComm"
        Me.lvComm.Size = New System.Drawing.Size(394, 207)
        Me.lvComm.TabIndex = 6
        Me.lvComm.UseCompatibleStateImageBehavior = False
        Me.lvComm.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 389
        '
        'TblCommissionStructureTableAdapter1
        '
        Me.TblCommissionStructureTableAdapter1.ClearBeforeFill = True
        '
        'TksijobsDataSet1
        '
        Me.TksijobsDataSet1.DataSetName = "TKSIJOBSDataSet"
        Me.TksijobsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCommStructEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(394, 301)
        Me.Controls.Add(Me.lvComm)
        Me.Controls.Add(Me.cmdUseDefault)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmCommStructEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Commission Structure"
        CType(Me.TksijobsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Public OK As Boolean
    Public g_lngCommSelected As Integer
    Private oJob As New JobObj

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        If Me.lvComm.SelectedItems.Count > 0 Then
            Me.g_lngCommSelected = Me.lvComm.SelectedItems(0).Text
            OK = True
            Me.Hide()
        End If
    End Sub

    Private Sub cmdUseDefault_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUseDefault.Click
        Me.g_lngCommSelected = 1
        OK = True
        Me.Hide()
    End Sub

    Private Sub frmCommStructEdit_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        LoadStructures()
        PopulateForm()
    End Sub

    Private Function LoadStructures() As Boolean
        'oJob.SelectCommissionStruct(Me.DsTKSI1)
        Me.TblCommissionStructureTableAdapter1.Fill(Me.TksijobsDataSet1.tblCommissionStructure)
        Dim drCom As TKSIJOBSDataSet.tblCommissionStructureRow
        For Each drCom In Me.TksijobsDataSet1.tblCommissionStructure
            If drCom.lngPriority = 1 Then
                Return True
            End If
        Next
        'must be a priority 1 structure at least
        MsgBox("Error lowest priority number in Commission table is not 1.")
        Return False
    End Function

    Private Sub PopulateForm()
        Dim strRate As String
        Dim drCom As TKSIJOBSDataSet.tblCommissionStructureRow
        Me.lvComm.Items.Clear()
        For Each drCom In Me.TksijobsDataSet1.tblCommissionStructure
            strRate = "Pri:" & drCom.lngPriority & " | " & drCom.dblRate1
            strRate = strRate & " | " & drCom.dblRate2
            strRate = strRate & " | " & drCom.dblRate3
            strRate = strRate & " | " & drCom.dblRate4
            strRate = strRate & " | " & drCom.dblRate5
            strRate = strRate & " | " & drCom.dblRate6
            strRate = strRate & " | " & drCom.dblRate7
            strRate = strRate & " | " & drCom.dblRate8
            strRate = strRate & " | " & drCom.dblRate9
            strRate = strRate & " | " & drCom.dblRate10
            strRate = strRate & " | " & drCom.dblRate11
            strRate = strRate & " | " & drCom.dblRate12
            strRate = strRate & " | " & drCom.dblRate13
            strRate = strRate & " | " & drCom.dblRate14
            strRate = strRate & " | " & drCom.dblRate15
            strRate = strRate & " | " & drCom.dblRate16
            strRate = strRate & " | " & drCom.dblRate17
            strRate = strRate & " | " & drCom.dblRate18
            strRate = strRate & " | " & drCom.dblRate19
            strRate = strRate & " | " & drCom.dblRate20
            strRate = strRate & " | " & drCom.dblJobCostRate

            Dim itemtemp As ListViewItem
            itemtemp = Me.lvComm.Items.Add(drCom.lngID)
            If drCom.lngPriority = 1 Then
                strRate = strRate & "  DEFAULT "
                itemtemp.BackColor = Color.Yellow
            End If

            itemtemp.SubItems.Add(strRate)
        Next
    End Sub
End Class