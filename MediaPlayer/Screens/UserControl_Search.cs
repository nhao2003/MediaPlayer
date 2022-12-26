﻿using MediaPlayer.Items;
using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace MediaPlayer.Widgets
{
    public partial class UserControl_Search : UserControl
    {
        static SortHandling searchAndSort;
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
            searchAndSort = new SortHandling(pn_Search);
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
            searchAndSort.ResetUserControl();

            if (textSearchMedia.Count > 0)
            {
                searchAndSort.LoadSongOntoScreen(textSearchMedia);
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
