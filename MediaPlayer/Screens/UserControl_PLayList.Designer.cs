namespace MediaPlayer.Widgets
{
    partial class UserControl_PlayList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_PlayList));
            this.lb_Title = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lb_authors = new Guna.UI.WinForms.GunaLabel();
            this.lb_SumDuration = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.pn_Display = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pn_Songs = new System.Windows.Forms.Panel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btn_back = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_play = new Guna.UI.WinForms.GunaCircleButton();
            this.pic_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btn_more = new Guna.UI.WinForms.GunaCircleButton();
            this.timerPlaylist = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel2.SuspendLayout();
            this.pn_Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(330, 52);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(710, 177);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "Title";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel2.Controls.Add(this.btn_more);
            this.gunaPanel2.Controls.Add(this.btn_back);
            this.gunaPanel2.Controls.Add(this.btn_play);
            this.gunaPanel2.Controls.Add(this.pic_Avatar);
            this.gunaPanel2.Controls.Add(this.gunaCircleButton1);
            this.gunaPanel2.Controls.Add(this.gunaLabel3);
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Controls.Add(this.gunaComboBox1);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.lb_authors);
            this.gunaPanel2.Controls.Add(this.lb_SumDuration);
            this.gunaPanel2.Controls.Add(this.lb_Title);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.GradientColor1 = System.Drawing.Color.White;
            this.gunaPanel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1084, 333);
            this.gunaPanel2.TabIndex = 6;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(1377, 59);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(61, 62);
            this.gunaCircleButton1.TabIndex = 24;
            this.gunaCircleButton1.Text = "UpdateScreen";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.Location = new System.Drawing.Point(1458, 78);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(114, 31);
            this.gunaLabel3.TabIndex = 27;
            this.gunaLabel3.Text = "Sort by:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 0;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.ItemHeight = 25;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "A to Z",
            "Artist",
            "Album",
            "Date added"});
            this.gunaComboBox1.Location = new System.Drawing.Point(1587, 78);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 15;
            this.gunaComboBox1.Size = new System.Drawing.Size(139, 31);
            this.gunaComboBox1.TabIndex = 26;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(352, 43);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 28);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "PLAYLIST";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_authors
            // 
            this.lb_authors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_authors.AutoEllipsis = true;
            this.lb_authors.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_authors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_authors.Location = new System.Drawing.Point(352, 229);
            this.lb_authors.Margin = new System.Windows.Forms.Padding(0);
            this.lb_authors.Name = "lb_authors";
            this.lb_authors.Size = new System.Drawing.Size(620, 28);
            this.lb_authors.TabIndex = 2;
            this.lb_authors.Text = "Minh, Hào, Bảo";
            this.lb_authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_SumDuration
            // 
            this.lb_SumDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SumDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SumDuration.ForeColor = System.Drawing.Color.White;
            this.lb_SumDuration.Location = new System.Drawing.Point(352, 264);
            this.lb_SumDuration.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SumDuration.Name = "lb_SumDuration";
            this.lb_SumDuration.Size = new System.Drawing.Size(620, 28);
            this.lb_SumDuration.TabIndex = 2;
            this.lb_SumDuration.Text = "Time";
            this.lb_SumDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.BorderSize = 0;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.ItemHeight = 25;
            this.gunaComboBox2.Items.AddRange(new object[] {
            "A to Z",
            "Artist",
            "Album",
            "Date added"});
            this.gunaComboBox2.Location = new System.Drawing.Point(1587, 78);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Radius = 15;
            this.gunaComboBox2.Size = new System.Drawing.Size(139, 31);
            this.gunaComboBox2.TabIndex = 26;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel2.Location = new System.Drawing.Point(1458, 78);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(114, 31);
            this.gunaLabel2.TabIndex = 27;
            this.gunaLabel2.Text = "Sort by:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = null;
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.Location = new System.Drawing.Point(1377, 59);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(61, 62);
            this.gunaCircleButton2.TabIndex = 24;
            this.gunaCircleButton2.Text = "UpdateScreen";
            // 
            // pn_Display
            // 
            this.pn_Display.AllowDrop = true;
            this.pn_Display.AutoScroll = true;
            this.pn_Display.BackColor = System.Drawing.Color.Transparent;
            this.pn_Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Display.Controls.Add(this.pn_Songs);
            this.pn_Display.Controls.Add(this.gunaCircleButton2);
            this.pn_Display.Controls.Add(this.gunaLabel2);
            this.pn_Display.Controls.Add(this.gunaButton2);
            this.pn_Display.Controls.Add(this.gunaComboBox2);
            this.pn_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Display.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_Display.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pn_Display.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pn_Display.Location = new System.Drawing.Point(0, 333);
            this.pn_Display.Name = "pn_Display";
            this.pn_Display.Size = new System.Drawing.Size(1084, 508);
            this.pn_Display.TabIndex = 7;
            // 
            // pn_Songs
            // 
            this.pn_Songs.AllowDrop = true;
            this.pn_Songs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Songs.AutoScroll = true;
            this.pn_Songs.Location = new System.Drawing.Point(10, 6);
            this.pn_Songs.Name = "pn_Songs";
            this.pn_Songs.Size = new System.Drawing.Size(1074, 502);
            this.pn_Songs.TabIndex = 33;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(1755, 78);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(188, 39);
            this.gunaButton2.TabIndex = 25;
            this.gunaButton2.Text = "Add music";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.Animated = true;
            this.btn_back.AnimationHoverSpeed = 0.07F;
            this.btn_back.AnimationSpeed = 0.03F;
            this.btn_back.BaseColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Black;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = global::MediaPlayer.Properties.Resources.back_btn;
            this.btn_back.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_back.Location = new System.Drawing.Point(994, 41);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_back.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_back.OnHoverImage = global::MediaPlayer.Properties.Resources.back_btn;
            this.btn_back.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 32;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play.Animated = true;
            this.btn_play.AnimationHoverSpeed = 0.07F;
            this.btn_play.AnimationSpeed = 0.03F;
            this.btn_play.BaseColor = System.Drawing.Color.Transparent;
            this.btn_play.BorderColor = System.Drawing.Color.Black;
            this.btn_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_play.FocusedColor = System.Drawing.Color.Empty;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Image = global::MediaPlayer.Properties.Resources.play_green;
            this.btn_play.ImageSize = new System.Drawing.Size(70, 70);
            this.btn_play.Location = new System.Drawing.Point(990, 222);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_play.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_play.OnHoverImage = global::MediaPlayer.Properties.Resources.play_green;
            this.btn_play.OnPressedColor = System.Drawing.Color.Black;
            this.btn_play.Size = new System.Drawing.Size(70, 70);
            this.btn_play.TabIndex = 32;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Avatar.BaseColor = System.Drawing.Color.Transparent;
            this.pic_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pic_Avatar.Image")));
            this.pic_Avatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Avatar.InitialImage")));
            this.pic_Avatar.Location = new System.Drawing.Point(10, 9);
            this.pic_Avatar.Margin = new System.Windows.Forms.Padding(10);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Radius = 10;
            this.pic_Avatar.Size = new System.Drawing.Size(310, 310);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Avatar.TabIndex = 31;
            this.pic_Avatar.TabStop = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(1755, 78);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(188, 39);
            this.gunaButton1.TabIndex = 25;
            this.gunaButton1.Text = "Add music";
            // 
            // btn_more
            // 
            this.btn_more.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_more.Animated = true;
            this.btn_more.AnimationHoverSpeed = 0.07F;
            this.btn_more.AnimationSpeed = 0.03F;
            this.btn_more.BaseColor = System.Drawing.Color.Transparent;
            this.btn_more.BorderColor = System.Drawing.Color.Black;
            this.btn_more.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_more.FocusedColor = System.Drawing.Color.Empty;
            this.btn_more.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_more.ForeColor = System.Drawing.Color.White;
            this.btn_more.Image = global::MediaPlayer.Properties.Resources.dots;
            this.btn_more.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_more.Location = new System.Drawing.Point(1030, 41);
            this.btn_more.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_more.Name = "btn_more";
            this.btn_more.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_more.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_more.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_more.OnHoverImage = global::MediaPlayer.Properties.Resources.dots;
            this.btn_more.OnPressedColor = System.Drawing.Color.Black;
            this.btn_more.Size = new System.Drawing.Size(30, 30);
            this.btn_more.TabIndex = 32;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // timerPlaylist
            // 
            this.timerPlaylist.Tick += new System.EventHandler(this.timerPlaylist_Tick);
            // 
            // UserControl_PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pn_Display);
            this.Controls.Add(this.gunaPanel2);
            this.Name = "UserControl_PlayList";
            this.Size = new System.Drawing.Size(1084, 841);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.pn_Display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_Title;
        private Guna.UI.WinForms.GunaGradient2Panel gunaPanel2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaPictureBox pic_Avatar;
        private Guna.UI.WinForms.GunaLabel lb_SumDuration;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lb_authors;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaGradient2Panel pn_Display;
        private Guna.UI.WinForms.GunaCircleButton btn_back;
        private Guna.UI.WinForms.GunaCircleButton btn_play;
        private System.Windows.Forms.Panel pn_Songs;
        private Guna.UI.WinForms.GunaCircleButton btn_more;
        private System.Windows.Forms.Timer timerPlaylist;
    }
}
