Option Strict Off
Option Explicit On
Friend Class AddressAdd
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
    Public WithEvents txtLocCode As System.Windows.Forms.TextBox
	Public WithEvents txtJobAdd1 As System.Windows.Forms.TextBox
	Public WithEvents txtJobAdd2 As System.Windows.Forms.TextBox
	Public WithEvents txtJobCity As System.Windows.Forms.TextBox
	Public WithEvents txtJobState As System.Windows.Forms.TextBox
	Public WithEvents txtJobZip As System.Windows.Forms.TextBox
	Public WithEvents txtJobCounty As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtLocCode = New System.Windows.Forms.TextBox()
        Me.txtJobAdd1 = New System.Windows.Forms.TextBox()
        Me.txtJobAdd2 = New System.Windows.Forms.TextBox()
        Me.txtJobCity = New System.Windows.Forms.TextBox()
        Me.txtJobState = New System.Windows.Forms.TextBox()
        Me.txtJobZip = New System.Windows.Forms.TextBox()
        Me.txtJobCounty = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLocCode
        '
        Me.txtLocCode.AcceptsReturn = True
        Me.txtLocCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocCode.Location = New System.Drawing.Point(77, 39)
        Me.txtLocCode.MaxLength = 0
        Me.txtLocCode.Name = "txtLocCode"
        Me.txtLocCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocCode.Size = New System.Drawing.Size(155, 23)
        Me.txtLocCode.TabIndex = 0
        '
        'txtJobAdd1
        '
        Me.txtJobAdd1.AcceptsReturn = True
        Me.txtJobAdd1.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobAdd1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobAdd1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobAdd1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobAdd1.Location = New System.Drawing.Point(77, 69)
        Me.txtJobAdd1.MaxLength = 0
        Me.txtJobAdd1.Name = "txtJobAdd1"
        Me.txtJobAdd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobAdd1.Size = New System.Drawing.Size(395, 26)
        Me.txtJobAdd1.TabIndex = 1
        '
        'txtJobAdd2
        '
        Me.txtJobAdd2.AcceptsReturn = True
        Me.txtJobAdd2.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobAdd2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobAdd2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobAdd2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobAdd2.Location = New System.Drawing.Point(77, 98)
        Me.txtJobAdd2.MaxLength = 0
        Me.txtJobAdd2.Name = "txtJobAdd2"
        Me.txtJobAdd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobAdd2.Size = New System.Drawing.Size(395, 26)
        Me.txtJobAdd2.TabIndex = 1
        '
        'txtJobCity
        '
        Me.txtJobCity.AcceptsReturn = True
        Me.txtJobCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobCity.Location = New System.Drawing.Point(77, 128)
        Me.txtJobCity.MaxLength = 0
        Me.txtJobCity.Name = "txtJobCity"
        Me.txtJobCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobCity.Size = New System.Drawing.Size(155, 26)
        Me.txtJobCity.TabIndex = 2
        '
        'txtJobState
        '
        Me.txtJobState.AcceptsReturn = True
        Me.txtJobState.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobState.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobState.Location = New System.Drawing.Point(307, 128)
        Me.txtJobState.MaxLength = 0
        Me.txtJobState.Name = "txtJobState"
        Me.txtJobState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobState.Size = New System.Drawing.Size(165, 26)
        Me.txtJobState.TabIndex = 3
        '
        'txtJobZip
        '
        Me.txtJobZip.AcceptsReturn = True
        Me.txtJobZip.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobZip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobZip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobZip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobZip.Location = New System.Drawing.Point(77, 158)
        Me.txtJobZip.MaxLength = 0
        Me.txtJobZip.Name = "txtJobZip"
        Me.txtJobZip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobZip.Size = New System.Drawing.Size(155, 26)
        Me.txtJobZip.TabIndex = 4
        '
        'txtJobCounty
        '
        Me.txtJobCounty.AcceptsReturn = True
        Me.txtJobCounty.BackColor = System.Drawing.SystemColors.Window
        Me.txtJobCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobCounty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobCounty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobCounty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJobCounty.Location = New System.Drawing.Point(307, 158)
        Me.txtJobCounty.MaxLength = 0
        Me.txtJobCounty.Name = "txtJobCounty"
        Me.txtJobCounty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtJobCounty.Size = New System.Drawing.Size(165, 26)
        Me.txtJobCounty.TabIndex = 5
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(38, 197)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(117, 31)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(326, 197)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(117, 31)
        Me.cmdOK.TabIndex = 6
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "File #"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(481, 31)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Add an address below:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(10, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Address 1"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(10, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(68, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Address 2"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(10, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(68, 21)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "City"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(240, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(68, 21)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "State"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(10, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Zip"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(240, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "County"
        '
        'AddressAdd
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(498, 257)
        Me.Controls.Add(Me.txtLocCode)
        Me.Controls.Add(Me.txtJobAdd1)
        Me.Controls.Add(Me.txtJobAdd2)
        Me.Controls.Add(Me.txtJobCity)
        Me.Controls.Add(Me.txtJobState)
        Me.Controls.Add(Me.txtJobZip)
        Me.Controls.Add(Me.txtJobCounty)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "AddressAdd"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Add New Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 

	Public OK As Boolean
	Private lID As Integer
    ' Friend dc As linqTKSIDataContext

    Public ReadOnly Property ID() As Integer
        Get
            ID = lID
        End Get
    End Property

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        OK = False
        Me.Hide()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'on error Resume Next
        saveRecord()
    End Sub
    Private Sub saveRecord()
        Try

            If Len(txtJobAdd1.Text) < 1 Then
                Windows.Forms.MessageBox.Show("Cant add an empty address")
                OK = False
                Me.Hide()
            Else
                Dim dc As linqTKSIDataContext = GetLinqDataContext()
                Dim iMax As Integer = (From row In dc.tAddresses Select row.nID).Max
                Dim addnew As New tAddress
                With addnew
                    .nID = iMax + 1
                    .sAddress1 = txtJobAdd1.Text.Trim
                    .sAddress2 = txtJobAdd2.Text.Trim
                    .sCity = txtJobCity.Text.Trim
                    .sState = txtJobState.Text.Trim
                    .sZip = txtJobZip.Text.Trim
                    .sCounty = txtJobCounty.Text.Trim
                    .sLocCode = txtLocCode.Text.Trim

                End With
                dc.tAddresses.InsertOnSubmit(addnew)
                dc.SubmitChanges()



                OK = True
                Me.Hide()
            
            End If
        Catch ex As Exception
            MessageBox.Show("error saving new address, please double check work. " & ex.Message)
        End Try

   
    End Sub

End Class