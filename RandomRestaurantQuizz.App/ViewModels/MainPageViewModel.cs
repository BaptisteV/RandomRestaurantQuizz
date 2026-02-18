using CommunityToolkit.Mvvm.ComponentModel;
using RandomRestaurantQuizz.App.Resources.Strings;
using RandomRestaurantQuizz.Core.Places.GoogleApi;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial VmSearchLocation SearchLocation { get; set; }
    [ObservableProperty]
    public partial VmRound Round { get; set; } = new();
    [ObservableProperty]
    public partial string Score { get; set; }
    [ObservableProperty]
    public partial string ScoreDiff { get; set; }
    [ObservableProperty]
    public partial ImageSource ImageSource { get; set; }
    [ObservableProperty]
    public partial double RatingInput { get; set; } = 2.5;
    [ObservableProperty]
    public partial string RatingInputText { get; set; } = $"{2.5:F2}";

    [ObservableProperty]
    public partial ObservableCollection<VmReview> Reviews { get; set; } = new();

    public ICommand ToggleReviewCommand => new Command<VmReview>(review =>
    {
        if (review == null) return;
        foreach (var r in Reviews)
        {
            r.IsExpanded = (r == review) && !r.IsExpanded;
        }
        review.Text = review.IsExpanded ? review.FullText : review.TruncatedText;
    });
}

public partial class VmSearchLocation : ObservableObject
{
    [ObservableProperty]
    public partial string Name { get; set; } = "";
    [ObservableProperty]
    public partial double Latitude { get; set; }
    [ObservableProperty]
    public partial double Longitude { get; set; }
}

public partial class VmRound : ObservableObject
{
    [ObservableProperty]
    public partial string RestaurantName { get; set; } = "";
    [ObservableProperty]
    public partial string Progress { get; set; } = "";
}

public partial class VmReview : ObservableObject
{
    [ObservableProperty]
    public partial string AuthorName { get; set; }
    [ObservableProperty]
    public partial double Rating { get; set; }
    [ObservableProperty]
    public partial string FullText { get; set; }
    [ObservableProperty]
    public partial string TruncatedText { get; set; }
    [ObservableProperty]
    public partial string Text { get; set; }
    [ObservableProperty]
    public partial string RelativePublishTimeDescription { get; set; }
    [ObservableProperty]
    public partial bool IsExpanded { get; set; } = false;

    public static int ReviewLabelLength { get; set; } = 180;

    private static string AddReadMoreIfNeeded(string text)
    {
        var noBreak = text.Replace('\n', ' ');
        if (noBreak.Length > ReviewLabelLength)
        {
            var chars = noBreak.Substring(0, ReviewLabelLength - AppText.More.Length) + AppText.More;

            return chars;
        }
        return text;
    }

    public static VmReview FromCoreReview(Review review)
    {
        var truncatedText = AddReadMoreIfNeeded(review.Text.Text);
        return new VmReview
        {
            AuthorName = review.AuthorAttribution.DisplayName,
            Rating = review.Rating,
            FullText = review.Text.Text,
            Text = truncatedText,
            TruncatedText = truncatedText,
            RelativePublishTimeDescription = review.RelativePublishTimeDescription,
        };
    }
}

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

public class TextToTruncatedTextConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var text = (string)value!;
        return AddReadMoreIfNeeded(text);
    }

    private static object AddReadMoreIfNeeded(string text)
    {
        const int maxLineLength = 52;
        const string readMore = "...Read more";
        if (text.Length > maxLineLength)
        {
            return text.Substring(0, maxLineLength - readMore.Length) + readMore;
        }
        return text;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
}