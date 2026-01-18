using RandomRestaurantQuizz.Core.Data;
using RandomRestaurantQuizz.Core.Models;
using RandomRestaurantQuizz.Core.Photos;
using System.Text.Json;

namespace RandomRestaurantQuizz.Core.Places;

public class GooglePlacesStaticClient(HttpClient _, IPhotoDownloader photoDownloader) : IGooglePlacesClient
{
    public async Task<List<PlaceResult>> GetRestaurants(GeoLoc center, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Deserialize<PlacesApiResponse>(TestData.JsonDij, new JsonSerializerOptions(JsonSerializerDefaults.Web))?.Places ?? [];
        var withPhotos = await photoDownloader.GetPhotos(json, cancellationToken);
        return withPhotos;
    }
}
