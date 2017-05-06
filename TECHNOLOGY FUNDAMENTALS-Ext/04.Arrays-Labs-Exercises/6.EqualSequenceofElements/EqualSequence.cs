using System;
using System.Linq;
//Read an array of integers and find out if all the elements in the array are the same.
namespace _6.EqualSequenceofElements
{
    public class EqualSequence
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int count = 0;
            for (int i = 0; i < numsArr.Length - 1; i++)
            {
                if (numsArr[i] == numsArr[i + 1]) count++;
                //  if (numbers[i] != numbers[i - 1])

            }
            if (numsArr[numsArr.Length - 1] == numsArr[numsArr.Length - 2]) count++;
            if (count == numsArr.Length) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
