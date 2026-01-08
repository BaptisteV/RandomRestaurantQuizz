using Plugin.Maui.Audio;

namespace RandomRestaurantQuizz.Core.SoundEffects;

public class PitchShifter : IPitchShifter
{
    public AsyncAudioPlayer ShiftBy(AsyncAudioPlayer sample, double shiftByPercent)
    {
        sample.Speed = shiftByPercent / 2.0;
        return sample;
    }
}
