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
using TagLib;
using static ns6.WinApi;

namespace MediaPlayer.Items
{
    public partial class DisplayMediaItems : UserControl
    {
        private List<Media> listSongs;
        private MediaTypes mediaTypes;
        public DisplayMediaItems()
        {
            InitializeComponent();
        }

        public DisplayMediaItems(string title, List<Media> listSongs, MediaTypes mediaTypes)
        {
            InitializeComponent();
            label_Title.Text = title;
            this.listSongs = listSongs;
            this.mediaTypes = mediaTypes;

            MediaItem mediaItem;
            int x = 10;
            for (int i = 0; i < listSongs.Count && i < 8; i++)
            {
                mediaItem = new MediaItem(listSongs[i])
                {
                    Location = new Point(x, 0),
                };
                x += 215;
                panel_Items.Controls.Add(mediaItem);
            }
            panel_Items.AutoScroll = false;
            DoubleBuffered = true;
        }

        private void label_SeeAll_Click(object sender, EventArgs e)
        {
            if(mediaTypes == MediaTypes.Audio)
            {
                Form_Main.Instance.ChangePage(2);
            }
            else Form_Main.Instance.ChangePage(3);
        }
    }
}
