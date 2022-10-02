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
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Home
            // 
            this.flowLayoutPanel_Home.AutoScroll = true;
            this.flowLayoutPanel_Home.AutoSize = true;
            this.flowLayoutPanel_Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Home.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Home.Name = "flowLayoutPanel_Home";
            this.flowLayoutPanel_Home.Size = new System.Drawing.Size(1084, 583);
            this.flowLayoutPanel_Home.TabIndex = 0;
            this.flowLayoutPanel_Home.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Home_Paint);
            this.flowLayoutPanel_Home.Resize += new System.EventHandler(this.flowLayoutPanel_Home_Resize);
            // 
            // UserControl_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel_Home);
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
    }
}
