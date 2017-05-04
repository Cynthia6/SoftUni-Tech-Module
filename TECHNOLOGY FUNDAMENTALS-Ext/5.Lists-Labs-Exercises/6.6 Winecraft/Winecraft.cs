using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will be given a sequence of integers, which will represent grapes. On the next line you will be given N - an integer, indicating the growth days.
// You must increment every integer in the list by 1 N times. However, if one of the grapes’ value is greater than the grape to its left and is also greater than
// the one to his right, it should steal the values, which would have been incremented to its neighbors, and add them to itself, instead of being incremented by 1
// like normal (note: if any of the greater grapes’ neighboring grapes have a value of 0, DON’T decrement it and DON’T add its value to the greater grape).
//Lesser grapes don’t get incremented, but instead they have their values decremented by 1 by their neighboring greater grapes, therefore their values get added to 
    //the greater grapes.
//After you're done with the growing (processed the grapes N times), every grape which has a value, lower than N should be removed.
//The process should then repeat, again incrementing everything N times, where the greater grapes steal from the lesser grapes, until your list contains less than N grapes.
//After that, print the remaining grapes on the console (one line, space-separated).

namespace _6._6_Winecraft
{
    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDays)
            {
                for (int i = 0; i < growthDays; i++)
                {
                    IncreasingGrapes(grapes);

                    for (int q = 0; q < grapes.Count; q++)
                    {
                        ProcessGrapes(grapes, q);
                    }
                }

                RemoveSmallerGrapes(grapes, growthDays);

            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        private static void RemoveSmallerGrapes(List<int> grapes, int growthDays)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= growthDays)
                {
                    grapes.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void ProcessGrapes(List<int> grapes, int q)
        {
            if (q != 0 && q != grapes.Count - 1)
            {
                int left = q - 1;
                int right = q + 1;
                var isGreaterThanLeft = grapes[q] > grapes[left];
                var isGreaterThanRight = grapes[q] > grapes[right];

                if (isGreaterThanLeft && isGreaterThanRight)
                {
                    grapes[q]--;

                    if (grapes[left] > 0)
                    {
                        grapes[q]++;
                        grapes[left] = Math.Max(grapes[left] - 2, 0);
                    }
                    if (grapes[right] > 0)
                    {
                        grapes[q]++;
                        grapes[right] = Math.Max(grapes[right] - 2, 0);
                    }
                }
            }
        }

        private static void IncreasingGrapes(List<int> grapes)
        {
            for (int r = 0; r < grapes.Count; r++)
            {
                grapes[r]++;
            }
        }
    }
}