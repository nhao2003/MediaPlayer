using MediaPlayer.Items;
using MediaPlayer.Models;
using MediaPlayer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Playing : UserControl
    {
        private Media _media;

        public Media Media
        {
            get => _media;
            set
            {
                if (value == null) return;
                _media = value;
                pic_Avatar.Image = _media.Image;
                this.BackgroundImage = ImageTools.GaussianBlur(_media.Image, radial: 100);
                RotationTimer.Start();
                lb_NextName.Text = _media.Title;
                lb_NextAuthor.Text = _media.Artists;
                IsPlaying = (PlayMedia.Status == WMPPlayState.wmppsPlaying);
            }
        }
        public UserControl_Playing()
        {
            InitializeComponent();
            radius = pic_Avatar.Radius;
        }

        private void UserControl_Playing_Load(object sender, EventArgs e)
        {

        }
        float angle = 0;
        int radius = 0;
        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            if (PlayMedia.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                RotationTimer.Interval = 25;
                // thu nho radius
                if (pic_Avatar.Radius < 180) pic_Avatar.Radius += 10;
                // rotate
                if (angle > 360) angle = 0;
                else angle += 1f;
                Bitmap img = (Bitmap)MediaHelpers.PlayQueue[MediaHelpers.CurrentIndex].Image;
                img = RotateImage(img, angle);
                pic_Avatar.Image = img;

                //btn play
                IsPlaying = true;
            }
            else
            {
                RotationTimer.Interval = 1;
                // phong to radius
                if (pic_Avatar.Radius >= 20 && angle == 360) pic_Avatar.Radius -= 10;
                // rotate
                if (angle < 360)
                {
                    angle += 10f;
                    if (360 - angle < 10) angle = 360;
                    Bitmap img = (Bitmap)MediaHelpers.PlayQueue[MediaHelpers.CurrentIndex].Image;
                    img = RotateImage(img, angle);
                    pic_Avatar.Image = img;
                }
                //btn play
                IsPlaying = false;
            }
        }
        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }
        public void UpdateScreen()
        {
            pn_Display.Controls.Clear();
            if (MediaHelpers.PlayQueue.Count == 0) return;
            Media = MediaHelpers.listSongs.Find(x => x.FilePath == PlayMedia.Path);
            RotationTimer.Start();
            for (int i = MediaHelpers.PlayQueue.Count - 1; i >= 0; i--)
            {
                MusicRow row = new MusicRow(MediaHelpers.PlayQueue[i])
                {
                    Dock = DockStyle.Top,
                    IsHover = (PlayMedia.Path == MediaHelpers.PlayQueue[i].FilePath),
                    IsPlaying = (PlayMedia.Path == MediaHelpers.PlayQueue[i].FilePath),
                };

                pn_Display.Controls.Add(row);
            }
        }
        private void pic_Avatar_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MediaControl.click_btn_play();
        }
        private bool isPlaying = false;
        public bool IsPlaying {
            set
            {
                if (value)
                {
                    btn_Play.Image = Resources.pause_nobackrgound;
                    btn_Play.Text = "   Tạm dừng";
                }
                else
                {
                    btn_Play.Image = Resources.play_nobackground;
                    btn_Play.Text = "   Tiếp tục phát";
                }
                isPlaying = value;
            }
        }
        private void btn_Play_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MediaControl.click_btn_play();
        }
    }
}
