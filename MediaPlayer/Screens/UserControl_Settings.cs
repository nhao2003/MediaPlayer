﻿using System;
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
    public partial class UserControl_Settings : UserControl
    {
        // khai bao delegate
        public delegate void sendStringData(string data);
        public sendStringData sendMusicFolderPath;
        public sendStringData sendVideoFolderPath;
        public sendStringData sendTheme;
        public sendStringData sendColor;

        public string musicFolderPath = "C:\\users\\Administrator\\Music";
        public string videoFolderPath = "C:\\users\\Administrator\\Videos";

        public List<string> themes = new List<string>() { "Light", "Dark"};
        public List<string> colors = new List<string>() { "Green", "Blue", "Red", "Yellow" };
        public UserControl_Settings()
        {
            InitializeComponent();

            music_library_path.Text = musicFolderPath;
            video_library_path.Text = videoFolderPath;

            choose_theme_ComboBox.DataSource = themes;
            choose_color_ComboBox.DataSource = colors;
        }

        private void choose_music_path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = musicFolderPath;
            fbd.Description = "Choose music folder path";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                musicFolderPath = fbd.SelectedPath;
                music_library_path.Text = musicFolderPath;
                if (sendMusicFolderPath != null)
                    sendMusicFolderPath(musicFolderPath);
            }
        }

        private void choose_videos_path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = videoFolderPath;
            fbd.Description = "Choose videos folder path";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                videoFolderPath = fbd.SelectedPath;
                video_library_path.Text = videoFolderPath;
                if(sendVideoFolderPath != null)
                    sendVideoFolderPath(videoFolderPath);
            }
        }

        private void choose_theme_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // thay doi theme
            //MessageBox.Show(choose_theme_ComboBox.SelectedItem.ToString());
            if(sendColor != null)
                sendTheme(choose_theme_ComboBox.SelectedItem.ToString());
        }

        private void choose_color_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // thay doi mau
            //MessageBox.Show(choose_color_ComboBox.SelectedItem.ToString());
            if(sendColor != null)
                sendColor(choose_color_ComboBox.SelectedItem.ToString());

        }
    }
}
