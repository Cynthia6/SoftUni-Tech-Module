using System;
//A hotel has three types of rooms: studio, double and master suite. The prices are different for the different months:
namespace _4.Hotel
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            double priceS = 0.0;
            double priceD = 0.0;
            double priceSuite = 0.0;
            if (month == "may" || month == "october")
            {
                if (nights > 7)
                {
                    double oneNight = 50 - (50 * 0.05);
                    priceS = oneNight * nights;
                    if (month == "october") priceS -= oneNight;
                }
                else priceS = nights * 50;
              
                priceD = nights * 65;
                priceSuite = nights * 75;
            }
            else if (month == "june" || month == "september")
            {
                priceS = nights * 60;
                priceD = nights * 72;
                if (month == "september" && nights > 7) priceS -= 60;
                else if (nights > 14)
                {
                    priceD = priceD - (priceD * 0.10);
                }
                priceSuite = nights * 82;
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                priceS = nights * 68;
                priceD = nights * 77;
                priceSuite = nights * 89;
                if (nights > 14) priceSuite = priceSuite - (priceSuite * 0.15);
            }
            else
            {
                return;
            }
            Console.WriteLine($"Studio: {priceS:F2} lv.");
            Console.WriteLine($"Double: {priceD:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
        }
    }
}
