using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Models;

namespace RandomRestaurantQuizz;

public sealed class App : IDisposable
{
    private readonly GooglePlacesClient _placesClient;
    private readonly ILogger<App> _logger;
    private readonly PhotoManager _photoManager;
    private readonly CancellationTokenSource _cts;

    public App(GooglePlacesClient placesClient, PhotoManager photoManager, ILogger<App> logger)
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

        // Enrich with photos TODO fetch all photos
        var restaurantsWithFirstPhoto = await _photoManager.GetFirstImages(restaurants, _cts.Token);

        // Filter only those with at least one photo and more than 1 user rating
        var selectedRestaurants = restaurantsWithFirstPhoto.Where(r => r.FirstImage is not null && r.UserRatingCount > 0).ToList().AsReadOnly();
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
            await _photoManager.OpenFirstImage(restaurant);
            //Console.ReadLine();
        }
    }

    public void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }
}
