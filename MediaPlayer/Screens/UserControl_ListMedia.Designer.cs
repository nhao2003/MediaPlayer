namespace MediaPlayer.Screens
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
            this.lb_Title = new Guna.UI.WinForms.GunaLabel();
            this.panel_Title = new Guna.UI.WinForms.GunaPanel();
            this.lb_SortBy = new System.Windows.Forms.Label();
            this.cb_SortBy = new Guna.UI.WinForms.GunaComboBox();
            this.btn_Suffle_Play = new Guna.UI.WinForms.GunaButton();
            this.pn_Display = new Guna.UI.WinForms.GunaPanel();
            this.panel_Title.SuspendLayout();
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
            // panel_Title
            // 
            this.panel_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_Title.Controls.Add(this.lb_SortBy);
            this.panel_Title.Controls.Add(this.cb_SortBy);
            this.panel_Title.Controls.Add(this.btn_Suffle_Play);
            this.panel_Title.Controls.Add(this.lb_Title);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1084, 150);
            this.panel_Title.TabIndex = 6;
            // 
            // lb_SortBy
            // 
            this.lb_SortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SortBy.AutoSize = true;
            this.lb_SortBy.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SortBy.ForeColor = System.Drawing.Color.White;
            this.lb_SortBy.Location = new System.Drawing.Point(810, 90);
            this.lb_SortBy.Name = "lb_SortBy";
            this.lb_SortBy.Size = new System.Drawing.Size(88, 30);
            this.lb_SortBy.TabIndex = 29;
            this.lb_SortBy.Text = "Sort by:";
            // 
            // cb_SortBy
            // 
            this.cb_SortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SortBy.BackColor = System.Drawing.Color.Transparent;
            this.cb_SortBy.BaseColor = System.Drawing.Color.White;
            this.cb_SortBy.BorderColor = System.Drawing.Color.Silver;
            this.cb_SortBy.BorderSize = 0;
            this.cb_SortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_SortBy.FocusedColor = System.Drawing.Color.Empty;
            this.cb_SortBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_SortBy.ForeColor = System.Drawing.Color.Black;
            this.cb_SortBy.FormattingEnabled = true;
            this.cb_SortBy.Items.AddRange(new object[] {
            "A to Z",
            "Date added",
            "Artist",
            "Album"});
            this.cb_SortBy.Location = new System.Drawing.Point(925, 90);
            this.cb_SortBy.Name = "cb_SortBy";
            this.cb_SortBy.OnHoverItemBaseColor = System.Drawing.Color.Lime;
            this.cb_SortBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_SortBy.Radius = 10;
            this.cb_SortBy.Size = new System.Drawing.Size(135, 31);
            this.cb_SortBy.StartIndex = 0;
            this.cb_SortBy.TabIndex = 28;
            this.cb_SortBy.SelectedIndexChanged += new System.EventHandler(this.ChangeSortOptionEvent);
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
            this.pn_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Display.AutoScroll = true;
            this.pn_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
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
            this.Controls.Add(this.panel_Title);
            this.Name = "UserControl_ListMedia";
            this.Size = new System.Drawing.Size(1084, 645);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_Title;
        private Guna.UI.WinForms.GunaPanel panel_Title;
        private Guna.UI.WinForms.GunaButton btn_Suffle_Play;
        private Guna.UI.WinForms.GunaPanel pn_Display;
        private System.Windows.Forms.Label lb_SortBy;
        private Guna.UI.WinForms.GunaComboBox cb_SortBy;
    }
}
