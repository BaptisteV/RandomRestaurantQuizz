using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.App.ViewModels;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage
{
    private readonly IQuizzViewModel _vm;

    private readonly ILogger<MainPage> _logger;
    private readonly ISoundEffect _soundEffects;
    private readonly IQuizzGame _quizzGame;

    private readonly GeoLocPickerPage _geoPage;

    public MainPage(IQuizzGame quizz, ILogger<MainPage> logger, ISoundEffect soundEffects, IQuizzViewModel vm, GeoLocPickerPage geoPage)
    {
        _vm = vm;
        BindingContext = _vm;
        _quizzGame = quizz;
        _logger = logger;
        _soundEffects = soundEffects;
        _geoPage = geoPage;

        InitializeComponent();

        _geoPage.NewLocation = OnNewLocation;

        //_quizzGame.PhotoChanged = OnPhotoChanged;
        _quizzGame.RoundFinished = OnRoundFinished;
        _quizzGame.ScoreChanged = OnScoreChangedE;
        _quizzGame.PhotoChanged = OnPhotoChanged;

        _ = Task.Run(() => Navigation.PushAsync(_geoPage, true));
    }

    private async Task OnScoreChangedE(ScoreChangedEvent scoreChangedEvent)
    {
        _vm.Score = scoreChangedEvent.TotalScore;
        _vm.LocationName = scoreChangedEvent.LocationLabel;
        _vm.ScoreDiff = scoreChangedEvent.ScoreDiff;

        AnimateScoreDiff(scoreChangedEvent.RoundScore);

        await _soundEffects.PlayAnswer(correctnessPercentage: scoreChangedEvent.RoundScore, CancellationToken.None);
    }

    private Task OnPhotoChanged(PhotoChangedEvent photoChangedEvent)
    {
        _logger.LogDebug("Photo changed");
        _vm.ImageSource = photoChangedEvent.Source;
        return Task.CompletedTask;
    }

    private async Task OnRoundFinished(RoundFinishedEvent roundFinishedEvent)
    {
        _logger.LogDebug("Round finished");
        var recapVm = new RecapViewModel(roundFinishedEvent.TotalScore, roundFinishedEvent.PersonalBests);
        await Navigation.PushModalAsync(new RecapModal(recapVm), true);
        await Navigation.PopModalAsync(true);
        await Navigation.PushModalAsync(_geoPage, true);
        await Navigation.PushModalAsync(new SpinnerModal(), true);
        await _quizzGame.InitRound(_geoPage.CurrentLocation, CancellationToken.None);
        await Navigation.PopModalAsync(true);
    }

    private void AnimateScoreDiff(double roundScore)
    {
        ScoreDiffLabel.Opacity = 0.0;
        ScoreDiffLabel.TextColor = roundScore >= 50.0 ? Colors.Green : Colors.Red;
        _ = Task.Run(async () =>
        {
            await ScoreDiffLabel.FadeToAsync(100, 500, Easing.CubicIn);
            await Task.Delay(2000);
            await ScoreDiffLabel.FadeToAsync(0, 2000, Easing.CubicOut);
        });
    }

    private Task OnNewLocation(string name, GeoLoc geoloc)
    {
        _logger.LogInformation("New location picked: {Location}", name);
        _quizzGame.SetSearchLocation(geoloc, Cities.DefaultRadius);
        return Task.CompletedTask;
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        await _soundEffects.Init();
        await Navigation.PushModalAsync(new SpinnerModal(), true);
        await _quizzGame.InitRound(_geoPage.CurrentLocation, CancellationToken.None);
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
