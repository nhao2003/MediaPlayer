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
using MediaPlayer.Screens;
using System.Numerics;

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        public string path = null;
        public delegate void PassMediaControl(MediaControl control);
        public bool repeatSong = false;
        public bool repeatPlaylist = false;
        public MediaControl()
        {
            InitializeComponent();
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;
            UserControl_LibrarySong test = new UserControl_LibrarySong();
            PassMediaControl datasend = new PassMediaControl(test.GetMediaControl);
            datasend(this);
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

        private void RandomMode()
        {
            // lay count list song
            // create array int 0 -> count with random
            // change the next fuction with new array
        }
        public void getPathOfSong(string path)
        {
            TagLib.File file = TagLib.File.Create(path);
            gunaLabel_SongName.Text = (file.Tag.Title);
            gunaLabel_NameAthor.Text = (file.Tag.Album);
            try
            {
                var ff = TagLib.File.Create(path);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                gunaPictureBox_SongImage.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Lay path gan cho PlayMedia
                if (path != null) PlayMedia.setURL(path);

                MediaTrackBar.Maximum = (int)file.Properties.Duration.TotalSeconds;
                MediaTrackBar.Value = 0;
                timeSongPlay.Text = "00:00";
                timeSongEnd.Text = string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds / 60) + ":" + string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds % 60);
                btn_Play.Image = Resources.play_hover;
                btn_Play.OnHoverImage = Resources.play_hover;

                PlayMedia.setCurrentTimePlay();
            }
        }

        private void gunaCircleButton_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                getPathOfSong(path);
            }
        }
        public void pauseCurrentPlayer()
        {
            if (PlayMedia.IsFirst() == false) return;
            if (PlayMedia.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
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
                if (PlayMedia.IsFirst() == false) return;
                if (PlayMedia.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    timerSong.Enabled = false;
                    btn_Play.Image = Resources.play_hover;
                    btn_Play.OnHoverImage = Resources.play_hover;
                    PlayMedia.pauseSong();
                }
                else if (PlayMedia.getStatus() == WMPLib.WMPPlayState.wmppsPaused)
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
                MediaTrackBar.Maximum = (int)PlayMedia.getDurationSong();
                MediaTrackBar.Value = (int)PlayMedia.getCurrentPositionSong();
                timeSongPlay.Text = PlayMedia.getCurrentPositionStringSong();
                timeSongEnd.Text = PlayMedia.getDurationStringSong();
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
                    //btn_Play.Image = Resources.pause_hover;
                    //btn_Play.OnHoverImage = Resources.pause_hover;
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
            if (PlayMedia.IsFirst() == false) return;
            PlayMedia.setCurrentPosition(e.X, MediaTrackBar.Width);
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            if (PlayMedia.IsFirst() == false) return;
            PlayMedia.setVolume(gunaTrackBar_Volume.Value);
            SetIconVolume();
        }
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            if (PlayMedia.IsFirst() == false) return;
            PlayMedia.setVolume(gunaTrackBar_Volume.Value);
            SetIconVolume();
        }

        public int volumeNow = 100;

        private void SetIconVolume()
        {
            if (PlayMedia.IsFirst() == false) return;
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
            if (PlayMedia.IsFirst() == false) return;
            if (PlayMedia.player.settings.volume != 0)
            {
                PlayMedia.muteVolume();
                volumeNow = gunaTrackBar_Volume.Value;
                gunaTrackBar_Volume.Value = 0;
            }
            else
            {
                PlayMedia.setVolume(volumeNow);
                gunaTrackBar_Volume.Value = volumeNow;
            }
            SetIconVolume();
        }
        private void gunaCircleButton_next_Click(object sender, EventArgs e)
        {
            if (PlayMedia.IsFirst() == false) return;
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
            if (PlayMedia.IsFirst() == false) return;
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
    }
}
