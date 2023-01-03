using Guna.UI.WinForms;
using MediaPlayer.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class MediaContextMenu : GunaContextMenuStrip
    {
        private Media media;
        public MediaContextMenu(Media media)
        {
            this.media = media;
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
        }

        private void Item_AddToPlayList(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int index = MediaHelpers.AllPlayList.FindIndex(fi => fi.PlayListID == (string)item.Tag);
            MediaHelpers.AllPlayList[index].AddMedia(media);
        }


        private void NewPlaylist_Click(object sender, System.EventArgs e)
        {
            AddPlayList addPlayList = new AddPlayList();
            addPlayList.ShowDialog();
        }

        private void FavoriteList_Click(object sender, System.EventArgs e)
        {
            MediaHelpers.FavoriteList.ListMedia.Add(media);
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
