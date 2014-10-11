using System;

namespace Pre4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pre4(new[] { 1, 2, 4, 1 }));
            Console.ReadLine();
        }

        public static int[] Pre4(int[] nums)
        {
            var k = 0;
            while (nums[k] != 4) { k++; }

            var arr = new int[k];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = nums[i];
            return arr;
        }
    }
}
