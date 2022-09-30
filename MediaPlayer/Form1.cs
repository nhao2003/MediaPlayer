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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.panel_base.Controls.Clear();
            Form_Home formHome = new Form_Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formHome.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formHome);
            formHome.Show();
        }
        bool sideBarExpand = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void gunaGradient2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void gunaGradient2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void gunaGradient2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void gunaButton_Home_Click(object sender, EventArgs e)
        {
            //this.panel_base.Controls.Clear();
            Form_Home formHome = new Form_Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formHome.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formHome);
            formHome.Show();
        }

        private void gunaButton_Search_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            Form_Search formSearch = new Form_Search()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formSearch.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formSearch);
            formSearch.Show();
        }

        private void gunaButton_Music_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            Form_Music formMusic = new Form_Music()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formMusic.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formMusic);
            formMusic.Show();
        }

        private void gunaButton_Video_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            Form_Video formVideo = new Form_Video()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formVideo.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formVideo);
            formVideo.Show();
        }

        private void gunaButton_Library_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            Form_Library formLibrary = new Form_Library()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formLibrary.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formLibrary);
            formLibrary.Show();
        }

        private void gunaButton_Setting_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            Form_Setting formSetting = new Form_Setting()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            formSetting.FormBorderStyle = FormBorderStyle.None;
            this.panel_base.Controls.Add(formSetting);
            formSetting.Show();
        }

        private void panel_base_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
