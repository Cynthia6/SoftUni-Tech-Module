﻿using System;
//Read an integer N and on the next N lines read an array of integers. Then, find the count of negative elements in the array.
namespace _2.Count_of_Negative_Elements
{
    public class NegativeElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numsArr = new int[n];
            int count = 0;
            for (int i = 0; i < numsArr.Length; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum <  0) count++;
            }
            Console.WriteLine(count);

        }
    }
}
