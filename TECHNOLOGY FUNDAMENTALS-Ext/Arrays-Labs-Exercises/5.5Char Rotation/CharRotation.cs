using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given two lines of input: a string and an int array. Modify the elements in the first array by the second array, following these conditions:
//•	If the element at the position is even, subtract its value to the ASCII code of the character on the same position.
//•	If the element at the position is odd, add its value to the ASCII code of the character on the same position.
//After that, print the resulting string.

namespace _5._5Char_Rotation
{
    public class CharRotation
    {
        public static void Main()
        {
            var symbols = Console.ReadLine();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] charSymbols = symbols.ToCharArray();
            string result = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) charSymbols[i] -= (char)numbers[i]; 
                else charSymbols[i] += (char)numbers[i];
                result = result +  charSymbols[i];
            }

            Console.WriteLine(result);
        //    string symbols = Console.ReadLine();
        //    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //    Console.WriteLine(string.Join("", ModifyElementsInArray(symbols, numbers)));
        //}

        //private static char[] ModifyElementsInArray(string symbols, int[] numbers)
        //{
        //    char[] modifiedElements = new char[symbols.Length];

        //    for (int i = 0; i < modifiedElements.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            modifiedElements[i] = (char)(symbols[i] - numbers[i]);
        //        }
        //        else
        //        {
        //            modifiedElements[i] = (char)(symbols[i] + numbers[i]);
        //        }
        //    }

        //    return modifiedElements;
        }
    }
}
