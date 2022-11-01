using System.Security.Cryptography.X509Certificates;

namespace Modulifier
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = tabControl.SelectedIndex;

            switch (tab)
            {
                case 0:
                    this.Text = "Modulifier Main Menu";
                    break;
                case 1:
                    this.Text = "Modulifier PIP Installer";
                    break;
            }
        }
    }
}