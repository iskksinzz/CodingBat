using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PlusOut("12xy34", "xy"));
            Console.WriteLine(PlusOut("12xy34", "1"));
            Console.WriteLine(PlusOut("12xy34xyabcxy", "xy"));
            Console.ReadLine();
        }

        /* Given a string and a non-empty word string, return a version of the original
         * string where all chars have been replaced by pluses ("+"), except for appearances
         * of the word string which are preserved unchanged. */
        public static string PlusOut(string str, string word)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (i <= str.Length - word.Length && str.Substring(i, word.Length).Equals(word))
                {
                    result += str.Substring(i, word.Length);
                    i += word.Length - 1;
                }
                else
                {
                    result += '+';
                }
            }
            return result;
        }
    }
}