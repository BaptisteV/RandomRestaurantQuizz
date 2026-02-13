using DuckDB.NET.Data;
using System.Text.Json;

namespace RandomRestaurantQuizz.Api;

public sealed class PlacesCacheRepository
{
    private readonly string _connectionString;
    private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public PlacesCacheRepository(
        SqliteDbPath dbPath)
    {
        _connectionString = dbPath.ConnectionString;

        using var con = new DuckDBConnection(_connectionString);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        CREATE TABLE IF NOT EXISTS places_cache (
            cache_key TEXT PRIMARY KEY,
            latitude DOUBLE,
            longitude DOUBLE,
            radius INTEGER,
            response_json JSON,
            created_at TIMESTAMP
        );
        """;
        cmd.ExecuteNonQuery();
    }

    public List<PlaceResult>? TryGet(string cacheKey, TimeSpan maxAge)
    {
        using var con = new DuckDBConnection(_connectionString);
        con.Open();

        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        SELECT response_json, created_at
        FROM places_cache
        WHERE cache_key = ?
        """;

        cmd.Parameters.Add(new DuckDBParameter { Value = cacheKey });

        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
            return null;

        var createdAt = reader.GetDateTime(1);
        if (DateTime.UtcNow - createdAt > maxAge)
            return null;

        var json = reader.GetString(0);
        return JsonSerializer.Deserialize<List<PlaceResult>>(json, _jsonOptions);
    }

    public void Store(string cacheKey, SearchLocation loc, List<PlaceResult> places)
    {
        using var con = new DuckDBConnection(_connectionString);
        con.Open();

        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        INSERT OR REPLACE INTO places_cache
        VALUES (?, ?, ?, ?, ?, CURRENT_TIMESTAMP)
        """;

        cmd.Parameters.Add(new DuckDBParameter { Value = cacheKey });
        cmd.Parameters.Add(new DuckDBParameter { Value = loc.Latitude });
        cmd.Parameters.Add(new DuckDBParameter { Value = loc.Longitude });
        cmd.Parameters.Add(new DuckDBParameter { Value = SearchLocation.SearchRadius });
        cmd.Parameters.Add(new DuckDBParameter
        {
            Value = JsonSerializer.Serialize(places, _jsonOptions)
        });

        cmd.ExecuteNonQuery();
    }
}