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

namespace MediaPlayer.Items
{
    public partial class MusicRow : UserControl
    {
        public MusicRow()
        {
            InitializeComponent();
            var request = WebRequest.Create("https://data.chiasenhac.com/data/cover/160/159824.jpg");
            try
            {
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pic_Song.Image = Bitmap.FromStream(stream);
                }

                pic_Song.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {

            }
        }

        private void MusicRow_MouseEnter(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(165, 220, 188);
        }

        private void MusicRow_MouseLeave(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(216, 243, 220);
        }

        private void MusicRow_Click(object sender, EventArgs e)
        {
            PlayMedia.Play("C:\\Users\\haosi\\Music\\Head In the Clouds - Hayd.mp3");
        }
    }
}
