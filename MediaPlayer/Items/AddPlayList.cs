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

namespace MediaPlayer.Items
{
    public partial class AddPlayList : Form
    {
        private bool isRename = false;
        /// <summary>
        /// Add playlist or rename
        /// </summary>
        /// <param name="playlist">Set value if rename playlist</param>
        public AddPlayList(Playlist playlist = null)
        {
            InitializeComponent();
            if (playlist != null)
            {
                isRename = true;
                btn_Save_Or_Rename.Text = @"Rename";
            }
        }

        private void btn_Save_Or_Rename_Click(object sender, EventArgs e)
        {
            if (isRename)
            {
                
            }
            else
            {
                
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
            
        }
    }
}
