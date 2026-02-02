using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage, IDisposable
{
    private readonly ILogger<MainPage> _logger;

    private readonly MainPageViewModel _vm;

    private readonly ISoundEffect _soundEffects;
    private readonly IQuizzGame _quizzGame;
    private readonly GeoLocPickerPage _geoPage;
    private readonly CancellationTokenSource _cts = new();

    public MainPage(IQuizzGame quizz, ILogger<MainPage> logger, ISoundEffect soundEffects, MainPageViewModel vm, GeoLocPickerPage geoPage)
    {
        _vm = vm;
        BindingContext = _vm;
        _quizzGame = quizz;
        _logger = logger;
        _soundEffects = soundEffects;
        _geoPage = geoPage;

        InitializeComponent();

        _geoPage.SearchLocationChanged = OnSearchLocationChanged;

        _quizzGame.RestaurantChanged = OnRestaurantChanged;
        _quizzGame.RoundFinished = OnRoundFinished;
        _quizzGame.ScoreChanged = OnScoreChanged;
        _quizzGame.PhotoChanged = OnPhotoChanged;
        Navigation.PushAsync(_geoPage, true).Wait();
    }

    private async Task OnRestaurantChanged(RestaurantChangedEvent startedEvent)
    {
        _vm.Score = startedEvent.ScoreChangedEvent.TotalScore;
        _vm.RestaurantName = startedEvent.RestaurantName;
        _vm.ScoreDiff = startedEvent.ScoreChangedEvent.ScoreDiff;

        _vm.ImageSource = startedEvent.PhotoChangedEvent.Source;
        _vm.Reviews = [.. startedEvent.Reviews.Select(VmReview.FromCoreReview)];
        //return Task.CompletedTask;
    }

    private async Task OnScoreChanged(ScoreChangedEvent scoreChangedEvent)
    {
        _vm.Score = scoreChangedEvent.TotalScore;
        _vm.ScoreDiff = scoreChangedEvent.ScoreDiff;

        AnimateScoreDiff(scoreChangedEvent.RoundScore);
        await _soundEffects.PlayAnswer(correctnessPercentage: scoreChangedEvent.RoundScore, CancellationToken.None);
    }

    private void AnimateScoreDiff(double roundScore)
    {
        ScoreDiffLabel.Opacity = 100.0;
        ScoreDiffLabel.TextColor = roundScore >= 50.0 ? Colors.Green : Colors.Red;
        _ = Task.Run(async () =>
        {
            try
            {
                await ScoreDiffLabel.FadeToAsync(100, 1000, Easing.CubicIn);
                await Task.Delay(2000, _cts.Token);
                await ScoreDiffLabel.FadeToAsync(0, 1000, Easing.CubicOut);
            }
            catch (TaskCanceledException) { ScoreDiffLabel.CancelAnimations(); }
        });
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
        await Navigation.PushAsync(_geoPage, true);
        await Navigation.PushModalAsync(new RecapModal(recapVm), true);
        await InitWithSpinner();
    }

    private async Task OnSearchLocationChanged(string name, GeoLoc geoloc)
    {
        _logger.LogInformation("New location picked: {Location}", name);
        _vm.LocationName = name;
        _quizzGame.SetSearchLocation(geoloc, Cities.DefaultRadius);
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        _cts.TryReset();
        await _soundEffects.Init();
        await InitWithSpinner();

        AnswerBtn.IsEnabled = true;
    }

    private async Task InitWithSpinner()
    {
        await Navigation.PushModalAsync(new SpinnerModal(), true);
        await _quizzGame.InitRound(_geoPage.CurrentLocation, CancellationToken.None);
        await Navigation.PopModalAsync(true);
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

    private void ContentPage_Unloaded(object sender, EventArgs e)
    {
        _cts.Cancel();
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        _cts.Dispose();
    }
}
