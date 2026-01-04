using Microsoft.Extensions.Logging;
using RandomRestaurantQuizz.Data;
using RandomRestaurantQuizz.Photos;

namespace RandomRestaurantQuizz.Places;

public class TestSearchAndPhotosRunner : IRunner
{
    private readonly IPlaceFinder _placeFinder;
    private readonly PhotoFileManager _photoManager;
    private readonly ILogger<TestSearchAndPhotosRunner> _logger;

    public TestSearchAndPhotosRunner(IPlaceFinder placeFinder, PhotoFileManager photoManager, ILogger<TestSearchAndPhotosRunner> logger)
    {
        _placeFinder = placeFinder;
        _photoManager = photoManager;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        Cities.Data.TryGetValue("Dijon", out var city);

        foreach (var restaurant in await _placeFinder.GetRestaurants(city))
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
