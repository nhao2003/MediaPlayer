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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
                fileNames = openFileDialog.SafeFileNames;
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
                SongList[i].getFilePath(), SongList[i].getDuration(), SongList[i].getDateAdded()
                , SongList[i].getisLiked() };

                joins[i] = String.Join(", ", array);
            }

            //using (var writer = new StreamWriter("Songs.csv"))
            //using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            //{
            //    csv.WriteField("Id");
            //    csv.WriteField("Title");
            //    csv.WriteField("Artists");
            //    csv.WriteField("FilePath");
            //    csv.WriteField("Duration");
            //    csv.WriteField("DateAdded");
            //    csv.WriteField("isLiked");
            //    for (int i = 0; i < filePaths.Length; i++)
            //    {
            //        string[] write = joins[i].Split(',');
            //        csv.WriteRecord(write.AsEnumerable());
            //    }
            //}
  
        }


    }
}
