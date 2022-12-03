using MediaPlayer.Models;
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
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            player.uiMode = "none";
            timerSong.Enabled = true;
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;
        }
        //string path = null;
        public double timeSkip = 10;
        public double currentTimePlay = 0.0;
        //string filenames;

        public void getPathOfSong(string path)
        {
            try
            {
                player.URL = path;

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
            catch(Exception e)
            {
                MessageBox.Show("Video bi loi: " + e.ToString());
            }
        }

        // timer 
        private void timer_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaTrackBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                MediaTrackBar.Value = (int)player.Ctlcontrols.currentPosition;
                timeSongPlay.Text = getCurrentPositionStringSong();
                timeSongEnd.Text = getDurationStringSong();
                currentTimePlay = player.Ctlcontrols.currentPosition;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
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

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    timerSong.Enabled = false;
                    player.Ctlcontrols.pause();
                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    player.Ctlcontrols.currentPosition = currentTimePlay;
                    player.Ctlcontrols.play();
                    timerSong.Enabled = true;
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
                    player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / MediaTrackBar.Width;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            player.settings.volume = gunaTrackBar_Volume.Value;
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            player.settings.volume = gunaTrackBar_Volume.Value;
        }
        public int volumeNow = 50;
        private void gunaCircleButton_Volume_Click(object sender, EventArgs e)
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
                if(currentTimePlay + timeSkip <= MediaTrackBar.Maximum)
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
