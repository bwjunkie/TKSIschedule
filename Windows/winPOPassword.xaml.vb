Imports GalaSoft.MvvmLight.Messaging

Public Class winPOPassword

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        btnOK.Focus()
    End Sub

    Private Sub winPOPassword_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        Messenger.Default.Unregister("ClosePOPasswordWindow")
    End Sub

    Private Sub winPOPassword_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Messenger.Default.Register(Of String)("ClosePOPasswordWindow", AddressOf CloseThisWindow)
        Me.txtPassword.Focus()
    End Sub

    Private Sub CloseThisWindow()
        Try
            Me.Close()
        Catch
        End Try

    End Sub
End Class
