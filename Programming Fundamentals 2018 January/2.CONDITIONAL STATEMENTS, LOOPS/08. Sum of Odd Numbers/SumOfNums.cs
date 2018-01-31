using System;
//Write a program that prints the next n odd numbers (starting from 1) and on the last row prints the sum of them.

namespace _08.Sum_of_Odd_Numbers
{
    class SumOfNums
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num*2; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
