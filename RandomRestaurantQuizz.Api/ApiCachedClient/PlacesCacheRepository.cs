using DuckDB.NET.Data;
using System.Globalization;
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

        // Clear();
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
            created_at TEXT
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
        if (!await reader.ReadAsync())
            return null;

        var c = reader.GetString(1);
        var createdAt = DateTime.ParseExact(c, "O", CultureInfo.InvariantCulture);
        if (DateTime.UtcNow - createdAt > maxAge)
            return null;

        var json = reader.GetString(0);

        return JsonSerializer.Deserialize<PlacesApiResponse>(json, _jsonOptions);
    }

    public async Task Store(string cacheKey, SearchLocation loc, PlacesApiResponse response)
    {
        using var con = new DuckDBConnection(_connectionString);
        await con.OpenAsync();

        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        INSERT INTO places_cache 
        VALUES (?, ?, ?, ?, ?, ?);
        """;

        cmd.Parameters.Add(new DuckDBParameter { Value = cacheKey });
        cmd.Parameters.Add(new DuckDBParameter { Value = loc.Latitude });
        cmd.Parameters.Add(new DuckDBParameter { Value = loc.Longitude });
        cmd.Parameters.Add(new DuckDBParameter { Value = SearchLocation.SearchRadius });
        cmd.Parameters.Add(new DuckDBParameter
        {
            Value = JsonSerializer.Serialize(response, _jsonOptions)
        });
        cmd.Parameters.Add(new DuckDBParameter() { Value = DateTime.Now.ToString("O") });

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task ClearAsync()
    {
        using var con = new DuckDBConnection(_connectionString);
        await con.OpenAsync();
        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        DROP TABLE places_cache;
        """;

        await cmd.ExecuteNonQueryAsync();
    }

    public void Clear()
    {
        using var con = new DuckDBConnection(_connectionString);
        con.Open();
        using var cmd = con.CreateCommand();
        cmd.CommandText =
        """
        DROP TABLE places_cache;
        """;

        cmd.ExecuteNonQuery();
    }
}