namespace MediaPlayer.Widgets
{
    partial class UserControl_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Home));
            this.flowLayoutPanel_Home = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Track_list = new System.Windows.Forms.ListBox();
            this.pic_act = new System.Windows.Forms.PictureBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTrack_start = new System.Windows.Forms.Label();
            this.labelTrackEnd = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pic_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Home
            // 
            this.flowLayoutPanel_Home.AutoScroll = true;
            this.flowLayoutPanel_Home.AutoSize = true;
            this.flowLayoutPanel_Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel_Home.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Home.Name = "flowLayoutPanel_Home";
            this.flowLayoutPanel_Home.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel_Home.TabIndex = 0;
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(1084, 65);
            this.gunaLabel_Recent.TabIndex = 5;
            this.gunaLabel_Recent.Text = "Home";
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_preview.Location = new System.Drawing.Point(11, 508);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(123, 43);
            this.btn_preview.TabIndex = 6;
            this.btn_preview.Text = "preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Location = new System.Drawing.Point(243, 508);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(123, 43);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play.Location = new System.Drawing.Point(386, 508);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(123, 43);
            this.btn_play.TabIndex = 6;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pause.Location = new System.Drawing.Point(530, 508);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(123, 43);
            this.btn_pause.TabIndex = 6;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.Location = new System.Drawing.Point(676, 508);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(123, 43);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.Location = new System.Drawing.Point(931, 508);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(123, 43);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(11, 464);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1043, 23);
            this.progressBar.TabIndex = 7;
            // 
            // Track_list
            // 
            this.Track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Track_list.FormattingEnabled = true;
            this.Track_list.ItemHeight = 16;
            this.Track_list.Location = new System.Drawing.Point(399, 205);
            this.Track_list.Name = "Track_list";
            this.Track_list.Size = new System.Drawing.Size(556, 240);
            this.Track_list.TabIndex = 8;
            this.Track_list.SelectedIndexChanged += new System.EventHandler(this.Track_list_SelectedIndexChanged);
            // 
            // pic_act
            // 
            this.pic_act.Image = global::MediaPlayer.Properties.Resources.defaultImage;
            this.pic_act.Location = new System.Drawing.Point(89, 205);
            this.pic_act.Name = "pic_act";
            this.pic_act.Size = new System.Drawing.Size(248, 243);
            this.pic_act.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_act.TabIndex = 9;
            this.pic_act.TabStop = false;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(998, 233);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 215);
            this.track_volume.TabIndex = 11;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(998, 211);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(40, 16);
            this.labelVolume.TabIndex = 12;
            this.labelVolume.Text = "100%";
            // 
            // labelTrack_start
            // 
            this.labelTrack_start.AutoSize = true;
            this.labelTrack_start.BackColor = System.Drawing.Color.Black;
            this.labelTrack_start.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrack_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTrack_start.Location = new System.Drawing.Point(3, 82);
            this.labelTrack_start.Name = "labelTrack_start";
            this.labelTrack_start.Size = new System.Drawing.Size(145, 49);
            this.labelTrack_start.TabIndex = 13;
            this.labelTrack_start.Text = "00:00";
            // 
            // labelTrackEnd
            // 
            this.labelTrackEnd.AutoSize = true;
            this.labelTrackEnd.BackColor = System.Drawing.Color.Black;
            this.labelTrackEnd.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTrackEnd.Location = new System.Drawing.Point(939, 82);
            this.labelTrackEnd.Name = "labelTrackEnd";
            this.labelTrackEnd.Size = new System.Drawing.Size(145, 49);
            this.labelTrackEnd.TabIndex = 13;
            this.labelTrackEnd.Text = "00:00";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 65);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1084, 120);
            this.player.TabIndex = 10;
            // 
            // UserControl_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.labelTrackEnd);
            this.Controls.Add(this.labelTrack_start);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pic_act);
            this.Controls.Add(this.Track_list);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.gunaLabel_Recent);
            this.Controls.Add(this.flowLayoutPanel_Home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(1084, 583);
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.UserControl_Home_SizeChanged);
            this.Resize += new System.EventHandler(this.UserControl_Home_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pic_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Home;
        private Guna.UI.WinForms.GunaLabel gunaLabel_Recent;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox Track_list;
        private System.Windows.Forms.PictureBox pic_act;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTrack_start;
        private System.Windows.Forms.Label labelTrackEnd;
    }
}
