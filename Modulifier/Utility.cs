using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace Modulifier
{
    internal static partial class Utility
    {
        internal static readonly Dictionary<string, Bitmap> assets = new(new KeyValuePair<string, Bitmap>[]
        {
            // Windows native icons
            new("warning", ExtractIconFromDllExe("imageres.dll", 079)),
            new("error", ExtractIconFromDllExe("imageres.dll", 093)),

            // App assets
            new("add", new(@".\assets\add.png")),
            new("logo-ico", new(@".\assets\logo.ico")),
            new("logo-png", new(@".\assets\logo.png")),
            new("py", new(@".\assets\py-ic.png")),
            new("welcome", new(@".\assets\welcome-ic.png")),
            new("begin-install", new(@".\assets\begin_install.png")),
            new("stop-install", new(@".\assets\stop_install.png"))
        });

        internal static bool isDebugMode;

        internal const string DEFAULT_EXCEPTION_INSTRUCTION =
            "There is a log file in the logs folder.\nPlease follow there and get the latest error log, and share it in a GitHub issue.\nYou can see the links in the Main Menu.\nIf you can't get to the Main Menu, please go to github.com/its-mrarsikk/modulifier/issues/new to create an issue. Thank you.";

        internal static Process? OpenUrl(string url) => Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });

        internal static bool ExistsOnPath(string fileName, bool useProcessStart = false)
        {
            if (useProcessStart)
            {
                bool exists = true;
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = false, CreateNoWindow = true });
                }
                catch (Win32Exception) { exists = false; }
                return exists;
            }

            return GetFullPath(fileName) != null;
        }

        internal static string GetHighestVersion(string directory, string extension, string[] cutStart, string[] cutEnd)
        // THIS METHOD IS WRITTEN 95% BY AI.
        {
            string highestVersion = "";
            int[] version = new int[3] { 0, 0, 0 };

            foreach (string file in Directory.GetFiles(directory.ToLower(), extension.ToLower()))
            {
                string filename = file.ToLower();
                foreach (string startString in cutStart)
                {
                    filename = filename.Replace(startString.ToLower(), "");
                }
                foreach (string endString in cutEnd)
                {
                    filename = filename.Replace(endString.ToLower(), "");
                }
                string[] parts = filename.Split('.')[0].Split('_')[0].Split('-')[0].Split('.');

                int i = 0;
                foreach (string part in parts)
                {
                    int v = int.Parse(part);
                    if (v > version[i])
                    {
                        version[i] = v;
                        highestVersion = file;
                    }
                    i++;
                }
            }

            return highestVersion;
        }

        internal static string? GetFullPath(string fileName)
        {
            if (File.Exists(fileName))
            {
                return Path.GetFullPath(fileName);
            }
            string? values = Environment.GetEnvironmentVariable("PATH");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            foreach (var path in values.Split(Path.PathSeparator))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                {
                    return fullPath;
                }
            }
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            return null;
        }

        internal static string GetCurrentMethodName()
        {
            StackFrame f = new(1);
            return $"{f.GetMethod()?.DeclaringType}.{f.GetMethod()?.Name}";
        }

        internal static string DetailsFromException(Exception e, string? instructions = null)
        {
            StringBuilder details = new($"--- EXCEPTION DETAILS FOR {e.GetType().Name} ---\n\n");
            details.AppendLine("* Exception Message")
                .AppendLine(e.Message)
                .AppendLine("\n* Stack Trace")
                .AppendLine(e.StackTrace)
                .AppendLine("\n* HRESULT")
                .AppendLine(e.HResult.ToString());
            if (e is ArgumentException argE) details.AppendLine("\n* Argument Name")
                .AppendLine(argE.ParamName);
            details.AppendLine("\n");

            if (e.InnerException != null)
            {
                Exception inner = e.InnerException;
                details.AppendLine($"--- EXCEPTION DETAILS FOR INNER {inner.GetType().Name} ---\n\n");
                details.AppendLine("* Exception Message")
                    .AppendLine(inner.Message)
                    .AppendLine("\n* Stack Trace")
                    .AppendLine(inner.StackTrace)
                    .AppendLine("\n* HRESULT")
                    .AppendLine(inner.HResult.ToString());
                if (inner is ArgumentException argEi) details.AppendLine("\n* Argument Name")
                    .AppendLine(argEi.ParamName);
            }

            if (instructions != null)
            {
                details.AppendLine("\n--- INSTRUCTIONS ---\n")
                    .AppendLine(instructions);
            }

            return details.ToString();
        }

        internal static Bitmap ExtractIconFromDllExe(string file, int index)
        {
            [DllImport("shell32.dll")]
            static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

            IntPtr hIcon = ExtractIcon(IntPtr.Zero, file, index);
            Icon icon = Icon.FromHandle(hIcon);
            return icon.ToBitmap();
        }

        internal static Bitmap GetFromAssetsOrEmpty(string key) =>
            assets.GetValueOrDefault(key) ?? new(1, 1, PixelFormat.Format32bppArgb);
    }
}