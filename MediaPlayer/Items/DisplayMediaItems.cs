﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
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
            MediaItem mediaItem;
            int x = 10;

            foreach (Song song in ListSong.listSongs)
            {
                mediaItem = new MediaItem(song)
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
