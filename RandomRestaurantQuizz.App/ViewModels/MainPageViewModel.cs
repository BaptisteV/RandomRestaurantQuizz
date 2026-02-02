using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial string LocationName { get; set; }
    [ObservableProperty]
    public partial int Score { get; set; }
    [ObservableProperty]
    public partial string ScoreDiff { get; set; }
    [ObservableProperty]
    public partial string RestaurantName { get; set; }
    [ObservableProperty]
    public partial ImageSource ImageSource { get; set; }
    [ObservableProperty]
    public partial ObservableCollection<VmReview> Reviews { get; set; } = new();

    public ICommand ToggleReviewCommand => new Command<VmReview>(review =>
    {
        if (review == null) return;
        review.IsExpanded = !review.IsExpanded;
    });
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

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is true ? ExpandedLines : CollapsedLines;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotSupportedException();
}