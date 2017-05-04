using System;
using System.IO;
using System.Collections.Generic;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. 
namespace _02.Line_Numbers
{
    class LineNums
    {
        static void Main()
        {
            string[] file = File.ReadAllLines("input.txt");
            var oddLines = new List<string>();
            for (int i = 0; i < file.Length; i++)
            {
                oddLines.Add($"{i+1}. {file[i]}");
                               
            }
            File.WriteAllLines("output.txt", oddLines);

            Console.WriteLine(String.Join(System.Environment.NewLine, oddLines));
        }
    }
}
