using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.Models
{
    internal class Playlist
    {
        private String Id;
        private String ListName;
        private List<Song> ListSongs;
        private int NumOfSong;
        private Image BackroundImage;
        private DateTime DateCreated;

        public Playlist(String name,
                        List<Song> listSongs,
                        int numOfSong,
                        Image backroundImage,
                        DateTime dateCreated)
        {
            this.Id = Guid.NewGuid().ToString("N");
            this.ListName = name;
            this.ListSongs = listSongs;
            this.NumOfSong = numOfSong;
            this.BackroundImage = backroundImage;
            this.DateCreated = dateCreated;
        }
    }
}
