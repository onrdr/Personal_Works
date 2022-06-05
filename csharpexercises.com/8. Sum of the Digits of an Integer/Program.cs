using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_of_the_Digits_of_an_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İnput an Integer");
            int userInPut = int.Parse(Console.ReadLine());

            int sum = 0;


            while (userInPut != 0)
            {
                sum += userInPut % 10;
                userInPut /= 10;
            }

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
