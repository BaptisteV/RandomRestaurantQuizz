namespace RandomRestaurantQuizz.App.Pages.MainPage;

public class RatingToColorConverter : IValueConverter
{
    public Color BaseColor { get; set; } = Colors.Gold;

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var rating = (double?)value ?? 0.0;
        var ratio = (float)(rating / 5.0);
        return BaseColor.WithAlpha(ratio * 0.5f + 0.33f);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotImplementedException();
}
