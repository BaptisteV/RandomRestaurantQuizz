using RandomRestaurantQuizz.Core.Quizzz;

namespace RandomRestaurantQuizz.App;

public partial class RecapModal : ContentPage
{
    public RecapModal(QuizzModel quizzModel)
    {
        InitializeComponent();
        InitUI(quizzModel);
    }

    private void InitUI(QuizzModel quizzModel)
    {
        ScoreLabel.Text = $"Score: {quizzModel.Player.TotalScore()}";

        var orderedScores = quizzModel.PersonalBests
            .OrderByDescending(s => s.Value)
            .ThenByDescending(s => s.Timestamp)
            .ToList();

        PbGrid.BatchBegin();
        for (var row = 0; row < orderedScores.Count; row++)
        {
            var pb = orderedScores[row];
            var lblTime = new Label()
            {
                Text = pb.Timestamp.ToString("G") + ":" + pb.Timestamp.ToString("ss"),
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
        await Navigation.PopModalAsync();
    }
}