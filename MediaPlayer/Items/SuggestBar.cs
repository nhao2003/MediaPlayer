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
        public delegate void Send(string path);
        public Send sendPath;
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
                musicRow.Media = MediaHelpers.listSongs[i];
                musicRow.sendPath = new MusicRow.Send(sendChildPath);
                panel_MusicRow.Controls.Add(musicRow);
            }
            // lay anh dau tien ra lam anh mac dinh
            //if (MediaHelpers.listSongs.Count >= 0 && MediaHelpers.listSongs[0].Image != null) 
            //    pic_main.Image = MediaHelpers.listSongs[0].Image;
        }
        public void sendChildPath(String s, Image image)
        {
            pic_main.Image = image;
            sendPath(s);
        }
    }
}
