Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports GalaSoft.MvvmLight
Imports System.Windows.Threading

Public Class winJob

    Private vm As vmJob

    Public Sub LoadJob(_nAddID As Integer, _nJobID As Integer)

        vm = New vmJob
        vm.LoadJobNewDataContext(_nAddID, _nJobID)

        Me.DataContext = vm

    End Sub



    Private Sub winJob_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Try

            Me.Focus()

            If vm.HasChanges Then
                If MessageBox.Show("Save changes?", "save changes?", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then
                    vm.SaveJobAndReload()
                End If
            End If

        Catch
        End Try

    End Sub

    Private Sub winPO_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If vm IsNot Nothing Then
            vm.IsActivated = True
        End If
    End Sub

    Private Sub winPO_DeActivated(sender As Object, e As EventArgs) Handles Me.Deactivated
        If vm IsNot Nothing Then
            vm.IsActivated = False
        End If
    End Sub

    Private Sub winJob_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.Top = 15
        Me.Left = 15
        If global_largerFontsInUse Then
            '  Me.Height = global_ScreenHeight - 500
            '  Me.Height = global_ScreenHeight - CInt(global_ScreenHeight / 3.8)
            Me.MaxHeight = global_ScreenHeight - CInt(global_ScreenHeight / 3.9)
            Me.col2.Width = New GridLength(global_ScreenWidth * 0.43)

            '   Me.MaxWidth = global_ScreenWidth - CInt(global_ScreenWidth / 4)
            '  Me.MinHeight = global_ScreenHeight - CInt(global_ScreenHeight / 3.8)
        Else
            ' Me.Height = global_ScreenHeight - 60
            Me.MaxHeight = global_ScreenHeight - 50
            Me.col2.Width = New GridLength(global_ScreenWidth * 0.45)
            '   Me.MaxWidth = global_ScreenWidth - 50
            ' Me.MinHeight = global_ScreenHeight - 60
        End If
    End Sub
End Class


