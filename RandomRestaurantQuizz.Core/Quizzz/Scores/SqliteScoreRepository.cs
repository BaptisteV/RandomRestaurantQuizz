using Microsoft.Data.Sqlite;
using System.Globalization;

namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

public sealed class SqliteScoreRepository : IScoreRepository, IDisposable
{
    private readonly SqliteConnection _connection;

    public SqliteScoreRepository(AppDataDb sqliteDbPath)
    {
        _connection = new SqliteConnection(sqliteDbPath.ConnectionString);
    }

    public void Dispose()
    {
        _connection.Close();
        _connection.Dispose();
    }

    public async Task Init()
    {
        await _connection.OpenAsync();

        // await DropTable();

        var command = _connection.CreateCommand();
        command.CommandText =
        """
        CREATE TABLE IF NOT EXISTS Score (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            ScoreValue DOUBLE PRECISION NOT NULL,
            Ts TEXT NOT NULL,
            LocationName TEXT NOT NULL
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
        SELECT Id, ScoreValue, Ts, LocationName
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
                LocationName = reader.GetString(3),
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
        INSERT INTO Score (ScoreValue, Ts, LocationName)
        VALUES ($scoreValue, $ts, $locationName);
        """;

        command.Parameters.AddWithValue("$scoreValue", score.Value);
        command.Parameters.AddWithValue("$ts", score.Timestamp.ToString("O", CultureInfo.InvariantCulture));
        command.Parameters.AddWithValue("$locationName", score.LocationName);

        await command.ExecuteNonQueryAsync();
    }
}