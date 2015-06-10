Imports System.Linq
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight
Imports System.IO

Public Class vmJob

    Inherits MyViewModelBase

    Private PO4040, PO4020, PO4010, PO4030, PO4070 As Decimal
    Private SO4040, SO4020, SO4010, SO4030, SO4070 As Decimal
    Public SOALLITEMS As Decimal

    'old style windows.forms printing objects, not yet converted to WPF
    Private WithEvents PrintDocument8x11 As New System.Drawing.Printing.PrintDocument
    Private WithEvents PrintDocument11x17 As New System.Drawing.Printing.PrintDocument
    Private imageToPrint As System.Drawing.Image

    Private dc1 As linqTKSIDataContext = GetLinqDataContext()

    Private _bljobactivity As BindingList(Of tblJobActivity)
    Public Property bljobactivity As BindingList(Of tblJobActivity)
        Get
            _bljobactivity = New BindingList(Of tblJobActivity)
            If tjob IsNot Nothing Then
                Dim q = (From row In dc1.tblJobActivities Where row.nJobID = Me.tjob.nID Order By row.dateEntered)
                For Each ja In q
                    _bljobactivity.Add(ja)
                Next
            End If


            Return _bljobactivity
        End Get
        Set(value As BindingList(Of tblJobActivity))
            _bljobactivity = value
            RaisePropertyChanged("bljobactivity")
        End Set
    End Property

    Private _listemployees As BindingList(Of String)
    Public ReadOnly Property listemployees As BindingList(Of String)
        Get
            If _listemployees Is Nothing Then
                _listemployees = New BindingList(Of String)
                Dim q = (From row In dc1.tEmployees Where row.archive = False)
                For Each emp1 In q
                    _listemployees.Add(emp1.nickname)
                Next
                _listemployees.Add("")
            End If
            Return _listemployees
        End Get
    End Property

    Private Property selectedpo As tPOHeader

    Public ReadOnly Property JobsAndPOs As BindingList(Of Object)
        Get
            Dim bl As New BindingList(Of Object)
            For Each j In tjobs
                bl.Add(j)
                For Each po In (From row In j.tPOHeaders Order By row.sPONumSortable)
                    bl.Add(po)
                Next
            Next
            Return bl
        End Get
    End Property

    Private _newactivity As String = ""
    Public Property NewActivity As String
        Get
            Return _newactivity
        End Get
        Set(value As String)
            _newactivity = value
            RaisePropertyChanged("NewActivity")
        End Set
    End Property

    Private _decCreditUsed As Decimal?
    Public Property decCreditUsed() As Decimal
        Get
            Try
                If _decCreditUsed Is Nothing Then  'so we dont recompute this value several times
                    _decCreditUsed = 0
                    Dim lines = (From row In dc1.tSOLines Where row.tSOHeader.nCustID = tjob.nCustID Where row.sType.ToUpper = "COMMENT" Select row.nAmount).Sum(Function(a) CType(a, Decimal?))
                    If lines IsNot Nothing Then
                        _decCreditUsed = lines
                    End If
                End If
                Return _decCreditUsed

            Catch ex As Exception
                Return -999
            End Try
        End Get
        Set(value As Decimal)
            _decCreditUsed = value
        End Set
    End Property

    Public ReadOnly Property CreditUsed As String
        Get
            If tjob IsNot Nothing Then
                If tjob.tCustomr.dCrLimit = 0 Then
                    Return "N/A"
                Else
                    Return decCreditUsed.ToString("C")
                End If

            End If
            Return ""
        End Get
    End Property

    Dim creditlimit As Decimal = 0

    Public ReadOnly Property CreditUsedOverLimitBrush As Brush
        Get
            Dim brushReturn As New SolidColorBrush(Color.FromRgb(&HEE, &HEE, &HEE))
            'Brushes.LightGray
            Try
                If tjob IsNot Nothing Then
                    creditlimit = tjob.tCustomr.dCrLimit
                    If creditlimit <> 0.0 Then
                        brushReturn = Brushes.LimeGreen
                    End If
                    If tjob.sTerms.ToUpper.Contains("NET") Then
                        Dim used = decCreditUsed()
                        If used > creditlimit Then
                            brushReturn = Brushes.Pink
                        End If
                    End If

                End If

            Catch
            End Try

            Return brushReturn
        End Get
    End Property

    Public Sub LoadJobNewDataContext(_nAddressID As Integer, _nJobID As Integer)

        Try

            Me.dc1 = GetLinqDataContext()
            Me.tjob = Nothing
            Me.tjobs = Nothing
            Me.NewActivity = ""

            Dim qAdd = (From row In dc1.tAddresses Where row.nID = _nAddressID)
            If qAdd.Count = 1 Then
                Address = qAdd.Single
                Dim qAllJobs = (From row In dc1.tJobs Where row.nAddressID = _nAddressID Order By row.sJobNo.PadRight(13, "0"))
                tjobs = New BindingList(Of tJob)(qAllJobs.ToList)
                If _nJobID > 0 Then
                    Dim qJob = (From row In dc1.tJobs Where row.nID = _nJobID)
                    If qJob.Count > 0 Then
                        Dim job1 = qJob.Single
                        Me.tjob = job1

                    Else
                        MessageBox.Show("could not locate job ID:" & _nJobID)
                    End If
                Else
                    'only show address info, job pane should be disabled, for selection from multiple jobs
                    'if there only exists one job, then show it
                    If tjobs.Count = 1 Then
                        Me.tjob = tjobs.Single

                    End If
                End If

            Else
                MessageBox.Show("error address ID not found: " & _nAddressID)
            End If

            RaiseAllPropertyChanged()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RefreshJobMessegeFromOutside(_job As tJob)
        If _tjob.nID = Me.tjob.nID Then
            SaveJobAndReload(False)
        End If
    End Sub

    Public ReadOnly Property HasChanges() As Boolean
        Get
            If dc1.GetChangeSet.Updates.Count > 0 Or dc1.GetChangeSet.Deletes.Count > 0 Or dc1.GetChangeSet.Inserts.Count > 0 Then
                Return True
            ElseIf NewActivity.Length > 0 Then
                Return True
            End If

            Return False
        End Get
    End Property

    Private _blswo As BindingList(Of tblSWOPending)
    Public ReadOnly Property blswo As BindingList(Of tblSWOPending)
        Get
            _blswo = New BindingList(Of tblSWOPending)

            If tjobs IsNot Nothing Then
                Dim listSWO = New List(Of tblSWOPending)  'get all SWOs for all jobs in thiis address and then order them by date
                For Each j In tjobs
                    For Each swo In j.tblSWOPendings
                        listSWO.Add(swo)
                    Next
                Next
                For Each swo In (From row In listSWO Order By row.dateCreated Descending)
                    _blswo.Add(swo)
                Next
            End If

            Return _blswo
        End Get
    End Property

    Private _listinvoices As BindingList(Of tSOHeader)
    Public Property listinvoices As BindingList(Of tSOHeader)
        Get
            If tjob IsNot Nothing Then
                _listinvoices = tjob.tSOHeaders.GetNewBindingList
            End If

            Return _listinvoices
        End Get
        Set(value As BindingList(Of tSOHeader))
            _listinvoices = value
            RaisePropertyChanged("listinvoices")
        End Set
    End Property

    Private _tjobs As BindingList(Of tJob)
    Public Property tjobs As BindingList(Of tJob)
        Get
            Return _tjobs
        End Get
        Set(value As BindingList(Of tJob))
            _tjobs = value
            RaisePropertyChanged("tjobs")
        End Set
    End Property

    Private _Address As tAddress
    Public Property Address As tAddress
        Get
            Return _Address
        End Get
        Set(value As tAddress)
            _Address = value
            RaisePropertyChanged("Address")
        End Set
    End Property

    Private Sub DeleteJob()

        SaveJobAndReload()

        If Me.tjob IsNot Nothing Then
            If Me.tjob.tSOHeaders.Count = 0 And Me.tjob.tPOHeaders.Count = 0 Then
                If MessageBox.Show("Are you sure you want to delete this job?", "delete job?", MessageBoxButton.YesNo) = MessageBoxResult.Yes Then
                    Me.dc1.tJobs.DeleteOnSubmit(Me.tjob)
                    Me.dc1.SubmitChanges()

                    LoadJobNewDataContext(Me.Address.nID, 0)
                End If

            Else
                MessageBox.Show("Cannot delete job with an existing PO or Invoice.")
            End If
        Else
            MessageBox.Show("No job selected to delete")
        End If
    End Sub

    Private Function AddSO(ByRef sTAXID As String) As Boolean

        Try
            Dim taxable As Decimal

            If Me.tjob IsNot Nothing Then

                Dim drSo As New tSOHeader
                With drSo
                    '.tJob = Me.tjob
                    .dinvoice = _tjob.dJobCreated
                    .nJobID = _tjob.nID
                    .nSimplySequence = 0
                    .sTerms = _tjob.sTerms

                    '.dmailed STAYS NULL until invoice is actually mailed out

                    If Not _tjob.tAddress Is Nothing Then
                        .sShipTo1 = _tjob.tAddress.sAddress1
                        .sShipTo2 = _tjob.tAddress.sAddress2
                        .sShipToCity = _tjob.tAddress.sCity
                        .sShipToCounty = _tjob.tAddress.sCounty
                        .sShipToState = _tjob.tAddress.sState
                        .sShipToZip = _tjob.tAddress.sZip
                    End If

                    If Not _tjob.tCustomr Is Nothing Then
                        .sName = _tjob.tCustomr.sName
                    End If

                    .nCustID = _tjob.nCustID
                    ' .tCustomr = tJob.tCustomr

                    .sSONum = _tjob.sJobNo
                    .sFOB = ""
                    .sOurOrder = ""
                    .sVIA = ""
                    .sYourOrder = ""

                    .nTotal = 0
                    .nTaxRate = 0

                End With
                dc1.tSOHeaders.InsertOnSubmit(drSo)
                dc1.SubmitChanges()

                Dim l4010 As Integer
                Dim l4020 As Integer
                Dim l4030 As Integer
                Dim l4040 As Integer
                Dim l4070 As Integer

                If Len(sTAXID) > 3 Then
                    l4010 = 4210
                    l4020 = 4220
                    l4030 = 4230
                    l4040 = 4240
                    l4070 = 4270
                Else
                    l4010 = 4010
                    l4020 = 4020
                    l4030 = 4030
                    l4040 = 4040
                    l4070 = 4070
                End If

                Me.InitAccountTotals(tjob)

                AddSOLine(drSo, "Comment", "Description of Invoice Goes Here")
                AddSOLine(drSo, "Comment", "")

                If (PO4010) > 0 Or PO4070 > 0 Or PO4030 > 0 Then
                    AddSOLine(drSo, "Item", "Cabinetry", l4010, (PO4010))
                    AddSOLine(drSo, "Comment", "Cabinetry", , (PO4010 + PO4070 + PO4030))
                    taxable = taxable + (PO4010)
                End If
                If (PO4020) > 0 Then
                    AddSOLine(drSo, "Item", "Tops", l4020, (PO4020))
                    AddSOLine(drSo, "Comment", "Tops", , (PO4020))
                    taxable = taxable + (PO4020)
                End If
                If (PO4030) > 0 Then
                    AddSOLine(drSo, "Item", "Hardware", l4030, (PO4030))
                    '    Inv.AddLine "Comment", "Hardware", , (PO4030)
                    taxable = taxable + (PO4030)
                End If

                If (PO4070) > 0 Then
                    AddSOLine(drSo, "Item", "Freight", l4070, (PO4070))
                    taxable = taxable + (PO4070)
                End If

                If (PO4040) > 0 Then
                    AddSOLine(drSo, "Item", "Labor", l4040, (PO4040))
                    AddSOLine(drSo, "Comment", "Labor", , (PO4040))
                End If

                If taxable > 0 Then
                    If Len(sTAXID) > 3 Then
                        AddSOLine(drSo, "Comment", sTAXID, , 0)
                    Else
                        AddTaxItemLinesPerAccountCode(taxable, drSo)
                        AddSOLine(drSo, "Comment", "SALES TAX @ " & (Decimal.Round(CDec(tjob.nTaxRate), 2)) & "%", , Decimal.Round(CDec(tjob.nTaxRate * taxable) / 100, 2))
                        AddSOLine(drSo, "Comment", "")
                        AddSOLine(drSo, "Balance", "TOTAL", , PO4040 + taxable + Decimal.Round(CDec(tjob.nTaxRate * taxable) / 100, 2))
                    End If
                Else
                    AddSOLine(drSo, "Comment", "")
                    AddSOLine(drSo, "Balance", "TOTAL", , PO4040)
                End If
                dc1.SubmitChanges()
                Return True
                'End If

            Else
                MessageBox.Show("error: no job loaded")
            End If

        Catch ex As Exception

            Windows.Forms.MessageBox.Show("Error saving SO. " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub InitAccountTotals(ByVal drJob As tJob) ' dsTKSI.tJobRow)

        '   Dim drPO As dsTKSI.tPOHeaderRow
        PO4010 = 0
        PO4020 = 0
        PO4030 = 0
        PO4040 = 0
        PO4070 = 0
        For Each drPO In drJob.tPOHeaders '.GettPOHeaderRows

            Select Case drPO.nAccount
                Case 4010
                    PO4010 = PO4010 + drPO.nRetailSale + drPO.nAdd
                Case 4020
                    PO4020 = PO4020 + drPO.nRetailSale + drPO.nAdd
                Case 4030
                    PO4030 = PO4030 + drPO.nRetailSale + drPO.nAdd
                Case 4040
                    PO4040 = PO4040 + drPO.nRetailSale + drPO.nAdd
            End Select
            PO4070 = PO4070 + drPO.nRetailFreight
        Next

        '    Dim drSOLine As dsTKSI.tSOLineRow

        SO4010 = 0
        SO4020 = 0
        SO4030 = 0
        SO4040 = 0
        SO4070 = 0
        SOALLITEMS = 0

        '  Dim drSO As dsTKSI.tSOHeaderRow
        For Each drSO In drJob.tSOHeaders ' .GettSOHeaderRows
            For Each drSOLine In drSO.tSOLines '.GettSOLineRows
                Select Case drSOLine.nAccountID
                    Case Is > 0
                        SOALLITEMS += drSOLine.nAmount
                    Case 4010
                        SO4010 += drSOLine.nAmount
                    Case 4020
                        SO4020 += drSOLine.nAmount
                    Case 4030
                        SO4030 += drSOLine.nAmount
                    Case 4040
                        SO4040 += drSOLine.nAmount
                    Case 4070
                        SO4070 += drSOLine.nAmount
                End Select
            Next
        Next
    End Sub

    Private Sub AddTaxItemLinesPerAccountCode(ByVal taxable As Decimal, ByVal drSO As tSOHeader)
        Dim q = (From row In dc1.tblJobTaxes Where row.nJobID = drSO.nJobID)
        For Each jobtax In q
            AddSOLine(drSO, "Item", jobtax.TaxName, jobtax.TaxCode, System.Math.Round((jobtax.TaxPercent * taxable) / 100, 2))
        Next

    End Sub

    Private Function AddSOLine(drSO As tSOHeader, Optional ByVal stype As String = "Comment", Optional ByVal sDesc As String = "", Optional ByVal Account As Integer = 0, Optional ByVal Amount As Decimal = 0) As tSOLine
        Try
            Dim lastLineNo As Integer
            If drSO.tSOLines.Count > 0 Then
                lastLineNo = (From row In drSO.tSOLines Select row.nLineNumber).Max
            Else
                lastLineNo = 0
            End If

            Dim drLine As New tSOLine
            With drLine
                .tSOHeader = drSO
                '   .nSOID = drSO.nID
                .nLineNumber = lastLineNo + 1
                .sDesc = sDesc
                .sType = stype
                .nAmount = Amount
                .nAccountID = Account
                .bTaxable = False
                .sHidden = False
            End With

            dc1.tSOLines.InsertOnSubmit(drLine)

            Return drLine
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Function

    Private Sub addinvoice()
        If tjob IsNot Nothing Then
            ShowBusyPopup()

            SaveJobAndReload()
            AddSO(tjob.sInvNotes)
            SaveJobAndReload()

            CloseBusyPopup()
        Else
            MessageBox.Show("no job selected to add invoice.")
        End If
    End Sub

    Private Sub AddPO()

        ShowBusyPopup()

        Try
            SaveJobAndReload()
            Dim tempVendor As Integer = 477
            If Me.tjob IsNot Nothing Then
                If Me.tjob.tPOHeaders.Count > 0 Then
                    tempVendor = Me.tjob.tPOHeaders(0).nVendorID
                End If

                Dim drPO As New tPOHeader
                With drPO
                    .tJob = Me.tjob
                    ' .nJobID = drJob.nID  Do not need to do this, since it happens with .tjob =
                    .nCheckNo = 0
                    .nAccount = 4010
                    .nAdd = 0
                    .nBoxes = 0
                    .nInvNo = 0
                    .nPOSort = 0
                    .nRetailFreight = 0
                    .nRetailSale = 0
                    .nSaleAccount = 0
                    .nsalesadjust = 0
                    .nTotal = 0
                    .nTruck = 1
                    .nVendorID = tempVendor
                    .sAdjustReason = ""
                    .sBackOrder = ""
                    .sTerms = "Net 30"
                    .dPODate = Today
                    .dRequired = Today.Date
                    .sConf = ""
                    .sPONum = Me.tjob.sJobNo & "-"
                    .sPOType = "PO"
                    .SRECNOTES = ""
                    .SDELNOTES = ""
                    .sFilter = ""
                    .sFOB = ""
                    .sItemDesc = ""
                    .sItems = ""
                    .sVia = ""
                    .sShipTo1 = ""
                    .sShipTo2 = ""
                    .sShipToCity = ""
                    .sShiptoCounty = ""
                    .sShipToState = ""
                    .sShipToZip = ""
                    .bSimply = False
                    .sEnteredBy = ""
                    .sCurActNote = ""

                    If Not Me.tjob.tAddress Is Nothing Then
                        With Me.tjob.tAddress
                            drPO.sShipTo1 = .sAddress1 & " " & .sAddress2
                            drPO.sShipTo2 = ""
                            drPO.sShipToCity = .sCity
                            drPO.sShiptoCounty = .sCounty
                            drPO.sShipToState = .sState
                            drPO.sShipToZip = .sZip

                        End With
                    End If
                    If Not Me.tjob.tCustomr Is Nothing Then
                        .sShipto3 = Me.tjob.tCustomr.sName
                    End If

                    Me.dc1.tPOHeaders.InsertOnSubmit(drPO)
                    Me.dc1.SubmitChanges()

                    SaveJobAndReload()

                End With

            Else
                MessageBox.Show("error no job loaded ")
            End If

            CloseBusyPopup()

        Catch ex As Exception
            CloseBusyPopup()
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
        End Try
    End Sub

    Private Sub ChangeJobAddress()
        Try
            Dim editJob As New JobAddressView
            editJob.DataContext = Me
            editJob.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ChangeCustomer()
        Try
            Dim blnAllowChange = True

            If tjob IsNot Nothing Then
                If tjob.tSOHeaders.Count > 0 Then
                    For Each inv In tjob.tSOHeaders
                        If inv.dsimply IsNot Nothing Then
                            blnAllowChange = False  ' cannot change customer if invoice is already sent to accounting
                            MessageBox.Show("An Invoice for this Job has already been sent to accounting so the customer cannot be changed")
                        ElseIf inv.dmailed IsNot Nothing Then
                            MessageBox.Show("The Invoice for this Job has already been mailed, so please double check the mailing status.")
                        End If
                    Next
                End If
            Else
                blnAllowChange = False  ' no job loaded
                MessageBox.Show("No Job loaded")
            End If

            If blnAllowChange Then
                Dim winCust As New winSelectCustomer
                winCust.ShowDialog()
                Try
                    Dim cust1 = DirectCast(winCust.DataContext, vmSelectCust).selectedcust
                    If cust1 IsNot Nothing Then
                        Dim q = (From row In Me.dc1.tCustomrs Where row.lID = cust1.lid)
                        If q.Count = 1 Then
                            Me.tjob.tCustomr = q.Single
                            Me.SaveJobAndReload()
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("no customer selected ")
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SaveJobAndReload(Optional _RunChecksOnJobScreen As Boolean = True)
        Try
            If Me.tjob IsNot Nothing Then
                Dim addid = Me.tjob.nAddressID
                Dim jobid = Me.tjob.nID

                StartTimer()

                Try
                    If _RunChecksOnJobScreen Then
                        If tjob.tCustomr.dCrLimit > 0 AndAlso tjob.sTerms IsNot Nothing AndAlso (tjob.sTerms = "50-50" Or tjob.sTerms = "50-40-10") Then
                            MessageBox.Show("Customer has a credit limit, but Terms are set to 50-50, they may get billed the final 50.")
                        End If
                    End If
                Catch
                End Try

                If Me.HasChanges Then

                    DataFunctions.SaveJob(Me.tjob)
                    Try
                        If NewActivity.Length > 0 Then
                            DataFunctions.SaveJobActivity(jobid, NewActivity)
                        End If
                    Catch ex As Exception
                        global_EmailErrorLog("error in SaveJobAndReload newactivity jobid: " & Me.tjob.nID & " " & ex.Message)
                    End Try

                End If

                Me.LoadJobNewDataContext(addid, jobid)

                EndTimer(2, " long save job screen save ")
            Else
                MessageBox.Show("No job loaded.")
            End If
        Catch ex As Exception
            global_EmailErrorLog("error in SaveJobAndReload " & ex.Message)
            MessageBox.Show("error saving and reloading job " & ex.Message)
        End Try

    End Sub

    Public Sub CancelJobChanges2()
        Try
            RaisePropertyChanged("HasChanges")
        Catch ex As Exception
            MessageBox.Show("error saving changes " & ex.Message)
        End Try

    End Sub

    Dim winbusy1 As winBusy
    Private Sub ShowBusyPopup()
        Try
            If winbusy1 IsNot Nothing Then
                winbusy1.Close()
            End If
        Catch
        End Try
        Try
            winbusy1 = New winBusy
            winbusy1.Show()
        Catch
        End Try
    End Sub

    Private Sub CloseBusyPopup()
        Try
            If winbusy1 IsNot Nothing Then
                winbusy1.Close()
            End If
        Catch
        End Try
    End Sub

    Private Sub addjob()

        Try
            ''save existing job before you continue to new PO screen
            If HasChanges Then
                If MessageBox.Show("Save existing changes first?", "save?", MessageBoxButton.YesNo) Then
                    Me.SaveJobAndReload()
                End If
            End If

            If Me.Address IsNot Nothing Then

                Dim CustSearch As New CustSearch
                CustSearch.ShowDialog()
                Dim qcust = (From row In dc1.tCustomrs Where row.lID = CustSearch.lID)

                If qcust.Count > 0 Then

                    ShowBusyPopup()

                    Try
                        Dim newjob = DataFunctions.NewJob(Me.Address, qcust.Single)

                        Me.tjobs.Add(newjob)
                        Me.dc1.SubmitChanges()
                        Me.tjob = newjob

                        Me.SaveJobAndReload()

                        CloseBusyPopup()
                    Catch ex As Exception
                        CloseBusyPopup()
                        MessageBox.Show("error adding job " & ex.Message)
                    End Try

                Else
                    MessageBox.Show("error customer not selected")
                End If
            Else
                MessageBox.Show("error no valid address selected")
            End If

        Catch ex As Exception
            MessageBox.Show("error adding job " & ex.Message)
        End Try

    End Sub

    Private _tjob As tJob
    Public Property tjob As tJob
        Get
            Return _tjob
        End Get
        Set(value As tJob)
            _tjob = value

            Messaging.Messenger.Default.Unregister(Of tJob)(Me)
            If _tjob IsNot Nothing Then
                Messaging.Messenger.Default.Register(Of tJob)(Me, _tjob.nID, AddressOf RefreshJobMessegeFromOutside)

            End If
            'ensure this selected job is the only one selected/highlighted
            If tjobs IsNot Nothing Then
                For Each j In tjobs  'unselect all other jobs
                    j.isSelected = False
                Next
            End If

            If _tjob IsNot Nothing Then
                _tjob.isSelected = True
            End If

            Me.selectedimage = ""
            RaiseAllPropertyChanged()

            Me.SendFocusMsg(FocusMessage.topboxfocus)
        End Set
    End Property

    Private Sub RaiseAllPropertyChanged()
        RaisePropertyChanged("tjob")
        RaisePropertyChanged("tjobs")
        RaisePropertyChanged("listinvoices")
        RaisePropertyChanged("HasChanges")
        RaisePropertyChanged("listimages")
        RaisePropertyChanged("blswo")
        RaisePropertyChanged("bljobactivity")
        RaisePropertyChanged("JobsAndPOs")

    End Sub

    Private Sub OpenJOBPOorSWO(e As RoutedEventArgs)

        If e.GetType Is GetType(MouseButtonEventArgs) Then
            Dim mbeargs As MouseButtonEventArgs = DirectCast(e, MouseButtonEventArgs)
            Select Case mbeargs.ClickCount

                Case 1
                    If e.OriginalSource.datacontext.GetType Is GetType(tJob) Then
                        e.Handled = True

                        Dim jb1 = DirectCast(e.OriginalSource.datacontext, tJob)
                        If tjob Is Nothing Then
                            tjob = jb1
                        Else
                            If jb1.nID <> Me.tjob.nID Then
                                Me.tjob = jb1
                            End If
                        End If


                    ElseIf e.OriginalSource.datacontext.GetType Is GetType(tPOHeader) Then
                        Dim po = DirectCast(e.OriginalSource.datacontext, tPOHeader)
                        If tjob Is Nothing Then
                            tjob = po.tJob
                        ElseIf tjob.nID <> po.nJobID Then
                            tjob = po.tJob
                        End If
                    End If
                Case 2
                    If e.OriginalSource.datacontext.GetType Is GetType(tPOHeader) Then
                        e.Handled = True
                        Dim poid = DirectCast(e.OriginalSource.datacontext, tPOHeader).nID

                        OpenPOScreen(poid, False)

                    ElseIf e.OriginalSource.datacontext.GetType Is GetType(tblSWOPending) Then
                        e.Handled = True

                        Dim frm1 As New frmSWO1
                        frm1.LoadSWO(DirectCast(e.OriginalSource.datacontext, tblSWOPending).gid, listimages.ToList)
                        frm1.ShowDialog()

                        SaveJobAndReload()

                    End If
            End Select
        Else
            'some other event args are coming in ?
        End If

    End Sub

    Private Sub SelectJob(sel As Object)
        If sel.GetType Is GetType(tPOHeader) Then
            Me.selectedpo = DirectCast(sel, tPOHeader)
        End If
    End Sub

    Private _image1 As BitmapImage
    Public Property image1 As BitmapImage
        Get
            Return _image1
        End Get
        Set(value As BitmapImage)
            _image1 = value
            RaisePropertyChanged("image1")
        End Set
    End Property

    Private Sub OpenImage(e As RoutedEventArgs)
        Dim x As New clsPDFCreate("jobimage", False, False)
        x.InsertImage8x11(selectedimage)
        x.ShowPDF()
    End Sub

    Public Sub OpenInvoice(e As RoutedEventArgs)
        Try

            If e.GetType Is GetType(MouseButtonEventArgs) Then
                Dim mbeargs As MouseButtonEventArgs = DirectCast(e, MouseButtonEventArgs)
                If mbeargs.ClickCount = 2 Then
                    If e.OriginalSource.datacontext.GetType Is GetType(tSOHeader) Then

                        Dim SOID = DirectCast(e.OriginalSource.datacontext, tSOHeader).nID

                        e.Handled = True
                        If Me.HasChanges Then
                            If MessageBox.Show("Save job changes?", "save changes?", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then
                                SaveJobAndReload()  'this creates a new datacontext
                            End If
                        End If

                        Dim inv1 As New frmInvoice
                        inv1.LoadInvoice(SOID)
                        inv1.ShowDialog()
                        SaveJobAndReload()

                    End If
                Else
                    'one click?
                End If
            Else
                'some other event args are coming in ?
            End If

        Catch ex As Exception
            MessageBox.Show("error in OpenJob " & ex.Message)
        End Try
    End Sub

    Public Sub DeleteSWO()
        Try
            If selectedswo IsNot Nothing Then
                DataFunctions.DeleteSWO(selectedswo.gid)
                '  Me.dc1.tblSWOPendings.DeleteOnSubmit(selectedswo)
                SaveJobAndReload()
            Else
                MessageBox.Show("No SWO selected.")
            End If
        Catch ex As Exception
            MessageBox.Show("error in DeleteSWO " & ex.Message)
        End Try
    End Sub

    Private Sub AddSwo()
        If Not Me.tjob Is Nothing Then
            SaveJobAndReload()  'this wont be necessary eventually if the SWO create process is updated to Linq to sql

            Dim frm1 As New frmSWO1
            Dim gidSWO As Guid
            If selectedimage.Length > 0 Then
                Try
                    frm1.PictureBox1.Image = GetImageFromFile(selectedimage)
                Catch ex As Exception
                    MessageBox.Show("error adding job image to new SWO." & ex.Message)
                End Try
            End If

            gidSWO = frm1.CreateSWO(Me.tjob.nID, Me.tjob.nAddressID, tjob.nCustID, Me.tjob.sSalesperson, "SWO-PO", Me.tjob.sTerms)
            frm1.LoadSWO(gidSWO, listimages.ToList)
            frm1.ShowDialog()

            SaveJobAndReload()

        Else
            Windows.Forms.MessageBox.Show("Select a previous Job before adding an SWO.")
        End If
    End Sub

    Private _selectedimage As String = ""
    Public Property selectedimage As String
        Get
            Return _selectedimage
        End Get
        Set(value As String)
            If value Is Nothing Then
                _selectedimage = ""
            Else
                _selectedimage = value
            End If

            If _selectedimage.Length > 0 Then
                If _selectedimage.ToUpper.EndsWith(".PDF") Then
                    Process.Start(_selectedimage)
                Else
                    Dim bmi As New BitmapImage()
                    bmi.BeginInit()
                    bmi.CacheOption = BitmapCacheOption.OnLoad
                    bmi.UriSource = New Uri(value, UriKind.Absolute)
                    bmi.EndInit()

                    RenderOptions.SetBitmapScalingMode(bmi, BitmapScalingMode.HighQuality)
                    image1 = bmi
                End If

            Else
                image1 = Nothing
            End If

            RaisePropertyChanged("selectedimage")
        End Set
    End Property

    Private _selectedswo As tblSWOPending
    Public Property selectedswo As tblSWOPending
        Get
            Return _selectedswo
        End Get
        Set(value As tblSWOPending)
            _selectedswo = value
            RaisePropertyChanged("selectedswo")
        End Set
    End Property

    Private Sub OpenCommissionStructureEdit()
        SaveJobAndReload()

        Dim frmStruct As New frmCommStructEdit
        frmStruct.ShowDialog()
        If frmStruct.OK Then
            Dim q = (From row In dc1.tblCommissionStructures Where row.lngID = frmStruct.g_lngCommSelected)
            If q.Count > 0 Then
                tjob.lngCommissionStruct = q.First.lngID
                SaveJobAndReload()
            Else
                MessageBox.Show("cannot find commission structure")
            End If
        End If
    End Sub

    Public ReadOnly Property listimages As BindingList(Of String)
        Get
            image1 = Nothing

            Dim list1 As New BindingList(Of String)

            If Me.tjob IsNot Nothing Then
                Dim strJobFolderRoot = sImagesPath & Me.tjob.jobNoNumericPrefix & "\"
                Dim strJobSubFolder = strJobFolderRoot & Me.tjob.sJobNo & "\"
                Dim strJobMapsFolder = strJobFolderRoot & "MAPS\"

                If System.IO.Directory.Exists(strJobSubFolder) Then
                    Try
                        For Each tempfile In (From row In IO.Directory.GetFiles(strJobSubFolder) Order By Right(row, 6).TrimStart("/").PadLeft(9, "0"))
                            list1.Add(tempfile)
                        Next
                    Catch ex As Exception
                        list1.Add("error")
                    End Try
                End If

                If System.IO.Directory.Exists(strJobMapsFolder) Then
                    Try
                        For Each tempfile In IO.Directory.GetFiles(strJobMapsFolder)
                            list1.Add(tempfile)
                        Next
                    Catch ex As Exception
                        list1.Add("map error")
                    End Try
                End If
            End If

            Return list1
        End Get
    End Property

    Private Property _bln11x17 As Boolean = False
    Public Property bln11x17 As Boolean
        Get
            Return _bln11x17
        End Get
        Set(value As Boolean)
            _bln11x17 = value
            RaisePropertyChanged("bln11x17")
        End Set
    End Property

    Public ReadOnly Property isadminuser
        Get
            If sUserlevel < UserRights.Admin Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property isadminasstuser
        Get
            If sUserlevel <= UserRights.AdminAsst Then
                Return True
            End If
            Return False
        End Get
    End Property

    Private Sub OpenTaxEdit()
        Try
            Me.SaveJobAndReload()
            Dim frm1 As New frmJobTaxEdit
            frm1.JobID = tjob.nID
            frm1.StartPosition = Forms.FormStartPosition.CenterScreen
            frm1.ShowDialog()
            Me.SaveJobAndReload()
            Me.SendFocusMsg(FocusMessage.taxfocus)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SendFocusMsg(_msg As String)
        If Me.tjob IsNot Nothing Then
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send(Of FocusMessage)(New FocusMessage(_msg, Me.tjob.nID))
        End If
    End Sub

#Region "Commands"

    Private _cmdsave As RelayCommand
    Public ReadOnly Property cmdsave As RelayCommand
        Get
            If _cmdsave Is Nothing Then
                _cmdsave = New RelayCommand(AddressOf SaveJobAndReload)
            End If
            Return _cmdsave
        End Get
    End Property

    Private _cmdtax As RelayCommand
    Public ReadOnly Property cmdtax As RelayCommand
        Get
            If _cmdtax Is Nothing Then
                _cmdtax = New RelayCommand(AddressOf OpenTaxEdit)
            End If
            Return _cmdtax
        End Get
    End Property

    Private _cmddeljob As RelayCommand
    Public ReadOnly Property cmddeljob As RelayCommand
        Get
            If _cmddeljob Is Nothing Then
                _cmddeljob = New RelayCommand(AddressOf DeleteJob)
            End If
            Return _cmddeljob
        End Get
    End Property

    Private _cmdswo As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdswo As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdswo Is Nothing Then
                _cmdswo = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenJOBPOorSWO)
            End If
            Return _cmdswo
        End Get
    End Property

    Public ReadOnly Property cmdcommissionstructure As RelayCommand
        Get
            Return New RelayCommand(AddressOf OpenCommissionStructureEdit)
        End Get
    End Property

    Private _cmdimage As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdimage As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdimage Is Nothing Then
                _cmdimage = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenImage)
            End If
            Return _cmdimage
        End Get
    End Property

    Private _cmdinvoice As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdinvoice As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdinvoice Is Nothing Then
                _cmdinvoice = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenInvoice)
            End If
            Return _cmdinvoice
        End Get
    End Property

    Private _cmdjobpodoubleclick As RelayCommand(Of RoutedEventArgs)
    Public ReadOnly Property cmdjobpodoubleclick As RelayCommand(Of RoutedEventArgs)
        Get
            If _cmdjobpodoubleclick Is Nothing Then
                _cmdjobpodoubleclick = New RelayCommand(Of RoutedEventArgs)(AddressOf OpenJOBPOorSWO)
            End If
            Return _cmdjobpodoubleclick
        End Get
    End Property

    Private _cmdjobposelect As RelayCommand(Of Object)
    Public ReadOnly Property cmdjobposelect As RelayCommand(Of Object)
        Get
            If _cmdjobposelect Is Nothing Then
                _cmdjobposelect = New RelayCommand(Of Object)(AddressOf SelectJob)
            End If
            Return _cmdjobposelect
        End Get
    End Property

    Private _cmdaddpo As RelayCommand
    Public ReadOnly Property cmdaddpo As RelayCommand
        Get
            If _cmdaddpo Is Nothing Then
                _cmdaddpo = New RelayCommand(AddressOf AddPO)
            End If
            Return _cmdaddpo
        End Get
    End Property

    Private _cmdaddinvoice As RelayCommand
    Public ReadOnly Property cmdaddinvoice As RelayCommand
        Get

            If _cmdaddinvoice Is Nothing Then
                _cmdaddinvoice = New RelayCommand(AddressOf addinvoice)
            End If
            Return _cmdaddinvoice
        End Get
    End Property

    Private _cmdaddjob As RelayCommand
    Public ReadOnly Property cmdaddjob As RelayCommand
        Get

            If _cmdaddjob Is Nothing Then
                _cmdaddjob = New RelayCommand(AddressOf addjob)
            End If
            Return _cmdaddjob
        End Get
    End Property

    Public ReadOnly Property cmdChangeJobAddress As RelayCommand
        Get
            Return New RelayCommand(AddressOf ChangeJobAddress)
        End Get
    End Property

    Public ReadOnly Property cmdChangeCustomer As RelayCommand
        Get
            Return New RelayCommand(AddressOf ChangeCustomer)
        End Get
    End Property

    Private _cmddeleteswo As RelayCommand
    Public ReadOnly Property cmddeleteswo As RelayCommand
        Get
            If _cmddeleteswo Is Nothing Then
                _cmddeleteswo = New RelayCommand(AddressOf DeleteSWO)
            End If
            Return _cmddeleteswo
        End Get
    End Property

    Private _cmdaddswo As RelayCommand
    Public ReadOnly Property cmdaddswo As RelayCommand
        Get
            If _cmdaddswo Is Nothing Then
                _cmdaddswo = New RelayCommand(AddressOf AddSwo)
            End If
            Return _cmdaddswo
        End Get
    End Property
