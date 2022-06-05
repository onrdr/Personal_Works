using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._2_Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yol1();
            Yol2();
        }
        static void Yol1()
        {
            int[,] arr = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int k = 7; k > i; k--)
                {   //For loop to print spaces
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
        static void Yol2()
        {
            Console.WriteLine("Number of row : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int a = 1;

                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" {0}",a);
                    a = a * (i-k) / (k+1);    

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
