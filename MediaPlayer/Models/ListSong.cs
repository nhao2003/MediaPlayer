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
        public static string pathFolder = "C:\\users\\haosi\\Music";
        public static List<Song> listSongs = new List<Song>();
        public static void FetchListSong()
        {
            string[] filePaths;
            // chon file =======================================================
            filePaths = System.IO.Directory.GetFiles(
                pathFolder,
                "*.mp3",
                System.IO.SearchOption.AllDirectories);
            //===================================================================
            Song tmp;
            for (int i = 0; i < filePaths.Length; i++)
            {
                try
                {
                    tmp = new Song(filePaths[i]);
                    listSongs.Add(tmp);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("An error occured ");
                    MessageBox.Show(ex.ToString(), filePaths.Length.ToString() + i.ToString());
                }
            }
        }
    }
}
