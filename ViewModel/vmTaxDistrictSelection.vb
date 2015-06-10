Imports System.Collections.ObjectModel

Public Class vmTaxDistrictSelection
    Inherits MyViewModelBase

    Public dc As linqTKSIDataContext
    Public job As tJob

    Public ReadOnly Property taxlist As ObservableCollection(Of tblTaxDistrict)
        Get
            Dim currentjobtax = (From row In job.tblJobTaxes Select row.tblTaxDistrict)
            Dim q = (From row In dc.tblTaxDistricts Order By row.Note)
            For Each tax In q
                If currentjobtax.Contains(q) Then
                    tax.isSelected = True
                End If
            Next
            Return New ObservableCollection(Of tblTaxDistrict)(q.ToList)
        End Get
    End Property

End Class
