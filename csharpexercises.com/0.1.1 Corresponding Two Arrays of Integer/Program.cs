using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._1_Corresponding_Two_Arrays_of_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    C# program to multiply corresponding elements of two arrays of integers. Go to the editor
            //Sample Output:
            //Array1:[1, 3, -5, 4]
            //Array2:[1, 4, -5, -2]
            //Multiply corresponding elements of two arrays:
            //1 12 25 - 8

            Console.Write("Write a number for length of the string : ");
            int i = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[i];
            int [] arr2 = new int[i];
            int [] result = new int[i];

            

            // Out Put the strings
            Console.Write("First String : ");

            for (int k = 0; k < arr1.Length; k++)
            {
                Console.Write(+arr1[k] + ", ");               
            }
            Console.Write("\nSecond String : ");

            for (int k = 0; k < arr1.Length; k++)
            {
                Console.Write(+arr2[k] + ", ");
            }

            //Multiplication
            for (int j = 0; j < arr2.Length; j++)
            {
               result[j] = arr1[j] * arr2[j];
            }
            Console.Write("\nResult String is : ");

            for (int j = 0; j < result.Length; j++)
            {
                Console.Write(result[j]+", ");
            }

            Console.ReadLine();
        }
    }
}
