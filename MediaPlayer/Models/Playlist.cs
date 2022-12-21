﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MediaPlayer.Properties;

namespace MediaPlayer.Models
{
    public class Playlist
    {
        private String playListID;
        private String playListName;
        private List<Media> listMedia = new List<Media>();
        private string backroundImageFileName = null;
        private DateTime dateCreated;
        private static string ImageBackgroundFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Media Player", "Play List Image");
        public String PlayListID => playListID;

        public String PlayListName
        {
            get => playListName;
            set => playListName = value;
        }

        public string BackroundImageFileName
        {
            set
            {
                FileInfo file = new FileInfo(value);
                string FileName = playListID + file.Extension;
                if (backroundImageFileName == null)
                    backroundImageFileName = Path.Combine(ImageBackgroundFolder, FileName);
                if (!Directory.Exists(ImageBackgroundFolder))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(backroundImageFileName));
                }
                if(!File.Exists(backroundImageFileName))
                    File.Delete(backroundImageFileName);
                File.Copy(value, backroundImageFileName);
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
        public Playlist(String name = "Unnamed", string backroundImageFileName = null , List<Media> listMedia = null)
        {
            this.playListID = Guid.NewGuid().ToString("N");
            this.playListName = name;
            this.backroundImageFileName = backroundImageFileName;
            this.dateCreated = DateTime.Now;
            if(listMedia != null)
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
