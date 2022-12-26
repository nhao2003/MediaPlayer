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
