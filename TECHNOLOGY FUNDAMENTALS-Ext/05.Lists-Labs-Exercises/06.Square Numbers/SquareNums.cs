using System;
using System.Collections.Generic;
using System.Linq;
//Read a list of integers and extract all square numbers from it and print them in descending order. 
//A square number is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.
namespace _06.Square_Numbers
{
    public class SquareNums
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num)) result.Add(num);
            }
            result.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
