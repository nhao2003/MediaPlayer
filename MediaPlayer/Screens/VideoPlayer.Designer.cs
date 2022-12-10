namespace MediaPlayer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SongName = new Guna.UI.WinForms.GunaLabel();
            this.gunaTrackBar_Volume = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaCircleButton_Volume = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_giam = new System.Windows.Forms.Button();
            this.btn_Fullscreen = new System.Windows.Forms.Button();
            this.btn_tang = new System.Windows.Forms.Button();
            this.btn_play = new Guna.UI.WinForms.GunaCircleButton();
            this.timeSongEnd = new System.Windows.Forms.Label();
            this.timeSongPlay = new System.Windows.Forms.Label();
            this.MediaTrackBar = new Guna.UI.WinForms.GunaTrackBar();
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lb_SongName);
            this.panel1.Controls.Add(this.gunaTrackBar_Volume);
            this.panel1.Controls.Add(this.gunaCircleButton_Volume);
            this.panel1.Controls.Add(this.btn_giam);
            this.panel1.Controls.Add(this.btn_Fullscreen);
            this.panel1.Controls.Add(this.btn_tang);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.timeSongEnd);
            this.panel1.Controls.Add(this.timeSongPlay);
            this.panel1.Controls.Add(this.MediaTrackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 123);
            this.panel1.TabIndex = 1;
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
            this.lb_SongName.Size = new System.Drawing.Size(420, 23);
            this.lb_SongName.TabIndex = 25;
            this.lb_SongName.Text = "Tên bài hát";
            // 
            // gunaTrackBar_Volume
            // 
            this.gunaTrackBar_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTrackBar_Volume.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaTrackBar_Volume.Location = new System.Drawing.Point(966, 65);
            this.gunaTrackBar_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTrackBar_Volume.Name = "gunaTrackBar_Volume";
            this.gunaTrackBar_Volume.Size = new System.Drawing.Size(180, 26);
            this.gunaTrackBar_Volume.TabIndex = 24;
            this.gunaTrackBar_Volume.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaTrackBar_Volume.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaTrackBar_Volume.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar_Volume_Scroll);
            // 
            // gunaCircleButton_Volume
            // 
            this.gunaCircleButton_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCircleButton_Volume.Animated = true;
            this.gunaCircleButton_Volume.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_Volume.AnimationSpeed = 0.03F;
            this.gunaCircleButton_Volume.BackColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Volume.BaseColor = System.Drawing.Color.White;
            this.gunaCircleButton_Volume.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Volume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_Volume.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_Volume.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_Volume.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Volume.Image")));
            this.gunaCircleButton_Volume.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton_Volume.Location = new System.Drawing.Point(918, 62);
            this.gunaCircleButton_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_Volume.Name = "gunaCircleButton_Volume";
            this.gunaCircleButton_Volume.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Volume.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton_Volume.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Volume.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton_Volume.OnHoverImage")));
            this.gunaCircleButton_Volume.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Volume.Size = new System.Drawing.Size(32, 32);
            this.gunaCircleButton_Volume.TabIndex = 23;
            this.gunaCircleButton_Volume.Click += new System.EventHandler(this.gunaCircleButton_Volume_Click);
            // 
            // btn_giam
            // 
            this.btn_giam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_giam.Location = new System.Drawing.Point(451, 66);
            this.btn_giam.Name = "btn_giam";
            this.btn_giam.Size = new System.Drawing.Size(75, 29);
            this.btn_giam.TabIndex = 22;
            this.btn_giam.Text = "Lùi 10s";
            this.btn_giam.UseVisualStyleBackColor = true;
            this.btn_giam.Click += new System.EventHandler(this.btn_giam_Click);
            // 
            // btn_Fullscreen
            // 
            this.btn_Fullscreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Fullscreen.Location = new System.Drawing.Point(745, 66);
            this.btn_Fullscreen.Name = "btn_Fullscreen";
            this.btn_Fullscreen.Size = new System.Drawing.Size(84, 29);
            this.btn_Fullscreen.TabIndex = 22;
            this.btn_Fullscreen.Text = "Fullscreen";
            this.btn_Fullscreen.UseVisualStyleBackColor = true;
            this.btn_Fullscreen.Click += new System.EventHandler(this.btn_tang_Click);
            // 
            // btn_tang
            // 
            this.btn_tang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tang.Location = new System.Drawing.Point(633, 66);
            this.btn_tang.Name = "btn_tang";
            this.btn_tang.Size = new System.Drawing.Size(84, 29);
            this.btn_tang.TabIndex = 22;
            this.btn_tang.Text = "Tăng 10s";
            this.btn_tang.UseVisualStyleBackColor = true;
            this.btn_tang.Click += new System.EventHandler(this.btn_tang_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_play.Animated = true;
            this.btn_play.AnimationHoverSpeed = 0.07F;
            this.btn_play.AnimationSpeed = 0.03F;
            this.btn_play.BaseColor = System.Drawing.Color.White;
            this.btn_play.BorderColor = System.Drawing.Color.Black;
            this.btn_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_play.FocusedColor = System.Drawing.Color.Empty;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_play.Location = new System.Drawing.Point(547, 49);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.btn_play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_play.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.btn_play.OnHoverImage = global::MediaPlayer.Properties.Resources.play_hover;
            this.btn_play.OnPressedColor = System.Drawing.Color.Black;
            this.btn_play.Size = new System.Drawing.Size(64, 64);
            this.btn_play.TabIndex = 21;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // timeSongEnd
            // 
            this.timeSongEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSongEnd.AutoSize = true;
            this.timeSongEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSongEnd.ForeColor = System.Drawing.Color.White;
            this.timeSongEnd.Location = new System.Drawing.Point(1102, 25);
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
            this.MediaTrackBar.Size = new System.Drawing.Size(1026, 23);
            this.MediaTrackBar.TabIndex = 0;
            this.MediaTrackBar.TrackColor = System.Drawing.Color.DimGray;
            this.MediaTrackBar.TrackHoverColor = System.Drawing.Color.Gray;
            this.MediaTrackBar.TrackIdleColor = System.Drawing.Color.Silver;
            this.MediaTrackBar.TrackPressedColor = System.Drawing.Color.Black;
            this.MediaTrackBar.Value = 0;
            this.MediaTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MediaTrackBar_MouseDown);
            // 
            // timerSong
            // 
            this.timerSong.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1158, 659);
            this.player.TabIndex = 0;
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VideoPlayer";
            this.Text = "VideoPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTrackBar MediaTrackBar;
        private System.Windows.Forms.Label timeSongEnd;
        private System.Windows.Forms.Label timeSongPlay;
        private System.Windows.Forms.Button btn_giam;
        private System.Windows.Forms.Button btn_tang;
        private Guna.UI.WinForms.GunaCircleButton btn_play;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar_Volume;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_Volume;
        private Guna.UI.WinForms.GunaLabel lb_SongName;
        private System.Windows.Forms.Timer timerSong;
        private System.Windows.Forms.Button btn_Fullscreen;
    }
}