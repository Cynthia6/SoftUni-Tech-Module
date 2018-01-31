using System;
//Write a program, which prints all 3-letter combinations, using only the letters from a given interval. You will also
//receive a third letter.Every combination, which contains this letter should not be printed.

namespace _14._0_Magic_Letter
{
    class Letter
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <=second ; k++)
                    {
                        if (i != third && j != third  && k != third)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                       
                    }
                }
            }
        }
    }
}
