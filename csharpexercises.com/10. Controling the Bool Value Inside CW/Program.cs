using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Controling_the_Bool_Value_Inside_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an Integer :");
            int userInPut = int.Parse(Console.ReadLine());

            bool decider1 = true;
            bool decider2 = false;

            if (userInPut % 3 == 0 || userInPut % 7 == 0)
            {
                Console.WriteLine(decider1);
            }
            else
                Console.WriteLine(decider2);

            Console.ReadLine();

            //***IMPORTANT*** :  Aşağıdaki gibi console.writeline içinde de bool kontrol yapılabiliyor. 
            /* 
             
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }

            */
        }
    }
}
