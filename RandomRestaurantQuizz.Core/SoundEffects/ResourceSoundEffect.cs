using Plugin.Maui.Audio;

namespace RandomRestaurantQuizz.Core.SoundEffects;

public class ResourceSoundEffect(IAudioManager audioManager) : ISoundEffect
{
    private readonly IAudioManager _audioManager = audioManager;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private AsyncAudioPlayer _winSound;
    private AsyncAudioPlayer _looseSound;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public async Task Init()
    {
        _winSound = _audioManager.CreateAsyncPlayer(await FileSystem.OpenAppPackageFileAsync("win.wav"));
        _looseSound = _audioManager.CreateAsyncPlayer(await FileSystem.OpenAppPackageFileAsync("loose.wav"));
    }

    public async Task PlayAnswer(double correctnessPercentage, CancellationToken cancellationToken)
    {
        if (correctnessPercentage > 50.0)
        {
            await PlayWin(cancellationToken);
        }
        else
        {
            await PlayLoose(cancellationToken);
        }
    }

    private async Task PlayWin(CancellationToken cancellationToken)
    {
        await _winSound.PlayAsync(cancellationToken);
    }

    private async Task PlayLoose(CancellationToken cancellationToken)
    {
        await _looseSound.PlayAsync(cancellationToken);
    }
}
