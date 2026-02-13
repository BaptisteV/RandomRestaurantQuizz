using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Console;

public partial class TestSearchAndPhotosRunner(IGooglePlacesClient restauClient, PhotoFileManager photoManager, ILogger<TestSearchAndPhotosRunner> logger) : IRunner
{
    private readonly IGooglePlacesClient _restauClient = restauClient;
    private readonly PhotoFileManager _photoManager = photoManager;
    private readonly ILogger<TestSearchAndPhotosRunner> _logger = logger;

    private const string CityName = "Dijon";

    public async Task RunAsync(CancellationToken cancellationToken)
    {
        var searchLocation = Locations.Cities.Single(l => l.Name == CityName);

        foreach (var restaurant in (await _restauClient.GetRestaurants(searchLocation, cancellationToken)).Places)
        {
            LogRestaurant(restaurant.DisplayName.Text, restaurant.Rating, restaurant.UserRatingCount, restaurant.FormattedAddress, restaurant.Photos.Count);
            await _photoManager.SaveTempJpgs(restaurant);
        }

        _photoManager.OpenTempFolder();
    }


    [LoggerMessage(Level = LogLevel.Information, Message =
        $$"""
        Name: {Name}
        Rating: {Rating}:0.0⭐ ({UserRatingCount})
        Address: {Address}
        PhotoCount: {PhotoCount}
        """)]
    private partial void LogRestaurant(string? name, double rating, int userRatingCount, string? address, int? photoCount);
}
