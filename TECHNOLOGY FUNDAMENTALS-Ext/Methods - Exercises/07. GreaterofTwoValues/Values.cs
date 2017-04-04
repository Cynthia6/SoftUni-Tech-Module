using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given two values of the same type as input. The values can be of type int, char of string. 
//Create a method GetMax() that returns the greater of the two values: 
namespace _07.GreaterofTwoValues
{
    class Values
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = (IntMax(first, second));
                Console.WriteLine(max);

            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = CharMax(first, second);
                Console.WriteLine(max);

            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = StringMax(first, second);
                Console.WriteLine(max);

            }
        }
    
            public static int IntMax(int a, int b)
        {
            int result = Math.Max(a, b);
            return result;
        }
        public static char CharMax(char a, char b)
        {
            if (a > b) return a;
            else return b;
        }
        public static string StringMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0) return a;
            else return b;
        }
        }
    }

