using System.Diagnostics;
using System.Text;

namespace Modulifier
{
    internal static partial class Utility
    {
        internal static bool isDebugMode;

        internal const string DEFAULT_EXCEPTION_INSTRUCTION = "There is a log file in the logs folder.\nPlease follow there and get the latest error log, and share it in a GitHub issue.\nYou can see the links in the Main Menu.\nIf you can't get to the Main Menu, please go to github.com/its-mrarsikk/modulifier/issues/new to create an issue. Thank you.";

        internal static Process? OpenUrl(string url) => Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });

        internal static bool ExistsOnPath(string fileName) => GetFullPath(fileName) != null;

        internal static string GetHighestVersion(string directory, string extension, string[] cutStart, string[] cutEnd)
        {
            string highestVersion = "";
            int[] version = new int[3] { 0, 0, 0 };

            foreach (string file in Directory.GetFiles(directory, extension))
            {
                string filename = file;
                foreach (string startString in cutStart)
                {
                    filename = filename.Replace(startString, "");
                }
                foreach (string endString in cutEnd)
                {
                    filename = filename.Replace(endString, "");
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
                details.AppendLine("\n\n--- INSTRUCTIONS ---\n\n")
                    .AppendLine(instructions);
            }

            return details.ToString();
        }
    }
}