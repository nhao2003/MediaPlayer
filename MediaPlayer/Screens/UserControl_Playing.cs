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
                if(value == null) return;
                _media = value;
                pic_Avatar.Image = _media.Image;
                pic_BackGround.Image = GaussianBlur.Blur(_media.Image, 100);
            }
        }
        public UserControl_Playing()
        {
            InitializeComponent();
        }

    }
}
