using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class MediaControl : UserControl
    {
        public delegate void pessTheButton(object sender, EventArgs e);
        public pessTheButton playSong;
        public pessTheButton nextSong;
        public pessTheButton previewSong;
        public MediaControl()
        {
            InitializeComponent();
        }

        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            if(playSong != null)
                playSong(sender, e);
        }

        private void gunaCircleButton_next_Click(object sender, EventArgs e)
        {
            if(nextSong != null)
            {
                nextSong(sender, e);
            }
        }

        private void gunaCircleButton_prev_Click(object sender, EventArgs e)
        {
            if(previewSong != null)
            {
                previewSong(sender, e);
            }
        }
    }
}
