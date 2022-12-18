using System.Windows.Forms;

namespace MediaPlayer.Widgets
{
    partial class UserControl_Library
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
            this.cb_SortBy = new Guna.UI.WinForms.GunaComboBox();
            this.lb_SortBy = new System.Windows.Forms.Label();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.AddNewPlayList_Play = new Guna.UI.WinForms.GunaButton();
            this.pn_Display = new System.Windows.Forms.FlowLayoutPanel();
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
            this.lb_Title.Size = new System.Drawing.Size(183, 62);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "Library";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            "Date added"});
            this.cb_SortBy.Location = new System.Drawing.Point(912, 81);
            this.cb_SortBy.Name = "cb_SortBy";
            this.cb_SortBy.OnHoverItemBaseColor = System.Drawing.Color.Lime;
            this.cb_SortBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_SortBy.Radius = 10;
            this.cb_SortBy.Size = new System.Drawing.Size(135, 31);
            this.cb_SortBy.StartIndex = 0;
            this.cb_SortBy.TabIndex = 4;
            this.cb_SortBy.SelectedIndexChanged += new System.EventHandler(this.cb_SortBy_SelectedIndexChanged);
            // 
            // lb_SortBy
            // 
            this.lb_SortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SortBy.AutoSize = true;
            this.lb_SortBy.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_SortBy.ForeColor = System.Drawing.Color.White;
            this.lb_SortBy.Location = new System.Drawing.Point(779, 81);
            this.lb_SortBy.Name = "lb_SortBy";
            this.lb_SortBy.Size = new System.Drawing.Size(88, 30);
            this.lb_SortBy.TabIndex = 5;
            this.lb_SortBy.Text = "Sort by:";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.Controls.Add(this.AddNewPlayList_Play);
            this.gunaPanel2.Controls.Add(this.lb_Title);
            this.gunaPanel2.Controls.Add(this.lb_SortBy);
            this.gunaPanel2.Controls.Add(this.cb_SortBy);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1084, 123);
            this.gunaPanel2.TabIndex = 6;
            // 
            // AddNewPlayList_Play
            // 
            this.AddNewPlayList_Play.AnimationHoverSpeed = 0.07F;
            this.AddNewPlayList_Play.AnimationSpeed = 0.03F;
            this.AddNewPlayList_Play.BackColor = System.Drawing.Color.Transparent;
            this.AddNewPlayList_Play.BaseColor = System.Drawing.Color.Lime;
            this.AddNewPlayList_Play.BorderColor = System.Drawing.Color.Black;
            this.AddNewPlayList_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddNewPlayList_Play.FocusedColor = System.Drawing.Color.Empty;
            this.AddNewPlayList_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddNewPlayList_Play.ForeColor = System.Drawing.Color.Black;
            this.AddNewPlayList_Play.Image = global::MediaPlayer.Properties.Resources.new_playlist;
            this.AddNewPlayList_Play.ImageSize = new System.Drawing.Size(20, 20);
            this.AddNewPlayList_Play.Location = new System.Drawing.Point(14, 69);
            this.AddNewPlayList_Play.Name = "AddNewPlayList_Play";
            this.AddNewPlayList_Play.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.AddNewPlayList_Play.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddNewPlayList_Play.OnHoverForeColor = System.Drawing.Color.White;
            this.AddNewPlayList_Play.OnHoverImage = null;
            this.AddNewPlayList_Play.OnPressedColor = System.Drawing.Color.Black;
            this.AddNewPlayList_Play.Radius = 15;
            this.AddNewPlayList_Play.Size = new System.Drawing.Size(157, 43);
            this.AddNewPlayList_Play.TabIndex = 6;
            this.AddNewPlayList_Play.Text = "New playlist";
            this.AddNewPlayList_Play.Click += new System.EventHandler(this.AddNewPlayList_Play_Click);
            // 
            // pn_Display
            // 
            this.pn_Display.AutoScroll = true;
            this.pn_Display.BackColor = System.Drawing.Color.Transparent;
            this.pn_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Display.Location = new System.Drawing.Point(0, 123);
            this.pn_Display.Name = "pn_Display";
            this.pn_Display.Size = new System.Drawing.Size(1084, 522);
            this.pn_Display.TabIndex = 7;
            // 
            // UserControl_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pn_Display);
            this.Controls.Add(this.gunaPanel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_Library";
            this.Size = new System.Drawing.Size(1084, 645);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_Title;
        private Guna.UI.WinForms.GunaComboBox cb_SortBy;
        private System.Windows.Forms.Label lb_SortBy;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton AddNewPlayList_Play;
        private System.Windows.Forms.FlowLayoutPanel pn_Display;
    }
}
