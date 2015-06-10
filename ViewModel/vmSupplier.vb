Imports System.Linq
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command

Public Class vmSupplier
    Inherits ViewModelBase

    Public Class VendorPOsDateRange
        Public Property listPO As ObservableCollection(Of tPOHeader)
        Public Property VendorRow As tVendor
        Public ReadOnly Property totalboxes As Integer
            Get
                Dim q = (From row In listPO Select row.nBoxes).Sum
                Return q
            End Get
        End Property
    End Class

    Public Property listVendor As ObservableCollection(Of VendorPOsDateRange)
    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Public Sub New(VendorID As Integer, dateStart As Date, dateEnd As Date)
        Dim qPO = (From row In dc.tPOHeaders Where row.dRequired >= dateStart And row.dRequired <= dateEnd)
        Dim qVen = (From row In qPO Select row.tVendor).Distinct

        For Each ven In qVen
            Dim pogroup As New VendorPOsDateRange
            Dim qPOVen = (From row In qPO Where row.tVendor Is ven)
            With pogroup
                .VendorRow = ven
                .listPO = New ObservableCollection(Of tPOHeader)(qPOVen)
            End With
        Next
    End Sub
End Class
