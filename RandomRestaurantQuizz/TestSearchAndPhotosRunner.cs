using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Photos;
using RandomRestaurantQuizz.Core.Places;

namespace RandomRestaurantQuizz.Console;

public class TestSearchAndPhotosRunner : IRunner
{
    private readonly IGooglePlacesClient _restauClient;
    private readonly PhotoFileManager _photoManager;
    private readonly ILogger<TestSearchAndPhotosRunner> _logger;

    public TestSearchAndPhotosRunner(IGooglePlacesClient restauClient, PhotoFileManager photoManager, ILogger<TestSearchAndPhotosRunner> logger)
    {
        _restauClient = restauClient;
        _photoManager = photoManager;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        Cities.Data.TryGetValue("Dijon", out var city);

        foreach (var restaurant in await _restauClient.GetRestaurants(city))
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
}
