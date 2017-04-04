using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    // You will be given two numbers.Your task is to find the lowest one by value, find the numerical type it fits in from the following (byte, ushort, uint, ulong) 
    //and check how many times the greater one by value overflows the type of the smaller one(rounded to the nearest whole integer).
    class Program
    {
        static void Main(string[] args)
        {


            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());
            decimal temp = 0;

            if (number2 > number1)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
            }

            //first number
            if (byte.MinValue <= number1 && number1 <= byte.MaxValue)
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (ushort.MinValue <= number1 && number1 <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (uint.MinValue <= number1 && number1 <= uint.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
            }
            else
                Console.WriteLine("bigger type: ulong");

            //second number and calculating number of overflows
            if (byte.MinValue <= number2 && number2 <= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                Console.WriteLine("{0} can overflow byte {1} times",
                    number1,
                    Math.Round(number1 / byte.MaxValue));
            }
            else if (ushort.MinValue <= number2 && number2 <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                Console.WriteLine("{0} can overflow ushort {1} times",
                    number1,
                    Math.Round(number1 / ushort.MaxValue));
            }
            else if (uint.MinValue <= number2 && number2 <= uint.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                Console.WriteLine("{0} can overflow uint {1} times",
                    number1,
                    Math.Round(number1 / uint.MaxValue));
            }
            else
            {
                Console.WriteLine("smaller type: ulong");
                Console.WriteLine("{0} can overflow ulong {1} times",
                    number1,
                    Math.Round(number1 / ulong.MaxValue));
            }

            //ulong firstNum = ulong.Parse(Console.ReadLine());
            //ulong secondNum = ulong.Parse(Console.ReadLine());

            //ulong biggerNum = Math.Max(firstNum, secondNum);
            //ulong smallerNum = Math.Min(firstNum, secondNum);

            //string bigType = "";
            //string smallType = "";
            //ulong smallNumType = 0;

            //if (biggerNum >= smallerNum)
            //{
            //    if (biggerNum > byte.MinValue && biggerNum <= byte.MaxValue)
            //    {
            //        bigType = "byte";
            //    }
            //    else if (biggerNum > ushort.MinValue && biggerNum <= ushort.MaxValue)
            //    {
            //        bigType = "ushort";
            //    }
            //    else if (biggerNum > uint.MinValue && biggerNum <= uint.MaxValue)
            //    {
            //        bigType = "uint";
            //    }
            //    else if (biggerNum > ulong.MinValue && biggerNum <= ulong.MaxValue)
            //    {
            //        bigType = "ulong";
            //    }

            //    if (smallerNum > byte.MinValue && smallerNum <= byte.MaxValue)
            //    {
            //        smallType = "byte";
            //        smallNumType = byte.MaxValue;
            //    }
            //    else if (smallerNum > ushort.MinValue && smallerNum <= ushort.MaxValue)
            //    {
            //        smallType = "ushort";
            //        smallNumType = ushort.MaxValue;
            //    }
            //    else if (smallerNum > uint.MinValue && smallerNum <= uint.MaxValue)
            //    {
            //        smallType = "uint";
            //        smallNumType = uint.MaxValue;
            //    }
            //    else if (smallerNum > ulong.MinValue && smallerNum <= ulong.MaxValue)
            //    {
            //        smallType = "ulong";
            //        smallNumType = ulong.MaxValue;
            //    }

            //    Console.WriteLine($"bigger type: {bigType}");
            //    Console.WriteLine($"smaller type: {smallType}");
            //    Console.WriteLine($"{biggerNum} can overflow {smallType} {Math.Round((double)biggerNum / smallNumType)} times");
            //}
        }
    }
}
