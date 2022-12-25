using MediaPlayer.Models;
using System.Drawing;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Items
{
    public partial class SuggestBar : UserControl
    {
        public int numOfMediaShow = 5;
        public Media _media = null;
        public SuggestBar()
        {
            MusicRow musicRow;
            InitializeComponent();
            for (int i = 0; i < MediaHelpers.listSongs.Count && i < numOfMediaShow; i++)
            {
                musicRow = new MusicRow()
                {
                    Location = new Point(0, i * 75),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                };
                if (i == 0) pic_main.Image = MediaHelpers.listSongs[i].Image;
                musicRow.Media = MediaHelpers.listSongs[i];
                panel_MusicRow.Controls.Add(musicRow);
            }
        }
        public void changeImage(Media media)
        {
            _media = media;
            pic_main.Image = media.Image;
        }

        private void pic_main_Click(object sender, System.EventArgs e)
        {
            if (_media == null) return;
            if (_media.MediaTypes == MediaTypes.Audio)
            {
                Form_Main.Instance.ViewPlayingSong(_media);
            }
        }
    }
}
