﻿namespace MediaPlayer
{
    partial class VideoPlayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.timer_Hide = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_play = new Guna.UI.WinForms.GunaCircleButton();
            this.lb_SongName = new Guna.UI.WinForms.GunaLabel();
            this.gunaTrackBar_Volume = new Guna.UI.WinForms.GunaTrackBar();
            this.btn_volum = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_giam = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_FullScreen = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Hide = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_tang = new Guna.UI.WinForms.GunaCircleButton();
            this.timeSongEnd = new System.Windows.Forms.Label();
            this.timeSongPlay = new System.Windows.Forms.Label();
            this.MediaTrackBar = new Guna.UI.WinForms.GunaTrackBar();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSong
            // 
            this.timerSong.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_Hide
            // 
            this.timer_Hide.Interval = 1000;
            this.timer_Hide.Tick += new System.EventHandler(this.timer_Hide_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.lb_SongName);
            this.panel1.Controls.Add(this.gunaTrackBar_Volume);
            this.panel1.Controls.Add(this.btn_volum);
            this.panel1.Controls.Add(this.btn_giam);
            this.panel1.Controls.Add(this.btn_FullScreen);
            this.panel1.Controls.Add(this.btn_Hide);
            this.panel1.Controls.Add(this.btn_tang);
            this.panel1.Controls.Add(this.timeSongEnd);
            this.panel1.Controls.Add(this.timeSongPlay);
            this.panel1.Controls.Add(this.MediaTrackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 123);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel1_PreviewKeyDown);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_play.Animated = true;
            this.btn_play.AnimationHoverSpeed = 0.07F;
            this.btn_play.AnimationSpeed = 0.03F;
            this.btn_play.BaseColor = System.Drawing.Color.Transparent;
            this.btn_play.BorderColor = System.Drawing.Color.Black;
            this.btn_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_play.FocusedColor = System.Drawing.Color.Empty;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Image = global::MediaPlayer.Properties.Resources.play;
            this.btn_play.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_play.Location = new System.Drawing.Point(552, 48);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_play.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_play.OnHoverImage = global::MediaPlayer.Properties.Resources.play_hover;
            this.btn_play.OnPressedColor = System.Drawing.Color.Black;
            this.btn_play.Size = new System.Drawing.Size(64, 64);
            this.btn_play.TabIndex = 26;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lb_SongName
            // 
            this.lb_SongName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_SongName.AutoEllipsis = true;
            this.lb_SongName.BackColor = System.Drawing.Color.Transparent;
            this.lb_SongName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_SongName.ForeColor = System.Drawing.Color.Transparent;
            this.lb_SongName.Location = new System.Drawing.Point(12, 65);
            this.lb_SongName.Name = "lb_SongName";
            this.lb_SongName.Size = new System.Drawing.Size(366, 23);
            this.lb_SongName.TabIndex = 25;
            this.lb_SongName.Text = "Tên bài hát";
            // 
            // gunaTrackBar_Volume
            // 
            this.gunaTrackBar_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTrackBar_Volume.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaTrackBar_Volume.Location = new System.Drawing.Point(994, 62);
            this.gunaTrackBar_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTrackBar_Volume.Name = "gunaTrackBar_Volume";
            this.gunaTrackBar_Volume.Size = new System.Drawing.Size(139, 26);
            this.gunaTrackBar_Volume.TabIndex = 24;
            this.gunaTrackBar_Volume.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaTrackBar_Volume.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaTrackBar_Volume.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.Value = 100;
            this.gunaTrackBar_Volume.ValueChanged += new System.EventHandler(this.gunaTrackBar_Volume_ValueChanged);
            this.gunaTrackBar_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar_Volume_Scroll);
            this.gunaTrackBar_Volume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            // 
            // btn_volum
            // 
            this.btn_volum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volum.Animated = true;
            this.btn_volum.AnimationHoverSpeed = 0.07F;
            this.btn_volum.AnimationSpeed = 0.03F;
            this.btn_volum.BackColor = System.Drawing.Color.Transparent;
            this.btn_volum.BaseColor = System.Drawing.Color.Transparent;
            this.btn_volum.BorderColor = System.Drawing.Color.Black;
            this.btn_volum.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_volum.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_volum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_volum.ForeColor = System.Drawing.Color.White;
            this.btn_volum.Image = global::MediaPlayer.Properties.Resources.volume_high;
            this.btn_volum.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_volum.Location = new System.Drawing.Point(954, 59);
            this.btn_volum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_volum.Name = "btn_volum";
            this.btn_volum.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_volum.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_volum.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_volum.OnHoverImage = global::MediaPlayer.Properties.Resources.volume_high;
            this.btn_volum.OnPressedColor = System.Drawing.Color.Black;
            this.btn_volum.Size = new System.Drawing.Size(32, 32);
            this.btn_volum.TabIndex = 23;
            this.btn_volum.Click += new System.EventHandler(this.gunaCircleButton_Volume_Click);
            this.btn_volum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            // 
            // btn_giam
            // 
            this.btn_giam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_giam.AnimationHoverSpeed = 0.07F;
            this.btn_giam.AnimationSpeed = 0.03F;
            this.btn_giam.BaseColor = System.Drawing.Color.Transparent;
            this.btn_giam.BorderColor = System.Drawing.Color.Black;
            this.btn_giam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_giam.FocusedColor = System.Drawing.Color.Empty;
            this.btn_giam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_giam.ForeColor = System.Drawing.Color.White;
            this.btn_giam.Image = global::MediaPlayer.Properties.Resources.replay10s;
            this.btn_giam.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_giam.Location = new System.Drawing.Point(480, 62);
            this.btn_giam.Name = "btn_giam";
            this.btn_giam.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_giam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_giam.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_giam.OnHoverImage = global::MediaPlayer.Properties.Resources.replay10s_hover;
            this.btn_giam.OnPressedColor = System.Drawing.Color.Black;
            this.btn_giam.Size = new System.Drawing.Size(32, 32);
            this.btn_giam.TabIndex = 22;
            this.btn_giam.Click += new System.EventHandler(this.btn_giam_Click);
            this.btn_giam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            // 
            // btn_FullScreen
            // 
            this.btn_FullScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FullScreen.AnimationHoverSpeed = 0.07F;
            this.btn_FullScreen.AnimationSpeed = 0.03F;
            this.btn_FullScreen.BaseColor = System.Drawing.Color.Transparent;
            this.btn_FullScreen.BorderColor = System.Drawing.Color.Black;
            this.btn_FullScreen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_FullScreen.FocusedColor = System.Drawing.Color.Empty;
            this.btn_FullScreen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FullScreen.ForeColor = System.Drawing.Color.White;
            this.btn_FullScreen.Image = global::MediaPlayer.Properties.Resources.Full_Screen;
            this.btn_FullScreen.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_FullScreen.Location = new System.Drawing.Point(728, 64);
            this.btn_FullScreen.Name = "btn_FullScreen";
            this.btn_FullScreen.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_FullScreen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_FullScreen.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_FullScreen.OnHoverImage = global::MediaPlayer.Properties.Resources.Full_Screen_Hover;
            this.btn_FullScreen.OnPressedColor = System.Drawing.Color.Black;
            this.btn_FullScreen.Size = new System.Drawing.Size(25, 25);
            this.btn_FullScreen.TabIndex = 22;
            this.btn_FullScreen.Click += new System.EventHandler(this.btn_FullScreen_Click);
            this.btn_FullScreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Hide.AnimationHoverSpeed = 0.07F;
            this.btn_Hide.AnimationSpeed = 0.03F;
            this.btn_Hide.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Hide.BorderColor = System.Drawing.Color.Black;
            this.btn_Hide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Hide.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Hide.ForeColor = System.Drawing.Color.White;
            this.btn_Hide.Image = global::MediaPlayer.Properties.Resources.hide_control;
            this.btn_Hide.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Hide.Location = new System.Drawing.Point(405, 64);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Hide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Hide.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Hide.OnHoverImage = global::MediaPlayer.Properties.Resources.hide_control_hover;
            this.btn_Hide.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Hide.Size = new System.Drawing.Size(25, 25);
            this.btn_Hide.TabIndex = 22;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            this.btn_Hide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            // 
            // btn_tang
            // 
            this.btn_tang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tang.AnimationHoverSpeed = 0.07F;
            this.btn_tang.AnimationSpeed = 0.03F;
            this.btn_tang.BaseColor = System.Drawing.Color.Transparent;
            this.btn_tang.BorderColor = System.Drawing.Color.Black;
            this.btn_tang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_tang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_tang.ForeColor = System.Drawing.Color.White;
            this.btn_tang.Image = global::MediaPlayer.Properties.Resources.forward10s;
            this.btn_tang.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_tang.Location = new System.Drawing.Point(647, 62);
            this.btn_tang.Name = "btn_tang";
            this.btn_tang.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_tang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_tang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tang.OnHoverImage = global::MediaPlayer.Properties.Resources.forward10s_hover;
            this.btn_tang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tang.Size = new System.Drawing.Size(32, 32);
            this.btn_tang.TabIndex = 22;
            this.btn_tang.Click += new System.EventHandler(this.btn_tang_Click);
            this.btn_tang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            // 
            // timeSongEnd
            // 
            this.timeSongEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSongEnd.AutoSize = true;
            this.timeSongEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSongEnd.ForeColor = System.Drawing.Color.White;
            this.timeSongEnd.Location = new System.Drawing.Point(1105, 25);
            this.timeSongEnd.Name = "timeSongEnd";
            this.timeSongEnd.Size = new System.Drawing.Size(44, 18);
            this.timeSongEnd.TabIndex = 1;
            this.timeSongEnd.Text = "00:00";
            // 
            // timeSongPlay
            // 
            this.timeSongPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeSongPlay.AutoSize = true;
            this.timeSongPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSongPlay.ForeColor = System.Drawing.Color.White;
            this.timeSongPlay.Location = new System.Drawing.Point(12, 25);
            this.timeSongPlay.Name = "timeSongPlay";
            this.timeSongPlay.Size = new System.Drawing.Size(44, 18);
            this.timeSongPlay.TabIndex = 1;
            this.timeSongPlay.Text = "00:00";
            // 
            // MediaTrackBar
            // 
            this.MediaTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaTrackBar.DisplayFocus = true;
            this.MediaTrackBar.Location = new System.Drawing.Point(66, 23);
            this.MediaTrackBar.Name = "MediaTrackBar";
            this.MediaTrackBar.Size = new System.Drawing.Size(1029, 23);
            this.MediaTrackBar.TabIndex = 0;
            this.MediaTrackBar.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.MediaTrackBar.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.MediaTrackBar.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.MediaTrackBar.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.MediaTrackBar.Value = 0;
            this.MediaTrackBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            this.MediaTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MediaTrackBar_MouseDown);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1158, 659);
            this.player.TabIndex = 2;
            this.player.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.player_ClickEvent_1);
            this.player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.player_KeyDownEvent);
            this.player.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.player_MouseMoveEvent);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoPlayer";
            this.Text = "Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_FormClosing);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayer_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSong;
        private System.Windows.Forms.Timer timer_Hide;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCircleButton btn_play;
        private Guna.UI.WinForms.GunaLabel lb_SongName;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar_Volume;
        private Guna.UI.WinForms.GunaCircleButton btn_volum;
        private Guna.UI.WinForms.GunaCircleButton btn_giam;
        private Guna.UI.WinForms.GunaCircleButton btn_FullScreen;
        private Guna.UI.WinForms.GunaCircleButton btn_Hide;
        private Guna.UI.WinForms.GunaCircleButton btn_tang;
        private System.Windows.Forms.Label timeSongEnd;
        private System.Windows.Forms.Label timeSongPlay;
        private Guna.UI.WinForms.GunaTrackBar MediaTrackBar;
        public AxWMPLib.AxWindowsMediaPlayer player;
    }
}