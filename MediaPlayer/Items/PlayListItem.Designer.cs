namespace MediaPlayer.Items
{
    partial class PlayListItem
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
            this.label_DateCreate = new Guna.UI.WinForms.GunaLabel();
            this.label_Name = new Guna.UI.WinForms.GunaLabel();
            this.pic_SongPic = new Guna.UI.WinForms.GunaPictureBox();
            this.panel_MediaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SongPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MediaItem
            // 
            this.panel_MediaItem.BackColor = System.Drawing.Color.Transparent;
            this.panel_MediaItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_MediaItem.Controls.Add(this.label_DateCreate);
            this.panel_MediaItem.Controls.Add(this.label_Name);
            this.panel_MediaItem.Controls.Add(this.pic_SongPic);
            this.panel_MediaItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MediaItem.Location = new System.Drawing.Point(0, 0);
            this.panel_MediaItem.Name = "panel_MediaItem";
            this.panel_MediaItem.Radius = 10;
            this.panel_MediaItem.Size = new System.Drawing.Size(200, 270);
            this.panel_MediaItem.TabIndex = 0;
            this.panel_MediaItem.Click += new System.EventHandler(this.Playlist_Click);
            this.panel_MediaItem.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.panel_MediaItem.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.panel_MediaItem.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // label_DateCreate
            // 
            this.label_DateCreate.AutoEllipsis = true;
            this.label_DateCreate.AutoSize = true;
            this.label_DateCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_DateCreate.ForeColor = System.Drawing.Color.Silver;
            this.label_DateCreate.Location = new System.Drawing.Point(3, 231);
            this.label_DateCreate.Name = "label_DateCreate";
            this.label_DateCreate.Size = new System.Drawing.Size(51, 20);
            this.label_DateCreate.TabIndex = 5;
            this.label_DateCreate.Text = "0 item";
            this.label_DateCreate.Click += new System.EventHandler(this.Playlist_Click);
            this.label_DateCreate.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.label_DateCreate.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.label_DateCreate.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // label_Name
            // 
            this.label_Name.AutoEllipsis = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(0, 203);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(197, 28);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "PlayListName";
            this.label_Name.Click += new System.EventHandler(this.Playlist_Click);
            this.label_Name.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.label_Name.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.label_Name.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
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
            this.pic_SongPic.Click += new System.EventHandler(this.Playlist_Click);
            this.pic_SongPic.MouseEnter += new System.EventHandler(this.panel_MediaItem_MouseEnter);
            this.pic_SongPic.MouseLeave += new System.EventHandler(this.label_Author_MouseLeave);
            this.pic_SongPic.MouseHover += new System.EventHandler(this.panel_MediaItem_MouseHover);
            // 
            // PlayListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_MediaItem);
            this.MaximumSize = new System.Drawing.Size(200, 270);
            this.MinimumSize = new System.Drawing.Size(200, 270);
            this.Name = "PlayListItem";
            this.Size = new System.Drawing.Size(200, 270);
            this.panel_MediaItem.ResumeLayout(false);
            this.panel_MediaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SongPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel panel_MediaItem;
        private Guna.UI.WinForms.GunaLabel label_DateCreate;
        private Guna.UI.WinForms.GunaLabel label_Name;
        private Guna.UI.WinForms.GunaPictureBox pic_SongPic;
    }
}
