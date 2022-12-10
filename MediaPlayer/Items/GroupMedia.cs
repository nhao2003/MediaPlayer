using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class GroupMedia : UserControl
    {
        /// <summary>
        /// Get or set Group Music Title
        /// </summary>
        public String Title
        {
            get => lb_Title.Text;
            set => lb_Title.Text = value;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="title">Set Group Music Title</param>
        /// <param name="displatList">Set DisplayList</param>
        public GroupMedia(string title, List<Media> displatList)
        {
            InitializeComponent();
            Title = title;
            for (int i = displatList.Count - 1; i >= 0; i--)
            {
                MusicRow musicRow = new MusicRow()
                {
                    Location = new Point(0, (displatList.Count - 1 - i) * 75),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    Dock = DockStyle.Bottom
                };
                musicRow.Media = displatList[i];
                panel_Display.Controls.Add(musicRow);
            }
        }
    }
}
