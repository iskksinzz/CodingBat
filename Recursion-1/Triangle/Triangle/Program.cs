using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle(4));
            Console.ReadLine();
        }

        public static int Triangle(int rows)
        {
            return rows == 0 ? rows : Triangle(rows - 1) + rows;
        }
    }
}
