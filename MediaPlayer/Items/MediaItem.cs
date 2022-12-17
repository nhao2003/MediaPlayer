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
    public partial class MediaItem : UserControl
    {
        private Media media;
        public MediaItem(Media media)
        {
            this.media = media;
            InitializeComponent();
            contextMenu.Tag = media;
            label_NameSong.Text = media.Title;
            label_Author.Text = media.Artists;
            pic_SongPic.Image = media.Image;
            contextMenu.Play.Click += contextMenuPlay_click;
        }

        private void contextMenuPlay_click(object sender, EventArgs e)
        {
            Form_Main.Instance.ClassifyMedia(media.FilePath, media.MediaTypes);
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(media.Image);
        }
        private void MediaItem_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                contextMenu.Show(ToolStripDropDown.MousePosition);
                return;
            }
            Form_Main.Instance.ClassifyMedia(media.FilePath, media.MediaTypes);
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(media.Image);
        }

        private void panel_MediaItem_MouseEnter(object sender, EventArgs e)
        {
            this.panel_MediaItem.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void panel_MediaItem_MouseHover(object sender, EventArgs e)
        {
            this.panel_MediaItem.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void label_Author_MouseLeave(object sender, EventArgs e)
        {
            this.panel_MediaItem.BaseColor = Color.FromArgb(24, 24, 24);
        }

    }
}
