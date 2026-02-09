using Microsoft.Data.Sqlite;
using System.Globalization;

namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public sealed class SqlLiteScoreRepository : IScoreRepository, IDisposable
{
    private const string DbFilename = "scores.db";
    private readonly SqliteConnection _connection;

    public SqlLiteScoreRepository()
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, DbFilename);
        var connectionString = $"Data Source={dbPath}";
        _connection = new SqliteConnection(connectionString);
    }

    public void Dispose()
    {
        _connection.Close();
        _connection.Dispose();
    }

    public async Task Init()
    {
        await _connection.OpenAsync();

        await DropTable();

        var command = _connection.CreateCommand();
        command.CommandText =
        """
        CREATE TABLE IF NOT EXISTS Score (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            ScoreValue DOUBLE PRECISION NOT NULL,
            Ts TEXT NOT NULL
        );
        """;

        await command.ExecuteNonQueryAsync();
    }

    private async Task DropTable()
    {
        var command = _connection.CreateCommand();
        command.CommandText =
        """
        DROP TABLE IF EXISTS Score;        
        """;

        await command.ExecuteNonQueryAsync();
    }

    public async Task<List<Score>> ReadScores()
    {
        var scores = new List<Score>();

        await _connection.OpenAsync();

        var command = _connection.CreateCommand();
        command.CommandText =
        """
        SELECT Id, ScoreValue, Ts
        FROM Score
        ORDER BY ScoreValue DESC;
        """;

        await using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            scores.Add(new Score
            {
                Id = reader.GetInt32(0),
                Value = reader.GetDouble(1),
                Timestamp = DateTime.ParseExact(reader.GetString(2), "O", CultureInfo.InvariantCulture),
            });
        }

        return scores;
    }

    public async Task SaveScore(Score score)
    {
        await _connection.OpenAsync();

        var command = _connection.CreateCommand();
        command.CommandText =
        """
        INSERT INTO Score (ScoreValue, Ts)
        VALUES ($scoreValue, $ts);
        """;

        command.Parameters.AddWithValue("$scoreValue", score.Value);
        command.Parameters.AddWithValue("$ts", score.Timestamp.ToString("O", CultureInfo.InvariantCulture));

        await command.ExecuteNonQueryAsync();
    }
}