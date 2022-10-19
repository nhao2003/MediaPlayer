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

            int xLoc = 14;
            int yLoc = 91;
            songs = new UserControl_LibrarySong[filePaths.Length];
            for (int i = 0; i < filePaths.Length; i++)
            {
                songs[i] = new UserControl_LibrarySong();
                // songs[i].Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
                songs[i].Location = new Point(xLoc, yLoc);
                songs[i].Dock = DockStyle.Top;
                songs[i].InitializeSongItem(f[i], filePaths.Length - i);
                yLoc += 100;
                gunaElipsePanel2.Controls.Add(songs[i]);
            }

            //gunaDataGridView1.Rows.Add(filePaths.Length);
            //int id = 1;
            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    gunaDataGridView1.Rows[i].Cells[0].Value = id++;
            //    gunaDataGridView1.Rows[i].Cells[1].Value = Image.FromFile(@"C:\Users\tuanb\source\repos\LibraryBranch\MediaPlayer\MediaPlayer\Resources\921f72eb0b0a345c3ffe1e83283037ab.png");
            //    gunaDataGridView1.Rows[i].Cells[2].Value = SongList[i].getTitle() + Environment.NewLine + SongList[i].getArtists();
            //    gunaDataGridView1.Rows[i].Cells[3].Value = SongList[i].getDateAdded().ToShortDateString();
            //    if (SongList[i].getisLiked()) gunaDataGridView1.Rows[i].Cells[3].Value = Image.FromFile(@"C:\Users\tuanb\source\repos\LibraryBranch\MediaPlayer\MediaPlayer\Resources\heart (1).png");
            //    else gunaDataGridView1.Rows[i].Cells[4].Value = Image.FromFile(@"C:\Users\tuanb\source\repos\LibraryBranch\MediaPlayer\MediaPlayer\Resources\heart.png");
            //    gunaDataGridView1.Rows[i].Cells[5].Value = SongList[i].getDuration();
            //}
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
        public void SortByAtoZ(string selectedItem)
        {
            var songlist = new List<Song>(SongList);
            int xLoc = 14;
            int yLoc = 91;
            int idx = 1;
            var res = from song in songlist
                      orderby song.getTitle() ascending
                      group song by song.getTitle()[0];
            foreach (var group in res)
            {
                GunaLabel category = new GunaLabel();
                category.Text = group.Key.ToString();
                category.Location = new Point(xLoc, yLoc);
                gunaElipsePanel2.Controls.Add(category);
                yLoc += 5;
                foreach (var song in songlist)
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

            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                gunaElipsePanel2.Controls.Remove(songs[i]);
            }
            string selectedChoice = gunaComboBox1.SelectedItem.ToString();
            if (selectedChoice == "A to Z") SortByAtoZ(selectedChoice);
            //else if (selectedChoice == "Date aded") SortByDateAdded(selectedChoice);
            //else if (selectedChoice == "Album") SortByAlbum(selectedChoice);
            //else if (selectedChoice == "Artist") SortByArtist(selectedChoice);
        }
    }
}
