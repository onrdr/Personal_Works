using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program that takes a number as input and print its multiplication table


            Console.WriteLine("Hangi Sayının Çarpım Tablosunu İstiyorsun: ");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = " + (userInput * i), userInput, i);
            }
            
            Console.ReadLine();
        }
    }
}
