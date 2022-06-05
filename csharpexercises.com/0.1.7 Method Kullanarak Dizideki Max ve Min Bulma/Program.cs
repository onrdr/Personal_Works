using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._7_Method_Kullanarak_Dizideki_Max_ve_Min_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rnd = new Random();

            Console.WriteLine("Dizideki Üretilen Sayılar : ");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 100);
                Console.Write(dizi[i] + ", ");
            }
            Console.WriteLine("\nDizideki max sayı : {0}", Max(dizi));
            Console.WriteLine("Dizideki max sayı : {0}", Min(dizi));

            Console.ReadLine();
        }
        static int Max(int[] _dizi)
        {
            int maxNum = _dizi.Max();
            return maxNum;
        }
        static int Min(int[] _dizi)
        {
            int minNum = _dizi.Min();
            return minNum;
        }
    }
}
