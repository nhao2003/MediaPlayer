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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
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
            this.pic_art.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lb_album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lb_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listBox_title.AccessibleDescription = "";
            this.listBox_title.AccessibleName = "";
            this.listBox_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.listBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_title.FormattingEnabled = true;
            this.listBox_title.ItemHeight = 20;
            this.listBox_title.Location = new System.Drawing.Point(665, 302);
            this.listBox_title.Name = "listBox_title";
            this.listBox_title.Size = new System.Drawing.Size(376, 264);
            this.listBox_title.TabIndex = 5;
            this.listBox_title.SelectedIndexChanged += new System.EventHandler(this.listBox_title_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.Color.Gray;
            this.textBox_Search.Location = new System.Drawing.Point(665, 272);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(376, 24);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.Text = "Search";
            this.textBox_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_name_MouseClick);
            this.textBox_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Search_KeyUp);
            // 
            // button_Open
            // 
            this.button_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Open.Location = new System.Drawing.Point(665, 242);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(86, 24);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Play
            // 
            this.button_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Play.Location = new System.Drawing.Point(665, 208);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(86, 28);
            this.button_Play.TabIndex = 7;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_next
            // 
            this.button_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_next.Location = new System.Drawing.Point(955, 238);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(86, 28);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(855, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.listBox_title);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.lb_album);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.gunaLabel_Recent);
            this.Name = "UserControl_Video";
            this.Size = new System.Drawing.Size(1085, 583);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
