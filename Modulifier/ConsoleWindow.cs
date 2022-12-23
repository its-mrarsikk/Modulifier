using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modulifier
{
    public static class ConsoleWindow
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        /// <summary>
        /// Detaches the calling process from its console
        /// </summary>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.
        /// To get extended error information, call Marshal.GetLastWin32Error.</returns>
        [DllImport("kernel32", SetLastError = true)]
        private static extern bool FreeConsole();
        /// <summary>
        /// Attaches the calling process to the console of the specified process.
        /// </summary>
        /// <param name="dwProcessId">[in] Identifier of the process, usually will be ATTACH_PARENT_PROCESS</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.
        /// To get extended error information, call Marshal.GetLastWin32Error.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);
        /// <summary>Identifies the console of the parent of the current process as the console to be attached.
        /// always pass this with AttachConsole in .NET for stability reasons and mainly because
        /// I have NOT tested interprocess attaching in .NET so dont blame me if it doesnt work! </summary>
        const uint ATTACH_PARENT_PROCESS = 0x0ffffffff;
        /// <summary>
        /// calling process is already attached to a console
        /// </summary>
        const int ERROR_ACCESS_DENIED = 5;
        /// <summary>
        /// Allocate a console if application started from within windows GUI.
        /// Detects the presence of an existing console associated with the application and
        /// attaches itself to it if available.
        /// </summary>
        public static void StartConsole(string entryMsg = "Welcome!")
        {
            AllocConsole();
            AttachConsole(ATTACH_PARENT_PROCESS);
            Console.WriteLine(entryMsg);
        }

        public static void Log(object? obj) => Console.Write(obj?.ToString());

        public static void LogLine(object? obj) => Console.WriteLine(obj?.ToString());

        public static ConsoleKeyInfo ReadKey(bool intercept = false) => Console.ReadKey(intercept);

        public static string? ReadLine()
        {
            Console.Write(">");
            return Console.ReadLine();
        }
    }
}
