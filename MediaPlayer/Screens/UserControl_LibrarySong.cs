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
using MediaPlayer.Items;
using WMPLib;
using System.Threading;

namespace MediaPlayer.Screens
{
    public partial class UserControl_LibrarySong : UserControl
    {
        public UserControl_LibrarySong()
        {
            InitializeComponent();
        }
        private string filepath;
        public delegate void PassDataBetweenForms(string filePath);
        static MediaControl mediaControl;
        public void InitializeSongItem(TagLib.File f, string filePath, int idx)
        {
            // gunaPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            // gunaElipsePanel1.AutoSize = true;
            gunaLabel2.Text = idx.ToString();
            // gunaPictureBox3.Image = Image.FromFile("ImgSource\\forest.jpg");
            gunaLabel1.Text = f.Tag.Title + Environment.NewLine + String.Join(", ", f.Tag.AlbumArtists);
            gunaLabel4.Text = f.Tag.Album;
            // gunaPictureBox2.Image = Image.FromFile("ImgSource\\heart.png");
            gunaLabel5.Text = DateTime.Now.ToShortDateString();
            gunaLabel6.Text = f.Properties.Duration.ToString().Substring(3, 5);
            this.filepath = filePath;
            if (idx % 2 == 0)
            {
                gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(162, 220, 188);
            }
            else
            {
                gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(192, 255, 192);
            }

        }
        public void InitializeCategoryBar()
        {
            gunaElipsePanel1.AutoSize = true;
            gunaLabel2.Text = "#";
            gunaLabel1.Text = "Title and Author";
            gunaLabel4.Text = "Album";
            gunaLabel5.Text = "Date added";
            gunaLabel6.Text = "Duration";
        }
        

        public void GetMediaControl(MediaControl control)
        {
            mediaControl = control;
        }

        private void gunaElipsePanel1_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }
    }
}
