Public MustInherit Class abstractConverter
    Inherits Markup.MarkupExtension

    Public Overrides Function ProvideValue(serviceProvider As IServiceProvider) As Object
        Return Me

    End Function
End Class
