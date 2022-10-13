namespace MediaPlayer.Widgets
{
    partial class UserControl_Home
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
            this.flowLayoutPanel_Home = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Home
            // 
            this.flowLayoutPanel_Home.AutoScroll = true;
            this.flowLayoutPanel_Home.AutoSize = true;
            this.flowLayoutPanel_Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel_Home.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Home.Name = "flowLayoutPanel_Home";
            this.flowLayoutPanel_Home.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel_Home.TabIndex = 0;
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(1084, 65);
            this.gunaLabel_Recent.TabIndex = 5;
            this.gunaLabel_Recent.Text = "Home";
            // 
            // UserControl_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.gunaLabel_Recent);
            this.Controls.Add(this.flowLayoutPanel_Home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(1084, 583);
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.UserControl_Home_SizeChanged);
            this.Resize += new System.EventHandler(this.UserControl_Home_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Home;
        private Guna.UI.WinForms.GunaLabel gunaLabel_Recent;
    }
}
