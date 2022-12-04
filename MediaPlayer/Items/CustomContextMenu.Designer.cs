using System.Windows.Forms;

namespace MediaPlayer.Items
{
    partial class CustomContextMenu
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
            this.Play = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayNext = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Image = global::MediaPlayer.Properties.Resources.play_hover;
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(141, 26);
            this.Play.Text = "Play";
            this.Play.Click += Play_Click;
            // 
            // PlayNext
            // 
            this.PlayNext.Name = "PlayNext";
            this.PlayNext.Size = new System.Drawing.Size(141, 26);
            this.PlayNext.Text = "Play next";
            // 
            // CustomContextMenu
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Play,
            this.PlayNext});
            this.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.RenderStyle.ColorTable = null;
            this.RenderStyle.RoundedEdges = true;
            this.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.Size = new System.Drawing.Size(142, 56);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.ToolStripMenuItem PlayNext;
        public ToolStripMenuItem Play;
    }
}
