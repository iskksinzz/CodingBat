using System;

namespace SameEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SameEnds("abXYab"));
            Console.WriteLine(SameEnds("xx"));
            Console.WriteLine(SameEnds("xxx"));
            Console.ReadLine();
        }

        public static string SameEnds(string str)
        {
            var s = "";
            for (var i = 1; i < str.Length/2+1; i++)
            {
                if (str.Substring(0, i).Equals(str.Substring(str.Length - i)))
                    s = str.Substring(0, i);
            }
            return s;
        }
    }
}