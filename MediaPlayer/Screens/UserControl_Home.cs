using MediaPlayer.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_Home : UserControl
    {
        DisplayMediaItems RecentMusic = new DisplayMediaItems();
        DisplayMediaItems RecentVideo = new DisplayMediaItems();
        public UserControl_Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //RecentMusic.Height = 700;
            //flowLayoutPanel_Home.Controls.Add(RecentMusic);
            //flowLayoutPanel_Home.Controls.Add(RecentVideo);
        }

        private void UserControl_Home_Resize(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Home_SizeChanged(object sender, EventArgs e)
        {
            int width = flowLayoutPanel_Home.Width - 30;
            RecentMusic.Width = width;
            //RecentVideo.Width = width;
        }
        string[] paths, files;

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog.FileNames;
                paths = openFileDialog.FileNames;
                for(int i =0;i < files.Length; i++)
                {
                    Track_list.Items.Add(files[i]);
                }
            }
        }

        private void Track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[Track_list.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();  
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(Track_list.SelectedIndex  < Track_list.Items.Count - 1)
            {
                Track_list.SelectedIndex = Track_list.SelectedIndex + 1;
            }
        }
    }
}
