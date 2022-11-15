namespace MediaPlayer.Widgets
{
    partial class UserControl_Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Video));
            this.gunaLabel_Recent = new Guna.UI.WinForms.GunaLabel();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.bt_open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel_Recent
            // 
            this.gunaLabel_Recent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel_Recent.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel_Recent.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel_Recent.Name = "gunaLabel_Recent";
            this.gunaLabel_Recent.Size = new System.Drawing.Size(197, 65);
            this.gunaLabel_Recent.TabIndex = 2;
            this.gunaLabel_Recent.Text = "Video";
            // 
            // videoPlayer
            // 
            this.videoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(0, 54);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(1084, 591);
            this.videoPlayer.TabIndex = 3;
            // 
            // bt_open
            // 
            this.bt_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_open.Location = new System.Drawing.Point(992, 20);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(75, 23);
            this.bt_open.TabIndex = 4;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // UserControl_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.gunaLabel_Recent);
            this.Name = "UserControl_Video";
            this.Size = new System.Drawing.Size(1084, 645);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel_Recent;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Button bt_open;
    }
}
