namespace RandomRestaurantQuizz.App.Pages.MainPage;

public class VmUpdater(MainPageViewModel vm)
{
    public void UpdateScore(ScoreChangedEvent scoreChangedEvent)
    {
        vm.Score = scoreChangedEvent.TotalScore;
        vm.ScoreDiff = scoreChangedEvent.ScoreDiff;
    }

    public void UpdatePhoto(PhotoChangedEvent photoChangedEvent)
    {
        vm.ImageSource = photoChangedEvent.Source;
    }

    public void UpdateSearchLocation(SearchLocation searchLocation)
    {
        vm.SearchLocation = new VmSearchLocation
        {
            Latitude = searchLocation.Geoloc.Latitude,
            Longitude = searchLocation.Geoloc.Longitude,
            Name = searchLocation.Name,
        };
    }

    public void UpdateRating(double x, double width)
    {
        var horizontalRatio = (float)((x - 8.0) / width); // From 0.0 to 1.0
        vm.RatingInput = Math.Clamp(Math.Round(horizontalRatio * 5.0, 2), 0.0, 5.0);
        vm.RatingInputText = $"{vm.RatingInput:F2}";
    }

    public void UpdateRestaurant(RestaurantChangedEvent restaurant)
    {
        vm.Round.RestaurantName = restaurant.Round.RestaurantName;
        vm.SearchLocation.Name = restaurant.Round.LocationName;
        vm.Round.Progress = restaurant.Round.Progress;

        UpdatePhoto(restaurant.PhotoChangedEvent);
        vm.Reviews = [.. restaurant.Reviews.ConvertAll(VmReview.FromCoreReview)];
    }
}
