Imports System.Windows.Data
Imports System.Windows
Imports System.Globalization

Public Class BooleanToVisibilityConverter
    Inherits Markup.MarkupExtension
    Implements IValueConverter

    Sub New()

    End Sub

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me
    End Function

    Private m_valueWhenTrue As Visibility = Visibility.Visible
    Public Property ValueWhenTrue() As Visibility
        Get
            Return m_valueWhenTrue
        End Get
        Set(value As Visibility)
            m_valueWhenTrue = value
        End Set
    End Property

    Private m_valueWhenFalse As Visibility = Visibility.Collapsed
    Public Property ValueWhenFalse() As Visibility
        Get
            Return m_valueWhenFalse
        End Get
        Set(value As Visibility)
            m_valueWhenFalse = value
        End Set
    End Property

    Private m_valueWhenNull As Visibility = Visibility.Hidden
    Public Property ValueWhenNull() As Visibility
        Get
            Return m_valueWhenNull
        End Get
        Set(value As Visibility)
            m_valueWhenNull = value
        End Set
    End Property

    Private Function GetVisibility(value As Object) As Object
        If Not (TypeOf value Is Boolean) OrElse value Is Nothing Then
            Return ValueWhenNull
        End If

        If CBool(value) Then
            Return m_valueWhenTrue
        End If

        Return m_valueWhenFalse
    End Function

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Return GetVisibility(value)
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
