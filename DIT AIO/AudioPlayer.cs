using System;
using System.IO;
using System.Media;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using DIT_AIO;

public class AudioPlayer
{
    private SoundPlayer soundPlayer;
    private bool isPlaying = false;
    private System.Drawing.Image playImage;
    private System.Drawing.Image pauseImage;
    private List<string> songList = new List<string>(); // Store the list of resource names here
    private int currentSongIndex = -1; // Start at -1 to indicate no song has been played yet
    private List<int> playedIndices = new List<int>();

    public AudioPlayer(System.Drawing.Image playImage, System.Drawing.Image pauseImage)
    {
        this.playImage = playImage;
        this.pauseImage = pauseImage;

        // Initialize the song list with the resource name
        songList = new List<string>
        {
            "DIT_AIO.Resources.claytonic_music.wav",
            "DIT_AIO.Resources.claytonic_music_slow.wav"
            // Add more resource names if you have more songs
        };

        ShuffleSongs(); // Shuffle the songs at the beginning
    }

    private void ShuffleSongs()
    {
        Random rng = new Random();
        songList = songList.OrderBy(x => rng.Next()).ToList();
        playedIndices.Clear();
    }

    public void LoadNextSong()
    {
        // If all songs have been played, reshuffle and start over
        if (playedIndices.Count == songList.Count)
        {
            ShuffleSongs();
            currentSongIndex = -1; // Reset index
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
            // Load the audio resource using ResourceHelper
            Stream resourceStream = ResourceHelper.GetResourceStream(resourceName);

            // Initialize the SoundPlayer with the stream
            soundPlayer = new SoundPlayer(resourceStream);
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
            // Load and play the next song
            LoadNextSong();
            PlayLooping();
            clickedButton.Image = playImage;
        }
    }
}
