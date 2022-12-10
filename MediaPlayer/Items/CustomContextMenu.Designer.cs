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
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.AddTo = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Image = global::MediaPlayer.Properties.Resources.play_hover;
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(141, 26);
            this.Play.Text = "Play";
            // 
            // PlayNext
            // 
            this.PlayNext.Name = "PlayNext";
            this.PlayNext.Size = new System.Drawing.Size(141, 26);
            this.PlayNext.Text = "Play next";
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(138, 6);
            // 
            // AddTo
            // 
            this.AddTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayQueue});
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(141, 26);
            this.AddTo.Text = "Add to";
            this.AddTo.Click += AddTo_Click;
            // 
            // PlayQueue
            // 
            this.PlayQueue.Name = "PlayQueue";
            this.PlayQueue.Size = new System.Drawing.Size(164, 26);
            this.PlayQueue.Text = "Play queue";
            // 
            // CustomContextMenu
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Play,
            this.PlayNext,
            this.Separator,
            this.AddTo});
            this.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.RenderStyle.ColorTable = null;
            this.RenderStyle.RoundedEdges = true;
            this.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.Size = new System.Drawing.Size(142, 88);
            this.ResumeLayout(false);

        }

        private void AddTo_Click(object sender, System.EventArgs e)
        {
            AddPlayList addPlayList = new AddPlayList();
            addPlayList.ShowDialog();
        }




        #endregion
        private System.Windows.Forms.ToolStripMenuItem PlayNext;
        public ToolStripMenuItem Play;
        private ToolStripSeparator Separator;
        private ToolStripMenuItem AddTo;
        private ToolStripMenuItem PlayQueue;
    }
}
