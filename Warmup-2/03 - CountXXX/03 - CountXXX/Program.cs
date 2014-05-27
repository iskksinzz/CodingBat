using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___CountXXX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountX("abcxx"));
            Console.WriteLine(CountX("xxx"));
            Console.WriteLine(CountX("xxxx"));
            Console.ReadLine();
        }

        /* Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx". */

        public static int CountX(string str)
        {
            var count = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2).Equals("xx"))
                    count++;
            }
            return count;
        }
    }
}
