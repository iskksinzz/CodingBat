using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EndOther("Hiabc", "abc"));
            Console.WriteLine(EndOther("AbC", "HiaBc"));
            Console.WriteLine(EndOther("abc", "abXabc"));
            Console.ReadLine();
        }

        /* Given two strings, return true if either of the strings appears at the very end of the other string, 
         * ignoring upper/lower case differences (in other words, the computation should not be "case sensitive"). */
        public static bool EndOther(string first, string second)
        {
            var len = second.Length;
            if (first.Length < second.Length)
                len = first.Length;

            return first.Substring(first.Length - len).Equals(second.Substring(second.Length - len), StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
