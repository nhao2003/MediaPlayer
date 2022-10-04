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
        private String id;
        private String name;
        private List<Song> listSongs;
        private int numOfSong;
        private Image backroundImage;
        private DateTime dateCreated;

        public Playlist(String name,
                        List<Song> listSongs,
                        int numOfSong,
                        Image backroundImage,
                        DateTime dateCreated)
        {
            this.id = Guid.NewGuid().ToString("N");
            this.name = name;
            this.listSongs = listSongs;
            this.numOfSong = numOfSong;
            this.backroundImage = backroundImage;
            this.dateCreated = dateCreated;
        }
    }
}
