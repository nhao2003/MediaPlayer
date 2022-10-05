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
        // thuộc tính
        private String id; // id is unique
        private String name;
        private String author;
        private String path;
        private Image SongImage; // Ảnh bìa
        private double duration; // thời lượng bài hát
        private DateTime dateAdded; // ngày thêm bài hát
        private bool liked; // check bài hát được thích hay chưa

        // Phương thức
        public Song(String name, 
                    String author, 
                    String path, 
                    Image SongImage, 
                    double duration,
                    DateTime dateAdded)
        {
            this.id = Guid.NewGuid().ToString("N");
            this.name = name;
            this.author = author;
            this.path = path;
            this.SongImage = SongImage;
            this.duration = duration;
            this.dateAdded = dateAdded;
            this.liked = false;
            //(SongImage == null) ? 
            //    this.SongImage = Image.FromFile(".\\MediaPlayer\\MediaPlayer\\Resources\\defaultImage.jpg") : 
            //    this.SongImage = SongImage;
        }

        // phuong thuc like
        public void LikedSong(bool check = true)
        {
            this.liked = check;
        }

    }
}
