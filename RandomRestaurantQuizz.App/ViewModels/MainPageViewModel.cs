using CommunityToolkit.Mvvm.ComponentModel;
using RandomRestaurantQuizz.Core.Places.Api;
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
        review.IsExpanded = !review.IsExpanded;
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
    public partial string Text { get; set; }
    [ObservableProperty]
    public partial string RelativePublishTimeDescription { get; set; }
    [ObservableProperty]
    public partial bool IsExpanded { get; set; } = false;

    public static VmReview FromCoreReview(Review review)
    {
        return new VmReview
        {
            AuthorName = review.AuthorAttribution.DisplayName,
            Rating = review.Rating,
            Text = review.Text.Text,
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