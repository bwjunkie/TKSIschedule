Public Class FocusMessage

    Sub New(_msg As String, _dataID As Integer)
        objectnametofocus = _msg
        Me.dataID = _dataID
    End Sub

    Public objectnametofocus As String
    Public dataID As Integer
    Public Shared taxfocus As String = "taxfocus"
    Public Shared topboxfocus As String = "topbox"
End Class
