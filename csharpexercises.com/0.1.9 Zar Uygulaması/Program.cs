using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._9_Zar_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] yeniZar = new int[2];

            int check = 0;

            do
            {
                Console.WriteLine("\nYeni zar istemek için 'Y' harfine basınız... Çıkmak için herhangi bir tuşa basınız.");
                string start = Console.ReadLine().ToUpper();

                if (start == "Y")
                {
                    ZarÜretici(yeniZar);
                }
                else
                {
                    Console.WriteLine("Çıkış Yaptınız : ");
                    Console.ReadLine();
                    check = 1;
                }

            } while (check == 0);

        }
        static void ZarÜretici(int[] aYeniZar)
        {
            Random rnd = new Random();

            for (int i = 0; i < aYeniZar.Length; i++)
            {
                aYeniZar[i] = rnd.Next(1, 7);
            }

            Console.WriteLine($"Gelen zar : {aYeniZar[0]} - {aYeniZar[1]}");
        }

    }
}

