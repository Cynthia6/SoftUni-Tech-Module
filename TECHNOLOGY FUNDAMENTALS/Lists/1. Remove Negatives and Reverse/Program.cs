using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputArr = inputStr.Split(' ');
            List<int> inputInt = new List<int>();
            List<int> newIntList = new List<int>();
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputInt.Add(int.Parse(inputArr[i]));
            }

            for (int i = 0; i < inputInt.Count; i++)
            {
                if (inputInt[i] > 0)
                {
                    newIntList.Add(inputInt[i]);
                }
            }

            if (newIntList.Any())
            {
                newIntList.Reverse();
                foreach (var item in newIntList)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("empty");
            }



            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            //nums.RemoveAll(x => x < 0);
            //nums.Reverse();

            //if (nums.Any())   Console.Write(string.Join(" ", nums));
            //else Console.WriteLine("empty");




        }
    }
}
