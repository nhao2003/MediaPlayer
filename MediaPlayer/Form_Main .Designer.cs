using System.Threading;
using Guna.UI.WinForms;
using MediaPlayer.Widgets;
using System.Windows.Forms;
using MediaPlayer.Models;

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
            //PlayMedia.thread.Interrupt();
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
            this.gunaPanel_MediaControl = new Guna.UI.WinForms.GunaPanel();
            this.Panel_SlidingBar = new Guna.UI.WinForms.GunaPanel();
            this.btn_Library = new Guna.UI.WinForms.GunaButton();
            this.btn_Settings = new Guna.UI.WinForms.GunaButton();
            this.btn_Video = new Guna.UI.WinForms.GunaButton();
            this.btn_Music = new Guna.UI.WinForms.GunaButton();
            this.btn_Search = new Guna.UI.WinForms.GunaButton();
            this.btn_Home = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Logo = new Guna.UI.WinForms.GunaGradientTileButton();
            this.Panel_SlidingBar.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel_MediaControl
            // 
            this.gunaPanel_MediaControl.BackColor = System.Drawing.Color.White;
            this.gunaPanel_MediaControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel_MediaControl.Location = new System.Drawing.Point(0, 625);
            this.gunaPanel_MediaControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel_MediaControl.Name = "gunaPanel_MediaControl";
            this.gunaPanel_MediaControl.Size = new System.Drawing.Size(1182, 128);
            this.gunaPanel_MediaControl.TabIndex = 6;
            // 
            // Panel_SlidingBar
            // 
            this.Panel_SlidingBar.BackColor = System.Drawing.Color.Black;
            this.Panel_SlidingBar.Controls.Add(this.btn_Library);
            this.Panel_SlidingBar.Controls.Add(this.btn_Settings);
            this.Panel_SlidingBar.Controls.Add(this.btn_Video);
            this.Panel_SlidingBar.Controls.Add(this.btn_Music);
            this.Panel_SlidingBar.Controls.Add(this.btn_Search);
            this.Panel_SlidingBar.Controls.Add(this.btn_Home);
            this.Panel_SlidingBar.Controls.Add(this.gunaPanel1);
            this.Panel_SlidingBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SlidingBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SlidingBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_SlidingBar.Name = "Panel_SlidingBar";
            this.Panel_SlidingBar.Size = new System.Drawing.Size(228, 625);
            this.Panel_SlidingBar.TabIndex = 10;
            // 
            // btn_Library
            // 
            this.btn_Library.Animated = true;
            this.btn_Library.AnimationHoverSpeed = 0.07F;
            this.btn_Library.AnimationSpeed = 0.5F;
            this.btn_Library.BackColor = System.Drawing.Color.Transparent;
            this.btn_Library.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Library.BorderColor = System.Drawing.Color.Black;
            this.btn_Library.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Library.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Library.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Library.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Library.ForeColor = System.Drawing.Color.Silver;
            this.btn_Library.Image = global::MediaPlayer.Properties.Resources.Library;
            this.btn_Library.ImageOffsetX = 10;
            this.btn_Library.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Library.Location = new System.Drawing.Point(0, 319);
            this.btn_Library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Library.Name = "btn_Library";
            this.btn_Library.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btn_Library.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Library.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Library.OnHoverImage = global::MediaPlayer.Properties.Resources.Library_hover;
            this.btn_Library.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Library.Radius = 10;
            this.btn_Library.Size = new System.Drawing.Size(228, 54);
            this.btn_Library.TabIndex = 19;
            this.btn_Library.Tag = this.btn_Library.Image;
            this.btn_Library.Text = "Thư viện";
            this.btn_Library.Click += new System.EventHandler(this.btn_Page_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Animated = true;
            this.btn_Settings.AnimationHoverSpeed = 0.07F;
            this.btn_Settings.AnimationSpeed = 0.5F;
            this.btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Settings.BorderColor = System.Drawing.Color.Black;
            this.btn_Settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Settings.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Settings.ForeColor = System.Drawing.Color.Silver;
            this.btn_Settings.Image = global::MediaPlayer.Properties.Resources.setting;
            this.btn_Settings.ImageOffsetX = 10;
            this.btn_Settings.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Settings.Location = new System.Drawing.Point(0, 571);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btn_Settings.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_Settings.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Settings.OnHoverImage = global::MediaPlayer.Properties.Resources.setting_hover;
            this.btn_Settings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Settings.Radius = 10;
            this.btn_Settings.Size = new System.Drawing.Size(228, 54);
            this.btn_Settings.TabIndex = 18;
            this.btn_Settings.Tag = this.btn_Settings.Image;
            this.btn_Settings.Text = "Cài đặt";
            this.btn_Settings.Click += new System.EventHandler(this.btn_Page_Click);
            // 
            // btn_Video
            // 
            this.btn_Video.Animated = true;
            this.btn_Video.AnimationHoverSpeed = 0.07F;
            this.btn_Video.AnimationSpeed = 0.5F;
            this.btn_Video.BackColor = System.Drawing.Color.Transparent;
            this.btn_Video.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Video.BorderColor = System.Drawing.Color.Black;
            this.btn_Video.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Video.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Video.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Video.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Video.ForeColor = System.Drawing.Color.Silver;
            this.btn_Video.Image = global::MediaPlayer.Properties.Resources.video;
            this.btn_Video.ImageOffsetX = 10;
            this.btn_Video.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Video.Location = new System.Drawing.Point(0, 265);
            this.btn_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btn_Video.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Video.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Video.OnHoverImage = global::MediaPlayer.Properties.Resources.video_hover;
            this.btn_Video.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Video.Radius = 10;
            this.btn_Video.Size = new System.Drawing.Size(228, 54);
            this.btn_Video.TabIndex = 17;
            this.btn_Video.Tag = this.btn_Video.Image;
            this.btn_Video.Text = "Video";
            this.btn_Video.Click += new System.EventHandler(this.btn_Page_Click);
            // 
            // btn_Music
            // 
            this.btn_Music.Animated = true;
            this.btn_Music.AnimationHoverSpeed = 0.07F;
            this.btn_Music.AnimationSpeed = 0.5F;
            this.btn_Music.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Music.BorderColor = System.Drawing.Color.Black;
            this.btn_Music.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Music.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Music.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Music.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Music.ForeColor = System.Drawing.Color.Silver;
            this.btn_Music.Image = global::MediaPlayer.Properties.Resources.music;
            this.btn_Music.ImageOffsetX = 10;
            this.btn_Music.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Music.Location = new System.Drawing.Point(0, 211);
            this.btn_Music.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btn_Music.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Music.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Music.OnHoverImage = global::MediaPlayer.Properties.Resources.music_hover;
            this.btn_Music.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Music.Radius = 10;
            this.btn_Music.Size = new System.Drawing.Size(228, 54);
            this.btn_Music.TabIndex = 16;
            this.btn_Music.Tag = this.btn_Music.Image;
            this.btn_Music.Text = "Nhạc";
            this.btn_Music.Click += new System.EventHandler(this.btn_Page_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Animated = true;
            this.btn_Search.AnimationHoverSpeed = 0.07F;
            this.btn_Search.AnimationSpeed = 0.5F;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Silver;
            this.btn_Search.Image = global::MediaPlayer.Properties.Resources.search;
            this.btn_Search.ImageOffsetX = 10;
            this.btn_Search.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Search.Location = new System.Drawing.Point(0, 157);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Search.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Search.OnHoverImage = global::MediaPlayer.Properties.Resources.search_hover;
            this.btn_Search.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Search.Radius = 10;
            this.btn_Search.Size = new System.Drawing.Size(228, 54);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Tag = this.btn_Search.Image;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Page_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Animated = true;
            this.btn_Home.AnimationHoverSpeed = 0.07F;
            this.btn_Home.AnimationSpeed = 0.5F;
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Home.BorderColor = System.Drawing.Color.Black;
            this.btn_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Home.ForeColor = System.Drawing.Color.Silver;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageOffsetX = 10;
            this.btn_Home.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Home.Location = new System.Drawing.Point(0, 103);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btn_Home.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btn_Home.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Home.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.OnHoverImage")));
            this.btn_Home.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Home.Radius = 10;
            this.btn_Home.Size = new System.Drawing.Size(228, 54);
            this.btn_Home.TabIndex = 14;
            this.btn_Home.Tag = this.btn_Home.Image;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.Click += new System.EventHandler(this.btn_Page_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.Logo);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(228, 103);
            this.gunaPanel1.TabIndex = 7;
            // 
            // Logo
            // 
            this.Logo.AnimationHoverSpeed = 0.07F;
            this.Logo.AnimationSpeed = 0.03F;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BaseColor1 = System.Drawing.Color.Aqua;
            this.Logo.BaseColor2 = System.Drawing.Color.LawnGreen;
            this.Logo.BorderColor = System.Drawing.Color.Black;
            this.Logo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Logo.FocusedColor = System.Drawing.Color.Empty;
            this.Logo.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageSize = new System.Drawing.Size(52, 52);
            this.Logo.Location = new System.Drawing.Point(9, 5);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.Logo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Logo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Logo.OnHoverForeColor = System.Drawing.Color.White;
            this.Logo.OnHoverImage = null;
            this.Logo.OnPressedColor = System.Drawing.Color.Black;
            this.Logo.Radius = 15;
            this.Logo.Size = new System.Drawing.Size(204, 94);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "User name";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.Panel_SlidingBar);
            this.Controls.Add(this.gunaPanel_MediaControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form_Main";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Panel_SlidingBar.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GunaPanel gunaPanel_MediaControl;
        private GunaPanel Panel_SlidingBar;
        private GunaButton btn_Library;
        private GunaButton btn_Settings;
        private GunaButton btn_Video;
        private GunaButton btn_Music;
        private GunaButton btn_Search;
        private GunaButton btn_Home;
        private GunaPanel gunaPanel1;
        private GunaGradientTileButton Logo;
    }
}

