using System;

//Write a program which reads an array of integers, calculates its sum and prints it. 
//The input consists of a number n(the number of elements) + n integers, each as a separate line.

namespace _01.Sum_Array_Elements
{
    public class Sum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                result += currentNum;
            }
            Console.WriteLine(result);

        }
    }
}
