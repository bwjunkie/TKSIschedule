<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSWOCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvSelectCustomer = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnSaveCustomer = New System.Windows.Forms.Button
        Me.txtNewCustomerInfo = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TCustomrTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Existing Customer"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add New Customer Info (do not select one above)"
        '
        'lvSelectCustomer
        '
        Me.lvSelectCustomer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvSelectCustomer.FullRowSelect = True
        Me.lvSelectCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvSelectCustomer.HideSelection = False
        Me.lvSelectCustomer.Location = New System.Drawing.Point(15, 35)
        Me.lvSelectCustomer.Name = "lvSelectCustomer"
        Me.lvSelectCustomer.Size = New System.Drawing.Size(673, 130)
        Me.lvSelectCustomer.TabIndex = 2
        Me.lvSelectCustomer.UseCompatibleStateImageBehavior = False
        Me.lvSelectCustomer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Customer Name"
        Me.ColumnHeader2.Width = 320
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Customer Address"
        Me.ColumnHeader3.Width = 320
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCustomer.Location = New System.Drawing.Point(539, 320)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(149, 36)
        Me.btnSaveCustomer.TabIndex = 3
        Me.btnSaveCustomer.Text = "OK"
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'txtNewCustomerInfo
        '
        Me.txtNewCustomerInfo.Location = New System.Drawing.Point(15, 210)
        Me.txtNewCustomerInfo.Multiline = True
        Me.txtNewCustomerInfo.Name = "txtNewCustomerInfo"
        Me.txtNewCustomerInfo.Size = New System.Drawing.Size(673, 93)
        Me.txtNewCustomerInfo.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(384, 320)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(149, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TCustomrTableAdapter1
        '
        Me.TCustomrTableAdapter1.ClearBeforeFill = True
        '
        'frmSWOCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 384)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtNewCustomerInfo)
        Me.Controls.Add(Me.btnSaveCustomer)
        Me.Controls.Add(Me.lvSelectCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSWOCustomer"
        Me.Text = "Customer Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvSelectCustomer As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSaveCustomer As System.Windows.Forms.Button
    Friend WithEvents txtNewCustomerInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TCustomrTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tCustomrTableAdapter
End Class
