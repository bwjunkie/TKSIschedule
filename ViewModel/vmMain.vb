Imports System.Linq
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command
Imports System.Data.Linq

Public Class vmMain
    Inherits MyViewModelBase

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private _listjobsextra As New ObservableCollection(Of Object)
    Public Property listjobsextra As ObservableCollection(Of Object)
        Get
            Return _listjobsextra
        End Get
        Set(value As ObservableCollection(Of Object))
            _listjobsextra = value
            RaisePropertyChanged("listjobsextra")
        End Set
    End Property

    Private Sub CustDblClick()
        OpenCustDetail()
    End Sub

    Private Sub commissions()
        Dim frm As New winCommissions
        frm.ShowDialog()
    End Sub

    Private _listcustomers As New ObservableCollection(Of cust1)
    Public Property listcustomers As ObservableCollection(Of cust1)
        Get
            Return _listcustomers
        End Get
        Set(value As ObservableCollection(Of cust1))
            _listcustomers = value
            RaisePropertyChanged("listcustomers")
            '  RaisePropertyChanged("collistcustomers")
        End Set
    End Property

    Private _searchstringcust As String = ""
    Public Property searchstringcust As String
        Get
            Return _searchstringcust
        End Get
        Set(value As String)
            _searchstringcust = value
            RaisePropertyChanged("searchstringcust")
            If _searchstringcust.Length > 1 Then
                DoSearchCust()
            End If
        End Set
    End Property

    Public Property selectedcust As cust1

    Public Property selectedjob

    Private _searchstring As String = ""
    Public Property searchstring As String
        Get
            Return _searchstring
        End Get
        Set(value As String)
            _searchstring = value
            RaisePropertyChanged("searchstring")
            If _searchstring.Length > 3 Then
                DoSearch()
            End If
        End Set
    End Property

    Sub New()
        'put auto default search for sales people to see their own jobs?

        Dim search As String = searchstring.Trim
        Dim qAdd = (From row In dc.tAddresses Where row.tJobs.First.dCreated > Now.AddDays(-10) Order By row.sLocCode.PadLeft(8, "0") Select row.nID, row.sLocCode, row.sAddress1, row.tJobs)
        For Each add1 In qAdd
            listjobsextra.Add(New file1(add1.nID, "FILE: " & add1.sLocCode, add1.sAddress1))
            For Each job1a In add1.tJobs
                listjobsextra.Add(New job1(job1a.nID, job1a.nAddressID, "", "JOB: " & job1a.sJobNo & " - " & job1a.sJobDesc))
            Next
        Next

    End Sub

    Private Sub DoSearch()

        StartTimer()

        listjobsextra.Clear()
        Dim search As String = searchstring.Trim.ToUpper
        Dim qAdd = (From row In dc.tAddresses Where row.sLocCode.StartsWith(search) Or row.sAddress1.Contains(search) Order By row.sLocCode.PadLeft(8, "0") Select row.nID, row.sLocCode, row.sAddress1, row.tJobs)

        Dim qSales = (From row In dc.tEmployees Where row.nickname.ToUpper = search)
        If qSales.Count > 0 Then
            Dim qjob = (From rowj In dc.tJobs Where rowj.sSalesperson.ToUpper = search Select rowj.nAddressID)
            If qjob.Count > 0 Then
                qAdd = (From row In dc.tAddresses Where qjob.Contains(row.nID) Order By row.sLocCode.PadLeft(8, "0") Select row.nID, row.sLocCode, row.sAddress1, row.tJobs)

            End If

        End If
        For Each add1 In qAdd
            listjobsextra.Add(New file1(add1.nID, "FILE: " & add1.sLocCode, add1.sAddress1))
            For Each job1a In add1.tJobs
                listjobsextra.Add(New job1(job1a.nID, job1a.nAddressID, "", "JOB: " & job1a.sJobNo & " - " & job1a.sJobDesc))
            Next
        Next

        EndTimer(1, " long job search ")
    End Sub

    Public Class cust1
        Public Property lid As Integer
        Public Property sName As String
        Sub New()

        End Sub
    End Class

    Private Sub DoSearchCust()
        Dim q = (From row In dc.tCustomrs Where row.sName.StartsWith(searchstringcust.Trim) Order By row.sName Select New cust1 With {.lid = row.lID, .sName = row.sName})
        listcustomers = New ObservableCollection(Of cust1)(q.ToList)
    End Sub

    Public Sub OpenJob()
        Try
            If selectedjob.GetType Is GetType(job1) Then
                Dim ojob As job1 = DirectCast(selectedjob, job1)
                OpenJobScreen(ojob.naddressid, ojob.nid, False)

            ElseIf selectedjob.GetType Is GetType(file1) Then
                Dim ofile As file1 = DirectCast(selectedjob, file1)
                OpenJobScreen(ofile.nid, 0, False)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub OpenCustDetail()
        If selectedcust IsNot Nothing Then
            Dim cust2 As New winCustDetail
            cust2.loadCust(selectedcust.lid)
            cust2.Top = 15
            cust2.Show()

        End If
    End Sub

    Private Sub newvendor()
        Dim ven As New winNewVendor
        ven.Show()
    End Sub

    Private Sub ProgramFixes()
        Try
            Dim fixes As New winProgramFixes
            fixes.Show()
        Catch ex As Exception
            MessageBox.Show("error in programfixes " & ex.Message)
        End Try
    End Sub

    Private Sub ShowCreditLimits()
        Dim frmbusy1 As New winBusy
        frmbusy1.Show()

        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        '   Dim opt As New DataLoadOptions
        '   opt.LoadWith(Of tJob)(Function(j) j.tCustomr)
        '   opt.LoadWith(Of tCustomr)(Function(c) c.tSOHeaders)
        '   opt.LoadWith(Of tSOHeader)(Function(so) so.tSOLines)
        Dim pdf1 As New clsPDFCreate("Credit Limits")
        pdf1.AddParagraphToPDF("Active Credits in Use", 14)
        pdf1.AddParagraphToPDF(pdf1.ColTextPad("Name", "", "Credit Allowed", "Used"), 9)

        Dim q = (From row In dc.tJobs Where row.dJobCreated > Now.AddYears(-2) And row.sTerms.ToUpper.Contains("NET") Select row.tCustomr Distinct)
        For Each cust In (From row In q Order By row.sName)
            ' Dim vmjob1 As New vmJob
            Dim lines = (From row In dc.tSOLines Where row.sType.ToUpper = "COMMENT" And row.tSOHeader.nCustID = cust.lID Select row).Sum(Function(s) CType(s.nAmount, Decimal?))
            If lines IsNot Nothing Then
                If lines > 500 Then
                    pdf1.AddParagraphToPDF(pdf1.ColTextPad(Mid(cust.sName, 1, 27), "", Format(cust.dCrLimit, "currency"), Format(lines, "currency")), 9)
                End If
            End If



        Next

        pdf1.AddParagraphToPDF("All Customers", 14)
        pdf1.AddParagraphToPDF(pdf1.ColTextPad("Name", "", "Credit Allowed", "Used"), 9)
        For Each cust In (From row In q Order By row.sName)
            '   Dim vmjob1 As New vmJob
            Dim lines = (From row In dc.tSOLines Where row.sType.ToUpper = "COMMENT" And row.tSOHeader.nCustID = cust.lID Select row).Sum(Function(s) CType(s.nAmount, Decimal?))
            Dim decUsed As Decimal = 0
            If lines IsNot Nothing Then
                decUsed = lines
            End If

            Dim sjobswithWrongTerms As String = ""
            If cust.dCrLimit < 1000 Then
                Dim qjob = (From row In cust.tJobs Where row.sTerms.ToUpper.Contains("NET"))


                If qjob.Count > 0 Then
                    Dim icount As Integer = 0
                    For Each j1 In qjob
                        icount += 1
                        sjobswithWrongTerms = String.Concat(sjobswithWrongTerms, j1.sJobNo, " ")
                        If icount > 2 Then
                            Exit For
                        End If
                    Next
                    '  pdf1.AddParagraphToPDF(sjobswithWrongTerms, 9)
                Else

                End If
            End If

            pdf1.AddParagraphToPDF(pdf1.ColTextPad(Mid(cust.sName, 1, 27), sjobswithWrongTerms, Format(cust.dCrLimit, "currency"), Format(decUsed, "currency")), 9)


        Next

        pdf1.ShowPDF()

        frmbusy1.Close()
    End Sub

    Private Sub AddCustomer()
        Dim cust1 As New winAddCust
        cust1.ShowDialog()
    End Sub

    Public ReadOnly Property SalespersonSWOlist() As ObservableCollection(Of tblSWOPending)
        Get
            Try
                'show job-loccode and customer name
                Dim qSWO = (From row In dc.tblSWOPendings Where row.dateOrderBy > Now.AddDays(-6) Order By row.dateOrderBy Descending)
                Return New ObservableCollection(Of tblSWOPending)(qSWO.ToList)

            Catch ex As Exception
                MessageBox.Show("error in PendingSWO " & ex.Message)
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property SalesNeedsAttentionList As ObservableCollection(Of tJob)
        Get
            Dim ret As New ObservableCollection(Of tJob)
            '  Dim qjob = (From row In dc.tblJobActivities Join rowjob In dc.tJobs On CInt(row.nJobID) Equals rowjob.nID Where rowjob.sSalesperson = global_Nickname)

            Dim q = (From row In dc.tblJobActivities Join rowjob In dc.tJobs On CInt(row.nJobID) Equals rowjob.nID Where rowjob.sSalesperson = global_Nickname And row.ActivityType.ToUpper.Trim = JobActivityTypes.WaitingOnSalesperson And row.dateEntered > Now.AddDays(-14) Select rowjob Distinct)

            For Each job1 In q
                Dim qact = (From row In dc.tblJobActivities Where CInt(row.nJobID) = job1.nID Order By row.dateEntered Descending Take 1)
                If qact.Count > 0 Then
                    If qact.First.ActivityType.ToUpper.Trim = JobActivityTypes.WaitingOnSalesperson Then
                        'means the final activity is waiting on sales
                        ret.Add(job1)
                    End If
                End If

            Next


            Return ret

        End Get
    End Property

    Public ReadOnly Property ApprovedSWOlist() As ObservableCollection(Of tblSWOPending)
        Get
            Try
                'show job-loccode and customer name
                dc.Refresh(RefreshMode.KeepChanges)
                Dim qSWO = (From row In dc.tblSWOPendings Where row.sStatus.ToUpper.Trim = "supervisor" Order By row.dateOrderBy Descending)
                Return New ObservableCollection(Of tblSWOPending)(qSWO.ToList)

            Catch ex As Exception
                MessageBox.Show("error in PendingSWO " & ex.Message)
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property nickname As String
        Get
            Return global_Nickname
        End Get
    End Property

    Private Sub OpenSWOPending(e As RoutedEventArgs)
        If e.GetType Is GetType(MouseButtonEventArgs) Then
            Dim mbeargs As MouseButtonEventArgs = DirectCast(e, MouseButtonEventArgs)
            Select Case mbeargs.ClickCount
                Case 1

                Case 2  'double click
                    If e.OriginalSource.datacontext.GetType Is GetType(tblSWOPending) Then
                        e.Handled = True
                        Dim frm1 As New frmSWO1
                        frm1.LoadSWO(DirectCast(e.OriginalSource.datacontext, tblSWOPending).gid, New List(Of String))
                        frm1.ShowDialog()
                        RaisePropertyChanged("ApprovedSWOlist")

                    ElseIf e.OriginalSource.datacontext.GetType Is GetType(tJob) Then
                        Dim job1 As tJob = DirectCast(e.OriginalSource.datacontext, tJob)
                        OpenJobScreen(job1.nAddressID, job1.nID, True)
                    End If
            End Select
        End If
    End Sub

