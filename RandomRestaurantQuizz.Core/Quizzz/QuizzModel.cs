using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Quizzz.Scores;

namespace RandomRestaurantQuizz.Core.Quizzz;

public class QuizzModel
{
    public byte[] Image => CurrentPlace.Photos[_currentPhotoIndex].DownloadedImage ?? [];

    public Player Player { get; private set; } = new();

    public PlaceResult CurrentPlace { get; private set; } = new();

    public Guess? LastGuess { get; private set; }

    public List<Score> PersonalBests { get; set; } = [];

    public QuizzModel NextRestaurant(PlaceResult newRestaurant, Guess? lastGuess)
    {
        CurrentPlace = newRestaurant;
        LastGuess = lastGuess;
        _currentPhotoIndex = 0;
        return this;
    }

    private int _currentPhotoIndex = 0;

    public QuizzModel NextPhoto()
    {
        var maxIndex = CurrentPlace.Photos.Count - 1;
        var nextIndex = Math.Min(_currentPhotoIndex + 1, maxIndex);
        _currentPhotoIndex = nextIndex;

        return this;
    }

    public QuizzModel PreviousPhoto()
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

public static class QuizzModelExtensions
{
    extension(QuizzModel model)
    {
        public IEnumerable<Score> SortBest()
        {
            return model.PersonalBests
                .OrderByDescending(s => s.Value)
                .ThenByDescending(s => s.Timestamp);
        }
    }
}