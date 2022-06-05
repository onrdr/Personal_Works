using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Remove_a_Character_from_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program remove specified a character from a non-empty string using index of a character.


            Console.WriteLine("Lütfen Kelimenizi Giriniz : ");
            string word = Console.ReadLine();

            Console.WriteLine("Kaçıncı Harfi Çıkarmak İstediğinizi Giriniz: ");
            int removeWord = int.Parse(Console.ReadLine());

            Console.WriteLine(Remove_char(word, removeWord));

            Console.ReadLine();

        }
        public static string Remove_char(string str, int n)
        {
            return str.Remove(n, 1);
            
        }

        // *** Bu şekilde return c.Remove(i)  içine sadece i yazarsak ondan sonraki bütün değerleri siler.
        //Ama yukardaki gibi  return c.Remove(i, 1) yazarsan 1 demek i den sonraki sadece 1 harfi sil demek. 

        //public static string Remove_char(string c, int i)
        //{
        //    return c.Remove(i);
        //}
    }

}
