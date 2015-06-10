
Imports System.Collections.ObjectModel
Imports System.Data
Imports System.ComponentModel
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight

Public Class vmShipping
    Inherits ViewModelBase

    Private dsTruckData As New dsTKSI
    Private SelPO As String = ""
    Public Property listTrucks As clsTrucks
    Public Property listTruckPackages As clsPackages
    Private dispatcherTimer As System.Windows.Threading.DispatcherTimer
    Private HideReceived As Boolean = False

    Public Property refreshcommand As RelayCommand
    Public Property printcommand As RelayCommand

    Private listPOlog As New List(Of POLog)

    Private Property BusyPleaseWait As Boolean
        Get
            Return HideReceived
        End Get
        Set(value As Boolean)
            HideReceived = value
            RaisePropertyChanged("visbusy")
        End Set
    End Property

    Public ReadOnly Property visbusy As Windows.Visibility
        Get
            If BusyPleaseWait Then
                visbusy = Windows.Visibility.Visible
            Else
                visbusy = Windows.Visibility.Collapsed
            End If
        End Get
    End Property

    Public ReadOnly Property collistTruckPackages As CollectionView
        Get
            If listTruckPackages Is Nothing Then
                Return Nothing
            Else
                Dim MyCollectionView As ListCollectionView = New ListCollectionView(listTruckPackages)
                MyCollectionView.SortDescriptions.Add(New SortDescription("PO", ListSortDirection.Ascending))
                Dim GroupDescription As PropertyGroupDescription = New PropertyGroupDescription("PO")
                MyCollectionView.GroupDescriptions.Add(GroupDescription)

                Return MyCollectionView
            End If

        End Get
    End Property

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Sub New()

        listTrucks = New clsTrucks

        dispatcherTimer = New System.Windows.Threading.DispatcherTimer()
        AddHandler dispatcherTimer.Tick, AddressOf dispatcherTimer_Tick
        dispatcherTimer.Interval = New TimeSpan(0, 0, 20)
        dispatcherTimer.Start()

        refreshcommand = New RelayCommand(AddressOf Executerefreshcommand)
        printcommand = New RelayCommand(AddressOf Executeprintcommand)
    End Sub

    Private Function Executeprintcommand()
        PrintData()
    End Function

    Private Function Executerefreshcommand()
        UpdateTruckData()
    End Function

    Private Sub dispatcherTimer_Tick()
        UpdateTruckData()
    End Sub

    Private Sub PrintData()
        Try
            Dim pdf1 As New clsPDFCreate(SelectedPO)
            pdf1.AddParagraphToPDF(vbTab & vbTab & " Delivery Report " & Now.ToShortDateString & " " & Now.ToShortTimeString)
            pdf1.AddParagraphToPDF("")
            pdf1.PDFAddHalfSeperatorLine()
            pdf1.AddParagraphToPDF("")
            For Each o In (From row In listTruckPackages Where row.Delivered = False)
                pdf1.AddParagraphToPDF("Not Delivered: " & o.PO & " Label: " & o.LabelID)
            Next
            pdf1.PDFAddHalfSeperatorLine()
            pdf1.AddParagraphToPDF("")
            pdf1.AddParagraphToPDF("Delivered")
            pdf1.AddParagraphToPDF("")
            pdf1.PDFAddHalfSeperatorLine()
            For Each o In (From row In listTruckPackages Where row.Delivered = True)
                pdf1.AddParagraphToPDF(o.PO)
            Next
            pdf1.PDFAddHalfSeperatorLine()
            pdf1.AddParagraphToPDF("")
            pdf1.ShowPDF()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Public Property SelectedPO As String
        Get
            Return SelPO
        End Get
        Set(value As String)
            SelPO = value
            UpdateTruckData()

        End Set
    End Property

    Private Sub UpdateTruckData()
        If SelPO.Length > 3 Then
            dispatcherTimer.Stop()
            dispatcherTimer.Start()

            BusyPleaseWait = True
            listTruckPackages = New clsPackages(SelPO, dsTruckData, Me.HideReceived, True, Me.dc)
            RaisePropertyChanged("listTruckPackages")
            RaisePropertyChanged("collistTruckPackages")
            BusyPleaseWait = False
        End If

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

End Class






