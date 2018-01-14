using System;

namespace _16.Tricky_Strings
{
    // You are given a delimiter.On the next line, you will receive a number N.On the next N lines, you will receive strings on each line.
    //Your task is to print the strings, separated by the delimiter.
    //Note: the delimiter and strings could be anything: whitespace and empty strings are acceptable input!

    public class Strings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                
                string words = Console.ReadLine();
                result += words;
                if (i != 5) result += delimiter;
            }
        //  string removeLastChar = result.Remove(result.Length - delimiter.Length);
            Console.WriteLine(result);
        }
    }
}
