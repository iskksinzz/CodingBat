using System;

namespace StringClean
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(StringClean("yyzzza"));
            Console.WriteLine(StringClean("abbbcdd"));
            Console.WriteLine(StringClean("Hello"));
            Console.ReadLine();
        }

        private static string StringClean(string str)
        {
            if (str.Length < 2)
                return str;
            if (str[0].Equals(str[1]))
                return StringClean(str.Substring(1));
            return str[0] + StringClean(str.Substring(1));
        }
    }
}
