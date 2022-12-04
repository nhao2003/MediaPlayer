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
namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        public MediaControl()
        {
            InitializeComponent();
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;
            UserControl_LibrarySong test = new UserControl_LibrarySong();
            PassMediaControl datasend = new PassMediaControl(test.GetMediaControl);
            datasend(this);
        }
        public string path = null;
        public delegate void PassMediaControl(MediaControl control);
        internal void transferDataFromLib(string filePath)
        {
            path = filePath;
            getPathOfSong(path);
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
            catch (Exception)
            {

            }
            finally
            {
                if (path != null) PlayMedia.setURL(path);

                MediaTrackBar.Maximum = (int)file.Properties.Duration.TotalSeconds;
                MediaTrackBar.Value = 0;
                timeSongPlay.Text = "00:00";
                timeSongEnd.Text = string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds / 60) + ":" + string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds % 60);

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
                    PlayMedia.pauseSong();
                }
                else if (PlayMedia.getStatus() == WMPLib.WMPPlayState.wmppsPaused)
                {
                    PlayMedia.continueSong();
                    timerSong.Enabled = true;
                }
                else
                {
                    timerSong.Enabled = true;
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
                PlayMedia.setCurrentTimePlay();
            }
        }

        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            PlayMedia.setCurrentPosition(e.X, MediaTrackBar.Width);
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            PlayMedia.setVolume(gunaTrackBar_Volume.Value);
        }
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            PlayMedia.setVolume(gunaTrackBar_Volume.Value);
        }

        public int volumeNow = 50;
        private void gunaCircleButton_Volume_Click(object sender, EventArgs e)
        {
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
        }
    }
}
