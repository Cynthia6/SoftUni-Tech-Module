using System;
//Calculate how many courses will be needed to transport n persons by using 3 vehicles of capacity 4, 8 and 12 respectively.
//The input holds one line: the number of people n.The vehicles can travel at the same time.

namespace _4.Transport
{
    class Transport
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double result = n / 24;
            if (n % 24 != 0) result+=1;

            Console.WriteLine((int)result);
           //Console.WriteLine(Math.Ceiling((double)n/ 24));      
        }
    }
}
