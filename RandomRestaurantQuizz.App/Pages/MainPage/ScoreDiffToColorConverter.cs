using System.Text.RegularExpressions;

namespace RandomRestaurantQuizz.App.Pages.MainPage;

public partial class ScoreDiffToColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var val = (string)value!;
        var matches = ScoreDiffRegex.Match(val);
        if (matches.Success)
        {
            var d = double.Parse(matches.Groups[0].Value);
            return d >= 50.0 ? Colors.Green : Colors.Red;
        }
        return Colors.White;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    [GeneratedRegex(@"[+-]?\d+\.\d{2}")]
    private static partial Regex ScoreDiffRegex { get; }
}