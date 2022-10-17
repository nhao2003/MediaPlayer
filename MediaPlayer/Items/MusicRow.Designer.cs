﻿namespace MediaPlayer.Items
{
    partial class MusicRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicRow));
            this.panel_MusicRow = new Guna.UI.WinForms.GunaElipsePanel();
            this.label_Duration = new System.Windows.Forms.Label();
            this.btn_Like = new Guna.UI.WinForms.GunaCircleButton();
            this.label_NameSinger = new Guna.UI.WinForms.GunaLabel();
            this.label_NameSong = new Guna.UI.WinForms.GunaLabel();
            this.label_Index = new Guna.UI.WinForms.GunaLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel_MusicRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MusicRow
            // 
            this.panel_MusicRow.BackColor = System.Drawing.Color.Transparent;
            this.panel_MusicRow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.panel_MusicRow.Controls.Add(this.label_Duration);
            this.panel_MusicRow.Controls.Add(this.btn_Like);
            this.panel_MusicRow.Controls.Add(this.label_NameSinger);
            this.panel_MusicRow.Controls.Add(this.label_NameSong);
            this.panel_MusicRow.Controls.Add(this.label_Index);
            this.panel_MusicRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MusicRow.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel_MusicRow.Location = new System.Drawing.Point(0, 0);
            this.panel_MusicRow.Name = "panel_MusicRow";
            this.panel_MusicRow.Radius = 15;
            this.panel_MusicRow.Size = new System.Drawing.Size(700, 70);
            this.panel_MusicRow.TabIndex = 0;
            this.panel_MusicRow.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.panel_MusicRow.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.panel_MusicRow.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // label_Duration
            // 
            this.label_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Duration.AutoSize = true;
            this.label_Duration.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Duration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Duration.Location = new System.Drawing.Point(624, 23);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(49, 23);
            this.label_Duration.TabIndex = 23;
            this.label_Duration.Text = "3:18";
            // 
            // btn_Like
            // 
            this.btn_Like.Animated = true;
            this.btn_Like.AnimationHoverSpeed = 0.07F;
            this.btn_Like.AnimationSpeed = 0.03F;
            this.btn_Like.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Like.BorderColor = System.Drawing.Color.Black;
            this.btn_Like.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Like.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Like.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Like.ForeColor = System.Drawing.Color.White;
            this.btn_Like.Image = ((System.Drawing.Image)(resources.GetObject("btn_Like.Image")));
            this.btn_Like.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Like.Location = new System.Drawing.Point(52, 17);
            this.btn_Like.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.btn_Like.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Like.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.btn_Like.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_Like.OnHoverImage")));
            this.btn_Like.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Like.Size = new System.Drawing.Size(35, 37);
            this.btn_Like.TabIndex = 22;
            this.btn_Like.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.btn_Like.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.btn_Like.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // label_NameSinger
            // 
            this.label_NameSinger.AutoSize = true;
            this.label_NameSinger.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_NameSinger.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_NameSinger.Location = new System.Drawing.Point(115, 38);
            this.label_NameSinger.Name = "label_NameSinger";
            this.label_NameSinger.Size = new System.Drawing.Size(134, 19);
            this.label_NameSinger.TabIndex = 21;
            this.label_NameSinger.Text = "Đây là tên ca sĩ!!";
            this.label_NameSinger.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.label_NameSinger.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.label_NameSinger.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // label_NameSong
            // 
            this.label_NameSong.AutoSize = true;
            this.label_NameSong.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_NameSong.Location = new System.Drawing.Point(114, 12);
            this.label_NameSong.Name = "label_NameSong";
            this.label_NameSong.Size = new System.Drawing.Size(171, 26);
            this.label_NameSong.TabIndex = 21;
            this.label_NameSong.Text = "Waitting for you";
            this.label_NameSong.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.label_NameSong.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.label_NameSong.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // label_Index
            // 
            this.label_Index.AutoSize = true;
            this.label_Index.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Index.Location = new System.Drawing.Point(13, 21);
            this.label_Index.Name = "label_Index";
            this.label_Index.Size = new System.Drawing.Size(24, 26);
            this.label_Index.TabIndex = 21;
            this.label_Index.Text = "1";
            this.label_Index.MouseEnter += new System.EventHandler(this.MusicRow_MouseEnter);
            this.label_Index.MouseLeave += new System.EventHandler(this.MusicRow_MouseLeave);
            this.label_Index.MouseHover += new System.EventHandler(this.MusicRow_MouseEnter);
            // 
            // MusicRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_MusicRow);
            this.Name = "MusicRow";
            this.Size = new System.Drawing.Size(700, 70);
            this.panel_MusicRow.ResumeLayout(false);
            this.panel_MusicRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel panel_MusicRow;
        private Guna.UI.WinForms.GunaLabel label_NameSinger;
        private Guna.UI.WinForms.GunaLabel label_NameSong;
        private Guna.UI.WinForms.GunaLabel label_Index;
        private Guna.UI.WinForms.GunaCircleButton btn_Like;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}