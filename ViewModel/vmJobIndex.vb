Public Class vmJobIndex

    Private _dc As linqTKSIDataContext
    Private Property dc As linqTKSIDataContext
        Get
            If _dc Is Nothing Then
                _dc = GetLinqDataContext()
                _dc.ObjectTrackingEnabled = True
            End If
            Return _dc
        End Get
        Set(value As linqTKSIDataContext)
            _dc = value
        End Set
    End Property

End Class
