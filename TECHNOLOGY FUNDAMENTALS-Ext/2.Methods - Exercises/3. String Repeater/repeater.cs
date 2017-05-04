using System;
//Write a RepeatString(str, count) method that receives a string and an integer N as parameters and returns the string, repeated N times. 
//After that, print the result on the console.
namespace _3.String_Repeater
{
    public class repeater
    {
        public static void Main()
        {
            string input = 
Console.ReadLine();

            int times = 
int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input,times));
        }
        public static string RepeatString(string a, int b)
        {
            string result = "";
            for (int i = 1; i <= b; i++)
            {
                result = result + a;

            }
            return result;
        }
    }
}
