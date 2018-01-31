using System;
//Write a program, which receives a number – n, and prints a triangle from 1 to n as in the examples.

namespace _10._0_Triangle_of_Numbers
{
    class Triangle
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int i2 = 1; i2 <= i; i2++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
