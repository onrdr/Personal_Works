

namespace OldVersion
{
    internal class Messages
    {
        public static void Error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Success(string success)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(success);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void CloseSystem()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Application Closing in 3");
            Thread.Sleep(1000);
            Console.Write(" 2");
            Thread.Sleep(1000);
            Console.Write(" 1");
            Thread.Sleep(1000);
        }

    }
}
