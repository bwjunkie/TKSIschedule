
Imports System.Windows.Data
Imports System.Windows
Imports System.Globalization

Public Class CommissionPriorityConverter
    Inherits Markup.MarkupExtension
    Implements IValueConverter

    Sub New()

    End Sub

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me
    End Function

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert

        Dim iStruct As Integer = 0
        If Integer.TryParse(value, iStruct) Then
            If iStruct > 0 Then
                Dim dc As linqTKSIDataContext = GetLinqDataContext()
                Dim q = (From row In dc.tblCommissionStructures Where row.lngID = iStruct)
                If q.Count > 0 Then
                    Return q.First.lngPriority.ToString
                End If
            End If

        End If
        Return (0).ToString
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function

End Class
