using System;
//Write a program, which finds all possible combinations in the interval between two numbers. The program should also find the last combination, in which a number’s digits are equal to a given magical number.

namespace _13._0_Game_of_Numbers
{
    class Game
    {
        static void Main()
        {

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());
            int result1 = 0;
            int result2 = 0;
            int count = 0;
            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    if (j + i == magical)
                    {
                        result1 = i;
                        result2 = j;                        
                    }
                    count++;
                }
            }
            if (result1 != 0 && result2 != 0)
            {
                Console.WriteLine($"Number found! {result1} + {result2} = {magical}");
            }
            else
                Console.WriteLine($"{count} combinations - neither equals {magical}");
            
            //    int N = int.Parse(Console.ReadLine());
            //    int M = int.Parse(Console.ReadLine());
            //    int magicNum = int.Parse(Console.ReadLine());
            //    int counter = 0;
            //    for (int i = M; i >=N; i--)
            //    {
            //        for (int j = M; j >= N; j--)
            //        {
            //            if (i+j == magicNum)
            //            {
            //                Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
            //                return;
            //            }
            //            counter++;
            //        }
            //    }

            //    Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            //}
        }
    }
}