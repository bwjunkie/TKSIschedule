Public Class CommPayment
    Public OK As Boolean = False
    Private dc As linqTKSIDataContext = GetLinqDataContext()
    Private sales As String = ""
    Private jobid As Integer = -1
    Private totalCanPay As Decimal = 0
    Public listReturnPaymentAmounts As New Dictionary(Of String, Decimal)

    Sub New(_sales As String, _totalCanPay As Decimal, _jobid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sales = _sales
        totalCanPay = _totalCanPay
        jobid = _jobid
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Try

            listReturnPaymentAmounts.Clear()
            Dim blnValid As Boolean = True
            If chkSplitPayment.IsChecked Then
                Dim dec1 As Decimal
                Dim dec2 As Decimal
                Dim dec3 As Decimal
                If Decimal.TryParse(Me.txtAmount1.Text, dec1) And Decimal.TryParse(Me.txtAmount2.Text, dec2) Then
                    If Me.cmbSales1.SelectedItem IsNot Nothing And Me.cmbSales2.SelectedItem IsNot Nothing Then
                        'If Decimal.TryParse(Me.txtAmount3.Text, dec3) Then
                        '    If Me.cmbSales3.SelectedItem Is Nothing Then
                        '        blnValid = False
                        '        MessageBox.Show("3 split payment must have valid Sales.")
                        '    Else
                        '        listReturnPaymentAmounts.Add(Me.cmbSales3.SelectedItem, Me.txtAmount3.Text)
                        '    End If
                        'Else
                        '    'not using 3rd split
                        'End If
                        If dec1 + dec2 + dec3 <= totalCanPay Then
                            'good
                            listReturnPaymentAmounts.Add(Me.cmbSales1.SelectedItem, Me.txtAmount1.Text)
                            listReturnPaymentAmounts.Add(Me.cmbSales2.SelectedItem, Me.txtAmount2.Text)
                        Else
                            blnValid = False
                            MessageBox.Show("Payment amounts are beyond total available to pay.")
                        End If
                    Else
                        blnValid = False
                        MessageBox.Show("No Salesperson selected for split payment.")
                    End If

                Else
                    blnValid = False
                    MessageBox.Show("Split payment must have valid amounts.")
                End If
            Else
                Dim dec1 As Decimal
                If Decimal.TryParse(Me.txtAmount1.Text, dec1) And cmbSales1.SelectedItem IsNot Nothing Then
                    listReturnPaymentAmounts.Add(cmbSales1.SelectedItem, dec1)
                    blnValid = True
                Else
                    blnValid = False
                End If
            End If
            If blnValid Then
                OK = True
                Me.Hide()

            End If
        Catch ex As Exception
            MessageBox.Show("error " & ex.Message)
        End Try


    End Sub

    Private Sub CommPayment_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim q = (From row In dc.tEmployees Where row.archive = False Order By row.nickname Select row.nickname)

        Me.cmbSales1.ItemsSource = q

        Dim qSelected = (From row In q Where row = sales)

        If qSelected.Count = 1 Then
            Me.cmbSales1.SelectedItem = qSelected.First
        End If
        Dim qemp = (From row In dc.tEmployees Where row.archive = False Order By row.nickname Select row.nickname)
        Me.cmbSales2.ItemsSource = qemp

        'Me.cmbSales3.ItemsSource = (From row In dc.tEmployees Where row.archive = False Order By row.nickname Select row.nickname)

        Me.txtAmount1.Text = TwoDecimal(totalCanPay)
        Try
            Dim qJob = (From row In dc.tJobs Where row.nID = jobid)
            If qJob.Count > 0 Then
                If qJob.Single.sSalesperson2.Length > 0 Or qJob.Single.blnSplitCommission Then
                    Me.chkSplitPayment.IsChecked = True
                    Me.txtAmount1.Text = TwoDecimal(totalCanPay / 2)
                    lblMustBeSplitCommissionFLAG.Visibility = Windows.Visibility.Visible
                    Me.lblMustBeSplitCommissionFLAG.Content = Me.lblMustBeSplitCommissionFLAG.Content & " Total: " & TwoDecimal(totalCanPay)

                    If qJob.Single.sSalesperson2.Length > 0 Then
                        Dim qemp1 = From row In qemp Where row = qJob.Single.sSalesperson2
                        If qemp1.Count > 0 Then
                            Me.cmbSales2.SelectedItem = qemp1.First
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error split may not work: " & ex.Message)
        End Try


    End Sub
End Class
