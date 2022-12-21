using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using File = TagLib.File;

namespace MediaPlayer.Models
{
    public class Playlist
    {
        private String playListID;
        private String playListName;
        private List<Media> listMedia = new List<Media>();
        private string backroundImageFillName = null;
        private DateTime dateCreated;
        private static string ImageBackgroundFolder = $@"C:\Users\{Environment.UserName}\Documents\Media Player\PLay List Image Background";
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
                file.CopyTo(backroundImageFillName, true);
                backroundImageFillName = value;
            }
            get => backroundImageFillName;
        }
        public Image BackGroundImage => Image.FromFile(backroundImageFillName);
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
        public Playlist(String name = "Unnamed", string backroundImageFillName = null , List<Media> listMedia = null)
        {
            this.playListID = Guid.NewGuid().ToString("N");
            this.playListName = name;
            this.backroundImageFillName = backroundImageFillName;
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
