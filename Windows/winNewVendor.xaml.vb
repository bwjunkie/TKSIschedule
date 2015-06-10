Public Class winNewVendor

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        Try
            Dim dc As linqTKSIDataContext = GetLinqDataContext()
            Dim qsearch = (From row In dc.tVendors Where row.sName.ToUpper.Trim = Me.txtname.Text.ToUpper.Trim)
            If qsearch.Count > 0 Then
                MessageBox.Show("Vendor already exists.")
            Else
                Dim qmax = (From row In dc.tVendors Select row.lid).Max

                Dim newven As New tVendor
                With newven
                    .lid = qmax + 1
                    .IgnoreScheduling = chkIgnorescheduling.IsChecked
                    .sName = txtname.Text.Trim
                    .sStreet1 = txtaddress1.Text.Trim
                    .sStreet2 = txtaddress2.Text.Trim
                    .sCity = txtcity.Text.Trim
                    .sProvState = txtstate.Text.Trim
                    .sPostalZip = txtzip.Text.Trim
                    .sPhone1 = txtphone1.Text.Trim
                    .sPhone2 = txtphone2.Text.Trim
                    .sFax = txtfax.Text.Trim
                    .sCountry = "USA"
                    .vendorType = txtvendortype.Text.Trim

                    dc.tVendors.InsertOnSubmit(newven)
                    dc.SubmitChanges()

                    '   Dim sage1 As New clsSageAccountingTools
                    clsSageAccountingTools.NewVendor(newven.lid) ' (.sName, .sStreet1, .sStreet2, .sProvState, .sCity, .sPostalZip, .sCountry, .sPhone1, .sPhone2, .sFax)
                End With

                MessageBox.Show("New Vendor Save Complete")
                Me.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
