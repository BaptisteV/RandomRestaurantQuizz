namespace RandomRestaurantQuizz.App.Pages.MainPage;

public class BoolToMaxLinesConverter : IValueConverter
{
    public int CollapsedLines { get; set; } = 1;
    public int ExpandedLines { get; set; } = 0; // 0 = unlimited

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is true ? ExpandedLines : CollapsedLines;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
}
