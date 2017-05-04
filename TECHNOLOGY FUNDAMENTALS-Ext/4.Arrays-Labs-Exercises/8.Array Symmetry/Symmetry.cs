using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read an array of strings and find out if it’s symmetric. If it is, print “Yes”, otherwise print “No”.
namespace _8.Array_Symmetry
{
    public class Symmetry
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            bool isSymmetric = true;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != words[words.Length-i-1])
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
