using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._6_Method_Kullanarak_Dizi_Toplam_ve_Ortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[20];
            Random random = new Random();

            Console.WriteLine("üretilen Sayılar : ");
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılar[i] = random.Next(1, 100);
                Console.Write(sayılar[i] + " ,");
            }

            // Toplam methodunu private yaptım ve statiği kaldırdım. Sadece denemek için. It seems static olmadan new obj olarak tanımlamak lazım.
            Program t = new Program();
            int sum = t.Toplam(sayılar);
            Console.WriteLine("\nToplam : {0}", sum);

            // Average methodu da static olarak aldım. Üstteki methodla karşılaştırınce static kullanmak daha kısa ve kolay.
            Console.WriteLine("Ortalama : {0}", Average(sayılar));


            Console.ReadLine();
        }
        private int Toplam(int[] _sayılar)
        {
            int sum = 0;

            for (int i = 0; i < _sayılar.Length; i++)
            {
                sum += _sayılar[i];

            }
            return sum;
        }
        static double Average(int[] _sayılar)
        {
            int sum = 0;


            for (int i = 0; i < _sayılar.Length; i++)
            {
                sum += (int)_sayılar[i];

            }
            double average = (double)sum / (_sayılar.Length);
            return average;
        }
    }
}
