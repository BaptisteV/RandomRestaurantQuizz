using RandomRestaurantQuizz.App.ViewModels;
using RandomRestaurantQuizz.Core.Quizzz.Scores;

namespace RandomRestaurantQuizz.App;

public partial class RecapModal : ContentPage
{
    public RecapModal(RecapViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
        FillScoresGrid(vm.Scores);
    }

    private void FillScoresGrid(List<Score> scores)
    {
        ScoresGrid.BatchBegin();
        for (var row = 0; row < scores.Count; row++)
        {
            var pb = scores[row];
            var lblTime = new Label()
            {
                Text = pb.Timestamp.ToString("G"),
                FontSize = 17, // Medium,
                HorizontalOptions = LayoutOptions.Center,
            };
            var lblScore = new Label()
            {
                Text = pb.Value.ToString(),
                FontSize = 17, // Medium,
                HorizontalOptions = LayoutOptions.Center,
            };

            ScoresGrid.Add(lblTime, 0, row);
            ScoresGrid.Add(lblScore, 1, row);
        }
        ScoresGrid.BatchCommit();
    }

    private async void CloseBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }
}