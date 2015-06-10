
Imports System.Windows.Data
Imports System.Windows
Imports System.Globalization

Public Class RtfToTextConverter
    Inherits Markup.MarkupExtension
    Implements IValueConverter

    Sub New()

    End Sub

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me
    End Function

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Try
            Dim returnValue As String = String.Empty
            Dim converter As New System.Windows.Forms.RichTextBox()
            converter.Rtf = DirectCast(value, String)
            returnValue = converter.Text
            Return returnValue
        Catch ex As Exception
            Return "*error*"
        End Try

    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
