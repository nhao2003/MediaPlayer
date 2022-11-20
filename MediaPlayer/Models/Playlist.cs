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
        private String Id;
        private String ListName;
        private List<Media> listMedia;
        private Image BackroundImage;
        private DateTime DateCreated;
        public Playlist(String name = "Unknown name")
        {
            this.Id = Guid.NewGuid().ToString("N");
            this.ListName = name;
            this.DateCreated = DateTime.Now;
        }
    }
}
