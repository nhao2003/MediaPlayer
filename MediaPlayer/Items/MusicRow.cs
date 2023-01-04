﻿using MediaPlayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class MusicRow : UserControl
    {
        private Media _media;
        public delegate void PassDataBetweenForms(Media media);
        static MediaControl mediaControl;
        private string filePath;
        public void GetMediaControl(MediaControl control)
        {
            mediaControl = control;
        }
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

        public MusicRow()
        {
            InitializeComponent();
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

        private void MusicRow_MouseEnter(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void MusicRow_MouseLeave(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.Transparent;
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
            MediaHelpers.isPlayingPlaylist = false;
            Form_Main.Instance.ClassifyMedia(_media);
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
        }

        private void contextMenuPlay_click(object sender, EventArgs e)
        {
            MediaHelpers.isPlayingPlaylist = false;
            Form_Main.Instance.ClassifyMedia(_media);
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
        }
    }
}
