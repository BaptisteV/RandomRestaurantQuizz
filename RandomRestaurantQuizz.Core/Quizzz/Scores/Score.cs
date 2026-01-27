//using SQLite;

namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class Score
{
    //[PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int Value { get; init; }
    public DateTime Timestamp { get; init; }
}
