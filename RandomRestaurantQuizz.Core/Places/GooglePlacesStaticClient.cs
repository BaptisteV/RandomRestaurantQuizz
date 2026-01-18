using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public class GooglePlacesStaticClient(HttpClient _) : IGooglePlacesClient
{
    public Task<List<PlaceResult>> GetRestaurantsInCity(GeoLoc center, int radiusSize = 1000, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Deserialize<PlacesApiResponse>(TestData.JsonDij, new JsonSerializerOptions(JsonSerializerDefaults.Web));

        return Task.FromResult(json!.Places);
    }
}
