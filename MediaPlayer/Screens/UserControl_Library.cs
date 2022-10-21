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
using MediaPlayer.Screens;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Library : UserControl
    {
        public UserControl_Library()
        {
            InitializeComponent();
        }
     
        static string[] filePaths;
        static string[] joins;
        TagLib.File[] f;
        static Song[] SongList;
        static UserControl_LibrarySong[] songs;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                var files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".mp3") || s.EndsWith(".flac") || s.EndsWith(".wav") || s.EndsWith(".ogg"));
                filePaths = files.ToArray();
            }

            f = new TagLib.File[filePaths.Length];
            SongList = new Song[filePaths.Length];
            joins = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                f[i] = TagLib.File.Create(filePaths[i]);
            }

            for (int i = 0; i < filePaths.Length; i++)
            {
                SongList[i] = new Song();
                // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
                SongList[i].setId(Guid.NewGuid().ToString("N"));
                SongList[i].setTitle(f[i].Tag.Title);
                SongList[i].setArtists(String.Join(", ", f[i].Tag.AlbumArtists));
                SongList[i].setFilePath(filePaths[i]);
                SongList[i].setSongImage();
                SongList[i].setDuration(f[i].Properties.Duration.ToString().Substring(3, 5));
                SongList[i].setDateAdded(DateTime.Now);
                SongList[i].setisLiked();

                object[] array = { SongList[i].getId(), SongList[i].getTitle(), SongList[i].getArtists(),
                SongList[i].getFilePath(), "", SongList[i].getDuration(), SongList[i].getDateAdded().ToString("f")
                , SongList[i].getisLiked() };

                joins[i] = String.Join(";", array);
            }

            //string csv_FilePath = @"C:\Users\tuanb\source\repos\New UI\MediaPlayer\MediaPlayer\Resources\Song.csv";
            //StringBuilder sbOutput = new StringBuilder();
            //sbOutput.AppendLine("sep=;");
            //sbOutput.AppendLine("Id;Title;Artists;FilePath;SongImage;Duration;DateAdded;isLiked");
            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    sbOutput.AppendLine(joins[i]);
            //}
            //File.WriteAllText(csv_FilePath, sbOutput.ToString());
            // File.AppendAllText(csv_FilePath, sbOutput.ToString()); (for appending use)

            int xLoc = 0;
            int yLoc = 100;
            songs = new UserControl_LibrarySong[filePaths.Length];
            for (int i = 0; i < filePaths.Length; i++)
            {
                songs[i] = new UserControl_LibrarySong();
                // songs[i].Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
                songs[i].Location = new Point(xLoc, yLoc);
                songs[i].Dock = DockStyle.Top;
                songs[i].InitializeSongItem(f[i], i + 1);
                yLoc += 100;
                gunaElipsePanel2.Controls.Add(songs[i]);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userControl_LibrarySong1_Load(object sender, EventArgs e)
        {

        }
        public void SortByAtoZ()
        {
            var songlist = new List<Song>(SongList);
            int xLoc = 14;
            int yLoc = 91;
            int idx = 0;
            var res = from song in songlist
                      orderby song.getTitle() ascending
                      group song by song.getTitle()[0];

            foreach (var group in res.Reverse())
            {
                
                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    // songdisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
                    songdisplay.Location = new Point(xLoc, yLoc);
                    TagLib.File temp = TagLib.File.Create(song.getFilePath());
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    yLoc += 100;
                }
                yLoc -= 100;
                GunaElipsePanel category_display = new GunaElipsePanel();
                category_display.Location = new Point(xLoc, yLoc);
                category_display.Dock = DockStyle.Top;
                category_display.Height = 30;
                category_display.BackColor = System.Drawing.Color.FromArgb(216, 243, 220);

                GunaLabel category = new GunaLabel();
                category.Text = group.Key.ToString();
                category.Font = new Font("Inter", 14);
                category.Location = new Point(xLoc, yLoc);
                category.Dock = DockStyle.Top;

                gunaElipsePanel2.Controls.Add(category_display);
                category_display.Controls.Add(category);
            }
        }

        public void SortByDateAdded()
        {
            var songlist = new List<Song>(SongList);
            int xLoc = 14;
            int yLoc = 91;
            int idx = 0;
            var res = from song in songlist
                      orderby song.getDateAdded() ascending
                      group song by song.getDateAdded();

            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    // songdisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
                    songdisplay.Location = new Point(xLoc, yLoc);
                    TagLib.File temp = TagLib.File.Create(song.getFilePath());
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    yLoc += 100;
                }
                yLoc -= 100;
                GunaElipsePanel category_display = new GunaElipsePanel();
                category_display.Location = new Point(xLoc, yLoc);
                category_display.Dock = DockStyle.Top;
                category_display.Height = 30;
                category_display.BackColor = System.Drawing.Color.FromArgb(216, 243, 220);

                GunaLabel category = new GunaLabel();
                category.Text = group.Key.ToString();
                category.Font = new Font("Inter", 14);
                category.Location = new Point(xLoc, yLoc);
                category.Dock = DockStyle.Top;

                gunaElipsePanel2.Controls.Add(category_display);
                category_display.Controls.Add(category);
            }
        }

        public void SortByArtist()
        {
            var songlist = new List<Song>(SongList);
            int xLoc = 14;
            int yLoc = 91;
            int idx = 0;
            var res = from song in songlist
                      orderby song.getArtists() ascending
                      group song by song.getArtists();

            foreach (var group in res.Reverse())
            {

                foreach (var song in group.Reverse())
                {
                    UserControl_LibrarySong songdisplay = new UserControl_LibrarySong();
                    // songdisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
                    songdisplay.Location = new Point(xLoc, yLoc);
                    TagLib.File temp = TagLib.File.Create(song.getFilePath());
                    songdisplay.Dock = DockStyle.Top;
                    songdisplay.InitializeSongItem(temp, idx++);
                    gunaElipsePanel2.Controls.Add(songdisplay);
                    yLoc += 100;
                }
                yLoc -= 100;
                GunaElipsePanel category_display = new GunaElipsePanel();
                category_display.Location = new Point(xLoc, yLoc);
                category_display.Dock = DockStyle.Top;
                category_display.Height = 30;
                category_display.BackColor = System.Drawing.Color.FromArgb(216, 243, 220);

                GunaLabel category = new GunaLabel();
                category.Text = group.Key.ToString();
                category.Font = new Font("Inter", 14);
                category.Location = new Point(xLoc, yLoc);
                category.Dock = DockStyle.Top;

                gunaElipsePanel2.Controls.Add(category_display);
                category_display.Controls.Add(category);
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                gunaElipsePanel2.Controls.Remove(songs[i]);
            }
            string selectedChoice = gunaComboBox1.SelectedItem.ToString();
            if (selectedChoice == "A to Z") SortByAtoZ();
            else if (selectedChoice == "Date added") SortByDateAdded();
            //else if (selectedChoice == "Album") SortByAlbum(selectedChoice);
            else if (selectedChoice == "Artist") SortByArtist();
        }
    }
}
