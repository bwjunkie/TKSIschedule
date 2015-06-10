Public Class DateConverter
    Implements System.Windows.Data.IValueConverter

    Public Function Convert(ByVal value As Object,
                            ByVal targetType As System.Type,
                            ByVal parameter As Object,
                            ByVal culture As System.Globalization.CultureInfo) _
             As Object Implements System.Windows.Data.IValueConverter.Convert

        Dim dreturn As Date

        If Date.TryParse(value, dreturn) Then
            Return dreturn
        Else
            Return CDate("1/1/2000")
        End If
     


    End Function

    Public Function ConvertBack(ByVal value As Object,
                                ByVal targetType As System.Type,
                                ByVal parameter As Object,
                                ByVal culture As System.Globalization.CultureInfo) _
            As Object Implements System.Windows.Data.IValueConverter.ConvertBack

        Dim strValue As String = value
        Dim resultDateTime As DateTime
        If DateTime.TryParse(strValue, resultDateTime) Then
            Return resultDateTime
        End If
        Return DependencyProperty.UnsetValue

    End Function
End Class



