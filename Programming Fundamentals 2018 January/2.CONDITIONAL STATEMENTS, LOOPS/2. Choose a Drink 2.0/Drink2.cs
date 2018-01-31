using System;
//Your program needs to get smarter. Now you will receive on the second line the quantities of the drink and you have
//to print the calculated the price.You can see the prices of the drinks in the table below:

namespace _2.Choose_a_Drink_2._0
{
    class Drink2
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (profession == "Athlete")
            {
                price = 0.70;
                Console.WriteLine($"The {profession} has to pay {quantity*price:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00;
                Console.WriteLine($"The {profession} has to pay {quantity*price:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70;
                Console.WriteLine($"The {profession} has to pay {quantity*price:F2}.");
            }
            else
            {
                price = 1.20;
                Console.WriteLine($"The {profession} has to pay {quantity*price:F2}.");
            }
        }
    }
}
