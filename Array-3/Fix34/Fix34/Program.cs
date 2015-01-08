using System;

namespace Fix34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fix34(new[] { 1, 3, 1, 4 }));
            Console.WriteLine(Fix34(new[] { 1, 3, 1, 4, 4, 3, 1 }));
            Console.WriteLine(Fix34(new[] { 3, 2, 2, 4 }));
            Console.ReadLine();
        }

        static int[] Fix34(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3 && nums[i + 1] != 4)
                {
                    var temp = nums[i + 1];
                    nums[i + 1] = 4;
                    for (var j = i + 2; j < nums.Length; j++)
                    {
                        if (nums[j] == 4)
                            nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
