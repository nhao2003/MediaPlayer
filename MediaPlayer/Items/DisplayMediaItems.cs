using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
using static ns6.WinApi;

namespace MediaPlayer.Items
{
    public partial class DisplayMediaItems : UserControl
    {
        public delegate void Send(string path, Image image);
        public Send sendPath;
        private List<Media> listSongs;
        public DisplayMediaItems()
        {
            InitializeComponent();
        }

        public DisplayMediaItems(String title, List<Media> listSongs)
        {
            InitializeComponent();
            label_Title.Text = title;
            this.listSongs = listSongs;

            MediaItem mediaItem;
            int x = 10;
            for (int i = 0; i < listSongs.Count && i < 8; i++)
            {
                mediaItem = new MediaItem(listSongs[i])
                {
                    Location = new Point(x, 0),
                    sendPath = new MediaItem.Send(sendChildPath)
                };
                x += 215;
                panel_Items.Controls.Add(mediaItem);
            }
            panel_Items.AutoScroll = false;
            DoubleBuffered = true;
        }
        private void DisplayMediaItems_Load(object sender, EventArgs e)
        {
            
        }
        public void sendChildPath(String s, Image image)
        {
            sendPath(s, image);
        }
    }
}
