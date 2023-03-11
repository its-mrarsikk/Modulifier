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
            MainForm? f = null;

            try
            {
                if (args.Length > 0)
                {
                    Utility.isDebugMode = args[0].ToLower() == "--debug" || args[0].ToLower() == "-d";
                }

                f = Bootstrap();

                Application.Run(f);
            }
            catch (Exception e)
            {
                f ??= new();
                DetailsMessageBox.Show(f, "Unexpected error", "Modulifier met an unexpected error.\nPlease go to the details to learn more.",
                    Utility.DetailsFromException(e, Utility.DEFAULT_EXCEPTION_INSTRUCTION), new("./assets/error.png"));
            }
        }

        private static MainForm Bootstrap()
        {
            if (Utility.isDebugMode) Utility.ConsoleControl.InitConsole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            return new();
        }
    }
}