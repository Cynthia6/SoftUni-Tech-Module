using System;

namespace _3.Exact_Product_of_Real_Numbers
{
    //Write program to enter n numbers and calculate and print their exact product (without rounding).
    public class RealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal nums = 1m;

            for (int i = 1; i <= n; i++)
            {
                nums *= decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine(nums);
        }
    }
}
