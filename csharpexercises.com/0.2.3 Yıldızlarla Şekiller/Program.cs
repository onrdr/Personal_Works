using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._3_Yıldızlarla_Şekiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                   /\
                  /**\  
                 /****\
                 \****/
       //         \**/
       //          \/
           
            #region
            Console.Write("Sayı Girin : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                // Boşluk için loop
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                // Yıldız için loop
                for (int k = 0; k < 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                Console.WriteLine("");
            }

            for (int i = num; i >= 0; i--)
            {
                // Boşluk için loop


                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                // Yıldız için loop
                for (int k = 0; k < 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("/");

                Console.WriteLine();
            }

            Console.ReadLine();
            #endregion

        }
    }
}
