using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaPlayer.Items;
using MediaPlayer.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TagLib;
using System.IO;
using CsvHelper;
using MediaPlayer.Widgets;
namespace MediaPlayer.Items
{
    internal class SortHandling
    {
        private GunaPanel PanelContainingMusicRows;
        private List<string> joins = new List<string>();
        private List<TagLib.File> fileSongs = new List<TagLib.File>();
        private List<Media> songList = new List<Media>();
        private List<MusicRow> songs = new List<MusicRow>();
        private List<CategoryPanel> listCategories = new List<CategoryPanel>();
        static Point displayPanelLocation = new Point(0, 300);

        public SortHandling()
        {

        }

        public SortHandling(GunaPanel panelContainingMusicRows)
        {
            this.PanelContainingMusicRows = panelContainingMusicRows;
        }

        public List<Media> GetListMedia()
        {
            return songList;
        }

        internal void ResetUserControl()
        {
            try
            {
                // Xoa cac music panel cu
                if (songs.Count > 0)
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        PanelContainingMusicRows.Controls.Remove(songs[i]);
                    }
                }
                // Xoa cac category neu co
                if (listCategories.Count > 0)
                {
                    for (int j = 0; j < listCategories.Count; j++)
                    {
                        PanelContainingMusicRows.Controls.Remove(listCategories[j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void SetCategoryPanelAttribute(ref CategoryPanel category, Point categoryLocation, string groupKey)
        {
            category.Location = new Point(categoryLocation.X, categoryLocation.Y);
            category.Dock = DockStyle.Top;
            category.Height = 35;
            category.InitializeCategory(groupKey);
        }

        public void AddMusicDataToLists(ref List<string> filePaths)
        {

            // Tao cac file taglib luu tru thong tin media
            for (int i = 0; i < filePaths.Count; i++)
            {
                if (CheckSongExistsInLists(filePaths[i])) continue;
                fileSongs.Add(TagLib.File.Create(filePaths[i]));

                songList.Add(new Media(filePaths[i]));

                joins.Add(songList[i].Title + ";" + songList[i].Artists + ";"
                    + songList[i].FilePath + ";" + songList[i].Album + ";" + songList[i].Duration + ";" + songList[i].DateAdded
                    + ";" + songList[i].IsLiked.ToString());
            }
        }

        public bool CheckSongExistsInLists(string filePath)
        {
            foreach (var song in songList)
            {
                if (song.FilePath == filePath) return true;
            }
            return false;
        }

        public void LoadSongOntoScreen(List<Media> listSongNeedToBeLoaded = null)
        {
            List<Media> loadSongs;

            if (listSongNeedToBeLoaded == null)
            {
                loadSongs = new List<Media>(songList);
            }
            else
            {
                loadSongs = new List<Media>(listSongNeedToBeLoaded);
            }

            // Load cac music song thanh cac panel len form
            for (int i = 0; i < loadSongs.Count; i++)
            {
                MusicRow temp = new MusicRow();
                temp.Location = new Point(displayPanelLocation.X, displayPanelLocation.Y);
                temp.Dock = DockStyle.Top;
                temp.InitializeSongItem(loadSongs[i]);
                songs.Add(temp);
                displayPanelLocation.Y += 100;
                PanelContainingMusicRows.Controls.Add(temp);
            }
        }

        public void SaveToDatabase()
        {
            // Luu data vo file csv
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string csv_FilePath = startupPath + "\\Song.csv";
            StringBuilder sbOutput = new StringBuilder();
            sbOutput.AppendLine("sep=;");
            sbOutput.AppendLine("Title;Artists;FilePath;Album;Duration;DateAdded;isLiked");
            for (int i = 0; i < joins.Count; i++)
            {
                sbOutput.AppendLine(joins[i]);
            }
            System.IO.File.WriteAllText(csv_FilePath, sbOutput.ToString());
            // File.AppendAllText(csv_FilePath, sbOutput.ToString()); // (for appending use)
        }

        public void SortByAtoZ(List<Media> listNeedToBeSorted = null)
        {
            List<Media> songlist;

            if (listNeedToBeSorted == null)
            {
                songlist = new List<Media>(songList);
            }
            else
            {
                songlist = new List<Media>(listNeedToBeSorted);
            }

            ResetPanelLocation();

            IEnumerable<IGrouping<char, Media>> res = from song in songlist
                                                      orderby song.Title ascending
                                                      group song by song.Title[0];
            ReInitializeMediaAndCategoryPanel();

            try
            {
                DisplaySortMediaItems(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SortByDateAdded(List<Media> listNeedToBeSorted = null)
        {
            List<Media> songlist;

            if (listNeedToBeSorted == null)
            {
                songlist = new List<Media>(songList);
            }
            else
            {
                songlist = new List<Media>(listNeedToBeSorted);
            }

            ResetPanelLocation();

            IEnumerable<IGrouping<DateTime, Media>> res = from song in songlist
                                                          orderby song.DateAdded ascending
                                                          group song by song.DateAdded;
            ReInitializeMediaAndCategoryPanel();

            try
            {
                DisplaySortMediaItems(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SortByArtist(List<Media> listNeedToBeSorted = null)
        {

            List<Media> songlist;
            
            if (listNeedToBeSorted == null)
            {
                songlist = new List<Media>(songList);
            }
            else
            {
                songlist = new List<Media>(listNeedToBeSorted);
            }

            ResetPanelLocation();

            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                        orderby song.Artists ascending
                                                        group song by song.Artists;
            ReInitializeMediaAndCategoryPanel();

            try
            {
                DisplaySortMediaItems(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SortByAlbum(List<Media> listNeedToBeSorted = null)
        {
            List<Media> songlist;

            if (listNeedToBeSorted == null)
            {
                songlist = new List<Media>(songList);
            }
            else
            {
                songlist = new List<Media>(listNeedToBeSorted);
            }

            ResetPanelLocation();

            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                        orderby song.Album ascending
                                                        group song by song.Album;
            ReInitializeMediaAndCategoryPanel();

            try
            {
                DisplaySortMediaItems(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void ReInitializeMediaAndCategoryPanel()
        {
            songs = new List<MusicRow>();
            listCategories = new List<CategoryPanel>();
        }

        private static void ResetPanelLocation()
        {
            displayPanelLocation.X = 0;
            displayPanelLocation.Y = 100;
        }

        private void DisplaySortMediaItems<T>(IEnumerable<IGrouping<T, Media>> res)
        {
            // int panelIndex = 0;
            foreach (var group in res.Reverse())
            {
                foreach (var song in group.Reverse())
                {
                    MusicRow songdisplay = new MusicRow();

                    TagLib.File temp = TagLib.File.Create(song.FilePath);

                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(song);

                    PanelContainingMusicRows.Controls.Add(songdisplay);
                    songs.Add(songdisplay);

                    displayPanelLocation.Y += 100;
                }
                displayPanelLocation.Y -= 100;

                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, displayPanelLocation, group.Key.ToString());

                PanelContainingMusicRows.Controls.Add(category_display);
                listCategories.Add(category_display);
            }
        }
    }
}
