using MediaPlayer.Items;
using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
namespace MediaPlayer.Widgets
{
    public partial class UserControl_Search : UserControl
    {
        private List<Media> textSearchMedia = new List<Media>();
        public List<Media> MergeSongListAndVideoList
        {
            get
            {
                List<Media> list = new List<Media>(MediaHelpers.listSongs);
                list.AddRange(MediaHelpers.listVideos);
                return list;
            }
        }
        public UserControl_Search()
        {
            InitializeComponent();
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

        private void EventSearchText(object sender, EventArgs e)
        {
            string searchText = gunaTextBox1.Text;

            SearchSongByText(searchText);
            pn_Search.Controls.Clear();

            if (textSearchMedia.Count > 0)
            {
                textSearchMedia.ForEach(x =>
                {
                    MusicRow musicRow = new MusicRow(x)
                    {
                        Dock = DockStyle.Top
                    };
                    pn_Search.Controls.Add(musicRow);
                });
            }
        }

        private void SearchSongByText(string searchText)
        {
            textSearchMedia = new List<Media>();
            searchText = searchText.Trim();
            bool isNotHaveDiacritics = Diacritics.CheckNoDiacriticsInText(searchText);

            foreach (var item in MergeSongListAndVideoList)
            {
                // If there's no diacritics in searchText -> Proceed to search diacritics insensitively
                // Else search diacritics sensitively
                string title = isNotHaveDiacritics == true ? Diacritics.RemoveDiacritics(item.Title) : item.Title;
                string album = isNotHaveDiacritics == true ? Diacritics.RemoveDiacritics(item.Album) : item.Album;
                string artists = isNotHaveDiacritics == true ? Diacritics.RemoveDiacritics(item.Artists) : item.Artists;

                bool isFoundTitle = title.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0;
                bool isFoundAlbum = album.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0;
                bool isFoundArtists = artists.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0;

                if (isFoundTitle == true || isFoundArtists == true || isFoundAlbum == true)
                {
                    textSearchMedia.Add(item);
                }
            }
        }
    }
}
