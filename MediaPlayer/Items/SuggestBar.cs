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
        public SuggestBar()
        {
            MusicRow musicRow;
            InitializeComponent();
            for (int i = 0; i < MediaHelpers.listSongs.Count && i < 5; i++)
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
        }
        public void sendChildPath(String s)
        {
            sendPath(s);
        }
    }
}
