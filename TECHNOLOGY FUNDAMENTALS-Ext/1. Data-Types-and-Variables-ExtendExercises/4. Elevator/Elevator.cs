using System;

namespace _4.Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double result = (n / 24);
            if (n % 24 != 0)
            {
                result += 1;
            }
            Console.WriteLine((int)(result));

        }
    }
}
