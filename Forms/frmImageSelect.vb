Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Public Class frmImageSelect
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnStartDrawing As System.Windows.Forms.Button
    Friend WithEvents btnClearDrawing As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnTEXT As System.Windows.Forms.Button
    Friend WithEvents pnlPicture As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteImage As System.Windows.Forms.Button
    Friend WithEvents TblSWOImagesTableAdapter1 As TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOImagesTableAdapter
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnAddImage = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnStartDrawing = New System.Windows.Forms.Button
        Me.btnClearDrawing = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnDeleteImage = New System.Windows.Forms.Button
        Me.btnTEXT = New System.Windows.Forms.Button
        Me.pnlPicture = New System.Windows.Forms.Panel
        Me.TblSWOImagesTableAdapter1 = New TKSISchedule.TKSIJOBSDataSetTableAdapters.tblSWOImagesTableAdapter
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlPicture.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1500, 2200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddImage.Location = New System.Drawing.Point(918, 7)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(204, 23)
        Me.btnAddImage.TabIndex = 1
        Me.btnAddImage.Text = "Save to SWO"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(108, 7)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(89, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next -->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(13, 7)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(89, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "<-- Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnStartDrawing
        '
        Me.btnStartDrawing.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartDrawing.Location = New System.Drawing.Point(402, 7)
        Me.btnStartDrawing.Name = "btnStartDrawing"
        Me.btnStartDrawing.Size = New System.Drawing.Size(89, 23)
        Me.btnStartDrawing.TabIndex = 4
        Me.btnStartDrawing.Text = "Start Drawing"
        Me.btnStartDrawing.UseVisualStyleBackColor = False
        '
        'btnClearDrawing
        '
        Me.btnClearDrawing.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearDrawing.Location = New System.Drawing.Point(497, 7)
        Me.btnClearDrawing.Name = "btnClearDrawing"
        Me.btnClearDrawing.Size = New System.Drawing.Size(89, 23)
        Me.btnClearDrawing.TabIndex = 5
        Me.btnClearDrawing.Text = "Clear Drawing and Text"
        Me.btnClearDrawing.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnDeleteImage)
        Me.Panel1.Controls.Add(Me.btnTEXT)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnAddImage)
        Me.Panel1.Controls.Add(Me.btnClearDrawing)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnStartDrawing)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 40)
        Me.Panel1.TabIndex = 6
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(690, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print Image"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'btnDeleteImage
        '
        Me.btnDeleteImage.Location = New System.Drawing.Point(785, 7)
        Me.btnDeleteImage.Name = "btnDeleteImage"
        Me.btnDeleteImage.Size = New System.Drawing.Size(89, 23)
        Me.btnDeleteImage.TabIndex = 9
        Me.btnDeleteImage.Text = "Delete Image"
        Me.btnDeleteImage.UseVisualStyleBackColor = True
        Me.btnDeleteImage.Visible = False
        '
        'btnTEXT
        '
        Me.btnTEXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTEXT.Location = New System.Drawing.Point(307, 7)
        Me.btnTEXT.Name = "btnTEXT"
        Me.btnTEXT.Size = New System.Drawing.Size(89, 23)
        Me.btnTEXT.TabIndex = 6
        Me.btnTEXT.Text = "Add Text"
        Me.btnTEXT.UseVisualStyleBackColor = False
        '
        'pnlPicture
        '
        Me.pnlPicture.AutoScroll = True
        Me.pnlPicture.Controls.Add(Me.PictureBox1)
        Me.pnlPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPicture.Location = New System.Drawing.Point(0, 40)
        Me.pnlPicture.Name = "pnlPicture"
        Me.pnlPicture.Size = New System.Drawing.Size(1181, 742)
        Me.pnlPicture.TabIndex = 7
        '
        'TblSWOImagesTableAdapter1
        '
        Me.TblSWOImagesTableAdapter1.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'frmImageSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1181, 782)
        Me.Controls.Add(Me.pnlPicture)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmImageSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Full page view"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlPicture.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private gSWOID As Guid
    Private alImageList As New List(Of String) ' ArrayList
    Public ImageToAdd As String = ""
    Private currentImage As String = ""

    Private strSWOFolder As String = ""

    Dim mousePath As New System.Drawing.Drawing2D.GraphicsPath() 'declare a new Graphic path to follow the mouse movement
    Dim mousePathZoom As New System.Drawing.Drawing2D.GraphicsPath

    '*** below I declare some values for an Alpha  and other user selected variables
    'these will be used as I expand this program for a higher level use.

    Dim myAlpha As Integer = 100 ' declare a Alpha variable
    Dim myUserColor As New Color()
    Dim myPenWidth As Single = 5 'set pen width variable
    '**************************************************************
    Private blnAllowText As Boolean = False
    Dim blnAllowDrawing As Boolean = False

    Public blnEditExisting As Boolean = False
    Public ImageToRemove As String = ""
    Private blnDeleteFile As Boolean = False

    Public Sub LoadImageList(ByVal alImages As List(Of String), ByVal gSWOID1 As Guid, ByVal sSWOFolder As String)
        Me.gSWOID = gSWOID1
        Me.alImageList = alImages
        Me.strSWOFolder = sSWOFolder
    End Sub

    Private Sub frmImageSelect_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not Me.PictureBox1.Image Is Nothing Then
                Me.PictureBox1.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try
    End Sub

    Private Sub frmImageSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim frm1 As New frmWorking
        Try
            frm1.Show()
            Me.Location = New Point(1, 1)
            Me.Width = global_ScreenWidth - 130
            Me.Height = global_ScreenHeight - 90

            If Me.blnEditExisting Then
                Me.btnDeleteImage.Visible = True
            End If

            'load initial image 
            Dim path1 As String
            For Each path1 In Me.alImageList
                If File.Exists(path1) Then
                    Dim img1 As Image = Image.FromFile(path1)
                    If img1.Width > 2400 Then
                        Me.PictureBox1.Size = New Size(img1.Width / 2, img1.Height / 2)
                    ElseIf img1.Width > 1600 Then
                        Me.PictureBox1.Size = New Size(img1.Width / 1.5, img1.Height / 1.5)
                    Else

                        Me.PictureBox1.Size = img1.Size
                    End If

                    Me.PictureBox1.Image = img1
                    Me.currentImage = path1

                    Exit For
                End If
            Next
        Catch ex As Exception
        Finally
            Try
                frm1.Close()
            Catch
            End Try
        End Try


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim frm1 As New frmWorking
        Try
            frm1.Show()
            'load initial image 
            Me.blnAllowDrawing = False
            Me.blnAllowText = False
            Dim path1 As String
            Dim blnUseNext As Boolean = False
            For Each path1 In Me.alImageList
                If blnUseNext Then
                    If IO.File.Exists(path1) Then
                        Me.PictureBox1.Image = Image.FromFile(path1)
                        Me.currentImage = path1
                    End If

                    Exit For
                End If
                If path1 = currentImage Then
                    blnUseNext = True
                End If
            Next
        Catch ex As Exception
        Finally
            Try
                frm1.Close()
            Catch
            End Try
        End Try

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        Dim frm1 As New frmWorking
        Try
            frm1.Show()
            'load initial image 

            Me.blnAllowDrawing = False
            Me.blnAllowText = False

            Dim path1 As String
            Dim blnUsePrevious As Boolean = False
            Dim strPreviousPic As String = ""

            For Each path1 In Me.alImageList
                If blnUsePrevious Then
                    If IO.File.Exists(strPreviousPic) Then
                        Me.PictureBox1.Image = Image.FromFile(strPreviousPic)
                        currentImage = strPreviousPic
                        Exit Sub
                    Else
                        Exit Sub
                    End If

                End If
                If path1 = currentImage Then
                    blnUsePrevious = True
                Else
                    strPreviousPic = path1
                End If
            Next
            If IO.File.Exists(strPreviousPic) Then
                Me.PictureBox1.Image = Image.FromFile(strPreviousPic)
                currentImage = strPreviousPic
            End If
        Catch ex As Exception
        Finally
            Try
                frm1.Close()
            Catch
            End Try
        End Try

    End Sub

    Private Sub btnAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddImage.Click
        Dim frm1 As New frmWorking
        Try
            frm1.Show()
            Me.blnAllowDrawing = False
            Me.blnAllowText = False

            If Not Me.PictureBox1.Image Is Nothing Then

                Try
                    Dim i As Integer = 1
                    For i = 1 To 100
                        Dim strImageName As String = sImagesPath & Me.strSWOFolder & "\SWO\" & i.ToString & ".TIF"
                        Dim strImageThumbName = Replace(strImageName, "\SWO\", "\SWO\thumbs\")
                        strImageThumbName = Replace(strImageThumbName, ".TIF", ".JPG")

                        If Not IO.File.Exists(strImageName) Then
                            If Not IO.Directory.Exists(sImagesPath & Me.strSWOFolder & "\SWO\") Then
                                IO.Directory.CreateDirectory(sImagesPath & strSWOFolder & "\SWO\")
                            End If
                            If Not IO.Directory.Exists(sImagesPath & Me.strSWOFolder & "\SWO\thumbs\") Then
                                IO.Directory.CreateDirectory(sImagesPath & strSWOFolder & "\SWO\thumbs\")
                            End If

                            ' Dim bmp1 As New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
                            Dim g As Graphics
                            Dim tmpBitmap As Bitmap = New Bitmap(Me.PictureBox1.Image.Width, Me.PictureBox1.Image.Height)
                            g = Graphics.FromImage(tmpBitmap)
                            g.SmoothingMode = Drawing2D.SmoothingMode.None
                            g.DrawImage(Me.PictureBox1.Image, 0, 0, tmpBitmap.Width, tmpBitmap.Height)

                            Dim CurrentPen = New Pen(Color.FromArgb(myAlpha, myUserColor), myPenWidth)
                            g.DrawPath(CurrentPen, mousePathZoom)

                            'Dim mousePathZoom As New Drawing2D.GraphicsPath

                            Dim currentZoomScaleX As Single = Me.PictureBox1.Image.Width / Me.PictureBox1.Width
                            Dim currentZoomScaleY As Single = Me.PictureBox1.Image.Height / Me.PictureBox1.Height

                            'Dim pntf As PointF
                            'Dim k As Integer = 0
                            'Dim pnts() As Point
                            'If mousePath.PointCount > 0 Then
                            '    For Each pntf In mousePath.PathPoints
                            '        Dim pntToAdd As New Point(pntf.X * currentZoomScaleX, pntf.Y * currentZoomScaleY)
                            '        mousePathZoom.AddLine(pntToAdd, pntToAdd)
                            '    Next
                            '    Dim CurrentPen1 = New Pen(Color.FromArgb(myAlpha, myUserColor), myPenWidth)
                            '    g.DrawPath(CurrentPen1, mousePathZoom)

                            'End If

                            Dim ctrl1 As Control
                            For Each ctrl1 In Me.pnlPicture.Controls
                                If Mid(ctrl1.Name, 1, 3) = "txt" Then
                                    If ctrl1.Text.Trim.Length > 0 Then
                                        g.DrawString(ctrl1.Text, New Font("Arial", 48, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, ctrl1.Location.X * currentZoomScaleX, ctrl1.Location.Y * currentZoomScaleY)

                                    End If
                                End If
                            Next

                            tmpBitmap.Save(strImageName, System.Drawing.Imaging.ImageFormat.Tiff)

                            Dim imgThumb As Image = New Bitmap(tmpBitmap, New Size(tmpBitmap.Size.Width * 0.2, tmpBitmap.Size.Height * 0.2))
                            imgThumb.Save(strImageThumbName, Imaging.ImageFormat.Jpeg)

                            Me.ImageToAdd = strImageName

                            If Me.blnEditExisting Then
                                Me.ImageToRemove = Me.currentImage
                            End If

                            Exit For
                        End If
                    Next
                Catch

                End Try

            End If

            Dim tblImages As New TKSIJOBSDataSet.tblSWOImagesDataTable
            Me.TblSWOImagesTableAdapter1.FillByGSWOID(tblImages, Me.gSWOID)

            Try
                ' delete previous entries out and rebuild image list in SQL with current arraylist of images
                If Me.blnEditExisting Then
                    Me.alImageList.Add(Me.ImageToAdd)
                    If Me.ImageToRemove.Trim.Length > 2 Then
                        If IO.File.Exists(Me.ImageToRemove.Trim) Then
                            Dim str As String
                            Dim i As Integer = 0
                            For Each str In Me.alImageList
                                i += 1
                                If str.ToUpper.Trim = Me.ImageToRemove.ToUpper.Trim Then
                                    Me.alImageList.Remove(str)
                                    Exit For
                                End If
                            Next

                        End If
                    End If

                    Dim drImage As TKSIJOBSDataSet.tblSWOImagesRow
                    For Each drImage In tblImages
                        drImage.Delete()
                    Next

                    Dim str1 As String
                    For Each str1 In Me.alImageList
                        drImage = tblImages.AddtblSWOImagesRow(Me.gSWOID, str1)
                    Next
                    Me.TblSWOImagesTableAdapter1.Update(tblImages)
                Else
                    'adding image from original Job file
                    If Me.ImageToAdd.Trim.Length > 0 Then
                        tblImages.AddtblSWOImagesRow(Me.gSWOID, Me.ImageToAdd)
                        Me.TblSWOImagesTableAdapter1.Update(tblImages)
                    End If
                End If

            Catch

            End Try

            Me.Close()

        Catch

        Finally
            Try
                frm1.Close()
            Catch
            End Try
        End Try

    End Sub

    Private Sub btnStartDrawing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartDrawing.Click
        Me.blnAllowText = False
        Me.PictureBox1.Cursor = Cursors.Cross
        Me.blnAllowDrawing = True
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown

        If Me.blnAllowDrawing Then

            If e.Button = MouseButtons.Left Then ' draw a filled circle if left mouse is down  
                mousePath.StartFigure()    ' The L mouse is down so we need to start a new line in mousePath
                mousePathZoom.StartFigure()
            End If

        End If
        If Me.blnAllowText Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim txt1 As New TextBox
                txt1.Font = New Font("Arial", 24, FontStyle.Regular, GraphicsUnit.Point)
                txt1.Name = "txt" & Now.Ticks
                txt1.Size = New Size(400, 200)
                txt1.BorderStyle = BorderStyle.FixedSingle
                Me.pnlPicture.Controls.Add(txt1)
                txt1.Location = New Point(e.Location.X - Me.pnlPicture.HorizontalScroll.Value, e.Location.Y - Me.pnlPicture.VerticalScroll.Value)
                txt1.BringToFront()
                txt1.Focus()
                Me.pnlPicture.ResumeLayout()
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If Me.blnAllowDrawing Then

            If e.Button = MouseButtons.Left Then ' draw a filled circle if left mouse is down  

                Try
                    mousePath.AddLine(e.X, e.Y, e.X, e.Y)    'Add mouse coordiantes to mousePath

                    Dim currentZoomScaleX As Single = Me.PictureBox1.Image.Width / Me.PictureBox1.Width
                    Dim currentZoomScaleY As Single = Me.PictureBox1.Image.Height / Me.PictureBox1.Height

                    mousePathZoom.AddLine(e.X * currentZoomScaleX, e.Y * currentZoomScaleY, e.X * currentZoomScaleX, e.Y * currentZoomScaleY)
                Catch
                    MsgBox("Please re-open the image to draw.")
                End Try

            End If

            PictureBox1.Invalidate() 'Repaint the PictureBox using the PictureBox1 Paint event


        End If

    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        If Me.blnAllowDrawing Then

            ' Here is where we do the actual painting

            Try ' error trapping
                myUserColor = (System.Drawing.Color.Blue) 'You can remove this line and add a user selected color to
                'change the value of myUserColor

                myAlpha = 160  ' This will give the color a Alpha effect, you can set this to 255 if you want a full color
                Dim CurrentPen = New Pen(Color.FromArgb(myAlpha, myUserColor), myPenWidth) 'Set up the pen
                e.Graphics.DrawPath(CurrentPen, mousePath)  'draw the path! :)

            Catch
                ' MsgBox("Not happening!")
            End Try
        End If

    End Sub

    Private Sub btnClearDrawing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDrawing.Click
        mousePath = New System.Drawing.Drawing2D.GraphicsPath()
        mousePathZoom = New Drawing2D.GraphicsPath

        PictureBox1.Invalidate()
        Dim ctrl1 As Control
        For Each ctrl1 In Me.pnlPicture.Controls
            If ctrl1.GetType Is GetType(TextBox) Then
                ctrl1.Text = ""
            End If
        Next
    End Sub

    Private Sub btnTEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTEXT.Click
        Me.blnAllowDrawing = False
        Me.blnAllowText = True
    End Sub

    Private Sub btnStopText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.blnAllowText = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.blnAllowDrawing = False
    End Sub

    Private Sub btnDeleteImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteImage.Click
        Dim frm1 As New frmWorking
        Try
            frm1.Show()

            Me.blnAllowDrawing = False
            Me.blnAllowText = False

            If Me.blnEditExisting Then
                If Not Me.PictureBox1.Image Is Nothing Then
                    Me.PictureBox1.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
                End If

                Me.blnDeleteFile = True

                'remove the file from the arraylist of entries

                If IO.File.Exists(Me.currentImage) Then
                    Dim tblImages As New TKSIJOBSDataSet.tblSWOImagesDataTable
                    Me.ImageToRemove = Me.currentImage
                    If Me.ImageToRemove.Trim.Length > 2 Then
                        If IO.File.Exists(Me.ImageToRemove.Trim) Then
                            Dim str As String
                            Dim i As Integer = 0
                            For Each str In Me.alImageList
                                i += 1
                                If str.ToUpper.Trim = Me.ImageToRemove.ToUpper.Trim Then
                                    Me.alImageList.Remove(str)
                                    Exit For
                                End If
                            Next

                        End If
                    End If

                    Me.TblSWOImagesTableAdapter1.FillByGSWOID(tblImages, Me.gSWOID)
                    Dim drImage As TKSIJOBSDataSet.tblSWOImagesRow
                    For Each drImage In tblImages
                        drImage.Delete()
                    Next
                    Me.TblSWOImagesTableAdapter1.Update(tblImages)

                    Dim str1 As String
                    For Each str1 In Me.alImageList
                        drImage = tblImages.AddtblSWOImagesRow(Me.gSWOID, str1)
                    Next
                    Me.TblSWOImagesTableAdapter1.Update(tblImages)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
        Finally
            Try
                frm1.Close()
            Catch
            End Try
        End Try

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not Me.PictureBox1.Image Is Nothing Then
            Me.PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If Not Me.PictureBox1.Image Is Nothing Then
            e.Graphics.DrawImage(Me.PictureBox1.Image, 0, 0, 850, 1100)
        End If

    End Sub
End Class
