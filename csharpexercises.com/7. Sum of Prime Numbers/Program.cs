using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_of_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hangi Sayıya Kadar Asal Sayıları Toplayalım? : ");
            //int sayiyaKadar = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //for (int i = 2; i <= sayiyaKadar; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        if (i % j != 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();


            int p, s = 0;

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List of Prime Numbers ");


            for (int i = 2; i <= num; i++)
            {
                p = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        p = 0;
                        break;
                    }
                }
                if (p == 1)
                {
                    Console.Write(i + ", ");
                    s += i;
                }
            }
            Console.WriteLine("\nSum of prime numbers: " + s);

            Console.ReadLine();
        }
    }
}