#Region "relaycommands"

    Private _cmdswo As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdswo As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdswo Is Nothing Then
                _cmdswo = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenSWOPending)
            End If
            Return _cmdswo
        End Get
    End Property

    Private _cmdjobrouted As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdjobrouted As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdjobrouted Is Nothing Then
                _cmdjobrouted = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenSWOPending)
            End If
            Return _cmdjobrouted
        End Get
    End Property

    Private _cmdjob As RelayCommand
    Public ReadOnly Property cmdjob As RelayCommand
        Get
            If _cmdjob Is Nothing Then
                _cmdjob = New RelayCommand(AddressOf OpenJob)
            End If
            Return _cmdjob
        End Get
    End Property

    Private _cmdprogramfixes As RelayCommand
    Public ReadOnly Property cmdprogramfixes As RelayCommand
        Get
            If _cmdprogramfixes Is Nothing Then
                _cmdprogramfixes = New RelayCommand(AddressOf ProgramFixes)
            End If
            Return _cmdprogramfixes
        End Get
    End Property

    Private _cmdwarehousereport As RelayCommand
    Public ReadOnly Property cmdwarehousereport As RelayCommand
        Get
            If _cmdwarehousereport Is Nothing Then
                _cmdwarehousereport = New RelayCommand(Sub()
                                                           Try
                                                               Dim frm As New frmOrdersInWarehouse
                                                               frm.Show()
                                                           Catch ex As Exception
                                                               MessageBox.Show(ex.Message)
                                                           End Try
                                                       End Sub)
            End If
            Return _cmdwarehousereport
        End Get
    End Property

    Private _cmdcreditlimits As RelayCommand
    Public ReadOnly Property cmdcreditlimits As RelayCommand
        Get
            If _cmdcreditlimits Is Nothing Then
                _cmdcreditlimits = New RelayCommand(Sub()
                                                        Try
                                                            ShowCreditLimits()
                                                        Catch ex As Exception
                                                            MessageBox.Show(ex.Message)
                                                        End Try
                                                    End Sub)
            End If
            Return _cmdcreditlimits
        End Get
    End Property

    Private _CustDoubleClick As RelayCommand
    Public ReadOnly Property CustDoubleClick As RelayCommand
        Get
            If _CustDoubleClick Is Nothing Then
                _CustDoubleClick = New RelayCommand(AddressOf CustDblClick)
            End If
            Return _CustDoubleClick
        End Get
    End Property

    Private _cmdaddaddress As RelayCommand
    Public ReadOnly Property cmdaddaddress As RelayCommand
        Get
            If _cmdaddaddress Is Nothing Then
                _cmdaddaddress = New RelayCommand(Sub()
                                                      Dim frmNewAdd As New AddressAdd
                                                      ' frmNewAdd.dc = Me.dc
                                                      frmNewAdd.ShowDialog()
                                                      Me.searchstring = frmNewAdd.txtLocCode.Text.Trim
                                                  End Sub)
            End If
            Return _cmdaddaddress
        End Get
    End Property

    Private _cmdinstallerbook As RelayCommand
    Public ReadOnly Property cmdinstallerbook As RelayCommand
        Get
            If _cmdinstallerbook Is Nothing Then
                _cmdinstallerbook = New RelayCommand(Sub()
                                                         Try
                                                             Dim frmIn As New frmInstallerBook
                                                             frmIn.Show()
                                                         Catch ex As Exception
                                                             MessageBox.Show(ex.Message)
                                                         End Try


                                                     End Sub)
            End If
            Return _cmdinstallerbook
        End Get
    End Property

    Private _cmdsupplierreport As RelayCommand
    Public ReadOnly Property cmdsupplierreport As RelayCommand
        Get
            If _cmdsupplierreport Is Nothing Then
                _cmdsupplierreport = New RelayCommand(Sub()
                                                          Try
                                                              Dim frm As New rptSupplier
                                                              frm.Show()
                                                          Catch ex As Exception
                                                              MessageBox.Show(ex.Message)
                                                          End Try


                                                      End Sub)
            End If
            Return _cmdsupplierreport
        End Get
    End Property

    Private _cmdcurrentaccounts As RelayCommand
    Public ReadOnly Property cmdcurrentaccounts As RelayCommand
        Get
            If _cmdcurrentaccounts Is Nothing Then
                _cmdcurrentaccounts = New RelayCommand(Sub()
                                                           Try
                                                               Dim frm As New rptCurrentAcct
                                                               frm.Show()
                                                           Catch ex As Exception
                                                               MessageBox.Show(ex.Message)
                                                           End Try


                                                       End Sub)
            End If
            Return _cmdcurrentaccounts
        End Get
    End Property

    Private _cmdsalestotals As RelayCommand
    Public ReadOnly Property cmdsalestotals As RelayCommand
        Get
            If _cmdsalestotals Is Nothing Then
                _cmdsalestotals = New RelayCommand(Sub()
                                                       Try
                                                           Dim frm As New winSalesTotals ' New rptSales
                                                           frm.ShowDialog()
                                                       Catch ex As Exception
                                                           MessageBox.Show(ex.Message)
                                                       End Try

                                                   End Sub)
            End If
            Return _cmdsalestotals
        End Get
    End Property

    Private _cmdbackorder As RelayCommand
    Public ReadOnly Property cmdbackorder As RelayCommand
        Get
            If _cmdbackorder Is Nothing Then
                _cmdbackorder = New RelayCommand(Sub()
                                                     Try
                                                         Dim frm As New rptBO
                                                         frm.Show()
                                                     Catch ex As Exception
                                                         MessageBox.Show(ex.Message)
                                                     End Try


                                                 End Sub)
            End If
            Return _cmdbackorder
        End Get
    End Property

    Private _cmddepositreport As RelayCommand
    Public ReadOnly Property cmddepositreport As RelayCommand
        Get
            If _cmddepositreport Is Nothing Then
                _cmddepositreport = New RelayCommand(Sub()
                                                         Try
                                                             Dim frm As New frmDateCriteriaDeposits
                                                             frm.Text = "Deposit Report"
                                                             frm.Show()
                                                         Catch ex As Exception
                                                             MessageBox.Show(ex.Message)
                                                         End Try

                                                     End Sub)
            End If
            Return _cmddepositreport
        End Get
    End Property

    Private _cmddepositsheet As RelayCommand
    Public ReadOnly Property cmddepositsheet As RelayCommand
        Get
            If _cmddepositsheet Is Nothing Then
                _cmddepositsheet = New RelayCommand(Sub()
                                                        Try
                                                            Dim frm As New frmCreateDeposit
                                                            frm.Show()
                                                        Catch ex As Exception
                                                            MessageBox.Show(ex.Message)
                                                        End Try

                                                    End Sub)
            End If
            Return _cmddepositsheet
        End Get
    End Property

    Private _cmdcustedit As RelayCommand
    Public ReadOnly Property cmdcustedit As RelayCommand
        Get
            If _cmdcustedit Is Nothing Then
                _cmdcustedit = New RelayCommand(Sub()
                                                    Try
                                                        If Me.selectedcust IsNot Nothing Then
                                                            Dim frm As New winEditCustomer(Me.selectedcust.lid)
                                                            frm.ShowDialog()
                                                            DoSearchCust()
                                                        End If

                                                    Catch ex As Exception
                                                        MessageBox.Show(ex.Message)
                                                    End Try

                                                End Sub)
            End If
            Return _cmdcustedit
        End Get
    End Property

    Private _cmduninvoiced As RelayCommand
    Public ReadOnly Property cmduninvoiced As RelayCommand
        Get
            If _cmduninvoiced Is Nothing Then
                _cmduninvoiced = New RelayCommand(Sub()
                                                      Try
                                                          Dim frm As New rptUnInvoiced
                                                          frm.Show()
                                                      Catch ex As Exception
                                                          MessageBox.Show(ex.Message)
                                                      End Try

                                                  End Sub)
            End If
            Return _cmduninvoiced
        End Get
    End Property

    Private _cmdinvoicealert2wkletter As RelayCommand
    Public ReadOnly Property cmdinvoicealert2wkletter As RelayCommand
        Get
            If _cmdinvoicealert2wkletter Is Nothing Then
                _cmdinvoicealert2wkletter = New RelayCommand(Sub()
                                                                 Try
                                                                     Dim frm As New windowInvoiceAltert
                                                                     frm.Show()
                                                                 Catch ex As Exception
                                                                     MessageBox.Show(ex.Message)
                                                                 End Try

                                                             End Sub)
            End If
            Return _cmdinvoicealert2wkletter
        End Get
    End Property

    Private _cmdsuppliersflex As RelayCommand
    Public ReadOnly Property cmdsuppliersflex As RelayCommand
        Get
            If _cmdsuppliersflex Is Nothing Then
                _cmdsuppliersflex = New RelayCommand(Sub()
                                                         Try
                                                             Dim frm As New rptFreeSupplier
                                                             frm.Show()
                                                         Catch ex As Exception
                                                             MessageBox.Show(ex.Message)
                                                         End Try

                                                     End Sub)
            End If
            Return _cmdsuppliersflex
        End Get
    End Property

    Private _cmdsuppliersbyweek As RelayCommand
    Public ReadOnly Property cmdsuppliersbyweek As RelayCommand
        Get
            If _cmdsuppliersbyweek Is Nothing Then
                _cmdsuppliersbyweek = New RelayCommand(Sub()
                                                           Try
                                                               Dim frm As New rptSIMPLY
                                                               frm.Show()
                                                           Catch ex As Exception
                                                               MessageBox.Show(ex.Message)
                                                           End Try

                                                       End Sub)
            End If
            Return _cmdsuppliersbyweek
        End Get
    End Property

    Private _cmdARAPsheet As RelayCommand
    Public ReadOnly Property cmdARAPsheet As RelayCommand
        Get
            If _cmdARAPsheet Is Nothing Then
                _cmdARAPsheet = New RelayCommand(Sub()
                                                     Try
                                                         Dim frm As New rptARWeeklySheet
                                                         frm.Show()
                                                     Catch ex As Exception
                                                         MessageBox.Show(ex.Message)
                                                     End Try

                                                 End Sub)
            End If
            Return _cmdARAPsheet
        End Get
    End Property

    Private _cmdtaxtableedit As RelayCommand
    Public ReadOnly Property cmdtaxtableedit As RelayCommand
        Get
            If _cmdtaxtableedit Is Nothing Then
                _cmdtaxtableedit = New RelayCommand(Sub()
                                                        Try
                                                            Dim frm As New frmTaxTableEdit
                                                            frm.Show()
                                                        Catch ex As Exception
                                                            MessageBox.Show(ex.Message)
                                                        End Try

                                                    End Sub)
            End If
            Return _cmdtaxtableedit
        End Get
    End Property

    Private _cmdaddcustomer As RelayCommand
    Public ReadOnly Property cmdaddcustomer As RelayCommand
        Get
            If _cmdaddcustomer Is Nothing Then
                _cmdaddcustomer = New RelayCommand(AddressOf AddCustomer)
            End If
            Return _cmdaddcustomer
        End Get
    End Property


    Private _cmdaddvendor As RelayCommand
    Public ReadOnly Property cmdaddvendor As RelayCommand
        Get
            If _cmdaddvendor Is Nothing Then
                _cmdaddvendor = New RelayCommand(AddressOf newvendor)
            End If
            Return _cmdaddvendor
        End Get
    End Property

    Private _cmdkcshipping As RelayCommand
    Public ReadOnly Property cmdkcshipping As RelayCommand
        Get
            If _cmdkcshipping Is Nothing Then
                _cmdkcshipping = New RelayCommand(Sub()
                                                      Dim frmRec As New frmShippingScan
                                                      frmRec.ShowDialog()
                                                  End Sub)
            End If
            Return _cmdkcshipping
        End Get
    End Property

    Private _cmdmanageshipping As RelayCommand
    Public ReadOnly Property cmdmanageshipping As RelayCommand
        Get
            If _cmdmanageshipping Is Nothing Then
                _cmdmanageshipping = New RelayCommand(Sub()
                                                          Dim frm1 As New frmScheduleJobs
                                                          frm1.Show()
                                                      End Sub)
            End If
            Return _cmdmanageshipping
        End Get
    End Property

    Private _cmdbinsandwarehouse As RelayCommand
    Public ReadOnly Property cmdbinsandwarehouse As RelayCommand
        Get
            If _cmdbinsandwarehouse Is Nothing Then
                _cmdbinsandwarehouse = New RelayCommand(Sub()
                                                            Dim frm1 As New frmBinsWarehouse
                                                            frm1.ShowDialog()
                                                        End Sub)
            End If
            Return _cmdbinsandwarehouse
        End Get
    End Property

    Private _cmdabelsetc As RelayCommand
    Public ReadOnly Property cmdabelsetc As RelayCommand
        Get
            If _cmdabelsetc Is Nothing Then
                _cmdabelsetc = New RelayCommand(Sub()
                                                    Dim frm1 As New frmLabelsHardware
                                                    frm1.ShowDialog()
                                                End Sub)
            End If
            Return _cmdabelsetc
        End Get
    End Property

    Private _cmdkcreceiving As RelayCommand
    Public ReadOnly Property cmdkcreceiving As RelayCommand
        Get
            If _cmdkcreceiving Is Nothing Then
                _cmdkcreceiving = New RelayCommand(Sub()
                                                       Dim frmRec As New frmReceivingStatus
                                                       frmRec.ShowDialog()
                                                   End Sub)
            End If
            Return _cmdkcreceiving
        End Get
    End Property

    Private _cmdreceiving As RelayCommand
    Public ReadOnly Property cmdreceiving As RelayCommand
        Get
            If _cmdreceiving Is Nothing Then
                _cmdreceiving = New RelayCommand(Sub()
                                                     Dim frmRec As New Receiving
                                                     frmRec.ShowDialog()
                                                 End Sub)
            End If
            Return _cmdreceiving
        End Get
    End Property

    Private _cmdcashreceipts As RelayCommand
    Public ReadOnly Property cmdcashreceipts As RelayCommand
        Get
            If _cmdcashreceipts Is Nothing Then
                _cmdcashreceipts = New RelayCommand(Sub()
                                                        Dim frm1 As New frmCashReceiptDateCriteria
                                                        frm1.ShowDialog()
                                                    End Sub)
            End If
            Return _cmdcashreceipts
        End Get
    End Property

    Private _cmdshipping As RelayCommand
    Public ReadOnly Property cmdshipping As RelayCommand
        Get
            If _cmdshipping Is Nothing Then
                _cmdshipping = New RelayCommand(Sub()
                                                    Dim frmShip1 As New Shipping
                                                    frmShip1.ShowDialog()
                                                End Sub)
            End If
            Return _cmdshipping
        End Get
    End Property

    Private _cmdcommissions As RelayCommand
    Public ReadOnly Property cmdcommissions As RelayCommand
        Get
            If _cmdcommissions Is Nothing Then
                _cmdcommissions = New RelayCommand(AddressOf commissions)
            End If
            Return _cmdcommissions
        End Get
    End Property
