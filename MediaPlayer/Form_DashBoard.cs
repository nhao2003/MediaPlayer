using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form_DashBoard : Form
    {
        public Form_DashBoard()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog;
        string[] filePaths;
        string[] fileNames;
        
        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files (*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
                fileNames = openFileDialog.SafeFileNames;
                foreach (var item in fileNames)
                {
                    this.listBox1.Items.Add(item);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                int choose = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = filePaths[choose];
                this.textBox1.Text = fileNames[choose];
            }
        }
    }
}
