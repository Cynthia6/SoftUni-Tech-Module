using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Write a program that reads a text file and writes its every odd line in another file. Line numbers starts from 0.
namespace _01.Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            string[] file = File.ReadAllLines("input.txt");
          //  var currentLine = String.Empty;
            var oddLines = new List<string>();
            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                  //  currentLine = file[i];
                    oddLines.Add(file[i]);
                }
            }
            File.WriteAllLines("output.txt", oddLines);

            Console.WriteLine(String.Join(System.Environment.NewLine, oddLines));
        }
    }
}