#End Region

End Class


Public Class file1

    Inherits MyViewModelBase
    Public nid As Integer
    Public Property field1 As String
    Public Property field2 As String

    Sub New(_nid As Integer, _field1 As String, _field2 As String)
        nid = _nid
        field1 = _field1
        field2 = _field2
    End Sub

    Sub New()
    End Sub

    Public Sub OpenJob(e As RoutedEventArgs)
        Try

            If e.GetType Is GetType(MouseButtonEventArgs) Then
                Dim mbeargs As MouseButtonEventArgs = DirectCast(e, MouseButtonEventArgs)
                If mbeargs.ClickCount = 2 Then

                    e.Handled = True

                    OpenJobScreen(Me.nid, 0, False)
                End If
            Else
                'some other event args are coming in ?
            End If

        Catch ex As Exception
            MessageBox.Show("error in OpenJob " & ex.Message)
        End Try
    End Sub

#Region "relaycommands"
    'Private _cmdjobold As RelayCommand
    'Public ReadOnly Property cmdjobold As RelayCommand
    '    Get
    '        If _cmdjobold Is Nothing Then
    '            _cmdjobold = New RelayCommand(AddressOf OpenJobOld)
    '        End If
    '        Return _cmdjobold
    '    End Get
    'End Property
    Private _cmdjob As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdjob As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdjob Is Nothing Then
                _cmdjob = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenJob)
            End If
            Return _cmdjob
        End Get
    End Property
