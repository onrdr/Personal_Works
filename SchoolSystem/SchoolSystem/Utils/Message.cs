using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Utils
{
    internal class Message
    {
        public static void Error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Success(string error)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(error);
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
