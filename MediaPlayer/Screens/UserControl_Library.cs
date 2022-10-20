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

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Library : UserControl
    {
        public UserControl_Library()
        {
            InitializeComponent();
        }
     
        static string[] filePaths;
        static string[] fileNames;
        static string[] joins;
        TagLib.File[] f;
        static Song[] SongList;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            //openFileDialog.Multiselect = true;
            //openFileDialog.Title = "Open";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    filePaths = openFileDialog.FileNames;
            //    fileNames = openFileDialog.SafeFileNames;
            //}

            //f = new TagLib.File[filePaths.Length];
            //SongList = new Song[filePaths.Length];
            //joins = new string[filePaths.Length];

            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    f[i] = TagLib.File.Create(filePaths[i]);
            //}

            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    SongList[i] = new Song();
            //    // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
            //    SongList[i].setId(Guid.NewGuid().ToString("N"));
            //    SongList[i].setTitle(f[i].Tag.Title);
            //    SongList[i].setArtists(String.Join(", ", f[i].Tag.AlbumArtists));
            //    SongList[i].setFilePath(filePaths[i]);
            //    SongList[i].setSongImage();
            //    SongList[i].setDuration(f[i].Properties.Duration.ToString().Substring(3, 5));
            //    SongList[i].setDateAdded(DateTime.Now);
            //    SongList[i].setisLiked();

            //    object[] array = { SongList[i].getId(), SongList[i].getTitle(), SongList[i].getArtists(),
            //    SongList[i].getFilePath(), "", SongList[i].getDuration(), SongList[i].getDateAdded().ToString("f")
            //    , SongList[i].getisLiked() };

            //    joins[i] = String.Join(";", array);
            //}

            //string csv_FilePath = @"C:\Users\tuanb\source\repos\New UI\MediaPlayer\MediaPlayer\Resources\Song.csv";
            //StringBuilder sbOutput = new StringBuilder();
            //sbOutput.AppendLine("sep=;");
            //sbOutput.AppendLine("Id;Title;Artists;FilePath;SongImage;Duration;DateAdded;isLiked");
            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    sbOutput.AppendLine(joins[i]);
            //}
            //File.WriteAllText(csv_FilePath, sbOutput.ToString());
            //// File.AppendAllText(csv_FilePath, sbOutput.ToString()); (for appending use)

            //gunaDataGridView1.Rows.Add(filePaths.Length);
            //int id = 1;
            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    gunaDataGridView1.Rows[i].Cells[0].Value = id++;
            //    gunaDataGridView1.Rows[i].Cells[1].Value = SongList[i].getTitle() + Environment.NewLine + SongList[i].getArtists();
            //    gunaDataGridView1.Rows[i].Cells[2].Value = SongList[i].getDateAdded().ToString("f");
            //    gunaDataGridView1.Rows[i].Cells[3].Value = SongList[i].getisLiked();
            //    gunaDataGridView1.Rows[i].Cells[4].Value = SongList[i].getDuration();
            //}
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
