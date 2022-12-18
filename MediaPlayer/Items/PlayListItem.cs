using ns2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
using TagLib;

namespace MediaPlayer.Items
{
    public partial class PlayListItem : UserControl
    {
        private Playlist playlist;
        public Playlist Playlist => playlist;
        public PlayListItem(Playlist playlist)
        {
            this.playlist = playlist;
            InitializeComponent();
            label_NameSong.Text = playlist.PlayListName;
            label_Author.Text = $@"{playlist.ListMedia.Count} items";
            pic_SongPic.Image = this.playlist.BackroundImage;
        }
        private void MediaItem_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                return;
            } 
            Form_Main.Instance.DisplayPlayList(playlist);
        }

        private void panel_MediaItem_MouseEnter(object sender, EventArgs e)
        {
            panel_MediaItem.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void panel_MediaItem_MouseHover(object sender, EventArgs e)
        {
            panel_MediaItem.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void label_Author_MouseLeave(object sender, EventArgs e)
        {
            panel_MediaItem.BaseColor = Color.FromArgb(24, 24, 24);
        }

    }
}
