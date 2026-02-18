using DuckDB.NET.Data;
using System.Data;
using System.Globalization;

namespace RandomRestaurantQuizz.Core.Quizzz.Scores;

// /!\ Not supported on Android (yet)
// https://duckdb.org/docs/stable/dev/building/android
public sealed class DuckDbScoreRepository : IScoreRepository, IDisposable
{
    private readonly DuckDBConnection _connection;

    public DuckDbScoreRepository(AppDataDb dbPath)
    {
        _connection = new DuckDBConnection(dbPath.ConnectionString);
    }

    public void Dispose()
    {
        _connection?.Dispose();
    }

    public async Task Init()
    {
        if (!_connection.State.HasFlag(ConnectionState.Open))
            await _connection.OpenAsync();

        // await DropTable();

        var command = _connection.CreateCommand();
        command.CommandText =
        """
        CREATE TABLE IF NOT EXISTS Score (
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

        var command = _connection.CreateCommand();
        command.CommandText =
        """
        SELECT ScoreValue, Ts, LocationName
        FROM Score
        ORDER BY ScoreValue DESC;
        """;

        await using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            scores.Add(new Score
            {
                Value = reader.GetDouble(0),
                Timestamp = DateTime.ParseExact(reader.GetString(1), "O", CultureInfo.InvariantCulture),
                LocationName = reader.GetString(2),
            });
        }

        return scores;
    }

    public async Task SaveScore(Score score)
    {
        var command = _connection.CreateCommand();
        command.CommandText =
        """
        INSERT INTO Score (ScoreValue, Ts, LocationName)
        VALUES ($scoreValue, $ts, $locationName);
        """;

        var scoreValueParam = command.CreateParameter();
        scoreValueParam.ParameterName = "scoreValue";
        scoreValueParam.Value = score.Value;
        command.Parameters.Add(scoreValueParam);

        var tsParam = command.CreateParameter();
        tsParam.ParameterName = "ts";
        tsParam.Value = score.Timestamp.ToString("O", CultureInfo.InvariantCulture);
        command.Parameters.Add(tsParam);

        var locationParam = command.CreateParameter();
        locationParam.ParameterName = "locationName";
        locationParam.Value = score.LocationName;
        command.Parameters.Add(locationParam);

        await command.ExecuteNonQueryAsync();
    }
}