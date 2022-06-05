using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._5_Dizideki_En_Büyük_Asal_Sayıyı_Bul
{
    internal class Program
    {
        /*
         * 20 elemanlı bir diziye 0-100 arası rastgele sayılar atarak 
         * bu dizi içinde bulunan en büyük çift sayıyı metot kullanarak bulacağız. 
         * Örneğimizde rastgele girişi yapılan sayılardan hiçbirinin çift olmaması durumunda 
         * “Dizide çift sayı bulunamadı” mesajı verilmesi sağlanmıştır.
         */
        static void Main(string[] args)
        {
            int[] arrInt = new int[20];

            Random rnd = new Random();
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = rnd.Next(1, 100);
                Console.WriteLine("{0}. Sayı : {1}", i + 1, arrInt[i]);
            }
            
            int biggestNum = BiggestCheck(arrInt);

            if (biggestNum != 0)
            {
                Console.WriteLine("\nThe biggest number is : {0}",biggestNum);
            }
            else
            {
                Console.WriteLine("There is no even number in this array !!!");
            }
            

            Console.ReadLine();
        }
        static int BiggestCheck(int[]_arrInt)
        {
            int _biggestNum = 0;

            for (int i = 0; i < _arrInt.Length; i++)
            {
                if (_biggestNum < _arrInt[i] && _arrInt[i] % 2 == 0)
                {
                    _biggestNum = _arrInt[i]; 
                }
            }
            return _biggestNum;  
        }
        
    }
}
