using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._3.Count_a_Specified_Number_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Write a C# program to count a specified number in a given array of integers. Go to the editor
            // Test Data:
            // Input an integer: 5
            //Sample Output
            //Number of 5 present in the said array: 2

            CountTheNum();
          


            Console.Read();
        }
        static void CountTheNum()
        {
            int[] intNum = new int[10];
            Random rnd = new Random();
            int count = 0;
            int count2 = 0;

            // System fullfill the array
            for (int i = 0; i < intNum.Length; i++)
            {
                intNum[i] = rnd.Next(0, 10);
                Console.Write(intNum[i] + ", ");
            }
            Console.WriteLine("\nPlease write the number you want the system to find: ");
            int num = int.Parse(Console.ReadLine());

            // Counting the desired number in the array and sum pf all the array numbers
            for (int i = 0; i < intNum.Length; i++)
            {
                if (num == intNum[i])
                {
                    count++;
                }
                count2 += intNum[i];
            }

            // Checking the first and the last index whether they are equal
            bool check = true;
            if (intNum[0] == intNum[intNum.Length - 1])
            {

                Console.WriteLine("\nFirst and last elements are equal\n");
            }
            else
            {
                {
                    Console.WriteLine("\nFirst and last elements are NOT equal\n");
                }


                Console.WriteLine("The number of {0} is used {1} times int the string", num, count);
                Console.WriteLine("Sum of the array numbers : " + count2);
            }
        }
        
        
    }

}
