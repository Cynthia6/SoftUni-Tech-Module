using System;
//A master number is an integer that holds the following properties:
// Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
// Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
// Holds at least one even digit, e.g. 232, 707, 6886, 87578.
// Write a program to print all master numbers in the range[1…n].

namespace _12._0_Master_Number
{
    class MasterNum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (IsPalindrome(i.ToString()) && SumDiv(i)) { Console.WriteLine(i); }
            }
        }

        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i]) { return false; }
            }
            return true;
        }
        static bool SumDiv(int n)
        {
            bool evenDigit = false; bool divisible = false;
            int sum = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0) { evenDigit = true; }
                sum += lastDigit;
                n /= 10;
            }
            if (sum % 7 == 0) { divisible = true; }
            if (evenDigit && divisible) { return true; }
            else { return false; }
        }
    }
}