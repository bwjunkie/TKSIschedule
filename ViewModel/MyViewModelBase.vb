Public MustInherit Class MyViewModelBase
    Inherits GalaSoft.MvvmLight.ViewModelBase

    Public Sub RaiseNetworkError()
        RaisePropertyChanged("NetworkConnection")
    End Sub

    Public ReadOnly Property NetworkConnection
        Get
            Return global_TestNetworkConnectionFAILED()
        End Get
    End Property

    Public ReadOnly Property ShippingVisibility As Boolean
        Get
            If sUserlevel <= UserRights.Shipping Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property AdminVisibility As Boolean
        Get
            If sUserlevel <= UserRights.Admin Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property PayrollVisibility As Boolean
        Get
            If sUserlevel <= UserRights.Payroll Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property AdminAsstVisibility As Boolean
        Get
            If sUserlevel <= UserRights.AdminAsst Then
                Return True
            End If
            Return False
        End Get
    End Property

    Private _IsActivated As Boolean = False
    Public Property IsActivated As Boolean
        Get
            Return _IsActivated
        End Get
        Set(value As Boolean)
            _IsActivated = value
        End Set
    End Property

    Public ReadOnly Property GiantFontSize As Double
        Get
            If global_largerFontsInUse Then
                Return 20.0
            End If
            Return 24.0
        End Get
    End Property
    Public ReadOnly Property LargeFontSize As Double
        Get
            If global_largerFontsInUse Then
                Return 15.0
            End If
            Return 18.0
        End Get
    End Property
    Public ReadOnly Property NormalFontSize As Double
        Get
            If global_largerFontsInUse Then
                Return 12.0
            End If

            Return 14.0
        End Get
    End Property

    Public ReadOnly Property Small2FontSize As Double
        Get
            If global_largerFontsInUse Then
                Return 9.0
            End If
            Return 10.0
        End Get
    End Property

    Public ReadOnly Property SmallFontSize As Double
        Get
            If global_largerFontsInUse Then
                Return 8.0
            End If
            Return 9.0
        End Get
    End Property

    Public ReadOnly Property BoxWidth120 As Double
        Get
            Return 120.0
        End Get
    End Property

End Class
