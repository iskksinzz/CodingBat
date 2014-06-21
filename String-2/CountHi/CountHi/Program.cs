using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountHi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountHi("abc hi ho"));
            Console.WriteLine(CountHi("ABChi hi"));
            Console.WriteLine(CountHi("hihi"));
            Console.ReadLine();
        }

        /* Return the number of times that the string "hi" appears anywhere in the given string. */
        public static int CountHi(string str)
        {
            var count = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2).Equals("hi"))
                    count++;
            }
            return count;
        }
    }
}
