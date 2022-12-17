using MediaPlayer.Items;
using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.IO;
using CsvHelper;
using Guna.UI.WinForms;
using MediaPlayer.Widgets;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_ListMedia : UserControl
    {
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;
        /// <summary>
        /// Get or Set UserControl MediaList Title
        /// </summary>
        public String Title
        {
            get => lb_Title.Text;
            set => lb_Title.Text = value;
        }
        /// <summary>
        /// Get or Set List Media
        /// </summary>
        private List<Media> ListMedia = new List<Media>();
        public void sendChildPath(String s, MediaTypes mediaTypes)
        {
            if (mediaTypes == MediaTypes.Audio) Form_Main.Instance.MediaControl.getPathOfSong(s);
            else
            {
                Form_Main.Instance.MediaControl.getPathOfSong(s);
                VideoPlayer videoScreen = new VideoPlayer();
                videoScreen.Show();
                videoScreen.getPathOfSong(s);
            }
        }

        // Khai bao cac bien toan cuc
        static List<string> filePaths = new List<string>();
        static List<string> joins = new List<string>();
        static List<TagLib.File> fileSongs = new List<TagLib.File>();
        static List<Media> songList = new List<Media>();
        static List<MediaPanel> songs = new List<MediaPanel>();
        static List<CategoryPanel> listCategories = new List<CategoryPanel>();
        static string defaultMusicPath = null, defaultVideoPath;
        static Point displayPanelLocation = new Point(0, 300);
       

        public UserControl_ListMedia()
        {
            InitializeComponent();
            Init();
            //GroupMedia group = new GroupMedia("Dummy 1", MediaHelpers.listSongs)
            //{
            //    Dock = DockStyle.Top
            //};
            //GroupMedia gp = new GroupMedia("Dummy 2", MediaHelpers.listSongs)
            //{
            //    Dock = DockStyle.Top
            //};
            //pn_Display.Controls.Add(group);
            //pn_Display.Controls.Add(gp);
        }

        internal static void GetMusicVideoPath(string musicPath, string videoPath)
        {
            defaultMusicPath = musicPath;
            defaultVideoPath = videoPath;
        }

        /// <summary>
        /// Reset UserControl (screen)
        /// </summary>
        internal void ResetUserControl()
        {
            try
            {
                // Xoa cac music panel cu
                if (songs.Count > 0)
                {
                    MessageBox.Show("Success");
                    for (int i = 0; i < songs.Count; i++)
                    {
                        pn_Display.Controls.Remove(songs[i]);
                    }
                }
                // Xoa cac category neu co
                if (listCategories.Count > 0)
                {
                    MessageBox.Show("Success");
                    for (int j = 0; j < listCategories.Count; j++)
                    {
                        pn_Display.Controls.Remove(listCategories[j]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Phuong thuc set cac gia tri mac dinh cho categoryPanel
        public void SetCategoryPanelAttribute(ref CategoryPanel category, Point categoryLocation, string groupKey)
        {
            category.Location = new Point(categoryLocation.X, categoryLocation.Y);
            category.Dock = DockStyle.Top;
            category.Height = 40;
            category.BackColor = System.Drawing.Color.FromArgb(216, 243, 220);
            category.InitializeCategory(groupKey);
        }

        /// <summary>
        /// Phuong thuc khoi tao khi bat dau chay
        /// </summary>
        private void Init()
        {
            List<string> defaultFiles = new List<string>();
            try
            {
                defaultFiles = Directory.GetFiles(defaultMusicPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".mp3") || s.EndsWith(".flac") || s.EndsWith(".wav") || s.EndsWith(".ogg")).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AddMusicDataToLists(ref defaultFiles);
            SaveToDatabase(ref joins);
            LoadSongOntoScreen(ref defaultFiles);
        }

        /// <summary>
        /// Them cac bai nhac vo danh sach 
        /// </summary>
        /// <param name="filePaths"></param>
        public void AddMusicDataToLists(ref List<string> filePaths)
        {
            // Tao cac file taglib luu tru thong tin media
            for (int i = 0; i < filePaths.Count; i++)
            {
                fileSongs.Add(TagLib.File.Create(filePaths[i]));
            }
            // Load cac music song thanh cac object
            for (int i = 0; i < filePaths.Count; i++)
            {
                songList.Add(new Media(filePaths[i]));
                joins.Add(songList[i].Title + ";" + songList[i].Artists + ";"
                    + songList[i].FilePath + ";" + songList[i].Album + ";" + songList[i].Duration + ";" + songList[i].DateAdded
                    + ";" + songList[i].IsLiked.ToString());
            }
        }

        /// <summary>
        /// Load cac panel len man hinh
        /// </summary>
        /// <param name="filePaths"></param>
        public void LoadSongOntoScreen(ref List<string> filePaths)
        {
            // Load cac music song thanh cac panel len form
            for (int i = 0; i < filePaths.Count; i++)
            {
                MediaPanel temp = new MediaPanel();
                temp.Location = new Point(displayPanelLocation.X, displayPanelLocation.Y);
                temp.Dock = DockStyle.Top;
                temp.InitializeSongItem(fileSongs[filePaths.Count - i - 1],
                    songList[filePaths.Count - i - 1].FilePath, filePaths.Count - i);
                songs.Add(temp);
                displayPanelLocation.Y += 100;
                pn_Display.Controls.Add(temp);
            }
        }

        /// <summary>
        /// Save to csv File
        /// </summary>
        /// <param name="joins"></param>
        public void SaveToDatabase(ref List<string> joins)
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

        /// <summary>
        /// Add more music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                AddMusicDataToLists(ref filePaths);
                SaveToDatabase(ref joins);
                LoadSongOntoScreen(ref filePaths);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Refresh button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            ResetUserControl();
            Init();
        }
        
        /// <summary>
        /// Sort theo thu tu A - Z
        /// </summary>
        public void SortByAtoZ()
        {
            var songlist = new List<Media>(songList);

            ResetPanelLocation();

            IEnumerable<IGrouping<char, Media>> res = from song in songlist
                                                      orderby song.Title ascending
                                                      group song by song.Title[0];
            ReInitializeMediaAndCategoryPanel();

            DisplaySortMediaItems(res);
        }


        /// <summary>
        /// Sort theo ngay them nhac
        /// </summary>
        public void SortByDateAdded()
        {
            var songlist = new List<Media>(songList);

            ResetPanelLocation();

            IEnumerable<IGrouping<DateTime, Media>> res = from song in songlist
                                                          orderby song.DateAdded ascending
                                                          group song by song.DateAdded;
            songs = new List<MediaPanel>();
            listCategories = new List<CategoryPanel>();

            DisplaySortMediaItems(res);
        }

        /// <summary>
        /// Sort theo nhac si
        /// </summary>
        public void SortByArtist()
        {
            var songlist = new List<Media>(songList);

            ResetPanelLocation();

            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                        orderby song.Artists ascending
                                                        group song by song.Artists;
            songs = new List<MediaPanel>();
            listCategories = new List<CategoryPanel>();

            DisplaySortMediaItems(res);
        }

        /// <summary>
        /// Sort theo Album
        /// </summary>
        public void SortByAlbum()
        {
            var songlist = new List<Media>(songList);

            ResetPanelLocation();

            IEnumerable<IGrouping<string, Media>> res = from song in songlist
                                                        orderby song.Album ascending
                                                        group song by song.Album;
            songs = new List<MediaPanel>();
            listCategories = new List<CategoryPanel>();

            DisplaySortMediaItems(res);
        }

        private static void ReInitializeMediaAndCategoryPanel()
        {
            songs = new List<MediaPanel>();
            listCategories = new List<CategoryPanel>();
        }

        private static void ResetPanelLocation()
        {
            displayPanelLocation.X = 0;
            displayPanelLocation.Y = 100;
        }
        /// <summary>
        /// Hien thi lai cac mediapanel da sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="res"></param>
        private void DisplaySortMediaItems<T>(IEnumerable<IGrouping<T, Media>> res)
        {
            int panelIndex = 0;
            foreach (var group in res.Reverse())
            {
                foreach (var song in group.Reverse())
                {
                    MediaPanel songdisplay = new MediaPanel();
                    TagLib.File temp = TagLib.File.Create(song.FilePath);
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, song.FilePath, panelIndex++);
                    pn_Display.Controls.Add(songdisplay);
                    songs.Add(songdisplay);
                    displayPanelLocation.Y += 100;
                }
                displayPanelLocation.Y -= 100;
                CategoryPanel category_display = new CategoryPanel();
                SetCategoryPanelAttribute(ref category_display, displayPanelLocation, group.Key.ToString());

                pn_Display.Controls.Add(category_display);
                listCategories.Add(category_display);
            }
        }
    }
}
