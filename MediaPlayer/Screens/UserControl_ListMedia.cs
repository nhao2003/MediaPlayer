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
        public List<Media> ListMedia {
            get => _listMedia;
            set
            {
                pn_Display.Controls.Clear();
                _listMedia = value;
                GroupMedia group = new GroupMedia("A", _listMedia)
                {
                    Dock = DockStyle.Top
                };
                pn_Display.Controls.Add(group);
            }
        }

        /// <summary>
        /// Initialize data
        /// </summary>
        static SortHandling manageSort;
        static string defaultMusicPath = null, defaultVideoPath = null;
        private List<string> filePaths = new List<string>();

        public UserControl_ListMedia()
        {
            InitializeComponent();
            manageSort = new SortHandling(pn_Display);
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
            
            manageSort.AddMusicDataToLists(ref defaultFiles);

            manageSort.SaveToDatabase();

            manageSort.SortByAtoZ();
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
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Goi ham xoa cac category panel, music panel
                manageSort.ResetUserControl();
                // Dua tren lua chon tren combobox ma tien hanh sort
                string selectedChoice = gunaComboBox1.SelectedItem.ToString();
                if (selectedChoice == "A to Z") manageSort.SortByAtoZ();
                
                else if (selectedChoice == "Date added") manageSort.SortByDateAdded();
                
                else if (selectedChoice == "Album") manageSort.SortByAlbum();
               
                else if (selectedChoice == "Artist") manageSort.SortByArtist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Event press F5 to refresh screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_ListMedia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                manageSort.ResetUserControl();
                Init();
            }
        }

        private void RefreshClickEvent(object sender, EventArgs e)
        {
            manageSort.ResetUserControl();
            Init();
        }

        private void LoadListMediaEvent(object sender, EventArgs e)
        {
            manageSort.ResetUserControl();
            Init();
        }
    }
}
