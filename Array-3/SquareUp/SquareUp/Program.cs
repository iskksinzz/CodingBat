using System;

namespace SquareUp
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareUp(3);
            Console.ReadLine();
        }
        public static int[] SquareUp(int n)
        {
            var arr = new int[n * n];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (n - j > i + 1)
                    {
                        arr[i * n + j] = 0;
                    }
                    else
                    {
                        arr[i * n + j] = n - j;
                    }
                }
            }
            return arr;
        }
    }
}
