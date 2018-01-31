using System;
//You will receive an integer as an input from the console. Print the 10 times table for this integer.

namespace _09.Multiplication_Table
{
    class Table
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <=10)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
                i++;
            }

        }
    }
}
