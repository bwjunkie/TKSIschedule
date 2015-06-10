Imports System.Windows.Forms
Imports System.Drawing

Public Class frmJobTaxEdit
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
    Friend WithEvents lvDistrict As System.Windows.Forms.ListView
    Friend WithEvents txtMiscTax As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSelected As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMiscTaxDollars As System.Windows.Forms.TextBox
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.butCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTotalSelected = New System.Windows.Forms.Label
        Me.lvDistrict = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.txtMiscTax = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMiscTaxDollars = New System.Windows.Forms.TextBox
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
        Me.Panel1.Size = New System.Drawing.Size(360, 56)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assign Job Tax"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.butCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblTotalSelected)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 278)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 80)
        Me.Panel2.TabIndex = 2
        '
        'butCancel
        '
        Me.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butCancel.Location = New System.Drawing.Point(8, 40)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(168, 32)
        Me.butCancel.TabIndex = 9
        Me.butCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(184, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total:"
        '
        'lblTotalSelected
        '
        Me.lblTotalSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSelected.Location = New System.Drawing.Point(272, 8)
        Me.lblTotalSelected.Name = "lblTotalSelected"
        Me.lblTotalSelected.Size = New System.Drawing.Size(72, 24)
        Me.lblTotalSelected.TabIndex = 7
        Me.lblTotalSelected.Text = "Misc Tax"
        '
        'lvDistrict
        '
        Me.lvDistrict.CheckBoxes = True
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
        Me.ColumnHeader4.Width = 20
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
        'txtMiscTax
        '
        Me.txtMiscTax.Location = New System.Drawing.Point(248, 216)
        Me.txtMiscTax.Name = "txtMiscTax"
        Me.txtMiscTax.Size = New System.Drawing.Size(96, 20)
        Me.txtMiscTax.TabIndex = 5
        Me.txtMiscTax.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Misc Tax %"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(96, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Misc Tax $ (under 10cents)"
        Me.Label4.Visible = False
        '
        'txtMiscTaxDollars
        '
        Me.txtMiscTaxDollars.Location = New System.Drawing.Point(248, 240)
        Me.txtMiscTaxDollars.Name = "txtMiscTaxDollars"
        Me.txtMiscTaxDollars.Size = New System.Drawing.Size(96, 20)
        Me.txtMiscTaxDollars.TabIndex = 7
        Me.txtMiscTaxDollars.Text = ""
        Me.txtMiscTaxDollars.Visible = False
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frmJobTaxEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 358)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMiscTaxDollars)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMiscTax)
        Me.Controls.Add(Me.lvDistrict)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmJobTaxEdit"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private TotalSelectedTax As Single
    Friend JobID As Integer
    Private oJob As New JobObj
    Private blnFormLoading As Boolean = False

    Private Sub butAddDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

            LoadTaxForm()
        End If
    End Sub

    Private Sub LoadTaxForm()
        oJob.SelectJobAndTaxInfo(Me.DsTKSI1, JobID)
        LoadDistrictList()
    End Sub

    Private Sub LoadDistrictList()
        blnFormLoading = True
        Dim itemTemp As ListViewItem
        Dim dr As dsTKSI.tblTaxDistrictRow
        For Each dr In Me.DsTKSI1.tblTaxDistrict.Rows
            itemTemp = New ListViewItem
            With itemTemp
                .SubItems.Add(dr.RateName)
                If LoadedJobUsesThisRate(dr.RateName) > 0 Then
                    itemTemp.Checked = True
                    Me.TotalSelectedTax += dr.TaxRate
                End If
                .SubItems.Add(dr.TaxRate)
                .SubItems.Add(dr.AccountingCode.ToString)
            End With
            itemTemp.Text = dr.ID
            Me.lvDistrict.Items.Add(itemTemp)
        Next

        Dim sngMisc As Single
        sngMisc = LoadedJobUsesThisRate("Misc")
        If sngMisc > 0 Then
            Me.txtMiscTax.Text = sngMisc
            Me.TotalSelectedTax += sngMisc
        End If

        Me.lblTotalSelected.Text = Me.TotalSelectedTax
        blnFormLoading = False
    End Sub

    Private Function LoadedJobUsesThisRate(ByVal rateCompare As String) As Single
        Try
            Dim dr As dsTKSI.tblJobTaxRow
            For Each dr In Me.DsTKSI1.tblJobTax
                If dr.TaxName = rateCompare Then
                    Return dr.TaxPercent
                End If
            Next
        Catch ex As Exception
            Return 0
        End Try
        Return 0
    End Function

    Private Sub frmTaxTableEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTaxForm()
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub ComputeTotalSelectedTax()
        Dim itemTemp As ListViewItem
        Dim total As Single
        For Each itemTemp In Me.lvDistrict.CheckedItems
            Try
                total += itemTemp.SubItems(2).Text
            Catch ex As Exception
            End Try
        Next
        If IsNumeric(Me.txtMiscTax.Text) Then
            total += Me.txtMiscTax.Text
        Else

        End If
        total = Decimal.Round(CDec(total), 3)
        TotalSelectedTax = total
        Me.lblTotalSelected.Text = total
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            ComputeTotalSelectedTax()
            Dim dr As dsTKSI.tblJobTaxRow
            Dim itemtemp As ListViewItem

            'delete all tax records for this job and recreate them based on checked items
            For Each dr In Me.DsTKSI1.tblJobTax
                dr.Delete()
            Next

            For Each itemtemp In Me.lvDistrict.CheckedItems
                dr = Me.DsTKSI1.tblJobTax.NewRow
                With dr
                    .nJobID = Me.JobID
                    .TaxCode = itemtemp.SubItems(3).Text
                    .TaxPercent = Decimal.Round(CDec(itemtemp.SubItems(2).Text), 3)
                    .TaxName = itemtemp.SubItems(1).Text
                End With
                Me.DsTKSI1.tblJobTax.Rows.Add(dr)
            Next

            If IsNumeric(Me.txtMiscTax.Text) Then
                Try
                    dr = Me.DsTKSI1.tblJobTax.NewRow
                    With dr
                        .nJobID = Me.JobID
                        .TaxCode = "2630"
                        .TaxPercent = Decimal.Round(CDec(Me.txtMiscTax.Text), 3)
                        .TaxName = "Misc"
                    End With
                    Me.DsTKSI1.tblJobTax.Rows.Add(dr)
                Catch ex As Exception
                End Try
            End If

            If Me.DsTKSI1.tJob.Rows.Count > 0 Then
                Me.DsTKSI1.tJob(0).nTaxRate = Decimal.Round(CDec(Me.TotalSelectedTax), 3)
            End If

            oJob.updateTaxTables(Me.DsTKSI1)

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Me.Close()
        End Try

    End Sub

    Private Sub ClearCheckBoxesOnDistrict()
        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvDistrict.Items
            itemtemp.Checked = False
        Next
    End Sub

    Private Sub lvDistrict_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvDistrict.ItemCheck
        If Not Me.blnFormLoading Then
            Try
                If (e.CurrentValue = CheckState.Checked) And (e.NewValue = CheckState.Unchecked) Then
                    Me.TotalSelectedTax -= Decimal.Round(CDec(CType(sender, ListView).Items(e.Index).SubItems(2).Text), 2)
                End If
                If (e.CurrentValue = CheckState.Unchecked) And (e.NewValue = CheckState.Checked) Then
                    Me.TotalSelectedTax += CSng(CType(sender, ListView).Items(e.Index).SubItems(2).Text)
                End If
                Me.lblTotalSelected.Text = Me.TotalSelectedTax
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtMiscTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiscTax.TextChanged
        If Not Me.blnFormLoading Then
            Me.ComputeTotalSelectedTax()
        End If
    End Sub

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub

    Private Sub txtMiscTaxDollars_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiscTaxDollars.TextChanged
        If Not Me.blnFormLoading Then
            Me.ComputeTotalSelectedTax()
        End If
    End Sub
End Class
