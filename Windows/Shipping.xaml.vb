Public Class Shipping

    Private Sub Shipping_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim Rec1 As New vmShipping
        Me.DataContext = Rec1
    End Sub
End Class
