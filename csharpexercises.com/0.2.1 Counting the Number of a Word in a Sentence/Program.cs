using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._1_Counting_the_Number_of_a_Word_in_a_Sentence
{
    class program
    {
        public static void Main()
        {
            string s1;
            Console.WriteLine("Enter the String : ");
            s1 = Console.ReadLine();
            Console.WriteLine(counting.CountStringOccurrences(s1, "the"));
            Console.ReadLine();
        }
    }
    public static class counting
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
