using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MediaPlayer.Properties;

namespace MediaPlayer.Items
{
    public partial class MusicRow : UserControl
    {
        private Media _media;
        public Media Media
        {
            get
            {
                return _media;
            }
            set
            {
                _media = value;
                pic_Song.Image = _media.Image;
                label_NameSong.Text = _media.Title;
                label_Duration.Text = _media.DurationText;
                label_NameSinger.Text = _media.Artists;
            }
        }

        public MusicRow()
        {
            InitializeComponent();
        }

        private void MusicRow_MouseEnter(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(40, 40, 40);
        }

        private void MusicRow_MouseLeave(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.Transparent;
        }

        private void MusicRow_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MediaControl.getPathOfSong(_media.FilePath);
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media.Image);
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            _media.Like();
            if (_media.IsLiked)
            {
                btn_Like.Image = Resources.favorite_hover;
                btn_Like.OnHoverImage = Resources.favorite_hover;
            }
            else
            {
                btn_Like.Image = Resources.favorite;
                btn_Like.OnHoverImage = Resources.not_favorite_hover;
            }
        }
    }
}
