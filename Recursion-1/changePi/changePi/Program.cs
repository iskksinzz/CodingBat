using System;

namespace changePi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChangePi("xpix"));
            Console.WriteLine(ChangePi("pipi"));
            Console.WriteLine(ChangePi("pip"));
            Console.ReadLine();
        }

        private static string ChangePi(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            if (str.Substring(0, 2).Equals("pi"))
            {
                return "3.14" + ChangePi(str.Substring(2));
            }
            return str[0] + ChangePi(str.Substring(1));
        }
    }
}
