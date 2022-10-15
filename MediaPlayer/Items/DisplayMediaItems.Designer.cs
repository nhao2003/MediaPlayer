namespace MediaPlayer.Items
{
    partial class DisplayMediaItems
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
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_SeeAll = new Guna.UI.WinForms.GunaLabel();
            this.label_Title = new Guna.UI.WinForms.GunaLabel();
            this.panel_Items = new Guna.UI.WinForms.GunaPanel();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.Controls.Add(this.label_SeeAll);
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1074, 47);
            this.panel_Title.TabIndex = 1;
            // 
            // label_SeeAll
            // 
            this.label_SeeAll.AutoSize = true;
            this.label_SeeAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_SeeAll.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label_SeeAll.Location = new System.Drawing.Point(887, 0);
            this.label_SeeAll.Name = "label_SeeAll";
            this.label_SeeAll.Size = new System.Drawing.Size(187, 46);
            this.label_SeeAll.TabIndex = 4;
            this.label_SeeAll.Text = "Xem tất cả";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label_Title.Location = new System.Drawing.Point(3, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(91, 46);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Title";
            // 
            // panel_Items
            // 
            this.panel_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Items.Location = new System.Drawing.Point(0, 47);
            this.panel_Items.Name = "panel_Items";
            this.panel_Items.Size = new System.Drawing.Size(1074, 316);
            this.panel_Items.TabIndex = 2;
            // 
            // DisplayMediaItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.panel_Items);
            this.Controls.Add(this.panel_Title);
            this.Name = "DisplayMediaItems";
            this.Size = new System.Drawing.Size(1074, 363);
            this.Load += new System.EventHandler(this.DisplayMediaItems_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title;
        private Guna.UI.WinForms.GunaLabel label_SeeAll;
        private Guna.UI.WinForms.GunaLabel label_Title;
        private Guna.UI.WinForms.GunaPanel panel_Items;
    }
}
