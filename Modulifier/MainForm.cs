using System.Diagnostics;
using System.ComponentModel;
using System;

namespace Modulifier
{
    public partial class MainForm : Form
    {

        private bool debug = false;

        public MainForm()
        {
            InitializeComponent();
        }

        // global events
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

                    // pip/py check
                    if (!Utility.ExistsOnPath("pip")) // pip not installed\not in path
                    {
                        tabControl.SelectedIndex = 0;

                        DialogResult pipinstallagreement = MessageBox.Show(this, "Your computer has no installed pip, or it's not in PATH.\nWould you like to install pip?", "pip not found!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                        if (pipinstallagreement == DialogResult.Yes)
                        {
                            if (!Utility.ExistsOnPath("py")) // python not installed\not in path
                            {
                                DialogResult pyinstalleragreement = MessageBox.Show(this, "Your computer has no installed Python, or it's not in PATH.\nLaunch Python installer to install Python?", "Python not found!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                                if (pyinstalleragreement == DialogResult.Yes)
                                {
                                    if (!File.Exists("./etc/pyins3110.exe")) // installer not in place
                                    {
                                        DetailsMessageBox.ShowDialog(this, $"Bundled Python Installer is renamed or deleted", $"Bundled Python Installer couldn't start. The file was renamed or deleted.\nSee details for further information.",
    $@"If renamed, rename it back to ""pyins3110.exe"". If deleted:

Get a Python 3.11.0 installer at www.python.org/downloads, or a fresh Modulifier at www.github.com/its-mrarsikk/Modulifier/releases.

If you've downloaded Python manually, name the installer ""pyins3110.exe"" and put into (app folder)/etc/.", new("./assets/warn.png"));
                                        return;
                                    }

                                    Process.Start("./etc/pyins3110.exe");
                                    return;
                                }
                                else return;
                            }

                            Process.Start("py", "-m ensurepip --upgrade");
                            return;
                        }
                        else return;
                    }

                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ConsoleWindow.StartConsole();
            // Process.Start(new ProcessStartInfo("title", "Console Window"));
            //ConsoleWindow.LogLine("Hello World!");

        }

        // menu strip
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void aboutBoxToolStripMenuItem_Click(object sender, EventArgs e) => new About().ShowDialog(this);
        private void openConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsoleWindow.StartConsole("Modulifier debug console\n[Version 0.7.0, by its-mrarsikk]");
            writeToolStripMenuItem.Enabled = true;
            openConsoleToolStripMenuItem.Enabled = false;
        }
        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsoleWindow.ReadLine();
        }

        // main menu
        private void mainmenu_releases2_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/releases");
        private void mainmenu_issue2_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/issues");
        private void mainmenu_contribute2_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/fork");
        private void mainmenu_contribute3_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/compare");

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ConsoleWindow.Log(">");
            var s = ConsoleWindow.ReadLine();
            foreach (Control ctrl in Controls)
            {
                ctrl.Text = s;
            }
        }







        // pip

    }
}