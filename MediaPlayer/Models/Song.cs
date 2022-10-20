using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.Models
{
    public class Song
    {
        // Id, Title, Artists, FilePath, SongImage, Duration, DateAdded, isLiked
        // thuộc tính
        private String id;
        private String title;
        private String artists;
        private String filePath;
        private Image image; // Ảnh bìa
        private double duration; // thời lượng bài hát
        private DateTime dateAdded; // ngày thêm bài hát
        private bool isLiked; // check bài hát được thích hay chưa

        public String Id { get; }

        public String Title
        {
            get
            {
                if (title == null) return "Unknown";
                return title;
            }
        }
        public String Artists {
            get
            {
                if (artists == null) return "Unknown";
                return artists;
            }
        }
        public Image Image { get; }
        public double Duration { get; }
        public DateTime DateAdded { get; }
        public bool IsLiked { get; }
        public Song()
        {
        }
        public Song(String name, 
                    String author,
                    String artist,
                    String path, 
                    double duration,
                    DateTime dateAdded,
                    Image SongImage = null)
        {
            this.id = Guid.NewGuid().ToString("N");
            this.title = name;
            this.artists = author;
            this.filePath = path;

            this.image = SongImage;
            this.duration = duration;
            this.dateAdded = dateAdded;
            this.isLiked = false;
        }

        public void Like()
        {
            isLiked = !isLiked;
        }

    }
}
