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
        public pessTheButton play;
        public MediaControl()
        {
            InitializeComponent();
        }

        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            if(play != null)
                play(sender, e);
        }
    }
}
