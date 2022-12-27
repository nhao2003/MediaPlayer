﻿using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MediaPlayer.Models
{
    public class Playlist
    {
        private string playListID;
        private string playListName;
        private List<Media> listMedia = new List<Media>();
        private string backroundImageFileName = null;
        private DateTime dateCreated;
        private static readonly string ImageBackgroundFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Media Player\\Play List Image";
        public string PlayListID => playListID;

        public string PlayListName
        {
            get => playListName;
            set => playListName = value;
        }

        public string BackroundImageFileName
        {
            set
            {
                try
                {
                    FileInfo file = new FileInfo(value);
                    string FileName = playListID + file.Extension;
                    if (backroundImageFileName == null)
                        backroundImageFileName = Path.Combine(ImageBackgroundFolder, FileName);
                    Directory.CreateDirectory(ImageBackgroundFolder);
                    if (File.Exists(backroundImageFileName))
                        File.Copy(value, backroundImageFileName, true);
                    else
                        File.Copy(value, backroundImageFileName);
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm ảnh! Vui lòng thử tắt chương trình diệt Virus!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            get => backroundImageFileName;
        }

        public Image BackGroundImage => backroundImageFileName == null ? Resources.defaultImage : Image.FromFile(backroundImageFileName);

        public List<Media> ListMedia
        {
            get => listMedia;
            set => listMedia = value;
        }

        public DateTime DateCreated
        {
            set => dateCreated = value;
            get { return dateCreated; }
        }
        public Playlist(string name = "Unnamed", string backroundImageFileName = null, List<Media> listMedia = null)
        {
            playListID = Guid.NewGuid().ToString("N");
            playListName = name;
            this.backroundImageFileName = backroundImageFileName;
            dateCreated = DateTime.Now;
            if (listMedia != null)
                ListMedia = listMedia;
        }

        public static IEnumerable<IGrouping<char, Media>> SortListAToZ(List<Media> list)
        {
            IEnumerable<IGrouping<char, Media>> res = from song in list
                                                      orderby song.Title ascending
                                                      group song by song.Title[0];
            return res.Reverse();
        }

        public static IEnumerable<IGrouping<string, Media>> SortListDateAdded(List<Media> list)
        {
            IEnumerable<IGrouping<string, Media>> res = from song in list
                                                        orderby song.DateAdded ascending
                                                        group song by song.DateAdded.ToString("dd/MM/yyyy");
            return res.Reverse();
        }

        public static IEnumerable<IGrouping<string, Media>> SortListAlbum(List<Media> list)
        {
            IEnumerable<IGrouping<string, Media>> res = from song in list
                                                        orderby song.Album ascending
                                                        group song by song.Album;
            return res.Reverse();
        }

        public static IEnumerable<IGrouping<string, Media>> SortListArtists(List<Media> list)
        {
            IEnumerable<IGrouping<string, Media>> res = from song in list
                                                        orderby song.Artists ascending
                                                        group song by song.Artists;
            return res.Reverse();
        }
    }
}
