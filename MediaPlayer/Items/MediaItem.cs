﻿using MediaPlayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class MediaItem : UserControl
    {
        private Media _media = new Media();
        public MediaItem(Media media)
        {
            this._media = media;
            InitializeComponent();
            label_NameSong.Text = media.Title;
            label_Author.Text = media.ArtistsString;
            pic_SongPic.Image = media.Image;

        }

        private void MediaItem_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu(new Media(_media.FilePath));
                contextMenu.Show(ToolStripDropDown.MousePosition);
                return;
            }
            MediaHelpers.isPlayingPlaylist = false;
            Form_Main.Instance.ClassifyMedia(_media);
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
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
