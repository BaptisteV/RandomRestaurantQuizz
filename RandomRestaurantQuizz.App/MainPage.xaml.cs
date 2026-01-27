using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> _logger;
    private readonly ISoundEffect _soundEffects;
    private readonly IScoreSaver _scoreSaver;
    private readonly IQuizz _quizz;

    public MainPage(IQuizz quizz, ILogger<MainPage> logger, ISoundEffect soundEffects, IScoreSaver scoreSaver)
    {
        _quizz = quizz;
        _logger = logger;
        _soundEffects = soundEffects;
        _scoreSaver = scoreSaver;

        InitializeComponent();

        _quizz.ScoreChanged = async (model) =>
        {
            UpdateLabels(model);

            ScoreDiffLabel.Opacity = 0.0;
            if (model.LastScoreUpdate < 0)
                return;

            ScoreDiffLabel.TextColor = model.LastScoreUpdate >= 50.0 ? Colors.Green : Colors.Red;
            ScoreDiffLabel.Text = $"+{model.LastScoreUpdate} ({model.LastRating:n1})";
            _ = Task.Run(async () =>
            {
                await ScoreDiffLabel.FadeToAsync(100, 500, Easing.CubicIn);
                await Task.Delay(500);
                await ScoreDiffLabel.FadeToAsync(0, 1000, Easing.CubicOut);
            });

            await _soundEffects.PlayAnswer(correctnessPercentage: model.LastScoreUpdate, CancellationToken.None);
        };

        _quizz.PhotoChanged = async model =>
        {
            UpdatePhoto(model);
        };

        _quizz.RoundFinished = async model =>
        {
            _logger.LogDebug("Round finished");
            await _scoreSaver.SaveScore(model.TotalScore);
            await Navigation.PushModalAsync(new RecapModal(model));

            await _quizz.InitRound(CancellationToken.None);
        };
    }

    private void UpdateLabels(Core.Models.QuizzModel model)
    {
        ScoreLabel.Text = $"Score: {model.TotalScore}";
        RestaurantNameLabel.Text = $"{model.RestaurantName} ({model.RatingCount})";
    }

    private void UpdatePhoto(Core.Models.QuizzModel model)
    {
        _logger.LogDebug("Photo changed");
        RestaurantPhotoImage.Source = ImageSource.FromStream(() => new MemoryStream(model.Image));
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        await _soundEffects.Init();
        await _quizz.InitRound(CancellationToken.None);
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var x = e.GetPosition(PhotoContainer)!.Value.X;
        var width = PhotoContainer.Width;
        var xPercent = 100.0 * x / width;

        // Tap sides to change photo
        if (xPercent <= 25)
        {
            await _quizz.PreviousPhoto();
        }
        else if (xPercent >= 75)
        {
            await _quizz.NextPhoto();
        }
    }

    private void RatingSlider_ValueChanged(object sender, ValueChangedEventArgs slideEvent)
    {
        RatingLabel.Text = $"{slideEvent.NewValue:F1}";
        Stars.Rating = slideEvent.NewValue;
    }

    private void AnswerBtn_Clicked(object sender, EventArgs e)
    {
        _quizz.Answer(RatingSlider.Value);
    }
}
