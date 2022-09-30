namespace MediaPlayer
{
    partial class Form_MusicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MusicControl));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel_End = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel_Start = new Guna.UI.WinForms.GunaLabel();
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton6 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton4 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton5 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaLabel_End);
            this.gunaPanel1.Controls.Add(this.gunaLabel_Start);
            this.gunaPanel1.Controls.Add(this.gunaTrackBar1);
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Controls.Add(this.bunifuPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1240, 124);
            this.gunaPanel1.TabIndex = 1;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaLabel_End
            // 
            this.gunaLabel_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_End.AutoSize = true;
            this.gunaLabel_End.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel_End.Location = new System.Drawing.Point(849, 6);
            this.gunaLabel_End.Name = "gunaLabel_End";
            this.gunaLabel_End.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel_End.TabIndex = 12;
            this.gunaLabel_End.Text = "00:00";
            // 
            // gunaLabel_Start
            // 
            this.gunaLabel_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel_Start.AutoSize = true;
            this.gunaLabel_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel_Start.Location = new System.Drawing.Point(351, 6);
            this.gunaLabel_Start.Name = "gunaLabel_Start";
            this.gunaLabel_Start.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel_Start.TabIndex = 11;
            this.gunaLabel_Start.Text = "00:00";
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTrackBar1.Location = new System.Drawing.Point(401, 0);
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(442, 32);
            this.gunaTrackBar1.TabIndex = 10;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(228)))));
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 124);
            this.panel1.TabIndex = 9;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(18, 16);
            this.gunaImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(95, 95);
            this.gunaImageButton1.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(119, 47);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(98, 23);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Tên bài hát";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(119, 70);
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
            this.bunifuPanel1.Location = new System.Drawing.Point(401, 31);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(445, 93);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton2.BackColor = System.Drawing.Color.White;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(49, 49);
            this.gunaImageButton2.Location = new System.Drawing.Point(179, 16);
            this.gunaImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.OnHoverImage")));
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(69, 64);
            this.gunaImageButton2.TabIndex = 0;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // gunaImageButton6
            // 
            this.gunaImageButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton6.BackColor = System.Drawing.Color.White;
            this.gunaImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton6.Image")));
            this.gunaImageButton6.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaImageButton6.Location = new System.Drawing.Point(31, 32);
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
            this.gunaImageButton4.BackColor = System.Drawing.Color.White;
            this.gunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton4.Image")));
            this.gunaImageButton4.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaImageButton4.Location = new System.Drawing.Point(111, 32);
            this.gunaImageButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton4.Name = "gunaImageButton4";
            this.gunaImageButton4.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton4.OnHoverImage")));
            this.gunaImageButton4.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton4.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton4.TabIndex = 0;
            // 
            // gunaImageButton5
            // 
            this.gunaImageButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaImageButton5.BackColor = System.Drawing.Color.White;
            this.gunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton5.Image")));
            this.gunaImageButton5.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaImageButton5.Location = new System.Drawing.Point(351, 32);
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
            this.gunaImageButton3.BackColor = System.Drawing.Color.White;
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.Image")));
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaImageButton3.Location = new System.Drawing.Point(286, 32);
            this.gunaImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton3.OnHoverImage")));
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton3.TabIndex = 0;
            // 
            // Form_MusicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 124);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MusicControl";
            this.Text = "Form_MusicControl";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton4;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton5;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton6;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
        private Guna.UI.WinForms.GunaLabel gunaLabel_End;
        private Guna.UI.WinForms.GunaLabel gunaLabel_Start;
    }
}