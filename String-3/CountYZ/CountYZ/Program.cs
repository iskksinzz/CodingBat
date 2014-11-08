using System;

namespace CountYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountYZ("fez day"));
            Console.WriteLine(CountYZ("day fez"));
            Console.WriteLine(CountYZ("day fyyyz"));
            Console.ReadLine();
        }

        public static int CountYZ(string str)
        {
            var c = 0;
            str = str.ToLower() + " ";
            for (var i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] == 'y' || str[i] == 'z') && !char.IsLetter(str[i + 1]))
                    c++;
            }
            return c;
        }
    }
}