#End Region

End Class

Public Class job1

    Inherits MyViewModelBase

    Public nid As Integer
    Public naddressid As Integer
    Public sJobDesc As String
    Public sAddressDesc As String
    Public sJobNo As String
    Public sLocCode As String
    Public Property field1 As String
    Public Property field2 As String

    Sub New(_nid As Integer, _naddressid As Integer, _field1 As String, _field2 As String)
        nid = _nid
        naddressid = _naddressid
        field1 = _field1
        field2 = _field2
    End Sub

    Sub New()
    End Sub

    Public Sub OpenJobOld()
        Try
            OpenJobScreen(Me.naddressid, Me.nid, False)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub OpenJob(e As RoutedEventArgs)
        Try
            If e.GetType Is GetType(MouseButtonEventArgs) Then
                Dim mbeargs As MouseButtonEventArgs = DirectCast(e, MouseButtonEventArgs)

                If mbeargs.ClickCount = 2 Then
                    e.Handled = True
                    OpenJobScreen(Me.naddressid, Me.nid, False)
                End If
            Else
                'some other event args are coming in ?
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "relaycommands"
 
    Private _cmdjob As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdjob As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdjob Is Nothing Then
                _cmdjob = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenJob)
            End If
            Return _cmdjob
        End Get
    End Property
#End Region

End Class
