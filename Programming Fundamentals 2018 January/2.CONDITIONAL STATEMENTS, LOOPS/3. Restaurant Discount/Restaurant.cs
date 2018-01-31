using System;
//A restaurant want to automate their reservation process. They need a program that reads the hall and the count of
//people from the console and calculates how much the customer should pay to book the place.
//Different halls have different prices:

namespace _3.Restaurant_Discount
{
    class Restaurant
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            int hallPrice = 0;
            int totalPrice = 0;
            string hallName = "";
            double discountPrice = 0.0;
            double pricePerson = 0.0;
            if (people <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (people <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (people <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
               
            if (package == "normal")
            {
                totalPrice = hallPrice + 500;
                discountPrice = totalPrice - (totalPrice * 0.05);
                pricePerson = discountPrice / people;
            }
            else if (package == "gold")
            {
                totalPrice = hallPrice + 750;
                discountPrice = totalPrice - (totalPrice * 0.1);
                pricePerson = discountPrice / people;
            }
            else if (package == "platinum")
            {
                totalPrice = hallPrice + 1000;
                discountPrice = totalPrice - (totalPrice * 0.15);
                pricePerson = discountPrice / people;
            }
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerson:F2}$");
        }
    }
}
