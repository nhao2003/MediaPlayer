using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaPlayer.Items;
using MediaPlayer.Models;


namespace MediaPlayer.Screens
{
    public partial class UserControl_ListMedia : UserControl
    {
        public UserControl_ListMedia()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Get or Set UserControl MediaList Title
        /// </summary>
        public string Title
        {
            get => lb_Title.Text;
            set => lb_Title.Text = value;
        }

        private List<Media> _listMedia;

        /// <summary>
        /// Get or Set List Media
        /// </summary>
        public List<Media> ListMedia { 
            get => _listMedia;
            set => _listMedia = value;
        }

        public void SortMediaAToZ()
        {
            IEnumerable<IGrouping<char, Media>> sortByAToZ = Playlist.SortListAToZ(ListMedia);
            DisplayMediaItems(sortByAToZ);
        }

        public void SortMediaByDateAdded()
        {
            IEnumerable<IGrouping<string, Media>> sortByDateAdded = Playlist.SortListDateAdded(ListMedia);
            DisplayMediaItems(sortByDateAdded);
        }

        public void SortMediaByAlbum()
        {
            IEnumerable<IGrouping<string, Media>> sortByAlbum = Playlist.SortListAlbum(ListMedia);
            DisplayMediaItems(sortByAlbum);
        }

        public void SortMediaByArtists()
        {
            IEnumerable<IGrouping<string, Media>> sortByArtists = Playlist.SortListArtists(ListMedia);
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
            catch(Exception ex)
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
