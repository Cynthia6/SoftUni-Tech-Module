using System;
using System.Linq;
//Read an array of integers and print how many times a given element exists in it.
namespace _3.CountOfGivenElementInArray
{
    public class GivenElement
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numsArr.Length; i++)
            {
                if (numsArr[i] == element) count++;
            }
            Console.WriteLine(count);
        }
    }
}
