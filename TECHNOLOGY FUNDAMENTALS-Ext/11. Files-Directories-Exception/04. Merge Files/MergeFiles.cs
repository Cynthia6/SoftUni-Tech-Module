using System;
using System.Collections.Generic;
using System.IO;

//Write a program that reads the contents of two text files and merges them together into a third one.
namespace _04.Merge_Files
{
    class MergeFiles
    {
        static void Main()
        {
            string[] firstInput = File.ReadAllText("../../FileOne.txt")
                           .Split(new[] { '\n', '\r', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondInput = File.ReadAllText("../../FileTwo.txt")
                .Split(new[] { '\n', '\r', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < firstInput.Length; i++)
            {
                File.AppendAllText("../../FileResult.txt", firstInput[i] + Environment.NewLine + secondInput[i] + Environment.NewLine);
            }
        }
    }
}