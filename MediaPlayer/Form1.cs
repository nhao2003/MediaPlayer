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

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
