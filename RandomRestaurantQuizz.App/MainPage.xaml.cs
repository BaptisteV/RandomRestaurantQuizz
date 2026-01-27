using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> _logger;
    private readonly ISoundEffect _soundEffects;
    private readonly IQuizzGame _quizzGame;

    public MainPage(IQuizzGame quizz, ILogger<MainPage> logger, ISoundEffect soundEffects)
    {
        _quizzGame = quizz;
        _logger = logger;
        _soundEffects = soundEffects;

        InitializeComponent();

        _quizzGame.ScoreChanged = OnScoreChanged;
        _quizzGame.PhotoChanged = OnPhotoChanged;
        _quizzGame.RoundFinished = OnRoundFinished;
    }

    private async Task OnScoreChanged(QuizzModel model)
    {
        ScoreLabel.Text = $"Score: {model.Player.TotalScore()}";
        RestaurantNameLabel.Text = $"{model.CurrentPlace.DisplayName.Text} ({model.CurrentPlace.UserRatingCount} 👤)";

        ScoreDiffLabel.Opacity = 0.0;
        if (model.LastGuess is null)
            return;

        var roundScore = model.LastGuess.RoundScore();

        AnimateScoreDiff(roundScore);

        await _soundEffects.PlayAnswer(correctnessPercentage: roundScore, CancellationToken.None);
    }

    private Task OnPhotoChanged(QuizzModel model)
    {
        _logger.LogDebug("Photo changed");
        RestaurantPhotoImage.Source = ImageSource.FromStream(() => new MemoryStream(model.Image));
        return Task.CompletedTask;
    }

    private async Task OnRoundFinished(QuizzModel model)
    {
        _logger.LogDebug("Round finished");
        //await Navigation.PushModalAsync(new RecapModal(model));
        await Navigation.PushModalAsync(new SpinnerModal(), true);
        await _quizzGame.InitRound(CancellationToken.None);
        await Navigation.PopModalAsync(true);
    }

    private void AnimateScoreDiff(double roundScore)
    {
        ScoreDiffLabel.TextColor = roundScore >= 50.0 ? Colors.Green : Colors.Red;
        ScoreDiffLabel.Text = $"+{roundScore} ({roundScore:n1})";
        _ = Task.Run(async () =>
        {
            await ScoreDiffLabel.FadeToAsync(100, 500, Easing.CubicIn);
            await Task.Delay(500);
            await ScoreDiffLabel.FadeToAsync(0, 1000, Easing.CubicOut);
        });
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        await _soundEffects.Init();
        await Navigation.PushModalAsync(new SpinnerModal(), true);
        await _quizzGame.InitRound(CancellationToken.None);
        await Navigation.PopModalAsync(true);
        AnswerBtn.IsEnabled = true;
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var x = e.GetPosition(PhotoContainer)!.Value.X;
        var width = PhotoContainer.Width;
        var xPercent = 100.0 * x / width;

        // Tap sides to change photo
        if (xPercent <= 25)
        {
            await _quizzGame.PreviousPhoto();
        }
        else if (xPercent >= 75)
        {
            await _quizzGame.NextPhoto();
        }
    }

    private void RatingSlider_ValueChanged(object sender, ValueChangedEventArgs slideEvent)
    {
        RatingLabel.Text = $"{slideEvent.NewValue:F1}";
        Stars.Rating = slideEvent.NewValue;
    }

    private void AnswerBtn_Clicked(object sender, EventArgs e)
    {
        _quizzGame.Answer(RatingSlider.Value);
    }
}
