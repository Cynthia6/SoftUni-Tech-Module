using System;
//Write a program, which finds all possible combinations in the interval between two numbers. The program should also find the last combination, in which a number’s digits are equal to a given magical number.

namespace _13._0_Game_of_Numbers
{
    class Game
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = M; i >=N; i--)
            {
                for (int j = M; j >= N; j--)
                {
                    if (i+j == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        return;
                    }
                    counter++;
                }
            }
            
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
