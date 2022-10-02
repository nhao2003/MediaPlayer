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
    public partial class DisplayMediaItems : UserControl
    {
        public DisplayMediaItems()
        {
            InitializeComponent();
        }

        private void DisplayMediaItems_Load(object sender, EventArgs e)
        {
            MediaItem mediaItem;
            for (int i = 0; i < 8; i++)
            {
                mediaItem = new MediaItem();
                flowLayoutPanel_Media.Controls.Add(mediaItem);
            }
        }

        private void flowLayoutPanel_Recent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DisplayMediaItems_ParentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_ClientSizeChanged(object sender, EventArgs e)
        {
        }
    }
}
