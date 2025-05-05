using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace AvaloniaHelper.Converters;

public class RadioButtonConverter : IValueConverter
{
    // Enumからboolへの変換
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null || parameter == null)
        {
            return false;
        }
        return value.ToString() == parameter.ToString();
    }

    // boolからEnumへの変換
    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null || parameter == null) return 0;
        if ((bool)value && parameter != null)
        {
            var stringValue = parameter.ToString();
            if (stringValue == null)
            {
                throw new ArgumentException("文字列がまちがっています。");
            }
            return Enum.Parse(targetType, stringValue);
        }
        return 0;
    }
}
