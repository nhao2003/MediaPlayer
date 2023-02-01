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
        public List<Media> AllMedias
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

        private void EventTextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (tbEnterTextSearch.Text == "Nhập tên nhạc / Album / Ca sĩ")
            {
                tbEnterTextSearch.Text = "";
                tbEnterTextSearch.ForeColor = Color.Black;
            }
        }

        private void EventTextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (tbEnterTextSearch.Text == "")
            {
                tbEnterTextSearch.Text = "Nhập tên nhạc / Album / Ca sĩ";
                tbEnterTextSearch.ForeColor = Color.Green;
            }
        }

        private void EventSearchText(object sender, EventArgs e)
        {
            pn_Search.Controls.Clear();
            string searchText = tbEnterTextSearch.Text;
            List<Media> listOfSearchMedias = new List<Media>(ReturnMediaListsSearchedByText(searchText));
            LoadMediasOntoScreen(listOfSearchMedias);
        }

        private void LoadMediasOntoScreen(List<Media> listOfSearchMedias)
        {
            if (listOfSearchMedias.Count <= 0) return;
                listOfSearchMedias.ForEach(x =>
                {
                    MusicRow musicRow = new MusicRow(x)
                    {
                        Dock = DockStyle.Top
                    };
                    pn_Search.Controls.Add(musicRow);
                });
        }

        private List<Media> ReturnMediaListsSearchedByText(string searchText)
        {
            var result = new List<Media>();
            searchText = searchText.Trim();
            bool isNotHaveDiacritics = Diacritics.CheckNoDiacriticsInText(searchText);

            foreach (var media in AllMedias)
            {
                // If there's no diacritics in searchText -> Proceed to search diacritics insensitively
                // Else search diacritics sensitively
                string title = 
                    isNotHaveDiacritics == true ?
                    Diacritics.RemoveDiacritics(media.Title) :
                    media.Title;
                string album = isNotHaveDiacritics == true ? 
                    Diacritics.RemoveDiacritics(media.Album) :
                    media.Album;
                List<string> artists = isNotHaveDiacritics == true ? 
                    Diacritics.RemoveDiacriticsForAList(media.Artists) :
                    media.Artists;

                bool isFoundTitle = title.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0;
                bool isFoundAlbum = album.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0;
                bool isFoundArtists = CheckArtistExistsInList(artists, searchText);

                if (isFoundTitle == true || isFoundArtists == true || isFoundAlbum == true)
                {
                    result.Add(media);
                }
            }
            return result;
        }

        private bool CheckArtistExistsInList(List<string> listArtists, string searchText)
        {
            foreach (var artist in listArtists)
            {
                bool isFoundArtists = artist.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0;
                if (isFoundArtists == true) return true;
            }
            return false;
        }
    }
}
