

Public Class winProgramFixes

    Dim vm As New vmTaskList

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        If ComponentModel.DesignerProperties.GetIsInDesignMode(Me) Then
            Return
        End If
        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.MaxHeight = global_ScreenHeight - 80

            Me.DataContext = vm

        Catch ex As Exception
            MessageBox.Show("error in sub New " & ex.Message)
        End Try

    End Sub

    Private Sub winProgramFixes_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        Try
            btnsave.Focus()
            vm.windowclosing()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Me.Focus()
    End Sub
End Class
