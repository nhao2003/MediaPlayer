namespace MediaPlayer.Items
{
    partial class GroupMedia
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_Display = new System.Windows.Forms.Panel();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.lb_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(898, 57);
            this.panel_Title.TabIndex = 0;
            this.panel_Title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Title_Paint);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(3, 8);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(74, 41);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Title";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Display
            // 
            this.panel_Display.AutoSize = true;
            this.panel_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Display.Location = new System.Drawing.Point(0, 57);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(898, 68);
            this.panel_Display.TabIndex = 1;
            // 
            // GroupMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_Display);
            this.Controls.Add(this.panel_Title);
            this.Name = "GroupMedia";
            this.Size = new System.Drawing.Size(898, 125);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_Display;
    }
}
