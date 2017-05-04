using System;
using System.Collections.Generic;
using System.Linq;
//Write a program to read an array of integers and find how many odd numbers at odd positions the array holds. 
//If there are no numbers which match this criteria, do not print anything
namespace _06.OddNumsAtOddPositions
{
    class OddPositions
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            for (int i = 0; i < numsArr.Length; i++)
            {
                if (i % 2 != 0 && numsArr[i] % 2 != 0) Console.WriteLine($"Index {i} -> {numsArr[i]}");
            }
         
        }
    }
}
