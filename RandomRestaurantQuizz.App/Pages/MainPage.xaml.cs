using RandomRestaurantQuizz.App.Pages.MainPage;

namespace RandomRestaurantQuizz.App;

public partial class MainPage : ContentPage, IDisposable
{
    private readonly ILogger<MainPage> _logger;

    private readonly MainPageViewModel _vm;

    private readonly IQuizzGame _quizzGame;
    private readonly GeoLocPickerPage _geoPage;
    private readonly IGeolocationService _geoService;
    private readonly VmUpdater _vmUpdater;

    private readonly CancellationTokenSource _cts = new();

    public MainPage(
        IQuizzGame quizz,
        VmUpdater vmUpdater,
        MainPageViewModel vm,
        GeoLocPickerPage geoPage,
        IGeolocationService geoService,
        ILogger<MainPage> logger)
    {
        _vm = vm;
        _vmUpdater = vmUpdater;
        _quizzGame = quizz;
        _logger = logger;
        _geoPage = geoPage;
        _geoService = geoService;

        _quizzGame.RoundFinished = OnRoundsFinished;

        BindingContext = _vm;

        _ = Task.Run(async () =>
        {
            // Show GeoLocPickerPage on start
            await Navigation.PushAsync(_geoPage, false);
        });

        InitializeComponent();

        _quizzGame.SetTransitions(new MainPageTransitions(RestaurantImage, RestaurantNameLabel, ReviewsContainer, AnswerBtn));
    }

    private async void ContentPage_Loaded(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SpinnerModal(), false);

        await InitWithSpinner();

        await Navigation.PopModalAsync(true);
    }

    private async Task OnRoundsFinished(RoundsFinishedEvent roundFinishedEvent)
    {
        _logger.LogDebug("Rounds finished");
        var recapVm = new RecapViewModel(roundFinishedEvent.TotalScore, roundFinishedEvent.PersonalBests);
        await Navigation.PushAsync(_geoPage, true);
        await Navigation.PushModalAsync(new RecapModal(recapVm), true);
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
        _vmUpdater.UpdateRating(x, width);
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