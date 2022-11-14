using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Models
{
    static class ListVideo
    {
        public static string pathFolder = "C:\\Users\\Administrator\\Videos";
        public static List<Song> listVideos = new List<Song>();
        public static void FetchListVideo()
        {
            string[] filePaths = { };
            listVideos = new List<Song>();
            // chon file =======================================================
            try
            {
                filePaths = System.IO.Directory.GetFiles(
                pathFolder,
                "*.mp4",
                System.IO.SearchOption.AllDirectories);
            }
            catch
            {
                MessageBox.Show("Duong dan" + pathFolder + " khong ton tai");
            }
            //===================================================================
            Song tmp;
            for (int i = 0; i < filePaths.Length; i++)
            {
                try
                {
                    tmp = new Song(filePaths[i]);
                    listVideos.Add(tmp);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("An error occured ");
                    MessageBox.Show(ex.ToString(), "Tong so video: " + filePaths.Length.ToString() + " loi o bai: " + i.ToString());
                }
            }
        }
    }
}
