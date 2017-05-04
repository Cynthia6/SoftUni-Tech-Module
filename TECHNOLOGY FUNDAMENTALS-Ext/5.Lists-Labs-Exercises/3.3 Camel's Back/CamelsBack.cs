using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The city is breaking down on a camel back. You will receive a sequence of N integers, (space-separated), which will represent the buildings in the city. 
// You will then receive an integer M, indicating the camel back's size. 
//The camel back is a linear structure standing below the city, in such a way that it has an equal amount of buildings to its left and right.The idea is, 
//if every round – one building falls from the left side of the city, and one from the right side, how many rounds will it take for the city to stop breaking down?
//As output you must print how many rounds it took before the city stopped breaking down as “{ rounds}
//rounds”. On the next line, print what’s left of the city(space-separated). Format: “remaining: {buildings(space-separated)}”
//If no buildings have fallen, print “already stable: {buildings(space-separated)}”

namespace _3._3_Camel_s_Back
{
    public class CamelsBack
    {
        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var m = int.Parse(Console.ReadLine());
            int i = 0;
            int count = 0;
            if (n.Count != m)
            {
                while (n.Count != m)
                {
                    n.RemoveAt(i);
                    n.RemoveAt(n.Count - 1);
                    count++;
                
                }
                Console.WriteLine($"{count} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", n));
            }
            else
            {
                Console.WriteLine("already stable: " + string.Join(" ", n));
               
            }
        }
    }
}
