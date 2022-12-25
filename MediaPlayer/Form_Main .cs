using Guna.UI.WinForms;
using MediaPlayer.Items;
using MediaPlayer.Models;
using MediaPlayer.Widgets;
using System;
using System.Drawing;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer
{

    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            userControl_Music.Title = "Music";
            UserControl_Video.Title = "Video";
            userControl_Music.ListMedia = MediaHelpers.listSongs;
            UserControl_Video.ListMedia = MediaHelpers.listVideos;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            userControl_Settings1.rebuild = new UserControl_Settings.Rebuild(rebuildHome);
        }
        private static Form_Main instance = new Form_Main();

        public static Form_Main Instance
        {
            get => instance;
            set => instance = value;
        }
        private GunaButton _oldButton = null;
        private void btn_Page_Click(object sender, EventArgs e)
        {
            GunaButton button = (GunaButton)sender;
            if (_oldButton != null)
            {
                if (button.Text == _oldButton.Text)
                    return;
                _oldButton.Image = (Image)_oldButton.Tag;
                _oldButton.ForeColor = Color.Silver;
            }
            button.ForeColor = Color.White;
            button.Image = button.OnHoverImage;
            _oldButton = button;
            switch (button.Text)
            {
                case "Trang chủ":
                    MainPages.SetPage(0);
                    break;
                case "Tìm kiếm":
                    MainPages.SetPage(1);
                    break;
                case "Nhạc":
                    MainPages.SetPage(2);
                    break;
                case "Video":
                    MainPages.SetPage(3);
                    break;
                case "Thư viện":
                    MainPages.SetPage(4);
                    break;
                case "Cài đặt":
                    MainPages.SetPage(5);
                    break;
            };
        }

        public void ChangePage(int n)
        {
            MainPages.SetPage(n);
            if (n == 2) _oldButton = btn_Music;
            else _oldButton = btn_Video;
            if (_oldButton != null)
            {
                _oldButton.Image = _oldButton.OnHoverImage;
                _oldButton.ForeColor = Color.White;
                btn_Home.Image = (Image)btn_Home.Tag;
                btn_Home.ForeColor = Color.Silver;
            }
        }
        public VideoPlayer videoScreen = new VideoPlayer();
        public void ClassifyMedia(Media media)
        {
            if (media.MediaTypes == MediaTypes.Audio)
            {
                if (media != null)
                    MediaControl.getPathOfSong(media);
            }
            else
            {
                try
                {
                    if (videoScreen.Visible == false)
                    {
                        videoScreen = new VideoPlayer();
                        videoScreen.Show();
                    }
                    MediaControl.pauseCurrentPlayer();
                    videoScreen.getPathOfSong(media);
                    MediaControl.isPlayingVideo = true;
                    MediaControl.videoScreen = videoScreen;
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void DisplayPlayList(Playlist playlist)
        {
            userControl_PlayList.Title = playlist.PlayListName;
            userControl_PlayList.ListMedia = playlist.ListMedia;
            MainPages.SetPage(6);
        }
        public void rebuildHome()
        {
            this.tabPage_Home.Controls.Remove(this.userControl_Home1);
            userControl_Home1 = new UserControl_Home()
            {
                Dock = DockStyle.Fill,
            };
            this.tabPage_Home.Controls.Add(this.userControl_Home1);
        }

        public void ViewPlayingSong(Media media)
        {
            userControl_Playing.Media = media;
            MainPages.SetPage(7);
            btn_Home.Image = (Image)btn_Home.Tag;
            btn_Home.ForeColor = Color.Silver;
            _oldButton = btn_Settings;
        }
    }
}
