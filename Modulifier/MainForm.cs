using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.CodeDom;
using System.Diagnostics;
using System.ComponentModel;

namespace Modulifier
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        // utility
        private Process? OpenUrl(string url) => Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = tabControl.SelectedIndex;

            switch (tab)
            {
                case 0: // Main menu tab selected
                    this.Text = "Modulifier Main Menu";
                    break;
                case 1:
                    this.Text = "Modulifier PIP Manager"; // pip tab selected

                    Process? pip = Process.Start("pip", "-h");
                    if (pip == null) // pip hasn't started
                    {
                        DialogResult pipinstallagreement = MessageBox.Show(this, "Your computer has no installed pip.\nWould you like to install pip?", "pip not installed!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        if (pipinstallagreement == DialogResult.Yes)
                        {
                            Process? ensurepip = Process.Start("py", "-m ensurepip --upgrade");
                            if (ensurepip == null) // py not installed
                            {
                                DialogResult pyinstalleragreement = MessageBox.Show(this, "ensurepip has failed to start\nLaunch Python installer to repair or install Python?", "ensurepip failure!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                if (pyinstalleragreement == DialogResult.Yes)
                                {
                                    try
                                    {
                                        Process.Start("./etc/pyins3110.exe");
                                    }
                                    catch (Win32Exception exception)
                                    {

                                    }
                                }
                            }
                        }
                    }

                    break;
            }
        }

        // menu strip
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void aboutBoxToolStripMenuItem_Click(object sender, EventArgs e) => new About().ShowDialog(this);

        // main menu
        private void mainmenu_releases2_Click(object sender, EventArgs e) => OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/releases");
        private void mainmenu_issue2_Click(object sender, EventArgs e) => OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/issues");
        private void mainmenu_contribute2_Click(object sender, EventArgs e) => OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/fork");
        private void mainmenu_contribute3_Click(object sender, EventArgs e) => OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/compare");

        // pip

    }
}