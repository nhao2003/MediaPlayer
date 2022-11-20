using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Video : UserControl
    {
        public UserControl_Video()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        string path;
        string filenames;

        public void getPathOfSong(string path)
        {
            videoPlayer.URL = path;
        }
        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "mp4 files (*.mp4)|*.mp4";
            ofd.Title = "Open";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                filenames = ofd.SafeFileName;
            }
            getPathOfSong(path);
        }
    }
}
