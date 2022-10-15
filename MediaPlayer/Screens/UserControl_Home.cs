using MediaPlayer.Items;
using ns2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Home : UserControl
    {
        DisplayMediaItems RecentMusic = new DisplayMediaItems()
        {
            Dock = DockStyle.Bottom,
        };
        DisplayMediaItems RecentVideo = new DisplayMediaItems()
        {
            Dock = DockStyle.Bottom,
        };
        public UserControl_Home()
        {
            
            InitializeComponent();
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            RecentVideo.Parent = panel_Home;
            panel_Home.Controls.Add(RecentVideo);
            panel_Home.Controls.Add(RecentMusic);
            //RecentMusic.Show();
            //panel_Home.

        }

        private void panel_Home_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Home.VerticalScroll.Value += 10;
        }
    }
}
