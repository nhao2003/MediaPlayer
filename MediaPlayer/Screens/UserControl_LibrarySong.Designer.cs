namespace MediaPlayer.Screens
{
    partial class UserControl_LibrarySong
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Inter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(15, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(23, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "1";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(89, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 10;
            this.gunaPictureBox1.Size = new System.Drawing.Size(55, 55);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.gunaPanel1.Controls.Add(this.gunaTextBox2);
            this.gunaPanel1.Controls.Add(this.gunaTextBox3);
            this.gunaPanel1.Controls.Add(this.gunaTextBox4);
            this.gunaPanel1.Controls.Add(this.gunaTextBox1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1051, 100);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaTextBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox2.Location = new System.Drawing.Point(908, 13);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.Size = new System.Drawing.Size(105, 83);
            this.gunaTextBox2.TabIndex = 3;
            this.gunaTextBox2.Text = "Duration";
            this.gunaTextBox2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaTextBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox3.Location = new System.Drawing.Point(734, 13);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.Size = new System.Drawing.Size(168, 83);
            this.gunaTextBox3.TabIndex = 2;
            this.gunaTextBox3.Text = "Date added";
            this.gunaTextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox3.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            this.gunaTextBox3.Click += new System.EventHandler(this.gunaTextBox3_Click);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaTextBox4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox4.Location = new System.Drawing.Point(455, 13);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.Size = new System.Drawing.Size(191, 83);
            this.gunaTextBox4.TabIndex = 2;
            this.gunaTextBox4.Text = "Album";
            this.gunaTextBox4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox4.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaTextBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaTextBox1.Location = new System.Drawing.Point(200, 13);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.Size = new System.Drawing.Size(182, 83);
            this.gunaTextBox1.TabIndex = 2;
            this.gunaTextBox1.Text = "Title and Author";
            this.gunaTextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            this.gunaTextBox1.Click += new System.EventHandler(this.gunaTextBox1_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Location = new System.Drawing.Point(663, 36);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(38, 40);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // UserControl_LibrarySong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UserControl_LibrarySong";
            this.Size = new System.Drawing.Size(1051, 100);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaTextBox2;
        private Guna.UI.WinForms.GunaLabel gunaTextBox3;
        private Guna.UI.WinForms.GunaLabel gunaTextBox4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaTextBox1;
    }
}
