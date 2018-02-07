using System;
//Create a method GetMax(int a, int b), that returns the largest of two numbers. Write a program that reads
//three numbers from the console and prints the biggest of them.Use the GetMax(…) method you just created.

namespace _2.Max_Method
{
    class Max
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());
            int temp = GetMax1(a, b);
            int maxnumber = GetMax1(temp, c);
            Console.WriteLine(maxnumber);


        }
        public static int GetMax1(int a, int b)
        {
            if (a > b) return a;
            else return b;

        }

    }
}
