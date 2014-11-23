using System;
using System.Text.RegularExpressions;

namespace WithoutString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WithoutString("Hello there", "llo"));
            Console.WriteLine(WithoutString("Hello there", "e"));
            Console.WriteLine(WithoutString("Hello there", "x"));
            Console.WriteLine(WithoutString("This is a FISH", "IS"));
            Console.WriteLine(WithoutString("THIS is a FISH", "is"));
            Console.WriteLine(WithoutString("THIS is a FISH", "iS"));
            Console.WriteLine(WithoutString("abxxxxab", "xx"));
            Console.WriteLine(WithoutString("abxxxab", "xx"));
            Console.WriteLine(WithoutString("abxxxab", "x"));
            Console.WriteLine(WithoutString("xxx", "x"));
            Console.WriteLine(WithoutString("xxx", "xx"));
            Console.WriteLine(WithoutString("xyzzy", "Y"));
            Console.WriteLine(WithoutString("", "x"));
            Console.WriteLine(WithoutString("abcabc", "b"));
            Console.WriteLine(WithoutString("AA22bb", "2"));
            Console.WriteLine(WithoutString("1111", "1"));
            Console.WriteLine(WithoutString("1111", "11"));
            Console.WriteLine(WithoutString("MkjtMkx", "Mk"));
            Console.WriteLine(WithoutString("Hi HoHo", "Ho"));
            Console.ReadLine();
        }

        public static string WithoutString(string str, string remove)
        {
            while (true)
            {
                var i = str.ToLower().IndexOf(remove.ToLower());
                if (i != -1)
                    str = str.Remove(i, remove.Length);
                if (!str.ToLower().Contains(remove.ToLower()))
                    break;
            }
            return str;
        }
    }
}
