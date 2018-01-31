using System;
//Write a program, which takes as an input a grade and prints “Passed!” if the grade is equal or more than 3.00.
namespace _01.Passed
{
    class Passed
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
