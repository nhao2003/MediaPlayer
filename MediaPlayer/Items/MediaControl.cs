using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
using System.IO;
using MediaPlayer.Widgets;
using System.Numerics;
using TagLib.Riff;

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        public string path = null;
        public delegate void PassMediaControl(MediaControl control);
        public bool repeatSong = false;
        public bool repeatPlaylist = false;
        public bool isPlayingVideo = false;
        Random random = new Random(); //At class level
        static List<int> listIndexDefalt = new List<int>(); //At class level
        List<int> listIndexPlay = listIndexDefalt;
        public MediaControl()
        {
            InitializeComponent();
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;
            //UserControl_LibrarySong test = new UserControl_LibrarySong();
            //PassMediaControl datasend = new PassMediaControl(test.GetMediaControl);
            //datasend(this);
            // genera new list index of song
            for(int i = 0; i < MediaHelpers.listSongs.Count; i++)
            {
                listIndexDefalt.Add(i);
            }
        }
        internal void transferDataFromLib(string filePath)
        {
            path = filePath;
            getPathOfSong(path);
        }
        private void ChangeRepeatMode()
        {
            if (repeatSong == false && repeatPlaylist == false)
            {
                repeatSong = true;
                repeatPlaylist = false;
            }
            else if (repeatSong == true && repeatPlaylist == false)
            {
                repeatSong = false;
                repeatPlaylist = true;
            }
            else if (repeatSong == false && repeatPlaylist == true)
            {
                repeatSong = false;
                repeatPlaylist = false;
            }
        }
        // random mode
        private List<int> GetRandomListIndex()
        {
            List<int> listRanIndex = listIndexDefalt;
            int n = listRanIndex.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = listRanIndex[k];
                listRanIndex[k] = listRanIndex[n];
                listRanIndex[n] = value;
            }
            return listRanIndex;
        }
        public void getPathOfSong(string path)
        {
            if (isPlayingVideo)
            {
                MessageBox.Show("Video is playing! Please turn off video");
                return;
            }
            TagLib.File file = TagLib.File.Create(path);
            gunaLabel_SongName.Text = (file.Tag.Title != null)
                ? file.Tag.Title.ToString()
                : Path.GetFileNameWithoutExtension(path);
            gunaLabel_NameAthor.Text = (file.Tag.Album);
            if (gunaLabel_NameAthor.Text == "") gunaLabel_NameAthor.Text = "UnKnow";
            try
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                gunaPictureBox_SongImage.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {
                //MessageBox.Show("Media Control , get path song: " + ex.ToString());
                gunaPictureBox_SongImage.Image = Resources.defaultImage;
            }
            finally
            {
                MediaTrackBar.Maximum = (int)file.Properties.Duration.TotalSeconds;
                MediaTrackBar.Value = 0;
                timeSongPlay.Text = "00:00";
                timeSongEnd.Text = string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds / 60) + ":" + string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds % 60);
                btn_Play.Image = Resources.play_hover;
                btn_Play.OnHoverImage = Resources.play_hover;

                // Lay path gan cho PlayMedia
                if (path != null) PlayMedia.URL = path;
                PlayMedia.setCurrentTimePlay();
                // Play
                timerSong.Enabled = true;
                btn_Play.Image = Resources.pause_hover;
                btn_Play.OnHoverImage = Resources.pause_hover;
                PlayMedia.playSong();
            }
        }

        public void pauseCurrentPlayer()
        {
            if (PlayMedia.IsFirst == false) return;
            if (PlayMedia.Status == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timerSong.Enabled = false;
                btn_Play.Image = Resources.play_hover;
                btn_Play.OnHoverImage = Resources.play_hover;
                PlayMedia.pauseSong();
            }
        }
        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            try
            {
                // adjust video
                if (isPlayingVideo)
                {
                    videoScreen.click_btn_play();
                    return;
                }
                // adjust song
                if (PlayMedia.IsFirst == false) return;
                if (PlayMedia.Status == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    timerSong.Enabled = false;
                    btn_Play.Image = Resources.play_hover;
                    btn_Play.OnHoverImage = Resources.play_hover;
                    PlayMedia.pauseSong();
                }
                else if (PlayMedia.Status == WMPLib.WMPPlayState.wmppsPaused)
                {
                    btn_Play.Image = Resources.pause_hover;
                    btn_Play.OnHoverImage = Resources.pause_hover;
                    PlayMedia.continueSong();
                    timerSong.Enabled = true;
                }
                else
                {
                    timerSong.Enabled = true;
                    btn_Play.Image = Resources.pause_hover;
                    btn_Play.OnHoverImage = Resources.pause_hover;
                    PlayMedia.playSong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (PlayMedia.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaTrackBar.Maximum = (int)PlayMedia.DurationSong;
                MediaTrackBar.Value = (int)PlayMedia.CurrentPositionSong;
                timeSongPlay.Text = PlayMedia.CurrentPositionStringSong;
                timeSongEnd.Text = PlayMedia.DurationStringSong;
                btn_Play.Image = Resources.pause_hover;
                btn_Play.OnHoverImage = Resources.pause_hover;
                PlayMedia.setCurrentTimePlay();
            }
            else if (PlayMedia.player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (repeatSong)
                {
                    // lap lai bai hat
                    timerSong.Enabled = true;
                    PlayMedia.playSong();
                }
                else
                {
                    gunaCircleButton_next_Click(sender, e);
                }
            }
        }

        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.setCurrentPosition(e.X, MediaTrackBar.Width);
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            PlayMedia.setCurrentPosition(e.X, MediaTrackBar.Width);
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.changeVolume(gunaTrackBar_Volume.Value);
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            PlayMedia.Volume = gunaTrackBar_Volume.Value;
            SetIconVolume();
        }
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.changeVolume(gunaTrackBar_Volume.Value);
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            PlayMedia.Volume = gunaTrackBar_Volume.Value;
            SetIconVolume();
        }

        public int volumeNow = 100;

        private void SetIconVolume()
        {
            if (gunaTrackBar_Volume.Value == 0)
            {
                btn_Volume.Image = Resources.volume_mute;
                btn_Volume.OnHoverImage = Resources.volume_mute_hover;
            }
            else if (gunaTrackBar_Volume.Value < 50)
            {
                btn_Volume.Image = Resources.volume_low;
                btn_Volume.OnHoverImage = Resources.volume_low_hover;
            }
            else
            {
                btn_Volume.Image = Resources.volume_high;
                btn_Volume.OnHoverImage = Resources.volume_high_hover;
            }
        }
        private void gunaCircleButton_Volume_Click(object sender, EventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.changeMute();
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            if (PlayMedia.player.settings.volume != 0)
            {
                PlayMedia.muteVolume();
                volumeNow = gunaTrackBar_Volume.Value;
                gunaTrackBar_Volume.Value = 0;
            }
            else
            {
                PlayMedia.Volume = volumeNow;
                gunaTrackBar_Volume.Value = volumeNow;
            }
            SetIconVolume();
        }
        private void gunaCircleButton_next_Click(object sender, EventArgs e)
        {
            if (PlayMedia.IsFirst == false) return;
            for (int i = 0; i < MediaHelpers.listSongs.Count; i++)
            {
                if(MediaHelpers.listSongs[i].FilePath == PlayMedia.Path)
                {
                    if(i != MediaHelpers.listSongs.Count - 1)
                    {
                        getPathOfSong(MediaHelpers.listSongs[i + 1].FilePath);
                        PlayMedia.playSong();
                    }
                    else if (i == MediaHelpers.listSongs.Count - 1 && repeatPlaylist == true)
                    {
                        getPathOfSong(MediaHelpers.listSongs[0].FilePath);
                        PlayMedia.playSong();
                    }
                    return;
                }
            }
        }

        private void gunaCircleButton_prev_Click(object sender, EventArgs e)
        {
            if (PlayMedia.IsFirst == false) return;
            for (int i = 0; i < MediaHelpers.listSongs.Count; i++)
            {
                if (MediaHelpers.listSongs[i].FilePath == PlayMedia.Path)
                {
                    if (i != 0)
                    {
                        getPathOfSong(MediaHelpers.listSongs[i - 1].FilePath);
                    }
                    PlayMedia.playSong();
                    return;
                }
            }
        }

        private void gunaCircleButton_Like_Click(object sender, EventArgs e)
        {
            //VideoPlayer video = new VideoPlayer();
            //video.Width = 900;
            //video.Height = 600;
            //video.ShowDialog();
        }

        // Sync with video
        public VideoPlayer videoScreen = new VideoPlayer();
        public void SyncWithVideo(string path, WMPLib.WMPPlayState status, bool isClosing)
        {
            // ten, anh, thoi luong
            TagLib.File file = TagLib.File.Create(path);
            gunaLabel_SongName.Text = (file.Tag.Title != null)
                ? file.Tag.Title.ToString()
                : Path.GetFileNameWithoutExtension(path);
            gunaLabel_NameAthor.Text = (file.Tag.Album);
            if (gunaLabel_NameAthor.Text == "") gunaLabel_NameAthor.Text = "UnKnow";
            SetIconVolume();
            try
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                gunaPictureBox_SongImage.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {
                gunaPictureBox_SongImage.Image = Resources.defaultImage;
            }
            finally
            {
                MediaTrackBar.Maximum = (int)file.Properties.Duration.TotalSeconds;
                timeSongEnd.Text = string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds / 60) + ":" + string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds % 60);
                
            }
            // button
            if (status == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btn_Play.Image = Resources.pause_hover;
                btn_Play.OnHoverImage = Resources.pause_hover;
            }
            else
            {
                btn_Play.Image = Resources.play_hover;
                btn_Play.OnHoverImage = Resources.play_hover;
            }
            if (isClosing && status == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timerSong.Enabled = true;
                btn_Play.Image = Resources.pause_hover;
                btn_Play.OnHoverImage = Resources.pause_hover;
                PlayMedia.playSong();
            }
        }

        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            if (PlayMedia.Repeat == RepeatMode.Off)
            {
                PlayMedia.Repeat = RepeatMode.All;
                btn_Repeat.Image = Resources.repeat_on;
                btn_Repeat.OnHoverImage = Resources.repeat_on;
            }
            else if(PlayMedia.Repeat == RepeatMode.All)
            {
                PlayMedia.Repeat = RepeatMode.One;
                btn_Repeat.Image = Resources.repeat_one;
                btn_Repeat.OnHoverImage = Resources.repeat_one;
            } else if (PlayMedia.Repeat == RepeatMode.One)
            {
                PlayMedia.Repeat = RepeatMode.Off;
                btn_Repeat.Image = Resources.repeat;
                btn_Repeat.OnHoverImage = Resources.repeat;
            }
        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            if (PlayMedia.Suffle)
            {
                btn_Suffle.Image = Resources.suffle;
                btn_Suffle.OnHoverImage = Resources.suffle;
                PlayMedia.Suffle = false;
            }
            else
            {
                btn_Suffle.Image = Resources.suffle_hover;
                btn_Suffle.OnHoverImage = Resources.suffle_hover;
                PlayMedia.Suffle = true;
            }
        }
    }
}
