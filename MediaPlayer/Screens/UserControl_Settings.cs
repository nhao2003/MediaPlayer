using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagLib;
namespace MediaPlayer.Widgets
{
    public partial class UserControl_Settings : UserControl
    {
        public delegate void Rebuild();
        public Rebuild rebuild;

        //public string musicFolderPath = "C:\\users\\Administrator\\Music";
        //public string videoFolderPath = "C:\\users\\Administrator\\Videos";
        public string musicFolderPath = MediaHelpers.MusicPathFolder;
        public string videoFolderPath = MediaHelpers.VideoPathFolder;

        public UserControl_Settings()
        {
            InitializeComponent();

            music_library_path.Text = musicFolderPath;
            video_library_path.Text = videoFolderPath;
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
                MediaHelpers.MusicPathFolder = musicFolderPath;
                MediaHelpers.FetchListMedia(MediaTypes.Audio);
                rebuild();
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
                MediaHelpers.VideoPathFolder = videoFolderPath;
                MediaHelpers.FetchListMedia(MediaTypes.Video);
                rebuild();
            }

        }

        private void choose_theme_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // thay doi theme
            //choose_theme_ComboBox.SelectedItem
        }

        private void choose_color_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // thay doi mau
            //choose_color_ComboBox.SelectedItem
        }


    }
}
