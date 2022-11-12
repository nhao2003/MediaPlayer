﻿using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediaPlayer.Items
{
    public partial class MusicRow : UserControl
    {
        public delegate void Send(string path);
        public Send sendPath;
        private Song song;
        public Song Song
        {
            get
            {
                return song;
            }
            set
            {
                song = value;
                pic_Song.Image = song.Image;
                label_NameSong.Text = song.Title;
                label_Duration.Text = song.DurationText;
                label_NameSinger.Text = song.Artists;
            }
        }

        public MusicRow()
        {
            InitializeComponent();
            var request = WebRequest.Create("https://data.chiasenhac.com/data/cover/160/159824.jpg");
        }

        public static void setInfo()
        {

        }
        private void MusicRow_MouseEnter(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(221, 228, 228);
        }

        private void MusicRow_MouseLeave(object sender, EventArgs e)
        {
            panel_MusicRow.BaseColor = Color.FromArgb(206,217,217);
        }

        private void MusicRow_Click(object sender, EventArgs e)
        {
            sendPath(song.FilePath);
        }
    }
}
