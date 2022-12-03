using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using WMPLib;
using System.Threading;
using System.Threading.Tasks;
using MediaPlayer.Models;
using TagLib;

namespace MediaPlayer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private void gunaButton_Home_Click(object sender, EventArgs e)
        {
            MainPages.SetPage(0);
        }

        private void gunaButton_Search_Click(object sender, EventArgs e)
        {
            MainPages.SetPage(1);
        }

        private void gunaButton_Music_Click(object sender, EventArgs e)
        {
            MainPages.SetPage(2);
        }

        private void gunaButton_Video_Click(object sender, EventArgs e)
        {
            MainPages.SetPage(3);
        }

        private void gunaButton_Library_Click(object sender, EventArgs e)
        {
            MainPages.SetPage(4);

        }

        private void gunaButton_Settings_Click(object sender, EventArgs e)
        {
            MainPages.SetPage(5);
        }
        // gui data tu item song
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;


        public void sendChildPath(String s, MediaTypes mediaTypes)
        {
            if (mediaTypes == MediaTypes.Audio) mediaControl.getPathOfSong(s);
            else
            {
                mediaControl.pauseCurrentPlayer();
                VideoPlayer videoScreen = new VideoPlayer();
                videoScreen.Show();
                videoScreen.getPathOfSong(s);
            }
            
        }
        public void rebuildHome()
        {
            this.tabPage_Home.Controls.Remove(this.userControl_Home1);
            userControl_Home1 = new UserControl_Home()
            {
                Dock = DockStyle.Fill,
            };
            userControl_Home1.sendPath = new UserControl_Home.Send(sendChildPath);
            this.tabPage_Home.Controls.Add(this.userControl_Home1);
        }
        // khai bao cac delegate va thuoc tinh
        private void Form_Main_Load(object sender, EventArgs e)
        {
            userControl_Home1.sendPath = new UserControl_Home.Send(sendChildPath);
            userControl_Settings1.rebuild = new UserControl_Settings.Rebuild(rebuildHome);
        }
    }
}
