using System;

namespace _14.ASCII_String
{
    public class ASCII
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {

             int num =   int.Parse(Console.ReadLine());
             result += (char)num;
                
            }
            Console.WriteLine(result);
        }
    }
}
