using MediaPlayer.Items;
using MediaPlayer.Models;
using System;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Library : UserControl
    {
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;
        public UserControl_Library()
        {
            InitializeComponent();
            UpdateScreen();
        }
        private void cb_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScreen();
        }
        public void UpdateScreen()
        {
            pn_Display.Controls.Clear();
            MediaHelpers.AllPlayList.ForEach(pl =>
            {
                PlayListItem item = new PlayListItem(pl);
                Panel panel = new Panel();
                panel.Width = 8;
                pn_Display.Controls.Add(panel);
                pn_Display.Controls.Add(item);
            });
        }

        private void AddNewPlayList_Play_Click(object sender, EventArgs e)
        {
            AddPlayList addPlayList = new AddPlayList();
            DialogResult dialogResult = addPlayList.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Playlist playlist = (Playlist)addPlayList.Tag;
                PlayListItem item = new PlayListItem(playlist);
                pn_Display.Controls.Add(item);
            }
        }
    }
}