﻿using MediaPlayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class MusicRow : UserControl
    {
        private Media _media;
        private string filePath;
        public bool isPlayList = false;
        public Media Media
        {
            get
            {
                return _media;
            }
            set
            {
                _media = value;
                pic_Song.Image = _media.Image;
                label_NameSong.Text = _media.Title;
                label_Duration.Text = _media.DurationText;
                label_NameSinger.Text = _media.Artists;
            }
        }

        public MusicRow(Media media = null, bool isPlayList = false)
        {
            InitializeComponent();
            if(media != null)
            {
                Media = media;
            }
            this.isPlayList = isPlayList;
        }

        public void InitializeSongItem(Media initializeMedia)
        {
            pic_Song.Image = initializeMedia.Image;
            label_NameSong.Text = initializeMedia.Title;
            label_NameSinger.Text = initializeMedia.Artists;
            label_Duration.Text = initializeMedia.DurationText;
            filePath = initializeMedia.FilePath;
            _media = initializeMedia;
        }
        private bool isHover = false;
        public bool IsHover
        {
            get => isHover;
            set
            {
                isHover = value;
                if (value)
                {
                    panel_MusicRow.BaseColor = Color.FromArgb(40, 40, 40);
                }
                else
                {
                    panel_MusicRow.BaseColor = Color.Transparent;
                }
            }
        }
        public bool IsPlaying = false;
        private void MusicRow_MouseEnter(object sender, EventArgs e)
        {
            IsHover = true;
        }

        private void MusicRow_MouseLeave(object sender, EventArgs e)
        {
             IsHover = IsPlaying;
        }

        private void MusicRow_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu(_media);
                contextMenu.Play.Click += contextMenuPlay_click;
                contextMenu.Show(ToolStripDropDown.MousePosition);
                return;
            }
            if (isPlayList == false)
            {
                MediaHelpers.isPlayingPlaylist = false;
                Form_Main.Instance.ClassifyMedia(_media);
                Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
            }
            else
            {
                // this row is in play list
                Form_Main.Instance.ClassifyMedia(_media);
                Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
            }
        }

        private void contextMenuPlay_click(object sender, EventArgs e)
        {
            if(isPlayList == false)
            {
                MediaHelpers.isPlayingPlaylist = false;
                Form_Main.Instance.ClassifyMedia(_media);
                Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
            }
            else
            {
                // this row is in play list
                Form_Main.Instance.ClassifyMedia(_media);
                Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
            }
        }
    }
}
