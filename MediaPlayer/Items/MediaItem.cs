using ns2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;

namespace MediaPlayer.Items
{
    public partial class MediaItem : UserControl
    {
        public delegate void Send(string path);
        public Send sendPath;
        private Song song;
        public MediaItem(Song song)
        {
            InitializeComponent();
            this.song = song;
            label_NameSong.Text = song.Title;
            label_Author.Text = song.Artists;
            pic_SongPic.Image = song.Image;
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            sendPath(song.FilePath);
        }
    }
}
