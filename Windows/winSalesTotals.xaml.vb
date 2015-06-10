Public Class winSalesTotals
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim vm As New vmSalesTotals
        Me.DataContext = vm

    End Sub
End Class
