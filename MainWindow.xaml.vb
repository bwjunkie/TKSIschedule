Imports System.Globalization
Imports GalaSoft.MvvmLight
Imports System.Windows.Threading

Class MainWindow

    Dim timerTestNetwork As DispatcherTimer

    Private Sub timerTestNetwork_Tick()
        Try
            DirectCast(Me.DataContext, vmMain).RaiseNetworkError()
        Catch ex As Exception
            global_EmailErrorLog("timer tick error " & ex.Message)
        End Try

    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try
            Me.Top = 10
            Me.MaxHeight = global_ScreenHeight - 30

            Dim vm As New vmMain
            Me.DataContext = vm
            Me.txtJobSearch.Focus()
            If sUserlevel = UserRights.Sales Then

            End If
            If sUserlevel <= UserRights.Shipping Then
                Me.tabShipping.Visibility = Windows.Visibility.Visible
            Else
                Me.tabShipping.Visibility = Windows.Visibility.Collapsed
            End If
            If sUserlevel <= UserRights.AdminAsst Then
                Me.tabAdmin.Visibility = Windows.Visibility.Visible
            Else
                Me.tabAdmin.Visibility = Windows.Visibility.Collapsed
            End If
            If sUserlevel <= UserRights.Admin Then
                Me.tabAccounting.Visibility = Windows.Visibility.Visible
            Else
                Me.tabAccounting.Visibility = Windows.Visibility.Collapsed
            End If
            If sUserlevel = UserRights.Payroll Then
                Me.tabPayroll.Visibility = Windows.Visibility.Visible
                Me.btnCommissions.Visibility = Windows.Visibility.Visible
            Else
                Me.tabPayroll.Visibility = Windows.Visibility.Collapsed
                Me.btnCommissions.Visibility = Windows.Visibility.Collapsed
            End If
            If global_Username.ToUpper.Contains("WAREHOUSE") Then
                Me.tabShipping.Visibility = Windows.Visibility.Visible
                Me.tabSales.Visibility = Windows.Visibility.Collapsed
            End If
        Catch ex As Exception
            MessageBox.Show("error in main screen loading : " & ex.Message)
        End Try

        Try
            timerTestNetwork = New DispatcherTimer()
            AddHandler timerTestNetwork.Tick, AddressOf timerTestNetwork_Tick
            timerTestNetwork.Interval = New TimeSpan(0, 0, 11)
            timerTestNetwork.Start()
        Catch
        End Try

    End Sub
End Class
