Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmScheduleJobs

    Dim _imgGrip As Bitmap
    Dim _imgOpen As Bitmap
    Dim _imgClose As Bitmap
    Dim _font As Font

    Private csGreen As CellStyle
    Private csYellow As CellStyle
    Private csWhite As CellStyle
    Private csOrange As CellStyle
    Private csBlue As CellStyle

    'each time a new job is shown, user must select a date on calender before you can schedule a job
    'to avoid dragging job onto whichever date is shown without thinking about the date that needs to be selected first
    Private blnAllowJobSchedule As Boolean = False
    Private intJobCurrentlySelected As Integer = 0

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'ds1.tVendor' table. You can move, or remove it, as needed.
        Me.Location = New Point(1, 1)
        Dim iwidth As Integer = global_ScreenWidth
        If iwidth > 1600 Then iwidth = 1600
        Dim iHeight As Integer = global_ScreenHeight - 30
        If iHeight > 1000 Then
            iHeight -= 100
        End If

        Me.Size = New Point(iwidth - 70, iHeight)

        Me.C1Sizer2.Grid.Columns(1).Size = 918
        Me.C1Sizer2.Grid.Columns(2).Size = 0
        Me.C1Sizer2.Grid.Columns(0).Size = 390

        _font = New Font("Tahoma", 8, FontStyle.Bold)
        _imgGrip = CType(pictureBox5.Image, Bitmap)
        _imgOpen = CType(pictureBox6.Image, Bitmap)
        _imgClose = CType(pictureBox7.Image, Bitmap)
        _imgOpen.MakeTransparent(Color.Red)
        _imgClose.MakeTransparent(Color.Red)

        csWhite = Me.flexNeedAttention.Styles.Add("White")
        csWhite.BackColor = Color.White

        csGreen = Me.flexNeedAttention.Styles.Add("Green")
        csGreen.BackColor = Color.LightGreen

        csYellow = Me.flexNeedAttention.Styles.Add("Yellow")
        csYellow.BackColor = Color.Yellow

        csOrange = Me.flexNeedAttention.Styles.Add("Orange")
        csOrange.BackColor = Color.LightSalmon

        csBlue = Me.flexNeedAttention.Styles.Add("Blue")
        csBlue.BackColor = Color.LightBlue

        LoadFlexGrids()

    End Sub

    Private Sub SetupFlexGridColumns()
        With Me.flexNeedAttention
            .AllowDragging = AllowDraggingEnum.Rows
            '.Rows.Count = 0
            .Cols.Count = 6
            .Cols(0).Visible = False
            .Cols(0).Width = 0
            .Cols(0).AllowMerging = True

            .Cols(1).Visible = False
            .Cols(1).Width = 0
            .Cols(1).AllowMerging = True

            .Cols(2).Width = 70

            .Cols(3).Width = 70

            .Cols(4).Width = 300
            .ShowErrors = True
        End With
        With Me.flexOnHold
            .AllowDragging = AllowDraggingEnum.Rows
            .Rows.Count = 0
            .Cols.Count = 5
            .Cols(0).Visible = False
            .Cols(0).Width = 0
            .Cols(0).AllowMerging = True

            '.Cols(0).Style = .Cols(0).StyleFixed
            .Cols(1).Width = 70
            .Cols(1).AllowMerging = True
            .Cols(2).Width = 70
            .Cols(4).Width = 300

            .AllowMerging = AllowMergingEnum.Free
        End With

        With Me.flexSWO
            .AllowDragging = AllowDraggingEnum.Rows
            .Rows.Count = 0
            .Cols.Count = 5
            .Cols(0).Visible = False
            .Cols(0).Width = 0
            '.Cols(0).Style = .Cols(0).StyleFixed
            .Cols(1).Width = 70
            .Cols(1).AllowMerging = True
            .Cols(2).Width = 70
            .Cols(4).Width = 300
            .AllowMerging = AllowMergingEnum.Free
        End With

        With Me.flexSearch
            .AllowDragging = AllowDraggingEnum.Rows
            '.Rows.Count = 0
            .Cols.Count = 6
            .Cols(0).Visible = False
            .Cols(0).Width = 0
            .Cols(0).AllowMerging = True
            .Cols(1).Width = 70
            .Cols(2).Width = 70
            .Cols(3).Width = 70
            .Cols(4).Width = 120
            .ShowErrors = True
        End With
    End Sub

    Private alJobsGoingOnFlexGrid As New ArrayList

    Private Class JobOnFlexGrid
        Public sJobNo As String = ""
        Public nJobID As Integer = -1
        Public flexToUse As C1FlexGrid
        Public sDateReq As String = ""
        Public sCurrAccounts As String = ""
        Public sCustomer As String = ""
        Public sRowError As String = ""
        Public blnWaitingOnAnotherJob As String = ""
        Public sJobWaitingOn As String = ""
        Public blnVendorIgnore As Boolean = False
        Public sJobType As String = ""  'SWO OR PO OR JOBCOST etc.
        Public blnInstallerBookConflict As Boolean = False
    End Class

    Private Sub LoadFlexGrids()

        Me.TPOHeaderTableAdapter1.FillByDDelNullBackorderYes(Me.ds1.tPOHeader)
        Me.TJobTableAdapter1.FillByDDELnullBackorderYes(Me.ds1.tJob)
        Me.TCustomrTableAdapter.Fill(Me.ds1.tCustomr)
        Me.TVendorTableAdapter.Fill(Me.ds1.tVendor)
        Me.TblActivityTypeTableAdapter1.Fill(Me.ds1.tblActivityType)
        Me.TblJobActivityTableAdapter1.FillBy(Me.ds1.tblJobActivity)
        Me.AppointmentsTableAdapter1.FillBylast30days(Me.ds1.Appointments)
        Me.TAddressTableAdapter1.FillByALL(Me.ds1.tAddress)
        Me.TblInstallerDatesTableAdapter1.FillByRecentWithJobNo(Me.ds1.tblInstallerDates)
        'Me.flexNeedAttention.DataSource = Me.ds1.tPOHeader

        SetupFlexGridColumns()

        Dim sSameAddressJob As String = ""
        Dim sSameAddressJobScheduleDate As Date

        ' Dim flexPreviuos As C1FlexGrid
        'Dim dtNeeds As New TKSIJOBSDataSet.dtAttentionGridDataTable
        Dim drJ As TKSIJOBSDataSet.tJobRow

        alJobsGoingOnFlexGrid.Clear()

        For Each drJ In Me.ds1.tJob

            sSameAddressJob = ""
            sSameAddressJobScheduleDate = CDate("1/1/1999")

            Try
                Dim sJob5 As String = Mid(drJ.sJobNo, 1, 6)
                Dim nextJobDigit As String
                If IsNumeric(sJob5) Then
                    'leave as 6 digit for folder/file creation
                ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                    sJob5 = Mid(sJob5, 1, 5)
                Else
                    sJob5 = Mid(sJob5, 1, 4)
                End If

                Dim draOtherJobs As TKSIJOBSDataSet.tJobRow()
                draOtherJobs = Me.ds1.tJob.Select("sJobNo like '" & sJob5 & "%'")
                Dim drJ1 As TKSIJOBSDataSet.tJobRow
                For Each drJ1 In draOtherJobs
                    If drJ1.sJobNo <> drJ.sJobNo Then
                        If sJob5.Length = 5 Then
                            nextJobDigit = Mid(drJ1.sJobNo, 6, 1)
                        Else
                            nextJobDigit = Mid(drJ1.sJobNo, 5, 1)
                        End If

                        sSameAddressJob = " (" & nextJobDigit & ")"
                        If drJ1.GetAppointmentsRows.Length > 0 Then
                            sSameAddressJobScheduleDate = drJ1.GetAppointmentsRows(0).Start
                        Else
                            '1999 signifies this job has no appointments
                            sSameAddressJobScheduleDate = CDate("1/1/1999")
                        End If
                    End If
                Next
            Catch ex As Exception
                sSameAddressJob = " (error)"
                sSameAddressJobScheduleDate = CDate("1/1/1999")
            End Try

            'If drJ.sJobNo = "2161H" Then
            '    Stop
            'End If
            'default the entire job to true as all PO received
            'if any PO is not recieved then entire job is not received

            Dim blnPOreceived As Boolean = True

            Dim blnJobScheduled As Boolean = False

            Dim sJobType As String = ""
            Dim dSoonestDateRequired As Date = CDate("1/1/2999")
            Dim sCurAccountNotes As String = ""
            Dim drH As TKSIJOBSDataSet.tPOHeaderRow

            Dim drActivity As TKSIJOBSDataSet.tblJobActivityRow
            Dim draActivity As TKSIJOBSDataSet.tblJobActivityRow()

            Dim blnSpecialDeliverPOs As Boolean = False
            draActivity = Me.ds1.tblJobActivity.Select("njobid=" & drJ.nID, "dateentered desc")
            For Each drActivity In draActivity
                If UCase(drActivity.ActivityType) = UCase("Special Delivery Needs") Then
                    blnSpecialDeliverPOs = True
                End If
            Next

            'each job has several POs all of which can have individual dates required and notes
            'but we want to show an accumlation since they are genearly all the same date and notes
            'usually pertain to the entire job


            sJobType = "NORMAL"
            Dim blnAllPOAreSWO As Boolean = True
            Dim blnPartsPOReceivedForSWO As Boolean = True
            For Each drH In drJ.GettPOHeaderRows
                Dim blnThisPOisSWO As Boolean = False
                'need to flag if this particular PO is an SWO even if the whole job is already flagged as SWO

                If Mid(drH.sPOType, 1, 3) = "SWO" Then
                    sJobType = "SWO"
                    blnThisPOisSWO = True
                Else
                    blnAllPOAreSWO = False
                End If
                If drH.sCurActNote.Trim.Length > 0 Then
                    sCurAccountNotes = sCurAccountNotes & " " & drH.sCurActNote
                End If
                If drH.dRequired < dSoonestDateRequired Then
                    dSoonestDateRequired = drH.dRequired
                End If
                If drH.IsDRECNull Then
                    blnPOreceived = False
                End If
                If drH.IsDRECNull And (Not blnThisPOisSWO) Then
                    'keep track if all PO are received except the SWO PO (which never has parts)
                    'if the entire job is not an SWO this code will still flag but wont get used for anything
                    blnPartsPOReceivedForSWO = False
                End If
            Next

            Dim blnHasCabinetry As Boolean = False
            For Each drH In drJ.GettPOHeaderRows
                If drH.nAccount = 4010 And sJobType <> "SWO" Then
                    blnHasCabinetry = True
                    If Not blnSpecialDeliverPOs Then
                        'use the cabinetry PO as the soonest date even though there may be other required dates that are sooner
                        dSoonestDateRequired = drH.dRequired
                    Else
                        'continue with the earliest date that was found
                    End If
                    'if cabinetry is here, then show job as received even if other POs are not here
                    If Not drH.IsDRECNull Then
                        blnPOreceived = True
                    End If
                End If
            Next

            Dim sDateReq As String = ""
            sDateReq = dSoonestDateRequired.Month & "/" & dSoonestDateRequired.Day

            Dim sCustomer As String = ""
            If Not drJ.tCustomrRow Is Nothing Then
                sCustomer = drJ.tCustomrRow.sName
            End If

            'examine all activity, the most recent activity that is also flagged to create remind should be examined
            'to see if day has come for job to be moved to reminder list.

            Dim flexToUse As C1FlexGrid

            'default to needs attention unless specificaly has activity that does not need
            If (dSoonestDateRequired.AddDays(0) < Today.Date) Or (sJobType = "SWO" And blnPartsPOReceivedForSWO) Then
                flexToUse = Me.flexNeedAttention
            Else
                If sJobType = "SWO" Then
                    flexToUse = Me.flexSWO
                Else
                    flexToUse = Me.flexSWO
                End If
            End If

            If blnAllPOAreSWO Then
                flexToUse = Me.flexNeedAttention
            End If

            Dim blnWaitingOnAnotherJob As Boolean = False
            Dim sJobWaitingOn As String = ""
            Dim blnBackOrderAlreadyHandled As Boolean = False

            For Each drActivity In draActivity ' drJ.GettblJobActivityRows

                If UCase(drActivity.ActivityType) = "CREDIT" Or UCase(drActivity.ActivityType) = "FINDERS FEE" Then
                    blnJobScheduled = True
                    flexToUse = Me.flexSWO
                    Exit For
                End If

                If UCase(drActivity.ActivityType.Trim) = "WAITING ON ANOTHER JOB" Then
                    blnWaitingOnAnotherJob = True
                    sJobWaitingOn = Replace(UCase(drActivity.ActivityDetail), "WAITING ON ANOTHER JOB", "").Trim
                End If

                If drActivity.ActivityDetail.Trim.ToUpper = "BO HANDLED" Then
                    blnBackOrderAlreadyHandled = True
                End If

                'For Each drActivity In drJ.GettblJobActivityRows
                If Not drActivity.tblActivityTypeRow Is Nothing Then
                    If drActivity.tblActivityTypeRow.CauseReminder = True Then
                        If (drActivity.dateEntered.AddDays(drActivity.tblActivityTypeRow.DaysToWait).Date <= Today.Date) Then
                            'last activity is expired, so "on hold" status is implicitly removed
                        Else
                            'there has been activity on this job telling us
                            'it doesnt need attention for some more days still
                            flexToUse = Me.flexOnHold
                        End If
                        If drActivity.tblActivityTypeRow.DaysToWait = 0 Then
                            'last action says place in needs attention forever, until new activity is created or job is scheduled
                            flexToUse = Me.flexNeedAttention
                        End If

                        'if specific call back date was set then check to see if we have arrived at that date
                        Try
                            If InStr(UCase(drActivity.ActivityDetail), "CALL BACK") > 0 Then
                                If drActivity.ActivityDetail.Length > 10 Then
                                    If IsDate(Replace(UCase(drActivity.ActivityDetail), "CALL BACK", "").Trim) Then
                                        If CDate(Replace(UCase(drActivity.ActivityDetail), "CALL BACK", "").Trim).Date <= Today.Date Then
                                            flexToUse = Me.flexNeedAttention
                                        Else
                                            flexToUse = Me.flexOnHold
                                        End If
                                    End If
                                End If

                            End If
                        Catch ex As Exception
                        End Try

                        Exit For
                    End If
                End If

            Next

            'if the only undelivered PO on this job is a vendor which is not-applicable, like Denver Glass, then ignore entire job, do not put on needs attention
            Dim blnVendorIgnore As Boolean = False
            For Each drH In drJ.GettPOHeaderRows
                If drH.IsDDELNull Then
                    If drH.tVendorRow.IgnoreScheduling Then
                        blnVendorIgnore = True
                    Else
                        'if there is even one PO not delivered that is a valid vendor then abort this whole loop
                        blnVendorIgnore = False
                        Exit For
                    End If
                End If
            Next
            If blnVendorIgnore Then
                'actually dont put it on the list at all
                flexToUse = Me.flexSWO
            End If

            'if the only undelivered PO on this job is a vendor which is not-applicable, like Denver Glass, then ignore entire job, do not put on needs attention
            Dim blnBOonPO As Boolean = False
            For Each drH In drJ.GettPOHeaderRows
                If drH.sBackOrder = "Yes" Then
                    blnBOonPO = True
                    Exit For
                End If
            Next
            If blnBOonPO And (Not blnBackOrderAlreadyHandled) Then
                flexToUse = Me.flexNeedAttention
            End If

            Dim blnJobScheduleInPast As Boolean = False
            'its already scheduled so dont show in needs attention
            If drJ.GetAppointmentsRows.Length > 0 Then
                Dim drApp1 As TKSIJOBSDataSet.AppointmentsRow
                For Each drApp1 In drJ.GetAppointmentsRows
                    If drApp1.Start > Today.AddDays(-1) Then
                        blnJobScheduled = True
                        flexToUse = Me.flexSWO
                    Else
                        blnJobScheduleInPast = True
                    End If
                Next
            End If

            Dim blnInstallerBookConflict As Boolean = False
            Dim drInstaller As TKSIJOBSDataSet.tblInstallerDatesRow
            For Each drInstaller In Me.ds1.tblInstallerDates
                If UCase(Mid(drInstaller.sJobNum, 1, 5)) = UCase(drJ.sJobNo) Then
                    If drInstaller.DateStart < Today.Date.AddDays(8) Then
                        'installer date is coming soon
                        'if we dont have product then flag even if the job is scheduled
                        If Not blnPOreceived Then
                            flexToUse = Me.flexNeedAttention
                            blnInstallerBookConflict = True
                        End If
                    End If
                    If drInstaller.DateStart < Today.Date.AddDays(3) Then
                        'installer date is coming NOW
                        'even if we have the product here, if there is nothing the schedule then flag
                        If Not blnJobScheduled Then
                            flexToUse = Me.flexNeedAttention
                            blnInstallerBookConflict = True
                        End If
                    End If
                End If
            Next

            Dim strJob As String
            strJob = drJ.sJobNo & sSameAddressJob
            If drJ.GetAppointmentsRows.Length > 0 Then
                sDateReq = sDateReq & " - " & drJ.GetAppointmentsRows(0).Start.Month & "/" & drJ.GetAppointmentsRows(0).Start.Day
            End If
            Try
                'if there are other jobs with same address then show the dates they are scheduled
                If sSameAddressJob.Length > 0 Then
                    If "1999" <> sSameAddressJobScheduleDate.Year Then
                        sDateReq = sDateReq & " (" & sSameAddressJobScheduleDate.Month & "/" & sSameAddressJobScheduleDate.Day & ")"
                    End If
                End If
            Catch ex As Exception
            End Try

            Dim JobOnFlexGrid1 As New JobOnFlexGrid
            With JobOnFlexGrid1
                .nJobID = drJ.nID
                .sJobNo = drJ.sJobNo & sSameAddressJob
                .blnVendorIgnore = blnVendorIgnore
                .flexToUse = flexToUse
                .sDateReq = sDateReq
                .blnInstallerBookConflict = blnInstallerBookConflict


                If blnInstallerBookConflict Then
                    .sCustomer = "(INST) " & sCustomer
                Else
                    .sCustomer = sCustomer
                End If

                If blnBOonPO Then
                    .sCustomer = "(BO) " & sCustomer
                End If

                .sCurrAccounts = sCurAccountNotes

                If dSoonestDateRequired < Today.Date.AddDays(-2) And flexToUse Is Me.flexNeedAttention And blnPOreceived Then
                    .sRowError = "overdue"
                End If
                If blnJobScheduleInPast Then
                    .sRowError = "Date Past"
                End If
                .sJobType = sJobType

                .blnWaitingOnAnotherJob = blnWaitingOnAnotherJob
                .sJobWaitingOn = sJobWaitingOn

            End With

            Me.alJobsGoingOnFlexGrid.Add(JobOnFlexGrid1)

        Next

        PopulateFlexGridFromArraylist()

    End Sub

    Private Sub PopulateFlexGridFromArraylist()

        Dim dtNeeds As New TKSIJOBSDataSet.dtAttentionGridDataTable
        Dim JobOnFlexGrid1 As JobOnFlexGrid

        For Each JobOnFlexGrid1 In Me.alJobsGoingOnFlexGrid
            With JobOnFlexGrid1
                If Not .blnVendorIgnore Then

                    If .blnWaitingOnAnotherJob Then
                        'figure out if the other job is also marked as needs attention, if so then show both together in needs attention
                        Dim JobOnFlexGrid2 As JobOnFlexGrid
                        '    Dim blnWaitingJobFound As Boolean = False
                        For Each JobOnFlexGrid2 In Me.alJobsGoingOnFlexGrid
                            'Dim sJob5 As String = Mid(JobOnFlexGrid2.sJobNo, 1, 6)
                            'If IsNumeric(Mid(sJob5, 1, 5)) Then
                            '    'leave as 6 digit with job and letter
                            'Else
                            '    'job number and letter is really only 5 digit total
                            '    sJob5 = Mid(sJob5, 1, 5)
                            'End If

                            Dim sJob5 As String = Mid(JobOnFlexGrid2.sJobNo, 1, 7)
                            If IsNumeric(Mid(sJob5, 1, 6)) Then
                                'leave as 7 digit with letter on end
                            ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                                sJob5 = Mid(sJob5, 1, 6)
                            Else
                                sJob5 = Mid(sJob5, 1, 5)
                            End If

                            If .sJobWaitingOn = sJob5 Then
                                ' blnWaitingJobFound = True
                                'if the other job is in needs attention them move this one in there also
                                If JobOnFlexGrid2.flexToUse Is Me.flexNeedAttention Then
                                    JobOnFlexGrid1.flexToUse = Me.flexNeedAttention
                                Else
                                    JobOnFlexGrid1.flexToUse = Me.flexOnHold
                                End If
                            End If
                        Next
                        'If Not blnWaitingJobFound Then
                        '    'this job is waiting on another job but
                        'End If
                    End If

                    If .flexToUse Is Me.flexNeedAttention Then

                        Dim dr As TKSIJOBSDataSet.dtAttentionGridRow
                        dr = dtNeeds.NewdtAttentionGridRow
                        dr.NID = .nJobID

                        'Dim sJob5 As String = Mid(.sJobNo, 1, 5)
                        'If IsNumeric(sJob5) Then
                        '    'leave as 5 digit for folder/file creation
                        'Else
                        '    sJob5 = Mid(sJob5, 1, 4)
                        'End If

                        Dim sJob5 As String = Mid(.sJobNo, 1, 6)
                        If IsNumeric(sJob5) Then
                            'leave as 6 digit for folder/file creation
                        ElseIf IsNumeric(Mid(sJob5, 1, 5)) Then
                            sJob5 = Mid(sJob5, 1, 5)
                        Else
                            sJob5 = Mid(sJob5, 1, 4)
                        End If

                        dr.sJobNoShort = sJob5
                        dr.sJobNo = .sJobNo
                        dr.sDateReq = .sDateReq
                        dr.sCurAccountNotes = .sCurrAccounts
                        dr.sCustomer = .sCustomer

                        If .sRowError.Length > 0 Then
                            dr.RowError = .sRowError
                            dr.SetColumnError(1, "overdue")
                        End If

                        dtNeeds.Rows.Add(dr)

                    Else

                        .flexToUse.AddItem(.nJobID & ControlChars.Tab & .sJobNo & ControlChars.Tab & .sDateReq & ControlChars.Tab & .sCurrAccounts & ControlChars.Tab & .sCustomer)

                        If .sJobType = "SWO" Then
                            .flexToUse.Rows(.flexToUse.Rows.Count - 1).Style = csGreen
                        Else
                            .flexToUse.Rows(.flexToUse.Rows.Count - 1).Style = csWhite
                        End If

                    End If

                Else
                    'vendor ignore do nothing
                End If
            End With

        Next

        With Me.flexNeedAttention
            .DataSource = dtNeeds
            .ShowErrors = True
            .ShowCursor = True
            .Cols(0).Width = 0
            .Cols(1).Width = 0
            .Cols(1).AllowMerging = True
            .AllowMerging = AllowMergingEnum.RestrictRows
        End With

        Me.flexNeedAttention.Cols.Item(4).Visible = False
    End Sub


    Private Sub LoadJobCommunication(ByVal nJobID As Integer)
        Try
            If Me.intJobCurrentlySelected <> nJobID Then
                Me.blnAllowJobSchedule = False
            End If

            Dim drJ As TKSIJOBSDataSet.tJobRow
            drJ = Me.ds1.tJob.FindBynID(nJobID)
            If drJ Is Nothing Then
                Me.TJobTableAdapter1.FillByNID(Me.ds1.tJob, nJobID)
                drJ = Me.ds1.tJob(0)
            
            End If

            Me.CtrJobComm1.LoadJob(drJ.nID)

            nJOBSelected = drJ.nID
            nAddressSelected = drJ.nAddressID

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error on LoadJobComm : " & ex.Message)
        End Try

    End Sub

    Private Sub btnShowSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSchedule.Click
       Me.C1Sizer2.Grid.Columns(2).Size = 950
        Me.C1Sizer2.Grid.Columns(1).Size = 0
        Me.C1Sizer2.Grid.Columns(0).Size = 290
    End Sub

    Private Sub btnShowJobComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowJobComm.Click
        Me.C1Sizer2.Grid.Columns(1).Size = 918
        Me.C1Sizer2.Grid.Columns(2).Size = 0
        Me.C1Sizer2.Grid.Columns(0).Size = 350
    End Sub

    Private Sub C1Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.SelectionChangedEventArgs) Handles C1Calendar1.SelectionChanged
        Me.blnAllowJobSchedule = True
        With Me.CtrFullSchedule1
            .C1Schedule1.ShowDates(Me.C1Calendar1.SelectedDates)
            .C1Schedule2.ShowDates(Me.C1Calendar1.SelectedDates)
            .C1Schedule3.ShowDates(Me.C1Calendar1.SelectedDates)
            .C1Schedule4.ShowDates(Me.C1Calendar1.SelectedDates)
            .C1Schedule5.ShowDates(Me.C1Calendar1.SelectedDates)
        End With
    End Sub

    Private Sub flexNeedAttention_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flexNeedAttention.MouseDown
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then
                If Me.blnAllowJobSchedule Then
                    Me.flexNeedAttention.DoDragDrop(Me.flexNeedAttention.Clip, DragDropEffects.Copy)
                Else
                    Me.flexNeedAttention.DoDragDrop(Me.flexNeedAttention.Clip, DragDropEffects.None)
                End If
            End If
            With Me.flexNeedAttention
                Dim nJobID As Integer
                nJobID = .Rows(.RowSel)(0)
                If nJobID > 0 Then
                    nJOBSelected = nJobID
                    LoadJobCommunication(nJobID)
                End If
            End With

        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub flexSearch_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flexSearch.MouseDown
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then
                If Me.blnAllowJobSchedule Then
                    Me.flexSearch.DoDragDrop(Me.flexSearch.Clip, DragDropEffects.Copy)
                Else
                    Me.flexSearch.DoDragDrop(Me.flexSearch.Clip, DragDropEffects.None)
                End If
            End If

            With Me.flexSearch
                Dim nJobID As Integer
                nJobID = .Rows(.RowSel)(0)
                If nJobID > 0 Then
                    LoadJobCommunication(nJobID)
                End If
            End With
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub flexOnHold_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flexOnHold.MouseDown
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then
                If Me.blnAllowJobSchedule Then
                    Me.flexOnHold.DoDragDrop(Me.flexOnHold.Clip, DragDropEffects.Copy)
                Else
                    Me.flexOnHold.DoDragDrop(Me.flexOnHold.Clip, DragDropEffects.None)
                End If
            End If

            With Me.flexOnHold
                Dim nJobID As Integer
                nJobID = .Rows(.RowSel)(0)
                If nJobID > 0 Then
                    nJOBSelected = nJobID
                    LoadJobCommunication(nJobID)
                End If
            End With
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private nJOBSelected As Integer = 0
    Private nAddressSelected As Integer = 0

    Private Sub flexSWO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles flexSWO.MouseDown
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then
                If Me.blnAllowJobSchedule Then
                    Me.flexSWO.DoDragDrop(Me.flexSWO.Clip, DragDropEffects.Copy)
                Else
                    Me.flexSWO.DoDragDrop(Me.flexSWO.Clip, DragDropEffects.None)
                End If
            End If

            With Me.flexSWO
                Dim nJobID As Integer
                nJobID = .Rows(.RowSel)(0)
                If nJobID > 0 Then
                    LoadJobCommunication(nJobID)
                End If
            End With
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub C1Calendar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Calendar1.Click
        Me.blnAllowJobSchedule = True
    End Sub

    Private Sub mnuMarkDelivered_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        Select Case e.ContextInfo.Source.Name
            Case "flexNeedAttention"
                With Me.flexNeedAttention
                    Dim nJobID As Integer
                    nJobID = .Rows(.RowSel)(0)
                    If nJobID > 0 Then
                        'LoadJobCommunication(nJobID)
                    End If
                End With

            Case Else

        End Select
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadFlexGrids()
        Me.CtrFullSchedule1.RefreshAppointments()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Me.flexSearch.Rows.Count = 0

            If Me.txtSearch.Text.Trim.Length > 3 Then
                Me.TJobTableAdapter1.FillByLikeJobno(Me.ds1.tJob, Me.txtSearch.Text.Trim & "%")
                If Me.ds1.tJob.Rows.Count > 0 Then
                    Dim drJ As TKSIJOBSDataSet.tJobRow
                    For Each drJ In Me.ds1.tJob
                        Me.TPOHeaderTableAdapter1.FillByNJOBID(Me.ds1.tPOHeader, drJ.nID)
                        Dim sDateReq As String = ""
                        If drJ.GettPOHeaderRows.Length > 0 Then
                            sDateReq = drJ.GettPOHeaderRows(0).dRequired.Month & "/" & drJ.GettPOHeaderRows(0).dRequired.Day
                        End If

                        Dim sCustomer As String = ""
                        If Not drJ.tCustomrRow Is Nothing Then
                            sCustomer = drJ.tCustomrRow.sName
                        End If

                        Dim strAdd As String = drJ.nID & ControlChars.Tab & drJ.sJobNo & ControlChars.Tab & sDateReq & ControlChars.Tab
                        strAdd = String.Concat(strAdd, sCustomer & ControlChars.Tab & drJ.tAddressRow.sAddress1)
                        Me.flexSearch.AddItem(strAdd)

                    Next
                Else
                    'search customer names
                    Me.TJobTableAdapter1.FillByLikeSName(Me.ds1.tJob, Me.txtSearch.Text.Trim & "%")
                    Me.TPOHeaderTableAdapter1.FillByCustName1(Me.ds1.tPOHeader, Me.txtSearch.Text.Trim & "%")
                    Dim drJ As TKSIJOBSDataSet.tJobRow
                    For Each drJ In Me.ds1.tJob
                        'Me.TPOHeaderTableAdapter1.FillByNJOBID(Me.ds1.tPOHeader, drJ.nID)

                        Dim sDateReq As String = ""
                        If drJ.GettPOHeaderRows.Length > 0 Then
                            sDateReq = drJ.GettPOHeaderRows(0).dRequired.Month & "/" & drJ.GettPOHeaderRows(0).dRequired.Day
                        End If

                        Dim sCustomer As String = ""
                        If Not drJ.tCustomrRow Is Nothing Then
                            sCustomer = drJ.tCustomrRow.sName
                        End If

                        Dim strAdd As String = drJ.nID & ControlChars.Tab & drJ.sJobNo & ControlChars.Tab & sDateReq & ControlChars.Tab
                        strAdd = String.Concat(strAdd, sCustomer & ControlChars.Tab & drJ.tAddressRow.sAddress1)
                        Me.flexSearch.AddItem(strAdd)

                        'Me.flexSearch.AddItem(drJ.nID & ControlChars.Tab & drJ.sJobNo & ControlChars.Tab & sDateReq & ControlChars.Tab & sCustomer & ControlChars.Tab & drJ.tAddressRow.sAddress1)

                    Next
                End If
            End If
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub mnuOpenJobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenJobToolStripMenuItem.Click
        If nJOBSelected > 0 Then
            OpenJobScreen(nAddressSelected, nJOBSelected, False)
        
        End If
    End Sub

    Private Sub PrintJobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintJobToolStripMenuItem.Click
        If nJOBSelected > 0 Then
            Me.LoadJobCommunication(nJOBSelected)
            Me.CtrJobComm1.PrintJob(False, False)
        End If
    End Sub
End Class