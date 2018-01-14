using System;
//Create a program that reads a number N.On the next N lines, it reads integers from the ASCII table.
//The task is to concatenate everything in string format.


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
