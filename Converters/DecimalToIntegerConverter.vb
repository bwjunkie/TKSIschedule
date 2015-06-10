Imports System.Windows.Data
Imports System.Windows
Imports System.Globalization
Public Class DecimalToIntegerConverter

    Implements IValueConverter
 
    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then
            Return 0
        Else
            Return CType(value, Integer)
        End If

    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class


