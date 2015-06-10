Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Friend Class CustSearch
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
    Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtCustSearch As System.Windows.Forms.TextBox
    Public WithEvents lblSearch As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvCustomer As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtCustSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.lvCustomer = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(38, 217)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(117, 30)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(326, 217)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(117, 30)
        Me.cmdOK.TabIndex = 3
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'txtCustSearch
        '
        Me.txtCustSearch.AcceptsReturn = True
        Me.txtCustSearch.BackColor = System.Drawing.Color.White
        Me.txtCustSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCustSearch.Location = New System.Drawing.Point(0, 20)
        Me.txtCustSearch.MaxLength = 0
        Me.txtCustSearch.Name = "txtCustSearch"
        Me.txtCustSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustSearch.Size = New System.Drawing.Size(241, 21)
        Me.txtCustSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSearch.Size = New System.Drawing.Size(478, 41)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Type Search Criteria:"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvCustomer
        '
        Me.lvCustomer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvCustomer.FullRowSelect = True
        Me.lvCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvCustomer.HideSelection = False
        Me.lvCustomer.Location = New System.Drawing.Point(0, 41)
        Me.lvCustomer.MultiSelect = False
        Me.lvCustomer.Name = "lvCustomer"
        Me.lvCustomer.Size = New System.Drawing.Size(478, 166)
        Me.lvCustomer.TabIndex = 5
        Me.lvCustomer.UseCompatibleStateImageBehavior = False
        Me.lvCustomer.View = System.Windows.Forms.View.Details
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
        'CustSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(478, 279)
        Me.Controls.Add(Me.lvCustomer)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtCustSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "CustSearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search for a Customer"
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 

    Private oJob As New JobObj
	Public OK As Boolean
    Public lID As Integer
	
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        'on error Resume Next
        OK = False
        Me.Hide()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        saveSelection()
    End Sub

    Private Sub saveSelection()
        If Me.lvCustomer.SelectedItems.Count > 0 Then
            Dim cust As String = Me.lvCustomer.SelectedItems(0).Text
            If IsNumeric(cust) Then
                Me.lID = CLng(cust)
                OK = True
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub gridLocation_DblClick()
        saveSelection()
    End Sub

    Private Sub txtcustSearch_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCustSearch.TextChanged
        If Len(txtCustSearch.Text.Trim) > 0 Then
            Me.lvCustomer.Items.Clear()
            oJob.SelectCustomerByName(Me.DsTKSI1, txtCustSearch.Text.Trim)
            Dim drCust As dsTKSI.tCustomrRow
            For Each drCust In Me.DsTKSI1.tCustomr
                Dim tempitem As ListViewItem
                tempitem = Me.lvCustomer.Items.Add(drCust.lID)
                tempitem.SubItems.Add(drCust.sName & " - " & drCust.sStreet1)
            Next
        End If
    End Sub

    Private Sub lvCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCustomer.DoubleClick
        saveSelection()
    End Sub
End Class