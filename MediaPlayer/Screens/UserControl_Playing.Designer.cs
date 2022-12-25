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
            this.pic_BackGround = new Guna.UI.WinForms.GunaPictureBox();
            this.pic_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.RotationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_BackGround
            // 
            this.pic_BackGround.BackColor = System.Drawing.Color.Black;
            this.pic_BackGround.BaseColor = System.Drawing.Color.Transparent;
            this.pic_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_BackGround.Location = new System.Drawing.Point(0, 0);
            this.pic_BackGround.Name = "pic_BackGround";
            this.pic_BackGround.Size = new System.Drawing.Size(1084, 645);
            this.pic_BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BackGround.TabIndex = 0;
            this.pic_BackGround.TabStop = false;
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
            // UserControl_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Avatar);
            this.Controls.Add(this.pic_BackGround);
            this.Name = "UserControl_Playing";
            this.Size = new System.Drawing.Size(1084, 645);
            this.Load += new System.EventHandler(this.UserControl_Playing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pic_BackGround;
        private Guna.UI.WinForms.GunaPictureBox pic_Avatar;
        private System.Windows.Forms.Timer RotationTimer;
    }
}
