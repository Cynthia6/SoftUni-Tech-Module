using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.From_Terabytes_to_Bits
{
    //Write program to enter a real number of terabytes and convert it to bits.
    class Bits
    {
        static void Main(string[] args)
        {
            var n = 
decimal.Parse(Console.ReadLine());

         decimal terabytes = n * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine("{0:f0}",terabytes);


        }
    }
}
