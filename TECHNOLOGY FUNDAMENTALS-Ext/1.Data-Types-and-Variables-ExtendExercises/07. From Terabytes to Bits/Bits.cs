using System;

namespace _07.From_Terabytes_to_Bits
{
    //Write program to enter a real number of terabytes and convert it to bits.
    public class Bits
    {
        public static void Main()
        {
            var n = 
decimal.Parse(Console.ReadLine());

         decimal terabytes = n * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine("{0:f0}",terabytes);


        }
    }
}
