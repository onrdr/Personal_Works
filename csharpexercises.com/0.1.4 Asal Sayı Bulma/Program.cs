using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._4_Asal_Sayı_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı sayı girsin. Asal olup olamdığını kontrol et. Asalsa sonraki 5 asal sayıyı yazdır.
            // Değilse sadece asal değil diye uyarı ver ve program sonlansın...

            Console.WriteLine("Kontrol etmek istediğiniz sayıyı giriniz : ");
            int num = int.Parse(Console.ReadLine());

            if (PrimeCheck(num))
            {
                Console.WriteLine("{0} is a prime number ", num);
            }
            else
            {
                Console.WriteLine("{0} is  NOT a prime number ", num);

            }

            int count = 0;

            if (PrimeCheck(num))
            {
                while (true)
                {
                    num++;

                    if (PrimeCheck(num) == true)
                    {
                        Console.WriteLine("{0} is the following prime number. ", num);

                        count++;

                        if (count == 5)
                        {
                            break;
                        }
                    }


                }
            }

            Console.ReadLine();
        }
        static bool PrimeCheck(int num1)
        {
            bool durum = true;
            int check = 0;

            for (int i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }

            return durum;
           
        }
       
           
        

    }
}
