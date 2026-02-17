using RandomRestaurantQuizz.Core.Places.Api;

namespace RandomRestaurantQuizz.Core.Places;

public class GetRestaurantsResponse
{
    public required PlacesApiResponse ApiResponse { get; init; }
    public required SearchParams Searched { get; init; }
}
