using System;
using System.Linq;
//You will be given two integer lists on the first two lines (space-separated). Remove the elements in the first list from the elements in the second list. 
//If an element from the first list occurs more than once in the second list, remove all occurrences.
//After you remove the elements, check the sum of both lists.If the sum of both of them is equal, print “Yes.Sum: { sum}”. 
//If not print the absolute difference between the two lists in the format “No.Diff: {sum}”.

namespace _3.Equal_Sum_After_Extraction
{
    public class EqualSum
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //foreach (var number in firstLine)
            //{
            //    secondList.RemoveAll(x => x == number);
            //}
           
            for (int i = 0; i < secondList.Count; i++)
            {
                for (int r = 0; r < firstList.Count; r++)
                {
                    if (secondList[i] == firstList[r])
                    {
                        secondList.Remove(secondList[i]);
                        i--;
                    }
                }
            }

            if (firstList.Sum() == secondList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum() - secondList.Sum())}");
            }
        }
    }
}