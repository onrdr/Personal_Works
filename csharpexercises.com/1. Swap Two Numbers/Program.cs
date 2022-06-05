using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Swap_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to swap two numbers.

            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}
