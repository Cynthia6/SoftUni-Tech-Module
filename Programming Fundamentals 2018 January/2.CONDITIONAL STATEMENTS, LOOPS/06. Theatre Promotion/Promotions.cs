using System;
//A theatre is doing a ticket sale, but they need a program to calculate the price of a single ticket. If the given age
//does not fit one of the categories, you should print &quot;Error!&quot;. You can see the prices in the table below:....

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main()
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (day == "weekday")
            {
                if (0 <= age && age <= 18 || 64 < age && age <= 122)
                {
                    price = 12;
                }
                if (18 < age && age <= 64)
                {
                    price = 18;
                }
            }
            if (day == "weekend")
            {
                if (0 <= age && age <= 18 || 64 < age && age <= 122)
                {
                    price = 15;
                }
                if (18 < age && age <= 64)
                {
                    price = 20;
                }
            }
            if (day == "holiday")
            {
                if (0 <= age && age <= 18)
                {
                    price = 5;
                }
                if ( 18 < age && age <= 64)
                {
                    price = 12;
                }
                if (64 < age && age <= 122)
                {
                    price = 10;
                }
            }

           if (price > 0 ) Console.WriteLine($"{price}$");
            else Console.WriteLine("Error!");
        
        }
    }
}
