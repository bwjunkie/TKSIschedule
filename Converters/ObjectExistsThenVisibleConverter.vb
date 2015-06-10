
Imports System.Windows.Data
Imports System.Windows
Imports System.Globalization

Public Class ObjectExistsThenVisibleConverter
    Inherits Markup.MarkupExtension
    Implements IValueConverter

    Sub New()

    End Sub

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me
    End Function

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then
            Return Visibility.Collapsed
        Else
            Return Visibility.Visible
        End If
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function


End Class

