using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Solution.RomanToInt("MMDCIV")} and {Solution.RomanToInt("XIX")}");

            Console.ReadLine();

        }

    }
    public class Solution
    {
        public static int RomanToInt(string s)
        {

            var counter = 0;

            var dictionary = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
                };

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    counter += dictionary[s[i]];
                    continue;
                }
                if (dictionary[s[i - 1]] >= dictionary[s[i]])
                {
                    // keep going
                    counter += dictionary[s[i]];
                }
                else
                {
                    counter = counter + dictionary[s[i]] - (2 * dictionary[s[i - 1]]);
                }
            }

            return counter;
        }
    }
}