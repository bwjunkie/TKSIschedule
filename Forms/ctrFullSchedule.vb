Public Class ctrFullSchedule

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private Sub CreateJobAppointment(ByVal app As C1.C1Schedule.Appointment, ByVal dsSched As TKSIJOBSDataSet, ByVal sUserCode As String)
        If Not blnLoadingData Then
            Try
                blnLoadingData = True
                Dim drJob As tJob ' TKSIJOBSDataSet.tJobRow
                Dim drCust As TKSIJOBSDataSet.tCustomrRow
                Dim drAdd As TKSIJOBSDataSet.tAddressRow



                'sjob6 is 5 digit for all jobs prior to 2010, but will be 6 digits for future
                'job num like 8000a vrs 21111b
                '  Dim sJob5 As String = Mid(app.Body, 1, 5)
                Dim sJob6 As String = Mid(app.Body, 1, 6)
                '  If IsNumeric(sJob5) Then
                ''leave as 5 digit for folder/file creation
                'Else
                ' sJob5 = Mid(app.Body, 1, 4)
                ' sJob6 = Mid(app.Body, 1, 5)
                ' End If

                If IsNumeric(sJob6.Trim) Then

                    ' Dim daJ As New TKSIJOBSDataSetTableAdapters.tJobTableAdapter
                    ' daJ.Connection.ConnectionString = cnSQL

                    '  Dim drJ As tJob
                    Dim qJ = (From row In dc.tJobs Where row.nID = CInt(sJob6.Trim))
                    If qJ.Count > 0 Then  ' daJ.FillBy(Me.TKSIJOBSDataSet.tJob, sJob6) > 0 Then
                        '  If Me.TJobTableAdapter1.FillBy(Me.TKSIJOBSDataSet.tJob, sJob6) > 0 Then

                        If app.Start.Hour < 6 Or app.Start.Hour > 19 Then
                            Windows.Forms.MessageBox.Show("Appointment must be between 7am and 6pm.  Please try again.")
                            Exit Sub
                        End If

                        drJob = qJ.First ' Me.TKSIJOBSDataSet.tJob(0)

                        If Me.TCustomrTableAdapter1.FillByLID(Me.TKSIJOBSDataSet.tCustomr, drJob.nCustID) > 0 Then
                            drCust = Me.TKSIJOBSDataSet.tCustomr(0)
                            If Me.TAddressTableAdapter1.Fill(Me.TKSIJOBSDataSet.tAddress, drJob.nAddressID) > 0 Then
                                drAdd = Me.TKSIJOBSDataSet.tAddress(0)
                                app.Body = drJob.sJobNo & ControlChars.CrLf & drCust.sName & ControlChars.CrLf & drJob.sJobDesc & ControlChars.CrLf & drAdd.sAddress1 & ControlChars.CrLf & drAdd.sAddress2 & ControlChars.CrLf & drAdd.sCity & ", " & drAdd.sState & " " & drAdd.sZip
                                app.Subject = drJob.sJobNo & ControlChars.CrLf & drCust.sName & ControlChars.CrLf & drJob.sJobDesc & ControlChars.CrLf & drAdd.sAddress1 & ControlChars.CrLf & drAdd.sAddress2 & ControlChars.CrLf & drAdd.sCity & ", " & drAdd.sState & " " & drAdd.sZip
                                app.End = app.Start.AddHours(3)

                            Else
                                'no address record
                                app.Body = "error no address"
                                app.Subject = "error no address"
                            End If
                        Else
                            'no customer record
                            app.Body = "error no customer"
                            app.Subject = "error no customer"
                        End If

                        If dsSched.Appointments.Rows.Count > 0 Then
                            dsSched.Appointments(dsSched.Appointments.Rows.Count - 1).JobNo = drJob.nID
                        End If

                        Try
                            'create activity log showing scheduled
                            Dim drActivity As TKSIJOBSDataSet.tblJobActivityRow
                            drActivity = Me.TKSIJOBSDataSet.tblJobActivity.NewtblJobActivityRow
                            With drActivity
                                .gID = Guid.NewGuid
                                .Other = ""
                                .nJobID = drJob.nID
                                .dateEntered = Now
                                .ActivityType = "MISC"
                                .ActivityDetail = "Scheduled " & app.Start.Month & "/" & app.Start.Day & " " & app.Start.ToShortTimeString
                            End With
                            Me.TKSIJOBSDataSet.tblJobActivity.AddtblJobActivityRow(drActivity)
                            Me.TblJobActivityTableAdapter1.Update(Me.TKSIJOBSDataSet.tblJobActivity)
                        Catch ex As Exception
                        End Try
                    Else
                        'no job record
                        app.Body = "error no job"
                        app.Subject = "error no job"
                    End If
                Else
                    'invalid job code from drag drop
                End If

                If dsSched.Appointments.Rows.Count > 0 Then
                    dsSched.Appointments(dsSched.Appointments.Rows.Count - 1).UserName = sUserCode
                End If
                Me.AppointmentsTableAdapter.Update(dsSched.Appointments)

            Catch ex As Exception
                'Windows.Forms.MessageBox.Show(ex.Message)
            Finally
                blnLoadingData = False
            End Try
        End If

    End Sub

    Private blnLoadingData As Boolean = False
    Private blnAppointmentBeingMoved As Boolean = False

    Private Sub C1Schedule1_AppointmentAdded(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles C1Schedule1.AppointmentAdded
        If Not Me.blnLoadingData Then
            If Not Me.blnAppointmentBeingMoved Then
                CreateJobAppointment(e.Appointment, Me.dsSchedule1, "1")
            Else
                Me.blnAppointmentBeingMoved = False
            End If

        End If
    End Sub

    Private Sub C1Schedule2_AppointmentAdded(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles C1Schedule2.AppointmentAdded
        If Not Me.blnLoadingData Then
            If Not Me.blnAppointmentBeingMoved Then
                CreateJobAppointment(e.Appointment, Me.dsSchedule2, "2")
            Else
                Me.blnAppointmentBeingMoved = False
                Me.C1Schedule2.Refresh()
            End If

        End If
    End Sub

    Private Sub C1Schedule3_AppointmentAdded(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles C1Schedule3.AppointmentAdded
        If Not Me.blnLoadingData Then
            If Not Me.blnAppointmentBeingMoved Then
                CreateJobAppointment(e.Appointment, Me.dsSchedule3, "3")
            Else
                Me.blnAppointmentBeingMoved = False
            End If

        End If
    End Sub

    Private Sub C1Schedule4_AppointmentAdded(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles C1Schedule4.AppointmentAdded
        If Not Me.blnLoadingData Then
            If Not Me.blnAppointmentBeingMoved Then
                CreateJobAppointment(e.Appointment, Me.dsSchedule4, "4")
            Else
                Me.blnAppointmentBeingMoved = False
            End If

        End If
    End Sub

    Private Sub C1Schedule5_AppointmentAdded(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles C1Schedule5.AppointmentAdded
        If Not Me.blnLoadingData Then
            If Not Me.blnAppointmentBeingMoved Then
                CreateJobAppointment(e.Appointment, Me.dsSchedule5, "5")
            Else
                Me.blnAppointmentBeingMoved = False
            End If

        End If
    End Sub

    Private Sub ctrFullSchedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshAppointments()
    End Sub

    Public Sub RefreshAppointments()
        blnLoadingData = True
        Try
            Me.TblServicePersonTableAdapter.Fill(Me.TKSIJOBSDataSet.tblServicePerson)
            Me.AppointmentsTableAdapter.FillBy(Me.dsSchedule1.Appointments, "1")
            Me.AppointmentsTableAdapter.FillBy(Me.dsSchedule2.Appointments, "2")
            Me.AppointmentsTableAdapter.FillBy(Me.dsSchedule3.Appointments, "3")
            Me.AppointmentsTableAdapter.FillBy(Me.dsSchedule4.Appointments, "4")
            Me.AppointmentsTableAdapter.FillBy(Me.dsSchedule5.Appointments, "5")

            Try
                Dim drService As TKSIJOBSDataSet.tblServicePersonRow
                For Each drService In Me.TKSIJOBSDataSet.tblServicePerson
                    Select Case drService.settings2
                        Case "1"
                            Me.lblService1.Text = drService.sName
                        Case "2"
                            Me.lblService2.Text = drService.sName
                        Case "3"
                            Me.lblService3.Text = drService.sName
                        Case "4"
                            Me.lblService4.Text = drService.sName
                        Case "5"
                            Me.lblService5.Text = drService.sName
                        Case Else
                            'no labels to add
                    End Select
                Next
            Catch ex As Exception

            End Try



        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            blnLoadingData = False
        End Try
    End Sub

    Private Function MoveAppointment(ByVal app As C1.C1Schedule.Appointment, ByVal sMoveToUserCode As String) As Boolean

        'Dim drNewApp As TKSIJOBSDataSet.AppointmentsRow
        Dim dsNewSchedul As TKSIJOBSDataSet
        Dim dsExistingAppSchedule As TKSIJOBSDataSet
        Dim sMoveFromUserCode As String = ""

        Select Case sUsernameSchedClicked
            Case "1"
                dsExistingAppSchedule = Me.dsSchedule1
            Case "2"
                dsExistingAppSchedule = Me.dsSchedule2
            Case "3"
                dsExistingAppSchedule = Me.dsSchedule3
            Case "4"
                dsExistingAppSchedule = Me.dsSchedule4
            Case "5"
                dsExistingAppSchedule = Me.dsSchedule5
            Case Else
                Exit Function
        End Select

        Select Case sMoveToUserCode
            Case "1"
                dsNewSchedul = Me.dsSchedule1
            Case "2"
                dsNewSchedul = Me.dsSchedule2
            Case "3"
                dsNewSchedul = Me.dsSchedule3
            Case "4"
                dsNewSchedul = Me.dsSchedule4
            Case "5"
                dsNewSchedul = Me.dsSchedule5
            Case Else
                Exit Function
        End Select

        Dim draApp As TKSIJOBSDataSet.AppointmentsRow()
        draApp = dsExistingAppSchedule.Appointments.Select("subject like '" & Mid(app.Subject, 1, 5) & "%'")
        If draApp.Length > 0 Then
            'this is existing appointment before being moved
            draApp(0).UserName = sMoveToUserCode
            If Me.AppointmentsTableAdapter.Update(dsExistingAppSchedule) > 0 Then
                Return True
            End If
            'drNewApp = dsNewSchedul.Appointments.NewAppointmentsRow
            'With drNewApp
            '    .Location = ""
            '    .Properties = ""
            '    .JobNo = draApp(0).JobNo
            '    .Body = draApp(0).Body
            '    .Subject = draApp(0).Subject
            '    .Start = draApp(0).Start
            '    ._End = draApp(0)._End
            '    .UserName = drServicePerson.settings2
            '    .Id = Guid.NewGuid
            'End With
            'dsNewSchedul.Appointments.Rows.Add(drNewApp)
            'Me.AppointmentsTableAdapter.Update(dsNewSchedul)

        End If
        Return False
    End Function

    Private Function DeleteRowBySubject(ByVal sSubject As String, ByVal dsSched As TKSIJOBSDataSet) As Boolean

            Dim draApp As TKSIJOBSDataSet.AppointmentsRow()
            draApp = dsSched.Appointments.Select("subject like '" & Mid(sSubject, 1, 5) & "%'")
            If draApp.Length > 0 Then
                draApp(0).Delete()
            Me.AppointmentsTableAdapter.Update(dsSched.Appointments)
            blnAppointmentBeingMoved = True
                Return True
            End If
            Return False


    End Function

    'Private Sub C1Schedule1_AppointmentChanged(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles C1Schedule1.AppointmentChanged


    '    If e.Appointment.Categories.Count > 0 Then

    '        Dim drServicePerson As TKSIJOBSDataSet.tblServicePersonRow
    '        For Each drServicePerson In Me.TKSIJOBSDataSet.tblServicePerson
    '            If drServicePerson.sName.ToUpper.Trim = e.Appointment.Categories(0).Text.ToUpper.Trim Then
    '                If MoveAppointment(e.Appointment, drServicePerson, "1", Me.dsSchedule1) Then
    '                    Me.DeleteRowBySubject(e.Appointment.Subject, Me.dsSchedule1)
    '                    Exit For
    '                End If
    '            End If
    '        Next

    '    End If
    'End Sub

    Private appClicked As C1.C1Schedule.Appointment = Nothing
    Private sUsernameSchedClicked As String = ""

    Private Sub C1Schedule1_BeforeContextMenuShow(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeContextMenuShowEventArgs) Handles C1Schedule1.BeforeContextMenuShow
        Me.appClicked = e.Appointment
        sUsernameSchedClicked = "1"
    End Sub

    Private Sub C1Schedule1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Schedule1.Validated
        If blnLoadingData = False Then
            Try

                Me.AppointmentsTableAdapter.Update(Me.dsSchedule1.Appointments)
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub C1Schedule2_BeforeContextMenuShow(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeContextMenuShowEventArgs) Handles C1Schedule2.BeforeContextMenuShow
        Me.appClicked = e.Appointment
        sUsernameSchedClicked = "2"
    End Sub

    Private Sub C1Schedule2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Schedule2.Validated
        If blnLoadingData = False Then
            Try
                Me.AppointmentsTableAdapter.Update(Me.dsSchedule2.Appointments)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub C1Schedule3_BeforeContextMenuShow(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeContextMenuShowEventArgs) Handles C1Schedule3.BeforeContextMenuShow
        Me.appClicked = e.Appointment
        sUsernameSchedClicked = "3"
    End Sub

    Private Sub C1Schedule3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Schedule3.Validated
        If blnLoadingData = False Then
            Try
                Me.AppointmentsTableAdapter.Update(Me.dsSchedule3.Appointments)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub C1Schedule4_BeforeContextMenuShow(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeContextMenuShowEventArgs) Handles C1Schedule4.BeforeContextMenuShow
        Me.appClicked = e.Appointment
        sUsernameSchedClicked = "4"
    End Sub

    Private Sub C1Schedule4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Schedule4.Validated
        If blnLoadingData = False Then
            Try
                Me.AppointmentsTableAdapter.Update(Me.dsSchedule4.Appointments)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub C1Schedule5_BeforeContextMenuShow(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeContextMenuShowEventArgs) Handles C1Schedule5.BeforeContextMenuShow
        Me.appClicked = e.Appointment
        sUsernameSchedClicked = "5"
    End Sub

    Private Sub C1Schedule5_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Schedule5.Validated
        If blnLoadingData = False Then
            Try
                Me.AppointmentsTableAdapter.Update(Me.dsSchedule5.Appointments)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click, ToolStripMenuItem6.Click, ToolStripMenuItem7.Click, ToolStripMenuItem8.Click, ToolStripMenuItem9.Click, ToolStripMenuItem10.Click, ToolStripMenuItem11.Click, ToolStripMenuItem12.Click, ToolStripMenuItem13.Click, ToolStripMenuItem14.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripClick3(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click, ToolStripMenuItem16.Click, ToolStripMenuItem17.Click, ToolStripMenuItem18.Click, ToolStripMenuItem19.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripClick4(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click, ToolStripMenuItem21.Click, ToolStripMenuItem22.Click, ToolStripMenuItem23.Click, ToolStripMenuItem24.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripClick5(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click, ToolStripMenuItem26.Click, ToolStripMenuItem27.Click, ToolStripMenuItem28.Click, ToolStripMenuItem29.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment could be moved")
        Else
            Me.MoveAppointment(Me.appClicked, sender.Tag)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Sub PrintApp1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintApp1.Click, PrintApp2.Click, PrintApp3.Click, PrintApp4.Click, PrintApp5.Click
        If Me.appClicked Is Nothing Then
            Windows.Forms.MessageBox.Show("No appointment to print")
        Else
            Me.PrintJob(Me.appClicked)
            Me.RefreshAppointments()
        End If
    End Sub

    Private Function PrintJob(ByVal app As C1.C1Schedule.Appointment) As Boolean

        Dim dsExistingAppSchedule As TKSIJOBSDataSet
        Dim sMoveFromUserCode As String = ""

        Select Case sUsernameSchedClicked
            Case "1"
                dsExistingAppSchedule = Me.dsSchedule1
            Case "2"
                dsExistingAppSchedule = Me.dsSchedule2
            Case "3"
                dsExistingAppSchedule = Me.dsSchedule3
            Case "4"
                dsExistingAppSchedule = Me.dsSchedule4
            Case "5"
                dsExistingAppSchedule = Me.dsSchedule5
            Case Else
                Return False
        End Select

        Dim draApp As TKSIJOBSDataSet.AppointmentsRow()
        draApp = dsExistingAppSchedule.Appointments.Select("subject like '" & Mid(app.Subject, 1, 5) & "%'")
        If draApp.Length > 0 Then
         
            '  If Me.TJobTableAdapter1.FillBy(Me.TKSIJOBSDataSet.tJob, Mid(app.Body, 1, 5)) > 0 Then
            Dim ctrJob1 As New ctrJobComm
            ctrJob1.LoadJob(Me.TKSIJOBSDataSet.tJob(0).nID)
            ctrJob1.PrintJob(False, False)
            Return True
            '  End If

        End If
        Return False
    End Function
End Class
