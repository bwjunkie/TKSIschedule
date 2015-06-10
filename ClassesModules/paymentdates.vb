Imports System.Windows.Data

Public Class paymentdates

    Inherits Collections.ObjectModel.ObservableCollection(Of String)

    Public ReadOnly ALL_UNPAID As String = "ALL UNPAID"

    Public Sub New()
        CreateItems()
        Dim dv = CollectionViewSource.GetDefaultView(Me)
        dv.MoveCurrentTo(ALL_UNPAID)
    End Sub

    Public Sub New(sdate As String)
        CreateItems()
        Dim dv = CollectionViewSource.GetDefaultView(Me)

        If Date.TryParse(sdate, Nothing) Then
            dv.MoveCurrentTo(sdate)
        Else
            dv.MoveCurrentTo(ALL_UNPAID)
        End If
    End Sub

    Public Sub CreateItems()

        Me.Add(ALL_UNPAID)

        ' If Not globalIsInDesignerMode() Then
        Using dt As New System.Data.DataTable
            Dim da As New System.Data.SqlClient.SqlCommand("SELECT DISTINCT dDate FROM tPayments ORDER BY dDate DESC")
            da.Connection = New System.Data.SqlClient.SqlConnection(My.Settings.TKSIJOBSConnectionString)
            da.Connection.Open()
            Dim dreader As System.Data.SqlClient.SqlDataReader = da.ExecuteReader
            Do While dreader.Read
                Me.Add(dreader.GetDateTime(0).ToShortDateString)
            Loop
            da.Connection.Close()
        End Using

    End Sub

End Class

