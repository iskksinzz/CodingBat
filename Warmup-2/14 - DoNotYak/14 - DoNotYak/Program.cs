using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___DoNotYak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoNotYak("yakpak"));
            Console.WriteLine(DoNotYak("pakyak"));
            Console.WriteLine(DoNotYak("yak123ya"));
            Console.ReadLine();
        }

        /* Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but the "a" can be any char. The "yak" strings will not overlap. */
        public static string DoNotYak(string str)
        {
            var result = string.Empty;
            var n = 3;
            for (var i = 0; i < str.Length - 1; i += 3)
            {
                if (i + 3 > str.Length) { n = 2; }
                if (!str.Substring(i, n).Equals("yak"))
                    result += str.Substring(i, n);
            }
            return result;
        }
    }
}
