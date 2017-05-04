using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In music, certain frequencies correspond to certain musical notes (example: A -> 440hz, C# -> 554.37hz). 
//You will be given frequencies as real numbers on the first line of the input(space-separated). 
//Your task is to convert the numbers to their musical note representation, then separate them into naturals(C, B, F and etc.)
// and sharp notes(C#, F#, A#, etc.). After that, print both lists in the console in the format described in the examples. 
//After you print them, sum each list’s frequencies and print it on the console, rounded to the second decimal place.

namespace _5._5_Note_Statistics
{
    public class NoteStatistics
    {
        public static void Main()
        {
            var inputFrequencieses = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var frequenciesNotes = new Dictionary<double, string>();
            frequenciesNotes[261.63] = "C";
            frequenciesNotes[277.18] = "C#";
            frequenciesNotes[293.66] = "D";
            frequenciesNotes[311.13] = "D#";
            frequenciesNotes[329.63] = "E";
            frequenciesNotes[349.23] = "F";
            frequenciesNotes[369.99] = "F#";
            frequenciesNotes[392.00] = "G";
            frequenciesNotes[415.30] = "G#";
            frequenciesNotes[440.00] = "A";
            frequenciesNotes[466.16] = "A#";
            frequenciesNotes[493.88] = "B";

            var notes = GetNotes(inputFrequencieses, frequenciesNotes);
            var natural = GetNaturals(inputFrequencieses, frequenciesNotes);
            var sharps = GetSharps(inputFrequencieses, frequenciesNotes);
            double naturalsSum = GetNaturalSum(natural, frequenciesNotes);
            double sharpsSum = GetSharpsSum(sharps, frequenciesNotes);

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", natural)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine("Naturals sum: {0}", naturalsSum);
            Console.WriteLine("Sharps sum: {0}", sharpsSum);
        }

        static double GetSharpsSum(List<string> sharps, Dictionary<double, string> frequenciesNotes)
        {
            double sharpsSum = 0;
            var reversedDict = frequenciesNotes.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

            foreach (var item in sharps)
            {
                if (reversedDict.ContainsKey(item))
                {
                    sharpsSum += reversedDict[item];
                }
            }

            return sharpsSum;
        }

        static double GetNaturalSum(List<string> natural, Dictionary<double, string> frequenciesNotes)
        {
            double naturalSum = 0;
            var reversedDict = frequenciesNotes.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

            foreach (var item in natural)
            {
                if (reversedDict.ContainsKey(item))
                {
                    naturalSum += reversedDict[item];
                }
            }

            return naturalSum;
        }

        static List<string> GetNaturals(List<double> inputFrequencieses, Dictionary<double, string> frequenciesNotes)
        {
            var notes = GetNotes(inputFrequencieses, frequenciesNotes);
            var naturalNotes = new List<string>();

            foreach (var item in notes)
            {
                if (!item.Contains("#"))
                {
                    naturalNotes.Add(item);
                }
            }

            return naturalNotes;
        }

        private static List<string> GetSharps(List<double> inputFrequencieses, Dictionary<double, string> frequenciesNotes)
        {
            var existingNotes = GetNotes(inputFrequencieses, frequenciesNotes);
            var natural = GetNaturals(inputFrequencieses, frequenciesNotes);
            var sharps = new List<string>();

            foreach (var item in existingNotes)
            {
                if (!natural.Contains(item))
                {
                    sharps.Add(item);
                }
            }

            return sharps;
        }

        static List<string> GetNotes(List<double> inputFrequencieses, Dictionary<double, string> frequenciesNotes)
        {
            var existingNotes = new List<string>();

            foreach (var item in inputFrequencieses)
            {
                if (frequenciesNotes.ContainsKey(item))
                {
                    existingNotes.Add(frequenciesNotes[item]);
                }
            }

            return existingNotes;
        }
    }
}