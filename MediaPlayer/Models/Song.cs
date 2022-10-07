using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.Models
{
    internal class Song
    {
        // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
        // thuộc tính
        private String Id; // id is unique
        private String Title;
        private String Artists;
        private String FilePath;
        private Image SongImage; // Ảnh bìa
        private string Duration; // thời lượng bài hát
        private DateTime DateAdded; // ngày thêm bài hát
        private bool isLiked; // check bài hát được thích hay chưa

        public string getId()
        {
            return Id;
        }
        public void setId(string id)
        {
            this.Id = id;
        }

        public string getTitle()
        {
            return Title;
        }
        public void setTitle(string title)
        {
            this.Title = title;
        }

        public string getArtists()
        {
            return Artists;
        }
        public void setArtists(string artists)
        {
            this.Artists = artists;
        }

        public string getFilePath()
        {
            return FilePath;
        }
        public void setFilePath(string filepath)
        {
            this.FilePath = filepath;
        }

        public Image getSongImage()
        {
            return SongImage;
        }
        public void setSongImage(Image image = null)
        {
            this.SongImage = image;
        }

        public string getDuration()
        {
            return Duration;
        }
        public void setDuration(string duration)
        {
            this.Duration = duration;
        }

        public DateTime getDateAdded()
        {
            return DateAdded;
        }
        public void setDateAdded(DateTime addedTime)
        {
            this.DateAdded = addedTime;
        }
        public bool getisLiked()
        {
            return isLiked;
        }
        public void setisLiked(bool isLiked = false)
        {
            this.isLiked = isLiked;
        }
        public Song()
        {
            // SongImage = null;
        }
        // Phương thức
        // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
        public Song(String name, 
                    String author,
                    String artist,
                    String path, 
                    string duration,
                    DateTime dateAdded,
                    Image SongImage = null)
        {
            this.Id = Guid.NewGuid().ToString("N");
            this.Title = name;
            this.Artists = author;
            this.FilePath = path;

            this.SongImage = SongImage;
            this.Duration = duration;
            this.DateAdded = dateAdded;
            this.isLiked = false;
            //(SongImage == null) ? 
            //    this.SongImage = Image.FromFile(".\\MediaPlayer\\MediaPlayer\\Resources\\defaultImage.jpg") : 
            //    this.SongImage = SongImage;
        }


        // phuong thuc like
        public void LikedSong(bool check = true)
        {
            this.isLiked = check;
        }

    }
}
