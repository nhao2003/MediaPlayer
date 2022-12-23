using MediaPlayer.Items;
using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_ListMedia : UserControl
    {
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;

        /// <summary>
        /// Get or Set UserControl MediaList Title
        /// </summary>
        public string Title
        {
            get => lb_Title.Text;
            set
            {
                lb_Title.Text = value;
            }
        }

        private List<Media> _listMedia = new List<Media>();
        /// <summary>
        /// Get or Set List Media
        /// </summary>
        public List<Media> ListMedia
        {
            get => _listMedia;
            set
            {
                _listMedia = value;
                SortMediaAToZ();
                cb_SortBy.SelectedIndex = 0;
            }
        }
        public void SortMediaAToZ()
        {
            IEnumerable<IGrouping<char, Media>> sortByAToZ = Playlist.SortListAToZ(_listMedia);
            DisplayMediaItems(sortByAToZ);
        }

        public void SortMediaByDateAdded()
        {
            IEnumerable<IGrouping<string, Media>> sortByDateAdded = Playlist.SortListDateAdded(_listMedia);
            DisplayMediaItems(sortByDateAdded);
        }

        public void SortMediaByAlbum()
        {
            IEnumerable<IGrouping<string, Media>> sortByAlbum = Playlist.SortListAlbum(_listMedia);
            DisplayMediaItems(sortByAlbum);
        }

        public void SortMediaByArtists()
        {
            IEnumerable<IGrouping<string, Media>> sortByArtists = Playlist.SortListArtists(_listMedia);
            DisplayMediaItems(sortByArtists);
        }

        private void DisplayMediaItems<T>(IEnumerable<IGrouping<T, Media>> sortAToZ)
        {
            pn_Display.Controls.Clear();
            try
            {
                foreach (var group in sortAToZ)
                {

                    GroupMedia temp = new GroupMedia(group.Key.ToString(), group.ToList());
                    temp.Dock = DockStyle.Top;
                    pn_Display.Controls.Add(temp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Initialize data
        /// </summary>
        static SortHandling manageSort;
        private List<string> filePaths = new List<string>();

        public UserControl_ListMedia()
        {
            InitializeComponent();
            manageSort = new SortHandling(pn_Display);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            manageSort.ResetUserControl();
            // Chon folder de lay music
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    var files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".mp3") || s.EndsWith(".flac") || s.EndsWith(".wav") || s.EndsWith(".ogg"));
                    filePaths = files.ToList();
                }

                manageSort.AddMusicDataToLists(ref filePaths);

                manageSort.SaveToDatabase();

                manageSort.LoadSongOntoScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Choosing sort option changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSortOptionEvent(object sender, EventArgs e)
        {
            try
            {
                // Goi ham xoa cac category panel, music panel
                manageSort.ResetUserControl();
                // Dua tren lua chon tren combobox ma tien hanh sort
                string selectedChoice = cb_SortBy.SelectedItem.ToString();
                switch (selectedChoice)
                {
                    case "A to Z":
                        SortMediaAToZ();
                        break;
                    case "Date added":
                        SortMediaByDateAdded();
                        break;
                    case "Album":
                        SortMediaByAlbum();
                        break;
                    case "Artist":
                        SortMediaByArtists();
                        break;
                    default:
                        SortMediaAToZ();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
