using System;
using System.Collections.Generic;
using System.IO;

//You are given a folder named “TestFolder”. Get the size of all files in the folder, which are NOT directories. 
//The result should be written to another text file in Megabytes.
namespace _05.Get_Folder_Size
{
    public class GetSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("../../TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("../../output.txt", sum.ToString());
        }
    }
}