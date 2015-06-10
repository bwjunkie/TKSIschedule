Imports System.ComponentModel
Imports System.Windows.Data
Imports System.Windows.Media


Public Class salesperson
    Inherits TKSIJOBSDataSet.tEmployeeDataTable
    Public Sub New()
        Dim daSales As New TKSIJOBSDataSetTableAdapters.tEmployeeTableAdapter
        daSales.FillByNotArchive(Me)
    End Sub
End Class


