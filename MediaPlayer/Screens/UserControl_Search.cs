using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
using System.IO;
using CsvHelper;
using Guna.UI.WinForms;
using MediaPlayer.Widgets;
using MediaPlayer.Items;
namespace MediaPlayer.Widgets
{
    public partial class UserControl_Search : UserControl
    {
        static SortHandling searchAndSort;
        static string defaultMusicPath = null, defaultVideoPath = null;
        private List<Media> textSearchMedia = new List<Media>();

        public UserControl_Search()
        {
            InitializeComponent();
            searchAndSort = new SortHandling(pn_Search);
            Init();
        }

        internal static void GetMusicVideoPath(string musicPath, string videoPath)
        {
            defaultMusicPath = musicPath;
            defaultVideoPath = videoPath;
        }

        public void Init()
        {
            
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Nhập tên nhạc / Album / Ca sĩ")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Nhập tên nhạc / Album / Ca sĩ";
                gunaTextBox1.ForeColor = Color.Green;
            }
        }

        private void ChangeSortEvent(object sender, EventArgs e)
        {
            try
            {
                // Goi ham xoa cac category panel, music panel
                searchAndSort.ResetUserControl();

                // Dua tren lua chon tren combobox ma tien hanh sort
                string selectedChoice = gunaComboBox1.SelectedItem.ToString();

                if (selectedChoice == "A to Z") searchAndSort.SortByAtoZ(textSearchMedia);

                else if (selectedChoice == "Date added") searchAndSort.SortByDateAdded(textSearchMedia);

                else if (selectedChoice == "Album") searchAndSort.SortByAlbum(textSearchMedia);

                else if (selectedChoice == "Artist") searchAndSort.SortByArtist(textSearchMedia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EventClickRefresh(object sender, EventArgs e)
        {
            searchAndSort.ResetUserControl();
            Init();
        }

        private void EventSearchText(object sender, EventArgs e)
        {
            string searchText = gunaTextBox1.Text;

            SearchSongByText(searchText);

            if (textSearchMedia.Count > 0)
            {
                searchAndSort.ResetUserControl();
                searchAndSort.LoadSongOntoScreen(textSearchMedia);
            }
        }
        public List<Media> MergeSongListAndVideoList
        {
            get
            {
                List<Media> list = new List<Media>(MediaHelpers.listSongs);
                list.AddRange(MediaHelpers.listVideos);
                return list;
            }
        }
        private void SearchSongByText(string searchText)
        {
            textSearchMedia = new List<Media>();

            foreach (var item in MergeSongListAndVideoList)
            {
                bool isFoundTitle = item.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
                bool isFoundAlbum = item.Album.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
                bool isFoundArtists = item.Artists.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

                if (isFoundTitle == true || isFoundArtists == true || isFoundAlbum == true)
                {
                    textSearchMedia.Add(item);
                }
            }
        }
    }
}
