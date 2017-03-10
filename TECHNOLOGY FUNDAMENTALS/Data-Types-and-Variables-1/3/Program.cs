using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse   (Console.ReadLine());
            decimal nums = 0m;

            for (int i = 1; i <= n; i++)
            {
                nums += decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine(nums);
        }
    }
}
