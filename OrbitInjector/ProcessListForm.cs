using System.Windows.Forms;

namespace OrbitInjector
{
    public partial class ProcessListForm : Form
    {
        public ProcessListForm()
        {
            InitializeComponent();
            this.Controls.Add(new ProcessListUC());
        }
    }
}

