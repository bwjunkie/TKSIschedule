Imports System.Collections.ObjectModel
Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command

Public Class vmTaskList
    Inherits GalaSoft.MvvmLight.ViewModelBase

    Public dc As linqTKSIDataContext = GetLinqDataContext()

    Private _listAll As ObservableCollection(Of tblTasklist)
    Private ReadOnly Property ocEntiretList() As ObservableCollection(Of tblTasklist)
        Get
            If _listAll Is Nothing Then
                Dim q = (From row In dc.tblTasklists)
                _listAll = New ObservableCollection(Of tblTasklist)(q.ToList)
            End If
            Return _listAll
        End Get
    End Property

    Private _listfixes As ObservableCollection(Of tblTasklist)
    Public Property listfixes As ObservableCollection(Of tblTasklist)  'this is the filtered list
        Get
            Dim listReturn As New ObservableCollection(Of tblTasklist)

            _listfixes = New ObservableCollection(Of tblTasklist)(From row In ocEntiretList Order By row.dateentered Descending)

            'If radioeveryonelist Then
            '    _listfixes = New ObservableCollection(Of tblTasklist)(From row In ocEntiretList Order By row.users, row.dateentered)
            'ElseIf radiomylist Then
            '    _listfixes = New ObservableCollection(Of tblTasklist)(From row In ocEntiretList Where row.users.ToUpper.Contains(global_Username) Order By row.users, row.dateentered)
            'End If

            'If checkboxhidecompleted Then
            '    Dim q = (From row In _listfixes Where (Not row.metatags.ToUpper.Contains("COMPLETED")))
            '    _listfixes = New ObservableCollection(Of tblTasklist)(q.ToList)
            'Else
            '    Dim q = (From row In _listfixes)
            '    _listfixes = New ObservableCollection(Of tblTasklist)(q.ToList)
            'End If

            Return _listfixes
        End Get
        Set(value As ObservableCollection(Of tblTasklist))
            _listfixes = value

            RaisePropertyChanged("listfixes")
        End Set
    End Property

    'Private _checkboxhidecompleted As Boolean
    'Public Property checkboxhidecompleted As Boolean
    '    Get
    '        Return _checkboxhidecompleted
    '    End Get
    '    Set(value As Boolean)
    '        _checkboxhidecompleted = value
    '        RaisePropertyChanged("listfixes")
    '    End Set
    'End Property

    'Private _radioeveryonelist As Boolean
    'Public Property radioeveryonelist As Boolean
    '    Get
    '        Return _radioeveryonelist
    '    End Get
    '    Set(value As Boolean)
    '        _radioeveryonelist = value
    '        If value Then
    '            _radiomylist = False
    '            RaisePropertyChanged("listfixes")
    '        End If
    '    End Set
    'End Property

    'Private _radiomylist As Boolean = True
    'Public Property radiomylist As Boolean
    '    Get
    '        Return _radiomylist
    '    End Get
    '    Set(value As Boolean)
    '        _radiomylist = value
    '        If value Then
    '            _radioeveryonelist = False
    '            RaisePropertyChanged("listfixes")
    '        End If

    '    End Set
    'End Property

    Public Sub windowclosing()
        Try
            Me.dc.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public ReadOnly Property cmdsave As RelayCommand
        Get
            Return New RelayCommand(AddressOf windowclosing)
        End Get
    End Property

    Private _cmddeleteline As RelayCommand(Of Object)
    Public ReadOnly Property cmddeleteline As RelayCommand(Of Object)
        Get
            If _cmddeleteline Is Nothing Then
                _cmddeleteline = New RelayCommand(Of Object)(AddressOf DeleteLine)
            End If
            Return _cmddeleteline
        End Get
    End Property

    Private Sub DeleteLine(item1 As Object)
        If item1.GetType Is GetType(tblTasklist) Then
            Dim tsk = DirectCast(item1, tblTasklist)
            Me._listAll.Remove(tsk)
            Me.dc.tblTasklists.DeleteOnSubmit(tsk)
            ' dc.SubmitChanges()
            RaisePropertyChanged("listfixes")
        End If
    End Sub

    Private _cmdaddnewline As relaycommand
    Public ReadOnly Property cmdaddnewline As relaycommand
        Get
            If _cmdaddnewline Is Nothing Then
                _cmdaddnewline = New RelayCommand(AddressOf AddNewLine)
            End If
            Return _cmdaddnewline
        End Get
    End Property

    Private Sub AddNewLine()
        Try
            Dim line1 As New tblTasklist
            With line1
                .gid = Guid.NewGuid
                .metatags = ""
                .users = global_Username
                .datemodified = Now
                .dateentered = Now
                .description = "new"
            End With
            Me.dc.tblTasklists.InsertOnSubmit(line1)
            ' Me.dc.SubmitChanges()
            _listAll.Add(line1)
            RaisePropertyChanged("listfixes")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
