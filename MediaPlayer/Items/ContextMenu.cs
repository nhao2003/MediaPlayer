﻿using Guna.UI.WinForms;
using MediaPlayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class ContextMenu : GunaContextMenuStrip
    {
        private Playlist playlist;
        private Media media;
        public ContextMenu(Playlist playlist)
        {
            this.media = null;
            this.playlist = playlist;
            InitializeComponent();
            InitializeAddtoDrop();
        }
        public ContextMenu(Media media, Playlist playlist = null)
        {
            this.media = media;
            this.playlist = playlist;
            InitializeComponent();
            InitializeAddtoDrop();
        }

        private void InitializeAddtoDrop()
        {
            MediaHelpers.AllPlayList.ForEach(pl =>
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = pl.PlayListName;
                item.Tag = pl.PlayListID;
                item.Click += Item_AddToPlayList;
                item.BackColor = Color.FromArgb(24, 24, 24);
                item.ForeColor = Color.White;
                AddTo.DropDownItems.Add(item);
            });
            NewPlaylist.Click+= NewPlaylist_Click;
            Delete.Click += Btn_Delete_Click;
            Play.Click+= Play_Click;
            PlayNext.Click+= PlayNext_Click;
            PlayQueue.Click+= PlayQueue_Click;
            FavoriteList.Click+= FavoriteList_Click;
            Rename.Click += Rename_Click;
            if (playlist == null)
            {
                Rename.Visible= false;
                Rename.Enabled= false;
            }
            if(media != null && playlist == null)
            {
                Delete.Visible= false;
                Delete.Enabled= false;
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if(media== null)
            {
                AddPlayList addPlayList = new AddPlayList(playlist);
                addPlayList.ShowDialog();
                Form_Main.Instance.userControl_Library.UpdateScreen();
            }
            
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if(media == null)
            {
                MediaHelpers.DeletePlayList(playlist);
                Form_Main.Instance.userControl_Library.UpdateScreen();
            }
            else
            {

            }
        }

        private void Item_AddToPlayList(object sender, EventArgs e)
        {
            if(media != null)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                int index = MediaHelpers.AllPlayList.FindIndex(fi => fi.PlayListID == (string)item.Tag);
                MediaHelpers.AllPlayList[index].AddMedia(media);
            }
            else
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                int index = MediaHelpers.AllPlayList.FindIndex(fi => fi.PlayListID == (string)item.Tag);
                MediaHelpers.AllPlayList[index].AddRangeMedia(playlist.ListMedia);
            }
        }


        private void NewPlaylist_Click(object sender, System.EventArgs e)
        {
            AddPlayList addPlayList = new AddPlayList();
            addPlayList.ShowDialog();
            Form_Main.Instance.userControl_Library.UpdateScreen();
        }

        private void FavoriteList_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PlayQueue_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PlayNext_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Play_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}