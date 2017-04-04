using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to read an array of integers, find the smallest element and print it.
namespace _03.SmallestElementOfArrays
{
    class Smallest
    {
        static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currMin = int.MaxValue;
            for (int i = 0; i < numsArr.Length; i++)
            {
                if (currMin > numsArr[i]) currMin = numsArr[i];
            }
            Console.WriteLine(currMin);

        }
    }
}
