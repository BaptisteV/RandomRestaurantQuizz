using Microsoft.Extensions.Logging;

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

    public async Task RunAsync()
    {
        var restaurants = (await _placesClient.GetRestaurantsInDijonAsync()).ToList();
        if (restaurants.Count == 0)
        {
            _logger.LogWarning("No restaurants found in Dijon.");
            return;
        }

        var restaurantsWithFirstPhoto = await _photoManager.GetAllImages(restaurants, _cts.Token);
        var without = restaurantsWithFirstPhoto.Count(r => r.FirstImage == null || r.FirstImage.Length == 0);
        _logger.LogInformation("{WithCount} with photos, {WithoutCount} without", restaurants.Count - without, without);

        foreach (var restaurant in restaurantsWithFirstPhoto)
        {
            _logger.LogInformation("====================================");
            _logger.LogInformation("Name: {Name}", restaurant.DisplayName?.Text ?? "N/A");
            _logger.LogInformation("Rating: {Rating} ⭐", restaurant.Rating?.ToString("0.0") ?? "N/A");
            _logger.LogInformation("Reviews: {Reviews}", restaurant.UserRatingCount?.ToString() ?? "N/A");
            _logger.LogInformation("Address: {Address}", restaurant.FormattedAddress ?? "N/A");
            _logger.LogInformation("PhotoCount: {PhotoCount}", restaurant.Photos?.Count ?? 0);
            await _photoManager.DisplayFirstImage(restaurant);
            Console.ReadLine();
        }

    }

    public void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }
}
