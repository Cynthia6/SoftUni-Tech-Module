using System;
using System.Linq;
//Read a list of integers on the first line of the console. After that, sort the array, using the Bubble Sort algorithm.
namespace _04.Sort_Array_Using_Bubble
{
    public class BubbleSOrt
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool swap = false;

            do
            {
                swap = false;
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    if(numbers[i] > numbers[i + 1])
                    {
                        swap = true;
                        var temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }

            } while (swap);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
