using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordEnds("abcXY123XYijk", "XY")); // c13i
            Console.WriteLine(WordEnds("XY123XY", "XY")); // 13
            Console.WriteLine(WordEnds("XY1XY", "XY")); // 11
            Console.WriteLine(WordEnds("abc1xyz1abc", "abc")); // 11
            Console.WriteLine(WordEnds("XYXY", "XY")); // XY
            Console.WriteLine(WordEnds("abc1xyz1i1j", "1")); // cxziij
            Console.WriteLine(WordEnds("abc1xyz1abc", "b")); // acac
            Console.ReadLine();
        }

        /* Given a string and a non-empty word string, return a string made of each char
         * just before and just after every appearance of the word in the string. 
         * Ignore cases where there is no char before or after the word, and a char may
         * be included twice if it is between two words. */
        public static string WordEnds(string str, string word)
        {
            var result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                if (i <= str.Length - word.Length && str.Substring(i, word.Length).Equals(word))
                {
                    if (i > 0)
                        result += str.Substring(i - 1, 1);

                    if (i != str.Length - word.Length)
                        result += str.Substring(i + word.Length, 1);
                        i += word.Length - 1;
                }
            }
            return result;
        }
    }
}
