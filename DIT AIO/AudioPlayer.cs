using System;
using System.IO;
using System.Media;
using System.Drawing;  // This is the key to ensuring the correct Image type is used
using System.Windows.Forms;
using DIT_AIO;

public class AudioPlayer
{
    private SoundPlayer soundPlayer;
    private MemoryStream audioStream;
    private bool isPlaying = false;
    private System.Drawing.Image playImage;  // Use System.Drawing.Image
    private System.Drawing.Image pauseImage;  // Use System.Drawing.Image

    public AudioPlayer(System.Drawing.Image playImage, System.Drawing.Image pauseImage)
    {
        this.playImage = playImage;
        this.pauseImage = pauseImage;
    }

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

    public void HandleMusicButtonClick(Button clickedButton)
    {
        if (IsPlaying())
        {
            // Stop the sound if it's playing 
            Stop();
            clickedButton.Image = pauseImage;
        }
        else
        {
            // Play the sound if it's not playing
            PlayLooping();
            clickedButton.Image = playImage;
        }
    }
}
