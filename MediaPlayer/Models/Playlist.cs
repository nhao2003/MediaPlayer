using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MediaPlayer.Models
{
    public class Playlist
    {
        private String playListID;
        private String playListName;
        private List<Media> listMedia = new List<Media>();
        private Image backroundImage;
        private DateTime dateCreated;

        public String PlayListID => playListID;

        public String PlayListName
        {
            get => playListName;
            set => playListName = value;
        }

        public Image BackroundImage
        {
            set { backroundImage = value; }
            get { return backroundImage; }
        }

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
        public Playlist(String name = "Unnamed", Image backroundImage = null , List<Media> listMedia = null)
        {
            this.playListID = Guid.NewGuid().ToString("N");
            this.playListName = name;
            this.backroundImage = backroundImage;
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
