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

namespace MediaPlayer.Items
{
    public partial class SuggestBar : UserControl
    {
        public SuggestBar()
        {
            MusicRow musicRow;
            InitializeComponent();
            foreach (Song song in ListSong.listSongs)
            {
                musicRow = new MusicRow()
                {
                    Dock = DockStyle.Top
                };
                musicRow.Song = song;
                panel_MusicRow.Controls.Add(musicRow);
            }
        }
    }
}
