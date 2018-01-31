using System;
//Write a program, which receives a profession (as a string) and chooses the perfect drink for the person. The possible
//combinations are:
// “Water” – for “Athlete”
// “Coffee” – for “Businessman” or “Businesswoman”
// “Beer” – for “SoftUni Student”
// “Tea” – for all other professions.

namespace _1.Choose_a_Drink
{
    class Drink
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }

        }
    }
}
