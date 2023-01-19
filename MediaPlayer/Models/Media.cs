using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using TagLib;
using System.Windows.Forms;
namespace MediaPlayer.Models
{
    /// <summary>
    /// Đây là class Song chứa các thông tin một bài nhạc
    /// </summary>
    public class Media
    {
        private string title;
        private List<string> artists;
        private string album;
        private string filePath;
        private Image image;
        private TimeSpan duration;
        private DateTime dateAdded;
        private TagLib.File others;
        private MediaTypes mediaType;
        public MediaTypes MediaTypes { get { return mediaType; } }
        public string PlaylistID = null;
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
        public List<string> Artists
        {
            set => artists = value;
            get
            {
                if (artists == null)
                {
                    artists = new List<string>()
                    {
                        "Unknown"
                    };
                }
                return artists;
            }
        }
        public string ArtistsString
        {
            get
            {
                if(artists == null)
                {
                    return "Unknown";
                }
                string txt = "";
                for (int i = 0; i < artists.Count; i++)
                {
                    txt += artists[i].Trim();
                    if(i+1 < artists.Count)
                    {
                        txt += ", ";
                    }
                }
                return txt;
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
        /// Tạo bài hát bằng đường dẫn
        /// </summary>
        /// <param name="path">Đường dẫn bài hát</param>
        [Obsolete]
        public Media(string path)
        {
            TagLib.File taglib = TagLib.File.Create(path);
            this.title = (taglib.Tag.Title != null) ? taglib.Tag.Title.ToString() : Path.GetFileNameWithoutExtension(path);
            this.artists = (taglib.Tag.Artists.Length != 0) ? taglib.Tag.Artists[0].Split(',').ToList():null;
            this.duration = (taglib.Properties.Duration != null) ? taglib.Properties.Duration : new TimeSpan(0, 0, 0);
            this.dateAdded = System.IO.File.GetCreationTime(path);
            this.filePath = path;
            this.mediaType = taglib.Properties.MediaTypes;
            this.album = taglib.Tag.Album;
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
                    string thumbnailPath = "video_thumbnail" + title + ".jpg";
                    if (!System.IO.File.Exists(thumbnailPath))
                    {
                        ffMpeg.GetVideoThumbnail(path, thumbnailPath, 5);
                    }
                    this.image = Image.FromFile(thumbnailPath);
                }
                catch
                {
                    this.image = Resources.defaultImage;
                }
            }
        }
        public Media()
        {

        }
    }
}