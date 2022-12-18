namespace MediaPlayer.Widgets
{
    partial class UserControl_Search
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
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.pn_Search = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.White;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(201, 69);
            this.gunaLabel_Recent.TabIndex = 2;
            this.gunaLabel_Recent.Text = "Search";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.Gray;
            this.gunaElipsePanel2.Controls.Add(this.gunaTextBox1);
            this.gunaElipsePanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(36, 52);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(705, 50);
            this.gunaElipsePanel2.TabIndex = 3;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTextBox1.BackColor = System.Drawing.Color.Black;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.Gray;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.Gray;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Gray;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.Color.Empty;
            this.gunaTextBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaTextBox1.Location = new System.Drawing.Point(72, 5);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(541, 38);
            this.gunaTextBox1.TabIndex = 1;
            this.gunaTextBox1.Text = "Nhập tên nhạc / Album / Ca sĩ";
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.EventSearchText);
            this.gunaTextBox1.Enter += new System.EventHandler(this.gunaTextBox1_Enter);
            this.gunaTextBox1.Leave += new System.EventHandler(this.gunaTextBox1_Leave);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = global::MediaPlayer.Properties.Resources.search;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::MediaPlayer.Properties.Resources.search;
            this.gunaPictureBox1.InitialImage = global::MediaPlayer.Properties.Resources.search;
            this.gunaPictureBox1.Location = new System.Drawing.Point(25, 13);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(31, 30);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Controls.Add(this.gunaComboBox1);
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel_Recent);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.ForeColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1084, 120);
            this.gunaElipsePanel1.TabIndex = 3;
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
            this.gunaCircleButton1.Location = new System.Drawing.Point(1023, 40);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(61, 62);
            this.gunaCircleButton1.TabIndex = 30;
            this.gunaCircleButton1.Text = "Refresh";
            this.gunaCircleButton1.Click += new System.EventHandler(this.EventClickRefresh);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.Location = new System.Drawing.Point(758, 65);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(114, 31);
            this.gunaLabel3.TabIndex = 29;
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
            this.gunaComboBox1.Location = new System.Drawing.Point(878, 67);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 15;
            this.gunaComboBox1.Size = new System.Drawing.Size(139, 31);
            this.gunaComboBox1.TabIndex = 28;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.ChangeSortEvent);
            // 
            // pn_Search
            // 
            this.pn_Search.AutoScroll = true;
            this.pn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.pn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Search.Location = new System.Drawing.Point(0, 120);
            this.pn_Search.Name = "pn_Search";
            this.pn_Search.Size = new System.Drawing.Size(1084, 525);
            this.pn_Search.TabIndex = 4;
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Search);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(1084, 645);
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel_Recent;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaPanel pn_Search;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
    }
}
