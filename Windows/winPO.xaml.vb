Imports GalaSoft.MvvmLight.Messaging
Imports System.Threading
Public Class winPO

    Private vm As vmPO

    Public Sub LoadPO(_POID As Integer)
        vm = New vmPO
        vm.LoadPO(_POID)

        Me.DataContext = vm
        If sUserlevel >= UserRights.Sales Then
            Me.IsEnabled = False
        End If
    End Sub

    Public Sub LoadPO(_POID As Integer, _dc As linqTKSIDataContext)
        vm = New vmPO
        vm.LoadPO(_POID, _dc)

        Me.DataContext = vm
        If sUserlevel >= UserRights.Sales Then
            Me.IsEnabled = False
        End If
    End Sub

    Private Sub RegisterMessengers()
        Messenger.Default.Unregister(Of String)(Me)
        If vm IsNot Nothing Then
            Messenger.Default.Register(Of String)(Me, vm.PO.nID, AddressOf MessegesToMe)
        End If

    End Sub

    Private Sub MessegesToMe(_msg As String)
        Try
            Select _msg
                Case "focuspo"
                    Me.Focus()
                Case "closepowindow"
                    Me.Close()
            End Select
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

    Private Sub POwpf_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        Try
            Me.btnSave.Focus()
        Catch
        End Try

        Dim vm As vmPO = Me.DataContext

        If vm.HasChanges Then

            If MessageBox.Show("Save changes?", "save changes?", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then
                If vm.UserEnteredCredentials Then
                    vm.SaveChanges()
                Else
                    e.Cancel = True
                    Dim frmPOPass As New winPOPassword
                    frmPOPass.DataContext = vm
                    frmPOPass.ShowDialog()
                    If vm.HasChanges Then
                        e.Cancel = True
                    End If
                End If
            End If

        End If

        ' Messenger.Default.Unregister(Of String)(Me)
    End Sub

    Private Sub TextBox_GotKeyboardFocus_1(sender As Object, e As KeyboardFocusChangedEventArgs)
        Try
            DirectCast(sender, TextBox).SelectAll()
        Catch
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        btnSave.Focus()  'hack to make sure , propertychanged event has fired on last textbox that had focus
    End Sub

    Private Sub winPO_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        RegisterMessengers()

        Me.Top = 25
        Me.Left = 60
        If global_largerFontsInUse Then
            Me.MaxHeight = global_ScreenHeight - CInt(global_ScreenHeight / 4)
        Else
            Me.MaxHeight = global_ScreenHeight - 50
        End If
    End Sub
End Class
