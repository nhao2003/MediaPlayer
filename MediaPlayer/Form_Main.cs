﻿using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void gunaPanel_MusicControl_Paint(object sender, PaintEventArgs e)
        {
            MediaControl mediaControl = new MediaControl();
            panel_base.Controls.Add(mediaControl);
            mediaControl.Show();
        }

        private void panel_base_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton_Home_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            UserControl_Home userControl_Home = new UserControl_Home();
            this.panel_base.Controls.Add(userControl_Home);
            userControl_Home.Show();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            MediaControl mediaControl = new MediaControl()
            {
                Dock = DockStyle.Fill
            };
            this.gunaPanel_MediaControl.Controls.Add(mediaControl);
            mediaControl.Show();
            gunaButton_Home_Click(sender, e);
        }

        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton_Search_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            UserControl_Search userControl_Search = new UserControl_Search();
            this.panel_base.Controls.Add(userControl_Search);
            userControl_Search.Show();
        }

        private void gunaButton_Music_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            UserControl_Music userControl_Music = new UserControl_Music();
            this.panel_base.Controls.Add(userControl_Music);
            userControl_Music.Show();
        }

        private void gunaButton_Video_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            UserControl_Video userControl_Video = new UserControl_Video();
            this.panel_base.Controls.Add(userControl_Video);
            userControl_Video.Show();
        }

        private void gunaButton_Library_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            UserControl_Library userControl_Library = new UserControl_Library();
            this.panel_base.Controls.Add(userControl_Library);
            userControl_Library.Show();
        }

        private void gunaButton_Settings_Click(object sender, EventArgs e)
        {
            this.panel_base.Controls.Clear();
            UserControl_Settings userControl_Settings = new UserControl_Settings();
            this.panel_base.Controls.Add(userControl_Settings);
            userControl_Settings.Show();
        }
    }
}
