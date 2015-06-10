Imports System.Windows.Forms
Imports System.Drawing

Public Class frmDisplayScanImages

    Public drJob As dsTKSI.tJobRow
    Private blnScanCredit As Boolean = False

    Private Sub btnScanChecks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanChecks.Click
        Me.blnScanCredit = False
        Me.Acquire()
    End Sub

    Private Sub Acquire() '  _tw.Acquire(_ActiveProfile, True)
        Try
            Dim WiaObj As WIA.CommonDialog
            Dim WiaDev As WIA.Device
            Dim wiaImg As WIA.ImageFile
            wiaImg = New WIA.ImageFile

            WiaObj = New WIA.CommonDialog

            If WiaDev Is Nothing Then ' WiaDev is defined globally
                WiaDev = WiaObj.ShowSelectDevice( _
                WIA.WiaDeviceType.ScannerDeviceType, True, False)
            End If
            Dim Itm As WIA.Item
            Dim ItmProp As WIA.Property

            For Each Itm In WiaDev.Items
                For Each ItmProp In Itm.Properties
                    ' Windows.Forms.MessageBox.Show(ItmProp.Name & ItmProp.PropertyID)

                    Select Case ItmProp.Name
                        Case "Media Type"
                            ' ItmProp.Value = 128
                        Case "Bits Per Pixel"
                            ' ItmProp.Value = 1
                            '    Case "brightness"
                            '    Case "Threshold"
                    End Select

                    Select Case ItmProp.PropertyID
                        Case 6159 ' threshold
                            Try
                                ItmProp.Value = 160
                            Catch ex As Exception

                            End Try

                        Case 6154 'Brightness
                            Try
                                ItmProp.Value = 1
                            Catch ex As Exception
                                ' ItmProp.Value = 70
                            End Try

                        Case 6147 ' Horizontal Resolution

                            ItmProp.Value = 300
                        Case 6148 ' Vertical Resolution
                            ItmProp.Value = 300
                        Case 6151 ' Horizontal Extent (Scanning Area)

                            ItmProp.Value = 2550

                        Case 6152 ' Vertical Extent (Scanning Area)

                            If Me.blnScanCredit Then
                                ItmProp.Value = 3300
                            Else
                                ItmProp.Value = 1200
                            End If

                            'ItmProp.Value = 3300
                            'ItmProp.Value = 5100
                        Case 6149 ' Horizontal Starting Position (Scanning Area)
                            ItmProp.Value = 0
                        Case 6150 ' Vertical Starting Position (Scanning Area)
                            ItmProp.Value = 0
                        Case 6146 ' Current Intent
                            ItmProp.Value = 4 ' Text or Line Art
                    End Select
                Next

                Dim sJob5 As String = Mid(Me.drJob.sJobNo, 1, 5)
                If IsNumeric(sJob5) Then
                    'leave as 5 digit for folder/file creation
                Else
                    sJob5 = Mid(sJob5, 1, 4)
                End If

                Dim checksPath As String = ""
                '  checksPath = sImagesPath & sJob5 & "\" & drJob.sJobNo & "\CHECKS\"
                checksPath = global_sCreditPathImagesPath & sJob5 & "\" & drJob.sJobNo & "\"

                If Not IO.Directory.Exists(checksPath) Then
                    IO.Directory.CreateDirectory(checksPath)
                End If

                Dim i As Integer = 0
                Try
                    Dim offset As Integer
                    For i = 1 To 100
                        offset = 0
                        Try
                            wiaImg = WiaObj.ShowTransfer(Itm)
                        Catch ex As Exception
                            'we just keep going until the scanner errors because there is nothing left in the feeder
                            Exit For
                        End Try

                        Dim strFileName As String = ""


                        Do
                            strFileName = checksPath & i + offset & ".tif"
                            offset += 1
                        Loop Until Not IO.File.Exists(strFileName)

                        wiaImg.SaveFile(strFileName)

                    Next

                Catch ex As Exception
                    Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            Next

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.LoadJobimages(Me.drJob)

    End Sub

    Private Sub LoadJobimages(ByVal drJob As dsTKSI.tJobRow)
        Dim sJob5 As String = Mid(Me.drJob.sJobNo, 1, 5)
        If IsNumeric(sJob5) Then
            'leave as 5 digit for folder/file creation
        Else
            sJob5 = Mid(sJob5, 1, 4)
        End If

        Try
            Me.PictureBox1.Refresh()
            Me.PictureBox2.Refresh()
            Me.PictureBox3.Refresh()
        Catch
        End Try

        Dim i As Integer = 0
        Dim checksPath As String = ""
        checksPath = sImagesPath & sJob5 & "\" & drJob.sJobNo & "\CHECKS\"
        'old path for checks only  (old checks were not moved to new location)
        If System.IO.Directory.Exists(checksPath) Then
            Dim file1 As String
            For Each file1 In IO.Directory.GetFiles(checksPath)
                i += 1
                Select Case i
                    Case 1
                        Me.PictureBox1.Image = Image.FromFile(file1)
                        Me.PictureBox1.Tag = file1
                    Case 2

                        Me.PictureBox2.Image = Image.FromFile(file1)
                        Me.PictureBox2.Tag = file1
                    Case 3

                        Me.PictureBox3.Image = Image.FromFile(file1)
                        Me.PictureBox3.Tag = file1
                    Case Else
                        Me.Text = i - 3 & " checks not shown... please look in " & checksPath
                End Select

            Next

        End If

        'new path for checks and credit
        checksPath = global_sCreditPathImagesPath & sJob5 & "\" & drJob.sJobNo & "\"
        If System.IO.Directory.Exists(checksPath) Then
            Dim file1 As String
            For Each file1 In IO.Directory.GetFiles(checksPath)
                If Not file1.ToUpper.Contains("THUMB") Then  'thumbs.db file will create error
                    i += 1
                    Select Case i
                        Case 1
                            Me.PictureBox1.Image = Image.FromFile(file1)
                            Me.PictureBox1.Tag = file1
                        Case 2

                            Me.PictureBox2.Image = Image.FromFile(file1)
                            Me.PictureBox2.Tag = file1
                        Case 3

                            Me.PictureBox3.Image = Image.FromFile(file1)
                            Me.PictureBox3.Tag = file1
                        Case Else
                            Me.Text = i - 3 & " checks not shown... please look in " & checksPath
                    End Select
                End If
            Next
        End If
    End Sub

    Private Sub frmDisplayScanImages_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not Me.PictureBox1.Image Is Nothing Then
                Me.PictureBox1.Image.Dispose()
            End If

        Catch
        End Try
        Try
            If Not Me.PictureBox2.Image Is Nothing Then
                Me.PictureBox2.Image.Dispose()
            End If

        Catch
        End Try
        Try
            If Not Me.PictureBox3.Image Is Nothing Then
                Me.PictureBox3.Image.Dispose()
            End If

        Catch
        End Try

    End Sub

    Private Sub frmDisplayScanImages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.drJob Is Nothing Then
            LoadJobimages(Me.drJob)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        DeleteImage(1)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        DeleteImage(2)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        DeleteImage(3)
    End Sub

    Private Sub DeleteImage(ByVal intPic As Integer)
        Dim strpic As String = ""

        Try
            If Windows.Forms.MessageBox.Show("Are you sure you want to delete this image?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Select Case intPic
                    Case 1
                        If Not Me.PictureBox1.Image Is Nothing Then
                            strpic = Me.PictureBox1.Tag
                            Me.PictureBox1.Image.Dispose()
                        End If

                    Case 2
                        If Not Me.PictureBox2.Image Is Nothing Then
                            strpic = Me.PictureBox2.Tag
                            Me.PictureBox2.Image.Dispose()
                        End If

                    Case 3
                        If Not Me.PictureBox3.Image Is Nothing Then
                            strpic = Me.PictureBox3.Tag
                            Me.PictureBox3.Image.Dispose()
                        End If

                    Case Else
                        Windows.Forms.MessageBox.Show("Please right-click on the image you want to delete and try again.")
                        Exit Try
                End Select



                If IO.File.Exists(strpic) Then
                    IO.File.Delete(strpic)
                End If


                Me.LoadJobimages(Me.drJob)
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error deleting... " & ex.Message)
        End Try

    End Sub

    Private Sub btnScanCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanCredit.Click
        Me.blnScanCredit = True
        Me.Acquire()
    End Sub
End Class