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
    public partial class MediaPanel : UserControl
    {
        public MediaPanel()
        {
            InitializeComponent();
        }
        private string filepath;
        public delegate void PassDataBetweenForms(string filePath);
        static MediaControl mediaControl;
        public void InitializeSongItem(TagLib.File f, string filePath, int idx)
        {
            // gunaPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            gunaPanel1.AutoSize = true;
            gunaLabel1.Text = idx.ToString();
            //gunaPictureBox1.Image = Image.FromFile("ImgSource\\forest.jpg");
            gunaTextBox1.Text = f.Tag.Title + Environment.NewLine + String.Join(", ", f.Tag.AlbumArtists);
            gunaTextBox4.Text = f.Tag.Album;
            //gunaPictureBox2.Image = Image.FromFile("ImgSource\\heart.png");
            gunaTextBox3.Text = DateTime.Now.ToShortDateString();
            gunaTextBox2.Text = f.Properties.Duration.ToString().Substring(3, 5);
            this.filepath = filePath;
        }
        public void InitializeCategoryBar()
        {
            gunaPanel1.AutoSize = true;
            gunaLabel1.Text = "#";
            gunaTextBox1.Text = "Title and Author";
            gunaTextBox4.Text = "Album";
            gunaTextBox3.Text = "Date added";
            gunaTextBox2.Text = "Duration";
        }

        public void GetMediaControl(MediaControl control)
        {
            mediaControl = control;
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaTextBox4_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaTextBox3_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaTextBox2_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }

        private void gunaPanel1_Click(object sender, EventArgs e)
        {
            PassDataBetweenForms datasend = new PassDataBetweenForms(mediaControl.transferDataFromLib);
            datasend(filepath);
        }
    }
}
