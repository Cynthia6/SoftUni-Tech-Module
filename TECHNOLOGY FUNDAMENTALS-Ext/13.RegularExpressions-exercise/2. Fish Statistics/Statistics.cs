using System;
using System.Text.RegularExpressions;

namespace _2.Fish_Statistics
{
    public class Statistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"(>+)?<(\(+)('|-|x)>";
            var regex = new Regex(pattern);
            var fishes = regex.Matches(input);

            if (fishes.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                for (int i = 0; i < fishes.Count; i++)
                {
                    Console.WriteLine($"Fish {i + 1}: {fishes[i]}");

                    var tailLength = fishes[i].Groups[1].Length;
                    var tailType = Tail(tailLength);
                    if (tailLength > 0)
                    {
                        Console.WriteLine($"Tail type: {tailType} ({tailLength * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"Tail type: {tailType}");
                    }

                    var bodyLength = fishes[i].Groups[2].Length;
                    var bodyType = Body(bodyLength);
                    Console.WriteLine($"Body type: {bodyType} ({bodyLength * 2} cm)");

                    var eye = fishes[i].Groups[3].Value;
                    var status = Status(eye);
                    Console.WriteLine($"Status: {status}");
                }
            }
        }

        private static string Status(string eye)
        {
            string status = string.Empty;
            if (eye == "'")
            {
                status = "Awake";
            }
            else if (eye == "-")
            {
                status = "Asleep";
            }
            else if (eye == "x")
            {
                status = "Dead";
            }

            return status;
        }

        private static string Body(int bodyLength)
        {
            string bodyType = string.Empty;
            if (bodyLength > 10)
            {
                bodyType = "Long";
            }
            else if (bodyLength <= 10 && bodyLength > 5)
            {
                bodyType = "Medium";
            }
            else if (bodyLength <= 5)
            {
                bodyType = "Short";
            }

            return bodyType;
        }

        private static string Tail(int tailLength)
        {
            string tailType;
            if (tailLength > 5)
            {
                tailType = "Long";
            }
            else if (tailLength <= 5 && tailLength > 1)
            {
                tailType = "Medium";
            }
            else if (tailLength == 1)
            {
                tailType = "Short";
            }
            else
            {
                tailType = "None";
            }

            return tailType;
        }
    }
}