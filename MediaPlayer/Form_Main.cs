using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form_Main : Form
    {
        UserControl_Home userControl_Home = new UserControl_Home() { Dock = DockStyle.Fill};
        UserControl_Search userControl_Search = new UserControl_Search { Dock = DockStyle.Fill };
        UserControl_Music userControl_Music = new UserControl_Music() { Dock = DockStyle.Fill };
        UserControl_Video userControl_Video = new UserControl_Video() { Dock = DockStyle.Fill };
        UserControl_Library userControl_Library = new UserControl_Library() { Dock = DockStyle.Fill };
        UserControl_Settings userControl_Settings = new UserControl_Settings() { Dock = DockStyle.Fill };
        public Form_Main()
        {
            InitializeComponent();
            this.panel_base.Controls.Add(userControl_Home);
            this.panel_base.Controls.Add(userControl_Search);
            this.panel_base.Controls.Add(userControl_Settings);
            this.panel_base.Controls.Add(userControl_Music);
            this.panel_base.Controls.Add(userControl_Video);
            this.panel_base.Controls.Add(userControl_Library);
            userControl_Home.Show();
            userControl_Search.Show();
            userControl_Music.Show();
            userControl_Video.Show();
            userControl_Library.Show();
            userControl_Settings.Show();
        }

        private void gunaPanel_MusicControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_base_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton_Home_Click(object sender, EventArgs e)
        {
            userControl_Home.BringToFront();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            gunaButton_Home_Click(sender, e);
        }

        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton_Search_Click(object sender, EventArgs e)
        {
            userControl_Search.BringToFront();
        }

        private void gunaButton_Music_Click(object sender, EventArgs e)
        {
            userControl_Music.BringToFront();
        }

        private void gunaButton_Video_Click(object sender, EventArgs e)
        {
            userControl_Video.BringToFront();
        }

        private void gunaButton_Library_Click(object sender, EventArgs e)
        {
            userControl_Library.BringToFront();
        }

        private void gunaButton_Settings_Click(object sender, EventArgs e)
        {
            userControl_Settings.BringToFront();
        }

        private void panel_base_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void mediaControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
