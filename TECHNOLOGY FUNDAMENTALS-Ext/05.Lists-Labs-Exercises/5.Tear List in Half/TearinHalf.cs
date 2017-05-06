using System;
using System.Collections.Generic;
using System.Linq;
//You will receive a list of integers on the first input line (space-separated). Your task is to separate the list into two parts 
//and perform the following operations:.....
namespace _5.Tear_List_in_Half
{
    public class TearinHalf
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstHalf = input.Take(input.Length / 2).ToArray();
            var secondHalf = input.Skip(input.Length / 2).ToArray();
       //     var length = input.Length + (input.Length / 2);
            var result = new List<int>();


            for (int i = 0; i < firstHalf.Length; i++)
            {
                result.Add(secondHalf[i] / 10);
                result.Add(firstHalf[i]);
                result.Add(secondHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}