using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View;

/// <summary>
/// Реализует конвертер для отображения элемента в зависимости от булевого значения. 
/// Если значение true, элемент отображается, иначе скрывается.
/// </summary>
public class BooleanToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Преобразует логическое значение в значение Visibility:
    /// true -> Visibility.Visible, иначе -> Visibility.Collapsed.
    /// </summary>
    /// <param name="value">Входное значение; ожидается тип <see cref="bool"/>.</param>
    /// <param name="targetType">Тип назначения.</param>
    /// <param name="parameter">Параметр преобразования (не используется).</param>
    /// <param name="culture">Культура для преобразования (не используется).</param>
    /// <returns>Возвращает <see cref="System.Windows.Visibility.Visible"/>,
    /// если значение равно true; иначе <see cref="System.Windows.Visibility.Collapsed"/>.</returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value == true)
        {
            return Visibility.Visible;
        }

        return Visibility.Collapsed;
    }

    /// <summary>
    /// Обратное преобразование не реализовано — метод возвращает переданное значение без изменений.
    /// </summary>
    /// <param name="value">Входное значение для обратного преобразования.</param>
    /// <param name="targetType">Тип назначения для обратного преобразования.</param>
    /// <param name="parameter">Параметр преобразования (не используется).</param>
    /// <param name="culture">Культура для преобразования (не используется).</param>
    /// <returns>Возвращает исходное значение (не выполняется попытки конвертации в bool).</returns>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value;
    }
}
