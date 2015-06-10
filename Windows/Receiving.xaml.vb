Class Receiving

    Private Sub Receiving_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim Rec1 As New vmReceiving
        Me.DataContext = Rec1
        Me.MaxHeight = global_ScreenHeight - 80
        Me.Top = 10
        Me.Left = 20
    End Sub

End Class
