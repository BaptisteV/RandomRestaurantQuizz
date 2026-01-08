using Plugin.Maui.Audio;

namespace RandomRestaurantQuizz.Core.SoundEffects;

public class DynamicSoundEffect(IAudioManager audioManager, IPitchShifter pitchShifter) : ISoundEffect
{
    private readonly IAudioManager _audioManager = audioManager;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private AsyncAudioPlayer _baseSound;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public async Task Init()
    {
        _baseSound = _audioManager.CreateAsyncPlayer(await FileSystem.OpenAppPackageFileAsync("base.wav"));
    }

    public Task OnAnswer(double correctnessPercentage, CancellationToken cancellationToken)
    {
        var shiftedSound = pitchShifter.ShiftBy(_baseSound, correctnessPercentage);
        return shiftedSound.PlayAsync(cancellationToken);
    }
}
