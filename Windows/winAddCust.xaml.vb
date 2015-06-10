Public Class winAddCust

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private Sub ucEditCustomer1_SavePressed(sname As String, saddress1 As String, saddress2 As String, scity As String, sstate As String, szip As String, sphone1 As String, sphone2 As String, sfax As String, sCredit As String) Handles ucEditCustomer1.SavePressed
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
                    Decimal.TryParse(sCredit, .dCrLimit)
                Catch
                    .dCrLimit = 0
                End Try
                .dAmtYTD = 0
            End With

            dc.tCustomrs.InsertOnSubmit(cust1)
            If dc.GetChangeSet.Inserts.Count > 0 Then
                dc.SubmitChanges()
                If cust1.lID > 4400 Then
                    Dim frmBusy1 As New winBusy
                    frmBusy1.Show()
                    Try
                        'Dim sage1 As New clsSageAccountingTools
                        clsSageAccountingTools.NewCust(cust1.lID)
                        Me.Close()

                    Catch ex As Exception
                        Throw New Exception(ex.Message)
                    Finally
                        frmBusy1.Close()
                    End Try
                Else
                    MessageBox.Show("customer ID not valid for saving to Sage.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
