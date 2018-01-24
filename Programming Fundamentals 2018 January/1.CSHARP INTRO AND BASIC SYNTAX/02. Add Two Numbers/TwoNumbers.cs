using System;
// Write a program, which reads 2 whole numbers and adds them together. Then, print them in the following format:
// “a + b = sum”
namespace _02.Add_Two_Numbers
{
    class TwoNumbers
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int result = numOne + numTwo;
            Console.WriteLine($"{numOne} + {numTwo} = {result}");
        }
    }
}
