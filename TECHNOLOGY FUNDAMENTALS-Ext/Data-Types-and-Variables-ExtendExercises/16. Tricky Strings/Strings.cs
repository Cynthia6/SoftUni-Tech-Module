using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    // You are given a delimiter.On the next line, you will receive a number N.On the next N lines, you will receive strings on each line.
    //Your task is to print the strings, separated by the delimiter.
//Note: the delimiter and strings could be anything: whitespace and empty strings are acceptable input!

    class Strings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                if (i != 1) result += delimiter;
                string words = Console.ReadLine();
                result += words;
            }
        //    string removeLastChar = result.Remove(result.Length - delimiter.Length);
            Console.WriteLine(result);
        }
    }
}
