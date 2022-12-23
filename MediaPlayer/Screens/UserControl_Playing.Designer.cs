namespace MediaPlayer.Screens
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
            this.pic_Background = new Guna.UI.WinForms.GunaPictureBox();
            this.pic_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Background
            // 
            this.pic_Background.BaseColor = System.Drawing.Color.White;
            this.pic_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Background.Location = new System.Drawing.Point(0, 0);
            this.pic_Background.Name = "pic_Background";
            this.pic_Background.Size = new System.Drawing.Size(1084, 645);
            this.pic_Background.TabIndex = 0;
            this.pic_Background.TabStop = false;
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BaseColor = System.Drawing.Color.White;
            this.pic_Avatar.Location = new System.Drawing.Point(3, 3);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(300, 300);
            this.pic_Avatar.TabIndex = 1;
            this.pic_Avatar.TabStop = false;
            // 
            // UserControl_Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Avatar);
            this.Controls.Add(this.pic_Background);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_Playing";
            this.Size = new System.Drawing.Size(1084, 645);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pic_Background;
        private Guna.UI.WinForms.GunaPictureBox pic_Avatar;
    }
}
