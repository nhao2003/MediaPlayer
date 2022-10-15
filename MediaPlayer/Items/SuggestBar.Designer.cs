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
            this.musicRow5 = new MediaPlayer.Items.MusicRow();
            this.musicRow4 = new MediaPlayer.Items.MusicRow();
            this.musicRow3 = new MediaPlayer.Items.MusicRow();
            this.musicRow2 = new MediaPlayer.Items.MusicRow();
            this.musicRow1 = new MediaPlayer.Items.MusicRow();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.gunaElipsePanel1.Controls.Add(this.musicRow5);
            this.gunaElipsePanel1.Controls.Add(this.musicRow4);
            this.gunaElipsePanel1.Controls.Add(this.musicRow3);
            this.gunaElipsePanel1.Controls.Add(this.musicRow2);
            this.gunaElipsePanel1.Controls.Add(this.musicRow1);
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1091, 382);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // musicRow5
            // 
            this.musicRow5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicRow5.Location = new System.Drawing.Point(385, 310);
            this.musicRow5.Name = "musicRow5";
            this.musicRow5.Size = new System.Drawing.Size(700, 70);
            this.musicRow5.TabIndex = 3;
            // 
            // musicRow4
            // 
            this.musicRow4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicRow4.Location = new System.Drawing.Point(385, 231);
            this.musicRow4.Name = "musicRow4";
            this.musicRow4.Size = new System.Drawing.Size(700, 70);
            this.musicRow4.TabIndex = 4;
            // 
            // musicRow3
            // 
            this.musicRow3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicRow3.Location = new System.Drawing.Point(385, 155);
            this.musicRow3.Name = "musicRow3";
            this.musicRow3.Size = new System.Drawing.Size(700, 70);
            this.musicRow3.TabIndex = 5;
            // 
            // musicRow2
            // 
            this.musicRow2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicRow2.Location = new System.Drawing.Point(385, 79);
            this.musicRow2.Name = "musicRow2";
            this.musicRow2.Size = new System.Drawing.Size(700, 70);
            this.musicRow2.TabIndex = 6;
            // 
            // musicRow1
            // 
            this.musicRow1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicRow1.Location = new System.Drawing.Point(385, 3);
            this.musicRow1.Name = "musicRow1";
            this.musicRow1.Size = new System.Drawing.Size(700, 70);
            this.musicRow1.TabIndex = 7;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Silver;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.InitialImage")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(6, 4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 30;
            this.gunaPictureBox1.Size = new System.Drawing.Size(373, 373);
            this.gunaPictureBox1.TabIndex = 2;
            this.gunaPictureBox1.TabStop = false;
            // 
            // SuggestBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.gunaElipsePanel1);
            this.DoubleBuffered = true;
            this.Name = "SuggestBar";
            this.Size = new System.Drawing.Size(1091, 382);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private MusicRow musicRow5;
        private MusicRow musicRow4;
        private MusicRow musicRow3;
        private MusicRow musicRow2;
        private MusicRow musicRow1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}
