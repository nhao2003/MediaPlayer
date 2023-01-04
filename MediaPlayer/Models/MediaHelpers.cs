using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Models
{
    static class MediaHelpers
    {
        private static PlaylistDatabase database = new PlaylistDatabase();
        private static string userName = Environment.UserName;
        private static string musicPathFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        private static string videoPathFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        private static List<Media> playQueue = new List<Media>();
        public static PlaylistDatabase Database
        {
            set { database = value; }
            get { return database; }
        }
        private static List<Playlist> allPlayList = database.QueryAllPlaylists();
        public static List<Playlist> AllPlayList
        {
            get
            {
                return allPlayList;
            }
        }

        public static void UpdatePlaylist(Playlist playlist)
        {
            int index = MediaHelpers.AllPlayList.FindIndex(pl => pl.PlayListID == playlist.PlayListID);
            if (index > 0)
            {
                allPlayList[index] = playlist;
                Database.UpdatePlaylist(playlist);
            }
        }
        public static void AddPlayList(Playlist playlist)
        {
            if (allPlayList.Exists(x => x.PlayListID == playlist.PlayListID))
            {
                throw new Exception("Playlist trùng ID");
            }
            allPlayList.Add(playlist);
            database.InsertPlaylist(playlist);
        }
        public static void DeletePlayList(Playlist playlist)
        {
            int index = allPlayList.FindIndex(x => x.PlayListID == playlist.PlayListID);
            if (index >= 0)
            {
                database.DeletePlaylist(allPlayList[index].PlayListID);
                allPlayList.RemoveAt(index);
                MessageBox.Show("Đã xóa");
            }
        }
        public static void DeleteMediaFromPlaylist(string mediaPath, string playlistID)
        {
            int index = allPlayList.FindIndex(x => x.PlayListID == playlistID);
            if (index >= 0)
            {
                int indexOfMedia = allPlayList[index].ListMedia.FindIndex(x => x.FilePath == mediaPath);
                allPlayList[index].ListMedia.RemoveAt(indexOfMedia);
            }
            database.DeleteMediaInAPlaylist(mediaPath, playlistID);
        }
        /// <summary>
        /// List các bài nhạc
        /// </summary>
        public static List<Media> listSongs = new List<Media>();
        /// <summary>
        /// List các video
        /// </summary>
        public static List<Media> listVideos = new List<Media>();
        /// <summary>
        /// Danh sách playlist đang chờ.
        /// Có thể chứa nhạc và video.
        /// </summary>
        public static List<Media> PlayQueue
        {
            set => playQueue = value;
            get => PlayQueue;
        }
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
            string[] filePaths = { };
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
                tmp = new Media(filePaths[i]);
                if (mediaTypes == MediaTypes.Audio) listSongs.Add(tmp);
                else listVideos.Add(tmp);
            }
        }
    }
}
