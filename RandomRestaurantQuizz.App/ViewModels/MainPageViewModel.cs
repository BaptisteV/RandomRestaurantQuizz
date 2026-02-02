using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

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