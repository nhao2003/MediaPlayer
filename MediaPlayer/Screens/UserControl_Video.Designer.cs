namespace MediaPlayer.Widgets
{
    partial class UserControl_Video
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
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lb_album = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.listBox_title = new System.Windows.Forms.ListBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.label_track_start = new System.Windows.Forms.Label();
            this.label_strack_end = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(197, 65);
            this.gunaLabel_Recent.TabIndex = 2;
            this.gunaLabel_Recent.Text = "Video";
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.pic_art.Location = new System.Drawing.Point(665, 68);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(100, 100);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_art.TabIndex = 3;
            this.pic_art.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(777, 68);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(64, 20);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Titlte :";
            // 
            // lb_album
            // 
            this.lb_album.AutoSize = true;
            this.lb_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_album.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_album.Location = new System.Drawing.Point(777, 106);
            this.lb_album.Name = "lb_album";
            this.lb_album.Size = new System.Drawing.Size(73, 20);
            this.lb_album.TabIndex = 4;
            this.lb_album.Text = "Album :";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_year.Location = new System.Drawing.Point(777, 142);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(59, 20);
            this.lb_year.TabIndex = 4;
            this.lb_year.Text = "Year :";
            // 
            // listBox_title
            // 
            this.listBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.listBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_title.FormattingEnabled = true;
            this.listBox_title.ItemHeight = 20;
            this.listBox_title.Location = new System.Drawing.Point(665, 309);
            this.listBox_title.Name = "listBox_title";
            this.listBox_title.Size = new System.Drawing.Size(376, 244);
            this.listBox_title.TabIndex = 5;
            this.listBox_title.SelectedIndexChanged += new System.EventHandler(this.listBox_title_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.Color.Gray;
            this.textBox_Search.Location = new System.Drawing.Point(665, 279);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(376, 24);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.Text = "Search";
            this.textBox_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_name_MouseClick);
            this.textBox_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Search_KeyUp);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(665, 249);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(139, 24);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(234, 525);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(86, 28);
            this.button_Play.TabIndex = 7;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(112, 525);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(86, 28);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(436, 525);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(86, 28);
            this.button_pause.TabIndex = 7;
            this.button_pause.Text = "pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(550, 525);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(86, 28);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(892, 238);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(149, 56);
            this.track_volume.TabIndex = 9;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Value = 50;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(863, 253);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(33, 16);
            this.label_volume.TabIndex = 10;
            this.label_volume.Text = "50%";
            // 
            // label_track_start
            // 
            this.label_track_start.AutoSize = true;
            this.label_track_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_track_start.Location = new System.Drawing.Point(18, 482);
            this.label_track_start.Name = "label_track_start";
            this.label_track_start.Size = new System.Drawing.Size(43, 16);
            this.label_track_start.TabIndex = 11;
            this.label_track_start.Text = "00:00";
            // 
            // label_strack_end
            // 
            this.label_strack_end.AutoSize = true;
            this.label_strack_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_strack_end.Location = new System.Drawing.Point(593, 482);
            this.label_strack_end.Name = "label_strack_end";
            this.label_strack_end.Size = new System.Drawing.Size(43, 16);
            this.label_strack_end.TabIndex = 11;
            this.label_strack_end.Text = "00:00";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(67, 480);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_continue
            // 
            this.button_continue.Location = new System.Drawing.Point(335, 525);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(86, 28);
            this.button_continue.TabIndex = 7;
            this.button_continue.Text = "Continue";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // UserControl_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label_strack_end);
            this.Controls.Add(this.label_track_start);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.listBox_title);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.lb_album);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.gunaLabel_Recent);
            this.Controls.Add(this.track_volume);
            this.Name = "UserControl_Video";
            this.Size = new System.Drawing.Size(1085, 583);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel_Recent;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lb_album;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.ListBox listBox_title;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label_track_start;
        private System.Windows.Forms.Label label_strack_end;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_continue;
    }
}
