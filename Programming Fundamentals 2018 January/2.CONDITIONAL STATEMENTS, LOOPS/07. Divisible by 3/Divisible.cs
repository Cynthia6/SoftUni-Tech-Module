using System;
//Write a program, which prints all the numbers from 1 to 100, which are divisible by 3. You have to use a single for
//loop.The program should not receive input.

namespace _07.Divisible_by_3
{
    class Divisible
    {
        static void Main()
        {
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
            //for (int i = 3; i <= 100; i++)
            //{
            //    if (i % 3 == 0) Console.WriteLine(i);
            //}
        }
    }
}
