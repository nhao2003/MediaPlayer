using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ns6.WinApi;

namespace MediaPlayer.Items
{
    public partial class DisplayMediaItems : UserControl
    {
        private string[] filePaths;

        public DisplayMediaItems()
        {
            InitializeComponent();

        }

        private void DisplayMediaItems_Load(object sender, EventArgs e)
        {
            //MediaItem mediaItem;
            //int x = 10;

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            //openFileDialog.Multiselect = true;
            //openFileDialog.Title = "Open";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    filePaths = openFileDialog.FileNames;
            //}
            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    mediaItem = new MediaItem(filePaths[i])
            //    {
            //        Location = new Point(x, 0),
            //    };
            //    x += 210;
            //    panel_Items.Controls.Add(mediaItem);
            //}



            //for (int i = 0; i < 4; i++)
            //{
            //    mediaItem = new MediaItem()
            //    {
            //        Location = new Point(x, 0),
            //    };
            //    x += 210;
            //    panel_Items.Controls.Add(mediaItem);
            //}

            //panel_Items.AutoScroll = true;
        }
    }
}
