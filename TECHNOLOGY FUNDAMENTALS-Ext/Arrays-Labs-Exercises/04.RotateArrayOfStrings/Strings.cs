using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to read an array of strings, rotate it to the right and print its rotated elements.
namespace _04.RotateArrayOfStrings
{
    class Strings
    {
        static void Main()
        {
            var stringArr = Console.ReadLine().Split(' ').ToArray();
            var rotatedArr = new string[stringArr.Length];

            for (int i = 0; i < rotatedArr.Length-1; i++)
            {
                rotatedArr[i + 1] = stringArr[i];
                var lastElement = stringArr[rotatedArr.Length - 1];

                rotatedArr[0] = lastElement;
            }
            Console.WriteLine(string.Join(" ", rotatedArr));

        }
    }
}
