using MediaPlayer.Models;
using ns2;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                this.BackgroundImage = GaussianBlur.Blur(_media.Image, radial: 100);
                lbSong.Text = _media.Title;
                lbArtist.Text = _media.Artists;
                lb_Duration.Text = _media.DurationText;
                lb_dateAdd.Text = _media.DateAdded.ToString();
                RotationTimer.Start();
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
                Bitmap img = (Bitmap)Media.Image;
                img = RotateImage(img, angle);
                pic_Avatar.Image = img;
            }
            else
            {
                RotationTimer.Interval = 1;
                // phong to radius
                if (pic_Avatar.Radius >= 20 && angle == 360) pic_Avatar.Radius -= 10;
                // rotate
                if(angle < 360)
                {
                    angle += 10f;
                    if(360 - angle < 10) angle = 360;
                    Bitmap img = (Bitmap)Media.Image;
                    img = RotateImage(img, angle);
                    pic_Avatar.Image = img;
                }
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

        private void pic_Avatar_Click(object sender, EventArgs e)
        {
            if (PlayMedia.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Form_Main.Instance.MediaControl.pauseCurrentPlayer();
            }
            else
            {
                Form_Main.Instance.MediaControl.startTimer = true;
                PlayMedia.playSong();
            }
        }
    }
}
