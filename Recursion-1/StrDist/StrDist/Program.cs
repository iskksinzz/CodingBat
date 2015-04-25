using System;

namespace StrDist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrDist("catcowcat", "cat"));
            Console.WriteLine(StrDist("catcowcat", "cow"));
            Console.WriteLine(StrDist("cccatcowcatxx", "cat"));
            Console.ReadLine();
        }

        private static int StrDist(string str, string sub)
        {
            if (str.IndexOf(sub) == -1)
                return 0;
            if (!str.Substring(0, sub.Length).Equals(sub))
                return StrDist(str.Substring(1), sub);
            if (str.LastIndexOf(sub) != -1)
                return str.Substring(0, str.LastIndexOf(sub) + sub.Length).Length;
            return StrDist(str.Substring(1), sub);
        }
    }
}
