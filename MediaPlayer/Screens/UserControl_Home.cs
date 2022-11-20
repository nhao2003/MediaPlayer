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
using MediaPlayer.Models;
using TagLib;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Home : UserControl
    {
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;

        DisplayMediaItems RecentMusic = new DisplayMediaItems("Recent Music", MediaHelpers.listSongs)
        {
            Dock = DockStyle.Bottom,
            
        };

        private DisplayMediaItems RecentVideo = new DisplayMediaItems("Recent Video", MediaHelpers.listVideos)
        {
            Dock = DockStyle.Bottom,
        };
        public UserControl_Home()
        {
            InitializeComponent();
            RecentVideo.Parent = panel_Home;
            RecentMusic.sendPath = new DisplayMediaItems.Send(sendChildPathMusic);
            RecentVideo.sendPath = new DisplayMediaItems.Send(sendChildPathVideo);
            panel_Home.Controls.Add(RecentMusic);
            panel_Home.Controls.Add(RecentVideo);
            suggestBar1.sendPath = new SuggestBar.Send(sendChildPathMusic);
        }
        public void sendChildPathMusic(String s)
        {
            sendPath(s, MediaTypes.Audio);
        }
        public void sendChildPathVideo(String s)
        {
            sendPath(s, MediaTypes.Video);
        }

        private void panel_Home_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Home.VerticalScroll.Value += 10;
        }
    }
}
