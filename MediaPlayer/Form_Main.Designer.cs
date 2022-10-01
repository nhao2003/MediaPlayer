using Guna.UI.WinForms;
using System.Windows.Forms;

namespace MediaPlayer
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton_Library = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Setting = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Video = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Music = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Search = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Home = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGradientTileButton1 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.panel_base = new System.Windows.Forms.Panel();
            this.gunaPanel_MusicControl = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.gunaButton_Library);
            this.gunaPanel2.Controls.Add(this.gunaButton_Setting);
            this.gunaPanel2.Controls.Add(this.gunaButton_Video);
            this.gunaPanel2.Controls.Add(this.gunaButton_Music);
            this.gunaPanel2.Controls.Add(this.gunaButton_Search);
            this.gunaPanel2.Controls.Add(this.gunaButton_Home);
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(284, 789);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaButton_Library
            // 
            this.gunaButton_Library.Animated = true;
            this.gunaButton_Library.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Library.AnimationSpeed = 0.03F;
            this.gunaButton_Library.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Library.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Library.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Library.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_Library.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Library.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Library.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Library.Image")));
            this.gunaButton_Library.ImageOffsetX = 10;
            this.gunaButton_Library.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Library.Location = new System.Drawing.Point(0, 344);
            this.gunaButton_Library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Library.Name = "gunaButton_Library";
            this.gunaButton_Library.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Library.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.gunaButton_Library.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Library.OnHoverImage")));
            this.gunaButton_Library.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Library.Radius = 10;
            this.gunaButton_Library.Size = new System.Drawing.Size(284, 54);
            this.gunaButton_Library.TabIndex = 6;
            this.gunaButton_Library.Text = "Thư viện";
            this.gunaButton_Library.Click += new System.EventHandler(this.gunaButton_Library_Click);
            // 
            // gunaButton_Setting
            // 
            this.gunaButton_Setting.Animated = true;
            this.gunaButton_Setting.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Setting.AnimationSpeed = 0.03F;
            this.gunaButton_Setting.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Setting.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Setting.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Setting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaButton_Setting.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_Setting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Setting.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Setting.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Setting.Image")));
            this.gunaButton_Setting.ImageOffsetX = 10;
            this.gunaButton_Setting.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Setting.Location = new System.Drawing.Point(0, 735);
            this.gunaButton_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Setting.Name = "gunaButton_Setting";
            this.gunaButton_Setting.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Setting.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Setting.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.gunaButton_Setting.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Setting.OnHoverImage")));
            this.gunaButton_Setting.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Setting.Radius = 10;
            this.gunaButton_Setting.Size = new System.Drawing.Size(284, 54);
            this.gunaButton_Setting.TabIndex = 5;
            this.gunaButton_Setting.Text = "Cài đặt";
            this.gunaButton_Setting.Click += new System.EventHandler(this.gunaButton_Setting_Click);
            // 
            // gunaButton_Video
            // 
            this.gunaButton_Video.Animated = true;
            this.gunaButton_Video.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Video.AnimationSpeed = 0.03F;
            this.gunaButton_Video.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Video.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Video.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Video.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_Video.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Video.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Video.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Video.Image")));
            this.gunaButton_Video.ImageOffsetX = 10;
            this.gunaButton_Video.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Video.Location = new System.Drawing.Point(0, 290);
            this.gunaButton_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Video.Name = "gunaButton_Video";
            this.gunaButton_Video.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Video.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.gunaButton_Video.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Video.OnHoverImage")));
            this.gunaButton_Video.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Video.Radius = 10;
            this.gunaButton_Video.Size = new System.Drawing.Size(284, 54);
            this.gunaButton_Video.TabIndex = 4;
            this.gunaButton_Video.Text = "Video";
            this.gunaButton_Video.Click += new System.EventHandler(this.gunaButton_Video_Click);
            // 
            // gunaButton_Music
            // 
            this.gunaButton_Music.Animated = true;
            this.gunaButton_Music.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Music.AnimationSpeed = 0.03F;
            this.gunaButton_Music.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Music.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Music.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Music.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_Music.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Music.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Music.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Music.Image")));
            this.gunaButton_Music.ImageOffsetX = 10;
            this.gunaButton_Music.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Music.Location = new System.Drawing.Point(0, 236);
            this.gunaButton_Music.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Music.Name = "gunaButton_Music";
            this.gunaButton_Music.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Music.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.gunaButton_Music.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Music.OnHoverImage")));
            this.gunaButton_Music.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Music.Radius = 10;
            this.gunaButton_Music.Size = new System.Drawing.Size(284, 54);
            this.gunaButton_Music.TabIndex = 3;
            this.gunaButton_Music.Text = "Nhạc";
            this.gunaButton_Music.Click += new System.EventHandler(this.gunaButton_Music_Click);
            // 
            // gunaButton_Search
            // 
            this.gunaButton_Search.Animated = true;
            this.gunaButton_Search.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Search.AnimationSpeed = 0.03F;
            this.gunaButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Search.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Search.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Search.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Search.Image")));
            this.gunaButton_Search.ImageOffsetX = 10;
            this.gunaButton_Search.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Search.Location = new System.Drawing.Point(0, 182);
            this.gunaButton_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Search.Name = "gunaButton_Search";
            this.gunaButton_Search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Search.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.gunaButton_Search.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Search.OnHoverImage")));
            this.gunaButton_Search.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Search.Radius = 10;
            this.gunaButton_Search.Size = new System.Drawing.Size(284, 54);
            this.gunaButton_Search.TabIndex = 2;
            this.gunaButton_Search.Text = "Tìm kiếm";
            this.gunaButton_Search.Click += new System.EventHandler(this.gunaButton_Search_Click);
            // 
            // gunaButton_Home
            // 
            this.gunaButton_Home.Animated = true;
            this.gunaButton_Home.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Home.AnimationSpeed = 0.03F;
            this.gunaButton_Home.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Home.FocusedColor = System.Drawing.Color.White;
            this.gunaButton_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Home.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Home.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Home.Image")));
            this.gunaButton_Home.ImageOffsetX = 10;
            this.gunaButton_Home.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Home.Location = new System.Drawing.Point(0, 128);
            this.gunaButton_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Home.Name = "gunaButton_Home";
            this.gunaButton_Home.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Home.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.gunaButton_Home.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Home.OnHoverImage")));
            this.gunaButton_Home.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Home.Radius = 10;
            this.gunaButton_Home.Size = new System.Drawing.Size(284, 54);
            this.gunaButton_Home.TabIndex = 1;
            this.gunaButton_Home.Text = "Trang chủ";
            this.gunaButton_Home.Click += new System.EventHandler(this.gunaButton_Home_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaGradientTileButton1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(284, 128);
            this.gunaPanel3.TabIndex = 0;
            // 
            // gunaGradientTileButton1
            // 
            this.gunaGradientTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton1.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientTileButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaGradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton1.Image")));
            this.gunaGradientTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientTileButton1.Location = new System.Drawing.Point(12, 6);
            this.gunaGradientTileButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientTileButton1.Name = "gunaGradientTileButton1";
            this.gunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(211)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.OnHoverImage = null;
            this.gunaGradientTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.Radius = 15;
            this.gunaGradientTileButton1.Size = new System.Drawing.Size(260, 116);
            this.gunaGradientTileButton1.TabIndex = 0;
            this.gunaGradientTileButton1.Text = "User name";
            // 
            // panel_base
            // 
            this.panel_base.BackColor = System.Drawing.Color.Teal;
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.ForeColor = System.Drawing.Color.Coral;
            this.panel_base.Location = new System.Drawing.Point(284, 0);
            this.panel_base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(1028, 789);
            this.panel_base.TabIndex = 2;
            // 
            // gunaPanel_MusicControl
            // 
            this.gunaPanel_MusicControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaPanel_MusicControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel_MusicControl.Location = new System.Drawing.Point(284, 665);
            this.gunaPanel_MusicControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel_MusicControl.Name = "gunaPanel_MusicControl";
            this.gunaPanel_MusicControl.Size = new System.Drawing.Size(1028, 124);
            this.gunaPanel_MusicControl.TabIndex = 0;
            this.gunaPanel_MusicControl.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel_MusicControl_Paint);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 789);
            this.Controls.Add(this.gunaPanel_MusicControl);
            this.Controls.Add(this.panel_base);
            this.Controls.Add(this.gunaPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1327, 826);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.Panel panel_base;
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel_MusicControl;
        private GunaButton gunaButton_Home;
        private GunaButton gunaButton_Library;
        private GunaButton gunaButton_Setting;
        private GunaButton gunaButton_Video;
        private GunaButton gunaButton_Music;
        private GunaButton gunaButton_Search;
    }
}

