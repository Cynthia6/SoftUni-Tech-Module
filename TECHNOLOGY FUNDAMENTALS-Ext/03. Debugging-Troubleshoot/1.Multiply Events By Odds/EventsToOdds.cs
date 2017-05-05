using System;

namespace _1.Multiply_Events_By_Odds
{
    public class EventsToOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
               
                number /= 10;
            }
            return sum;
        }


        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
             
                number /= 10;
            }
            return sum;
        }
    }
}

