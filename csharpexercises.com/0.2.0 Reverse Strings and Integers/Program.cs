using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._0_Reverse_Strings_and_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RevNum();       // Reverse The Number Given by the User

            //RevString();    // Reverse The String Given by the User

            string abc = "Hello how   are      you ? ";
            
            Console.WriteLine(abc.Replace(' ','_'));

            Console.ReadLine();
        }
        static void RevNum()
        {
            int rem, revNum = 0;

            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num /= 10;
            }
            Console.WriteLine(revNum);
        }
        static void RevString()
        {
            string revStr = string.Empty;
            
            Console.WriteLine("Please Enter a String : ");
            string userStr = Console.ReadLine();

            for (int i = userStr.Length - 1; i >= 0; i--)
            {
                revStr += userStr[i];
            }
            Console.WriteLine(revStr);
        }
    }
}

