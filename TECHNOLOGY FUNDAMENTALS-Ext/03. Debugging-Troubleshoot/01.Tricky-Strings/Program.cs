using System;

namespace _01.Tricky_Strings
{
    public class Program
    {
        public static void Main()
        {
            
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                
                var currentString = string.Empty;
                currentString = Console.ReadLine();
                result += currentString;
                if (i != numberOfStrings) result += delimiter;
                
            }
            Console.WriteLine(result);
        }
    }
}
