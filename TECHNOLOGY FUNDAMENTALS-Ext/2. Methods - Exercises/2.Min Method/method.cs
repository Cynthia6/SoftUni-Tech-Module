using System;
//Create a GetMin(int a, int b) method, that returns the smaller of two numbers. Write a program that reads three numbers from the console 
//and prints the smallest of them. Use the GetMin(…) method you just created.
namespace _2.Min_Method
{
    public class method
    {
        public static void Main()
        {
            int first =
int.Parse(Console.ReadLine());

            int second =
int.Parse(Console.ReadLine());

            int third =
int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(first, second, third));
        }

            public static int GetMin(int a, int b, int c)
        {
            int result = Math.Min(a, b);
            int result2 = Math.Min(result, c);
            return result2;
        }
    }
}
