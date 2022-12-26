using MediaPlayer.Items;
using MediaPlayer.Models;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Home : UserControl
    {

        DisplayMediaItems RecentMusic = new DisplayMediaItems("Recent Music", MediaHelpers.listSongs, MediaTypes.Audio)
        {
            Dock = DockStyle.Bottom,

        };

        private DisplayMediaItems RecentVideo = new DisplayMediaItems("Recent Video", MediaHelpers.listVideos, MediaTypes.Video)
        {
            Dock = DockStyle.Bottom,
        };
        public UserControl_Home()
        {
            InitializeComponent();
            RecentVideo.Parent = panel_Home;
            panel_Home.Controls.Add(RecentMusic);
            panel_Home.Controls.Add(RecentVideo);
        }

        private void panel_Home_Scroll(object sender, ScrollEventArgs e)
        {
            panel_Home.VerticalScroll.Value += 10;
        }
    }
}
