using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatSeparator("Word", "X", 3));
            Console.WriteLine(RepeatSeparator("This", "AND", 2));
            Console.WriteLine(RepeatSeparator("This", "AND", 1));
            Console.ReadLine();
        }

        /* Given two strings, word and a separator, return a big string made
         * of count occurences of the word, separated by the separator string. */
        public static string RepeatSeparator(string word, string sep, int count)
        {
            var result = string.Empty;
            for (var i = 0; i < count; i++)
            {
                result += word;
                if (i != count - 1)
                    result += sep;
            }
            return result;
        }
    }
}
