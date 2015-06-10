Imports System.Collections.ObjectModel
Imports System.Data
Imports System.ComponentModel
Imports System.Linq
Imports System.Data.Linq
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight

Public Class vmPO
    Inherits MyViewModelBase

    Private dc As linqTKSIDataContext

    Public _po As tPOHeader
    Public Property PO As tPOHeader
        Get
            Return _po
        End Get
        Set(value As tPOHeader)
            _po = value
        End Set
    End Property

    Private Const specialDeliver As String = "Special Delivery Needs"

    Private _POLines As ObservableCollection(Of tPOLine)
    Public Property POLines As ObservableCollection(Of tPOLine)
        Get
            If _POLines Is Nothing Then
                _POLines = New ObservableCollection(Of tPOLine)(PO.tPOLines)
            End If
            Return _POLines

        End Get
        Set(value As ObservableCollection(Of tPOLine))
            _POLines = value
            RaisePropertyChanged("POLines")
            RaisePropertyChanged("FactorWithoutFreight")
        End Set
    End Property

    Public ReadOnly Property ItemComment As ObservableCollection(Of String)
        Get
            Dim oc As New ObservableCollection(Of String)
            oc.Add("Item")
            oc.Add("Comment")
            Return oc
        End Get
    End Property

    Public ReadOnly Property AccountList As ObservableCollection(Of Integer)
        Get
            Dim oc As New ObservableCollection(Of Integer)
            oc.Add("0")
            oc.Add("5010")
            oc.Add("5020")
            oc.Add("5030")
            oc.Add("5040")
            oc.Add("5070")
            oc.Add("5260")
            oc.Add("5270")
            oc.Add("5490")
            oc.Add("5570")

            Return oc
        End Get
    End Property

    Private _deliverynotes As String = ""
    Public ReadOnly Property deliverynotes As String
        Get
            If PO.DDEL Is Nothing Then
                _deliverynotes = "Has NOT been delivered" & PO.SDELNOTES
            Else
                _deliverynotes = "Delivery Date: " & PO.DDEL & " - " & PO.SDELNOTES
            End If
            Return _deliverynotes
        End Get

    End Property

    Private _receivednotes As String = ""
    Public ReadOnly Property receivednotes As String
        Get
            If PO.DREC Is Nothing Then
                _receivednotes = "Has NOT been received" & PO.SRECNOTES
            Else
                _receivednotes = "Received Date: " & PO.DREC & " - " & PO.SRECNOTES
            End If
            Return _receivednotes
        End Get

    End Property

    Private _specialdeliverneeds As Boolean
    Public Property specialdeliverneeds As Boolean
        Get
            Dim q = (From row In Me.dc.tblJobActivities Where row.nJobID = Me.PO.nJobID And row.ActivityType.ToUpper.Contains(specialDeliver.ToUpper))
            If q.Count > 0 Then
                Return True
            End If
            Return False
        End Get
        Set(value As Boolean)
            _specialdeliverneeds = value
            If value = True Then
                Dim drAct As New tblJobActivity ' = Me.TksijobsDataSet1.tblJobActivity.NewtblJobActivityRow
                With drAct
                    .dateEntered = Now
                    .Other = ""
                    .nJobID = Me.PO.nJobID
                    .ActivityType = specialDeliver
                    .ActivityDetail = specialDeliver
                    .gID = Guid.NewGuid
                End With
                Me.dc.tblJobActivities.InsertOnSubmit(drAct)
                Me.dc.SubmitChanges()
            Else
                Dim q = (From row In Me.dc.tblJobActivities Where row.nJobID = Me.PO.nJobID And row.ActivityType.ToUpper.Contains(specialDeliver.ToUpper))
                If q.Count > 0 Then
                    For Each act In q
                        Me.dc.tblJobActivities.DeleteOnSubmit(act)
                    Next
                    Me.dc.SubmitChanges()
                End If

            End If

        End Set
    End Property

    Public Function HasChanges() As Boolean
        If dc.GetChangeSet.Updates.Count > 0 Or dc.GetChangeSet.Deletes.Count > 0 Or dc.GetChangeSet.Inserts.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public ReadOnly Property FactorWithoutFreight
        Get
            Return PO.FactorWithoutFreight
        End Get
    End Property

    Private _prompttext As String = ""
    Public Property prompttext As String
        Get
            Return _prompttext
        End Get
        Set(value As String)
            _prompttext = value
            RaisePropertyChanged("prompttext")
        End Set
    End Property

    Private _prompttitle As String = "Enter Password *** "
    Public Property prompttitle As String
        Get
            Return _prompttitle
        End Get
        Set(value As String)
            _prompttitle = value
            RaisePropertyChanged("prompttitle")
        End Set
    End Property

    Private _UserEnteredCredentials As Boolean = False
    Public Property UserEnteredCredentials As Boolean
        Get
            If (Not Me.PO.sPOType.ToUpper.Contains("JOBCOST")) Then
                If Me.PO.Cost >= 1 And Me.PO.Sale < 1 Then  'if not a job cost must have sale with any costs otherwise password is required
                    Return _UserEnteredCredentials
                Else
                    Return True
                End If
            Else
                Return True
            End If

        End Get
        Set(value As Boolean)
            _UserEnteredCredentials = value
        End Set
    End Property

    Private Sub SetPassword()
        If prompttext = "181818" Or prompttext = "5640" Then
            UserEnteredCredentials = True
            SubmitDatabaseChanges(Me.PO.nJobID)
            Messaging.Messenger.Default.Send("ClosePOPasswordWindow")
        Else
            prompttitle = "Incorrect password"
        End If

    End Sub

    Public ReadOnly Property promptok As RelayCommand
        Get
            Return New RelayCommand(AddressOf SetPassword)
        End Get
    End Property

    Public Function SaveChanges() As Boolean

        For Each line1 In (From row In PO.tPOLines Where row.nCost <> 0 Or row.nAccountID <> 0)
            If line1.sType <> "Item" Then
                line1.sType = "Item"
                MessageBox.Show("Automatically setting PO Lines with a cost/account to type 'Item'")
            End If
        Next

        If Not IsSWOVendorPOTypeMatching() Then
            MessageBox.Show("SWO PO Type is MIS-MATCHED.")
        End If

        StartTimer()

        If Me.HasChanges Then
            If UserEnteredCredentials Then
                SubmitDatabaseChanges(Me.PO.nJobID)
                EndTimer(2, " long save PO ")
                Return True
            Else
                EndTimer(2, " long save PO ")
                Dim Pass1 As New winPOPassword
                Pass1.DataContext = Me
                Pass1.ShowDialog()
            End If
        Else
            'no changes need to be saved
        End If

        EndTimer(2, " long save PO ")
    End Function

    Private Function IsSWOVendorPOTypeMatching() As Boolean
        If Me.PO.tVendor IsNot Nothing AndAlso Me.PO.tVendor.sName.ToUpper.Contains("SERVICE WORK") Then
            If Me.PO.sPOType.Contains("SWO") Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub SubmitDatabaseChanges(_jobid As Integer)
        dc.SubmitChanges()
        Try
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send(Of tJob)(Nothing, _jobid)
            POLines = New ObservableCollection(Of tPOLine)(PO.tPOLines)
            RaisePropertyChanged("FactorWithoutFreight")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim _cmdaddline As RelayCommand(Of String)
    Public ReadOnly Property cmdaddline As RelayCommand(Of String)
        Get
            If _cmdaddline Is Nothing Then
                _cmdaddline = New RelayCommand(Of String)(AddressOf cmdAddCommentLine)
            End If
            Return _cmdaddline
        End Get
    End Property

    Dim _cmddeletepo As RelayCommand
    Public ReadOnly Property cmddeletepo As RelayCommand
        Get
            If _cmddeletepo Is Nothing Then
                _cmddeletepo = New RelayCommand(AddressOf DeletePO)
            End If
            Return _cmddeletepo
        End Get
    End Property

    Private Sub DeletePO()
        Try
            If MessageBox.Show("Are you sure you want to DELETE this PO?", "DELETE?", MessageBoxButton.YesNo) = MessageBoxResult.Yes Then
                Dim jobid As Integer = Me.PO.nJobID
                dc.tPOHeaders.DeleteOnSubmit(Me.PO)
                SubmitDatabaseChanges(jobid)
                Messaging.Messenger.Default.Send(Of String)("closepowindow", PO.nID)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Dim _cmdsendtosage As RelayCommand
    Public ReadOnly Property cmdsendtosage As RelayCommand
        Get
            If _cmdsendtosage Is Nothing Then
                _cmdsendtosage = New RelayCommand(AddressOf SendToSage)
            End If
            Return _cmdsendtosage
        End Get
    End Property

    Dim _cmdduplicate As RelayCommand
    Public ReadOnly Property cmdduplicate As RelayCommand
        Get
            If _cmdduplicate Is Nothing Then
                _cmdduplicate = New RelayCommand(AddressOf DuplicatePO)
            End If
            Return _cmdduplicate
        End Get
    End Property

    Dim _cmdshipping As RelayCommand
    Public ReadOnly Property cmdshipping As RelayCommand
        Get
            If _cmdshipping Is Nothing Then
                _cmdshipping = New RelayCommand(AddressOf ShippingDetail)
            End If
            Return _cmdshipping
        End Get
    End Property

    Dim _cmdundeliver As RelayCommand
    Public ReadOnly Property cmdundeliver As RelayCommand
        Get
            If _cmdundeliver Is Nothing Then
                _cmdundeliver = New RelayCommand(AddressOf Undeliver)
            End If
            Return _cmdundeliver
        End Get
    End Property

    Dim _cmddeliver As RelayCommand
    Public ReadOnly Property cmddeliver As RelayCommand
        Get
            If _cmddeliver Is Nothing Then
                _cmddeliver = New RelayCommand(AddressOf deliver)
            End If
            Return _cmddeliver
        End Get
    End Property

    Dim _cmdprint As RelayCommand
    Public ReadOnly Property cmdprint As RelayCommand
        Get
            If _cmdprint Is Nothing Then
                _cmdprint = New RelayCommand(AddressOf printPO)
            End If
            Return _cmdprint
        End Get
    End Property

    Private Function CheckForFinanceCharge() As Boolean
        Try
            For Each line1 In Me.PO.tPOLines
                If line1.sDesc.ToUpper.Contains("FINANCE") Then
                    If PO.nAccount = 4040 Then
                        Return True
                    End If
                End If
            Next
            Return False
        Catch
        End Try

    End Function

    Private Sub PrintPO()
        Try
            If CheckForFinanceCharge Then
                MessageBox.Show("Cannot print Installer  PO's with a finance charge.")
                Exit Sub
            End If
            Me.SaveChanges()
            ' Dim drPO As dsTKSI.tPOHeaderRow
            Dim daPO As New dsTKSITableAdapters.tPOHeaderTableAdapter
            Dim dsPO As New dsTKSI
            dsPO.EnforceConstraints = False
            If daPO.FillByNID(dsPO.tPOHeader, Me.PO.nID) > 0 Then
                Dim drPO As dsTKSI.tPOHeaderRow = dsPO.tPOHeader(0)
                Dim daLine As New dsTKSITableAdapters.tPOLineTableAdapter
                daLine.FillByNPOID(dsPO.tPOLine, Me.PO.nID)
                Dim daven As New dsTKSITableAdapters.tVendorTableAdapter
                daven.Fill(dsPO.tVendor)

                Dim drPrint As New frmPO
                drPrint.drPO = drPO
                drPrint.Show()
                drPrint.flexPOHeader.PrintGrid("", True, 1, 40, 40)
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'POtoPDF(Me.PO)
    End Sub

    Private Sub ShippingDetail()
        Try
            Dim frm1 As New frmShippingDetail
            frm1.LoadByPO(Me.PO.sPONum)
            frm1.ShowDialog()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub deliver()
        Try
            If Me.PO.DDEL Is Nothing Then
                Me.PO.DDEL = Now
                'If Me.PO.DREC Is Nothing Then
                '    Me.PO.DREC = Now
                'End If
                MessageBox.Show("PO delivered, however shipping parts items may not be marked as delivered until scanned in.")
            Else
                MessageBox.Show("PO already has a delivered date.")
            End If
            RaisePropertyChanged("deliverynotes")
            RaisePropertyChanged("receivednotes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Undeliver()
        Try
            Me.PO.DDEL = Nothing
            Me.UndeliverTrailerDetailItems()
            RaisePropertyChanged("deliverynotes")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UndeliverTrailerDetailItems()
        Try

            Dim qheaders = (From row In dc.tblTrailerHeaders Where row.PO = Me.PO.sPONum)
            Dim qdetail = (From row In dc.tblTrailerDetails Where row.po.StartsWith(Me.PO.sPONum))

            For Each det1 In qdetail
                If det1.DeliveredTKSI IsNot Nothing Then
                    det1.DeliveredTKSI = Nothing
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error updating trailer details lines " & ex.Message)
        End Try
    End Sub

    Private Sub DuplicatePO()
        Try
            Dim drPO1 As New tPOHeader
            With Me.PO
                drPO1.nJobID = .nJobID
                drPO1.nVendorID = .nVendorID
                drPO1.sPONum = .sPONum & "-BO"
                drPO1.sShipTo1 = .sShipTo1
                drPO1.sShipTo2 = .sShipTo2
                drPO1.sShipto3 = .sShipto3
                drPO1.sShipToCity = .sShipToCity
                drPO1.sShipToState = .sShipToState
                drPO1.sShipToZip = .sShipToZip
                drPO1.sShiptoCounty = .sShiptoCounty
                drPO1.nBoxes = 0

                If .dPODate IsNot Nothing Then
                    drPO1.dPODate = .dPODate
                End If

                If .dRequired IsNot Nothing Then
                    drPO1.dRequired = .dRequired
                End If

                drPO1.sItemDesc = .sItemDesc
                drPO1.sItems = .sItems

                drPO1.sVia = .sVia
                drPO1.sFOB = .sFOB
                drPO1.nRetailSale = 0
                drPO1.nSaleAccount = .nSaleAccount
                drPO1.nRetailFreight = 0
                drPO1.sConf = "N/A"
                drPO1.nAdd = 0

                drPO1.SRECNOTES = .SRECNOTES
                drPO1.SDELNOTES = .SDELNOTES

                drPO1.nAccount = .nAccount
                drPO1.nInvNo = .nInvNo
                drPO1.nCheckNo = 0

                ' If .dSimply IsNot Nothing Then
                '  drPO1.dSimply = .dSimply  'leave Sage date NULL on new duplicate PO
                'End If

                drPO1.nTruck = 1
                drPO1.sFilter = .sFilter
                drPO1.sBackOrder = .sBackOrder
                drPO1.sItems = .sItems
                drPO1.sItemDesc = .sItemDesc
                drPO1.sPOType = .sPOType
                drPO1.nsalesadjust = .nsalesadjust
                drPO1.sAdjustReason = .sAdjustReason
                drPO1.sCurActNote = .sCurActNote
                drPO1.nPOSort = .nPOSort
                drPO1.bSimply = False
                drPO1.nTotal = .nTotal
                drPO1.sTerms = .sTerms
                drPO1.sEnteredBy = "DuplicatePO"
            End With
            Me.dc.tPOHeaders.InsertOnSubmit(drPO1)
            dc.SubmitChanges()


            Dim drLine As tPOLine
            For Each drLine In Me.POLines
                Dim drLine1 As New tPOLine
                With drLine1
                    .nAccountID = drLine.nAccountID
                    .nCost = drLine.nCost
                    .nLineNumber = drLine.nLineNumber
                    .nPOID = drPO1.nID
                    .sDesc = drLine.sDesc
                    .sType = drLine.sType
                    .sReceived = drLine.sReceived
                    .tPOHeader = drPO1
                End With
                Me.dc.tPOLines.InsertOnSubmit(drLine1)
            Next
            dc.SubmitChanges()
            If drPO1 IsNot Nothing Then
                OpenPOScreen(drPO1.nID, False)
            End If
        Catch ex As Exception
            MessageBox.Show("Error duplicating PO " & ex.Message)
        End Try

    End Sub

    Private Sub SendToSage()
        If Me.HasChanges Then
            MessageBox.Show("Changes must be saved first.")
        Else
            Dim discount As Decimal
            Dim frmDisc As New frmDiscount1

            frmDisc.ShowDialog()
            If frmDisc.blnOK Then
                If IsNumeric(frmDisc.txtDiscount.Text.Trim) Then
                    discount = frmDisc.txtDiscount.Text.Trim
                Else
                    discount = 0
                End If

                If UpdateSimply(Me.PO, discount) Then

                    Me.PO.dSimply = Now
                    Me.PO.bSimply = True

                    Me.dc.SubmitChanges()

                    MessageBox.Show("Sage Updated")
                Else
                    MessageBox.Show("Did not update, please  check Sage/Peachtree. (PO line items must exist)")
                End If
            Else
                'user cancelled
            End If
        End If


    End Sub

    Private Sub AddLine(_desc As String, _received As Boolean, _cost As Decimal, _account As Integer, _type As String, _po As tPOHeader, _dc As linqTKSIDataContext)
        Try
            If _desc Is Nothing Then
                _desc = ""
            End If

            Dim iLineNo As Integer = 1
            Dim q = (From row In PO.tPOLines Select row.nLineNumber)
            If q.Count > 0 Then
                iLineNo = q.Max + 1
            End If
            Dim line1 As New tPOLine
            With line1
                .nLineNumber = iLineNo
                .sDesc = _desc
                .sReceived = _received
                .nCost = _cost
                .nAccountID = _account
                .sType = _type
                .tPOHeader = _po
            End With
            _dc.tPOLines.InsertOnSubmit(line1)
            Me.POLines.Add(line1)
            ' _dc.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("Error adding line " & ex.Message)
        End Try

    End Sub

    Private Sub UpdateLinesGUI()
        POLines = New ObservableCollection(Of tPOLine)(_PO.tPOLines)
    End Sub

    Public Sub AddInstallerLines()
        cmdAddCommentLine("")
        cmdAddCommentLine("")
        cmdAddCommentLine("")
        cmdAddCommentLine("If you have any questions please")
        cmdAddCommentLine("call " & Me.PO.tJob.sSalesperson & " at 303-799-9200")
        cmdAddCommentLine("")
        cmdAddCommentLine("Job Contact: " & Me.PO.tJob.sJobContact)
        cmdAddCommentLine("Phone: " & Me.PO.tJob.sPhone)
        cmdAddCommentLine("")
        cmdAddCommentLine("PLEASE SIGN AND RETURN UPON")
        cmdAddCommentLine("COMPLETION FOR FULL PAYMENT")
        cmdAddCommentLine("")
        cmdAddCommentLine("SIGN ___________________________________________")
        cmdAddCommentLine("DATE ___________________________________________")

    End Sub

    Private Sub cmdAddCommentLine(_description As String)

        AddLine(_description, False, 0, 0, "Comment", Me.PO, Me.dc)
        UpdateLinesGUI()

    End Sub

    Dim _cmdsave As RelayCommand
    Public ReadOnly Property cmdsave As RelayCommand
        Get
            If _cmdsave Is Nothing Then
                _cmdsave = New RelayCommand(AddressOf SaveChanges)
            End If
            Return _cmdsave
        End Get
    End Property

    Dim _cmdinstallerlines As RelayCommand
    Public ReadOnly Property cmdinstallerlines As RelayCommand
        Get
            If _cmdinstallerlines Is Nothing Then
                _cmdinstallerlines = New RelayCommand(AddressOf installerlines)
            End If
            Return _cmdinstallerlines
        End Get
    End Property

    Private Sub installerlines()
        Try
            If PO.nAccount = 4040 Then
                AddInstallerLines()
            Else
                MessageBox.Show("This is not a labor PO - 4040")
            End If
        Catch
        End Try
    End Sub

    Dim _cmddeleteline As RelayCommand(Of Integer)
    Public ReadOnly Property cmddeleteline As RelayCommand(Of Integer)
        Get
            If _cmddeleteline Is Nothing Then
                _cmddeleteline = New RelayCommand(Of Integer)(AddressOf DeleteLine)
            End If
            Return _cmddeleteline
        End Get
    End Property

    Private Sub DeleteLine(iLine As Integer)
        Dim qdel = (From row In Me.PO.tPOLines Where row.nLineNumber = iLine)
        If qdel.Count > 0 Then

            Me.dc.tPOLines.DeleteOnSubmit(qdel.First)
            POLines.Remove(qdel.First)
            '   dc.SubmitChanges()
            RaisePropertyChanged("POLines")
            '  POLines = New ObservableCollection(Of tPOLine)(PO.tPOLines)

        End If
    End Sub

    Dim _cmdeditvendor As RelayCommand
    Public ReadOnly Property cmdeditvendor As RelayCommand
        Get
            If _cmdeditvendor Is Nothing Then
                _cmdeditvendor = New RelayCommand(AddressOf EditVendor)
            End If
            Return _cmdeditvendor
        End Get
    End Property

    Public Sub LoadPO(_poid As Integer)
        dc = GetLinqDataContext()
        Dim q As IQueryable(Of tPOHeader) = (From row In dc.tPOHeaders Where row.nID = _poid)
        If q.Count > 0 Then
            Me.PO = q.First
            POLines = New ObservableCollection(Of tPOLine)(PO.tPOLines)
            AddHandler POLines.CollectionChanged, AddressOf lineschanged
        End If
    End Sub

    Public Sub LoadPO(_poid As Integer, _dc As linqTKSIDataContext)
        dc = _dc
        Dim q As IQueryable(Of tPOHeader) = (From row In dc.tPOHeaders Where row.nID = _poid)
        If q.Count > 0 Then
            Me.PO = q.First
            POLines = New ObservableCollection(Of tPOLine)(PO.tPOLines)
            AddHandler POLines.CollectionChanged, AddressOf lineschanged
        End If
    End Sub

    Private Sub lineschanged()
        RaisePropertyChanged("FactorWithoutFreight")
    End Sub

    Private Sub EditVendor()
        Try
            Dim frmVend As New VendorSearch
            frmVend.ShowDialog()
            If frmVend.OK Then
                Dim q = (From row In dc.tVendors Where row.lid = frmVend.ID)

                If q.Count > 0 Then
                    Me.PO.tVendor = q.First
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
