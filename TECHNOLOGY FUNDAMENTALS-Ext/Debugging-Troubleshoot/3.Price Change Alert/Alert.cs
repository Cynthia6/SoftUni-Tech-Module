using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Price_Change_Alert
{
    class Alert
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double Price = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double difference = CalculatePercentage(Price, nextPrice);
                bool isSignificantDifference = isDiff(difference, treshold);

                string message = GetResultMessage(nextPrice, Price, difference, isSignificantDifference);
                Console.WriteLine(message);

                Price = nextPrice;
            }
        }

        private static string GetResultMessage(double price, double nextPrice, double difference, bool isSignificantDifference)
            
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", price);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", nextPrice, price, difference*100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", nextPrice, price, difference*100);
            }
            else if (isSignificantDifference && (difference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", nextPrice, price, difference*100);
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

        private static double CalculatePercentage(double price, double nextPrice)
        {
            double percent = (nextPrice - price) / price;
            return percent;
        }
    }
}