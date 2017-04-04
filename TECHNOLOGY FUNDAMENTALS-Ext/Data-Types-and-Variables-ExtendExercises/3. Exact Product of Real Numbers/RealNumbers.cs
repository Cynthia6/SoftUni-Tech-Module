using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Product_of_Real_Numbers
{
    //Write program to enter n numbers and calculate and print their exact product (without rounding).
    class RealNumbers
    {
        static void Main(string[] args)
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
