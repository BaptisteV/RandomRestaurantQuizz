using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace RandomRestaurantQuizz.Core.SoundEffects;


public sealed class SoundEffectGenerator : ISoundEffect, IDisposable
{
    private readonly IWavePlayer waveOut = new WaveOutEvent
    {
        Volume = 0.25f,
    };

    public void PlayVictorySound()
    {
        // Create a rising arpeggio for victory (C-E-G-C major chord)
        var sound = CreateArpeggio(
            new[] { 523.25f, 659.25f, 783.99f, 1046.50f }, // C5, E5, G5, C6
            150, // Duration of each note in ms
            0.3f // Volume
        );

        PlaySound(sound);
    }

    public void PlayFailureSound()
    {
        // Create a descending tone for failure
        var sound = CreateDescendingTone(
            400f,  // Start frequency
            200f,  // End frequency
            600,   // Duration in ms
            0.3f   // Volume
        );

        PlaySound(sound);
    }

    private ISampleProvider CreateArpeggio(float[] frequencies, int noteDurationMs, float volume)
    {
        var sampleRate = 44100;
        var noteProviders = new List<ISampleProvider>();

        foreach (var freq in frequencies)
        {
            var oscillator = new SignalGenerator(sampleRate, 1)
            {
                Gain = volume,
                Frequency = freq,
                Type = SignalGeneratorType.Sin
            };

            var noteDuration = TimeSpan.FromMilliseconds(noteDurationMs);
            var note = oscillator.Take(noteDuration);
            noteProviders.Add(note);
        }

        // Concatenate all notes
        return new ConcatenatingSampleProvider(noteProviders);
    }

    private ISampleProvider CreateDescendingTone(float startFreq, float endFreq, int durationMs, float volume)
    {
        var sampleRate = 44100;
        var samples = (int)(sampleRate * durationMs / 1000.0);
        var buffer = new float[samples];

        for (int i = 0; i < samples; i++)
        {
            // Linear frequency sweep from start to end
            float t = (float)i / samples;
            float frequency = startFreq + (endFreq - startFreq) * t;

            // Apply envelope (fade out)
            float envelope = 1.0f - (t * 0.7f);

            // Generate sine wave
            float sample = (float)(Math.Sin(2 * Math.PI * frequency * i / sampleRate) * volume * envelope);
            buffer[i] = sample;
        }

        return new RawSourceWaveStream(buffer, sampleRate, 1).ToSampleProvider();
    }

    private void PlaySound(ISampleProvider sound)
    {
        // Stop any currently playing sound
        waveOut?.Stop();

        // Initialize with the new sound
        waveOut?.Init(sound);
        waveOut?.Play();
    }

    public void Dispose()
    {
        waveOut?.Stop();
        waveOut?.Dispose();
    }

    public Task Init()
    {
        return Task.CompletedTask;
    }

    public Task PlayAnswer(double correctnessPercentage, CancellationToken cancellationToken)
    {
        if (correctnessPercentage > 50.0)
        {
            PlayVictorySound();
        }
        else
        {
            PlayFailureSound();
        }
        return Task.CompletedTask;
    }
}

// Helper class to convert float array to ISampleProvider
public class RawSourceWaveStream : WaveStream
{
    private readonly float[] audioData;
    private readonly WaveFormat waveFormat;
    private long position;

    public RawSourceWaveStream(float[] data, int sampleRate, int channels)
    {
        audioData = data;
        waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
    }

    public override WaveFormat WaveFormat => waveFormat;
    public override long Length => audioData.Length * 4;
    public override long Position
    {
        get => position;
        set => position = value;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        int samplesRequired = count / 4;
        int samplesAvailable = audioData.Length - (int)(position / 4);
        int samplesToRead = Math.Min(samplesRequired, samplesAvailable);

        for (int i = 0; i < samplesToRead; i++)
        {
            int sampleIndex = (int)(position / 4) + i;
            byte[] bytes = BitConverter.GetBytes(audioData[sampleIndex]);
            Array.Copy(bytes, 0, buffer, offset + (i * 4), 4);
        }

        position += samplesToRead * 4;
        return samplesToRead * 4;
    }
}
