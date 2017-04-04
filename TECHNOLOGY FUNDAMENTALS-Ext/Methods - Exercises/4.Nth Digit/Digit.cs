using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method FindNthDigit(number, index) that receives a number and an index N as parameters and returns the Nth digit of the number
// (counted from right to left, starting from 1). After that, print the result on the console.
namespace _4.Nth_Digit
{
    class Digit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number,position));

        }
        public static int FindNthDigit(int number, int position)
        {
            int digit = 0;
            int count = 0;
            while (number > 0)
            {
               
                if (count == position)
                {
                    break;
                }
                 else
                {
                    digit = number % 10;
                    count++;
                    number = number / 10;
                }
              
            }
            return digit;
            
        }
    }
}
