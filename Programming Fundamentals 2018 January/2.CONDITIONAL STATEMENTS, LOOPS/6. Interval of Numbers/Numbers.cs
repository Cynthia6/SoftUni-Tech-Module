using System;
//Write a program, which takes two numbers as input and prints the interval of numbers between them, starting
//from the smaller one and ending with the larger one.

namespace _6.Interval_of_Numbers
{
    class Numbers
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (end < start)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            for (int i = start; i <=end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
