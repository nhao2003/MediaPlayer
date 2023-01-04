namespace MediaPlayer.Items
{
    partial class MusicRow
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
            this.panel_MusicRow = new Guna.UI.WinForms.GunaElipsePanel();
            this.pic_Song = new Guna.UI.WinForms.GunaPictureBox();
            this.label_Duration = new System.Windows.Forms.Label();
            this.label_NameSinger = new Guna.UI.WinForms.GunaLabel();
            this.label_NameSong = new Guna.UI.WinForms.GunaLabel();
            this.panel_MusicRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MusicRow
            // 
            this.panel_MusicRow.BackColor = System.Drawing.Color.Transparent;
            this.panel_MusicRow.BaseColor = System.Drawing.Color.Transparent;
            this.panel_MusicRow.Controls.Add(this.pic_Song);
            this.panel_MusicRow.Controls.Add(this.label_Duration);
            this.panel_MusicRow.Controls.Add(this.label_NameSinger);
            this.panel_MusicRow.Controls.Add(this.label_NameSong);
            this.panel_MusicRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MusicRow.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel_MusicRow.Location = new System.Drawing.Point(0, 0);
            this.panel_MusicRow.Margin = new System.Windows.Forms.Padding(0);
            this.panel_MusicRow.Name = "panel_MusicRow";
            this.panel_MusicRow.Radius = 15;
            this.panel_MusicRow.Size = new System.Drawing.Size(700, 70);
            this.panel_MusicRow.TabIndex = 0;
            this.panel_MusicRow.Click += new System.EventHandler(this.MusicRow_Click);
            this.panel_MusicRow.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.panel_MusicRow.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.panel_MusicRow.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // pic_Song
            // 
            this.pic_Song.BackColor = System.Drawing.Color.Transparent;
            this.pic_Song.BaseColor = System.Drawing.Color.White;
            this.pic_Song.Location = new System.Drawing.Point(15, 8);
            this.pic_Song.Name = "pic_Song";
            this.pic_Song.Radius = 10;
            this.pic_Song.Size = new System.Drawing.Size(55, 55);
            this.pic_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Song.TabIndex = 24;
            this.pic_Song.TabStop = false;
            this.pic_Song.Click += new System.EventHandler(this.MusicRow_Click);
            // 
            // label_Duration
            // 
            this.label_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Duration.AutoSize = true;
            this.label_Duration.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Duration.ForeColor = System.Drawing.Color.White;
            this.label_Duration.Location = new System.Drawing.Point(624, 23);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(49, 23);
            this.label_Duration.TabIndex = 23;
            this.label_Duration.Text = "3:18";
            this.label_Duration.Click += new System.EventHandler(this.MusicRow_Click);
            this.label_Duration.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.label_Duration.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            // 
            // label_NameSinger
            // 
            this.label_NameSinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NameSinger.AutoEllipsis = true;
            this.label_NameSinger.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_NameSinger.ForeColor = System.Drawing.Color.Gray;
            this.label_NameSinger.Location = new System.Drawing.Point(73, 38);
            this.label_NameSinger.Margin = new System.Windows.Forms.Padding(0);
            this.label_NameSinger.Name = "label_NameSinger";
            this.label_NameSinger.Size = new System.Drawing.Size(475, 19);
            this.label_NameSinger.TabIndex = 21;
            this.label_NameSinger.Text = "Đây là tên ca sĩ!!";
            this.label_NameSinger.Click += new System.EventHandler(this.MusicRow_Click);
            this.label_NameSinger.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.label_NameSinger.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.label_NameSinger.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // label_NameSong
            // 
            this.label_NameSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NameSong.AutoEllipsis = true;
            this.label_NameSong.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_NameSong.ForeColor = System.Drawing.Color.White;
            this.label_NameSong.Location = new System.Drawing.Point(72, 12);
            this.label_NameSong.Margin = new System.Windows.Forms.Padding(0);
            this.label_NameSong.Name = "label_NameSong";
            this.label_NameSong.Size = new System.Drawing.Size(475, 26);
            this.label_NameSong.TabIndex = 21;
            this.label_NameSong.Text = "Heads in the cloud";
            this.label_NameSong.Click += new System.EventHandler(this.MusicRow_Click);
            this.label_NameSong.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.label_NameSong.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.label_NameSong.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // MusicRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_MusicRow);
            this.DoubleBuffered = true;
            this.Name = "MusicRow";
            this.Size = new System.Drawing.Size(700, 70);
            this.Click += new System.EventHandler(this.MusicRow_Click);
            this.panel_MusicRow.ResumeLayout(false);
            this.panel_MusicRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Song)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel panel_MusicRow;
        private Guna.UI.WinForms.GunaLabel label_NameSinger;
        private Guna.UI.WinForms.GunaLabel label_NameSong;
        private System.Windows.Forms.Label label_Duration;
        private Guna.UI.WinForms.GunaPictureBox pic_Song;
    }
}
