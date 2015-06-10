Imports System.Windows.Forms
Imports System.Drawing

Public Class ctrPO1Line
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents bntDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.txtAccount = New System.Windows.Forms.TextBox
        Me.bntDelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbType
        '
        Me.cmbType.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Comment", "Item"})
        Me.cmbType.Location = New System.Drawing.Point(36, 3)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(100, 21)
        Me.cmbType.TabIndex = 1
        '
        'txtDesc
        '
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(136, 3)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(638, 17)
        Me.txtDesc.TabIndex = 2
        '
        'txtCost
        '
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCost.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(662, 3)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(112, 17)
        Me.txtCost.TabIndex = 3
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAccount
        '
        Me.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccount.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(774, 3)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(96, 17)
        Me.txtAccount.TabIndex = 4
        Me.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bntDelete
        '
        Me.bntDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bntDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.bntDelete.Location = New System.Drawing.Point(0, 3)
        Me.bntDelete.Name = "bntDelete"
        Me.bntDelete.Size = New System.Drawing.Size(36, 21)
        Me.bntDelete.TabIndex = 5
        Me.bntDelete.TabStop = False
        Me.bntDelete.Text = "DEL"
        Me.bntDelete.UseVisualStyleBackColor = False
        '
        'ctrPO1Line
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.bntDelete)
        Me.Name = "ctrPO1Line"
        Me.Padding = New System.Windows.Forms.Padding(0, 3, 2, 2)
        Me.Size = New System.Drawing.Size(872, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private drPOLine As dsTKSI.tPOLineRow

    Private blnClickDesc As Boolean = False
    Private blnClickAmount As Boolean = False
    Private blnClickAccount As Boolean = False

    Friend Sub Load1Line(ByVal drline As dsTKSI.tPOLineRow)
        drPOLine = drline
        Me.cmbType.Text = drPOLine.sType
        Me.txtDesc.Text = drPOLine.sDesc.Trim
        Me.txtCost.Text = TwoDecimal(drPOLine.nCost)
        Me.txtAccount.Text = drPOLine.nAccountID
    End Sub

    Friend Function Save1Line() As dsTKSI.tPOLineRow
        With drPOLine
            .sType = Me.cmbType.Text.Trim
            .sDesc = Me.txtDesc.Text.Trim
            If IsNumeric(Me.txtCost.Text.Trim) Then
                .nCost = Me.txtCost.Text.Trim
                If CDec(Me.txtCost.Text.Trim) > 0 Then
                    .sType = "Item"
                End If

            Else
                .nCost = 0
            End If
            If IsNumeric(Me.txtAccount.Text.Trim) Then
                .nAccountID = Me.txtAccount.Text.Trim

            Else
                .nAccountID = 0
            End If
        End With
        Return drPOLine
    End Function

    Private Sub ctrPO1Line_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub ctrPO1Line_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.BackColor = Color.White
    End Sub

    Private Sub bntDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntDelete.Click
        DeleteLine()
    End Sub

    Friend Sub DeleteLine()
        Me.drPOLine.Delete()
        Me.Parent.Controls.Remove(Me)
    End Sub

    Private Sub ctrPO1Line_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case sUserlevel
            Case Is >= UserRights.Sales
                Me.txtAccount.Visible = False
                Me.txtCost.Visible = False
                Me.txtDesc.Enabled = False
                Me.cmbType.Enabled = False
                Me.bntDelete.Enabled = False

            Case UserRights.Shipping
                Me.txtAccount.Visible = False
                Me.txtCost.Visible = False
                Me.bntDelete.Enabled = False
                Me.cmbType.Enabled = False
        End Select

    End Sub

    Private Sub txtDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyDown
        If e.KeyValue = Keys.Down Then
            RaiseEvent arrowdown()
        End If
        If e.KeyValue = Keys.Up Then
            RaiseEvent arrowup()
        End If
        If e.KeyValue = Keys.Left Then
            RaiseEvent arrowleft()
        End If
        If e.KeyValue = Keys.Right Then
            RaiseEvent arrowright()
        End If
    End Sub

    Friend Event arrowdown()
    Friend Event arrowup()
    Friend Event arrowleft()
    Friend Event arrowright()

    Private Sub txtDesc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDesc.MouseUp
        If Not Me.blnClickDesc Then
            If e.Button = MouseButtons.Left Then
                Me.txtDesc.SelectAll()
                Me.blnClickDesc = True
            End If
        End If

    End Sub

    Private Sub txtAccount_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAccount.MouseUp
        If Not Me.blnClickAccount Then
            If e.Button = MouseButtons.Left Then
                Me.txtAccount.SelectAll()
            End If
            blnClickAccount = True
        End If
    End Sub

    Private Sub txtCost_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCost.MouseUp
        If Not Me.blnClickAmount Then
            If e.Button = MouseButtons.Left Then
                Me.txtCost.SelectAll()
            End If
            blnClickAmount = True
        End If
    End Sub

    Private Sub txtAccount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccount.Leave
        blnClickAccount = False
    End Sub

    Private Sub txtDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.Leave
        Me.blnClickDesc = False
    End Sub

    Private Sub txtCost_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.Leave
        Me.blnClickAmount = False
    End Sub
End Class
