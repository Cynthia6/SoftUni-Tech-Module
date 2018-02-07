using System;
//Create a program that reads an integer number and multiplies the sum of all its even digits by the sum of all its
//odd digits:

namespace _09.Multiply_Evens_by_Odds
{
    class EventsOdds
    {
        static void Main()
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
