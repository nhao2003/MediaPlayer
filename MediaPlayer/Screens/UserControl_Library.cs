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
    public partial class UserControl_Library : UserControl
    {
        public UserControl_Library()
        {
            InitializeComponent();
        }

        // Khai bao cac bien toan cuc
        static List<string> filePaths = new List<string>();
        static List<string> joins = new List<string>();
        static List<TagLib.File> fileSongs = new List<TagLib.File>();
        static List<Media> songList = new List<Media>();
        static List<MediaPanel> songs = new List<MediaPanel>();
        static List<CategoryPanel> listCategories = new List<CategoryPanel>();

        // Phuong thuc reset UserControl
        private void ResetUserControl()
        {
            try
            {
                // Xoa cac music panel cu
                if (songs.Count > 0)
                {
                    MessageBox.Show("Success");
                    for (int i = 0; i < songs.Count; i++)
                    {
                        gunaElipsePanel2.Controls.Remove(songs[i]);
                    }
                }
                // Xoa cac category neu co
                if (listCategories.Count > 0)
                {
                    MessageBox.Show("Success");
                    for (int j = 0; j < listCategories.Count; j++)
                    {
                        gunaElipsePanel2.Controls.Remove(listCategories[j]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Init()
        {

        }
        // Phuong thuc set cac gia tri mac dinh cho categoryPanel
        public void SetCategoryPanelAttribute(ref CategoryPanel category, int xLoc,int yLoc, string groupKey)
        {
            category.Location = new Point(xLoc, yLoc);
            category.Dock = DockStyle.Top;
            category.Height = 40;
            category.BackColor = System.Drawing.Color.FromArgb(216, 243, 220);
            category.InitializeCategory(groupKey);
        }

        // Event click Add music
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.ResetUserControl();
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
                
                fileSongs = new List<TagLib.File>();
                songList = new List<Media>();
                joins = new List<string>();

                
                for (int i = 0; i < filePaths.Count; i++)
                {
                    fileSongs.Add(TagLib.File.Create(filePaths[i]));
                }

                // Load cac music song thanh cac object
                for (int i = 0; i < filePaths.Count; i++)
                {
                    songList.Add(new Media(filePaths[i]));
                    joins.Add( songList[i].Title + ";" + songList[i].Artists + ";"
                        + songList[i].FilePath + ";" + songList[i].Album + ";" + songList[i].Duration + ";" + songList[i].DateAdded
                        + ";" + songList[i].IsLiked.ToString());
                }

                // Luu data vo file csv, hien chua can su dung
                //string csv_FilePath = "MusicDataBase\\Song.csv";
                //StringBuilder sbOutput = new StringBuilder();
                //sbOutput.AppendLine("sep=;");
                //sbOutput.AppendLine("Title;Artists;FilePath;Album;Duration;DateAdded;isLiked");
                //for (int i = 0; i < filePaths.Length; i++)
                //{
                //    sbOutput.AppendLine(joins[i]);
                //}
                //File.WriteAllText(csv_FilePath, sbOutput.ToString());
                // File.AppendAllText(csv_FilePath, sbOutput.ToString()); // (for appending use)

                // Load cac music song thanh cac panel len form
                int xLoc = 0;
                int yLoc = 300;
                for (int i = 0; i < filePaths.Count; i++)
                {
                    MediaPanel temp = new MediaPanel();
                    temp.Location = new Point(xLoc, yLoc);
                    temp.Dock = DockStyle.Top;
                    temp.InitializeSongItem(fileSongs[i], songList[i].FilePath, i + 1);
                    songs.Add(temp);
                    yLoc += 100;
                    gunaElipsePanel2.Controls.Add(temp);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Haven't choose any folder yet !!!");
                MessageBox.Show(ex.Message);
            }
        }


        // Sort theo thu tu alphabet A-Z
        public void SortByAtoZ()
        {
            var songlist = new List<Media>(songList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<char, Media>> res = from song in songlist
                      orderby song.Title ascending
                      group song by song.Title[0];
            int i = 0;
            songs = new List<MediaPanel>();
            int j = 0;
            listCategories = new List<CategoryPanel>();
            foreach (var group in res.Reverse())
            {
                
                foreach (var song in group.Reverse())
                {
                    MediaPanel songdisplay = new MediaPanel();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs.Add(songdisplay);
                    yLoc += 100;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                listCategories.Add(category_display);
            }
        }
        // Sort theo ngay them nhac
        public void SortByDateAdded()
        {
            var songlist = new List<Media>(songList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<DateTime, Media>> res = from song in songlist
                                                         orderby song.DateAdded ascending
                                                         group song by song.DateAdded;
            int i = 0;
            songs = new List<MediaPanel>();
            int j = 0;
            listCategories = new List<CategoryPanel>();
            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    MediaPanel songdisplay = new MediaPanel();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs.Add(songdisplay);
                    yLoc += 140;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                listCategories.Add(category_display);
            }
        }
        // Sort theo ten tac gia
        public void SortByArtist()
        {
            var songlist = new List<Media>(songList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                       orderby song.Artists ascending
                                                       group song by song.Artists;
            int i = 0;
            songs = new List<MediaPanel>();
            int j = 0;
            listCategories = new List<CategoryPanel>();
            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    MediaPanel songdisplay = new MediaPanel();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs.Add(songdisplay);
                    yLoc += 100;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                listCategories.Add(category_display);
            }
        }
        public void SortByAlbum()
        {
            var songlist = new List<Media>(songList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                       orderby song.Album ascending
                                                       group song by song.Album;
            int i = 0;
            songs = new List<MediaPanel>();
            int j = 0;
            listCategories = new List<CategoryPanel>();
            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    MediaPanel songdisplay = new MediaPanel();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs.Add(songdisplay);
                    yLoc += 100;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                listCategories.Add(category_display);
            }
        }
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                // Goi ham xoa cac category panel, music panel
                this.ResetUserControl();
                // Dua tren lua chon tren combobox ma tien hanh sort
                string selectedChoice = gunaComboBox1.SelectedItem.ToString();
                if (selectedChoice == "A to Z") SortByAtoZ();
                else if (selectedChoice == "Date added") SortByDateAdded();
                else if (selectedChoice == "Album") SortByAlbum();
                else if (selectedChoice == "Artist") SortByArtist();
            }
            catch(Exception ex){
                //MessageBox.Show("There's nothing to sort !!!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
