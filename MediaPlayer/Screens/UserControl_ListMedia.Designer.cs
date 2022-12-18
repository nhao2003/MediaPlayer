namespace MediaPlayer.Widgets
{
    partial class UserControl_ListMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ListMedia));
            this.lb_Title = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.btn_Suffle_Play = new Guna.UI.WinForms.GunaButton();
            this.pn_Display = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(3, 4);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(124, 62);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "Title";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.Controls.Add(this.gunaCircleButton1);
            this.gunaPanel2.Controls.Add(this.gunaLabel3);
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Controls.Add(this.gunaComboBox1);
            this.gunaPanel2.Controls.Add(this.btn_Suffle_Play);
            this.gunaPanel2.Controls.Add(this.lb_Title);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1084, 150);
            this.gunaPanel2.TabIndex = 6;
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
            this.gunaCircleButton1.Location = new System.Drawing.Point(1377, 59);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(61, 62);
            this.gunaCircleButton1.TabIndex = 24;
            this.gunaCircleButton1.Text = "Refresh";
            this.gunaCircleButton1.Click += new System.EventHandler(this.RefreshClickEvent);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.Location = new System.Drawing.Point(1458, 78);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(114, 31);
            this.gunaLabel3.TabIndex = 27;
            this.gunaLabel3.Text = "Sort by:";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(1755, 78);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(188, 39);
            this.gunaButton1.TabIndex = 25;
            this.gunaButton1.Text = "Add music";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.gunaComboBox1.Location = new System.Drawing.Point(1587, 78);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 15;
            this.gunaComboBox1.Size = new System.Drawing.Size(139, 31);
            this.gunaComboBox1.TabIndex = 26;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // btn_Suffle_Play
            // 
            this.btn_Suffle_Play.AnimationHoverSpeed = 0.07F;
            this.btn_Suffle_Play.AnimationSpeed = 0.03F;
            this.btn_Suffle_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Suffle_Play.BaseColor = System.Drawing.Color.Lime;
            this.btn_Suffle_Play.BorderColor = System.Drawing.Color.Black;
            this.btn_Suffle_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Suffle_Play.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Suffle_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Suffle_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Suffle_Play.Image = global::MediaPlayer.Properties.Resources.suffle_hover;
            this.btn_Suffle_Play.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Suffle_Play.Location = new System.Drawing.Point(14, 78);
            this.btn_Suffle_Play.Name = "btn_Suffle_Play";
            this.btn_Suffle_Play.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btn_Suffle_Play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Suffle_Play.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Suffle_Play.OnHoverImage = null;
            this.btn_Suffle_Play.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Suffle_Play.Radius = 15;
            this.btn_Suffle_Play.Size = new System.Drawing.Size(157, 43);
            this.btn_Suffle_Play.TabIndex = 6;
            this.btn_Suffle_Play.Text = "Suffle and play";
            // 
            // pn_Display
            // 
            this.pn_Display.AutoScroll = true;
            this.pn_Display.BackColor = System.Drawing.Color.Transparent;
            this.pn_Display.Location = new System.Drawing.Point(0, 150);
            this.pn_Display.Name = "pn_Display";
            this.pn_Display.Size = new System.Drawing.Size(1084, 495);
            this.pn_Display.TabIndex = 7;
            // 
            // UserControl_ListMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pn_Display);
            this.Controls.Add(this.gunaPanel2);
            this.Name = "UserControl_ListMedia";
            this.Size = new System.Drawing.Size(1084, 645);
            this.Load += new System.EventHandler(this.LoadListMediaEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserControl_ListMedia_KeyDown);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_Title;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btn_Suffle_Play;
        private Guna.UI.WinForms.GunaPanel pn_Display;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
    }
}
