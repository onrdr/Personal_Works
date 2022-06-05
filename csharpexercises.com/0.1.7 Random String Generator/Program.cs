using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._7_Random_String_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object of random class
            Random rnd = new Random();

            // Choosing the size of string
            // Using Next() string
            int stringlen = rnd.Next(1, 10);
            int randValue;
            string str = " ";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                // Generating a random number.
                randValue = rnd.Next(0, 26);

                // Generating random character by converting the random number into character.

                letter = Convert.ToChar(randValue + 65);

                // Appending the letter to string.
                str += letter;
            }
            Console.Write("Random String : " + str);

            Console.ReadLine();
        }
    }
}
