using System;

namespace _03.Exchange_Variable_Values
{
    //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. 
    //Print the variable values before and after the exchange, as shown below:
    public class Values
    {
        public static void Main()
        {

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            //  Console.WriteLine($"Before: \na = {a} \nb = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($" \n{a} \n{b}");
        }
    }
}
