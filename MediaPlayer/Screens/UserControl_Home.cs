using MediaPlayer.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Home : UserControl
    {
        DisplayMediaItems RecentMusic = new DisplayMediaItems();
        DisplayMediaItems RecentVideo = new DisplayMediaItems();
        public UserControl_Home()
        {
            InitializeComponent();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel_Recent_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            flowLayoutPanel_Home.Controls.Add(RecentMusic);
            flowLayoutPanel_Home.Controls.Add(RecentVideo);
        }

        private void flowLayoutPanel_Recent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel_Home_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanel_Home_Resize(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Home_Resize(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Home_SizeChanged(object sender, EventArgs e)
        {
            int width = flowLayoutPanel_Home.Width - 30;
            RecentMusic.Width = width;
            RecentVideo.Width = width;
        }

        private void gunaLabel_Title_Click(object sender, EventArgs e)
        {

        }
    }
}
