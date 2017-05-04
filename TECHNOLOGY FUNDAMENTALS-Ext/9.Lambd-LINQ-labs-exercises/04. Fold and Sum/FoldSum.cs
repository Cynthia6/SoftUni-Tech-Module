using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower rows (2*k integers):
namespace _04.Fold_and_Sum
{
    public class FoldSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            var k = numbers.Length / 4;

            var upperRow1 = numbers
                .Take(k)
                .Reverse()
                .ToArray();
            var upperRow2 = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var upperRow = upperRow1
                .Concat(upperRow2)
                .ToArray();

            var lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var sum = new int[k * 2];
            for (int i = 0; i < k * 2; i++)
            {
                sum[i] = upperRow[i] + lowerRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}