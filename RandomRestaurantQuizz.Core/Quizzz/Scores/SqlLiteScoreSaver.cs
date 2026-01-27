using SQLite;

namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public class SqlLiteScoreSaver : IScoreSaver
{
    private const string DbFilename = "scores.db";
    private readonly SQLiteAsyncConnection _database;

    public SqlLiteScoreSaver()
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, DbFilename);
        _database = new SQLiteAsyncConnection(dbPath);
    }

    public async Task Init()
    {
        await _database.CreateTableAsync<Score>();
    }

    public async Task<List<Score>> ReadScores()
    {
        return await _database.Table<Score>().ToListAsync();
    }

    public async Task SaveScore(Score score)
    {
        await _database.InsertAsync(score);
    }
}
