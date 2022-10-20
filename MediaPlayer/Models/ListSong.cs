using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Models
{
    static class ListSong
    {
        static public List<Song> listSongs = new List<Song>();
        static string[] filePaths;
        static string[] fileNames;
        static string[] joins;
        static TagLib.File[] f;
        static public void fetchListSong()
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
            joins = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                f[i] = TagLib.File.Create(filePaths[i]);
            }

            Song tmp;
            for (int i = 0; i < filePaths.Length; i++)
            {

                // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
                //tmp = new Song(
                //    name:f[i].Tag.Title,
                //    String.Join(", ", f[i].Tag.AlbumArtists),
                //    filePaths[i],
                //    f[i].Properties.
                //        );
                //tmp.setId(Guid.NewGuid().ToString("N"));
                //tmp.setTitle(f[i].Tag.Title);
                //tmp.setArtists(String.Join(", ", f[i].Tag.AlbumArtists));
                //tmp.setFilePath(filePaths[i]);
                //tmp.setSongImage();
                //tmp.setDuration(f[i].Properties.Duration.ToString().Substring(3, 5));
                //tmp.setDateAdded(DateTime.Now);
                //tmp.setisLiked();
                //listSongs.Add(tmp);
            }

            foreach (Song x in ListSong.listSongs)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
