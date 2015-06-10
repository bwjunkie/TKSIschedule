Public Class ValueToBrushConverter
    Inherits Markup.MarkupExtension
    Implements System.Windows.Data.IValueConverter

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me
    End Function

    Sub New()

    End Sub

    Public Function Convert(ByVal value As Object,
                            ByVal targetType As System.Type,
                            ByVal parameter As Object,
                            ByVal culture As System.Globalization.CultureInfo) _
             As Object Implements System.Windows.Data.IValueConverter.Convert

        Dim brush1 As Brush = Brushes.Transparent
        Try
            If DirectCast(value, String).Length > 0 Then
                brush1 = New SolidColorBrush(Color.FromArgb(192, 255, 255, 127))

            End If
        Catch
        End Try
        Return brush1


    End Function

    Public Function ConvertBack(ByVal value As Object,
                                ByVal targetType As System.Type,
                                ByVal parameter As Object,
                                ByVal culture As System.Globalization.CultureInfo) _
            As Object Implements System.Windows.Data.IValueConverter.ConvertBack

        Return Brushes.Transparent

    End Function

End Class
