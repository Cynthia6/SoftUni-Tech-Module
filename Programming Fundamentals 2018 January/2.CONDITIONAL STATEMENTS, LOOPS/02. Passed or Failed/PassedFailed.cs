using System;
//Modify the above program, so it will print "Failed!" if the grade is lower than 3.00.

namespace _02.Passed_or_Failed
{
    class PassedFailed
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
