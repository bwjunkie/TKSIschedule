Public Class AddCustomer
    Dim dc As New linqTKSIDataContext
    Private Sub ctrEditCustomer_SavePressed(sname As String, saddress1 As String, saddress2 As String, scity As String, sstate As String, szip As String, sphone1 As String, sphone2 As String, sfax As String, sCredit As String) 'Handles ctrEditCustomer.SavePressed
        Try
            Dim cust1 As New tCustomr

            With cust1
                .sName = sname
                .sCity = scity
                .sStreet1 = saddress1
                .sStreet2 = saddress2
                .sPhone1 = sphone1
                .sPhone2 = sphone2
                .sFax = sfax
                .sCountry = "USA"
                .sPostalZip = szip
                .sProvState = sstate
                Try
                    .dCrLimit = sCredit
                Catch
                    .dCrLimit = 0
                End Try
                .dAmtYTD = 0
            End With

            dc.tCustomrs.InsertOnSubmit(cust1)
            If dc.GetChangeSet.Inserts.Count > 0 Then
                dc.SubmitChanges()
                If cust1.lID > 4400 Then
                    Dim frmBusy1 As New winbusy
                    frmbusy1.show()
                    Try
                        Dim proc1 As Process = Process.Start(AppDomain.CurrentDomain.BaseDirectory & "\SageCommand.exe", "NEWCUSTOMER=" & cust1.lID)
                        proc1.WaitForExit()
                    Catch ex As Exception

                    Finally
                        frmworking.close()
                    End Try


                End If
            End If


            'Dim sage1 As New clsSageAccountingTools
            'sage1.NewCustomer(sname, saddress1, saddress2, sstate, scity, szip, "USA", sphone1, sphone2, cust1.dCrLimit)
            'sage1.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
