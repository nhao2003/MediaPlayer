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
            this.GunaElipsePanel_SlidingBar = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton_Library = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Settings = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Video = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Music = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Search = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Home = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGradientTileButton2 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaPanel_MediaControl = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_base = new System.Windows.Forms.Panel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.GunaElipsePanel_SlidingBar.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaElipsePanel_SlidingBar
            // 
            this.GunaElipsePanel_SlidingBar.BackColor = System.Drawing.Color.Transparent;
            this.GunaElipsePanel_SlidingBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Library);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Settings);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Video);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Music);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Search);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Home);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaPanel1);
            this.GunaElipsePanel_SlidingBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.GunaElipsePanel_SlidingBar.Location = new System.Drawing.Point(0, 0);
            this.GunaElipsePanel_SlidingBar.Name = "GunaElipsePanel_SlidingBar";
            this.GunaElipsePanel_SlidingBar.Size = new System.Drawing.Size(228, 789);
            this.GunaElipsePanel_SlidingBar.TabIndex = 5;
            // 
            // gunaButton_Library
            // 
            this.gunaButton_Library.Animated = true;
            this.gunaButton_Library.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Library.AnimationSpeed = 0.1F;
            this.gunaButton_Library.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Library.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Library.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Library.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Library.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Library.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Library.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Library.Image")));
            this.gunaButton_Library.ImageOffsetX = 10;
            this.gunaButton_Library.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Library.Location = new System.Drawing.Point(0, 344);
            this.gunaButton_Library.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Library.Name = "gunaButton_Library";
            this.gunaButton_Library.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Library.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Library.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Library.OnHoverImage")));
            this.gunaButton_Library.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Library.Radius = 10;
            this.gunaButton_Library.Size = new System.Drawing.Size(228, 54);
            this.gunaButton_Library.TabIndex = 13;
            this.gunaButton_Library.Text = "Thư viện";
            this.gunaButton_Library.Click += new System.EventHandler(this.gunaButton_Library_Click);
            // 
            // gunaButton_Settings
            // 
            this.gunaButton_Settings.Animated = true;
            this.gunaButton_Settings.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Settings.AnimationSpeed = 0.1F;
            this.gunaButton_Settings.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Settings.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Settings.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaButton_Settings.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Settings.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Settings.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Settings.Image")));
            this.gunaButton_Settings.ImageOffsetX = 10;
            this.gunaButton_Settings.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Settings.Location = new System.Drawing.Point(0, 735);
            this.gunaButton_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Settings.Name = "gunaButton_Settings";
            this.gunaButton_Settings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Settings.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Settings.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Settings.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Settings.OnHoverImage")));
            this.gunaButton_Settings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Settings.Radius = 10;
            this.gunaButton_Settings.Size = new System.Drawing.Size(228, 54);
            this.gunaButton_Settings.TabIndex = 12;
            this.gunaButton_Settings.Text = "Cài đặt";
            this.gunaButton_Settings.Click += new System.EventHandler(this.gunaButton_Settings_Click);
            // 
            // gunaButton_Video
            // 
            this.gunaButton_Video.Animated = true;
            this.gunaButton_Video.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Video.AnimationSpeed = 0.1F;
            this.gunaButton_Video.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Video.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Video.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Video.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Video.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Video.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Video.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Video.Image")));
            this.gunaButton_Video.ImageOffsetX = 10;
            this.gunaButton_Video.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Video.Location = new System.Drawing.Point(0, 290);
            this.gunaButton_Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Video.Name = "gunaButton_Video";
            this.gunaButton_Video.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Video.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Video.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Video.OnHoverImage")));
            this.gunaButton_Video.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Video.Radius = 10;
            this.gunaButton_Video.Size = new System.Drawing.Size(228, 54);
            this.gunaButton_Video.TabIndex = 11;
            this.gunaButton_Video.Text = "Video";
            this.gunaButton_Video.Click += new System.EventHandler(this.gunaButton_Video_Click);
            // 
            // gunaButton_Music
            // 
            this.gunaButton_Music.Animated = true;
            this.gunaButton_Music.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Music.AnimationSpeed = 0.1F;
            this.gunaButton_Music.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Music.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Music.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Music.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Music.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Music.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Music.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Music.Image")));
            this.gunaButton_Music.ImageOffsetX = 10;
            this.gunaButton_Music.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Music.Location = new System.Drawing.Point(0, 236);
            this.gunaButton_Music.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Music.Name = "gunaButton_Music";
            this.gunaButton_Music.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Music.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Music.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Music.OnHoverImage")));
            this.gunaButton_Music.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Music.Radius = 10;
            this.gunaButton_Music.Size = new System.Drawing.Size(228, 54);
            this.gunaButton_Music.TabIndex = 10;
            this.gunaButton_Music.Text = "Nhạc";
            this.gunaButton_Music.Click += new System.EventHandler(this.gunaButton_Music_Click);
            // 
            // gunaButton_Search
            // 
            this.gunaButton_Search.Animated = true;
            this.gunaButton_Search.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Search.AnimationSpeed = 0.1F;
            this.gunaButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Search.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Search.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Search.Image")));
            this.gunaButton_Search.ImageOffsetX = 10;
            this.gunaButton_Search.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Search.Location = new System.Drawing.Point(0, 182);
            this.gunaButton_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Search.Name = "gunaButton_Search";
            this.gunaButton_Search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Search.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Search.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Search.OnHoverImage")));
            this.gunaButton_Search.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Search.Radius = 10;
            this.gunaButton_Search.Size = new System.Drawing.Size(228, 54);
            this.gunaButton_Search.TabIndex = 9;
            this.gunaButton_Search.Text = "Tìm kiếm";
            this.gunaButton_Search.Click += new System.EventHandler(this.gunaButton_Search_Click);
            // 
            // gunaButton_Home
            // 
            this.gunaButton_Home.Animated = true;
            this.gunaButton_Home.AnimationHoverSpeed = 0.07F;
            this.gunaButton_Home.AnimationSpeed = 0.1F;
            this.gunaButton_Home.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.BorderColor = System.Drawing.Color.Black;
            this.gunaButton_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton_Home.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaButton_Home.ForeColor = System.Drawing.Color.Black;
            this.gunaButton_Home.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton_Home.Image")));
            this.gunaButton_Home.ImageOffsetX = 10;
            this.gunaButton_Home.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton_Home.Location = new System.Drawing.Point(0, 128);
            this.gunaButton_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton_Home.Name = "gunaButton_Home";
            this.gunaButton_Home.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Home.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Home.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Home.OnHoverImage")));
            this.gunaButton_Home.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Home.Radius = 10;
            this.gunaButton_Home.Size = new System.Drawing.Size(228, 54);
            this.gunaButton_Home.TabIndex = 8;
            this.gunaButton_Home.Text = "Trang chủ";
            this.gunaButton_Home.Click += new System.EventHandler(this.gunaButton_Home_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(228, 128);
            this.gunaPanel1.TabIndex = 7;
            // 
            // gunaGradientTileButton2
            // 
            this.gunaGradientTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton2.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton2.BaseColor1 = System.Drawing.Color.Aqua;
            this.gunaGradientTileButton2.BaseColor2 = System.Drawing.Color.LawnGreen;
            this.gunaGradientTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaGradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton2.Image")));
            this.gunaGradientTileButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientTileButton2.Location = new System.Drawing.Point(12, 6);
            this.gunaGradientTileButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientTileButton2.Name = "gunaGradientTileButton2";
            this.gunaGradientTileButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(211)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.OnHoverImage = null;
            this.gunaGradientTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.Radius = 15;
            this.gunaGradientTileButton2.Size = new System.Drawing.Size(204, 116);
            this.gunaGradientTileButton2.TabIndex = 0;
            this.gunaGradientTileButton2.Text = "User name";
            // 
            // gunaPanel_MediaControl
            // 
            this.gunaPanel_MediaControl.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel_MediaControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel_MediaControl.Location = new System.Drawing.Point(228, 645);
            this.gunaPanel_MediaControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel_MediaControl.Name = "gunaPanel_MediaControl";
            this.gunaPanel_MediaControl.Size = new System.Drawing.Size(1084, 144);
            this.gunaPanel_MediaControl.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Controls.Add(this.gunaCircleButton2);
            this.panel1.Controls.Add(this.gunaCircleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(228, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 62);
            this.panel1.TabIndex = 8;
            // 
            // panel_base
            // 
            this.panel_base.BackColor = System.Drawing.Color.Transparent;
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.ForeColor = System.Drawing.Color.Coral;
            this.panel_base.Location = new System.Drawing.Point(228, 62);
            this.panel_base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(1084, 583);
            this.panel_base.TabIndex = 9;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::MediaPlayer.Properties.Resources.next_page_right;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton1.Location = new System.Drawing.Point(17, 6);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(48, 48);
            this.gunaCircleButton1.TabIndex = 1;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton2.Image")));
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaCircleButton2.Location = new System.Drawing.Point(71, 6);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(48, 48);
            this.gunaCircleButton2.TabIndex = 1;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.DimGray;
            this.gunaCirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(48, 48);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 2;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(815, 6);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(257, 48);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(54, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(157, 30);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Xin chào, user";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1312, 789);
            this.Controls.Add(this.panel_base);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel_MediaControl);
            this.Controls.Add(this.GunaElipsePanel_SlidingBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1327, 826);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.GunaElipsePanel_SlidingBar.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GunaElipsePanel GunaElipsePanel_SlidingBar;
        private GunaButton gunaButton_Library;
        private GunaButton gunaButton_Settings;
        private GunaButton gunaButton_Video;
        private GunaButton gunaButton_Music;
        private GunaButton gunaButton_Search;
        private GunaButton gunaButton_Home;
        private GunaPanel gunaPanel1;
        private GunaGradientTileButton gunaGradientTileButton2;
        private GunaPanel gunaPanel_MediaControl;
        private Panel panel1;
        private Panel panel_base;
        private GunaCircleButton gunaCircleButton1;
        private GunaCircleButton gunaCircleButton2;
        private GunaElipsePanel gunaElipsePanel1;
        private GunaCirclePictureBox gunaCirclePictureBox1;
        private GunaLabel gunaLabel1;
    }
}

