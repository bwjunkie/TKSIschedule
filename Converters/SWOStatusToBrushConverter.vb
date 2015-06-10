Imports System.Windows.Data
Imports System.Windows
Imports System.Globalization

Public Class SWOStatusToBrushConverter

    Inherits Markup.MarkupExtension
    Implements IValueConverter

    Sub New()

    End Sub

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me
    End Function

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Try
            Dim status = DirectCast(value, String)
            If status.ToString = "po" Or status = "approved" Then
                Return Brushes.PaleGreen
            Else
                Return Brushes.Transparent
            End If

        Catch ex As Exception
            Return Brushes.Red
        End Try

    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class

