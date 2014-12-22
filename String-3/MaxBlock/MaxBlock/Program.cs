using System;
using System.Text.RegularExpressions;

namespace MaxBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxBlock("hoopla"));
            Console.WriteLine(MaxBlock("abbCCCddBBBxx"));
            Console.WriteLine(MaxBlock(""));
            Console.ReadLine();
        }

        private static int MaxBlock(string str)
        {
            var max = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var c = 0;
                for (var j = i; j < str.Length; j++)
                {
                    if (str[i].Equals(str[j])) c++;
                    else break;
                }
                if (c > max) max = c;
            }
            return max;
        }
    }
}
