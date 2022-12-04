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
    public partial class CategoryPanel : UserControl
    {
        public CategoryPanel()
        {
            InitializeComponent();
        }
        public void InitializeCategory(string category)
        {
            label1.Text = category;   
        }
    }
}
