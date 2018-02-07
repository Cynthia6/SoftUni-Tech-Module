using System;
using System.Linq;

//Create a program to check if given symbol is digit, vowel or any other symbol.

namespace _13.Vowel_or_Digit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol)) Console.WriteLine("digit");
            else if ("aeiou".Contains(symbol)) Console.WriteLine("vowel");
            else Console.WriteLine("other");
        }
    }
}
