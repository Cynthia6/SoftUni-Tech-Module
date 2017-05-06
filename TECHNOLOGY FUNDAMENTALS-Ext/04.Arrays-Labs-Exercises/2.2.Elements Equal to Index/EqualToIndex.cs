using System;
using System.Linq;

//Read an array of integers and extract the elements which have the same value as their index.
namespace _2._2.Elements_Equal_to_Index
{
    public class EqualToIndex
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == i) result += i + " ";
            }
            Console.WriteLine(result);
            //if (elements[i] == i)
            //{
            //    Console.Write( elements[i] + " " );
            //}
            //Console.WriteLine();
                
        }
    }
}
