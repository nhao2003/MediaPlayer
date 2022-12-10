using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;

namespace MediaPlayer.Items
{
    public partial class SuggestBar : UserControl
    {
        public int numOfMediaShow = 5;
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
                if(i == 0) pic_main.Image = MediaHelpers.listSongs[i].Image;
                musicRow.Media = MediaHelpers.listSongs[i];
                panel_MusicRow.Controls.Add(musicRow);
            }
        }
        public void changeImage(Image image)
        {
            pic_main.Image = image;
        }
    }
}
