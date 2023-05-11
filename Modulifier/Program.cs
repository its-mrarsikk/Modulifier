namespace Modulifier
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Bootstrap();
            MainForm? f = null;

            AppDomain.CurrentDomain.UnhandledException += delegate (object s, UnhandledExceptionEventArgs e)
            {
                DetailsMessageBox.Show(null, "Unexpected error", "Modulifier met an unexpected error.\nPlease go to the details to learn more.",
            Utility.DetailsFromException((Exception)e.ExceptionObject, Utility.DEFAULT_EXCEPTION_INSTRUCTION), Utility.GetFromAssetsOrEmpty("error"));
            };

            f ??= new();
            if (args.Length > 0)
            {
                Utility.IsDebugMode = args[0].ToLower() == "--debug" || args[0].ToLower() == "-d"; // check cmd args
            }

            f = new();

            Application.Run(f);
        }

        private static void Bootstrap()
        {
            if (Utility.IsDebugMode) Utility.ConsoleControl.InitConsole();

            Console.WriteLine("\n-- Early Init --\nEnabling visual styles...");
            Application.EnableVisualStyles();

            Console.WriteLine("Initializing compatible text rendering...");
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Initializing high DPI mode...");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Console.WriteLine();
        }
    }
}