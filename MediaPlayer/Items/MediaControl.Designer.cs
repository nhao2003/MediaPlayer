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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaControl));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel_End = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel_Start = new Guna.UI.WinForms.GunaLabel();
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.panel_MediaInfo = new System.Windows.Forms.Panel();
            this.gunaPictureBox_Media = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton6 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton4 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton5 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.panel_MediaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_Media)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel_End);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel_Start);
            this.gunaElipsePanel1.Controls.Add(this.gunaTrackBar1);
            this.gunaElipsePanel1.Controls.Add(this.panel_MediaInfo);
            this.gunaElipsePanel1.Controls.Add(this.bunifuPanel1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1022, 138);
            this.gunaElipsePanel1.TabIndex = 1;
            // 
            // gunaLabel_End
            // 
            this.gunaLabel_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_End.AutoSize = true;
            this.gunaLabel_End.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel_End.Location = new System.Drawing.Point(748, 11);
            this.gunaLabel_End.Name = "gunaLabel_End";
            this.gunaLabel_End.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel_End.TabIndex = 17;
            this.gunaLabel_End.Text = "00:00";
            // 
            // gunaLabel_Start
            // 
            this.gunaLabel_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_Start.AutoSize = true;
            this.gunaLabel_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel_Start.Location = new System.Drawing.Point(282, 20);
            this.gunaLabel_Start.Name = "gunaLabel_Start";
            this.gunaLabel_Start.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel_Start.TabIndex = 16;
            this.gunaLabel_Start.Text = "00:00";
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTrackBar1.Location = new System.Drawing.Point(332, 14);
            this.gunaTrackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(410, 26);
            this.gunaTrackBar1.TabIndex = 15;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            // 
            // panel_MediaInfo
            // 
            this.panel_MediaInfo.Controls.Add(this.gunaPictureBox_Media);
            this.panel_MediaInfo.Controls.Add(this.gunaLabel1);
            this.panel_MediaInfo.Controls.Add(this.gunaLabel2);
            this.panel_MediaInfo.Location = new System.Drawing.Point(7, 14);
            this.panel_MediaInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_MediaInfo.Name = "panel_MediaInfo";
            this.panel_MediaInfo.Size = new System.Drawing.Size(269, 113);
            this.panel_MediaInfo.TabIndex = 14;
            // 
            // gunaPictureBox_Media
            // 
            this.gunaPictureBox_Media.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox_Media.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox_Media.Location = new System.Drawing.Point(3, 11);
            this.gunaPictureBox_Media.Name = "gunaPictureBox_Media";
            this.gunaPictureBox_Media.Radius = 10;
            this.gunaPictureBox_Media.Size = new System.Drawing.Size(90, 90);
            this.gunaPictureBox_Media.TabIndex = 8;
            this.gunaPictureBox_Media.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(99, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(98, 23);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Tên bài hát";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(99, 53);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 23);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Tên ca sĩ";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.gunaImageButton2);
            this.bunifuPanel1.Controls.Add(this.gunaImageButton6);
            this.bunifuPanel1.Controls.Add(this.gunaImageButton4);
            this.bunifuPanel1.Controls.Add(this.gunaImageButton5);
            this.bunifuPanel1.Controls.Add(this.gunaImageButton3);
            this.bunifuPanel1.Location = new System.Drawing.Point(286, 44);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(506, 83);
            this.bunifuPanel1.TabIndex = 13;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(49, 49);
            this.gunaImageButton2.Location = new System.Drawing.Point(195, 10);
            this.gunaImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.OnHoverImage")));
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(69, 64);
            this.gunaImageButton2.TabIndex = 0;
            // 
            // gunaImageButton6
            // 
            this.gunaImageButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton6.Image")));
            this.gunaImageButton6.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaImageButton6.Location = new System.Drawing.Point(54, 26);
            this.gunaImageButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton6.Name = "gunaImageButton6";
            this.gunaImageButton6.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton6.OnHoverImage")));
            this.gunaImageButton6.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton6.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton6.TabIndex = 0;
            // 
            // gunaImageButton4
            // 
            this.gunaImageButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton4.Image")));
            this.gunaImageButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaImageButton4.Location = new System.Drawing.Point(119, 23);
            this.gunaImageButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton4.Name = "gunaImageButton4";
            this.gunaImageButton4.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton4.OnHoverImage")));
            this.gunaImageButton4.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton4.Size = new System.Drawing.Size(43, 39);
            this.gunaImageButton4.TabIndex = 0;
            // 
            // gunaImageButton5
            // 
            this.gunaImageButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton5.Image")));
            this.gunaImageButton5.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaImageButton5.Location = new System.Drawing.Point(373, 26);
            this.gunaImageButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton5.Name = "gunaImageButton5";
            this.gunaImageButton5.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton5.OnHoverImage")));
            this.gunaImageButton5.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton5.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton5.TabIndex = 0;
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.Image")));
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaImageButton3.Location = new System.Drawing.Point(297, 23);
            this.gunaImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.OnHoverImage")));
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(43, 39);
            this.gunaImageButton3.TabIndex = 0;
            // 
            // MediaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "MediaControl";
            this.Size = new System.Drawing.Size(1028, 144);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.panel_MediaInfo.ResumeLayout(false);
            this.panel_MediaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox_Media)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel_End;
        private Guna.UI.WinForms.GunaLabel gunaLabel_Start;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
        private System.Windows.Forms.Panel panel_MediaInfo;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox_Media;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton6;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton4;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton5;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
    }
}
