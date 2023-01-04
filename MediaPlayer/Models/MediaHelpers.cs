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
        private static List<int> listIndexDefalt = new List<int>();// list index of playQueue
        public static bool isPlayingPlaylist = false;
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
            get => playQueue;
        }
        
        public static void PlayThePlaylist(Playlist pl)
        {
            isPlayingPlaylist = true;
            playQueue.Clear();
            playQueue = new List<Media>(pl.ListMedia);
            Form_Main.Instance.ClassifyMedia(playQueue[0]);
        }
        /// <summary>
        /// list index of playQueue
        /// </summary>
        public static List<int> ListIndexPlayQueue
        {
            get
            {
                listIndexDefalt.Clear();
                // genera new list index of song
                for (int i = 0; i < PlayQueue.Count; i++)
                {
                    listIndexDefalt.Add(i);
                }
                return listIndexDefalt;
            }
        }
        /// <summary>
        /// Add a media to play queue
        /// if media is exit, remote this and add to the last position
        /// </summary>
        /// <param name="media"></param>
        public static void AddToQueue(Media media)
        {
            // check media is exit, if exit => remote
            for (int i = 0; i < PlayQueue.Count; i++)
            {
                if (PlayQueue[i].FilePath == media.FilePath)
                {
                    PlayQueue.Remove(PlayQueue[i]);
                }
            }
            PlayQueue.Add(media);
            Form_Main.Instance.MediaControl.UpdateListIndexPlay();
        }
        /// <summary>
        /// add this media next to the current media is playing
        /// </summary>
        /// <param name="media"></param>
        public static void AddNextToCurrrentPlaying(Media media)
        {
            // check media is exit, if exit => remote
            for (int i = 0; i < PlayQueue.Count; i++)
            {
                if (PlayQueue[i].FilePath == media.FilePath)
                {
                    PlayQueue.Remove(PlayQueue[i]);
                }
            }
            // insert this media next to current playing
            PlayQueue.Insert(CurrentIndex+1, media);
            Form_Main.Instance.MediaControl.UpdateListIndexPlay();
        }
        /// <summary>
        /// Random mode
        /// </summary>
        /// <returns></returns>
        public static List<int> ListRanDomIndex
        {
            get
            {
                Random random = new Random();
                List<int> listRanIndex = new List<int>(ListIndexPlayQueue);
                listRanIndex.Remove(CurrentIndex);
                int n = listRanIndex.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    int value = listRanIndex[k];
                    listRanIndex[k] = listRanIndex[n];
                    listRanIndex[n] = value;
                }
                listRanIndex.Insert(0, CurrentIndex);
                return listRanIndex;
            }
        }
        /// <summary>
        /// index of current index of song is playing
        /// </summary>
        public static int CurrentIndex
        {
            get
            {
                for (int i = 0; i < PlayQueue.Count; i++)
                {
                    if (PlayQueue[ListIndexPlayQueue[i]].FilePath == PlayMedia.Path)
                    {
                        return i;
                    }
                }
                return -1;
            }
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
