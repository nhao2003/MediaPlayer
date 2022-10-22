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

namespace MediaPlayer
{
    public partial class Form_Main : Form
    {
        // duong dan cua video voi music
        public string musicFolderPath = "C:\\users\\Administrator\\Music";
        public string videoFolderPath = "C:\\users\\Administrator\\Videos";
        // theme va color
        public string theme = "Light";
        public string color = "Green";

        public Form_Main()
        {
            ListSong.FetchListSong();
            InitializeComponent();
        }

        private void userControl_Home1_Load(object sender, EventArgs e)
        {
            
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

        private void mediaControl_Load(object sender, EventArgs e)
        {
            
        }
        // gui data tu item song
        public delegate void Send(string path);
        public Send sendPath;
        
        public void sendChildPath(String s)
        {
            mediaControl.getPathOfSong(s);
        }
        // lay data tu setting screen
        public void getMusicFolderPath(string path)
        {
            musicFolderPath = path;
        }
        public void getVideoFolderPath(string path)
        {
            videoFolderPath = path;
        }
        public void getTheme(string theme)
        {
            this.theme = theme;
        }
        public void getColor(string color)
        {
            this.color = color;
        }
        // khai bao cac delegate va thuoc tinh
        private void Form_Main_Load(object sender, EventArgs e)
        {
            userControl_Home1.sendPath = new UserControl_Home.Send(sendChildPath);

            userControl_Settings1.sendMusicFolderPath = new UserControl_Settings.sendStringData(getMusicFolderPath);
            userControl_Settings1.sendVideoFolderPath = new UserControl_Settings.sendStringData(getVideoFolderPath);
            userControl_Settings1.sendTheme = new UserControl_Settings.sendStringData(getTheme);
            userControl_Settings1.sendColor = new UserControl_Settings.sendStringData(getColor);
        }
    }
}
