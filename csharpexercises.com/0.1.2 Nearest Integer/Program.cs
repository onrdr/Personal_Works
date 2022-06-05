using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._2_Nearest_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir reference sayı giriniz : ");
            int refnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ilk sayıyı girin :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı girin :");
            int num2 = int.Parse(Console.ReadLine());

            int value1 = Math.Abs(refnum - num1);   // Mutlak Değer alma işlemi
            int value2 = Math.Abs(refnum - num2);

            if (value1>value2)
            {
                Console.WriteLine("Reference Sayınıza en yakın sayı : "+num2);
            }
            else if (value1 < value2)
            {
                Console.WriteLine("Reference Sayınıza en yakın sayı : " + num1);

            }
            else
            {
                Console.WriteLine("Girdiğiniz iki sayı da reference sayıya eşit uzaklıktadır");
            }

            Console.ReadLine();
        }
    }
}
