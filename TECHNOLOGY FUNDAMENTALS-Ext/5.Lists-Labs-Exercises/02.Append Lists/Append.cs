using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to append several lists of numbers.
//	Lists are separated by ‘|’.
//	Values are separated by spaces(‘ ’, one or several)
//	Order the lists from the last to the first, and their values from left to right.

namespace _02.Append_Lists
{
    public class Append
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();
            var result = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                result.AddRange(numbers[i]
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList()); 
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
