using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___DoubleX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleX("axxbb"));
            Console.WriteLine(DoubleX("axaxxax"));
            Console.WriteLine(DoubleX("xxxxx"));
            Console.ReadLine();
        }

        /* Given a string, return true if the first instance of "x" in the string is immediately followed by another "x". */

        public static bool DoubleX(string str)
        {
            var counter = 0;
            for (var i = 0; i < str.Length-1; i++)
            {
                if (str[i].Equals('x')) counter++;
                if(str.Substring(i, 2).Equals("xx") && counter < 2) return true;
            }
            return false;
        }
    }
}
