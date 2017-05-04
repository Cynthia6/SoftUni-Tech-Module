using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a list of integers and extract all square numbers from it and print them in descending order. 
//A square number is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.
namespace _06.Square_Numbers
{
    class SquareNums
    {
        static void Main(string[] args)
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
