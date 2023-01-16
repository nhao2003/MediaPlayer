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
            this.pn_EnterSearch = new Guna.UI.WinForms.GunaElipsePanel();
            this.pb_IconSearch = new Guna.UI.WinForms.GunaPictureBox();
            this.tbEnterTextSearch = new Guna.UI.WinForms.GunaTextBox();
            this.pn_HeaderSearch = new Guna.UI.WinForms.GunaElipsePanel();
            this.lb_Title = new Guna.UI.WinForms.GunaLabel();
            this.pn_Search = new Guna.UI.WinForms.GunaPanel();
            this.pn_EnterSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconSearch)).BeginInit();
            this.pn_HeaderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_EnterSearch
            // 
            this.pn_EnterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_EnterSearch.BackColor = System.Drawing.Color.Transparent;
            this.pn_EnterSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_EnterSearch.Controls.Add(this.pb_IconSearch);
            this.pn_EnterSearch.Controls.Add(this.tbEnterTextSearch);
            this.pn_EnterSearch.Location = new System.Drawing.Point(11, 65);
            this.pn_EnterSearch.Name = "pn_EnterSearch";
            this.pn_EnterSearch.Radius = 20;
            this.pn_EnterSearch.Size = new System.Drawing.Size(858, 50);
            this.pn_EnterSearch.TabIndex = 3;
            // 
            // pb_IconSearch
            // 
            this.pb_IconSearch.BaseColor = System.Drawing.Color.White;
            this.pb_IconSearch.Image = global::MediaPlayer.Properties.Resources.search;
            this.pb_IconSearch.Location = new System.Drawing.Point(29, 5);
            this.pb_IconSearch.Name = "pb_IconSearch";
            this.pb_IconSearch.Size = new System.Drawing.Size(33, 38);
            this.pb_IconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_IconSearch.TabIndex = 2;
            this.pb_IconSearch.TabStop = false;
            // 
            // tbEnterTextSearch
            // 
            this.tbEnterTextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnterTextSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEnterTextSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEnterTextSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEnterTextSearch.BorderSize = 0;
            this.tbEnterTextSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEnterTextSearch.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEnterTextSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEnterTextSearch.FocusedForeColor = System.Drawing.Color.White;
            this.tbEnterTextSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbEnterTextSearch.ForeColor = System.Drawing.Color.White;
            this.tbEnterTextSearch.Location = new System.Drawing.Point(68, 5);
            this.tbEnterTextSearch.Name = "tbEnterTextSearch";
            this.tbEnterTextSearch.PasswordChar = '\0';
            this.tbEnterTextSearch.SelectedText = "";
            this.tbEnterTextSearch.Size = new System.Drawing.Size(694, 38);
            this.tbEnterTextSearch.TabIndex = 1;
            this.tbEnterTextSearch.Text = "Nhập tên nhạc / Album / Ca sĩ";
            this.tbEnterTextSearch.TextChanged += new System.EventHandler(this.EventSearchText);
            this.tbEnterTextSearch.Enter += new System.EventHandler(this.EventTextBoxSearch_Enter);
            this.tbEnterTextSearch.Leave += new System.EventHandler(this.EventTextBoxSearch_Leave);
            // 
            // pn_HeaderSearch
            // 
            this.pn_HeaderSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pn_HeaderSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pn_HeaderSearch.Controls.Add(this.lb_Title);
            this.pn_HeaderSearch.Controls.Add(this.pn_EnterSearch);
            this.pn_HeaderSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_HeaderSearch.ForeColor = System.Drawing.Color.White;
            this.pn_HeaderSearch.Location = new System.Drawing.Point(0, 0);
            this.pn_HeaderSearch.Name = "pn_HeaderSearch";
            this.pn_HeaderSearch.Size = new System.Drawing.Size(1084, 136);
            this.pn_HeaderSearch.TabIndex = 3;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(0, 0);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(173, 62);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "Search";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_Search
            // 
            this.pn_Search.AutoScroll = true;
            this.pn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Search.Location = new System.Drawing.Point(0, 136);
            this.pn_Search.Name = "pn_Search";
            this.pn_Search.Size = new System.Drawing.Size(1084, 509);
            this.pn_Search.TabIndex = 4;
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pn_Search);
            this.Controls.Add(this.pn_HeaderSearch);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(1084, 645);
            this.pn_EnterSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconSearch)).EndInit();
            this.pn_HeaderSearch.ResumeLayout(false);
            this.pn_HeaderSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipsePanel pn_EnterSearch;
        private Guna.UI.WinForms.GunaTextBox tbEnterTextSearch;
        private Guna.UI.WinForms.GunaElipsePanel pn_HeaderSearch;
        private Guna.UI.WinForms.GunaPanel pn_Search;
        private Guna.UI.WinForms.GunaPictureBox pb_IconSearch;
        private Guna.UI.WinForms.GunaLabel lb_Title;
    }
}
