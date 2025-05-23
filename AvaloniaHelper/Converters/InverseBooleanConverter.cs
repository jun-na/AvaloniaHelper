﻿using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace AvaloniaHelper.Converters;

/// <summary>
/// boolの反転コンバータ
/// </summary>
public class InverseBooleanConverter : IValueConverter
{

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return !(bool)value;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return false;
    }
}
