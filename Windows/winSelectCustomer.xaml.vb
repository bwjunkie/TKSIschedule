Imports GalaSoft.MvvmLight.Messaging

Public Class winSelectCustomer

    Private Sub winSelectCustomer_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim vm1 As New vmSelectCust
        Me.DataContext = vm1
        Messenger.Default.Register(Of String)("closecustomerwindow", AddressOf CloseThisWindow)
    End Sub

    Private Sub CloseThisWindow()
        Me.Close()
    End Sub

End Class
