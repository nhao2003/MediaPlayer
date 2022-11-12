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
        public Form_Main()
        {
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
        // khai bao cac delegate va thuoc tinh
        private void Form_Main_Load(object sender, EventArgs e)
        {
            userControl_Home1.sendPath = new UserControl_Home.Send(sendChildPath);
        }

        private void gunaButton_Home_Click_1(object sender, EventArgs e)
        {
            MainPages.SetPage(0);
        }

        private void gunaButton_Search_Click_1(object sender, EventArgs e)
        {
            MainPages.SetPage(1);
        }

        private void gunaButton_Music_Click_1(object sender, EventArgs e)
        {
            MainPages.SetPage(2);
        }

        private void gunaButton_Video_Click_1(object sender, EventArgs e)
        {
            MainPages.SetPage(3);
        }

        private void gunaButton_Library_Click_1(object sender, EventArgs e)
        {
            MainPages.SetPage(4);
        }

        private void gunaButton_Settings_Click_1(object sender, EventArgs e)
        {
            MainPages.SetPage(5);
        }
    }
}
