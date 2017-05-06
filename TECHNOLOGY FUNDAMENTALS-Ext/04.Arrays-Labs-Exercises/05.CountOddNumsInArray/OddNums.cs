using System;
using System.Linq;
//Write a program to read an array of integers and find how many odd elements it holds.

namespace _05.CountOddNumsInArray
{
    public class OddNums
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < numsArr.Length; i++)
            {
                if (numsArr[i] % 2 != 0) count++;
            }
            Console.WriteLine(count);
        }
    }
}
