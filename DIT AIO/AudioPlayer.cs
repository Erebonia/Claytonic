using DIT_AIO;
using NAudio.Wave;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;
using System.Linq;

public class AudioPlayer
{
    private WaveOutEvent waveOutEvent;
    private WaveStream waveStream;
    private bool isPlaying = false;
    private System.Drawing.Image playImage;
    private System.Drawing.Image pauseImage;
    private List<string> songList = new List<string>();
    private int currentSongIndex = -1;
    private List<int> playedIndices = new List<int>();
    private TrackBar musicVolume; // Reference to the TrackBar control

    public AudioPlayer(System.Drawing.Image playImage, System.Drawing.Image pauseImage, TrackBar musicVolume)
    {
        this.playImage = playImage;
        this.pauseImage = pauseImage;
        this.musicVolume = musicVolume;

        // Initialize the song list with the resource names
        songList = new List<string>
        {
            "DIT_AIO.Resources.claytonic_music.wav",
            "DIT_AIO.Resources.claytonic_music_slow.wav",
            "DIT_AIO.Resources.CoffeeTonic.wav"

        };

        ShuffleSongs();

        // Attach the Scroll event handler to the TrackBar
        this.musicVolume.Scroll += new EventHandler(musicVolume_Scroll);
    }

    private void ShuffleSongs()
    {
        Random rng = new Random();
        songList = songList.OrderBy(x => rng.Next()).ToList();
        playedIndices.Clear();
    }

    public void LoadNextSong(Button clickedButton)
    {
        if (playedIndices.Count == songList.Count)
        {
            ShuffleSongs();
            currentSongIndex = -1;
        }

        do
        {
            currentSongIndex = (currentSongIndex + 1) % songList.Count;
        } while (playedIndices.Contains(currentSongIndex));

        playedIndices.Add(currentSongIndex);
        LoadAudio(songList[currentSongIndex], clickedButton);
    }

    public void LoadAudio(string resourceName, Button clickedButton)
    {
        try
        {
            Stream resourceStream = ResourceHelper.GetResourceStream(resourceName);
            waveStream = new WaveFileReader(resourceStream);
            waveOutEvent = new WaveOutEvent();
            waveOutEvent.Init(waveStream);

            // Set the initial volume based on the TrackBar's current value
            SetVolume(musicVolume.Value / 10f);

            // Subscribe to the PlaybackStopped event
            waveOutEvent.PlaybackStopped += OnPlaybackStopped;

            // Start playing immediately
            PlayLooping();

            // Update the button image
            UpdateUI(clickedButton);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load audio: {ex.Message}");
        }
    }

    private void OnPlaybackStopped(object sender, StoppedEventArgs e)
    {
        if (e.Exception == null && isPlaying)
        {
            // If the playback stopped naturally (song ended), loop the track
            waveStream.Position = 0; // Reset position to the beginning
            waveOutEvent.Play();
        }
        else if (e.Exception != null)
        {
            MessageBox.Show($"Playback stopped due to an error: {e.Exception.Message}");
        }
    }

    public void PlayLooping()
    {
        if (waveOutEvent != null)
        {
            waveStream.Position = 0; // Reset position to the beginning
            waveOutEvent.Play();
            isPlaying = true;
        }
    }

    public void Pause()
    {
        if (waveOutEvent != null)
        {
            waveOutEvent.Pause();
            isPlaying = false;
        }
    }

    public void Stop()
    {
        if (waveOutEvent != null)
        {
            waveOutEvent.Stop();
            isPlaying = false;

            // Reset volume to current TrackBar setting when stopping
            SetVolume(musicVolume.Value / 10f);
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
            Stop(); // Stop the current song
            UpdateUI(clickedButton);
        }
        else
        {
            LoadNextSong(clickedButton); // Load and play the next song
            PlayLooping();
            UpdateUI(clickedButton);
        }
    }

    public void SetVolume(float volume)
    {
        if (waveOutEvent != null && waveStream != null)
        {
            waveOutEvent.Volume = volume;

            // Debugging: Output the volume value to see if it matches expectations
            Console.WriteLine($"Volume Set: {waveOutEvent.Volume}");
        }
    }

    private void musicVolume_Scroll(object sender, EventArgs e)
    {
        // Scale the TrackBar value (0 to 10) to the NAudio volume range (0.0 to 1.0)
        float volume = musicVolume.Value / 10f;

        // Debugging: Output the TrackBar value and scaled volume
        Console.WriteLine($"TrackBar Value: {musicVolume.Value}, Volume Set: {volume}");

        SetVolume(volume);
    }

    // This method will update the button image based on the playing status
    public void UpdateButtonImage(Button clickedButton)
    {
        if (IsPlaying())
        {
            clickedButton.Image = pauseImage;
        }
        else
        {
            clickedButton.Image = playImage;
        }
    }

    // Call this method after loading or stopping audio to ensure the image is correct
    private void UpdateUI(Button clickedButton)
    {
        if (clickedButton != null)
        {
            UpdateButtonImage(clickedButton);
        }
    }
}
