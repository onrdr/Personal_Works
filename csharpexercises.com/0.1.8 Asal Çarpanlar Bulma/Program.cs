using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._8_Asal_Çarpanlar_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayılar = new ArrayList();

        Here:
            Console.WriteLine("\nEnter a number : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= userInput; i++)
            {
                while (userInput % i == 0)
                {
                    int bölüm = userInput / i;
                    userInput = bölüm;
                    bool flag = asalSayılar.Contains(i);

                    if (flag == false)
                    {
                        asalSayılar.Add(i);
                    }
                    if (userInput == 1)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < asalSayılar.Count; i++)
            {
                Console.Write(asalSayılar[i] + ", ");
            }
            System.Threading.Thread.Sleep(3000);
            goto Here;
        }
    }

}
