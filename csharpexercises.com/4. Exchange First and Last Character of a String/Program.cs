using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Exchange_First_and_Last_Character_of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to create a new string from a given string where the first and last characters will change their positions.

            Console.WriteLine(First_last("w3resource"));
            Console.WriteLine(First_last("Python"));
            Console.WriteLine(First_last("xy"));

            Console.ReadLine();
        }
        public static string First_last(string ustr)
        {

            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
