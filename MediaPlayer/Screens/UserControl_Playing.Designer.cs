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
            this.RotationTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_NextName = new Guna.UI.WinForms.GunaLabel();
            this.lb_NextAuthor = new Guna.UI.WinForms.GunaLabel();
            this.pn_Display = new Guna.UI.WinForms.GunaPanel();
            this.lb_Queue = new Guna.UI.WinForms.GunaLabel();
            this.btn_Play = new Guna.UI.WinForms.GunaButton();
            this.pic_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // RotationTimer
            // 
            this.RotationTimer.Interval = 25;
            this.RotationTimer.Tick += new System.EventHandler(this.RotationTimer_Tick);
            // 
            // lb_NextName
            // 
            this.lb_NextName.AllowDrop = true;
            this.lb_NextName.AutoEllipsis = true;
            this.lb_NextName.BackColor = System.Drawing.Color.Transparent;
            this.lb_NextName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NextName.ForeColor = System.Drawing.Color.White;
            this.lb_NextName.Location = new System.Drawing.Point(25, 384);
            this.lb_NextName.Name = "lb_NextName";
            this.lb_NextName.Size = new System.Drawing.Size(362, 110);
            this.lb_NextName.TabIndex = 9;
            this.lb_NextName.Text = "Tên bài hát";
            this.lb_NextName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_NextAuthor
            // 
            this.lb_NextAuthor.AutoEllipsis = true;
            this.lb_NextAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lb_NextAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_NextAuthor.ForeColor = System.Drawing.Color.White;
            this.lb_NextAuthor.Location = new System.Drawing.Point(25, 494);
            this.lb_NextAuthor.Name = "lb_NextAuthor";
            this.lb_NextAuthor.Size = new System.Drawing.Size(362, 43);
            this.lb_NextAuthor.TabIndex = 10;
            this.lb_NextAuthor.Text = "Tên ca sĩ";
            this.lb_NextAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_Display
            // 
            this.pn_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Display.AutoScroll = true;
            this.pn_Display.BackColor = System.Drawing.Color.Transparent;
            this.pn_Display.Location = new System.Drawing.Point(450, 96);
            this.pn_Display.Name = "pn_Display";
            this.pn_Display.Size = new System.Drawing.Size(610, 546);
            this.pn_Display.TabIndex = 5;
            // 
            // lb_Queue
            // 
            this.lb_Queue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Queue.AutoEllipsis = true;
            this.lb_Queue.AutoSize = true;
            this.lb_Queue.BackColor = System.Drawing.Color.Transparent;
            this.lb_Queue.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Queue.ForeColor = System.Drawing.Color.White;
            this.lb_Queue.Location = new System.Drawing.Point(453, 21);
            this.lb_Queue.Name = "lb_Queue";
            this.lb_Queue.Size = new System.Drawing.Size(338, 59);
            this.lb_Queue.TabIndex = 9;
            this.lb_Queue.Text = "Danh sách phát";
            // 
            // btn_Play
            // 
            this.btn_Play.AnimationHoverSpeed = 0.07F;
            this.btn_Play.AnimationSpeed = 0.03F;
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Play.BorderColor = System.Drawing.Color.Black;
            this.btn_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Play.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Image = global::MediaPlayer.Properties.Resources.play_nobackground;
            this.btn_Play.ImageOffsetX = 10;
            this.btn_Play.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Play.Location = new System.Drawing.Point(99, 559);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btn_Play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Play.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Play.OnHoverImage = null;
            this.btn_Play.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Play.Radius = 25;
            this.btn_Play.Size = new System.Drawing.Size(214, 55);
            this.btn_Play.TabIndex = 11;
            this.btn_Play.Text = "   Đang phát";
            this.btn_Play.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
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
            this.pic_Avatar.Click += new System.EventHandler(this.pic_Avatar_Click);
            // 
            // UserControl_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lb_Queue);
            this.Controls.Add(this.lb_NextName);
            this.Controls.Add(this.lb_NextAuthor);
            this.Controls.Add(this.pn_Display);
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
        private Guna.UI.WinForms.GunaLabel lb_NextName;
        private Guna.UI.WinForms.GunaLabel lb_NextAuthor;
        private Guna.UI.WinForms.GunaPanel pn_Display;
        private Guna.UI.WinForms.GunaLabel lb_Queue;
        private Guna.UI.WinForms.GunaButton btn_Play;
    }
}
