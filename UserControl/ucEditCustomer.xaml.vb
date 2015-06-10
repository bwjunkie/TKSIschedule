Public Class ucEditCustomer

    Public Event SavePressed(sname As String, saddress1 As String, saddress2 As String, scity As String, sstate As String, szip As String, sphone1 As String, sphone2 As String, sfax As String, sCredit As String)

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        RaiseEvent SavePressed(txtname.Text, txtaddress1.Text, txtaddress2.Text, txtcity.Text, txtstate.Text, txtzip.Text, txtphone1.Text, txtphone2.Text, txtfax.Text, txtcreditlimit.Text)
    End Sub
End Class
