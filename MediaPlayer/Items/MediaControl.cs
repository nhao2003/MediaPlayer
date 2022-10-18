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

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        // làm sao gắn được data dô hai cái này là được
        String fileName;
        String filePath;
        public MediaControl(String fileName, String filePath) 
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }
        //=============================================

        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        OpenFileDialog openFileDialog;
        public double currentTimePlay = 0.0;
        public bool begin = false;

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
                Player.URL = filePath;
                Player.controls.stop();
                // chọn bài hát thì trả về 0
                currentTimePlay = 0.0;
                timeSongPlay.Text = "00:00";
                MediaTrackBar.Value = (int)Player.controls.currentPosition;
            }
        }
        
        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            if (filePath == null) return;
            //MediaTrackBar.Maximum = Convert.ToInt32(Player.currentMedia.duration);
            if (!timerSong.Enabled)
            {
                Player.controls.currentPosition = currentTimePlay;
                timerSong.Start();
                Player.controls.play();
            }
            else
            {
                //gunaCircleButton_Play.OnHoverImage = Image.FromFile("pause.png");
                Player.controls.stop();
                timerSong.Stop();
            }
        }

        private void gunaTrackBar_Music_ValueChanged(object sender, EventArgs e)
        {
            Player.controls.currentPosition = MediaTrackBar.Value;
        }

        public String convert(int n)
        {
            return n > 9 ? "" + n : "0" + n;
        }
        private void timerSong_Tick(object sender, EventArgs e)
        {
            timeSongEnd.Text = convert((int)Player.currentMedia.duration / 100) + ":" + convert((int)Player.currentMedia.duration % 100);
            currentTimePlay = Player.controls.currentPosition;
            timeSongPlay.Text = Player.controls.currentPositionString;
            //timeSongPlay.Text = currentTimePlay.ToString();
            MediaTrackBar.Value = (int)Player.controls.currentPosition;

        }

        // chỉnh âm thanh
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            //Player.settings.volume = Slider.Value;
            //gunaLabel_NameAthor.Text = Slider.Value.ToString();
        }

        private void MediaTrackBar_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
