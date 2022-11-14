using MediaPlayer.Models;
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
    public partial class UserControl_Settings : UserControl
    {
        public delegate void Rebuild();
        public Rebuild rebuild;

        //public string musicFolderPath = "C:\\users\\Administrator\\Music";
        public string musicFolderPath = ListSong.pathFolder;
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
                ListSong.pathFolder = musicFolderPath;
                ListSong.FetchListSong();
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
