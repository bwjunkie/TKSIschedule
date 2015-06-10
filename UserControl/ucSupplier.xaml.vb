Public Class ucSupplier

    Private Sub TextBlock_MouseLeftButtonDown_1(sender As Object, e As MouseButtonEventArgs)
        If sender.text.length = 0 Then
            sender.text = Today.Date.ToShortDateString
        End If
    End Sub
End Class
