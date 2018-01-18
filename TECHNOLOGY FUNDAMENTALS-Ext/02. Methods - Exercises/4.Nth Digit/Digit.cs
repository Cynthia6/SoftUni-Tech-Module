using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method FindNthDigit(number, index) that receives a number and an index N as parameters and returns the Nth digit of the number
// (counted from right to left, starting from 1). After that, print the result on the console.
namespace _4.Nth_Digit
{
    public class Digit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number,position));

        }
        private static int FindNthDigit(int num, int indx)
        {
            int result = 0;
            int currenti = 1;
            while (num != 0)
            {
               
                if (currenti == indx)
                {
                    num = num % 10;
                    result = num;
                }
                else
                    num /= 10;
                    currenti++;

            }
            return result;
        }
    }
}
