namespace MediaPlayer.Items
{
    partial class MediaItem
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
            this.panel_MediaItem = new Guna.UI.WinForms.GunaElipsePanel();
            this.label_Author = new Guna.UI.WinForms.GunaLabel();
            this.label_NameSong = new Guna.UI.WinForms.GunaLabel();
            this.pic_SongPic = new Guna.UI.WinForms.GunaPictureBox();
            this.panel_MediaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SongPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MediaItem
            // 
            this.panel_MediaItem.BackColor = System.Drawing.Color.Transparent;
            this.panel_MediaItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_MediaItem.Controls.Add(this.label_Author);
            this.panel_MediaItem.Controls.Add(this.label_NameSong);
            this.panel_MediaItem.Controls.Add(this.pic_SongPic);
            this.panel_MediaItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MediaItem.Location = new System.Drawing.Point(0, 0);
            this.panel_MediaItem.Name = "panel_MediaItem";
            this.panel_MediaItem.Radius = 10;
            this.panel_MediaItem.Size = new System.Drawing.Size(200, 300);
            this.panel_MediaItem.TabIndex = 0;
            this.panel_MediaItem.Click += new System.EventHandler(this.MediaItem_Click);
            this.panel_MediaItem.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.panel_MediaItem.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.panel_MediaItem.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // label_DateCreate
            // 
            this.label_Author.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Author.ForeColor = System.Drawing.Color.Silver;
            this.label_Author.Location = new System.Drawing.Point(3, 231);
            this.label_Author.Name = "label_DateCreate";
            this.label_Author.Size = new System.Drawing.Size(194, 59);
            this.label_Author.TabIndex = 5;
            this.label_Author.Text = "gunaLabel2";
            this.label_Author.Click += new System.EventHandler(this.MediaItem_Click);
            this.label_Author.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.label_Author.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.label_Author.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // label_Name
            // 
            this.label_NameSong.AutoEllipsis = true;
            this.label_NameSong.BackColor = System.Drawing.Color.Transparent;
            this.label_NameSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_NameSong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_NameSong.ForeColor = System.Drawing.Color.White;
            this.label_NameSong.Location = new System.Drawing.Point(0, 203);
            this.label_NameSong.Name = "label_Name";
            this.label_NameSong.Size = new System.Drawing.Size(197, 28);
            this.label_NameSong.TabIndex = 4;
            this.label_NameSong.Text = "MediaName";
            this.label_NameSong.Click += new System.EventHandler(this.MediaItem_Click);
            this.label_NameSong.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.label_NameSong.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.label_NameSong.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // pic_SongPic
            // 
            this.pic_SongPic.BackColor = System.Drawing.Color.Transparent;
            this.pic_SongPic.BaseColor = System.Drawing.Color.LightGray;
            this.pic_SongPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_SongPic.Location = new System.Drawing.Point(0, 0);
            this.pic_SongPic.Name = "pic_SongPic";
            this.pic_SongPic.Radius = 10;
            this.pic_SongPic.Size = new System.Drawing.Size(200, 200);
            this.pic_SongPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SongPic.TabIndex = 3;
            this.pic_SongPic.TabStop = false;
            this.pic_SongPic.Click += new System.EventHandler(this.MediaItem_Click);
            this.pic_SongPic.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.pic_SongPic.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.pic_SongPic.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_MediaItem);
            this.MaximumSize = new System.Drawing.Size(200, 300);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(200, 300);
            this.panel_MediaItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SongPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel panel_MediaItem;
        private Guna.UI.WinForms.GunaLabel label_Author;
        private Guna.UI.WinForms.GunaLabel label_NameSong;
        private Guna.UI.WinForms.GunaPictureBox pic_SongPic;
    }
}
