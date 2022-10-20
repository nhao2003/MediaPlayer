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
        private String Id;
        private String songTitle;
        private String songAuthor;
        private Image songImage;
        private string path;
        public MediaItem(string path)
        {
            InitializeComponent();
            var request = WebRequest.Create("https://i.scdn.co/image/ab67616d00001e02771323ba8f7fe1d93fe094ed");
            try
            {
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pic_SongPic.Image = Bitmap.FromStream(stream);
                }

                pic_SongPic.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch
            {

            }

            this.path = path;
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            PlayMedia.Play(path);
        }
    }
}
