using DuckDB.NET.Data;
using System.Text.Json;

namespace RandomRestaurantQuizz.Api.ApiCachedClient;

public sealed class PlacesCacheRepository
{
    private readonly string _connectionString;
    private readonly JsonSerializerOptions _jsonOptions = new(JsonSerializerDefaults.Web);

    public PlacesCacheRepository(
        AppDataDb dbPath)
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

    public async Task<PlacesApiResponse?> TryGet(string cacheKey, TimeSpan maxAge)
    {
        using var con = new DuckDBConnection(_connectionString);
        await con.OpenAsync();

        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        SELECT response_json, created_at
        FROM places_cache
        WHERE cache_key = ?
        """;

        cmd.Parameters.Add(new DuckDBParameter { Value = cacheKey });

        using var reader = await cmd.ExecuteReaderAsync();
        if (!(await reader.ReadAsync()))
            return null;

        var createdAt = reader.GetDateTime(1);
        if (DateTime.UtcNow - createdAt > maxAge)
            return null;

        var json = reader.GetString(0);

        PlacesApiResponse? response = null;
        try
        {
            response = JsonSerializer.Deserialize<PlacesApiResponse>(json, _jsonOptions)!;
        }
        catch (JsonException)
        {
            await Clear();
        }

        return response;
    }

    public async Task Store(string cacheKey, SearchLocation loc, PlacesApiResponse response)
    {
        using var con = new DuckDBConnection(_connectionString);
        await con.OpenAsync();

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
            Value = JsonSerializer.Serialize(response, _jsonOptions)
        });

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task Clear()
    {
        using var con = new DuckDBConnection(_connectionString);
        await con.OpenAsync();
        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        DELETE FROM places_cache;
        """;

        await cmd.ExecuteNonQueryAsync();
    }
}