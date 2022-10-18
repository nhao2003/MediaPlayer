using AxWMPLib;
using MediaPlayer.Items;
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
        public Player player1 = new Player();

        // gui du lieu qua ben form cha
        public delegate void sendStringData(String data);
        public sendStringData sendPathSong;
        
        public UserControl_Video()
        {
            player1.Width = 633;
            player1.Height = 485;
            player1.Location = new Point(14, 68);
            player1.BackColor = Color.White;
            player1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
            this.Controls.Add(player1);
            InitializeComponent();
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
            // data can gui ==========================================================
            if (sendPathSong != null)
                sendPathSong(paths[listBox_title.SelectedIndex]);
            //========================================================================
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
            finally
            {
                button_Play.PerformClick();
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
        public void button_Play_Click(object sender, EventArgs e)
        {
            try
            {
                player1.setURL(paths[listBox_title.SelectedIndex]);
               
            }
            catch
            {
                MessageBox.Show("Ban chua chon bai hat!", "line 82");
            }
            
            player1.playSong();
            textBox_Search.Text = "Search";
        }

        private void textBox_name_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Search.Text = "";
        }

        public void button_next_Click(object sender, EventArgs e)
        {
            if(listBox_title.SelectedIndex < listBox_title.Items.Count - 1)
            {
                listBox_title.SelectedIndex += 1;
                listBox_title_SelectedIndexChanged(sender, e);

                player1.setURL(paths[listBox_title.SelectedIndex]);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (listBox_title.SelectedIndex > 0)
            {
                listBox_title.SelectedIndex -= 1;
                listBox_title_SelectedIndexChanged(sender, e);

                player1.setURL(paths[listBox_title.SelectedIndex]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player1.setCurrentTimePlay();
                /*if (progressBar.Value >= progressBar.Maximum)
                {
                    button_next.PerformClick();
                }*/
            }
        }
    }
}
