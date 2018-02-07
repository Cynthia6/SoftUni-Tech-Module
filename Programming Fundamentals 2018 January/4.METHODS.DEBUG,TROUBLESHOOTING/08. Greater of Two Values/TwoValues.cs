using System;
//You are given two values of the same type as input.The values can be of type int, char of string. Create a method
//GetMax() that returns the greater of the two values:

namespace _08.Greater_of_Two_Values
{
    class TwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));


            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));

            }
        }

        private static int GetMax(int first, int second)
        {
            int result = Math.Max(first, second);
            return result;
        }
        private static char GetMax(char first, char second)
        {
            if (first > second)
                return first;
            else
                return second;
        }
        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0) return first; //returns number 1>0 if bigger
            else return second;

        }
    }
}