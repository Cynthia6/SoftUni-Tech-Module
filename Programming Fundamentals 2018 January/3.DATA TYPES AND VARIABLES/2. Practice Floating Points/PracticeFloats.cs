using System;
//Create a new C# project and create a program that assigns floating point values to variables. 
//Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). 
//Finally, you need to print all variables to the console.

namespace _2.Practice_Floating_Points
{
    class PracticeFloats
    {
        static void Main()
        {
            decimal num1 = 3.141592653589793238M;
            double num2 = 1.60217657;
            decimal num3 = 7.8184261974584555216535342341M;
            Console.WriteLine($"{num1}\n{num2}\n{num3}");
        }
    }
}
