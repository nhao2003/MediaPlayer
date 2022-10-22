using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Models
{
    static class ListSong
    {
        public static List<Song> listSongs = new List<Song>();
        private static string[] filePaths;
        private static string[] _joins;
        private static TagLib.File[] f;
        public static void FetchListSong()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
            }

            f = new TagLib.File[filePaths.Length];
            _joins = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                f[i] = TagLib.File.Create(filePaths[i]);
            }
            Song tmp;
            for (int i = 0; i < filePaths.Length; i++)
            {
                try
                {
                    var bin = (byte[])(f[i].Tag.Pictures[0].Data.Data);
                    tmp = new Song(
                        title: f[i].Tag.Title.ToString(),
                        artist: String.Join(", ", f[i].Tag.Album),
                        duration: f[i].Properties.Duration,
                        dateAdded: DateTime.Now,
                        path: filePaths[i],
                        songImage: Image.FromStream(new MemoryStream(bin))
                    );
                    listSongs.Add(tmp);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("An error occured ");
                    MessageBox.Show(filePaths.Length.ToString(), i.ToString());
                }
            }
        }
    }
}
