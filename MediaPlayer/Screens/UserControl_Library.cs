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
using MediaPlayer.Screens;
namespace MediaPlayer.Widgets
{
    public partial class UserControl_Library : UserControl
    {
        public UserControl_Library()
        {
            InitializeComponent();
        }

        // Khai bao cac bien toan cuc
        static string[] filePaths;
        static string[] joins;
        TagLib.File[] f;
        static Media[] SongList;
        static UserControl_LibrarySong[] songs;
        // Bien toan cuc luu tru danh sach cac category sau khi sort
        static CategoryPanel[] list_category;

        // Phuong thuc reset UserControl
        private void ResetUserControl()
        {
            try
            {
                // Xoa cac music panel cu
                if (songs != null)
                {
                    for (int i = 0; i < songs.Length; i++)
                    {
                        gunaElipsePanel2.Controls.Remove(songs[i]);
                    }
                }
                // Xoa cac category neu co
                if (list_category != null)
                {
                    for (int j = 0; j < list_category.Length; j++)
                    {
                        gunaElipsePanel2.Controls.Remove(list_category[j]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
                    filePaths = files.ToArray();
                }
                // Cac mang luu tru thong tin music
                f = new TagLib.File[filePaths.Length];
                SongList = new Media[filePaths.Length];
                joins = new string[filePaths.Length];
                for (int i = 0; i < filePaths.Length; i++)
                {
                    f[i] = TagLib.File.Create(filePaths[i]);
                }
                // Load cac music song thanh cac object
                for (int i = 0; i < filePaths.Length; i++)
                {
                    SongList[i] = new Media();
                    // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
                    // SongList[i].Id= Guid.NewGuid().ToString("N");
                    SongList[i].Title = f[i].Tag.Title;
                    SongList[i].Artists = (String.Join(", ", f[i].Tag.AlbumArtists));
                    SongList[i].FilePath = (filePaths[i]);
                    SongList[i].Album = f[i].Tag.Album;
                    // SongList[i].SongImage();
                    SongList[i].Duration = (f[i].Properties.Duration);
                    SongList[i].DateAdded = (DateTime.Now);
                    SongList[i].IsLiked = false;
                    joins[i] = SongList[i].Title + ";" + SongList[i].Artists + ";"
                        + SongList[i].FilePath + ";" + SongList[i].Album + ";" + SongList[i].Duration + ";" + SongList[i].DateAdded
                        + ";" + SongList[i].IsLiked.ToString();
                }

                // Luu data vo file csv, hien chua can su dung
                string csv_FilePath = "MusicDataBase\\Song.csv";
                StringBuilder sbOutput = new StringBuilder();
                sbOutput.AppendLine("sep=;");
                sbOutput.AppendLine("Title;Artists;FilePath;Album;Duration;DateAdded;isLiked");
                for (int i = 0; i < filePaths.Length; i++)
                {
                    sbOutput.AppendLine(joins[i]);
                }
                File.WriteAllText(csv_FilePath, sbOutput.ToString());
                // File.AppendAllText(csv_FilePath, sbOutput.ToString()); // (for appending use)

                // Load cac music song thanh cac panel len form
                int xLoc = 0;
                int yLoc = 300;
                songs = new UserControl_LibrarySong[filePaths.Length];
                for (int i = 0; i < filePaths.Length; i++)
                {
                    songs[i] = new UserControl_LibrarySong();
                    songs[i].Location = new Point(xLoc, yLoc);
                    songs[i].Dock = DockStyle.Top;
                    songs[i].InitializeSongItem(f[i], SongList[i].FilePath, i + 1);
                    yLoc += 100;
                    gunaElipsePanel2.Controls.Add(songs[i]);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Haven't choose any folder yet !!!");
                MessageBox.Show(ex.Message);
            }
        }


        // Sort theo thu tu alphabet A-Z
        public void SortByAtoZ()
        {
            var songlist = new List<Media>(SongList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<char, Media>> res = from song in songlist
                      orderby song.Title ascending
                      group song by song.Title[0];
            int i = 0;
            songs = new UserControl_LibrarySong[filePaths.Length];
            int j = 0;
            list_category = new CategoryPanel[res.Count()];
            foreach (var group in res.Reverse())
            {
                
                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs[i++] = songdisplay;
                    yLoc += 100;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                list_category[j] = new CategoryPanel();
                list_category[j++] = category_display;
            }
        }
        // Sort theo ngay them nhac
        public void SortByDateAdded()
        {
            var songlist = new List<Media>(SongList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<DateTime, Media>> res = from song in songlist
                                                         orderby song.DateAdded ascending
                                                         group song by song.DateAdded;
            int i = 0;
            songs = new UserControl_LibrarySong[filePaths.Length];
            int j = 0;
            list_category = new CategoryPanel[res.Count()];
            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs[i++] = songdisplay;
                    yLoc += 140;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                list_category[j] = new CategoryPanel();
                list_category[j++] = category_display;
            }
        }
        // Sort theo ten tac gia
        public void SortByArtist()
        {
            var songlist = new List<Media>(SongList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                       orderby song.Artists ascending
                                                       group song by song.Artists;
            int i = 0;
            songs = new UserControl_LibrarySong[filePaths.Length];
            int j = 0;
            list_category = new CategoryPanel[res.Count()];
            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs[i++] = songdisplay;
                    yLoc += 100;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                list_category[j] = new CategoryPanel();
                list_category[j++] = category_display;
            }
        }
        public void SortByAlbum()
        {
            var songlist = new List<Media>(SongList);
            int xLoc = 0;
            int yLoc = 100;
            int idx = 0;
            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                       orderby song.Album ascending
                                                       group song by song.Album;
            int i = 0;
            songs = new UserControl_LibrarySong[filePaths.Length];
            int j = 0;
            list_category = new CategoryPanel[res.Count()];
            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    songs[i++] = songdisplay;
                    yLoc += 100;
                }
                yLoc -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, xLoc, yLoc, group.Key.ToString());

                gunaElipsePanel2.Controls.Add(category_display);
                list_category[j] = new CategoryPanel();
                list_category[j++] = category_display;
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
                MessageBox.Show("There's nothing to sort !!!");
            }
        }
    }
}
