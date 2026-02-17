using RandomRestaurantQuizz.Core.Places.GoogleApi;

namespace RandomRestaurantQuizz.Core.Places;

public class QuizzApiResult
{
    public required PlacesApiResponse ApiResponse { get; init; }
    public required SearchParams Searched { get; init; }
}
