using CommunityToolkit.Mvvm.ComponentModel;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Quizzz;
using RandomRestaurantQuizz.Core.Quizzz.Scores;

namespace RandomRestaurantQuizz.App.ViewModels;

public partial class MainPageViewModel : ObservableObject, IQuizzViewModel
{
    [ObservableProperty]
    public partial int Score { get; set; }

    [ObservableProperty]
    public partial int ScoreDiff { get; set; }

    [ObservableProperty]
    public partial string LocationName { get; set; }

    [ObservableProperty]
    public partial byte[] ImageData { get; set; }

    [ObservableProperty]
    public partial bool IsLoading { get; set; }

    [ObservableProperty]
    public partial int SliderValue { get; set; }

    public byte[] Image => CurrentPlace.Photos[_currentPhotoIndex].DownloadedImage ?? [];

    public Player Player { get; private set; } = new();

    public PlaceResult CurrentPlace { get; private set; } = new();

    public Guess? LastGuess { get; private set; }

    public List<Score> PersonalBests { get; set; } = [];

    public MainPageViewModel NextRestaurant(PlaceResult newRestaurant, Guess? lastGuess)
    {
        CurrentPlace = newRestaurant;
        LastGuess = lastGuess;
        _currentPhotoIndex = 0;
        return this;
    }

    private int _currentPhotoIndex = 0;

    public MainPageViewModel NextPhoto()
    {
        var maxIndex = CurrentPlace.Photos.Count - 1;
        var nextIndex = Math.Min(_currentPhotoIndex + 1, maxIndex);
        _currentPhotoIndex = nextIndex;

        return this;
    }

    public MainPageViewModel PreviousPhoto()
    {
        var prevIndex = Math.Max(0, _currentPhotoIndex - 1);
        _currentPhotoIndex = prevIndex;

        return this;
    }

    public override string ToString()
    {
        return $"CurrentPlace={CurrentPlace.DisplayName.Text}, TotalScore {Player.TotalScore()}";
    }
}
