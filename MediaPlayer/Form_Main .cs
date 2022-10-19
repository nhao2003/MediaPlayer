using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.Windows.Forms;
using System.Drawing;

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
            indicater.Top = gunaButton_Home.Top;
            MainPages.SetPage(0);
        }

        private void gunaButton_Search_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Search.Top;
            MainPages.SetPage(1);
        }

        private void gunaButton_Music_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Music.Top;
            MainPages.SetPage(2);
        }

        private void gunaButton_Video_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Video.Top;
            MainPages.SetPage(3);
        }

        private void gunaButton_Library_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Library.Top;
            MainPages.SetPage(4);

        }

        private void gunaButton_Settings_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Settings.Top;
            MainPages.SetPage(5);
        }

        private void userControl_Library1_Load(object sender, EventArgs e)
        {

        }
    }
}
