﻿using AxWMPLib;
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
        private void UserControl_Video_Load(object sender, EventArgs e)
        {
        }

        String[] paths, files;

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                foreach(var tt in paths)
                {
                    TagLib.File file = TagLib.File.Create(tt);
                    try
                    {
                        listBox_title.Items.Add(file.Tag.Title);
                    }
                    catch { }
                }
            }
        }
        private void listBox_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            TagLib.File file = TagLib.File.Create(paths[listBox_title.SelectedIndex]);
            lbl_title.Text = ("Title: " + file.Tag.Title);
            lb_album.Text = ("Album: " + file.Tag.Album);
            lb_year.Text = ("Year: " + file.Tag.Year);
            try
            {
                var ff = TagLib.File.Create(paths[listBox_title.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {

            }
        }
        private void textBox_Search_KeyUp(object sender, KeyEventArgs e)
        {
            int index = listBox_title.FindString(textBox_Search.Text);
            if (0 <= index)
            {
                listBox_title.SelectedIndex = index;
            }
        }
        private void button_Play_Click(object sender, EventArgs e)
        {
            try
            {
                player1.setURL(paths[listBox_title.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "82");
            }
            
            player1.playSong();
            textBox_Search.Text = "Search";
        }

        private void textBox_name_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Search.Text = "";
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            player1.stopSong();
            progressBar.Value = 0;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            player1.pauseSong();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if(listBox_title.SelectedIndex < listBox_title.Items.Count - 1)
            {
                listBox_title.SelectedIndex += 1;
                listBox_title_SelectedIndexChanged(sender, e);

                player1.setURL(paths[listBox_title.SelectedIndex]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_title.SelectedIndex > 0)
            {
                listBox_title.SelectedIndex -= 1;
                listBox_title_SelectedIndexChanged(sender, e);

                player1.playSong();
            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player1.setVolume(track_volume.Value);
            label_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            player1.setCurrentPosition(e.X, progressBar.Width);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player1.getDurationSong();
                progressBar.Value = (int)player1.getCurrentPositionSong();
                if (player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    if (progressBar.Value >= progressBar.Maximum)
                    {
                        button_next.PerformClick();
                    }
                }
            }
            try
            {
                label_track_start.Text = player1.getCurrentPositionStringSong();
                if (player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    label_strack_end.Text = player1.getDurationStringSong();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.ToString(), "169");
            }
        }
    }
}
