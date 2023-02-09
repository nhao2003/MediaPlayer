using Guna.UI.WinForms;
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
        public bool isDeletedPlaylist = false;
        public ContextMenu(Playlist playlist)
        {
            this.media = null;
            this.playlist = playlist;
            InitializeComponent();
            InitializeAddtoDrop();
        }
        public ContextMenu(Media media)
        {
            this.media = media;
            this.playlist = MediaHelpers.AllPlayList.Find(x => x.PlayListID == media.PlaylistID);
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
            NewPlaylist.Click += NewPlaylist_Click;
            Delete.Click += Btn_Delete_Click;
            Play.Click += Play_Click;
            PlayNext.Click += PlayNext_Click;
            PlayQueue.Click += PlayQueue_Click;
            Rename.Click += Rename_Click;
            if (playlist == null)
            {
                Rename.Visible = false;
                Rename.Enabled = false;
            }
            if (media != null && playlist == null)
            {
                Delete.Visible = false;
                Delete.Enabled = false;
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (media == null)
            {
                AddPlayList addPlayList = new AddPlayList(playlist);
                addPlayList.ShowDialog();
                Form_Main.Instance.userControl_Library.UpdateScreen();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (media == null)
            {
                MediaHelpers.DeletePlayList(playlist);
                Form_Main.Instance.userControl_Library.UpdateScreen();
                isDeletedPlaylist = true;
            }
            else if (media != null && playlist != null)
            {
                MediaHelpers.DeleteMediaFromPlaylist(media.FilePath, playlist.PlayListID);
                Form_Main.Instance.userControl_PlayList.DisplayMediaItems();
            }
            
        }

        private void Item_AddToPlayList(object sender, EventArgs e)
        {
            if (media != null)
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
            int index = MediaHelpers.AllPlayList.FindIndex(fi => fi.PlayListID == (addPlayList.Tag as Playlist).PlayListID);
            if (media != null)
            {
                if (media.MediaTypes != TagLib.MediaTypes.Audio) return;
                if(index != -1)
                MediaHelpers.AllPlayList[index].AddMedia(media);
            }
            else
            {
                MediaHelpers.AllPlayList[index].AddRangeMedia(playlist.ListMedia);
            }
            Form_Main.Instance.userControl_Library.UpdateScreen();
        }
        /// <summary>
        /// add to the end of the queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void PlayQueue_Click(object sender, System.EventArgs e)
        {
            if (media != null)
            {
                MediaHelpers.AddToQueue(media);
            }
            else
            {
                MediaHelpers.AddPlaylistToQueue(playlist);
            }
        }
        /// <summary>
        /// add this media next to the current playing media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void PlayNext_Click(object sender, System.EventArgs e)
        {
            if (media != null)
            {
                MediaHelpers.AddNextToCurrrentPlaying(media);
            }
            else
            {
                MediaHelpers.AddPlaylistNextToCurrrentPlaying(playlist);
            }
            // check dont play media
            if (PlayMedia.IsFirst == false && MediaHelpers.PlayQueue.Count != 0)
            {
                Form_Main.Instance.MediaControl.getPathOfSong(MediaHelpers.PlayQueue[0]);
            }
        }

        private void Play_Click(object sender, System.EventArgs e)
        {
            if (media != null)
            {
                MediaHelpers.isPlayingPlaylist = false;
                Form_Main.Instance.ClassifyMedia(media);
                Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(media);
            }
            else
            {
                MediaHelpers.PlayThePlaylist(playlist);
            }
        }
    }
}
