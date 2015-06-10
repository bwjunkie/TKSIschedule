
Public Class SimpleBindableBase
    Inherits BindableBase
    Private ReadOnly _fields As New Dictionary(Of String, Object)()

    Protected Overridable Sub [Set](Of T)(value As T, <CallerMemberName> Optional propertyName As String = Nothing)
        If propertyName Is Nothing Then
            Throw New ArgumentNullException("propertyName")
        End If
        If _fields.ContainsKey(propertyName) Then
            Dim oldValue = _fields(propertyName)
            If oldValue.Equals(value) Then ' Equals(oldValue, value) Then
                Return
            End If

            _fields(propertyName) = value
            Me.OnPropertyChanged(propertyName)
        Else
            If Equals(value, Nothing) Then
                Return
            End If
            _fields.Add(propertyName, value)
            Me.OnPropertyChanged(propertyName)
        End If
    End Sub

    Protected Overridable Function [Get](Of T)(<CallerMemberName> Optional propertyName As String = Nothing) As T
        If propertyName Is Nothing Then
            Throw New ArgumentNullException("propertyName")
        End If
        If Not _fields.ContainsKey(propertyName) Then
            Return Nothing
        End If
        Return DirectCast(_fields(propertyName), T)
    End Function

End Class
