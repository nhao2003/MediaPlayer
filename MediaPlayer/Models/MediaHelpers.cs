using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Models
{
    static class MediaHelpers
    {
        private static string userName = Environment.UserName;
        private static string musicPathFolder = $"C:\\Users\\{userName}\\Music";
        private static string videoPathFolder = $"C:\\Users\\{userName}\\Videos";
        /// <summary>
        /// List các bài nhạc
        /// </summary>
        public static List<Media> listSongs = new List<Media>();
        /// <summary>
        /// List các video
        /// </summary>
        public static List<Media> listVideos = new List<Media>();
        /// <summary>
        /// Đường dẫn thư mục nhạc
        /// </summary>
        public static string MusicPathFolder
        {
            set
            {
                musicPathFolder = value;
            }
            get
            { return musicPathFolder; }
        }
        /// <summary>
        /// Đường dẫn thư mục video
        /// </summary>
        public static string VideoPathFolder
        {
            set
            {
                videoPathFolder = value;
            }
            get { return videoPathFolder; }
        }
        /// <summary>
        /// Duyệt các Nhạc hoặc Video
        /// </summary>
        /// <param name="mediaTypes"></param>
        /// <exception cref="Exception"></exception>
        public static void FetchListMedia(MediaTypes mediaTypes)
        {
            string SearchPattern;
            string path;
            if (mediaTypes == MediaTypes.Audio)
            {
                SearchPattern = "*.mp3";
                path = musicPathFolder;
                listSongs = new List<Media>();
            }
            else if (mediaTypes == MediaTypes.Video)
            {
                SearchPattern = "*.mp4";
                path = videoPathFolder;
                listVideos = new List<Media>();
            }
            else
            {
                throw new Exception("MediaTypes is invalid");
            }
            string[] filePaths = {};
            // chon file =======================================================
            try
            {
                filePaths = System.IO.Directory.GetFiles(
                    path,
                    SearchPattern,
                    System.IO.SearchOption.AllDirectories);
            }
            catch
            {
                MessageBox.Show("Duong dan" + path + " khong ton tai");
            }
            //===================================================================
            Media tmp;
            for (int i = 0; i < filePaths.Length; i++)
            {
                try
                {
                    tmp = new Media(filePaths[i]);
                    if (mediaTypes == MediaTypes.Audio) listSongs.Add(tmp);
                    else listVideos.Add(tmp);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}
