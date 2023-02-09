using MediaPlayer.Models;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using TagLib;
using System.Linq;

namespace MediaPlayer.Items
{
    public partial class SuggestBar : UserControl
    {
        public int numOfMediaShow = 5;
        private Media _media = null;
        public Media currentMedia
        {
            get { return _media; }
            set
            {
                pic_main.Image = _media.Image;
                _media = value;
            }
        }
        public SuggestBar()
        {
            InitializeComponent();
            InitSuggest(); ;
        }

        private void InitSuggest()
        {
            MusicRow musicRow;
            Random rand = new Random();
            List<int> selected = new List<int>();
            while (selected.Count < 5 && selected.Count < MediaHelpers.listSongs.Count)
            {
                int candidate = rand.Next(0, MediaHelpers.listSongs.Count);
                if (!selected.Contains(candidate))
                {
                    selected.Add(candidate);
                }
            }
            for (int i = 0; i < selected.Count; i++)
            {
                musicRow = new MusicRow()
                {
                    Location = new Point(0, i * 75),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                };
                if (i == 0) pic_main.Image = MediaHelpers.listSongs[i].Image;
                musicRow.Media = MediaHelpers.listSongs[selected[i]];
                panel_MusicRow.Controls.Add(musicRow);
            }
            if (_media == null && MediaHelpers.listSongs.Count != 0)
            {
                pic_main.Image = MediaHelpers.listSongs[0].Image;
            }
        }

        public void changeImage(Media media)
        {
            _media = media;
            pic_main.Image = media.Image;
        }

        private void pic_main_Click(object sender, System.EventArgs e)
        {
            if(_media == null)
            {
                if (_media == null && MediaHelpers.listSongs.Count != 0)
                    Form_Main.Instance.ClassifyMedia(MediaHelpers.listSongs[0]);
            }
            else if (_media.MediaTypes == MediaTypes.Audio)
            {
                Form_Main.Instance.ViewPlayingSong();
            }
            else
            {
                Form_Main.Instance.MediaControl.showSongAndVideo();
            }
        }
    }
}
