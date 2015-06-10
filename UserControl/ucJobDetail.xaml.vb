Public Class ucJobDetail

    Private Sub myfocus(_msg As FocusMessage)
        Try

            If Me.DataContext IsNot Nothing Then
                If TypeOf Me.DataContext Is vmJob Then
                    Dim vm As vmJob = Me.DataContext
                    If vm.tjob IsNot Nothing Then

                        If _msg.dataID = vm.tjob.nID Then
                            Select Case _msg.objectnametofocus
                                Case FocusMessage.taxfocus
                                    If vm.IsActivated Then
                                        Me.txtlabor.Focus()
                                    End If

                                Case FocusMessage.topboxfocus
                                    If vm.IsActivated Then
                                        Me.txtbuildingPermit.Focus()
                                    End If

                            End Select
                        End If
                    End If
                End If

            End If
        Catch
        End Try

    End Sub

    Private Sub ucJobDetail_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register(Of FocusMessage)(Me, AddressOf myfocus)
        Catch
        End Try
    End Sub
End Class
