using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediaPlayer.Items
{
    public partial class AddPlayList : Form
    {
        private bool isRename = false;
        private Playlist playlist;
        /// <summary>
        /// Add playlist or rename
        /// </summary>
        /// <param name="playlist">Set value if rename playlist</param>
        public AddPlayList(Playlist playlist = null)
        {
            InitializeComponent();
            if (playlist != null)
            {
                this.playlist = playlist;
                isRename = true;
                btn_Save_Or_Rename.Text = @"Rename";
            }
        }

        private void btn_Save_Or_Rename_Click(object sender, EventArgs e)
        {
            if (isRename)
            {
                int index = MediaHelpers.Playlists.FindIndex(pl => pl.PlayListID == playlist.PlayListID);
                if (index > 0)
                {
                    MediaHelpers.Playlists[index].PlayListName = tb_NamePlayList.Text;
                    if(openFileDialog.FileName!= "")
                        MediaHelpers.Playlists[index].BackroundImageFileName = openFileDialog.FileName;
                }
            }
            else
            {
                Playlist playlist = new Playlist(tb_NamePlayList.Text, openFileDialog.FileName);
                Tag = playlist;
                MediaHelpers.Playlists.Add(playlist);
            }

            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tb_NamePlayList_TextChanged(object sender, EventArgs e)
        {
            if (tb_NamePlayList.Text.Trim().Length == 0)
            {
                btn_Save_Or_Rename.Enabled = false;
            }
            else
            {
                btn_Save_Or_Rename.Enabled = true;
            }
        }

        private void pic_BackGround_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "";

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;
            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }
            openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, "All Files", "*.*");
            openFileDialog.DefaultExt = ".png";

            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                pic_BackGround.Image = Image.FromFile(openFileDialog.FileName);
                playlist.BackroundImageFileName = openFileDialog.FileName;
                openFileDialog.Dispose();
            }
        }
    }
}
