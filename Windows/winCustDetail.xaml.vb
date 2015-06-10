Public Class winCustDetail
    Public Sub loadCust(_ncustid As Integer)
        Dim vm As New CustomerDetailViewModel()
        vm.LoadCust(_ncustid)
        Me.DataContext = vm
    End Sub

End Class
