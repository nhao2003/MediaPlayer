using MediaPlayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            label_Name.Text = playlist.PlayListName;
            label_DateCreate.Text = playlist.DateCreated.ToString("dd/MM/yyyy");
            pic_SongPic.Image = this.playlist.BackGroundImage;
        }
        private void Playlist_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu(playlist);
                contextMenu.Show(ToolStripDropDown.MousePosition);
            }else
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
