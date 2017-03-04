using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
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
