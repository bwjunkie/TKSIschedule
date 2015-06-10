Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight

Public Class ocCommissions
    Inherits viewmodelbase
    ' Inherits ObservableCollection(Of CommissionList)

    Public Sub New()
        Me.commlist.Add(New CommissionList)
    End Sub

    Private _commlist As New ObservableCollection(Of CommissionList)
    Public Property commlist As ObservableCollection(Of CommissionList)
        Get
            Return _commlist
        End Get
        Set(value As ObservableCollection(Of CommissionList))
            _commlist = value
            RaisePropertyChanged("commlist")
        End Set
    End Property

    Private _selectedcomm As CommissionList
    Public Property selectedcomm As CommissionList
        Get
            Return _selectedcomm
        End Get
        Set(value As CommissionList)
            _selectedcomm = value

            RaisePropertyChanged("selectedcomm")
        End Set
    End Property
End Class


