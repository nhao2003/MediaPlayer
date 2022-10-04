namespace MediaPlayer.Widgets
{
    partial class UserControl_Settings
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
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(2, 0);
            this.gunaLabel_Recent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(174, 53);
            this.gunaLabel_Recent.TabIndex = 2;
            this.gunaLabel_Recent.Text = "Settings";
            // 
            // UserControl_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel_Recent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl_Settings";
            this.Size = new System.Drawing.Size(813, 524);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel_Recent;
    }
}
