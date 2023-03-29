global using Console = Modulifier.Utility.Console;
using System.Runtime.InteropServices;

namespace Modulifier
{
    internal static partial class Utility
    {
        internal static class ConsoleControl
        {
            const string DEFAULT_INIT_MSG = "Modulifier Debug Console\n(c) its-mrarsikk. 2023";
            const string DEFAULT_TITLE = "Modulifier Debug Console";
            public static bool ConsoleOpened { get; private set; } = false;

            // http://msdn.microsoft.com/en-us/library/ms681944(VS.85).aspx
            /// <summary>
            /// Allocates a new console for the calling process.
            /// </summary>
            /// <returns>nonzero if the function succeeds; otherwise, zero.</returns>
            /// <remarks>
            /// A process can be associated with only one console,
            /// so the function fails if the calling process already has a console.
            /// </remarks>
            [DllImport("kernel32.dll", SetLastError = true)]
            static extern int AllocConsole();

            // http://msdn.microsoft.com/en-us/library/ms683150(VS.85).aspx
            /// <summary>
            /// Detaches the calling process from its console.
            /// </summary>
            /// <returns>nonzero if the function succeeds; otherwise, zero.</returns>
            /// <remarks>
            /// If the calling process is not already attached to a console,
            /// the error code returned is ERROR_INVALID_PARAMETER (87).
            /// </remarks>
            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern int FreeConsole();

            /// <summary>
            /// Sets the title of the console window.
            /// </summary>
            /// <param name="lpConsoleTitle">The new title for the console window.</param>
            /// <returns>If the function succeeds, the return value is true. If the function fails, the return value is false.</returns>
            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            static extern bool SetConsoleTitle(string lpConsoleTitle);

            /// <summary>
            /// Sets the console control handler.
            /// </summary>
            /// <param name="HandlerRoutine">The delegate for the console control handler.</param>
            /// <param name="Add">Specifies whether the console control handler is to be added or removed.</param>
            /// <returns>Returns a Boolean value indicating success or failure.</returns>
            /// <remarks>
            /// This method sets the control handler for the console to the specified delegate. If Add is true,
            /// the delegate is added as a control handler, otherwise it is removed. The ConsoleCtrlDelegate must
            /// return a Boolean value indicating whether it has handled the control event.
            /// </remarks>
            [DllImport("kernel32.dll")]
            static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);

            /// <summary>
            /// The delegate for the console control handler.
            /// </summary>
            /// <param name="dwCtrlType">The type of console control event.</param>
            /// <returns>Returns a Boolean value indicating whether the control event has been handled.</returns>
            delegate bool ConsoleCtrlDelegate(int dwCtrlType);

            /// <summary>
            /// The console control handler method.
            /// </summary>
            /// <param name="ctrlType">The type of console control event.</param>
            /// <returns>Returns a Boolean value indicating whether the control event has been handled.</returns>
            static bool ConsoleCtrlHandler(int ctrlType)
            {
                switch (ctrlType)
                {
                    case 0: // CTRL_C_EVENT
                    case 1: // CTRL_BREAK_EVENT
                    case 2: // CTRL_CLOSE_EVENT
                        Console.WriteLine($"<CTRL {ctrlType}: EXIT>");
                        return true;
                    default: // any other ctrl
                        Console.WriteLine($"<CTRL {ctrlType}: DEFAULT>");
                        return false;
                }
            }



            /// <summary>
            /// Initiates the console by calling <see cref="AllocConsole()"/> (kernel32.dll) and displaying an init message.
            /// </summary>
            /// <param name="message">The init message to display.</param>
            /// <returns>nonzero if the function succeeds; otherwise, zero.</returns>
            /// /// <remarks>
            /// If the calling process is not already attached to a console,
            /// the error code returned is ERROR_INVALID_PARAMETER (87).
            /// </remarks>
            internal static int InitConsole(string message = DEFAULT_INIT_MSG, string title = DEFAULT_TITLE)
            {
                int err = AllocConsole();
                if (err != 0)
                {
                    ConsoleOpened = true;
                    SetConsoleTitle(title);
                    SetConsoleCtrlHandler(new(ConsoleCtrlHandler), true);
                    System.Console.WriteLine(message);
                }
                return err;
            }
        }
    }
}