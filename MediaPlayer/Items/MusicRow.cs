using MediaPlayer.Models;
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
using System.Xml.Linq;

namespace MediaPlayer.Items
{
    public partial class MusicRow : UserControl
    {
        public delegate void Send(string path, Image image);
        public Send sendPath;
        private Media _media;
        public Media Media
        {
            get
            {
                return _media;
            }
            set
            {
                _media = value;
                pic_Song.Image = _media.Image;
                label_NameSong.Text = _media.Title;
                label_Duration.Text = _media.DurationText;
                label_NameSinger.Text = _media.Artists;
            }
        }

        public MusicRow()
        {
            InitializeComponent();
            var request = WebRequest.Create("https://data.chiasenhac.com/data/cover/160/159824.jpg");
        }

        public static void setInfo()
        {

        }
        private void MusicRow_MouseEnter(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void MusicRow_MouseLeave(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.Transparent;
        }

        private void MusicRow_Click(object sender, EventArgs e)
        {
            sendPath(_media.FilePath, _media.Image);
        }
    }
}
