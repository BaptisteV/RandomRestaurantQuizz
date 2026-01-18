using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Photos;

namespace RandomRestaurantQuizz.Core.Places;

public sealed class PlaceFinder : IPlaceFinder, IDisposable
{
    private readonly IGooglePlacesClient _placesClient;
    private readonly ILogger<PlaceFinder> _logger;
    private readonly PhotoDownloader _photoDownloader;
    private readonly CancellationTokenSource _cts;

    public PlaceFinder(IGooglePlacesClient placesClient, PhotoDownloader photoDownloader, ILogger<PlaceFinder> logger)
    {
        _placesClient = placesClient;
        _photoDownloader = photoDownloader;
        _logger = logger;
        _cts = new CancellationTokenSource();
    }

    public async Task<IReadOnlyList<PlaceResult>> GetRestaurants(GeoLoc center)
    {
        // Get all possible restaurants
        var restaurants = (await _placesClient.GetRestaurantsInCity(center, 1000, _cts.Token)).Where(r => r.Photos?.Count > 0).ToList();

        // Enrich with photos
        var restaurantsWithFirstPhoto = await _photoDownloader.GetPhotos(restaurants, _cts.Token);

        // Filter only those with at least one photo and more than 1 user rating
        var selectedRestaurants = restaurantsWithFirstPhoto.Where(r => r.UserRatingCount > 0).ToList().AsReadOnly();
        _logger.LogInformation("Selected {SelectedRestaurantCount} out of {RestaurantCount}", selectedRestaurants.Count, restaurants.Count);

        return selectedRestaurants;
    }

    public void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }
}
