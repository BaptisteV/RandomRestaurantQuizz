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

        _ = Task.Run(async () => Navigation.PushAsync(_geoPage, true));
    }

    private Task OnRestaurantChanged(RestaurantChangedEvent startedEvent)
    {
        _vm.Score = startedEvent.ScoreChangedEvent.TotalScore;
        _vm.RestaurantName = startedEvent.RestaurantName;
        _vm.ScoreDiff = startedEvent.ScoreChangedEvent.ScoreDiff;

        _vm.ImageSource = startedEvent.PhotoChangedEvent.Source;
        _vm.Reviews = [.. startedEvent.Reviews.ConvertAll(VmReview.FromCoreReview)];

        return Task.CompletedTask;
    }

    private async Task OnScoreChanged(ScoreChangedEvent scoreChangedEvent)
    {
        _vm.Score = scoreChangedEvent.TotalScore;
        _vm.ScoreDiff = scoreChangedEvent.ScoreDiff;
        await Task.WhenAll(AnimateScoreDiff(scoreChangedEvent.RoundScore), _soundEffects.PlayAnswer(correctnessPercentage: scoreChangedEvent.RoundScore, CancellationToken.None));
    }

    private async Task AnimateScoreDiff(double roundScore)
    {
        try
        {
            ScoreDiffLabel.CancelAnimations();

            ScoreDiffLabel.TextColor = roundScore >= 50.0 ? Colors.Green : Colors.Red;
            ScoreDiffLabel.Opacity = 1.0;

            await ScoreDiffLabel.FadeToAsync(100, 1000, Easing.CubicIn);
            await Task.Delay(4000, _cts.Token);
            await ScoreDiffLabel.FadeToAsync(0, 1000, Easing.CubicOut);
        }
        catch (TaskCanceledException) { }
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

    private async void AnswerBtn_Clicked(object sender, EventArgs e)
    {
        await _quizzGame.Answer(_vm.RatingInput);
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

    private void RatingPbInput_Tapped(object sender, TappedEventArgs e)
    {
        var x = e.GetPosition(StarsContainer)!.Value.X;
        var width = StarsContainer.Width - 12 - 12;

        var horizontalRatio = (x - 8) / width; // From 0.0 to 1.0
        _vm.RatingInput = (double)new ProgressToStarInput().ConvertBack(horizontalRatio, typeof(double), null, CultureInfo.CurrentCulture);
        _vm.RatingInputText = $"{_vm.RatingInput:F2}";
    }
}
