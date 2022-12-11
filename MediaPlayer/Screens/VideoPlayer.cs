using MediaPlayer.Models;
using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }
        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            timerSong.Enabled = true;
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;
            player.uiMode = "none";

        }
        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Main.Instance.MediaControl.SyncWithVideo(_path, WMPLib.WMPPlayState.wmppsStopped);
            Form_Main.Instance.MediaControl.isPlayingVideo = false;
            if (_path != null) PlayMedia.setURL(_path);
            PlayMedia.setCurrentTimePlay(currentTimePlay);
        }

        public double timeSkip = 10;
        public double currentTimePlay = 0.0;
        private string _path = "";

        public void getPathOfSong(string path)
        {
            try
            {
                player.URL = path;
                _path = path;

                TagLib.File file = TagLib.File.Create(path);
                lb_SongName.Text = (file.Tag.Title != null)
                ? file.Tag.Title.ToString()
                : Path.GetFileNameWithoutExtension(path);

                MediaTrackBar.Maximum = (int)file.Properties.Duration.TotalSeconds;
                MediaTrackBar.Value = 0;
                timeSongPlay.Text = "00:00";
                timeSongEnd.Text = string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds / 60) + ":" + string.Format("{0:00}", (int)file.Properties.Duration.TotalSeconds % 60);

                currentTimePlay = player.Ctlcontrols.currentPosition;
            }
            catch (Exception e)
            {
                MessageBox.Show("Video bi loi: " + e.ToString());
            }
        }

        // timer 
        private void timer_Tick(object sender, EventArgs e)
        {
            Form_Main.Instance.MediaControl.SyncWithVideo(_path, player.playState);
            SetIconVolume();
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaTrackBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                MediaTrackBar.Value = (int)player.Ctlcontrols.currentPosition;
                timeSongPlay.Text = getCurrentPositionStringSong();
                timeSongEnd.Text = getDurationStringSong();
                currentTimePlay = player.Ctlcontrols.currentPosition;

                // sync with mediaControl
                Form_Main.Instance.MediaControl.MediaTrackBar.Value = (int)player.Ctlcontrols.currentPosition;
                Form_Main.Instance.MediaControl.gunaTrackBar_Volume.Value = gunaTrackBar_Volume.Value;
                Form_Main.Instance.MediaControl.timeSongPlay.Text = getCurrentPositionStringSong();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Form_Main.Instance.MediaControl.isPlayingVideo = false;
                this.Close();
            }
        }
        private string getDurationStringSong()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                return player.Ctlcontrols.currentItem.durationString.ToString();
            return "00:00";
        }
        private string getCurrentPositionStringSong()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                return player.Ctlcontrols.currentPositionString;
            return "00:00";
        }
        private void SetIconVolume()
        {
            if (gunaTrackBar_Volume.Value == 0)
            {
                btn_volum.Image = Resources.volume_mute;
                btn_volum.OnHoverImage = Resources.volume_mute_hover;
            }
            else if (gunaTrackBar_Volume.Value < 50)
            {
                btn_volum.Image = Resources.volume_low;
                btn_volum.OnHoverImage = Resources.volume_low_hover;
            }
            else
            {
                btn_volum.Image = Resources.volume_high;
                btn_volum.OnHoverImage = Resources.volume_high_hover;
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            click_btn_play();
        }
        public void click_btn_play()
        {
            try
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    //timerSong.Enabled = false;
                    player.Ctlcontrols.pause();
                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    player.Ctlcontrols.currentPosition = currentTimePlay;
                    player.Ctlcontrols.play();
                    //timerSong.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Video bi loi nut play: " + ex.ToString());
            }
        }
        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (player.currentMedia != null)
                    setCurrentPosition(e.X, MediaTrackBar.Width);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void setCurrentPosition(int mousePosition, int progressBarWidth)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * mousePosition / progressBarWidth;
        }
        // volume
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            changeVolume(gunaTrackBar_Volume.Value);
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            changeVolume(gunaTrackBar_Volume.Value);
        }
        public int volumeNow = 100;
        private void gunaCircleButton_Volume_Click(object sender, EventArgs e)
        {
            changeMute();
        }
        public void changeMute()
        {
            if (player.settings.volume != 0)
            {
                player.settings.volume = 0;
                volumeNow = gunaTrackBar_Volume.Value;
                gunaTrackBar_Volume.Value = 0;
            }
            else
            {
                player.settings.volume = volumeNow;
                gunaTrackBar_Volume.Value = volumeNow;
            }
        }
        public void changeVolume(int n)
        {
            gunaTrackBar_Volume.Value = n;
            player.settings.volume = n;
        }
        // time song
        private void btn_giam_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTimePlay - timeSkip >= 0)
                    player.Ctlcontrols.currentPosition = currentTimePlay - timeSkip;
                else player.Ctlcontrols.currentPosition = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Video bi loi nut giam: " + ex.ToString());
            }

        }

        private void btn_tang_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTimePlay + timeSkip <= MediaTrackBar.Maximum)
                    player.Ctlcontrols.currentPosition = currentTimePlay + timeSkip;
                else player.Ctlcontrols.currentPosition = MediaTrackBar.Maximum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Video bi loi nut tang: " + ex.ToString());
            }
        }

    }
}
