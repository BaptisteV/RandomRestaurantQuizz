namespace RandomRestaurantQuizz.Core.Places;

public interface IQuizzApiClient
{
    Task<QuizzApiResult?> GetRestaurants(SearchParams searchParams, CancellationToken cancellationToken);
}
