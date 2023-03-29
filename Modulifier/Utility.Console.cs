namespace Modulifier
{
    internal static partial class Utility
    {
        internal static class Console
        {

            public static bool Write(object message)
            {
                if (!ConsoleControl.ConsoleOpened) return false;
                System.Console.Write(message.ToString());
                return true;
            }

            public static bool WriteLine(object? message = null) => Write(((message?.ToString()) ?? "") + "\n");
        }
    }
}