using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(1, 6));
            Console.WriteLine(FizzBuzz(1, 8));
            Console.WriteLine(FizzBuzz(1, 11));
            Console.ReadLine();
        }

        public static string[] FizzBuzz(int start, int end)
        {
            var arr = new string[end - start];
            var j = 0;
            for (int i = start; i < end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { arr[j++] = "FizzBuzz"; }
                else if (i % 3 == 0) { arr[j++] = "Fizz"; }
                else if (i % 5 == 0) { arr[j++] = "Buzz"; }
                else { arr[j++] = Convert.ToString(i); }
            }
            return arr;
        }
    }
}
