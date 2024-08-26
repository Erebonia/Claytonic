using DIT_AIO;
using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

public class AudioPlayer
{
    private SoundPlayer soundPlayer;
    private MemoryStream audioStream;
    private bool isPlaying = false;

    public AudioPlayer() { }

    public void LoadAudio(string resourceName)
    {
        try
        {
            // Get the assembly where the resource is embedded
            Stream resourceStream = ResourceHelper.GetResourceStream(resourceName);

            // Copy the stream to a MemoryStream
            audioStream = new MemoryStream();
            resourceStream.CopyTo(audioStream);
            audioStream.Position = 0; // Reset position to the beginning

            // Initialize the SoundPlayer with the MemoryStream
            soundPlayer = new SoundPlayer(audioStream);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load audio: {ex.Message}");
        }
    }

    public void PlayLooping()
    {
        if (soundPlayer != null)
        {
            soundPlayer.PlayLooping();
            isPlaying = true;
        }
    }

    public void Stop()
    {
        if (soundPlayer != null)
        {
            soundPlayer.Stop();
            isPlaying = false;
        }
    }

    public bool IsPlaying()
    {
        return isPlaying;
    }
}
