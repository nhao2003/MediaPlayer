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
    }
}
