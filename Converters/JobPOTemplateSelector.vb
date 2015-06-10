Public Class JobPOTemplateSelector
    Inherits DataTemplateSelector

    Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate

        Dim element As FrameworkElement
        element = TryCast(container, FrameworkElement)

        If element IsNot Nothing AndAlso item IsNot Nothing AndAlso TypeOf item Is tPOHeader Then

            ' Dim po As tPOHeader = TryCast(item, po)
            Return TryCast(Application.Current.Resources("potemplate"), DataTemplate)
        Else
            Return TryCast(Application.Current.Resources("jobtemplate"), DataTemplate)
        End If

        Return Nothing
    End Function

    '    public class TerrainSelector : DataTemplateSelector
    '{
    '  public override DataTemplate SelectTemplate(object item, DependencyObject container)
    '  {
    '    var square = item as Square;
    '    if (square == null) 
    '       return null;
    '    if (square.Terrain is Dirt)
    '    {
    '      return Application.Resources["DirtTemplate"] as DataTemplate;
    '    }
    '    if (square.Terrain is Steel)
    '    {
    '      return Application.Resources["SteelTemplate"] as DataTemplate;
    '    }
    '    return null;
    '  }
    '}

End Class
