using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Data;
using RandomRestaurantQuizz.Models;
using RandomRestaurantQuizz.Places;

namespace RandomRestaurantQuizz;

public sealed class PlaceFinder : IDisposable
{
    private readonly GooglePlacesClient _placesClient;
    private readonly ILogger<PlaceFinder> _logger;
    private readonly PhotoManager _photoManager;
    private readonly CancellationTokenSource _cts;

    public PlaceFinder(GooglePlacesClient placesClient, PhotoManager photoManager, ILogger<PlaceFinder> logger)
    {
        _placesClient = placesClient;
        _logger = logger;
        _photoManager = photoManager;
        _cts = new CancellationTokenSource();
    }

    private async Task<IReadOnlyList<PlaceResult>> GetRestaurants(GeoLoc center)
    {
        // Get all possible restaurants
        var restaurants = (await _placesClient.GetRestaurantsInCity(center, 1000, _cts.Token)).Where(r => r.Photos?.Count > 0).ToList();

        // Enrich with photos
        var restaurantsWithFirstPhoto = await _photoManager.GetPhotos(restaurants, _cts.Token);

        // Filter only those with at least one photo and more than 1 user rating
        var selectedRestaurants = restaurantsWithFirstPhoto.Where(r => r.UserRatingCount > 0).ToList().AsReadOnly();
        _logger.LogInformation("Selected {SelectedRestaurantCount} out of {RestaurantCount}", selectedRestaurants.Count, restaurants.Count);

        return selectedRestaurants;
    }

    public async Task RunAsync()
    {
        Cities.Data.TryGetValue("Dijon", out var city);

        foreach (var restaurant in await GetRestaurants(city))
        {
            _logger.LogInformation("====================================");
            _logger.LogInformation("Name: {Name}", restaurant.DisplayName?.Text);
            _logger.LogInformation("Rating: {Rating}⭐ ({UserRatingCount})", restaurant.Rating?.ToString("0.0"), restaurant.UserRatingCount);
            _logger.LogInformation("Address: {Address}", restaurant.FormattedAddress);
            _logger.LogInformation("PhotoCount: {PhotoCount}", restaurant.Photos?.Count ?? 0);
            await _photoManager.SaveTempJpgs(restaurant);
        }
        _photoManager.OpenTempFolder();
    }

    public void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }
}
