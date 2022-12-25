namespace MediaPlayer.Widgets
{
    partial class UserControl_Playing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Playing));
            this.pic_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.RotationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Duration = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_dateAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Avatar.BaseColor = System.Drawing.Color.Transparent;
            this.pic_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Avatar.Image")));
            this.pic_Avatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Avatar.InitialImage")));
            this.pic_Avatar.Location = new System.Drawing.Point(25, 21);
            this.pic_Avatar.Margin = new System.Windows.Forms.Padding(10);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Radius = 20;
            this.pic_Avatar.Size = new System.Drawing.Size(362, 362);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Avatar.TabIndex = 3;
            this.pic_Avatar.TabStop = false;
            // 
            // RotationTimer
            // 
            this.RotationTimer.Interval = 25;
            this.RotationTimer.Tick += new System.EventHandler(this.RotationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(413, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name: ";
            // 
            // lbSong
            // 
            this.lbSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSong.AutoEllipsis = true;
            this.lbSong.BackColor = System.Drawing.Color.Transparent;
            this.lbSong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSong.ForeColor = System.Drawing.Color.Black;
            this.lbSong.Location = new System.Drawing.Point(602, 82);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(468, 44);
            this.lbSong.TabIndex = 4;
            this.lbSong.Text = "songName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(413, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artists: ";
            // 
            // lbArtist
            // 
            this.lbArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArtist.AutoEllipsis = true;
            this.lbArtist.BackColor = System.Drawing.Color.Transparent;
            this.lbArtist.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbArtist.ForeColor = System.Drawing.Color.Black;
            this.lbArtist.Location = new System.Drawing.Point(602, 148);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(468, 44);
            this.lbArtist.TabIndex = 4;
            this.lbArtist.Text = "songName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(413, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 35);
            this.label7.TabIndex = 4;
            this.label7.Text = "Duration:";
            // 
            // lb_Duration
            // 
            this.lb_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Duration.AutoEllipsis = true;
            this.lb_Duration.BackColor = System.Drawing.Color.Transparent;
            this.lb_Duration.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Duration.ForeColor = System.Drawing.Color.Black;
            this.lb_Duration.Location = new System.Drawing.Point(602, 212);
            this.lb_Duration.Name = "lb_Duration";
            this.lb_Duration.Size = new System.Drawing.Size(468, 44);
            this.lb_Duration.TabIndex = 4;
            this.lb_Duration.Text = "songName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(413, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 35);
            this.label9.TabIndex = 4;
            this.label9.Text = "DateAdded:";
            // 
            // lb_dateAdd
            // 
            this.lb_dateAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_dateAdd.AutoEllipsis = true;
            this.lb_dateAdd.BackColor = System.Drawing.Color.Transparent;
            this.lb_dateAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_dateAdd.ForeColor = System.Drawing.Color.Black;
            this.lb_dateAdd.Location = new System.Drawing.Point(602, 280);
            this.lb_dateAdd.Name = "lb_dateAdd";
            this.lb_dateAdd.Size = new System.Drawing.Size(468, 44);
            this.lb_dateAdd.TabIndex = 4;
            this.lb_dateAdd.Text = "songName";
            // 
            // UserControl_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_dateAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_Duration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Avatar);
            this.Name = "UserControl_Playing";
            this.Size = new System.Drawing.Size(1084, 645);
            this.Load += new System.EventHandler(this.UserControl_Playing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox pic_Avatar;
        private System.Windows.Forms.Timer RotationTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Duration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_dateAdd;
    }
}
