using System;
//Write a program, which finds all the possible combinations between two numbers – N and M.
//The first digit decreases from N to 1, and the second digit increases from 1 to M.The two digits form a number.
//Multiply the two digits, then multiply their product by 3. Add the result to the total sum.
//You will also be given a third number, which will be the maximum boundary of the sum.If the sum is equal or
//greater than this number you should stop the program. See the examples for further information.

namespace _12._0_Test_Numbers
{
    class Test
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int totalSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    sum += i * j * 3;
                    counter++;
                    if (sum >= totalSum)
                    {
                        Console.WriteLine($"{counter} combinations\r\nSum: {sum} >= {totalSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations\r\nSum: {sum}");
        }
    }
}
