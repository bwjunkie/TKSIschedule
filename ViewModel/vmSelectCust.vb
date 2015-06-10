Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.ComponentModel
Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command

Public Class vmSelectCust

    Inherits ViewModelBase

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Private _listcustomers As New ObservableCollection(Of cust1)
    Public Property listcustomers As ObservableCollection(Of cust1)
        Get
            Return _listcustomers
        End Get
        Set(value As ObservableCollection(Of cust1))
            _listcustomers = value
            RaisePropertyChanged("listcustomers")

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

    Private _selectedcust As cust1
    Public Property selectedcust As cust1
        Get
            Return _selectedcust
        End Get
        Set(value As cust1)
            _selectedcust = value
            RaisePropertyChanged("selectedcust")
        End Set
    End Property

    Public Class file1
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
    End Class

    Public Class cust1
        Public Property lid As Integer
        Public Property sName As String
        Sub New()

        End Sub
    End Class

    Private Sub DoSearchCust()
        StartTimer()
        Dim q = (From row In dc.tCustomrs Where row.sName.StartsWith(searchstringcust.Trim) Order By row.sName Select New cust1 With {.lid = row.lID, .sName = row.sName})
        listcustomers = New ObservableCollection(Of cust1)(q.ToList)
        EndTimer(1, " long cust search ")
    End Sub

    Public Sub OpenCustDetail()
        If selectedcust IsNot Nothing Then
            Dim cust1 As New CustDetail
            cust1.lCustID = selectedcust.lid
            cust1.ShowDialog()
        End If
    End Sub

    Private _CustDoubleClick As RelayCommand
    Public ReadOnly Property CustDoubleClick As RelayCommand
        Get
            If _CustDoubleClick Is Nothing Then
                _CustDoubleClick = New RelayCommand(AddressOf CustomerSelected)
            End If
            Return _CustDoubleClick
        End Get
    End Property

    Private Sub CustomerSelected()
        If Me.selectedcust IsNot Nothing Then
            Messaging.Messenger.Default.Send("closecustomerwindow")
        End If

    End Sub

End Class
