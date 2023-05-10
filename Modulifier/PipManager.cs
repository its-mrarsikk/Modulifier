using System.Diagnostics;

namespace Modulifier 
{

    internal static class PipManager
    {
        const string PYTHON_NOT_FOUND_ERROR = "Python not found: it's not installed, or not in PATH. Install a version of Python, or add an existing one's files into PATH.";
        const string PYTHON_NOT_FOUND_ERROR_TITLE = "Python not found!";
        const string PIP_NOT_FOUND_ERROR = "PIP not found: it's not installed, or not in PATH. Try to install PIP?";
        const string PIP_NOT_FOUND_ERROR_TITLE = "PIP not found!";

        internal static bool isPythonPresent;
        internal static bool isPipPresent;
        internal static bool isChecked = false;

        /// <returns>Presence of Python and pip. Tuple's 1st item represents the Python presence, the 2nd - pip presence.</returns>
        internal async static Task<Tuple<bool, bool>> CheckPipPresence(Form? dialogParent)
        {
            dialogParent ??= MainForm.ActiveForm;
            if (!Utility.ExistsOnPath("python.exe --version", true)) // python is not installed or not in path.
            {
                MessageBox.Show(dialogParent, PYTHON_NOT_FOUND_ERROR, PYTHON_NOT_FOUND_ERROR_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                isPythonPresent = false;
                isPipPresent = false;
            }
            if (!Utility.ExistsOnPath("python -m pip --version", true))
            {
                isPythonPresent = true;
                DialogResult pipinstalldialogresult = MessageBox.Show(dialogParent, PIP_NOT_FOUND_ERROR, PIP_NOT_FOUND_ERROR_TITLE,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (pipinstalldialogresult == DialogResult.Yes)
                {
                    Tuple<bool, string> result = await TryInstallPip();
                    if (result.Item1 == false) // probably failed
                    {
                        MessageBox.Show($"Failed to install pip: {result.Item2}");
                        isPipPresent = false;
                    }
                    else isPipPresent = true;
                }
                else isPipPresent = false;
            }
            isPythonPresent = true;
            isPipPresent = true;
            isChecked = true;
            return new(isPythonPresent, isPipPresent);
        }

        private static async Task<Tuple<bool, string>> TryInstallPip(bool showConsoleOutput = true /* i plan to make a progressbar window, so soon the default will be false
                                                                                        * as a more user-friendly ui is present */)
        {
            Process pipinst = new() { // the pip installation process; it can't error because of no python; it will be called only when python is present when checked in CheckPipPresence
                StartInfo = new ProcessStartInfo { FileName = "python.exe", Arguments = "-m ensurepip", UseShellExecute = false, CreateNoWindow = !showConsoleOutput, RedirectStandardError = true }
            };
            string stderr = string.Empty;

            await Task.Run(() =>
            {
                pipinst.Start();
                stderr = pipinst.StandardError.ReadToEnd();
                pipinst.Dispose();
            });

            // returning
            static bool LineNotEmpty(string line) => !string.IsNullOrWhiteSpace(line); // predicate
            static bool LineEmpty(string line) => !LineNotEmpty(line);

            List<string> stderr_lines = stderr.Split(new string[] { "\n", "\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            stderr_lines.RemoveAll(LineEmpty); // remove empty lines
            Tuple<bool, string> result = new(true, "SUCCESS"); // first assertment - operation succeeded; otherwise will be changed appropriately

            if (stderr_lines.Count > 0)
            {
                result = new(false, stderr_lines.FindLast(LineNotEmpty) ?? "Unknown error");
                Console.WriteLine($"Pip installation failed. Stderr:\n{stderr}");
            }

            return result;
        }
    }
}