Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmInstallerBook
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butNextWeek As System.Windows.Forms.Button
    Friend WithEvents butPreviousWeek As System.Windows.Forms.Button
    Friend WithEvents lvDays As System.Windows.Forms.ListView
    Friend WithEvents butAddJob As System.Windows.Forms.Button
    Friend WithEvents butDeleteJob As System.Windows.Forms.Button
    Friend WithEvents lvLedgend As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butEditJob As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnUpdateWeb As System.Windows.Forms.Button
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lvDays = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butNextWeek = New System.Windows.Forms.Button()
        Me.butPreviousWeek = New System.Windows.Forms.Button()
        Me.butAddJob = New System.Windows.Forms.Button()
        Me.butDeleteJob = New System.Windows.Forms.Button()
        Me.lvLedgend = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butEditJob = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DsTKSI1 = New TKSISchedule.dsTKSI()
        Me.btnUpdateWeb = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvDays
        '
        Me.lvDays.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDays.FullRowSelect = True
        Me.lvDays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvDays.Location = New System.Drawing.Point(0, 40)
        Me.lvDays.MultiSelect = False
        Me.lvDays.Name = "lvDays"
        Me.lvDays.Size = New System.Drawing.Size(880, 939)
        Me.lvDays.TabIndex = 0
        Me.lvDays.UseCompatibleStateImageBehavior = False
        Me.lvDays.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sunday"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Monday"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tuesday"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Wednesday"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Thursday"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Friday"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Saturday"
        Me.ColumnHeader7.Width = 120
        '
        'butNextWeek
        '
        Me.butNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butNextWeek.Location = New System.Drawing.Point(144, 8)
        Me.butNextWeek.Name = "butNextWeek"
        Me.butNextWeek.Size = New System.Drawing.Size(120, 24)
        Me.butNextWeek.TabIndex = 1
        Me.butNextWeek.Text = "Next Week >"
        '
        'butPreviousWeek
        '
        Me.butPreviousWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butPreviousWeek.Location = New System.Drawing.Point(16, 8)
        Me.butPreviousWeek.Name = "butPreviousWeek"
        Me.butPreviousWeek.Size = New System.Drawing.Size(120, 24)
        Me.butPreviousWeek.TabIndex = 2
        Me.butPreviousWeek.Text = "< Previous Week"
        '
        'butAddJob
        '
        Me.butAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAddJob.Location = New System.Drawing.Point(312, 8)
        Me.butAddJob.Name = "butAddJob"
        Me.butAddJob.Size = New System.Drawing.Size(80, 24)
        Me.butAddJob.TabIndex = 3
        Me.butAddJob.Text = "Add Job"
        '
        'butDeleteJob
        '
        Me.butDeleteJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butDeleteJob.Location = New System.Drawing.Point(488, 8)
        Me.butDeleteJob.Name = "butDeleteJob"
        Me.butDeleteJob.Size = New System.Drawing.Size(80, 24)
        Me.butDeleteJob.TabIndex = 4
        Me.butDeleteJob.Text = "Delete Job"
        '
        'lvLedgend
        '
        Me.lvLedgend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvLedgend.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvLedgend.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvLedgend.Location = New System.Drawing.Point(886, 40)
        Me.lvLedgend.MultiSelect = False
        Me.lvLedgend.Name = "lvLedgend"
        Me.lvLedgend.Size = New System.Drawing.Size(193, 320)
        Me.lvLedgend.TabIndex = 5
        Me.lvLedgend.UseCompatibleStateImageBehavior = False
        Me.lvLedgend.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Width = 30
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 120
        '
        'butEditJob
        '
        Me.butEditJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butEditJob.Location = New System.Drawing.Point(400, 8)
        Me.butEditJob.Name = "butEditJob"
        Me.butEditJob.Size = New System.Drawing.Size(80, 24)
        Me.butEditJob.TabIndex = 6
        Me.butEditJob.Text = "Edit Job"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpdateWeb)
        Me.Panel1.Controls.Add(Me.butNextWeek)
        Me.Panel1.Controls.Add(Me.butPreviousWeek)
        Me.Panel1.Controls.Add(Me.butAddJob)
        Me.Panel1.Controls.Add(Me.butDeleteJob)
        Me.Panel1.Controls.Add(Me.butEditJob)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 41)
        Me.Panel1.TabIndex = 7
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 160000
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTKSI1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdateWeb
        '
        Me.btnUpdateWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateWeb.Location = New System.Drawing.Point(742, 8)
        Me.btnUpdateWeb.Name = "btnUpdateWeb"
        Me.btnUpdateWeb.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdateWeb.TabIndex = 7
        Me.btnUpdateWeb.Text = "Update Web"
        '
        'frmInstallerBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1130, 831)
        Me.Controls.Add(Me.lvDays)
        Me.Controls.Add(Me.lvLedgend)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmInstallerBook"
        Me.Text = "Installer Book by week"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private currentStartDate As Date
    Private alCurrentCalendarBoxes As New ArrayList

    Private Sub frmInstallerBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ' If Me.WorkstationHasInternetAccess Then
            If Not WebRecentlyUpdated() Then
                UpdateWeb()
            End If
            'End If

            currentStartDate = GetStartDateOfWeek(Now.Date)
            LoadNewFormData()
            If global_ScreenWidth < 1200 Then
                Me.Width = global_ScreenWidth - 180
            End If

            Me.Top = 5
            Me.Height = global_ScreenHeight - 50
            Me.lvDays.Height = global_ScreenHeight - 135


        Catch ex As Exception

        End Try

    End Sub

    Private oJob As New JobObj

    Private Sub LoadNewFormData()
        Me.currentSelectedJob = 0
        'oJob.SelectAllJobAddressCustomerVendor(Me.DsTKSI1)

        If Not oJob.SelectInstallerDataStartEnd(Me.DsTKSI1, currentStartDate) Then
            Windows.Forms.MessageBox.Show("Error loading database info.")
        Else
            oJob.SelectCustomersVendors(Me.DsTKSI1)
            BuildWeek()
            BuildLedgend()
        End If
    End Sub

    Private Sub BuildLedgend()
        Me.lvLedgend.Items.Clear()
        Dim dr As dsTKSI.tblInstallerRow
        For Each dr In Me.DsTKSI1.tblInstaller
            Dim itemtemp As ListViewItem
            itemtemp = Me.lvLedgend.Items.Add("")
            itemtemp.UseItemStyleForSubItems = False
            itemtemp.SubItems.Add(dr.Name)
            itemtemp.SubItems(0).BackColor = Color.FromArgb(dr.color)
        Next
    End Sub

    Private Function GetStartDateOfWeek(ByVal thisWeek As Date) As Date
        Dim dStart As Date
        Dim dEnd As Date
        dStart = thisWeek.AddDays(-6)
        dEnd = thisWeek.AddDays(6)
        Dim i As Integer
        For i = 1 To 20
            Select Case dStart.DayOfWeek
                Case DayOfWeek.Sunday
                    Return dStart
            End Select
            dStart = dStart.AddDays(1)
        Next
        Return thisWeek.Date
    End Function

    'job address
    'sales name
    'cust name
    'po number

    Private Sub BuildWeek()
        Dim dDate As Date
        dDate = currentStartDate

        Me.ColumnHeader1.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)
        Me.ColumnHeader2.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)
        Me.ColumnHeader3.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)
        Me.ColumnHeader4.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)
        Me.ColumnHeader5.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)
        Me.ColumnHeader6.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)
        Me.ColumnHeader7.Text = dDate.DayOfWeek.ToString & " " & dDate.Date
        dDate = dDate.AddDays(1)

        FillRowsWithJobs()

        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub FillRowsWithJobs()

        Me.lvDays.Items.Clear()
        Dim drDate As dsTKSI.tblInstallerDatesRow

        ClearPreviousCalendarLabelBoxes()
        Me.alCurrentCalendarBoxes = New ArrayList

        Dim CalendarJobList1 As New CalendarJobList(True)

        For Each drDate In Me.DsTKSI1.tblInstallerDates
            If (drDate.DateStart <= currentStartDate.AddDays(6)) And _
                (drDate.DateEnd >= currentStartDate) Then
                Dim calendar1 As New CalendarJob(drDate, Me.currentStartDate)
                CalendarJobList1.AddJob(calendar1)
                'AddJob(drDate)
            End If
        Next

        DrawCalendarBoxes(CalendarJobList1)

    End Sub

    Private Sub ClearPreviousCalendarLabelBoxes()
        Try
            Dim label1 As CalendarBox
            For Each label1 In Me.alCurrentCalendarBoxes
                Me.Controls.Remove(label1)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DrawCalendarBoxes(ByVal CalList As CalendarJobList)
        Dim cal1 As CalendarJob
        Dim previuosAddedJobLevel As Long
        previuosAddedJobLevel = -1

        For Each cal1 In CalList.alList
            cal1.topLeftPointLocation.X = ((cal1.dayOfWeekNumber - 1) * 120) + 3
            cal1.topLeftPointLocation.Y = Me.lvDays.Location.Y + ((cal1.LevelToPlaceOnCalendar * 50) - 30)
            cal1.boxSize.Height = 47
            cal1.boxSize.Width = cal1.jobLength * 119
            DrawOneBox(cal1)
        Next
    End Sub

    Private Sub DrawOneBox(ByVal cal1 As CalendarJob)

        Dim label2 As CalendarBox
        label2 = New CalendarBox

        Dim strBoxText As String
        strBoxText = GetTextForJob(cal1)

        With cal1
            If IsNumeric(cal1.drDate.tblInstallerRow.color) Then
                Dim lcolor As Long
                lcolor = CLng(cal1.drDate.tblInstallerRow.color)
                label2.BackColor = Color.FromArgb(lcolor)
            End If
        End With

        label2.Location = cal1.topLeftPointLocation
        label2.Name = cal1.installerID & cal1.startDate.Month & cal1.startDate.Day
        label2.Size = cal1.boxSize
        label2.TabIndex = 2
        label2.Text = strBoxText
        label2.dDate = cal1.startDate
        label2.ID = cal1.drDate.ID
        label2.Font = New Font("Arial", 8, FontStyle.Bold)
        If label2.ID = Me.currentSelectedJob Then
            label2.BackColor = Color.White
            label2.BorderStyle = BorderStyle.FixedSingle

        End If

        Me.Controls.Add(label2)
        label2.BringToFront()
        AddHandler label2.Click, AddressOf Me.HandleLableClick
        SaveNewLabelToArray(label2)
    End Sub

    Private Function GetTextForJob(ByVal cal1 As CalendarJob) As String
        Try
            Dim sName As String
            'Dim sJobNum As String
            Dim s2ndline As String
            Dim s3rdline As String
            'Dim lcolor As Long
            With cal1
                sName = .drDate.tblInstallerRow.Name
                sName = sName
                s2ndline = .drDate.jobaddress
                s3rdline = "(" & .drDate.sales & ") "
                s3rdline = s3rdline & .drDate.Customer
            End With
            Return sName & vbCrLf & s2ndline & vbCrLf & s3rdline
        Catch ex As Exception

        End Try

    End Function

    Private Sub SaveNewLabelToArray(ByVal label2 As CalendarBox)
        alCurrentCalendarBoxes.Add(label2)
    End Sub

    Private Sub HandleLableClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.currentSelectedJob = sender.id
        BuildWeek()

    End Sub

    Private Structure CalendarJobList
        Dim alList As ArrayList
        Sub New(ByVal overLap As Boolean) 'overLap is for future use of optional overlapping jobs on same horizontal level 
            alList = New ArrayList
        End Sub
        Sub AddJob(ByVal job As CalendarJob)
            If Me.alList.Count = 0 Then
                'first job added, automatically gets level 1
                job.LevelToPlaceOnCalendar = 1
            Else
                'if this new job has different installer ID than previous job that was added to this joblist,
                'then i gets a new level, else we have to compare dates to see if it can go on the same level
                'we want any jobs that have the same installer ID to be on the same horizontal line of the calendar
                'except when they overlap, then they have to get on next line
                Dim previousJob As CalendarJob
                Dim blnFoundExistingLine As Boolean
                Dim existingLineThatDoesNotConflict As Long
                existingLineThatDoesNotConflict = 0
                previousJob = alList(alList.Count - 1)

                Dim otherJob As CalendarJob
                Dim i As Long
                For i = 1 To alList.Count
                    blnFoundExistingLine = True
                    For Each otherJob In alList
                        If otherJob.LevelToPlaceOnCalendar = i Then
                            If job.installerID = otherJob.installerID Then
                                If DatesConflict(job, otherJob) Then
                                    blnFoundExistingLine = False
                                End If
                            Else
                                blnFoundExistingLine = False
                            End If
                        End If
                    Next
                    If blnFoundExistingLine Then
                        job.LevelToPlaceOnCalendar = i
                        Exit For
                    Else
                        job.LevelToPlaceOnCalendar = previousJob.LevelToPlaceOnCalendar + 1
                    End If
                Next
            End If

            Me.alList.Add(job)
        End Sub

        Private Function DatesConflict(ByVal job1 As CalendarJob, ByVal job2 As CalendarJob) As Boolean
            'determine if two jobs should be allowed on same horizontal line
            'if job1 is monday and tuesday, and job2 is friday, then they are both ok to be on 1 line

            Dim date1 As Date
            Dim date2 As Date
            For Each date1 In job1.dateArray
                For Each date2 In job2.dateArray
                    If Date.Equals(date1, date2) Then
                        Return True
                    End If
                Next
            Next
            Return False
        End Function

    End Structure


    Private Structure CalendarJob

        Dim drDate As dsTKSI.tblInstallerDatesRow
        Dim startDate As Date
        Dim endDate As Date
        Dim dateArray As ArrayList 'of date type
        Dim jobLength As Long
        Dim dayOfWeekNumber As Long 'sunday is 1 saturday is 7
        Dim LevelToPlaceOnCalendar As Long
        Dim topLeftPointLocation As Point
        Dim boxSize As Size
        Dim installerID As Long

        Sub New(ByVal p_drDate As dsTKSI.tblInstallerDatesRow, ByVal weekBeingShownStartDate As Date)
            Me.drDate = p_drDate
            Me.installerID = drDate.tblInstallerRow.ID

            'jobs that start and end on same day should have length of 1
            'joblength and startdate for this object can only include days for which the week showing is applicable
            'so if the job started last week on wednesday and goes for 20 days then...
            'when looking at this week, the start date is sunday and the joblength is 7 days

            Me.topLeftPointLocation = New Point(0, 0)
            Me.boxSize = New Size(0, 0)
            Me.dateArray = New ArrayList
            Dim i As Long
            Dim blnStartDateFound As Boolean
            blnStartDateFound = False
            For i = 0 To (drDate.DateEnd.Subtract(drDate.DateStart).Days)
                If drDate.DateStart.AddDays(i) >= weekBeingShownStartDate And _
                    drDate.DateStart.AddDays(i) <= weekBeingShownStartDate.AddDays(6) Then
                    If Not blnStartDateFound Then
                        Me.startDate = drDate.DateStart.AddDays(i)
                    End If
                    blnStartDateFound = True
                    Me.jobLength += 1

                    Me.endDate = drDate.DateEnd
                    Me.dateArray.Add(drDate.DateStart.AddDays(i))
                End If
            Next
            Select Case startDate.DayOfWeek
                Case DayOfWeek.Sunday
                    Me.dayOfWeekNumber = 1
                Case DayOfWeek.Monday
                    Me.dayOfWeekNumber = 2
                Case DayOfWeek.Tuesday
                    Me.dayOfWeekNumber = 3
                Case DayOfWeek.Wednesday
                    Me.dayOfWeekNumber = 4
                Case DayOfWeek.Thursday
                    Me.dayOfWeekNumber = 5
                Case DayOfWeek.Friday
                    Me.dayOfWeekNumber = 6
                Case DayOfWeek.Saturday
                    Me.dayOfWeekNumber = 7
            End Select
        End Sub
    End Structure

    Private Sub butNextWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNextWeek.Click
        Me.currentSelectedJob = 0
        currentStartDate = GetStartDateOfWeek(Me.currentStartDate.AddDays(7))
        oJob.SelectInstallerDataStartEnd(Me.DsTKSI1, currentStartDate)
        BuildWeek()
    End Sub

    Private Sub butPreviousWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butPreviousWeek.Click
        Me.currentSelectedJob = 0
        currentStartDate = GetStartDateOfWeek(Me.currentStartDate.AddDays(-7))
        oJob.SelectInstallerDataStartEnd(Me.DsTKSI1, currentStartDate)
        BuildWeek()
    End Sub

    Private Sub butAddJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddJob.Click
        Dim frmAddJob1 As New frmAddJob
        frmAddJob1.DsTKSI1 = Me.DsTKSI1
        frmAddJob1.ShowDialog()
        If frmAddJob1.OK Then
            LoadNewFormData()
        End If
    End Sub

    Private Sub butDeleteJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteJob.Click
        If Me.currentSelectedJob > 0 Then
            DeleteJob(currentSelectedJob)
        End If
    End Sub

    Private Sub DeleteJob(ByVal InstallerDateID As Long)
        Dim dr As dsTKSI.tblInstallerDatesRow
        dr = Me.DsTKSI1.tblInstallerDates.FindByID(InstallerDateID)
        If Not dr Is Nothing Then
            If Windows.Forms.MessageBox.Show("Are you sure you want to delete this installer job?", "Delete Installer Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dr.Delete()
                oJob.UpdateInstallerInfo(Me.DsTKSI1)

                Me.BuildWeek()
            End If
        Else
            Windows.Forms.MessageBox.Show("Could not locate installer job.")
        End If
    End Sub

    Private Sub lvDays_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDays.Click
        'if any cells were previously highlighted then change them back to orig color
        If Not IsNothing(Me.alSelectedItems) Then
            If Me.alSelectedItems.Count > 0 Then
                UnselectLastHighlightedCells()
            End If
        End If

        If Me.lvDays.SelectedItems.Count > 0 Then
            Me.lvDays.SelectedItems(0).Selected = False
        End If

        Dim objDraw As Point
        Dim itemtemp As ListViewItem
        objDraw = Me.lvDays.PointToClient(Cursor.Position)
        If Not IsNothing(objDraw) Then
            With objDraw
                itemtemp = Me.lvDays.GetItemAt(.X, .Y)
            End With
            If Not itemtemp Is Nothing Then
                currentSelectedJob = GetIDFromLVSubItem(itemtemp)
                HighlightJob(currentSelectedJob)
            End If
        End If
    End Sub

    Private currentSelectedJob As Long
    Private origColor As Color
    Private alSelectedItems As ArrayList

    Private Sub UnselectLastHighlightedCells()
        Dim subitem As ListViewItem.ListViewSubItem
        For Each subitem In alSelectedItems
            subitem.BackColor = origColor
            subitem.ForeColor = Color.Black
        Next
    End Sub
    Private Sub HighlightJob(ByVal ID As Long)
        Dim itemtemp As ListViewItem
        Me.alSelectedItems = New ArrayList

        For Each itemtemp In Me.lvDays.Items
            Dim subitem As ListViewItem.ListViewSubItem
            Dim blnFound As Boolean
            Dim updatedColor As Color
            'find all sub items in the entire listview that belong to this job
            'and color them a highlight for selected
            If GetIDFromLVSubItem(itemtemp) = ID Then
                For Each subitem In itemtemp.SubItems
                    If Len(subitem.Text) > 0 Then
                        blnFound = True
                        origColor = subitem.BackColor
                        updatedColor = Color.DarkBlue
                        subitem.BackColor = updatedColor
                        subitem.ForeColor = Color.White
                        Me.alSelectedItems.Add(subitem)
                    End If
                    If blnFound Then
                        If subitem.BackColor.ToArgb = origColor.ToArgb Then
                            subitem.BackColor = updatedColor
                            subitem.ForeColor = Color.White
                            Me.alSelectedItems.Add(subitem)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Function GetIDFromLVSubItem(ByVal itemtemp As ListViewItem) As Long
        'Dim id As Long
        Dim subitem As ListViewItem.ListViewSubItem
        For Each subitem In itemtemp.SubItems
            If Len(subitem.Text) > 0 Then
                If IsNumeric(Mid(subitem.Text, Len(subitem.Text) - 6)) Then
                    Return CLng(Mid(subitem.Text, Len(subitem.Text) - 6))
                End If
            End If
        Next

        Return 0
    End Function

    '  Private ledgendCount As Integer
    '  Private blnGoBackwards As Boolean

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Dim i As Integer
        'Try
        '    If ledgendCount > 55 Then
        '        blnGoBackwards = True
        '    ElseIf ledgendCount < -25 * CInt(Me.lvLedgend.Items.Count / 10) Then
        '        blnGoBackwards = False
        '    End If
        '    If Me.blnGoBackwards Then
        '        ledgendCount -= 1
        '    Else
        '        ledgendCount += 1
        '    End If
        '    Me.lvLedgend.Location = New System.Drawing.Point(690, ledgendCount - 50)

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub butEditJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditJob.Click
        If Me.currentSelectedJob > 0 Then
            Dim dr As dsTKSI.tblInstallerDatesRow
            dr = Me.DsTKSI1.tblInstallerDates.FindByID(Me.currentSelectedJob)
            If Not dr Is Nothing Then
                Dim frmJob As New frmAddJob
                'frmJob.DsTKSI1 = Me.DsTKSI1
                frmJob.EditMode = True
                frmJob.EditdrJob = dr
                frmJob.ShowDialog()
                If frmJob.OK Then
                    oJob.UpdateInstallerInfo(Me.DsTKSI1)
                    Me.LoadNewFormData()
                End If
            End If
        End If
    End Sub

    'Private Function WorkstationHasInternetAccess() As Boolean
    '    Try
    '        Select Case UCase(System.Environment.MachineName)
    '            'only these computers have internet access on port 80 for web services
    '        Case "JASON", "DOUG", "LINDA", "FRONT-DESK", "JEREMY", "TKSI 2K SERVER", "ORANGE1"
    '                Return True
    '            Case Else
    '                Return False
    '        End Select
    '    Catch ex As Exception
    '        Windows.Forms.MessageBox.Show("could not determine computer name. " & ex.Message)
    '        Return False
    '    End Try

    'End Function

    Private Function WebRecentlyUpdated() As Boolean
        If ISDebugMachine Then Return True
        'return true if a file exists and its recent , like less than an hour old
        Try
            Dim strReturn As String = ""
            Dim tksiWebService As New UpdateJobList
            strReturn = tksiWebService.GetLastWebSyncDate()
            Me.Text = "Installer Book by week (last web sync = " & strReturn & ")"
            Try
                If IsDate(strReturn) Then
                    If CDate(strReturn) > Now.AddHours(-0.5) Then
                        Return True
                    End If
                End If
            Catch ex As Exception
                Return False
            End Try


        Catch ex As Exception
            'Return False
        End Try

        Return False
    End Function

    Private Function GetWebInstallerBookDataAndUpdateLocalData(ByVal sxml As String, ByVal frmUserFeedBack As Form) As Boolean
        frmUserFeedBack.Text = "Retreving web xml data from the internet web server..."

        Try
            Dim ds1 As New dsWeb
            ds1.EnforceConstraints = False
            Try
                frmUserFeedBack.Text = "Reading pending changes submitted by installers..."
                Dim sr As New IO.StringReader(sxml)
                ds1.ReadXml(sr)
            Catch ex As Exception
                'Windows.Forms.MessageBox.Show("Failed to read installer temp file into memory ... " & ex1.Message)
                Return False
            End Try

            Dim dra() As dsWeb.JobsRow

            'find new blackout dates entered by web users
            Dim i As Long
            dra = ds1.Jobs.Select(ds1.Jobs.Detail5Column.ColumnName.ToString & " ='pending'")
            If dra.Length > 0 Then
                'create jobs in local installer book database to show these web created "installer not available" entries
                For i = 0 To dra.Length - 1
                    Dim drDate As dsTKSI.tblInstallerDatesRow
                    drDate = Me.DsTKSI1.tblInstallerDates.NewtblInstallerDatesRow
                    With drDate
                        .DateStart = dra(i).JobDate
                        .InstallerID = dra(i).InstallerID
                        .Customer = ""
                        .DateEnd = .DateStart.Date.AddHours(23.9)
                        .jobaddress = "INSTALLER NOT AVAILABLE"
                        .sales = ""
                        .other = ""
                        .sJobNum = ""

                    End With

                    Dim drTestInstallerExists As dsTKSI.tblInstallerRow
                    drTestInstallerExists = Me.DsTKSI1.tblInstaller.FindByID(drDate.InstallerID)
                    If Not drTestInstallerExists Is Nothing Then
                        Me.DsTKSI1.tblInstallerDates.Rows.Add(drDate)
                    Else
                        'there is no longer an installer with that ID code, so ignore, dont add to table
                    End If

                Next

                oJob.UpdateInstallerInfo(Me.DsTKSI1)
            End If

            Try
                'remove all duplicate entries created by web user
                'anything with "installer not available" is the only known time this happens
                'if there is a real job that conflicts with a "installer not available" then
                'just leave it
                Dim drDate As dsTKSI.tblInstallerDatesRow

                'Me.DsTKSI1.tblInstallerDates.Clear()
                'Me.daDates.Fill(Me.DsTKSI1.tblInstallerDates)

                Dim lastStart As String = ""
                Dim lastEnd As String = ""
                Dim lastInstaller As String = ""
                Dim lastJobAddress As String = ""

                Dim thisStart As String = ""
                Dim thisEnd As String = ""
                Dim thisInstaller As String = ""
                Dim thisJobAddress As String = ""

                For Each drDate In Me.DsTKSI1.tblInstallerDates

                    With drDate
                        thisInstaller = .InstallerID.ToString
                        thisStart = .DateStart.ToShortDateString '& " " & .DateStart.ToShortTimeString
                        thisEnd = .DateEnd.ToShortDateString '& " " & .DateEnd.ToShortTimeString
                        thisJobAddress = .jobaddress
                    End With

                    If UCase(thisInstaller) = UCase(lastInstaller) And _
                    thisStart = lastStart And thisEnd = lastEnd And _
                    UCase(thisJobAddress) = UCase(lastJobAddress) Then
                        'delete it because its the exact same job being shown twice for the exact same installer 
                        'with the exact same start and end date
                        drDate.Delete()
                        'dont load lastInstaller data with deleted row, causes exception
                    Else
                        lastJobAddress = drDate.jobaddress
                        lastInstaller = drDate.InstallerID.ToString
                        lastStart = drDate.DateStart.ToShortDateString '& " " & drdate.DateStart.ToShortTimeString
                        lastEnd = drDate.DateEnd.ToShortDateString '& " " & drdate.DateEnd.ToShortTimeString
                        '
                    End If

                Next

                oJob.UpdateInstallerInfo(Me.DsTKSI1)

            Catch ex As Exception
                Me.Text = ("Error while removing duplicate installer book entries.  " & ex.Message)
            End Try

        Catch ex As Exception
            'Windows.Forms.MessageBox.Show("GetWebInstallerBookDataAndUpdateLocalData2 ... " & ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub BuildWebDataFromLocalDataAndSendToWebServer(ByVal frmUserFeedBack As Form)
        Try
            frmUserFeedBack.Text = "Building web xml data file from local database...."
            Dim ds1 As New dsTKSI
            ds1.EnforceConstraints = False

            oJob.SelectAllInstallerData(Me.DsTKSI1)

            Dim drInstaller As dsTKSI.tblInstallerRow
            Dim drJobDates As dsTKSI.tblInstallerDatesRow
            Dim dsWeb1 As New dsWeb
            dsWeb1.EnforceConstraints = False

            For Each drInstaller In Me.DsTKSI1.tblInstaller
                Dim dr As dsWeb.InstallerRow
                dr = dsWeb1.Installer.NewInstallerRow
                dr.ID = drInstaller.ID
                dr.Name = drInstaller.Name
                dr.username = drInstaller.username
                dr.password = drInstaller.password
                dsWeb1.Installer.Rows.Add(dr)
            Next
            dsWeb1.Installer.AcceptChanges()

            Dim lastStart As String = ""
            Dim lastEnd As String = ""
            Dim lastInstaller As String = ""
            Dim lastJobAddress As String = ""

            Dim thisStart As String = ""
            Dim thisEnd As String = ""
            Dim thisInstaller As String = ""
            Dim thisJobAddress As String = ""

            For Each drJobDates In Me.DsTKSI1.tblInstallerDates

                thisInstaller = drJobDates.InstallerID.ToString
                thisStart = drJobDates.DateStart.ToShortDateString '& " " & drJobDates.DateStart.ToShortTimeString
                thisEnd = drJobDates.DateEnd.ToShortDateString '& " " & drJobDates.DateEnd.ToShortTimeString
                thisJobAddress = drJobDates.jobaddress

                If UCase(thisInstaller) = UCase(lastInstaller) And _
                thisStart = lastStart And thisEnd = lastEnd _
                And UCase(thisJobAddress) = UCase(lastJobAddress) Then
                    'dont send this job to web because its an exact dup of the previous job processed by this loop
                Else
                    'possibly send this job to web
                    'only send future and present jobs to web
                    If drJobDates.DateEnd >= Today.Date Then
                        Dim dr As dsWeb.JobsRow
                        dr = dsWeb1.Jobs.NewJobsRow
                        With dr
                            .gID = Guid.NewGuid
                            .JobDate = drJobDates.DateStart.ToShortDateString
                            .jobEnd = drJobDates.DateEnd.ToShortDateString
                            .InstallerID = drJobDates.InstallerID
                            Try
                                'detail 5 first , it's important because it should have 'pending' or empty, no nulls
                                .Detail5 = ""
                                .Detail1 = drJobDates.jobaddress
                                .Detail2 = drJobDates.sales
                                .Detail3 = drJobDates.Customer

                                .Detail4 = drJobDates.sJobNum

                            Catch ex As Exception
                            End Try

                        End With
                        dsWeb1.Jobs.Rows.Add(dr)
                    End If
                End If

                lastInstaller = drJobDates.InstallerID.ToString
                lastStart = drJobDates.DateStart.ToShortDateString '& " " & drJobDates.DateStart.ToShortTimeString
                lastEnd = drJobDates.DateEnd.ToShortDateString '& " " & drJobDates.DateEnd.ToShortTimeString
                lastJobAddress = drJobDates.jobaddress

            Next

            dsWeb1.Jobs.AcceptChanges()

            Dim strUpload As String = ""
            Dim downloadFromWeb As String = ""

            strUpload = dsWeb1.GetXml

            Dim xUpload As New UpdateJobList
            downloadFromWeb = xUpload.UploadJobs(strUpload)
            If UCase(downloadFromWeb) <> "FALSE" Then
                GetWebInstallerBookDataAndUpdateLocalData(downloadFromWeb, frmUserFeedBack)
            End If

        Catch ex As Exception
            'Windows.Forms.MessageBox.Show("BuildWebDataFromLocalDataAndSendToWebServer error... " & ex.Message)
        End Try

    End Sub

    Private Sub UpdateWeb()
        Dim frmbusy1 As New frmWorking
        frmbusy1.Text = frmbusy1.Text & " Updating Web..."
        frmbusy1.Show()
        Try
            BuildWebDataFromLocalDataAndSendToWebServer(frmbusy1)
            WebRecentlyUpdated()
            Me.BuildWeek()
        Catch ex As Exception
            'internet probably not available' Windows.Forms.MessageBox.Show("mnuUpdate error... " & ex.Message)
        Finally
            frmbusy1.Close()
        End Try
    End Sub

    'Private Sub mnuUpdateWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'If WorkstationHasInternetAccess() Then
    '    UpdateWeb()
    '    'End If

    'End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'If Me.WorkstationHasInternetAccess Then
        If Not WebRecentlyUpdated() Then
            UpdateWeb()
        End If
        'End If
    End Sub

    Private Sub btnUpdateWeb_Click(sender As Object, e As EventArgs) Handles btnUpdateWeb.Click
        UpdateWeb()
    End Sub
End Class
