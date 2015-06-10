Imports System.Windows.Forms
Imports System.Drawing

Public Class frmAddJob
    Inherits System.Windows.Forms.Form

    Public OK As Boolean
    Public installerID As Integer

    Public EditMode As Boolean
    Public EditInstallerID As Long
    Public EditStartdate As Date
    Public EditEndDate As Date
    Public EditCustomer As String
    Public EditAddress As String
    Public EditSales As String
    Public EditJob As String
    Public EditdrJob As dsTKSI.tblInstallerDatesRow

    Private oJob As New JobObj

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvInstaller As System.Windows.Forms.ListView
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents startDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents endDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents butAddInstaller As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butEditInstaller As System.Windows.Forms.Button
    Friend WithEvents butDeleteInstaller As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents txtJobno As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.startDate = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.endDate = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvInstaller = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butOK = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.butAddInstaller = New System.Windows.Forms.Button()
        Me.butEditInstaller = New System.Windows.Forms.Button()
        Me.butDeleteInstaller = New System.Windows.Forms.Button()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJobno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'startDate
        '
        Me.startDate.Location = New System.Drawing.Point(16, 24)
        Me.startDate.MaxSelectionCount = 1
        Me.startDate.Name = "startDate"
        Me.startDate.TabIndex = 0
        Me.startDate.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Job:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End Job:"
        '
        'endDate
        '
        Me.endDate.Location = New System.Drawing.Point(13, 226)
        Me.endDate.MaxSelectionCount = 1
        Me.endDate.Name = "endDate"
        Me.endDate.TabIndex = 1
        Me.endDate.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Installer:"
        '
        'lvInstaller
        '
        Me.lvInstaller.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvInstaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInstaller.FullRowSelect = True
        Me.lvInstaller.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvInstaller.HideSelection = False
        Me.lvInstaller.Location = New System.Drawing.Point(303, 24)
        Me.lvInstaller.MultiSelect = False
        Me.lvInstaller.Name = "lvInstaller"
        Me.lvInstaller.Size = New System.Drawing.Size(216, 397)
        Me.lvInstaller.TabIndex = 2
        Me.lvInstaller.UseCompatibleStateImageBehavior = False
        Me.lvInstaller.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 20
        '
        'butOK
        '
        Me.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butOK.Location = New System.Drawing.Point(244, 565)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(176, 24)
        Me.butOK.TabIndex = 7
        Me.butOK.Text = "Finished"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Job Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(92, 493)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(328, 20)
        Me.txtAddress.TabIndex = 3
        '
        'butAddInstaller
        '
        Me.butAddInstaller.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAddInstaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddInstaller.Location = New System.Drawing.Point(415, 427)
        Me.butAddInstaller.Name = "butAddInstaller"
        Me.butAddInstaller.Size = New System.Drawing.Size(104, 24)
        Me.butAddInstaller.TabIndex = 8
        Me.butAddInstaller.Text = "Add Installer"
        '
        'butEditInstaller
        '
        Me.butEditInstaller.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butEditInstaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEditInstaller.Location = New System.Drawing.Point(303, 427)
        Me.butEditInstaller.Name = "butEditInstaller"
        Me.butEditInstaller.Size = New System.Drawing.Size(104, 24)
        Me.butEditInstaller.TabIndex = 9
        Me.butEditInstaller.Text = "Edit Installer"
        '
        'butDeleteInstaller
        '
        Me.butDeleteInstaller.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butDeleteInstaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteInstaller.Location = New System.Drawing.Point(303, 452)
        Me.butDeleteInstaller.Name = "butDeleteInstaller"
        Me.butDeleteInstaller.Size = New System.Drawing.Size(104, 24)
        Me.butDeleteInstaller.TabIndex = 10
        Me.butDeleteInstaller.Text = "Delete Installer"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(92, 541)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(88, 20)
        Me.txtSales.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 541)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sales:"
        '
        'txtJobno
        '
        Me.txtJobno.Location = New System.Drawing.Point(92, 565)
        Me.txtJobno.Name = "txtJobno"
        Me.txtJobno.Size = New System.Drawing.Size(88, 20)
        Me.txtJobno.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 565)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Job:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(92, 517)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(328, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 517)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Customer:"
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmAddJob
        '
        Me.AcceptButton = Me.butOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(569, 599)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.txtJobno)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.butDeleteInstaller)
        Me.Controls.Add(Me.butEditInstaller)
        Me.Controls.Add(Me.butAddInstaller)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.endDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startDate)
        Me.Controls.Add(Me.lvInstaller)
        Me.Name = "frmAddJob"
        Me.Text = "Add Job For Installer"
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend Sub LoadEditData(ByVal drEdit As dsTKSI.tblInstallerDatesRow)
        'used for edit mode only
        'not new jobs

        Try
            If Me.EditMode Then
                With drEdit
                    Me.txtAddress.Text = .jobaddress
                    Me.txtSales.Text = .sales
                    Me.txtJobno.Text = .sJobNum
                    Me.txtCustomer.Text = .Customer

                    If Not .IsDateStartNull Then Me.startDate.SelectionStart = .DateStart
                    If Not .IsDateEndNull Then Me.endDate.SelectionStart = .DateEnd

                    Dim itemtemp As ListViewItem
                    For Each itemtemp In Me.lvInstaller.Items
                        Try
                            If IsNumeric(itemtemp.Text) Then
                                If CLng(itemtemp.Text) = .InstallerID Then
                                    itemtemp.Selected = True
                                    itemtemp.BackColor = Color.Yellow
                                End If
                            End If

                        Catch ex As Exception
                        End Try
                    Next

                End With
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadInstallerList()
        oJob.SelectInstallersOnly(Me.DsTKSI1)
        Me.lvInstaller.Items.Clear()
        Dim dr As dsTKSI.tblInstallerRow
        Dim itemtemp As New ListViewItem

        itemtemp = Me.lvInstaller.Items.Add("")
        itemtemp.Selected = False
        itemtemp.SubItems.Add("")
        itemtemp.SubItems.Add("")

        For Each dr In Me.DsTKSI1.tblInstaller
            itemtemp = Me.lvInstaller.Items.Add(dr.ID)
            itemtemp.Selected = False
            itemtemp.SubItems.Add(dr.Name)
            itemtemp.SubItems.Add("...")
        Next

    End Sub

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        Try
            If Me.lvInstaller.SelectedItems.Count > 0 Then
                If IsNumeric(Me.lvInstaller.SelectedItems(0).Text) Then
                    Me.installerID = CInt(Me.lvInstaller.SelectedItems(0).Text)
                    If Me.startDate.SelectionStart <= Me.endDate.SelectionStart Then
                        If Me.EditMode Then
                            If SaveEditData() Then
                                Me.OK = True
                            End If
                        Else
                            If CreateInstallerJob() Then
                                Me.OK = True
                            End If
                        End If
                        Me.Hide()

                    Else
                        Windows.Forms.MessageBox.Show("Invalid date selection. Please try again.")
                    End If
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function SaveEditData() As Boolean
        If Me.EditMode Then
            SaveBoxesToDataRow(Me.EditdrJob)
            Return True
        End If
    End Function

    Private Function JobExists(ByVal sJob As String) As Integer
        If Len(sJob) > 0 Then
            oJob.SelectJobBySJOBNO(Me.DsTKSI1, sJob)
            If Me.DsTKSI1.tJob.Rows.Count > 0 Then
                Return Me.DsTKSI1.tJob(0).nID
            End If
        Else
            Return 0
        End If

    End Function

    Private Function CreateInstallerJob() As Boolean
        Try
            Dim dr As dsTKSI.tblInstallerDatesRow
            dr = Me.DsTKSI1.tblInstallerDates.NewRow

            SaveBoxesToDataRow(dr)
            Me.DsTKSI1.tblInstallerDates.Rows.Add(dr)

            oJob.UpdateInstallerInfo(Me.DsTKSI1)
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving data to database...  " & ex.Message)
            Return False
        End Try

    End Function

    Private Sub SaveBoxesToDataRow(ByVal dr As dsTKSI.tblInstallerDatesRow)
        If Me.lvInstaller.SelectedItems.Count > 0 Then
            dr.InstallerID = CInt(Me.lvInstaller.SelectedItems(0).Text)
        End If

        dr.DateStart = Me.startDate.SelectionStart
        dr.DateEnd = Me.endDate.SelectionStart
        Try
            dr.sJobNum = Me.txtJobno.Text
            dr.jobaddress = Me.txtAddress.Text
            dr.Customer = Me.txtCustomer.Text
            dr.other = ""
            dr.sales = Me.txtSales.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub butAddInstaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddInstaller.Click
        Dim frm As New frmAddInstaller
        frm.ShowDialog()
        If frm.OK Then
            Dim dr As dsTKSI.tblInstallerRow
            dr = Me.DsTKSI1.tblInstaller.NewRow
            dr.Name = frm.txtName.Text
            dr.Contact1 = frm.txtphone1.Text
            dr.Contact2 = frm.txtPhone2.Text
            dr.Contact3 = frm.txtPhone3.Text
            dr.username = frm.txtUsername.Text
            dr.password = frm.txtPassword.Text

            dr.color = CLng(frm.color1)
            Me.DsTKSI1.tblInstaller.Rows.Add(dr)

            oJob.UpdateInstallerInfo(Me.DsTKSI1)
            LoadInstallerList()
        End If
    End Sub

    Private Sub butEditInstaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditInstaller.Click
        If Me.lvInstaller.SelectedItems.Count > 0 Then
            If IsNumeric(Me.lvInstaller.SelectedItems(0).Text) Then
                Dim dr As dsTKSI.tblInstallerRow
                dr = Me.DsTKSI1.tblInstaller.FindByID(CInt(Me.lvInstaller.SelectedItems(0).Text))
                If Not dr Is Nothing Then
                    Dim frm1 As New frmAddInstaller
                    With frm1
                        .blnIsEdit = True
                        .txtName.Text = dr.Name
                        Try
                            .txtphone1.Text = dr.Contact1
                            .txtPhone2.Text = dr.Contact2
                            .txtPhone3.Text = dr.Contact3

                            .color1 = CLng(dr.color)
                            .butColor.BackColor = Color.FromArgb(CLng(dr.color))

                            .txtUsername.Text = dr.username
                            .txtPassword.Text = dr.password

                        Catch ex As Exception
                        End Try
                    End With
                    frm1.butOK.Visible = True
                    frm1.ShowDialog()
                    If frm1.OK Then
                        dr.Name = frm1.txtName.Text
                        dr.Contact1 = frm1.txtphone1.Text
                        dr.Contact2 = frm1.txtPhone2.Text
                        dr.Contact3 = frm1.txtPhone3.Text
                        Try
                            dr.color = frm1.color1
                        Catch ex As Exception
                        End Try
                        dr.username = frm1.txtUsername.Text
                        dr.password = frm1.txtPassword.Text

                        oJob.UpdateInstallerInfo(Me.DsTKSI1)

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub butDeleteInstaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteInstaller.Click
        If Me.lvInstaller.SelectedItems.Count > 0 Then
            If IsNumeric(Me.lvInstaller.SelectedItems(0).Text) Then
                Dim dr As dsTKSI.tblInstallerRow
                dr = Me.DsTKSI1.tblInstaller.FindByID(CInt(Me.lvInstaller.SelectedItems(0).Text))
                If Not dr Is Nothing Then
                    If Windows.Forms.MessageBox.Show("Are you sure you want to delete this installer (" & dr.Name & ")?", "Delete Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        dr.Delete()

                        oJob.UpdateInstallerInfo(Me.DsTKSI1)
                        Me.LoadInstallerList()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lvInstaller_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvInstaller.MouseDown
        If e.Button = MouseButtons.Right Then
            If Me.lvInstaller.SelectedItems.Count > 0 Then
                Dim dr As dsTKSI.tblInstallerRow
                dr = Me.DsTKSI1.tblInstaller.FindByID(CInt(Me.lvInstaller.SelectedItems(0).Text))
                If Not dr Is Nothing Then
                    Dim frm1 As New frmAddInstaller
                    With frm1
                        .blnIsEdit = False
                        .txtName.Text = dr.Name
                        Try
                            .txtphone1.Text = dr.Contact1
                            .txtPhone2.Text = dr.Contact2
                            .txtPhone3.Text = dr.Contact3

                            .color1 = CLng(dr.color)
                            .butColor.BackColor = Color.FromArgb(CLng(dr.color))

                        Catch ex As Exception
                        End Try
                    End With
                    'this is a view only screen
                    frm1.txtPassword.Visible = False
                    frm1.txtUsername.Visible = False
                    frm1.butOK.Visible = False
                    frm1.Label6.Visible = False
                    frm1.Label5.Visible = False
                    frm1.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub endDate_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles endDate.DateChanged
        If Me.startDate.SelectionStart <= Me.endDate.SelectionStart Then
            FlagInstallersWithConflicts()
        End If
    End Sub

    Private Sub FlagInstallersWithConflicts()
        Dim ds1 As New dsTKSI
        ds1.EnforceConstraints = False

        oJob.SelectInstallerconflictStartEnd(ds1, Me.startDate.SelectionStart, Me.endDate.SelectionStart)

        Dim itemtemp As ListViewItem
        For Each itemtemp In Me.lvInstaller.Items
            itemtemp.BackColor = Color.White
            Dim dr As dsTKSI.tblInstallerDatesRow
            For Each dr In ds1.tblInstallerDates.Rows
                Try
                    If IsNumeric(itemtemp.Text) Then
                        If dr.tblInstallerRow.ID = CLng(itemtemp.Text) Then
                            itemtemp.Selected = False
                            itemtemp.BackColor = Color.DarkRed
                        End If
                    End If

                Catch ex As Exception
                End Try
            Next
        Next
    End Sub

    Private Sub frmAddJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadInstallerList()
        If Me.EditMode = True Then
            Me.LoadEditData(Me.EditdrJob)
        End If

    End Sub
End Class
