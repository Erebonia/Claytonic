using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DIT_AIO;
using NAudio.Wave;

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
            "DIT_AIO.Resources.claytonic_music_slow.wav"
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

    public void LoadNextSong()
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
        LoadAudio(songList[currentSongIndex]);
    }

    public void LoadAudio(string resourceName)
    {
        try
        {
            Stream resourceStream = ResourceHelper.GetResourceStream(resourceName);
            waveStream = new WaveFileReader(resourceStream);
            waveOutEvent = new WaveOutEvent();
            waveOutEvent.Init(waveStream);

            // Set the initial volume based on the TrackBar's current value
            SetVolume(musicVolume.Value / 100f);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load audio: {ex.Message}");
        }
    }

    public void PlayLooping()
    {
        if (waveOutEvent != null)
        {
            waveOutEvent.Play();
            isPlaying = true;
        }
    }

    public void Stop()
    {
        if (waveOutEvent != null)
        {
            waveOutEvent.Stop();
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
            Stop();
            clickedButton.Image = pauseImage;
        }
        else
        {
            LoadNextSong();
            PlayLooping();
            clickedButton.Image = playImage;
        }
    }

    public void SetVolume(float volume)
    {
        if (waveOutEvent != null && waveStream != null)
        {
            waveOutEvent.Volume = volume;
        }
    }

    private void musicVolume_Scroll(object sender, EventArgs e)
    {
        float volume = musicVolume.Value / 100f;
        SetVolume(volume);
    }
}
