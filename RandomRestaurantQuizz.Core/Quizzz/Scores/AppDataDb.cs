namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class AppDataDb
{
    public required string DbFile { get; init; }
    public string ConnectionString => $"Data Source={DbFile}";
}
