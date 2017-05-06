using System;
using System.Linq;
//Read a list of integers on the first line of the console. After that, reverse the array in-place (as in, don’t create a new 
//collection to hold the result, reverse it using only the original array). After you are done, print the reversed array on the console.
namespace _03.Reverse_Array_In_place
{
   public class Reverse
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}