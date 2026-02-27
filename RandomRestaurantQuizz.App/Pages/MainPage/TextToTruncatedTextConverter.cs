namespace RandomRestaurantQuizz.App.Pages.MainPage;

public class TextToTruncatedTextConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var text = (string)value!;
        return AddReadMoreIfNeeded(text);
    }

    private static string AddReadMoreIfNeeded(string text)
    {
        const int maxLineLength = 52;
        const string readMore = "...Read more";
        if (text.Length > maxLineLength)
        {
            return string.Concat(text.AsSpan(0, maxLineLength - readMore.Length), readMore);
        }
        return text;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
}
