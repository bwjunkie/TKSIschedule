Imports System.Windows.Forms

Public Class frmTaxTableEdit

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

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butDeleteDistrict As System.Windows.Forms.Button
    Friend WithEvents butAddDistrict As System.Windows.Forms.Button
    Friend WithEvents lvDistrict As System.Windows.Forms.ListView
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.butClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lvDistrict = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.butDeleteDistrict = New System.Windows.Forms.Button
        Me.butAddDistrict = New System.Windows.Forms.Button
        Me.DsTKSI1 = New dsTKSI
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 56)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(592, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tax Table Edit"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.butClose)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 48)
        Me.Panel2.TabIndex = 2
        '
        'butClose
        '
        Me.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butClose.Location = New System.Drawing.Point(240, 8)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(104, 32)
        Me.butClose.TabIndex = 3
        Me.butClose.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(8, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'lvDistrict
        '
        Me.lvDistrict.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvDistrict.FullRowSelect = True
        Me.lvDistrict.HideSelection = False
        Me.lvDistrict.Location = New System.Drawing.Point(8, 64)
        Me.lvDistrict.Name = "lvDistrict"
        Me.lvDistrict.Size = New System.Drawing.Size(336, 144)
        Me.lvDistrict.TabIndex = 4
        Me.lvDistrict.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "District Name"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tax Rate"
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Accnt Code"
        Me.ColumnHeader7.Width = 90
        '
        'butDeleteDistrict
        '
        Me.butDeleteDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butDeleteDistrict.Location = New System.Drawing.Point(352, 96)
        Me.butDeleteDistrict.Name = "butDeleteDistrict"
        Me.butDeleteDistrict.Size = New System.Drawing.Size(80, 24)
        Me.butDeleteDistrict.TabIndex = 7
        Me.butDeleteDistrict.Text = "Del District"
        '
        'butAddDistrict
        '
        Me.butAddDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAddDistrict.Location = New System.Drawing.Point(352, 64)
        Me.butAddDistrict.Name = "butAddDistrict"
        Me.butAddDistrict.Size = New System.Drawing.Size(80, 24)
        Me.butAddDistrict.TabIndex = 8
        Me.butAddDistrict.Text = "Add District"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frmTaxTableEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 278)
        Me.Controls.Add(Me.butAddDistrict)
        Me.Controls.Add(Me.butDeleteDistrict)
        Me.Controls.Add(Me.lvDistrict)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmTaxTableEdit"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private oJob As New JobObj

    Private Sub butAddDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddDistrict.Click
        Dim frm1 As New frmTaxDistrict
        frm1.ShowDialog()
        If frm1.OK Then
            Dim dr As dsTKSI.tblTaxDistrictRow
            dr = Me.DsTKSI1.tblTaxDistrict.NewRow
            dr.AccountingCode = frm1.txtAccountCode.Text
            dr.Note = ""
            If IsNumeric(frm1.txtRate.Text) Then
                dr.TaxRate = frm1.txtRate.Text
            End If
            dr.RateName = frm1.txtDistrictName.Text
            Me.DsTKSI1.tblTaxDistrict.Rows.Add(dr)
            oJob.updateTaxTables(Me.DsTKSI1)
            'Me.daTaxDistrict.Update(Me.DsTKSI1.tblTaxDistrict)
            LoadTaxForm()
        End If
    End Sub

    Private Sub LoadTaxForm()
        If Not oJob.SelectAllTaxInfo(Me.DsTKSI1) Then
            Windows.Forms.MessageBox.Show("Error loading database info.")
            Exit Sub
        Else
            LoadDistrictList()
        End If
    End Sub

    Private Sub LoadDistrictList()
        Me.lvDistrict.Items.Clear()
        Dim itemTemp As ListViewItem
        Dim dr As dsTKSI.tblTaxDistrictRow
        For Each dr In Me.DsTKSI1.tblTaxDistrict.Rows
            itemTemp = Me.lvDistrict.Items.Add(dr.ID)
            With itemTemp
                .SubItems.Add(dr.RateName)
                .SubItems.Add((dr.TaxRate))
                .SubItems.Add(dr.AccountingCode.ToString)
            End With
        Next
    End Sub

    Private Sub butDeleteDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteDistrict.Click
        If Me.lvDistrict.SelectedItems.Count > 0 Then
            If IsNumeric(Me.lvDistrict.SelectedItems(0).Text) Then
                Dim districtID As Long
                districtID = CLng(Me.lvDistrict.SelectedItems(0).Text)
                Dim dr As dsTKSI.tblTaxDistrictRow
                dr = Me.DsTKSI1.tblTaxDistrict.FindByID(districtID)
                If Not dr Is Nothing Then
                    dr.Delete()
                    oJob.updateTaxTables(Me.DsTKSI1)
                    LoadTaxForm()
                End If
            End If
        End If

    End Sub

    'Private Function DistrictIsNotBeingUsed(ByVal districtID As Long) As String
    '    Dim drDist As dsTKSI.tblTaxDistrictRow
    '    drDist = Me.DsTKSI1.tblTaxDistrict.FindByID(districtID)
    '    If (drDist Is Nothing) Then
    '        Return "ERROR could not find selected district"
    '    Else
    '        If drDist.GettblTaxJOINRows.Length > 0 Then
    '            Try
    '                Return drDist.GettblTaxJOINRows(0).tblTaxRegionRow.TaxRegionName
    '            Catch ex As Exception
    '                Return "ERROR missing region records."
    '            End Try
    '        End If
    '    End If
    '    Return ""
    'End Function

    Private Sub frmTaxTableEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTaxForm()
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim regionID As String
        Dim districtID As New ArrayList 'of string
        'Dim itemTemp As ListViewItem

        Me.btnSave.Enabled = False

    End Sub

    Private Sub ClearCheckBoxesOnDistrict()
        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvDistrict.Items
            itemtemp.Checked = False
        Next
    End Sub

    Private Sub CheckDistrictItem(ByVal DistrictID As Long)
        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvDistrict.Items
            If itemtemp.Text = DistrictID.ToString Then
                itemtemp.Checked = True
            End If
        Next
    End Sub
End Class
