using System;

//You will receive an array of strings as input. Your task is to find the average character within every string in the array. 
//As in, take every character’s ASCII code, sum it and divide the result by the sum of the count of all the letters in the array.
namespace _2.AverageCharacterDelimiter
{
    public class Delimiter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            var charCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var inputAsChar = input[i].ToCharArray();
                foreach (var element in inputAsChar)
                {
                    sum += element;
                    charCounter++;
                }

            }
            char average = Convert.ToChar(sum / charCounter);
            var delimiter = average.ToString().ToUpper();

            Console.WriteLine(string.Join($"{delimiter}", input));
        }
    }
}