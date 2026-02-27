using CommunityToolkit.Mvvm.ComponentModel;
using RandomRestaurantQuizz.App.Resources.Strings;

namespace RandomRestaurantQuizz.App.Pages.MainPage;

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
