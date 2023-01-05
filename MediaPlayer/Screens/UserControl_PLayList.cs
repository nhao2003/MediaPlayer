using MediaPlayer.Items;
using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TagLib;
using Guna.UI.WinForms;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_PlayList : UserControl
    {
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;

        /// <summary>
        /// Get or Set UserControl MediaList Title
        /// </summary>
        public string Title
        {
            get => lb_Title.Text;
            set
            {
                lb_Title.Text = value;
            }
        }

        private MediaTypes _mediaTypeOfScreen;
        private Playlist _playlist = new Playlist();
        private List<Media> _listMedia = new List<Media>();
        public Playlist Playlist
        {
            get => _playlist;
            set
            {
                _playlist= value;
                lb_Title.Text = _playlist.PlayListName;
                _listMedia = _playlist.ListMedia;
                gunaPanel2.GradientColor1 = ImageTools.GetDominantColor(_playlist.BackGroundImage as Bitmap);
                pic_Avatar.Image = _playlist.BackGroundImage;
                CaculateDuration();
                GetAuthors();
                //DisplayMediaItems(Playlist.SortListAToZ(_playlist.ListMedia));
                DisplayMediaItems(_listMedia);
            }
        }
        private void CaculateDuration()
        {
            int sum = 0;
            _listMedia.ForEach(media =>
            {
                sum += media.Duration.Minutes;
            });
            lb_SumDuration.Text = $"{_listMedia.Count} Media";
            if (_listMedia.Count > 1)
                lb_SumDuration.Text += "s ";
            if(sum < 60)
                lb_SumDuration.Text += $"● About {sum} minutes.";
            else if(sum/60 < 2)
                lb_SumDuration.Text += $"● About 1 hour {sum / 60} minutues";
            else
                lb_SumDuration.Text += $"● About {sum / 60} hours {sum / 60} minutues";
        }
        private void GetAuthors()
        {
            string a = "";
            int i = 0;
            foreach(Media media in _listMedia)
            {
                if (i > 1)
                {
                    a += media.Artists;
                    break;
                }
                else
                {
                    a += media.Artists + ", ";
                }
                i++;
            }
            if (_listMedia.Count > 3) a += " and more";
            lb_authors.Text = a;
        }
        public void setMediaType()
        {
            if (_listMedia.Equals(MediaHelpers.listSongs))
            {
                _mediaTypeOfScreen = MediaTypes.Audio;
            }
            else if (_listMedia.Equals(MediaHelpers.listVideos))
            {
                _mediaTypeOfScreen = MediaTypes.Video;
            }
        }
        private void DisplayMediaItems<T>(IEnumerable<IGrouping<T, Media>> sortResult)
        {
            pn_Display.Controls.Clear();
            try
            {
                foreach (var group in sortResult)
                {

                    GroupMedia temp = new GroupMedia(group.Key.ToString(), group.ToList());
                    temp.Dock = DockStyle.Top;
                    pn_Display.Controls.Add(temp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayMediaItems(List<Media> list)
        {
            try
            {
                pn_Songs.Controls.Clear();
                int top = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    top = i*75;
                    MusicRow musicRow = new MusicRow()
                    {
                        Location = new Point(100, top),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        Dock = DockStyle.Top,
                    };
                    musicRow.Media = list[i];
                    pn_Songs.Controls.Add(musicRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<string> filePaths = new List<string>();

        public UserControl_PlayList()
        {
            InitializeComponent();
            //manageSort = new SortHandling(pn_Display as G);
            setMediaType();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        public void UpdateScreen()
        {
            if (this._mediaTypeOfScreen == MediaTypes.Audio)
            {
                _listMedia = MediaHelpers.listSongs;
            }
            else if (this._mediaTypeOfScreen == MediaTypes.Video)
            {
                _listMedia = MediaHelpers.listVideos;
            }
        }
    }
}
