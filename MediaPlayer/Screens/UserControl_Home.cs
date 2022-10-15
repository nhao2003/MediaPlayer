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
            Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left
        };
        DisplayMediaItems RecentVideo = new DisplayMediaItems()
        {
            Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left,
            Location = new Point(0, 350)
        };
        public UserControl_Home()
        {
            
            InitializeComponent();
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            RecentMusic.Parent = panel_Home;
            RecentVideo.Parent = panel_Home;
            panel_Home.Controls.Add(RecentMusic);
            panel_Home.Controls.Add(RecentVideo);
            //RecentMusic.Show();
            //panel_Home.

        }

        private void panel_Home_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Home.VerticalScroll.Value += 10;
        }
    }
}
