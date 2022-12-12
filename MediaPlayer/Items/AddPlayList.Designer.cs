namespace MediaPlayer.Items
{
    partial class AddPlayList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Title = new System.Windows.Forms.Label();
            this.pic_BackGround = new Guna.UI.WinForms.GunaPictureBox();
            this.tb_NamePlayList = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_Save_Or_Rename = new Guna.UI.WinForms.GunaButton();
            this.btn_Cancel = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackGround)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(33, 26);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(272, 41);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Add to new playlist";
            // 
            // pic_BackGround
            // 
            this.pic_BackGround.BackColor = System.Drawing.Color.Transparent;
            this.pic_BackGround.BaseColor = System.Drawing.Color.White;
            this.pic_BackGround.Image = global::MediaPlayer.Properties.Resources.defaultImage;
            this.pic_BackGround.Location = new System.Drawing.Point(131, 88);
            this.pic_BackGround.Name = "pic_BackGround";
            this.pic_BackGround.Radius = 15;
            this.pic_BackGround.Size = new System.Drawing.Size(150, 150);
            this.pic_BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BackGround.TabIndex = 1;
            this.pic_BackGround.TabStop = false;
            this.pic_BackGround.Click += new System.EventHandler(this.pic_BackGround_Click);
            // 
            // tb_NamePlayList
            // 
            this.tb_NamePlayList.BackColor = System.Drawing.Color.Transparent;
            this.tb_NamePlayList.BaseColor = System.Drawing.Color.White;
            this.tb_NamePlayList.BorderColor = System.Drawing.Color.Silver;
            this.tb_NamePlayList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_NamePlayList.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_NamePlayList.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_NamePlayList.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_NamePlayList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_NamePlayList.Location = new System.Drawing.Point(49, 257);
            this.tb_NamePlayList.Name = "tb_NamePlayList";
            this.tb_NamePlayList.PasswordChar = '\0';
            this.tb_NamePlayList.Radius = 10;
            this.tb_NamePlayList.SelectedText = "";
            this.tb_NamePlayList.Size = new System.Drawing.Size(314, 49);
            this.tb_NamePlayList.TabIndex = 3;
            this.tb_NamePlayList.Text = "Untitled playlist";
            this.tb_NamePlayList.TextChanged += new System.EventHandler(this.tb_NamePlayList_TextChanged);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Controls.Add(this.pic_BackGround);
            this.gunaPanel1.Controls.Add(this.tb_NamePlayList);
            this.gunaPanel1.Controls.Add(this.lb_Title);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(413, 333);
            this.gunaPanel1.TabIndex = 4;
            // 
            // btn_Save_Or_Rename
            // 
            this.btn_Save_Or_Rename.AnimationHoverSpeed = 0.07F;
            this.btn_Save_Or_Rename.AnimationSpeed = 0.03F;
            this.btn_Save_Or_Rename.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save_Or_Rename.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Save_Or_Rename.BorderColor = System.Drawing.Color.Black;
            this.btn_Save_Or_Rename.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save_Or_Rename.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Save_Or_Rename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save_Or_Rename.ForeColor = System.Drawing.Color.White;
            this.btn_Save_Or_Rename.Image = null;
            this.btn_Save_Or_Rename.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Save_Or_Rename.Location = new System.Drawing.Point(49, 363);
            this.btn_Save_Or_Rename.Name = "btn_Save_Or_Rename";
            this.btn_Save_Or_Rename.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Save_Or_Rename.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save_Or_Rename.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save_Or_Rename.OnHoverImage = null;
            this.btn_Save_Or_Rename.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save_Or_Rename.Radius = 10;
            this.btn_Save_Or_Rename.Size = new System.Drawing.Size(146, 42);
            this.btn_Save_Or_Rename.TabIndex = 5;
            this.btn_Save_Or_Rename.Text = "Save";
            this.btn_Save_Or_Rename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save_Or_Rename.Click += new System.EventHandler(this.btn_Save_Or_Rename_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AnimationHoverSpeed = 0.07F;
            this.btn_Cancel.AnimationSpeed = 0.03F;
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Cancel.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Cancel.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Image = null;
            this.btn_Cancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Cancel.Location = new System.Drawing.Point(217, 363);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Cancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Cancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Cancel.OnHoverImage = null;
            this.btn_Cancel.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Cancel.Radius = 10;
            this.btn_Cancel.Size = new System.Drawing.Size(146, 42);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AddPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(413, 439);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save_Or_Rename);
            this.Controls.Add(this.gunaPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPlayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlayList";
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackGround)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private Guna.UI.WinForms.GunaPictureBox pic_BackGround;
        private Guna.UI.WinForms.GunaTextBox tb_NamePlayList;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_Save_Or_Rename;
        private Guna.UI.WinForms.GunaButton btn_Cancel;
    }
}