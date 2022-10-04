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

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        // làm sao gắn được data dô hai cái này là được
        String fileName;
        String filePath;

        //=============================================

        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        OpenFileDialog openFileDialog;
        public double currentTimePlay = 0.0;
        public MediaControl()
        {
            Player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            
            InitializeComponent();
            //Slider.Value = 0b0;
        }
        private void Player_PlayStateChange(int NewState)
        {
            //trangThai.Text = Player.status;
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
        }

        // chức năng thêm nhạc ở đây nè
        private void gunaCircleButton_Open_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ở đây lấy file name với path của bài nhạc nè
                filePath = openFileDialog.FileName;
                fileName = openFileDialog.SafeFileName;
                gunaLabel_SongName.Text = fileName;
                //=============================================
                currentTimePlay = 0.0;
               // timeSongEnd.Text = Player.currentMedia.duration.ToString();
            }
        }
        //============================================
        private void gunaCircleButton5_Click(object sender, EventArgs e)
        {

        }
        
        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            if (filePath == null) return;
            Player.URL = filePath;
            if (!timerSong.Enabled)
            {
                Player.controls.currentPosition = currentTimePlay;
                timerSong.Start();
                Player.controls.play();
            }
            else
            {
                Player.controls.stop();
                timerSong.Stop();
            }
            //if (Player.status.ToLower().Contains("playing"))
            //{
            //    timerSong.Stop();
            //    Player.controls.pause();
            //}
            //else
            //{
            //    timerSong.Start();
            //    Player.controls.play();
            //}
        }

        private void gunaTrackBar_Music_ValueChanged(object sender, EventArgs e)
        {
            Player.controls.currentPosition = Slider.Value;
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            timeSongEnd.Text = Player.currentMedia.duration.ToString();
            currentTimePlay = Player.controls.currentPosition;
            timeSongPlay.Text = Player.controls.currentPositionString;
            //timeSongPlay.Text = currentTimePlay.ToString();
            Slider.Value = (int)Player.controls.currentPosition;
        }

        // chỉnh âm thanh
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            //Player.settings.volume = Slider.Value;
            //gunaLabel_NameAthor.Text = Slider.Value.ToString();
        }
    }
}
