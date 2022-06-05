using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.First_Character_is_Added_Front_and_End_of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back
            string str;
            int l = 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);

                Console.ReadLine();
            }
        }
    }
}
