using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will receive a list of integers on the same line (separated by one space). On the next lines, you will start receiving a list of strings, 
//until you receive the string “end”. Your task is to insert each string (converted to integer) at a specific index in the list. 
//The index is determined by the first digit of the number.
//Example: 514  first digit – 5  insert 514 at the 5th index of the list.
//After you insert all the elements, print the list, separated by single spaces.

namespace _2._2Integer_Insertion
{
    public class INTInsertion
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var currentNum = int.Parse(input);
                var firstDigit = input[0].ToString();
                var index = int.Parse(firstDigit);

                list.Insert(index, currentNum);
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        
        }
    }
}
