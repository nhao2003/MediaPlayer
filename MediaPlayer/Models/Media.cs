using MediaPlayer.Properties;
using System;
using System.Drawing;
using System.IO;
using TagLib;


namespace MediaPlayer.Models
{
    /// <summary>
    /// Đây là class Song chứa các thông tin một bài nhạc
    /// </summary>
    public class Media
    {
        private string id;
        private string title;
        private string artists;
        private string album;
        private string filePath;
        private Image image;
        private TimeSpan duration;
        private DateTime dateAdded;
        private bool isLiked = false;
        private TagLib.File others;
        private MediaTypes mediaType;
        public MediaTypes MediaTypes { get { return mediaType; } }
        /// <summary>
        /// Lấy ID
        /// </summary>
        public string Id => id;
        /// <summary>
        /// Tên playlist
        /// </summary>
        public string Title
        {
            set => title = value;
            get
            {
                if (title == null) return "Unknown";
                return title;
            }
        }
        /// <summary>
        /// Tên ca sĩ
        /// </summary>
        public string Artists
        {
            set => artists = value;
            get
            {
                if (artists == null) return "Unknown";
                return artists;
            }
        }
        public string Album
        {
            set => album = value;
            get
            {
                if (album == null) return "Unknown";
                return album;
            }
        }
        /// <summary>
        /// Ảnh bài hát
        /// </summary>
        public Image Image
        {
            set => image = value;
            get
            {
                return image;
            }
        }
        /// <summary>
        /// Duration dưới dạng TimeSpan
        /// Muốn lấy tổng thời gian gian tính bằng dây có thể dùng duration.TotalSeconds
        /// </summary>
        public TimeSpan Duration
        {
            set => duration = value;
            get
            {
                return duration;
            }
        }
        /// <summary>
        /// Ngày thêm nhạc
        /// </summary>
        public DateTime DateAdded
        {
            set => dateAdded = value;
            get
            {
                return dateAdded;
            }
        }
        /// <summary>
        /// Lấy thông tin yêu thích
        /// </summary>
        public bool IsLiked
        {
            set => isLiked = value;
            get
            {
                return isLiked;
            }
        }
        /// <summary>
        /// Lấy patch của bài hát
        /// </summary>
        public string FilePath
        {
            set => filePath = value;
            get
            {
                return filePath;
            }
        }
        /// <summary>
        /// Lấy duration bài hát dưới dạng text
        /// Ví dụ: 03:18
        /// </summary>
        public string DurationText
        {
            get
            {
                string durationText = "";
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


        /// <summary>
        /// Khởi tạo bài hát
        /// </summary>
        /// <param name="title">Tên bài hát</param>
        /// <param name="artist">Nghệ sĩ</param>
        /// <param name="duration">Thời lượng</param>
        /// <param name="dateAdded">Ngày thêm</param>
        /// <param name="path">Đường dẫn</param>
        /// <param name="mediaImage">Ảnh</param>
        public Media(string title, string artist, TimeSpan duration, DateTime dateAdded, string path, Image mediaImage)
        {
            this.id = Guid.NewGuid().ToString("N");
            this.title = (title != null) ? title : "Unknown";
            this.artists = (artist != null) ? artist : "Unknown";
            this.album = (album != null) ? album : "Unknown";
            this.duration = (duration != null) ? duration : new TimeSpan(0, 0, 0);
            this.dateAdded = System.IO.File.GetCreationTime(path);
            this.filePath = path;
            this.image = mediaImage;
            this.others = TagLib.File.Create(path);
        }
        /// <summary>
        /// Tạo bài hát bằng đường dẫn
        /// </summary>
        /// <param name="path">Đường dẫn bài hát</param>
        public Media(string path)
        {
            TagLib.File taglib = TagLib.File.Create(path);
            this.id = Guid.NewGuid().ToString("N");
            this.title = (taglib.Tag.Title != null) ? taglib.Tag.Title.ToString() : Path.GetFileNameWithoutExtension(path);
            this.artists = (taglib.Tag.Album != null) ? string.Join(", ", taglib.Tag.Album) : "Unknow";
            this.duration = (taglib.Properties.Duration != null) ? taglib.Properties.Duration : new TimeSpan(0, 0, 0);
            this.dateAdded = System.IO.File.GetCreationTime(path);
            this.filePath = path;
            this.mediaType = taglib.Properties.MediaTypes;
            this.others = taglib;

            if (taglib.Tag.Pictures.Length > 0)
            {
                var bin = (byte[])(taglib.Tag.Pictures[0].Data.Data);
                this.image = Image.FromStream(new MemoryStream(bin));
            }
            else
            {
                try
                {
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                    string fileName = "video_thumbnail" + title + ".jpg";
                    if (System.IO.File.Exists(fileName) == false)
                    {
                        ffMpeg.GetVideoThumbnail(path, fileName, 5);
                    }
                    this.image = Image.FromFile(fileName);
                }
                catch
                {
                    this.image = Resources.defaultImage;
                }
            }
        }
        public void Like()
        {
            isLiked = !isLiked;
        }

        public Media()
        {
            this.id = Guid.NewGuid().ToString("N");
        }

    }
}