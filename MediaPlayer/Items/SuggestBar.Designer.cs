namespace MediaPlayer.Items
{
    partial class SuggestBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuggestBar));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.panel_MusicRow = new System.Windows.Forms.Panel();
            this.pic_main = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.Controls.Add(this.panel_MusicRow);
            this.gunaElipsePanel1.Controls.Add(this.pic_main);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 1;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1091, 382);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // panel_MusicRow
            // 
            this.panel_MusicRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MusicRow.BackColor = System.Drawing.Color.Transparent;
            this.panel_MusicRow.Location = new System.Drawing.Point(382, 0);
            this.panel_MusicRow.Margin = new System.Windows.Forms.Padding(0);
            this.panel_MusicRow.Name = "panel_MusicRow";
            this.panel_MusicRow.Size = new System.Drawing.Size(709, 382);
            this.panel_MusicRow.TabIndex = 3;
            // 
            // pic_main
            // 
            this.pic_main.BackColor = System.Drawing.Color.Transparent;
            this.pic_main.BaseColor = System.Drawing.Color.Silver;
            this.pic_main.Image = ((System.Drawing.Image)(resources.GetObject("pic_main.Image")));
            this.pic_main.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_main.InitialImage")));
            this.pic_main.Location = new System.Drawing.Point(10, 10);
            this.pic_main.Margin = new System.Windows.Forms.Padding(10);
            this.pic_main.Name = "pic_main";
            this.pic_main.Radius = 30;
            this.pic_main.Size = new System.Drawing.Size(362, 362);
            this.pic_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_main.TabIndex = 2;
            this.pic_main.TabStop = false;
            // 
            // SuggestBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaElipsePanel1);
            this.DoubleBuffered = true;
            this.Name = "SuggestBar";
            this.Size = new System.Drawing.Size(1091, 382);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox pic_main;
        private System.Windows.Forms.Panel panel_MusicRow;
    }
}
