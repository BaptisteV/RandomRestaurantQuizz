using RandomRestaurantQuizz.App.Pages.Transitions;
using RandomRestaurantQuizz.Core.SoundEffects;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage, IDisposable
{
    private readonly ILogger<MainPage> _logger;

    private readonly MainPageViewModel _vm;

    private readonly ISoundEffect _soundEffects;
    private readonly IQuizzGame _quizzGame;
    private readonly GeoLocPickerPage _geoPage;
    private readonly IGeolocationService _geoService;
    private readonly MainPageTransitions _transitions;

    private readonly CancellationTokenSource _cts = new();

    public MainPage(IQuizzGame quizz, ILogger<MainPage> logger, ISoundEffect soundEffects, MainPageViewModel vm, GeoLocPickerPage geoPage, IGeolocationService geoService)
    {
        _vm = vm;
        _quizzGame = quizz;
        _logger = logger;
        _soundEffects = soundEffects;
        _geoPage = geoPage;
        _geoService = geoService;

        _geoPage.SearchLocationChanged = OnSearchLocationChanged;

        _quizzGame.RestaurantChanged = OnRestaurantChanged;
        _quizzGame.RoundFinished = OnRoundFinished;
        _quizzGame.ScoreChanged = OnScoreChanged;
        _quizzGame.PhotoChanged = OnPhotoChanged;

        BindingContext = _vm;

        _ = Task.Run(async () =>
        {
            // Show GeoLocPickerPage on start
            await Navigation.PushAsync(_geoPage, false);
        });

        InitializeComponent();
        _transitions = new MainPageTransitions(RestaurantImage, RestaurantNameLabel, ReviewsContainer, AnswerBtn);
    }

    private async void ContentPage_Loaded(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SpinnerModal(), false);

        await _soundEffects.Init();
        await InitWithSpinner();

        AnswerBtn.IsEnabled = true;

        await Navigation.PopModalAsync(true);
    }

    private Task OnRestaurantChanged(RestaurantChangedEvent startedEvent)
    {
        _vm.Round.RestaurantName = startedEvent.Round.RestaurantName;
        _vm.SearchLocation.Name = startedEvent.Round.LocationName;
        _vm.Round.Progress = startedEvent.Round.Progress;

        _vm.ImageSource = startedEvent.PhotoChangedEvent.Source;
        _vm.Reviews = [.. startedEvent.Reviews.ConvertAll(VmReview.FromCoreReview)];

        return Task.CompletedTask;
    }

    private async Task OnScoreChanged(ScoreChangedEvent scoreChangedEvent)
    {
        _vm.Score = scoreChangedEvent.TotalScore;
        _vm.ScoreDiff = scoreChangedEvent.ScoreDiff;
        ColorScoreDiff(scoreChangedEvent.RoundScore);
        _ = Task.Run(() => _soundEffects.PlayAnswer(correctnessPercentage: scoreChangedEvent.RoundScore, _cts.Token));
    }

    private void ColorScoreDiff(double roundScore)
    {
        ScoreDiffLabel.TextColor = roundScore >= 50.0 ? Colors.Green : Colors.Red;
        ScoreDiffLabel.Opacity = 1.0;
    }

    private Task OnPhotoChanged(PhotoChangedEvent photoChangedEvent)
    {
        _logger.LogDebug("Photo changed");
        _transitions.AnimateRestaurantStart();
        _vm.ImageSource = photoChangedEvent.Source;
        return Task.CompletedTask;
    }

    private async Task OnRoundFinished(RoundsFinishedEvent roundFinishedEvent)
    {
        _logger.LogDebug("Round finished");
        var recapVm = new RecapViewModel(roundFinishedEvent.TotalScore, roundFinishedEvent.PersonalBests);
        await Navigation.PushAsync(_geoPage, true);
        await Navigation.PushModalAsync(new RecapModal(recapVm), true);
    }

    private async Task OnSearchLocationChanged(SearchLocation searchLocation)
    {
        _logger.LogInformation("New location picked: {SearchLocation}", searchLocation.Name);
        _vm.SearchLocation = new VmSearchLocation
        {
            Latitude = searchLocation.Geoloc.Latitude,
            Longitude = searchLocation.Geoloc.Longitude,
            Name = searchLocation.Name,
        };
    }

    private async Task InitWithSpinner()
    {
        var searchLocation = new SearchLocation()
        {
            Geoloc = new Geoloc()
            {
                Latitude = _vm.SearchLocation.Latitude,
                Longitude = _vm.SearchLocation.Longitude,
            },
            Name = _vm.SearchLocation.Name,
        };

        var userLocation = await _geoService.GetCurrentLocation();
        await _quizzGame.InitRound(new SearchParams()
        {
            Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName,
            Location = searchLocation,
        },
        userLocation,
        _cts.Token);
    }

    private async void TapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
    {
        var x = e.GetPosition(PhotoContainer)!.Value.X;
        var width = PhotoContainer.Width;
        var xPercent = 100.0 * x / width;

        // Tap sides to change photo
        if (xPercent < 50)
        {
            await _quizzGame.PreviousPhoto();
        }
        else if (xPercent >= 50)
        {
            await _quizzGame.NextPhoto();
        }
    }

    private async void AnswerBtn_Clicked(object? sender, EventArgs e)
    {
        _transitions.AnimateRestaurantEnd();
        await _quizzGame.Answer(_vm.RatingInput, _cts.Token);
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

    private void RatingPbInput_Tapped(object? sender, TappedEventArgs e)
    {
        var x = e.GetPosition(StarsContainer)!.Value.X;
        var width = StarsContainer.Width - 12 - 12;

        var horizontalRatio = (float)((x - 8.0) / width); // From 0.0 to 1.0
        _vm.RatingInput = Math.Clamp(Math.Round(horizontalRatio * 5.0, 2), 0.0, 5.0);
        _vm.RatingInputText = $"{_vm.RatingInput:F2}";
    }

    private void ReviewsContainer_SizeChanged(object? sender, EventArgs e)
    {
        VmReview.ReviewLabelLength = (int)(ReviewsContainer.Width / 8.2);
        foreach (var review in _vm.Reviews)
        {
            review.Text = review.IsExpanded ? review.FullText : review.TruncatedText;
        }
    }
}
