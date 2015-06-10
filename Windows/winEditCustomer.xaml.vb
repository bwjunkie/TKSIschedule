Public Class winEditCustomer
    Sub New(_custID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        custID = _custID
    End Sub

    Private dc As linqTKSIDataContext = GetLinqDataContext()
    Private custID As Integer
    Private soriginalname As String = ""
    Private Sub ucEditCustomer1_Loaded(sender As Object, e As RoutedEventArgs) Handles ucEditCustomer1.Loaded
        Dim q = (From row In dc.tCustomrs Where row.lID = custID)
        If q.Count = 1 Then
            Dim cust1 As tCustomr = q.First
            With ucEditCustomer1
                .txtname.Text = cust1.sName
                .txtaddress1.Text = cust1.sStreet1
                .txtaddress2.Text = cust1.sStreet2
                .txtcity.Text = cust1.sCity
                .txtstate.Text = cust1.sProvState
                .txtzip.Text = cust1.sPostalZip
                .txtphone1.Text = cust1.sPhone1
                .txtphone2.Text = cust1.sPhone2
                If cust1.dCrLimit > 0 Then
                    .txtcreditlimit.Text = cust1.dCrLimit
                End If
                soriginalname = cust1.sName
            End With
        End If

    End Sub

    Private Sub ucEditCustomer1_SavePressed(sname As String, saddress1 As String, saddress2 As String, scity As String, sstate As String, szip As String, sphone1 As String, sphone2 As String, sfax As String, sCredit As String) Handles ucEditCustomer1.SavePressed
        Dim q = (From row In dc.tCustomrs Where row.lID = custID)
        If q.Count = 1 Then
            With q.First
                .sName = sname
                .sStreet1 = saddress1
                .sStreet2 = saddress2
                .sCity = scity
                .sProvState = sstate
                .sPostalZip = szip
                .sPhone1 = sphone1
                .sPhone2 = sphone2
                .sFax = sfax
                If sCredit.Length > 0 Then
                    If Not Decimal.TryParse(sCredit, .dCrLimit) Then
                        MessageBox.Show("Credit limit not saved.")
                    End If
                End If

            End With
            If dc.GetChangeSet.Updates.Count > 0 Then
                dc.SubmitChanges()

                '   Dim frmBusy1 As New winBusy
                '   frmBusy1.Show()
                '  Try
                '  Dim proc1 As Process = Process.Start(AppDomain.CurrentDomain.BaseDirectory & "\SageCommand.exe", "EDITCUSTOMER=" & q.First.lID)
                '  proc1.WaitForExit()
                '  If proc1.ExitCode = 1 Then
                ' MessageBox.Show("Sage incomplete, please double check and add customer manually if needed")
                ' ElseIf proc1.ExitCode = 0 Then
                ' MessageBox.Show("Success Editing Customer")
                ' End If
                '  Me.Close()
                '  Catch ex As Exception
                ' Throw New Exception(ex.Message)
                ' Finally
                'frmBusy1.Close()
                'End Try

                'Dim sage1 As New clsSageAccountingTools
                'sage1.EditCustomer(soriginalname, sname, saddress1, saddress2, sstate, scity, szip, "USA", sphone1, sphone2)
                'sage1.Dispose()
                Me.Close()
            End If

        End If
    End Sub
End Class
