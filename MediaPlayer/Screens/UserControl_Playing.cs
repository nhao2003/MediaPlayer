using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
using MediaPlayer.Properties;

namespace MediaPlayer.Screens
{
    public partial class UserControl_Playing : UserControl
    {
        private Media _media = new Media();

        public Media Media
        {
            get => _media;
            set
            {
                _media = value;
                pic_Avatar.Image = _media.Image;
                pic_Background.Image = GaussianBlur.Blur(_media.Image, 100);
            }
        }

        public UserControl_Playing()
        {
            InitializeComponent();
            pic_Avatar.Image = Resources.defaultImage;
            pic_Background.Image = GaussianBlur.Blur(Resources.defaultImage, 100);
        }
    }
}
