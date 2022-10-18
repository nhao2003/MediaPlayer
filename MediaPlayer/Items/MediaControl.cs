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

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        public delegate void pessTheButton(object sender, EventArgs e);
        public delegate void scrollTheTrackBar(object sender, EventArgs e, int value, int progressBarWidth);
        public delegate int getIntData();
        public delegate string getStringData();
        public delegate WMPLib.WMPPlayState getStatus();
        // xu ly su kien
        public pessTheButton playSong;
        public pessTheButton nextSong;
        public pessTheButton previewSong;
        public scrollTheTrackBar setCurrentPosition;
        public scrollTheTrackBar setVolume;
        // lay data theo timer
        public getIntData getDurationSong;
        public getIntData getCurrentPositionSong;
        public getStringData getDurationStringSong;
        public getStringData getCurrentPositionStringSong;
        public getStatus getStatusSong;
        
        public MediaControl()
        {
            InitializeComponent();
        }
        public void getPathOfSong(string path)
        {
            TagLib.File file = TagLib.File.Create(path);
            lb_SongName.Text = (file.Tag.Title);
            lb_NameAthor.Text = (file.Tag.Album);
            try
            {
                var ff = TagLib.File.Create(path);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                songImage.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {

            }
        }
        
        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            if(playSong != null)
            {
                playSong(sender, e);
            }
                
        }

        private void gunaCircleButton_next_Click(object sender, EventArgs e)
        {
            if(nextSong != null)
            {
                nextSong(sender, e);
            }
        }

        private void gunaCircleButton_prev_Click(object sender, EventArgs e)
        {
            if(previewSong != null)
            {
                previewSong(sender, e);
            }
        }

        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(setCurrentPosition != null)
            {
                setCurrentPosition(sender, e, e.X, MediaTrackBar.Width);
            }
        }
        private void MediaTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (setCurrentPosition != null)
            {
                //setCurrentPosition(sender, e, e.OldValue, MediaTrackBar.Width);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (getStatusSong() == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaTrackBar.Maximum = getDurationSong();
                MediaTrackBar.Value = getCurrentPositionSong();
                timeSongStart.Text = getCurrentPositionStringSong();
                timeSongEnd.Text = getDurationStringSong();
            }
                
        }

        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            if(setVolume != null)
            {
                setVolume(sender, e, Track_volume.Value, Track_volume.Width);
                label_volume.Text = Track_volume.Value.ToString() + "%";
            }
        }
    }
}
