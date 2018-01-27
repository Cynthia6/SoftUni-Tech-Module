using System;
using System.Linq;
//Read an array of strings and find the last three consecutive equal strings.
namespace _1._1Last_Sequence_Consectuvie
{
    public class LastSequence
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();
            string lastThree = string.Empty;
            int i = 1;
                while(i < words.Length-1)
                {
                    if (words[i] == words[i + 1] && words[i] == words[i-1] ) lastThree = words[i] + ' ' + words[i + 1] + ' ' + words[i -1];
                    i++;
                }
            //for (int i = text.Length - 1; i > 0; i--)
            //{
            //    if (text[i] == text[i - 1] && text[i] == text[i - 2])
            //    {
            //        Console.WriteLine($"{text[i]} {text[i - 1]} {text[i - 2]}");
            //        break;

                    Console.WriteLine(lastThree);

        }
    }
}
