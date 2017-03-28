using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method Encrypt(char letter) which encrypts the letter in the following way:
//•	Take the first and the last digit of its ASCII code and append them together in a string.
//•	Append at the start of the resulting string the character corresponding to:
//•	Then append at the end of the resulting string the character corresponding to:
//o the ASCII code of the letter - the first digit of the ASCII code of the letter
//•	The method should return the encrypted string.

namespace _8.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                 result += Encrypted(symbol);
                

            }
            Console.WriteLine(result);
        }

        private static string Encrypted(char symbol)
        {
            int firstDigit, lastDigit;
            int symToInt = (int)(symbol);
            if (symToInt <= 99) firstDigit = symToInt / 10;
            else firstDigit = symToInt / 100;
            lastDigit = symToInt % 10;
            string result = firstDigit + "" + lastDigit;
            symToInt += lastDigit;
            result = (char)symToInt + "" + result;
            symToInt = symToInt - lastDigit - firstDigit;
            result = result + "" + (char)symToInt;
            return result;
        }
    }
}
