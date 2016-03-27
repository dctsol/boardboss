using System.Windows.Forms;

namespace BOARDBoss.Presentation
{
    public partial class AboutApp : Form
    {
        public AboutApp()
        {
            InitializeComponent();

            AppName.Text = Application.ProductName;
            AppVersion.Text = Application.ProductVersion;
        }
    }
}
