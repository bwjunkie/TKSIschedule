Imports System.ComponentModel

Public Class frmPromtUserYesNo

    '  Public OK As Boolean = False

    '<BrowsableAttribute(False)> _
    'Public Overloads Property DialogResult() As DialogResult
    '    Get

    '    End Get
    '    Set(ByVal value As DialogResult)

    '    End Set
    'End Property

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()

    End Sub

End Class