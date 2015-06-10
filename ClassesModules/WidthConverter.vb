Imports System.Globalization

Public Class WidthConverter

    Implements IValueConverter
    Public Function Convert(o As Object, t As Type, parameter As Object, cult As CultureInfo) Implements IValueConverter.Convert
        Dim l As ListView = o
        Dim g As GridView = l.View
        Dim total As Double = 0
        For i As Integer = 0 To g.Columns.Count - 1
            total += g.Columns(i).ActualWidth
        Next
        Return l.ActualWidth - total
    End Function
    Public Function ConvertBack(o As Object, t As Type, parameter As Object, culture As CultureInfo) Implements IValueConverter.ConvertBack
        Throw New NotSupportedException
    End Function

End Class
