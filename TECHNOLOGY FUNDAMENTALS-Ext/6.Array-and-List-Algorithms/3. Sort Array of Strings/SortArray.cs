using System;

//You are given an array of strings (one line, space-delimited). Sort the array using the Bubble sort or Insertion sort algorithms. 
//Instead of comparing if one string is smaller than the other (which you can’t do), you can use the string.CompareTo(str) method. 
//Once the array is sorted, print it on the console, separating the elements by spaces.
namespace _3.Sort_Array_of_Strings
{
    public class SortArray
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    var position = words[i].CompareTo(words[j]);
                    if (position == 1)
                    {
                        var temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", words));

        }
    }
}