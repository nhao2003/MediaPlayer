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
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.AddTo = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoriteList = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTo_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.Play = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayNext = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // Separator
            // 
            this.Separator.ForeColor = System.Drawing.Color.White;
            this.Separator.Name = "Separator";
            this.Separator.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Separator.Size = new System.Drawing.Size(160, 6);
            // 
            // AddTo
            // 
            this.AddTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayQueue,
            this.FavoriteList,
            this.AddTo_Separator,
            this.NewPlaylist});
            this.AddTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddTo.ForeColor = System.Drawing.Color.White;
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(163, 32);
            this.AddTo.Text = "Add to";
            // 
            // PlayQueue
            // 
            this.PlayQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.PlayQueue.ForeColor = System.Drawing.Color.White;
            this.PlayQueue.Image = global::MediaPlayer.Properties.Resources.play_queue;
            this.PlayQueue.Name = "PlayQueue";
            this.PlayQueue.Size = new System.Drawing.Size(203, 32);
            this.PlayQueue.Text = "Play queue";
            // 
            // FavoriteList
            // 
            this.FavoriteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FavoriteList.ForeColor = System.Drawing.Color.White;
            this.FavoriteList.Name = "FavoriteList";
            this.FavoriteList.Size = new System.Drawing.Size(203, 32);
            this.FavoriteList.Text = "Favorite List";
            // 
            // AddTo_Separator
            // 
            this.AddTo_Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.AddTo_Separator.ForeColor = System.Drawing.Color.White;
            this.AddTo_Separator.Name = "AddTo_Separator";
            this.AddTo_Separator.Size = new System.Drawing.Size(200, 6);
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Image = global::MediaPlayer.Properties.Resources.play_hover;
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(163, 32);
            this.Play.Text = "Play";
            // 
            // PlayNext
            // 
            this.PlayNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlayNext.ForeColor = System.Drawing.Color.White;
            this.PlayNext.Image = global::MediaPlayer.Properties.Resources.add_to_queue;
            this.PlayNext.Name = "PlayNext";
            this.PlayNext.Size = new System.Drawing.Size(163, 32);
            this.PlayNext.Text = "Play next";
            // 
            // NewPlaylist
            // 
            this.NewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.NewPlaylist.ForeColor = System.Drawing.Color.White;
            this.NewPlaylist.Image = global::MediaPlayer.Properties.Resources.new_playlist;
            this.NewPlaylist.Name = "NewPlaylist";
            this.NewPlaylist.Size = new System.Drawing.Size(203, 32);
            this.NewPlaylist.Text = "New Playlist";
            // 
            // CustomContextMenu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
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
            this.Size = new System.Drawing.Size(164, 106);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolStripMenuItem PlayNext;
        public ToolStripMenuItem Play;
        private ToolStripSeparator Separator;
        private ToolStripMenuItem AddTo;
        private ToolStripMenuItem PlayQueue;
        private ToolStripMenuItem FavoriteList;
        private ToolStripSeparator AddTo_Separator;
        private ToolStripMenuItem NewPlaylist;
    }
}
