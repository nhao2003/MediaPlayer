using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MediaPlayer.Models
{
    /// <summary>
    /// Đây là class Song chứa các thông tin một bài nhạc
    /// </summary>
    public class Song
    {
        private String id;
        private String title;
        private String artists;
        private String filePath;
        private Image image;
        private TimeSpan duration;
        private DateTime dateAdded;
        private bool isLiked = false;
        private TagLib.File others;
        public String Id { get; }
        /// <summary>
        /// Tên bài hát
        /// </summary>
        public String Title
        {
            get
            {
                if (title == null) return "Unknown";
                return title;
            }
        }
        /// <summary>
        /// Tên ca sĩ
        /// </summary>
        public String Artists {
            get
            {
                if (artists == null) return "Unknown";
                return artists;
            }
        }
        /// <summary>
        /// Ảnh bài hát
        /// </summary>
        public Image Image => image;
        /// <summary>
        /// Duration dưới dạng TimeSpan
        /// Muốn lấy tổng thời gian gian tính bằng dây có thể dùng duration.TotalSeconds
        /// </summary>
        public TimeSpan Duration => duration;
        /// <summary>
        /// Ngày thêm nhạc
        /// </summary>
        public DateTime DateAdded => dateAdded;
        /// <summary>
        /// Lấy thông tin yêu thích
        /// </summary>
        public bool IsLiked => isLiked;
        /// <summary>
        /// Lấy patch của bài hát
        /// </summary>
        public String FilePath => filePath;
        /// <summary>
        /// Lấy duration bài hát dưới dạng text
        /// Ví dụ: 03:18
        /// </summary>
        public String DurationText
        {
            get
            {
                String durationText = "";
                if (duration.Minutes < 10)
                    durationText += 0;
                durationText += duration.Minutes.ToString() + ':';
                if (duration.Seconds < 10)
                    durationText += 0;
                durationText += duration.Seconds.ToString();
                return durationText;
            }
        }
        /// <summary>
        /// Các thông tin khác
        /// </summary>
        public TagLib.File Others => others;

        //public Song()
        //{
        //}

        /// <summary>
        /// Khởi tạo bài hát
        /// </summary>
        /// <param name="title">Tên bài hát</param>
        /// <param name="artist">Nghệ sĩ</param>
        /// <param name="duration">Thời lượng</param>
        /// <param name="dateAdded">Ngày thêm</param>
        /// <param name="path">Đường dẫn</param>
        /// <param name="songImage">Ảnh</param>
        public Song(string title, string artist, TimeSpan duration, DateTime dateAdded, string path, Image songImage)
        {
            this.title = title;
            this.artists = artist;
            this.duration = duration;
            this.dateAdded = dateAdded;
            this.filePath = path;
            this.image = songImage;
            this.others = TagLib.File.Create(path);
        }

        public void Like()
        {
            isLiked = !isLiked;
        }

    }
}
