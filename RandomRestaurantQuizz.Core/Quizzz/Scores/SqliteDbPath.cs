namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class SqliteDbPath
{
    public required string DbPath { get; init; }
    public string ConnectionString => $"Data Source={DbPath}";
}
