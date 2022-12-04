using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MediaPlayer.Models
{
    internal class Playlist
    {
        private String playListID;
        private String playListName;
        private List<Media> listMedia;
        private Image backroundImage;
        private DateTime dateCreated;

        public String PlayListID => playListID;

        public String PlayListName
        {
            get { return playListName; }
            set { playListName = value; }
        }

        public Image BackroundImage
        {
            set { backroundImage = value; }
            get { return backroundImage; }
        }

        public DateTime DateCreated
        {
            set => dateCreated = value;
            get { return dateCreated; }
        }
        public Playlist(String name = "Unknown name")
        {
            this.playListID = Guid.NewGuid().ToString("N");
            this.playListName = name;
            this.dateCreated = DateTime.Now;
        }
    }
}
