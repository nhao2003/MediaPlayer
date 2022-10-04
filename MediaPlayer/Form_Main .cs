using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.Windows.Forms;

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
    }
}
