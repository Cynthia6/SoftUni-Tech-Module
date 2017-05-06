using System;
using System.Collections.Generic;
using System.Linq;
//Read a list of integers on the first line of the console. After that, sort the array, using the Insertion Sort algorithm, 
//but instead of doing it in-place, add the result one by one to a list.
namespace _06.Insertion_Sort_Using_List
{
    public class Insertion2
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var inserted = false;
                var currentElement = numbers[i];
                for (int listIndex = 0; listIndex < resultList.Count; listIndex++)
                {
                    var currentListElement = resultList[listIndex];
                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        resultList.Insert(Math.Max(0, listIndex), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    resultList.Add(currentElement);
                }
            }


            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}