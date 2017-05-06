using System;
using System.Linq;
//Read an array of real numbers and a number p. Find how many elements are bigger than p in the array and print the count.
namespace _4.CountOccurrencesofLargerNums
{
    public class CountOccurrences
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numsArr.Length; i++)
            {
                if (numsArr[i] > p) count++;
            }
            Console.WriteLine(count);
        }
    }
}
