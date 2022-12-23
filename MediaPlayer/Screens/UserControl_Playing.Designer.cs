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
            this.pic_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.pic_BackGround = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pic_Avatar.BaseColor = System.Drawing.Color.Transparent;
            this.pic_Avatar.Image = global::MediaPlayer.Properties.Resources.favorite_hover;
            this.pic_Avatar.Location = new System.Drawing.Point(13, 329);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Radius = 30;
            this.pic_Avatar.Size = new System.Drawing.Size(300, 300);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Avatar.TabIndex = 1;
            this.pic_Avatar.TabStop = false;
            // 
            // pic_BackGround
            // 
            this.pic_BackGround.BaseColor = System.Drawing.Color.White;
            this.pic_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_BackGround.Image = global::MediaPlayer.Properties.Resources.defaultImage;
            this.pic_BackGround.Location = new System.Drawing.Point(0, 0);
            this.pic_BackGround.Name = "pic_BackGround";
            this.pic_BackGround.Size = new System.Drawing.Size(1084, 645);
            this.pic_BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BackGround.TabIndex = 0;
            this.pic_BackGround.TabStop = false;
            // 
            // UserControl_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Avatar);
            this.Controls.Add(this.pic_BackGround);
            this.Name = "UserControl_Playing";
            this.Size = new System.Drawing.Size(1084, 645);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pic_BackGround;
        private Guna.UI.WinForms.GunaPictureBox pic_Avatar;
    }
}
