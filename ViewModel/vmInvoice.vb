Imports System.Collections.ObjectModel
Imports System.Data
Imports System.ComponentModel
Imports System.Linq
Imports System.Data.Linq
Imports GalaSoft.MvvmLight.Command
Imports GalaSoft.MvvmLight

Public Class vmInvoice

    Inherits ViewModelBase

    Private dc As linqTKSIDataContext

    Public _so As tSOHeader
    Public Property SO As tSOHeader
        Get
            Return _so
        End Get
        Set(value As tSOHeader)
            _so = value
        End Set
    End Property

    Private _SOLines As ObservableCollection(Of tSOLine)
    Public Property SOLines As ObservableCollection(Of tSOLine)
        Get
            If _SOLines Is Nothing Then
                _SOLines = New ObservableCollection(Of tSOLine)(SO.tSOLines)
            End If
            Return _SOLines

        End Get
        Set(value As ObservableCollection(Of tSOLine))
            _SOLines = value
            RaisePropertyChanged("SOLines")
        End Set
    End Property

    Public ReadOnly Property ItemComment As ObservableCollection(Of String)
        Get
            Dim oc As New ObservableCollection(Of String)
            oc.Add("Item")
            oc.Add("Comment")
            Return oc
        End Get
    End Property

    Public ReadOnly Property AccountList As ObservableCollection(Of Integer)
        Get
            Dim oc As New ObservableCollection(Of Integer)
            oc.Add("0")
            oc.Add("5010")
            oc.Add("5020")
            oc.Add("5030")
            oc.Add("5040")
            oc.Add("5070")
            oc.Add("5260")
            oc.Add("5270")
            oc.Add("5490")
            oc.Add("5570")

            Return oc
        End Get
    End Property

    Public Function HasChanges() As Boolean
        If dc.GetChangeSet.Updates.Count > 0 Or dc.GetChangeSet.Deletes.Count > 0 Or dc.GetChangeSet.Inserts.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Private _prompttext As String = ""
    Public Property prompttext As String
        Get
            Return _prompttext
        End Get
        Set(value As String)
            _prompttext = value
            RaisePropertyChanged("prompttext")
        End Set
    End Property

    Public Function SaveChanges() As Boolean
        StartTimer()
        If Me.HasChanges Then
            SubmitDatabaseChanges()
            Return True
        Else
            'no changes need to be saved
        End If
        EndTimer(2, " long save invoice ")
    End Function

    Private Sub SubmitDatabaseChanges()
        dc.SubmitChanges()
        SOLines = New ObservableCollection(Of tSOLine)(SO.tSOLines)
    End Sub

    Dim _cmdaddline As RelayCommand(Of String)
    Public ReadOnly Property cmdaddline As RelayCommand(Of String)
        Get
            If _cmdaddline Is Nothing Then
                _cmdaddline = New RelayCommand(Of String)(AddressOf cmdAddCommentLine)
            End If
            Return _cmdaddline
        End Get
    End Property

    Dim _cmddeleteso As RelayCommand
    Public ReadOnly Property cmddeleteso As RelayCommand
        Get
            If _cmddeleteso Is Nothing Then
                _cmddeleteso = New RelayCommand(AddressOf DeleteSO)
            End If
            Return _cmddeleteso
        End Get
    End Property

    Private Sub DeleteSO()
        Try
            If MessageBox.Show("Are you sure you want to DELETE this Invoice?", "DELETE?", MessageBoxButton.YesNo) = MessageBoxResult.Yes Then
                dc.tSOHeaders.DeleteOnSubmit(Me.SO)
                dc.SubmitChanges()
                Messaging.Messenger.Default.Send(Of String)("closesowindow", SO.nID)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Dim _cmdsendtosage As RelayCommand
    Public ReadOnly Property cmdsendtosage As RelayCommand
        Get
            If _cmdsendtosage Is Nothing Then
                _cmdsendtosage = New RelayCommand(AddressOf SendToSage)
            End If
            Return _cmdsendtosage
        End Get
    End Property


    Dim _cmdprint As RelayCommand
    Public ReadOnly Property cmdprint As RelayCommand
        Get
            If _cmdprint Is Nothing Then
                _cmdprint = New RelayCommand(AddressOf Print)
            End If
            Return _cmdprint
        End Get
    End Property

    Private Sub Print()
        MessageBox.Show("feature not ready")
        'Try
        '    Me.SaveChanges()
        '    Dim daPO As New dsTKSITableAdapters.tPOHeaderTableAdapter
        '    Dim dsPO As New dsTKSI
        '    dsPO.EnforceConstraints = False
        '    If daPO.FillByNID(dsPO.tPOHeader, Me.PO.nID) > 0 Then
        '        Dim drPO As dsTKSI.tPOHeaderRow = dsPO.tPOHeader(0)
        '        Dim daLine As New dsTKSITableAdapters.tPOLineTableAdapter
        '        daLine.FillByNPOID(dsPO.tPOLine, Me.PO.nID)
        '        Dim daven As New dsTKSITableAdapters.tVendorTableAdapter
        '        daven.Fill(dsPO.tVendor)

        '        Dim drPrint As New frmPO
        '        drPrint.drPO = drPO
        '        drPrint.Show()
        '        drPrint.flexPOHeader.PrintGrid("", True, 1, 40, 40)
        '    End If

        'Catch ex As Exception
        '    Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

        'POtoPDF(Me.PO)
    End Sub

    Private Sub SendToSage()
        MessageBox.Show("feature not ready")
        'If Me.HasChanges Then
        '    MessageBox.Show("Changes must be saved first.")
        'Else

        '    If UpdateSimply(Me.SO) Then

        '        Me.SO.dsimply = Now

        '        Me.dc.SubmitChanges()

        '        MessageBox.Show("Sage Updated")
        '    Else
        '        MessageBox.Show("Did not update, please  check Sage/Peachtree. (PO line items must exist)")
        '    End If
        '    Else
        '    'user cancelled
        'End If
        'End If


    End Sub

    Private Sub AddLine(_desc As String, _received As Boolean, _cost As Decimal, _account As Integer, _type As String, _so As tSOHeader, _dc As linqTKSIDataContext)
        Try
            If _desc Is Nothing Then
                _desc = ""
            End If

            Dim iLineNo As Integer = 1
            Dim q = (From row In SO.tSOLines Select row.nLineNumber)
            If q.Count > 0 Then
                iLineNo = q.Max + 1
            End If
            Dim line1 As New tSOLine
            With line1
                .nLineNumber = iLineNo
                .sDesc = _desc

                ' .sReceived = _received
                ' .nCost = _cost
                .nAccountID = _account
                .sType = _type
                .tSOHeader = _so
            End With
            _dc.tSOLines.InsertOnSubmit(line1)
            Me.SOLines.Add(line1)
            ' _dc.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("Error adding line " & ex.Message)
        End Try
    End Sub

    Private Sub cmdAddCommentLine(_description As String)
        AddLine(_description, False, 0, 0, "Comment", Me.SO, Me.dc)
    End Sub

    Dim _cmdsave As RelayCommand
    Public ReadOnly Property cmdsave As RelayCommand
        Get
            If _cmdsave Is Nothing Then
                _cmdsave = New RelayCommand(AddressOf SaveChanges)
            End If
            Return _cmdsave
        End Get
    End Property

    Dim _cmddeleteline As RelayCommand(Of Integer)
    Public ReadOnly Property cmddeleteline As RelayCommand(Of Integer)
        Get
            If _cmddeleteline Is Nothing Then
                _cmddeleteline = New RelayCommand(Of Integer)(AddressOf DeleteLine)
            End If
            Return _cmddeleteline
        End Get
    End Property

    Private Sub DeleteLine(iLine As Integer)
        Dim qdel = (From row In Me.SO.tSOLines Where row.nLineNumber = iLine)
        If qdel.Count > 0 Then
            Me.dc.tSOLines.DeleteOnSubmit(qdel.First)
            SOLines.Remove(qdel.First)
            RaisePropertyChanged("POLines")
        End If
    End Sub

    Sub New()

    End Sub

    Public Sub LoadInvoice(_soid As Integer)
        dc = GetLinqDataContext()
        Dim q = (From row In dc.tSOHeaders Where row.nID = _soid)
        If q.Count > 0 Then
            Me.SO = q.First
            SOLines = New ObservableCollection(Of tSOLine)(SO.tSOLines)
            AddHandler SOLines.CollectionChanged, AddressOf lineschanged
        End If

    End Sub

    Private Sub lineschanged()

    End Sub

End Class
