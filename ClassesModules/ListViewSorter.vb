Imports System.Windows.Forms

Public Class ListViewSorter
    ' We need to Implement IComparer so our 
    ' ListView can use this class
    Implements System.Collections.IComparer

    Public Enum EnumSortOrder As Integer
        Ascending = 0
        Descending = 1
    End Enum

    Public SortOrder As EnumSortOrder
    Public SortColumn As Integer

    ' Default constructor
    '  SortColumn - ListView column to sort on
    Public Sub New( _
        ByVal SortColumn As Integer, _
        ByVal SortOrder As EnumSortOrder)

        Me.SortColumn = SortColumn
        Me.SortOrder = SortOrder

    End Sub

    ' Compare objects based in the IComparer Interface
    Public Function Compare( _
        ByVal x As Object, _
        ByVal y As Object) _
        As Integer _
        Implements System.Collections.IComparer.Compare

        Dim xString As String = ""
        Dim YString As String = ""

        ' Convert the two passed values to listview items
        Dim l1 As ListViewItem
        Dim l2 As ListViewItem

        l1 = CType(x, ListViewItem)
        l2 = CType(y, ListViewItem)

        ' Get the appropriate text values depending on whether we are being asked
        ' to sort on the first column (0) or subitem columns (>0)
        Try
            If SortColumn = 0 Then
                ' SortColumn is 0, we need to compare the Text property of the Item itself
                xString = l1.Text
                YString = l2.Text
            Else
                ' SortColumn is not 0, so we need to compare the Text property of the SubItem
                xString = l1.SubItems(SortColumn).Text
                YString = l2.SubItems(SortColumn).Text
            End If
        Catch ex As Exception

        End Try


        If l1.ListView.Columns(SortColumn).Text = "PAGES" Then
            If IsNumeric(xString) And IsNumeric(YString) Then
                Dim xNum As Long
                Dim yNum As Long
                xNum = CLng(xString)
                yNum = CLng(YString)
                If xNum = yNum Then
                    Return 0
                ElseIf xNum > yNum Then
                    ' X is greater than Y
                    If SortOrder = EnumSortOrder.Ascending Then
                        Return 1
                    Else
                        Return -1
                    End If
                ElseIf xNum < yNum Then
                    ' Y is greater than X
                    If SortOrder = EnumSortOrder.Ascending Then
                        Return -1
                    Else
                        Return 1
                    End If
                End If
            End If
        End If

        If (l1.ListView.Columns(SortColumn).Text) = "DAY" Or (l1.ListView.Columns(SortColumn).Text) = "dateRec" Then
            If InStr(xString, "/") > 0 And InStr(YString, "/") > 0 Then
                Try
                    If IsDate(xString) And IsDate(YString) Then
                        Dim xdate As Date
                        Dim ydate As Date
                        xdate = CDate(xString)
                        ydate = CDate(YString)
                        If xdate = ydate Then
                            Return 0
                        ElseIf xdate > ydate Then
                            ' X is greater than Y
                            If SortOrder = EnumSortOrder.Ascending Then
                                Return 1
                            Else
                                Return -1
                            End If
                        ElseIf xdate < ydate Then
                            ' Y is greater than X
                            If SortOrder = EnumSortOrder.Ascending Then
                                Return -1
                            Else
                                Return 1
                            End If
                        End If
                    End If
                Catch ex As Exception
                    Return -1
                End Try
            Else
                Return -1
            End If
        End If

        'Do the comparison
        'Try
        '    If Len(xString) > 0 And Len(YString) > 0 Then
        '        Dim xdate As Date
        '        Dim ydate As Date
        '        xdate = CDate(xString)
        '        ydate = CDate(YString)
        '        If xdate = ydate Then
        '            Return 0
        '        ElseIf xdate > ydate Then
        '            ' X is greater than Y
        '            If SortOrder = EnumSortOrder.Ascending Then
        '                Return 1
        '            Else
        '                Return -1
        '            End If
        '        ElseIf xdate < ydate Then
        '            ' Y is greater than X
        '            If SortOrder = EnumSortOrder.Ascending Then
        '                Return -1
        '            Else
        '                Return 1
        '            End If
        '        End If
        '    End If
        'Catch
        'End Try

        If xString = YString Then
            ' Values are equal
            Return 0
        ElseIf xString > YString Then
            ' X is greater than Y
            If SortOrder = EnumSortOrder.Ascending Then
                Return 1
            Else
                Return -1
            End If
        ElseIf xString < YString Then
            ' Y is greater than X
            If SortOrder = EnumSortOrder.Ascending Then
                Return -1
            Else
                Return 1
            End If

        End If

    End Function

End Class
