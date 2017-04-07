using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Read an array of strings and find out how many of them are capital English letters (such as A, B, C etc.). Print the count on the console.
namespace _7.CountofCapitalLettersinArray
{
    class CapitalsCount
    {
        static void Main()
        {
            var stringArr = Console.ReadLine().Split(' ').ToArray();
            int count = 0;
            char[] character = new char[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                if (stringArr[i].Length == 1) character[i] = char.Parse(stringArr[i]);
                {
                    if (character[i] >= 65 && character[i] <= 90) count++;
                }
                
            }
            Console.WriteLine(count);
        }
    
    }
}
