using System;
//Write program to enter n numbers and calculate and print their exact sum (without rounding).

namespace _3._3.Exact_Sum_of_Numbers
{
    class Numbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal nums = 0m;

            for (int i = 1; i <= n; i++)
            {
                nums += decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine(nums);
        }
    }
}
