using System;
//You are assigned to rework a given piece of code which is working without bugs but is not properly formatted.
//The given program tracks stock prices and gives updates about the significance in each price change.Based on the
//significance, there are four kind of changes: no change at all(price is equal to the previous), minor(difference is
//below the significance threshold), price up and price down.

namespace _11.Price_Change_Alert
{
    class PriceAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double Price = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double difference = CalculateDifference(Price, nextPrice);
                bool isSignificantDifference = isDiff(difference, treshold);

                string message = Get(nextPrice, Price, difference, isSignificantDifference);
                Console.WriteLine(message);

                Price = nextPrice;
            }
        }

        private static string Get(double price, double last, double difference, bool isSignificantDifference)

        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", price);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, difference * 100);
            return message;
        }
        private static bool isDiff(double treshold, double isDiff)
        {
            if (Math.Abs(treshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double CalculateDifference(double price, double nextPrice)
        {
            double r = (nextPrice - price) / price;
            return r;
        }
    }
}