#End Region



#Region "ImagingScanning"

    Private _cmddeletescan As RelayCommand
    Public ReadOnly Property cmddeletescan As RelayCommand
        Get
            If _cmddeletescan Is Nothing Then
                _cmddeletescan = New RelayCommand(AddressOf DeleteScan)
            End If
            Return _cmddeletescan
        End Get

    End Property

    Private Sub DeleteScan()
        Try
            If selectedimage IsNot Nothing Then
                If MessageBox.Show("Delete Image?", "Delete Image?", MessageBoxButton.YesNo) = MessageBoxResult.Yes Then
                    Dim strFile As String = selectedimage
                    selectedimage = Nothing  'release resource
                    IO.File.Delete(strFile)
                End If
                RaisePropertyChanged("listimages")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private _cmdprintimage As RelayCommand
    Public ReadOnly Property cmdprintimage As RelayCommand
        Get
            If _cmdprintimage Is Nothing Then
                _cmdprintimage = New RelayCommand(Sub()
                                                      PrintImage()
                                                  End Sub)
            End If
            Return _cmdprintimage
        End Get
    End Property

    Private Function GetImageFromFile(_File As String) As System.Drawing.Image

        Dim fs As IO.FileStream = New IO.FileStream(_File, IO.FileMode.Open, IO.FileAccess.Read)
        Dim reader As New BinaryReader(fs)
        Dim memoryStream1 = New MemoryStream(reader.ReadBytes(CInt(fs.Length)))
        Try
            fs.Close()
            fs.Dispose()
        Catch
        End Try

        Return System.Drawing.Image.FromStream(memoryStream1)
    End Function

    Private Sub PrintImage()
        Try
            If selectedimage IsNot Nothing Then
                If IO.File.Exists(selectedimage) Then

                    Try
                        imageToPrint = GetImageFromFile(selectedimage)
                        Dim blnLetterSize As Boolean = True
                        If (imageToPrint.Width / imageToPrint.Height > 0.7) Then
                            'letter
                        Else
                            blnLetterSize = False
                        End If

                        'begin printing
                        Dim settings As New System.Drawing.Printing.PrinterSettings
                        If blnLetterSize Then

                            PrintDocument8x11.PrinterSettings.PrinterName = settings.PrinterName
                            Dim print1 As New System.Drawing.Printing.PageSettings
                            print1.Landscape = False
                            With print1
                                Try
                                    Dim paper As Long
                                    paper = GetLetterPaperEnum(print1)
                                    If paper >= 0 Then
                                        .PaperSize = .PrinterSettings.PaperSizes(paper)
                                    End If
                                Catch ex As Exception
                                End Try
                                .PrinterSettings.PrinterName = settings.PrinterName
                                .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                                .Margins.Bottom = 0
                                .Margins.Left = 0
                                .Margins.Top = 0
                                .Margins.Right = 0
                            End With

                            PrintDocument8x11.DefaultPageSettings = print1

                            PrintDocument8x11.Print()
                        Else

                            PrintDocument11x17.PrinterSettings.PrinterName = settings.PrinterName
                            Dim print2 As New System.Drawing.Printing.PageSettings
                            print2.Landscape = False
                            With print2
                                Try
                                    Dim paper As Long
                                    paper = GetLetterPaperEnum(print2, "11 x 17")
                                    If paper >= 0 Then
                                        .PaperSize = .PrinterSettings.PaperSizes(paper)
                                    Else
                                        paper = GetLetterPaperEnum(print2, "11x17")
                                        If paper >= 0 Then
                                            .PaperSize = .PrinterSettings.PaperSizes(paper)
                                        End If
                                    End If
                                Catch ex As Exception
                                End Try
                                .PrinterSettings.PrinterName = settings.PrinterName
                                .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
                                .Margins.Bottom = 0
                                .Margins.Left = 0
                                .Margins.Top = 0
                                .Margins.Right = 0
                            End With
                            PrintDocument11x17.DefaultPageSettings = print2

                            PrintDocument11x17.Print()

                        End If

                    Catch ex As Exception
                        MessageBox.Show("error printing: " & ex.Message)
                    End Try
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("error printing: " & ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument8x11_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument8x11.PrintPage
        e.Graphics.DrawImage(imageToPrint, 0, 0, 850, 1100)
        e.HasMorePages = False
    End Sub

    Private Sub PrintDocument11x17_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument11x17.PrintPage
        Dim settings As New System.Drawing.Printing.PrinterSettings
        Me.PrintDocument11x17.PrinterSettings.PrinterName = settings.PrinterName

        Dim print2 As New System.Drawing.Printing.PageSettings
        print2.Landscape = False
        With print2
            Try
                Dim paper As Long
                paper = GetLetterPaperEnum(print2, "11 x 17")
                If paper >= 0 Then
                    .PaperSize = .PrinterSettings.PaperSizes(paper)
                Else
                    paper = GetLetterPaperEnum(print2, "11x17")
                    If paper >= 0 Then
                        .PaperSize = .PrinterSettings.PaperSizes(paper)
                    End If
                End If

            Catch ex As Exception
            End Try

            .PrinterSettings.PrinterName = settings.PrinterName
            .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            .Margins.Bottom = 0
            .Margins.Left = 0
            .Margins.Top = 0
            .Margins.Right = 0
        End With
        Me.PrintDocument11x17.DefaultPageSettings = print2
        e.Graphics.DrawImage(imageToPrint, 0, 0, 1100, 1700)
        e.HasMorePages = False
    End Sub

    Private _cmdattachimage As RelayCommand
    Public ReadOnly Property cmdattachimage As RelayCommand
        Get
            If _cmdattachimage Is Nothing Then
                _cmdattachimage = New RelayCommand(Sub()
                                                       AttachImage(False)
                                                   End Sub)
            End If
            Return _cmdattachimage
        End Get
    End Property

    Private _cmdattachmap As RelayCommand
    Public ReadOnly Property cmdattachmap As RelayCommand
        Get
            If _cmdattachmap Is Nothing Then
                _cmdattachmap = New RelayCommand(Sub()
                                                     Try
                                                         AttachImage(True)
                                                     Catch ex As Exception
                                                         Windows.MessageBox.Show("error in cmdattachmap " & ex.Message)
                                                     End Try

                                                 End Sub)
            End If
            Return _cmdattachmap
        End Get
    End Property

    Private Sub AttachImage(blnMap As Boolean)
        If tjob Is Nothing Then
            MessageBox.Show("Select a job first.")
        Else
            Dim openfile As New Forms.OpenFileDialog

            openfile.ShowDialog()

            If openfile.FileName.Length > 0 Then
                If IO.File.Exists(openfile.FileName) Then

                    Dim strJobFolderRoot = sImagesPath & Me.tjob.jobNoNumericPrefix & "\"
                    Dim strJobSubFolder = strJobFolderRoot & Me.tjob.sJobNo & "\"
                    Dim strJobMapsFolder = strJobFolderRoot & "MAPS\"

                    If Not IO.Directory.Exists(strJobFolderRoot) Then
                        IO.Directory.CreateDirectory(strJobFolderRoot)
                    End If
                    If Not IO.Directory.Exists(strJobSubFolder) Then
                        IO.Directory.CreateDirectory(strJobSubFolder)
                    End If

                    Dim strImage As String = ""
                    strImage = openfile.FileName

                    Dim blnIsPDF As Boolean = False
                    If strImage.ToUpper.Contains(".PDF") Then
                        blnIsPDF = True
                    End If

                    Dim offset As Integer = 0
                    Dim strDestFileName As String = ""

                    If blnMap Then
                        If Not IO.Directory.Exists(strJobMapsFolder) Then  'only create a maps sub folder if we need one
                            IO.Directory.CreateDirectory(strJobMapsFolder)
                        End If
                        strDestFileName = strJobMapsFolder
                    Else
                        strDestFileName = strJobSubFolder
                    End If

                    Dim strFinalDest As String = strDestFileName
                    Do
                        strFinalDest = strDestFileName & 1 + offset

                        If blnIsPDF Then
                            strFinalDest = strFinalDest & ".pdf"
                        Else
                            strFinalDest = strFinalDest & ".tif"
                        End If


                        If offset > 100 Then
                            MessageBox.Show("max 100 files reached, cannot attach image.")
                            Exit Do
                        End If
                        If Not IO.File.Exists(strFinalDest) Then
                            IO.File.Copy(strImage, strFinalDest)
                            Exit Do
                        End If

                        offset += 1

                    Loop

                    RaisePropertyChanged("listimages")

                End If
            End If
        End If

    End Sub

    Private _cmdscan8x11 As RelayCommand
    Public ReadOnly Property cmdscan8x11 As RelayCommand
        Get
            If _cmdscan8x11 Is Nothing Then
                _cmdscan8x11 = New RelayCommand(AddressOf Scan8x11)
            End If
            Return _cmdscan8x11
        End Get
    End Property

    Private _cmdscanmap As RelayCommand
    Public ReadOnly Property cmdscanmap As RelayCommand
        Get
            If _cmdscanmap Is Nothing Then
                _cmdscanmap = New RelayCommand(AddressOf ScanMap)
            End If
            Return _cmdscanmap
        End Get
    End Property

    Private Sub Scan8x11()
        Me.Acquire(False, False)
    End Sub

    Private Sub ScanMap()
        Me.Acquire(False, True)
    End Sub

    Private Sub Scan11x17()
        Me.Acquire(True, False)
    End Sub

    Private _cmdscan11x17 As RelayCommand
    Public ReadOnly Property cmdscan11x17 As RelayCommand
        Get
            If _cmdscan11x17 Is Nothing Then
                _cmdscan11x17 = New RelayCommand(AddressOf Scan11x17)
            End If
            Return _cmdscan11x17
        End Get
    End Property

#Region " twainlib event handlers  "

    'Private WithEvents _tw As openTwain.Twain
    'Private _OutputDirectory As String = "C:\"
    'Private _ExceptionFile As String = "cmdHarnessEx.txt"
    'Private _SurpressDialogs As Boolean = True
    'Private _KnownDialogsFile As String = "kDialogs.xml"

    'Private WithEvents m_MessageTmr As System.Threading.Timer

    'Private _promptText As String = "Twain:\>"
    'Private _lastCmdId As Int32 = 0
    'Private _UnrecognizedCmd As String = "Unrecognized command"

    'Private _InProgress As Boolean = False

    'Private _ActiveSourceId As Int32 = 0
    'Private _ActiveSourceName As String = String.Empty

    'Private _AvailableProfiles As New Dictionary(Of String, String)
    'Private _ActiveProfileId As Int32 = 0
    'Private _ActiveProfileName As String = String.Empty

    'Private _ActiveProfile As openTwain.Profile

    'Private m_tmrInterval As Int32 = 60000

    'Private t As System.Threading.Thread

    'Private blnScanningMaps As Boolean = False

    'Private Sub _tw_CloseDsOkEvent() _
    'Handles _tw.CloseDsOkEvent
    '    'OK button from DsUi selected

    '    Try
    '        '  Me.Text = ("Ok selected")
    '        tw_EndingScan()
    '    Catch ex As Exception
    '        '  Me.Text = ("huh? " & ex.ToString)
    '    End Try

    'End Sub

    'Private Sub _tw_CloseRequestEvent() _
    'Handles _tw.CloseRequestEvent
    '    'cancel button from DsUi selected
    '    ' Me.Text = ("Cancel selected")
    '    tw_EndingScan()

    'End Sub

    ' ''' <summary>
    ' ''' 
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub tw_Failure() _
    'Handles _tw.FailureEvent

    '    MessageBox.Show("Failure event")
    '    tw_EndingScan()

    'End Sub

    ' ''' <summary>
    ' ''' 
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub tw_TransferReady() _
    'Handles _tw.TransferReadyEvent
    '    Try
    '        If Not _tw.Images.Count > 0 Then
    '            ' Me.Text = ("No results")

    '        Else 'look we have results...

    '            For Each path As String In _tw.Images
    '                '  Me.Text = (path)
    '            Next
    '        End If
    '    Catch ex As Exception
    '        '  Me.Text = (ex.ToString)
    '    End Try

    'End Sub

    ' ''' <summary>
    ' ''' 
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Private Sub tw_EndingScan() _
    'Handles _tw.EndScanEvent

    '    ' Me.Text = ("tw_EndingScan")

    'End Sub

    Private Sub Acquire(ByVal bln11x17 As Boolean, blnMap As Boolean)
        Try

            Dim WiaObj As WIA.CommonDialog
            Dim WiaDev As WIA.Device
            Dim wiaImg As WIA.ImageFile
            wiaImg = New WIA.ImageFile

            WiaObj = New WIA.CommonDialog

            If WiaDev Is Nothing Then ' WiaDev is defined globally
                WiaDev = WiaObj.ShowSelectDevice( _
                WIA.WiaDeviceType.ScannerDeviceType, True, False)
            End If
            Dim Itm As WIA.Item
            Dim ItmProp As WIA.Property

            For Each Itm In WiaDev.Items
                For Each ItmProp In Itm.Properties

                    Select Case ItmProp.Name
                        Case "Media Type"
                            ' ItmProp.Value = 128
                        Case "Bits Per Pixel"
                            ' ItmProp.Value = 1
                            '    Case "brightness"
                            '    Case "Threshold"
                    End Select

                    Select Case ItmProp.PropertyID
                        Case 6159 ' threshold
                            Try
                                ItmProp.Value = 160
                            Catch
                            End Try
                        Case 6154 'Brightness
                            Try
                                ItmProp.Value = 1
                            Catch ex As Exception
                                ' ItmProp.Value = 70
                            End Try
                        Case 6147 ' Horizontal Resolution
                            ItmProp.Value = 300
                        Case 6148 ' Vertical Resolution
                            ItmProp.Value = 300
                        Case 6151 ' Horizontal Extent (Scanning Area)
                            If bln11x17 Then
                                ItmProp.Value = 3300
                            Else
                                ItmProp.Value = 2550
                            End If
                        Case 6152 ' Vertical Extent (Scanning Area)
                            If bln11x17 Then
                                ItmProp.Value = 5100
                            Else
                                ItmProp.Value = 3300
                            End If
                            'ItmProp.Value = 3300
                            'ItmProp.Value = 5100
                        Case 6149 ' Horizontal Starting Position (Scanning Area)
                            ItmProp.Value = 0
                        Case 6150 ' Vertical Starting Position (Scanning Area)
                            ItmProp.Value = 0
                        Case 6146 ' Current Intent
                            ItmProp.Value = 4 ' Text or Line Art
                    End Select
                Next


                Dim strJobFolderRoot = sImagesPath & Me.tjob.jobNoNumericPrefix & "\"
                Dim strJobSubFolder = strJobFolderRoot & Me.tjob.sJobNo & "\"
                Dim strJobMapsFolder = strJobFolderRoot & "MAPS\"

                If Not IO.Directory.Exists(strJobFolderRoot) Then
                    IO.Directory.CreateDirectory(strJobFolderRoot)
                End If
                If Not IO.Directory.Exists(strJobSubFolder) Then
                    IO.Directory.CreateDirectory(strJobSubFolder)
                End If

                Try
                    If blnMap Then
                        If Not IO.Directory.Exists(strJobMapsFolder) Then
                            IO.Directory.CreateDirectory(strJobMapsFolder)
                        End If
                    End If
                Catch
                End Try


                Dim i As Integer = 0
                Try
                    Dim offset As Integer
                    Dim strPathToSave As String = strJobSubFolder
                    If blnMap Then
                        strPathToSave = strJobMapsFolder
                    End If

                    For i = 1 To 100
                        offset = 0
                        Try
                            wiaImg = WiaObj.ShowTransfer(Itm)
                        Catch ex As Exception
                            'we just keep going until the scanner errors because there is nothing left in the feeder
                            Exit For
                        End Try

                        Dim strFileName As String = ""
                        '    If blnMap Then

                        'If Not IO.Directory.Exists(sImagesPath & Me.tjob.jobNoNumericPrefix & "\MAPS\") Then
                        '    IO.Directory.CreateDirectory(sImagesPath & Me.tjob.jobNoNumericPrefix & "\MAPS\")
                        'End If
                        'Do
                        '    strFileName = sImagesPath & Me.tjob.jobNoNumericPrefix & "\MAPS\" & i + offset & ".tif"
                        '    offset += 1
                        'Loop Until Not IO.File.Exists(strFileName)
                        'wiaImg.SaveFile(strFileName)
                        'Else


                        Do
                            strFileName = strPathToSave & i + offset & ".tif"
                            offset += 1
                            If offset > 1000 Then
                                MessageBox.Show("error max images reached on scanning")
                                Exit For
                            End If

                        Loop Until Not IO.File.Exists(strFileName)
                        wiaImg.SaveFile(strFileName)
                        '  End If
                    Next
                Catch ex As Exception
                    Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Next

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        '   Me.blnMap = False
        RaisePropertyChanged("listimages")

    End Sub

#End Region

#End Region

End Class
