using System;
using System.Linq;
//Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. 
//In case of no elements left in the list, print “empty”.
namespace _01.RemoveNegativesAndReverse
{
    public class RemoveAndReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            if (numbers.Count != 0) Console.WriteLine(string.Join(" ", numbers));
            else Console.WriteLine("empty");
        }
    }
}
