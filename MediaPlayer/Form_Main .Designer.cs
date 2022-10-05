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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.GunaElipsePanel_SlidingBar = new Guna.UI.WinForms.GunaElipsePanel();
            this.indicater = new System.Windows.Forms.Panel();
            this.gunaButton_Library = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Settings = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Video = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Music = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Search = new Guna.UI.WinForms.GunaButton();
            this.gunaButton_Home = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Logo = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaPanel_MediaControl = new Guna.UI.WinForms.GunaPanel();
            this.Appbar = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Button_Redo = new Guna.UI.WinForms.GunaCircleButton();
            this.Button_Undo = new Guna.UI.WinForms.GunaCircleButton();
            this.MainPages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage_Home = new System.Windows.Forms.TabPage();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.tabPage_Music = new System.Windows.Forms.TabPage();
            this.tabPage_Video = new System.Windows.Forms.TabPage();
            this.tabPage_Library = new System.Windows.Forms.TabPage();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.userControl_Home1 = new MediaPlayer.Widgets.UserControl_Home();
            this.userControl_Search1 = new MediaPlayer.Widgets.UserControl_Search();
            this.userControl_Music1 = new MediaPlayer.Widgets.UserControl_Music();
            this.userControl_Video1 = new MediaPlayer.Widgets.UserControl_Video();
            this.userControl_Library1 = new MediaPlayer.Widgets.UserControl_Library();
            this.userControl_Settings1 = new MediaPlayer.Widgets.UserControl_Settings();
            this.mediaControl = new MediaPlayer.Items.MediaControl();
            this.GunaElipsePanel_SlidingBar.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel_MediaControl.SuspendLayout();
            this.Appbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.MainPages.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            this.tabPage_Search.SuspendLayout();
            this.tabPage_Music.SuspendLayout();
            this.tabPage_Video.SuspendLayout();
            this.tabPage_Library.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaElipsePanel_SlidingBar
            // 
            this.GunaElipsePanel_SlidingBar.BackColor = System.Drawing.Color.Transparent;
            this.GunaElipsePanel_SlidingBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.indicater);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Library);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Settings);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Video);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Music);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Search);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaButton_Home);
            this.GunaElipsePanel_SlidingBar.Controls.Add(this.gunaPanel1);
            this.GunaElipsePanel_SlidingBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.GunaElipsePanel_SlidingBar.Location = new System.Drawing.Point(0, 0);
            this.GunaElipsePanel_SlidingBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GunaElipsePanel_SlidingBar.Name = "GunaElipsePanel_SlidingBar";
            this.GunaElipsePanel_SlidingBar.Radius = 1;
            this.GunaElipsePanel_SlidingBar.Size = new System.Drawing.Size(171, 609);
            this.GunaElipsePanel_SlidingBar.TabIndex = 5;
            // 
            // indicater
            // 
            this.indicater.BackColor = System.Drawing.Color.SeaGreen;
            this.indicater.ForeColor = System.Drawing.Color.Teal;
            this.indicater.Location = new System.Drawing.Point(3, 108);
            this.indicater.Name = "indicater";
            this.indicater.Size = new System.Drawing.Size(5, 44);
            this.indicater.TabIndex = 20;
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
            this.gunaButton_Library.Location = new System.Drawing.Point(0, 280);
            this.gunaButton_Library.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton_Library.Name = "gunaButton_Library";
            this.gunaButton_Library.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Library.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Library.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Library.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Library.OnHoverImage")));
            this.gunaButton_Library.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Library.Radius = 10;
            this.gunaButton_Library.Size = new System.Drawing.Size(171, 44);
            this.gunaButton_Library.TabIndex = 19;
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
            this.gunaButton_Settings.Location = new System.Drawing.Point(0, 565);
            this.gunaButton_Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton_Settings.Name = "gunaButton_Settings";
            this.gunaButton_Settings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Settings.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gunaButton_Settings.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Settings.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Settings.OnHoverImage")));
            this.gunaButton_Settings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Settings.Radius = 10;
            this.gunaButton_Settings.Size = new System.Drawing.Size(171, 44);
            this.gunaButton_Settings.TabIndex = 18;
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
            this.gunaButton_Video.Location = new System.Drawing.Point(0, 236);
            this.gunaButton_Video.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton_Video.Name = "gunaButton_Video";
            this.gunaButton_Video.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Video.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Video.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Video.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Video.OnHoverImage")));
            this.gunaButton_Video.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Video.Radius = 10;
            this.gunaButton_Video.Size = new System.Drawing.Size(171, 44);
            this.gunaButton_Video.TabIndex = 17;
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
            this.gunaButton_Music.Location = new System.Drawing.Point(0, 192);
            this.gunaButton_Music.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton_Music.Name = "gunaButton_Music";
            this.gunaButton_Music.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Music.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Music.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Music.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Music.OnHoverImage")));
            this.gunaButton_Music.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Music.Radius = 10;
            this.gunaButton_Music.Size = new System.Drawing.Size(171, 44);
            this.gunaButton_Music.TabIndex = 16;
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
            this.gunaButton_Search.Location = new System.Drawing.Point(0, 148);
            this.gunaButton_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton_Search.Name = "gunaButton_Search";
            this.gunaButton_Search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Search.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Search.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Search.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Search.OnHoverImage")));
            this.gunaButton_Search.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Search.Radius = 10;
            this.gunaButton_Search.Size = new System.Drawing.Size(171, 44);
            this.gunaButton_Search.TabIndex = 15;
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
            this.gunaButton_Home.Location = new System.Drawing.Point(0, 104);
            this.gunaButton_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton_Home.Name = "gunaButton_Home";
            this.gunaButton_Home.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaButton_Home.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton_Home.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton_Home.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton_Home.OnHoverImage")));
            this.gunaButton_Home.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.gunaButton_Home.Radius = 10;
            this.gunaButton_Home.Size = new System.Drawing.Size(171, 44);
            this.gunaButton_Home.TabIndex = 14;
            this.gunaButton_Home.Text = "Trang chủ";
            this.gunaButton_Home.Click += new System.EventHandler(this.gunaButton_Home_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.Logo);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(171, 104);
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
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logo.Name = "Logo";
            this.Logo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.Logo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(211)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.Logo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Logo.OnHoverForeColor = System.Drawing.Color.White;
            this.Logo.OnHoverImage = null;
            this.Logo.OnPressedColor = System.Drawing.Color.Black;
            this.Logo.Radius = 15;
            this.Logo.Size = new System.Drawing.Size(153, 94);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "User name";
            // 
            // gunaPanel_MediaControl
            // 
            this.gunaPanel_MediaControl.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel_MediaControl.Controls.Add(this.mediaControl);
            this.gunaPanel_MediaControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel_MediaControl.Location = new System.Drawing.Point(171, 492);
            this.gunaPanel_MediaControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel_MediaControl.Name = "gunaPanel_MediaControl";
            this.gunaPanel_MediaControl.Size = new System.Drawing.Size(814, 117);
            this.gunaPanel_MediaControl.TabIndex = 6;
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.Transparent;
            this.Appbar.Controls.Add(this.labelName);
            this.Appbar.Controls.Add(this.label1);
            this.Appbar.Controls.Add(this.avatar);
            this.Appbar.Controls.Add(this.Button_Redo);
            this.Appbar.Controls.Add(this.Button_Undo);
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.ForeColor = System.Drawing.Color.Coral;
            this.Appbar.Location = new System.Drawing.Point(171, 0);
            this.Appbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(814, 50);
            this.Appbar.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(721, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(667, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hello,";
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar.BaseColor = System.Drawing.Color.White;
            this.avatar.Location = new System.Drawing.Point(622, 7);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(39, 39);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 4;
            this.avatar.TabStop = false;
            this.avatar.UseTransfarantBackground = false;
            // 
            // Button_Redo
            // 
            this.Button_Redo.AnimationHoverSpeed = 0.07F;
            this.Button_Redo.AnimationSpeed = 0.03F;
            this.Button_Redo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.Button_Redo.BorderColor = System.Drawing.Color.Black;
            this.Button_Redo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Redo.FocusedColor = System.Drawing.Color.Empty;
            this.Button_Redo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Redo.ForeColor = System.Drawing.Color.White;
            this.Button_Redo.Image = ((System.Drawing.Image)(resources.GetObject("Button_Redo.Image")));
            this.Button_Redo.ImageSize = new System.Drawing.Size(24, 24);
            this.Button_Redo.Location = new System.Drawing.Point(53, 5);
            this.Button_Redo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Redo.Name = "Button_Redo";
            this.Button_Redo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.Button_Redo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button_Redo.OnHoverForeColor = System.Drawing.Color.White;
            this.Button_Redo.OnHoverImage = null;
            this.Button_Redo.OnPressedColor = System.Drawing.Color.Black;
            this.Button_Redo.Size = new System.Drawing.Size(36, 39);
            this.Button_Redo.TabIndex = 1;
            // 
            // Button_Undo
            // 
            this.Button_Undo.AnimationHoverSpeed = 0.07F;
            this.Button_Undo.AnimationSpeed = 0.03F;
            this.Button_Undo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.Button_Undo.BorderColor = System.Drawing.Color.Black;
            this.Button_Undo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Undo.FocusedColor = System.Drawing.Color.Empty;
            this.Button_Undo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Undo.ForeColor = System.Drawing.Color.White;
            this.Button_Undo.Image = global::MediaPlayer.Properties.Resources.next_page_right;
            this.Button_Undo.ImageSize = new System.Drawing.Size(24, 24);
            this.Button_Undo.Location = new System.Drawing.Point(13, 5);
            this.Button_Undo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.Button_Undo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Button_Undo.OnHoverForeColor = System.Drawing.Color.White;
            this.Button_Undo.OnHoverImage = null;
            this.Button_Undo.OnPressedColor = System.Drawing.Color.Black;
            this.Button_Undo.Size = new System.Drawing.Size(36, 39);
            this.Button_Undo.TabIndex = 1;
            // 
            // MainPages
            // 
            this.MainPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MainPages.AllowTransitions = false;
            this.MainPages.Controls.Add(this.tabPage_Home);
            this.MainPages.Controls.Add(this.tabPage_Search);
            this.MainPages.Controls.Add(this.tabPage_Music);
            this.MainPages.Controls.Add(this.tabPage_Video);
            this.MainPages.Controls.Add(this.tabPage_Library);
            this.MainPages.Controls.Add(this.tabPage_Settings);
            this.MainPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPages.Location = new System.Drawing.Point(171, 50);
            this.MainPages.Margin = new System.Windows.Forms.Padding(0);
            this.MainPages.Multiline = true;
            this.MainPages.Name = "MainPages";
            this.MainPages.Padding = new System.Drawing.Point(0, 0);
            this.MainPages.Page = this.tabPage_Settings;
            this.MainPages.PageIndex = 5;
            this.MainPages.PageName = "tabPage_Settings";
            this.MainPages.PageTitle = "tabPage_Settings";
            this.MainPages.SelectedIndex = 0;
            this.MainPages.Size = new System.Drawing.Size(814, 442);
            this.MainPages.TabIndex = 9;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.MainPages.Transition = animation2;
            this.MainPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.userControl_Home1);
            this.tabPage_Home.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Home.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Size = new System.Drawing.Size(806, 416);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "tabPage_Home";
            this.tabPage_Home.UseVisualStyleBackColor = true;
            // 
            // tabPage_Search
            // 
            this.tabPage_Search.Controls.Add(this.userControl_Search1);
            this.tabPage_Search.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Search.Size = new System.Drawing.Size(806, 416);
            this.tabPage_Search.TabIndex = 1;
            this.tabPage_Search.Text = "tabPage_Search";
            this.tabPage_Search.UseVisualStyleBackColor = true;
            // 
            // tabPage_Music
            // 
            this.tabPage_Music.Controls.Add(this.userControl_Music1);
            this.tabPage_Music.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Music.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Music.Name = "tabPage_Music";
            this.tabPage_Music.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Music.Size = new System.Drawing.Size(806, 416);
            this.tabPage_Music.TabIndex = 2;
            this.tabPage_Music.Text = "tabPage_Music";
            this.tabPage_Music.UseVisualStyleBackColor = true;
            // 
            // tabPage_Video
            // 
            this.tabPage_Video.Controls.Add(this.userControl_Video1);
            this.tabPage_Video.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Video.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Video.Name = "tabPage_Video";
            this.tabPage_Video.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Video.Size = new System.Drawing.Size(806, 416);
            this.tabPage_Video.TabIndex = 3;
            this.tabPage_Video.Text = "tabPage_Video";
            this.tabPage_Video.UseVisualStyleBackColor = true;
            // 
            // tabPage_Library
            // 
            this.tabPage_Library.Controls.Add(this.userControl_Library1);
            this.tabPage_Library.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Library.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Library.Name = "tabPage_Library";
            this.tabPage_Library.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Library.Size = new System.Drawing.Size(806, 416);
            this.tabPage_Library.TabIndex = 4;
            this.tabPage_Library.Text = "tabPage_Library";
            this.tabPage_Library.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.userControl_Settings1);
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(806, 416);
            this.tabPage_Settings.TabIndex = 5;
            this.tabPage_Settings.Text = "tabPage_Settings";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // userControl_Home1
            // 
            this.userControl_Home1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Home1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Home1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_Home1.Name = "userControl_Home1";
            this.userControl_Home1.Size = new System.Drawing.Size(806, 416);
            this.userControl_Home1.TabIndex = 0;
            this.userControl_Home1.Load += new System.EventHandler(this.userControl_Home1_Load);
            // 
            // userControl_Search1
            // 
            this.userControl_Search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Search1.Location = new System.Drawing.Point(2, 2);
            this.userControl_Search1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_Search1.Name = "userControl_Search1";
            this.userControl_Search1.Size = new System.Drawing.Size(802, 412);
            this.userControl_Search1.TabIndex = 0;
            // 
            // userControl_Music1
            // 
            this.userControl_Music1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Music1.Location = new System.Drawing.Point(2, 2);
            this.userControl_Music1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControl_Music1.Name = "userControl_Music1";
            this.userControl_Music1.Size = new System.Drawing.Size(802, 412);
            this.userControl_Music1.TabIndex = 0;
            // 
            // userControl_Video1
            // 
            this.userControl_Video1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Video1.Location = new System.Drawing.Point(2, 2);
            this.userControl_Video1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControl_Video1.Name = "userControl_Video1";
            this.userControl_Video1.Size = new System.Drawing.Size(802, 412);
            this.userControl_Video1.TabIndex = 0;
            // 
            // userControl_Library1
            // 
            this.userControl_Library1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Library1.Location = new System.Drawing.Point(2, 2);
            this.userControl_Library1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControl_Library1.Name = "userControl_Library1";
            this.userControl_Library1.Size = new System.Drawing.Size(802, 412);
            this.userControl_Library1.TabIndex = 0;
            // 
            // userControl_Settings1
            // 
            this.userControl_Settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.userControl_Settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Settings1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Settings1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_Settings1.Name = "userControl_Settings1";
            this.userControl_Settings1.Size = new System.Drawing.Size(806, 416);
            this.userControl_Settings1.TabIndex = 0;
            // 
            // mediaControl
            // 
            this.mediaControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaControl.Location = new System.Drawing.Point(0, 0);
            this.mediaControl.Margin = new System.Windows.Forms.Padding(2);
            this.mediaControl.Name = "mediaControl";
            this.mediaControl.Size = new System.Drawing.Size(814, 117);
            this.mediaControl.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(985, 609);
            this.Controls.Add(this.MainPages);
            this.Controls.Add(this.Appbar);
            this.Controls.Add(this.gunaPanel_MediaControl);
            this.Controls.Add(this.GunaElipsePanel_SlidingBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1001, 596);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.GunaElipsePanel_SlidingBar.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel_MediaControl.ResumeLayout(false);
            this.Appbar.ResumeLayout(false);
            this.Appbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.MainPages.ResumeLayout(false);
            this.tabPage_Home.ResumeLayout(false);
            this.tabPage_Search.ResumeLayout(false);
            this.tabPage_Music.ResumeLayout(false);
            this.tabPage_Video.ResumeLayout(false);
            this.tabPage_Library.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GunaElipsePanel GunaElipsePanel_SlidingBar;
        private GunaPanel gunaPanel1;
        private GunaGradientTileButton Logo;
        private GunaPanel gunaPanel_MediaControl;
        private Panel Appbar;
        private GunaCircleButton Button_Undo;
        private GunaCircleButton Button_Redo;
        private Items.MediaControl mediaControl;
        private GunaButton gunaButton_Library;
        private GunaButton gunaButton_Settings;
        private GunaButton gunaButton_Video;
        private GunaButton gunaButton_Music;
        private GunaButton gunaButton_Search;
        private GunaButton gunaButton_Home;
        private Bunifu.UI.WinForms.BunifuPages MainPages;
        private TabPage tabPage_Home;
        private Widgets.UserControl_Home userControl_Home1;
        private TabPage tabPage_Search;
        private Widgets.UserControl_Search userControl_Search1;
        private TabPage tabPage_Music;
        private Widgets.UserControl_Music userControl_Music1;
        private TabPage tabPage_Video;
        private Widgets.UserControl_Video userControl_Video1;
        private TabPage tabPage_Library;
        private Widgets.UserControl_Library userControl_Library1;
        private TabPage tabPage_Settings;
        private Widgets.UserControl_Settings userControl_Settings1;
        private Panel indicater;
        private GunaCirclePictureBox avatar;
        private Label labelName;
        private Label label1;
    }
}

