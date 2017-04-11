using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You will be given an array of phone numbers(strings) and an array of names(strings). 
//After which, you will be given strings on new lines, until you receive the command “done”. 
//Find the numbers, which correspond to the names and print them on the console in the following format:
//•	{name} -> {number}
//A number corresponds to a name when it’s located on the same position as its corresponding name in both arrays.

namespace _3._3Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] contactName = Console.ReadLine().Split(' ').ToArray();

            string name = Console.ReadLine();

            while (name != "done")
            {
                for (int i = 0; i < contactName.Length; i++)
                {
                    if (contactName[i] == name)
                    {
                        Console.WriteLine($"{name} -> {phoneNumbers[i]}");
                    }   
                }

                name = Console.ReadLine();
            }
        }
    }
}