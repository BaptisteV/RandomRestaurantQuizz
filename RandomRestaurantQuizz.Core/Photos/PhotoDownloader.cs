using RandomRestaurantQuizz.Core.Places.GoogleApi;
using System.Diagnostics;

namespace RandomRestaurantQuizz.Core.Photos;

public class PhotoDownloader : IPhotoDownloader
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly IFileNamer _fileNamer;
    private readonly ILogger<PhotoDownloader> _logger;

    public PhotoDownloader(HttpClient httpClient, SecretsJson config, IFileNamer fileNamer, ILogger<PhotoDownloader> logger)
    {
        _httpClient = httpClient;
        _apiKey = config.GooglePlacesApiKey;
        _logger = logger;
        _fileNamer = fileNamer;
    }

    private string GetPhotoUrl(string photoName, int maxWidth = 800)
    {
        var segments = photoName.Split('/');
        var placeId = segments[1];
        var photoReference = segments[3];
        var url = $"https://places.googleapis.com/v1/places/{placeId}/photos/{photoReference}/media?key={_apiKey}&maxWidthPx={maxWidth}";
        return url;
    }

    private async Task<byte[]> GetImage(Photo photo, CancellationToken cancellationToken)
    {
        var url = GetPhotoUrl(photo.Name!);
        _logger.LogDebug("Downloading: {DownloadUrl}", url);
        using var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsByteArrayAsync(cancellationToken);
    }

    private bool PhotoInCache(PlaceResult place, int photoIndex)
    {
        var filename = _fileNamer.GetFilename(place, photoIndex);

        var rootDir = Path.GetDirectoryName(filename)!;
        if (!Directory.Exists(rootDir))
        {
            Directory.CreateDirectory(rootDir);
        }

        if (!File.Exists(filename))
            return false;

        if (new FileInfo(filename).Length == 0)
            return false;

        _logger.LogDebug("Photo {PhotoIndex} already exists for {PlaceName}, skipping download.", photoIndex, place.DisplayName.Text);
        return true;
    }

    private async Task<byte[]> GetSinglePhoto(PlaceResult place, int p, string filename, CancellationToken cancellationToken)
    {
        async Task<byte[]> ReadFromDisk(string filename, CancellationToken cancellationToken)
        {
            var image = await File.ReadAllBytesAsync(filename, cancellationToken);
            return image;
        }

        async Task<byte[]> ReadFromApi(string filename, Photo photo, CancellationToken cancellationToken)
        {
            var image = await GetImage(photo, cancellationToken);
            _ = Task.Run(async () => await File.WriteAllBytesAsync(filename, image, cancellationToken), cancellationToken);
            return image;
        }

        if (!PhotoInCache(place, p))
        {
            return await ReadFromApi(filename, place.Photos[p], cancellationToken);
        }
        else
        {
            return await ReadFromDisk(filename, cancellationToken);
        }
    }
    private async Task GetSingleRestaurantPhotos(PlaceResult place, CancellationToken cancellationToken)
    {
        try
        {
            if (place.Photos.Count == 0)
            {
                _logger.LogWarning("No photo for {PlaceName}", place.DisplayName.Text);
                return;
            }

            for (var p = 0; p < place.Photos.Count; p++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                // The first image gets downloaded early
                if (place.Photos[p].DownloadedImage.Length > 0)
                    continue;

                var filename = _fileNamer.GetFilename(place, p);
                var data = await GetSinglePhoto(place, p, filename, cancellationToken);
                place.Photos[p].DownloadedImage = data;
            }
        }
        catch (HttpRequestException reqException)
        {
            _logger.LogError(reqException, "Failed to get image for place: {PlaceName}", place.DisplayName.Text);
            throw;
        }
        catch (OperationCanceledException cancelledException)
        {
            _logger.LogError(cancelledException, "Getting image canceled for: {PlaceName}", place.DisplayName.Text);
            throw;
        }

    }

    public async Task<PlaceResult> GetFirstPhoto(PlaceResult placeResult, CancellationToken cancellationToken)
    {
        var sw = Stopwatch.StartNew();
        var data = await GetSinglePhoto(placeResult, 0, _fileNamer.GetFilename(placeResult, 0), cancellationToken);
        placeResult.Photos[0].DownloadedImage = data;

        var elapsed = sw.Elapsed;
        _logger.LogInformation("First restaurant photo fetched in {DlElapsed}", elapsed);

        return placeResult;
    }

    public async Task<PlaceResult> LazyGetPhotos(PlaceResult placeResult, CancellationToken cancellationToken)
    {
        var sw = Stopwatch.StartNew();
        var data = await GetSinglePhoto(placeResult, 0, _fileNamer.GetFilename(placeResult, 0), cancellationToken);
        placeResult.Photos[0].DownloadedImage = data;

        var elapsed = sw.Elapsed;
        _logger.LogInformation("First restaurant photo fetched in {DlElapsed}", elapsed);

        _ = Task.Run(async () =>
        {
            var swAll = Stopwatch.StartNew();
            await GetSingleRestaurantPhotos(placeResult, cancellationToken);
            var elapsedAll = swAll.Elapsed;
            _logger.LogInformation("All restaurant's photos fetched in {DlElapsed}", elapsedAll);
        }, cancellationToken);

        return placeResult;
    }
}