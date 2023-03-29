using System.Text;
using System.Management;

namespace Modulifier
{
    internal static class Logger
    {
        internal static string logsFolder = @"%localappdata%\its-mrarsikk\Modulifier\Logs\";

        // util
        private static string GetTimestamp()
        {
            StringBuilder s = new("[");
            s.Append($"{DateTime.Now.ToString("G")} (");

            TimeSpan utcOffset = TimeZoneInfo.Local.GetUtcOffset(DateTimeOffset.Now);
            s.Append("GMT+" + utcOffset.ToString(@"hh\:mm") + ")]");

            return s.ToString();
        }

        internal static string GetSystemInfo()
        {
            return null;
        }
        // loggin'
    }
}
