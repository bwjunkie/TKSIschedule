Imports System.ComponentModel
Imports System.Windows.Media
Imports GalaSoft.MvvmLight

Public Class CommissionList
    Inherits viewmodelbase

    Public Property JobDetails As String = "Job: No Jobs Selected"
    Public Property sJobNo As String = "JOBNO?"
    Public Property TotalSale As String = "0.00"
    Public Property TotalCost As String = "0.00"
    Public Property Factor As String = ".00"
    Public Property CommissionDetail As String = ""
    Public Property CustPayment As String = "0.00"
    Public Property colorPaymentFull As Brush = Brushes.PaleGreen
    Public Property dDate As String = "1/1/2000"
    Public Property Contract As String = "0.00"
    Public Property salesnickname As String = ""

    Public Property Total5010 As String = "0"
    Public Property Total5030 As String = "0"
    Public Property Total5040 As String = "0"

    Public Property Total4010 As String = "0"
    Public Property Total4030 As String = "0"
    Public Property Total4040 As String = "0"

    Public Property JobMarkup As String = "0.00"

    Public Property colorJobMarkup As Brush = Brushes.PaleGreen
    Public Property decPortionToPay As Decimal = 0
    Public Property decPaymentsThisDate As Decimal = 0
    Public Property decPaymentsFromAnyDates As Decimal = 0

    Public Property CommRate As String = "commrate"
    Public Property CommTotal As String = "commtotal"
    Public Property NetProfit As String = "netprofit"
    Public Property BalanceDue As String = "balancedue"
    Public Property nJobID As Integer = 0
    Public Property nAddressID As Integer = 0
    Public Property PaymentTotals As New clsPaymentsTotals

    Private _ClickToPay As String = "Click To Pay"
    Private _colorClickToPay As Brush = New SolidColorBrush(Color.FromRgb(150, 150, 150))

    'Private _borderbrush As Brush = Brushes.Gray
    'Public Property borderbrush As Brush
    '    Get
    '        Return _borderbrush
    '    End Get
    '    Set(value As Brush)
    '        _borderbrush = value
    '        RaisePropertyChanged("borderbrush")
    '    End Set
    'End Property



    'Private _borderthickness As Thickness = New Thickness(1)
    'Public Property borderthickness As Thickness
    '    Get
    '        Return _borderthickness
    '    End Get
    '    Set(value As Thickness)
    '        _borderthickness = value
    '        RaisePropertyChanged("borderthickness")
    '    End Set
    'End Property

    Public Property ClickToPay As String
        Get
            Return _ClickToPay
        End Get
        Set(value As String)
            _ClickToPay = value
            RaisePropertyChanged("ClickToPay")
        End Set
    End Property

    Public Property colorClickToPay As Brush
        Get
            Return _colorClickToPay
        End Get
        Set(value As Brush)
            _colorClickToPay = value
            RaisePropertyChanged("colorClickToPay")
        End Set
    End Property

    Public Sub New(_JobDetails As String)
        Me.JobDetails = _JobDetails
    End Sub

    Public Sub New()

    End Sub

    Public Class clsPaymentsTotals
        Public Property nPaymentID As New List(Of Integer)
        Public Property PaymentTotal As Decimal = 0
        Public Property PaymentCount As Integer = 0
    End Class

End Class

