using System;
using System.Linq;
//Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well(see the examples below).
//	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class Sum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i -= 2;
                }
                if (i < -1)
                {
                    i = -1;
                }
                
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
