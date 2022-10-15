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
            MediaItem mediaItem = new MediaItem();
            int x = 10;
            for (int i = 0; i < 4; i++)
            {
                mediaItem = new MediaItem()
                {
                    Location = new Point(x, 0),
                };
                x += 210;
                panel_Items.Controls.Add(mediaItem);
            }

            panel_Items.AutoScroll = true;
        }
    }
}
