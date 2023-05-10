using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using Windows.Gaming.Input.ForceFeedback;

namespace Modulifier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Console.WriteLine("-- Application Init --\nInitializing components...");
            InitializeComponent();
            Console.WriteLine("Preparing events...");
            PipTabOpened += delegate (object? s, EventArgs e)
            {
                ToggleButtonsEnabled(this.pipTab, false);
            };
            PipFound += delegate (object? s, EventArgs e)
            {
                Console.WriteLine("pipfound");
                ToggleButtonsEnabled(this.pipTab, true);
            };
        }
#pragma warning disable IDE1006
        // global events
        private async void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = tabControl.SelectedIndex;

            switch (tab)
            {
                case 1: // pip
                    // pip/py check
                    OnPipTabOpened();
                    if (!PipManager.isChecked)
                    {
                        Tuple<bool, bool> chk = await PipManager.CheckPipPresence(this);
                        if (chk.Item2) OnPipFound();
                    }
                    else
                    {
                        if (PipManager.isPipPresent) OnPipFound();
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
            string location = Environment.ProcessPath ?? string.Empty
                // removing prefixes
                .Replace("file:///", string.Empty)
                .Replace("\\\\.\\", string.Empty)
                .Replace("\\\\?\\", string.Empty);


            if (string.IsNullOrWhiteSpace(location))
            {
                DetailsMessageBox.Show(this, "Failed to restart", "Location of the executable file couldn't be found.\nPlease look into the details for error details and instructions.",
                    @"At Modulifier.MainForm.restartWithDebugToolStripMenuItem_Click, Environment.ProcessPath returned an empty string.

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

        // events to handle the async changes
        private event EventHandler PipTabOpened;
        private void OnPipTabOpened() => PipTabOpened.Invoke(this, EventArgs.Empty);
        private event EventHandler PipFound;
        private void OnPipFound() => PipFound.Invoke(this, EventArgs.Empty);
#pragma warning restore IDE1006

        // quick utils
        private void ToggleButtonsEnabled(TabPage tab, bool enabled)
        {
            var controls = tab.Controls;
            foreach (Control control in controls)
            {
                if (control != null && control is Button) control.Enabled = enabled;
            }
        }
    }
}