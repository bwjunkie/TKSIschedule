Imports GalaSoft.MvvmLight
Imports System.Drawing
Imports System.Drawing.Graphics

Public Class Login

    Private Sub testSage()
        Try
            Dim sage1 As New clsSageAccountingTools
            sage1.Dispose()
            sage1 = Nothing
        Catch ex As Exception
            MessageBox.Show(" Sage test: " & ex.Message)
        End Try

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As RoutedEventArgs) Handles cmdOK.Click
        Try

            Dim dc As linqTKSIDataContext = GetLinqDataContext()
            Dim q = (From row In dc.tUsers Where row.Username.ToUpper = Me.txtUsername.Text.Trim.ToUpper And row.Password.ToUpper = Me.txtPassword.Password.Trim.ToUpper)
            If q.Count > 0 Then
                user1 = q.First  '.Username.ToUpper
                Select Case q.First.Userlevel.ToUpper
                    Case "PAYROLL"
                        sUserlevel = UserRights.Payroll
                    Case "ADMIN"
                        sUserlevel = UserRights.Admin
                    Case "ADMIN.ASST"
                        sUserlevel = UserRights.AdminAsst
                    Case "SHIPPING"
                        sUserlevel = UserRights.Shipping
                    Case "SALES"
                        sUserlevel = UserRights.Sales
                End Select
            End If
            If ISDebugMachine Then
                sUserlevel = UserRights.Payroll
                ' sUsername = "JOSH"
            End If
            If sUserlevel > 0 Then

                Dim frmmain1 As New MainWindow
                frmmain1.Show()

                Try
                    Dim spath = System.Windows.Forms.Application.StartupPath.ToUpper
                    If spath.Contains("DELL-SERVER") Or spath.Contains("Z:\") Then
                        global_EmailErrorLog("not using patch " & Environment.MachineName & " " & user1.Username & " " & spath)
                    End If
                Catch 
                End Try
                Me.Close()
            Else
                Me.Title = "Username not found"
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Login_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        SetupImagePathsAndConnectionStrings()

        If global_TestNetworkConnectionFAILED() Then
            Me.lblNetworkError.Visibility = Windows.Visibility.Visible
        End If

        Try
            Dim user As String = ""

            Try
                user = GetSetting(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).InternalName, "user", "user", "Login")
            Catch ex As Exception
            End Try

            If user.Length > 0 Then
                txtUsername.Text = user
            End If

            If Me.txtUsername.Text.Trim.Length > 0 Then
                txtPassword.Focus()
            Else
                txtUsername.Focus()
            End If
        Catch ex As Exception
        End Try

        'If ISDebugMachine Then
        '    If Not System.Diagnostics.Debugger.IsAttached Then
        '        testSage()
        '    End If
        'End If
        Try

            Dim m As Matrix = PresentationSource.FromVisual(Application.Current.MainWindow).CompositionTarget.TransformToDevice
            Dim dx As Double = m.M11
            Dim dy As Double = m.M22
            If dx > 1.1 Then
                global_largerFontsInUse = True
            End If
        Catch
        End Try
    End Sub
End Class
