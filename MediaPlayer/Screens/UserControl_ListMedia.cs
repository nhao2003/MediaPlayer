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
        public string Title
        {
            get => lb_Title.Text;
            set
            {
                lb_Title.Text = value;
            }
        }

        private List<Media> _listMedia;
        /// <summary>
        /// Get or Set List Media
        /// </summary>
        public List<Media> ListMedia {
            get => _listMedia??(_listMedia = new List<Media>());
            set
            {
                pn_Display.Controls.Clear();
                _listMedia = value;
                GroupMedia group = new GroupMedia("A", _listMedia)
                {
                    Dock = DockStyle.Top
                };
                pn_Display.Controls.Add(group);
            }
        }

        public UserControl_ListMedia()
        {
            InitializeComponent();
        }

        private void cb_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ví dụ sort
            pn_Display.Controls.Clear();
            GroupMedia group = new GroupMedia("A", ListMedia)
            {
                Dock = DockStyle.Top
            };
            GroupMedia gp = new GroupMedia("B", ListMedia)
            {
                Dock = DockStyle.Top
            };
            pn_Display.Controls.Add(group);
            pn_Display.Controls.Add(gp);
        }
    }
}
