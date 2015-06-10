Public Class TreeViewLineConverter
        Implements IValueConverter
        Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim item As TreeViewItem = DirectCast(value, TreeViewItem)
            Dim ic As ItemsControl = ItemsControl.ItemsControlFromItemContainer(item)
            Return ic.ItemContainerGenerator.IndexFromContainer(item) = ic.Items.Count - 1
        End Function

        Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return False
        End Function

    End Class
