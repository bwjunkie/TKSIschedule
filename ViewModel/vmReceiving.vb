Imports System.Collections.ObjectModel
Imports System.Data
Imports System.ComponentModel
Imports System.Linq
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight
Imports System.Windows.Application

Public Class vmReceiving
    Inherits ViewModelBase

    Private dc As linqTKSIDataContext = GetLinqDataContext()
    Private SelTruck As String = ""
    Public Property listTrucks As clsTrucks

    Private _listtruckpackages As clsPackages
    Public Property listTruckPackages As clsPackages
        Get
            Return _listtruckpackages
        End Get
        Set(value As clsPackages)
            _listtruckpackages = value
            RaisePropertyChanged("listTruckPackages")
            RaisePropertyChanged("collistTruckPackages")
        End Set
    End Property

    Private _packageselected As PackagePOItem
    Public Property packageselected As PackagePOItem
        Get
            Return _packageselected
        End Get
        Set(value As PackagePOItem)
            _packageselected = value
            RaisePropertyChanged("packageselected")
        End Set
    End Property

    Private dispatcherTimer As System.Windows.Threading.DispatcherTimer

    Private _hidereceived As Boolean = False
    Public Property HideReceived As Boolean
        Get
            Return _hidereceived
        End Get
        Set(value As Boolean)

            _hidereceived = value
            UpdateTruckData()
            'If value <> _hidereceived Then
            '    _hidereceived = value

            'Else
            '    _hidereceived = value
            'End If

            RaisePropertyChanged("HideReceived")
        End Set
    End Property

    Private _refreshcommand As RelayCommand
    Public ReadOnly Property refreshcommand As RelayCommand
        Get
            If _refreshcommand Is Nothing Then
                _refreshcommand = New RelayCommand(AddressOf UpdateTruckData)
            End If
            Return _refreshcommand
        End Get
    End Property

    Private _cmdprintreceivingreport As RelayCommand
    Public ReadOnly Property cmdprintreceivingreport As RelayCommand
        Get
            If _cmdprintreceivingreport Is Nothing Then
                _cmdprintreceivingreport = New RelayCommand(AddressOf PrintReceivingReport)
            End If
            Return _cmdprintreceivingreport
        End Get
    End Property


    Private listPOlog As New List(Of POLog)


    Public ReadOnly Property collistTruckPackages As CollectionView
        Get
            If listTruckPackages Is Nothing Then
                Return Nothing
            Else
                Dim MyCollectionView As ListCollectionView = CollectionViewSource.GetDefaultView(listTruckPackages)

                '   Dim MyCollectionView As ListCollectionView = New ListCollectionView(listTruckPackages)
                '   MyCollectionView.SortDescriptions.Add(New SortDescription("PO", ListSortDirection.Ascending))
                '   MyCollectionView.SortDescriptions.Add(New SortDescription("pkgno", ListSortDirection.Ascending))

                Dim GroupDescription As PropertyGroupDescription = New PropertyGroupDescription("PO")
                MyCollectionView.GroupDescriptions.Add(GroupDescription)

                Return MyCollectionView
            End If

        End Get
    End Property

    Sub New()

        listTrucks = New clsTrucks

        dispatcherTimer = New System.Windows.Threading.DispatcherTimer()
        AddHandler dispatcherTimer.Tick, AddressOf dispatcherTimer_Tick
        dispatcherTimer.Interval = New TimeSpan(0, 0, 25)
        dispatcherTimer.Start()

    End Sub

    Private Sub dispatcherTimer_Tick()
        UpdateTruckData()
    End Sub

    Public Property SelectedTruck As String
        Get
            Return SelTruck
        End Get
        Set(value As String)
            SelTruck = value
            UpdateTruckData()
            dispatcherTimer.Stop()
            dispatcherTimer.Start()

        End Set
    End Property

    Private Sub UpdateTruckData()
        Dim winBusy1 As New winBusy
        Try
            winBusy1.Show()
            If SelTruck.Length > 0 Then
                listTruckPackages = New clsPackages(SelTruck, Me.HideReceived, dc)
            Else
                listTruckPackages = New clsPackages("", False, dc)
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            winBusy1.Close()
        End Try

    End Sub

    Private Class POLog
        Public iScannedCount As Integer = 0
        Public iUnscannedCount As Integer = 0
        Public iItemsNotOnTruck As Integer = 0
        Public sPO As String = ""
        Public sdamageNotes As String = ""
        Sub New(_sPO As String, _iScannedCount As Integer, _iUnscannedCount As Integer, _iItemsNotOnTruck As Integer, _sDamageNotes As String)
            iScannedCount = _iScannedCount
            iUnscannedCount = _iUnscannedCount
            iItemsNotOnTruck = _iItemsNotOnTruck
            sPO = _sPO
            sdamageNotes = _sDamageNotes
        End Sub
    End Class

    Private _cmdprintlabel As RelayCommand
    Public ReadOnly Property cmdprintlabel
        Get
            If _cmdprintlabel Is Nothing Then
                _cmdprintlabel = New RelayCommand(AddressOf PrintLabel)
            End If
            Return _cmdprintlabel
        End Get
    End Property

    Dim line1 As String = ""
    Dim line2 As String = ""
    Dim line3 As String = ""
    Dim line4BarCode As String = ""
    Private WithEvents PrintDocumentBarCodeLabel As New System.Drawing.Printing.PrintDocument

    Private Sub PrintLabel()
        Try
            If Me.packageselected IsNot Nothing Then
                line4BarCode = Me.packageselected.LabelID 'drTD.LabelID
                line3 = Me.packageselected.PkgRow.dlrpo

                Try
                    Dim strLn As String = "Ln: "
                    Dim strDesc As String = ""
                    For Each spl In (From row In Me.packageselected.Description.Split(" ") Where row.Trim.Length > 0)
                        If IsNumeric(spl) Then
                            strLn = (String.Concat(strLn, spl.Trim & " "))
                        Else
                            strDesc = String.Concat(strDesc, spl.Trim & " ")
                        End If
                    Next
                    line2 = Mid(strLn & strDesc, 1, 30) '  Mid(Me.packageselected.Description, 1, 26)
                Catch ex As Exception
                End Try

                With Me.PrintDocumentBarCodeLabel

                    .DocumentName = "Shipping Label"
                    If ISDebugMachine Then
                        .PrinterSettings.PrinterName = global_DefaultPrinter()
                        '  .PrinterSettings.PrinterName = "\\Warehouse1\ZebraLP2dock"
                    Else
                        .PrinterSettings.PrinterName = "\\Warehouse1\ZebraLP2dock"
                    End If

                    .PrinterSettings.DefaultPageSettings.Margins.Left = 20
                    .PrinterSettings.DefaultPageSettings.Margins.Right = 5
                    .PrinterSettings.DefaultPageSettings.Margins.Top = 20
                    .PrinterSettings.DefaultPageSettings.Margins.Bottom = 5

                End With
                Me.PrintDocumentBarCodeLabel.Print()
            Else
                MessageBox.Show("select a line to print first")
            End If

        Catch ex As Exception
            MessageBox.Show("Error printing label. " & ex.Message)
        End Try

    End Sub

    Private Sub PrintDocumentBarCodeLabel_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentBarCodeLabel.PrintPage
        e.HasMorePages = Me.DrawLabelGraphics(e.Graphics)
    End Sub

    Private Function DrawLabelGraphics(ByVal g As System.Drawing.Graphics) As Boolean
        g.DrawString(Me.line1, New System.Drawing.Font("Arial", "14", System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point), System.Drawing.Brushes.Black, 5, 1)
        g.DrawString(Me.line2, New System.Drawing.Font("Arial", "14", System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point), System.Drawing.Brushes.Black, 5, 26)
        g.DrawString(Me.line3, New System.Drawing.Font("Arial", "14", System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point), System.Drawing.Brushes.Black, 5, 51)
        g.DrawString("*" & Me.line4BarCode & "*", New System.Drawing.Font("Bar Code 39 d", "16", System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point), System.Drawing.Brushes.Black, 5, 76)
        g.DrawString("*" & Me.line4BarCode & "*", New System.Drawing.Font("Arial", "10", System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point), System.Drawing.Brushes.Black, 5, 106)

        Return False
    End Function

    Private Function CheckForBadPONumbers(ByVal PO As String) As Boolean
        Dim q = (From row In dc.tPOHeaders Where row.sPONum = PO)
        If q.Count = 1 Then
            Return True
        End If
        Return False
    End Function

    Private Sub PrintReceivingReport()
        Try

            Try
                'trailer header is not 1 for 1 for unique PO numbers
                'there can be 2 trailer headers for one PO
                'so we have to loop the trailer details sorted by PO to be unique set of PO

                Dim pdf As New clsPDFCreate("Receiving Report " & Now.ToString)
                pdf.AddParagraphToPDF("Truck: " & Me.SelectedTruck & " - " & SelectedTruck)
                pdf.PDFAddSeperatorLine()
                pdf.AddParagraphToPDF(pdf.ColTextPad("PO", "Unscanned", "Diff Truck", "Total Lines", "Style Info"))
                pdf.PDFAddSeperatorLine()
                'get unique list of POs contianed in this truck only

                Dim qLinesWithPOnotNull As IQueryable(Of tblCWPackage) = (From row In dc.tblCWPackages Where row.dlrpo.Length > 0 Select row)

                Dim podistinctTemp = (From d1 In qLinesWithPOnotNull Where d1.shipdata = Me.SelectedTruck Order By d1.dlrpo Select d1.dlrpo Distinct)

                Me.listPOlog.Clear()

                For Each poFilter As String In podistinctTemp

                    Try
                        'get all detail items for this PO, even some not on this truck
                        Dim qLinesAnyTruckPerPO As IQueryable(Of tblCWPackage) = (From row In qLinesWithPOnotNull Where row.dlrpo = poFilter Select row)

                        Dim iCountLinesAnyTruck As Integer = qLinesAnyTruckPerPO.Count

                        Dim qLinesThisTruck As IQueryable(Of tblCWPackage) = (From row In qLinesAnyTruckPerPO Where row.shipdata = Me.SelectedTruck)

                        Dim iCountLinesThisTruck As Integer = qLinesThisTruck.Count

                        Dim iCountLinesDifferentTruck As Integer = iCountLinesAnyTruck - iCountLinesThisTruck

                        Dim qLineUnscanned As IQueryable(Of tblCWPackage) = From row In qLinesThisTruck Where row.dateReceived Is Nothing And row.dateDelivered Is Nothing Select row
                        Dim iCountUnscanned As Integer = qLineUnscanned.Count

                        Dim POLog1 As POLog

                        If Not CheckForBadPONumbers(poFilter) Then
                            pdf.AddParagraphToPDF(pdf.ColTextPad(poFilter & " Bad PO Number", "", "Not in TKSI system", "", ""))
                        Else
                            pdf.AddParagraphToPDF(pdf.ColTextPad(poFilter, iCountUnscanned.ToString, iCountLinesDifferentTruck, iCountLinesAnyTruck, ""))
                            POLog1 = New POLog(poFilter, iCountLinesThisTruck - iCountUnscanned, iCountUnscanned, iCountLinesDifferentTruck, "")
                            listPOlog.Add(POLog1)
                        End If

                        For Each row In qLineUnscanned
                            Dim sDesc As String = ""
                            Dim sLines As String = "Ln:"
                            For Each cont In row.tblCWPackageContents
                                sDesc = String.Concat(sDesc, cont.fdesc, " ", cont.material)
                                sLines = String.Concat(sLines, " ", cont.cabno)
                            Next
                            Try
                                pdf.AddParagraphToPDF(pdf.ColTextPad("(" & sLines & ")", "", "", "", sDesc))
                            Catch ex As Exception
                                pdf.AddParagraphToPDF("ERROR showing unscanned line- " & poFilter & " " & ex.Message)
                            End Try
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Error while building report: " & ex.Message)
                        Exit For
                    End Try
                Next

                pdf.ShowPDF()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            If MessageBox.Show("Do you want to update Supplier Report Received Date?", "Update Received Date?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes) = MessageBoxResult.Yes Then
                UpdateTKSIReceiving()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateTKSIReceiving()
        Me.alPONeedingActivityUpdate.Clear()

        For Each polog1 As POLog In Me.listPOlog
            With polog1
                If (.iScannedCount > .iUnscannedCount And .iScannedCount > .iItemsNotOnTruck) Then
                    Dim q1po = (From row In dc.tPOHeaders Where row.sPONum = polog1.sPO)
                    If q1po.Count = 1 Then
                        Dim poH = q1po.First

                        If poH.DREC Is Nothing Then
                            poH.DREC = Now.Date
                            If poH.dRequired > Today.Date.AddDays(3) Or poH.dRequired < Today.Date.AddDays(-3) Then
                                poH.dRequired = Today.Date
                            End If
                            If poH.nTruck < 2 Then
                                Dim iTruck As Integer = 0
                                If Integer.TryParse(Mid(Me.SelectedTruck, 1, 2), iTruck) Then
                                    poH.nTruck = iTruck
                                End If

                            End If
                        End If

                        Dim PO1 As New POWithDamage
                        PO1.dReceived = poH.DREC
                        PO1.nAccount = poH.nAccount
                        PO1.nBoxes = poH.nBoxes
                        PO1.sDamageNotes = .sdamageNotes
                        PO1.nJobID = poH.nJobID
                        alPONeedingActivityUpdate.Add(PO1)

                    Else
                        MessageBox.Show("missing PO (did not update received date): " & polog1.sPO)
                    End If
                End If
            End With

        Next
        dc.SubmitChanges()
        Dim po2 As POWithDamage
        For Each po2 In Me.alPONeedingActivityUpdate
            'only update activity log on jobs that are specificaly getting flagged as Received
            AddJobNoToActivityArray(po2)
        Next

        UpdateJobActivityToSQL(Me.alJobActivity)
    End Sub

    Private alPONeedingActivityUpdate As New List(Of POWithDamage)
    Private alJobActivity As New List(Of JobActivityLine)

    Private Class POWithDamage
        Public nJobID As Integer = 0
        Public sDamageNotes As String = ""
        Public nBoxes As Integer = 0
        Public nAccount As Integer = 0
        Public dReceived As Date = Nothing
    End Class

    Private Class JobActivityLine
        Public nJobID As Integer = 0
        Public stype As String = ""
        Public sDetail As String = ""
        Public blnHasCabs As Boolean = False
        Public blnWholeJobRecieved As Boolean = False
    End Class

    Private Sub UpdateJobActivityToSQL(ByVal alActivity As List(Of JobActivityLine))
        Dim act1 As JobActivityLine
        For Each act1 In alActivity
            Dim drAct As New tblJobActivity
            With drAct
                .ActivityDetail = act1.sDetail
                .nJobID = act1.nJobID
                .ActivityType = UCase(act1.stype)
                .dateEntered = Now
                .gID = Guid.NewGuid
                .Other = ""
            End With
            dc.tblJobActivities.InsertOnSubmit(drAct)
        Next
        dc.SubmitChanges()

    End Sub

    Private Sub AddJobNoToActivityArray(ByVal PO1 As POWithDamage)
        'we only want to write one line of activity per job number that has been handled by the scanning process

        Dim act1 As JobActivityLine
        Dim i As Integer
        Dim blnFoundActivity As Boolean = False

        Dim sActivityType As String = ""
        Dim sActivityDetail As String = ""

        If PO1.sDamageNotes.Length > 0 Then
            sActivityType = "Job Received"
            sActivityDetail = "Job Received / Damage: " & PO1.sDamageNotes
        Else
            If PO1.nBoxes > 0 Then
                'this is a cabinetry PO
                sActivityType = "Job Received"
                sActivityDetail = "Job Received"
            ElseIf PO1.nAccount = 4010 Then
                sActivityType = "Misc Received"
                sActivityDetail = "Misc Received"
            Else
                sActivityType = "Hardware Received"
                sActivityDetail = "Hardware Received"
            End If
        End If

        For i = 0 To Me.alJobActivity.Count - 1
            act1 = Me.alJobActivity(i)
            If act1.nJobID = PO1.nJobID Then
                blnFoundActivity = True
                'activity has already been added, only overwrite if this is more important
                If InStr(act1.sDetail, "Damage") > 0 Then
                    'dont overwrite existing damage note
                ElseIf PO1.sDamageNotes.Length > 0 Then
                    'overwrite anything other than damage with this new damaged item
                    act1.stype = "Job Received"
                    act1.sDetail = sActivityDetail
                    Me.alJobActivity(i) = act1

                ElseIf act1.stype = "Hardware Received" Then
                    'overwrite with anything
                    If act1.blnHasCabs Then
                        act1.stype = sActivityType
                        act1.sDetail = sActivityDetail
                    Else
                        act1.stype = "Job Received"
                        act1.sDetail = act1.stype

                    End If

                    Me.alJobActivity(i) = act1
                ElseIf act1.stype = "Misc Received" And sActivityType = "Job Received" Then
                    'always overwrite with job received if we did get cabinets
                    act1.stype = sActivityType
                    act1.sDetail = sActivityDetail
                    Me.alJobActivity(i) = act1
                End If

                Exit For
            End If
        Next

        If Not blnFoundActivity Then
            'add a new activity line
            act1 = New JobActivityLine

            'when first adding activity, check if the whole job is just misc pieces or does it have cabinetry?
            'also are the other POs recieved as well?
            'misc items should flag as job recieved only if all other items are received

            act1.blnWholeJobRecieved = True
            For Each drPO1 In (From row In dc.tPOHeaders Where row.nJobID = PO1.nJobID)
                If drPO1.nBoxes > 0 Then
                    act1.blnHasCabs = True
                End If    'disregard labor POs when determining if the whole job has been received
                If drPO1.DREC Is Nothing And drPO1.nAccount < 4040 Then
                    act1.blnWholeJobRecieved = False
                End If
            Next

            If act1.blnHasCabs Then
                act1.stype = sActivityType
                act1.sDetail = sActivityDetail
            ElseIf Not act1.blnWholeJobRecieved Then
                act1.stype = sActivityType
                act1.sDetail = sActivityDetail
            Else
                'even if parts received are misc, flag as job received if everything is in
                act1.stype = "Job Received"
                act1.sDetail = "Job Received"
            End If

            act1.nJobID = PO1.nJobID
            Me.alJobActivity.Add(act1)
        End If
    End Sub

End Class

Public Class PackagePOItem
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private dc As linqTKSIDataContext

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

    Public Property LabelID As String = ""
    Public Property Description As String = ""
    Public Property Received As Boolean
        Get
            Return _received
        End Get
        Set(value As Boolean)
            If value <> _received Then
                updateSQLreceived(value)
            End If
            _received = value
            OnPropertyChanged("brushReceived")
        End Set
    End Property

    Private Sub updateSQLreceived(blnReceive As Boolean)
        If Not PkgRow Is Nothing Then
            If blnReceive Then
                PkgRow.dateReceived = Now
            Else
                PkgRow.dateReceived = Nothing
            End If

            dc.SubmitChanges()
        End If
    End Sub

    Private Sub updateSQLdelivered(blnDelivered As Boolean)
        If Not PkgRow Is Nothing Then
            If blnDelivered Then
                PkgRow.dateDelivered = Now
            Else
                PkgRow.dateDelivered = Nothing
            End If

            Me.dc.SubmitChanges()
        End If
    End Sub

    Public Property Delivered As Boolean
        Get
            Return _delivered
        End Get
        Set(value As Boolean)

            If value <> _delivered Then
                updateSQLdelivered(value)
            End If
            _delivered = value

            OnPropertyChanged("brushReceived")
        End Set
    End Property

    Public Property PO As String = ""
    Private _delivered As Boolean = False
    Private _received As Boolean = False
    Public PkgRow As tblCWPackage
    Private _brushRec As Brush = Current.FindResource("brushFadedYellow")
    Private _brushDel As Brush = Current.FindResource("brushFadedGreen")

    Public ReadOnly Property brushReceived As Brush
        Get
            If Received Then
                If Delivered Then
                    brushReceived = _brushDel
                Else
                    brushReceived = _brushRec
                End If
            Else
                brushReceived = Brushes.White
            End If
        End Get
    End Property

    Sub New(row1 As tblCWPackage, _dc As linqTKSIDataContext)
        dc = _dc
        Me.PkgRow = row1
        If row1.dateDelivered IsNot Nothing Then
            Me._delivered = True
        End If
        If row1.dateReceived IsNot Nothing Then
            Me._received = True

        End If
        Dim strDesc As String = ""
        Dim iTotalCount As Integer = 0
        Try
            Dim sPreviousItem As String = ""
            For Each rowC In (From row In row1.tblCWPackageContents Order By row.cabno)

                iTotalCount += 1
                Dim strNewItem As String = String.Concat(rowC.cabno, "        ", rowC.fdesc, " ", rowC.material)
                Dim sSeperator As String = ""

                sSeperator = vbNewLine   '" | "

                If Not strDesc.Contains(strNewItem) Then
                    If iTotalCount > 1 Then
                        strDesc = String.Concat(strDesc, sSeperator)
                    End If
                    strDesc = String.Concat(strDesc, strNewItem)
                Else
                    strDesc = String.Concat(strDesc, " |")
                End If

                sPreviousItem = strNewItem

            Next

        Catch ex As Exception
            strDesc = "ERROR ***"
        End Try

        Me.LabelID = row1.serialno
        Me.Description = strDesc
        Me.PO = row1.dlrpo & "  (" & row1.shopno & ")"
    End Sub

End Class

Public Class clsPackages
    Inherits ObservableCollection(Of PackagePOItem)
    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Sub New(strTruck As String, blnHideReceived As Boolean, dc2 As linqTKSIDataContext)
        '    Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Dim q1 As IQueryable(Of tblCWPackage)
        If blnHideReceived Then

            q1 = (From row In dc.tblCWPackages Where row.shipdata = strTruck And row.dateReceived Is Nothing Select row)
            Dim l1 = (From row In q1.ToList Order By global_POSortable(row.dlrpo), row.tblCWPackageContents.First.cabno)
            For Each o3 In l1
                Me.Add(New PackagePOItem(o3, dc))
            Next

        Else
            q1 = (From row In dc.tblCWPackages Where row.shipdata = strTruck Select row)
            Dim l1 = (From row In q1.ToList Order By global_POSortable(row.dlrpo), row.tblCWPackageContents.First.cabno)
            For Each o3 In l1
                Me.Add(New PackagePOItem(o3, dc))
            Next

        End If

    End Sub

    Sub New(strPO As String, dsTruckData As dsTKSI, blnHideReceived As Boolean, blnPO As Boolean, dc As linqTKSIDataContext)

        strPO = strPO.TrimEnd("%")
        Dim q1 As IQueryable(Of tblCWPackage)
        q1 = From row In dc.tblCWPackages Where row.dlrpo.StartsWith(strPO)
        For Each o3 In q1
            Me.Add(New PackagePOItem(o3, dc))
        Next
    End Sub

End Class

Public Class clsTrucks
    Inherits ObjectModel.ObservableCollection(Of String)

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Sub New()

        Dim dateCutoff As Date = Now.AddMonths(-3)
        Dim fnIsRecentDate = Function(shipdata As String) As Date
                                 If shipdata.Trim.Length = 0 Then
                                     Return dateCutoff.AddDays(1)  'put at end of list?
                                 End If
                                 If shipdata.Length > 5 Then
                                     Dim dDate As Date
                                     If Date.TryParse(shipdata.Substring(shipdata.Length - 10, 10), dDate) Then
                                         Return dDate
                                     Else
                                         Return dateCutoff.AddDays(1)
                                     End If
                                 End If
                                 Return dateCutoff.AddDays(1)
                             End Function



        Dim q11 = (From row In dc.tblCWPackages Select row.shipdata).Distinct
        Dim listD As New List(Of strAndDate)
        For Each q12 In (From row In q11)
            Dim sad As New strAndDate
            sad.d1 = fnIsRecentDate(q12)
            sad.s1 = q12
            If sad.d1 > dateCutoff Then
                listD.Add(sad)
            End If

        Next
        For Each sad2 As String In (From row In listD Order By row.d1 Descending Select row.s1)
            Me.Add(sad2)
        Next

    End Sub

    Private Structure strAndDate
        Dim s1 As String
        Dim d1 As Date
    End Structure

End Class


