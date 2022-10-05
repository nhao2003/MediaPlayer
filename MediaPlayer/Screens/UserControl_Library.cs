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

            for (int i = 0; i < filePaths.Length; i++)
            {
                f[i] = TagLib.File.Create(filePaths[i]);
            }

            for (int i = 0; i < filePaths.Length; i++)
            {
                // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
                SongList[i].setId(Guid.NewGuid().ToString("N"));
                SongList[i].setTitle(f[i].Tag.Title);
                SongList[i].setArtists(String.Join(", ", f[i].Tag.AlbumArtists));
                SongList[i].setFilePath(filePaths[i]);
                // SongList[i].setSongImage();
                SongList[i].setDuration(f[i].Properties.Duration.ToString().Substring(3, 5));
                SongList[i].setDateAdded(DateTime.Now);
                SongList[i].setisLiked();
                
            }


        }

        
    }
}
