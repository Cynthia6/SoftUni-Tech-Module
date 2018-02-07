using System;
//Create a method for printing triangles as shown below:
//Examples
//1
//1 2
//1 2 3
//1 2
//1
namespace _03.Printing_Triangle
{
    class Triangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                PrintLine(rows);
            }
            for (int rows2 = n - 1; rows2 >= 0; rows2--)
            {
                PrintLine(rows2);
            }

        }
        public static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }

    }
}