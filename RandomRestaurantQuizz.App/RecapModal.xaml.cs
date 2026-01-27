using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.App;

public partial class RecapModal : ContentPage
{
    private const int MaxScoreCount = 10;

    public RecapModal(QuizzModel quizzModel)
    {
        InitializeComponent();
        InitUI(quizzModel);
    }

    private void InitUI(QuizzModel quizzModel)
    {
        ScoreLabel.Text = $"Score: {quizzModel.Player.TotalScore()}";

        var orderedScores = quizzModel
            .SortBest()
            .Take(MaxScoreCount)
            .ToList();

        PbGrid.BatchBegin();
        for (var row = 0; row < orderedScores.Count; row++)
        {
            var pb = orderedScores[row];
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

            PbGrid.Add(lblTime, 0, row);
            PbGrid.Add(lblScore, 1, row);
        }
        PbGrid.BatchCommit();
    }

    private async void CloseBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }
}