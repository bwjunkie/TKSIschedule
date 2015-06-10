Imports System.Windows.Forms

Public Class ctrPOLines
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
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(6, 6)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(852, 24)
        Me.pnlTop.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(642, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(144, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(602, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(746, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Account"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctrPOLines
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlTop)
        Me.DockPadding.All = 6
        Me.Name = "ctrPOLines"
        Me.Size = New System.Drawing.Size(864, 192)
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private drPO As dsTKSI.tPOHeaderRow

    Friend Sub LoadPOLines(ByVal drPO1 As dsTKSI.tPOHeaderRow)
        'clear out all existing lines first
        Me.SuspendLayout()
        Try
            Dim i As Integer
            For i = 0 To 100
                If i < Me.Controls.Count Then
                    If Not (Me.Controls(i).GetType Is GetType(Panel)) Then
                        Me.Controls.RemoveAt(i)
                        'when removing a line, count of form objects gets reduced
                        'must decrement counter or a control will be skipped
                        i -= 1
                    End If
                End If
            Next

            Me.drPO = drPO1
            Dim drLine As dsTKSI.tPOLineRow
            Dim lineCount As Long = 1

            Dim ds1 As dsTKSI
            ds1 = drPO1.Table.DataSet

            Dim draLine As dsTKSI.tPOLineRow()
            draLine = ds1.tPOLine.Select("nPoid=" & drPO1.nID, "nLineNumber")
            For Each drLine In draLine
                lineCount += 1
                'Dim ctr As Control
                'For Each ctr In Me.Controls
                '    If ctr.GetType Is GetType(ctrPO1Line) Then
                '        If ctr.Name = "ctrPO1Line" & lineCount Then
                '            Me.Controls.Remove(ctr)
                '            Exit For
                '        End If
                '    End If
                'Next

                Dim ctrLine As New ctrPO1Line
                With ctrLine
                    .BackColor = System.Drawing.Color.White
                    .Dock = System.Windows.Forms.DockStyle.Top
                    .DockPadding.Left = 8
                    .DockPadding.Right = 8
                    .Location = New System.Drawing.Point(0, 24)
                    .Name = "ctrPO1Line" & lineCount
                    .Size = New System.Drawing.Size(656, 26)
                    .TabIndex = lineCount + 1
                End With
                Me.Controls.Add(ctrLine)
                ctrLine.BringToFront()
                ctrLine.Load1Line(drLine)
            Next
            Me.pnlTop.SendToBack()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.ResumeLayout()
    End Sub

    Friend Sub SavePOLines()
        Try
            Dim cnt1 As Control
            For Each cnt1 In Me.Controls
                If cnt1.GetType Is GetType(ctrPO1Line) Then
                    CType(cnt1, ctrPO1Line).Save1Line()
                End If
            Next
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving PO Lines.  " & ex.Message)
        End Try
    End Sub

    Friend Sub DeleteAllLines()
        Dim drPOLINE As dsTKSI.tPOLineRow
        For Each drPOLINE In Me.drPO.GettPOLineRows
            drPOLINE.Delete()
        Next
        Dim i As Long
        For i = 1 To 100
            If i < Me.Controls.Count Then
                Me.Controls.RemoveAt(i)
            End If
        Next
    End Sub

End Class
