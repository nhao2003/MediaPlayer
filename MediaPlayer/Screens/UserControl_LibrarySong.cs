using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Widgets;
using MediaPlayer.Screens;
using MediaPlayer.Models;

namespace MediaPlayer.Screens
{
    public partial class UserControl_LibrarySong : UserControl
    {
        public UserControl_LibrarySong()
        {
            InitializeComponent();
        }
        public void InitializeSongItem(TagLib.File f, int idx)
        {
            gunaPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            gunaPanel1.AutoSize = true;
            gunaLabel1.Text = idx.ToString();
            gunaPictureBox1.Image = Image.FromFile(@"C:\Users\tuanb\source\repos\LibraryBranch\MediaPlayer\MediaPlayer\Resources\921f72eb0b0a345c3ffe1e83283037ab.png");
            gunaTextBox1.Text = f.Tag.Title + Environment.NewLine + String.Join(", ", f.Tag.AlbumArtists);
            gunaTextBox4.Text = f.Tag.Album;
            gunaPictureBox2.Image = Image.FromFile(@"C:\Users\tuanb\source\repos\LibraryBranch\MediaPlayer\MediaPlayer\Resources\heart.png");
            gunaTextBox3.Text = DateTime.Now.ToShortDateString();
            gunaTextBox2.Text = f.Properties.Duration.ToString().Substring(3, 5);
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
