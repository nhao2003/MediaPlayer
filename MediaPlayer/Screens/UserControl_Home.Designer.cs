using System.Windows.Forms;
using Guna.UI.WinForms;
using MediaPlayer.Items;

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
            this.panel_Home = new Guna.UI.WinForms.GunaGradient2Panel();
            this.suggestBar1 = new MediaPlayer.Items.SuggestBar();
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.panel_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Home
            // 
            this.panel_Home.AutoScroll = true;
            this.panel_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_Home.Controls.Add(this.suggestBar1);
            this.panel_Home.Controls.Add(this.gunaLabel_Recent);
            this.panel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Home.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_Home.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Home.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_Home.Location = new System.Drawing.Point(0, 0);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(1084, 583);
            this.panel_Home.TabIndex = 4;
            this.panel_Home.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_Home_Scroll);
            // 
            // suggestBar1
            // 
            this.suggestBar1.BackColor = System.Drawing.Color.Transparent;
            this.suggestBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.suggestBar1.Location = new System.Drawing.Point(0, 65);
            this.suggestBar1.Name = "suggestBar1";
            this.suggestBar1.Size = new System.Drawing.Size(1084, 397);
            this.suggestBar1.TabIndex = 4;
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel_Recent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.White;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(1084, 65);
            this.gunaLabel_Recent.TabIndex = 3;
            this.gunaLabel_Recent.Text = "Home";
            // 
            // UserControl_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.panel_Home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(1084, 583);
            this.panel_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private Guna.UI.WinForms.GunaGradient2Panel panel_Home;
        public SuggestBar suggestBar1;
        private GunaLabel gunaLabel_Recent;
    }
}
