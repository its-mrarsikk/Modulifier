using System.Diagnostics;
using System.Drawing.Imaging;

namespace Modulifier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Console.WriteLine("-- Application Init --\nInitializing components...");
            InitializeComponent();
        }

        // global events
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = tabControl.SelectedIndex;

            switch (tab)
            {
                case 0: // Main menu tab selected
                    Text = "Modulifier Main Menu";
                    break;

                case 1:
                    Text = "Modulifier PIP Manager"; // pip tab selected
                    // pip/py check
                    if (!Utility.ExistsOnPath("python.exe")) // python is not installed or not in path.
                    {
                        tabControl.SelectedIndex = 0;
                        DialogResult pyinstalldialogresult = MessageBox.Show(this, "Python not found: it's not installed, or not in PATH or App Paths. Launch Python installer?", "Python not found!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        switch (pyinstalldialogresult)
                        {
                            case DialogResult.Yes:
                                string installer = "./etc/" +
                                    Utility.GetHighestVersion("./etc", ".exe", new string[] { "pyins" }, Array.Empty<string>());
                                try
                                {
                                    Process.Start(new ProcessStartInfo { FileName = installer, UseShellExecute = true });
                                }
                                catch (Win32Exception ex)
                                {
                                    DetailsMessageBox.ShowDialog(this, "Error launching installer",
                                        "Seems like there isn't a Python installer. Try installing Python manually.", Utility.DetailsFromException(ex, "Try installing Python manually."), Utility.GetFromAssetsOrEmpty("warn"));
                                    throw;
                                }
                                break;

                            case DialogResult.No:
                                return;
                        }
                    }
                    else // python is there, may continue
                    {
                        Button[] buttons =
                        {
                            pip_packages_install,
                            pip_packages_download,
                            pip_packages_uninstall,
                            pip_other_update,
                            pip_other_cmd
                        };

                        if (!Utility.ExistsOnPath("pip", true))
                        {
                            tabControl.SelectedIndex = 0;

                            DialogResult pipinstalldialogresult = MessageBox.Show(this, "PIP not found: it's not installed, or not in PATH or App Paths. Launch PIP installer?", "PIP not found!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            switch (pipinstalldialogresult)
                            {
                                case DialogResult.Yes:
                                    Process.Start(new ProcessStartInfo { FileName = "python.exe", Arguments = "-m ensurepip", UseShellExecute = false });
                                    break;

                                case DialogResult.No:
                                    return;
                            }
                        }
                        else foreach (var button in buttons) { button.Enabled = true; }
                    }
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // some tests
            new PipInstall().Show();
            // MessageBox.Show(this, Logger.GetSystemInfo());
            // actual behaviour
            Console.WriteLine("Form loaded.");
            Console.WriteLine("\n-- Runtime --");
        }

#pragma warning disable IDE1006
        // main menu
        private void mainmenu_releases2_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/releases");

        private void mainmenu_issue2_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/issues");

        private void mainmenu_contribute2_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/fork");

        private void mainmenu_contribute3_Click(object sender, EventArgs e) =>
            Utility.OpenUrl(@"https://github.com/its-mrarsikk/Modulifier/compare");

        // menu strip
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void aboutBoxToolStripMenuItem_Click(object sender, EventArgs e) => new About().ShowDialog(this);

        private void restartWithDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            string location = Environment.ProcessPath
                // removing prefixes
                .Replace("file://", string.Empty)
                .Replace("\\\\.\\", string.Empty)
                .Replace("\\\\?\\", string.Empty);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            if (string.IsNullOrWhiteSpace(location))
            {
                DetailsMessageBox.Show(this, "Failed to restart", "Location of the executable file couldn't be found.\nPlease look into the details for error details and instructions.",
                    @"At Modulifier.MainForm.restartWithDebugToolStripMenuItem_Click:106-110, Assembly.GetEntryAssembly()?.Location returned an empty string.

--- INSTRUCTIONS ---

To restart Modulifier in Debug mode manually, follow these steps:
1. Exit Modulifier.
2. Open CMD or PS.
3. Navigate to the Modulifier install directory.
4. Execute the following command:
	Modulifier.exe -d
	OR
	Modulifier.exe --debug
5. After these steps, Modulifier will be started with Debug.", new("./assets/warn.png"));
                return;
            }

            Application.Exit();
            try
            {
                Process.Start(new ProcessStartInfo { FileName = location, Arguments = "--debug", UseShellExecute = true });
            }
            catch (Win32Exception ex)
            {
                DetailsMessageBox.Show(this, "Failed to restart", "Failed to start the application.\nPlease look into the details for error details and instructions.",
                    Utility.DetailsFromException(ex, Utility.DEFAULT_EXCEPTION_INSTRUCTION), new("./assets/warn.png"));
                return;
            }
        }

        // pip
        private void pip_packages_install_Click(object sender, EventArgs e)
        {
            // new PipInstall().Show();
            // ^ this one is commented coz i still test it
            // so, todo: finish pipinstall and uncomment this.
        }
#pragma warning restore IDE1006
    }
}