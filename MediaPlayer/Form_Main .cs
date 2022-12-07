using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using WMPLib;
using System.Threading;
using System.Threading.Tasks;
using Guna.UI.WinForms;
using MediaPlayer.Models;
using TagLib;

namespace MediaPlayer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
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
        // gui data tu item song
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;


        public void sendChildPath(String s, MediaTypes mediaTypes)
        {
            if (mediaTypes == MediaTypes.Audio) MediaControl.getPathOfSong(s);
            else
            {
                MediaControl.pauseCurrentPlayer();
                VideoPlayer videoScreen = new VideoPlayer();
                videoScreen.Show();
                videoScreen.getPathOfSong(s);
            }
        }
        public void rebuildHome()
        {
            this.tabPage_Home.Controls.Remove(this.userControl_Home1);
            userControl_Home1 = new UserControl_Home()
            {
                Dock = DockStyle.Fill,
            };
            userControl_Home1.sendPath = new UserControl_Home.Send(sendChildPath);
            this.tabPage_Home.Controls.Add(this.userControl_Home1);
        }
        // khai bao cac delegate va thuoc tinh
        private void Form_Main_Load(object sender, EventArgs e)
        {
            userControl_Home1.sendPath = new UserControl_Home.Send(sendChildPath);
            userControl_Settings1.rebuild = new UserControl_Settings.Rebuild(rebuildHome);
        }
    }
}
