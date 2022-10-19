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

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        public MediaControl()
        {
            InitializeComponent();
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
        }
        public string path = null;
        private void gunaCircleButton_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                getPathOfSong(path);
            }
        }

        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            try
            {
                if (path != null)
                    PlayMedia.setURL(path);
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
            }
        }

        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            PlayMedia.setCurrentPosition(e.X, MediaTrackBar.Width);
        }

        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            PlayMedia.setVolume(gunaTrackBar_Volume.Value);
        }
    }
}
