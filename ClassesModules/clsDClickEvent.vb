Public Class HandledEventHandler
    Inherits System.Windows.Interactivity.EventTrigger

    Protected Overrides Sub OnEvent(_eventArgs As EventArgs)
        Dim rea As RoutedEventArgs = _eventArgs
        If rea IsNot Nothing Then
            rea.Handled = True
        End If
        MyBase.OnEvent(_eventArgs)
    End Sub

End Class
