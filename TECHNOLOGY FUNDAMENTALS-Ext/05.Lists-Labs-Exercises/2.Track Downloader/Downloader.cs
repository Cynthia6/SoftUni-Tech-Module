using System;
using System.Collections.Generic;
using System.Linq;
//You will receive a list of blacklisted words (on the same line, separated by one space). On the next lines, you will start receiving a list of filenames
//(as strings) until you receive the string “end”. Your task is to add the filenames to a list and sort them. Ignore the tracks which contain the text in the blacklist.
namespace _2.Track_Downloader
{
    public class Downloader
    {
        public static void Main()
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();
            string files = Console.ReadLine();
           // var songsList = new List<string>();
            var downloads = new List<string>();
          
            while (files != "end")
            {
                bool isBlacklisted = false;
                //songsList.Add(song);
                foreach (var keyword in blacklist)
                {
                    if (files.Contains(keyword))
                    {
                       isBlacklisted = true;
                        break;
                    }
                }
                if (isBlacklisted==false)
                {
                    downloads.Add(files);
                }

                files = Console.ReadLine();
            }
            downloads.Sort();
            Console.WriteLine(string.Join("\n", downloads));
        }
        
    }
}
