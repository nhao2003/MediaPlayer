namespace MediaPlayer.Items
{
    partial class MediaItem
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel_Author = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel_MediaName = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel_Author);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel_MediaName);
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(200, 300);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaLabel_Author
            // 
            this.gunaLabel_Author.AutoSize = true;
            this.gunaLabel_Author.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel_Author.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel_Author.Location = new System.Drawing.Point(4, 241);
            this.gunaLabel_Author.Name = "gunaLabel_Author";
            this.gunaLabel_Author.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel_Author.TabIndex = 5;
            this.gunaLabel_Author.Text = "gunaLabel2";
            // 
            // gunaLabel_MediaName
            // 
            this.gunaLabel_MediaName.AutoSize = true;
            this.gunaLabel_MediaName.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_MediaName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel_MediaName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel_MediaName.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_MediaName.Location = new System.Drawing.Point(3, 203);
            this.gunaLabel_MediaName.Name = "gunaLabel_MediaName";
            this.gunaLabel_MediaName.Size = new System.Drawing.Size(127, 28);
            this.gunaLabel_MediaName.TabIndex = 4;
            this.gunaLabel_MediaName.Text = "MediaName";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 10;
            this.gunaPictureBox1.Size = new System.Drawing.Size(200, 200);
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(200, 300);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel_Author;
        private Guna.UI.WinForms.GunaLabel gunaLabel_MediaName;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}
