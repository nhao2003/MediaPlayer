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
            InitializeComponent();
            for (int i = 0; i < ListSong.listSongs.Count; i++)
            {
                panel_MusicRow.Controls.Add(MusicRow());
            }
        }
    }
}
