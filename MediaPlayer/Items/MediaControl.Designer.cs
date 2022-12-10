namespace MediaPlayer.Items
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
            this.timeSongEnd = new Guna.UI.WinForms.GunaLabel();
            this.MediaTrackBar = new Guna.UI.WinForms.GunaTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaTrackBar_Volume = new Guna.UI.WinForms.GunaTrackBar();
            this.btn_Volume = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel_SongName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel_NameAthor = new Guna.UI.WinForms.GunaLabel();
            this.timeSongPlay = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaCircleButton4 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton_prev = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton5 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton_next = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Play = new Guna.UI.WinForms.GunaCircleButton();
            this.timerSong = new System.Windows.Forms.Timer(this.components);
            this.gunaCircleButton_Like = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaPictureBox_SongImage = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            this.gunaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_SongImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSongEnd
            // 
            this.timeSongEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSongEnd.AutoSize = true;
            this.timeSongEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeSongEnd.ForeColor = System.Drawing.Color.White;
            this.timeSongEnd.Location = new System.Drawing.Point(536, 13);
            this.timeSongEnd.Name = "timeSongEnd";
            this.timeSongEnd.Size = new System.Drawing.Size(44, 20);
            this.timeSongEnd.TabIndex = 17;
            this.timeSongEnd.Text = "00:00";
            // 
            // MediaTrackBar
            // 
            this.MediaTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MediaTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.MediaTrackBar.Location = new System.Drawing.Point(55, 10);
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
            this.panel1.Controls.Add(this.btn_Volume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(926, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 120);
            this.panel1.TabIndex = 14;
            // 
            // gunaTrackBar_Volume
            // 
            this.gunaTrackBar_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTrackBar_Volume.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaTrackBar_Volume.Location = new System.Drawing.Point(75, 49);
            this.gunaTrackBar_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTrackBar_Volume.Name = "gunaTrackBar_Volume";
            this.gunaTrackBar_Volume.Size = new System.Drawing.Size(160, 26);
            this.gunaTrackBar_Volume.TabIndex = 20;
            this.gunaTrackBar_Volume.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaTrackBar_Volume.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaTrackBar_Volume.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar_Volume.Value = 100;
            this.gunaTrackBar_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar_Volume_Scroll);
            // 
            // btn_Volume
            // 
            this.btn_Volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Volume.Animated = true;
            this.btn_Volume.AnimationHoverSpeed = 0.07F;
            this.btn_Volume.AnimationSpeed = 0.03F;
            this.btn_Volume.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Volume.BorderColor = System.Drawing.Color.Black;
            this.btn_Volume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Volume.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_Volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Volume.ForeColor = System.Drawing.Color.White;
            this.btn_Volume.Image = global::MediaPlayer.Properties.Resources.volume_high;
            this.btn_Volume.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Volume.Location = new System.Drawing.Point(37, 47);
            this.btn_Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Volume.Name = "btn_Volume";
            this.btn_Volume.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Volume.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Volume.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_Volume.OnHoverImage = global::MediaPlayer.Properties.Resources.volume_high_hover;
            this.btn_Volume.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Volume.Size = new System.Drawing.Size(32, 32);
            this.btn_Volume.TabIndex = 19;
            this.btn_Volume.Click += new System.EventHandler(this.gunaCircleButton_Volume_Click);
            // 
            // gunaLabel_SongName
            // 
            this.gunaLabel_SongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_SongName.AutoEllipsis = true;
            this.gunaLabel_SongName.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_SongName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel_SongName.ForeColor = System.Drawing.Color.White;
            this.gunaLabel_SongName.Location = new System.Drawing.Point(120, 24);
            this.gunaLabel_SongName.Name = "gunaLabel_SongName";
            this.gunaLabel_SongName.Size = new System.Drawing.Size(180, 23);
            this.gunaLabel_SongName.TabIndex = 6;
            this.gunaLabel_SongName.Text = "Tên bài hát";
            // 
            // gunaLabel_NameAthor
            // 
            this.gunaLabel_NameAthor.AutoEllipsis = true;
            this.gunaLabel_NameAthor.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_NameAthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel_NameAthor.ForeColor = System.Drawing.Color.White;
            this.gunaLabel_NameAthor.Location = new System.Drawing.Point(124, 47);
            this.gunaLabel_NameAthor.Name = "gunaLabel_NameAthor";
            this.gunaLabel_NameAthor.Size = new System.Drawing.Size(153, 56);
            this.gunaLabel_NameAthor.TabIndex = 7;
            this.gunaLabel_NameAthor.Text = "Tên ca sĩ";
            // 
            // timeSongPlay
            // 
            this.timeSongPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSongPlay.AutoSize = true;
            this.timeSongPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeSongPlay.ForeColor = System.Drawing.Color.White;
            this.timeSongPlay.Location = new System.Drawing.Point(5, 13);
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
            this.gunaPanel.Controls.Add(this.gunaCircleButton4);
            this.gunaPanel.Controls.Add(this.MediaTrackBar);
            this.gunaPanel.Controls.Add(this.timeSongPlay);
            this.gunaPanel.Controls.Add(this.gunaCircleButton_prev);
            this.gunaPanel.Controls.Add(this.gunaCircleButton5);
            this.gunaPanel.Controls.Add(this.gunaCircleButton_next);
            this.gunaPanel.Controls.Add(this.btn_Play);
            this.gunaPanel.Location = new System.Drawing.Point(332, 0);
            this.gunaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel.Name = "gunaPanel";
            this.gunaPanel.Size = new System.Drawing.Size(591, 120);
            this.gunaPanel.TabIndex = 13;
            // 
            // gunaCircleButton4
            // 
            this.gunaCircleButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaCircleButton4.Animated = true;
            this.gunaCircleButton4.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton4.AnimationSpeed = 0.03F;
            this.gunaCircleButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton4.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton4.Image = global::MediaPlayer.Properties.Resources.suffle;
            this.gunaCircleButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaCircleButton4.Location = new System.Drawing.Point(90, 47);
            this.gunaCircleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton4.Name = "gunaCircleButton4";
            this.gunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton4.OnHoverImage = global::MediaPlayer.Properties.Resources.suffle_hover;
            this.gunaCircleButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton4.Size = new System.Drawing.Size(49, 49);
            this.gunaCircleButton4.TabIndex = 19;
            // 
            // gunaCircleButton_prev
            // 
            this.gunaCircleButton_prev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaCircleButton_prev.Animated = true;
            this.gunaCircleButton_prev.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_prev.AnimationSpeed = 0.03F;
            this.gunaCircleButton_prev.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_prev.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_prev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_prev.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_prev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_prev.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_prev.Image = global::MediaPlayer.Properties.Resources.back;
            this.gunaCircleButton_prev.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaCircleButton_prev.Location = new System.Drawing.Point(181, 47);
            this.gunaCircleButton_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_prev.Name = "gunaCircleButton_prev";
            this.gunaCircleButton_prev.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_prev.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_prev.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_prev.OnHoverImage = global::MediaPlayer.Properties.Resources.back_hover;
            this.gunaCircleButton_prev.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_prev.Size = new System.Drawing.Size(49, 49);
            this.gunaCircleButton_prev.TabIndex = 19;
            this.gunaCircleButton_prev.Click += new System.EventHandler(this.gunaCircleButton_prev_Click);
            // 
            // gunaCircleButton5
            // 
            this.gunaCircleButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaCircleButton5.Animated = true;
            this.gunaCircleButton5.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton5.AnimationSpeed = 0.03F;
            this.gunaCircleButton5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton5.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton5.Image = global::MediaPlayer.Properties.Resources.repeat;
            this.gunaCircleButton5.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaCircleButton5.Location = new System.Drawing.Point(453, 47);
            this.gunaCircleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton5.Name = "gunaCircleButton5";
            this.gunaCircleButton5.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton5.OnHoverImage = global::MediaPlayer.Properties.Resources.repeat_hover;
            this.gunaCircleButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton5.Size = new System.Drawing.Size(49, 49);
            this.gunaCircleButton5.TabIndex = 18;
            // 
            // gunaCircleButton_next
            // 
            this.gunaCircleButton_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaCircleButton_next.Animated = true;
            this.gunaCircleButton_next.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_next.AnimationSpeed = 0.03F;
            this.gunaCircleButton_next.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_next.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_next.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_next.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_next.Image = global::MediaPlayer.Properties.Resources.next;
            this.gunaCircleButton_next.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaCircleButton_next.Location = new System.Drawing.Point(358, 47);
            this.gunaCircleButton_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_next.Name = "gunaCircleButton_next";
            this.gunaCircleButton_next.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_next.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_next.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_next.OnHoverImage = global::MediaPlayer.Properties.Resources.next_hover;
            this.gunaCircleButton_next.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_next.Size = new System.Drawing.Size(49, 49);
            this.gunaCircleButton_next.TabIndex = 18;
            this.gunaCircleButton_next.Click += new System.EventHandler(this.gunaCircleButton_next_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Play.Animated = true;
            this.btn_Play.AnimationHoverSpeed = 0.07F;
            this.btn_Play.AnimationSpeed = 0.03F;
            this.btn_Play.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Play.BorderColor = System.Drawing.Color.Black;
            this.btn_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Play.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Image = global::MediaPlayer.Properties.Resources.play;
            this.btn_Play.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Play.Location = new System.Drawing.Point(262, 39);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Play.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_Play.OnHoverImage = global::MediaPlayer.Properties.Resources.play_hover;
            this.btn_Play.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Play.Size = new System.Drawing.Size(64, 64);
            this.btn_Play.TabIndex = 18;
            this.btn_Play.Click += new System.EventHandler(this.gunaCircleButton_Play_Click);
            // 
            // timerSong
            // 
            this.timerSong.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gunaCircleButton_Like
            // 
            this.gunaCircleButton_Like.Animated = true;
            this.gunaCircleButton_Like.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton_Like.AnimationSpeed = 0.03F;
            this.gunaCircleButton_Like.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Like.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Like.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton_Like.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton_Like.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton_Like.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton_Like.Image = global::MediaPlayer.Properties.Resources.favorite;
            this.gunaCircleButton_Like.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaCircleButton_Like.Location = new System.Drawing.Point(283, 59);
            this.gunaCircleButton_Like.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton_Like.Name = "gunaCircleButton_Like";
            this.gunaCircleButton_Like.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Like.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Like.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton_Like.OnHoverImage = global::MediaPlayer.Properties.Resources.favorite_hover;
            this.gunaCircleButton_Like.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton_Like.Size = new System.Drawing.Size(35, 37);
            this.gunaCircleButton_Like.TabIndex = 19;
            this.gunaCircleButton_Like.Click += new System.EventHandler(this.gunaCircleButton_Like_Click);
            // 
            // gunaPictureBox_SongImage
            // 
            this.gunaPictureBox_SongImage.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox_SongImage.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox_SongImage.Location = new System.Drawing.Point(13, 13);
            this.gunaPictureBox_SongImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox_SongImage.Name = "gunaPictureBox_SongImage";
            this.gunaPictureBox_SongImage.Radius = 10;
            this.gunaPictureBox_SongImage.Size = new System.Drawing.Size(91, 90);
            this.gunaPictureBox_SongImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox_SongImage.TabIndex = 8;
            this.gunaPictureBox_SongImage.TabStop = false;
            // 
            // MediaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.gunaCircleButton_Like);
            this.Controls.Add(this.gunaPanel);
            this.Controls.Add(this.gunaLabel_SongName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPictureBox_SongImage);
            this.Controls.Add(this.gunaLabel_NameAthor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MediaControl";
            this.Size = new System.Drawing.Size(1200, 120);
            this.panel1.ResumeLayout(false);
            this.gunaPanel.ResumeLayout(false);
            this.gunaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_SongImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel timeSongEnd;
        private Guna.UI.WinForms.GunaLabel timeSongPlay;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox_SongImage;
        private Guna.UI.WinForms.GunaLabel gunaLabel_SongName;
        private Guna.UI.WinForms.GunaLabel gunaLabel_NameAthor;
        private Guna.UI.WinForms.GunaPanel gunaPanel;
        private Guna.UI.WinForms.GunaCircleButton btn_Play;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_next;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton4;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_prev;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton5;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton_Like;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar_Volume;
        private Guna.UI.WinForms.GunaCircleButton btn_Volume;
        private System.Windows.Forms.Timer timerSong;
        public Guna.UI.WinForms.GunaTrackBar MediaTrackBar;
    }
}
