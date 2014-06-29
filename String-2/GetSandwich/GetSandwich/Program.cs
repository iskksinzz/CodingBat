using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetSandwich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSandwich("breadjambread"));
            Console.WriteLine(GetSandwich("xxbreadjambreadyy"));
            Console.WriteLine(GetSandwich("xxbreadyy"));
            Console.ReadLine();
        }

        /* A sandwich is two pieces of bread with something in between. 
         * Return the string that is between the first and last appearance 
         * of "bread" in the given string, or return the empty string "" 
         * if there are not two pieces of bread. */

        public static string GetSandwich(string str)
        {
            if (str.Length < 11) return "";

            var firstBread = 0;
            var lastBread = 0;
            var count = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (i <= str.Length - 5 && str.Substring(i, 5).Equals("bread"))
                {
                    if (count < 1)
                    {
                        firstBread = i + 5;
                        count++;
                    }
                    else
                    {
                        lastBread = i;
                    }
                }
            }
            return lastBread < 1 ? "" : str.Substring(firstBread, lastBread - firstBread);
        }
    }
}
