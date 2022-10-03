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
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        public MediaControl()
        {
            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
            InitializeComponent();
        }

        private void gunaTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void gunaCircleButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            Player.URL = "C:\\Users\\haosi\\source\\repos\\MediaPlayer\\MediaPlayer\\Resources\\Ex_s Hate Me Part 2_ Rap Version_ - AMee.mp3";
            Player.controls.play();
        }
    }
}
