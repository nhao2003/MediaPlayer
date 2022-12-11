using MediaPlayer.Items;
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
using TagLib;

namespace MediaPlayer.Widgets
{
    public partial class UserControl_ListMedia : UserControl
    {
        public delegate void Send(string path, MediaTypes mediaTypes);
        public Send sendPath;
        /// <summary>
        /// Get or Set UserControl MediaList Title
        /// </summary>
        public String Title
        {
            get => lb_Title.Text;
            set => lb_Title.Text = value;
        }
        /// <summary>
        /// Get or Set List Media
        /// </summary>
        private List<Media> ListMedia = new List<Media>();
        public UserControl_ListMedia()
        {
            InitializeComponent();
            GroupMedia group = new GroupMedia("Dummy 1", MediaHelpers.listSongs)
            {
                Dock = DockStyle.Top
            };
            GroupMedia gp = new GroupMedia("Dummy 2", MediaHelpers.listSongs)
            {
                Dock = DockStyle.Top
            };
            pn_Display.Controls.Add(group);
            pn_Display.Controls.Add(gp);
        }
    }
}
