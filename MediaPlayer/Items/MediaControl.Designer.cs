﻿namespace MediaPlayer.Items
{
    partial class MediaControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaControl));
            this.timeSongEnd = new Guna.UI.WinForms.GunaLabel();
            this.MediaTrackBar = new Guna.UI.WinForms.GunaTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaTrackBar_Volume = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaCircleButton_Open = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton_Volume = new Guna.UI.WinForms.GunaCircleButton();
            this.panel_MediaInfo = new System.Windows.Forms.Panel();
            this.gunaLabel_SongName = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox_SongImage = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel_NameAthor = new Guna.UI.WinForms.GunaLabel();
            this.gunaCircleButton_Like = new Guna.UI.WinForms.GunaCircleButton();
            this.timeSongPlay = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaCircleButton4 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton_prev = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton5 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton_next = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton_Play = new Guna.UI.WinForms.GunaCircleButton();
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel_MediaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_SongImage)).BeginInit();
            this.gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeSongEnd
            // 
            this.timeSongEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSongEnd.AutoSize = true;
            this.timeSongEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeSongEnd.Location = new System.Drawing.Point(538, 13);
            this.timeSongEnd.Name = "timeSongEnd";
            this.timeSongEnd.Size = new System.Drawing.Size(44, 20);
            this.timeSongEnd.TabIndex = 17;
            this.timeSongEnd.Text = "00:00";
            // 
            // MediaTrackBar
            // 
            this.MediaTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MediaTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.MediaTrackBar.Location = new System.Drawing.Point(57, 10);
            this.MediaTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MediaTrackBar.MouseWheelBarPartitions = 1000;
            this.MediaTrackBar.Name = "MediaTrackBar";
            this.MediaTrackBar.Size = new System.Drawing.Size(475, 26);
            this.MediaTrackBar.TabIndex = 15;
            this.MediaTrackBar.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.MediaTrackBar.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.MediaTrackBar.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.MediaTrackBar.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.MediaTrackBar.Value = 0;
            this.MediaTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MediaTrackBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaTrackBar_Volume);
            this.panel1.Controls.Add(this.gunaCircleButton_Open);
            this.panel1.Controls.Add(this.gunaCircleButton_Volume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(900, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 120);
            this.panel1.TabIndex = 14;
            // 
            // gunaTrackBar_Volume
            // 
            this.gunaTrackBar_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTrackBar_Volume.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaTrackBar_Volume.Location = new System.Drawing.Point(108, 49);
            this.gunaTrackBar_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTrackBar_Volume.Name = "gunaTrackBar_Volume";
            this.gunaTrackBar_Volume.Size = new System.Drawing.Size(180, 26);
            this.gunaTrackBar_Volume.TabIndex = 20;
            this.gunaTrackBar_Volume.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaTrackBar_Volume.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaTrackBar_Volume.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar_Volume_Scroll);
            // 
            // gunaCircleButton_Open
            // 
            this.gunaCircleButton_Open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton_Open.Animated = true;
            this.gunaCircleButton_Open.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_Open.AnimationSpeed = 0.03F;
            this.gunaCircleButton_Open.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Open.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Open.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_Open.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Open.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_Open.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_Open.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Open.Image")));
            this.gunaCircleButton_Open.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton_Open.Location = new System.Drawing.Point(15, 44);
            this.gunaCircleButton_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_Open.Name = "gunaCircleButton_Open";
            this.gunaCircleButton_Open.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Open.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Open.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Open.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Open.OnHoverImage")));
            this.gunaCircleButton_Open.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Open.Size = new System.Drawing.Size(32, 32);
            this.gunaCircleButton_Open.TabIndex = 19;
            this.gunaCircleButton_Open.Click += new System.EventHandler(this.gunaCircleButton_Open_Click);
            // 
            // gunaCircleButton_Volume
            // 
            this.gunaCircleButton_Volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton_Volume.Animated = true;
            this.gunaCircleButton_Volume.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_Volume.AnimationSpeed = 0.03F;
            this.gunaCircleButton_Volume.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Volume.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Volume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_Volume.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_Volume.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_Volume.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Volume.Image")));
            this.gunaCircleButton_Volume.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton_Volume.Location = new System.Drawing.Point(61, 44);
            this.gunaCircleButton_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_Volume.Name = "gunaCircleButton_Volume";
            this.gunaCircleButton_Volume.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Volume.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Volume.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Volume.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Volume.OnHoverImage")));
            this.gunaCircleButton_Volume.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Volume.Size = new System.Drawing.Size(32, 32);
            this.gunaCircleButton_Volume.TabIndex = 19;
            this.gunaCircleButton_Volume.Click += new System.EventHandler(this.gunaCircleButton_Volume_Click);
            // 
            // panel_MediaInfo
            // 
            this.panel_MediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MediaInfo.Controls.Add(this.gunaLabel_SongName);
            this.panel_MediaInfo.Controls.Add(this.gunaPictureBox_SongImage);
            this.panel_MediaInfo.Controls.Add(this.gunaLabel_NameAthor);
            this.panel_MediaInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_MediaInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_MediaInfo.Name = "panel_MediaInfo";
            this.panel_MediaInfo.Size = new System.Drawing.Size(304, 120);
            this.panel_MediaInfo.TabIndex = 14;
            // 
            // gunaLabel_SongName
            // 
            this.gunaLabel_SongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_SongName.AutoEllipsis = true;
            this.gunaLabel_SongName.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_SongName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel_SongName.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_SongName.Location = new System.Drawing.Point(101, 27);
            this.gunaLabel_SongName.Name = "gunaLabel_SongName";
            this.gunaLabel_SongName.Size = new System.Drawing.Size(203, 23);
            this.gunaLabel_SongName.TabIndex = 6;
            this.gunaLabel_SongName.Text = "Tên bài hát";
            // 
            // gunaPictureBox_SongImage
            // 
            this.gunaPictureBox_SongImage.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox_SongImage.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox_SongImage.Location = new System.Drawing.Point(4, 15);
            this.gunaPictureBox_SongImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox_SongImage.Name = "gunaPictureBox_SongImage";
            this.gunaPictureBox_SongImage.Radius = 10;
            this.gunaPictureBox_SongImage.Size = new System.Drawing.Size(91, 90);
            this.gunaPictureBox_SongImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox_SongImage.TabIndex = 8;
            this.gunaPictureBox_SongImage.TabStop = false;
            // 
            // gunaLabel_NameAthor
            // 
            this.gunaLabel_NameAthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_NameAthor.AutoEllipsis = true;
            this.gunaLabel_NameAthor.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_NameAthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel_NameAthor.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_NameAthor.Location = new System.Drawing.Point(101, 56);
            this.gunaLabel_NameAthor.Name = "gunaLabel_NameAthor";
            this.gunaLabel_NameAthor.Size = new System.Drawing.Size(203, 64);
            this.gunaLabel_NameAthor.TabIndex = 7;
            this.gunaLabel_NameAthor.Text = "Tên ca sĩ";
            // 
            // gunaCircleButton_Like
            // 
            this.gunaCircleButton_Like.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton_Like.Animated = true;
            this.gunaCircleButton_Like.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_Like.AnimationSpeed = 0.03F;
            this.gunaCircleButton_Like.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Like.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Like.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_Like.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_Like.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_Like.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_Like.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Like.Image")));
            this.gunaCircleButton_Like.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaCircleButton_Like.Location = new System.Drawing.Point(3, 55);
            this.gunaCircleButton_Like.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_Like.Name = "gunaCircleButton_Like";
            this.gunaCircleButton_Like.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Like.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Like.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Like.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Like.OnHoverImage")));
            this.gunaCircleButton_Like.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Like.Size = new System.Drawing.Size(35, 37);
            this.gunaCircleButton_Like.TabIndex = 19;
            // 
            // timeSongPlay
            // 
            this.timeSongPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSongPlay.AutoSize = true;
            this.timeSongPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeSongPlay.Location = new System.Drawing.Point(7, 13);
            this.timeSongPlay.Name = "timeSongPlay";
            this.timeSongPlay.Size = new System.Drawing.Size(44, 20);
            this.timeSongPlay.TabIndex = 16;
            this.timeSongPlay.Text = "00:00";
            // 
            // gunaPanel
            // 
            this.gunaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel.AutoSize = true;
            this.gunaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel.Controls.Add(this.timeSongEnd);
            this.gunaPanel.Controls.Add(this.gunaCircleButton_Like);
            this.gunaPanel.Controls.Add(this.gunaCircleButton4);
            this.gunaPanel.Controls.Add(this.MediaTrackBar);
            this.gunaPanel.Controls.Add(this.timeSongPlay);
            this.gunaPanel.Controls.Add(this.gunaCircleButton_prev);
            this.gunaPanel.Controls.Add(this.gunaCircleButton5);
            this.gunaPanel.Controls.Add(this.gunaCircleButton_next);
            this.gunaPanel.Controls.Add(this.gunaCircleButton_Play);
            this.gunaPanel.Location = new System.Drawing.Point(303, 0);
            this.gunaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel.Name = "gunaPanel";
            this.gunaPanel.Size = new System.Drawing.Size(594, 120);
            this.gunaPanel.TabIndex = 13;
            // 
            // gunaCircleButton4
            // 
            this.gunaCircleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton4.Animated = true;
            this.gunaCircleButton4.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton4.AnimationSpeed = 0.03F;
            this.gunaCircleButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton4.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton4.Image")));
            this.gunaCircleButton4.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton4.Location = new System.Drawing.Point(92, 56);
            this.gunaCircleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton4.Name = "gunaCircleButton4";
            this.gunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton4.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton4.OnHoverImage")));
            this.gunaCircleButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.Size = new System.Drawing.Size(32, 32);
            this.gunaCircleButton4.TabIndex = 19;
            // 
            // gunaCircleButton_prev
            // 
            this.gunaCircleButton_prev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton_prev.Animated = true;
            this.gunaCircleButton_prev.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_prev.AnimationSpeed = 0.03F;
            this.gunaCircleButton_prev.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_prev.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_prev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_prev.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_prev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_prev.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_prev.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_prev.Image")));
            this.gunaCircleButton_prev.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaCircleButton_prev.Location = new System.Drawing.Point(183, 48);
            this.gunaCircleButton_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_prev.Name = "gunaCircleButton_prev";
            this.gunaCircleButton_prev.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_prev.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_prev.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_prev.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_prev.OnHoverImage")));
            this.gunaCircleButton_prev.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_prev.Size = new System.Drawing.Size(49, 49);
            this.gunaCircleButton_prev.TabIndex = 19;
            // 
            // gunaCircleButton5
            // 
            this.gunaCircleButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton5.Animated = true;
            this.gunaCircleButton5.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton5.AnimationSpeed = 0.03F;
            this.gunaCircleButton5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton5.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton5.Image")));
            this.gunaCircleButton5.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton5.Location = new System.Drawing.Point(468, 55);
            this.gunaCircleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton5.Name = "gunaCircleButton5";
            this.gunaCircleButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton5.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton5.OnHoverImage")));
            this.gunaCircleButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.Size = new System.Drawing.Size(32, 32);
            this.gunaCircleButton5.TabIndex = 18;
            // 
            // gunaCircleButton_next
            // 
            this.gunaCircleButton_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton_next.Animated = true;
            this.gunaCircleButton_next.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_next.AnimationSpeed = 0.03F;
            this.gunaCircleButton_next.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_next.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_next.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_next.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_next.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_next.Image")));
            this.gunaCircleButton_next.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaCircleButton_next.Location = new System.Drawing.Point(360, 48);
            this.gunaCircleButton_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_next.Name = "gunaCircleButton_next";
            this.gunaCircleButton_next.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_next.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_next.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_next.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_next.OnHoverImage")));
            this.gunaCircleButton_next.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_next.Size = new System.Drawing.Size(49, 49);
            this.gunaCircleButton_next.TabIndex = 18;
            // 
            // gunaCircleButton_Play
            // 
            this.gunaCircleButton_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCircleButton_Play.Animated = true;
            this.gunaCircleButton_Play.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_Play.AnimationSpeed = 0.03F;
            this.gunaCircleButton_Play.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Play.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_Play.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_Play.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_Play.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Play.Image")));
            this.gunaCircleButton_Play.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaCircleButton_Play.Location = new System.Drawing.Point(264, 39);
            this.gunaCircleButton_Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_Play.Name = "gunaCircleButton_Play";
            this.gunaCircleButton_Play.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Play.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Play.OnHoverImage = global::MediaPlayer.Properties.Resources.play_hover;
            this.gunaCircleButton_Play.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Play.Size = new System.Drawing.Size(64, 64);
            this.gunaCircleButton_Play.TabIndex = 18;
            this.gunaCircleButton_Play.Click += new System.EventHandler(this.gunaCircleButton_Play_Click);
            // 
            // timerSong
            // 
            this.timerSong.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MediaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel);
            this.Controls.Add(this.panel_MediaInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MediaControl";
            this.Size = new System.Drawing.Size(1200, 120);
            this.panel1.ResumeLayout(false);
            this.panel_MediaInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_SongImage)).EndInit();
            this.gunaPanel.ResumeLayout(false);
            this.gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel timeSongEnd;
        private Guna.UI.WinForms.GunaLabel timeSongPlay;
        private Guna.UI.WinForms.GunaTrackBar MediaTrackBar;
        private System.Windows.Forms.Panel panel_MediaInfo;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox_SongImage;
        private Guna.UI.WinForms.GunaLabel gunaLabel_SongName;
        private Guna.UI.WinForms.GunaLabel gunaLabel_NameAthor;
        private Guna.UI.WinForms.GunaPanel gunaPanel;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_Play;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_next;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton4;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_prev;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton5;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_Like;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar_Volume;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_Volume;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_Open;
        private System.Windows.Forms.Timer timerSong;
    }
}
