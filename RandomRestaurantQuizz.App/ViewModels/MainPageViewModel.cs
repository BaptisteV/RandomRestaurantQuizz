using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RandomRestaurantQuizz.App.Resources.Strings;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace RandomRestaurantQuizz.App.ViewModels;

public class VmUpdater(MainPageViewModel vm)
{
    public void UpdateScore(ScoreChangedEvent scoreChangedEvent)
    {
        vm.Score = scoreChangedEvent.TotalScore;
        vm.ScoreDiff = scoreChangedEvent.ScoreDiff;
    }

    public void UpdatePhoto(PhotoChangedEvent photoChangedEvent)
    {
        vm.ImageSource = photoChangedEvent.Source;
    }

    public void UpdateSearchLocation(SearchLocation searchLocation)
    {
        vm.SearchLocation = new VmSearchLocation
        {
            Latitude = searchLocation.Geoloc.Latitude,
            Longitude = searchLocation.Geoloc.Longitude,
            Name = searchLocation.Name,
        };
    }

    public void UpdateRating(double x, double width)
    {
        var horizontalRatio = (float)((x - 8.0) / width); // From 0.0 to 1.0
        vm.RatingInput = Math.Clamp(Math.Round(horizontalRatio * 5.0, 2), 0.0, 5.0);
        vm.RatingInputText = $"{vm.RatingInput:F2}";
    }

    public void UpdateRestaurant(RestaurantChangedEvent restaurant)
    {
        vm.Round.RestaurantName = restaurant.Round.RestaurantName;
        vm.SearchLocation.Name = restaurant.Round.LocationName;
        vm.Round.Progress = restaurant.Round.Progress;

        UpdatePhoto(restaurant.PhotoChangedEvent);
        vm.Reviews = [.. restaurant.Reviews.ConvertAll(VmReview.FromCoreReview)];
    }
}

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial VmSearchLocation SearchLocation { get; set; } = new();
    [ObservableProperty]
    public partial VmRound Round { get; set; } = new();
    [ObservableProperty]
    public partial string Score { get; set; } = $"{0.0:F2}";
    [ObservableProperty]
    public partial string ScoreDiff { get; set; } = $" +{0.0:F2} ({0.0:F2})";
    [ObservableProperty]
    public partial ImageSource? ImageSource { get; set; }
    [ObservableProperty]
    public partial double RatingInput { get; set; } = 2.5;
    [ObservableProperty]
    public partial string RatingInputText { get; set; } = $"{2.5:F2}";

    [ObservableProperty]
    public partial ObservableCollection<VmReview> Reviews { get; set; } = new();

    public ICommand ToggleReviewCommand => new RelayCommand<VmReview>(review =>
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

    private static string TruncateSingleLine(string text)
    {
        var noBreak = text.Replace('\n', ' ');
        if (noBreak.Length > ReviewLabelLength)
        {
            var chars = string.Concat(noBreak.AsSpan(0, ReviewLabelLength - AppText.More.Length), AppText.More);

            return chars;
        }
        return text;
    }

    public static VmReview FromCoreReview(Review review)
    {
        var truncatedText = TruncateSingleLine(review.Text.Text);
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