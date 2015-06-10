Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight.Command

Public Class CustomerDetailViewModel
    Inherits MyViewModelBase

    Private _jobscollection As CollectionView
    Public ReadOnly Property jobscollection As CollectionView
        Get
            If _jobscollection Is Nothing Then
                _jobscollection = New CollectionView(listjobsextra)
            End If
            Return _jobscollection
        End Get
    End Property

    Public ReadOnly Property cmdsaveinvoicenotes As RelayCommand
        Get
            Return New RelayCommand(AddressOf saveinvoicenotes)
        End Get
    End Property

    'Private _invoicenotes As String
    'Public Property invoicenotes As String
    '    Get
    '        If cust.tblCustomerExtendeds Is Nothing Then
    '            _invoicenotes = ""
    '        ElseIf _invoicenotes Is Nothing Then
    '            _invoicenotes = cust.tblCustomerExtendeds.InvoiceNotes
    '        End If
    '        Return _invoicenotes
    '    End Get
    '    Set(value As String)
    '        If value Is Nothing Then
    '            _invoicenotes = ""
    '        Else
    '            _invoicenotes = value
    '        End If
    '        RaisePropertyChanged("invoicenotes")
    '    End Set
    'End Property

    Private Sub saveinvoicenotes()
        Try
            'Dim extended As tblCustomerExtended
            'If cust.tblCustomerExtendeds Is Nothing Then
            '    extended = New tblCustomerExtended
            '    extended.InvoiceNotes = ""
            '    extended.tCustomr = cust
            '    dc.tblCustomerExtendeds.InsertOnSubmit(extended)
            'Else
            '    extended = cust.tblCustomerExtendeds
            'End If

            'extended.InvoiceNotes = invoicenotes
            StartTimer()
            Me.dc.SubmitChanges()

            EndTimer(2, " long save cust detail ")
        Catch ex As Exception
            Windows.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Property selectedjob

    Private _listjobsextra As ObservableCollection(Of Object)
    Public Property listjobsextra As ObservableCollection(Of Object)
        Get
            Return _listjobsextra
        End Get
        Set(value As ObservableCollection(Of Object))
            _listjobsextra = value
            _jobscollection = Nothing

            RaisePropertyChanged("jobscollection")
            RaisePropertyChanged("jobslist")

        End Set
    End Property

    Private _cust As tCustomr
    Public Property cust As tCustomr
        Get
            Return _cust

        End Get
        Set(value As tCustomr)
            _cust = value
            RaisePropertyChanged("cust")
        End Set
    End Property

    Private dc As linqTKSIDataContext = GetLinqDataContext()
    Public Sub LoadCust(_custID As Integer)
        Dim qcust = (From row In dc.tCustomrs Where row.lID = _custID)
        If qcust.Count > 0 Then
            cust = qcust.Single

            If cust.tblCustomerExtendeds Is Nothing Then
                Dim extended As New tblCustomerExtended
                extended = New tblCustomerExtended
                extended.InvoiceNotes = ""
                extended.tCustomr = cust
                dc.tblCustomerExtendeds.InsertOnSubmit(extended)
            End If
            DoSearch(_custID)
        End If

    End Sub

    Private Sub DoSearch(_custid As Integer)

        Dim listReturn As New ObservableCollection(Of Object)

        Dim qadd1 = (From row In dc.tJobs Where row.nCustID = _custid Select row.tAddress)

        Dim qAdd = (From row In dc.tAddresses Where qadd1.Contains(row) Order By row.sLocCode.PadLeft(8, "0") Select row.nID, row.sLocCode, row.sAddress1, jobs1 = (From rowj In row.tJobs Where rowj.nCustID = _custid).ToList)

        For Each add1 In qAdd
            listReturn.Add(New file1(add1.nID, "FILE: " & add1.sLocCode, add1.sAddress1))
            For Each job1a In add1.jobs1
                listReturn.Add(New job1(job1a.nID, job1a.nAddressID, "", "JOB: " & job1a.sJobNo & " - " & job1a.sJobDesc))
            Next
        Next
        listjobsextra = listReturn
    End Sub
End Class
